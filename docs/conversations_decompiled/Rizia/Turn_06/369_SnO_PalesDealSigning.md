# Rizia/Turn 6/SnO_PalesDealSigning

- **ID konwersacji:** `369`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/369_SnO_PalesDealSigning.md`
- **Liczba węzłów dialogowych:** 556
- **Liczba wyborów gracza:** 123

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[70]** Laurento Esquibel
- **[79]** Vina Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*
- **[99]** Patricio Alvarez (R)

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal`
- `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_Cede`
- `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal`
- `RiziaDLC.Incident_Border_KillSoldiers`
- `RiziaDLC.Incident_Naval_FocusAidOnValero`
- `RiziaDLC.Incident_Naval_NoRescue`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.MITZ_ScrewedOverLespia`
- `RiziaDLC.Pales_PostIncident_Deal_25`
- `RiziaDLC.Pales_PostIncident_Deal_Cede`
- `RiziaDLC.Pales_PostIncident_Peace_Deal`
- `RiziaDLC.Policy_Economy_AureusField_Extractions`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Relations_VinaManus_ApproveAfterPales`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Situation_Economy_AureusField_HighExtraction`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn05_ITZVote_Nationalization`
- `RiziaDLC.War_Incident_Border`
- `RiziaDLC.War_Incident_Naval`
- `RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening`
- `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_PalesPipelineConstruction`
- `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower`
- `RiziaDLC.Energy_Modifier_AureusGasField`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Pales`
- `RiziaDLC.Policy_Economy_AureusField_Extractions`
- `RiziaDLC.Policy_Economy_PalesPipeline_Completed`
- `RiziaDLC.Policy_Economy_PalesPipeline_Project`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Situation_Economy_AureusField_HighExtraction`
- `RiziaDLC.Situation_Economy_AureusField_LowExtraction`
- `RiziaDLC.Situation_Economy_AureusField_MediumExtraction`
- `RiziaDLC.VinaManus_Together`
- `RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening`
- `RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening`
- `RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales`
- `RiziaDLCSupport.News_Turn06_RH_Gossip_VixelDealCerenomy`
- `RiziaDLCSupport.News_Turn06_RH_VinaReturnsFromPales`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 16
- **Węzły modyfikujące stan gry:** 47

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Budget_Modifier_PalesPipelineConstruction`
- `RiziaDLC.Energy_Modifier_AureusGasField`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Pales`
- `RiziaDLC.Policy_Economy_AureusField_Extractions`
- `RiziaDLC.Policy_Economy_PalesPipeline_Completed`
- `RiziaDLC.Policy_Economy_PalesPipeline_Project`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Situation_Economy_AureusField_HighExtraction`
- `RiziaDLC.Situation_Economy_AureusField_LowExtraction`
- `RiziaDLC.Situation_Economy_AureusField_MediumExtraction`
- `RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales`
- `RiziaDLCSupport.News_Turn06_RH_VinaReturnsFromPales`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[92]` (Paskal Beniwoll): `Variable["RiziaDLC.Situation_Economy_AureusField_HighExtraction"] = true; Variable["RiziaDLC.Ener...`
- Węzeł `[96]` (Paskal Beniwoll): `-- SYMBOLIC DRILLING -- INCOME ADDED TURN 7;`
- Węzeł `[100]` (Paskal Beniwoll): `-- SYMBOLIC OPENING OF PIPELINE -- INCOME ADDED IMMEDIATELY;`
- Węzeł `[132]` (Paskal Beniwoll): `Variable["RiziaDLC.Situation_Economy_AureusField_MediumExtraction"] = true; Variable["RiziaDLC.En...`
- Węzeł `[133]` (Paskal Beniwoll): `Variable["RiziaDLC.Situation_Economy_AureusField_LowExtraction"] = true; Variable["RiziaDLC.Energ...`
- Węzeł `[141]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] + 6;`
- Węzeł `[142]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] + 2;`
- Węzeł `[146]` (Paskal Beniwoll): `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] = true; Variable["RiziaDLC.Policy_Dip...`
- *...oraz 39 innych węzłów ze skryptami.*

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
  - -> `[555]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "After exchanging pleasantries, we were led inside. The light of the camera flashes nearly blinded us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[4]`
