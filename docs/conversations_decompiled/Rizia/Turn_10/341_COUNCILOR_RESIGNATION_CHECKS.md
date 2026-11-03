# Rizia/Turn 10/COUNCILOR RESIGNATION CHECKS

- **ID konwersacji:** `341`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/341_COUNCILOR_RESIGNATION_CHECKS.md`
- **Liczba węzłów dialogowych:** 32
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Council_Security_Taddeus`
- `RiziaDLC.HouseAzaro_Conquered`
- `RiziaDLC.HouseToras_Conquered`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[338] Rizia/Turn 10/CouncilMeeting** (../Turn_10/338_CouncilMeeting.md), Węzeł `[463]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 5

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[6]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] = true;`
- Węzeł `[13]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] = true;`
- Węzeł `[20]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] = true;`
- Węzeł `[27]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] = true;`
- Węzeł `[31]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone"] = true;`

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `338` (*Rizia/Turn 10/CouncilMeeting*), Węzeł `[463]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseAzaro_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseAzaro_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseAzaro_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseAzaro_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_LucitaResigns"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_SecurityCouncilorGone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseToras_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_TaddeusResigns"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true || RiziaDLC.Lucita_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true  or  Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoResigns"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Hugo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Arrested == true || RiziaDLC.Hugo_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Arrested"] == true  or  Variable["RiziaDLC.Hugo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_HugoGone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
