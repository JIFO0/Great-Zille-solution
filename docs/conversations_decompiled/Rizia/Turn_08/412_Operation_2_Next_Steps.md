# Rizia/Turn 8/Operation 2 Next Steps

- **ID konwersacji:** `412`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/412_Operation_2_Next_Steps.md`
- **Liczba węzłów dialogowych:** 278
- **Liczba wyborów gracza:** 30

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[83]** Taddeus Azaro
- **[88]** Carlos Robles Azaro
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Situation_Order_ForeignIntelligence_Adequate`
- `RiziaDLC.Situation_Order_ForeignIntelligence_Effective`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.War_Control_Skipped`
- `RiziaDLC.War_Objective_Captured_Arces`
- `RiziaDLC.War_Objective_Captured_FortAles`
- `RiziaDLC.War_Objective_Captured_Terador`
- `RiziaDLC.War_Objective_Captured_Ziqes`
- `RiziaDLC.War_Pales_LespianSupport`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLC.Zille_Discovered_LespianInvolvement`
- `RiziaDLC.Zille_Publicized_LespianInvolvement`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded`
- `RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Resources_Military_EnemyAirStrikeCount`
- `RiziaDLC.War_Operation2Loss_Charge`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong`
- `RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust`
- `RiziaDLCSupport.Journal_Turn08_PostOperation1_Charge`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[410] Rizia/Turn 8/SnO_War_Pales_PostOperation1** (../Turn_08/410_SnO_War_Pales_PostOperation1.md), Węzeł `[174]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 18
- **Węzły modyfikujące stan gry:** 11

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.War_Operation2Loss_Charge`
- `RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[61]` (Paskal Beniwoll): `Variable["RiziaDLC.War_Operation2Loss_Charge"] = true;`
- Węzeł `[159]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] = true;`
- Węzeł `[160]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] = true;`
- Węzeł `[161]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] = true;`
- Węzeł `[162]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] = true;`
- Węzeł `[190]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] = true;`
- Węzeł `[191]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] = true;`
- Węzeł `[192]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] = true;`
- *...oraz 3 innych węzłów ze skryptami.*

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
  - -> `[21]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `410` (*Rizia/Turn 8/SnO_War_Pales_PostOperation1*), Węzeł `[174]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Operation1_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Operation1_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[6]`
Mówca: **Carlos Robles Azaro**
> ""We are in a good position to encircle the peninsula.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[7]`
Mówca: **Taddeus Azaro**
> ""The troops are eagerly awaiting orders to begin the second operation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[8]`
Mówca: **Carlos Robles Azaro**
> ""After the enemy took control of Terador and Fort Ales, we managed to push them back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Terador == false && RiziaDLC.War_Objective_Captured_FortAles == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Terador == false && RiziaDLC.War_Objective_Captured_FortAles == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Terador"] == false  and  Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_Terador == false && RiziaDLC.War_Objective_Captured_FortAles == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Terador"] == false  and  Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Terador == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Terador == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Terador"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_Terador == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Terador"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_FortAles == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_FortAles == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_FortAles == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_FortAles"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
Mówca: **Carlos Robles Azaro**
> ""After the enemy took control of Terador, we managed to push them back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
Mówca: **Carlos Robles Azaro**
> ""After the enemy took control of Fort Ales, we managed to push them back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Carlos Robles Azaro**
> ""Despite the enemy's best efforts, we managed to push them back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Lucita Azaro**
> ""We have more details about the situation on the front lines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[22]`
Mówca: **Carlos Robles Azaro**
> ""We are back where we started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[23]`
Mówca: **Carlos Robles Azaro**
> ""Our troops are pushing with everything they've got. But the enemy is refusing to yield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Taddeus Azaro**
> ""They tried to spearhead into our territories after we set up our defensive positions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC.War_Objective_Captured_Ziqes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC.War_Objective_Captured_Ziqes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Arces"] == true  and  Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_Arces == true && RiziaDLC.War_Objective_Captured_Ziqes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Arces"] == true  and  Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Arces == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Arces == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Arces"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_Arces == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Arces"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Ziqes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Objective_Captured_Ziqes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Objective_Captured_Ziqes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Ziqes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Carlos Robles Azaro**
> ""After the capture of both Arces and Ziqes, we pushed further past Arces, close to Mandana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[35]`
Mówca: **Carlos Robles Azaro**
> ""After the capture of Arces, we pushed further past the city, close to Mandana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[36]`
Mówca: **Carlos Robles Azaro**
> ""After the capture of Ziqes, we pushed further past Arces, close to Mandana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[37]`
Mówca: **Carlos Robles Azaro**
> ""Although we failed to capture either Arces or Ziqes, we managed to push further past Arces, close to Mandana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[38]`
Mówca: **Taddeus Azaro**
> ""A complete victory is in sight, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[42]`
  - -> `[45]`
  - -> `[250]`