Mówca: **Axel Reinhart**
> ""Welcome back, Your Majesty. It's a delight to have you here with us once again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I was here to finalize our deal with Duke Reinhart and Prime Minister Alvarez. Today, Rizia would officially cede its claim to the Aureus gas field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Upon our arrival to Castle Reinhart, we were greeted by the smiling faces of the Palesian and Lespian delegations as well as Duke Reinhart, who waited at the front gates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[7]`
Mówca: **Narrator**
> "The city was familiar to me by now. But the atmosphere was far more welcoming than it had ever been before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Narrator**
> "I was here to sign our deal with Duke Reinhart as resolved by the AN. After today, Rizia would own 50 percent of the Aureus gas field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[15]`
Mówca: **Narrator**
> "I was here to finalize our concession to Duke Reinhart, according to the AN's resolution. After today, Rizia's claim on the Aureus gas field would be officially null and void."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[19]`
Mówca: **Narrator**
> "Vina was already inside, standing next to the Palesian foreign affairs team. She came to me when we entered the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Vina Toras**
> ""I'm glad you made it, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[22]`
  - -> `[23]`
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Narrator**
> "We took our seats around a large table along with the delegates from each country's ministry of foreign affairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You must be dying to return home. Thank you for accepting this duty, Vina. It means a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to see you, Vina. How were the meetings? I'm told there are no issues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you miss your old man?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Vina Toras**
> ""Ha. Not when you put it like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[184]`
  - -> `[185]`

### Węzeł `[26]`
Mówca: **Vina Toras**
> ""They were long and arduous for sure. But honestly, it wasn't as boring as I'd have thought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Peace_Deal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Peace_Deal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_PostIncident_Peace_Deal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[30]`
Mówca: **Narrator**
> "For the third time since my coronation, our convoy drove steadily across the cobbled streets of Old Town Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_Cede == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_Cede == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_PostIncident_Deal_Cede == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_25 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_25 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_25"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_PostIncident_Deal_25 == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Deal_25"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Narrator**
> "I was here to sign our deal with Duke Reinhart as resolved by the AN. After today, Rizia would own 50 percent of the Aureus gas field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[38]`
Mówca: **Narrator**
> "I was here to sign our deal with Duke Reinhart. After today, Rizia would own 25 percent of the Aureus gas field. Not as much as I wanted, but better than nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[39]`
Mówca: **Narrator**
> "I was here to finalize our concession to Duke Reinhart. After today, the Aureus gas field would officially belong to the Grand Duchy of Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[40]`
Mówca: **Narrator**
> "After exchanging pleasantries, we were led inside. The light of the cameras nearly blinded us as we walked in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[41]`
Mówca: **Narrator**
> "Upon our arrival to Castle Reinhart, we were greeted by the smiling faces of the Palesian delegation as well as Duke Reinhart, waiting for us by the front gate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[42]`
Mówca: **Vina Toras**
> ""Uh... I wouldn't exactly call it *dying*. But yes, thank you, Father. I did my best to offer support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[184]`
  - -> `[183]`

### Węzeł `[43]`
Mówca: **Vina Toras**
> ""There were no issues with the agreement, and I'm told everything is ready for you to sign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[44]`
  - -> `[45]`
  - -> `[46]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great work. Keep it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Vina. You've done an amazing job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, then. Let's get this over with, shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Narrator**
> "We were led into the conference room where the meeting was to take place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Peace_Deal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Peace_Deal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_PostIncident_Peace_Deal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Axel Reinhart**
> ""I'm looking forward to settling this Aureus business and paving the way for a thaw between Pales and Rizia once and for all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[54]`
  - -> `[113]`
  - -> `[56]`

### Węzeł `[52]`
Mówca: **Axel Reinhart**
> ""Today is not just about signing a deal. It's about laying the foundation for cooperation and mutual benefit between Pales and Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[54]`
  - -> `[113]`
  - -> `[56]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Duke Reinhart. Your words mean a lot for me and our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are so kind, Duke Reinhart. Thank you for having us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a pleasure to be here under such promising circumstances. This deal will mark a new chapter for both of our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be fair, I don't need a meeting with you to enjoy my visit to this great city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[57]`
Mówca: **Narrator**
> "He started laughing along with everyone else at the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Axel Reinhart**
> ""I must also thank your daughter. It's rare that a princess has such a knack for diplomatic intricacies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Axel Reinhart**
> ""I must also thank our partners in the Rizian delegation. They were instrumental in working out all the legal particulars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
Mówca: **Axel Reinhart**
> ""Uh... Fair enough!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[64]`
Mówca: **Narrator**
> "Vina blushed and bowed her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[65]`
Mówca: **Narrator**
> "The delegates bowed their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[66]`
Mówca: **Axel Reinhart**
> ""Rizia has agreed to cede half of its AN-acknowledged claim to the Aureus field to Pales, granting the Grand Duchy a 75 percent share in total.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Peace_Deal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Peace_Deal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_PostIncident_Peace_Deal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_25 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_25 == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_25"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_PostIncident_Deal_25 == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Deal_25"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Axel Reinhart**
> ""Both Rizia and Pales accept the Alliance of Nations' resolution. Ownership of the Aureus gas field will be divided evenly between our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Axel Reinhart**
> ""Rizia has agreed to cede its claim to the Aureus gas field, in exchange for lasting peace between the kingdom and the Grand Duchy of Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[81]`
Mówca: **Axel Reinhart**
> ""Both Rizia and Pales accept the Alliance of Nations' resolution. Pales will be granted sole ownership of the Aureus gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Cede == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Cede == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true  or  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Cede == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true  or  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[91]`
Mówca: **Narrator**
> "I was here to finalize our deal with Duke Reinhart. After today, Rizia would own the rights to the Aureus gas field -- and a fully operational pipeline to go with it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_AureusField_HighExtraction = true;
RiziaDLC.Energy_Modifier_AureusGasField = 8)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Economy_AureusField_HighExtraction"] = true;
Variable["RiziaDLC.Energy_Modifier_AureusGasField"] = 8;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // SYMBOLIC DRILLING // INCOME ADDED TURN 7)*
- **Efekt (`userScript`):** `-- SYMBOLIC DRILLING -- INCOME ADDED TURN 7;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true  or  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true  or  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // SYMBOLIC OPENING OF PIPELINE // INCOME ADDED IMMEDIATELY)*
- **Efekt (`userScript`):** `-- SYMBOLIC OPENING OF PIPELINE -- INCOME ADDED IMMEDIATELY;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I missed you, Vina. How was Pales?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Vina Toras**
> ""To be honest, I had a great time here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Vina Toras**
> ""Axel went above and beyond to make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[104]`
  - -> `[107]`
  - -> `[105]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see. Is it *Axel* now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did he? Don't fall for his theatrics. He's a snake through and through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to know. I'm happy you had a good time here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be careful, Vina. It's *Duke Reinhart* and it will stay that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Vina Toras**
