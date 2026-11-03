# Rizia/Turn 7/Energy Partnership Unfriendly

- **ID konwersacji:** `382`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/382_Energy_Partnership_Unfriendly.md`
- **Liczba węzłów dialogowych:** 109
- **Liczba wyborów gracza:** 24

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
- Węzeł `[2]` -> **[377] Rizia/Turn 7/FPnT_DerdiaNegotiations** (../Turn_07/377_FPnT_DerdiaNegotiations.md), Węzeł `[536]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 14
- **Węzły modyfikujące stan gry:** 6

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Budget_Modifier_DerdiaTrade`
- `RiziaDLC.Derdia_EnergyShippingAgreement`
- `RiziaDLC.Energy_Modifier_DerdiaEnergyExport`
- `RiziaDLC.Policy_Economy_DerdiaPipeline_Project`
- `RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement`
- `RiziaDLCSupport.Reports_Turn07_Derdia_EnergyDealShipping`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[51]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[53]` (Paskal Beniwoll): `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = true; Variable["RiziaDLC.Derdia_EnergySh...`
- Węzeł `[72]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting"] = true; Variable["RiziaDLCIsola...`
- Węzeł `[81]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[99]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[105]` (Paskal Beniwoll): `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] = true; Variable["RiziaDLC.Diplomacy_D...`

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `377` (*Rizia/Turn 7/FPnT_DerdiaNegotiations*), Węzeł `[536]`

### Węzeł `[3]`
Mówca: **Jorga Azmal**
> ""Do you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "He adjusted the folds of his robe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Jorga Azmal**
> ""I will remind you that you had an opportunity to strengthen those ties by lifting your Golcondist ban. You did not seize it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[6]`
Mówca: **Jorga Azmal**
> ""But there is one other thing Rizia can help us with. Energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Jorga Azmal**
> ""I hear you are constructing a pipeline between Rizia and Morella. Can it be extended to my country?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[17]`
  - -> `[18]`
  - -> `[65]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I doubt that Morella would allow such an extension given your history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agreed. We shouldn't be getting too far ahead of ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[10]`
Mówca: **Jorga Azmal**
> ""It is not Derdia's fault that we are cruelly barred from our ancestral places of worship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. Derdia, Rizia and Morella will stand strong against the CSP's overreach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're at war. Our ships could get targeted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[16]`
Mówca: **Jorga Azmal**
> ""You do not want to extend your pipeline from Morella. But perhaps you would still be willing to ship us oil or gas across the Gulf of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[62]`
  - -> `[63]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It depends on whether you are able to make peace with the Morellan prime minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An interesting possibility. I will consider it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Jorga Azmal**
> ""I recognize that it would require us to cooperate with Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_DerdiaPipeline_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[23]`
Mówca: **Jorga Azmal**
> ""The only potential I see is for an energy partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[24]`
Mówca: **Jorga Azmal**
> ""But there is one other thing Rizia can help us with. Energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[25]`
Mówca: **Jorga Azmal**
> ""But the pipeline you have promised is a good start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. Derdia, Rizia and Morella will stand strong together against Arcasian imperialism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[27]`
Mówca: **Jorga Azmal**
> ""But for a chance at energy security, I am willing to face the devil herself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_CommieKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_CommieKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_CommieKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_CommieKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_CommieKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[31]`
Mówca: **Jorga Azmal**
> ""I hear you have formed energy partnerships with other Merkopan countries. Perhaps you would be willing to ship us oil or gas across the Gulf of Moridia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[12]`
  - -> `[62]`
  - -> `[63]`

