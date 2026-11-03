# Rizia/Turn 4/A_CouncilTalkAboutPales

- **ID konwersacji:** `313`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Rizia/Turn_04/313_A_CouncilTalkAboutPales.md`
- **Liczba węzłów dialogowych:** 418
- **Liczba wyborów gracza:** 83

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[80]** Elena Werner
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Coronation_Speech_TakeBackLand`
- `RiziaDLC.Lucita_CompromisingPhoto`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed`
- `RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project`
- `RiziaDLC.Prologue_FriendlyToPales`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Relations_Lucita_Romance`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Resources_EnergyModifiersTotal`
- `RiziaDLC.Resources_Military_NavalBombardmentCapability`
- `RiziaDLC.Security_Pales_SendSpecialOps`
- `RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport`
- `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport`
- `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLC.Turn02_Diplomacy_Intention_ATO`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Discovery`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Lespia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Morella_NegotiatingPower`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Enable_Policy_RD_Order_ExpandFortAlesNavalBase`
- `RiziaDLC.Enable_Policy_RD_Order_ExpandTeradorAirbase`
- `RiziaDLC.Enable_Policy_RD_Order_PalesAdminDistrict_StrengthenedBorderFort`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_Pacifist`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Lucita_Romance`
- `RiziaDLC.Resources_Authority`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed`
- `RiziaDLCSupport.Codex_Characters_ForeignLeaders_DijerkDanOtkende`
- `RiziaDLCSupport.Codex_Characters_ForeignLeaders_DijerkDanOtkende1952`
- `RiziaDLCSupport.Codex_Characters_ForeignLeaders_MaartinVanHoorten`
- `RiziaDLCSupport.Codex_Locations_Countries_Agnolia`
- `RiziaDLCSupport.Codex_Locations_Countries_Agnolia_1952`
- `RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade`
- `RiziaDLCSupport.Reports_Turn04_NavyDeployed`
- `RiziaDLCSupport.Reports_Turn04_PorteDrazon_BFFUnmasked`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 13
- **Węzły modyfikujące stan gry:** 25

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Enable_Policy_RD_Order_PalesAdminDistrict_StrengthenedBorderFort`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Lucita_Romance`
- `RiziaDLC.Resources_Authority`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll`
- `RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize`
- `RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed`
- *...oraz 1 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[67]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] = true;`
- Węzeł `[68]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] = true;`
- Węzeł `[69]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] = true;`
- Węzeł `[76]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] = true;`
- Węzeł `[87]` (Paskal Beniwoll): `AddConversant("Laurento Esquibel"); AddConversant("Elena Werner"); AddConversant("Hugo Toras"); A...`
- Węzeł `[92]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Reports_Turn04_NavyDeployed"] = true;`
- Węzeł `[101]` (Paskal Beniwoll): `End();`
- Węzeł `[102]` (Paskal Beniwoll): `PlayLoopedMusic("R_UpInTheAir","R_UpInTheAir_Loop");`
- *...oraz 17 innych węzłów ze skryptami.*

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
  - -> `[417]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I had called a council meeting in Fort Ales to discuss our strategy in the Pales gas dispute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The city was named after its most famous building, a Valgish fortress that now served as the government headquarters for the Pales Administrative District."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Titus escorted me down the hallway to a nondescript conference room, where Laurento, Lucita, Elena and Hugo were already waiting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[6]`
Mówca: **Narrator**
> "I took a seat across from Lucita."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "Don't look at her."]** — Mówca: **Player_Romus_Italic**
> "I looked around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Good morning, Your Majesty. Should we fill you in on the situation so far?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've read the reports. I know about the Palesian drillship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[11]`
Mówca: **Laurento Esquibel**
> ""Duke Reinhart is now under the impression that the entire gas field belongs to Pales. He has ordered that exploratory drilling begin immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "Look at her."]** — Mówca: **Player_Romus_Italic**
> "We made eye contact for a brief moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[13]`
Mówca: **Laurento Esquibel**
> ""I'll take it from here. As you know, our joint team of researchers recently completed their assessment of the gas field between Pales and Rizia -- tentatively nicknamed Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Elena Werner**
> ""However, a few days after our team's return to port, we received the news that the Palesians had made a different decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[15]`
Mówca: **Laurento Esquibel**
> ""The Rizian surveyors determined that the field lay in both Rizian and Palesian territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[16]`
Mówca: **Elena Werner**
> ""Then where should we start, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... why is this a dispute? I thought our maritime borders were clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do we now know how much gas the field contains?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's enough information. I'm ready to discuss our response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[20]`
Mówca: **Elena Werner**
> ""We still don't have exact numbers. But the surveyors have confirmed that it's a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Elena Werner**
> ""Quite possibly more than the current natural gas reserves of Rizia and Pales combined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Lucita Azaro**
> ""In other words, whichever country controls the Aureus field will become Merkopa's next energy superpower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[23]`
Mówca: **Laurento Esquibel**
> ""They've been shifting for the past century.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Laurento Esquibel**
> ""The late Empire of Valgos used to control the waters between Pales and Caleqabiz. But the area came into question when the island joined Rizia in 1855.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[25]`
Mówca: **Elena Werner**
> ""Ah, yes. ANDOR.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Laurento Esquibel**
> ""And in case of overlap, no one country may exploit those resources without the other's agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[31]`
  - -> `[32]`

