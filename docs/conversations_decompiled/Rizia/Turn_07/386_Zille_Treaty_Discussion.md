# Rizia/Turn 7/Zille Treaty Discussion

- **ID konwersacji:** `386`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/386_Zille_Treaty_Discussion.md`
- **Liczba węzłów dialogowych:** 215
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_HouseSazon`
- `RiziaDLC.Diplomacy_Wehlen_AgreementRefused`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.MITZ_Nationalization_NoShare`
- `RiziaDLC.MITZ_Nationalization_SmallerShare`
- `RiziaDLC.MITZ_Renegotiation_SmallerShare`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen`
- `RiziaDLC.Policy_Economy_RizianWineIndustry`
- `RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed`
- `RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project`
- `RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized`
- `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas`
- `RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold`
- `RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine`
- `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF`
- `RiziaDLC.Situation_Law_WehlenRights_Full`
- `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied`
- `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan`
- `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.War_Incident_Border`
- `RiziaDLC.Zille_ReferendumPower`
- `RiziaDLC.Zille_ViolentResistancePower`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[388] Rizia/Turn 7/Religion** (../Turn_07/388_Religion.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `388` (*Rizia/Turn 7/Religion*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""My constituents, especially those in Brenas, have expressed concern over the lack of a concrete deadline for the region's return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""We are encouraged by the growing non-violent resistance movement against the Wehzek occupation. Yet we wonder whether it will be enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ReferendumPower > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ReferendumPower > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_ReferendumPower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_ReferendumPower > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_ReferendumPower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_ViolentResistancePower > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Manus Sazon**
> ""We worry that the growing presence of Su Omina in Zille, while certainly a thorn in the side of the Wehzek government, risks undermining our goal of a peaceful transfer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Manus Sazon**
> ""With no agreement in place with Wehlen and no organized resistance from Zille's Rizian population, we worry that the transfer will be postponed indefinitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Daria de Rava**
> ""A peaceful transfer might be our goal, but it was never President Smolak's. My party supports the reclamation of Zille by any means necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[198]`
  - -> `[199]`
  - -> `[209]`

### Węzeł `[20]`
Mówca: **Daria de Rava**
> ""We are on the same page here, Mr. Sazon. There is pressure among my party to take action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[196]`
  - -> `[197]`
  - -> `[209]`

### Węzeł `[21]`
Mówca: **Daria de Rava**
> ""We are on the same page here, Mr. Sazon. The pressure on Wehlen must be increased.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[196]`
  - -> `[197]`
  - -> `[209]`

### Węzeł `[22]`
Mówca: **Daria de Rava**
> ""My constituents have expressed concern over the lack of a concrete deadline for the region's return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[26]`
Mówca: **Manus Sazon**
> ""More to the point, it has alienated Rizia's Golcondist population, with whom we were already on shaky ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Manus Sazon**
> ""More to the point, it risks alienating Rizia's Golcondist population, just when we were beginning to better integrate them into our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[31]`
Mówca: **Daria de Rava**
> ""I will say that the process of granting rights to Wehzeks has been far from frictionless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false)))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Daria de Rava**
> ""There have been worries about the long-term feasibility of our trade deal. We may not have the resources necessary to hold up our end of the bargain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy < 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy < 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy < 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Renegotiation_SmallerShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Renegotiation_SmallerShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true  or  Variable["RiziaDLC.MITZ_Renegotiation_SmallerShare"] == true  or  Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Renegotiation_SmallerShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true  or  Variable["RiziaDLC.MITZ_Renegotiation_SmallerShare"] == true  or  Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_RizianWineIndustry == false && (RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_RizianWineIndustry == false && (RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_RizianWineIndustry"] == false  and  (Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_RizianWineIndustry == false && (RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_RizianWineIndustry"] == false  and  (Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[54]`
Mówca: **Narrator**
> "Manus put up a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[55]`
Mówca: **Daria de Rava**
> ""Thankfully, the trade deal seems to be proceeding as planned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[56]`
Mówca: **Daria de Rava**
> ""A peaceful transfer might be our goal, but it was never President Smolak's. My party supports the reclamation of Zille by any means necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[203]`
  - -> `[205]`

### Węzeł `[57]`
Mówca: **Manus Sazon**
> ""We are on the same page here, Madame Speaker. The people of Brenas are demanding action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[201]`
  - -> `[202]`

### Węzeł `[58]`
Mówca: **Manus Sazon**
> ""We are on the same page here, Madame Speaker. We need to increase the pressure on President Smolak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[201]`
  - -> `[202]`

### Węzeł `[59]`
Mówca: **Daria de Rava**
> ""We are encouraged by the growing non-violent resistance movement against the Wehzek occupation. Yet we wonder whether it will be enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[60]`
Mówca: **Daria de Rava**
> ""My constituents are eagerly awaiting the end of the Zille Agreement's three-year probationary period and the return of our land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ReferendumPower > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ReferendumPower > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_ReferendumPower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_ReferendumPower > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_ReferendumPower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_ViolentResistancePower > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_ViolentResistancePower > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Manus Sazon**
> ""As have mine. We worry that the growing presence of Su Omina in Zille, while certainly a thorn in the side of the Wehzek government, risks undermining our goal of a peaceful transfer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[68]`
Mówca: **Daria de Rava**
> ""With no agreement in place with Wehlen and no organized resistance from Zille's Rizian population, we worry that the transfer will be postponed indefinitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[72]`
Mówca: **Daria de Rava**
> ""However, I have been fielding concerns that Rizia's participation in Wehlen's 'Operation Bear Trap' is damaging certain lucrative international partnerships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[73]`
Mówca: **Manus Sazon**
> ""It is a matter of consistency, Madame Speaker. It was a mistake to fully integrate Wehzek citizens while restricting rights for other migrant groups.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_WehlenRights_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_WehlenRights_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_WehlenRights_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[80]`
Mówca: **Daria de Rava**
> ""However, I have been fielding concerns that Rizia's so-called Golcondist border ban is damaging certain lucrative international partnerships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Manus Sazon**
> ""In essence, it has already pushed away Rizia's Golcondist community, a group with whom our relationship was already fragile.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Manus Sazon**
> ""Essentially, it threatens to estrange Rizia's Golcondist community precisely at the moment we were making progress in integrating them into our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[89]`
Mówca: **Manus Sazon**
> ""The same goes for our border ban, which has been criticized as unfairly targeting those of Golcondist faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Daria de Rava**
> ""If and when the territory is finally returned, there are questions about how it will be reincorporated into Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[94]`
Mówca: **Manus Sazon**
> ""More to the point, it has alienated Rizia's Golcondist population, with whom we were already on shaky ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Manus Sazon**
> ""More to the point, it risks alienating Rizia's Golcondist population, just when we were beginning to better integrate them into our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false)))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Manus Sazon**
> ""There have been worries about the long-term feasibility of our trade deal. We may not have the resources necessary to hold up our end of the bargain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy < 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy < 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy < 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Renegotiation_SmallerShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Renegotiation_SmallerShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true  or  Variable["RiziaDLC.MITZ_Renegotiation_SmallerShare"] == true  or  Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Renegotiation_SmallerShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true  or  Variable["RiziaDLC.MITZ_Renegotiation_SmallerShare"] == true  or  Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_RizianWineIndustry == false && (RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_RizianWineIndustry == false && (RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_RizianWineIndustry"] == false  and  (Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_RizianWineIndustry == false && (RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_RizianWineIndustry"] == false  and  (Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[121]`
Mówca: **Manus Sazon**
> ""What questions, Ms. de Rava? Zille has always been part of the province of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[122]`
Mówca: **Manus Sazon**
> ""Thankfully, the trade deal seems to be proceeding as planned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[123]`
Mówca: **Manus Sazon**
> ""My constituents, especially those in Brenas, are eagerly awaiting the end of the Zille Agreement's three-year probationary period and the return of our land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[127]`
Mówca: **Manus Sazon**
> ""I don't think that's the conclusion we should be drawing, Madame Speaker. It's a matter of consistency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_WehlenRights_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_WehlenRights_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_WehlenRights_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[134]`
Mówca: **Daria de Rava**
> ""If and when the territory is finally returned, there are questions about how it will be reincorporated into Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[138]`
Mówca: **Manus Sazon**
> ""However, I have been fielding concerns that Rizia's Golcondist border ban is damaging our already-shaky relationship with that community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Manus Sazon**
> ""However, I have been fielding concerns that Rizia's Golcondist border ban is damaging our burgeoning relationship with that community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[146]`
Mówca: **Manus Sazon**
> ""The same goes for our border ban, which has been criticized as unfairly targeting those of Golcondist faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[147]`
Mówca: **Manus Sazon**
> ""However, some believe that cooperating with Wehlen on the persecution of their Bludish minority has been a bridge too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Daria de Rava**
> ""We are on the same page here, Mr. Sazon. My party is particularly concerned that Rizia's participation in Wehlen's 'Operation Bear Trap' is damaging our lucrative international partnerships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[149]`
Mówca: **Daria de Rava**
> ""More to the point, it has drawn criticism from certain international partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[150]`
Mówca: **Manus Sazon**
> ""I will say that agreeing to fully integrate Wehzek citizens while restricting rights for other migrant groups has led to some friction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Daria de Rava**
> ""Yes, my party has always been of the opinion that this term should have been left out of the amended treaty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[152]`
Mówca: **Narrator**
> "Daria put up a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[153]`
Mówca: **Manus Sazon**
> ""Objection. What questions? Zille has always been part of the province of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Daria de Rava**
> ""That may be true, but in the interests of stability, reincorporating it under Rizia Imperii's jurisdiction is the obvious choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Daria de Rava**
> ""It is the same reason why the Pales Administrative District has not yet rejoined Cardesse-Montaklar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Manus Sazon**
> ""That decision was due to ongoing border difficulties -- as we have experienced extremely recently. Zille faces no such danger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Border == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Manus Sazon**
> ""That decision was due to ongoing border difficulties. Zille faces no such danger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[161]`
Mówca: **Narrator**
> "The volume in the room grew louder as the Delegates began arguing among themselves. I turned to Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[164]`
  - -> `[167]`
  - -> `[168]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have to give Zille back to Brenas, don't I? House Sazon would revolt if I didn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at them. Squabbling away like a bunch of children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Giving the Sazons more land after what they did? They don't deserve it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is totally irrelevant, anyway. There's no telling when we'll get Zille back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shouldn't Zille's citizens decide for themselves who governs them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Hugo Toras**
> ""You really needn't come to these sessions, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[171]`
Mówca: **Hugo Toras**
> ""Don't go down that route, Your Majesty. Holding any kind of election in Zille opens the door for Wehlen to interfere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[172]`
Mówca: **Hugo Toras**
> ""Not if the house were sufficiently weakened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Country_HouseSazon > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Country_HouseSazon > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[176]`
Mówca: **Hugo Toras**
> ""You have empowered the Sazons enough without granting them more territory. I beg of you to be careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[177]`
Mówca: **Hugo Toras**
> ""I should say not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Hugo Toras**
> ""But with their heir's party holding a Delegate majority, the house's demands will only get bolder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[182]`
Mówca: **Hugo Toras**
> ""Fortunately, you don't have to listen to their demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[183]`
Mówca: **Hugo Toras**
> ""You'll have to make this decision sooner or later, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Hugo Toras**
> ""Sooner, one hopes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[185]`
Mówca: **Daria de Rava**
> ""How can you say that after the Friendship Day incident? There is no telling what Wehlen will do, even if Zille is returned without a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Manus Sazon**
> ""At this stage, Wehlen will not want to risk damaging our agreement. And if they do, my province can handle it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Manus Sazon**
> ""*If* Wehlen tries anything, my province can handle it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Narrator**
> "Eventually, Manus motioned for order. The Delegates quieted down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[195]`
Mówca: **Narrator**
> "Eventually, Daria motioned for order. The Delegates quieted down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia's strategy for reclaiming Zille from Wehlen is a matter of royal confidentiality and not up for debate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hear your concerns. I will do what I can to put a flame to Mr. Smolak's feet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, Mr. Sazon. I wish we lived in a world where all conflicts could be resolved peacefully. But we do not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hear your concerns. But I cannot control what is happening outside Rizia's borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I plan to work closely with the international community. Together, we can force a diplomatic handover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia's strategy for reclaiming Zille from Wehlen is a matter of royal confidentiality and not up for debate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hear your concerns. I will do what I can to put a flame to Mr. Smolak's feet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, Mr. Sazon. I wish we lived in a world where all conflicts could be resolved peacefully. But we do not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I plan to work closely with the international community. Together, we can force a diplomatic handover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hear your concerns. But I cannot control what is happening outside Rizia's borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Narrator**
> "Daria nodded, looking not entirely satisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[207]`
Mówca: **Narrator**
> "Manus nodded, looking not entirely satisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[208]`
Mówca: **Narrator**
> "Manus nodded, looking not entirely satisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have faith that God will restore our rightful territory to us. And you should too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[213]`
Mówca: **Manus Sazon**
> ""Moving on to more pressing topics...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[214]`
Mówca: **Daria de Rava**
> ""Moving on to more pressing topics...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
