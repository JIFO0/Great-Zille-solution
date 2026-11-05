# Rizia/Turn 6/AN Individual Support

- **ID konwersacji:** `364`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/364_AN_Individual_Support.md`
- **Liczba węzłów dialogowych:** 32
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- **[70]** Laurento Esquibel

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Derdia_Arbitration_Support`
- `RiziaDLC.Diplomacy_Morella_Arbitration_Support`
- `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf`
- `RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport`
- `RiziaDLC.Diplomacy_Wehlen_Arbitration_Support`
- `RiziaDLC.MITZ_ScrewedOverLespia`
- `RiziaDLC.Turn05_ITZVote_Nationalization`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[361] Rizia/Turn 6/A_CouncilMeeting** (../Turn_06/361_A_CouncilMeeting.md), Węzeł `[48]`

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
  - -> `[3]` (*Laurento Esquibel: ""The vote's outcome was influenced by a number of nations.""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[3]`
Mówca: **Laurento Esquibel**
> ""The vote's outcome was influenced by a number of nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_Arbitration_Support == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_Arbitration_Support == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_Arbitration_Support == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Morella_Arbitration_Support == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_Arbitration_Support == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_Arbitration_Support"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Laurento Esquibel: ""Prime Minister Alma Saltana of Morella used her legal ba..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Morella_Arbitration_Support == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_Arbitration_Support"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_Arbitration_Support == true"*)

### Węzeł `[7]`
Mówca: **Laurento Esquibel**
> ""Prime Minister Alma Saltana of Morella used her legal background to make a convincing argument on our behalf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_Arbitration_Support == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_Arbitration_Support == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_Arbitration_Support == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Derdia_Arbitration_Support == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_Arbitration_Support == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_Arbitration_Support"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Laurento Esquibel: ""Jorga Azmal of Derdia stated that the field belonged to ..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Derdia_Arbitration_Support == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_Arbitration_Support"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Arbitration_Support == true"*)

### Węzeł `[11]`
Mówca: **Laurento Esquibel**
> ""Jorga Azmal of Derdia stated that the field belonged to us by divine right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Arbitration_Support == true"*)

### Węzeł `[12]`
Mówca: **Laurento Esquibel**
> ""In the wake of our countries' new agreement, Wehlen was very supportive of our claim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport == true"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Arbitration_Support == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_Arbitration_Support == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_Arbitration_Support == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_Arbitration_Support == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Arbitration_Support"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Laurento Esquibel: ""In the wake of our countries' new agreement, Wehlen was ..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_Arbitration_Support == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Arbitration_Support"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport == t..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Laurento Esquibel: ""Queen Beatrice made a personal appearance at the AN to p..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Laurento Esquibel: ""Queen Beatrice sent a statement of support, though she n..."*)

### Węzeł `[19]`
Mówca: **Laurento Esquibel**
> ""Queen Beatrice made a personal appearance at the AN to plead our case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Laurento Esquibel: ""Chancellor Hegel of Valgsland made an especially heartfe..."*)

### Węzeł `[20]`
Mówca: **Laurento Esquibel**
> ""Queen Beatrice sent a statement of support, though she neglected to appear before the arbitration committee in person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Laurento Esquibel: ""Chancellor Hegel of Valgsland made an especially heartfe..."*)

### Węzeł `[21]`
Mówca: **Laurento Esquibel**
> ""Chancellor Hegel of Valgsland made an especially heartfelt plea to uphold the original interpretation of ANDOR, without mentioning Rizia by name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_ScrewedOverLespia == false && RiziaDLC.Turn..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_ScrewedOverLespia == false && RiziaDLC.Turn05_ITZVote_Nationalization == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_ScrewedOverLespia == false && RiziaDLC.Turn..."*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_ScrewedOverLespia == false && RiziaDLC.Tu..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_ScrewedOverLespia == false && RiziaDLC.Turn05_ITZVote_Nationalization == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_ScrewedOverLespia"] == false  and  Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Laurento Esquibel: ""Support for Pales came mostly from Lespia and other ATO ..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_ScrewedOverLespia == false && RiziaDLC.Turn05_ITZVote_Nationalization == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_ScrewedOverLespia"] == false  and  Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Laurento Esquibel: ""Support for Pales came mostly from Lespia and other ATO ..."*)

### Węzeł `[25]`
Mówca: **Laurento Esquibel**
> ""Support for Pales came mostly from Lespia and other ATO nations. Prime Minister Alvarez was not as vocal as he could have been, perhaps due to our alignment in MITZ matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)

### Węzeł `[26]`
Mówca: **Laurento Esquibel**
> ""Support for Pales came mostly from Lespia and other ATO nations, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)

### Węzeł `[27]`
Mówca: **Laurento Esquibel**
> ""Overall, we gained just enough international sympathy to overcome ATO's clout with the AN and have an edge in the proceedings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ==..."*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf ..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Laurento Esquibel: ""Overall, we gained just enough international sympathy to..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Laurento Esquibel: ""In the end, we simply couldn't overcome the clout ATO ca..."*)

### Węzeł `[31]`
Mówca: **Laurento Esquibel**
> ""In the end, we simply couldn't overcome the clout ATO carries with the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