### Węzeł `[27]`
Mówca: **Elena Werner**
> ""A nation has the sovereign right to any undersea gas and oil wells located within 200 kilometers of its coast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So it's clear. Pales is breaking the law by claiming sole ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Laurento Esquibel**
> ""The borders that Rizia recognizes today are the ones defined by the 1942 AN Directive on Offshore Resources. According to those, the field should be split almost exactly evenly between our two nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[30]`
Mówca: **Laurento Esquibel**
> ""Technically, no. Reinhart's predecessor signed ANDOR, but the Duke has yet to ratify it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are both Pales and Rizia signatories of this directive?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What happens if a country violates that directive?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Laurento Esquibel**
> ""Rizia has both signed and ratified ANDOR. Reinhart's predecessor signed the directive, but the Duke has yet to ratify it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[34]`
Mówca: **Lucita Azaro**
> ""They'd be subject to prosecution in an international court. And any military action against them would be fully justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Laurento Esquibel**
> ""Technically, Pales wouldn't be violating ANDOR by drilling without Rizia's consent. Reinhart's predecessor signed the directive, but the Duke has yet to ratify it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Gas Dispute Question Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[58]`
  - -> `[61]`
  - -> `[64]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Gas Dispute Question Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Gas Dispute Question Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[39]`
Mówca: **Laurento Esquibel**
> ""You established a rapport with Duke Reinhart prior to your coronation. Perhaps there's a way to build on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[231]`
  - -> `[229]`
  - -> `[230]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FriendlyToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FriendlyToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FriendlyToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FriendlyToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FriendlyToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Laurento Esquibel**
> ""I know you and Duke Reinhart don't have much of a rapport. But it might not be too late to come to an understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[226]`
  - -> `[225]`

### Węzeł `[44]`
Mówca: **Laurento Esquibel**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't we just split the field 50-50 with Pales. That's what we have a legal claim to, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if I were to let Pales keep its claim to the entire field?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Does Rizia need the gas from the field?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Gas Dispute Question Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[49]`
Mówca: **Elena Werner**
> ""Yes, that was the outcome I was hoping for before this incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Elena Werner**
> ""But it seems that without the aid of a third party, sharing the field will be more difficult than expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`
  - -> `[254]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Pales Diplomacy Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[73]`
  - -> `[272]`
  - -> `[77]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Pales Diplomacy Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[53]`
Mówca: **Narrator**
> "The meeting drew to a close."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "I spent a sleepless night in Fort Ales, wondering what would happen when the ship from Pales got to its destination."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Discovery == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Discovery == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Discovery"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Discovery == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize == true || RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Discovery"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_Borders"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_FieldSize"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_GasHub_RiziaNeed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll == true || RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede == true ||RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll == true || RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede == true ||RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede"] == true  or Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll == true || RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede == true ||RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll"] == true  or  Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede"] == true  or Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Share"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would welcome any other suggestions from my councilors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[81]`
Mówca: **Laurento Esquibel**
> ""The Palesians furthermore state that as a sparsely populated island, Caleqabiz should not have the same maritime radius as mainland Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[125]`
  - -> `[127]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_CompromisingPhoto == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_CompromisingPhoto == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_CompromisingPhoto == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Narrator**
> "She blushed. The other councilors studiously trained their eyes away from us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[86]`
Mówca: **Narrator**
> "She blushed. The other councilors didn't seem to notice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Laurento Esquibel");
AddConversant("Elena Werner");
AddConversant("Hugo Toras");
AddConversant("Lucita Azaro");

