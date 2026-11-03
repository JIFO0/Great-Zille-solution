# Rizia/Turn 4/FPnT_PalesDukeVisit

- **ID konwersacji:** `311`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Rizia/Turn_04/311_FPnT_PalesDukeVisit.md`
- **Liczba węzłów dialogowych:** 957
- **Liczba wyborów gracza:** 289

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.CountryRelation_Pales_Friendly`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Wehlen_Scapegoats`
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Prologue_FalloutWithDad`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_MetAxel`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Average`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Strong`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak`
- `RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_PalesTrade`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Lespia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Morella_NegotiatingPower`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_Cede`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Diplomacy_Wehlen_NegotiatingPower`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PersonalValue_Pacifist`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Pales`
- `RiziaDLC.Policy_Economy_PalesPipeline_Project`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Situation_Order_KingsGuardForce_Limited`
- `RiziaDLC.Situation_Order_KingsGuardForce_Powerful`
- `RiziaDLC.Turn03_Security_TitusLeadsInvestigation`
- `RiziaDLC.War_Pales_PublicWarSupport`
- `RiziaDLCSupport.Journal_Turn04_Pales_BuyGasRights`
- `RiziaDLCSupport.Journal_Turn04_Pales_CedeGasField`
- `RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration`
- `RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade`
- `RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal`
- `RiziaDLCSupport.Reports_Turn04_ArbitrationBegins`
- `RiziaDLCSupport.Reports_Turn04_Iza_ScapegoatsFound`
- `RiziaDLCSupport.Reports_Turn04_NavyWithdrawn`
- `RiziaDLCSupport.Reports_Turn04_Pales_SellField`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
- **Węzły modyfikujące stan gry:** 50

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Budget_Modifier_PalesTrade`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_Cede`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Pales`
- `RiziaDLC.Policy_Economy_PalesPipeline_Project`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.War_Pales_PublicWarSupport`
- `RiziaDLCSupport.Journal_Turn04_Pales_BuyGasRights`
- *...oraz 5 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[220]` (Paskal Beniwoll): `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] = false; Variable["RiziaDLC.Situation_Orde...`
- Węzeł `[221]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 1;`
- Węzeł `[223]` (Paskal Beniwoll): `RemoveConversant("Titus Gordion");`
- Węzeł `[224]` (Paskal Beniwoll): `RemoveConversant("Axel Reinhart");`
- Węzeł `[225]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Reports_Turn04_Iza_ScapegoatsFound"] = true;`
- Węzeł `[229]` (Paskal Beniwoll): `End();`
- Węzeł `[230]` (Paskal Beniwoll): `PlayLoopedMusic("R_Alliances","R_Alliances_Loop");`
- Węzeł `[234]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Reports_Turn04_Pales_SellField"] = true;`
- *...oraz 42 innych węzłów ze skryptami.*

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
  - -> `[956]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "He sighed and slid a report across the table towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Axel Reinhart**
> ""My security minister woke me up at midnight with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Axel Reinhart**
> ""I was assured that Pales had every right to begin drilling in the Aureus gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your country sending the drillship was an act of provocation. I had no choice but to respond in kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think it means, Your Grace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why did you send that ship to begin with? Why not notify my government?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[9]`
Mówca: **Axel Reinhart**
> ""I was perfectly happy living a life of leisure, coasting off the family fortune, enjoying the odd celebrity rendezvous...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[20]`
  - -> `[22]`
  - -> `[21]`

### Węzeł `[10]`
Mówca: **Narrator**
> "He looked me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[14]`
Mówca: **Axel Reinhart**
> ""You could have waited for me to state my case. Instead, you proved, once more, that you have no respect for Palesian sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`
  - -> `[646]`
  - -> `[647]`
  - -> `[648]`

### Węzeł `[15]`
Mówca: **Axel Reinhart**
> ""It means that despite my prior entreaties to you, the Rizian government continues to disrespect Palesian sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`
  - -> `[646]`
  - -> `[647]`
  - -> `[648]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is the 'Party Prince' you're talking to. I know the feeling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You didn't have to take his place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. Which celebrities?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Life is full of surprises, Your Grace. Should we get down to negotiations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[23]`
Mówca: **Axel Reinhart**
> ""Oh, but I did. Somebody had to step up to protect the Grand Duchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Axel Reinhart**
> ""A brilliant idea, putting jerks like us in charge of entire countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[28]`
Mówca: **Axel Reinhart**
> ""Yes, I know all about your escapades. In another life, we could've been friends. But in this one...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Axel Reinhart**
> ""And who would have stepped up in my stead? Who's left to protect Pales?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[33]`
Mówca: **Axel Reinhart**
> ""Yes, I suppose we had better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[34]`
Mówca: **Axel Reinhart**
> ""What is there to negotiate?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[35]`
Mówca: **Axel Reinhart**
> ""You'll have to wait until my memoirs are published. If I live long enough to write them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[36]`
Mówca: **Axel Reinhart**
> ""If I listed them all, we'd never have time for this talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[37]`
Mówca: **Axel Reinhart**
> ""I'll be honest with you, Your Majesty. I never expected my brother to abdicate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[44]`
Mówca: **Axel Reinhart**
> ""I know that our expedition may have seemed like an act of aggression. But all we are doing is claiming what is rightfully ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`
  - -> `[272]`
  - -> `[156]`

### Węzeł `[45]`
Mówca: **Titus Gordion**
> ""How did it go, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[62]`
  - -> `[65]`

### Węzeł `[46]`
Mówca: **Narrator**
> "The Duke reached beneath the table and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Axel Reinhart**
> ""Hilda? Be a doll and help show His Majesty the way out of the building. Wouldn't want him getting lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Narrator**
> "He sat back in his chair and scrutinized me closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Axel Reinhart**
> ""My brother always told me never to reason with a Rizian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Axel Reinhart**
> ""But what can I say? I'm an optimist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`
  - -> `[53]`
  - -> `[54]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For the amount I'm paying, something good had better come out of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So am I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're lucky that this Rizian sees reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not your brother. And I'm not my father. We can break this cycle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[55]`
Mówca: **Narrator**
> "I rejoined Titus in the reception room. We followed Hilda through winding corridors to the front door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Narrator**
> "We stepped outside into the waning sunlight. He waited until we were out of the building's shadow to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Surprisingly well. I'm excited to see what comes next.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One step closer to Palesian-Rizian reunification, Titus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Duke is a snake. But I can still get the upper hand on him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not great. Not great at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We may yet have a chance to avenge your father's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's between me and His Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Narrator**
> "Titus nodded wordlessly. We got into the car and began the long trip back to Porte Drazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_MetAxel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_MetAxel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_MetAxel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_MetAxel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_MetAxel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Narrator**
> "I hadn't been to Pales in many years."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Narrator**
> "It was my first visit to Pales since becoming King of Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "Titus and I stood side by side, peering out the window of Castle Reinhart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Narrator**
> "The Grand Duchy's royal residence was built on the foundations of an ancient paleacco, one of the stone fortifications that gave Pales its name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Narrator**
> "After his coronation, Duke Axel Reinhart had hired an up-and-coming local architect to expand the old building into a swooping, bulging wood and glass structure that seemed almost alive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Narrator**
> "The reception room had been moved to the top floor, and boasted enormous curved windows with a view of the Pales skyline. Its soaring, angular skyscrapers were unlike anything built in Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Titus Gordion**
> ""So this is the 'Pearl of the Antacean.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[79]`
  - -> `[78]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You sound unimpressed, Captain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Amazing what Lespian money can buy, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hard to believe all of this sprung up in the last few decades alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Titus Gordion**
> ""I'm a simple man, sir. Give me the classicism of Palas Rezna over... whatever this is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
Mówca: **Titus Gordion**
> ""Truly a feat, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Titus Gordion**
> ""'Amazing' is one word for it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Narrator**
> "Titus glanced around us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[90]`
Mówca: **Narrator**
> "Titus glanced around us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[91]`
Mówca: **Titus Gordion**
> ""Your cousin's associates have been less than cooperative. Even if they're innocent in the Wehlen bombing, I suspect they still have something to hide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[96]`
  - -> `[98]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about that *other* investigation I ordered?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Investigate harder, damn it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[97]`
Mówca: **Titus Gordion**
> ""By the way, Your Majesty, the men your cousin turned over have been extradited to Wehlen. There's still no word on what will happen to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[907]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep up the good work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[99]`
Mówca: **Titus Gordion**
> ""Still in the works, sir. It's too sensitive to assign to anyone else, so I'll have to pick it back up once we have significant time in the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[100]`
Mówca: **Titus Gordion**
> ""I'll pass on the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[101]`
Mówca: **Titus Gordion**
> ""I'll pass that on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where are you from, Titus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Titus Gordion**
> ""Born and raised in Porte Drazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Titus Gordion**
> ""My father was killed during the operation to take back Pales. I took up championship boxing to support my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`
  - -> `[107]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He gave his life for a good cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So much senseless bloodshed. May it never happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I bet you were good at it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Titus Gordion**
> ""Good enough to get noticed by military recruiters. I do miss those days in the ring sometimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[109]`
Mówca: **Titus Gordion**
> ""For what it's worth, sir, he believed in the cause. He never turned against King Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[110]`
Mówca: **Titus Gordion**
> ""He believed in it with all his heart. He never turned against King Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you've never been to Pales before?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Titus Gordion**
> ""No, sir. My father fought in the operation to take it back. Actually, he was killed here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`
  - -> `[113]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry if this visit is bringing up bad memories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Titus Gordion**
> ""Not a problem, sir. He died fighting for what he believed in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Narrator**
> "A panel in the wall slid open, and a secretary clad in a pastel minidress emerged. She motioned for me to enter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`
  - -> `[118]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Into the breach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sit tight. This ought to be quick.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Make yourself comfortable. This might be a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Titus Gordion**
> ""Will do, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[120]`
Mówca: **Titus Gordion**
> ""Good luck, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[121]`
Mówca: **Narrator**
> "The secretary announced my entrance. I stepped into the room and was greeted by Duke Reinhart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Axel Reinhart**
> ""Your Majesty. A pleasure to finally meet you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[136]`
  - -> `[128]`
  - -> `[132]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_MetAxel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_MetAxel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_MetAxel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_MetAxel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_MetAxel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[126]`
Mówca: **Axel Reinhart**
> ""Your Majesty. We meet again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[133]`
  - -> `[136]`
  - -> `[128]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's always a pleasure to visit this beautiful castle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I only wish it was under better circumstances, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[129]`
Mówca: **Narrator**
> "The Palesian ruler hadn't aged a day since we last met."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Narrator**
> "The Palesian ruler was tall and square-jawed, with looks out of an adventure serial. I recalled that the tabloids had nicknamed him "Duke Dashing"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[131]`
Mówca: **Narrator**
> "He was tall, square-jawed, with looks out of an adventure serial. I recalled that the tabloids had nicknamed him "Duke Dashing"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Likewise. You have a beautiful castle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "Bow."]** — Mówca: **Player_Romus_Italic**
> "I returned Duke Reinhart's bow. He spread his arms out wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[134]`
Mówca: **Axel Reinhart**
> ""Really? You think it's beautiful?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`
  - -> `[141]`

### Węzeł `[135]`
Mówca: **Axel Reinhart**
> ""As do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No ministers? No aides?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Axel Reinhart**
> ""I thought it best to try and settle this business between ourselves. Like in the old days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[138]`
Mówca: **Axel Reinhart**
> ""How do you like my castle?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`
  - -> `[141]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's very... modern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's breathtaking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have to be diplomatic, don't I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Narrator**
> "A corner of his mouth turned up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Narrator**
> "He raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Axel Reinhart**
> ""I wasn't sure about it myself. But when you're the leader of such an advanced economy, there's always pressure to keep up with the times. You know how it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Narrator**
> "The secretary left, closing the door behind her. The Duke and I took seats on opposite sides of a wooden conference table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Narrator**
> "His posture was casual, even as he regarded me with intensity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[147]`
Mówca: **Axel Reinhart**
> ""And now our ship finds itself in a standoff with the Rizian navy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Axel Reinhart**
> ""Tell me, Your Majesty. What is the meaning of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`
  - -> `[8]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[152]`
Mówca: **Axel Reinhart**
> ""It means that, as usual, the Rizian government continues to disrespect Palesian sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`
  - -> `[646]`
  - -> `[647]`
  - -> `[648]`

### Węzeł `[153]`
Mówca: **Axel Reinhart**
> ""You could have waited for me to state my case. Instead, you showed that, despite my prior entreaties, Rizia refuses to respect Palesian sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`
  - -> `[646]`
  - -> `[647]`
  - -> `[648]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I recognize your claim on the field. But you must recognize Rizia's right to it as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You broke the law by sending that ship. Count yourself lucky that Rizia has not retaliated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia does not dispute your claim to the field. In fact, we're prepared to let you keep it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Axel Reinhart**
> ""You are?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Narrator**
> "He raised an eyebrow in suspicion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[162]`
Mówca: **Axel Reinhart**
> ""Is this the same Romus Toras I spoke to three years ago?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[165]`
  - -> `[167]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know our first meeting went badly. This is my attempt to make amends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[164]`
Mówca: **Axel Reinhart**
> ""Let me guess. You want something in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[169]`
  - -> `[168]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My goal has always been to get Pales to rejoin Rizia. If giving up a gas field will help me achieve that goal, I'll do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Axel Reinhart**
> ""You think we're willing to trade our sovereignty for access to natural gas?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't say I would cede the field out of pure generosity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My goal has always been to get Pales to rejoin Rizia. If giving up a gas field will help me achieve that goal, I'll do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I truly don't believe it's worth the hassle to fight for the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course I do, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[171]`
Mówca: **Axel Reinhart**
> ""You can't truly think that the field's proximity to Caleqabiz gives you a right to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[292]`
  - -> `[291]`

### Węzeł `[172]`
Mówca: **Axel Reinhart**
> ""Your Majesty, I urge you to let this go. There are more powerful interests at play than either of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[285]`
  - -> `[280]`

### Węzeł `[173]`
Mówca: **Axel Reinhart**
> ""My legal experts have assured me that the proximity of Caleqabiz does not give Rizia a claim to our gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[281]`
  - -> `[301]`

### Węzeł `[174]`
Mówca: **Axel Reinhart**
> ""And how can I trust you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[175]`
Mówca: **Axel Reinhart**
> ""You must understand that Pales doesn't owe Rizia anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Axel Reinhart**
> ""By claiming the Aureus field, we are merely asserting the sovereignty that your country has disrespected for so long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`
  - -> `[344]`

### Węzeł `[177]`
Mówca: **Axel Reinhart**
> ""Your Majesty, you must understand that Pales doesn't owe Rizia anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They supported your independence... by making you dependent on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your family must have realized their motives for doing so were less than pure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should never have been put in that position, Your Grace. My predecessors' aggression was out of line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[181]`
Mówca: **Axel Reinhart**
> ""That's brave talk, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[182]`
**[WYBÓR GRACZA: ""I see no other choice but arbitration. The Alliance of Nations will decide ownership." [Arbitration]"]** — Mówca: **Player_Romus**
> ""I see no other choice but arbitration. The Alliance of Nations will decide ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[183]`
**[WYBÓR GRACZA: ""I suggest you keep the field, and keep the deal with Lespia. Rizia is staying out of this." [Cede Field]"]** — Mówca: **Player_Romus**
> ""I suggest you keep the field, and keep the deal with Lespia. Rizia is staying out of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Axel Reinhart**
> ""Thank you for acknowledging that. But it doesn't change anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[365]`
  - -> `[366]`

### Węzeł `[185]`
Mówca: **Narrator**
> "Duke Reinhart frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[186]`
Mówca: **Narrator**
> "Duke Reinhart frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[187]`
Mówca: **Narrator**
> "Duke Reinhart's secretary opened the door. He stood up and gestured for me to do the same."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Axel Reinhart**
> ""Until next time, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Axel Reinhart**
> ""You haven't exactly listened to my government's wishes in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Axel Reinhart**
> ""You may not have shown hostility towards Pales, Your Majesty, but many in your government have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Axel Reinhart**
> ""Sending that ship was our way of asserting Palesian sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`
  - -> `[646]`
  - -> `[647]`
  - -> `[648]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope Rico was right about them not cracking under pressure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Poor bastards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I couldn't care less. I'm sure they're guilty of *something*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Titus Gordion**
> ""They're a stubborn lot. My own men couldn't get a word out of them, and believe me, they tried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[199]`
Mówca: **Titus Gordion**
> ""My men did some digging into their backgrounds. Light misdemeanors, mostly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[200]`
Mówca: **Titus Gordion**
> ""I wouldn't feel too sorry for them. Even if they weren't involved in Zille, their record was less than shining.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Titus Gordion**
> ""We've been making little headway with the Su Omina investigation, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[202]`
Mówca: **Titus Gordion**
> ""Speaking of which, now that our investigation has ended, do you plan to return the Golden Guard to its previous size and function?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[205]`
  - -> `[208]`

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. The expanded unit might still prove useful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I want all your extra manpower concentrated on that *other* investigation I ordered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good point. Yes, that's money I could be putting to better use.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[209]`
Mówca: **Titus Gordion**
> ""Right, sir. We'll double down on that one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[210]`
Mówca: **Titus Gordion**
> ""Are you sure, Your Majesty? That would also mean putting an end to the *other* investigation you ordered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Titus Gordion**
> ""Glad to hear it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's too much going on to make this decision. Let's talk later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Titus Gordion**
> ""Are you sure, Your Majesty? You never know when you'll need an elite investigation unit at your disposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`
  - -> `[212]`

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I'm quite sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm. All right, let's keep the extra Golden Guards on the royal payroll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Narrator**
> "Titus nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded = false; 
RiziaDLC.Situation_Order_KingsGuardForce_Limited = true;
RiziaDLC.Situation_Order_KingsGuardForce_Powerful = false;
RiziaDLC.PoisonInvestigator_Titus = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] = false;
Variable["RiziaDLC.Situation_Order_KingsGuardForce_Limited"] = true;
Variable["RiziaDLC.Situation_Order_KingsGuardForce_Powerful"] = false;
Variable["RiziaDLC.PoisonInvestigator_Titus"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Titus Gordion**
> ""Very well, Your Majesty. I'll drop the news to the other units when we're back in the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `RemoveConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn04_Iza_ScapegoatsFound = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_Iza_ScapegoatsFound"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Alliances", "R_Alliances_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Alliances","R_Alliances_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn04_Pales_SellField = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_Pales_SellField"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn04_ArbitrationBegins = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_ArbitrationBegins"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[111]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`
  - -> `[244]`

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can only imagine how difficult it must be for you to be here, considering this is where your father lost his life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no doubt in my mind that Pales still falls under the Rizian banner. Their hostile attitude toward reunification is nothing short of a crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do hope our two countries can resolve our historical rivalries. A harmonious partnership could bring significant benefits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Titus Gordion**
> ""The pain never really goes away. I've simply learned to live with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[258]`
  - -> `[252]`

### Węzeł `[246]`
Mówca: **Titus Gordion**
> ""Sure. Though I must admit, I do hope to one day see the Rizian flag flying over Pales once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[247]`
Mówca: **Titus Gordion**
> ""An injustice I hope to see rectified in my lifetime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`
  - -> `[268]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know the feeling. Not a day goes by where I don't think about my late wife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One mustn't let personal feelings get in the way of doing one's duty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I got over my wife's death fairly quickly. Granted, she and I were never very close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As do I. I'm determined to make it happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and me both. Though, this matter must be approached with caution. Setting things in motion takes time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[256]`
Mówca: **Titus Gordion**
> ""Of course. I never meant to imply that it would.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[257]`
Mówca: **Titus Gordion**
> ""I've never been married myself, but I can only imagine the heartache one must feel from losing someone so close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_FalloutWithDad == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think about my father on a daily basis too, despite my best efforts to forget about him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not a day goes by where I don't think about my own father. I try to remind myself that grief makes one stronger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Titus Gordion**
> ""Father-son relationships can be complicated. Everyone's is different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[264]`
Mówca: **Titus Gordion**
> ""An optimistic way to look at life. I admire it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[265]`
Mówca: **Titus Gordion**
> ""Agreed. Haste can lead to mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[266]`
Mówca: **Titus Gordion**
> ""Much like a snowflake, grief manifests in countless shapes and forms, never identical.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[267]`
Mówca: **Titus Gordion**
> ""I have no doubt, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe there are far more pressing issues to deal with than Pales' reunification. It's dangerous when countries try to relive their imperial glory-days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Titus Gordion**
> ""While I personally believe the issue is of great importance, I understand your reasoning to give this matter a lower priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[270]`
Mówca: **Narrator**
> "He maintained eye contact as he bowed to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[271]`
Mówca: **Narrator**
> "He maintained eye contact as he bowed to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all a misunderstanding, Duke Reinhart. Send your ship back and we can settle this peacefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Axel Reinhart**
> ""Now you're interested in peace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Axel Reinhart**
> ""I would like to, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Axel Reinhart**
> ""Unfortunately, there are greater interests at play than either of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[318]`
  - -> `[317]`
  - -> `[316]`

### Węzeł `[279]`
Mówca: **Axel Reinhart**
> ""I offered you a chance for peace the last time we met. You turned it down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[303]`
  - -> `[304]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're admitting it. You're a puppet of Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My own experts would say that you've acted in clear violation of the Alliance of Nations Directive on Offshore Resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[282]`
Mówca: **Narrator**
> "Duke Reinhart bristled at that remark."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Axel Reinhart**
> ""Your Majesty, the Reinhart family has ruled over the Palesian peninsula for just as long as the Torases have ruled over Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Axel Reinhart**
> ""If you are going to question our legitimacy, you may as well question your own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`
  - -> `[290]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's precisely why I will not let this go. Western superpowers have no place meddling in South Merkopan affairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I too have the backing of powerful interests. You do not want to incur the wrath of Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[287]`
Mówca: **Axel Reinhart**
> ""You are ignoring ANDOR's nuances. It leaves much more room for ambiguity than other laws of its kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You ruled on behalf of the Valgos Empire, who stole Pales from Rizia. I would hardly call that 'legitimate'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I respect the length of your family's rule. However, Pales has only been a sovereign nation for a fraction of that time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are correct. Both of our families have clung to power for too long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our island counts just as much as your barely legitimate country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't make the rules. Our claim is clearly valid according to the Alliance of Nations Directive on Offshore Resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Caleqabiz may be small, but it is still a part of the great nation of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Axel Reinhart**
> ""You chose a convenient time to get patriotic about an island full of exiles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was under pressure from my father. I did not truly mean what I said.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_MetAxel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_MetAxel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_MetAxel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_MetAxel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_MetAxel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Axel Reinhart**
> ""I offered you a chance for peace three years ago. Instead, you betrayed me to your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`
  - -> `[304]`

### Węzeł `[300]`
Mówca: **Axel Reinhart**
> ""I'm afraid it may be too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've established that we have differing interpretations of the law. What will it take to come to a compromise?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was under pressure from him then. Now that I am king, I am no longer beholden to his wishes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did not and still do not want to cooperate with Pales after the violence of the 1920s. That doesn't mean I want a repeat of that conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do still have doubts about Pales' legitimacy. But this resource dispute overrides them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[305]`
Mówca: **Axel Reinhart**
> ""But until and unless Rizia respects Palesian sovereignty, we will be forced to assert ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`
  - -> `[315]`

### Węzeł `[306]`
Mówca: **Narrator**
> "His expression turned more serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[307]`
Mówca: **Narrator**
> "Duke Reinhart drew himself upright."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[308]`
Mówca: **Axel Reinhart**
> ""Yes, Pales was part of the Valgos Empire. But we developed our own laws and customs. Even our own language.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Axel Reinhart**
> ""When the Empire fell apart, what were we supposed to do? Simply give up everything we had built?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[328]`
  - -> `[327]`
  - -> `[326]`

### Węzeł `[310]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your family only came to power because the Valgos Empire put you there. And now the Empire is gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your 'sovereignty' only exists because of Lespian support. Without it, Pales would crumble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Axel Reinhart**
> ""And what of Rizia and Rumburg? What of the deal your father made with Wehlen to keep House Toras in power?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[314]`
Mówca: **Narrator**
> "Duke Reinhart drew himself upright."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, Your Grace. Let's not let the hostility between our families color our present relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're admitting it. You're a puppet of Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's precisely why I will not let this go. Western superpowers have no place meddling in South Merkopan affairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I too have the backing of powerful interests. You do not want to incur the wrath of Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[319]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[320]`
Mówca: **Axel Reinhart**
> ""Neither of us do, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[321]`
Mówca: **Axel Reinhart**
> ""I wish that I could believe you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[322]`
Mówca: **Axel Reinhart**
> ""Yet I don't see you hanging up your crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[323]`
Mówca: **Axel Reinhart**
> ""You know, Your Majesty, we Reinharts have ruled Pales for as long as your family has ruled Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[324]`
Mówca: **Axel Reinhart**
> ""That does not mean our sovereignty is undeserving of respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[325]`
Mówca: **Axel Reinhart**
> ""You are talking about ancient history, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales could have kept its cultural identity intact if it had rejoined Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regimes end. It was your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. No, I suppose not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would have done that before turning to Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[330]`
Mówca: **Axel Reinhart**
> ""Your father would never have accepted that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Axel Reinhart**
> ""That wasn't your kingdom's decision to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Axel Reinhart**
> ""And your own nationalist tendencies make me think you wouldn't, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[336]`
Mówca: **Axel Reinhart**
> ""Even if he had, my family never would have agreed. They had too much pride.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[337]`
Mówca: **Axel Reinhart**
> ""I heard what it was like back then. Rizia and Morella picking at us like vultures. Goddamn Valgsland trying to provoke a revolution from the sidelines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Axel Reinhart**
> ""You don't know what you would have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[339]`
Mówca: **Axel Reinhart**
> ""Lespia was the only nation willing to support our independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`
  - -> `[180]`

### Węzeł `[340]`
Mówca: **Axel Reinhart**
> ""Of course. But what choice did they have?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[366]`

### Węzeł `[341]`
Mówca: **Axel Reinhart**
> ""You know how wealthy we are. It wasn't entirely a one-way street.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[365]`
  - -> `[366]`

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What sovereignty? Your family only came to power because the Valgos Empire put you there. And now the Empire is gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your 'sovereignty' only exists because of Lespian support. Without it, Pales would crumble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, Your Grace. Let's not let the hostility between our families color our present relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[345]`
Mówca: **Narrator**
> "He cast a suspicious glance at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[346]`
Mówca: **Axel Reinhart**
> ""If I must do so to assert Pales' sovereignty, then I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`
  - -> `[344]`

### Węzeł `[347]`
Mówca: **Axel Reinhart**
> ""I wouldn't call it 'meddling', necessarily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[348]`
Mówca: **Axel Reinhart**
> ""I wouldn't call it 'meddling', exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then tell me, how can Rizia satisfy those interests?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Axel Reinhart**
> ""I'm afraid it may be too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[351]`
Mówca: **Axel Reinhart**
> ""Lespia, on the other hand, was more than willing to support our independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`
  - -> `[180]`

### Węzeł `[352]`
Mówca: **Axel Reinhart**
> ""But no Rizian ruler has ever truly respected Palesian sovereignty. I don't see why you would be different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`
  - -> `[315]`

### Węzeł `[353]`
Mówca: **Narrator**
> "He leaned forward and lowered his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[357]`
Mówca: **Narrator**
> "His gaze hardened as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Axel Reinhart**
> ""No, they won't. They need our gas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[359]`
Mówca: **Axel Reinhart**
> ""I know that. I'm not a fool.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
Mówca: **Axel Reinhart**
> ""But in the meantime, Lespia needs our gas. And they are promising us a sum that we can hardly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[361]`
Mówca: **Axel Reinhart**
> ""So they accepted help from Lespia. The only country willing to support our independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`
  - -> `[180]`

### Węzeł `[362]`
Mówca: **Axel Reinhart**
> ""Unless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`
  - -> `[395]`

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now that Lespia is an ATO member, they won't want to be connected to a monarchy for long. They'll have you overthrown the first chance they get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[364]`
Mówca: **Axel Reinhart**
> ""So you see, Your Majesty, we can't let Rizia take it from us. Not without a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`
  - -> `[384]`
  - -> `[385]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand why Pales accepted Lespia's aid. But now that Morella is in league with Valgsland, you could get caught between superpowers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's end the history lecture. What are we doing about this gas field?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[370]`
Mówca: **Narrator**
> "His gaze hardened as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Axel Reinhart**
> ""That's precisely why we need a bargaining chip. And we have one, right at the bottom of the Antacean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[375]`
Mówca: **Narrator**
> "His gaze hardened as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[376]`
Mówca: **Axel Reinhart**
> ""I am bringing this up so you understand the stakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Axel Reinhart**
> ""We have an obligation to Lespia. When they ask us for natural gas, we can hardly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[378]`
Mówca: **Axel Reinhart**
> ""And we certainly cannot let Rizia take it from us. Not without a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`
  - -> `[384]`
  - -> `[385]`

### Węzeł `[379]`
Mówca: **Narrator**
> "He leaned forward and lowered his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[380]`
Mówca: **Axel Reinhart**
> ""I brought all this up so you would understand the stakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[381]`
Mówca: **Axel Reinhart**
> ""We have an obligation to Lespia. When they ask us for natural gas, we can hardly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My war and security councilor wanted me to deploy our navy around the field. I should have listened to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is not looking for a fight. Surely there's still a peaceful solution to be found.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that a threat, Your Grace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[388]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, Your Grace. This isn't who you are. Let's just settle this quickly so you can get back to dating celebrities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[389]`
Mówca: **Narrator**
> "He exhaled heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[390]`
Mówca: **Axel Reinhart**
> ""You're right. I can't believe it's come to this. But I don't see another way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[391]`
Mówca: **Axel Reinhart**
> ""There is, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[392]`
Mówca: **Axel Reinhart**
> ""Do it if you like. We defeated your country once before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unless what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see where this is going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm listening...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[396]`
Mówca: **Narrator**
> "He spoke his next words very deliberately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[397]`
Mówca: **Axel Reinhart**
> ""I could envision a future where Pales severs its ties with Lespia in favor of a partnership with Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Axel Reinhart**
> ""But as my late cousin Ivar learned the hard way on holiday in the Montese Isles, one doesn't jump out of a plane without a parachute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[399]`
Mówca: **Narrator**
> "Duke Reinhart grabbed the nearest piece of paper and scribbled a number on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[400]`
Mówca: **Axel Reinhart**
> ""This would buy you the full exploration rights to the Aureus field, as we were preparing to grant Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[401]`
Mówca: **Axel Reinhart**
> ""Cede the field to us and pay what we're asking, and Rizia will have all the energy it could ever ask for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[402]`
Mówca: **Narrator**
> "I took a look at the numbers he'd written down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[899]`

### Węzeł `[403]`
Mówca: **Narrator**
> "It was an extremely large sum, but our treasury could afford it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[934]`
  - -> `[408]`
  - -> `[436]`
  - -> `[437]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 8)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`
  - -> `[406]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 8)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 8))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[917]`

### Węzeł `[407]`
Mówca: **Narrator**
> "It was more than our treasury could afford."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[434]`
  - -> `[439]`

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's far too much. Can't you go any lower?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[409]`
Mówca: **Axel Reinhart**
> ""Do you understand what I'm saying, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[412]`
  - -> `[413]`
  - -> `[414]`

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry about your cousin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[411]`
Mówca: **Axel Reinhart**
> ""Cocaine and skydiving don't mix.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't. Please explain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think so, but I don't like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do. How big of a parachute are we talking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[415]`
Mówca: **Axel Reinhart**
> ""Lespia's energy company LesPower has put in a bid for the exploration rights to the Aureus field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[416]`
Mówca: **Axel Reinhart**
> ""Sorry, but this is the best compromise I can offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[417]`
Mówca: **Narrator**
> "He briefly closed his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[418]`
Mówca: **Axel Reinhart**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[419]`
Mówca: **Axel Reinhart**
> ""Cede the field to us and agree to match their offer, and I will sell the rights to Rizia instead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`
  - -> `[421]`
  - -> `[425]`

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do I know you won't just turn around and sell the field to Lespia once we cede it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[421]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's ridiculous. We shouldn't have to pay for what's rightfully ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Axel Reinhart**
> ""We're both men of honor, Your Majesty. You'll have to trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[423]`
Mówca: **Axel Reinhart**
> ""I am generously offering you what's rightfully *ours*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[424]`
Mówca: **Axel Reinhart**
> ""I hope you see how beneficial this could be to both of our countries. We end our dependence on Lespia, Rizia gets all the energy it could wish for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[431]`
  - -> `[433]`

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That depends. How much is Lespia offering?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[426]`
Mówca: **Axel Reinhart**
> ""Now we're talking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[427]`
Mówca: **Axel Reinhart**
> ""I didn't think you'd come to the table so quickly. But great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[428]`
Mówca: **Axel Reinhart**
> ""It was always my family's policy not to discuss money out loud, so...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[429]`
Mówca: **Axel Reinhart**
> ""It was always my family's policy not to discuss money out loud, so...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[430]`
Mówca: **Narrator**
> "Duke Reinhart grabbed the nearest piece of paper and scribbled a numbers on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[899]`

### Węzeł `[431]`
**[WYBÓR GRACZA: ""You can have the field if you need it so badly. But I will not pay for the gas." [Cede Field]"]** — Mówca: **Player_Romus**
> ""You can have the field if you need it so badly. But I will not pay for the gas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[432]`
**[WYBÓR GRACZA: ""Sorry, but I must refuse. We have a legitimate claim to that gas field, and I am willing to defend it in court if necessary." [AN Arbitration]"]** — Mówca: **Player_Romus**
> ""Sorry, but I must refuse. We have a legitimate claim to that gas field, and I am willing to defend it in court if necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. Just out of curiosity, tell me how much we would have to pay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, but there's no way Rizia can pay this much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[435]`
**[WYBÓR GRACZA: ""Seems reasonable to me. You have a deal, Duke Reinhart." [-6 Budget Now, -2 Budget Per Turn Now, -4 Budget Per Turn in Future, +8 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""Seems reasonable to me. You have a deal, Duke Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[945]`

### Węzeł `[436]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't I just buy the rights to part of the field?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On second thought, this is insulting. My kingdom will not pay for our own gas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[438]`
Mówca: **Axel Reinhart**
> ""Then court it is, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't I just buy the rights to part of the field?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[440]`
Mówca: **Narrator**
> "Duke Reinhart crumpled up the piece of paper and casually tossed it away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[441]`
Mówca: **Axel Reinhart**
> ""That was my best suggestion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[442]`
Mówca: **Axel Reinhart**
> ""What would you prefer as a solution, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[443]`
Mówca: **Narrator**
> "Duke Reinhart frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[444]`
Mówca: **Axel Reinhart**
> ""Well... if you're sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[445]`
Mówca: **Axel Reinhart**
> ""If there's truly no other choice, then I will gladly agree to enter arbitration. But it's not quite the outcome I was hoping for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[889]`
  - -> `[477]`
  - -> `[479]`

### Węzeł `[446]`
Mówca: **Axel Reinhart**
> ""Thank you, I guess. But it's not quite the outcome I was hoping for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`
  - -> `[483]`
  - -> `[485]`
  - -> `[516]`

### Węzeł `[447]`
Mówca: **Axel Reinhart**
> ""I approached you because I believed Rizia was flourishing economically. Was I wrong?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`
  - -> `[451]`
  - -> `[951]`

### Węzeł `[448]`
Mówca: **Narrator**
> "He rubbed his chin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry to disappoint you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia's economy is as robust as it's ever been. But we will not pay so much to a country that has done us so much harm in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our resources have shrunk in the past years. That's why we need that gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[452]`
Mówca: **Axel Reinhart**
> ""This is an all-or-nothing deal, I'm afraid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[453]`
Mówca: **Axel Reinhart**
> ""Frankly, I thought Rizia could easily afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`
  - -> `[451]`
  - -> `[951]`

### Węzeł `[454]`
Mówca: **Axel Reinhart**
> ""Harm? If I recall correctly, *you* invaded *us."""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[455]`
Mówca: **Axel Reinhart**
> ""Unfortunately, if you can't purchase the rights to the entire field for the price I am asking, we will be forced to honor our original deal with Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`
  - -> `[461]`
  - -> `[462]`

### Węzeł `[456]`
Mówca: **Axel Reinhart**
> ""Then... what do you suggest, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`
  - -> `[459]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[935]`

### Węzeł `[460]`
**[WYBÓR GRACZA: ""Very well, Your Grace. You have a deal." [-10 Budget Now, -2 Budget Per Turn Now, -5 Budget Per Turn in Future, +8 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""Very well, Your Grace. You have a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[947]`

### Węzeł `[461]`
**[WYBÓR GRACZA: ""Stick with Lespia, then. You can keep the field, but we're not paying for it." [Cede Field]"]** — Mówca: **Player_Romus**
> ""Stick with Lespia, then. You can keep the field, but we're not paying for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[462]`
**[WYBÓR GRACZA: ""Then we will have to enter the arbitration process. I'll see you in court, Duke Reinhart." [Arbitration]"]** — Mówca: **Player_Romus**
> ""Then we will have to enter the arbitration process. I'll see you in court, Duke Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy = true;
RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = false;
RiziaDLC.Policy_Diplomacy_TradeDeal_Pales = true;
RiziaDLCSupport.Journal_Turn04_Pales_BuyGasRights = true;
RiziaDLC.Policy_Economy_PalesPipeline_Project = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] = true;
Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] = false;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Pales"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_BuyGasRights"] = true;
Variable["RiziaDLC.Policy_Economy_PalesPipeline_Project"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[900]`

### Węzeł `[464]`
Mówca: **Axel Reinhart**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[465]`
Mówca: **Narrator**
> "A boyish smile spread across his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[466]`
Mówca: **Axel Reinhart**
> ""Perfect, Your Majesty. Now, if only finding a wife was this easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[468]`
  - -> `[469]`
  - -> `[489]`

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I have a daughter...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A young playboy like you needn't settle down yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to a fruitful energy partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[470]`
Mówca: **Axel Reinhart**
> ""My people demand a queen. You know how it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[471]`
Mówca: **Axel Reinhart**
> ""And she's a beauty. But let's see how this gas deal goes before we get any closer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[472]`
Mówca: **Axel Reinhart**
> ""As do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[473]`
Mówca: **Narrator**
> "His lip twitched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[474]`
**[WYBÓR GRACZA: ""As a matter of fact, I'm sending naval reinforcements to prevent Pales from further invading the field during the arbitration process." [Send Navy, +1 Authority]"]** — Mówca: **Player_Romus**
> ""As a matter of fact, I'm sending naval reinforcements to prevent Pales from further breaching the field's borders during the arbitration process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[475]`
Mówca: **Narrator**
> "His nostrils flared."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[476]`
Mówca: **Axel Reinhart**
> ""That's *really* not the outcome I was hoping for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`
  - -> `[492]`
  - -> `[526]`

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nor I. But with the help of a third party, I'm sure we'll be able to come to a compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[478]`
Mówca: **Axel Reinhart**
> ""A fast one, I hope. Lespia has its eyes on us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[479]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's what you get for trying to sniff around for the best deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[480]`
Mówca: **Axel Reinhart**
> ""This will work out worse for you in the end. I know that much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Prime Minister Alvarez will be interested in hearing how close you came to betraying him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[482]`
Mówca: **Axel Reinhart**
> ""What?! You wouldn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`
  - -> `[503]`
  - -> `[506]`

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nor I. But I'm willing to let the field go to keep the peace between our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Cede = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then you shouldn't have tried to play Lespia and Rizia off each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[486]`
Mówca: **Axel Reinhart**
> ""Peace, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[487]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My war councilor suggested it as soon as your ship launched. I should have listened to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = true; RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]`

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine, fine, I'll marry you. Just don't tell our Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[490]`
Mówca: **Axel Reinhart**
> ""Funny. But you're not exactly my type.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry. But your willingness to double-cross Lespia shows you cannot be trusted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[493]`
Mówca: **Narrator**
> "He reached under his desk and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[494]`
Mówca: **Axel Reinhart**
> ""Hilda? Be a doll and help show His Majesty the way out of the building. Wouldn't want him getting lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[495]`
Mówca: **Narrator**
> "He sat back in his chair and scrutinized me closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`

### Węzeł `[496]`
Mówca: **Axel Reinhart**
> ""I should warn you that you're going to lose. Badly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`
  - -> `[498]`
  - -> `[499]`
  - -> `[512]`

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Win or lose, I will not simply capitulate to Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[498]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A shame we were unable to settle this like gentlemen, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're bluffing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[500]`
Mówca: **Narrator**
> "He blinked in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[501]`
Mówca: **Axel Reinhart**
> ""However badly you need it, we need it more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[502]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not the only one who can play games.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just wait and see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[504]`
Mówca: **Axel Reinhart**
> ""That's not what -- Never mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[505]`
Mówca: **Axel Reinhart**
> ""I truly hope we can maintain peace with a fleet of Lespian drillships between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[506]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I wouldn't. But it was fun to watch your face as I said that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[507]`
Mówca: **Narrator**
> "Reinhart scowled. He reached under his table and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[508]`
Mówca: **Axel Reinhart**
> ""Hilda? Be a doll and help show His Majesty the way out of the building. Wouldn't want him getting lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[509]`
Mówca: **Axel Reinhart**
> ""Let the record show that we tried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[510]`
Mówca: **Axel Reinhart**
> ""Nor I to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[511]`
Mówca: **Axel Reinhart**
> ""Am I? You'll find out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's an unbefitting attitude. All I want is to keep the peace between our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[513]`
Mówca: **Axel Reinhart**
> ""I want that as well. But I'm just stating the facts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[514]`
Mówca: **Narrator**
> "Reinhart reached under his table and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[515]`
Mówca: **Axel Reinhart**
> ""We'll send over an official concession form for you to sign. In the meantime, you won't object if our ship stays.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`
  - -> `[520]`
  - -> `[521]`

### Węzeł `[516]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This doesn't preclude the possibility of cooperation in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[517]`
Mówca: **Axel Reinhart**
> ""Cooperation will be a lot harder with a fleet of Lespian drillships between us. But we'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[518]`
Mówca: **Narrator**
> "He turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course not. It's your field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[520]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just remember that it is only staying due to our largesse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll meet again, Duke Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[522]`
Mówca: **Axel Reinhart**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[523]`
Mówca: **Axel Reinhart**
> ""Yes, thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[524]`
Mówca: **Axel Reinhart**
> ""I am sure that we will. We're neighbors, aren't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = true; 
RiziaDLC.PersonalValue_Tyrant += 1;
RiziaDLC.Resources_Authority += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = true;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[885]`

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm only taking precautions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[527]`
Mówca: **Axel Reinhart**
> ""She's an Azaro, isn't she? This meeting was doomed from the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[528]`
Mówca: **Axel Reinhart**
> ""It was an attempt at reconciliation. A futile one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[529]`
Mówca: **Axel Reinhart**
> ""Then so will we.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[530]`
Mówca: **Axel Reinhart**
> ""I hope you understand that if your navy enters the field before the AN has decided its ownership, I will be obligated to send our own fleet to join yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`
  - -> `[532]`
  - -> `[533]`

### Węzeł `[531]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. I look forward to it, in fact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[532]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't do anything too rash. Nobody wants escalation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[533]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita. If it is said, so it is, so it will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[534]`
Mówca: **Narrator**
> "He reached under his desk and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[535]`
Mówca: **Axel Reinhart**
> ""Hilda? Be a doll and help show His Majesty the way out of the building. Wouldn't want him getting lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[536]`
Mówca: **Narrator**
> "He sat back in his chair and scrutinized me closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1;
RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;
Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[538]`
Mówca: **Axel Reinhart**
> ""Sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[539]`
Mówca: **Axel Reinhart**
> ""Ha. Unbelievable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[540]`
Mówca: **Axel Reinhart**
> ""You cede the field to Pales and allow us to continue our exploratory drilling without objection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[541]`
Mówca: **Axel Reinhart**
> ""Or...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`
  - -> `[545]`
  - -> `[546]`

### Węzeł `[542]`
Mówca: **Axel Reinhart**
> ""But the simplest solution is for Rizia to know when to give up. Cede the field to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[543]`
Mówca: **Axel Reinhart**
> ""Cede the field to Pales and you will not have to find out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[544]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew there was a more reasonable option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't marry you, Your Grace. It's illegal in my country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[548]`
Mówca: **Narrator**
> "He looked at me strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[549]`
Mówca: **Axel Reinhart**
> ""I hope that was a joke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[550]`
Mówca: **Axel Reinhart**
> ""The only other way out I see is allowing the Alliance of Nations to decide the field's ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[551]`
Mówca: **Axel Reinhart**
> ""But the arbitration process could take years, as I'm sure you have been warned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`
  - -> `[553]`
  - -> `[554]`

### Węzeł `[552]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you sure there's absolutely nothing else you would accept?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[553]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are willing to wait however long we have to for justice to be served.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[554]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I cede the field to Pales, what will you give Rizia in return?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[555]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[556]`
Mówca: **Axel Reinhart**
> ""I reached out to you after my coronation because I was interested in Rizia as an alternative economic partner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[557]`
Mówca: **Axel Reinhart**
> ""But you made it very clear that Rizia did not reciprocate that interest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`
  - -> `[581]`
  - -> `[582]`

### Węzeł `[558]`
Mówca: **Axel Reinhart**
> ""Are you sure about that, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[559]`
Mówca: **Axel Reinhart**
> ""The chance to avoid a lengthy, costly court process that you will inevitably lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[560]`
Mówca: **Axel Reinhart**
> ""We don't have much to give, I'm afraid. But maybe Lespia will sell you part of their rights once they've been awarded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`
  - -> `[563]`
  - -> `[564]`

### Węzeł `[561]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not much of a consolation prize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[562]`
Mówca: **Axel Reinhart**
> ""I know your kingdom has been having difficulties with Wehlen. Can you afford to get caught up in multiple disputes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`
  - -> `[579]`
  - -> `[589]`

### Węzeł `[563]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What makes you think Rizia will lose?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[564]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about a chance for lasting peace between our two nations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[565]`
Mówca: **Axel Reinhart**
> ""You made it clear that Rizia did not want peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[566]`
Mówca: **Axel Reinhart**
> ""But if you've changed your mind, ceding the field to us would certainly help ease tensions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`
  - -> `[571]`

### Węzeł `[567]`
Mówca: **Axel Reinhart**
> ""We have the backing of Lespia, which has the backing of Arcasia. And we both know how much sway the latter has over the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[568]`
Mówca: **Axel Reinhart**
> ""But if you'd like to test that theory, be my guest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`
  - -> `[595]`

### Węzeł `[569]`
Mówca: **Axel Reinhart**
> ""Sorry. I can't think of anything else under the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[570]`
Mówca: **Axel Reinhart**
> ""But even a small percentage of the Aureus field would be a considerable amount of energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`
  - -> `[617]`
  - -> `[595]`

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do want peace. But your attitude is making it difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[572]`
Mówca: **Axel Reinhart**
> ""If I must do so to assert Pales' sovereignty, then I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`
  - -> `[574]`
  - -> `[575]`

### Węzeł `[573]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What sovereignty? Your family only came to power because the Valgos Empire put you there. And now the Empire is gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[574]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your 'sovereignty' only exists because of Lespian support. Without it, Pales would crumble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[575]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We respect Palesian sovereignty. All we are asking for is the right to our own gas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[576]`
Mówca: **Axel Reinhart**
> ""What of Rizia and Rumburg, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[577]`
Mówca: **Axel Reinhart**
> ""I don't know if I can believe you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[578]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Zille bombing was a tragedy. But our relations with Wehlen are as strong as they've ever been.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[579]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who do you think we are? The kingdom of Rizia can afford as many disputes as we like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[580]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, Your Grace. Give my kingdom a chance and we will prove ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[581]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just be reasonable. You are letting past grudges get in the way of a constructive solution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[582]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Could you blame me? We lost many good men fighting your country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[583]`
Mówca: **Axel Reinhart**
> ""Invading my country, you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[584]`
Mówca: **Axel Reinhart**
> ""I'm afraid it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[585]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Rights Purchase Deal)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Rights Purchase Deal])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[587]`
Mówca: **Axel Reinhart**
> ""We are not talking about past grudges. We are talking about your current attitude towards my country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[588]`
Mówca: **Axel Reinhart**
> ""This conversation is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must admit that our difficulties with Wehlen have only made our need for natural gas greater.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[590]`
Mówca: **Axel Reinhart**
> ""I understand. But Pales cannot back down. Lespia has offered a sum that we can hardly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[591]`
Mówca: **Axel Reinhart**
> ""Forgive my impertinence, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[592]`
Mówca: **Axel Reinhart**
> ""No, this conversation is over. Pales will only recognize Rizia's claim to the gas field if we are forced to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`
  - -> `[597]`

### Węzeł `[593]`
Mówca: **Axel Reinhart**
> ""I was mistaken, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[594]`
Mówca: **Axel Reinhart**
> ""But I am not backing down. Pales will only recognize Rizia's claim to the gas field if we are forced to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`
  - -> `[597]`

### Węzeł `[595]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still don't believe that the international community will rally around your insignificant little peninsula.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[596]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I see no choice but to get the AN involved. We have to enter arbitration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[597]`
**[WYBÓR GRACZA: ""My country is not as desperate as yours. Keep the field if you like." [Cede Field]"]** — Mówca: **Player_Romus**
> ""My country is not as desperate as yours. Keep the field if you like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[598]`
Mówca: **Narrator**
> "Duke Reinhart blinked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[599]`
Mówca: **Axel Reinhart**
> ""That's it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[600]`
Mówca: **Axel Reinhart**
> ""Not the outcome I was hoping for. But I accept.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[892]`
  - -> `[622]`
  - -> `[623]`

### Węzeł `[601]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Cede = true; RiziaDLCSupport.Journal_Turn04_Pales_CedeGasField = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_CedeGasField"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[602]`
Mówca: **Axel Reinhart**
> ""Thank you. I guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`
  - -> `[603]`
  - -> `[604]`
  - -> `[610]`

### Węzeł `[603]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a small price to pay for a chance at reconciliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[604]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All I ask in return is that you remember our generosity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[605]`
Mówca: **Axel Reinhart**
> ""I believe you mean that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[606]`
Mówca: **Axel Reinhart**
> ""I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[607]`
Mówca: **Axel Reinhart**
> ""Although reconciliation will be difficult with a fleet of Lespian drillships between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[608]`
Mówca: **Narrator**
> "He reached under his table and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[609]`
Mówca: **Narrator**
> "Reinhart reached under his table and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[610]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This doesn't preclude the possibility of cooperation in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[611]`
Mówca: **Axel Reinhart**
> ""Cooperation will be a lot harder with a fleet of Lespian drillships between us. But we'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and Lespia will both be first against the wall when the revolution comes, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[613]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[614]`
Mówca: **Axel Reinhart**
> ""Are you serious? If anyone's in danger from the so-called revolution, it's your limping monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[615]`
Mówca: **Narrator**
> "Reinhart scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[616]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Considerable for Pales, perhaps. Rizia's energy needs are greater than you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[617]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to save us both the hassle. But I am under as much pressure as you are to claim that field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[618]`
Mówca: **Narrator**
> "Duke Reinhart nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[619]`
**[WYBÓR GRACZA: ""Furthermore, I'm sending naval reinforcements to prevent Pales from further invading the field during the arbitration process." [Send Navy, +1 Authority]"]** — Mówca: **Player_Romus**
> ""Furthermore, I'm sending naval reinforcements to prevent Pales from further breaching the field's borders during the arbitration process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[620]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = true; RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[896]`

### Węzeł `[621]`
Mówca: **Narrator**
> "His nostrils flared."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[622]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the help of a third party, I'm sure we'll be able to come to a compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[623]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you really think we'd just hand you the field?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[624]`
Mówca: **Axel Reinhart**
> ""I thought you'd recognize a lost cause when you saw one. But it seems the Rizia of the 1920s is alive and well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[625]`
Mówca: **Axel Reinhart**
> ""A fast one, I hope. Lespia has its eyes on us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[626]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = true; RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade = true;
RiziaDLC.PersonalValue_Tyrant += 1; 
RiziaDLC.Resources_Authority += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalBlockade"] = true;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[884]`

### Węzeł `[627]`
Mówca: **Axel Reinhart**
> ""That's *really* not the outcome I was hoping for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`
  - -> `[629]`
  - -> `[630]`

### Węzeł `[628]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My war councilor suggested it as soon as your ship launched. I should have listened to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`

### Węzeł `[629]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust you. But I fear Lespia might lose its patience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`

### Węzeł `[630]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm only taking precautions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`

### Węzeł `[631]`
Mówca: **Axel Reinhart**
> ""She's an Azaro, isn't she? This meeting was doomed from the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[632]`
Mówca: **Axel Reinhart**
> ""If you insist on stoking potential conflict... so be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[633]`
Mówca: **Axel Reinhart**
> ""Then so will we.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[634]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End Peaceful Arbitration)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[635]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [End Cede Field])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[636]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [End Peaceful Arbitration])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[637]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End Violent Arbitration)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[638]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [End Violent Arbitration])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`

### Węzeł `[639]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End Cede Field)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[640]`
Mówca: **Axel Reinhart**
> ""Enough insults, Your Majesty. Tell me what you want to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`
  - -> `[643]`

