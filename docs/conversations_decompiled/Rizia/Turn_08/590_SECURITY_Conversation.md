# Rizia/Turn 8/SECURITY/SECURITY Conversation

- **ID konwersacji:** `590`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/590_SECURITY_Conversation.md`
- **Liczba węzłów dialogowych:** 287
- **Liczba wyborów gracza:** 10

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Army_Unit_Flagship_Total`
- `RiziaDLC.Army_Unit_Infantry_Total`
- `RiziaDLC.Army_Unit_Ship_Total`
- `RiziaDLC.Army_Unit_Submarine_Total`
- `RiziaDLC.Army_Unit_Support_Total`
- `RiziaDLC.Army_Unit_Tank_Total`
- `RiziaDLC.Council_Security_Taddeus`
- `RiziaDLC.Council_Security_Titus`
- `RiziaDLC.Focus_MilitaryBranch_Airforce`
- `RiziaDLC.Focus_MilitaryBranch_Navy`
- `RiziaDLC.Incident_Naval_RescueBoth`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Average`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Strong`
- `RiziaDLC.War_Control_Skipped`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[419] Rizia/Turn 8/A_GeneralCouncilMeeting** (../Turn_08/419_A_GeneralCouncilMeeting.md), Węzeł `[281]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 1

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[274]` (Paskal Beniwoll): `--;`

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `419` (*Rizia/Turn 8/A_GeneralCouncilMeeting*), Węzeł `[281]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[12]`
Mówca: **Lucita Azaro**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[13]`
Mówca: **Titus Gordion**
> ""Sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[14]`
Mówca: **Taddeus Azaro**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[15]`
Mówca: **Lucita Azaro**
> ""With all due respect, Your Majesty, considering our current situation, I'd rather leave such sensitive information to the war meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Lucita Azaro**
> ""The operation will likely come to an end very soon -- we can go over specifics after the council meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That doesn't give me any confidence about how things are going down there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Control_Skipped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Control_Skipped == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Control_Skipped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Control_Skipped == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Control_Skipped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. We'll discuss such matters at the more appropriate juncture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[22]`
Mówca: **Lucita Azaro**
> ""As the acting commander of our armed forces, you must be briefed by the general staff directly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Control_Skipped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Control_Skipped == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Control_Skipped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Control_Skipped == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Control_Skipped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Duchess Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Narrator**
> "She gave a military salute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Lucita Azaro**
> ""Rest assured, Your Majesty, we will be victorious. No matter what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[30]`
Mówca: **Hugo Toras**
> ""Thank you for your service, Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
Mówca: **Taddeus Azaro**
> ""Rizian armed forces have emerged as a formidable power, boasting superior capabilities compared to most neighboring nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[38]`
Mówca: **Taddeus Azaro**
> ""Rizian armed forces stand ready and strong. However, we still lag significantly behind some of our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[39]`
Mówca: **Taddeus Azaro**
> ""Rizian Armed Forces is in a sad state, Your Majesty. We are completely behind our neighbors in military capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
Mówca: **Titus Gordion**
> ""The general staff is content with the situation of the Rizian Armed Forces. We possess higher capabilities than most of our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[47]`
Mówca: **Titus Gordion**
> ""Rizian armed forces stand ready and strong. However, we still lag significantly behind some of our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[48]`
Mówca: **Titus Gordion**
> ""The general staff is very disappointed about the state of the Rizian Armed Forces. We are completely behind our neighbors in military capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[55]`
Mówca: **Lucita Azaro**
> ""Rizian armed forces have emerged as a formidable power, boasting superior capabilities compared to most neighboring nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
Mówca: **Lucita Azaro**
> ""Rizian armed forces stand ready and strong. However, we still lag significantly behind some of our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Lucita Azaro**
> ""The Rizian Armed Forces require investment. We are completely behind our neighbors in military capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total >= 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total >= 10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Infantry_Total >= 10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total >= 8)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total >= 8)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Infantry_Total >= 8))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total > 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total > 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Infantry_Total > 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[67]`
Mówca: **Lucita Azaro**
> ""At present, we can mobilize a large number of infantry divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[68]`
Mówca: **Lucita Azaro**
> ""At present, we can deploy approximately eight to nine fully equipped infantry divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
Mówca: **Lucita Azaro**
> ""At present, we can deploy approximately eight to nine fully equipped infantry divisions. However, our numbers are limited, signaling a need for expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Lucita Azaro**
> ""At present, we can deploy five fully equipped infantry divisions, which I believe is insufficient. We should look for ways to increase this number as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 7)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total >= 7))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total > 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total > 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
Mówca: **Lucita Azaro**
> ""Thankfully, we possess a vast number of mechanized support divisions specifically trained to back our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[81]`
Mówca: **Lucita Azaro**
> ""Thankfully, we possess a substantial number of mechanized support divisions specifically trained to back our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[82]`
Mówca: **Lucita Azaro**
> ""On the other hand, we also have a modest amount of mechanized support divisions that are specifically trained to back our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Lucita Azaro**
> ""Unfortunately, we can only field three mechanized support divisions specifically trained to back our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Lucita Azaro**
> ""Taking this into account, it would create substantial difficulties in defending ourselves in the event of a military conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Lucita Azaro**
> ""And as far as our tanks are concerned...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Tank_Total >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Tank_Total >= 6)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Tank_Total"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Tank_Total >= 6))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Tank_Total"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[95]`
Mówca: **Lucita Azaro**
> ""Our tank divisions outnumber all of our neighbors except Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[96]`
Mówca: **Lucita Azaro**
> ""We can comfortably field enough divisions to support our infantry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[97]`
Mówca: **Lucita Azaro**
> ""We operate with limited divisions, while our neighbors' inventory far surpasses ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Lucita Azaro**
> ""We have no divisions in place, whereas our neighbors' inventory is well stocked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Lucita Azaro**
> ""On the other hand, our air force is fully capable of challenging regional powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Airforce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Airforce == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_MilitaryBranch_Airforce == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Lucita Azaro**
> ""In contrast, the Rizian air force is barely capable of contesting Palesian air superiority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Flagship_Total == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Flagship_Total == 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Flagship_Total"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Flagship_Total == 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Flagship_Total"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[108]`
Mówca: **Lucita Azaro**
> ""And lastly, steering our navy is our flagship, the RRN Valero -- the most prized asset of the whole Rizian military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Lucita Azaro**
> ""And lastly, our navy has unfortunately suffered a significant loss with the flagship RRN Valero being taken out of service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Lucita Azaro**
> ""It's also important to highlight that despite significant investments in our navy, we still lack access to cutting-edge Valgish tech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Navy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Navy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_MilitaryBranch_Navy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Ship_Total >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Ship_Total >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Ship_Total >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Ship_Total >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Ship_Total >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Ship_Total >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[120]`
Mówca: **Lucita Azaro**
> ""Luckily, our fleet has a considerable number of destroyers -- pivotal for projecting power in the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[121]`
Mówca: **Lucita Azaro**
> ""Luckily, our fleet is capable of contesting our immediate neighbors at critical locations, if necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[122]`
Mówca: **Lucita Azaro**
> ""Unfortunately, our fleet is short on ships to effectively project power in the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Lucita Azaro**
> ""Our submarines can also provide crucial support -- enough to effectively defend our primary trade routes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[273]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Submarine_Total >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Submarine_Total >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Submarine_Total"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Submarine_Total >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Submarine_Total"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""Our submarines can also provide crucial support -- enough to cause significant damage despite being few in numbers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[273]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total >= 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total >= 10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Infantry_Total >= 10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total >= 8)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total >= 8)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Infantry_Total >= 8))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total > 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total > 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Infantry_Total > 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[137]`
Mówca: **Titus Gordion**
> ""We can field a significant number of infantry divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[138]`
Mówca: **Titus Gordion**
> ""We can deploy approximately eight to nine fully equipped infantry divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[139]`
Mówca: **Titus Gordion**
> ""We can deploy approximately eight to nine fully equipped infantry divisions. However, our numbers are limited, signaling a need for expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Titus Gordion**
> ""We can deploy five fully equipped infantry divisions, which I believe is insufficient. We should look for ways to increase this number as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 7)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total >= 7))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total > 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total > 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[150]`
Mówca: **Titus Gordion**
> ""Thankfully, we possess a vast number of mechanized support divisions specifically trained to bolster our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[151]`
Mówca: **Titus Gordion**
> ""Thankfully, we possess a substantial number of mechanized support divisions specifically trained to bolster our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[152]`
Mówca: **Titus Gordion**
> ""On the other hand, we also have a modest amount of mechanized support divisions  that are specifically trained to reinforce our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Titus Gordion**
> ""Regrettably, we can only field three mechanized support divisions specifically trained to reinforce our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Titus Gordion**
> ""In light of these factors, it would present a significant challenge to defend ourselves should a military conflict arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Titus Gordion**
> ""And as for our tanks...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Tank_Total >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Tank_Total >= 6)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Tank_Total"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Tank_Total >= 6))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Tank_Total"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total > 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total > 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[165]`
Mówca: **Titus Gordion**
> ""Our tank divisions outnumber all of our neighbors except Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[166]`
Mówca: **Titus Gordion**
> ""We presently field enough divisions to support our infantry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[167]`
Mówca: **Titus Gordion**
> "We currently field three divisions, significantly fewer than our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Titus Gordion**
> ""We operate with only two divisions, while our neighbors' stock far surpasses our own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Narrator**
> "He let out a sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Titus Gordion**
> ""In contrast, our air force is more than capable of challenging regional powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Airforce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Airforce == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_MilitaryBranch_Airforce == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Titus Gordion**
> ""In contrast, Rizia's air force is barely capable of contesting Palesian air superiority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Flagship_Total == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Flagship_Total == 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Flagship_Total"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Flagship_Total == 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Flagship_Total"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[178]`
Mówca: **Titus Gordion**
> ""And lastly, our navy is spearheaded by our flagship, the RRN Valero -- -- the most prized asset within the entire Rizian military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[179]`
Mówca: **Titus Gordion**
> ""And lastly, our navy has unfortunately experienced a significant setback due to the flagship RRN Valero being taken out of service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Titus Gordion**
> ""It's also important to highlight that despite significant investments in our navy, we still lack access to cutting-edge Valgish technology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Navy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Navy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_MilitaryBranch_Navy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Ship_Total >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Ship_Total >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Ship_Total >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Ship_Total >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Ship_Total >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Ship_Total >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[190]`
Mówca: **Titus Gordion**
> ""Luckily, our fleet includes a substantial number of destroyers -- pivotal for projecting power in the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[191]`
Mówca: **Titus Gordion**
> ""Luckily, our fleet is able to contest our immediate neighbors at critical locations, if needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[192]`
Mówca: **Titus Gordion**
> ""Unfortunately, our fleet lacks the ships necessary to project any significant power in the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Titus Gordion**
> ""Our submarines can also provide essential support -- enough to effectively defend our primary trade routes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[271]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Submarine_Total >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Submarine_Total >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Submarine_Total"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Submarine_Total >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Submarine_Total"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Titus Gordion**
> ""Our submarines can also provide essential support -- enough to cause significant damage despite being few in numbers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[271]`

### Węzeł `[198]`
Mówca: **Taddeus Azaro**
> ""Our current strength allows us to field five fully equipped infantry divisions, which is insufficient. We should look for ways to increase this number as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[199]`
Mówca: **Taddeus Azaro**
> ""Unfortunately, we can only field three mechanized support divisions specifically trained to reinforce our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Taddeus Azaro**
> ""Given these circumstances, it would pose a considerable challenge to defend ourselves in the event of a military conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Taddeus Azaro**
> ""And when it comes to our tanks...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Tank_Total >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Tank_Total >= 6)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Tank_Total"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Tank_Total >= 6))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Tank_Total"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total > 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total > 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[208]`
Mówca: **Taddeus Azaro**
> ""Our divisions outnumber all of our neighbors except Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[209]`
Mówca: **Taddeus Azaro**
> ""We currently field enough divisions to support our infantry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[210]`
Mówca: **Taddeus Azaro**
> ""We currently field three divisions, a figure considerably lower than that of our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Taddeus Azaro**
> ""We operate with only two divisions, while our neighbors' arsenal far surpasses our own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Taddeus Azaro**
> ""In contrast, our air force is quite capable of challenging regional powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Airforce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Airforce == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_MilitaryBranch_Airforce == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Airforce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Taddeus Azaro**
> ""In contrast, our air force is barely capable of contesting Palesian air superiority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Flagship_Total == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Flagship_Total == 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Flagship_Total"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Flagship_Total == 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Flagship_Total"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[221]`
Mówca: **Taddeus Azaro**
> ""Lastly, at the helm of our navy is our flagship, the RRN Valero -- the most prized asset of the whole Rizian military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Taddeus Azaro**
> ""And lastly, our navy has unfortunately experienced a major setback with the flagship RRN Valero being taken out of service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Navy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_MilitaryBranch_Navy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_MilitaryBranch_Navy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_MilitaryBranch_Navy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[226]`
Mówca: **Taddeus Azaro**
> ""Our submarines can also offer crucial support -- enough to effectively defend our primary trade routes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[272]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total >= 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total >= 10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Infantry_Total >= 10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total >= 8)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total >= 8)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Infantry_Total >= 8))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] >= 8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total > 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Infantry_Total > 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Infantry_Total"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Infantry_Total > 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Infantry_Total"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[236]`
Mówca: **Taddeus Azaro**
> ""Our current strength allows us to field numerous infantry divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[237]`
Mówca: **Taddeus Azaro**
> """Our current strength allows us to deploy approximately eight to nine fully equipped infantry divisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Taddeus Azaro**
> ""Our current strength allows us to deploy approximately eight to nine fully equipped infantry divisions. However, our numbers are limited, signaling a need for expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 7)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 7)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 7`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total >= 7))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 7) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total > 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total > 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[248]`
Mówca: **Taddeus Azaro**
> ""Thankfully, we command a vast number of mechanized support divisions specifically trained to reinforce our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[249]`
Mówca: **Taddeus Azaro**
> ""Thankfully, we command a substantial number of mechanized support divisions specifically trained to reinforce our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[250]`
Mówca: **Taddeus Azaro**
> ""On the other hand, we command a modest number of mechanized support divisions specifically trained to reinforce our infantry and armored units during assaults.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Support_Total >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Support_Total"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Support_Total >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Support_Total"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[254]`
Mówca: **Taddeus Azaro**
> ""It's also important to highlight that despite significant investments in our navy, we still lack access to advanced Valgish technology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Ship_Total >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Ship_Total >= 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Ship_Total >= 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Ship_Total >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Ship_Total >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Ship_Total >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Ship_Total"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[261]`
Mówca: **Taddeus Azaro**
> ""Luckily, our fleet boasts a substantial number of destroyers -- a vital component for projecting power in the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[262]`
Mówca: **Taddeus Azaro**
> ""Luckily, our fleet is able to contest our immediate neighbors at critical locations, if necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Taddeus Azaro**
> ""Unfortunately, our fleet lacks the ships necessary to exert any significant power in the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Submarine_Total >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Army_Unit_Submarine_Total >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Submarine_Total"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Army_Unit_Submarine_Total >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Submarine_Total"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Taddeus Azaro**
> ""Our submarines can also offer crucial support -- enough to cause significant damage despite being few in numbers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[272]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the overview.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have enough information about our armed forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Let's move on to another topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the report, Titus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the report, General.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the report, Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`
  - -> `[270]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_RescueBoth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_RescueBoth == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Naval_RescueBoth == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_RescueBoth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_RescueBoth == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Naval_RescueBoth == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_RescueBoth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_RescueBoth == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Naval_RescueBoth == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
