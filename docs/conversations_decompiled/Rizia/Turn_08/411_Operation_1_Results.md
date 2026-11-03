# Rizia/Turn 8/Operation 1 Results

- **ID konwersacji:** `411`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/411_Operation_1_Results.md`
- **Liczba węzłów dialogowych:** 310
- **Liczba wyborów gracza:** 32

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[83]** Taddeus Azaro
- **[88]** Carlos Robles Azaro
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Army_Unit_Azaro_Dead`
- `RiziaDLC.Army_Unit_GrandTotal_Total`
- `RiziaDLC.Army_Unit_Sazon_Dead`
- `RiziaDLC.Army_Unit_Toras_Dead`
- `RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Resources_Military_Equipment`
- `RiziaDLC.Resources_Military_Manpower`
- `RiziaDLC.Taddeus_Disgraced`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.War_Objective_Captured_Arces`
- `RiziaDLC.War_Objective_Captured_FortAles`
- `RiziaDLC.War_Objective_Captured_Terador`
- `RiziaDLC.War_Objective_Captured_Ziqes`
- `RiziaDLC.War_Operation1Briefing_Frontline`
- `RiziaDLC.War_Operation1_TotalEnemy_Dead`
- `RiziaDLC.War_Operation1_TotalPlayer_Dead`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLC.War_Pales_PublicWarSupport`
- `RiziaDLC.War_Pales_Resistance`
- `RiziaDLCIsolated.Taddeus_MedalsRipped`
- `RiziaDLCIsolated.Turn08_OperationResult_HouseUnits`
- `RiziaDLCIsolated.Turn08_OperationResult_Numbers`
- `RiziaDLCIsolated.Turn08_OperationResult_Objectives`
- `RiziaDLCIsolated.Turn08_OperationResult_Resistance`
- `RiziaDLCIsolated.Turn08_OperationResult_WarSupport`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Taddeus_Disgraced`
- `RiziaDLCIsolated.Taddeus_MedalsRipped`
- `RiziaDLCIsolated.Turn08_OperationResult_HouseUnits`
- `RiziaDLCIsolated.Turn08_OperationResult_Numbers`
- `RiziaDLCIsolated.Turn08_OperationResult_Objectives`
- `RiziaDLCIsolated.Turn08_OperationResult_Resistance`
- `RiziaDLCIsolated.Turn08_OperationResult_WarSupport`
- `RiziaDLCSupport.Journal_Turn08_PostOperation1_DisgracedTaddeus`
- `RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationLost`
- `RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationWon`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[412] Rizia/Turn 8/Operation 2 Next Steps** (../Turn_08/412_Operation_2_Next_Steps.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
- **Węzły modyfikujące stan gry:** 12

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLCIsolated.Turn08_OperationResult_WarSupport`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[49]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] = true;`
- Węzeł `[50]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] = true;`
- Węzeł `[51]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] = true;`
- Węzeł `[52]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] = true;`
- Węzeł `[234]` (Paskal Beniwoll): `Variable["RiziaDLC.Taddeus_Disgraced"] = true;`
- Węzeł `[246]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationWon"] = true;`
- Węzeł `[247]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationLost"] = true;`
- Węzeł `[248]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn08_PostOperation1_DisgracedTaddeus"] = true;`
- *...oraz 4 innych węzłów ze skryptami.*

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `412` (*Rizia/Turn 8/Operation 2 Next Steps*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Taddeus Azaro**
> ""To put it simply...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Operation1_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Taddeus Azaro**
> ""We are winning this war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[8]`
Mówca: **Taddeus Azaro**
> ""The operation is not going well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_GrandTotal_Total >= 20)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_GrandTotal_Total >= 20)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_GrandTotal_Total"] >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_GrandTotal_Total >= 20))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_GrandTotal_Total"] >= 20) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Taddeus Azaro**
> ""We currently have more than 20 operational groups in total, including our naval forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_GrandTotal_Total >= 15)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_GrandTotal_Total >= 15)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_GrandTotal_Total"] >= 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_GrandTotal_Total >= 15))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_GrandTotal_Total"] >= 15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_GrandTotal_Total >= 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_GrandTotal_Total >= 10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_GrandTotal_Total"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_GrandTotal_Total >= 10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_GrandTotal_Total"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Taddeus Azaro**
> ""We currently have more than 15 operational groups in total, including our navy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Taddeus Azaro**
> ""We currently have less than 15 operational groups in total, including our navy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Taddeus Azaro**
> ""We currently have less than 10 operational groups in total, including our navy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1_TotalPlayer_Dead >= 20)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1_TotalPlayer_Dead >= 20)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Operation1_TotalPlayer_Dead"] >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Operation1_TotalPlayer_Dead >= 20))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1_TotalPlayer_Dead"] >= 20) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1_TotalPlayer_Dead >= 15)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1_TotalPlayer_Dead >= 15)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Operation1_TotalPlayer_Dead"] >= 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Operation1_TotalPlayer_Dead >= 15))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1_TotalPlayer_Dead"] >= 15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1_TotalPlayer_Dead >= 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1_TotalPlayer_Dead >= 10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Operation1_TotalPlayer_Dead"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Operation1_TotalPlayer_Dead >= 10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1_TotalPlayer_Dead"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
Mówca: **Taddeus Azaro**
> ""This operation has cost us many lives. Around 20 divisions have perished on the battlefield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[32]`
Mówca: **Taddeus Azaro**
> ""This operation has cost us more lives than expected. Around 15 divisions have perished on the battlefield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[33]`
Mówca: **Taddeus Azaro**
> ""Meanwhile, around 10 divisions have perished on the battlefield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[34]`
Mówca: **Taddeus Azaro**
> ""Thankfully, we had minimal casualties on the battlefield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Operation 1 Results Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[304]`
  - -> `[39]`
  - -> `[43]`
  - -> `[46]`
  - -> `[53]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Numbers == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Numbers == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_Numbers == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Objectives == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Objectives == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_Objectives == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
Mówca: **Narrator**
> "He handed me a stack of papers detailing the operation results."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Resistance == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Resistance == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_Resistance == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_WarSupport == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_WarSupport == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_WarSupport == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Numbers = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Objectives = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Resistance = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_WarSupport = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Numbers == true || RiziaDLCIsolated.Turn08_OperationResult_Objectives == true ||RiziaDLCIsolated.Turn08_OperationResult_Resistance == true ||RiziaDLCIsolated.Turn08_OperationResult_WarSupport == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Numbers == true || RiziaDLCIsolated.Turn08_OperationResult_Objectives == true ||RiziaDLCIsolated.Turn08_OperationResult_Resistance == true ||RiziaDLCIsolated.Turn08_OperationResult_WarSupport == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[98]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_Numbers == true || RiziaDLCIsolated.Turn08_OperationResult_Objectives == true ||RiziaDLCIsolated.Turn08_OperationResult_Resistance == true ||RiziaDLCIsolated.Turn08_OperationResult_WarSupport == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Objectives"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Resistance"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_WarSupport"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have heard enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me about our numbers. How many troops do we have? How many have we lost?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What have we captured so far?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are we seeing a lot of resistance from the civilian population?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me about public opinion back home. What do Rizians think about the war?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[61]`
Mówca: **Lucita Azaro**
> ""Our intelligence reports indicate that the enemy has taken mass casualties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1_TotalEnemy_Dead >= 20)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1_TotalEnemy_Dead >= 20)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] >= 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Operation1_TotalEnemy_Dead >= 20))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] >= 20) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1_TotalEnemy_Dead >= 15)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1_TotalEnemy_Dead >= 15)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] >= 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Operation1_TotalEnemy_Dead >= 15))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] >= 15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1_TotalEnemy_Dead >= 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1_TotalEnemy_Dead >= 10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Operation1_TotalEnemy_Dead >= 10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1_TotalEnemy_Dead"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
Mówca: **Lucita Azaro**
> ""Our intelligence reports indicate that the enemy has taken many casualties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[72]`
Mówca: **Lucita Azaro**
> ""Our intelligence reports indicate that the enemy has taken quite a few casualties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[73]`
Mówca: **Lucita Azaro**
> ""The latest numbers state that we have successfully destroyed more than 20 divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[74]`
Mówca: **Lucita Azaro**
> ""Our intelligence reports indicate that the enemy has not taken many casualties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
Mówca: **Lucita Azaro**
> ""The latest numbers state that we have successfully destroyed more than 15 divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[76]`
Mówca: **Lucita Azaro**
> ""The latest numbers state that we have successfully destroyed more than 10 divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
Mówca: **Lucita Azaro**
> ""The latest numbers state that we have successfully destroyed less than 10 divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Lucita Azaro**
> ""Unfortunately, the Palesians are tougher than we expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[79]`
Mówca: **Lucita Azaro**
> ""They are tough, but so are we.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
Mówca: **Lucita Azaro**
> ""Honestly, even I didn't think it would be this easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Lucita Azaro**
> ""They're dropping like flies, Your Majesty. Left and right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Operation 1 Results Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Arces == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Arces == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Arces"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_Arces == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Arces"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Ziqes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Ziqes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_Ziqes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[89]`
Mówca: **Carlos Robles Azaro**
> ""We have taken Arces and Ziqes. New forward operating bases have been set up nearby.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC.War_Objective_Captured_Ziqes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC.War_Objective_Captured_Ziqes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Arces"] == true  and  Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC.War_Objective_Captured_Ziqes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Arces"] == true  and  Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[93]`
Mówca: **Carlos Robles Azaro**
> ""We have taken Arces. New forward operating bases have been set up nearby.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Operation1_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""ENOUGH, DAMN YOU!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see. Go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[99]`
Mówca: **Carlos Robles Azaro**
> ""We have taken Ziqes. New forward operating bases have been set up nearby.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Carlos Robles Azaro**
> ""Regretfully, we have yet to capture any of our main operation objectives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Terador == false && RiziaDLC.War_Objective_Captured_FortAles == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Terador == false && RiziaDLC.War_Objective_Captured_FortAles == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Terador"] == false  and  Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_Terador == false && RiziaDLC.War_Objective_Captured_FortAles == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Terador"] == false  and  Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_FortAles == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_FortAles == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_FortAles == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Terador == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Terador == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Terador"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_Terador == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Terador"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[110]`
Mówca: **Taddeus Azaro**
> ""With great sadness, I must also inform you that we have lost control of Terador and Fort Ales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[111]`
Mówca: **Taddeus Azaro**
> ""With great sadness, I must also inform you that we have lost control of Fort Ales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[112]`
Mówca: **Taddeus Azaro**
> ""With great sadness, I must also inform you that we have lost control of Terador.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Taddeus Azaro**
> ""Despite the heavy fighting, Fort Ales and Terador are still under our control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Carlos Robles Azaro**
> ""A minor setback. I'm confident we'll regain the ground we lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Carlos Robles Azaro**
> ""Our cities persevere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Operation 1 Results Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Resistance >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Resistance >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Resistance"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Resistance >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Resistance"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Resistance >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Resistance >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Resistance"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Resistance >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Resistance"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[123]`
Mówca: **Taddeus Azaro**
> ""A sizeable resistance is growing, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[124]`
Mówca: **Taddeus Azaro**
> ""Yes, sire. But all within our expectations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[125]`
Mówca: **Taddeus Azaro**
> ""There doesn't seem to be much of it. It's as I suspected -- Pales *wants* to rejoin Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Carlos Robles Azaro**
> ""Or we've simply intimidated civilians into submission. Either way, this works in our favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[127]`
Mówca: **Carlos Robles Azaro**
> ""We're doing everything we can to keep it contained.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Carlos Robles Azaro**
> ""Nothing that we can't handle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Operation 1 Results Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_PublicWarSupport > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_PublicWarSupport > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_PublicWarSupport"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_PublicWarSupport > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_PublicWarSupport"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Lucita Azaro**
> ""The people are on our side, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[134]`
Mówca: **Lucita Azaro**
> ""General sentiment seems to be against the war, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Lucita Azaro**
> ""But once we have a big win, I think the tide will change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[136]`
Mówca: **Lucita Azaro**
> ""And the more we keep winning, the more their sympathies will increase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Taddeus Azaro**
> ""Their strength keeps us strong. We will not lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Operation 1 Results Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[139]`
Mówca: **Narrator**
> "The room fell silent. Lucita spoke after a few long seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Carlos Robles Azaro**
> ""If you please, Your Majesty, we need more manpower and equipment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Operation1_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Carlos Robles Azaro**
> ""This might be the only way we can regain our footing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Carlos Robles Azaro**
> ""We've achieved promising results, but we are not done yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower < 1000)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower < 1000)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Manpower"] < 1000`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_Manpower < 1000))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Manpower"] < 1000) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Taddeus Azaro**
> ""Precisely. Our manpower is dwindling. New recruits would provide valuable support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Taddeus Azaro**
> ""Precisely. Additional recruits would provide valuable support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Equipment < 1000)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Equipment < 1000)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Equipment"] < 1000`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_Equipment < 1000))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Equipment"] < 1000) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Taddeus Azaro**
> "And of course, these troops will require more ammunition and weapons. Our operation has nearly depleted our supply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Taddeus Azaro**
> ""And of course, these troops will require ammo and weapons. We still have a decent stockpile, but more won't hurt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Taddeus Azaro**
> ""Your Majesty, one thing is certain. We can't win this war without able and capable boots on the ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[157]`
  - -> `[159]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will do whatever I can to support the army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hear you two. You do your part and I will do mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We also can't win this war without able and capable generals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[160]`
