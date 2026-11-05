# Rizia/Turn 6/ENERGY SITUATION/ENERGY SITUATION Conversation

- **ID konwersacji:** `586`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/586_ENERGY_SITUATION_Conversation.md`
- **Liczba węzłów dialogowych:** 338
- **Liczba wyborów gracza:** 10

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[80]** Elena Werner
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Policy_Economy_EnergyProtectionAct_49Percent`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Removed`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Energy_ProjectedIncome`
- `RiziaDLC.Energy_Promised`
- `RiziaDLC.MITZ_Demand_EnergyAgreement`
- `RiziaDLC.Policy_Economy_MorellaPipeline_Project`
- `RiziaDLC.Policy_RD_Economy_ConductMiningSurveys`
- `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed`
- `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project`
- `RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed`
- `RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project`
- `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed`
- `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Resources_EnergyModifiersTotal`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Situation_Economy_EnergyCrisis`
- `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1`
- `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2`
- `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option3`
- `RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Energy_ProjectedIncome`
- `RiziaDLC.Energy_Promised`
- `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1`
- `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2`
- `RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection`
- `RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[361] Rizia/Turn 6/A_CouncilMeeting** (../Turn_06/361_A_CouncilMeeting.md), Węzeł `[77]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[118]` | **""We have to deal with the energy problem immediately. What are your suggestions?""** | `[111]` **Elena Werner**: ""I have to underline the importa..."<br>`[112]` **Elena Werner**: ""I have to underline the signifi..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true  or  (Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1)`<br>`(Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1"] == true) == false` | `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Op...` | `[271]` **Elena Werner**: ""The only potential new energy s..."<br>`[293]` **Elena Werner**: ""Unfortunately, the closure of t..." |
| `[125]` | **""What is the current projection for our future energy production?""** | `[111]` **Elena Werner**: ""I have to underline the importa..."<br>`[112]` **Elena Werner**: ""I have to underline the signifi..."<br>*(oraz 8 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2"] == true) == false`<br>`(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1) == false` | `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Op...` | `[133]` **Elena Werner**: ""Fortunately, at the moment, our..."<br>`[134]` **Elena Werner**: ""At the moment, our energy deman..." |
| `[126]` | **""Thank you, Ms. Werner. I have enough information.""** | `[111]` **Elena Werner**: ""I have to underline the importa..."<br>`[112]` **Elena Werner**: ""I have to underline the signifi..."<br>*(oraz 8 innych węzłów)* | `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1) == false` | *Brak zmian stanu* | `[265]` **Elena Werner**: ""Of course, Your Majesty."" |
| `[213]` | **""In light of the current energy situation, we may need to rethink our strategy abo..."** | `[204]` **Elena Werner**: ""Unfortunately, the only project..."<br>`[205]` **Elena Werner**: ""Most importantly, there is the ..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`<br>`Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true` | *Brak zmian stanu* | `[261]` **Narrator**: "Elena looked at me questioningly." |
| `[223]` | **""What is the current situation with our extraction of gas there? I believe the Duk..."** | `[204]` **Elena Werner**: ""Unfortunately, the only project..."<br>`[205]` **Elena Werner**: ""Most importantly, there is the ..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true` | *Brak zmian stanu* | `[253]` **Elena Werner**: ""So far, we have worked in coope..." |
| `[227]` | **""And how does the estimated value fit into our current projection?""** | `[204]` **Elena Werner**: ""Unfortunately, the only project..."<br>`[205]` **Elena Werner**: ""Most importantly, there is the ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection"] == true) == false` | *Brak zmian stanu* | `[229]` **Elena Werner**: ""We own the rights to the entire..."<br>`[239]` **Elena Werner**: ""Even half of that field would g..." |
| `[228]` | **""Is the predicted gas output from Aureus enough to support our energy demands?""** | `[204]` **Elena Werner**: ""Unfortunately, the only project..."<br>`[205]` **Elena Werner**: ""Most importantly, there is the ..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection"] == true) == false` | *Brak zmian stanu* | `[229]` **Elena Werner**: ""We own the rights to the entire..."<br>`[239]` **Elena Werner**: ""Even half of that field would g..." |
| `[241]` | **""No, but in light of the current energy situation, we may need to rethink our stra..."** | `[240]` **Elena Werner**: ""Do you have any other questions..." | `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`<br>`Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true` | *Brak zmian stanu* | `[261]` **Narrator**: "Elena looked at me questioningly." |
| `[267]` | **""Do you have any suggestions on how to improve our energy situation?""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Op...` | `[271]` **Elena Werner**: ""The only potential new energy s..."<br>`[293]` **Elena Werner**: ""Unfortunately, the closure of t..." |
| `[312]` | **""That's good enough. Let's move on.""** | `[111]` **Elena Werner**: ""I have to underline the importa..."<br>`[112]` **Elena Werner**: ""I have to underline the signifi..."<br>*(oraz 8 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1"] == true  and  Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option3"] == true`<br>`(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1) == false` | *Brak zmian stanu* | `[265]` **Elena Werner**: ""Of course, Your Majesty."" |

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
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "// PROJECTED ENERGY INCOME"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "She placed a stack of papers on the table."*)

