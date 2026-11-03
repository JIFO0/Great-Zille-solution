# Rizia/Turn 4/FPnT_AlvarezCall

- **ID konwersacji:** `314`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Rizia/Turn_04/314_FPnT_AlvarezCall.md`
- **Liczba węzłów dialogowych:** 597
- **Liczba wyborów gracza:** 160

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[70]** Laurento Esquibel
- **[95]** Player_Romus *(Gracz)*
- **[99]** Patricio Alvarez (R)

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_Cede`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLCIsolated.Turn04_Alvarez_Alcoholic`
- `RiziaDLCIsolated.Turn04_Alvarez_Father`
- `RiziaDLCIsolated.Turn04_Alvarez_Trustworthy`
- `RiziaDLCIsolated.Turn04_Alvarez_Want`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_PalesPipelineConstruction`
- `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal`
- `RiziaDLC.Diplomacy_Lespia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Lespia_PromiseITZSupport`
- `RiziaDLC.Diplomacy_Lespia_WehlenHelp`
- `RiziaDLC.Diplomacy_Morella_NegotiatingPower`
- `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_Cancelled`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_BuyCancelled`
- `RiziaDLC.Diplomacy_Pales_GasField_Cede`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Pales`
- `RiziaDLC.Policy_Economy_PalesPipeline_Project`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Zille_ReferendumPower`
- `RiziaDLC.Zille_ViolentResistancePower`
- `RiziaDLCIsolated.Turn04_Alvarez_Alcoholic`
- `RiziaDLCIsolated.Turn04_Alvarez_Father`
- `RiziaDLCIsolated.Turn04_Alvarez_Trustworthy`
- `RiziaDLCIsolated.Turn04_Alvarez_Want`
- `RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal`
- `RiziaDLCSupport.Journal_Turn04_Lespia_PromiseITZSupport`
- `RiziaDLCSupport.Journal_Turn04_Pales_EndGasDeal`
- `RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal`
- `RiziaDLCSupport.News_Turn04_G_AN_UpcomingMeeting`
- `RiziaDLCSupport.News_Turn04_G_RiziaPales_Arbitration`
- `RiziaDLCSupport.News_Turn04_G_RiziaPales_Deal`
- `RiziaDLCSupport.News_Turn04_G_RiziaPales_NavalBlockade`
- `RiziaDLCSupport.News_Turn04_RH_RiziaPales_Arbitration`
- `RiziaDLCSupport.News_Turn04_RH_RiziaPales_Deal`
- `RiziaDLCSupport.News_Turn04_RH_RiziaPales_NavalBlockade`
- `RiziaDLCSupport.Reports_Turn04_NavyWithdrawn`
- `RiziaDLCSupport.Reports_Turn04_Pales_PalesianNavySent`
- `RiziaDLCSupport.Reports_Turn04_PorteDrazon_Arbitration_Canceled`
- `RiziaDLCSupport.Reports_Turn04_PorteDrazon_SellField_Reneged`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 11
- **Węzły modyfikujące stan gry:** 46

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Budget_Modifier_PalesPipelineConstruction`
- `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_Cancelled`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_BuyCancelled`
- `RiziaDLC.Diplomacy_Pales_GasField_Cede`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Pales`
- `RiziaDLC.Policy_Economy_PalesPipeline_Project`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Zille_ReferendumPower`
- *...oraz 10 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[65]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] = true;`
- Węzeł `[66]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] = true;`
- Węzeł `[67]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] = true;`
- Węzeł `[68]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] = true;`
- Węzeł `[252]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;`
- Węzeł `[253]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] = true; Variable["RiziaDLC.Zille_ViolentResistan...`
- Węzeł `[254]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;`
- Węzeł `[261]` (Paskal Beniwoll): `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] = false; Variable["RiziaDLCSuppor...`
- *...oraz 38 innych węzłów ze skryptami.*

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
  - -> `[596]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It had been a week since my meeting with Duke Reinhart in Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I had signed an official document ceding ownership of the Aureus gas field to the Grand Duchy of Pales. Elena and the Palesian economic minister were busy drawing up our deal to purchase the exploration rights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
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
  - -> `[12]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "I had signed an official document ceding ownership of the Aureus gas field to the Grand Duchy of Pales. According to reports, LesPower would shortly purchase the exploration rights to the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Narrator**
> "The Alliance of Nations had accepted our request to arbitrate ownership of the Aureus gas field. Preliminary hearings were to begin soon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "In the meantime, Lespian prime minister Patricio Alvarez had contacted Laurento, asking to speak with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Narrator**
> "I was spending the week at my palace in Monqiz. Laurento visited to brief me ahead of the phone call."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Narrator**
> "He stepped in front of my desk and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Laurento Esquibel**
> ""Good afternoon, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`
  - -> `[19]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust you're well, Mr. Esquibel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No time for small talk. Prime Minister Alvarez will be calling soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't know if it's a good afternoon or not until I've found out what Lespia wants from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
Mówca: **Laurento Esquibel**
> ""Well enough. Though I must say I'm worried by the increasing tensions in Southern Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll do my best to defuse tensions. Just call me Romus the Defuser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[22]`
Mówca: **Laurento Esquibel**
> ""Very well. What did you want to know about him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[23]`
Mówca: **Laurento Esquibel**
> ""Right you are. Forgive the inappropriate greeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand that President Smolak may have lingering security concerns after the bombing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Isn't there anything we can do? President Smolak can't keep holding on to Zille forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
Mówca: **Narrator**
> "He smiled wryly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Laurento Esquibel**
> ""It's not entirely up to you. I hope the upcoming Alliance of Nations session on South Merkopa will provide us with some clarity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Narrator**
> "He smoothed one of the ends of his moustache."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Laurento Esquibel**
> ""I have filed a complaint with the Alliance of Nations. Presumably this will be addressed during the upcoming South Merkopa session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Laurento Esquibel**
> ""For now, though, we have Prime Minister Alvarez to worry about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why do you think he's calling?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did my father ever talk to him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How trustworthy is he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard he's an alcoholic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Alvarez Brief)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[56]`
  - -> `[59]`
  - -> `[62]`
  - -> `[69]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[42]`