> ""Oh God. What are you talking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Vina Toras**
> ""Oh come on, Father. It's not like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Vina Toras**
> ""I think you have a very distorted perception of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Vina Toras**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[112]`
Mówca: **Vina Toras**
> ""I should show you around the Old Town before we leave. It's amazing how well-preserved it is, even in the middle of all the skyscrapers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_Cede == true || RiziaDLC.Pales_PostIncident_Deal_25 == true ||RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true ||RiziaDLC.Diplomacy_Pales_GasField_Cede == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_Cede == true || RiziaDLC.Pales_PostIncident_Deal_25 == true ||RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true ||RiziaDLC.Diplomacy_Pales_GasField_Cede == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] == true  or  Variable["RiziaDLC.Pales_PostIncident_Deal_25"] == true  or Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true  or Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_PostIncident_Deal_Cede == true || RiziaDLC.Pales_PostIncident_Deal_25 == true ||RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true ||RiziaDLC.Diplomacy_Pales_GasField_Cede == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] == true  or  Variable["RiziaDLC.Pales_PostIncident_Deal_25"] == true  or Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true  or Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, yes. Let's just get this over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Narrator**
> "There was a brief silence as his expression soured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Axel Reinhart**
> ""As I was saying...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[119]`
Mówca: **Axel Reinhart**
> ""Rizia has agreed to purchase the sole right  to extract resources from the Aureus Field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[123]`
Mówca: **Axel Reinhart**
> ""Rizia has agreed to cede its claim to the Aureus gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Axel Reinhart**
> ""Both Rizia and Pales accept the Alliance of Nations' resolution. Ownership of the Aureus gas field will be divided evenly between our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[131]`
Mówca: **Axel Reinhart**
> ""Both Rizia and Pales accept the Alliance of Nations' resolution. Pales will be granted sole ownership of the Aureus gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_AureusField_MediumExtraction = true;
RiziaDLC.Energy_Modifier_AureusGasField = 4)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Economy_AureusField_MediumExtraction"] = true;
Variable["RiziaDLC.Energy_Modifier_AureusGasField"] = 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_AureusField_LowExtraction = true;
RiziaDLC.Energy_Modifier_AureusGasField = 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Economy_AureusField_LowExtraction"] = true;
Variable["RiziaDLC.Energy_Modifier_AureusGasField"] = 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[134]`
Mówca: **Patricio Alvarez (R)**
> ""And Pales has agreed to give LesPower shared control over the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[135]`
Mówca: **Narrator**
> "Inside, we were greeted by the Lespian Prime Minister Alvarez and representatives from LesPower."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Patricio Alvarez (R)**
> ""It's good to see you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[137]`
Mówca: **Patricio Alvarez (R)**
> ""In turn, Lespia will be granting extraction rights for one-quarter of the Aureus field to Rizian Oil and Gas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[138]`
Mówca: **Narrator**
> "The assistants placed all the necessary papers in front of us to sign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[139]`
**[WYBÓR GRACZA: "Sign the papers."]** — Mówca: **Player_Romus_Italic**
> "I signed the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[140]`
Mówca: **Narrator**
> "The room broke into a lengthy round of applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy += 6)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] + 6;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_AureusField_HighExtraction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_AureusField_HighExtraction == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_AureusField_HighExtraction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_AureusField_HighExtraction == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_AureusField_HighExtraction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions = true;
RiziaDLC.Policy_Diplomacy_TradeDeal_Pales = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] = true;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Pales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[150]`
Mówca: **Narrator**
> "After exchanging congratulations, we were led outdoors into the courtyard, where a stage had been set up for the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[151]`
Mówca: **Narrator**
> "We stood in front of a massive board with an illustrated map of the Antacean Sea, depicting the Aureus field as a bridge connecting Pales, Rizia and Lespia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[155]`
Mówca: **Narrator**
> "We stood in front of a massive board with an illustrated map of the Antacean Sea, depicting the Aureus field as a bridge connecting Pales and Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[156]`
Mówca: **Narrator**
> "The stage itself was an outlandish construct, dominated by a towering replica of a drilling rig with a huge logo of LesPower on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Narrator**
> "As we stepped onto the stage, the applause of the crowd blended with the loud music from the speakers and the clicks of camera shutters -- overwhelming me for a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[158]`
Mówca: **Narrator**
> "Made to look like a sophisticated machine with oversized dials, levers, and flashing lights, it was less a piece of industrial equipment and more a prop from a science fiction movie."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_DrillingOpening"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`
  - -> `[302]`

### Węzeł `[165]`
Mówca: **Narrator**
> "The stage itself was an outlandish construct, dominated by a colossal replica of a pipeline with a gigantic valve wheel at its center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Narrator**
> "The valve was painted in garish colors and connected to a series of exaggerated, cartoonish pipes that snaked their way across the stage, complete with artificial steam vents and blinking lights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[167]`
Mówca: **Narrator**
> "The geysers were choreographed to erupt in unison with the crescendo of the music."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`
  - -> `[203]`
  - -> `[204]`
  - -> `[205]`

### Węzeł `[168]`
Mówca: **Laurento Esquibel**
> ""I want to applaud you again, Your Majesty, for your decisive actions. We very narrowly avoided an international incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[407]`
  - -> `[172]`
  - -> `[169]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I get it, Laurento. You've thanked me enough already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We couldn't have done it without your help, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know I would have preferred a better deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[172]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[173]`