### Węzeł `[39]`
Mówca: **Taddeus Azaro**
> ""Our enemies shall tremble before our might.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Simply holding the line is unacceptable. We will push with whatever we have. Even if that means more casualties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then be the wall that protects the mainland. Do not let them pass under any condition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew that our cause was just. We will take back what is rightfully ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not let this success get to your head, General. It is not over yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will come at Pales until there is nothing left of it but ash and smoke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will deliver them their loss with honor and dignity as befits our position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Taddeus Azaro**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[50]`
Mówca: **Carlos Robles Azaro**
> ""Unfortunately, we won't be able to gain any new territory at this point. Our hands are tied, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[51]`
Mówca: **Lucita Azaro**
> ""Your Majesty... if we push harder and fail, we'll find ourselves in an even more precarious situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Taddeus Azaro**
> ""In the worst-case scenario, the frontline might fall. Please listen to my daughter, Your Majesty. We can't overextend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Cowards, all of you! Attack or I will have you lashed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may have a point. Very well. We will wait and see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[55]`
Mówca: **Carlos Robles Azaro**
> ""Agreed. We should wait for more favorable conditions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[59]`
  - -> `[54]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Respectfully, General, I disagree. I order you to attack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[60]`
Mówca: **Taddeus Azaro**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation2Loss_Charge = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.War_Operation2Loss_Charge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[62]`
Mówca: **Lucita Azaro**
> ""We won't win this war without information. Which brings me to the following.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[63]`
Mówca: **Lucita Azaro**
> ""We need to talk about enemy positions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Lucita Azaro**
> ""The information from the frontline combined with tips from our spies in Rizian Foreign Intelligence indicate heavy preparation by Palesian troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Lucita Azaro**
> ""Their ground forces have been replenished and stand ready for our attack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[69]`
Mówca: **Lucita Azaro**
> ""Their ground forces have been replenished and stand ready for our attack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[79]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seem to have pulled back north to blockade the seas neighboring Fort Ales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seem to have pulled back to blockade the seas neighboring the Palesian capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seem to have pulled back south to blockade the seas neighboring Remaz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seem to have chosen to disperse their battleships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Lucita Azaro**
> ""I would advise us all to watch out for the enemy's ships. There's no telling what they're planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[84]`
Mówca: **Lucita Azaro**
> ""It'll be harder to get the upper hand on them this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[85]`
Mówca: **Lucita Azaro**
> ""But we still have the upper hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Control_Skipped == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Control_Skipped == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Control_Skipped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Control_Skipped == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Control_Skipped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true || RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true || RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true || RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true  or  Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Lucita Azaro**
> ""Their ground forces seem to be weak at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Lucita Azaro**
> ""Nonetheless, I advise caution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Lucita Azaro**
> ""As for their navy... our intelligence units are having a hard time divulging their whereabouts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_AlesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_AlesBlockaded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_PalesBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_PalesBlockaded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded == true || RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Default_RemazBlockaded"] == true  or  Variable["RiziaDLCSetup.War_Operation2_DeploymentOverride_Pales_Naval_Strong_RemazBlockaded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seemed to have pulled back north to blockade the seas neighboring Fort Ales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[111]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seemed to have pulled back to the capital to blockade the seas neighboring Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[112]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seemed to have pulled back south to blockade the seas neighboring Remaz.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[113]`
Mówca: **Lucita Azaro**
> ""As for their navy, they seemed to have chosen to disperse their battleships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[114]`
Mówca: **Lucita Azaro**
> ""Lespia is another matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_LespianSupport >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_LespianSupport >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_LespianSupport"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_LespianSupport >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_LespianSupport"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_LespianSupport > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_LespianSupport > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_LespianSupport"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_LespianSupport > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_LespianSupport"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Lucita Azaro**
> ""Thankfully, Pales doesn't seem to be receiving any support from Lespia at this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[122]`
Mówca: **Lucita Azaro**
> ""From the reports I've received, we can assume the worst-case scenario.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Lucita Azaro**
> ""From the reports I received, we need to prepare for their involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Lucita Azaro**
> ""Lespia is sending significant aid to Pales in the form of manpower and equipment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Lucita Azaro**
> ""Lespia has decided to provide at least some manpower and equipment assistance to Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Lucita Azaro**
> ""Including their newest bombs and bomber jets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[127]`
Mówca: **Taddeus Azaro**
> ""Those goddamn meddlers again... Someday it will be their turn as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[128]`
Mówca: **Taddeus Azaro**
> ""Ha. Those meddlers are too scared of Rizia's might to attempt anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[129]`
Mówca: **Lucita Azaro**
> ""There is still much to discuss about our plans. But this overview should suffice for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Taddeus Azaro**
> ""Do you have any questions, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Operation 2 Win Questions)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[181]`
  - -> `[184]`
  - -> `[187]`
  - -> `[194]`

### Węzeł `[132]`
Mówca: **Lucita Azaro**
> ""Their navy is currently blockading our ports in the southern seas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Lucita Azaro**
> ""However, our coastal artillery is effectively keeping their landing crafts at bay. With the defenses we have in place, we do not anticipate a naval invasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[134]`
Mówca: **Lucita Azaro**
> ""Lespia may be the deciding factor here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Lucita Azaro**
> ""They do not seem to have sent any substantial support to Pales yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Carlos Robles Azaro**
> ""Yes, but if the tides change, they very well might.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Lucita Azaro**
> ""Let's hope the wind is at our back. That concludes today's overview.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[138]`
Mówca: **Taddeus Azaro**
> ""Do you have any questions for us, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Operation 2 Lose Questions)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[147]`
  - -> `[150]`
  - -> `[153]`
  - -> `[156]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was this all a mistake?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can we win this war?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How much longer will we have to keep fighting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How can we prevent Lespia from helping Pales?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength == true || RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_CanWeWin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_Mistake"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_WarLength"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Lose_PreventLespia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those were all my questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Operation 2 Lose Questions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[166]`
