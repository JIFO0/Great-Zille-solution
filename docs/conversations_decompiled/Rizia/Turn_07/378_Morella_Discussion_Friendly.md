# Rizia/Turn 7/Morella Discussion Friendly

- **ID konwersacji:** `378`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/378_Morella_Discussion_Friendly.md`
- **Liczba węzłów dialogowych:** 105
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
- `RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella`
- `RiziaDLC.Prologue_Religious`
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
- Węzeł `[2]` -> **[377] Rizia/Turn 7/FPnT_DerdiaNegotiations** (../Turn_07/377_FPnT_DerdiaNegotiations.md), Węzeł `[575]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
- **Węzły modyfikujące stan gry:** 5

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Budget_Modifier_DerdiaTrade`
- `RiziaDLC.Policy_Economy_DerdiaPipeline_Project`
- `RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[11]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[15]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[22]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[71]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting"] = true; Variable["RiziaDLCSuppo...`
- Węzeł `[88]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_...`

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
  - -> `[14]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `377` (*Rizia/Turn 7/FPnT_DerdiaNegotiations*), Węzeł `[575]`

### Węzeł `[3]`
Mówca: **Jorga Azmal**
> ""Tell me. What has Saltana done to deserve my goodwill?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[27]`
  - -> `[4]`
  - -> `[6]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This isn't about 'goodwill'. It's about a murderous incursion of Derdian insurgents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are a man of God. Must your goodwill be earned, or can it not be freely given?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[9]`
Mówca: **Jorga Azmal**
> ""Insurgents? Was Wruhec an 'insurgent' when he spread his gospel across Southern Merkopa?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember the words of St. Wruhec. 'The light of compassion can illuminate even those who walk in the darkest of shadows.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[12]`
Mówca: **Jorga Azmal**
> ""As St. Wruhec has said, 'Generosity is the heart's river, but let its waters flow with discernment'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "He sat back on his cushion for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[14]`
Mówca: **Jorga Azmal**
> ""Ha. That witch has you doing her bidding?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[16]`
Mówca: **Jorga Azmal**
> ""We will talk. That is all I can promise you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[17]`
Mówca: **Jorga Azmal**
> ""I will meet with you and Saltana. That is all I can promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Silence, both of you. I did not come here to trade aphorisms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true || RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true  or  Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[23]`
Mówca: **Jorga Azmal**
> ""Or a way to make sure you still have resources for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Jorga Azmal**
> ""It's an investment, Your Majesty. Into the future of this region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[98]`

### Węzeł `[25]`
Mówca: **Sal Ignacius**
> ""As Wruhec wrote, 'Reach not for the stars above your head...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Jorga Azmal**
> ""...before tending to the soil beneath your feet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Think about it from a financial perspective. Peace between Derdia and Morella could be lucrative for all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What will happen when she allies with the CSP? Your insurgents will get blown to smithereens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Yet even the most imposing of mountains may still be shaped by the gentle rains of understanding'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what he wrote. The law is the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Azmal nodded approvingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[32]`
Mówca: **Jorga Azmal**
> ""We will talk to Saltana. I will respect her borders if she respects my pilgrims' rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[33]`
Mówca: **Jorga Azmal**
> ""We in Derdia only recognize one law. The law of the divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[34]`
Mówca: **Jorga Azmal**
> ""'In the realm of discourse, succinct truths are the sharpest blades of wisdom'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree, Supreme Wiseman. We will get Saltana to recognize your people's right to their ancestral land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Jorga Azmal**
> ""Halaita. If it is said, so it will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[37]`
Mówca: **Jorga Azmal**
> ""In that case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are fighting a war. Building a pipeline would be a waste of much-needed resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[42]`
Mówca: **Narrator**
> "A faint smile appeared on Sal's lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pipeline is out of the question. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""It's a deal, Supreme Wiseman. We will extend the pipeline if you leave Morella alone." [-2 Energy For +4 Budget Per Turn, -2 Budget Per Turn For Pipeline]"]** — Mówca: **Player_Romus**
> ""It's a deal, Supreme Wiseman. We will extend the pipeline if you leave Morella alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[45]`
Mówca: **Jorga Azmal**
> ""Are you aware of my country's weapons capabilities? We are more than prepared to fight for our right to holy pilgrimage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[46]`
Mówca: **Jorga Azmal**
> ""Riches are useless if we are unable to express our gratitude to the Lord who provided them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[47]`
Mówca: **Jorga Azmal**
> ""Tell Ms. Saltana I will talk to her. But only if the King of Rizia is present to act as an intermediary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`
  - -> `[50]`
  - -> `[56]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds fair enough. I'm happy to help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you are ready to compromise. Derdians are not automatically entitled to enter Morella, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My country's fighting a war, Supreme Wiseman. I don't have time to mediate my neighbors' squabbles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Jorga Azmal**
> ""You approached me, not the other way around. And this as far as I will go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[55]`
Mówca: **Jorga Azmal**
> ""Halaita. If it is said, so it will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the Lord on our side, we will convince her to aid your people in their holy travels.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Jorga Azmal**
> ""You spoke in our favor at the Alliance of Nations. I know you are not entirely on Morella's side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[64]`
Mówca: **Jorga Azmal**
> ""I was wary of you after your words at the Alliance of Nations. But your actions on behalf of Golcondists have spoken volumes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[65]`
Mówca: **Jorga Azmal**
> ""Yes, that is so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[66]`
Mówca: **Narrator**
> "He sat back on his cushion, looking defiant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[67]`
Mówca: **Jorga Azmal**
> ""We were once one kingdom. St. Wruhec knew nothing of these modern-day borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Jorga Azmal**
> ""Make sure she is aware that I will not simply back down. The more she tries to block our holy pilgrimage, the more fiercely we will fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Sal Ignacius**
> ""Wruhec himself would not have approved of your attitude, Supreme Wiseman. 'The most steadfast heart must be willing to sway, for in yielding, it finds strength.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Jorga Azmal**
> ""Did he not also write, 'As the mountain stand still against the tempest, so too must one hold firm to their convictions'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[18]`
  - -> `[35]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting = true; RiziaDLCSupport.Journal_Turn07_Derdia_MorellaDispute = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn07_Diplomacy_Derdia_EnableSaltanaMeeting"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_MorellaDispute"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Jorga Azmal**
