# Rizia/Turn 6/SnO_PalesPostIncidentMeeting

- **ID konwersacji:** `358`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/358_SnO_PalesPostIncidentMeeting.md`
- **Liczba węzłów dialogowych:** 847
- **Liczba wyborów gracza:** 258

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.CountryRelation_Rumburg_Hostile`
- `RiziaDLC.CountryRelation_Rumburg_Unfriendly`
- `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf`
- `RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal`
- `RiziaDLC.Incident_Border_KillSoldiers`
- `RiziaDLC.Incident_Naval_FocusAidOnValero`
- `RiziaDLC.Incident_Naval_FreeShips`
- `RiziaDLC.Incident_Naval_NoRescue`
- `RiziaDLC.Incident_Naval_RescueBoth`
- `RiziaDLC.MITZ_Renegotiation_Failed`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg`
- `RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_Completed`
- `RiziaDLC.PostIncident_Border_JointInvestigation`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.War_Incident_Naval`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Pales_PostIncident_Deal_25`
- `RiziaDLC.Pales_PostIncident_Deal_50`
- `RiziaDLC.Pales_PostIncident_Deal_Cede`
- `RiziaDLC.Pales_PostIncident_Peace_Deal`
- `RiziaDLC.Pales_PostIncident_Peace_NoDeal`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PostIncident_Border_JointInvestigation`
- `RiziaDLC.PostIncident_Border_ReleasedSoldiers`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Military_PalesianWarDeployment`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLCIsolated.Turn06_Pales_ListenedToDemands`
- `RiziaDLCSupport.News_Turn06_G_PalesWarStart`
- `RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded`
- `RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCededPartial`
- `RiziaDLCSupport.News_Turn06_G_PostIncidentNoDeal`
- `RiziaDLCSupport.News_Turn06_G_PostIncidentTalkBreakdown`
- `RiziaDLCSupport.News_Turn06_RH_PalesWarStart`
- `RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCeded`
- `RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCededPartial`
- `RiziaDLCSupport.News_Turn06_RH_PostIncidentNoDeal`
- `RiziaDLCSupport.News_Turn06_RH_PostIncidentTalkBreakdown`
- `RiziaDLCSupport.News_Turn06_RH_VinaHeldInPales`
- `RiziaDLCSupport.News_Turn06_V_PalesWarStart`
- `RiziaDLCSupport.Reports_Turn06_Pales_ThanksRomusForVisit`
- `RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage`
- `RiziaDLCSupport.Reports_Turn06_Terador_AirbaseStormed`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 8
- **Węzły modyfikujące stan gry:** 41

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Pales_PostIncident_Deal_25`
- `RiziaDLC.Pales_PostIncident_Deal_50`
- `RiziaDLC.Pales_PostIncident_Deal_Cede`
- `RiziaDLC.Pales_PostIncident_Peace_Deal`
- `RiziaDLC.Pales_PostIncident_Peace_NoDeal`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Military_PalesianWarDeployment`
- `RiziaDLCIsolated.Turn06_Pales_ListenedToDemands`
- `RiziaDLCSupport.News_Turn06_G_PalesWarStart`
- `RiziaDLCSupport.News_Turn06_RH_PalesWarStart`
- *...oraz 4 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[13]` (Paskal Beniwoll): `AddConversant("Axel Reinhart");`
- Węzeł `[334]` (Paskal Beniwoll): `Variable["RiziaDLC.PostIncident_Border_ReleasedSoldiers"] = true; Variable["RiziaDLC.Vina_Hostage...`
- Węzeł `[462]` (Paskal Beniwoll): `Variable["RiziaDLC.PostIncident_Border_JointInvestigation"] = true;`
- Węzeł `[471]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn06_Pales_ListenedToDemands"] = true;`
- Węzeł `[483]` (Paskal Beniwoll): `-- RIZIA CEDES GAS FIELD;`
- Węzeł `[488]` (Paskal Beniwoll): `-- RIZIA CEDES 25% GAS FIELD;`
- Węzeł `[501]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;`
- Węzeł `[502]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- *...oraz 33 innych węzłów ze skryptami.*

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
  - -> `[846]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The specter of the recent naval incident cast a long shadow over our relations. I sensed it in the mood of everyone around me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Upon our arrival to Castle Reinhart, we were greeted by the expressionless faces of the Palesian delegation with no sight of the Duke himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Our convoy drove steadily across the cobbled streets of Old Town Pales. It was my second visit to the Palesian capital since becoming King of Rizia, and the atmosphere this time was far more tense."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Naval == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Naval == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Naval == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "The specter of the recent border incident cast a long shadow over our relations. I sensed it in the mood of everyone around me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[10]`
Mówca: **Narrator**
> "No pleasantries were exchanged and no diplomatic gestures were played to the cameras. We were instead quickly ushered inside as the reporters were blocked off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Nobody from my security detail nor the welcoming delegation spoke as we entered the room where the meeting was to take place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "When Duke Reinhart entered the room, everyone else left. He didn't speak a word until we were completely alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `AddConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Axel Reinhart**
> ""King Romus. Your rushed arrival here is a testament to the gravity of our situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[15]`
Mówca: **Axel Reinhart**
> ""I wish I could say your visit today brings me comfort, but under these circumstances, I find it hard to extend a warm welcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`
  - -> `[60]`
  - -> `[61]`

### Węzeł `[16]`
Mówca: **Narrator**
> "He extended his hand for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Romus_Italic**
> "I shook his hand and we both sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "Leave his hand hanging."]** — Mówca: **Player_Romus_Italic**
> "I left his hand hanging and took a seat. He followed me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Axel Reinhart**
> ""You're not even going to bother, eh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Axel Reinhart**
> ""You dare to attack my people, then fail to show respect to me in the very heart of our land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Naval == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Naval == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Naval == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[24]`
Mówca: **Narrator**
> "He stared at me, brow furrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Axel Reinhart**
> ""Look. I do not intend to allow Pales be pushed around by Rizia any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Axel Reinhart**
> ""So please. Listen to me very carefully...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[62]`
  - -> `[63]`

### Węzeł `[27]`
Mówca: **Axel Reinhart**
> ""If you think I'd let Rizia use an orchestrated incident as justification for, well..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Axel Reinhart**
> ""...Whatever you intend to do. You'd be wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[44]`
  - -> `[45]`
  - -> `[46]`

### Węzeł `[29]`
Mówca: **Axel Reinhart**
> ""Despite the AN ruling in your favor, you went and deployed your navy to the field -- completely going against the resolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[30]`
Mówca: **Axel Reinhart**
> ""Is this not a declaration of war? What dialogue could you possibly be after?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Axel Reinhart**
> ""You not only cancelled your deal at the last minute, you went against international law by deploying your navy and blockading Aureus. And now you sank a Palesian ship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[35]`
Mówca: **Axel Reinhart**
> ""Please help me understand, *Your Majesty.* Because I'm having a devil of a time making sense of your actions right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`
  - -> `[80]`
  - -> `[85]`

### Węzeł `[36]`
Mówca: **Axel Reinhart**
> ""What right does the Rizian Navy have to block our access to the field? You not only went against international law, you sank a Palesian ship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[40]`
Mówca: **Axel Reinhart**
> ""Despite the AN ruling against you, you went and deployed your navy to the field -- in direct violation of the resolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Orchestrated incident? It was your soldiers that went inside and occupied a fort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hold on a second. According to our reports, your soldiers shot first. And I seem to believe those reports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Believe me, I'm on the same boat as you. Our reports suggest that your soldiers shot first. I came here to get some answers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[47]`
Mówca: **Axel Reinhart**
> ""Looking for answers? After you kill every single one of them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[51]`
Mówca: **Axel Reinhart**
> ""So you decided to kill every single one of them before verifying any of your reports?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[55]`
Mówca: **Axel Reinhart**
> ""And it was the Rizian Army that killed every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[56]`
Mówca: **Axel Reinhart**
> ""Your reports *suggest* utter lies, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not at all. I am merely stating our stance, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for having us...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope we can sort this problem out today, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Romus_Italic**
> "I did not respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "Don't interrupt."]** — Mówca: **Player_Romus_Italic**
> "I listened to his words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I'm not going to let you dictate anything. You're going to listen to me now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Axel Reinhart**
> ""Despite the AN ruling in your favor, you insisted on maintaining your blockade of the field -- completely going against the resolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship_DeployedAfterAN"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Axel Reinhart**
> ""Despite the AN ruling against you, you insisted on maintaining your blockade of the field -- in direct violation of the resolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[72]`
Mówca: **Axel Reinhart**
> ""Rizia has no right to block access to Aureus, Your Majesty. This is an open attack against Pales and international law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[73]`
Mówca: **Axel Reinhart**
> ""Is this not a declaration of war? What dialogue could you possibly be after?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Axel Reinhart**
> ""Please help me understand, *Your Majesty.* Because I'm having a devil of a time making sense of your actions right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`
  - -> `[81]`
  - -> `[85]`

### Węzeł `[75]`
Mówca: **Axel Reinhart**
> ""We know that your soldiers incited the incident. Our guards moved to the islet during the firefight -- simply because they were under fire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Axel Reinhart**
> ""And you're going to claim we shot first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[77]`
Mówca: **Axel Reinhart**
> ""So please tell me, Your Majesty. What in the hell happened at Navar Castle?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[235]`
  - -> `[236]`
  - -> `[267]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The deal wasn't in the best interests of the Rizian people. We will cede our rights no longer. Your ships have to respect our claims.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is laying claim to the entirety of the Aureus field. And frankly, I don't think Pales can do anything about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's not start on the wrong foot, Your Grace. I am aware of the incident, and I am here for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will not recognize the biased and unjustified resolution of the AN. Lespia and their western sponsors manipulated the ruling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's get our facts straight, Your Grace. Your ships were warned but they not only ignored them, our flagship was rammed into.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Naval == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Naval == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Naval"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[91]`
  - -> `[92]`
  - -> `[94]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Naval == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Naval"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[100]`
  - -> `[99]`
  - -> `[101]`

### Węzeł `[89]`
Mówca: **Narrator**
> "He looked at me, discomfort and concern etched onto his handsome features."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The deal wasn't in the best interests of the Rizian people. We will cede our rights no longer. Your ships have to respect our claims.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have decided to take the entirety of the Aureus field. And frankly, I don't think Pales can do anything about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's not start on the wrong foot, Your Grace. I am aware of the incident, and I am here for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will not recognize the biased and unjustified resolution of the AN. Lespia and their western sponsors manipulated the ruling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your ships were warned. Not only did they ignore that warning, they rammed into our flagship. Did you give the order yourself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We believe that this was an orchestrated incident to incite instability. I am not sure who is behind this, but our reports suggest it was the Palesians who shot first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's not start on the wrong foot, Your Grace. I am aware of the incident, and I am here for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your soldiers went inside Rizia and occupied a fort. Is this not an act of war, Your Grace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is a lot of misinformation going about. There are conflicting reports on which side shot first. I came here to get some answers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[102]`
Mówca: **Axel Reinhart**
> ""Rizia has no right to do that, Your Majesty. This is an open attack against Pales and international law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[103]`
Mówca: **Axel Reinhart**
> ""Peace? You are directly responsible for sinking our ship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[104]`
Mówca: **Axel Reinhart**
> ""Peace? You are directly responsible for sinking our ship and the loss of Palesian lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Incident_Naval_RescueBoth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Incident_Naval_RescueBoth == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FreeShips"] == true  or  Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Incident_Naval_RescueBoth == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FreeShips"] == true  or  Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Duke Reinhart raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Axel Reinhart: ""Rizia has no right to do that, You..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Axel Reinhart: ""Rizia has no right to block access..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "Duke Reinhart raised an eyebrow."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[112]`
Mówca: **Axel Reinhart**
> ""Rizia has no right to block access to that field, Your Majesty. This is an open attack against Pales and international law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[113]`
Mówca: **Axel Reinhart**
> ""Look at what you are saying, Your Majesty. The ruling was manipulated because you don't like the outcome?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Axel Reinhart: ""Look at what you are saying, Your..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[115]`
Mówca: **Axel Reinhart**
> ""We are not the side who fired at you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[116]`
Mówca: **Axel Reinhart**
> ""I refuse to even respond to that question, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Axel Reinhart: ""We are not the side who fired at y..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[118]`
Mówca: **Axel Reinhart**
> ""Are you here to threaten me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[131]`
  - -> `[57]`
  - -> `[130]`
  - -> `[125]`
  - -> `[127]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Incident_Naval_RescueBoth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Incident_Naval_RescueBoth == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FreeShips"] == true  or  Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Naval_FreeShips == true || RiziaDLC.Incident_Naval_RescueBoth == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FreeShips"] == true  or  Variable["RiziaDLC.Incident_Naval_RescueBoth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Axel Reinhart**
> ""Rizia is directly responsible for sinking our ship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Axel Reinhart**
> ""Rizia is directly responsible for sinking our ship and the loss of Palesian lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Axel Reinhart**
> ""So tell me, Your Majesty. What is the stance of your kingdom? What are you trying to achieve here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`
  - -> `[127]`
  - -> `[128]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's true, it was my decision to blockade the field. But the incident wouldn't have happened if your ship didn't ram into us. The damage it inflicted was extensive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was an accident, Your Grace. Rizia, by no means, wanted to escalate the tensions. The admirals reacted on their own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our stance is clear. Aureus lies inside our borders and anyone who enters that territory is subject to Rizian law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are all deeply saddened by the incident. I'd like to offer our sympathies and apologies on behalf of our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[129]`
Mówca: **Axel Reinhart**
> ""The international community acknowledged your claim and rewarded you half of the entire field. What more do you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was an accident, Your Grace. Rizia, by no means, wanted to escalate the tensions. The admirals reacted on their own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are all deeply saddened by the incident. I'd like to offer sympathies and apologies on behalf of our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]`

### Węzeł `[132]`
Mówca: **Axel Reinhart**
> ""I refuse to accept your comments. Don't mock me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Axel Reinhart**
> ""You just told me about your intentions of not letting go of Aureus. You gave the order to blockade the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Axel Reinhart**
> ""You just told me about your intentions of not respecting the AN's resolution. You gave the order to blockade the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Axel Reinhart**
> ""You may regard Pales as an insignificant appendage of your own kingdom -- but you have not seen our reach in the world yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Axel Reinhart**
> ""You are pushing me into a corner. And I have decided not to allow Rizia push us around any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[180]`
  - -> `[181]`
  - -> `[182]`

### Węzeł `[140]`
Mówca: **Axel Reinhart**
> ""I see that, Your Majesty. It is a stance of aggression and war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[141]`
Mówca: **Axel Reinhart**
> ""No. I will not allow Rizia to threaten Pales like this, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[142]`
Mówca: **Axel Reinhart**
> ""Is this Rizia's official stance then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`
  - -> `[171]`

### Węzeł `[143]`
Mówca: **Axel Reinhart**
> ""Are you not going to accept any responsibility?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[144]`
Mówca: **Axel Reinhart**
> ""Don't expect me to believe that was an accident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[148]`
Mówca: **Axel Reinhart**
> ""You allowed our sailors to die in the sea and captured our vessels, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Axel Reinhart**
> ""Don't expect me to believe you are saddened by any of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Axel Reinhart**
> ""You allowed our sailors to die in the sea and captured our vessels, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[154]`
Mówca: **Axel Reinhart**
> ""I find it difficult to believe, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Axel Reinhart**
> ""Is this going to be Rizia's official stance then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[160]`
  - -> `[158]`

### Węzeł `[156]`
Mówca: **Axel Reinhart**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Axel Reinhart**
> ""But Pales is expecting more than an apology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[191]`
  - -> `[192]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. And we are all deeply saddened by the incident. I'd like to offer our sympathies and apologies on behalf of our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[159]`
Mówca: **Narrator**
> "He had no expression on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`
  - -> `[167]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope to decide that after today's meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our stance is clear. Aureus lies inside our borders and anyone who enters that territory is subject to Rizian law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Axel Reinhart**
> ""Are you not going to accept any responsibility?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[169]`
  - -> `[168]`

### Węzeł `[163]`
Mówca: **Axel Reinhart**
> ""Rizia had better have something to offer, Your Majesty. It is not you who will dictate this conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[191]`
  - -> `[192]`

### Węzeł `[164]`
Mówca: **Axel Reinhart**
> ""Oh, please. Then why did you capture our ships? Was that also in the name of humanitarian aid?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`
  - -> `[247]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We did our best to save your officers, but we couldn't reach them in time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We had to focus our aid on our flagship that was damaged almost beyond repair. There were hundreds of people on that ship, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you want me to offer you? I am willing to do what it takes to preserve peace between our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course not. Your ship rammed into our vessel and sank. Rizia has nothing to do with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not for retaliating for your attack against our flagship. Pales is the one that escalated the incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will. However, Pales must understand and respect Rizia's stance on Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will not accept responsibility for retaliating for your attack against our flagship. Pales is the one that escalated the incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[172]`
Mówca: **Axel Reinhart**
> ""I understand. Rizian lives seem to matter more, after all...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't have to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[175]`
Mówca: **Axel Reinhart**
> ""We will stand alone if need be. But we will not bow down to your harassment any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[238]`
  - -> `[239]`
  - -> `[244]`

### Węzeł `[176]`
Mówca: **Axel Reinhart**
> ""Then I have nothing else to say. Except this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[177]`
Mówca: **Narrator**
> "Suddenly he bursted out in hysterical laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Axel Reinhart**
> ""I didn't expect you to come up with such nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[179]`
Mówca: **Axel Reinhart**
> ""And why did you capture our ships again? Was that also an *unintentional* consequence?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`
  - -> `[247]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody wants a war, Your Grace. I am here to reach a mutual understanding with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now you seem to be threatening me. And I don't like where this is going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps we can still reach an agreement. But Pales must understand and respect Rizia's stance on Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where is Vina?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Narrator**
> "He looked annoyed when I disrupted him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Axel Reinhart**
> ""She is safe and sound, Your Majesty. Don't worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Axel Reinhart**
> ""We'll bring her in later. But first, you will listen to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[190]`
Mówca: **Axel Reinhart**
> ""Nor do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. Let's discuss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's nothing else I can offer you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[193]`
Mówca: **Narrator**
> "He straightened his back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Axel Reinhart: ""You'd better have something to off..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[195]`
Mówca: **Axel Reinhart**
> ""These are not the actions of a country that wants peace. Wouldn't you say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`
  - -> `[203]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[199]`
Mówca: **Axel Reinhart**
> ""You allowed our sailors to die in the sea and captured our vessels, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[200]`
Mówca: **Axel Reinhart**
> ""You'd better have something to offer other than an apology, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[191]`
  - -> `[192]`

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have to trust me, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I assure you, we want peace. But if you keep pushing us, we are ready for anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't need to be enemies. Please understand the predicament I'm in. I cannot let go of that field so easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's not start on the wrong foot, Your Grace. I am aware of the incident, and I am here for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[208]`
Mówca: **Axel Reinhart**
> ""Looking for answers? After you kill every single one of them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[215]`
Mówca: **Axel Reinhart**
> ""So you decided to kill every single one of them before verifying any of those reports?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[216]`
Mówca: **Axel Reinhart**
> ""And it was the Rizian Army that killed every single one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[217]`
Mówca: **Axel Reinhart**
> ""Your reports *suggest* utter lies, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[218]`
Mówca: **Axel Reinhart**
> ""You may not have falsified the reports yourself, Your Majesty. But obfuscation is afoot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[219]`
Mówca: **Narrator**
> "Duke Reinhart raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "Duke Reinhart raised an eyebrow."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Axel Reinhart: ""We know that your soldiers incited..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I'm only here to take my daughter home to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, Your Grace. As long as Vina and I can leave Pales in peace, there will be no such aggression from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[230]`
Mówca: **Axel Reinhart**
> ""And then what, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[234]`
Mówca: **Axel Reinhart**
> ""You claim you want peace after the Rizian Army killed every single Palesian involved?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regardless of who shot first, your soldiers went inside Rizia and occupied a castle in the process. So please, don't try to blame Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to know the same, Duke Reinhart. The incident at our border is deeply regrettable, and I assure you, Rizia seeks a peaceful resolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[237]`
Mówca: **Axel Reinhart**
> ""You claim peace and you're still making threats?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody wants a war, Your Grace. I am here to reach a mutual understanding with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think Pales can stand against Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've made your point, Your Grace. I don't intend to pursue any aggression. Rizia only wants peace. I just need Vina to come back with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough of this. Do you want reconciliation or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't matter now, Your Grace. The fact is that is now part of the negotiations, whether you like it or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We did not capture anything. Your sailors will be released after the vessels are fully inspected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are consequences for rash actions, Your Grace. They ignored our warnings and rammed into our ship. I don't think I need to repeat this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[251]`
Mówca: **Axel Reinhart**
> ""Rizia will no longer dictate anything, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[252]`
Mówca: **Axel Reinhart**
> ""Exactly, Your Majesty. There are consequences for rash actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Axel Reinhart**
> ""And your actions are leading us to war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Axel Reinhart**
> ""Either you will listen to our demands and back off from Aureus completely...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`
  - -> `[404]`
  - -> `[405]`

### Węzeł `[255]`
Mówca: **Axel Reinhart**
> ""It sounds like they're being held captive to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[256]`
Mówca: **Axel Reinhart**
> ""I have nothing left to say. Except this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[257]`
Mówca: **Axel Reinhart**
> ""I don't think you want to find that out, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[238]`
  - -> `[258]`
  - -> `[244]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're wrong. I intend to find out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[259]`
Mówca: **Narrator**
> "He paused for a moment. His face darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true || RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Incident_Naval_FocusAidOnValero == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true || RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Incident_Naval_FocusAidOnValero == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true  or  Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true || RiziaDLC.Incident_Naval_NoRescue == true || RiziaDLC.Incident_Naval_FocusAidOnValero == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true  or  Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[266]`
Mówca: **Axel Reinhart**
> ""I wish I could say your visit today brings me comfort, but under these circumstances, I find it hard to extend a warm greeting. But still... Welcome back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`
  - -> `[60]`
  - -> `[61]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The reports we received can be deceptive, and I fear we are both victims of a larger game. It is not my desire, nor the desire of Rizia, to escalate tensions. We seek only to defend our sovereignty, as you do yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[268]`
Mówca: **Axel Reinhart**
> ""Regardless of who shot first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[269]`
Mówca: **Axel Reinhart**
> ""Peaceful resolution? When Rizian troops are shooting at our borders, and reports of aggression filter through every channel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Axel Reinhart**
> ""Defend your sovereignty? Or expand it at the cost of ours? Reports suggest it was Rizian soldiers who fired first, instigating the conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[281]`
  - -> `[280]`

### Węzeł `[271]`
Mówca: **Axel Reinhart**
> ""You must understand how this appears from my perspective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[278]`
  - -> `[277]`

### Węzeł `[272]`
Mówca: **Axel Reinhart**
> ""You killed our soldiers at the castle and ignore the reason how everything started?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Axel Reinhart**
> ""I am to believe Rizian reports? When Rizian troops are shooting at our borders, and reports of aggression filter through every channel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Appearances can be deceptive, and I fear we are both victims of a larger game. It is not my desire, nor the desire of Rizia, to escalate tensions. We seek only to defend our sovereignty, as you do yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. But I must assure you. I am here with peaceful intentions, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How about my perspective? I was told it was your soldiers who initiated a firefight and occupied a castle inside Rizia. We are only defending our sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those reports are not accurate, Duke Reinhart. Rizia has no interest in provoking a war. The situation at the border was a defensive response, triggered by movements we perceived as hostile.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why would I believe the Palesian reports?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[282]`
Mówca: **Axel Reinhart**
> ""Perceived as hostile? So, we are to believe this was all a misunderstanding? A tragic error in judgment that cost lives?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's get our facts straight, Your Grace. Our reports suggest otherwise. You can't claim to be the source of the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What would we gain from this, Your Grace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Axel Reinhart**
> ""You know the same goes for me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[287]`
Mówca: **Axel Reinhart**
> ""I don't know...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[288]`
Mówca: **Axel Reinhart**
> ""Look, Your Majesty. You speak of peace and cooperation, yet the actions at the border tell a different story.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[292]`
Mówca: **Axel Reinhart**
> ""Your soldiers surrounded and killed every Palesian in the castle without hesitation. You didn't think about communicating with me then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Axel Reinhart**
> ""So, how can I trust the words of a king whose armies take impulsive actions and stand ready to march into my lands?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`
  - -> `[298]`
  - -> `[299]`

### Węzeł `[294]`
Mówca: **Axel Reinhart**
> ""At this very moment, our soldiers in that castle are surrounded by your forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Axel Reinhart**
> ""If you want to have a dialogue, they must first be allowed to leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[312]`
  - -> `[313]`
  - -> `[314]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was interpreted as an occupation by the army and they responded accordingly. I cannot fault my soldiers for protecting our borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart, the positioning of our troops is purely defensive. The real question is, why were Palesian forces so close to the border in a manner that could be interpreted as provocative?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Impulsive actions? The real question is, why did Palesian forces decide to enter a paleacci inside our borders and stay there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am filled with regret about this whole thing. I am here to listen to your concerns. You have to trust me, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[300]`
Mówca: **Axel Reinhart**
> ""They were caught in the open when your forces opened fire, Your Majesty. They only took refuge there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`
  - -> `[321]`
  - -> `[322]`

### Węzeł `[301]`
Mówca: **Axel Reinhart**
> ""Provocative? It is common for patrols to be near borders. It is another thing entirely to respond with gunfire. Do you suggest we do not have the right to secure our own borders?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[304]`
  - -> `[305]`

### Węzeł `[302]`
Mówca: **Axel Reinhart**
> ""An occupation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course you have a right to secure your borders. Just the same way as we do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Securing borders is one thing, Duke, but reports indicate an aggressive stance from your patrols. We must consider the possibility of miscommunication among our forces, perhaps even deliberate misinformation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not saying that, Your Grace. The real question is, why did Palesian forces decide to enter a paleacci inside our borders and stay there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only according to the Palesian reports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Refuge? They did not surrender when they were surrounded, Your Grace. They were not the victims here. They killed six of our soldiers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Axel Reinhart**
> ""Perceived as hostile? So, we are to believe this was all a misunderstanding?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. They will be allowed to leave immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... That depends on the outcome of our meeting, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid that cannot happen. They need to surrender to us, and at the very least, stand trial for their actions against Rizian people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[315]`
Mówca: **Axel Reinhart**
> ""I want to trust you but Rizian actions make it very difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[316]`
Mówca: **Axel Reinhart**
> ""Miscommunication? You speak as if the incident was a mere diplomatic faux pas. Lives were lost, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Axel Reinhart**
> ""This cannot be brushed aside as a misunderstanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`
  - -> `[328]`

### Węzeł `[318]`
Mówca: **Axel Reinhart**
> ""Rizia responded disproportionately harsh, Your Majesty. Wouldn't you say so?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Axel Reinhart**
> ""We were in close cooperation since we agreed on our deal on Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Axel Reinhart**
> ""Why would Rizia act in this manner, right before the deal is finalized?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your reports say one thing, Duke, but ours indicate an aggressive stance from your patrols. We must consider the possibility of miscommunication among our forces, perhaps even deliberate misinformation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It looks like a very deliberate choice, Your Grace. Pales is the land of *paleaccis.* Was that a coincidence your forces occupied one?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Axel Reinhart**
> ""Are you claiming Pales wants to invade and occupy Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Axel Reinhart**
> ""Nobody would believe that, Your Majesty. And you know you also don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[325]`
Mówca: **Axel Reinhart**
> ""Do you really believe I am after a ruined medieval castle?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not brushing anything aside. I suspect it could be an inside job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do not and I never would underestimate the gravity of the situation, Your Grace. But we must not let this tragedy set the course for our nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you going to threaten me, Your Grace? I'm doing my best to reach an understanding but you are constantly pointing fingers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Axel Reinhart**
> ""For good reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[330]`
Mówca: **Axel Reinhart**
> ""A noble sentiment, but how do I reconcile it with the reports from my commanders? They claim your forces were not just defending, but actively pursuing engagement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`
  - -> `[345]`

### Węzeł `[331]`
Mówca: **Axel Reinhart**
> ""An inside job? From Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[332]`
Mówca: **Axel Reinhart**
> ""You cannot threaten Pales any longer, Your Majesty. I will not bow down to your threats. Palesians interpret this as an act of war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[333]`
Mówca: **Axel Reinhart**
> ""If you do not release them, it is proof that Rizia was after aggression all along and this incident was all a ruse to justify war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[380]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PostIncident_Border_ReleasedSoldiers = true; RiziaDLC.Vina_Hostage = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PostIncident_Border_ReleasedSoldiers"] = true;
Variable["RiziaDLC.Vina_Hostage"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Axel Reinhart**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[336]`
Mówca: **Axel Reinhart**
> ""Now... It is common for patrols to be near borders. It is another thing entirely to respond with gunfire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Axel Reinhart**
> ""We were in close cooperation since we agreed on our deal on Aureus. And right before the signing... This happens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[338]`
Mówca: **Axel Reinhart**
> ""And how do I reconcile it with the reports from my commanders? They claim your forces were not just defending, but actively pursuing engagement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`
  - -> `[345]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And yet, my reports suggest the exact opposite. That it was your forces who seemed to be edging closer to a conflict. We won't reach anywhere like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This disparity in reports is precisely why a joint investigation is critical. We cannot rely solely on biased perspectives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[341]`
Mówca: **Axel Reinhart**
> ""This cannot be brushed aside as a misunderstanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`
  - -> `[344]`

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not brushing anything aside. I suspect it could be an inside job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do not and I never would underestimate the gravity of the situation, Your Grace. But we must not let this tragedy set the course for our nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you going to threaten me, Your Grace? I'm doing my best to reach an understanding but you are constantly pointing fingers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What would we gain from this, Your Grace? This happened right before the signing of our deal. This is definitely intended to sabotage our claims on Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Axel Reinhart**
> ""Biased perspective? Are you suggesting that Pales is fabricating its reports?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[357]`
  - -> `[358]`

### Węzeł `[347]`
Mówca: **Axel Reinhart**
> ""Sabotage, you say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[348]`
Mówca: **Axel Reinhart**
> ""We cannot rely on biased perspective of the Rizian forces. There is clearly a mismatch between our reports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[349]`
  - -> `[351]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you suggesting that Rizia is fabricating its reports?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. And there's nothing we would gain from this. This happened right before the signing of our deal. This is definitely intended to sabotage our claims on Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suspect it could be an inside job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[352]`
Mówca: **Axel Reinhart**
> ""An inside job? From Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[353]`
Mówca: **Axel Reinhart**
> ""So, you also think that your reports are untrustworthy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`
  - -> `[369]`
  - -> `[370]`

### Węzeł `[354]`
Mówca: **Axel Reinhart**
> ""This cannot be brushed aside as a misunderstanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`
  - -> `[328]`

### Węzeł `[355]`
Mówca: **Axel Reinhart**
> ""Rizian nationalists? An inside job?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not fabricating, Your Grace, but there is always a lens through which situations are viewed. Each side sees the other's actions through a filter of suspicion and defense. Our goal should be to remove these filters and seek the objective truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I'm not pointing fingers at Pales. It could be from within Rizia as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a possibility. How can either of us be certain?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[359]`
Mówca: **Axel Reinhart**
> ""Not at all. But it is a possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[360]`
Mówca: **Axel Reinhart**
> ""The 'objective truth' is a slippery concept, Your Majesty. What is true for Rizia may not be true for Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[361]`
Mówca: **Axel Reinhart**
> ""Looking for certainty is a slippery slope, Your Majesty. What is true for Rizia may not be true for Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Axel Reinhart**
> ""Confusion and paranoia. This perspective is a slippery slope, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Axel Reinhart**
> ""Your call for a joint investigation seems more like a tactic to buy time, perhaps to strengthen your position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[384]`
  - -> `[385]`

### Węzeł `[364]`
Mówca: **Axel Reinhart**
> ""I'm merely pointing out the biases Rizians have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[365]`
  - -> `[367]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suppose it could be an inside job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Each side has a bias, Your Grace, we don't have a monopoly over it. Our goal should be to remove these filters and seek the objective truth. A joint investigation may be necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I won't allow you to point fingers at Rizia. It could be from within Pales as well. Your side would be giving away their rights to the field, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want to believe that but it is a possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are as trustworthy as the Palesian reports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm starting to suspect that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. As soon as Vina leaves Pales with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They will be released. As soon as Vina leaves Pales with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. They will be released immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Pales cannot dictate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[381]`
Mówca: **Axel Reinhart**
> ""You are the side that initiated the attack, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[382]`
Mówca: **Axel Reinhart**
> ""If you are not willing to listen to Palesian demands, we will interpret this as an attack on our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On the contrary, Duke Reinhart. Delay benefits neither of us. The longer this tension persists, the greater the risk of escalation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your Grace, we need to act swiftly and decisively to prevent a conflict that would be catastrophic for both our nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is your suggestion, Your Grace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[386]`
Mówca: **Axel Reinhart**
> ""Catastrophic, indeed. But can you assure me that this investigation will not be swayed by the powers at play?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`
  - -> `[389]`
  - -> `[390]`

### Węzeł `[387]`
Mówca: **Axel Reinhart**
> ""There is great risk, indeed. But can you assure me that this investigation will not be swayed by the powers at play?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`
  - -> `[389]`
  - -> `[390]`

### Węzeł `[388]`
Mówca: **Axel Reinhart**
> ""Neutral international observers must be involved for it to be a proper investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`
  - -> `[425]`

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't think either of us can assure that, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I propose we involve neutral international observers in the investigation. Let them be our eyes and ears, free from the biases of our national interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regardless of the investigation, Rizia wants to continue with our previous deal and preserve peace with Pales. Can you assure me if it's a possibility?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[392]`
Mówca: **Axel Reinhart**
> ""I agree. That could be a way to ensure the investigation is not swayed by either side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`
  - -> `[393]`
  - -> `[394]`

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agreed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would work, Your Grace. However, their findings must be accepted by both Rizia and Pales, without question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[395]`
Mówca: **Axel Reinhart**
> ""Rizia will no longer dictate anything, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Axel Reinhart**
> ""Then you have to prove it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Axel Reinhart: ""Either you will listen to our dema..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[398]`
Mówca: **Axel Reinhart**
> ""Are you going to listen to our concerns, or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[399]`
  - -> `[400]`

### Węzeł `[399]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. And I deeply regret what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Your Grace. You are making a mistake with your harsh attitude. I'm done listening to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Axel Reinhart: ""You'd better have something to off..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[403]`
**[WYBÓR GRACZA: "Keep listening."]** — Mówca: **Player_Romus_Italic**
> "I kept listening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Or what, Your Grace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[406]`
Mówca: **Axel Reinhart**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[407]`
Mówca: **Axel Reinhart**
> ""...Or... Well... Let's not even imagine that scenario.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[408]`
Mówca: **Narrator**
> "He paused for a moment. His face darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Axel Reinhart**
> ""Let's not imagine that scenario.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[410]`
Mówca: **Axel Reinhart**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[411]`
Mówca: **Axel Reinhart**
> ""Then you won't be surprised to hear that the Palesian Navy has been deployed to the Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[412]`
Mówca: **Axel Reinhart**
> ""We will not bow down against your aggression any longer. Rizia will have no access whatsoever to any energy from the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`
  - -> `[595]`
  - -> `[415]`
  - -> `[416]`
  - -> `[534]`

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would be a cause for war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You cannot afford to keep your navy at the field at all times, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[415]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You intended to escalate the situation further, after all...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will let the world know about your stance. Let's see who they'll support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[417]`
Mówca: **Axel Reinhart**
> ""You seem confident despite Rizia's clear breach of international law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[418]`
Mówca: **Axel Reinhart**
> ""Your attack was the cause for everything, Your Majesty, and you know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[419]`
Mówca: **Axel Reinhart**
> ""Oh, you don't know our new capabilities, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[420]`
Mówca: **Axel Reinhart**
> ""You seem confident... As if we were the side that broke their promise and cancelled a deal at the last minute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[421]`
Mówca: **Axel Reinhart**
> ""If you really think anyone will support Rizia, you are living in a land of fantasy, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`
  - -> `[539]`
  - -> `[541]`

### Węzeł `[422]`
Mówca: **Axel Reinhart**
> ""It is a possibility, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[423]`
Mówca: **Axel Reinhart**
> ""No. But neutral international observers can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`
  - -> `[425]`

### Węzeł `[424]`
Mówca: **Axel Reinhart**
> ""And what if the investigations reveal actions that cannot simply be rectified? What if they expose a deeper plot or intention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`
  - -> `[430]`
  - -> `[431]`

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Neutral is a strong word, Your Grace. The international community too have their biases.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[426]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly. Whatever the findings, we shall abide by them and take the necessary steps to rectify any wrongs and restore peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[427]`
Mówca: **Axel Reinhart**
> ""And what if the investigations reveal actions that cannot simply be rectified? What if they expose a deeper plot or intention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`
  - -> `[430]`
  - -> `[431]`

### Węzeł `[428]`
Mówca: **Axel Reinhart**
> ""There is no other way to resolve this without the presence of a third party, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`
  - -> `[466]`
  - -> `[467]`

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then we face those revelations together and act in the interests of peace and justice. It is a risk, but one I believe we must take for the greater good of our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If our expectations from the start are like this, how do we resolve this issue? If both sides want peace, why would any result change anything?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then we will act accordingly, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[432]`
Mówca: **Axel Reinhart**
> ""First of all, you will release our ships and our sailors immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`
  - -> `[435]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[436]`
Mówca: **Axel Reinhart**
> ""Needless to say, your navy will never be deployed back to Aureus again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[437]`
Mówca: **Axel Reinhart**
> ""And you will pay reparations for the ship you sank, as well as the sailors who lost their lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[438]`
Mówca: **Axel Reinhart**
> ""To ensure that, we will proceed with our previously agreed-upon deal. You will officially give up your claim to the gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`
  - -> `[472]`
  - -> `[477]`
  - -> `[478]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`
  - -> `[441]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[442]`
Mówca: **Axel Reinhart**
> ""To ensure that, you will cede half of the rights you obtained to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`
  - -> `[472]`
  - -> `[477]`
  - -> `[478]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[445]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]`

### Węzeł `[446]`
Mówca: **Narrator**
> "He straightened his back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[447]`
Mówca: **Axel Reinhart**
> ""What are you insinuating at?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`
  - -> `[454]`
  - -> `[449]`
  - -> `[450]`
  - -> `[452]`

### Węzeł `[448]`
Mówca: **Axel Reinhart**
> ""What do we about it then, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`
  - -> `[449]`
  - -> `[450]`
  - -> `[452]`

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This disparity in reports is precisely why a joint investigation is critical. We cannot rely solely on biased perspectives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look, Your Grace. I think there's someone else behind this incident. We can't point the fingers at ourselves, we must work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Axel Reinhart: ""Biased perspective? Are you sugges..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This seems like a plan to sabotage our rights on the Aureus. We made a deal, Duke Reinhart and regardless of what happened, you cannot back away from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Simply nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm just saying it could be anyone. We simply cannot jump to conclusions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[455]`
Mówca: **Axel Reinhart**
> ""What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We cannot rule out Pales, Your Grace. I don't think I trust your words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[457]`
Mówca: **Axel Reinhart**
> ""That doesn't inspire confidence, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[458]`
Mówca: **Axel Reinhart**
> ""You might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[459]`
Mówca: **Axel Reinhart**
> ""So you accept to conduct joint investigations together with international partners or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`
  - -> `[605]`
  - -> `[461]`

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes." [Begin Investigations]"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I don't see a point in it anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PostIncident_Border_JointInvestigation = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PostIncident_Border_JointInvestigation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[463]`
Mówca: **Axel Reinhart**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`

### Węzeł `[464]`
Mówca: **Axel Reinhart**
> ""Okay... And who might that be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`
  - -> `[707]`
  - -> `[709]`
  - -> `[708]`

### Węzeł `[465]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry but I don't support this. There are other powers at play and I cannot hand them the keys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[469]`
Mówca: **Axel Reinhart**
> ""First of all, you must pay reparations for the ship you sank, and the suffering and chaos it brought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[470]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn06_Pales_ListenedToDemands = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn06_Pales_ListenedToDemands"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2 &&(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`
  - -> `[474]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2 &&(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2  and (Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2 &&(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2  and (Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]`

### Węzeł `[475]`
**[WYBÓR GRACZA: ""Anything for peace." [Accept the deal] [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Anything for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[476]`
**[WYBÓR GRACZA: ""Anything for peace." [Accept the deal] [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Anything for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can agree to the gas field but not the reparations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can agree to the reparations but not the gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`
  - -> `[481]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[482]`
Mówca: **Axel Reinhart**
> ""I think we can make it work, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // RIZIA CEDES GAS FIELD)*
- **Efekt (`userScript`):** `-- RIZIA CEDES GAS FIELD;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`
  - -> `[486]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[487]`
Mówca: **Axel Reinhart**
> ""I think we can make it work, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // RIZIA CEDES 25% GAS FIELD)*
- **Efekt (`userScript`):** `-- RIZIA CEDES 25% GAS FIELD;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[489]`
Mówca: **Axel Reinhart**
> ""That will not do, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[490]`
Mówca: **Axel Reinhart**
> ""That will not do, Your Majesty. You cannot simply get the entirety of Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`
  - -> `[493]`

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[493]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[494]`
Mówca: **Axel Reinhart**
> ""That will not do, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[495]`
Mówca: **Axel Reinhart**
> ""You must, at the very least, agree to the AN's resolution and make the deal official. They already gave you half of the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. We are not giving up anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[497]`
**[WYBÓR GRACZA: ""Fine. I agree to it." [Agree to 50%] [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Fine. I agree to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[498]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But we won't, Your Grace. Your attitude made me change my mind about Aureus. Rizia will not give up an inch of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[499]`
**[WYBÓR GRACZA: ""Deal." [Accept the deal]"]** — Mówca: **Player_Romus**
> ""Deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[500]`
**[WYBÓR GRACZA: ""Deal." [Accept the deal]"]** — Mówca: **Player_Romus**
> ""Deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1;
RiziaDLC.Pales_PostIncident_Deal_50 = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLC.Pales_PostIncident_Deal_50"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[504]`
Mówca: **Axel Reinhart**
> ""You must, at the very least, agree to the AN's resolution and acknowledge Palesian ownership of the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`
  - -> `[506]`

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. We are not giving up that field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[506]`
**[WYBÓR GRACZA: ""Fine. I agree to it." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Fine. I agree to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1;
RiziaDLC.Pales_PostIncident_Deal_Cede = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`
  - -> `[510]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[511]`
Mówca: **Axel Reinhart**
> ""That will not do, Your Majesty. You cannot simply cancel your deal to cede your rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[512]`
Mówca: **Axel Reinhart**
> ""You must, at the very least, respect our previous agreement and make the deal official. We can reconsider reparations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`
  - -> `[514]`

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. We are not giving up that field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[514]`
**[WYBÓR GRACZA: ""Fine. I agree to it." [Agree to deal]"]** — Mówca: **Player_Romus**
> ""Fine. I agree to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_Cede = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "He paused for a moment. His face da..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[517]`
Mówca: **Axel Reinhart**
> ""That's great to hear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[518]`
Mówca: **Axel Reinhart**
> ""I knew you would see reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[519]`
Mówca: **Axel Reinhart**
> ""What!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[521]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`
  - -> `[523]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[523]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Naval_FocusAidOnValero == true || RiziaDLC.Incident_Naval_NoRescue == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Naval_FocusAidOnValero"] == true  or  Variable["RiziaDLC.Incident_Naval_NoRescue"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[524]`
Mówca: **Axel Reinhart**
> ""You must claim responsibility for the Palesian lives that were lost in the Antacean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`
  - -> `[527]`

### Węzeł `[525]`
Mówca: **Axel Reinhart**
> ""I think we can make it work, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`
  - -> `[526]`

### Węzeł `[526]`
**[WYBÓR GRACZA: ""Deal." [Accept the deal]"]** — Mówca: **Player_Romus**
> ""Deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[527]`
**[WYBÓR GRACZA: ""Deal." [Accept the deal] [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_Cede = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_Cede = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_25 = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_25"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_Cede = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]`

### Węzeł `[533]`
Mówca: **Axel Reinhart**
> ""That's great to hear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[534]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's calm down, Your Grace. Nobody wants a war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[535]`
Mówca: **Axel Reinhart**
> ""Rizia cannot threaten us with war anymore, Your Majesty. I thought you were a more careful man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[536]`
Mówca: **Axel Reinhart**
> ""And you seem not to be aware of our naval capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[537]`
Mówca: **Axel Reinhart**
> ""I intend to block your access to Aureus, and I don't think you can do anything about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`
  - -> `[540]`
  - -> `[599]`

### Węzeł `[538]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will not get away with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[539]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you try to block our access, we will take it by force. This would be cause for war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[540]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you try to block our access, we will take it by force. This is a cause for war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[541]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Take the whole field. I couldn't care less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[542]`
Mówca: **Axel Reinhart**
> ""As I already said, it is not a matter of *if* anymore. Our navy should be arriving as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[543]`
Mówca: **Axel Reinhart**
> ""Pales is ready to defend what is ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`
  - -> `[545]`
  - -> `[541]`

### Węzeł `[544]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will not retaliate. But you are making a mistake. This will have dire consequences for both of our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then war it is, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[546]`
Mówca: **Narrator**
> "He looked at me with skepticism."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[547]`
Mówca: **Axel Reinhart**
> ""I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[548]`
Mówca: **Axel Reinhart**
> ""As long as Rizia respects our claim and our sovereignty, we can still work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`
  - -> `[550]`
  - -> `[551]`

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will cede all of our rights to Pales. We don't need to be enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can never officially recognize that, Your Grace. But I intend to leave Pales alone. We don't need to be enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[551]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There will be no more working together. Let that be clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[552]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // WAR!)*
- **Efekt (`userScript`):** `-- WAR!;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[554]`
Mówca: **Axel Reinhart**
> ""You have forced my hand, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[555]`
Mówca: **Axel Reinhart**
> ""I would have rather have come to an understanding. But here we are...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`
  - -> `[557]`
  - -> `[558]`
  - -> `[576]`

### Węzeł `[556]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... Thank you for the meeting nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[558]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know what? In the name of friendship, I'm willing to officially cede our rights to the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[559]`
Mówca: **Narrator**
> "He looked at me with skepticism."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[560]`
Mówca: **Axel Reinhart**
> ""That would be a massive gesture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[561]`
Mówca: **Axel Reinhart**
> ""I'm sorry you came all the way here for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[562]`
Mówca: **Axel Reinhart**
> ""I understand this was a difficult decision to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[563]`
Mówca: **Axel Reinhart**
> ""But perhaps we can still work together in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`
  - -> `[569]`
  - -> `[551]`

### Węzeł `[564]`
Mówca: **Narrator**
> "He stood up and reached out for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`
  - -> `[566]`

### Węzeł `[565]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Romus_Italic**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[566]`
**[WYBÓR GRACZA: "Ignore his hand."]** — Mówca: **Player_Romus_Italic**
> "I ignored his hand and stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[567]`
Mówca: **Axel Reinhart**
> ""Well, then. Have a nice day, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`

### Węzeł `[568]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite everything, Rizia is ready for that, Your Grace. You can count on us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will see about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[570]`
Mówca: **Axel Reinhart**
> ""At least we have reached some level of understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[571]`
Mówca: **Narrator**
> "We both stood up and shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[572]`
Mówca: **Axel Reinhart**
> ""Thank you for coming to Pales, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[573]`
Mówca: **Axel Reinhart**
> ""Really? You would do that for Pales?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[574]`
Mówca: **Axel Reinhart**
> ""If you cede the field to us officially, not only the incident can be put behind us but I would be indebted to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`
  - -> `[500]`

### Węzeł `[575]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... No I can't. Thank you for the meeting nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[576]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you don't pull your ships back from the field... War it is, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[577]`
Mówca: **Narrator**
> "A sudden spasm of fear took hold of his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[578]`
Mówca: **Axel Reinhart**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[579]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Peace_NoDeal = true;
RiziaDLCSupport.News_Turn06_G_PostIncidentNoDeal = true;
RiziaDLCSupport.News_Turn06_RH_PostIncidentNoDeal = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_NoDeal"] = true;
Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentNoDeal"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PostIncidentNoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[580]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War = true;
RiziaDLC.Situation_Military_PalesianWarDeployment = true;
RiziaDLCSupport.News_Turn06_RH_PostIncidentTalkBreakdown = true;
RiziaDLCSupport.News_Turn06_G_PostIncidentTalkBreakdown = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower = -100;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pales_War"] = true;
Variable["RiziaDLC.Situation_Military_PalesianWarDeployment"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PostIncidentTalkBreakdown"] = true;
Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentTalkBreakdown"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = -100;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Peace_Deal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`
  - -> `[584]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[584]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_CedeCancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]`

### Węzeł `[585]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_Cede = true;
RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded = true;
RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCeded = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_Cede"] = true;
Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCeded"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_PostIncident_Deal_25 = true;
RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCededPartial = true;
RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCededPartial = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pales_PostIncident_Deal_25"] = true;
Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCededPartial"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCededPartial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[587]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`
  - -> `[589]`

### Węzeł `[588]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[589]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[590]`
Mówca: **Axel Reinhart**
> ""Needless to say, Vina will be returned to Rizia -- without a scratch on her, by the way. But of course, your navy will never be deployed back to Aureus again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[591]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`
  - -> `[593]`

### Węzeł `[592]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[593]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[594]`
Mówca: **Axel Reinhart**
> ""And I'm afraid I may have changed my mind about allowing your daughter to return home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[595]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`
  - -> `[597]`

### Węzeł `[596]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[597]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[598]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you do anything to Vina, Pales will cease to exist, Your Grace. I promise you that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[599]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`
  - -> `[601]`

### Węzeł `[600]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[601]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Just take the whole field in exchange for Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`

### Węzeł `[603]`
Mówca: **Axel Reinhart**
> ""If you make the deal official, we can still work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`
  - -> `[604]`

### Węzeł `[604]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I won't sign that deal. But you have to let Vina go. Otherwise it will be war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[605]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen. I suspect this was fabricated by another player in our region. We should be working together instead of suspecting each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[606]`
Mówca: **Axel Reinhart**
> ""Then your deal is off the table, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[607]`
Mówca: **Axel Reinhart**
> ""If Rizia can't be a trustable partner, I will not sign the papers -- and you will not be able to extract anything from Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[608]`
Mówca: **Axel Reinhart**
> ""I hope you are not claiming we had a hand in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[609]`
Mówca: **Axel Reinhart**
> ""And you know what, Your Majesty? We can back off from the deal, because the extraction rights were not officially finalized yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`
  - -> `[611]`
  - -> `[612]`
  - -> `[613]`

### Węzeł `[610]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[611]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would be a grand mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look, Your Grace. I think there's someone else behind this incident. We can't point the fingers at ourselves, we must work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[613]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We cannot rely solely on biased perspectives, Your Grace. We should investigate this incident thoroughly before taking any drastic actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[614]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Axel Reinhart: ""Biased perspective? Are you sugges..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[615]`
Mówca: **Axel Reinhart**
> ""Well... If you're not offering any solution out of this mess, I will back off from the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`
  - -> `[612]`
  - -> `[613]`

### Węzeł `[616]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Axel Reinhart: ""Then your deal is off the table, Y..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[617]`
Mówca: **Axel Reinhart**
> ""We will make it official soon, Your Majesty. I will invite you to Pales again for the final steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[618]`
Mówca: **Axel Reinhart**
> ""I hope no more incidents will take place before then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`
  - -> `[621]`
  - -> `[620]`
  - -> `[619]`

### Węzeł `[619]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[620]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The responsibility falls on both of our shoulders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[621]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't let that happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[622]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agreed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[623]`
Mówca: **Axel Reinhart**
> ""Well, then. Have a nice day, Your Majesty. We'll see each other again soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[624]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`
  - -> `[626]`

### Węzeł `[625]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[626]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]`

### Węzeł `[627]`
Mówca: **Narrator**
> "I left the meeting room with quick steps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[628]`
Mówca: **Narrator**
> "Laurento was waiting for me outside. I told him about everything we'd talked about."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]`

### Węzeł `[629]`
Mówca: **Axel Reinhart**
> ""Well, then. Have a nice day, Your Majesty. We'll see each other again soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[630]`
Mówca: **Axel Reinhart**
> ""We will not bow down against your aggression any longer. Rizia will have no access whatsoever to any energy from the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`
  - -> `[657]`
  - -> `[652]`
  - -> `[653]`
  - -> `[633]`

### Węzeł `[631]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would be a cause for war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[632]`
Mówca: **Axel Reinhart**
> ""If you really think the AN would support Rizia, you are living in a land of fantasy, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`
  - -> `[638]`
  - -> `[640]`

### Węzeł `[633]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's calm down, Your Grace. Nobody wants a war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[634]`
Mówca: **Axel Reinhart**
> ""Rizia cannot threaten us with war anymore, Your Majesty. I thought you were a more careful man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[635]`
Mówca: **Axel Reinhart**
> ""And you seem not to be aware of our navy's capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[636]`
Mówca: **Axel Reinhart**
> ""I intend to block access to Rizia, and I don't think you can do anything about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`
  - -> `[637]`
  - -> `[639]`
  - -> `[647]`

### Węzeł `[637]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will not get away with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[638]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you try to block our access, we will take it by force. This would be cause for war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[639]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you try to block our access, we will take it by force. This is a cause for war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[640]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Take the whole field. I couldn't care less. I will back off from the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[641]`
Mówca: **Axel Reinhart**
> ""As I already said, it is not a matter of *if* anymore. Deal is off the table.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[642]`
Mówca: **Axel Reinhart**
> ""Rizia will not extract anything from Aureus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`
  - -> `[644]`
  - -> `[640]`

### Węzeł `[643]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are making a mistake. This will have dire consequences for both of our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[644]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then war it is, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[645]`
Mówca: **Narrator**
> "He looked at me with skepticism."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[646]`
Mówca: **Axel Reinhart**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[647]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`
  - -> `[649]`

### Węzeł `[648]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`

### Węzeł `[649]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[650]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Just take the whole field in exchange for Vina. I will back off from the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You cannot simply back off from the deal at the last minute like this, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[652]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You intended to escalate the situation further after all...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[653]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The world will learn about how you cancelled the deal. Let's see who they'll support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[654]`
Mówca: **Axel Reinhart**
> ""You seem confident despite having no real friends outside of GRACE, Your Majesty. We have powerful allies in the international arena.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`

### Węzeł `[655]`
Mówca: **Axel Reinhart**
> ""Oh, but I can, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[656]`
Mówca: **Axel Reinhart**
> ""Your attack was the cause for everything, Your Majesty, and you know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[657]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`
  - -> `[659]`

### Węzeł `[658]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[659]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`

### Węzeł `[660]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you do anything to Vina, Pales will cease to exist, Your Grace. I promise you that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[661]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's calm down, Your Grace. Can't we work something out? Rizia wants to keep the deal between our countries. We've invested so much into this project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`

### Węzeł `[662]`
Mówca: **Axel Reinhart**
> ""You forced my hand, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`

### Węzeł `[663]`
Mówca: **Axel Reinhart**
> ""I would have rather achieved something here today. But here we are...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`
  - -> `[665]`
  - -> `[666]`
  - -> `[670]`

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... Thank you for the meeting nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[665]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[666]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you don't sign that deal, then war it is, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[667]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "A sudden spasm of fear took hold of..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[668]`
Mówca: **Axel Reinhart**
> ""As long as Rizia respects it, we may still continue our relations with your kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`
  - -> `[670]`
  - -> `[671]`

### Węzeł `[669]`
**[WYBÓR GRACZA: ""Fine. Aureus is completely yours. We don't need to be enemies.""]** — Mówca: **Player_Romus**
> ""Fine. Aureus is completely yours. We don't need to be enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[670]`
**[WYBÓR GRACZA: ""I can not force you to sign the deal, Your Grace. But I don't intend to work together with Pales anymore. You have lost the support of Rizia.""]** — Mówca: **Player_Romus**
> ""I can not force you to sign the deal, Your Grace. But I don't intend to work together with Pales anymore. You have lost the support of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[671]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know what, Your Grace? If you go this path, expect a military response. War, it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[672]`
Mówca: **Axel Reinhart**
> ""Then, peace will prevail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[673]`
Mówca: **Axel Reinhart**
> ""So be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[674]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Axel Reinhart: ""I understand this was a difficult..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[675]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Axel Reinhart: ""I'm sorry you came all the way her..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[676]`
Mówca: **Axel Reinhart**
> ""We will not take any actions until the results are in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[677]`
Mówca: **Axel Reinhart**
> ""But until we clear this up, we have to cancel the official signing of our deal for the time being.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`

### Węzeł `[678]`
Mówca: **Axel Reinhart**
> ""Until we have clear answers, Pales will not be transferring the extraction rights to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`
  - -> `[679]`
  - -> `[680]`
  - -> `[681]`

### Węzeł `[679]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can you give me any guarantee that you will sign the deal after the investigations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[680]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's fair. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[681]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have invested heavily into this project, Your Grace. If you decide to sabotage it, I promise you, Pales will pay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[682]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agreed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[683]`
Mówca: **Axel Reinhart**
> ""Great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[684]`
Mówca: **Narrator**
> "We both stood up and shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`

### Węzeł `[685]`
Mówca: **Axel Reinhart**
> ""Thank you for coming to Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`

### Węzeł `[686]`
Mówca: **Axel Reinhart**
> ""As long as Rizia's name has been cleared, I promise you, we will continue with the deal as promised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[687]`
Mówca: **Axel Reinhart**
> ""If Rizia's name will be cleared, Pales will resume the deal as promised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`
  - -> `[689]`
  - -> `[690]`

### Węzeł `[688]`
Mówca: **Axel Reinhart**
> ""There is no need for threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`

### Węzeł `[689]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright. Thank you for the meeting, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[690]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. You'd better not break your promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[691]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[692]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PostIncident_Border_JointInvestigation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`
  - -> `[694]`

### Węzeł `[693]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PostIncident_Border_JointInvestigation == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PostIncident_Border_JointInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]`

### Węzeł `[694]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PostIncident_Border_JointInvestigation == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PostIncident_Border_JointInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[695]`
Mówca: **Narrator**
> "The Duke waved his hand. The door opened, and I saw Vina waiting for me outside by the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[696]`
Mówca: **Axel Reinhart**
> ""We do not take hostages here, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]`

### Węzeł `[697]`
Mówca: **Narrator**
> "He smiled as my daughter rushed to embrace me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]`

### Węzeł `[698]`
Mówca: **Axel Reinhart**
> ""Oh, by the way... Miss Toras will be staying with us until the investigations are complete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[699]`
Mówca: **Axel Reinhart**
> ""You are making the same mistakes are your father, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]`

### Węzeł `[700]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage = true; RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Vina_Hostage"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]`

### Węzeł `[701]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`
  - -> `[703]`

### Węzeł `[702]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[703]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]`

### Węzeł `[704]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Vina_Hostage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[705]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not going to play into your hand. Rizia is not going to be forced to offer anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[706]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`

### Węzeł `[707]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`

### Węzeł `[708]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`

### Węzeł `[709]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`

### Węzeł `[710]`
Mówca: **Axel Reinhart**
> ""Why would Morellans be behind this, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`

### Węzeł `[711]`
Mówca: **Axel Reinhart**
> ""Their influence and presence is all too weak to orchestrate something of this scale without alerting our security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]`
  - -> `[726]`
  - -> `[773]`
  - -> `[781]`

### Węzeł `[712]`
Mówca: **Axel Reinhart**
> ""The Queen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`

### Węzeł `[713]`
Mówca: **Axel Reinhart**
> ""Isn't she the one who's fuelling Rizia's political ambitions in Southern Merkopa?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]`

### Węzeł `[714]`
Mówca: **Axel Reinhart**
> ""Are you claiming she wanted to stop Rizia from getting access to more gas -- despite being Rizia's largest energy partner?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`
  - -> `[721]`
  - -> `[722]`

### Węzeł `[715]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Rumburg_Unfriendly == true || RiziaDLC.CountryRelation_Rumburg_Hostile == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`
  - -> `[717]`

### Węzeł `[716]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Rumburg_Unfriendly == true || RiziaDLC.CountryRelation_Rumburg_Hostile == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == true  or  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[717]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Rumburg_Unfriendly == true || RiziaDLC.CountryRelation_Rumburg_Hostile == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Rumburg_Unfriendly"] == true  or  Variable["RiziaDLC.CountryRelation_Rumburg_Hostile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`

### Węzeł `[718]`
Mówca: **Axel Reinhart**
> ""Yes... Valgsland has ambitions in these regions. But they don't have any reason to sabotage this deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`
  - -> `[731]`
  - -> `[732]`

### Węzeł `[719]`
Mówca: **Axel Reinhart**
> ""Of course you would say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]`

### Węzeł `[720]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our relationship has soured of late. I suspect my sister-in-law is trying to hassle us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[721]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The amount of gas we'll gain from Aureus will have other nations begging at our feet. Queen Beatrice would never stand for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[722]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She is counting on Rizia to annex Pales and become more powerful -- and thus of more use to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[723]`
Mówca: **Axel Reinhart**
> ""I don't buy that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[724]`
Mówca: **Axel Reinhart**
> ""There are no reports or traces of any Rumburgian activity. If you cannot show me any proof -- this will only sound like a conspiracy theory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[725]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are underestimating their new government. Prime Minister Saltana is a troublesome woman. She wants our monarchies gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[726]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are commies, Axel. You know what they are capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[727]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are fighting against Saltana's nationalization of the Meftiem International Trade Zone. This is her way of incapacitating us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[728]`
Mówca: **Axel Reinhart**
> ""I don't buy that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`

### Węzeł `[729]`
Mówca: **Axel Reinhart**
> ""There are no reports or traces of any Morellan activity. If you cannot show me any proof -- this will only sound like a conspiracy theory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[730]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know they will come to reclaim Pales sooner or later, Your Grace. That's why they want to keep the field in your hands for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]`

### Węzeł `[731]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are commies, Axel. You know what they are capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]`

### Węzeł `[732]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are a threat in their eyes. Valgsland doesn't want our countries to be close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]`

### Węzeł `[733]`
Mówca: **Axel Reinhart**
> ""And I want a neutral investigation by the international community to be conducted. We will wait for the results before finalizing the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[734]`
Mówca: **Axel Reinhart**
> ""I want Rizia to pay reparations for the incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`

### Węzeł `[735]`
Mówca: **Axel Reinhart**
> ""These are my terms, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]`
  - -> `[737]`

### Węzeł `[736]`
**[WYBÓR GRACZA: ""Deal." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`

### Węzeł `[737]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no way I can accept this. If you back away from our deal like this, you will be throwing everything you had with Rizia away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[738]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PostIncident_Border_JointInvestigation = true;
RiziaDLC.Pales_PostIncident_Peace_Deal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PostIncident_Border_JointInvestigation"] = true;
Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[739]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[740]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`
  - -> `[742]`

### Węzeł `[741]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`

### Węzeł `[742]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[743]`
Mówca: **Axel Reinhart**
> ""I want a neutral investigation by the international community to be conducted. We will wait for the results before finalizing the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[744]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`
  - -> `[746]`

### Węzeł `[745]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]`

### Węzeł `[746]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]`

### Węzeł `[747]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[748]`
Mówca: **Axel Reinhart**
> ""You will be responsible for all of the lives that will be lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`

### Węzeł `[749]`
Mówca: **Narrator**
> "He quickly got up and gestured at the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[750]`
Mówca: **Axel Reinhart**
> ""You are no longer welcome here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`
  - -> `[753]`
  - -> `[755]`

### Węzeł `[751]`
Mówca: **Axel Reinhart**
> ""Goodbye, Romus. I'll take good care of your daughter until the war is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]`

### Węzeł `[752]`
Mówca: **Narrator**
> "His security quickly ushered me outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`

### Węzeł `[753]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I offered you a chance for peace, Axel. But you are standing in my way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`

### Węzeł `[754]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We will meet again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`

### Węzeł `[755]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. We will make it quick.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`

### Węzeł `[756]`
Mówca: **Narrator**
> "I walked through the hall with quick steps -- images of war and horror appearing in my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]`

### Węzeł `[757]`
Mówca: **Narrator**
> "Laurento was waiting for me outside with a concerned look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`

### Węzeł `[758]`
Mówca: **Narrator**
> "I tried to tell him about what happened with as few words as possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]`

### Węzeł `[759]`
Mówca: **Narrator**
> "He smiled broadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]`

### Węzeł `[760]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]`
  - -> `[762]`

### Węzeł `[761]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[762]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_WonHalf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[763]`
Mówca: **Axel Reinhart**
> ""To ensure that, you will sign an official concession acknowledging the AN arbitration results and Pales' full ownership of the gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`
  - -> `[472]`
  - -> `[477]`
  - -> `[478]`

### Węzeł `[764]`
Mówca: **Axel Reinhart**
> ""Don't mock me, Your Majesty. Consider your offer rejected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[765]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < -1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`
  - -> `[767]`

### Węzeł `[766]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina < -1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`

### Węzeł `[767]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina < -1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[768]`
Mówca: **Narrator**
> "As Laurento, Vina and I left the castle, my daughter was the only one who wasn't smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]`

### Węzeł `[769]`
Mówca: **Narrator**
> "I took one last look back as I went outside to rejoin Laurento and tell him what I'd agreed to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]`

### Węzeł `[770]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]`
  - -> `[772]`

### Węzeł `[771]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[772]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`
  - -> `[721]`
  - -> `[722]`

### Węzeł `[773]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`
  - -> `[775]`

### Węzeł `[774]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[775]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Renegotiation_Failed == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[776]`
Mówca: **Axel Reinhart**
> ""Lespia is our biggest partner. And you've been long despising the assistance they've given us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]`
  - -> `[790]`
  - -> `[791]`
  - -> `[792]`

### Węzeł `[777]`
Mówca: **Axel Reinhart**
> ""I don't buy that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]`

### Węzeł `[778]`
Mówca: **Axel Reinhart**
> ""There are no reports or traces of any Valgish activity. If you cannot show me any proof -- this will only sound like a conspiracy theory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[779]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[782]`
  - -> `[783]`
  - -> `[784]`

### Węzeł `[780]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know her well and I don't trust her one bit. I suspect my sister-in-law is trying to hassle us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[781]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are a threat in their eyes. Morella doesn't want our countries to be close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[782]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just think about it, Axel. It just makes sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]`

### Węzeł `[783]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have any proof.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]`

### Węzeł `[784]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What else do you want? That's enough proof of their meddling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]`