### Węzeł `[3]`
Mówca: **Elena Werner**
> ""That is correct. We are heading straight into an energy crisis and we are in need of new sources as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Hugo Toras: ""It is definitely worrying.""*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_MorellaPipeline_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_MorellaPipeline_Project == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_MorellaPipeline_Project == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_MorellaPipeline_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_MorellaPipeline_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_Promised += 3"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_MorellaPipeline_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_MorellaPipeline_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Demand_EnergyAgreement == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Demand_EnergyAgreement == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Demand_EnergyAgreement == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Demand_EnergyAgreement == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Demand_EnergyAgreement == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Demand_EnergyAgreement"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_Promised += 2"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Demand_EnergyAgreement == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Demand_EnergyAgreement"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Elena Werner: ""That is correct. We are heading straight into an energy ..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Elena Werner: ""I will start with an overview of our energy situation.""*)

### Węzeł `[13]`
Mówca: **Elena Werner**
> ""Thank you, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Proje..."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Pro..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_ProjectedIncome += 2"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "// ESQIRIS CLOSURE"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Compl..."*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Com..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "// ESQIRIS OPEN"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Proje..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// ESQIRIS CLOSURE`
- **Efekt skryptowy (`userScript`):** `-- ESQIRIS CLOSURE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Complete..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project ..."*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Projec..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_ProjectedIncome += 2"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "// NO ZPANA"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Complete..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Comple..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "// ZPANA OPEN"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project ..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// NO ZPANA`
- **Efekt skryptowy (`userScript`):** `-- NO ZPANA;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_ProjectedIncome += 1"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "// NO HAVAS"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == t..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "// HAVAS OPEN"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// NO HAVAS`
- **Efekt skryptowy (`userScript`):** `-- NO HAVAS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_ProjectedIncome += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Complete..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_ProjectedIncome += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_ProjectedIncome += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "// INVESTED IN GASOM WITH SORDLAND"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "// SORDLAND DIDNT LET US INVEST IN GASOM"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "// INVESTED IN GASOM"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// INVESTED IN GASOM`
- **Efekt skryptowy (`userScript`):** `-- INVESTED IN GASOM;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_ProjectedIncome += 2"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// INVESTED IN GASOM WITH SORDLAND`
- **Efekt skryptowy (`userScript`):** `-- INVESTED IN GASOM WITH SORDLAND;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_ProjectedIncome += 2"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// SORDLAND DIDNT LET US INVEST IN GASOM`
- **Efekt skryptowy (`userScript`):** `-- SORDLAND DIDNT LET US INVEST IN GASOM;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "// PROJECTED ENERGY INCOME ENDS"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_ProjectedIncome += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "// PROJECTED ENERGY INCOME ENDS"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_ProjectedIncome += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "// PROJECTED ENERGY INCOME ENDS"*)

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""It is definitely worrying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Elena Werner: ""But perhaps, we should start with an overview of our sit..."*)

### Węzeł `[50]`
Mówca: **Elena Werner**
> ""But perhaps, we should start with an overview of our situation first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal < 0"*)

### Węzeł `[51]`
Mówca: **Elena Werner**
> ""I will start with an overview of our energy situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal < 0"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal > 0"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_EnergyModifiersTotal > 0)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Elena Werner: ""Luckily, we are still producing enough energy to meet ou..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_EnergyModifiersTotal > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Elena Werner: ""We are not producing enough energy to keep up with the d..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy <= 0"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy <= 0)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Elena Werner: ""Our entire energy stockpile has been exhausted. We curre..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal > 0"*)

### Węzeł `[58]`
Mówca: **Elena Werner**
> ""Our entire energy stockpile has been exhausted. We currently have no extra energy to spare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Elena Werner: ""Everything is working to its limit and the situation can..."*)

### Węzeł `[59]`
Mówca: **Elena Werner**
> ""Everything is working to its limit and the situation can become alarming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal > 0"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resou..."*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Res..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Elena Werner: ""We are rapidly exhausting all of our energy stockpile.""*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy <= 0"*)

### Węzeł `[63]`
Mówca: **Elena Werner**
> ""We are rapidly exhausting all of our energy stockpile.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Elena Werner: ""If nothing's done to reverse the situation, we may end u..."*)

### Węzeł `[64]`
Mówca: **Elena Werner**
> ""If nothing's done to reverse the situation, we may end up in a destructive situation for Rizian industries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy >= 5"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy >= 5"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy >= 5)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Elena Werner: ""Despite our high energy reserves, our current consumptio..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy >= 3"*)

### Węzeł `[68]`
Mówca: **Elena Werner**
> ""Despite our high energy reserves, our current consumption rate will deplete them in no time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "She placed a stack of papers on the table."*)

### Węzeł `[69]`
Mówca: **Elena Werner**
> ""The current size of our reserves is not at a desirable level. Our current consumption rate can deplete them in little time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "She placed a stack of papers on the table."*)

### Węzeł `[70]`
Mówca: **Elena Werner**
> ""Luckily, we are still producing enough energy to meet our demands and stay above the balance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "She placed a stack of papers on the table."*)

### Węzeł `[71]`
Mówca: **Elena Werner**
> ""We are not producing enough energy to keep up with the demand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Elena Werner: ""If this continues, our industries and the whole of our e..."*)

### Węzeł `[72]`
Mówca: **Elena Werner**
> ""If this continues, our industries and the whole of our economy will suffer immensely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "She placed a stack of papers on the table."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_Ene..."*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_E..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Elena Werner: ""What's worse is that our current projection for the futu..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Elena Werner: ""The good news is that our current projection for the fut..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "She placed a stack of papers on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_Ene..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "She placed a stack of papers on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_Ene..."*)

### Węzeł `[78]`
Mówca: **Elena Werner**
> ""What's worse is that our current projection for the future doesn't look any better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Elena Werner: ""Based on our current deals and promises, including our p..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_Ene..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_E..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Elena Werner: ""But there is a problem. Our current projection for the f..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Elena Werner: ""Based on our current deals and promises, including our p..."*)

### Węzeł `[82]`
Mówca: **Elena Werner**
> ""But there is a problem. Our current projection for the future doesn't look good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Elena Werner: ""Based on our current deals and promises, including our p..."*)

### Węzeł `[83]`
Mówca: **Elena Werner**
> ""Based on our current deals and promises, including our projected energy production, we won't be able to meet the demand of our industries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_Promised >= 1"*)

### Węzeł `[84]`
Mówca: **Elena Werner**
> ""Based on our current deals and promises, including our projected energy production, we will be able to meet the demand of our industries -- if our current projects succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resou..."*)

### Węzeł `[85]`
Mówca: **Elena Werner**
> ""The good news is that our current projection for the future is still promising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Elena Werner: ""Based on our current deals and promises, including our p..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_Promised += 3`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Energy_Promised"] = Variable["RiziaDLC.Energy_Promised"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Demand_EnergyAgreement == true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_Promised += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Energy_Promised"] = Variable["RiziaDLC.Energy_Promised"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == ..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == ..."*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_49Percent =..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_49Percent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_49Percent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "// NO GASOM GAINS"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "// INVESTED IN GASOM WITH SORDLAND"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "// SORDLAND DIDNT LET US INVEST IN GASOM"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "// INVESTED IN GASOM"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// INVESTED IN GASOM`
- **Efekt skryptowy (`userScript`):** `-- INVESTED IN GASOM;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_ProjectedIncome += 1"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// INVESTED IN GASOM WITH SORDLAND`
- **Efekt skryptowy (`userScript`):** `-- INVESTED IN GASOM WITH SORDLAND;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_ProjectedIncome += 1"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// SORDLAND DIDNT LET US INVEST IN GASOM`
- **Efekt skryptowy (`userScript`):** `-- SORDLAND DIDNT LET US INVEST IN GASOM;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "// PROJECTED ENERGY INCOME ENDS"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_ProjectedIncome += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "// PROJECTED ENERGY INCOME ENDS"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_ProjectedIncome += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "// PROJECTED ENERGY INCOME ENDS"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_Promised >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_Promised >= 1"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Energy_Promised >= 1)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_Promised >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Energy_Promised"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Elena Werner: ""I have to underline the significance of this. If we cann..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Energy_Promised >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Energy_Promised"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_ProjectedIncome >= 1"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resou..."*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Res..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Elena Werner: ""I have to underline the importance of this. We cannot af..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "Hub_EnergyProjection"*)

### Węzeł `[111]`
Mówca: **Elena Werner**
> ""I have to underline the importance of this. We cannot afford to fail our energy projects -- if we want to meet the demands of our industries and our international partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "Hub_EnergyProjection"*)

### Węzeł `[112]`
Mówca: **Elena Werner**
> ""I have to underline the significance of this. If we cannot find new sources of energy -- we will not be able to meet the demands of our industries and our international partners at the same time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "Hub_EnergyProjection"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_ProjectedIncome >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_ProjectedIncome >= 1"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Energy_ProjectedIncome >= 1)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_ProjectedIncome >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Elena Werner: ""I have to underline the significance of this. The projec..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Energy_ProjectedIncome >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Elena Werner: ""I have to underline the significance of this. If we cann..."*)

### Węzeł `[116]`
Mówca: **Elena Werner**
> ""I have to underline the significance of this. The projected energy production from our current projects are not enough to meet the demands of our industries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "Hub_EnergyProjection"*)

### Węzeł `[117]`
Mówca: **Elena Werner**
> ""I have to underline the significance of this. If we cannot find new sources of energy, we may reach a point of no return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "Hub_EnergyProjection"*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have to deal with the energy problem immediately. What are your suggestions?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true  or  (Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1)` AND `(Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[111]` (Elena Werner), `[112]` (Elena Werner), `[116]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 = true"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true || (RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true || (Rizia..."*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true || (Riz..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true || (RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true  or  (Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player_Romus: ""We have to deal with the energy problem immediately. Wha..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true || (RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resources_Energy * -1))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true  or  (Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_Ene..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_Ene..."*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_E..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player_Romus: ""We have to deal with the energy problem immediately. Wha..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player_Romus: ""Do you have any suggestions on how to improve our energy..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is the current projection for our future energy production?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2"] == true) == false` AND `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Kontekst wejściowy (poprzednik):** `[111]` (Elena Werner), `[112]` (Elena Werner), `[116]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 = true"*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Ms. Werner. I have enough information.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Kontekst wejściowy (poprzednik):** `[111]` (Elena Werner), `[112]` (Elena Werner), `[116]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Elena Werner: ""Of course, Your Majesty.""*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_ProjectedIncome >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_ProjectedIncome >= 1"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Energy_ProjectedIncome >= 1)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_ProjectedIncome >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Proje..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Energy_ProjectedIncome >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Elena Werner: ""...But unfortunately we don't have any ongoing projects ..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal > 0"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_EnergyModifiersTotal > 0)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Elena Werner: ""Fortunately, at the moment, our energy demands are being..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_EnergyModifiersTotal > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Elena Werner: ""At the moment, our energy demands are not being met...""*)