// Adds the conversant with the character name in database)*
- **Efekt (`userScript`):** `AddConversant("Laurento Esquibel");
AddConversant("Elena Werner");
AddConversant("Hugo Toras");
AddConversant("Lucita Azaro");
-- Adds the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[91]`
Mówca: **Narrator**
> "My daughter had requested to stay home this time around, claiming she was feeling unwell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn04_NavyDeployed = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_NavyDeployed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance > 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[7]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Romance > 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Romance"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_CompromisingPhoto == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_CompromisingPhoto == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_CompromisingPhoto == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_CompromisingPhoto"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Narrator**
> "The other councilors busied themselves with the documents they were holding. Hugo finally spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[100]`
Mówca: **Narrator**
> "My fellow councilors were all poring over various documents. Hugo finally stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_UpInTheAir", "R_UpInTheAir_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_UpInTheAir","R_UpInTheAir_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[103]`
Mówca: **Narrator**
> "Lucita had a worried look on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Lucita Azaro**
> ""A Palesian drillship departed the port of Remaz at 0800 this morning. It is expected to reach the field by this time tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[105]`
Mówca: **Lucita Azaro**
> ""Your Majesty, I have advocated for caution regarding Pales in the past. But this strikes me as highly concerning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[110]`
  - -> `[111]`
  - -> `[113]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I completely agree, Lucita. We cannot ignore this obvious provocation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Romance > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Romance"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I share those concerns, Duchess. The Palesians were out of line to send that ship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still believe that caution is called for. I want to know all the details before we decide on our reaction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[112]`
Mówca: **Narrator**
> "Hugo cast a sidelong glance at my use of Lucita's first name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure there is a logical explanation. We shouldn't assume this was an act of aggression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[114]`
Mówca: **Hugo Toras**
> ""A response from Rizia is certainly warranted. I called this meeting today to decide on our course of action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[115]`
Mówca: **Hugo Toras**
> ""Very wise of you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[116]`
Mówca: **Hugo Toras**
> ""I agree, Your Majesty. But we cannot let the act go unremarked upon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Hugo Toras**
> ""Provocation or not, it indeed mustn't be ignored. I called this meeting today to decide our course of action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Laurento Esquibel**
> ""We have a meeting set with Duke Reinhart in two days. By which time the ship will have reached its destination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Laurento Esquibel**
> ""It is my hope that the Palesians are still open to negotiating the field's ownership, and that this is just a tactic to give them an edge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Elena Werner**
> ""You're getting ahead of yourself, Laurento. The King should be as informed about this dispute as possible before heading to Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right as usual, Ms. Werner. I want to know everything I can about the disputed field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm all caught up on the details. Let's get to the meat of the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's fair enough. What are we even using Caleqabiz for, anyway?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""Its strategic location between mainland Merkopa and Kyrute makes it a very useful port and naval base. And we should not forget about the presence of the exiled ex-Duchess Angelica Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But that's nonsense, right? It wouldn't hold up in an international court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Elena Werner**
> ""That's debatable, Your Majesty. With enough legal firepower and international support, Pales could have a case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare they disparage our island? They will pay for their impertinence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Hugo Toras**
> ""Caleqabiz may be small, but it holds large strategic importance. It is unfair to call it a lesser part of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal <= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal <= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_EnergyModifiersTotal <= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[133]`
Mówca: **Elena Werner**
> ""I'll be blunt, Your Majesty. Our existing gas reserves are dwindling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Elena Werner**
> ""The Esqiris field off of Valenqiris is on the verge of shutting down if we do not invest in its expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true || RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true || RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project == true || RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EsqirisGasFieldExpansion_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[138]`
Mówca: **Elena Werner**
> ""Our expansion of the Esqiris field will increase gas production, though access to even half of Aureus would yield better results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Elena Werner**
> ""We are not desperate. For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true || RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true || RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true  or  Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true || RiziaDLC.Situation_Economy_Sordland_ResortDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true  or  Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Elena Werner**
> ""President Ewald Alphonso was pleased enough with our trade deal that he has hinted at offering us a stake in his own gas company, Gasom. But next year's Sordish elections may jeopardize that offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`
  - -> `[146]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Elena Werner**
> ""Although we rejected Sordland's trade deal, President Alphonso has hinted at an opportunity to invest in his own gas company, Gasom, through back channels. But next year's Sordish elections may jeopardize that offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[146]`
  - -> `[145]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds shady. I wouldn't be surprised if this Gasom was on the verge of bankruptcy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alphonso's slipping in the polls already, eh? I wonder who the next guy will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds promising nonetheless. Follow up that lead if you can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just as well. I've had enough dealings with the Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Elena Werner**
> ""Their gas holdings are quite prodigious. I wouldn't write them off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[150]`
Mówca: **Elena Werner**
> ""It's too early to tell. He could still pull off a win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[151]`
Mówca: **Elena Werner**
> ""Whatever the state of the company, there's no denying that Sordland has prodigious gas holdings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Elena Werner**
> ""Yes, I'll keep you posted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Energy > 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Energy > 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Elena Werner**
> ""Outside of gas, our overall energy reserves are healthy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Elena Werner**
> ""Sordish or otherwise, we could really use the gas to bolster our overall energy reserves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true || RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Rumburg_AverageEnergyExport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
Mówca: **Elena Werner**
> ""And we can't forget about the contract we signed with Rumburg. We are exporting and making good on our energy obligations already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[165]`
Mówca: **Elena Werner**
> ""But we don't know what the future might bring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[166]`
Mówca: **Elena Werner**
> ""We're running low as it is, and we don't know what the future might bring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[167]`
Mówca: **Elena Werner**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[168]`
Mówca: **Lucita Azaro**
> ""Actually, I have some additional information that could influence our response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal <= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_EnergyModifiersTotal <= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_EnergyModifiersTotal <= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_EnergyModifiersTotal"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Elena Werner**
> ""Given Rizia's current natural gas needs, we should not relinquish our claim on the field without seriously considering the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[173]`
Mówca: **Elena Werner**
> ""Though we do not strictly need the gas from the field, we should not relinquish it without seriously considering the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_Pales_SendSpecialOps)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_Pales_SendSpecialOps)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Security_Pales_SendSpecialOps"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Security_Pales_SendSpecialOps))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Security_Pales_SendSpecialOps"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[177]`
Mówca: **Narrator**
> "Lucita raised a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[178]`
Mówca: **Hugo Toras**
> ""By all means, Duchess Azaro, go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Narrator**
> "She took out a photograph. It showed a number of men in business suits boarding a large vessel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Lucita Azaro**
> ""Our intelligence in Pales managed to get a visual on the boat before it departed. This man here is a representative from LesPower, the Lespian energy corporation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Narrator**
> "Hugo stared at her coldly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Hugo Toras**
> ""I was not informed that we had active intelligence operating in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Lucita Azaro**
> ""His Majesty and I made the decision to establish it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will not question Duchess Azaro's ability to do her job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[185]`
Mówca: **Hugo Toras**
> ""You were involved in this, Your Majesty? I thought the Wehlen investigation took full precedence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[189]`
  - -> `[190]`
  - -> `[186]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duchess, I do hope this surveillance didn't pull too much focus away from the Zille investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Lucita Azaro**
