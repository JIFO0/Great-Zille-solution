# Rizia/Turn 5/FPnT_MorellaReturnFlight

- **ID konwersacji:** `329`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Rizia/Turn_05/329_FPnT_MorellaReturnFlight.md`
- **Liczba węzłów dialogowych:** 41
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.MITZ_Nationalization_LargerShare`
- `RiziaDLC.MITZ_Nationalization_NoShare`
- `RiziaDLC.MITZ_Nationalization_SmallerShare`
- `RiziaDLC.MITZ_Renegotiation_LargerShare`
- `RiziaDLC.MITZ_Renegotiation_SameShareNoLespia`
- `RiziaDLC.MITZ_Renegotiation_SmallerShare`
- `RiziaDLCIsolated.Turn05_MorellaITZ_NationalizationDemands_Airplanes`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 9

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[21]` (Paskal Beniwoll): `ShowPagedDecisionsPanel("Panel_Nationalization_Demands_NoShare");`
- Węzeł `[22]` (Paskal Beniwoll): `ShowPagedDecisionsPanel("Panel_Nationalization_Demands_Share");`
- Węzeł `[23]` (Paskal Beniwoll): `ShowPagedDecisionsPanel("Panel_Nationalization_Concessions_SeizeLespiaShare");`
- Węzeł `[24]` (Paskal Beniwoll): `ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_BuyLespia");`
- Węzeł `[25]` (Paskal Beniwoll): `ShowPagedDecisionsPanel("Panel_Renegotiation_Demands_CedeRiziaShare");`
- Węzeł `[26]` (Paskal Beniwoll): `ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_SameShares");`
- Węzeł `[27]` (Paskal Beniwoll): `ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_NoLespia");`
- Węzeł `[29]` (Paskal Beniwoll): `End();`
- *...oraz 1 innych węzłów ze skryptami.*

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
  - -> `[40]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Nationalization_NoShare == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Nationalization_NoShare == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Nationalization_NoShare == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Nationalization_LargerShare == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Nationalization_LargerShare == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Nationalization_LargerShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Nationalization_LargerShare == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Nationalization_LargerShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Nationalization_SmallerShare == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Nationalization_SmallerShare == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Nationalization_SmallerShare == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_LargerShare == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_LargerShare == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_LargerShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Renegotiation_LargerShare == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_LargerShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_SmallerShare == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_SmallerShare == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_SmallerShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Renegotiation_SmallerShare == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_SmallerShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_SameShareNoLespia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_SameShareNoLespia == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_SameShareNoLespia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Renegotiation_SameShareNoLespia == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_SameShareNoLespia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ShowPagedDecisionsPanel("Panel_Nationalization_Demands_NoShare"))*
- **Efekt (`userScript`):** `ShowPagedDecisionsPanel("Panel_Nationalization_Demands_NoShare");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ShowPagedDecisionsPanel("Panel_Nationalization_Demands_Share"))*
- **Efekt (`userScript`):** `ShowPagedDecisionsPanel("Panel_Nationalization_Demands_Share");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ShowPagedDecisionsPanel("Panel_Nationalization_Concessions_SeizeLespiaShare"))*
- **Efekt (`userScript`):** `ShowPagedDecisionsPanel("Panel_Nationalization_Concessions_SeizeLespiaShare");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_BuyLespia"))*
- **Efekt (`userScript`):** `ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_BuyLespia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ShowPagedDecisionsPanel("Panel_Renegotiation_Demands_CedeRiziaShare"))*
- **Efekt (`userScript`):** `ShowPagedDecisionsPanel("Panel_Renegotiation_Demands_CedeRiziaShare");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_SameShares"))*
- **Efekt (`userScript`):** `ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_SameShares");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_NoLespia"))*
- **Efekt (`userScript`):** `ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_NoLespia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Narrator**
> "I reviewed the agreement once more before signing it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[30]`
Mówca: **Narrator**
> "I took my first-class seat in the plane that had been chartered for my return flight from Morella."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Looking outside of the window, I could see Argno and the mountains."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Narrator**
> "The future of our relationship with Morella and the MITZ was in my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Narrator**
> "I took a look at the papers in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[34]`
Mówca: **Narrator**
> "The pilot announced that our descent into Porte Drazon had begun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Narrator**
> "I fastened my seatbelt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[36]`
Mówca: **Narrator**
> "It struck me how much more comfortable this jet was than the ones we had in Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn05_MorellaITZ_NationalizationDemands_Airplanes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn05_MorellaITZ_NationalizationDemands_Airplanes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn05_MorellaITZ_NationalizationDemands_Airplanes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn05_MorellaITZ_NationalizationDemands_Airplanes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn05_MorellaITZ_NationalizationDemands_Airplanes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