Mówca: **Lucita Azaro**
> ""If we can get rid of this gridlock, we can, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Taddeus Azaro**
> ""We will, Your Majesty. We must.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[168]`
Mówca: **Taddeus Azaro**
> ""My King...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Narrator**
> "His voice trailed off. Lucita and Carlos stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[170]`
Mówca: **Taddeus Azaro**
> ""It's difficult to say. It certainly isn't going to be as easy as we thought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Carlos Robles Azaro**
> ""But we *will* win, Your Majesty. In due time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[172]`
Mówca: **Lucita Azaro**
> ""We can only hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can we trust the intelligence you have received?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How long until total victory?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there a way to disable Pales' navy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do we get past the capital's defenses?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[177]`
Mówca: **Lucita Azaro**
> ""Pales itself is a very well-defended city. It will be tough to bring down its walls. Literally and figuratively.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == true || RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust == true ||RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy == true ||  RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == true || RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust == true ||RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy == true ||  RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] == true  or   Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong == true || RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust == true ||RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy == true ||  RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_HowLong"] == true  or  Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_IntelligenceTrust"] == true  or Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_DisableNavy"] == true  or   Variable["RiziaDLCIsolated.Turn08_OperationResult_Win_CapitolDefences"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those were all my questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[199]`
Mówca: **Taddeus Azaro**
> ""Not long at all, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Carlos Robles Azaro**
> ""If we can make it through their defenses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_ForeignIntelligence_Effective == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Effective"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_ForeignIntelligence_Adequate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ForeignIntelligence_Adequate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[207]`
Mówca: **Lucita Azaro**
> ""We can absolutely trust it, Your Majesty. Our services are at the top of their game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[208]`
Mówca: **Lucita Azaro**
> ""We should be able to trust it, Your Majesty. Our services could be better funded, but they're adequate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[209]`
Mówca: **Lucita Azaro**
> ""I wish I could say yes. But the truth is, our services are stretched thin. I have no idea how accurate their findings are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[210]`
Mówca: **Taddeus Azaro**
> ""We will sabotage them in whatever way we deem necessary, but only if the situation permits it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[211]`
Mówca: **Lucita Azaro**
> ""And if the current situation doesn't permit it, we'll create a situation that does. One way or another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[212]`
Mówca: **Taddeus Azaro**
> ""The defenses around Pales are extreme, and the entrance to the peninsula will be difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Carlos Robles Azaro**
> ""If we can get past their fleet, a naval invasion is definitely a possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Taddeus Azaro**
> ""Or we can rely on airstrikes at the entrance to the corridor while pushing with our land troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Operation 2 Win Questions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[216]`
Mówca: **Taddeus Azaro**
> ""Then thank you for your time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[217]`
Mówca: **Lucita Azaro**
> ""Yes, Your Majesty. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[218]`
  - -> `[220]`
  - -> `[221]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not fail me. For your own good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Soon, I will ride my horse on the streets of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Toras and Azaro on the battlefield once more. My father would be proud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[222]`