Mówca: **Laurento Esquibel**
> ""Sorry. I didn't mean to come across as a sycophant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[174]`
Mówca: **Laurento Esquibel**
> ""No time to dwell on that now. We are here to celebrate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[175]`
Mówca: **Laurento Esquibel**
> ""I want to applaud you again, Your Majesty. This was a tense situation, and I believe Rizia made the best of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`
  - -> `[177]`
  - -> `[179]`
  - -> `[176]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I get it, Laurento. You've thanked me enough already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So do I, Mr. Esquibel. Your advice and assistance was invaluable as usual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know I would have preferred a better deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[179]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[180]`
Mówca: **Laurento Esquibel**
> ""Sorry. I do realize how much you hate sycophants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[181]`
Mówca: **Laurento Esquibel**
> ""No time to dwell on that now. We are here to celebrate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how was Pales?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how did the meetings go?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I missed you too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Narrator**
> "Her face gave way to a wide grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[187]`
Mówca: **Narrator**
> "We would also be inaugurating the opening of the Palestream pipeline, delivering gas from the field to Rizia on LesPower's terms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[188]`
Mówca: **Axel Reinhart**
> ""We'll finalize the official details right now. Everything that happens afterwards is just for show.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Axel Reinhart**
> ""So...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Narrator**
> "He gestured at the assistants in the room. They quickly placed enormous files on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[191]`
Mówca: **Narrator**
> "Laurento leaned in and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Romus_Italic**
> "I did not comment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[193]`
Mówca: **Laurento Esquibel**
> ""I certainly didn't expect this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[194]`
  - -> `[468]`
  - -> `[192]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What on earth have they done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, a deal this important deserves a spectacle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[196]`