### Węzeł `[641]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see no choice but to enter arbitration. We will notify the Alliance of Nations at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[642]`
Mówca: **Axel Reinhart**
> ""Understood, Your Majesty. Tell me what you want to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`
  - -> `[643]`

### Węzeł `[643]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know what? Rizia is not that desperate. We will cede the field to you if you like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[644]`
Mówca: **Axel Reinhart**
> ""Then let's end this conversation. Tell me what you want to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`
  - -> `[643]`

### Węzeł `[645]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What sovereignty? Your family only came to power because the Valgos Empire put you there. And now the Empire is gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[646]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your 'sovereignty' only exists because of Lespian support. Without it, Pales would crumble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, Your Grace. Let's not let the bad blood between our families color our present relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[648]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We respect your sovereignty. It doesn't mean you can steal our gas from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`

### Węzeł `[649]`
Mówca: **Axel Reinhart**
> ""Between our families? I think you're forgetting our personal history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[650]`
Mówca: **Axel Reinhart**
> ""And what of Rizia and Rumburg? What of the deal your father made with Wehlen to keep House Toras in power?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[651]`
Mówca: **Axel Reinhart**
> ""It is disrespectful to claim that the sovereignty of our nation, however young, is equal to that of a neglected speck of a Rizian island.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[652]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`
  - -> `[654]`