### Węzeł `[785]`
Mówca: **Axel Reinhart**
> ""No, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[786]`
Mówca: **Axel Reinhart**
> ""I am much more convinced that we need this neutral investigation. I don't see any other path forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]`

### Węzeł `[787]`
Mówca: **Axel Reinhart**
> ""So do you accept to conduct joint investigations together with international partners or not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`
  - -> `[461]`

### Węzeł `[788]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Axel Reinhart: ""So do you accept to conduct joint..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]`

### Węzeł `[789]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And they have been pushing over the control of Aureus through a deal with you. Haven't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]`

### Węzeł `[790]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That is precisely the point. They want you to stay reliant on them and having a separate deal with us surely didn't make them happy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]`

### Węzeł `[791]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are a threat in their eyes. Lespia doesn't want our countries to be close. You know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]`

### Węzeł `[792]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are the direct agents of ATO in all Eastern Merkopa. This is their plan to dismantle our monarchies from within.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]`

### Węzeł `[793]`
Mówca: **Axel Reinhart**
> ""Mr. Alvarez is surely mad about our deal to sell the rights to Rizia instead, but do you really think he'd go that far...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`
  - -> `[795]`
  - -> `[796]`

### Węzeł `[794]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why wouldn't he? He has both the means and the goals to sabotage our deal. And he is succeeding with every second we suspect each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[795]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who else, Your Grace? Rizia is surely not behind this as we've already paid our sum for the rights. And this happens right before it's finalized. The only loser of this deal is Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[796]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are puppets of the game Arcasia is playing in our region. You know how far they can go, Axel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[797]`
Mówca: **Axel Reinhart**
> ""I don't buy that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[798]`
Mówca: **Axel Reinhart**
> ""I suppose you might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]`

### Węzeł `[799]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_NegotiatingPower > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]`
  - -> `[801]`

### Węzeł `[800]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_NegotiatingPower > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]`

### Węzeł `[801]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_NegotiatingPower > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]`

### Węzeł `[802]`
Mówca: **Axel Reinhart**
> ""I don't know, Your Majesty. I won't be convinced like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[803]`
Mówca: **Axel Reinhart**
> ""We have to look into this together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`

### Węzeł `[804]`
Mówca: **Narrator**
> "He stopped for a moment to think."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]`

