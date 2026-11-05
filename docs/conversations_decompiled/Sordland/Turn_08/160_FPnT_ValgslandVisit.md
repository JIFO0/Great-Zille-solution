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
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Valgsland", "Progress..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_FPnT_ValgslandVisit = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_FPnT_ValgslandVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_TradeDeal == false && BaseGame.Lespia_Alliance == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_TradeDeal == false && BaseGame.Lespia_All..."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_TradeDeal == false && BaseGame.Lespia_A..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_TradeDeal == false && BaseGame.Lespia_Alliance == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_TradeDeal"] == false  and  Variable["BaseGame.Lespia_Alliance"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true || B..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_TradeDeal == false && BaseGame.Lespia_Alliance == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_TradeDeal"] == false  and  Variable["BaseGame.Lespia_Alliance"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_ValgslandVisit_Cancelled =..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne == true"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true || BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.EconomicDirection_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true || B..."*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true ||..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true || BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.EconomicDirection_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.EconomicDirection_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne = true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true || BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.EconomicDirection_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.EconomicDirection_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_FPnT_AntiCommunistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Lespia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Lespia == false"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.TradeDeal_Negotiation_Lespia == false)"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Lespia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true || B..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.TradeDeal_Negotiation_Lespia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_TradeDeal == false && BaseGame.Lespia_All..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_ValgslandVisit_Cancelled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_ValgslandVisit_Cancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "I returned to Holsord with good news."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal == true && BaseGame.Media_Ce..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal == true"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist += 2;
BaseGame.Sollist -= 2;
BaseGame.Capitalist -= 1;
BaseGame.Policy_Military_JointMilitaryExercises = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 1;
Variable["BaseGame.Policy_Military_JointMilitaryExercises"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_Sordland_Valgsland_Alliance");"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal == true && BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal == true && BaseGame.Media_Ce..."*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_TradeDeal == true && BaseGame.Media_..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal == true && BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_TradeDeal"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_Sordland_Valgsland_New_Trad..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_TradeDeal == true && BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_TradeDeal"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised == true"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.FactionReport_Turn08_ATO_CondemnsValgslandAlliance = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn08_ATO_CondemnsValgslandAlliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised == true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_Sordland_Valgsland_New_Trade = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_Sordland_Valgsland_New_Trade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised == true"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_HeljilandRecognised == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_Sordland_Recognized_Heljiland_Valgsland");"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_Sordland_Recognized_Heljiland_Valgsland");`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_Sordland_Recognized_Heljiland_Valgsland");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Heljiland_Map_Layer == 2"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_G_Valgsland_Cancelled_Visit = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_G_Valgsland_Cancelled_Visit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_FPnT_ValgslandVisit = true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_TradeDeal == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TradeZone_Valgsland = true; Bas..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TradeZone_Valgsland = true;
BaseGame.Policy_Diplomacy_TradeInitiative = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_TradeZone_Valgsland"] = true;
Variable["BaseGame.Policy_Diplomacy_TradeInitiative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_FTZValgsland = true; BaseGam..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_FTZValgsland = true;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_FTZValgsland"] = true;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Valgsland_Fish_Trade = true;..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == t..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Valgsland_Wheat_Trade = true..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Valgsland_Wheat_Trade = true;
BaseGame.Economy_Bergia += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Valgsland_Wheat_Trade"] = true;
Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Valgsland_Fish_Trade = true;
BaseGame.Economy_Agnland += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Valgsland_Fish_Trade"] = true;
Variable["BaseGame.Economy_Agnland"] = Variable["BaseGame.Economy_Agnland"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Valgsland_Tungsten_Trade = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Valgsland_Tungsten_Trade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == t..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Valgsland_Coal_Trade = true;..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Valgsland_Tungsten_Trade = true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Valgsland_Coal_Trade = true;
BaseGame.Economy_Lorren += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Valgsland_Coal_Trade"] = true;
Variable["BaseGame.Economy_Lorren"] = Variable["BaseGame.Economy_Lorren"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Valgsland_Alliance = true; Base..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised == true"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Valgsland_Alliance = true;
BaseGame.Policy_Diplomacy_Neutrality = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] = true;
Variable["BaseGame.Policy_Diplomacy_Neutrality"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_LackOfAllies = false; BaseGa..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_LackOfAllies = false;
BaseGame.Situation_Diplomacy_LespiaTradeTariffs = true;
BaseGame.Situation_Diplomacy_DiplomaticPressure = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_LackOfAllies"] = false;
Variable["BaseGame.Situation_Diplomacy_LespiaTradeTariffs"] = true;
Variable["BaseGame.Situation_Diplomacy_DiplomaticPressure"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Valgsland", "Country_Val..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_HeljilandRecognised == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Valgsland_HeljiIsland_Recognise..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Valgsland_HeljiIsland_Recognised = true;
BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Valgsland_HeljiIsland_Recognised"] = true;
Variable["BaseGame.Policy_Diplomacy_Agnolia_HeljiIsland_Recognised"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RemovePlayerCountryStatus("Country_Sordland_Recognition_H..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_TradeDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_..."*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespi..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_TradeDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_TradeDeal"] == false  and  Variable["BaseGame.Lespia_TradeDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_FailedTradeNegotiation = true"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_TradeDeal == false && BaseGame.Lespia_TradeDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_TradeDeal"] == false  and  Variable["BaseGame.Lespia_TradeDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_FailedTradeNegotiation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[71]`
Mówca: **Narrator**
> "I returned to Holsord with good news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist += 2; BaseGame.Sollist -= 2; BaseGam..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false && BaseGame.Decision_Turn06_Megaproject_Morna == true && BaseGame.Policy_Economy_RegionalInvestment_Lorren == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false..."*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == fal..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false && BaseGame.Decision_Turn06_Megaproject_Morna == true && BaseGame.Policy_Economy_RegionalInvestment_Lorren == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_GruniRuralDev_NoFunding"] == false  and  Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true  and  Variable["BaseGame.Policy_Economy_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Gruni += 1"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false && BaseGame.Decision_Turn06_Megaproject_Morna == true && BaseGame.Policy_Economy_RegionalInvestment_Lorren == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_GruniRuralDev_NoFunding"] == false  and  Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true  and  Variable["BaseGame.Policy_Economy_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Gruni += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Gruni"] = Variable["BaseGame.Economy_Gruni"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Heljiland_Map_Layer == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Heljiland_Map_Layer == 2"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Heljiland_Map_Layer == 2)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Heljiland_Map_Layer == 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Heljiland_Map_Layer"] == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Heljiland_Map_Layer = 1"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Heljiland_Map_Layer == 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Heljiland_Map_Layer"] == 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Heljiland_Map_Layer = 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Heljiland_Map_Layer"] = 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemovePlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");`
- **Efekt skryptowy (`userScript`):** `RemovePlayerCountryStatus("Country_Sordland_Recognition_HeljilandAgnolia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "AddPlayerCountryStatus("Country_Sordland_Recognition_Helj..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandValgsland");`
- **Efekt skryptowy (`userScript`):** `AddPlayerCountryStatus("Country_Sordland_Recognition_HeljilandValgsland");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Valgsland", "Country_Valgsland_Alliance");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Valgsland","Country_Valgsland_Alliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Valgsland", "Country_Val..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Valgsland", "Progress_DiplomaticMission_Valgsland");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Valgsland","Progress_DiplomaticMission_Valgsland");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Lespia", "Progress_Di..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Lespia", "Progress_DiplomaticMission_Lespia");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Lespia","Progress_DiplomaticMission_Lespia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Lespia == false"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Lespia", "Country_Lespia_TradeTariffs");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Lespia","Country_Lespia_TradeTariffs");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_HeljilandRecognised == true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Valgsland", "Country_Valgsland_Trade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Valgsland","Country_Valgsland_Trade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Lespia", "Country_Lespia..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_Sordland_Valgsland_Alliance");`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_Sordland_Valgsland_Alliance");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn08_ATO_CondemnsValgslan..."*)