Mówca: **Laurento Esquibel**
> ""It seems the Palesians went above and beyond for this ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[297]`
  - -> `[302]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[200]`
Mówca: **Laurento Esquibel**
> ""I can't debate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Narrator**
> "He pointed at a mock rig surrounding the stage. There were a series of artificial geysers, engineered to spout water and colored lights at timed intervals, simulating the dramatic discovery of natural gas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. That's a little too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Damn. This is amazing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Organizing this must have cost as much as the drilling facility itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Narrator**
> "As the music came to an end and the applause subsided, I took a closer look at the crowd that was gathered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Narrator**
> "Politicians, journalists and energy executives in their best formal attire were standing somewhat awkwardly amidst this bizarre setting. They cast amused glances at the entertainers who mingled among them - performers dressed as engineers and geologists, complete with exaggeratedly large yellow helmets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[208]`
Mówca: **Narrator**
> "Duke Reinhart then took the microphone and started explaining the importance of Aureus and the deal that had been finalized."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Narrator**
> "After thanking and congratulating LesPower, he turned towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_AureusField_HighExtraction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_AureusField_HighExtraction == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_AureusField_HighExtraction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_AureusField_HighExtraction == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_AureusField_HighExtraction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[213]`
Mówca: **Narrator**
> "After congratulating the delegates and thanking me, he turned towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Axel Reinhart**
> ""...And I invite King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_NoRescue"] == true  or  Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_NoRescue"] == true  or  Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Axel Reinhart**
> ""...And I invite His Majesty, King Romus of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[219]`
Mówca: **Narrator**
> "I took the microphone amidst the applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[223]`
  - -> `[520]`
  - -> `[257]`

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart, my friend, I want to thank you from the bottom of my heart for your understanding and cooperation over these past few years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ladies, gentlemen, dear friends. I would like to thank Duke Reinhart for inviting us to attend this grand ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Reinhart, Mr. Alvarez, LesPower and ladies and gentlemen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false && RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false && RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false  and  Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == false && RiziaDLC.Policy_Economy_AureusField_Extractions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false  and  Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Reinhart, esteemed delegates, ladies and gentlemen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart, Prime Minister Alvarez. I want to thank you both from the bottom of my heart for your understanding and cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[238]`
  - -> `[232]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are here to celebrate a truly significant event. A testament to our countries’ unbreakable bonds and ever-growing ambition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relations between Rizia, Pales and Lespia have reached a new peak. Our peaceful division of rights to the Aureus field reflects that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite a recent deterioration of Rizian-Palesian relations, we have come together to achieve a historic agreement -- a testament to true diplomacy and our mutual desire for cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite attempts to divide our countries, we deliberately chose the path to peace and mutual growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Today, we have concluded a historic agreement, which is a testament to true diplomacy and our mutual desire for cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relations between Rizia and Pales have reached a new peak. Our agreement regarding the Aureus field reflects that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[245]`
  - -> `[247]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_AureusField_Extractions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[248]`
  - -> `[250]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are more than excited about the massive amounts of energy this gas field will produce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks to our cooperation with Pales, Rizia will soon be transporting billions of cubic meters of natural gas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am honored to announce the official agreement between our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let us not forget that, despite holding the right to claim part ownership of Aureus, Rizia decided to cede all of our rights to our partners in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the name of peace and friendship, my kingdom selflessly gave away our claim to this massive new gas resource.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am honored to announce the official agreement between our three countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[255]`
  - -> `[264]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_AureusField_Extractions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would like to note that extracting and transporting gas is not as easy as some may think. It will be a great undertaking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This project has many benefits not only for our people and our country, but also for our neighbors and the region as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[260]`
**[WYBÓR GRACZA: "[Gesture at the geysers] "Believe me, ladies and gentlemen, I am as shocked as every one of you.""]** — Mówca: **Player_Romus**
> ""Believe me, ladies and gentlemen, I am as shocked as every one of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Narrator**
> "The crowd burst out in laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This field will hopefully have many benefits not only for Pales and its people, but also for its neighbors and the region as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks to the support and professionalism of LesPower, the project is already being implemented in a timely manner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks to the support and professionalism of our Palesian counterparts, future energy deals will be completed in a flash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`
  - -> `[271]`
  - -> `[272]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am certain that in the future, Rizia and Pales will implement many more mutually beneficial joint projects, whether in energy or other fields.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must point out that we live in a volatile region, with conflicts over resources, ideology and religion brewing on all fronts. Let Rizia and Pales serve as an example to all those around us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is my intention that Rizia continue on the path of peaceful conflict resolution. We will remain one of the most reliable trading partners in Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would like to congratulate the Palesian leadership for displaying the political courage and will to accomplish this extraordinary partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[276]`
  - -> `[279]`
  - -> `[535]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before I finish, I would like to highlight the importance of Palesian-Rizian friendship to Southern Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before I finish, I would like to highlight the importance of Lespian-Rizian friendship to Southern Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true && RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true && RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true  and  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_AureusField_Extractions == true && RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true  and  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before I finish, I would like to highlight how important it is for the monarchies of Merkopa to stick together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't bore you all for much longer. I know you want to see what happens when we turn that wheel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[527]`
  - -> `[530]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must not forget. Major powers like us have a responsibility to our region. Today, we are showing the world that we take our duties seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Prime Minister Alvarez and I have had our differences in the past. I hope this agreement will go some way towards mending those fences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Kingdom of Rizia believes in strengthening its cooperation with the member states of the ATO. There is so much we can gain from each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[531]`
  - -> `[288]`

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Both of our countries are important exporters of natural resources. I believe energy giants like us have a responsibility to the region. And today, we are showing the world that we take our duties seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart and I have had our differences in the past. I hope this initiative will go some way towards mending those fences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Kingdom of Rizia sees the people of Pales as our brothers and sisters. Let today be a step towards unity between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_NegotiatingPower += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`
  - -> `[292]`

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Both the Rizian and Palesian monarchies are important exporters of natural resources. I believe energy giants like us have a responsibility to the region. And today, we are showing the world that we take our duties seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In these turbulent times, the guiding hand of a king or a queen -- or a Duke or a Duchess -- is more necessary than ever. We shall prove to the world exactly what we are capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We see the Grand Duchy of Pales as a potential future GRACE member, and a powerful ally. Let today be a step towards that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now... Let the inauguration of the Palestream pipeline begin!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[312]`
  - -> `[313]`
  - -> `[476]`

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a closing word, I would like to thank everyone who has worked so hard on the design and construction of this gas pipeline: the engineers and builders, as well as the employees of all the contractors involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now... Let the inauguration of the Aureus drilling rig begin!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a closing word, I would like to thank everyone who has worked so hard on the design and construction of this drilling facility: the engineers and builders, as well as the employees of all the contractors involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now... Let the ceremonies begin!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a closing word, I would like to thank everyone who has worked so hard on reaching a resolution on Aureus. This is an asset for the entire region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish success to all of you and to all of us in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Border == true || RiziaDLC.War_Incident_Naval == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == true  or  Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Before I finish, I would also like to say a few words about the tragic events that occurred recently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[523]`
  - -> `[308]`
  - -> `[309]`

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a sad reality that misunderstandings and lack of communication led to the loss of lives. But we must put this behind us and look ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks to the conciliatory attitude of Duke Reinhart, we managed to reach an agreement in time to avoid further bloodshed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Kingdom of Rizia believes in compassion. We not only forgave each other, but also reached a historic resolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am still deeply saddened by the loss of life that occurred. We must never forget this incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you and have a good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Congratulations, everybody!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God bless you all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia axa Pales!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[316]`
Mówca: **Narrator**
> "The crowd roared with applause. I gave the microphone back to Duke Reinhart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_AureusField_Extractions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[323]`
Mówca: **Narrator**
> "He shook my hand and gestured for Prime Minister Alvarez to join us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[324]`
Mówca: **Narrator**
> "As the moment of the ceremonial valve-turning approached, we walked to the massive valve in the middle of the stage and placed our hands on it, posing for the cameras as we did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`
  - -> `[496]`

### Węzeł `[325]`
Mówca: **Narrator**
> "Instead of the expected mechanical hum, the speakers erupted with the sound of whistles and party horns. The music swelled and the geysers went off in unison, enveloping the area in a colorful mist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[326]`
Mówca: **Narrator**
> "As the main event approached, a gigantic faux control panel was wheeled onto the stage. The panel, festooned with blinking lights and oversized buttons, was set for the ceremonial ‘activation’ of the gas field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[327]`
Mówca: **Narrator**
> "Duke Reinhart and Prime Minister Alvarez were guided towards the panel, where they were handed gloves to operate the machinery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Narrator**
> "Duke Reinhart, Prime Minister Alvarez and I were guided towards the panel. We placed our hands on it, posing for the cameras as we did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`
  - -> `[511]`