> ""It did not, Your Majesty. I'll remind you that my department has been almost completely uninvolved in the Zille bombing fallout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[188]`
Mówca: **Narrator**
> "Lucita tried to conceal her indignance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, it was my idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believed the same. But she convinced me the Pales situation was worth keeping an eye on, and that turned out to be the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, I don't understand how this changes anything. We knew Pales and Lespia were in cahoots.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Lucita Azaro**
> ""What this evidence proves is that it's not Pales alone asserting its claim to the field. Lespia, and by extension ATO, is after that gas and all the money and power that comes with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do find it worrying that Lespia is so heavily involved in this expedition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[194]`
Mówca: **Narrator**
> "Lucita flashed me a grateful smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[195]`
Mówca: **Lucita Azaro**
> ""It did, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Laurento Esquibel**
> ""This photo sends a different message to me. Could it be possible that Lespia pressured Pales into claiming the field and sending the ship? And if so, can we use that fact to drive a wedge between the two?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[197]`
Mówca: **Lucita Azaro**
> ""I would humbly ask my fellow councilors to focus on the content of these findings, not the methods used to obtain them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[191]`
  - -> `[193]`

### Węzeł `[198]`
Mówca: **Hugo Toras**
> ""Forgive me, both of you. The last thing we need in this council is discord. And Duchess Azaro's findings are concerning to me as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Hugo, don't try to turn me against the Duchess. We're all colleagues here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Narrator**
> "Hugo's expression remained placid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Lucita Azaro**
> ""It did not, Your Majesty. If anything, our forces in Wehlen have doubled down on their efforts as the Zille handover deadline approaches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[206]`
Mówca: **Laurento Esquibel**
> ""Alternately, we could find a compromise that involves all three of our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[215]`
  - -> `[216]`
  - -> `[212]`

### Węzeł `[207]`
Mówca: **Narrator**
> "Lucita raised a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Lucita Azaro**
> ""What troubles me is the specter of Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Lucita Azaro**
> ""If Pales claims the field, I am almost certain that our northern neighbors will end up with the rights to it. They could be a presence in our waters for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Laurento Esquibel**
> ""That isn't necessarily bad for us. Maybe a compromise can be found that involves all three of our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[215]`
  - -> `[216]`
  - -> `[212]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no compromise where Lespia is involved. They'll steamroll over us at the first chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Diplomacy_Intention_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn02_Diplomacy_Intention_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn02_Diplomacy_Intention_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn02_Diplomacy_Intention_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Diplomacy_Intention_ATO"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to leave Lespia out of it. This dispute is between Rizia and Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But then what happens if Morella and their Valgslandian friends get involved? They won't be happy with an ATO member drilling so far south.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would be one way to get closer to ATO, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[218]`