### Węzeł `[653]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[654]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[655]`
Mówca: **Axel Reinhart**
> ""I am prepared to reconcile as long as you recognize that the gas field belongs to Pales alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[656]`
Mówca: **Axel Reinhart**
> ""But I am prepared to reconcile as long as you recognize that the gas field belongs to Pales alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[657]`
Mówca: **Narrator**
> "I saw intensity in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[658]`
Mówca: **Axel Reinhart**
> ""You know, Your Majesty, we Reinharts have ruled Pales for as long as the Torases have ruled Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[659]`
Mówca: **Axel Reinhart**
> ""And what of Rizia? Trudging forward with the legacy of the mighty Rezenids, long after their empire should have turned to dust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[660]`
Mówca: **Axel Reinhart**
> ""Yes, Pales was part of the Valgos Empire. But we developed our own laws and customs. Even our own language.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[661]`
Mówca: **Axel Reinhart**
> ""When the Empire fell apart, what were we supposed to do? Simply give up everything we had built?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`
  - -> `[664]`
  - -> `[663]`
  - -> `[662]`

### Węzeł `[662]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales could have kept its cultural identity intact if it had rejoined Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[663]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regimes end. It was your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. No, I suppose not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`

### Węzeł `[665]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would have done that before turning to Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[666]`
Mówca: **Axel Reinhart**
> ""Your father would never have allowed that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`

### Węzeł `[667]`
Mówca: **Axel Reinhart**
> ""That wasn't your kingdom's decision to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`

