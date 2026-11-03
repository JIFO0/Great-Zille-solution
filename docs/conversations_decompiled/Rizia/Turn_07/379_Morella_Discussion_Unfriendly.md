# Rizia/Turn 7/Morella Discussion Unfriendly

- **ID konwersacji:** `379`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/379_Morella_Discussion_Unfriendly.md`
- **Liczba węzłów dialogowych:** 92
- **Liczba wyborów gracza:** 20

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[69]** Jorga Azmal
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella`
- `RiziaDLC.Policy_Law_GolcondistBlasphemy`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_BudgetModifiersTotal`
- `RiziaDLC.Resources_EnergyModifiersTotal`
- `RiziaDLC.Trait_ReligiousKing`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_DerdiaTrade`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.MorellaConditions_DerdianProblemSolved`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia`
- `RiziaDLC.Policy_Economy_DerdiaPipeline_Project`
- `RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting`
- `RiziaDLCIsolated.Turn07_Derdia_FavorsDone`
- `RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement`
- `RiziaDLCSupport.Journal_Turn07_Derdia_MorellaDispute`
- `RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension`
- `RiziaDLCSupport.Reports_Turn07_Morella_PilgrimsToLeaveMorellaAlone`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[377] Rizia/Turn 7/FPnT_DerdiaNegotiations** (../Turn_07/377_FPnT_DerdiaNegotiations.md), Węzeł `[536]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 3

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Budget_Modifier_DerdiaTrade`
- `RiziaDLC.Policy_Economy_DerdiaPipeline_Project`
- `RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[21]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[39]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_...`
- Węzeł `[59]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_...`

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
  - -> `[10]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `377` (*Rizia/Turn 7/FPnT_DerdiaNegotiations*), Węzeł `[536]`

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Peace between Morella, Rizia and Derdia could be lucrative for all of us. Don't you realize that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't you realize Morella is on the verge of joining the CSP? Your insurgents will be blown to smithereens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not about 'help'. It's about Derdians breaking the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Jorga Azmal**
> ""As St. Wruhec has said, 'Laws devoid of justice are but chains upon the righteous. To break such chains is man's highest duty.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[7]`
Mówca: **Jorga Azmal**
> ""You think a man of God can be bought so easily?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[8]`
Mówca: **Jorga Azmal**
> ""Are you aware of my country's weapons capabilities? We are more than prepared to fight for our right to holy pilgrimage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[9]`
Mówca: **Jorga Azmal**
> ""After your lip service to Derdia at the Alliance of Nations, you are siding with Morella after all. I shouldn't be surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Jorga Azmal**
> ""So you are here to do a woman's bidding. I shouldn't be surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Jorga Azmal**
> ""Why should I help either of you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[4]`
  - -> `[5]`
  - -> `[16]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are a man of God. Must your goodwill be earned, or can it not be freely given?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[19]`
Mówca: **Jorga Azmal**
> ""As St. Wruhec has said, 'Generosity is the heart's river, but let its waters flow with discernment'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember the words of St. Wruhec. 'The light of compassion can illuminate even those who walk in the darkest of shadows.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Jorga Azmal**
> ""Yes, that is so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Narrator**
> "He sat back on his cushion, looking defiant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[24]`
Mówca: **Narrator**
> "He sat back on his cushion for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[28]`
Mówca: **Jorga Azmal**
> ""You approached me, not the other way around. And this as far as I will go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[29]`
Mówca: **Jorga Azmal**
> ""And only if she is willing to compromise and allow Derdians into Morella's Archsanctuaries. Unlike you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[33]`
  - -> `[64]`
  - -> `[37]`

### Węzeł `[30]`
Mówca: **Jorga Azmal**
> ""Tell Ms. Saltana I will talk to her. But only if the King of Rizia is present to act as an intermediary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the Lord on our side, we will convince her to aid your people in their holy travels.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My country's fighting a war, Supreme Wiseman. I don't have time to mediate my neighbors' squabbles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[36]`
Mówca: **Jorga Azmal**
> ""Halaita. If it is said, so it will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have spoken to her. I highly doubt she will compromise on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[38]`
Mówca: **Jorga Azmal**
> ""There is no 'halfway' when it comes to the holy duties of a Golcondist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = true; RiziaDLCSupport.Journal_Turn07_Derdia_MorellaDispute = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;
Variable["RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_MorellaDispute"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[40]`
Mówca: **Narrator**
> "He smirked slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Jorga Azmal**
> ""In that case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[42]`
Mówca: **Jorga Azmal**
> ""Or is it your Morellan friends you are worried about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[81]`

