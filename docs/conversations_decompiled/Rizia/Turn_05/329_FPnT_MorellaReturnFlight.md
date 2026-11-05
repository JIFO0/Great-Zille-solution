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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

- *Brak decyzji i wyborów gracza w tej scenie (dialog liniowy lub sekwencja techniczna).*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Nationalization_NoShare == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Nationalization_NoShare == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Nationalization_NoShare == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Nationalization_NoShare == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_Nationalization_Demands_No..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Nationalization_NoShare == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Nationalization_SmallerShare == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Nationalization_LargerShare == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Nationalization_LargerShare == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Nationalization_LargerShare == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Nationalization_LargerShare == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Nationalization_LargerShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_Nationalization_Concession..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Nationalization_LargerShare == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Nationalization_LargerShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_LargerShare == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Nationalization_SmallerShare == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Nationalization_SmallerShare == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Nationalization_SmallerShare == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Nationalization_SmallerShare == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_Nationalization_Demands_Sh..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Nationalization_SmallerShare == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Nationalization_LargerShare == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_LargerShare == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_LargerShare == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Renegotiation_LargerShare == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_LargerShare == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_LargerShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Renegotiation_LargerShare == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_LargerShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_SmallerShare == true"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_SmallerShare == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_SmallerShare == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Renegotiation_SmallerShare == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_SmallerShare == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_SmallerShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_Renegotiation_Demands_Cede..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Renegotiation_SmallerShare == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_SmallerShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_SameShareNoLespia == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_SameShareNoLespia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_SameShareNoLespia == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Renegotiation_SameShareNoLespia == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_SameShareNoLespia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_SameShareNoLespia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Renegotiation_SameShareNoLespia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_SameShareNoLespia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ShowPagedDecisionsPanel("Panel_Nationalization_Demands_NoShare")`
- **Efekt skryptowy (`userScript`):** `ShowPagedDecisionsPanel("Panel_Nationalization_Demands_NoShare");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "I reviewed the agreement once more before signing it."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ShowPagedDecisionsPanel("Panel_Nationalization_Demands_Share")`
- **Efekt skryptowy (`userScript`):** `ShowPagedDecisionsPanel("Panel_Nationalization_Demands_Share");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "I reviewed the agreement once more before signing it."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ShowPagedDecisionsPanel("Panel_Nationalization_Concessions_SeizeLespiaShare")`
- **Efekt skryptowy (`userScript`):** `ShowPagedDecisionsPanel("Panel_Nationalization_Concessions_SeizeLespiaShare");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "I reviewed the agreement once more before signing it."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_BuyLespia")`
- **Efekt skryptowy (`userScript`):** `ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_BuyLespia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "I reviewed the agreement once more before signing it."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ShowPagedDecisionsPanel("Panel_Renegotiation_Demands_CedeRiziaShare")`
- **Efekt skryptowy (`userScript`):** `ShowPagedDecisionsPanel("Panel_Renegotiation_Demands_CedeRiziaShare");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "I reviewed the agreement once more before signing it."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_SameShares")`
- **Efekt skryptowy (`userScript`):** `ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_SameShares");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "I reviewed the agreement once more before signing it."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_NoLespia")`
- **Efekt skryptowy (`userScript`):** `ShowPagedDecisionsPanel("Panel_Renegotiation_Concessions_NoLespia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "I reviewed the agreement once more before signing it."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "I reviewed the agreement once more before signing it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "The pilot announced that our descent into Porte Drazon ha..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[30]`
Mówca: **Narrator**
> "I took my first-class seat in the plane that had been chartered for my return flight from Morella."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn05_MorellaITZ_NationalizationDemands..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Looking outside of the window, I could see Argno and the mountains."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "The future of our relationship with Morella and the MITZ ..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "The future of our relationship with Morella and the MITZ was in my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "I took a look at the papers in front of me."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "I took a look at the papers in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Nationalization_NoShare == true"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "The pilot announced that our descent into Porte Drazon had begun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "I fastened my seatbelt."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "I fastened my seatbelt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[36]`
Mówca: **Narrator**
> "It struck me how much more comfortable this jet was than the ones we had in Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Looking outside of the window, I could see Argno and the ..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn05_MorellaITZ_NationalizationDemands_Airplanes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn05_MorellaITZ_NationalizationDemands..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn05_MorellaITZ_NationalizationDeman..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn05_MorellaITZ_NationalizationDemands_Airplanes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn05_MorellaITZ_NationalizationDemands_Airplanes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "It struck me how much more comfortable this jet was than ..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn05_MorellaITZ_NationalizationDemands_Airplanes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn05_MorellaITZ_NationalizationDemands_Airplanes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Looking outside of the window, I could see Argno and the ..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "I took my first-class seat in the plane that had been cha..."*)
