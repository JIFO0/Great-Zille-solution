# Sordland/Turn08/FPnT_LespiaVisit

- **ID konwersacji:** `154`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/154_FPnT_LespiaVisit.md`
- **Liczba węzłów dialogowych:** 80
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_CapitalistRayne`
- `BaseGame.Decision_Turn04_GruniRuralDev_NoFunding`
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn04_RegionalInvestment_Lorren`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.Decision_Turn06_Megaproject_Benfi`
- `BaseGame.EconomicDirection_Nationalization`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Lespia_SoldSordishPetroleum`
- `BaseGame.Lespia_TradeDeal`
- `BaseGame.TradeDeal_Negotiation_Valgsland`
- `BaseGame.Valgsland_Alliance`
- `BaseGame.Valgsland_TradeDeal`
- `BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Capitalist`
- `BaseGame.Economy_Agnland`
- `BaseGame.Economy_Bergia`
- `BaseGame.Economy_Gruni`
- `BaseGame.Economy_Lorren`
- `BaseGame.Policy_Diplomacy_Lespia_Alliance`
- `BaseGame.Policy_Diplomacy_Neutrality`
- `BaseGame.Policy_Diplomacy_TradeInitiative`
- `BaseGame.Policy_Diplomacy_TradeZone_Lespia`
- `BaseGame.Policy_Military_JointMilitaryExercises`
- `BaseGame.Situation_Diplomacy_DiplomaticPressure`
- `BaseGame.Situation_Diplomacy_FTZLespia`
- `BaseGame.Situation_Diplomacy_FailedTradeNegotiation`
- `BaseGame.Situation_Diplomacy_LackOfAllies`
- `BaseGame.Situation_Diplomacy_Lespia_Coal_Trade`
- `BaseGame.Situation_Diplomacy_Lespia_Fish_Trade`
- `BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum`
- `BaseGame.Situation_Diplomacy_Lespia_Tungsten_Trade`
- `BaseGame.Situation_Diplomacy_Lespia_Wheat_Trade`
- `BaseGame.Situation_Diplomacy_ValgslandTradeTariffs`
- `BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil`
- `BaseGame.Sollist`
- `BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne`
- `BaseGameSupport.FactionReport_Turn08_CSP_CondemnsLespiaAlliance`
- `BaseGameSupport.Journal_Turn08_LespiaVisit_Cancelled`
- `BaseGameSupport.News_Turn08_G_Lespia_Cancelled_Visit`
- `BaseGameSupport.News_Turn08_HP_Sordland_Lespia_New_Trade`
- `GameCondition.Turn08_FPnT_LespiaVisit`

### Skoki między-konwersacyjne:
- Węzeł `[9]` -> **[158] Sordland/Turn08/LespiaVisit_TalkWithSymon** (../Turn_08/158_LespiaVisit_TalkWithSymon.md), Węzeł `[1]`
- Węzeł `[10]` -> **[158] Sordland/Turn08/LespiaVisit_TalkWithSymon** (../Turn_08/158_LespiaVisit_TalkWithSymon.md), Węzeł `[1]`
- Węzeł `[12]` -> **[155] Sordland/Turn08/LespiaVisit_NeutralOrCapitalistRayne** (../Turn_08/155_LespiaVisit_NeutralOrCapitalistRayne.md), Węzeł `[1]`
- Węzeł `[15]` -> **[156] Sordland/Turn08/LespiaVisit_AntiCapitalistRayne** (../Turn_08/156_LespiaVisit_AntiCapitalistRayne.md), Węzeł `[1]`
- Węzeł `[16]` -> **[155] Sordland/Turn08/LespiaVisit_NeutralOrCapitalistRayne** (../Turn_08/155_LespiaVisit_NeutralOrCapitalistRayne.md), Węzeł `[1]`
- Węzeł `[20]` -> **[157] Sordland/Turn08/LespiaVisit_TradeDealCancelled** (../Turn_08/157_LespiaVisit_TradeDealCancelled.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 31

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy_Agnland`
- `BaseGame.Economy_Bergia`
- `BaseGame.Economy_Gruni`
- `BaseGame.Economy_Lorren`
- `BaseGame.Sollist`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Symon Holl): `Variable["GameCondition.Turn08_FPnT_LespiaVisit"] = true;`
- Węzeł `[10]` (Symon Holl): `Variable["BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne"] = true;`
- Węzeł `[20]` (Symon Holl): `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_Cancelled"] = true;`
- Węzeł `[24]` (Symon Holl): `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 2; Variable["BaseGame.Sollist...`
- Węzeł `[25]` (Symon Holl): `-- continue;`
- Węzeł `[29]` (Symon Holl): `Variable["BaseGameSupport.FactionReport_Turn08_CSP_CondemnsLespiaAlliance"] = true;`
- Węzeł `[30]` (Symon Holl): `Variable["BaseGameSupport.News_Turn08_HP_Sordland_Lespia_New_Trade"] = true;`
- Węzeł `[31]` (Symon Holl): `Variable["BaseGameSupport.News_Turn08_G_Lespia_Cancelled_Visit"] = true;`
- *...oraz 23 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_FPnT_LespiaVisit = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_FPnT_LespiaVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[4]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal == false && BaseGame.Valgsland_Alliance == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal == false && BaseGame.Valgsland_Alliance == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_TradeDeal"] == false  and  Variable["BaseGame.Valgsland_Alliance"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_TradeDeal == false && BaseGame.Valgsland_Alliance == false ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_TradeDeal"] == false  and  Variable["BaseGame.Valgsland_Alliance"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[7]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.EconomicDirection_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.EconomicDirection_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.EconomicDirection_Nationalization == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `158` (*Sordland/Turn08/LespiaVisit_TalkWithSymon*), Węzeł `[1]`

### Węzeł `[10]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `158` (*Sordland/Turn08/LespiaVisit_TalkWithSymon*), Węzeł `[1]`

### Węzeł `[11]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_CapitalistRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_CapitalistRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `155` (*Sordland/Turn08/LespiaVisit_NeutralOrCapitalistRayne*), Węzeł `[1]`

### Węzeł `[13]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_CapitalistRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `156` (*Sordland/Turn08/LespiaVisit_AntiCapitalistRayne*), Węzeł `[1]`

### Węzeł `[16]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `155` (*Sordland/Turn08/LespiaVisit_NeutralOrCapitalistRayne*), Węzeł `[1]`

### Węzeł `[17]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.TradeDeal_Negotiation_Valgsland == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.TradeDeal_Negotiation_Valgsland == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[19]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.TradeDeal_Negotiation_Valgsland == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[20]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_LespiaVisit_Cancelled = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_Cancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `157` (*Sordland/Turn08/LespiaVisit_TradeDealCancelled*), Węzeł `[1]`

### Węzeł `[21]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[24]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist += 2;
BaseGame.Sollist -= 2;
BaseGame.Policy_Military_JointMilitaryExercises = true;
BaseGame.Situation_Diplomacy_DiplomaticPressure = false;
BaseGame.Policy_Diplomacy_Lespia_Alliance = true;
BaseGame.Policy_Diplomacy_Neutrality = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;
Variable["BaseGame.Policy_Military_JointMilitaryExercises"] = true;
Variable["BaseGame.Situation_Diplomacy_DiplomaticPressure"] = false;
Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] = true;
Variable["BaseGame.Policy_Diplomacy_Neutrality"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[25]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[26]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[29]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.FactionReport_Turn08_CSP_CondemnsLespiaAlliance = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn08_CSP_CondemnsLespiaAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[30]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_Sordland_Lespia_New_Trade = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_Sordland_Lespia_New_Trade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[31]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_G_Lespia_Cancelled_Visit = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_G_Lespia_Cancelled_Visit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[32]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_TradeZone_Lespia = true;
BaseGame.Policy_Diplomacy_TradeInitiative = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_TradeZone_Lespia"] = true;
Variable["BaseGame.Policy_Diplomacy_TradeInitiative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_FTZLespia = true;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_FTZLespia"] = true;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[34]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[36]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[37]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[39]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[43]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Lespia_Tungsten_Trade = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_Tungsten_Trade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[44]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Lespia_Wheat_Trade = true;
BaseGame.Economy_Bergia += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_Wheat_Trade"] = true;
Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[45]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Lespia_Fish_Trade = true;
BaseGame.Economy_Agnland += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_Fish_Trade"] = true;
Variable["BaseGame.Economy_Agnland"] = Variable["BaseGame.Economy_Agnland"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[46]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Lespia_Coal_Trade = true;
BaseGame.Economy_Lorren += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_Coal_Trade"] = true;
Variable["BaseGame.Economy_Lorren"] = Variable["BaseGame.Economy_Lorren"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[47]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[49]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[50]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_SoldSordishPetroleum == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_SoldSordishPetroleum == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_SoldSordishPetroleum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_SoldSordishPetroleum == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_SoldSordishPetroleum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[53]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum = true;
BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] = true;
Variable["BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[54]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[56]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[58]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[59]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Lespia_Alliance = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_ValgslandTradeTariffs = true;
BaseGame.Situation_Diplomacy_LackOfAllies = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_ValgslandTradeTariffs"] = true;
Variable["BaseGame.Situation_Diplomacy_LackOfAllies"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[61]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[62]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_TradeDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_TradeDeal == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_TradeDeal"] == false  and  Variable["BaseGame.Lespia_TradeDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_TradeDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_TradeDeal"] == false  and  Variable["BaseGame.Lespia_TradeDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[66]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_FailedTradeNegotiation = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[67]`
Mówca: **Narrator**
> "I returned to Holsord with good news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[68]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_LackOfAllies = false;
BaseGame.Situation_Diplomacy_ValgslandTradeTariffs = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_LackOfAllies"] = false;
Variable["BaseGame.Situation_Diplomacy_ValgslandTradeTariffs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[69]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false || BaseGame.Decision_Turn06_Megaproject_Benfi == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false || BaseGame.Decision_Turn06_Megaproject_Benfi == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_GruniRuralDev_NoFunding"] == false  or  Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false || BaseGame.Decision_Turn06_Megaproject_Benfi == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_GruniRuralDev_NoFunding"] == false  or  Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[72]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Gruni += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Gruni"] = Variable["BaseGame.Economy_Gruni"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[73]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[74]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Lespia", "Country_Lespia_Alliance");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Lespia","Country_Lespia_Alliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Lespia", "Country_Lespia_Trade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Lespia","Country_Lespia_Trade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_Country_Valgsland", "Progress_DiplomaticMission_Valgsland");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_Country_Valgsland","Progress_DiplomaticMission_Valgsland");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_Country_Lespia", "Progress_DiplomaticMission_Lespia");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_Country_Lespia","Progress_DiplomaticMission_Lespia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[78]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Valgsland", "Country_Valgsland_TradeTariffs");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Valgsland","Country_Valgsland_TradeTariffs");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[79]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: EnableNews("G_Sordland_Lespia_Alliance");)*
- **Efekt (`userScript`):** `EnableNews("G_Sordland_Lespia_Alliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
