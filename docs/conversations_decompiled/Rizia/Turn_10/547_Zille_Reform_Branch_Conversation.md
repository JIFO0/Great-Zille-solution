# Rizia/Turn 10/Zille_Reform_Branch/Zille_Reform_Branch Conversation

- **ID konwersacji:** `547`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/547_Zille_Reform_Branch_Conversation.md`
- **Liczba węzłów dialogowych:** 179
- **Liczba wyborów gracza:** 2

---

## 1. Uczestnicy Sceny

- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[95]** Player_Romus *(Gracz)*
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Situation_Diplomacy_Zille_ATAActive`
- `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive`
- `RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal`
- `RiziaDLC.Situation_Law_WehlenRights_Full`
- `RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied`
- `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown`
- `RiziaDLC.ZilleOwnership_Brenas`
- `RiziaDLC.ZilleReferendum_Approved`
- `RiziaDLC.ZilleReferendum_Interfere_Agents_Success`
- `RiziaDLC.ZilleReferendum_Interfere_Army_Success`
- `RiziaDLC.ZilleReferendum_Won`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[348] Rizia/Turn 10/TalkWithPrimeMinister** (../Turn_10/348_TalkWithPrimeMinister.md), Węzeł `[679]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 4

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[77]` (Paskal Beniwoll): `--;`
- Węzeł `[150]` (Paskal Beniwoll): `--;`
- Węzeł `[161]` (Paskal Beniwoll): `--;`
- Węzeł `[178]` (Paskal Beniwoll): `--;`

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
  - -> `[84]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `348` (*Rizia/Turn 10/TalkWithPrimeMinister*), Węzeł `[679]`

### Węzeł `[3]`
Mówca: **Manus Sazon**
> ""Because of the referendum, we already had an Electoral Commission and voter registration systems within Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[4]`
Mówca: **Manus Sazon**
> ""While the referendum's infrastructure is beneficial, some perceive the electoral process as a top-down initiative, leading to concerns about fairness and transparency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[5]`
Mówca: **Manus Sazon**
> ""Zille's rapid reintegration has streamlined the electoral process, resulting in unified voter registration and high participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""However, without a say in Zille's return to Rizia, many feel disconnected from the decision, leading to suspicions and resistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Adarfo Sotelato**
> ""The rapid reintegration of Zille has brought some improvements to the electoral process, with unified voter registration and high participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Adarfo Sotelato**
> ""While the referendum's infrastructure is beneficial, some perceive the electoral process as a top-down initiative, raising doubts about its true fairness and transparency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[18]`
Mówca: **Daria de Rava**
> ""While the referendum's infrastructure is beneficial, some see the electoral process as imposed from above, fueling worries over fairness and transparency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[19]`
Mówca: **Manus Sazon**
> ""Some citizens perceive the electoral process as a top-down initiative, leading to concerns about fairness and transparency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Daria de Rava**
> ""Some citizens see the electoral process as imposed from above, fueling worries over fairness and transparency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[24]`
Mówca: **Adarfo Sotelato**
> ""Some citizens perceive the electoral process as a top-down initiative, raising doubts about its true fairness and transparency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Daria de Rava**
> ""As luck would have it, the referendum led to the creation of an Electoral Commission and voter registration systems within Zille...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[35]`
Mówca: **Adarfo Sotelato**
> ""Fortunately for us, the referendum led to the creation of an Electoral Commission and voter registration systems within Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Approved == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Approved == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Approved"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Approved == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Approved"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Daria de Rava**
> ""Zille's rapid reintegration has streamlined the electoral process, leading to unified voter registration and increased participation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[46]`
Mówca: **Daria de Rava**
> ""However, many are frustrated by their lack of input in Zille's return to Rizia, and this has led to some resistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[47]`
Mówca: **Adarfo Sotelato**
> ""Yet, for those who had no say in Zille's return to Rizia, the lack of involvement has created a sense of alienation, sowing mistrust and opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[51]`
Mówca: **Manus Sazon**
> ""These fears have only grown since the referendum, as accusations of interference have fueled lingering distrust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[52]`
Mówca: **Daria de Rava**
> ""These fears have only intensified since the referendum, as accusations of interference have fueled lingering distrust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[56]`
Mówca: **Adarfo Sotelato**
> ""These fears have only intensified since the referendum, as accusations of interference have fueled lingering distrust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_Interfere_Army_Success == true || RiziaDLC.ZilleReferendum_Interfere_Agents_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_Interfere_Army_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Agents_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[66]`
Mówca: **Manus Sazon**
> ""But with House Sazon in charge of governance, it does seem like voters are primed to go for the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[67]`
Mówca: **Daria de Rava**
> ""As for my party, we've all but given up on campaigning in Zille. House Sazon has them primed to vote for the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleOwnership_Brenas == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleOwnership_Brenas == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleOwnership_Brenas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleOwnership_Brenas == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleOwnership_Brenas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Adarfo Sotelato**
> ""As for how they'll vote, it could go either way. After decades of instability, they may decide my version of the RPP is too radical for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[72]`
Mówca: **Manus Sazon**
> ""And since House Sazon has no influence over the province, I can't be sure voters will go for the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleOwnership_Brenas == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleOwnership_Brenas == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleOwnership_Brenas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleOwnership_Brenas == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleOwnership_Brenas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Daria de Rava**
> ""On the bright side, I believe Zilleans can be convinced to align with the RNC. They want peace after years of upheaval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_WehlenRights_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_WehlenRights_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_WehlenRights_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[171]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[87]`
Mówca: **Manus Sazon**
> ""It's complicated, as you can imagine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[88]`
Mówca: **Manus Sazon**
> ""Though Zilleans have enjoyed freedom of movement since the Amendment to the Zille Agreement, many families separated by the region's transfer to Wehzek control are only now reuniting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_WehlenRights_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_WehlenRights_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_WehlenRights_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_WehlenRights_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_WehlenRights_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_WehlenRights_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[95]`
Mówca: **Manus Sazon**
> ""The mood is happy, but concerns about their future in Rizia remain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[99]`
Mówca: **Manus Sazon**
> ""To make matter worse, some Su Omina members have taken matters into their own hands, violently evicting Wehzek families from their homes, claiming the land belongs to 'real' Rizians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Manus Sazon**
> ""But your treaty with Wehlen, granting Wehzek citizens full rights as Rizians, has helped smooth the transition for those who remained behind, ensuring they receive legal protections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[101]`
Mówca: **Manus Sazon**
> ""We’ve worked swiftly to curb these incidents, but they have only deepened the fears of those hesitant about reintegration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true || RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true || RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true  or  Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true || RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true  or  Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[105]`
Mówca: **Manus Sazon**
> ""The Ariana Toras Association has been instrumental to reintegration efforts, expanding its cultural and language initiatives in Zille to help our new citizens feel at home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[109]`
Mówca: **Daria de Rava**
> ""It's no cakewalk, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[113]`
Mówca: **Adarfo Sotelato**
> ""Reincorpating Zille into Rizia has not been easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[114]`
Mówca: **Daria de Rava**
> ""There have also been isolated incidents of Su Omina members forcibly removing Wehzek families from their homes, claiming the land belongs to ‘true’ Rizians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true || RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true || RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true  or  Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true ||RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true || RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true  or  Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[118]`
Mówca: **Daria de Rava**
> ""However, your treaty with Wehlen, which grants Wehzek citizens full Rizian rights, has helped ease the transition for those who chose to remain, ensuring their legal protections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[119]`
Mówca: **Daria de Rava**
> ""The presence of the Ariana Toras Association has definitely had a positive effect. It's expanded its cultural and language initiatives in Zille to help new citizens integrate more smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[123]`
Mówca: **Daria de Rava**
> ""While Zilleans have had freedom of movement since the Amendment to the Zille Agreement, many families split by the region's transfer to Wehzek control are just now reuniting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_WehlenRights_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_WehlenRights_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_WehlenRights_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[127]`
Mówca: **Daria de Rava**
> ""The mood is celebratory, yet uncertainties about their future in Rizia persist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[128]`
Mówca: **Daria de Rava**
> ""We've acted quickly to contain these incidents, but they have only heightened the anxieties of those wary of reintegration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[129]`
Mówca: **Adarfo Sotelato**
> ""But you needn’t trouble yourself with such matters -- seeing how this is no longer within your purview.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[130]`
Mówca: **Manus Sazon**
> ""Meanwhile, your treaty with Wehlen, granting Wehzek citizens full rights as Rizians, has helped ease the transition for those who opted to stay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[131]`
Mówca: **Daria de Rava**
> ""Meanwhile, your treaty with Wehlen, granting Wehzek citizens full rights as Rizians, has helped ease the transition for those who opted to stay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[132]`
Mówca: **Adarfo Sotelato**
> ""Ultimately, these are issues for the people to resolve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[133]`
Mówca: **Manus Sazon**
> ""After 30 years, the families separated by Zille's transfer to Wehzek control have finally begun reuniting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[134]`
Mówca: **Daria de Rava**
> ""After 30 years, the families separated by Zille's transfer to Wehzek control have finally begun reuniting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[135]`
Mówca: **Adarfo Sotelato**
> ""All you need to know is that we're working hard towards achieving parity between the Wehzek and Rizian parts of the population. If they don't have equal rights, this whole reunification project is pointless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_WehlenRights_Full == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_WehlenRights_Full == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_WehlenRights_Full == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[139]`
Mówca: **Adarfo Sotelato**
> ""There's been some trouble with Dastnurists fleeing to Wehlen out of concern for their religious freedoms. I'm not that bothered, to be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[143]`
Mówca: **Adarfo Sotelato**
> ""I will tell you that your laws have helped smooth tensions. Granting Wehzeks and Rizians the same rights ahead of the transfer was a smart idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[144]`
Mówca: **Adarfo Sotelato**
> ""Oh, and we've had to deal with Su Omina members forcibly removing Wehzek families from their homes, claiming the land belongs to ‘true’ Rizians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[148]`
Mówca: **Adarfo Sotelato**
> ""We've acted quickly to contain these incidents, but they've only heightened the anxieties of those wary of reintegration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are election preparations going up there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
  - -> `[149]`
  - -> `[151]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Which way do you think they'll lean at the polls?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Manus Sazon**
> ""First we have to see if they vote at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Daria de Rava**
> ""That depends on who can be coaxed out to vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Adarfo Sotelato**
> ""We'll be lucky if they make it to the polls at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[162]`
Mówca: **Manus Sazon**
> ""Protests continue in some areas, particularly among Zilleans with Wehzek citizenship, who fear being treated as second-class citizens due to their limited legal protections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Manus Sazon**
> ""We've had to work hard to assuage fears among Dastnurists, many of whom have fled to Wehlen anticipating restrictions on their religious practices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[170]`
Mówca: **Daria de Rava**
> ""Among the most outspoken critics are Zilleans who hold Wehzek citizenship, fearing they will be treated as second-class citizens due to limited legal protections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Equal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Daria de Rava**
> ""There's been a flood of Dastnurists leaving Zille for Wehlen, worried that the Rizian government will restrict their religious freedoms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