### Węzeł `[43]`
Mówca: **Jorga Azmal**
> ""We are not allies, Your Majesty. This is purely a matter of convenience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[44]`
Mówca: **Jorga Azmal**
> ""I will give her one chance. If she refuses it, the Derdians' holy struggle will continue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[45]`
Mówca: **Jorga Azmal**
> ""Or a way to make sure you still have resources for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'For lo, true virtue lies in balancing the celestial with the hearth.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't make me regret this, Mr. Azmal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Jorga Azmal**
> ""Promises are easier to make than fulfill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[49]`
Mówca: **Jorga Azmal**
> ""I assure you I will not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[50]`
Mówca: **Jorga Azmal**
> ""And we in Derdia have plenty of hearths to keep alit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[51]`
Mówca: **Jorga Azmal**
> ""His pen was but a conduit for the Divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[52]`
Mówca: **Jorga Azmal**
> ""It's an investment, Your Majesty. Into the future of this region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[81]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pipeline is out of the question. Isn't there anything else you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[54]`
Mówca: **Narrator**
> "A faint smile appeared on Sal's lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was easier than I expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He wrote a lot, didn't he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[57]`
Mówca: **Sal Ignacius**
> ""As Wruhec wrote, 'Reach not for the stars above your head...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Jorga Azmal**
> ""...before tending to the soil beneath your feet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC.Policy_Economy_DerdiaPipeline_Project = true; 
RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia = true;
RiziaDLC.Budget_Modifier_DerdiaTrade = 2;
RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1; RiziaDLC.MorellaConditions_DerdianProblemSolved = true; RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement = true;
RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension = true;
RiziaDLCSupport.Reports_Turn07_Morella_PilgrimsToLeaveMorellaAlone = true;

EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;
Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] = true;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = true;
Variable["RiziaDLC.Budget_Modifier_DerdiaTrade"] = 2;
Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;
Variable["RiziaDLC.MorellaConditions_DerdianProblemSolved"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Morella_PilgrimsToLeaveMorellaAlone"] = true;
EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[47]`
  - -> `[61]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""It's a deal, Supreme Wiseman. We will extend the pipeline if you leave Morella alone." [-2 Energy For +2 Budget Per Turn, -2 Budget Per Turn For Pipeline]"]** — Mówca: **Player_Romus**
> ""It's a deal, Supreme Wiseman. We will extend the pipeline if you leave Morella alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She is a reasonable leader. I'm sure she will be able to meet you halfway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[65]`
Mówca: **Jorga Azmal**
> ""I have heard of your gas pipeline to Morella. Extend it to Derdia, and I will order our pilgrims away from Morella's borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[75]`
  - -> `[71]`
  - -> `[76]`

### Węzeł `[66]`
Mówca: **Narrator**
> "He cast a suspicious glance at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Jorga Azmal**
> ""There is one thing we Derdians need more than access to sacred sites. Energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. I wanted to suggest an energy partnership anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Respectfully, Supreme Wiseman, we barely have enough energy to sell to Morella, let alone Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Jorga Azmal**
> ""So Rizia's legendary gas wealth is a myth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[74]`
Mówca: **Jorga Azmal**
> ""Do you not trust us, Your Majesty? The word of a Derdian is bond.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that. Too much could go wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are fighting a war. Building a pipeline would be a waste of much-needed resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[80]`
Mówca: **Narrator**
> "He gave Sal and myself an appraising look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish it were that easy. But I cannot fund such a construction at this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_GolcondistBlasphemy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_GolcondistBlasphemy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Law_GolcondistBlasphemy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_GolcondistBlasphemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Jorga Azmal**
> ""And only if she is willing to compromise and allow Derdians into Morella's Archsanctuaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[33]`
  - -> `[64]`
  - -> `[37]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal < 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal < 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_EnergyModifiersTotal < 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