### Węzeł `[668]`
Mówca: **Axel Reinhart**
> ""You don't know what you would have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`

### Węzeł `[669]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC.Prologue_JoinedSuOmina == true || RiziaDLC.LeaningValue_Democratic < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`
  - -> `[671]`

### Węzeł `[670]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC.Prologue_JoinedSuOmina == true || RiziaDLC.LeaningValue_Democratic < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Absolutism"] == true  or  Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true  or  Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[671]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Focus_Government_Absolutism == true || RiziaDLC.Prologue_JoinedSuOmina == true || RiziaDLC.LeaningValue_Democratic < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Absolutism"] == true  or  Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true  or  Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[672]`
Mówca: **Axel Reinhart**
> ""And your own nationalist tendencies make me think you wouldn't, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[673]`
Mówca: **Axel Reinhart**
> ""Even if he had, my family never would have agreed. They had too much pride.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[674]`
Mówca: **Axel Reinhart**
> ""Lespia, on the other hand, was more than willing to support our independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`
  - -> `[679]`
  - -> `[680]`

### Węzeł `[675]`
Mówca: **Axel Reinhart**
> ""So they accepted help from Lespia. The only country willing to support our independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`
  - -> `[679]`
  - -> `[680]`

### Węzeł `[676]`
Mówca: **Axel Reinhart**
> ""I heard what it was like back then. Rizia and Morella picking at us like vultures. Goddamn Valgsland trying to provoke a revolution from the sidelines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[677]`
Mówca: **Axel Reinhart**
> ""Lespia was the only nation willing to support our independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`
  - -> `[679]`
  - -> `[680]`

### Węzeł `[678]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They supported your independence... by making you dependent on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[679]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your family must have realized their motives for doing so were less than pure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[680]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should never have been put in that position, Your Grace. My country should have left Pales alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[681]`
Mówca: **Axel Reinhart**
> ""Thank you for acknowledging that. But it doesn't change anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`
  - -> `[685]`
  - -> `[687]`
  - -> `[686]`