### Węzeł `[133]`
Mówca: **Elena Werner**
> ""Fortunately, at the moment, our energy demands are being met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_ProjectedIncome >= 1"*)

### Węzeł `[134]`
Mówca: **Elena Werner**
> ""At the moment, our energy demands are not being met...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_ProjectedIncome >= 1"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_ProjectedIncome >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_ProjectedIncome >= 1"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Energy_ProjectedIncome >= 1)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_ProjectedIncome >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Elena Werner: ""...Fortunately, we have additional projects that we're p..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Energy_ProjectedIncome >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Elena Werner: ""...And unfortunately we don't have any ongoing projects ..."*)

### Węzeł `[138]`
Mówca: **Elena Werner**
> ""...And unfortunately we don't have any ongoing projects or deals that will result in more energy output.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)

### Węzeł `[139]`
Mówca: **Elena Werner**
> ""Since there are no active projects, our prediction is that our energy output will stay stagnant in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[140]`
Mówca: **Elena Werner**
> ""...But unfortunately we don't have any ongoing projects or deals that will result in more energy output.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)

### Węzeł `[141]`
Mówca: **Elena Werner**
> ""...But we have additional projects that we're predicting more energy returns from.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Compl..."*)

### Węzeł `[142]`
Mówca: **Elena Werner**
> ""...Fortunately, we have additional projects that we're predicting some energy returns from.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Compl..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Proje..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Pro..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Elena Werner: ""Thanks to Your Majesty's decision to expand the Esqiris ..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "// ESQIRIS CLOSURE"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Compl..."*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Com..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Complete..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Proje..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// ESQIRIS CLOSURE`
- **Efekt skryptowy (`userScript`):** `-- ESQIRIS CLOSURE;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Complete..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project ..."*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Projec..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Elena Werner: ""The Zpana Hydroelectric Dam Project is continuing with s..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "// NO ZPANA"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Complete..."*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Comple..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project ..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// NO ZPANA`
- **Efekt skryptowy (`userScript`):** `-- NO ZPANA;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Elena Werner: ""Although not much by itself, the ongoing Havas Coal Mine..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "// NO HAVAS"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == t..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// NO HAVAS`
- **Efekt skryptowy (`userScript`):** `-- NO HAVAS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Elena Werner: ""Thanks to President Rayne's removal of their laws that p..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Elena Werner: ""Thanks to President Rayne's changes to their laws that p..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal < 0"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_EnergyModifiersTotal < 0)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_EnergyModifiersTotal < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Elena Werner: ""We are rapidly exhausting all of our energy stockpile.""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_EnergyModifiersTotal < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal <= RiziaDLC.Resou..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Elena Werner: ""Our negotiations with Sordland about the Gasom deal also..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Elena Werner: ""Since there are no active projects, our prediction is th..."*)

### Węzeł `[173]`
Mówca: **Elena Werner**
> ""Our negotiations with Sordland about the Gasom deal also fell flat. The new Sordish president decided not to allow us to invest. So there's no projected income from there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Elena Werner: ""Since there are no active projects, our prediction is th..."*)

### Węzeł `[174]`
Mówca: **Elena Werner**
> ""Thanks to Your Majesty's decision to expand the Esqiris Gas Field, our facilities in Esqiris will be able to continue their production with no problems -- and with a higher output than before when it is finished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Complete..."*)

### Węzeł `[175]`
Mówca: **Elena Werner**
> ""The Zpana Hydroelectric Dam Project is continuing with speed. If it succeeds, our projection is that it will provide some relief for our energy industry. As a renewable alternative, it will provide a strategic value for us as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true"*)

### Węzeł `[176]`
Mówca: **Elena Werner**
> ""Although not much by itself, the ongoing Havas Coal Mine Project is projected to bring a little relief to our energy situation when it starts working.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Proje..."*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Pro..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Elena Werner: ""...But we have additional projects that we're predicting..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Elena Werner: ""...But we may still have additional opportunities that w..."*)

### Węzeł `[180]`
Mówca: **Elena Werner**
> ""...But we may still have additional opportunities that we may get more energy returns from.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "// NO PROJECTION OF GASOM"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == tr..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == tr..."*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_49Percent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Elena Werner: ""Firstly, I want to talk about our deal with Gasom, the S..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_49Percent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "// NO PROJECTION OF GASOM"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// NO PROJECTION OF GASOM`
- **Efekt skryptowy (`userScript`):** `-- NO PROJECTION OF GASOM;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Elena Werner: ""Unfortunately, the only projection we can currently make..."*)

### Węzeł `[188]`
Mówca: **Elena Werner**
> ""Firstly, I want to talk about our deal with Gasom, the Sordish gas giant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "// NO PROJECTION OF GASOM"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == tr..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == tr..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_49Percent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Elena Werner: ""Additionally, there is our deal with Gasom, the Sordish ..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Economy_EnergyProtectionAct_49Percent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_49Percent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Elena Werner: ""Additionally, there was our deal with Gasom, the Sordish..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// NO PROJECTION OF GASOM`
- **Efekt skryptowy (`userScript`):** `-- NO PROJECTION OF GASOM;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Elena Werner: ""Most importantly, there is the issue with the disputed A..."*)

### Węzeł `[196]`
Mówca: **Elena Werner**
> ""Additionally, there is our deal with Gasom, the Sordish gas giant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[197]`
Mówca: **Elena Werner**
> ""Thanks to President Rayne's removal of their laws that previously limited foreign investment, we were able to obtain the majority of the shares together with Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Elena Werner: ""Therefore, we would be able to execute our original plan..."*)