### Węzeł `[329]`
Mówca: **Narrator**
> "With a theatrical flourish, they pressed the buttons and the mock rig came to life. The music swelled and the geysers went off in unison, enveloping the area in a colorful mist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[330]`
Mówca: **Narrator**
> "There was a series of industrial sounds as the mock rig came to life. The music swelled and the geysers went off in unison, enveloping the area in a colorful mist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Narrator**
> "After a few more minutes of picture-taking, we left the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[332]`
Mówca: **Narrator**
> "I couldn't help but feel relieved once we were finally out of Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatusImmediately("Rizia_Country_Pales", "Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);
RiziaDLC.Policy_Economy_PalesPipeline_Project = true;)*
- **Efekt (`userScript`):** `AddTokenStatusImmediately("Rizia_Country_Pales","Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);
Variable["RiziaDLC.Policy_Economy_PalesPipeline_Project"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_AureusField_Extractions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[337]`
Mówca: **Axel Reinhart**
> ""To our future partners!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`
  - -> `[465]`
  - -> `[464]`
  - -> `[459]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // SYMBOLIC DRILLING // NO INCOME)*
- **Efekt (`userScript`):** `-- SYMBOLIC DRILLING -- NO INCOME;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Narrator**
> "Upon our arrival to Castle Reinhart, we were greeted by the smiling faces of the Palesian and Lespian delegations as well as Duke Reinhart, waiting for us by the front gate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[343]`
Mówca: **Patricio Alvarez (R)**
> ""Lespia and LesPower are incredibly pleased that your nations have reached a mutual understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`
  - -> `[451]`
  - -> `[447]`
  - -> `[456]`

### Węzeł `[344]`
Mówca: **Patricio Alvarez (R)**
> ""We will assume shared control over three-quarters of the field, while Rizian Oil and Gas will control the remaining 25 percent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[345]`
Mówca: **Patricio Alvarez (R)**
> ""The contract for extraction and transportation of Palesian gas has been given to our state corporation LesPower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[346]`
Mówca: **Patricio Alvarez (R)**
> ""Rizian Oil and Gas will control the rights to the Rizian half of the field, while Lespia will share control over the Palesian half.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Patricio Alvarez (R)**
> ""Extraction and transportation from that half of the field will be carried out by our state corporation LesPower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[348]`
Mówca: **Patricio Alvarez (R)**
> ""From this point on, the extraction and transportation of Palesian gas will be handled by us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[349]`
Mówca: **Patricio Alvarez (R)**
> ""And LesPower of Lespia will receive the sole right to extract resources from the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[353]`
Mówca: **Narrator**
> "After me, the documents were also passed to Prime Minister Alvarez. As soon as he finished signing, the room broke into a lengthy round of applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[354]`
Mówca: **Axel Reinhart**
> ""To our future partners!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Narrator**
> "Prime Minister Alvarez then took the microphone and started explaining the importance of Aureus and the deal that had been finalized."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Narrator**
> "After a brief introduction, he gave the microphone to Duke Reinhart. The Palesian leader made his own brief speech before turning towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DisableToken("Rizia_Event_Aureus");)*
- **Efekt (`userScript`):** `DisableToken("Rizia_Event_Aureus");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You must be desperate to get back and see Manus. As I promised, you may announce your courtship at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_ApproveAfterPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_ApproveAfterPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_ApproveAfterPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[365]`
Mówca: **Vina Toras**
> ""Manus... Yes, of course. Thank you so much, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Narrator**
> "As she spoke, her gaze inadvertently traveled to where Duke Reinhart was standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_PalesPipeline_Project = false;
RiziaDLC.Policy_Economy_PalesPipeline_Completed = true;
RemoveTokenStatusImmediately("Rizia_Country_Pales", "Progress_Construction_PalesPipeline");
EnableReport("Construction_Pales_PipelineCompleted");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_Economy_PalesPipeline_Project"] = false;
Variable["RiziaDLC.Policy_Economy_PalesPipeline_Completed"] = true;
RemoveTokenStatusImmediately("Rizia_Country_Pales","Progress_Construction_PalesPipeline");
EnableReport("Construction_Pales_PipelineCompleted");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `AddConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Vina Toras");)*
- **Efekt (`userScript`):** `AddConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Patricio Alvarez (R)");)*
- **Efekt (`userScript`):** `AddConversant("Patricio Alvarez (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `AddConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Axel Reinhart");
RemoveConversant("Patricio Alvarez (R)");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `RemoveConversant("Axel Reinhart");
RemoveConversant("Patricio Alvarez (R)");
RemoveConversant("Vina Toras");
RemoveConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaDLC.Relations_VinaManus_ApproveAfterPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaDLC.Relations_VinaManus_ApproveAfterPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaDLC.Relations_VinaManus_ApproveAfterPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales = true; RiziaDLC.VinaManus_Together = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_Gossip_VinusAfterPales"] = true;
Variable["RiziaDLC.VinaManus_Together"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_ForThePeople", "R_ForThePeople_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_ForThePeople","R_ForThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_RH_Gossip_VixelDealCerenomy = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_Gossip_VixelDealCerenomy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_RH_VinaReturnsFromPales = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_VinaReturnsFromPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("DealSigning");)*
- **Efekt (`userScript`):** `PlaySoundEffect("DealSigning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("SigningApplause");)*
- **Efekt (`userScript`):** `PlaySoundEffect("SigningApplause");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("SigningApplause");)*
- **Efekt (`userScript`):** `PlaySoundEffect("SigningApplause");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CheerCrowd");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CheerCrowd");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_GasCorpPlaque"))*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_GasCorpPlaque");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[392]`
Mówca: **Narrator**
> "In the car, I glanced over at the PAR Aureus Plaque, a celebratory gift from the Rizian Oil and Gas Corporation, sitting snugly on the seat next to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: IsStatusInToken("Rizia_Country_Pales", "Progress_Construction_PalesPipeline"))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: IsStatusInToken("Rizia_Country_Pales", "Progress_Construction_PalesPipeline"))*
- **Warunek (`conditionsString`):** `IsStatusInToken("Rizia_Country_Pales","Progress_Construction_PalesPipeline")`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(IsStatusInToken("Rizia_Country_Pales", "Progress_Construction_PalesPipeline")))*
- **Warunek (`conditionsString`):** `(IsStatusInToken("Rizia_Country_Pales","Progress_Construction_PalesPipeline")) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[396]`
Mówca: **Narrator**
> "The city was familiar to me by now. But the atmosphere was much more cheerful and cordial than it had been during my last visit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[397]`
Mówca: **Narrator**
> "For the second time since my coronation, our convoy drove steadily across the cobbled streets of Old Town Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[398]`
Mówca: **Laurento Esquibel**
> ""Much obliged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true && RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
  - -> `[401]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true && RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true && RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The best? We lost what should rightfully belong to us!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[403]`