### Węzeł `[682]`
Mówca: **Axel Reinhart**
> ""Of course. But thanks to Rizia's aggression, they had no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`
  - -> `[685]`
  - -> `[687]`
  - -> `[686]`

### Węzeł `[683]`
Mówca: **Axel Reinhart**
> ""By making us wealthy. By giving us the capacity to defend ourselves against aggressors like you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`
  - -> `[685]`
  - -> `[687]`
  - -> `[686]`

### Węzeł `[684]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now that Lespia is an ATO member, they won't want to be connected to a monarchy for long. They'll have you overthrown the first chance they get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[685]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand why Pales accepted Lespia's aid. But now that Morella is in league with Valgsland, you could get caught between superpowers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[686]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough with the history lesson. What do you plan to do *now*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[687]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you met their new prime minister? Do you trust him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[688]`
Mówca: **Narrator**
> "His gaze hardened as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`

### Węzeł `[689]`
Mówca: **Axel Reinhart**
> ""No, they won't. Not while they need our gas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[690]`
Mówca: **Axel Reinhart**
> ""So you see, Your Majesty, we can't let Rizia take it from us. Not without a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`
  - -> `[698]`
  - -> `[699]`
  - -> `[702]`

### Węzeł `[691]`
Mówca: **Narrator**
> "His gaze hardened as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[692]`
Mówca: **Axel Reinhart**
> ""Not as long as we have a bargaining chip. And we do, right at the bottom of the Antacean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[693]`
Mówca: **Narrator**
> "His gaze hardened as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`