> ""There is one thing we Derdians need more than access to sacred sites. Energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Jorga Azmal**
> ""I've heard about your partnership with Morella. Extend the pipeline to Derdia, and I will order our pilgrims away from Morella's borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[83]`
  - -> `[77]`
  - -> `[38]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's your only request? Nothing would make me happier than to pursue an energy partnership with Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Jorga Azmal**
> ""When two like souls converge, the Divine smiles upon them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Respectfully, Supreme Wiseman, we barely have enough energy to sell to Morella, let alone Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Jorga Azmal**
> ""So Rizia's legendary gas wealth is a myth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Narrator**
> "He looked disappointed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that. Too much could go wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Jorga Azmal**
> ""Do you not trust us, Your Majesty? The word of a Derdian is bond.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Jorga Azmal**
> ""Or is it your Morellan friends you are worried about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[98]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He wrote a lot, didn't he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was easier than I expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn07_Derdia_FavorsDone += 1; RiziaDLC.Policy_Economy_DerdiaPipeline_Project = true; RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement = true; RiziaDLC.MorellaConditions_DerdianProblemSolved = true;
RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension = true;
RiziaDLCSupport.Reports_Turn07_Morella_PilgrimsToLeaveMorellaAlone = true;
RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia = true;
RiziaDLC.Budget_Modifier_DerdiaTrade = 4;

EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] = Variable["RiziaDLCIsolated.Turn07_Derdia_FavorsDone"] + 1;
Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Project"] = true;
Variable["RiziaDLCSupport.Journal_Turn07_Derdia_EnergyAgreement"] = true;
Variable["RiziaDLC.MorellaConditions_DerdianProblemSolved"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Derdia_PipelineExtension"] = true;
Variable["RiziaDLCSupport.Reports_Turn07_Morella_PilgrimsToLeaveMorellaAlone"] = true;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] = true;
Variable["RiziaDLC.Budget_Modifier_DerdiaTrade"] = 4;
EvaluateConditionalInstruction("ConstructionStarter_DerdiaPipeline");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[97]`
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[92]`
Mówca: **Jorga Azmal**
> ""We have more in common than expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[93]`
Mówca: **Jorga Azmal**
> ""I assure you I will not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[94]`
Mówca: **Jorga Azmal**
> ""And we in Derdia have plenty of hearths to keep alit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[95]`
Mówca: **Jorga Azmal**
> ""His pen was but a conduit for the Divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'For lo, true virtue lies in balancing the celestial with the hearth.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't make me regret this, Mr. Azmal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 2 || RiziaDLC.Resources_BudgetModifiersTotal >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 2  or  Variable["RiziaDLC.Resources_BudgetModifiersTotal"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unfortunately, Rizia cannot fund such a construction at this time. Is there anything else we can offer instead?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal < 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal < 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_EnergyModifiersTotal < 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] < 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