Mówca: **Carlos Robles Azaro**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[161]`
Mówca: **Lucita Azaro**
> ""The result of Golden Shield is clear, Your Majesty. We are on the right path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[162]`
Mówca: **Narrator**
> "There was no response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Operation1_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[166]`
Mówca: **Lucita Azaro**
> ""As these documents outline, the operation has been a great success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Lucita Azaro**
> ""Before we discuss the next steps, we need your seal on the results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Narrator**
> "General Azaro handed me a large scroll and a candle for the wax. I opened it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
**[WYBÓR GRACZA: "Press the seal on the wax."]** — Mówca: **Player_Romus_Italic**
> "I pressed my seal on the wax to approve."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Taddeus Azaro**
> ""Thank you, sire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[174]`
  - -> `[171]`
  - -> `[173]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have done well. I am proud of all of you. Not only for your exemplary service, but on a personal level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank *you* for your service to the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bring me victory, and only victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will not allow any failures. Do you understand?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Taddeus Azaro**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[176]`
Mówca: **Taddeus Azaro**
> ""I serve and obey.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Taddeus Azaro**
> ""That is very touching, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[178]`
Mówca: **Carlos Robles Azaro**
> ""As do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[179]`
Mówca: **Carlos Robles Azaro**
> ""Loud and clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[180]`
Mówca: **Lucita Azaro**
> ""Indeed. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[181]`
Mówca: **Lucita Azaro**
> ""The result of Golden Shield is unfortunately clear, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Lucita Azaro**
> ""The operation was not a success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[183]`
Mówca: **Taddeus Azaro**
> ""Lucita, help me down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Lucita Azaro**
> ""Father -- General, what are you-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[185]`
Mówca: **Narrator**
> "The old general descended from his wheelchair and knelt before me, pressing his forehead into the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Taddeus Azaro**
> ""My liege. My King. My lord. I have failed you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Taddeus Azaro**
> ""Do what you will with me. I leave my life at your mercy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`
  - -> `[192]`
  - -> `[191]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get up, General. A man of your stature should not humiliate himself like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you think this will convince me to spare you, you are wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Taddeus Azaro**
> ""This war should have been ours to win. I deserve punishment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My mercy? What kind of king do you think I am?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fix your mess, General. That is all I care about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[193]`
Mówca: **Narrator**
> "He wouldn't budge. Lucita rolled her eyes in frustration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Lucita Azaro**
> ""Father. Stop your hysterics and allow me to help you back into your chair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Taddeus Azaro**
> ""Silence, Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Taddeus Azaro**
> ""Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[198]`
  - -> `[237]`
  - -> `[199]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "Slap him."]** — Mówca: **Player_Romus_Italic**