### Węzeł `[805]`
Mówca: **Axel Reinhart**
> ""However, if you really want us to continue with this deal, I expect you to acknowledge the Rizian mistakes that led to this incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]`

### Węzeł `[806]`
Mówca: **Axel Reinhart**
> ""My people will expect something from your side. If we're to be going this route together, I expect you to pay reparations for the violent exchange.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[807]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]`
  - -> `[809]`

### Węzeł `[808]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Incident_Border_KillSoldiers == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]`

### Węzeł `[809]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Incident_Border_KillSoldiers == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]`

### Węzeł `[810]`
Mówca: **Axel Reinhart**
> ""I only ask of a modest sum. As a symbolic gesture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[838]`
  - -> `[812]`

### Węzeł `[811]`
**[WYBÓR GRACZA: ""Anything for peace." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Anything for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]`

### Węzeł `[812]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Your Grace. Absolutely out of the question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]`

### Węzeł `[813]`
Mówca: **Axel Reinhart**
> ""You have to pay for the Palesian lives that were killed by the Rizian Army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]`
  - -> `[812]`

### Węzeł `[814]`
Mówca: **Axel Reinhart**
> ""Then there won't be any deals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[815]`
**[WYBÓR GRACZA: ""Anything for peace." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Anything for peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]`

### Węzeł `[816]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]`

### Węzeł `[817]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]`

### Węzeł `[818]`
Mówca: **Axel Reinhart**
> ""Great. Then I believe I can make our signing work on our previously agreed-upon date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[819]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DisableToken("Rizia_Event_Aureus");)*
- **Efekt (`userScript`):** `DisableToken("Rizia_Event_Aureus");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[820]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]`
  - -> `[822]`