### Węzeł `[198]`
Mówca: **Elena Werner**
> ""Thanks to President Rayne's changes to their laws that previously limited foreign investment, we were able to obtain a good portion of their company together with Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Elena Werner: ""Although we may not be able to execute our original plan..."*)

### Węzeł `[199]`
Mówca: **Elena Werner**
> ""Additionally, there was our deal with Gasom, the Sordish gas giant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Elena Werner: ""Unfortunately, the Sordish Energy Protection Act serious..."*)

### Węzeł `[200]`
Mówca: **Elena Werner**
> ""Unfortunately, the Sordish Energy Protection Act seriously limits foreign investment, so we weren't able to obtain the amount of shares we wanted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Elena Werner: ""Although it could still provide us with some finances, w..."*)

### Węzeł `[201]`
Mówca: **Elena Werner**
> ""Although it could still provide us with some finances, we are not expecting too much from that deal in terms of energy output.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[202]`
Mówca: **Elena Werner**
> ""Therefore, we would be able to execute our original plan and divert some of the Sordish gas to Rizia. It is expected that the returns can provide some relief for our energy production.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[203]`
Mówca: **Elena Werner**
> ""Although we may not be able to execute our original plan and divert most of the Sordish gas to Rizia, it is still expected that the returns may provide a little relief for our energy production.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[204]`
Mówca: **Elena Werner**
> ""Unfortunately, the only projection we can currently make is about the disputed Aureus Gas Field. Therefore, it is of immense value to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[205]`
Mówca: **Elena Werner**
> ""Most importantly, there is the issue with the disputed Aureus Gas Field. The predicted gas output from that field is of immense value.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[206]`
Mówca: **Elena Werner**
> ""And finally, there is the disputed Aureus Gas Field. The predicted gas output from that field is of immense value.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "She took a look at her notes."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Elena Werner: ""There is, of course, the disputed Aureus Gas Field. The ..."*)

### Węzeł `[209]`
Mówca: **Elena Werner**
> ""There is, of course, the disputed Aureus Gas Field. The predicted gas output from that field is of immense value.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Elena Werner: ""But with our current situation, we won't be able to reap..."*)

### Węzeł `[210]`
Mówca: **Elena Werner**
> ""But with our current situation, we won't be able to reap much benefits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[211]`
Mówca: **Narrator**
> "She took a look at her notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Elena Werner: ""And finally, there is the disputed Aureus Gas Field. The..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[227]` (*Player_Romus: ""And how does the estimated value fit into our current pr..."*)
  - -> `[228]` (*Player_Romus: ""Is the predicted gas output from Aureus enough to suppor..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In light of the current energy situation, we may need to rethink our strategy about the field. We cannot allow Lespia or Pales to take it from us.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false` AND `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Kontekst wejściowy (poprzednik):** `[204]` (Elena Werner), `[205]` (Elena Werner), `[206]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "Elena looked at me questioningly."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_Ene..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_Ene..."*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_E..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player_Romus: ""In light of the current energy situation, we may need to..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is the current situation with our extraction of gas there? I believe the Duke is respecting our purchase deal?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Kontekst wejściowy (poprzednik):** `[204]` (Elena Werner), `[205]` (Elena Werner), `[206]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Elena Werner: ""So far, we have worked in cooperation to prepare our sid..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player_Romus: ""What is the current situation with our extraction of gas..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how does the estimated value fit into our current projection?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[204]` (Elena Werner), `[205]` (Elena Werner), `[206]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is the predicted gas output from Aureus enough to support our energy demands?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[204]` (Elena Werner), `[205]` (Elena Werner), `[206]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[229]`
Mówca: **Elena Werner**
> ""We own the rights to the entire field. That's enough energy to supply us for decades to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Elena Werner: ""Now that preliminary drilling is almost complete, I am c..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Elena Werner: ""We own the rights to the entire field. That's enough ene..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Elena Werner: ""Even half of that field would grant us immense relief fr..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Elena Werner: ""But we can get into the details of that in a second. I b..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Elena Werner: ""But unfortunately, given the concessions we made to the ..."*)

### Węzeł `[236]`
Mówca: **Elena Werner**
> ""Now that preliminary drilling is almost complete, I am confident that we will be reaping the benefits sooner than later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProje..."*)

### Węzeł `[237]`
Mówca: **Elena Werner**
> ""But unfortunately, given the concessions we made to the Duke of Pales, any energy we'll receive from the field will be of negligible importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProje..."*)

### Węzeł `[238]`
Mówca: **Elena Werner**
> ""But we can get into the details of that in a second. I believe Mr. Esquibel has some news from the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProje..."*)

### Węzeł `[239]`
Mówca: **Elena Werner**
> ""Even half of that field would grant us immense relief from our energy woes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[240]`
Mówca: **Elena Werner**
> ""Do you have any other questions, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hub_EnergyProjection]"*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, but in light of the current energy situation, we may need to rethink our strategy about the field. We cannot allow Lespia or Pales to take it from us.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false` AND `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Kontekst wejściowy (poprzednik):** `[240]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "Elena looked at me questioningly."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_Ene..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_Ene..."*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_E..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Energy_ProjectedIncome + RiziaDLC.Resources_EnergyModifiersTotal - RiziaDLC.Energy_Promised) <= 
RiziaDLC.Resources_Energy * -1)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Energy_ProjectedIncome"] + Variable["RiziaDLC.Resources_EnergyModifiersTotal"] - Variable["RiziaDLC.Energy_Promised"]) <= 
Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == false"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player_Romus: ""No, but in light of the current energy situation, we may..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Hub_EnergyProjection`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == true"*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 == true"*)
  - -> `[126]` (*Player_Romus: ""Thank you, Ms. Werner. I have enough information.""*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == t..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hub_EnergyProjection]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "Hub_EnergyProjection"*)

