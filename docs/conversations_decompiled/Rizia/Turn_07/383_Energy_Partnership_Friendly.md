# Rizia/Turn 7/Energy Partnership Friendly

- **ID konwersacji:** `383`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/383_Energy_Partnership_Friendly.md`
- **Liczba węzłów dialogowych:** 115
- **Liczba wyborów gracza:** 27

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[69]** Jorga Azmal
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella`
- `RiziaDLC.Policy_Economy_DerdiaPipeline_Project`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_BudgetModifiersTotal`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Trait_CommieKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLCIsolated.Turn07_DerdiaRequests_Morella`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_DerdiaTrade`
- `RiziaDLC.CountryRelation_Derdia_Friendly`
- `RiziaDLC.Derdia_EnergyShippingAgreement`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Energy_Modifier_DerdiaEnergyExport`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia`
- `RiziaDLC.Policy_Economy_DerdiaPipeline_Project`
- `RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting`
- `RiziaDLCIsolated.Turn07_Derdia_FavorsDone`
- `RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement`
- `RiziaDLCSupport.Reports_Turn07_Derdia_EnergyDealShipping`
- `RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[377] Rizia/Turn 7/FPnT_DerdiaNegotiations** (../Turn_07/377_FPnT_DerdiaNegotiations.md), Węzeł `[575]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 7

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Budget_Modifier_DerdiaTrade`
- `RiziaDLC.Derdia_EnergyShippingAgreement`
- `RiziaDLC.Energy_Modifier_DerdiaEnergyExport`
- `RiziaDLC.Policy_Economy_DerdiaPipeline_Project`
- `RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement`
- `RiziaDLCSupport.Reports_Turn07_Derdia_EnergyDealShipping`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[47]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[49]` (Paskal Beniwoll): `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = true; Variable["RiziaDLCIsolated.Turn07_...`
- Węzeł `[66]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting"] = true; Variable["RiziaDLCIsola...`
- Węzeł `[85]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[108]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[109]` (Paskal Beniwoll): `Variable["RiziaDLC.CountryRelation_Derdia_Friendly"] = true;`
- Węzeł `[110]` (Paskal Beniwoll): `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] = true; Variable["RiziaDLCSupport.Jour...`

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
  - -> `[91]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `377` (*Rizia/Turn 7/FPnT_DerdiaNegotiations*), Węzeł `[575]`

### Węzeł `[3]`
Mówca: **Jorga Azmal**
> ""In fact, I was hoping to speak with you about an energy partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Jorga Azmal**
> ""I hear you are constructing a pipeline between Rizia and Morella. Can it be extended to my country?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[14]`
  - -> `[15]`
  - -> `[61]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I doubt that Morella would allow such an extension given your history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. We shouldn't be getting too far ahead of ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[7]`
Mówca: **Jorga Azmal**
> ""It is not Derdia's fault that we are cruelly barred from our ancestral places of worship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. Derdia, Rizia and Morella will stand strong against the CSP's overreach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're at war. Our ships could get targeted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[13]`
Mówca: **Jorga Azmal**
> ""You do not want to extend your pipeline from Morella. But perhaps you would still be willing to ship us oil or gas across the Gulf of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[9]`
  - -> `[58]`
  - -> `[59]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It depends on whether you are able to make peace with the Morellan prime minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An interesting possibility. I will consider it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Jorga Azmal**
> ""I recognize that this would require closer cooperation with Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[20]`
Mówca: **Jorga Azmal**
> ""I have not given up hope that we may form an energy partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[21]`
Mówca: **Jorga Azmal**
> ""In fact, I was hoping to speak with you about an energy partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
Mówca: **Jorga Azmal**
> ""The pipeline you have promised is a good start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. Derdia, Rizia and Morella will stand strong together against Arcasian imperialism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[24]`
Mówca: **Jorga Azmal**
> ""But for a chance at energy security, I am willing to face the devil herself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_CommieKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_CommieKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_CommieKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_CommieKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_CommieKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[28]`
Mówca: **Jorga Azmal**
> ""I hear you have sold oil and gas to other Merkopan countries. Perhaps you would be willing to ship it to us across the Gulf of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[9]`
  - -> `[58]`
  - -> `[59]`

### Węzeł `[29]`
Mówca: **Jorga Azmal**
> ""Once energy is flowing from Rizia to Derdia, we can begin to talk about further cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[84]`
  - -> `[25]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdiaRequests_Morella"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdiaRequests_Morella"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We would be, if we had any energy to sell you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am afraid not. We barely have enough energy to meet Morella's needs, let alone Derdia's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""I agree to extend the pipeline. But you must be ready to stop your disgraceful border violations." [-2 Energy For +4 Budget Per Turn, -2 Budget Per Turn For Pipeline]"]** — Mówca: **Player_Romus**
> ""I agree to extend the pipeline. But you must be ready to stop your disgraceful border violations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Excellent. We will begin the pipeline, and our three nations will begin a new era of peace and cooperation." [-2 Energy For +4 Budget Per Turn, -2 Budget Per Turn For Pipeline]"]** — Mówca: **Player_Romus**
> ""Excellent. We will begin the pipeline, and our three nations will begin a new era of peace and cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My answer is no. You will have to come up with another energy solution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[41]`
Mówca: **Jorga Azmal**
> ""Peace? Her country discarded that chance when it closed its borders to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[42]`
Mówca: **Narrator**
> "Sal smiled faintly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Sal Ignacius**
> ""Ignoring your religious ideals for the sake of earthly riches. Your true colors are showing, Supreme Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`
  - -> `[44]`
  - -> `[67]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't call energy 'riches'. It is a basic need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember Wruhec's words, Sal. Do not reach for the stars above your head before tending to the soil beneath your feet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Jorga Azmal**
> ""Precisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[48]`
Mówca: **Jorga Azmal**
> ""Precisely. We cannot honor God if we cannot keep the lights on at our sanctuaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia = true; 
RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; 
RiziaDLC.Energy_Modifier_DerdiaEnergyExport = -2;
RiziaDLC.Budget_Modifier_DerdiaTrade = 3;
RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement = true;
RiziaDLCSupport.Reports_Turn07_Derdia_EnergyDealShipping = true;
RiziaDLC.Derdia_EnergyShippingAgreement = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = true;
Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;
Variable["RiziaDLC.Energy_Modifier_DerdiaEnergyExport"] = -2;
Variable["RiziaDLC.Budget_Modifier_DerdiaTrade"] = 3;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_EnergyDealShipping"] = true;
Variable["RiziaDLC.Derdia_EnergyShippingAgreement"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Jorga Azmal**
> ""That's too bad, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[51]`
Mówca: **Jorga Azmal**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[52]`
**[WYBÓR GRACZA: ""All right. An energy agreement it is." [-2 Energy Per Turn, +3 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""All right. An energy agreement it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nevertheless, I would rather not make an energy deal at this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[54]`
Mówca: **Jorga Azmal**
> ""It is your energy, Your Majesty. And your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[40]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy < 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy < 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy < 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wouldn't it be easier for you to buy oil from Wehlen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be frank, we need your diplomatic support more than we need you to buy our energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[60]`
Mówca: **Jorga Azmal**
> ""The Gulf is far north of your front, is it not? Shipping has not been disrupted so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy < 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy < 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy < 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[64]`
Mówca: **Jorga Azmal**
> ""Ah. A shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[65]`
Mówca: **Jorga Azmal**
> ""Only if she is ready to admit that she has wronged us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = true; RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting"] = true;
Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[70]`
Mówca: **Jorga Azmal**
> ""Our great Nurist republic will endeavor to support you diplomatically as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[71]`
Mówca: **Jorga Azmal**
> ""You're very optimistic. But I would not count on Morella to offer either of those to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[72]`
Mówca: **Jorga Azmal**
> ""That's unfortunate, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He is only trying to provide for his people, Grand Wiseman. Just as I am doing in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, Azmal. You cannot have it both ways.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Jorga Azmal**
> ""You asked me about closer ties, Your Majesty. This is my answer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[76]`
Mówca: **Jorga Azmal**
> ""Diplomatic support from a country with rolling blackouts. I'm not sure how much that's worth, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[77]`
Mówca: **Jorga Azmal**
> ""When two like souls converge, the Divine smiles upon them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[78]`
Mówca: **Jorga Azmal**
> ""Both superpowers are equally repugnant to me, Your Majesty. All I wish is for both of them to leave Derdia alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[79]`
Mówca: **Jorga Azmal**
> ""Still, I see much potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[80]`
Mówca: **Jorga Azmal**
> ""'United' is not the word for it. But if Rizia wishes for us to keep the peace, we shall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[81]`
Mówca: **Jorga Azmal**
> ""Wehlen? Your Majesty, Wiktor Smolak's persecution of Golcondists makes Morella's border controls seem gentle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's exactly the kind of strengthened ties I was thinking of, Supreme Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[83]`
Mówca: **Jorga Azmal**
> ""Ah. So I heard wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Empire of Moridia, united once more. It warms my heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[86]`
Mówca: **Jorga Azmal**
> ""Yes, we cannot be expected to carry out our religious duties without heat or electricity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[87]`
Mówca: **Jorga Azmal**
> ""We ourselves have implemented rolling blackouts recently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[88]`
Mówca: **Jorga Azmal**
> ""He will not even grant our pilgrims passage through his country to the holy Archsanctuary of Deyr. And you think he will trade with us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[89]`
Mówca: **Jorga Azmal**
> ""Think about it. Once your Zille harbor is recovered, the distance between our ports will be practically nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[90]`
Mówca: **Jorga Azmal**
> ""It will be easier to trade with Rizia once your Zille harbor is recovered from that madman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[91]`
Mówca: **Narrator**
> "Azmal's eyes lit up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Jorga Azmal**
> ""I would welcome the chance for Derdia to grow closer to our Rizian brothers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[93]`
Mówca: **Jorga Azmal**
> ""But as long as you continue to support Golcondists, we will endeavor to support you in whatever matters we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[94]`
Mówca: **Jorga Azmal**
> ""But we will endeavor to support you however we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`
  - -> `[100]`

### Węzeł `[95]`
Mówca: **Jorga Azmal**
> ""We may not be able to help each other with our energy needs. But you will have our support in other matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`
  - -> `[100]`

### Węzeł `[96]`
Mówca: **Jorga Azmal**
> ""Regardless, we will do our best to support you in other matters if that is what you desire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[100]`

### Węzeł `[97]`
Mówca: **Jorga Azmal**
> ""As long as you do not succumb to the Morellans' influence, we will endeavor to support you in whatever matters we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May St. Wruhec bless our bond.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will hold you to those words, Supreme Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You need not be outspoken in your support. Behind the scenes is fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An energy partnership is enough for now, I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[102]`
Mówca: **Narrator**
> "Azmal looked somewhat wounded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[103]`
Mówca: **Jorga Azmal**
> ""If you do not wish to be associated with Derdia, we will stay in the shadows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[104]`
Mówca: **Narrator**
> "Azmal nodded slowly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Jorga Azmal**
> ""We will see where it takes us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[106]`
Mówca: **Jorga Azmal**
> ""From now through eternity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
Mówca: **Jorga Azmal**
> ""From my lips to God's ears.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Derdia_Friendly = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.CountryRelation_Derdia_Friendly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_DerdiaPipeline_Project = true; RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement = true; 
RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension = true;
RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia = true;
RiziaDLC.Budget_Modifier_DerdiaTrade = 4;

EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension"] = true;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = true;
Variable["RiziaDLC.Budget_Modifier_DerdiaTrade"] = 4;
EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry. But it's out of the realm of possibility for us at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