Mówca: **Laurento Esquibel**
> ""Well... He can't be happy that Pales has reneged on its gas deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Laurento Esquibel**
> ""His country's energy demands have skyrocketed since joining ATO. I've heard rumors of massive new infrastructure investments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Laurento Esquibel**
> ""Naturally involving the Prime Minister's own construction company, Alvarez Industries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[45]`
Mówca: **Laurento Esquibel**
> ""Well... He can't be happy that AN arbitration is delaying Lespia's access to the Aureus gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[46]`
Mówca: **Laurento Esquibel**
> ""Well... He must be happy that Rizia is not challenging Lespia for access to the Aureus gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[47]`
Mówca: **Laurento Esquibel**
> ""No. His Majesty Valero died mere months after Alvarez won the 1949 election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Laurento Esquibel**
> ""He must have sent his obligatory congratulations. In private, though, he referred to the young man as 'the viper in a diaper'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[49]`
Mówca: **Laurento Esquibel**
> ""Considering the only reason he entered politics was to avoid going to jail?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
Mówca: **Laurento Esquibel**
> ""Rare is the world leader who doesn't enjoy a little drink on the job. Or a big one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Laurento Esquibel**
> ""But no, Alvarez has apparently acknowledged his problem and entered a rehabilitation program. He's as sober as an Archpriestess. For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[52]`
Mówca: **Laurento Esquibel**
> ""No charge has successfully been leveled against him. But in my opinion, he can only be trusted to protect his own best interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Alvarez_Want == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Alvarez_Want == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_Alvarez_Want == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Alvarez_Father == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Alvarez_Father == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_Alvarez_Father == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Alvarez_Alcoholic = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Alvarez_Trustworthy = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Alvarez_Father = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Alvarez_Want = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == true || RiziaDLCIsolated.Turn04_Alvarez_Father == true || RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == true || RiziaDLCIsolated.Turn04_Alvarez_Want == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == true || RiziaDLCIsolated.Turn04_Alvarez_Father == true || RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == true || RiziaDLCIsolated.Turn04_Alvarez_Want == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == true || RiziaDLCIsolated.Turn04_Alvarez_Father == true || RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == true || RiziaDLCIsolated.Turn04_Alvarez_Want == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[72]`
Mówca: **Laurento Esquibel**
> ""What questions did you have about Mr. Alvarez?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That'll be all. I'm ready for the phone call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Alvarez Brief])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[75]`
Mówca: **Laurento Esquibel**
> ""Very good, Your Majesty. I'll meet you afterwards for a debriefing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[76]`
Mówca: **Narrator**
> "An assistant brought in the blue telephone that was used for calls with heads of state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[77]`
Mówca: **Narrator**
> "At 3:01pm, it rang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Patricio Alvarez (R)**
> ""Good afternoon, King Romus. This is Patricio Alvarez.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`
  - -> `[83]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is His Majesty Romus Toras, Ruler of Rizia, Commander of the Royal Rizian Armed Forces, Duke of Valenqiris and Protector of the Rezenid Empire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is everything in Lespia, Mr. Prime Minister?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Patricio Alvarez (R)**
> ""Quite the mouthful. May your reign be as long as your titles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[82]`
Mówca: **Patricio Alvarez (R)**
> ""I'll be honest with you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you, Mr. Alvarez?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Patricio Alvarez (R)**
> ""Things are going surprisingly well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[88]`
Mówca: **Patricio Alvarez (R)**
> ""Things were going a lot better a week ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[92]`
Mówca: **Patricio Alvarez (R)**
> ""Our deal with Reinhart was a year in the making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[93]`
Mówca: **Patricio Alvarez (R)**
> ""I'll be honest with you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true ||  RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true ||  RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true  or   Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true ||  RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true  or   Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Patricio Alvarez (R)**
> ""I'm doing surprisingly well these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[98]`
Mówca: **Patricio Alvarez (R)**
> ""I was a lot better a week ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[99]`
Mówca: **Patricio Alvarez (R)**
> ""You must have some idea why I'm calling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[102]`
  - -> `[101]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Something to do with the gas field, I assume?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I honestly don't have a clue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suspect the reason involves Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[103]`
Mówca: **Narrator**
> "I heard him swallow on the other end of the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[104]`
Mówca: **Patricio Alvarez (R)**
> ""And one hour with you was enough to make the Duke of Pales have a sudden change of heart?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Patricio Alvarez (R)**
> ""What happened, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`
  - -> `[124]`
  - -> `[125]`

### Węzeł `[106]`
Mówca: **Narrator**
> "I heard him sigh on the other end of the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[107]`
Mówca: **Patricio Alvarez (R)**
> ""I was heartened to hear of the results of your meeting with Duke Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Patricio Alvarez (R)**
> ""I had an inkling that Rizia might try to obstruct our gas deal with Pales. I'm happy that was not the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`
  - -> `[111]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia has gone up against the combined might of Pales and Lespia before. We won't make that mistake again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, Duke Reinhart tried to double-cross you. But I refused his offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd be a fool to interfere with Lespia's plans, now that you've got ATO behind you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[112]`
Mówca: **Patricio Alvarez (R)**
> ""Really? That's very interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Patricio Alvarez (R)**
> ""Thank you for turning him down. And for delivering me this information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[114]`
Mówca: **Patricio Alvarez (R)**
> ""That's very wise of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Patricio Alvarez (R)**
> ""I've heard you're something of an untraditional monarch. Maybe there's a way for us to work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic > 0 && RiziaDLC.Focus_Government_Reform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic > 0 && RiziaDLC.Focus_Government_Reform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0  and  Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic > 0 && RiziaDLC.Focus_Government_Reform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0  and  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Patricio Alvarez (R)**
> ""I've been hesitant to reach out to your kingdom in the past. But maybe there's a way for us to work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Apparently he likes me more than you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia joined ATO. That was the last straw for both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We had the better offer. It's that simple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales recognized Rizia's rightful claim to the field. You should do so as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The truth is that Pales has always shared a closer affinity with Rizia than Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[128]`
Mówca: **Patricio Alvarez (R)**
> ""Hmm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[129]`
Mówca: **Patricio Alvarez (R)**
> ""Hmm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[130]`
Mówca: **Patricio Alvarez (R)**
> ""You're willing to let Wehlen tread all over you. But you saddle Rizia with more gas than you need because you're worried about ATO?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`
  - -> `[135]`

### Węzeł `[131]`
Mówca: **Patricio Alvarez (R)**
> ""I may be new at this Prime Minister thing. But I know when someone is making a business mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Zille is a local dispute. I see superpowers as far more of a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The deal with Pales has been made, Mr. Prime Minister. It can't be undone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[134]`
Mówca: **Patricio Alvarez (R)**
> ""Shelling out for more natural gas than you need while Wehlen is still treading all over you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[135]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia's energy needs are greater than you presume.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[136]`
Mówca: **Patricio Alvarez (R)**
> ""There are no 'local disputes' in Merkopa these days, Your Majesty. You realize President Smolak has the long arm of Malenyev guiding him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[137]`
Mówca: **Patricio Alvarez (R)**
> ""We both know that's nonsense. My energy executives are still floating around in the Aureus field as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Patricio Alvarez (R)**
> ""Are you building nuclear weapons? I don't think so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Patricio Alvarez (R)**
> ""I'll tell you what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Patricio Alvarez (R)**
> ""I've been following the situation in Zille. It seems to me like you could use help with this debacle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[198]`
  - -> `[199]`

### Węzeł `[141]`
Mówca: **Patricio Alvarez (R)**
> ""Hmm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Patricio Alvarez (R)**
> ""I may be new at this Prime Minister thing. But I know when someone is making a business mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Patricio Alvarez (R)**
> ""Saddling yourself with gas you don't need while Wehlen is still treading all over you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[135]`

### Węzeł `[144]`
Mówca: **Patricio Alvarez (R)**
> ""Here I am, about to land the gas deal of a lifetime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Patricio Alvarez (R)**
> ""And then my business partner calls me up and tells me we have to wait for AN arbitration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[535]`
  - -> `[148]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You really thought Rizia would cede the field without a fight?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're lucky it's only that. Duke Reinhart wanted me to buy the field out from under you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm only observing protocol, Mr. Alvarez. You would do the same if I laid claim to one of Lespia's resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[149]`
