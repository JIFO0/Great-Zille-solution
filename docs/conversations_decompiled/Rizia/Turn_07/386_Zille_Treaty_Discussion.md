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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[162]` | **""I have to give Zille back to Brenas, don't I? House Sazon would revolt if I didn't.""** | `[161]` **Narrator**: "The volume in the room grew loud..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Hugo Toras**: ""You have empowered the Sazons e..."<br>`[172]` **Hugo Toras**: ""Not if the house were sufficien..." |
| `[163]` | **""Look at them. Squabbling away like a bunch of children.""** | `[161]` **Narrator**: "The volume in the room grew loud..." | `Variable["RiziaDLC.LeaningValue_Democratic"] < 0` | *Brak zmian stanu* | `[170]` **Hugo Toras**: ""You really needn't come to thes..." |
| `[167]` | **""Giving the Sazons more land after what they did? They don't deserve it.""** | `[161]` **Narrator**: "The volume in the room grew loud..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Hugo Toras**: ""I should say not."" |
| `[168]` | **""This is totally irrelevant, anyway. There's no telling when we'll get Zille back.""** | `[161]` **Narrator**: "The volume in the room grew loud..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Hugo Toras**: ""You'll have to make this decisi..." |
| `[169]` | **""Shouldn't Zille's citizens decide for themselves who governs them?""** | `[161]` **Narrator**: "The volume in the room grew loud..." | `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false` | *Brak zmian stanu* | `[171]` **Hugo Toras**: ""Don't go down that route, Your ..." |
| `[196]` | **""Rizia's strategy for reclaiming Zille from Wehlen is a matter of royal confidenti..."** | `[19]` **Daria de Rava**: ""A peaceful transfer might be ou..."<br>`[20]` **Daria de Rava**: ""We are on the same page here, M..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Narrator**: "Manus nodded, looking not entire..." |
| `[197]` | **""I hear your concerns. I will do what I can to put a flame to Mr. Smolak's feet.""** | `[20]` **Daria de Rava**: ""We are on the same page here, M..."<br>`[21]` **Daria de Rava**: ""We are on the same page here, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Narrator**: "Manus nodded, looking not entire..." |
| `[198]` | **""Indeed, Mr. Sazon. I wish we lived in a world where all conflicts could be resolv..."** | `[19]` **Daria de Rava**: ""A peaceful transfer might be ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Narrator**: "Manus nodded, looking not entire..." |
| `[199]` | **""I hear your concerns. But I cannot control what is happening outside Rizia's bord..."** | `[19]` **Daria de Rava**: ""A peaceful transfer might be ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Narrator**: "Manus nodded, looking not entire..." |
| `[200]` | **""I plan to work closely with the international community. Together, we can force a..."** | `[20]` **Daria de Rava**: ""We are on the same page here, M..."<br>`[21]` **Daria de Rava**: ""We are on the same page here, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Narrator**: "Manus nodded, looking not entire..." |
| `[201]` | **""Rizia's strategy for reclaiming Zille from Wehlen is a matter of royal confidenti..."** | `[56]` **Daria de Rava**: ""A peaceful transfer might be ou..."<br>`[57]` **Manus Sazon**: ""We are on the same page here, M..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Narrator**: "Daria nodded, looking not entire..." |
| `[202]` | **""I hear your concerns. I will do what I can to put a flame to Mr. Smolak's feet.""** | `[57]` **Manus Sazon**: ""We are on the same page here, M..."<br>`[58]` **Manus Sazon**: ""We are on the same page here, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Narrator**: "Daria nodded, looking not entire..." |
| `[203]` | **""Indeed, Mr. Sazon. I wish we lived in a world where all conflicts could be resolv..."** | `[56]` **Daria de Rava**: ""A peaceful transfer might be ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Narrator**: "Manus nodded, looking not entire..." |
| `[204]` | **""I plan to work closely with the international community. Together, we can force a..."** | `[57]` **Manus Sazon**: ""We are on the same page here, M..."<br>`[58]` **Manus Sazon**: ""We are on the same page here, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Narrator**: "Daria nodded, looking not entire..." |
| `[205]` | **""I hear your concerns. But I cannot control what is happening outside Rizia's bord..."** | `[56]` **Daria de Rava**: ""A peaceful transfer might be ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Narrator**: "Manus nodded, looking not entire..." |
| `[212]` | **""I have faith that God will restore our rightful territory to us. And you should t..."** | `[19]` **Daria de Rava**: ""A peaceful transfer might be ou..."<br>`[20]` **Daria de Rava**: ""We are on the same page here, M..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[208]` **Narrator**: "Manus nodded, looking not entire..." |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true"*)

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""My constituents, especially those in Brenas, have expressed concern over the lack of a concrete deadline for the region's return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ReferendumPower > 0"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Manus Sazon: ""My constituents, especially those in Brenas, have expres..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Manus Sazon: ""My constituents, especially those in Brenas, are eagerly..."*)

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""We are encouraged by the growing non-violent resistance movement against the Wehzek occupation. Yet we wonder whether it will be enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Daria de Rava: ""We are on the same page here, Mr. Sazon. The pressure on..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ReferendumPower > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ReferendumPower > 0"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_ReferendumPower > 0)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ReferendumPower > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_ReferendumPower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Manus Sazon: ""We are encouraged by the growing non-violent resistance ..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_ReferendumPower > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_ReferendumPower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower > 0"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower > 0"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_ViolentResistancePower > 0)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Manus Sazon: ""We worry that the growing presence of Su Omina in Zille,..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_ViolentResistancePower > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Manus Sazon: ""With no agreement in place with Wehlen and no organized ..."*)