### Węzeł `[821]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[828]`

### Węzeł `[822]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`

### Węzeł `[823]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_V_PalesWarStart = true;
RiziaDLCSupport.News_Turn06_RH_PalesWarStart = true;
RiziaDLCSupport.News_Turn06_G_PalesWarStart = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_V_PalesWarStart"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PalesWarStart"] = true;
Variable["RiziaDLCSupport.News_Turn06_G_PalesWarStart"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]`

### Węzeł `[824]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_Completed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]`
  - -> `[826]`

### Węzeł `[825]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_Completed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]`

### Węzeł `[826]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_Completed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_TeradorAirforceBaseExpansion_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`

### Węzeł `[827]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn06_Terador_AirbaseStormed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Terador_AirbaseStormed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`

### Węzeł `[828]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_RH_VinaHeldInPales = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_RH_VinaHeldInPales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`

### Węzeł `[829]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `RemoveConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[830]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[831]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded = true;
RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCeded = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCeded"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCeded"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[832]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCededPartial = true;
RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCededPartial = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_G_PostIncidentDealFieldCededPartial"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_PostIncidentDealFieldCededPartial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[833]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn06_Pales_ThanksRomusForVisit = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Pales_ThanksRomusForVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[834]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Impasse", "R_Impasse_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Impasse","R_Impasse_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[835]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]`
  - -> `[837]`

### Węzeł `[836]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[837]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[838]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[839]`
  - -> `[840]`

### Węzeł `[839]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]`

### Węzeł `[840]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[841]`

### Węzeł `[841]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't afford your symbolism, Duke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]`

### Węzeł `[842]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[843]`
  - -> `[844]`

### Węzeł `[843]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`

### Węzeł `[844]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[845]`

### Węzeł `[845]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Peace is too expensive for our kingdom, Duke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]`

### Węzeł `[846]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Balancing peace and war after a crisis", "Old Town", "Grand-Duchy of Pales");)*
- **Efekt (`userScript`):** `SetRichPresence("Balancing peace and war after a crisis","Old Town","Grand-Duchy of Pales");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]`