Mówca: **Patricio Alvarez (R)**
> ""Did he? Interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Patricio Alvarez (R)**
> ""I thought you were a shrewd king. One who knows which way the wind is blowing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[151]`
Mówca: **Patricio Alvarez (R)**
> ""Well, as of my last conversation with him, he is determined to fight for what rightly belongs to Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[152]`
Mówca: **Patricio Alvarez (R)**
> ""It isn't your resource, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Patricio Alvarez (R)**
> ""My legal counsel has a crystal-clear case for Palesian ownership of the gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Patricio Alvarez (R)**
> ""You can talk about ANDOR rules all you want, but in the end, it's going to come down to your word versus ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Patricio Alvarez (R)**
> ""And who do you think has more sway with the Alliance of Nations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`
  - -> `[158]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're bluffing. The AN will have no choice but to side with Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand I might lose. But I am not going to back down on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you want Rizia to give up its claim on the field, you're going to have to present one hell of a counter-offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[159]`
Mówca: **Patricio Alvarez (R)**
> ""Are you sure about that? One hundred percent, absolutely sure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Patricio Alvarez (R)**
> ""Because if you aren't, I have a proposition for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[164]`
  - -> `[167]`

### Węzeł `[161]`
Mówca: **Patricio Alvarez (R)**
> ""Not 'might', Your Majesty. You will lose. After wasting a lot of unnecessary time and money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Patricio Alvarez (R)**
> ""If you want to avoid all that, I have a proposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[164]`
  - -> `[167]`

### Węzeł `[163]`
Mówca: **Patricio Alvarez (R)**
> ""As it happens, I do have a proposition that might interest you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[167]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of proposition?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, but I'm not interested.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[166]`
Mówca: **Patricio Alvarez (R)**
> ""And frankly, with Lespia on his side, he has an unimpeachable case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`
  - -> `[158]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No promises. But I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Patricio Alvarez (R)**
> ""At least hear me out first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Patricio Alvarez (R)**
> ""I've been following the situation in Zille. It seems to me like you could use help with this debacle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`
  - -> `[172]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What debacle? Our countries have an agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but I have everything under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am growing concerned about the timely return of the region, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Patricio Alvarez (R)**
> ""As you should be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[174]`
Mówca: **Patricio Alvarez (R)**
> ""So President Smolak has promised to return Zille as scheduled, despite the recent incident?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not in so many words...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... yes. Yes, he has.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Patricio Alvarez (R)**
> ""He's a slippery man, Smolak. You won't get your territory back unless you tighten your grip on him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`
  - -> `[181]`
  - -> `[182]`

### Węzeł `[178]`
Mówca: **Patricio Alvarez (R)**
> ""And you believed him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I already have a plan. It doesn't involve Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you offering to intervene, Mr. Prime Minister?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how do you propose we do that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You catch flies with honey, not vinegar. I'm not going to risk inflaming hostilities with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Patricio Alvarez (R)**
> ""I'm not suggesting hostility. I'm suggesting Lespia provide assistance from the sidelines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Patricio Alvarez (R)**
> ""Of course Lespia can't do that. But we can provide some assistance from the sidelines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Patricio Alvarez (R)**
> ""By speaking up on your behalf at the upcoming AN session, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`
  - -> `[215]`

### Węzeł `[186]`
Mówca: **Patricio Alvarez (R)**
> ""Of course Lespia can't interfere directly. But we can provide some assistance from the sidelines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[187]`
Mówca: **Patricio Alvarez (R)**
> ""All I'm suggesting is that we pitch in from the sidelines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not a debacle. Wehlen and Rizia have an agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Patricio Alvarez (R)**
> ""And President Smolak has promised to honor the terms of that agreement, despite the bombing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not in so many words...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... yes. Yes, he has.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Patricio Alvarez (R)**
> ""He's a slippery man, Smolak. You won't get your territory back unless you tighten your grip on him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`
  - -> `[204]`
  - -> `[205]`

### Węzeł `[193]`
Mówca: **Patricio Alvarez (R)**
> ""And you believed him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Patricio Alvarez (R)**
> ""You're willing to let Wehlen tread all over you. But you shell out for more gas than your country needs because you're worried about ATO?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`
  - -> `[135]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but I have everything under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not that it's your business, but yes, I am growing concerned about the timely return of the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Patricio Alvarez (R)**
> ""As you should be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[201]`
Mówca: **Patricio Alvarez (R)**
> ""So President Smolak has promised to honor the terms of your agreement, despite the bombing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I already have a plan. It doesn't involve Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you offering to intervene, Mr. Prime Minister?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how do you propose we do that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You catch flies with honey, not vinegar. I'm not going to risk inflaming hostilities with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Patricio Alvarez (R)**
> ""I'm not suggesting hostility. I'm suggesting Lespia provide indirect assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Patricio Alvarez (R)**
> ""By speaking up on your behalf at the upcoming AN session, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[524]`
  - -> `[317]`

### Węzeł `[208]`
Mówca: **Patricio Alvarez (R)**
> ""We wouldn't interfere with whatever you have in motion. But we can provide indirect assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[209]`
Mówca: **Patricio Alvarez (R)**
> ""Of course Lespia can't do that. But we can provide indirect assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[210]`
Mówca: **Patricio Alvarez (R)**
> ""Of course Lespia can't interfere directly. But we can provide assistance from the sidelines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it? You expect Rizia to give up our gained rights to the gas field for that little?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Patricio Alvarez (R)**
> ""You wouldn't have to give them up entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it? You'd expect us to give up our claim on the gas field for that little?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unfortunately, Rizia needs natural gas more than we need help with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'd have to make a very persuasive case for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Patricio Alvarez (R)**
> ""I'm a charming man. Everyone says so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[217]`
Mówca: **Patricio Alvarez (R)**
> ""What about both, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Patricio Alvarez (R)**
> ""It's more than you'll get if you continue down the arbitration path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Patricio Alvarez (R)**
> ""Cede the Aureus field to Pales, and in addition to the assistance I just promised, we'll sell you one-quarter of the exploration rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[220]`
Mówca: **Patricio Alvarez (R)**
> ""Actually, I'll be extra generous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do I know I can trust you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's an insult, Mr. Alvarez. Those rights are ours to begin with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[223]`
Mówca: **Patricio Alvarez (R)**
> ""My lying days are behind me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You wouldn't be bargaining if you thought you had an airtight case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Patricio Alvarez (R)**
> ""I'm trying to make sure we both get something out of this, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Patricio Alvarez (R)**
> ""A certain... social club I'm in has taught me the importance of service to others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[232]`
  - -> `[235]`
  - -> `[236]`

