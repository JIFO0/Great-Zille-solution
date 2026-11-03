# Sordland/Turn08/FPnT_ValgslandVisit

- **ID konwersacji:** `160`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/160_FPnT_ValgslandVisit.md`
- **Liczba węzłów dialogowych:** 89
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Decision_Turn04_GruniRuralDev_NoFunding`
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn04_RegionalInvestment_Lorren`
- `BaseGame.Decision_Turn05_SPAid_AcceptArcasia`
- `BaseGame.Decision_Turn06_Megaproject_Morna`
- `BaseGame.EconomicDirection_Privatization`
- `BaseGame.Heljiland_Map_Layer`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Lespia_TradeDeal`
- `BaseGame.Media_Censored`
- `BaseGame.Policy_Economy_RegionalInvestment_Lorren`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.TradeDeal_Negotiation_Lespia`
- `BaseGame.Valgsland_Alliance`
- `BaseGame.Valgsland_HeljilandRecognised`
- `BaseGame.Valgsland_TradeDeal`
- `BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Capitalist`
- `BaseGame.Economy_Agnland`
- `BaseGame.Economy_Bergia`
- `BaseGame.Economy_Gruni`
- `BaseGame.Economy_Lorren`
- `BaseGame.Heljiland_Map_Layer`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised`
- `BaseGame.Policy_Diplomacy_Neutrality`
- `BaseGame.Policy_Diplomacy_TradeInitiative`
- `BaseGame.Policy_Diplomacy_TradeZone_Valgsland`
- `BaseGame.Policy_Diplomacy_Valgsland_Alliance`
- `BaseGame.Policy_Diplomacy_Valgsland_HeljiIsland_Recognised`
- `BaseGame.Policy_Military_JointMilitaryExercises`
- `BaseGame.Situation_Diplomacy_DiplomaticPressure`
- `BaseGame.Situation_Diplomacy_FTZValgsland`
- `BaseGame.Situation_Diplomacy_FailedTradeNegotiation`
- `BaseGame.Situation_Diplomacy_LackOfAllies`
- `BaseGame.Situation_Diplomacy_LespiaTradeTariffs`
- `BaseGame.Situation_Diplomacy_Valgsland_Coal_Trade`
- `BaseGame.Situation_Diplomacy_Valgsland_Fish_Trade`
- `BaseGame.Situation_Diplomacy_Valgsland_Tungsten_Trade`
- `BaseGame.Situation_Diplomacy_Valgsland_Wheat_Trade`
- `BaseGame.Sollist`
- `BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne`
- `BaseGameSupport.FactionReport_Turn08_ATO_CondemnsValgslandAlliance`
- `BaseGameSupport.Journal_Turn08_ValgslandVisit_Cancelled`
- `BaseGameSupport.News_Turn08_G_Valgsland_Cancelled_Visit`
- `BaseGameSupport.News_Turn08_R_Sordland_Valgsland_New_Trade`
- `GameCondition.Turn08_FPnT_ValgslandVisit`