Mówca: **Lucita Azaro**
> ""And that could lead to the kind of consequences I was warning you about earlier, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[219]`
Mówca: **Elena Werner**
> ""I wish it were that simple, Your Majesty. But Pales will have to sell the gas from the Aureus field to someone. And our northern neighbors are the most likely candidates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[220]`
Mówca: **Lucita Azaro**
> ""Are we sure that's what we want, though? Especially with Morella and Valgsland waiting in the wings...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Elena Werner**
> ""You know what Lespian Protectionism is like, Laurento. The republic isn't exactly keen on sharing resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Narrator**
> "Laurento had a pained expression on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Laurento Esquibel**
> ""I still don't think we should give up on the possibility of negotiation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He ruined his chances at building on our rapport when he sent that ship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He ruined his chances at reaching an understanding when he sent that ship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want to come to an understanding. I want to crush his Grand Duchy to smithereens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist -= 1; RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For your sake, Mr. Esquibel, I will try to be diplomatic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no idea whether his intentions were sincere. He might still harbor a grudge against Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That will be hard with Lespia looking over his shoulder. But I will try to be diplomatic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. If we meet in person, I'm sure I'll be able to get him to back down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[232]`
Mówca: **Laurento Esquibel**
> ""The only way to find out is to talk to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[233]`
Mówca: **Laurento Esquibel**
> ""You know how much I respected your father. But with you, I see a chance for a new approach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[234]`
Mówca: **Narrator**
> "Laurento blanched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[235]`
Mówca: **Laurento Esquibel**
> ""The ship has not started drilling yet. It could be he doesn't intend for it to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[236]`
Mówca: **Laurento Esquibel**
> ""I am sure of it as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Laurento Esquibel**
> ""Shall we discuss our diplomatic options? Are you leaning towards any particular outcome?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[238]`
Mówca: **Laurento Esquibel**
> ""Perhaps we should at least discuss our diplomatic options? Are you leaning towards any particular outcome?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't need a third party. We can settle this between ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you mean asking the Alliance of Nations to arbitrate the dispute?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[241]`
Mówca: **Laurento Esquibel**
> ""Don't forget, Ms. Werner. What we would lose from ceding the field, we might gain from a closer partnership with Pales and Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Hugo Toras**
> ""On the other hand, Mr. Esquibel, it will make us look weak. And the foreign powers will jump on the opportunity like vultures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[243]`
Mówca: **Hugo Toras**
> ""Think about how much territory we have relinquished already. How much wealth we have lost because of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Hugo Toras**
> ""I am certain that if we give up this gas field, the Wehzeks will be even more emboldened to keep their grip on Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[247]`
  - -> `[248]`
  - -> `[258]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right, Hugo. First Pales, then Zille, then this? We must preserve what's left of our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[246]`
Mówca: **Narrator**
> "My uncle's hand unconsciously formed a fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On the other hand, won't fighting for our rightful part of the field take up resources we should be using to get Zille back?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if we're actually wrong about having a claim to the field? Ceding it to Pales would save us a lot of trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[249]`
Mówca: **Elena Werner**
> ""You do have a point there, Your Majesty. We would have to allocate our funding very carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[250]`
Mówca: **Lucita Azaro**
> ""If we do cede the field, it must be done very carefully. We can't let Duke Reinhart think that his intimidation tactics worked on us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[251]`
Mówca: **Elena Werner**
> ""Unfortunately, arbitration is an expensive and time-consuming process. And there's no guarantee it would end in our favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[252]`
Mówca: **Laurento Esquibel**
> ""Correct, Your Majesty. AN arbitration is the typical path in disputes like these.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[253]`
Mówca: **Laurento Esquibel**
> ""If you can't, though, the Alliance of Nations would be called in to arbitrate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A third party... like the Rizian military?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Laurento Esquibel**
> ""With that said, it's definitely the safest way to avoid a diplomatic incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`
  - -> `[263]`
  - -> `[262]`

### Węzeł `[256]`
Mówca: **Laurento Esquibel**
> ""I believe Ms. Werner was referring to the Alliance of Nations. It's usually called on to arbitrate disputes like these.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[257]`
Mówca: **Elena Werner**
> ""The value of the gas in the field is high enough that I think it's worth defending our claim for as long as we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like the idea any more than you do, Hugo. But my father taught me that sometimes we have to sacrifice part of our kingdom to save the rest of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Hugo Toras**
> ""Up to a point, Your Majesty. What happens when we have nothing left to sacrifice?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have Rumburg on our side. I'm sure Queen Beatrice would support us through the arbitration process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It does sound like the law is on our side. Maybe this is the easiest way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't have time to spare. I want that gas *now*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, the AN will muddle everything up with its bureaucracy. I want to talk to the Duke man to man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[264]`
Mówca: **Elena Werner**
> ""Even if we were granted part of the field instantly, it would take a while before gas extraction could begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Elena Werner**
> ""But yes, arbitration would take even longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[266]`
Mówca: **Elena Werner**
> ""On the other hand, if the AN does end up ruling against us, that would be definitive. We would be forced to completely give up our claim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[267]`
Mówca: **Laurento Esquibel**
> ""The weight of GRACE versus that of Lespia and ATO. We would be evenly matched.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[268]`
Mówca: **Laurento Esquibel**
> ""I would encourage you to try, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_Cede"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[270]`
Mówca: **Narrator**
> "She spoke slowly, as if thinking out loud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[271]`
Mówca: **Laurento Esquibel**
> ""Are you in your right mind, young lady? The navy? We'd be escalating the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[329]`
  - -> `[330]`
  - -> `[410]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there a way we can claim the entire field for Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Laurento Esquibel**
> ""Not without major diplomatic repercussions, I'm afraid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Elena Werner**
> ""No matter which maritime boundaries you look at, it's clear that half of the field lies in Palesian territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Elena Werner**
> ""The only way for Rizian Oil and Gas to access the entire field would be for us to purchase the exploration rights from Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`
  - -> `[303]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would make our gas extraction dependent on their conditions. No, thanks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds costlier than I envisioned, but we would certainly reap the rewards. Why don't we pursue that option?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Or reconquer Pales. Right, Duchess Azaro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[282]`