### Węzeł `[694]`
Mówca: **Axel Reinhart**
> ""I am bringing this up so you understand the stakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[695]`
Mówca: **Axel Reinhart**
> ""We have an obligation to Lespia. When they ask us for natural gas, we can hardly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[696]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Calm down, Your Grace. We have no intention of starting a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[697]`
Mówca: **Axel Reinhart**
> ""Then prove it. Send your ships back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`
  - -> `[707]`
  - -> `[708]`

### Węzeł `[698]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it's a fight you want, it's a fight you'll get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]`

### Węzeł `[699]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are not the only country with obligations. And the gas field is large enough to be split.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[700]`
Mówca: **Narrator**
> "His gaze hardened as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`

### Węzeł `[701]`
Mówca: **Axel Reinhart**
> ""I trust Patricio Alvarez more than I trust you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[702]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A compelling argument. But we won't cede the field to you for nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[703]`
Mówca: **Axel Reinhart**
> ""Are you sure, Your Majesty? You remember what happened in the 1920s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`
  - -> `[710]`
  - -> `[711]`

### Węzeł `[704]`
Mówca: **Axel Reinhart**
> ""Sharing a gas field requires close collaboration. You'll excuse me if I don't feel like collaborating with Rizia right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`
  - -> `[713]`
  - -> `[714]`

### Węzeł `[705]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will when you send *your* ship back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[706]`
Mówca: **Axel Reinhart**
> ""Why not? It would avoid us both a lot of headache.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`
  - -> `[729]`
  - -> `[730]`

### Węzeł `[707]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am considering it. But we have to come to an agreement regarding the gas field first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`

### Węzeł `[708]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do I know you won't just resume drilling if I call for a retreat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[709]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. We had you beat until you went crying to Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`

### Węzeł `[710]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. We lost a lot of good men fighting Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`

### Węzeł `[711]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I remember better than you. You weren't even born.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[712]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I admit I acted harshly. If I agree to call back our ships, can we have a reasonable talk?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`

### Węzeł `[713]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't have to collaborate. Just stay on our respective sides.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[714]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you don't choose to collaborate, we will force you to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]`

### Węzeł `[715]`
Mówca: **Axel Reinhart**
> ""No, I will not withdraw Pales' presence from the field as long as the Rizian navy is there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[716]`
Mówca: **Axel Reinhart**
> ""Excuse me, Your Majesty, but I'm feeling less than agreeable with your ships' guns pointed at mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[717]`
Mówca: **Axel Reinhart**
> ""If I do that, you can call your ships right back in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[718]`
Mówca: **Axel Reinhart**
> ""Lespia only offered us minor assistance with weapons and equipment. Your own internal strife harmed you more than Lespia did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[719]`
Mówca: **Axel Reinhart**
> ""Invading Pales, you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[720]`
Mówca: **Axel Reinhart**
> ""Then you know how unwise it is to provoke my Grand Duchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[721]`
Mówca: **Axel Reinhart**
> ""At last, something resembling sanity from the King of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[722]`
Mówca: **Axel Reinhart**
> ""I am asking you politely. Withdraw your navy, and we will talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`
  - -> `[736]`

### Węzeł `[723]`
Mówca: **Axel Reinhart**
> ""I will give you one chance. Withdraw your navy, and we will have a reasonable discussion about the gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`
  - -> `[736]`

### Węzeł `[724]`
Mówca: **Axel Reinhart**
> ""There's too much potential for disagreement. Which Rizia has already proved itself incapable of handling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[725]`
Mówca: **Axel Reinhart**
> ""Please, Your Majesty. Neither of us want escalation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[726]`
Mówca: **Axel Reinhart**
> ""Before we continue this conversation, I must insist that you withdraw your navy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`
  - -> `[736]`

### Węzeł `[727]`
Mówca: **Axel Reinhart**
> ""Yes. Withdraw your navy, and we will continue this conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`
  - -> `[736]`

### Węzeł `[728]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Giving in to Pales, and therefore Lespia, would make us look weak internationally. We can't afford that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`

### Węzeł `[729]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia needs the gas in that field, Your Grace. Do not test us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`

### Węzeł `[730]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's the principle of the thing. I truly believe the field's proximity to Caleqabiz gives us a right to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`

### Węzeł `[731]`
Mówca: **Axel Reinhart**
> ""And I believe it doesn't. So where does that get us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`

### Węzeł `[732]`
Mówca: **Axel Reinhart**
> ""Just because you need it doesn't make you entitled to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`

### Węzeł `[733]`
Mówca: **Axel Reinhart**
> ""Have you thought about how it would make us look to cave in to Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`

### Węzeł `[734]`
Mówca: **Axel Reinhart**
> ""Please, Your Majesty. We can discuss this. But I want you to withdraw your navy first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`
  - -> `[736]`

### Węzeł `[735]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. My ships are staying right where they are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`

### Węzeł `[736]`
**[WYBÓR GRACZA: ""If it means we can move forward, then fine. I'll call off my ships effective immediately." [Recall Fleet]"]** — Mówca: **Player_Romus**
> ""If it means we can move forward, then fine. I'll call off my ships effective immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]`

### Węzeł `[737]`
Mówca: **Narrator**
> "Duke Reinhart breathed a shaky sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[738]`
Mówca: **Axel Reinhart**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[739]`
Mówca: **Narrator**
> "Duke Reinhart paled. He swallowed before speaking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`

### Węzeł `[740]`
Mówca: **Axel Reinhart**
> ""That's it, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[741]`
Mówca: **Axel Reinhart**
> ""I see no choice but to call in the AN for arbitration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`
  - -> `[744]`
  - -> `[751]`

### Węzeł `[742]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great. They'll easily rule that Pales acted in direct violation of the AN Directive on Offshore Resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`

### Węzeł `[743]`
Mówca: **Axel Reinhart**
> ""And even if it applies, ANDOR is not black and white. It's very nuanced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`
  - -> `[746]`
  - -> `[748]`

### Węzeł `[744]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita. If it is said, so it is, so it will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[908]`

### Węzeł `[745]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's only nuanced compared to its predecessors. It doesn't stand alone as a brilliant piece of legislation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]`

### Węzeł `[746]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have the support of the international community. Pales doesn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]`

### Węzeł `[747]`
Mówca: **Axel Reinhart**
> ""I never cared for those old Wruhecist saws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`
  - -> `[753]`
  - -> `[757]`

### Węzeł `[748]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The rules over our maritime borders seem clear to me. And to my councilors as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]`

### Węzeł `[749]`
Mówca: **Axel Reinhart**
> ""A directive we never ratified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[750]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're disrespecting our religion now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[751]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on. What happened to solving disputes man to man?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]`

### Węzeł `[752]`
Mówca: **Axel Reinhart**
> ""I won't risk it. The potential for inciting an armed conflict is too high.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]`
  - -> `[787]`
  - -> `[801]`

### Węzeł `[753]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not a saw, it's a promise. Your words shall translate into actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`

### Węzeł `[754]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]`

### Węzeł `[755]`
Mówca: **Axel Reinhart**
> ""I'm as God-fearing as the next man. But we can't stay beholden to the words of old saints forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]`

### Węzeł `[756]`
Mówca: **Axel Reinhart**
> ""You're right about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]`

### Węzeł `[757]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nor do I, but my subjects go crazy for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`

### Węzeł `[758]`
Mówca: **Axel Reinhart**
> ""Everyone loves a king with a direct line to God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]`

### Węzeł `[759]`
Mówca: **Axel Reinhart**
> ""Unfortunately, our options for the Aureus field are still limited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]`

### Węzeł `[760]`
Mówca: **Axel Reinhart**
> ""Lespia is on the verge of purchasing the exploration rights to the field. Yet you obviously are not willing to cede it to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]`

### Węzeł `[761]`
Mówca: **Axel Reinhart**
> ""So the only choice I see is to take this to the Alliance of Nations for arbitration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[841]`
  - -> `[800]`
  - -> `[762]`

### Węzeł `[762]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. If I *do* cede the field to Pales, what will you give Rizia in return?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]`

### Węzeł `[763]`
Mówca: **Axel Reinhart**
> ""The chance to avoid a lengthy, costly court process that you will inevitably lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]`

### Węzeł `[764]`
Mówca: **Axel Reinhart**
> ""We don't have much to give, I'm afraid. But maybe Lespia will sell you part of the rights once they've been awarded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]`
  - -> `[766]`
  - -> `[774]`
  - -> `[767]`

### Węzeł `[765]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not much of a consolation prize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]`

### Węzeł `[766]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What makes you think Rizia will lose?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]`

### Węzeł `[767]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about a chance for lasting peace between our two nations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`