Mówca: **Laurento Esquibel**
> ""But we avoided an international incident. That's something to be proud of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`
  - -> `[406]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false && RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false && RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false  and  Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false && RiziaDLC.Diplomacy_Pales_GasField_Buy == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false  and  Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But at what cost? Lespia's getting the gas that should belong to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[411]`
Mówca: **Laurento Esquibel**
> ""If we play nice with both nations, we could yet claim a greater share of the rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[412]`
Mówca: **Laurento Esquibel**
> ""Much obliged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Peace_Deal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`
  - -> `[415]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Peace_Deal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_PostIncident_Peace_Deal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[416]`
Mówca: **Narrator**
> "Vina was already inside, standing next to the Palesian foreign affairs team. She ran to me the moment I entered the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Vina Toras");)*
- **Efekt (`userScript`):** `AddConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[418]`
Mówca: **Vina Toras**
> ""Father! I can't tell you how good it is to see you again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`
  - -> `[421]`
  - -> `[423]`
  - -> `[425]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am so, so sorry for what I put you through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Vina Toras**
> ""There were some scary moments. But I never actually believed Axel would let anything happen to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`
  - -> `[438]`
  - -> `[430]`
  - -> `[104]`

### Węzeł `[421]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did anyone hurt you? You can tell me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[422]`
Mówca: **Vina Toras**
> ""I'm just fine. Axel and the Palesians took good care of me the whole time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`
  - -> `[438]`
  - -> `[430]`
  - -> `[104]`

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for your hard work despite the unpleasantness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[424]`
Mówca: **Vina Toras**
> ""Ehm... you're welcome. I was just doing my diplomatic duty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`
  - -> `[438]`
  - -> `[430]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`
  - -> `[427]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[428]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thank the good Lord that you are safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[429]`
Mówca: **Vina Toras**
> ""I was never in any real trouble. Axel and the Palesians made sure I was taken care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`
  - -> `[438]`
  - -> `[430]`
  - -> `[104]`

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This was your greatest challenge as a princess yet, and you passed with flying colors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_ApproveAfterPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_ApproveAfterPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_ApproveAfterPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nearly losing you made me realize how much your happiness means to me. Once we're back in Rizia, we'll announce your relationship with Manus straight away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[435]`
Mówca: **Narrator**
> "She gave me a quick hug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[436]`
Mówca: **Vina Toras**
> ""The houses will be fine with it. You'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[437]`
Mówca: **Narrator**
> "She beamed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`
  - -> `[440]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm just grateful that the culprit has been jailed and we can put this whole mess behind us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[442]`
Mówca: **Vina Toras**
> ""I still can't believe Duchess Azaro would sabotage our deal like that. She's every bit as war-hungry as the stereotypes""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Peace_Deal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[445]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Peace_Deal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_PostIncident_Peace_Deal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[446]`
Mówca: **Vina Toras**
> ""The incident slowed things down, of course, but my Palesian counterparts and I managed to get the paperwork into shape. All you have to do is sign it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true && RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`
  - -> `[449]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true && RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true && RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've earned the right to gloat. Mr. Prime Minister. You and Reinhart won fair and square.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. I'm happy we managed to see through the nefarious forces trying to set us against each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Energy really is the great unifier, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[453]`
Mówca: **Narrator**
> "The smile dropped from his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[454]`
Mówca: **Patricio Alvarez (R)**
> ""I'll say. And there's more than enough in the Aureus field to go round.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[455]`
Mówca: **Patricio Alvarez (R)**
> ""Your own showing wasn't half bad, Your Majesty. You had us worried for a moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What did your friend Dwight have to say about all this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[457]`
Mówca: **Patricio Alvarez (R)**
> ""President Walker? I wouldn't know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[458]`
Mówca: **Patricio Alvarez (R)**
> ""I'll drink to that. After the ceremony, obviously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`
  - -> `[461]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll drink to that. What about you, Alvarez?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[463]`