Mówca: **Lucita Azaro**
> ""We could, but we have to remember that Lespia is involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_Pales_SendSpecialOps == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_Pales_SendSpecialOps == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Security_Pales_SendSpecialOps == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Lucita Azaro**
> ""We could, but we have to consider Lespia's potential involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[287]`
Mówca: **Lucita Azaro**
> ""We know for a fact that LesPower has designs on the gas field. If we want the rights, we will have to outbid them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Laurento Esquibel**
> ""Which may be difficult, considering the shaky state of Rizian-Palesian relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[289]`
Mówca: **Laurento Esquibel**
> ""And before that, we'd have to convince Duke Reinhart that Rizia is a trustworthy partner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Laurento Esquibel**
> ""Which might be possible. Reinhart still seems to trust you more than your father, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[294]`
Mówca: **Lucita Azaro**
> ""If Lespia already has designs on the field, Pales could force us to outbid them for access to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[295]`
Mówca: **Narrator**
> "I saw a hint of a smile on Lucita's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance > 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Romance > 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Romance"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[299]`
Mówca: **Lucita Azaro**
> ""I am still not convinced that's the right course of action for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Lucita Azaro**
> ""However, if you insisted on a new campaign against Pales, I would be obliged to provide counsel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[301]`
Mówca: **Narrator**
> "Lucita shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Lucita Azaro**
> ""I am still not convinced that's the right course of action for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_TakeBackLand == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_TakeBackLand == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_Speech_TakeBackLand == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[306]`
Mówca: **Lucita Azaro**
> ""Although it would make this dispute considerably less complicated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[307]`
Mówca: **Lucita Azaro**
> ""Agreed, Your Majesty. And don't forget about Lespia's involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_Pales_SendSpecialOps == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_Pales_SendSpecialOps == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Security_Pales_SendSpecialOps == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Lucita Azaro**
> ""Agreed, Your Majesty. And don't forget about Lespia's potential involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_PalesCouncil_DiplomacyHub_ClaimAll"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[313]`
Mówca: **Narrator**
> "Laurento wiped his brow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Laurento Esquibel**
> ""I beg of you to trust your first instincts, Duchess Azaro. Pursuing a path of aggression could delay our access to the gas field for months or even years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[315]`
Mówca: **Narrator**
> "Hugo cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Hugo Toras**
> ""If I may, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Hugo Toras**
> ""We have still not decided what to do about the Palesian drillship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[320]`
  - -> `[319]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like the idea of it being present in the gas field during our negotiations. But I don't see a way to stop it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We shouldn't immediately interpret the ship as a provocation. This could all be a misunderstanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have to do *something*, obviously. The Palesians must not be allowed to get away with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Lucita Azaro**
> ""I do, Your Majesty. But my fellow councilors won't like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[322]`
Mówca: **Lucita Azaro**
> ""I have one idea, Your Majesty. But my fellow councilors won't like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[323]`
Mówca: **Hugo Toras**
> ""Respectfully, Your Majesty, the Palesians' intentions are crystal clear to me. Even if Duke Reinhart is open to negotiations, he sent this ship to rattle us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Lucita Azaro**
> ""My suggestion is to rattle him right back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[325]`
Mówca: **Lucita Azaro**
> ""With His Majesty's blessing... the Rizian navy could surround the field, preventing the drillship from reaching its destination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Narrator**
> "Laurento looked up in outrage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Young lady'? I know you come from a different generation, Mr. Esquibel, but that address was completely out of line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Laurento Esquibel**
> ""Excuse me, Your Majesty. But only the impetuousness of youth could be behind such a rash response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I second that. A military response could have disastrous consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not an outlandish suggestion. We've already established that Pales is violating international law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[331]`
Mówca: **Elena Werner**
> ""Actually, my elderly friend, Duchess Azaro may have the right idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[332]`
Mówca: **Laurento Esquibel**
> ""Tensions with Pales are high enough already. This could bring them to a boiling point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[336]`
Mówca: **Laurento Esquibel**
> ""We were on the verge of reconciling with Pales after all these years. This would shatter our chances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[337]`
Mówca: **Narrator**
> "Laurento looked at her indignantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[338]`
Mówca: **Elena Werner**
> ""Of course we shouldn't fire on their ship. But a blockade would keep the gas field clear until you've had a chance to speak with Duke Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[339]`
Mówca: **Elena Werner**
> ""The Duchess is not talking about sinking the drilling ship, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Elena Werner**
> ""A blockade could keep the field clear until His Majesty has had a chance to speak with Duke Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Narrator**
> "Laurento looked at her indignantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[342]`
Mówca: **Elena Werner**
> ""If we do end up in arbitration talks, Pales having an established presence in the Aureus field would give them an unwarranted edge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[345]`
  - -> `[347]`
  - -> `[352]`

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That settles it, then. I want us to have a fighting chance to claim our rightful part of the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[344]`
Mówca: **Hugo Toras**
> ""I too am wary of miring ourselves in another conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even so, the risk of escalation is too high. It doesn't seem worth it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[346]`
Mówca: **Laurento Esquibel**
> ""Precisely, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_Pales_SendSpecialOps == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_Pales_SendSpecialOps == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Security_Pales_SendSpecialOps == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am hesitant to interfere. What if ATO retaliates?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Lucita Azaro**
> ""There may be LesPower executives on board the ship, but it is flying the Palesian flag. Neither Lespia nor ATO would be allowed to get involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales and Lespia are literally testing the waters with us. If we let them reach the field, we have already lost it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[353]`
Mówca: **Hugo Toras**
> ""I agree that asserting Rizian sovereignty is of the utmost importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Hugo Toras**
> ""Especially knowing what we know about Lespia's involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_Pales_SendSpecialOps == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_Pales_SendSpecialOps == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Security_Pales_SendSpecialOps == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Hugo Toras**
> ""But I am wary of miring ourselves in another conflict. What if the Palesians call our bluff?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[359]`
Mówca: **Hugo Toras**
> ""Yes, sending the navy would help assert Rizian sovereignty, but are we strong enough to defend ourselves should the Palesians call our bluff?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Lucita Azaro**
> ""We don't need to worry about that, Your Grace. Our navy is capable of outgunning Pales if need be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_NavalBombardmentCapability > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_NavalBombardmentCapability > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_NavalBombardmentCapability"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_NavalBombardmentCapability > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_NavalBombardmentCapability"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Lucita Azaro**
> ""That is a concern, Your Grace. We have a capable navy, but we won't be able to outgun Pales if it comes down to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Lucita Azaro**
> ""Still, this is not a decision to take lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[370]`
  - -> `[368]`
  - -> `[369]`

### Węzeł `[366]`
Mówca: **Lucita Azaro**
> ""This is not a decision to take lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[370]`
  - -> `[368]`
  - -> `[369]`