### Węzeł `[768]`
Mówca: **Axel Reinhart**
> ""You made it clear that Rizia did not want peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]`

### Węzeł `[769]`
Mówca: **Axel Reinhart**
> ""But if you've changed your mind about that, here's your opportunity to prove it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`
  - -> `[862]`

### Węzeł `[770]`
Mówca: **Axel Reinhart**
> ""We have the backing of Lespia, which has the backing of Arcasia. And we both know how much sway the latter has over the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]`

### Węzeł `[771]`
Mówca: **Axel Reinhart**
> ""But if you'd like to test that theory, be my guest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`
  - -> `[862]`

### Węzeł `[772]`
Mówca: **Axel Reinhart**
> ""Well. I can't think of anything else under the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]`

### Węzeł `[773]`
Mówca: **Axel Reinhart**
> ""But even a small percentage of the Aureus field would be a considerable amount of energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`
  - -> `[862]`

### Węzeł `[774]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I refuse to make deals with Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]`

### Węzeł `[775]`
Mówca: **Axel Reinhart**
> ""Then never mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]`

### Węzeł `[776]`
Mówca: **Axel Reinhart**
> ""We have the backing of Lespia, which has the backing of Arcasia. And we both know how much sway the latter has over the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`
  - -> `[781]`
  - -> `[782]`
  - -> `[783]`

### Węzeł `[777]`
Mówca: **Axel Reinhart**
> ""It's nuanced enough that I believe Pales will get the benefit of the doubt. Especially with international help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`
  - -> `[781]`
  - -> `[782]`
  - -> `[783]`

### Węzeł `[778]`
Mówca: **Axel Reinhart**
> ""Let's see if the AN sees it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[779]`
Mówca: **Axel Reinhart**
> ""Remember, we have the backing of Lespia, which has the backing of Arcasia. And we both know how much sway the latter has over the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`
  - -> `[781]`
  - -> `[782]`
  - -> `[783]`

### Węzeł `[780]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your intimidation won't work on me. Remember, my navy is still surrounding your ship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]`

### Węzeł `[781]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're forgetting the support we have from Rumburg and GRACE.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]`

### Węzeł `[782]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The rest of Southern Merkopa will take my side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]`

### Węzeł `[783]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You shouldn't place so much trust in Lespia, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]`

### Węzeł `[784]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Calling in a third party will help us find a compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[785]`
Mówca: **Axel Reinhart**
> ""In any event, I hope you will send your ships away peacefully once you lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`
  - -> `[795]`
  - -> `[811]`

### Węzeł `[786]`
Mówca: **Axel Reinhart**
> ""To the extent that 'compromise' is possible with a kingdom as militant as yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]`

### Węzeł `[787]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Armed conflict... what about arm wrestling? We can settle the argument right here at this table.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]`

### Węzeł `[788]`
Mówca: **Narrator**
> "He raised an eyebrow. I saw the muscles in his arm twitch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]`

### Węzeł `[789]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]`

### Węzeł `[790]`
Mówca: **Axel Reinhart**
> ""Are you joking? You would lose in an instant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[791]`

### Węzeł `[791]`
Mówca: **Axel Reinhart**
> ""Just as you will lose the arbitration process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`
  - -> `[795]`
  - -> `[812]`

### Węzeł `[792]`
Mówca: **Axel Reinhart**
> ""I hope you will send your ships away peacefully once you lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`
  - -> `[795]`
  - -> `[811]`

### Węzeł `[793]`
Mówca: **Axel Reinhart**
> ""And I hope you will send it away peacefully once you lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[794]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's presumptuous of you, Your Grace. You'll find no support from the rest of South Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]`

### Węzeł `[795]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What makes you think we will lose? Remember that we have GRACE on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]`

### Węzeł `[796]`
Mówca: **Axel Reinhart**
> ""This is the 20th century, Your Majesty. Dying monarchies don't have as much clout as they used to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[797]`
Mówca: **Axel Reinhart**
> ""Will they? After you've shown that you'll deploy your military at the drop of a hat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[798]`
Mówca: **Axel Reinhart**
> ""And you should not underestimate them. Or us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[799]`
Mówca: **Narrator**
> "He reached under his desk and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`

### Węzeł `[800]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's the only choice? Can't we come to a compromise on our own?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]`

### Węzeł `[801]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're afraid of what would happen if I unleashed the full power of the Rizian military on Pales. As you should be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]`

### Węzeł `[802]`
Mówca: **Axel Reinhart**
> ""I most certainly am not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]`

### Węzeł `[803]`
Mówca: **Axel Reinhart**
> ""But if we get into a conflict around the Aureus field, we risk damaging the very resource we're fighting over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]`
  - -> `[827]`
  - -> `[828]`

### Węzeł `[804]`
Mówca: **Axel Reinhart**
> ""Hilda? Be a doll and help show His Majesty the way out of the building. Wouldn't want him getting lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]`

### Węzeł `[805]`
Mówca: **Narrator**
> "He sat back in his chair and scrutinized me closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]`

### Węzeł `[806]`
Mówca: **Axel Reinhart**
> ""You do understand that as long as your navy is in our waters, we are obligated to send our ships to join yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`
  - -> `[808]`
  - -> `[809]`

### Węzeł `[807]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By all means, do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`

### Węzeł `[808]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your vastly inferior ships, you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]`

### Węzeł `[809]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry that it's come to this, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]`

### Węzeł `[810]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Watching your face as you surrender will be worth it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]`

### Węzeł `[811]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will respect whatever the AN decides, as long as their judgement is fair and unbiased.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`

### Węzeł `[812]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew the Duke of Pales would be too cowardly to arm wrestle a real king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]`

### Węzeł `[813]`
Mówca: **Axel Reinhart**
> ""And you will?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[814]`
Mówca: **Axel Reinhart**
> ""This is the 20th century, Your Majesty. Dying monarchies don't have as much clout as they used to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[815]`
Mówca: **Axel Reinhart**
> ""I'll hold you to that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[816]`
Mówca: **Axel Reinhart**
> ""You're embarrassing yourself, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[817]`
Mówca: **Axel Reinhart**
> ""This entirely avoidable situation? Yes, I'm sorry as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`

### Węzeł `[818]`
Mówca: **Axel Reinhart**
> ""You do not want to test the strength of the Palesian navy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`

### Węzeł `[819]`
Mówca: **Axel Reinhart**
> ""You're playing a very dangerous game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`

### Węzeł `[820]`
Mówca: **Axel Reinhart**
> ""I truly hope we can come to a peaceful resolution through the Alliance of Nations. For your sake, mostly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]`

### Węzeł `[821]`
Mówca: **Narrator**
> "Duke Reinhart's secretary opened the door. He stood up and gestured for me to do the same."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]`

### Węzeł `[822]`
Mówca: **Axel Reinhart**
> ""I'll see you in court, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]`
  - -> `[824]`
  - -> `[825]`

### Węzeł `[823]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until then, Duke Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[886]`

### Węzeł `[824]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[886]`

### Węzeł `[825]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See you on the battlefield.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]`

### Węzeł `[826]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[886]`

### Węzeł `[827]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then we'll just have to do our fighting elsewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]`

### Węzeł `[828]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was only posturing. I have no intention of inciting conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]`

### Węzeł `[829]`
Mówca: **Axel Reinhart**
> ""I truly hope you don't mean that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[830]`
Mówca: **Axel Reinhart**
> ""Believe me, Pales would not surrender.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[831]`
Mówca: **Axel Reinhart**
> ""Nor do I. But accidents happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[832]`
Mówca: **Axel Reinhart**
> ""With luck, the arbitration proceedings will conclude before mistakes are made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]`

### Węzeł `[833]`
Mówca: **Axel Reinhart**
> ""And with more luck, you will send your ships away peacefully when you lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`
  - -> `[795]`
  - -> `[811]`

### Węzeł `[834]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]`

### Węzeł `[835]`
Mówca: **Axel Reinhart**
> ""I am all for arbitration. Just wanted to save you the hassle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`
  - -> `[862]`

### Węzeł `[836]`
Mówca: **Axel Reinhart**
> ""Not after your past animosity towards the Grand Duchy. And certainly not after your naval blockade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[859]`

### Węzeł `[837]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[838]`
  - -> `[839]`

### Węzeł `[838]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]`

### Węzeł `[839]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]`

### Węzeł `[840]`
Mówca: **Axel Reinhart**
> ""I'm afraid your naval blockade has precluded any chance of doing business with Pales, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[859]`

### Węzeł `[841]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They'll easily rule that Pales acted in direct violation of the AN Directive on Offshore Resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]`

### Węzeł `[842]`
Mówca: **Axel Reinhart**
> ""And even if it applies, ANDOR is not black and white. It's very nuanced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[843]`
  - -> `[844]`
  - -> `[845]`

### Węzeł `[843]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's only nuanced compared to its predecessors. It doesn't stand alone as a brilliant piece of legislation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[848]`

### Węzeł `[844]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have the support of the international community. Pales doesn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[847]`

### Węzeł `[845]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The rules over our maritime borders seem clear to me. And to my councilors as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[855]`

### Węzeł `[846]`
Mówca: **Axel Reinhart**
> ""A directive we never ratified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]`

### Węzeł `[847]`
Mówca: **Axel Reinhart**
> ""We have the backing of Lespia, which has the backing of Arcasia. And we both know how much sway the latter has over the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]`
  - -> `[851]`
  - -> `[858]`
  - -> `[849]`

### Węzeł `[848]`
Mówca: **Axel Reinhart**
> ""It's nuanced enough that I believe Pales will get the benefit of the doubt. Especially with international help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]`
  - -> `[851]`
  - -> `[858]`
  - -> `[849]`

### Węzeł `[849]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You shouldn't place so much trust in Lespia, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]`

### Węzeł `[850]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your intimidation won't work on me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[856]`

### Węzeł `[851]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're forgetting the support we have from Rumburg and GRACE.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]`

### Węzeł `[852]`
Mówca: **Axel Reinhart**
> ""This is the 20th century, Your Majesty. Dying monarchies don't have as much clout as they used to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[853]`
Mówca: **Axel Reinhart**
> ""Will they? After you've shown that you'll deploy your military at the drop of a hat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[854]`
Mówca: **Axel Reinhart**
> ""And you should not underestimate them. Or us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[855]`
Mówca: **Axel Reinhart**
> ""Let's see if the AN sees it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]`

### Węzeł `[856]`
Mówca: **Axel Reinhart**
> ""It's not intimidation. I'm just stating the facts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[857]`
Mówca: **Axel Reinhart**
> ""Remember, we have the backing of Lespia, which has the backing of Arcasia. And we both know how much sway the latter has over the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]`
  - -> `[851]`
  - -> `[858]`
  - -> `[849]`

### Węzeł `[858]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The rest of Southern Merkopa will take my side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]`

### Węzeł `[859]`
Mówca: **Axel Reinhart**
> ""Either you cede us the field -- sparing us both a long and costly process -- or we call in the AN.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`
  - -> `[862]`

### Węzeł `[860]`
Mówca: **Axel Reinhart**
> ""I'm telling you, if you cede the gas field to us without argument, you'll be able to avoid a long and costly process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`
  - -> `[862]`

### Węzeł `[861]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not backing down. We will have to enter arbitration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[865]`