Mówca: **Patricio Alvarez (R)**
> ""Hm. You said it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To South Merkopa's newest energy superpowers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To the extraordinary opportunities Aureus will bring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To international cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a good thing Mother's not here. Wouldn't want her getting ideas for her next outfit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`
  - -> `[470]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[471]`
Mówca: **Laurento Esquibel**
> ""She would definitely appreciate... whatever that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`
  - -> `[474]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[475]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Making a mockery of God's wonders... who do they think they are?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`
  - -> `[478]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`
  - -> `[481]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_AureusField_Extractions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`
  - -> `[484]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[485]`
Mówca: **Narrator**
> "He shook my hand and beckoned me to follow him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[486]`
Mówca: **Narrator**
> "He shook my hand and smiled appreciatively as I was ushered into the wings. Prime Minister Alvarez triumphantly took my place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`
  - -> `[489]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[489]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[490]`
Mówca: **Narrator**
> "As the moment of the ceremonial valve-turning approached, the three of us walked to the massive valve in the middle and placed our hands on it, posing for the cameras as we did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[501]`

### Węzeł `[491]`
**[WYBÓR GRACZA: "Turn the valve."]** — Mówca: **Player_Romus_Italic**
> "With a dramatic countdown, we turned the wheel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[492]`
Mówca: **Narrator**
> "Instead of the expected mechanical hum, the speakers erupted with the sound of whistles and party horns. The music swelled and the geysers went off in unison, enveloping the area in a colorful mist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[493]`
**[WYBÓR GRACZA: "Turn the valve."]** — Mówca: **Player_Romus_Italic**
> "With a dramatic countdown, Reinhart and I turned the wheel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get Princess Vina up here. This honor belongs to her as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[495]`
Mówca: **Narrator**
> "My daughter eagerly bounded up to the stage. Together, the three of us turned the wheel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`
  - -> `[498]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[499]`
Mówca: **Narrator**
> "Through the fog, I noticed Vina and the Duke of Pales grinning at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[500]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get Princess Vina up here. This honor belongs to her as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`
  - -> `[503]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[504]`
Mówca: **Narrator**
> "My daughter eagerly bounded up to the stage. Together, all four of us turned the wheel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`
  - -> `[507]`

### Węzeł `[506]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_AureusField_Extractions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[508]`
Mówca: **Narrator**
> "We stood in front of a massive board with an illustrated map of the Antacean Sea, depicting the Aureus field as a bridge connecting Pales and Lespia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[509]`
**[WYBÓR GRACZA: "Press the button."]** — Mówca: **Player_Romus_Italic**
> "With a dramatic countdown, Reinhart, Alvarez and I each pressed one of the buttons on the panel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[510]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get Princess Vina up here. This honor belongs to her as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`
  - -> `[513]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[513]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[514]`
Mówca: **Narrator**
> "My daughter eagerly bounded up to the stage. She, Reinhart, Alvarez and I each pressed one of the buttons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[515]`
Mówca: **Narrator**
> "With a series of industrial sounds, the mock rig came to life. The music swelled and the geysers went off in unison, enveloping the area in a colorful mist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`
  - -> `[518]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_AureusField_Extractions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[519]`
Mówca: **Narrator**
> "After a few more minutes of picture-taking, they left the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`
  - -> `[522]`

### Węzeł `[521]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[226]`

### Węzeł `[523]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`
  - -> `[525]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, we identified and punished the responsible party, enabling us to mend our relations and turn over a new leaf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[527]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_Nationalization == true || RiziaDLC.MITZ_ScrewedOverLespia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`
  - -> `[529]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_Nationalization == true || RiziaDLC.MITZ_ScrewedOverLespia == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true  or  Variable["RiziaDLC.MITZ_ScrewedOverLespia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_ITZVote_Nationalization == true || RiziaDLC.MITZ_ScrewedOverLespia == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == true  or  Variable["RiziaDLC.MITZ_ScrewedOverLespia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[530]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father King Valero was wrong to mistrust Lespia. With Mr. Alvarez at the helm, I believe the Republic will be a valuable partner to us in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`
  - -> `[533]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[534]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My kingdom believes that our partnerships with our neighbors are our greatest asset. We shall continue to foster those partnerships, even at the expense of our own wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`
  - -> `[537]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`
  - -> `[540]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_AureusDeal_PipelineOpening"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[541]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't bore you all for much longer. I know you want to see what happens when we turn on that rig.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can see you are getting impatient. I will bring my speech to a close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[545]`
Mówca: **Narrator**
> "He looked at me with a sly smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[546]`
Mówca: **Patricio Alvarez (R)**
> ""As a gesture of gratitude for the magnanimity of King Romus, we shall also fund the construction of a pipeline from the Aureus field to Rizia. With the volume and price of gas deliveries to be agreed on -- or not -- at a later date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`
  - -> `[549]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_AureusField_Extractions == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Economy_AureusField_Extractions == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_AureusField_Extractions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_PalesPipelineConstruction"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`
  - -> `[553]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[554]`
Mówca: **Narrator**
> "I was here to finalize our deal with Duke Reinhart. After today, Rizia would own the rights to the Aureus gas field -- and a fully operational pipeline to go with it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Signing an energy deal with Pales and Lespia", "Old Town", "Grand-Duchy of Pales");)*
- **Efekt (`userScript`):** `SetRichPresence("Signing an energy deal with Pales and Lespia","Old Town","Grand-Duchy of Pales");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