### Węzeł `[253]`
Mówca: **Elena Werner**
> ""So far, we have worked in cooperation to prepare our side of the field for extraction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Elena Werner: ""As negotiated with Duke Reinhart, the entire rights will..."*)

### Węzeł `[254]`
Mówca: **Elena Werner**
> ""As negotiated with Duke Reinhart, the entire rights will be officially transferred to us after we sign the official treaty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProje..."*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hub_EnergyProjection]"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProje..."*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusPro..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "Jump to: [Player_Romus: ""Is the predicted gas output fro..."*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "Jump to: [Player_Romus: ""And how does the estimated valu..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_CouncilMeeting_Energy_AureusProjection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Elena Werner: ""Do you have any other questions, Your Majesty?""*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Player_Romus: ""And how does the estimated value f..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player_Romus: ""And how does the estimated value fit into our current pr..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Player_Romus: ""Is the predicted gas output from A..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player_Romus: ""Is the predicted gas output from Aureus enough to suppor..."*)

### Węzeł `[261]`
Mówca: **Narrator**
> "Elena looked at me questioningly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Hugo Toras: ""I fully agree with His Majesty.""*)

### Węzeł `[262]`
Mówca: **Hugo Toras**
> ""I fully agree with His Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive = true"*)

### Węzeł `[263]`
Mówca: **Hugo Toras**
> ""But perhaps we should first talk about the news from Pales, if we're done with the energy overview.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Elena Werner: ""Of course. Did you have any other questions about our en..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Intention_Pales_Aggressive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Hugo Toras: ""But perhaps we should first talk about the news from Pal..."*)

### Węzeł `[265]`
Mówca: **Elena Werner**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "She bowed in respect."*)

### Węzeł `[266]`
Mówca: **Narrator**
> "She bowed in respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you have any suggestions on how to improve our energy situation?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 = true"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true) && (RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Complet..."*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Compl..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true) && (RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true)  and  (Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Elena Werner: ""The only potential new energy source on the horizon is t..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true) && (RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true)  and  (Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Compl..."*)