> "I slapped him in fury. I heard gasps from everyone in the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will receive no punishment. You will continue working for the Crown. That is all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[199]`
**[WYBÓR GRACZA: "Rip his medals off."]** — Mówca: **Player_Romus_Italic**
> "I walked up to him and ripped the medals off his uniform. I heard gasps from everyone in the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[200]`
Mówca: **Taddeus Azaro**
> ""You are too kind to me, Your Majesty. But I shall accept and respect your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Taddeus Azaro**
> ""I accept and respect your punishment, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[202]`
Mówca: **Taddeus Azaro**
> ""I will redeem myself to you. This I promise in the name of House Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[241]`
  - -> `[205]`
  - -> `[206]`

### Węzeł `[203]`
Mówca: **Taddeus Azaro**
> ""So this is my punishment. I have disgraced myself, my family and my kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know that you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am bored of this charade. I don't have all day. Keep going with your briefing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not be so harsh on yourself, General. It's bad for morale.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Taddeus Azaro**
> ""We understand, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[208]`
Mówca: **Taddeus Azaro**
> ""Yes, my liege.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Lucita Azaro**
> ""Now. It's time for us to talk about our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[210]`
Mówca: **Narrator**
> "Lucita helped him back into his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[211]`
Mówca: **Lucita Azaro**
> ""Rom-- Your Majesty! What have you just done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[212]`
Mówca: **Narrator**
> "Lucita turned to me angrily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Lucita Azaro**
> ""Your Majesty! What have you just done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Lucita Azaro**
> ""Berate me for my failures if you wish. But to disgrace the highest-ranking member of House Azaro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can and you will. Do not question my authority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[219]`
Mówca: **Lucita Azaro**
> ""I cannot just sit idly by and take this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[222]`
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then make General Taddeus earn his rank. All I see is failure upon failure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You dare defy me? Your King?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry. You are right. I made a rash decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[223]`
Mówca: **Taddeus Azaro**
> ""Please, sire. She did not mean it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Taddeus Azaro**
> ""Lucita. Apologize to your King this second.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[225]`
Mówca: **Lucita Azaro**
> ""That problem is mine to handle. I don't need your intervention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Lucita Azaro**
> ""God. How could you do this to an old man? In a wheelchair?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[227]`
Mówca: **Lucita Azaro**
> ""You insulted my father. How am I supposed to react?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[228]`
Mówca: **Lucita Azaro**
> ""I am sorry, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[229]`
Mówca: **Narrator**
> "She collected herself and spoke through gritted teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[233]`
Mówca: **Lucita Azaro**
> ""I will do what I must to make sure we win this war. Leave my father out of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Disgraced = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Taddeus_Disgraced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[235]`
Mówca: **Narrator**
> "A long, complete silence followed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen to your daughter, General.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[240]`
Mówca: **Taddeus Azaro**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't forget that both of you are responsible for this failure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[242]`
Mówca: **Lucita Azaro**
> ""Can we please just move on, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Disgraced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Disgraced == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Disgraced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Disgraced == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Disgraced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationWon = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationWon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationLost = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_PostOperation1_OperationLost"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn08_PostOperation1_DisgracedTaddeus = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_PostOperation1_DisgracedTaddeus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[249]`
Mówca: **Narrator**
> "She smiled proudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[250]`
Mówca: **Narrator**
> "Lucita drew a breath in through her teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[254]`
Mówca: **Narrator**
> "Lucita's eyes shone brightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
Mówca: **Lucita Azaro**
> ""Yes. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[256]`
Mówca: **Narrator**
> "She clutched her forehead and took a deep breath, forcing herself to calm down. Taddeus kept his eyes on the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[257]`
Mówca: **Lucita Azaro**
> ""Our troops can still win this, Your Majesty. Just give us a chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1Briefing_Frontline == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1Briefing_Frontline == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Operation1Briefing_Frontline"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Operation1Briefing_Frontline == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1Briefing_Frontline"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Narrator**
> "The old general descended from his wheelchair and knelt before me, pressing his forehead to the floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[262]`
Mówca: **Carlos Robles Azaro**
> ""Your words mean a great deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[263]`
Mówca: **Narrator**
> "Before I could say anything, Taddeus turned to Carlos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Taddeus Azaro**
> ""Would you excuse us for a moment, General?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[265]`
Mówca: **Carlos Robles Azaro**
> ""If that is your wish, then certainly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Narrator**
> "He bowed to me and then to Taddeus before stepping out of the tent, confused. Taddeus tapped on his daughter's arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Carlos Robles Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Carlos Robles Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Carlos Robles Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Carlos Robles Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Narrator**
> "Carlos was brought back into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Narrator**
> "His expression was one of surprise as he glanced between Taddeus and Lucita, as if trying to decipher what had just taken place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Taddeus_MedalsRipped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Taddeus_MedalsRipped == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Taddeus_MedalsRipped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Taddeus_MedalsRipped == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Taddeus_MedalsRipped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Taddeus_MedalsRipped = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Taddeus_MedalsRipped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[275]`
Mówca: **Narrator**
> "His eyes quickly took in the sight of Taddeus, noting that his medals had been stripped from his jacket -- a clear sign that something had just transpired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[276]`
Mówca: **Taddeus Azaro**
> ""House Sazon’s troops are still in perfect shape and ready to continue the fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Sazon_Dead == 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Sazon_Dead == 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Sazon_Dead"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Sazon_Dead == 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Sazon_Dead"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Taddeus Azaro**
> ""House Sazon held their ground and made steady gains, though enemy resistance made progress difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Sazon_Dead == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Sazon_Dead == 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Sazon_Dead"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Sazon_Dead == 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Sazon_Dead"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Taddeus Azaro**
> ""House Sazon’s forces were completely overrun -- the survivors are either captured or dead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Taddeus Azaro**
> ""House Toras didn't suffer any losses, showcasing their efficiency and skill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Toras_Dead == 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Toras_Dead == 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Toras_Dead"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Toras_Dead == 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Toras_Dead"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Taddeus Azaro**
> ""House Toras held the line with fierce determination, though advancing proved difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Toras_Dead == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Toras_Dead == 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Toras_Dead"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Toras_Dead == 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Toras_Dead"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Taddeus Azaro**
> ""House Toras was annihilated. There are no reports of survivors from their last position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Taddeus Azaro**
> ""House Azaro’s forces showed remarkable coordination, emerging unscathed so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Azaro_Dead == 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Azaro_Dead == 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Azaro_Dead"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Azaro_Dead == 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Azaro_Dead"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Taddeus Azaro**
> ""House Azaro inflicted significant damage, but the enemy still holds strategic ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Azaro_Dead == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Azaro_Dead == 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Azaro_Dead"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Azaro_Dead == 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Azaro_Dead"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Taddeus Azaro**
> ""House Azaro’s warriors are no more, but they perished as true sons of Rizia -- undaunted, outnumbered, and defiant to their last breath.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What of our provincial forces?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_HouseUnits == false && (RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies == false && RiziaDLCIsolated.Turn08_OperationResult_Numbers == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_HouseUnits == false && (RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies == false && RiziaDLCIsolated.Turn08_OperationResult_Numbers == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_HouseUnits"] == false  and  (Variable["RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies"] == false  and  Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_HouseUnits == false && (RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies == false && RiziaDLCIsolated.Turn08_OperationResult_Numbers == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_HouseUnits"] == false  and  (Variable["RiziaDLC.Enable_Policy_RD_Order_RemoveProvincialLevies"] == false  and  Variable["RiziaDLCIsolated.Turn08_OperationResult_Numbers"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_HouseUnits = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_HouseUnits"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Operation 1 Results Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[309]`
Mówca: **Narrator**
> "Carlos gave him a questionable look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