### Węzeł `[17]`
Mówca: **Manus Sazon**
> ""We worry that the growing presence of Su Omina in Zille, while certainly a thorn in the side of the Wehzek government, risks undermining our goal of a peaceful transfer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Daria de Rava: ""A peaceful transfer might be our goal, but it was never ..."*)

### Węzeł `[18]`
Mówca: **Manus Sazon**
> ""With no agreement in place with Wehlen and no organized resistance from Zille's Rizian population, we worry that the transfer will be postponed indefinitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Daria de Rava: ""We are on the same page here, Mr. Sazon. There is pressu..."*)

### Węzeł `[19]`
Mówca: **Daria de Rava**
> ""A peaceful transfer might be our goal, but it was never President Smolak's. My party supports the reclamation of Zille by any means necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player_Romus: ""Rizia's strategy for reclaiming Zille from Wehlen is a m..."*)
  - -> `[198]` (*Player_Romus: ""Indeed, Mr. Sazon. I wish we lived in a world where all ..."*)
  - -> `[199]` (*Player_Romus: ""I hear your concerns. But I cannot control what is happe..."*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[20]`
Mówca: **Daria de Rava**
> ""We are on the same page here, Mr. Sazon. There is pressure among my party to take action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Player_Romus: ""I plan to work closely with the international community...."*)
  - -> `[196]` (*Player_Romus: ""Rizia's strategy for reclaiming Zille from Wehlen is a m..."*)
  - -> `[197]` (*Player_Romus: ""I hear your concerns. I will do what I can to put a flam..."*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[21]`
Mówca: **Daria de Rava**
> ""We are on the same page here, Mr. Sazon. The pressure on Wehlen must be increased.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Player_Romus: ""I plan to work closely with the international community...."*)
  - -> `[196]` (*Player_Romus: ""Rizia's strategy for reclaiming Zille from Wehlen is a m..."*)
  - -> `[197]` (*Player_Romus: ""I hear your concerns. I will do what I can to put a flam..."*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[22]`
Mówca: **Daria de Rava**
> ""My constituents have expressed concern over the lack of a concrete deadline for the region's return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ReferendumPower > 0"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Daria de Rava: ""My constituents have expressed concern over the lack of ..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Daria de Rava: ""My constituents are eagerly awaiting the end of the Zill..."*)

### Węzeł `[26]`
Mówca: **Manus Sazon**
> ""More to the point, it has alienated Rizia's Golcondist population, with whom we were already on shaky ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == t..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied..."*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfi..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Manus Sazon: ""More to the point, it has alienated Rizia's Golcondist p..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Manus Sazon: ""More to the point, it risks alienating Rizia's Golcondis..."*)

### Węzeł `[30]`
Mówca: **Manus Sazon**
> ""More to the point, it risks alienating Rizia's Golcondist population, just when we were beginning to better integrate them into our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == t..."*)

### Węzeł `[31]`
Mówca: **Daria de Rava**
> ""I will say that the process of granting rights to Wehzeks has been far from frictionless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Manus Sazon: ""It is a matter of consistency, Madame Speaker. It was a ..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners =..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Daria de Rava: ""I will say that the process of granting rights to Wehzek..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true"*)

### Węzeł `[35]`
Mówca: **Daria de Rava**
> ""There have been worries about the long-term feasibility of our trade deal. We may not have the resources necessary to hold up our end of the bargain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Daria de Rava: ""If and when the territory is finally returned, there are..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy < 1"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy < 1"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy < 1)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy < 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Daria de Rava: ""There have been worries about the long-term feasibility ..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy < 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Renegotiation_SmallerShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaD..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Renegotiation_SmallerShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true  or  Variable["RiziaDLC.MITZ_Renegotiation_SmallerShare"] == true  or  Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Daria de Rava: ""There have been worries about the long-term feasibility ..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Renegotiation_SmallerShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true  or  Variable["RiziaDLC.MITZ_Renegotiation_SmallerShare"] == true  or  Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_RizianWineIndustry == false && (R..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_RizianWineIndustry == false && (RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_RizianWineIndustry == false && (R..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_RizianWineIndustry == false && ..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_RizianWineIndustry == false && (RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_RizianWineIndustry"] == false  and  (Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Daria de Rava: ""There have been worries about the long-term feasibility ..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_RizianWineIndustry == false && (RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_RizianWineIndustry"] == false  and  (Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true"*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Manus put up a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Manus Sazon: ""Objection. What questions? Zille has always been part of..."*)

### Węzeł `[55]`
Mówca: **Daria de Rava**
> ""Thankfully, the trade deal seems to be proceeding as planned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Daria de Rava: ""If and when the territory is finally returned, there are..."*)

### Węzeł `[56]`
Mówca: **Daria de Rava**
> ""A peaceful transfer might be our goal, but it was never President Smolak's. My party supports the reclamation of Zille by any means necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player_Romus: ""Rizia's strategy for reclaiming Zille from Wehlen is a m..."*)
  - -> `[203]` (*Player_Romus: ""Indeed, Mr. Sazon. I wish we lived in a world where all ..."*)
  - -> `[205]` (*Player_Romus: ""I hear your concerns. But I cannot control what is happe..."*)

### Węzeł `[57]`
Mówca: **Manus Sazon**
> ""We are on the same page here, Madame Speaker. The people of Brenas are demanding action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player_Romus: ""I plan to work closely with the international community...."*)
  - -> `[201]` (*Player_Romus: ""Rizia's strategy for reclaiming Zille from Wehlen is a m..."*)
  - -> `[202]` (*Player_Romus: ""I hear your concerns. I will do what I can to put a flam..."*)

### Węzeł `[58]`
Mówca: **Manus Sazon**
> ""We are on the same page here, Madame Speaker. We need to increase the pressure on President Smolak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player_Romus: ""I plan to work closely with the international community...."*)
  - -> `[201]` (*Player_Romus: ""Rizia's strategy for reclaiming Zille from Wehlen is a m..."*)
  - -> `[202]` (*Player_Romus: ""I hear your concerns. I will do what I can to put a flam..."*)

### Węzeł `[59]`
Mówca: **Daria de Rava**
> ""We are encouraged by the growing non-violent resistance movement against the Wehzek occupation. Yet we wonder whether it will be enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Manus Sazon: ""We are on the same page here, Madame Speaker. We need to..."*)

### Węzeł `[60]`
Mówca: **Daria de Rava**
> ""My constituents are eagerly awaiting the end of the Zille Agreement's three-year probationary period and the return of our land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == ..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ReferendumPower > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ReferendumPower > 0"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_ReferendumPower > 0)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ReferendumPower > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_ReferendumPower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Daria de Rava: ""We are encouraged by the growing non-violent resistance ..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_ReferendumPower > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_ReferendumPower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower > 0"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower > 0"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_ViolentResistancePower > 0)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Manus Sazon: ""As have mine. We worry that the growing presence of Su O..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_ViolentResistancePower > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Daria de Rava: ""With no agreement in place with Wehlen and no organized ..."*)

### Węzeł `[67]`
Mówca: **Manus Sazon**
> ""As have mine. We worry that the growing presence of Su Omina in Zille, while certainly a thorn in the side of the Wehzek government, risks undermining our goal of a peaceful transfer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Daria de Rava: ""A peaceful transfer might be our goal, but it was never ..."*)

### Węzeł `[68]`
Mówca: **Daria de Rava**
> ""With no agreement in place with Wehlen and no organized resistance from Zille's Rizian population, we worry that the transfer will be postponed indefinitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Manus Sazon: ""We are on the same page here, Madame Speaker. The people..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == ..."*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF =..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Daria de Rava: ""However, I have been fielding concerns that Rizia's part..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == t..."*)

### Węzeł `[72]`
Mówca: **Daria de Rava**
> ""However, I have been fielding concerns that Rizia's participation in Wehlen's 'Operation Bear Trap' is damaging certain lucrative international partnerships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied..."*)

### Węzeł `[73]`
Mówca: **Manus Sazon**
> ""It is a matter of consistency, Madame Speaker. It was a mistake to fully integrate Wehzek citizens while restricting rights for other migrant groups.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_WehlenRights_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_WehlenRights_Full == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_WehlenRights_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners =..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_WehlenRights_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == t..."*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan ==..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Daria de Rava: ""However, I have been fielding concerns that Rizia's so-c..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[80]`
Mówca: **Daria de Rava**
> ""However, I have been fielding concerns that Rizia's so-called Golcondist border ban is damaging certain lucrative international partnerships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied..."*)

### Węzeł `[81]`
Mówca: **Manus Sazon**
> ""In essence, it has already pushed away Rizia's Golcondist community, a group with whom our relationship was already fragile.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfi..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Manus Sazon: ""In essence, it has already pushed away Rizia's Golcondis..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Manus Sazon: ""Essentially, it threatens to estrange Rizia's Golcondist..."*)

### Węzeł `[85]`
Mówca: **Manus Sazon**
> ""Essentially, it threatens to estrange Rizia's Golcondist community precisely at the moment we were making progress in integrating them into our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == t..."*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan ==..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Manus Sazon: ""The same goes for our border ban, which has been critici..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[89]`
Mówca: **Manus Sazon**
> ""The same goes for our border ban, which has been criticized as unfairly targeting those of Golcondist faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Daria de Rava: ""Thankfully, the trade deal seems to be proceeding as pla..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Daria de Rava: ""If and when the territory is finally returned, there are..."*)

### Węzeł `[93]`
Mówca: **Daria de Rava**
> ""If and when the territory is finally returned, there are questions about how it will be reincorporated into Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Manus put up a hand."*)

### Węzeł `[94]`
Mówca: **Manus Sazon**
> ""More to the point, it has alienated Rizia's Golcondist population, with whom we were already on shaky ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == t..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied..."*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfi..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Manus Sazon: ""More to the point, it has alienated Rizia's Golcondist p..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Manus Sazon: ""More to the point, it risks alienating Rizia's Golcondis..."*)

### Węzeł `[98]`
Mówca: **Manus Sazon**
> ""More to the point, it risks alienating Rizia's Golcondist population, just when we were beginning to better integrate them into our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == t..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners =..."*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Manus Sazon: ""I will say that agreeing to fully integrate Wehzek citiz..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false || RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false  or  Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true"*)

### Węzeł `[102]`
Mówca: **Manus Sazon**
> ""There have been worries about the long-term feasibility of our trade deal. We may not have the resources necessary to hold up our end of the bargain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Daria put up a hand."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy < 1"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy < 1"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy < 1)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy < 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Manus Sazon: ""There have been worries about the long-term feasibility ..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy < 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportGold"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Renegotiation_SmallerShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC..."*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaD..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Renegotiation_SmallerShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true  or  Variable["RiziaDLC.MITZ_Renegotiation_SmallerShare"] == true  or  Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Manus Sazon: ""There have been worries about the long-term feasibility ..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Renegotiation_SmallerShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true  or  Variable["RiziaDLC.MITZ_Renegotiation_SmallerShare"] == true  or  Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_RizianWineIndustry == false && (R..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ExportWine"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_RizianWineIndustry == false && (RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_RizianWineIndustry == false && (R..."*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_RizianWineIndustry == false && ..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_RizianWineIndustry == false && (RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_RizianWineIndustry"] == false  and  (Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Manus Sazon: ""There have been worries about the long-term feasibility ..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_RizianWineIndustry == false && (RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_RizianWineIndustry"] == false  and  (Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true"*)

### Węzeł `[121]`
Mówca: **Manus Sazon**
> ""What questions, Ms. de Rava? Zille has always been part of the province of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Daria de Rava: ""That may be true, but in the interests of stability, rei..."*)

### Węzeł `[122]`
Mówca: **Manus Sazon**
> ""Thankfully, the trade deal seems to be proceeding as planned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Daria put up a hand."*)

### Węzeł `[123]`
Mówca: **Manus Sazon**
> ""My constituents, especially those in Brenas, are eagerly awaiting the end of the Zille Agreement's three-year probationary period and the return of our land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == ..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == ..."*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF =..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Manus Sazon: ""However, some believe that cooperating with Wehlen on th..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == t..."*)

### Węzeł `[127]`
Mówca: **Manus Sazon**
> ""I don't think that's the conclusion we should be drawing, Madame Speaker. It's a matter of consistency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_WehlenRights_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_WehlenRights_Full == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_WehlenRights_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners =..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_WehlenRights_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_WehlenRights_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Wehlen_ExportGas == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Manus Sazon: ""Thankfully, the trade deal seems to be proceeding as pla..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Wehlen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Daria put up a hand."*)

### Węzeł `[134]`
Mówca: **Daria de Rava**
> ""If and when the territory is finally returned, there are questions about how it will be reincorporated into Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Manus Sazon: ""What questions, Ms. de Rava? Zille has always been part ..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == t..."*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan ==..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[138]`
Mówca: **Manus Sazon**
> ""However, I have been fielding concerns that Rizia's Golcondist border ban is damaging our already-shaky relationship with that community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Daria de Rava: ""More to the point, it has drawn criticism from certain i..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied..."*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfi..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Manus Sazon: ""However, I have been fielding concerns that Rizia's Golc..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Manus Sazon: ""However, I have been fielding concerns that Rizia's Golc..."*)

### Węzeł `[142]`
Mówca: **Manus Sazon**
> ""However, I have been fielding concerns that Rizia's Golcondist border ban is damaging our burgeoning relationship with that community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Daria de Rava: ""More to the point, it has drawn criticism from certain i..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == t..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan ==..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Manus Sazon: ""The same goes for our border ban, which has been critici..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[146]`
Mówca: **Manus Sazon**
> ""The same goes for our border ban, which has been criticized as unfairly targeting those of Golcondist faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[147]`
Mówca: **Manus Sazon**
> ""However, some believe that cooperating with Wehlen on the persecution of their Bludish minority has been a bridge too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Daria de Rava: ""We are on the same page here, Mr. Sazon. My party is par..."*)

### Węzeł `[148]`
Mówca: **Daria de Rava**
> ""We are on the same page here, Mr. Sazon. My party is particularly concerned that Rizia's participation in Wehlen's 'Operation Bear Trap' is damaging our lucrative international partnerships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied..."*)

### Węzeł `[149]`
Mówca: **Daria de Rava**
> ""More to the point, it has drawn criticism from certain international partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_WehlenRights_Full == true"*)

### Węzeł `[150]`
Mówca: **Manus Sazon**
> ""I will say that agreeing to fully integrate Wehzek citizens while restricting rights for other migrant groups has led to some friction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Daria de Rava: ""Yes, my party has always been of the opinion that this t..."*)

### Węzeł `[151]`
Mówca: **Daria de Rava**
> ""Yes, my party has always been of the opinion that this term should have been left out of the amended treaty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Manus Sazon: ""I don't think that's the conclusion we should be drawing..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "Daria put up a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Daria de Rava: ""If and when the territory is finally returned, there are..."*)

### Węzeł `[153]`
Mówca: **Manus Sazon**
> ""Objection. What questions? Zille has always been part of the province of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Daria de Rava: ""That may be true, but in the interests of stability, rei..."*)

### Węzeł `[154]`
Mówca: **Daria de Rava**
> ""That may be true, but in the interests of stability, reincorporating it under Rizia Imperii's jurisdiction is the obvious choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Daria de Rava: ""It is the same reason why the Pales Administrative Distr..."*)

### Węzeł `[155]`
Mówca: **Daria de Rava**
> ""It is the same reason why the Pales Administrative District has not yet rejoined Cardesse-Montaklar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true"*)

### Węzeł `[156]`
Mówca: **Manus Sazon**
> ""That decision was due to ongoing border difficulties -- as we have experienced extremely recently. Zille faces no such danger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Daria de Rava: ""How can you say that after the Friendship Day incident? ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Border == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Manus Sazon: ""That decision was due to ongoing border difficulties -- ..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Border == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Manus Sazon: ""That decision was due to ongoing border difficulties. Zi..."*)

### Węzeł `[160]`
Mówca: **Manus Sazon**
> ""That decision was due to ongoing border difficulties. Zille faces no such danger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Daria de Rava: ""How can you say that after the Friendship Day incident? ..."*)

### Węzeł `[161]`
Mówca: **Narrator**
> "The volume in the room grew louder as the Delegates began arguing among themselves. I turned to Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player_Romus: ""I have to give Zille back to Brenas, don't I? House Sazo..."*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[167]` (*Player_Romus: ""Giving the Sazons more land after what they did? They do..."*)
  - -> `[168]` (*Player_Romus: ""This is totally irrelevant, anyway. There's no telling w..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have to give Zille back to Brenas, don't I? House Sazon would revolt if I didn't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon > 0"*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at them. Squabbling away like a bunch of children.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Kontekst wejściowy (poprzednik):** `[161]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Hugo Toras: ""You really needn't come to these sessions, Your Majesty.""*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic < 0)"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player_Romus: ""Look at them. Squabbling away like a bunch of children.""*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus: ""Shouldn't Zille's citizens decide for themselves who gov..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Giving the Sazons more land after what they did? They don't deserve it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Hugo Toras: ""I should say not.""*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is totally irrelevant, anyway. There's no telling when we'll get Zille back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Hugo Toras: ""You'll have to make this decision sooner or later, Your ..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shouldn't Zille's citizens decide for themselves who governs them?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Kontekst wejściowy (poprzednik):** `[161]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Hugo Toras: ""Don't go down that route, Your Majesty. Holding any kind..."*)

### Węzeł `[170]`
Mówca: **Hugo Toras**
> ""You really needn't come to these sessions, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[171]`
Mówca: **Hugo Toras**
> ""Don't go down that route, Your Majesty. Holding any kind of election in Zille opens the door for Wehlen to interfere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[172]`
Mówca: **Hugo Toras**
> ""Not if the house were sufficiently weakened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon > 0"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseSazon > 0)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Hugo Toras: ""You have empowered the Sazons enough without granting th..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseSazon > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Hugo Toras: ""Not if the house were sufficiently weakened.""*)

### Węzeł `[176]`
Mówca: **Hugo Toras**
> ""You have empowered the Sazons enough without granting them more territory. I beg of you to be careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[177]`
Mówca: **Hugo Toras**
> ""I should say not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Hugo Toras: ""But with their heir's party holding a Delegate majority,..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Hugo Toras: ""Fortunately, you don't have to listen to their demands.""*)

### Węzeł `[181]`
Mówca: **Hugo Toras**
> ""But with their heir's party holding a Delegate majority, the house's demands will only get bolder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[182]`
Mówca: **Hugo Toras**
> ""Fortunately, you don't have to listen to their demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[183]`
Mówca: **Hugo Toras**
> ""You'll have to make this decision sooner or later, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Hugo Toras: ""Sooner, one hopes.""*)

### Węzeł `[184]`
Mówca: **Hugo Toras**
> ""Sooner, one hopes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[185]`
Mówca: **Daria de Rava**
> ""How can you say that after the Friendship Day incident? There is no telling what Wehlen will do, even if Zille is returned without a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false"*)

### Węzeł `[186]`
Mówca: **Manus Sazon**
> ""At this stage, Wehlen will not want to risk damaging our agreement. And if they do, my province can handle it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "The volume in the room grew louder as the Delegates began..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Manus Sazon: ""At this stage, Wehlen will not want to risk damaging our..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Manus Sazon: ""*If* Wehlen tries anything, my province can handle it.""*)

### Węzeł `[190]`
Mówca: **Manus Sazon**
> ""*If* Wehlen tries anything, my province can handle it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "The volume in the room grew louder as the Delegates began..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "Eventually, Manus motioned for order. The Delegates quiet..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Eventually, Daria motioned for order. The Delegates quiet..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "Eventually, Manus motioned for order. The Delegates quieted down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Manus Sazon: ""Moving on to more pressing topics...""*)

### Węzeł `[195]`
Mówca: **Narrator**
> "Eventually, Daria motioned for order. The Delegates quieted down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Daria de Rava: ""Moving on to more pressing topics...""*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia's strategy for reclaiming Zille from Wehlen is a matter of royal confidentiality and not up for debate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Daria de Rava), `[20]` (Daria de Rava), `[21]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Manus nodded, looking not entirely satisfied."*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hear your concerns. I will do what I can to put a flame to Mr. Smolak's feet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Daria de Rava), `[21]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Manus nodded, looking not entirely satisfied."*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, Mr. Sazon. I wish we lived in a world where all conflicts could be resolved peacefully. But we do not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Manus nodded, looking not entirely satisfied."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hear your concerns. But I cannot control what is happening outside Rizia's borders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Manus nodded, looking not entirely satisfied."*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I plan to work closely with the international community. Together, we can force a diplomatic handover.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Daria de Rava), `[21]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Manus nodded, looking not entirely satisfied."*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia's strategy for reclaiming Zille from Wehlen is a matter of royal confidentiality and not up for debate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Daria de Rava), `[57]` (Manus Sazon), `[58]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Daria nodded, looking not entirely satisfied."*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hear your concerns. I will do what I can to put a flame to Mr. Smolak's feet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Manus Sazon), `[58]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Daria nodded, looking not entirely satisfied."*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, Mr. Sazon. I wish we lived in a world where all conflicts could be resolved peacefully. But we do not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "Manus nodded, looking not entirely satisfied."*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I plan to work closely with the international community. Together, we can force a diplomatic handover.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Manus Sazon), `[58]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Daria nodded, looking not entirely satisfied."*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hear your concerns. But I cannot control what is happening outside Rizia's borders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "Manus nodded, looking not entirely satisfied."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "Daria nodded, looking not entirely satisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Manus put up a hand."*)

### Węzeł `[207]`
Mówca: **Narrator**
> "Manus nodded, looking not entirely satisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Manus put up a hand."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "Manus nodded, looking not entirely satisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Daria put up a hand."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player_Romus: ""I have faith that God will restore our rightful territor..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have faith that God will restore our rightful territory to us. And you should too.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[19]` (Daria de Rava), `[20]` (Daria de Rava), `[21]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Manus nodded, looking not entirely satisfied."*)

### Węzeł `[213]`
Mówca: **Manus Sazon**
> ""Moving on to more pressing topics...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[214]`
Mówca: **Daria de Rava**
> ""Moving on to more pressing topics...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