### Węzeł `[862]`
**[WYBÓR GRACZA: ""You know what? You're obviously more desperate for this gas field than we are. Keep it if you like." [Cede Field]"]** — Mówca: **Player_Romus**
> ""You know what? You're obviously more desperate for this gas field than we are. Keep it if you like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]`

### Węzeł `[863]`
Mówca: **Axel Reinhart**
> ""So be it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]`

### Węzeł `[864]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [End Peaceful Arbitration])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[865]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = true; RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[897]`

### Węzeł `[866]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Cede = true; RiziaDLCSupport.Journal_Turn04_Pales_CedeGasField = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower += 1;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower += 1;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Morella_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1;
RiziaDLC.War_Pales_PublicWarSupport += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_CedeGasField"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] + 1;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] + 1;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;
Variable["RiziaDLC.War_Pales_PublicWarSupport"] = Variable["RiziaDLC.War_Pales_PublicWarSupport"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[887]`

### Węzeł `[867]`
Mówca: **Narrator**
> "Duke Reinhart blinked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[868]`
Mówca: **Axel Reinhart**
> ""That's it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]`

### Węzeł `[869]`
Mówca: **Axel Reinhart**
> ""Thank you. I guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[873]`
  - -> `[870]`
  - -> `[871]`
  - -> `[872]`

### Węzeł `[870]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a small price to pay for a chance at reconciliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[874]`

### Węzeł `[871]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All I ask in return is that you remember our generosity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]`

### Węzeł `[872]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am hoping that this gives us a chance for cooperation in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[879]`

### Węzeł `[873]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You and Lespia will both be first against the wall when the revolution comes, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[880]`

### Węzeł `[874]`
Mówca: **Axel Reinhart**
> ""You sent your navy after us, now you speak of reconciliation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]`

### Węzeł `[875]`
Mówca: **Axel Reinhart**
> ""You sent your navy after us, now you expect us to praise your generosity?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]`

### Węzeł `[876]`
Mówca: **Axel Reinhart**
> ""I am glad that you saw reason and backed down. But I do not wish to have any dealings with Rizia in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[878]`

### Węzeł `[877]`
Mówca: **Narrator**
> "He reached under his table and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]`

### Węzeł `[878]`
Mówca: **Narrator**
> "Reinhart reached under his table and pressed an intercom button."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]`

### Węzeł `[879]`
Mówca: **Axel Reinhart**
> ""You sent your navy after us, and now you speak of cooperation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]`

### Węzeł `[880]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]`

### Węzeł `[881]`
Mówca: **Axel Reinhart**
> ""Are you serious? If anyone's in danger from the so-called revolution, it's your limping monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[877]`

### Węzeł `[882]`
Mówca: **Narrator**
> "Reinhart scowled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]`

### Węzeł `[883]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [End Cede Field])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[884]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1;
RiziaDLC.LeaningValue_Democratic -= 1;
RiziaDLC.PersonalValue_Pacifist -= 3;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 2;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[885]`
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
  - -> `[475]`

### Węzeł `[886]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = true; RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_EnterArbitration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[898]`

### Węzeł `[887]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = false; RiziaDLCSupport.Reports_Turn04_NavyWithdrawn = true; RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower += 1;
RiziaDLC.LeaningValue_Democratic += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = false;
Variable["RiziaDLCSupport.Reports_Turn04_NavyWithdrawn"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[867]`

### Węzeł `[888]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_NegotiatingPower += 2;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 2;
RiziaDLC.Diplomacy_Morella_NegotiatingPower += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] + 2;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 2;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[889]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[890]`
  - -> `[891]`

### Węzeł `[890]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[891]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[892]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[893]`
  - -> `[894]`

### Węzeł `[893]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[894]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[895]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[896]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[897]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[906]`

### Węzeł `[898]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[899]`
Mówca: **Narrator**
> "An upfront fee, an annual extraction rights payment, and in exchange, a stable annual energy supply from the gas field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[918]`

### Węzeł `[900]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatusImmediately("Rizia_Country_Pales", "Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);)*
- **Efekt (`userScript`):** `AddTokenStatusImmediately("Rizia_Country_Pales","Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[888]`

### Węzeł `[901]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]`
  - -> `[903]`

### Węzeł `[902]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[904]`

### Węzeł `[903]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]`

### Węzeł `[904]`
Mówca: **Axel Reinhart**
> ""I'm sure you could hold your own in that arena, Your Majesty. But no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]`

### Węzeł `[905]`
Mówca: **Axel Reinhart**
> ""We're going to arbitration. And Rizia will lose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`
  - -> `[795]`
  - -> `[812]`

### Węzeł `[906]`
Mówca: **Narrator**
> "The Duke gritted his teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[916]`

### Węzeł `[907]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn03_Security_TitusLeadsInvestigation = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn03_Security_TitusLeadsInvestigation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[195]`
  - -> `[196]`

### Węzeł `[908]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]`

### Węzeł `[909]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = false; RiziaDLCSupport.Reports_Turn04_NavyWithdrawn = true; RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal = true;
RiziaDLC.Diplomacy_Pales_NegotiatingPower += 1;
RiziaDLC.LeaningValue_Democratic += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = false;
Variable["RiziaDLCSupport.Reports_Turn04_NavyWithdrawn"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[863]`

### Węzeł `[910]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe we're done here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[909]`

### Węzeł `[911]`
**[WYBÓR GRACZA: ""Furthermore, since you were unable to offer us anything, I will not be recalling my fleet after all. Our navy will stay at the field until arbitration is through." [Continue Blockade]"]** — Mówca: **Player_Romus**
> ""Furthermore, since you were unable to offer us anything, I will not be recalling my fleet after all. Our navy will stay at the field until arbitration is through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[913]`

### Węzeł `[912]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As am I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[909]`

### Węzeł `[913]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[914]`

### Węzeł `[914]`
Mówca: **Narrator**
> "His jaw twitched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[915]`

### Węzeł `[915]`
Mówca: **Axel Reinhart**
> ""That's a big mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]`

### Węzeł `[916]`
Mówca: **Axel Reinhart**
> ""I'm sorry it had to come to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[911]`
  - -> `[912]`
  - -> `[910]`

### Węzeł `[917]`
Mówca: **Narrator**
> "It was an extremely large sum, more than our treasury could afford."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[434]`
  - -> `[439]`

### Węzeł `[918]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[919]`
  - -> `[920]`

### Węzeł `[919]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[924]`

### Węzeł `[920]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[921]`

### Węzeł `[921]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[922]`
  - -> `[923]`

### Węzeł `[922]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[923]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[927]`

### Węzeł `[924]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[925]`
  - -> `[926]`

### Węzeł `[925]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 10)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[930]`

### Węzeł `[926]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 10))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[931]`

### Węzeł `[927]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[928]`
  - -> `[929]`

### Węzeł `[928]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 6)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[932]`

### Węzeł `[929]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 6))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[930]`
Mówca: **Narrator**
> "It was a ridiculously large sum, but our treasury could afford it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[933]`
  - -> `[408]`
  - -> `[436]`
  - -> `[437]`

### Węzeł `[931]`
Mówca: **Narrator**
> "It was a ridiculously large sum, much more than our treasury could afford."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[434]`
  - -> `[439]`

### Węzeł `[932]`
Mówca: **Narrator**
> "It was a very large sum, but our treasury could afford it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`
  - -> `[408]`
  - -> `[436]`
  - -> `[437]`

### Węzeł `[933]`
**[WYBÓR GRACZA: ""Seems reasonable to me. You have a deal, Duke Reinhart." [-10 Budget Now, -2 Budget Per Turn Now, -5 Budget Per Turn in Future, +8 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""Seems reasonable to me. You have a deal, Duke Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[943]`

### Węzeł `[934]`
**[WYBÓR GRACZA: ""Seems reasonable to me. You have a deal, Duke Reinhart." [-8 Budget Now, -2 Budget Per Turn Now, -4 Budget Per Turn in Future, +8 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""Seems reasonable to me. You have a deal, Duke Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[944]`

### Węzeł `[935]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[936]`
  - -> `[937]`

### Węzeł `[936]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 8  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[941]`

### Węzeł `[937]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 8  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[938]`

### Węzeł `[938]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 6 && (RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.CountryRelation_Pales_Friendly == true) == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[939]`
  - -> `[940]`

### Węzeł `[939]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 6 && (RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.CountryRelation_Pales_Friendly == true) == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 6  and  (Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.CountryRelation_Pales_Friendly"] == true) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[942]`

### Węzeł `[940]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 6 && (RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true || RiziaDLC.CountryRelation_Pales_Friendly == true) == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 6  and  (Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true  or  Variable["RiziaDLC.CountryRelation_Pales_Friendly"] == true) == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[941]`
**[WYBÓR GRACZA: ""Very well, Your Grace. You have a deal." [-8 Budget Now, -2 Budget Per Turn Now, -4 Budget Per Turn in Future, +8 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""Very well, Your Grace. You have a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[948]`

### Węzeł `[942]`
**[WYBÓR GRACZA: ""Very well, Your Grace. You have a deal." [-6 Budget Now, -2 Budget Per Turn Now, -4 Budget Per Turn in Future, +8 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""Very well, Your Grace. You have a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[949]`

### Węzeł `[943]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 10;
RiziaDLC.Budget_Modifier_PalesTrade = -5;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 10;
Variable["RiziaDLC.Budget_Modifier_PalesTrade"] = -5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[946]`

### Węzeł `[944]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 8;
RiziaDLC.Budget_Modifier_PalesTrade = -4;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 8;
Variable["RiziaDLC.Budget_Modifier_PalesTrade"] = -4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[946]`

### Węzeł `[945]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 6;
RiziaDLC.Budget_Modifier_PalesTrade = -4;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 6;
Variable["RiziaDLC.Budget_Modifier_PalesTrade"] = -4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[946]`

### Węzeł `[946]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[947]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 10;
RiziaDLC.Budget_Modifier_PalesTrade = -5;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 10;
Variable["RiziaDLC.Budget_Modifier_PalesTrade"] = -5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[950]`

### Węzeł `[948]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 8;
RiziaDLC.Budget_Modifier_PalesTrade = -4;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 8;
Variable["RiziaDLC.Budget_Modifier_PalesTrade"] = -4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[950]`

### Węzeł `[949]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 6;
RiziaDLC.Budget_Modifier_PalesTrade = -4;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 6;
Variable["RiziaDLC.Budget_Modifier_PalesTrade"] = -4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[950]`

### Węzeł `[950]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[951]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true) || (RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true) || (RiziaDLC.Resources_Budget >= 6 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == false && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[952]`
  - -> `[953]`

### Węzeł `[952]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true) || (RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true) || (RiziaDLC.Resources_Budget >= 6 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == false && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true)  or  (Variable["RiziaDLC.Resources_Budget"] >= 8  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true)  or  (Variable["RiziaDLC.Resources_Budget"] >= 6  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == false  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[954]`

### Węzeł `[953]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Resources_Budget >= 10 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == true) || (RiziaDLC.Resources_Budget >= 8 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == true) || (RiziaDLC.Resources_Budget >= 6 && RiziaDLC.Situation_Diplomacy_PowerProjection_Average == false && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false)))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Resources_Budget"] >= 10  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == true)  or  (Variable["RiziaDLC.Resources_Budget"] >= 8  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == true)  or  (Variable["RiziaDLC.Resources_Budget"] >= 6  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Average"] == false  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[954]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can afford the deal if we need to. But I was hoping for a neighborly discount.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[955]`

### Węzeł `[955]`
Mówca: **Axel Reinhart**
> ""This *is* my discount.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[956]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Choosing between peace and war", "Castle Reinhart", "Grand-Duchy of Pales");)*
- **Efekt (`userScript`):** `SetRichPresence("Choosing between peace and war","Castle Reinhart","Grand-Duchy of Pales");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