### Węzeł `[227]`
Mówca: **Patricio Alvarez (R)**
> ""A certain... social club I'm in has taught me the importance of accountability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[232]`
  - -> `[235]`
  - -> `[236]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. I don't drink either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father was right about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Patricio Alvarez (R)**
> ""What'd His Majesty say? Only good things, I hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[234]`
Mówca: **Patricio Alvarez (R)**
> ""One thing we have in common, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may be sober, but I don't believe for a second that you've changed your ways.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not the bogeyman my councilors made you out to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[237]`
Mówca: **Patricio Alvarez (R)**
> ""You don't have to believe me. All you have to do is say yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[238]`
Mówca: **Patricio Alvarez (R)**
> ""But I'm not trying to be your friend. I'm just trying to help you avoid embarrassment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[239]`
Mówca: **Patricio Alvarez (R)**
> ""No. But you don't have to like me. All you have to do is say yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[240]`
Mówca: **Patricio Alvarez (R)**
> ""This isn't a plea for cooperation, Your Majesty. It's a chance for you to avoid embarrassment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for the offer, Mr. Alvarez. I'll remember your patronizing tone when I crush you and Pales in court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know full well what I'm up against. But win or lose, I want to see how arbitration plays out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if I were interested, I can't afford the gas offer. If arbitration is my only chance for a piece of Aureus, I have to take it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[247]`
**[WYBÓR GRACZA: ""I know when to back down. I'll accept the gas offer for a quarter of the field, but I don't want or need your help with Wehlen." [-4 Budget, +2 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""I know when to back down. I'll accept the gas offer, but I don't want or need your help with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
**[WYBÓR GRACZA: ""All right. Sell me 25% of the gas rights and help me out with Zille, and I'll withdraw Rizia's claim to the Aureus field." [-4 Budget, +2 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""All right. Sell me 25% of the gas rights and help me out with Zille, and I'll withdraw Rizia's claim to the Aureus field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Patricio Alvarez (R)**
> ""Your prerogative, Your Majesty. It's a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[250]`
Mówca: **Patricio Alvarez (R)**
> ""It's a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[251]`
Mówca: **Patricio Alvarez (R)**
> ""I'm looking forward to celebrating our agreement in person in Kyrute. Over, say, coffee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[259]`
  - -> `[258]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp = true;
RiziaDLC.Zille_ViolentResistancePower += 3;
RiziaDLC.Zille_ReferendumPower += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] = true;
Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 3;
Variable["RiziaDLC.Zille_ReferendumPower"] = Variable["RiziaDLC.Zille_ReferendumPower"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[255]`
Mówca: **Patricio Alvarez (R)**
> ""Fair enough, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Patricio Alvarez (R)**
> ""I'll see you in Kyrute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`
  - -> `[264]`

### Węzeł `[257]`
Mówca: **Patricio Alvarez (R)**
> ""No need for aggression, Your Majesty. This is a civil process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You got what you were asking for. No need to butter me up further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for calling, Mr. Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Something stronger for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = false; 
RiziaDLCSupport.Reports_Turn04_PorteDrazon_Arbitration_Canceled = true;
RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal = true;
RiziaDLC.Resources_Budget -= 4;
RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] = false;
Variable["RiziaDLCSupport.Reports_Turn04_PorteDrazon_Arbitration_Canceled"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 4;
Variable["RiziaDLC.Budget_Modifier_PalesPipelineConstruction"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pleasure speaking with you, Mr. Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I'll see you in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you forgotten I hold the cards here? My navy has the field surrounded right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[269]`
Mówca: **Patricio Alvarez (R)**
> ""I wonder what will happen if you're forced to use it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Patricio Alvarez (R)**
> ""The longer your ships stay there, the worse Rizia looks in the eyes of the international community. And as you know, there's a big AN meeting coming up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[273]`
  - -> `[274]`
  - -> `[506]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father was right about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Patricio Alvarez (R)**
> ""What'd His Majesty say? Only good things, I hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`
  - -> `[509]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may be sober, but I don't believe for a second that you've changed your ways.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would be very convenient to have this whole mess fixed by the time that meeting rolls around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Patricio Alvarez (R)**
> ""You don't have to believe me. All you have to do is say yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`
  - -> `[509]`

### Węzeł `[276]`
Mówca: **Patricio Alvarez (R)**
> ""You're right about that. The Wehlen situation's already messy enough without a naval standoff on your hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`
  - -> `[509]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Patricio Alvarez (R)**
> ""Oh. And of course, I expect the prompt removal of your naval reinforcements from the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[281]`
Mówca: **Narrator**
> "We said our goodbyes and hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[282]`
Mówca: **Narrator**
> "The line dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[283]`
Mówca: **Narrator**
> "I sat there for a while, wondering what I had gotten myself into."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Narrator**
> "I'd avoided a legal battle, but to what end?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[288]`
Mówca: **Narrator**
> "Were Duke Reinhart and Prime Minister Alvarez right? Was I doomed to lose this battle?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[289]`
Mówca: **Patricio Alvarez (R)**
> ""Four countries share the mining rights to the MITZ. It's no mystery that two of them want it nationalized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Patricio Alvarez (R)**
> ""If you and I don't hold the line against the Malenyevists, they'll take everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`
  - -> `[293]`

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Comrade' Saltana can nationalize our gold over my dead body.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a complex topic. The mines are on Morellan land, but we've invested millions in them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've exploited Morella's resources enough. Saltana can do what she wants with the MITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[294]`
Mówca: **Patricio Alvarez (R)**
> ""There you have it. We're in agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Patricio Alvarez (R)**
> ""I hope you'll repeat that sentiment the next time the MITZ board convenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`
  - -> `[473]`
  - -> `[477]`

### Węzeł `[296]`
Mówca: **Patricio Alvarez (R)**
> ""It's not complex to me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Patricio Alvarez (R)**
> ""I hope you'll see it my way by the next  MITZ board meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`
  - -> `[473]`
  - -> `[478]`
  - -> `[477]`

### Węzeł `[298]`
Mówca: **Patricio Alvarez (R)**
> ""So you're fine with losing all the money you've invested there? And all the revenue the mines have been generating for you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[299]`
Mówca: **Patricio Alvarez (R)**
> ""If you don't, you should know I'll do whatever I must to protect Lespia's interests. Whether that benefits Rizia or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[300]`
Mówca: **Patricio Alvarez (R)**
> ""Then I'll do what I must to protect Lespia's own interests. Which may or may not benefit your kingdom in the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[301]`
Mówca: **Patricio Alvarez (R)**
> ""And hell, I'll even put in a good word for you at the Alliance of Nations. Try and help you out of this sticky situation you're in with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Patricio Alvarez (R)**
> ""Assuming you want that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[304]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do. Please help by any means necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the offer, but we've got the Zille situation under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp = true; 
RiziaDLC.Zille_ViolentResistancePower += 3;
RiziaDLC.Zille_ReferendumPower += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] = true;
Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 3;
Variable["RiziaDLC.Zille_ReferendumPower"] = Variable["RiziaDLC.Zille_ReferendumPower"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you'll honor the bargain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[307]`
Mówca: **Patricio Alvarez (R)**
> ""We'll celebrate next month in Kyrute. Over coffee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`
  - -> `[310]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Something stronger for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't wait, Mr. Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good day, Mr. Alvarez.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Narrator**
> "The line dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[312]`
Mówca: **Narrator**
> "I sat in my office for a while after that, wondering what kind of bargain I had made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Narrator**
> "I sat in my office for a while after that, wondering if turning down Lespia's offer was the right decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Having Lespia on our side would hurt our chances with Wehlen, not help them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[318]`
Mówca: **Patricio Alvarez (R)**
> ""I disagree, Your Majesty. We could be instrumental in bringing the plight of your kingdom to the greater international community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Patricio Alvarez (R)**
> ""Cancel on Pales, allow Lespia to go through with our planned purchase, and we'll sell you 25 percent of the gas rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`
  - -> `[327]`

### Węzeł `[320]`
Mówca: **Patricio Alvarez (R)**
> ""But I'll throw in a bonus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there an 'or else' you're implying?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What makes you think Duke Reinhart would still sell to you after offering the field to me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Patricio Alvarez (R)**
> ""He doesn't have an alternative, does he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Patricio Alvarez (R)**
> ""Not from Lespia's side, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Patricio Alvarez (R)**
> ""Reinhart's practically a teenager. Turning to you was his version of a tantrum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[326]`
Mówca: **Patricio Alvarez (R)**
> ""I will warn you that Reinhart's practically a teenager. Turning to you was his version of a tantrum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why should I accept a quarter of the field instead of the rights to the whole thing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Patricio Alvarez (R)**
> ""Duke Reinhart is practically a teenager. Turning to you was his version of a tantrum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[329]`
Mówca: **Patricio Alvarez (R)**
> ""To save yourself trouble further down the line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[330]`
Mówca: **Patricio Alvarez (R)**
> ""Eventually, Reinhart will come back to us. I'm just trying to make sure Rizia is not left with nothing when he does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`
  - -> `[333]`
  - -> `[332]`
  - -> `[331]`

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How very charitable of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may have a point. I was already beginning to have second thoughts about the Pales deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This isn't generosity. This is an attempt to turn Rizia and Pales against each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[334]`
Mówca: **Patricio Alvarez (R)**
> ""A certain... social club I'm in has taught me the importance of service to others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[335]`
Mówca: **Patricio Alvarez (R)**
> ""We're both intelligent men, Your Majesty. We don't have time for the whims of a brat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Patricio Alvarez (R)**
> ""A reunion was never in the cards, Your Majesty. Do you think the Duke has so easily forgotten the way your people tried to conquer his?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Patricio Alvarez (R)**
> ""But it's up to you. Keep your deal if you believe that's what's best for your country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`
  - -> `[340]`
  - -> `[341]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That is in fact what I believe. Please don't reach out to me again, Mr. Alvarez.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do appreciate the offer. But my answer is no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[340]`
**[WYBÓR GRACZA: ""You make a convincing case. I'll call off the deal and accept a smaller share of the gas field rights. But I don't need or want your help with Wehlen." [Revert Pales Field Deal and Lose Paid Budget, +2 Energy Per Turn In Future]"]** — Mówca: **Player_Romus**
> ""You make a convincing case. I'll call off the deal and accept a smaller share of the gas field rights. But I don't need or want your help with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[341]`
**[WYBÓR GRACZA: ""You're right. It's better for us if we cancel the deal. But I'm still counting on a share of the gas rights and your full support with Wehlen." [Revert Pales Field Deal and Lose Paid Budget, +2 Energy Per Turn In Future, Diplomatic Support]"]** — Mówca: **Player_Romus**
> ""You're right. It's better for us if we cancel the deal. But I'm still counting on a share of the gas rights and your full support with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[342]`
Mówca: **Patricio Alvarez (R)**
> ""That's perfectly fine, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[343]`
Mówca: **Patricio Alvarez (R)**
> ""I truly appreciate this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[344]`
Mówca: **Patricio Alvarez (R)**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[345]`
Mówca: **Patricio Alvarez (R)**
> ""Fair enough, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[346]`
Mówca: **Patricio Alvarez (R)**
> ""I'll see you in Kyrute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`
  - -> `[350]`

### Węzeł `[347]`
Mówca: **Patricio Alvarez (R)**
> ""Fine with me. Good luck sorting everything out on your own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for your call, Mr. Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I'll see you in hell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for your call, Mr. Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to it as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure you are, now that you've gotten what you wanted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Narrator**
> "The line dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[355]`
Mówca: **Narrator**
> "I sat in my office as daylight faded, wondering if I had made the right decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[356]`
Mówca: **Patricio Alvarez (R)**
> ""And I'm looking forward to seeing you in Kyrute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`
  - -> `[353]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true; RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy = false;
RiziaDLC.Policy_Diplomacy_TradeDeal_Pales = false;
RiziaDLCSupport.Journal_Turn04_Pales_EndGasDeal = true;
RiziaDLCSupport.Reports_Turn04_PorteDrazon_SellField_Reneged = true;
RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] = false;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Pales"] = false;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_EndGasDeal"] = true;
Variable["RiziaDLCSupport.Reports_Turn04_PorteDrazon_SellField_Reneged"] = true;
Variable["RiziaDLC.Budget_Modifier_PalesPipelineConstruction"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp = true;
RiziaDLC.Zille_ViolentResistancePower += 3;
RiziaDLC.Zille_ReferendumPower += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] = true;
Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 3;
Variable["RiziaDLC.Zille_ReferendumPower"] = Variable["RiziaDLC.Zille_ReferendumPower"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_PromiseITZSupport = true; RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true; RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal = true;
RiziaDLC.Policy_Economy_PalesPipeline_Project = true;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower += 1;
RiziaDLC.Resources_Budget -= 3;
RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal"] = true;
Variable["RiziaDLC.Policy_Economy_PalesPipeline_Project"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] + 1;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 3;
Variable["RiziaDLC.Budget_Modifier_PalesPipelineConstruction"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `RemoveConversant("Laurento Esquibel");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Patricio Alvarez (R)");)*
- **Efekt (`userScript`):** `RemoveConversant("Patricio Alvarez (R)");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Patricio Alvarez (R)");)*
- **Efekt (`userScript`):** `RemoveConversant("Patricio Alvarez (R)");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Patricio Alvarez (R)");

// Removes the conversant with the character name in database)*
- **Efekt (`userScript`):** `RemoveConversant("Patricio Alvarez (R)");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[365]`
Mówca: **Patricio Alvarez (R)**
> ""I would expect more civility from a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Patricio Alvarez (R)**
> ""But not from a *Rizian* king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn04_G_AN_UpcomingMeeting = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_G_AN_UpcomingMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Negotiations","R_Negotiations_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn04_Pales_PalesianNavySent = true; RiziaDLCSupport.News_Turn04_G_RiziaPales_NavalBlockade = true; RiziaDLCSupport.News_Turn04_RH_RiziaPales_NavalBlockade = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_Pales_PalesianNavySent"] = true;
Variable["RiziaDLCSupport.News_Turn04_G_RiziaPales_NavalBlockade"] = true;
Variable["RiziaDLCSupport.News_Turn04_RH_RiziaPales_NavalBlockade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn04_G_RiziaPales_Deal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_G_RiziaPales_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn04_RH_RiziaPales_Deal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_RH_RiziaPales_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn04_G_RiziaPales_Arbitration = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_G_RiziaPales_Arbitration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn04_RH_RiziaPales_Arbitration = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_RH_RiziaPales_Arbitration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[384]`
Mówca: **Laurento Esquibel**
> ""Our Rumburgian allies have expressed their support for our naval blockade, as expected. And they are sure to be of use during the AN arbitration process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[385]`
Mówca: **Laurento Esquibel**
> ""However, the nation of Morella has yet to support or denounce us. The same goes for Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[386]`
Mówca: **Laurento Esquibel**
> ""Meanwhile, my requests for Wehlen to give us an updated timeline on the Zille handover have been repeatedly ignored...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[24]`
  - -> `[401]`
  - -> `[25]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[390]`
Mówca: **Laurento Esquibel**
> ""Our Rumburgian allies have expressed their intent to support us during the arbitration process, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[391]`
Mówca: **Laurento Esquibel**
> ""However, the nation of Morella has yet to express an opinion either way. The same goes for Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[392]`
Mówca: **Laurento Esquibel**
> ""We can expect improved relations with Lespia and Pales now that we've ceded ownership of the gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Cede == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Cede == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Cede == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[396]`
Mówca: **Laurento Esquibel**
> ""However, our neighbors don't seem happy that we've allowed Lespia to take control of such a large stretch of the Antacean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[397]`
Mówca: **Laurento Esquibel**
> ""Wehlen still refuses to give us an updated timeline for the Zille handover. Losing the gas field may have something to do with it...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[401]`
  - -> `[25]`

### Węzeł `[398]`
Mówca: **Laurento Esquibel**
> ""We can expect improved relations with Pales now that we're on the verge of a gas deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[399]`
Mówca: **Laurento Esquibel**
> ""However, we mustn't forget about Wehlen. My requests for an updated timeline on the Zille handover have been repeatedly ignored...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[401]`
  - -> `[25]`

### Węzeł `[400]`
Mówca: **Laurento Esquibel**
> ""Furthermore, Morella and Derdia have expressed interest in purchasing energy from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To hell with Wehlen. If they won't give us Zille back, we'll just have to take it from them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[402]`
Mówca: **Laurento Esquibel**
> ""I would urge patience, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[403]`
Mówca: **Laurento Esquibel**
> ""I have filed a complaint with the Alliance of Nations. Presumably this will be addressed during the upcoming South Merkopa session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[404]`
Mówca: **Laurento Esquibel**
> ""I would like to give him the benefit of the doubt. But the lack of a response is very worrying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[405]`
Mówca: **Patricio Alvarez (R)**
> ""Is that what it's like being a monarch? Make a decision, forget about the consequences?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[406]`
Mówca: **Patricio Alvarez (R)**
> ""Your suspicions are correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[407]`
Mówca: **Patricio Alvarez (R)**
> ""Your assumption is correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[408]`
Mówca: **Patricio Alvarez (R)**
> ""You and I both know how large the Aureus gas field is. Lespia definitely doesn't need all of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[409]`
Mówca: **Patricio Alvarez (R)**
> ""What if we made a deal? We'll sell you 25 percent of the rights we're buying from Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not buying it, Mr. Prime Minister. What's the catch?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What makes you think I want anything to do with the Aureus field?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I wanted gas from that field, I'd purchase it from Pales directly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would be interested. Tell me more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[416]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Patricio Alvarez (R)**
> ""Now, that's not true. I happen to know that Duke Reinhart detests you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[418]`
Mówca: **Patricio Alvarez (R)**
> ""That's not the way it works. Lespia controls the rights to the entire field now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[419]`
Mówca: **Patricio Alvarez (R)**
> ""Fortunately, I have no such qualms about Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[450]`
  - -> `[452]`

### Węzeł `[420]`
Mówca: **Patricio Alvarez (R)**
> ""Anyone who wants a piece of it has to go through us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[446]`
  - -> `[452]`

### Węzeł `[421]`
Mówca: **Patricio Alvarez (R)**
> ""No catch, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[422]`
Mówca: **Patricio Alvarez (R)**
> ""A certain... social club I'm in has taught me the importance of service to others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[423]`
  - -> `[428]`
  - -> `[431]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`
  - -> `[425]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[426]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They tried to get me to join that club in my wilder days. I refused.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. I don't drink, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`
  - -> `[430]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's nice. But I still don't believe you would offer such a large stake out of the goodness of your heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am glad that your faith gives you guidance, as it does me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[433]`
Mówca: **Patricio Alvarez (R)**
> ""Amazing, isn't it? Like wiping the fog off a window and finally being able to see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[434]`
Mówca: **Patricio Alvarez (R)**
> ""It's amazing, Your Majesty. Like wiping the fog off a window and finally being able to see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[435]`
Mówca: **Patricio Alvarez (R)**
> ""Believe it or not, this is my offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[436]`
Mówca: **Patricio Alvarez (R)**
> ""No use in being coy, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[437]`
Mówca: **Patricio Alvarez (R)**
> ""Every country in Merkopa is begging for a whiff of that gas. Even 25 percent of the field would grant you considerable power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[447]`
  - -> `[446]`

### Węzeł `[438]`
Mówca: **Patricio Alvarez (R)**
> ""There's not much to tell, really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[439]`
Mówca: **Patricio Alvarez (R)**
> ""A certain... social club I'm in has taught me the importance of service to others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[423]`
  - -> `[428]`
  - -> `[431]`

### Węzeł `[440]`
Mówca: **Patricio Alvarez (R)**
> ""I'm not talking about religion. But never mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[442]`
Mówca: **Patricio Alvarez (R)**
> ""In my case, I saw that it's time for Rizia and Lespia to grow closer together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[443]`
Mówca: **Patricio Alvarez (R)**
> ""I feel it's finally time for Rizia and Lespia to grow closer together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still don't understand your sudden show of generosity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[445]`
Mówca: **Patricio Alvarez (R)**
> ""It's simple, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps we ceded it a little too hastily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[447]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Except that we'd still be beholden to Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[448]`
Mówca: **Patricio Alvarez (R)**
> ""Let us worry about Pales, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[449]`
Mówca: **Patricio Alvarez (R)**
> ""On the contrary, Your Majesty. This is the best possible outcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, Rizia has qualms about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[451]`
Mówca: **Patricio Alvarez (R)**
> ""But why, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So Lespia wants a closer partnership with Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[453]`
Mówca: **Patricio Alvarez (R)**
> ""Is that so strange?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[454]`
Mówca: **Patricio Alvarez (R)**
> ""Look at what we're up against. The forces of Malenyevism closing in on all sides.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[456]`
  - -> `[457]`
  - -> `[458]`

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Morella's turn towards the east worries me as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. We have our differences, but neither of us wants Merkopa to turn into a socialist empire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Malenyevism and Arcasian liberalism are just two sides of the same coin to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's capitalist vultures like you that keep me up at night, not the specter of Malenyevism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[459]`
Mówca: **Patricio Alvarez (R)**
> ""We're not strictly Arcasian liberals over here in Lespia, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[460]`
Mówca: **Patricio Alvarez (R)**
> ""Hrm... Well, but you must still agree that the new prime minister of Morella is bad news for both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[462]`
Mówca: **Patricio Alvarez (R)**
> ""And at any rate, I'm sure you'll agree that the new prime minister of Morella is bad news for both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[463]`
Mówca: **Patricio Alvarez (R)**
> ""Damn straight, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[464]`
Mówca: **Patricio Alvarez (R)**
> ""And I'm sure you'll agree that the new prime minister of Morella is bad news for both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[465]`
Mówca: **Patricio Alvarez (R)**
> ""Exactly, Your Majesty. Their new Prime Minister Saltana is bad news for both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[466]`
Mówca: **Patricio Alvarez (R)**
> ""Getting up on her high horse, spouting made-up claims about pollution and human rights just because she has Valgsland in her corner...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[469]`
  - -> `[468]`

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Meftiem International Trade Zone nationalization debate. I agree, it's pure rubbish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know if we see eye to eye on this, Mr. Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does this have to do with the gas field, Mr. Alvarez?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[470]`
Mówca: **Patricio Alvarez (R)**
> ""Exactly!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[471]`
Mówca: **Patricio Alvarez (R)**
> ""We're on the same side with Aureus. We've got to be a team here, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[472]`
Mówca: **Patricio Alvarez (R)**
> ""Well, we should.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Aha. There's the ulterior motive I was looking for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[474]`
**[WYBÓR GRACZA: ""You bet I will, Mr. Alvarez. And I'll take you up on that gas offer." [-3 Budget, +2 Energy Per Turn In Future]"]** — Mówca: **Player_Romus**
> ""You bet I will, Mr. Alvarez. And I'll take you up on that gas offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[475]`
Mówca: **Patricio Alvarez (R)**
> ""I knew you were a smart man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[476]`
Mówca: **Patricio Alvarez (R)**
> ""Not an ulterior motive. Just laying the facts on the table.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if I don't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe I will, maybe I won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[479]`
Mówca: **Patricio Alvarez (R)**
> ""You do? That's not what I heard, but suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[480]`
Mówca: **Patricio Alvarez (R)**
> ""With pleasure, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[481]`
Mówca: **Patricio Alvarez (R)**
> ""Looking forward to getting rich off Palesian gas together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. This could be the beginning of a new era.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[483]`
Mówca: **Patricio Alvarez (R)**
> ""If there's one thing we Lespians love, it's a long-term commitment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[484]`
Mówca: **Patricio Alvarez (R)**
> ""I hope so, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Rich' is perhaps an overstatement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[486]`
Mówca: **Patricio Alvarez (R)**
> ""Natural gas is the future, isn't it? Any little bit is better than none.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[487]`
**[WYBÓR GRACZA: ""We do. But I won't make any promises regarding the MITZ." [-3 Budget, +2 Energy Per Turn In Future]"]** — Mówca: **Player_Romus**
> ""We do. But I won't make any promises regarding the MITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[488]`
Mówca: **Patricio Alvarez (R)**
> ""Fair enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[489]`
Mówca: **Patricio Alvarez (R)**
> ""Hell, I'll even put in a good word for you at the Alliance of Nations. Try and help you out of this sticky situation you're in with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[490]`
Mówca: **Patricio Alvarez (R)**
> ""Assuming you want that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[492]`

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do. Please help by any means necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the offer, but we've got the Zille situation under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[493]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp = true; RiziaDLC.Zille_ViolentResistancePower += 3;
RiziaDLC.Zille_ReferendumPower += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] = true;
Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 3;
Variable["RiziaDLC.Zille_ReferendumPower"] = Variable["RiziaDLC.Zille_ReferendumPower"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[494]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal = true; RiziaDLC.Diplomacy_Lespia_PromiseITZSupport = true; 
RiziaDLC.Diplomacy_Pales_GasField_Cede = false;
RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true;
RiziaDLC.Policy_Economy_PalesPipeline_Project = true; RiziaDLCSupport.Journal_Turn04_Lespia_PromiseITZSupport = true;
RiziaDLC.Resources_Budget -= 3; 
RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] = true;
Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] = false;
Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;
Variable["RiziaDLC.Policy_Economy_PalesPipeline_Project"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Lespia_PromiseITZSupport"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 3;
Variable["RiziaDLC.Budget_Modifier_PalesPipelineConstruction"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[495]`
Mówca: **Patricio Alvarez (R)**
> ""You're a smart man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[496]`
Mówca: **Patricio Alvarez (R)**
> ""He's like an eel, that President Smolak. You won't get what you want unless you tighten your grip on him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[497]`
Mówca: **Patricio Alvarez (R)**
> ""That's not what I heard. But suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[498]`
Mówca: **Patricio Alvarez (R)**
> ""He's like an eel, that President Smolak. You won't get what you want unless you tighten your grip on him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[499]`
Mówca: **Patricio Alvarez (R)**
> ""At any rate, I'm glad we could do business. We'll celebrate next month in Kyrute. Over coffee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`
  - -> `[501]`
  - -> `[502]`

### Węzeł `[500]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Something stronger for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[501]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't wait, Mr. Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[502]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good day, Mr. Alvarez.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true;
RiziaDLC.Resources_Budget -= 3;
RiziaDLC.Policy_Economy_PalesPipeline_Project = true; 
RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal = true;
RiziaDLC.Diplomacy_Pales_GasField_Cede = false;
RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 3;
Variable["RiziaDLC.Policy_Economy_PalesPipeline_Project"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal"] = true;
Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] = false;
Variable["RiziaDLC.Budget_Modifier_PalesPipelineConstruction"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[504]`
Mówca: **Patricio Alvarez (R)**
> ""We'll seal the deal soon after the Alliance of Nations meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[505]`
Mówca: **Patricio Alvarez (R)**
> ""I look forward to celebrating in person. Over coffee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`
  - -> `[501]`
  - -> `[502]`

### Węzeł `[506]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the offer of assistance with Wehlen? That still stands?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[507]`
Mówca: **Patricio Alvarez (R)**
> ""Of course it does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`
  - -> `[509]`

### Węzeł `[508]`
**[WYBÓR GRACZA: ""Fine. I'll withdraw both the Rizian navy and our claim to the field in exchange for 25 percent of the gas rights." [-4 Budget,  +2 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""Fine. I'll withdraw both the Rizian navy and our claim to the field in exchange for 25 percent of the gas rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[509]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will not back down that easily, Mr. Alvarez. We will proceed with arbitration, and my navy will stay in place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[510]`
Mówca: **Patricio Alvarez (R)**
> ""Very excellent, Your Majesty. You've saved us both a lot of trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[511]`
Mówca: **Patricio Alvarez (R)**
> ""That's too bad, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[512]`
Mówca: **Patricio Alvarez (R)**
> ""We have a long fight ahead of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`
  - -> `[514]`
  - -> `[515]`

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One that I am confident Rizia will win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'We'? This is Pales' fight, not yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[515]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope for a civil and peaceful legal process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[516]`
Mówca: **Patricio Alvarez (R)**
> ""You know what would help with that? Withdrawing your military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[517]`
Mówca: **Patricio Alvarez (R)**
> ""But I respect your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[518]`
Mówca: **Patricio Alvarez (R)**
> ""You're right, Your Majesty. Lespia will not get directly involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[519]`
Mówca: **Patricio Alvarez (R)**
> ""For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[520]`
Mówca: **Patricio Alvarez (R)**
> ""Ah, to have the confidence of a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[521]`
Mówca: **Patricio Alvarez (R)**
> ""I heard your father was also confident that Rizia would reconquer Pales. I wonder what happened there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_NegotiatingPower += 1;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower += 2;
RiziaDLC.Policy_Economy_PalesPipeline_Project = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] + 1;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] + 2;
Variable["RiziaDLC.Policy_Economy_PalesPipeline_Project"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[523]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 2;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] + 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[524]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are not closed to the idea, but I want to know more about what you have in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[525]`
Mówca: **Patricio Alvarez (R)**
> ""Let me help you with a brilliant and mutually beneficial idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`
  - -> `[528]`

### Węzeł `[527]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_BuyCancelled = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_BuyCancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_Cancelled = true;
RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_Cancelled"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatusImmediately("Rizia_Country_Pales", "Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);)*
- **Efekt (`userScript`):** `AddTokenStatusImmediately("Rizia_Country_Pales","Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[482]`
  - -> `[485]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatusImmediately("Rizia_Country_Pales", "Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);)*
- **Efekt (`userScript`):** `AddTokenStatusImmediately("Rizia_Country_Pales","Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatusImmediately("Rizia_Country_Pales", "Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);)*
- **Efekt (`userScript`):** `AddTokenStatusImmediately("Rizia_Country_Pales","Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatusImmediately("Rizia_Country_Pales", "Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);)*
- **Efekt (`userScript`):** `AddTokenStatusImmediately("Rizia_Country_Pales","Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`
  - -> `[537]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`
  - -> `[540]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`
  - -> `[592]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[541]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want to have anything to do with Lespia. Even if it means giving up access to the Aureus field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[542]`
Mówca: **Patricio Alvarez (R)**
> ""Suit yourself. I was only trying to be nice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Cede = true;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Morella_NegotiatingPower += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[544]`
Mówca: **Patricio Alvarez (R)**
> ""I'll see you in Kyrute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`
  - -> `[502]`
  - -> `[545]`

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for calling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("PhoneRingPickUp");)*
- **Efekt (`userScript`):** `PlaySoundEffect("PhoneRingPickUp");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`
  - -> `[549]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can't make these sorts of financial commitments right now. Nothing changes in our action plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[551]`
Mówca: **Laurento Esquibel**
> ""And there's the matter of our shared interests in the Meftiem International Trade Zone. He must also be aware of Morella's nationalization intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[552]`
Mówca: **Patricio Alvarez (R)**
> ""And let me guess. He talked you into paying for the infrastructure. All that money gone, for results you won't see for years if at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[553]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So in your version of the deal, we'd get less gas from the field, but the pipeline would be free?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[554]`
Mówca: **Patricio Alvarez (R)**
> ""You got it. And if Aureus turns out to be a dud after all, you won't have lost a cent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[555]`
Mówca: **Patricio Alvarez (R)**
> ""And LesPower will take over whatever infrastructure costs are necessary to bring that gas from Aureus to Rizia's doorstep.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[224]`
  - -> `[222]`
  - -> `[266]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_PalesPipelineConstruction"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`
  - -> `[559]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent"] == true  or  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent"] == true  or  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[560]`
Mówca: **Patricio Alvarez (R)**
> ""Even if you had a claim, defending and enforcing it would cost you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[561]`
Mówca: **Patricio Alvarez (R)**
> ""And I don't just mean money. A resource-hungry monarchy clashing with its closest neighbors... do you really want that image for Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[235]`
  - -> `[564]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal = true; 
RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = false; 
RiziaDLCSupport.Reports_Turn04_NavyWithdrawn = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal"] = true;
Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = false;
Variable["RiziaDLCSupport.Reports_Turn04_NavyWithdrawn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal = true; 
RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = false; 
RiziaDLCSupport.Reports_Turn04_NavyWithdrawn = true;
RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal"] = true;
Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = false;
Variable["RiziaDLCSupport.Reports_Turn04_NavyWithdrawn"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[564]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Reinhart was the one who started this mess. And we're supposed to simply roll over to him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[565]`
Mówca: **Patricio Alvarez (R)**
> ""You'd get championed as a peacemaker, and you'd still get gas out of the deal. I'd go for it, if I were in your shoes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[566]`
Mówca: **Patricio Alvarez (R)**
> ""We're on the same side here. Don't forget about our partnership in the MITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[567]`
Mówca: **Patricio Alvarez (R)**
> ""You're worried about someone trying to steal your resources away, you should look no further than your neighbor Ms. Saltana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[568]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Meftiem International Trade Zone nationalization debate. I agree, it's pure rubbish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know if we see eye to eye on this, Mr. Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[570]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's an entirely different topic. We were talking about the gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[571]`
Mówca: **Patricio Alvarez (R)**
> ""Exactly! If Rizia and Lespia don't hold the line against the commies, they'll take everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[572]`
Mówca: **Patricio Alvarez (R)**
> ""Resources are resources. And perhaps Rizia's time and energy are better spent protecting what you already have instead of going after something you don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[573]`
Mówca: **Patricio Alvarez (R)**
> ""Well, we should. If Rizia and Lespia don't hold the line against the commies, they'll take everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[574]`
Mówca: **Patricio Alvarez (R)**
> ""Getting up on her high horse, spouting made-up concerns about pollution and human rights just because she has Valgsland in her corner...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`
  - -> `[570]`
  - -> `[569]`

### Węzeł `[575]`
Mówca: **Patricio Alvarez (R)**
> ""So how do you feel about a partnership?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[245]`
  - -> `[242]`

### Węzeł `[576]`
Mówca: **Patricio Alvarez (R)**
> ""LesPower will take care of any infrastructure needed to deliver the gas to Rizia. You'd barely even have to lift a finger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`
  - -> `[410]`
  - -> `[411]`
  - -> `[412]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`
  - -> `[579]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[579]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[580]`
**[WYBÓR GRACZA: ""You know what? If it helps grease the wheels on our gas deal, I will." [-3 Budget, +2 Energy Per Turn In Future]"]** — Mówca: **Player_Romus**
> ""You know what? If it helps grease the wheels on our gas deal, I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`
  - -> `[583]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[584]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have to say upfront that I don't have the budget for this gas deal you're offering. But when it comes to the MITZ, we are on the same side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[585]`
Mówca: **Patricio Alvarez (R)**
> ""That's great to hear, Your Majesty. No worries about the gas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true; RiziaDLC.Diplomacy_Lespia_PromiseITZSupport = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[587]`
Mówca: **Patricio Alvarez (R)**
> ""But enough about Morella. Do we have a deal on Aureus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`
  - -> `[595]`
  - -> `[541]`

### Węzeł `[588]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`
  - -> `[590]`

### Węzeł `[589]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[590]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The gas field offer isn't within my budget. But I'll support you in the MITZ when the time comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[592]`
**[WYBÓR GRACZA: ""Absolutely. And I'll back you against Morella if it means that much to you." [-3 Budget, +2 Energy Per Turn In Future]"]** — Mówca: **Player_Romus**
> ""Absolutely. And I'll back you against Morella if it means that much to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[593]`
Mówca: **Patricio Alvarez (R)**
> ""To *us*, Your Majesty. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[594]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_PromiseITZSupport = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[595]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not going to accept the gas offer. But when it comes to the MITZ, Rizia has your back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[596]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Taking a lucrative call from Lespia’s Prime Minister", "Personal Office", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Taking a lucrative call from Lespia’s Prime Minister","Personal Office","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