### Skoki między-konwersacyjne:
- Węzeł `[8]` -> **[162] Sordland/Turn08/ValgslandVisit_ComradeRayne** (../Turn_08/162_ValgslandVisit_ComradeRayne.md), Węzeł `[1]`
- Węzeł `[12]` -> **[161] Sordland/Turn08/ValgslandVisit_TalkWithDeivid** (../Turn_08/161_ValgslandVisit_TalkWithDeivid.md), Węzeł `[1]`
- Węzeł `[13]` -> **[161] Sordland/Turn08/ValgslandVisit_TalkWithDeivid** (../Turn_08/161_ValgslandVisit_TalkWithDeivid.md), Węzeł `[1]`
- Węzeł `[15]` -> **[163] Sordland/Turn08/ValgslandVisit_AntiCommunistRayne** (../Turn_08/163_ValgslandVisit_AntiCommunistRayne.md), Węzeł `[1]`
- Węzeł `[16]` -> **[164] Sordland/Turn08/ValgslandVisit_DefaultRayne** (../Turn_08/164_ValgslandVisit_DefaultRayne.md), Węzeł `[1]`
- Węzeł `[20]` -> **[165] Sordland/Turn08/ValgslandVisit_TradeDealCancelled** (../Turn_08/165_ValgslandVisit_TradeDealCancelled.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 34

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy_Agnland`
- `BaseGame.Economy_Bergia`
- `BaseGame.Economy_Gruni`
- `BaseGame.Economy_Lorren`
- `BaseGame.Sollist`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Symon Holl): `Variable["GameCondition.Turn08_FPnT_ValgslandVisit"] = true;`
- Węzeł `[13]` (Symon Holl): `Variable["BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne"] = true;`
- Węzeł `[20]` (Symon Holl): `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_Cancelled"] = true;`
- Węzeł `[24]` (Symon Holl): `-- Continue;`
- Węzeł `[25]` (Symon Holl): `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 2; Variable["BaseGame.Solli...`
- Węzeł `[29]` (Symon Holl): `Variable["BaseGameSupport.FactionReport_Turn08_ATO_CondemnsValgslandAlliance"] = true;`
- Węzeł `[30]` (Symon Holl): `Variable["BaseGameSupport.News_Turn08_R_Sordland_Valgsland_New_Trade"] = true;`
- Węzeł `[34]` (Symon Holl): `EnableNews("G_Sordland_Recognized_Heljiland_Valgsland");`
- *...oraz 26 innych węzłów ze skryptami.*

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
  - -> `[84]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Symon Holl)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_FPnT_ValgslandVisit = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_FPnT_ValgslandVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[4]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_TradeDeal == false && BaseGame.Lespia_Alliance == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_TradeDeal == false && BaseGame.Lespia_Alliance == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_TradeDeal"] == false  and  Variable["BaseGame.Lespia_Alliance"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[6]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_TradeDeal == false && BaseGame.Lespia_Alliance == false ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_TradeDeal"] == false  and  Variable["BaseGame.Lespia_Alliance"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[7]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `162` (*Sordland/Turn08/ValgslandVisit_ComradeRayne*), Węzeł `[1]`

### Węzeł `[9]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[10]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true || BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.EconomicDirection_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true || BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.EconomicDirection_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.EconomicDirection_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true || BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.EconomicDirection_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.EconomicDirection_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `161` (*Sordland/Turn08/ValgslandVisit_TalkWithDeivid*), Węzeł `[1]`

### Węzeł `[13]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `161` (*Sordland/Turn08/ValgslandVisit_TalkWithDeivid*), Węzeł `[1]`

### Węzeł `[14]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `163` (*Sordland/Turn08/ValgslandVisit_AntiCommunistRayne*), Węzeł `[1]`

### Węzeł `[16]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `164` (*Sordland/Turn08/ValgslandVisit_DefaultRayne*), Węzeł `[1]`

### Węzeł `[17]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.TradeDeal_Negotiation_Lespia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.TradeDeal_Negotiation_Lespia == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[19]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.TradeDeal_Negotiation_Lespia == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[20]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_ValgslandVisit_Cancelled = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_Cancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `165` (*Sordland/Turn08/ValgslandVisit_TradeDealCancelled*), Węzeł `[1]`

### Węzeł `[21]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[23]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[24]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[25]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist += 2;
BaseGame.Sollist -= 2;
BaseGame.Capitalist -= 1;
BaseGame.Policy_Military_JointMilitaryExercises = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 1;
Variable["BaseGame.Policy_Military_JointMilitaryExercises"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[26]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal == true && BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal == true && BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_TradeDeal"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_TradeDeal == true && BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_TradeDeal"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.FactionReport_Turn08_ATO_CondemnsValgslandAlliance = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn08_ATO_CondemnsValgslandAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_R_Sordland_Valgsland_New_Trade = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_Sordland_Valgsland_New_Trade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[34]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: EnableNews("G_Sordland_Recognized_Heljiland_Valgsland");)*
- **Efekt (`userScript`):** `EnableNews("G_Sordland_Recognized_Heljiland_Valgsland");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[35]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_G_Valgsland_Cancelled_Visit = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_G_Valgsland_Cancelled_Visit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[36]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[39]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_TradeZone_Valgsland = true;
BaseGame.Policy_Diplomacy_TradeInitiative = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_TradeZone_Valgsland"] = true;
Variable["BaseGame.Policy_Diplomacy_TradeInitiative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_FTZValgsland = true;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_FTZValgsland"] = true;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[43]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[47]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Valgsland_Wheat_Trade = true;
BaseGame.Economy_Bergia += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Valgsland_Wheat_Trade"] = true;
Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[48]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Valgsland_Fish_Trade = true;
BaseGame.Economy_Agnland += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Valgsland_Fish_Trade"] = true;
Variable["BaseGame.Economy_Agnland"] = Variable["BaseGame.Economy_Agnland"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[49]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Valgsland_Tungsten_Trade = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Valgsland_Tungsten_Trade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[50]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[53]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Valgsland_Coal_Trade = true;
BaseGame.Economy_Lorren += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Valgsland_Coal_Trade"] = true;
Variable["BaseGame.Economy_Lorren"] = Variable["BaseGame.Economy_Lorren"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[55]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[58]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Valgsland_Alliance = true;
BaseGame.Policy_Diplomacy_Neutrality = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] = true;
Variable["BaseGame.Policy_Diplomacy_Neutrality"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_LackOfAllies = false;
BaseGame.Situation_Diplomacy_LespiaTradeTariffs = true;
BaseGame.Situation_Diplomacy_DiplomaticPressure = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_LackOfAllies"] = false;
Variable["BaseGame.Situation_Diplomacy_LespiaTradeTariffs"] = true;
Variable["BaseGame.Situation_Diplomacy_DiplomaticPressure"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[60]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[61]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Valgsland_HeljiIsland_Recognised = true;
BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Valgsland_HeljiIsland_Recognised"] = true;
Variable["BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[65]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[66]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_TradeDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_TradeDeal == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_TradeDeal"] == false  and  Variable["BaseGame.Lespia_TradeDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_TradeDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_TradeDeal"] == false  and  Variable["BaseGame.Lespia_TradeDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_FailedTradeNegotiation = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[71]`
Mówca: **Narrator**
> "I returned to Holsord with good news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[72]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false && BaseGame.Decision_Turn06_Megaproject_Morna == true && BaseGame.Policy_Economy_RegionalInvestment_Lorren == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false && BaseGame.Decision_Turn06_Megaproject_Morna == true && BaseGame.Policy_Economy_RegionalInvestment_Lorren == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_GruniRuralDev_NoFunding"] == false  and  Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true  and  Variable["BaseGame.Policy_Economy_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false && BaseGame.Decision_Turn06_Megaproject_Morna == true && BaseGame.Policy_Economy_RegionalInvestment_Lorren == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_GruniRuralDev_NoFunding"] == false  and  Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true  and  Variable["BaseGame.Policy_Economy_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[75]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Economy_Gruni += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy_Gruni"] = Variable["BaseGame.Economy_Gruni"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[76]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[77]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Heljiland_Map_Layer == 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Heljiland_Map_Layer == 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Heljiland_Map_Layer"] == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: !(BaseGame.Heljiland_Map_Layer == 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Heljiland_Map_Layer"] == 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[80]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: BaseGame.Heljiland_Map_Layer = 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Heljiland_Map_Layer"] = 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[81]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemovePlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");)*
- **Efekt (`userScript`):** `RemovePlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandValgsland");)*
- **Efekt (`userScript`):** `AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandValgsland");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[83]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Valgsland", "Country_Valgsland_Alliance");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Valgsland","Country_Valgsland_Alliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_Country_Valgsland", "Progress_DiplomaticMission_Valgsland");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_Country_Valgsland","Progress_DiplomaticMission_Valgsland");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_Country_Lespia", "Progress_DiplomaticMission_Lespia");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_Country_Lespia","Progress_DiplomaticMission_Lespia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[86]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Lespia", "Country_Lespia_TradeTariffs");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Lespia","Country_Lespia_TradeTariffs");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[87]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_Country_Valgsland", "Country_Valgsland_Trade");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_Country_Valgsland","Country_Valgsland_Trade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[88]`
Mówca: **Symon Holl**
*(Węzeł logiki narracyjnej: EnableNews("G_Sordland_Valgsland_Alliance");)*
- **Efekt (`userScript`):** `EnableNews("G_Sordland_Valgsland_Alliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