### Węzeł `[367]`
**[WYBÓR GRACZA: ""I understand the implications. But I fear we have no other choice. We will institute a naval blockade of the gas field immediately." [Order Blockade, +1 Authority]"]** — Mówca: **Player_Romus**
> ""I understand the implications. But I fear we have no other choice. We will institute a naval blockade of the gas field immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. And I think we should exercise caution. I will meet with Duke Reinhart before deciding our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see through your manipulations, Duchess Azaro, and I will not give in. We will refrain from provoking Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[370]`
**[WYBÓR GRACZA: ""I do not take Duke Reinhart's violation of the law lightly, either. Our navy will show him that Rizia cannot be intimidated." [Order Blockade, +1 Authority]"]** — Mówca: **Player_Romus**
> ""I do not take Duke Reinhart's violation of the law lightly, either. Our navy will show him that Rizia cannot be intimidated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[371]`
Mówca: **Lucita Azaro**
> ""Manipulations?! I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[372]`
Mówca: **Narrator**
> "She clenched her jaw and forced herself to smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Lucita Azaro**
> ""I understand, Your Majesty. Let me know if there's any other way I can support you in your negotiations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance -= 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[375]`
Mówca: **Narrator**
> "Laurento nodded, relieved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[376]`
Mówca: **Laurento Esquibel**
> ""Very good, Your Majesty. I'll get everything in order for your meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[377]`
Mówca: **Narrator**
> "Lucita nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = true;
RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade = true;
RiziaDLC.Resources_Authority += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = true; RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade = true;
RiziaDLC.Resources_Authority += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[380]`
Mówca: **Lucita Azaro**
> ""As you wish, Your Majesty. I'll make the order right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Narrator**
> "Lucita nodded. Laurento and Elena exchanged troubled glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[382]`
Mówca: **Narrator**
> "Laurento attempted to smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[383]`
Mówca: **Laurento Esquibel**
> ""This will add a tense background to negotiations, to say the least. But I have faith it will all work out for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[384]`
Mówca: **Elena Werner**
> ""That's the spirit, Laurento. I'm sure our ships will only be in place for a few days at most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[385]`
Mówca: **Hugo Toras**
> ""I'll adjourn the meeting so Duchess Azaro may begin preparations. We will inform you of the navy's position prior to your departure for Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`
  - -> `[399]`
  - -> `[404]`

### Węzeł `[386]`
Mówca: **Lucita Azaro**
> ""Our naval forces will be on standby in case you change your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[387]`
Mówca: **Hugo Toras**
> ""I pray to St. Wruhec that they will not be needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[388]`
Mówca: **Narrator**
> "There was a moment's silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[389]`
Mówca: **Hugo Toras**
> ""I'll adjourn the meeting so Mr. Esquibel can begin his preparations. We'll keep you abreast of any changes prior to your departure for Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`
  - -> `[391]`
  - -> `[390]`
  - -> `[393]`

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope I don't regret following your advice, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you all for your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I fully expect a peaceful resolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope there are no more unpleasant surprises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[394]`
Mówca: **Hugo Toras**
> ""We'll see to it that there aren't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[395]`
Mówca: **Laurento Esquibel**
> ""I am certain you would have regretted a military response more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[396]`
Mówca: **Lucita Azaro**
> ""Good luck, Your Majesty. I mean that sincerely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I fully expect a peaceful resolution. This is just a precaution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish I could see the look on Reinhart's face when he finds out about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[399]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the suggestion, Duchess. I knew you could be counted on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[400]`
Mówca: **Laurento Esquibel**
> ""You'll see him very soon, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[401]`
Mówca: **Laurento Esquibel**
> ""No need to justify it, Your Majesty. This is your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[402]`
Mówca: **Lucita Azaro**
> ""I'm just doing my job, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[403]`
Mówca: **Narrator**
> "She bowed her head modestly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you all for your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[405]`
Mówca: **Narrator**
> "The meeting drew to a close."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Narrator**
> "I spent a sleepless night in Fort Ales, wondering what would happen when the Rizian navy reached its destination."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Romance += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Romance"] = Variable["RiziaDLC.Relations_Lucita_Romance"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Morella_NegotiatingPower += 1;
RiziaDLC.LeaningValue_Democratic -= 1;
RiziaDLC.PersonalValue_Pacifist -= 3;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 2;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are the ones who are escalating. We cannot simply stay idle. We need a strong response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Enable_Policy_RD_Order_ExpandFortAlesNavalBase = true;
RiziaDLC.Enable_Policy_RD_Order_ExpandTeradorAirbase = true;
RiziaDLC.Enable_Policy_RD_Order_PalesAdminDistrict_StrengthenedBorderFort = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Order_ExpandFortAlesNavalBase"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_ExpandTeradorAirbase"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Order_PalesAdminDistrict_StrengthenedBorderFort"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn04_PorteDrazon_BFFUnmasked = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_PorteDrazon_BFFUnmasked"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableToken("Rizia_Event_Aureus");)*
- **Efekt (`userScript`):** `EnableToken("Rizia_Event_Aureus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[414]`
Mówca: **Laurento Esquibel**
> ""Since then, both Rizia and Pales have variously claimed ownership of these waters and the resources therein.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCountryPresident("Rizia_Country_Agnolia", "PM Maartin Van Hoorten");)*
- **Efekt (`userScript`):** `UpdateCountryPresident("Rizia_Country_Agnolia","PM Maartin Van Hoorten");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Codex_Characters_ForeignLeaders_MaartinVanHoorten = true;
RiziaDLCSupport.Codex_Characters_ForeignLeaders_DijerkDanOtkende1952 = true;
RiziaDLCSupport.Codex_Characters_ForeignLeaders_DijerkDanOtkende = false;
RiziaDLCSupport.Codex_Locations_Countries_Agnolia = false;
RiziaDLCSupport.Codex_Locations_Countries_Agnolia_1952 = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Codex_Characters_ForeignLeaders_MaartinVanHoorten"] = true;
Variable["RiziaDLCSupport.Codex_Characters_ForeignLeaders_DijerkDanOtkende1952"] = true;
Variable["RiziaDLCSupport.Codex_Characters_ForeignLeaders_DijerkDanOtkende"] = false;
Variable["RiziaDLCSupport.Codex_Locations_Countries_Agnolia"] = false;
Variable["RiziaDLCSupport.Codex_Locations_Countries_Agnolia_1952"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Managing the resource conflict with the Grand-Duchy of Pales", "Fort Ales", "Pales Administrative District");)*
- **Efekt (`userScript`):** `SetRichPresence("Managing the resource conflict with the Grand-Duchy of Pales","Fort Ales","Pales Administrative District");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