### Węzeł `[32]`
Mówca: **Jorga Azmal**
> ""Get energy flowing from Morella to my country. Then we can talk about further cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[98]`
  - -> `[28]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_DerdiaRequests_Morella"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn07_DerdiaRequests_Morella == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_DerdiaRequests_Morella"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We would be, if we had any energy to sell you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am afraid not. We barely have enough energy to meet Morella's needs, let alone Derdia's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[41]`
Mówca: **Jorga Azmal**
> ""Until your holy institutions respect my country's religion, a strictly transactional relationship is all I will agree to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""I shall begin the pipeline. But you must be ready to stop your disgraceful border violations." [-2 Energy For +2 Budget Per Turn, -2 Budget Per Turn For Pipeline]"]** — Mówca: **Player_Romus**
> ""I shall begin the pipeline. But you must be ready to stop your disgraceful border violations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[43]`
**[WYBÓR GRACZA: ""Excellent. We will build the pipeline, and together, our three nations will begin a new era of peace and cooperation." [-2 Energy For +2 Budget Per Turn, -2 Budget Per Turn For Pipeline]"]** — Mówca: **Player_Romus**
> ""Excellent. We will build the pipeline, and together, our three nations will begin a new era of peace and cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With all apologies, I cannot. A pipeline to Morella is all I can manage right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[45]`
Mówca: **Jorga Azmal**
> ""Peace? Her country discarded that chance when it closed its borders to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Sal smiled faintly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Sal Ignacius**
> ""Ignoring your religious ideals for the sake of earthly riches. Your true colors are showing, Supreme Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[48]`
  - -> `[73]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More proof that Golcondists don't have ideals at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember Wruhec's words, Sal. Do not reach for the stars above your head before tending to the soil beneath your feet,""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Jorga Azmal**
> ""Precisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[52]`
Mówca: **Jorga Azmal**
> ""You ask me for a closer relationship, only to insult me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia = true; 
RiziaDLC.Derdia_EnergyShippingAgreement = true;
RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; 
RiziaDLC.Energy_Modifier_DerdiaEnergyExport = -2;
RiziaDLC.Budget_Modifier_DerdiaTrade = 2;
RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement = true;
RiziaDLCSupport.Reports_Turn07_Derdia_EnergyDealShipping = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = true;
Variable["RiziaDLC.Derdia_EnergyShippingAgreement"] = true;
Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;
Variable["RiziaDLC.Energy_Modifier_DerdiaEnergyExport"] = -2;
Variable["RiziaDLC.Budget_Modifier_DerdiaTrade"] = 2;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_EnergyDealShipping"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Jorga Azmal**
> ""Then we have failed to find common ground once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[55]`
Mówca: **Jorga Azmal**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[56]`
**[WYBÓR GRACZA: ""All right. An energy agreement it is." [-2 Energy Per Turn, +2 Budget Per Turn]"]** — Mówca: **Player_Romus**
> ""All right. An energy agreement it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nevertheless, I would rather not make an energy deal with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[58]`
Mówca: **Jorga Azmal**
> ""In the end, it is your energy and your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[44]`
  - -> `[77]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy < 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy < 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy < 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wouldn't it be easier for you to buy oil from Wehlen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be frank, we need your diplomatic support more than we need you to buy our energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[64]`
Mówca: **Jorga Azmal**
> ""The Gulf is far north of your front, is it not? Shipping has not been disrupted so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy < 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy < 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy < 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was thinking of a different kind of partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[69]`
Mówca: **Jorga Azmal**
> ""Ah. A shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Jorga Azmal**
> ""But perhaps it is best for both of us to keep our relationship as it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[71]`
Mówca: **Jorga Azmal**
> ""Only if she is ready to admit that she has wronged us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = true; RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting"] = true;
Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
Mówca: **Jorga Azmal**
> ""I cannot promise closer cooperation than that. But I hope you are satisfied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish I could help you. But we lack the funds for such a construction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[78]`
Mówca: **Jorga Azmal**
> ""Let's not get too far ahead of ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[79]`
Mówca: **Jorga Azmal**
> ""So for all your talk of cooperation, you're on the side of the godless heathens. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[80]`
Mówca: **Jorga Azmal**
> ""And yet you were able to afford it where Morella was concerned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[82]`
Mówca: **Jorga Azmal**
> ""This conversation is going nowhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He is only trying to provide for his people, Grand Wiseman. Just as I am doing in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, Azmal. You cannot have it both ways.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Jorga Azmal**
> ""You asked me about closer ties, Your Majesty. This is my answer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy > 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy > 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[89]`
Mówca: **Jorga Azmal**
> ""Until your holy institutions respect my country's religion, a strictly transactional relationship is all I will agree to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[90]`
Mówca: **Jorga Azmal**
> ""I am glad we are on the same page. Regarding this, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[91]`
Mówca: **Jorga Azmal**
> ""I do not share your animosity towards the superpowers. For the last 40 years, they have been kind enough to leave Derdia alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[92]`
Mówca: **Jorga Azmal**
> ""Indeed not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[93]`
Mówca: **Jorga Azmal**
> ""'United' is not the term for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[94]`
Mówca: **Jorga Azmal**
> ""Wehlen? Your Majesty, Wiktor Smolak's persecution of Golcondists makes your blasphemy laws look gentle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's exactly the kind of partnership I was thinking of, Supreme Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[96]`
Mówca: **Jorga Azmal**
> ""Ah. So the mighty Rizia is facing an energy shortage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[97]`
Mówca: **Jorga Azmal**
> ""But as I understand it, your own supplies are running too low to provide us with what we need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Empire of Moridia, united once more. It warms my heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[100]`
Mówca: **Jorga Azmal**
> ""Yes, we cannot be expected to carry out our religious duties without heat or electricity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[101]`
Mówca: **Jorga Azmal**
> ""All the more reason for our nations to stay at a distance from each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[102]`
Mówca: **Jorga Azmal**
> ""He will not even grant our pilgrims passage through his country to the holy Archsanctuary of Deyr. And you think he will trade with us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[103]`
Mówca: **Jorga Azmal**
> ""Think about it. Once your Zille harbor is recovered, the distance between our ports will be practically nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[104]`
Mówca: **Jorga Azmal**
> ""It will be easier to trade with Rizia once your Zille harbor is recovered from that madman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_DerdiaPipeline_Project = true; 
RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1; RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement = true; 
RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension = true;
RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia = true;
RiziaDLC.Budget_Modifier_DerdiaTrade = 2;

EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] = true;
Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension"] = true;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = true;
Variable["RiziaDLC.Budget_Modifier_DerdiaTrade"] = 2;
EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
