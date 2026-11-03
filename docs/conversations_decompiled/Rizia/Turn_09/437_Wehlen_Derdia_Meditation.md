# Rizia/Turn 9/Wehlen Derdia Meditation

- **ID konwersacji:** `437`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/437_Wehlen_Derdia_Meditation.md`
- **Liczba węzłów dialogowych:** 394
- **Liczba wyborów gracza:** 56

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[69]** Jorga Azmal
- **[70]** Laurento Esquibel
- **[77]** Wiktor Smolak (R)
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Situation_Order_BFF_ThreatEliminated`
- `BaseGameSupport.News_Turn07_R_RitualFailed`
- `RiziaDLC.CountryRelation_Sordland_Allied`
- `RiziaDLC.CountryRelation_Sordland_Friendly`
- `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Intermerkopum_Efforts`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_Manpower`
- `RiziaDLC.Resources_Military_Ships`
- `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed`
- `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Failed`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Weak`
- `RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport`
- `RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco`
- `RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF`
- `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn09_MorellaDerdiaMediation_Failed`
- `RiziaDLC.Turn09_MorellaDerdiaMediation_Success`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor`
- `RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline`
- `RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Policy_Economy_WehlenPipeline_Project`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_Manpower`
- `RiziaDLC.Resources_Military_Ships`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.Turn09_DerdiaWehlenMediation_Failed`
- `RiziaDLC.Turn09_DerdiaWehlenMediation_Success`
- `RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor`
- `RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline`
- `RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute`
- `RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Failed`
- `RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimCorridor`
- `RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimSeaRoute`
- `RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Pipeline`
- `RiziaDLCSupport.News_Turn09_G_DerdiaWehlenOil`
- `RiziaDLCSupport.News_Turn09_G_PrayerCorridorBoth`
- `RiziaDLCSupport.News_Turn09_G_PrayerCorridorDerdia`
- `RiziaDLCSupport.News_Turn09_G_PrayerSeaRoute`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[438] Rizia/Turn 9/Pabel Extradition** (../Turn_09/438_Pabel_Extradition.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 27
- **Węzły modyfikujące stan gry:** 26

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Policy_Economy_WehlenPipeline_Project`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[42]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_Nego...`
- Węzeł `[179]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] = true;`
- Węzeł `[180]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] = true;`
- Węzeł `[181]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] = true;`
- Węzeł `[216]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1; Variable["Rizi...`
- Węzeł `[217]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower...`
- Węzeł `[218]` (Paskal Beniwoll): `Variable["RiziaDLC.Resources_Military_Ships"] = Variable["RiziaDLC.Resources_Military_Ships"] - 1...`
- Węzeł `[219]` (Paskal Beniwoll): `Variable["RiziaDLC.Policy_Economy_WehlenPipeline_Project"] = true; Variable["RiziaDLCSupport.Jour...`
- *...oraz 18 innych węzłów ze skryptami.*

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `438` (*Rizia/Turn 9/Pabel Extradition*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true || RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true || RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true  or  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true || RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true  or  Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Wiktor Smolak, Jorga Azmal and a handful of their ministers joined us around the conference table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Narrator**
> "A short while later, we reconvened with Jorga Azmal around the table. This time, we were joined by Wiktor Smolak and his entourage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Laurento Esquibel**
> ""Gentlemen. I know it has been historically difficult for Wehlen and Derdia to find common ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Smolak opened his arms wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Wiktor Smolak (R)**
> ""I have no idea what you mean, Mr. Esquibel. Derdians are always welcome in my republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Wiktor Smolak (R)**
> ""Or they would be, were it not for their troublesome associations with the Bludish Freedom Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_BFF_ThreatEliminated == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_BFF_ThreatEliminated == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Order_BFF_ThreatEliminated == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Jorga Azmal**
> ""The same Bludish Freedom Front that your cruel military operation all but eliminated?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Jorga Azmal**
> ""We understand the BFF has caused problems for you in the past. But we feel for the innocent Bluds who got caught in the crossfire during your single-minded pursuit of the organization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[25]`
  - -> `[26]`
  - -> `[35]`

### Węzeł `[20]`
Mówca: **Jorga Azmal**
> ""With help from His Majesty, I might add.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[25]`
  - -> `[26]`
  - -> `[30]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true || RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Wehlen_Terrorism_AntiBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`
  - -> `[28]`
  - -> `[35]`

### Węzeł `[24]`
Mówca: **Jorga Azmal**
> ""A pursuit aided by His Majesty, I might add.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`
  - -> `[28]`
  - -> `[30]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you or have you not been harboring BFF terrorists within your borders, Azmal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The BFF are not true Golcondists, Supreme Wiseman. They're mere puppets of superpowers who want to destabilize Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, President Smolak, you can't use the BFF as justification for animosity towards Derdia now that they no longer pose a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You cannot wave away the threat that the BFF still poses to Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[29]`
Mówca: **Jorga Azmal**
> ""We give shelter to Golcondists in need. We keep no record of their pasts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did find Operation Bear Trap rather over the top, President Smolak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
Mówca: **Jorga Azmal**
> ""So many Golcondists have died. Am I wrong in fearing that Derdia will be next?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[32]`
Mówca: **Jorga Azmal**
> ""As I said at the Alliance of Nations, there is only one superpower that I believe in. And He has blessed the Bluds on their holly mission.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[33]`
Mówca: **Jorga Azmal**
> ""Nor can we condemn our fellow Golcondists for fighting for their beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Jorga Azmal**
> ""Over the top?! That's all the criticism the King of Rizia can manage?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Operation Bear Trap raised alarms for us here in Rizia as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Jorga Azmal**
> ""Yet not enough for you to cut ties with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Narrator**
> "Laurento tapped on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Laurento Esquibel**
> ""The BFF is a volatile topic. Which is precisely why we should not be talking about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Laurento Esquibel**
> ""Let us focus instead on what Derdia and Wehlen can do for each other, and what the Kingdom of Rizia can do for you both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Both men were silent. They nodded warily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Laurento Esquibel**
> ""A longstanding point of contention has been Derdians gaining passage to Deyr in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[47]`
  - -> `[55]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's in Deyr again?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why has Wehlen been blocking the Derdians on their holy pilgrimage, President Smolak?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Wiktor Smolak (R)**
> ""The Archsanctuay of Deyr is first and foremost a Dastnurist site, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, yes. Our most holy of holy sites.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Azmal nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Azmal and Smolak gave me flabbergasted stares."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Jorga Azmal**
> ""It is our holiest of holy sites, Your Majesty. Where God delivered His message to Saint Dast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[53]`
Mówca: **Jorga Azmal**
> ""The Archsanctuary of Deyr is where Nurity as a whole came to be. Every true believer must visit it at least once, no matter their denomination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[54]`
Mówca: **Jorga Azmal**
> ""Yet it is said that every true believer in Nurity must visit it at least once. Wruhecists included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It sounds like that's a problem for the Sords, not the Rizians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Wiktor Smolak (R)**
> ""I wish it were that easy. My friend Anton would solve this in an instant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Wiktor Smolak (R)**
> ""Except that Derdians must pass through Wehlen to reach Deyr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[61]`
Mówca: **Wiktor Smolak (R)**
> ""It is the site of God's descension to Saint Dast. And therefore of particular importance to Dastnurists, not Wruhecists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[62]`
Mówca: **Wiktor Smolak (R)**
> ""Hmm. It's funny how your beloved St. Wruhec didn't come up once in that description.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[63]`
Mówca: **Jorga Azmal**
> ""Your 'friend' couldn't even get the Descension Day ceremony right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_R_RitualFailed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_R_RitualFailed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameSupport.News_Turn07_R_RitualFailed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameSupport.News_Turn07_R_RitualFailed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameSupport.News_Turn07_R_RitualFailed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Jorga Azmal**
> ""And why should I trust a man who harbors the same murderous intentions as you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Jorga Azmal**
> ""If there was another way to get there, we would use it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Deyr solutions)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[108]`
  - -> `[176]`
  - -> `[183]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Derdians don't have to pass through Wehlen to reach Deyr. We could help them find a sea route.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[71]`
Mówca: **Laurento Esquibel**
> ""Yes, I've looked into the possibility. It would go from Yol through the Sudis Sea all the way around to Lachaven.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Laurento Esquibel**
> ""Sordland would have to agree to it. But we're on good terms with them right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Sordland_Friendly == true || RiziaDLC.CountryRelation_Sordland_Allied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Sordland_Friendly == true || RiziaDLC.CountryRelation_Sordland_Allied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Sordland_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Sordland_Allied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Sordland_Friendly == true || RiziaDLC.CountryRelation_Sordland_Allied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Sordland_Friendly"] == true  or  Variable["RiziaDLC.CountryRelation_Sordland_Allied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Laurento Esquibel**
> ""The problem is that Sordland would have to agree with it. And we're not on the best of terms right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Ships >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Ships >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Ships"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_Ships >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Ships"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Laurento Esquibel**
> ""And we can supply the ships ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[81]`
Mówca: **Laurento Esquibel**
> ""The problem is that we don't have enough ships to spare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your corridor solution worked with Morella, Laurento. Can we not do the same thing with Wehlen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's get creative. There must be something that Wehlen would accept in exchange for allowing Derdians through to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Laurento, your corridor solution may not have worked with Morella, but could it work with Wehlen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Laurento Esquibel**
> ""It might.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Laurento Esquibel**
> ""President Smolak, His Majesty is referring to the creation of a secure corridor through Wehlen. Derdian pilgrims would be able to pass into Sordland using this route and this route only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[93]`
Mówca: **Wiktor Smolak (R)**
> ""Keeping your Golcondists from fraternizing with ours. Yes, I like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[94]`
Mówca: **Jorga Azmal**
> ""It has yet to be implemented in Morella. But I have high hopes for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Jorga Azmal**
> ""I did not agree to the idea before, and I do not understand why it is being proposed again now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Derdia_NegotiatingPower < 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] < 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Wiktor Smolak (R)**
> ""Sounds like a ringing endorsement, Supreme Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[103]`
Mówca: **Jorga Azmal**
> ""Prime Minister Saltana did not agree to the idea. I myself was open to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Deyr solutions])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if Rizia oversees the security of some kind of prayer corridor through Wehlen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Laurento Esquibel**
> ""Yes, that's one idea my department had.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Laurento Esquibel**
> ""We would plot a route through Wehlen known as 'St. Wruhec's Corridor'. Derdian pilgrims would be able to pass into Sordland using this route and this route only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower > 250)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower > 250)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Manpower"] > 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_Manpower > 250))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Manpower"] > 250) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Laurento Esquibel**
> ""Unfortunately, we can't spare the military manpower to ensure the security of the route.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[121]`
Mówca: **Laurento Esquibel**
> ""We have the military manpower to make sure the route is secure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[122]`
Mówca: **Laurento Esquibel**
> ""Rizia would be responsible for the route's security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Jorga Azmal**
> ""So long as your forces were able to keep Wehlen from blocking our journey, I would agree to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[127]`
Mówca: **Laurento Esquibel**
> ""Or we can contract an independent security company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[128]`
Mówca: **Laurento Esquibel**
> ""But we have the budget to contract an independent security company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[129]`
Mówca: **Wiktor Smolak (R)**
> ""Well... yes, there is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Wiktor Smolak (R)**
> ""We want Derdia to buy our oil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Wiktor Smolak (R)**
> ""We are still suffering the effects of the GRACE embargo on us, among other sanctions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Wiktor Smolak (R)**
> ""We have been the subject of unfair sanctions. But we have plenty of energy to spare for the right customer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Jorga Azmal**
> ""It is no secret that Derdia needs energy, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Jorga Azmal**
> ""All the more so since Rizia failed to deliver on its energy promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[141]`
Mówca: **Wiktor Smolak (R)**
> ""Ha! That's Rizia for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Wehlen_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Derdia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[148]`
Mówca: **Jorga Azmal**
> ""Although not as much as we used to, thanks to our recent deal with Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My kingdom would be very happy to supply the expertise and infrastructure for an oil pipeline between your two nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[150]`
Mówca: **Jorga Azmal**
> ""But we cannot afford the infrastructure that such an agreement would require.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[151]`
  - -> `[153]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you could supply Wehlen with missiles to raise the needed funds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Wiktor Smolak (R)**
> ""No offense, Your Majesty, but Wehlen has no need for Derdian missiles. Have you seen our arsenal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Wehlen is so desperate to sell oil, they should pay for the pipeline themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[157]`
Mówca: **Wiktor Smolak (R)**
> ""I can agree to fund part of it. But not all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[158]`
Mówca: **Wiktor Smolak (R)**
> ""Wehlen will also happily chip in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Laurento Esquibel**
> ""Between our two nations, we can definitely afford this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[166]`
Mówca: **Laurento Esquibel**
> ""Even then, I am not certain Rizia can afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Laurento Esquibel**
> ""We can definitely afford that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[171]`
Mówca: **Laurento Esquibel**
> ""I am not certain Rizia can afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[172]`
Mówca: **Laurento Esquibel**
> ""Unfortunate. It could've been a pivotal step forward in the South Merkopan alliance we are building.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[173]`
Mówca: **Laurento Esquibel**
> ""Such a deal could be a pivotal step forward in the South Merkopan alliance we are building.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[174]`
Mówca: **Laurento Esquibel**
> ""Your Majesty, Rizia should consider funding this pipeline. If we can afford it, that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[175]`
Mówca: **Wiktor Smolak (R)**
> ""If we were that desperate, Your Majesty, you would have had Zille back five years ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here is my solution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == true || RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == true || RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == true || RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == true || RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] == true  or  Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] == true  or  Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline == true || RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor == true || RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Pipeline"] == true  or  Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_Corridor"] == true  or  Variable["RiziaDLCIsolated.Turn09_WehlenDerdia_SeaRoute"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
Mówca: **Narrator**
> "Both Azmal and Smolak leaned forward to listen to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[192]`
  - -> `[195]`
  - -> `[199]`
  - -> `[204]`
  - -> `[208]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3  and  Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3  and  Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[190]`
**[WYBÓR GRACZA: ""We will fund a secure prayer corridor from Derdia through Wehlen to Sordland." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""We will fund a secure prayer corridor from Derdia through Wehlen to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[191]`
**[WYBÓR GRACZA: ""We will send troops to oversee the security of a Golcondist prayer corridor through Wehlen." [-250 Manpower]"]** — Mówca: **Player_Romus**
> ""We will send troops to oversee the security of a Golcondist prayer corridor through Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaDLC.Resources_Military_Manpower > 250)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaDLC.Resources_Military_Manpower > 250)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3  and  Variable["RiziaDLC.Resources_Military_Manpower"] > 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3 && RiziaDLC.Resources_Military_Manpower > 250))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3  and  Variable["RiziaDLC.Resources_Military_Manpower"] > 250) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Ships >= 1 && RiziaDLC.CountryRelation_Sordland_Friendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Ships >= 1 && RiziaDLC.CountryRelation_Sordland_Friendly == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Ships"] >= 1  and  Variable["RiziaDLC.CountryRelation_Sordland_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Military_Ships >= 1 && RiziaDLC.CountryRelation_Sordland_Friendly == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Ships"] >= 1  and  Variable["RiziaDLC.CountryRelation_Sordland_Friendly"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[198]`
**[WYBÓR GRACZA: ""We will create a sea route for Golcondist pilgrims to reach Sordland without having to cross into Wehlen." [-1 Ships]"]** — Mówca: **Player_Romus**
> ""We will create a sea route for Golcondist pilgrims to reach Sordland without having to cross into Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true && RiziaDLC.Resources_Budget >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true && RiziaDLC.Resources_Budget >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  and  Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport == true && RiziaDLC.Resources_Budget >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Rumburg_HighEnergyExport"] == true  and  Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[202]`
**[WYBÓR GRACZA: ""Together with Wehlen, we will fund an oil pipeline between Wehlen and Derdia. A secure Derdian pilgrimage route will be a condition for this new energy partnership." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Together with Wehlen, we will fund an oil pipeline between Wehlen and Derdia. A secure Derdian pilgrimage route will be a condition for this new energy partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[203]`
**[WYBÓR GRACZA: ""We will fund an oil pipeline between Wehlen and Derdia. A secure Derdian pilgrimage route will be a condition for this new energy partnership." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""We will fund an oil pipeline between Wehlen and Derdia. A secure Derdian pilgrimage route will be a condition for this new energy partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your nations must practice trust and cooperation. Remember, we all pray to the same God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You must fight a Derdian Duel of Generosity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Narrator**
> "Wiktor Smolak's eyes lit up with glee. He stood up and started punching the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Wiktor Smolak (R)**
> ""I've always wanted to do one of these! Will you be your own champion, Supreme Wiseman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Jorga Azmal**
> ""No! Both of you will stop insulting myself and my religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[316]`
  - -> `[305]`
  - -> `[304]`

### Węzeł `[212]`
Mówca: **Narrator**
> "Neither of them looked satisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Wiktor Smolak (R)**
> ""We didn't need to come to Rizia to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Jorga Azmal**
> ""This was a waste of both of our time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[316]`
  - -> `[305]`
  - -> `[304]`

### Węzeł `[215]`
Mówca: **Wiktor Smolak (R)**
> ""Wehlen accepts, Your Majesty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1; RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimCorridor = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimCorridor"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Manpower -= 250; RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimCorridor = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] - 250;
Variable["RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimCorridor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Military_Ships -= 1; RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimSeaRoute = true; RiziaDLCSupport.News_Turn09_G_PrayerSeaRoute = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Military_Ships"] = Variable["RiziaDLC.Resources_Military_Ships"] - 1;
Variable["RiziaDLCSupport.Journal_Turn09_WehlenDerdia_PilgrimSeaRoute"] = true;
Variable["RiziaDLCSupport.News_Turn09_G_PrayerSeaRoute"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_WehlenPipeline_Project = true; RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Pipeline = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_Economy_WehlenPipeline_Project"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Pipeline"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Economy_WehlenPipeline_Project = true; RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Pipeline = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Policy_Economy_WehlenPipeline_Project"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Pipeline"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[224]`
Mówca: **Jorga Azmal**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[226]`
  - -> `[225]`
  - -> `[337]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will shake hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thank the Lord for watching over today's talks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Wehlen_ImportTobacco"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now bring the khisha.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[231]`
Mówca: **Wiktor Smolak (R)**
> ""Hrm. That's the best you can do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[236]`
  - -> `[240]`

### Węzeł `[232]`
**[WYBÓR GRACZA: ""It is. Take it or leave it." [-1 Authority]"]** — Mówca: **Player_Romus**
> ""It is. Take it or leave it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[239]`
**[WYBÓR GRACZA: ""If it helps, Rizia will allocate additional funding towards the project." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""If it helps, Rizia will allocate additional funding towards the project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unfortunately, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[243]`
Mówca: **Wiktor Smolak (R)**
> ""Hrm. That's the best you can do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[248]`
  - -> `[240]`

### Węzeł `[244]`
**[WYBÓR GRACZA: ""It is. Take it or leave it." [-1 Authority]"]** — Mówca: **Player_Romus**
> ""It is. Take it or leave it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[251]`
**[WYBÓR GRACZA: ""If it helps, Rizia will allocate additional funding towards the project." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""If it helps, Rizia will allocate additional funding towards the project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[257]`
Mówca: **Wiktor Smolak (R)**
> ""Hrm. That's the best you can do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[262]`
  - -> `[240]`

### Węzeł `[258]`
**[WYBÓR GRACZA: ""It is. Take it or leave it." [-1 Authority]"]** — Mówca: **Player_Romus**
> ""It is. Take it or leave it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[265]`
**[WYBÓR GRACZA: ""If it helps, Rizia will allocate additional funding towards the project." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""If it helps, Rizia will allocate additional funding towards the project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[271]`
Mówca: **Wiktor Smolak (R)**
> ""Hrm. That's the best you can do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[276]`
  - -> `[240]`

### Węzeł `[272]`
**[WYBÓR GRACZA: ""It is. Take it or leave it." [-1 Authority]"]** — Mówca: **Player_Romus**
> ""It is. Take it or leave it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 1 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 1 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 1  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority >= 1 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 1  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[279]`
**[WYBÓR GRACZA: ""If it helps, Rizia will allocate additional funding towards the project." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""If it helps, Rizia will allocate additional funding towards the project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[285]`
Mówca: **Wiktor Smolak (R)**
> ""Hrm. That's the best you can do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[290]`
  - -> `[240]`

### Węzeł `[286]`
**[WYBÓR GRACZA: ""It is. Take it or leave it." [-2 Authority]"]** — Mówca: **Player_Romus**
> ""It is. Take it or leave it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 2 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 2 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 2  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority >= 2 && RiziaDLC.Situation_Diplomacy_PowerProjection_Weak == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 2  and  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Weak"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[293]`
**[WYBÓR GRACZA: ""If it helps, Rizia will allocate additional funding towards the project." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""If it helps, Rizia will allocate additional funding towards the project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[299]`
Mówca: **Narrator**
> "They both shook their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Wiktor Smolak (R)**
> ""Then our efforts today were in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Jorga Azmal**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[316]`
  - -> `[305]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry Rizia could not have been more helpful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope this will not impact our efforts to form the South Merkopan Alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was nonetheless a pleasure to see you both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you can still assure us a safe return of the Zille territory, Mr. Smolak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[312]`
Mówca: **Jorga Azmal**
> ""Your willingness to help Derdia and Morella shows that your efforts are in good faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[313]`
Mówca: **Jorga Azmal**
> ""Two failed mediations in one day? That is truly not a good omen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[314]`
Mówca: **Wiktor Smolak (R)**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Wiktor Smolak (R)**
> ""A deal with Derdia would have been a mere bonus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Intermerkopum_Efforts == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[319]`
Mówca: **Wiktor Smolak (R)**
> ""It's not your fault, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[320]`
Mówca: **Wiktor Smolak (R)**
> ""Anytime, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[327]`
Mówca: **Jorga Azmal**
> ""I thank you nonetheless for your help with Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[328]`
Mówca: **Jorga Azmal**
> ""Two failed mediations in one day. The Lord has not blessed Rizia with the gift of diplomacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_DerdiaWehlenMediation_Success = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_DerdiaWehlenMediation_Failed = true; RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Failed = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn09_DerdiaWehlenMediation_Failed"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_WehlenDerdia_Failed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[331]`
Mówca: **Jorga Azmal**
> ""We will see about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[332]`
Mówca: **Jorga Azmal**
> ""You have both failed the Golcondists. You will be judged poorly for it at the end of your days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[333]`
Mówca: **Narrator**
> "Smolak eagerly reached out his hand. Azmal shook it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[334]`
Mówca: **Narrator**
> "A Wehzek khisha pipe was standing in the corner of the room. An aide moved it to our table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Wiktor Smolak (R)**
> ""How thoughtful of Your Majesty! But I really must be going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[336]`
Mówca: **Jorga Azmal**
> ""Praise be to He who unites the universe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Intermerkopum_Efforts == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope this means I can count on both of your countries' cooperation in the formation of a South Merkopan alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Wiktor Smolak (R)**
> ""Very gladly. Together, we will make Rumburg regret its decision to mess with us!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[342]`
Mówca: **Wiktor Smolak (R)**
> ""Such modesty. All praise must go to King Romus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[343]`
Mówca: **Wiktor Smolak (R)**
> ""I'm up to my elbows in paperwork for the Zille transition. My citizens have so many concerns. You know how it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`
  - -> `[348]`

### Węzeł `[344]`
Mówca: **Narrator**
> "Laurento swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[345]`
Mówca: **Wiktor Smolak (R)**
> ""Now. I must be going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to that day, President Smolak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You had better not be planning any last-minute surprises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rest assured that Rizia shall make the transition as smooth as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[349]`
Mówca: **Wiktor Smolak (R)**
> ""Me? Never.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Narrator**
> "He bowed and left the suite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[351]`
Mówca: **Wiktor Smolak (R)**
> ""There is no doubt in my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_MorellaDerdiaMediation_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Jorga Azmal**
> ""I am truly grateful for all your help today, Your Majesty. Thanks to Rizia, the great Republic of Derdia shall finally be brought out of isolation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[363]`
  - -> `[364]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[358]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[360]`
Mówca: **Jorga Azmal**
> ""I am truly grateful for your help today, Your Majesty. I would never have thought Wehlen would be a more cooperative partner than Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[365]`
  - -> `[363]`

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Life is full of surprises, Supreme Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[362]`
Mówca: **Jorga Azmal**
> ""I am grateful for your help today, Your Majesty. Thanks to Rizia, the great Republic of Derdia shall finally be brought out of isolation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[363]`
  - -> `[364]`

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, we shall take on the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was my pleasure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wiktor is an unusual fellow. But he holds true to his word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[366]`
Mówca: **Wiktor Smolak (R)**
> ""I'm up to my elbows in paperwork for the Zille transition. My citizens have so many concerns. You know how it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`
  - -> `[369]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to that day, President Smolak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You had better not be planning any last-minute surprises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rest assured that Rizia shall make the transition as smooth as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[370]`
Mówca: **Wiktor Smolak (R)**
> ""Me? Never.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Narrator**
> "He bowed as Laurento escorted him out of the suite. I sat alone with Azmal for a long minute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[372]`
Mówca: **Wiktor Smolak (R)**
> ""There is no doubt in my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[373]`
Mówca: **Wiktor Smolak (R)**
> ""Sorry to cut this party short, but I really must be going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[377]`
Mówca: **Wiktor Smolak (R)**
> ""I'm working hard to conclude our agreed-upon transfer for Zille. There are a few paperwork challenges left but all is going splendidly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`
  - -> `[348]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[380]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn09_MorellaDerdiaMediation_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn09_G_PrayerCorridorBoth = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_G_PrayerCorridorBoth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn09_G_PrayerCorridorDerdia = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_G_PrayerCorridorDerdia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn09_G_DerdiaWehlenOil = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_G_DerdiaWehlenOil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Intermerkopum_Efforts == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Intermerkopum_Efforts == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Laurento Esquibel**
> ""Unfortunate. But surely there's another way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[391]`
Mówca: **Laurento Esquibel**
> ""Brokering a connection between Wehlen and Derdia could be beneficial for everyone involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddTokenStatusImmediately("Rizia_Country_Wehlen", "Progress_Construction_WehlenPipeline");
ScheduleProgress("Progress_Construction_WehlenPipeline", 1);)*
- **Efekt (`userScript`):** `AddTokenStatusImmediately("Rizia_Country_Wehlen","Progress_Construction_WehlenPipeline");
ScheduleProgress("Progress_Construction_WehlenPipeline", 1);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