Mówca: **Taddeus Azaro**
> ""It's an honor to be asked for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[223]`
Mówca: **Taddeus Azaro**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[224]`
Mówca: **Lucita Azaro**
> ""Soon, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[225]`
Mówca: **Lucita Azaro**
> ""We will fight in his honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[226]`
Mówca: **Taddeus Azaro**
> ""Then thank you for your time, Your Majesty. With you in command, victory is a sure thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[227]`
Mówca: **Taddeus Azaro**
> ""Then thank you for your time, Your Majesty. I promise we will make Rizia proud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[228]`
Mówca: **Lucita Azaro**
> ""Yes, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[240]`
  - -> `[246]`
  - -> `[242]`

### Węzeł `[229]`
Mówca: **Narrator**
> "He leaned over the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[230]`
Mówca: **Narrator**
> "He drew a circle around the peninsula and tapped his finger on it a few times."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[231]`
Mówca: **Narrator**
> "He drew a line around the border between Rizia and Pales and tapped his finger on it a few times."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[232]`
Mówca: **Narrator**
> "Lucita pointed at another stack of papers on the table. Among them, I saw photographs of what appeared to be battleships at night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[233]`
Mówca: **Narrator**
> "She pointed at Lespia on the map."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[234]`
Mówca: **Narrator**
> "After putting an X on the Palesian capital, she leaned back and crossed her arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[235]`
Mówca: **Narrator**
> "Everyone seemed taken aback, but nobody dared to protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[236]`
Mówca: **Narrator**
> "He put his fist on his heart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Narrator**
> "She pointed at a few ports and drew lines over the sea."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[238]`
Mówca: **Taddeus Azaro**
> ""We held our ground and will continue to do so until our last breath.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[239]`
Mówca: **Narrator**
> "Looking down without meeting my eyes, Lucita collected the documents on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No matter what, I thank you for your advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not fail me. For your own good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good luck to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[243]`
Mówca: **Lucita Azaro**
> ""It's an honor to be asked for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[244]`
Mówca: **Taddeus Azaro**
> ""You've made yourself very clear, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[245]`
Mówca: **Lucita Azaro**
> ""Good luck to all of us, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Leave me alone. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Taddeus Azaro**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_EnemyAirStrikeCount = 5;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Military_EnemyAirStrikeCount"] = 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn08_PostOperation1_Charge = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_PostOperation1_Charge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And lo, we shall smite our enemies with the full vengeance of the Divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[254]`
Mówca: **Narrator**
> "Lucita coughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[258]`
Mówca: **Narrator**
> "Lucita looked me in the eye earnestly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Discovered_LespianInvolvement == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Discovered_LespianInvolvement == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  and  Variable["RiziaDLC.Zille_Publicized_LespianInvolvement"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_Discovered_LespianInvolvement == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  and  Variable["RiziaDLC.Zille_Publicized_LespianInvolvement"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[262]`
Mówca: **Lucita Azaro**
> ""I'll remind you that we do have a certain amount of leverage over the Lespian government. Now would be a good time to use it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Discovered_LespianInvolvement == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Discovered_LespianInvolvement == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  and  Variable["RiziaDLC.Zille_Publicized_LespianInvolvement"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_Discovered_LespianInvolvement == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  and  Variable["RiziaDLC.Zille_Publicized_LespianInvolvement"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[266]`
Mówca: **Narrator**
> "Lucita looked directly at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Lucita Azaro**
> ""I'll remind you that we do have a certain amount of leverage over the Lespian government. Perhaps now is the time to use it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Lucita Azaro**
> ""As for the taking of the capital, should we get that far...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[269]`
Mówca: **Carlos Robles Azaro**
> ""Yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[270]`
Mówca: **Narrator**
> "Lucita spread several strategic maps of the region on the table before turning to Carlos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[271]`
Mówca: **Lucita Azaro**
> ""General?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[272]`
Mówca: **Carlos Robles Azaro**
> ""For king and country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[273]`
Mówca: **Carlos Robles Azaro**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[274]`
Mówca: **Carlos Robles Azaro**
> ""A pleasure as always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[275]`
Mówca: **Carlos Robles Azaro**
> ""Right away, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[276]`
Mówca: **Carlos Robles Azaro**
> ""For king and country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[277]`
Mówca: **Carlos Robles Azaro**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
