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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 0

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `361` (*Rizia/Turn 6/A_CouncilMeeting*), Węzeł `[48]`

### Węzeł `[3]`
Mówca: **Laurento Esquibel**
> ""The vote's outcome was influenced by a number of nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_Arbitration_Support == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_Arbitration_Support == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_Arbitration_Support"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Morella_Arbitration_Support == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_Arbitration_Support"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Laurento Esquibel**
> ""Prime Minister Alma Saltana of Morella used her legal background to make a convincing argument on our behalf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_Arbitration_Support == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_Arbitration_Support == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_Arbitration_Support"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Derdia_Arbitration_Support == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_Arbitration_Support"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[11]`
Mówca: **Laurento Esquibel**
> ""Jorga Azmal of Derdia stated that the field belonged to us by divine right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Laurento Esquibel**
> ""In the wake of our countries' new agreement, Wehlen was very supportive of our claim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Arbitration_Support == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Arbitration_Support == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Arbitration_Support"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_Arbitration_Support == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Arbitration_Support"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Rumburg_Arbitration_FullSupport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Laurento Esquibel**
> ""Queen Beatrice made a personal appearance at the AN to plead our case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Laurento Esquibel**
> ""Queen Beatrice sent a statement of support, though she neglected to appear before the arbitration committee in person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Laurento Esquibel**
> ""Chancellor Hegel of Valgsland made an especially heartfelt plea to uphold the original interpretation of ANDOR, without mentioning Rizia by name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_ScrewedOverLespia == false && RiziaDLC.Turn05_ITZVote_Nationalization == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_ScrewedOverLespia == false && RiziaDLC.Turn05_ITZVote_Nationalization == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_ScrewedOverLespia"] == false  and  Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_ScrewedOverLespia == false && RiziaDLC.Turn05_ITZVote_Nationalization == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_ScrewedOverLespia"] == false  and  Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Laurento Esquibel**
> ""Support for Pales came mostly from Lespia and other ATO nations. Prime Minister Alvarez was not as vocal as he could have been, perhaps due to our alignment in MITZ matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
Mówca: **Laurento Esquibel**
> ""Support for Pales came mostly from Lespia and other ATO nations, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Laurento Esquibel**
> ""Overall, we gained just enough international sympathy to overcome ATO's clout with the AN and have an edge in the proceedings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Laurento Esquibel**
> ""In the end, we simply couldn't overcome the clout ATO carries with the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
