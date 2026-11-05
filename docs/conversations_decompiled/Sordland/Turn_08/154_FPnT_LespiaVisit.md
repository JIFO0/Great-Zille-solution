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
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Valgsland", "Progress..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_FPnT_LespiaVisit = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_FPnT_LespiaVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal == false && BaseGame.Valgsland_Alliance == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal == false && BaseGame.Valgsla..."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_TradeDeal == false && BaseGame.Valgs..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal == false && BaseGame.Valgsland_Alliance == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_TradeDeal"] == false  and  Variable["BaseGame.Valgsland_Alliance"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_TradeDeal == false && BaseGame.Valgsland_Alliance == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_TradeDeal"] == false  and  Variable["BaseGame.Valgsland_Alliance"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_LespiaVisit_Cancelled = true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.EconomicDirection_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == t..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.EconomicDirection_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne = true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.EconomicDirection_Nationalization == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_CapitalistRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_CapitalistRayne == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_CapitalistRayne == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_CapitalistRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_CapitalistRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_FPnT_AntiCapitalistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Valgsland == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Valgsland == false"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.TradeDeal_Negotiation_Valgsland == false)"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Valgsland == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.TradeDeal_Negotiation_Valgsland == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal == false && BaseGame.Valgsla..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_LespiaVisit_Cancelled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_LespiaVisit_Cancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist += 2; BaseGame.Sollist -= 2; BaseGame..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_TradeDeal == true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist += 2;
BaseGame.Sollist -= 2;
BaseGame.Policy_Military_JointMilitaryExercises = true;
BaseGame.Situation_Diplomacy_DiplomaticPressure = false;
BaseGame.Policy_Diplomacy_Lespia_Alliance = true;
BaseGame.Policy_Diplomacy_Neutrality = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;
Variable["BaseGame.Policy_Military_JointMilitaryExercises"] = true;
Variable["BaseGame.Situation_Diplomacy_DiplomaticPressure"] = false;
Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] = true;
Variable["BaseGame.Policy_Diplomacy_Neutrality"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_LackOfAllies = false; BaseGa..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_TradeDeal == true"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_TradeDeal == true"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_TradeDeal == true)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_Sordland_Lespia_New_Trade ..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.FactionReport_Turn08_CSP_CondemnsLespiaAlliance = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn08_CSP_CondemnsLespiaAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_Sordland_Lespia_Alliance");"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_Sordland_Lespia_New_Trade = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_Sordland_Lespia_New_Trade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_G_Lespia_Cancelled_Visit = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_G_Lespia_Cancelled_Visit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_FPnT_LespiaVisit = true"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TradeZone_Lespia = true;
BaseGame.Policy_Diplomacy_TradeInitiative = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_TradeZone_Lespia"] = true;
Variable["BaseGame.Policy_Diplomacy_TradeInitiative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_FTZLespia = true; BaseGame.S..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_FTZLespia = true;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_FTZLespia"] = true;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_SoldSordishPetroleum == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == t..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Lespia_Coal_Trade = true; Ba..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Lespia_Tungsten_Trade = true"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Lespia_Fish_Trade = true; Ba..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == t..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Lespia_Wheat_Trade = true; B..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Lespia_Tungsten_Trade = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_Tungsten_Trade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Lespia_Wheat_Trade = true;
BaseGame.Economy_Bergia += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_Wheat_Trade"] = true;
Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Lespia_Fish_Trade = true;
BaseGame.Economy_Agnland += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_Fish_Trade"] = true;
Variable["BaseGame.Economy_Agnland"] = Variable["BaseGame.Economy_Agnland"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Lespia_Coal_Trade = true;
BaseGame.Economy_Lorren += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_Coal_Trade"] = true;
Variable["BaseGame.Economy_Lorren"] = Variable["BaseGame.Economy_Lorren"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_TradeDeal == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_TradeDeal == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TradeZone_Lespia = true; BaseGa..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_SoldSordishPetroleum == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_SoldSordishPetroleum == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_SoldSordishPetroleum == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_SoldSordishPetroleum == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_SoldSordishPetroleum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum = tr..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_SoldSordishPetroleum == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_SoldSordishPetroleum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum = true;
BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Lespia_SordishPetroleum"] = true;
Variable["BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "I returned to Holsord with good news."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Lespia_Alliance = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_ValgslandTradeTariffs = true..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_ValgslandTradeTariffs = true;
BaseGame.Situation_Diplomacy_LackOfAllies = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_ValgslandTradeTariffs"] = true;
Variable["BaseGame.Situation_Diplomacy_LackOfAllies"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Lespia", "Country_Lespia..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_TradeDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_..."*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespi..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_TradeDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_TradeDeal"] == false  and  Variable["BaseGame.Lespia_TradeDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_FailedTradeNegotiation = true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_TradeDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_TradeDeal"] == false  and  Variable["BaseGame.Lespia_TradeDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_FailedTradeNegotiation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[67]`
Mówca: **Narrator**
> "I returned to Holsord with good news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Lespia_Alliance = true;"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_LackOfAllies = false;
BaseGame.Situation_Diplomacy_ValgslandTradeTariffs = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_LackOfAllies"] = false;
Variable["BaseGame.Situation_Diplomacy_ValgslandTradeTariffs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn08_CSP_CondemnsLespiaAl..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false || BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false..."*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == fal..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false || BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_GruniRuralDev_NoFunding"] == false  or  Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Gruni += 1"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false || BaseGame.Decision_Turn06_Megaproject_Benfi == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_GruniRuralDev_NoFunding"] == false  or  Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Gruni += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Gruni"] = Variable["BaseGame.Economy_Gruni"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Lespia", "Country_Lespia_Alliance");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Lespia","Country_Lespia_Alliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Lespia", "Country_Lespia..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Lespia", "Country_Lespia_Trade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Lespia","Country_Lespia_Trade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Valgsland", "Country_Val..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Valgsland", "Progress_DiplomaticMission_Valgsland");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Valgsland","Progress_DiplomaticMission_Valgsland");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Lespia", "Progress_Di..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Lespia", "Progress_DiplomaticMission_Lespia");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Lespia","Progress_DiplomaticMission_Lespia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Valgsland == false"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Valgsland", "Country_Valgsland_TradeTariffs");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Valgsland","Country_Valgsland_TradeTariffs");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_Sordland_Lespia_Alliance");`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_Sordland_Lespia_Alliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "// continue"*)