### Węzeł `[271]`
Mówca: **Elena Werner**
> ""The only potential new energy source on the horizon is the Aureus gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Elena Werner: ""Therefore, it is very important that we sign the officia..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[275]`
Mówca: **Elena Werner**
> ""Therefore, it is very important that we sign the official treaty as soon as possible and make our purchase recognized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "Laurento nodded."*)

### Węzeł `[276]`
Mówca: **Elena Werner**
> ""I believe Mr. Esquibel has some news to share about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "Laurento nodded."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Elena Werner: ""I believe Mr. Esquibel has some news to share about that.""*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Elena Werner: ""But of course, we're ceding our claim to it, so there's ..."*)

### Węzeł `[280]`
Mówca: **Elena Werner**
> ""But of course, we're ceding our claim to it, so there's not much space for movement there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Laurento Esquibel: ""We can always negotiate better deals and import energy f..."*)

### Węzeł `[281]`
Mówca: **Laurento Esquibel**
> ""We can always negotiate better deals and import energy from our partners when necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hub_EnergyProjection]"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hub_EnergyProjection]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "Hub_EnergyProjection"*)

### Węzeł `[283]`
Mówca: **Narrator**
> "Laurento nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hub_EnergyProjection]"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true || RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Compl..."*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Com..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true || RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Complete..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true || RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Elena Werner: ""Unfortunately, the closure of the Esqiris Gas Field was ..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Complete..."*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Comple..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == false"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Elena Werner: ""One suggestion I have is to sign the plans for the Zpana..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true ..."*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == tru..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Elena Werner: ""And then there's the Aureus gas field...""*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true || RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Elena Werner: ""I wouldn't say coal is a long-term energy solution, but ..."*)

### Węzeł `[293]`
Mówca: **Elena Werner**
> ""Unfortunately, the closure of the Esqiris Gas Field was a huge blow for our energy production. We have to find new sources to replace it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Complete..."*)

### Węzeł `[294]`
Mówca: **Elena Werner**
> ""One suggestion I have is to sign the plans for the Zpana Hydroelectic Dam. Not only will it provide some relief for our energy industry, it has strategic value as a renewable alternative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == false"*)

### Węzeł `[295]`
Mówca: **Elena Werner**
> ""I wouldn't say coal is a long-term energy solution, but constructing a new mine in Havas would help us out to some degree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Elena Werner: ""And then there's the Aureus gas field...""*)

### Węzeł `[296]`
Mówca: **Elena Werner**
> ""Vast stretches of Rizia remain unexplored where resources are concerned. Commissioning a mining survey could uncover their potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Elena Werner: ""Experts say we could have untapped coal deposits in the ..."*)

### Węzeł `[297]`
Mówca: **Elena Werner**
> ""And then there's the Aureus gas field...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Complet..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_EnergyModifiersTotal > 0"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 == true"*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 ==..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player_Romus: ""What is the current projection for our future energy pro..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == true"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 ==..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true || (Rizia..."*)

### Węzeł `[306]`
Mówca: **Elena Werner**
> ""Of course. Did you have any other questions about our energy situation, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "Jump to: [Hub_EnergyProjection]"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hub_EnergyProjection]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "Hub_EnergyProjection"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Hub_EnergyProjection]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "Hub_EnergyProjection"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == true && RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 == true &&
RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == t..."*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 ==..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == true && RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 == true &&
RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1"] == true  and  Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Player_Romus: ""That's good enough. Let's move on.""*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1 == true && RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2 == true &&
RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1"] == true  and  Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option3"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's good enough. Let's move on.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option1"] == true  and  Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option2"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Hub_EnergyProjection_Option3"] == true` AND `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= Variable["RiziaDLC.Resources_Energy"] * -1) == false`
- **Kontekst wejściowy (poprzednik):** `[111]` (Elena Werner), `[112]` (Elena Werner), `[116]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Elena Werner: ""Of course, Your Majesty.""*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// ESQIRIS OPEN`
- **Efekt skryptowy (`userScript`):** `-- ESQIRIS OPEN;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Complete..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// ZPANA OPEN`
- **Efekt skryptowy (`userScript`):** `-- ZPANA OPEN;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_HavasCoalMine_Completed == true"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// HAVAS OPEN`
- **Efekt skryptowy (`userScript`):** `-- HAVAS OPEN;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// PROJECTED ENERGY INCOME ENDS`
- **Efekt skryptowy (`userScript`):** `-- PROJECTED ENERGY INCOME ENDS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "// PROMISED ENERGY EXPORTS"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// PROJECTED ENERGY INCOME`
- **Efekt skryptowy (`userScript`):** `-- PROJECTED ENERGY INCOME;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// PROMISED ENERGY EXPORTS`
- **Efekt skryptowy (`userScript`):** `-- PROMISED ENERGY EXPORTS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_MorellaPipeline_Project == true"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// NO GASOM GAINS`
- **Efekt skryptowy (`userScript`):** `-- NO GASOM GAINS;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "// PROJECTED ENERGY INCOME ENDS"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Energy_ProjectedIncome += 4"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Compl..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Energy_ProjectedIncome += 4`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Energy_ProjectedIncome"] = Variable["RiziaDLC.Energy_ProjectedIncome"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Compl..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Elena Werner: ""Thank you, Your Grace.""*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy >= 3"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy >= 3)"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Elena Werner: ""The current size of our reserves is not at a desirable l..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy >= 1"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy >= 1"*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy >= 1)"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Elena Werner: ""The current size of our reserves is already very troubli..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Elena Werner: ""The energy reserves already depleted and we are struggli..."*)

### Węzeł `[331]`
Mówca: **Elena Werner**
> ""The current size of our reserves is already very troubling. Our current consumption rate will deplete them in no time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "She placed a stack of papers on the table."*)

### Węzeł `[332]`
Mówca: **Elena Werner**
> ""The energy reserves already depleted and we are struggling to find new reserves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Elena Werner: ""We are fearing significant blackouts or other issues tha..."*)

### Węzeł `[333]`
Mówca: **Elena Werner**
> ""We are fearing significant blackouts or other issues that might arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "She placed a stack of papers on the table."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == false"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == false)"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ConductMiningSurveys"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Elena Werner: ""Vast stretches of Rizia remain unexplored where resource..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ConductMiningSurveys"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_HavasCoalMine_Project == true ..."*)

### Węzeł `[337]`
Mówca: **Elena Werner**
> ""Experts say we could have untapped coal deposits in the south, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Elena Werner: ""And then there's the Aureus gas field...""*)
