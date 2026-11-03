# Rizia/Turn 10/AxelVina_Unity

- **ID konwersacji:** `331`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/331_AxelVina_Unity.md`
- **Liczba węzłów dialogowych:** 620
- **Liczba wyborów gracza:** 129

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Rumburg_War`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.BirthdayGathering_ViolentAction`
- `RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike`
- `RiziaDLC.Birthday_WarnedAboutCoup`
- `RiziaDLC.Diplomacy_Pales_GRACEApplication`
- `RiziaDLC.Ending_Coup_Azaro`
- `RiziaDLC.Ending_Coup_Sazon`
- `RiziaDLC.Ending_Coup_Toras`
- `RiziaDLC.Ending_Revolution`
- `RiziaDLC.HouseAzaro_Conquered`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.HouseToras_Conquered`
- `RiziaDLC.Intermerkopum_Failed`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP`
- `RiziaDLC.Policy_Diplomacy_GRACEMember`
- `RiziaDLC.Policy_Diplomacy_Intermerkopum`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.PromiseToAbdicate`
- `RiziaDLC.Promised_Succession_Son_RespectTradition`
- `RiziaDLC.Reform_Regions_Centralized`
- `RiziaDLC.Reform_Success`
- `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLC.Situation_Law_RoyalTraditions_Broken`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Situation_Order_ViolentProtests_Valenqiris`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vendonesam_Lose`
- `RiziaDLC.Vina_KeepsLastName`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCIsolated.AxelConcerned`
- `RiziaDLCIsolated.Turn10_PalesReunification_NoDrink`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLC.PersonalValue_Drinking`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Said_GlovuriusAxaRizia`
- `RiziaDLC.Said_Halaita`
- `RiziaDLCIsolated.AxelConcerned`
- `RiziaDLCIsolated.Turn10_PalesReunification_NoDrink`
- `RiziaDLCSupport.Codex_Locations_Countries_Pales`
- `RiziaDLCSupport.Codex_Locations_Regions_PAD`
- `RiziaDLCSupport.FactionReports_Turn10_GRACE_Decision_Unification_Agree`
- `RiziaDLCSupport.News_Turn09_G_Decision_Unification_Agree`
- `RiziaDLCSupport.News_Turn09_RH_Decision_Unification_Agree`
- `RiziaDLCSupport.Reports_Turn09_Sordland_Decision_Unification_Agree`
- `RiziaDLCSupport.Reports_Turn10_Pales_Peace`
- `RiziaDLCText.GRACECountries`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 15
- **Węzły modyfikujące stan gry:** 47

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLCIsolated.Turn10_PalesReunification_NoDrink`
- `RiziaDLCSupport.Codex_Locations_Countries_Pales`
- `RiziaDLCSupport.Reports_Turn10_Pales_Peace`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[60]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`
- Węzeł `[149]` (Paskal Beniwoll): `--;`
- Węzeł `[150]` (Paskal Beniwoll): `--;`
- Węzeł `[153]` (Paskal Beniwoll): `--;`
- Węzeł `[159]` (Paskal Beniwoll): `--;`
- Węzeł `[177]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- Węzeł `[178]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- Węzeł `[179]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
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
  - -> `[356]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Failed == true || RiziaDLC.Policy_Diplomacy_Intermerkopum == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Failed == true || RiziaDLC.Policy_Diplomacy_Intermerkopum == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Failed"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Intermerkopum_Failed == true || RiziaDLC.Policy_Diplomacy_Intermerkopum == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Failed"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Since my daughter married him, the couple had been traveling constantly between Pales and Porte Drazon. The Palesian authorities were working hard with our government to realize our plans for unity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_KeepsLastName == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_KeepsLastName == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_KeepsLastName"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_KeepsLastName == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_KeepsLastName"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[10]`
Mówca: **Narrator**
> "The grand Rizia-Pales reunion was right around the corner. Preparations were complete, our teams were cooperating and the marriage between Vina and Axel seemed to be going well. It wasn't a distant dream anymore."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "The only thing that was left was Duke Reinhart's complete approval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[12]`
Mówca: **Narrator**
> "On one of their visits, we decided to take a break and visit my hometown in Monqiz."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[13]`
Mówca: **Narrator**
> "We were on the picturesque beach of Monqiz, sitting in front of a cafe run by distant Toras relatives in a secluded corner of the sandy shores."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[14]`
Mówca: **Axel Reinhart**
> ""It's refreshing being here, away from the court's rigidity. Life's simpler rhythms have a charm of their own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[15]`
Mówca: **Narrator**
> "We were on the picturesque beach of Monqiz, sitting in front of a cafe run by distant Toras relatives in a secluded corner that hadn't been invaded by Sordish tourists yet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[19]`
Mówca: **Narrator**
> "My eyes were on Vina as she was taking a stroll on the beach, talking to the locals she encountered. She seemed to be immensely popular here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`
  - -> `[23]`
  - -> `[24]`

### Węzeł `[20]`
Mówca: **Axel Reinhart**
> ""Tremendously, actually. We both think this was the right decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, Axel. Well said.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at her, Axel. I feel like she's more at home here than in any palace or court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me. Is the marriage faring well?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm glad everything is going great between the two of you. I hope it stays that way for your sake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
Mówca: **Axel Reinhart**
> ""Of course we're still working out the particulars of our marriage arrangement. But we make a good team, Vina and I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
Mówca: **Axel Reinhart**
> ""Perhaps so. She definitely has a spirit too vast for the confines of stone walls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[27]`
Mówca: **Axel Reinhart**
> ""You need not worry. Really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[28]`
Mówca: **Axel Reinhart**
> ""To be honest, I don't think I could manage the preparations for our reunion without her help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[32]`
  - -> `[31]`
  - -> `[360]`

### Węzeł `[29]`
Mówca: **Axel Reinhart**
> ""To be honest, it's your daughter who's given me a fresh perspective on life these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not surprised to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep her close to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to know, Axel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Just then, the waiter of the cafe approached us to ask what we would like to drink. Axel turned to him and spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[40]`
Mówca: **Narrator**
> "The waiter quickly brought a bottle of Erlory Maroon whiskey as a recommendation, and started talking about how smoky and delicious it was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[41]`
Mówca: **Axel Reinhart**
> ""What is the recommendation of the house?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[42]`
Mówca: **Narrator**
> "The waiter quickly brought over a bottle of Lespian wine, 'Chateau de Falenco 1934', and started talking about its complex flavors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[43]`
Mówca: **Narrator**
> "The waiter quickly brought a bottle of Cantuavo as his recommendation, and started talking about its exquisite taste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[47]`
Mówca: **Axel Reinhart**
> ""Cantuavo? Oh, yes, please. Rizians know how to make their wine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[48]`
Mówca: **Axel Reinhart**
> ""Lespian wine in Rizia? What has the world come to?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
Mówca: **Axel Reinhart**
> ""With all due respect, in all my years working with Lespia, I've had enough of that. I'd prefer something authentically Rizian. Cantuavo, perhaps?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[50]`
Mówca: **Narrator**
> "He laughed as he dismissed the bottle with a wave of his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[51]`
Mówca: **Narrator**
> "The waiter quickly explained it was the main choice of the wealthy Sordish tourists who visited the area."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Axel Reinhart**
> ""Oh, of course. Only a northerner with no culture would look at Lespian products and think they're fancy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[53]`
Mówca: **Axel Reinhart**
> ""Oh, I don't want whiskey. If I wanted hard liquor, I'd go with something Valgish or Galmish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "He laughed as he dismissed the bottle with a wave of his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Axel Reinhart**
> ""I'll have a Cantuavo, if you have any.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Narrator**
> "He looked at me to see if I would have the same."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[154]`
  - -> `[57]`
  - -> `[58]`
  - -> `[59]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An excellent choice. I'll have the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll just have water. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, but I'm not thirsty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValues_FellOffWagon = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[61]`
Mówca: **Narrator**
> "The waiter nodded and brought us our drinks a few minutes later."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Narrator**
> "The waiter nodded and brought Axel's drink a few minutes later."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[63]`
Mówca: **Axel Reinhart**
> ""Cheers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Axel Reinhart**
> ""Tell me... Are your family and the other royal houses really fine with your heirs bearing the Reinhart name?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`
  - -> `[70]`
  - -> `[71]`

### Węzeł `[65]`
Mówca: **Narrator**
> "We clinked our glasses and took a sip from our drinks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[66]`
Mówca: **Narrator**
> "He raised his glass and then took a sip from it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[67]`
Mówca: **Axel Reinhart**
> ""You know... My brother is quite mad about my decision to go along with this marriage. He thinks I've betrayed House Reinhart by giving my name away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course they're fine with it. Because they have to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They were fine with the marriage, weren't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Their opinions don't really matter. What matters is your union with Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Heirs? Do you and Vina have something to tell me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[72]`
Mówca: **Axel Reinhart**
> ""I hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[73]`
Mówca: **Axel Reinhart**
> ""I guess they were.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[74]`
Mówca: **Axel Reinhart**
> ""Let alone all these talks of 'reunification'. It's making my family quite hostile towards me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`
  - -> `[77]`
  - -> `[78]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think your brother will be a problem?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you saying they're trying to block your efforts?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know how difficult it is to go against your own family, Axel. And you still did. I respect that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you having second thoughts now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[79]`
Mówca: **Narrator**
> "He let out a short laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Axel Reinhart**
> ""He had his chance to rule. If he hadn't taken the coward's way out, none of this would be happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Axel Reinhart**
> ""Njolma's not the boss of me. I won't let this affect our cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[82]`
Mówca: **Axel Reinhart**
> ""Oh, they tried. But most of them don't even hold government positions anymore, the lazy bastards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[83]`
Mówca: **Axel Reinhart**
> ""No, not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Axel Reinhart**
> ""I'm just stating the obvious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[85]`
Mówca: **Axel Reinhart**
> ""Thank you. It is tough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[86]`
Mówca: **Narrator**
> "He took a large sip from his glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[87]`
Mówca: **Axel Reinhart**
> ""Tell me, how have your reforms been working out for Rizia? I see that the new government is already preparing for its first elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseOfDelegates_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[97]`
Mówca: **Axel Reinhart**
> ""I am more concerned about the Rizian side of the equation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true || RiziaDLC.Theocracy_Full == true || RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true || RiziaDLC.Theocracy_Full == true || RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true  or  Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Success == true || RiziaDLC.Theocracy_Full == true || RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true  or  Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[101]`
Mówca: **Axel Reinhart**
> ""I'm just trying to wrap my head around the dynamics here in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[102]`
Mówca: **Axel Reinhart**
> ""And how is this new religious rule of law faring for Rizia? It's a very different kingdom than when our negotiations began.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`
  - -> `[117]`

### Węzeł `[103]`
Mówca: **Axel Reinhart**
> ""That was a drastic change. Abolishing the power of your council and empowering the parliament just like that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`
  - -> `[106]`
  - -> `[107]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not so fond of the new charter myself, but I had to do it for the Rizian people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Times are changing, Axel. The days of kings leading armies on the battlefields are long gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Axel. I had to take a lot of risks for this charter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was. The question is, do you respect that system yourself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Axel Reinhart**
> ""Yes, of course. Governing Rizia is a much larger task than of Pales. I can't even imagine having direct control over such a large swath of land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[109]`
Mówca: **Axel Reinhart**
> ""And how is the abolishment of your House of Delegates working out? You've taken quite a risk with that decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`
  - -> `[112]`
  - -> `[113]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did what I had to do to keep Rizia running smoothly. The Delegates were only slowing us down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't believe in their function, Axel. I'm just undoing the mistakes of my father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Axel. It was the right thing to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did indeed. The question is, do you have a problem with that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Cosmetic changes only, Your Grace. Nothing to be concerned about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe in enforcing the Divine's laws, Axel. I'm doing this for God and Rizian people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is only beginning its transformation. I fully expect Pales to become part of our holy dominion as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you have a problem with that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Narrator**
> "He smiled nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[119]`
Mówca: **Axel Reinhart**
> ""No problem at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[120]`
Mówca: **Axel Reinhart**
> ""Oh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[121]`
Mówca: **Axel Reinhart**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Axel Reinhart**
> ""May the Divine bless you, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`
  - -> `[125]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me, Axel. Would you consider yourself a devout Wruhecist?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[126]`
Mówca: **Axel Reinhart**
> ""And how are you, Your Majesty? It's been a while since we last had a personal talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[127]`
  - -> `[128]`
  - -> `[129]`
  - -> `[130]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, son. We'll have all our lives to have many more of these talks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm fine, thank you. A lot going on, as you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like talking about my personal life, Axel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I may be honest with you, the recent unrest has been quite taxing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Azaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Azaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Revolution"] == true  or  Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Ending_Coup_Sazon"] == true  or  Variable["RiziaDLC.Ending_Coup_Azaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Azaro == true  ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Revolution"] == true  or  Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Ending_Coup_Sazon"] == true  or  Variable["RiziaDLC.Ending_Coup_Azaro"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would be a lie if I'd said everything is great. But you know how it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Axel Reinhart**
> ""Yes. I understand it well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[139]`
Mówca: **Axel Reinhart**
> ""That we do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[140]`
Mówca: **Axel Reinhart**
> ""I'm glad to hear that. Really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[141]`
Mówca: **Axel Reinhart**
> ""I suspected that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[142]`
Mówca: **Axel Reinhart**
> ""You've got to talk about yourself at some point, or the gossip columnists will do it for you. That's my take, at any rate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[143]`
Mówca: **Axel Reinhart**
> ""Hmm. You know best about these things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[144]`
Mówca: **Axel Reinhart**
> ""If you say so, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[145]`
Mówca: **Axel Reinhart**
> ""Oh, not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[146]`
Mówca: **Axel Reinhart**
> ""I couldn't imagine how hard it was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[147]`
Mówca: **Axel Reinhart**
> ""Absolutely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Axel Reinhart**
> ""Besides, governing Rizia is a much larger task than ruling Pales. I can't even imagine having direct control over such a large swath of land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[151]`
Mówca: **Axel Reinhart**
> ""Praise be to God, I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[152]`
Mówca: **Narrator**
> "He took a few seconds to deliberate over his answer. Finally, he smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do not partake in the vice of alcohol consumption.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Axel Reinhart**
> ""Uhm. As you wish. Then just the one glass of wine, please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true ||RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true ||RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true  or Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == true ||RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true  or Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Derteans 25:17, reads, and I quote, 'The path of the righteous man is beset on all sides by sinful temptations of intoxicants and debauchery. I warn you, that those who live like this will be refused to walk the path of Golconda.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Narrator**
> "He listened to me in shock as I recited the verse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Axel Reinhart**
> ""There's no text in Nurity that explicitly prohibits drinking alcohol, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[168]`
  - -> `[613]`
  - -> `[616]`
  - -> `[169]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is this going to be a sticking point, Your Grace? My plan is to purge our unified kingdom of all sin, alcohol included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are many passages warning against it. I choose to heed that warning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your interpretation is completely false and ungrounded. May God forgive your ignorance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. You can drink whatever you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I mean it, Axel. If you are to be with my daughter, you have to stop drinking and strive to follow the path of Enlightenment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Narrator**
> "He did not respond for a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Axel Reinhart**
> ""Uhm...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[173]`
Mówca: **Axel Reinhart**
> ""I understand. I'll just have a glass of water.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[174]`
Mówca: **Narrator**
> "He looked relieved and gestured at the waiter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[175]`
Mówca: **Axel Reinhart**
> ""Well, I choose not to. I'm sticking with my order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Narrator**
> "He then quickly gestured at the waiter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[182]`
Mówca: **Axel Reinhart**
> ""We haven't had much of a chance to talk about Intermerkopum yet, have we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Axel Reinhart**
> ""From what I'm hearing, few other countries expected such a bold move from Rizia, let alone Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[184]`
Mówca: **Axel Reinhart**
> ""May I ask you something?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[186]`
Mówca: **Axel Reinhart**
> ""But I think we're off to a very promising start. Although the Lespians are furious, as you can imagine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[193]`
  - -> `[188]`
  - -> `[187]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, I'd rather try to have a good relationship with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sooner or later, they will all have to realize and respect the power of Intermerkopum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Intermerkopum == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Intermerkopum == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_Intermerkopum == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Axel Reinhart**
> ""Lespia, for one, was immensely relieved when it didn't work out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[197]`
  - -> `[196]`
  - -> `[195]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What did you expect? We took their favorite toy away from them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. That means we are on the right track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, I'd rather try to have a good relationship with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't tell me you're thinking about crawling back to Alvarez.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you implying, Your Grace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That means we were on the right track. We'll try again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[199]`
Mówca: **Axel Reinhart**
> ""Alvarez should be the one trying to appease us now. Not the other way around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[200]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Axel Reinhart**
> ""We have make nice with Alvarez now, don't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[202]`
Mówca: **Axel Reinhart**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[204]`
Mówca: **Narrator**
> "He took another sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[208]`
Mówca: **Narrator**
> "On one of their visits, we decided to take a break and visit my hometown in Monqiz. Queen Consort Lucita joined us as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[212]`
Mówca: **Narrator**
> "My eyes were on Vina and Lucita strolling along the beach. My wife stood behind my daughter as locals stopped and approached the Princess. She seemed to be immensely popular here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`
  - -> `[23]`
  - -> `[24]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[216]`
Mówca: **Axel Reinhart**
> ""And how is your own marriage going, Your Majesty? Pregnancy suits the Queen Consort, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[364]`
  - -> `[363]`
  - -> `[499]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_GRACEMember == false ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[220]`
Mówca: **Axel Reinhart**
> ""So...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[221]`
Mówca: **Narrator**
> "He continued without waiting for my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[222]`
Mówca: **Axel Reinhart**
> ""Why would Rizia isolate itself from GRACE and Rumburg? It seems to me that you've lost your greatest support structure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[224]`
  - -> `[419]`
  - -> `[415]`

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, please. Rumburg and Rizia were never truly allies. The only thing keeping us together was a sham of an arranged marriage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rumburg is nothing but trouble, Axel. Rizia cannot afford to have such a close association with that kingdom anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It wasn't my choice. When Queen Beatrice got wind of our intention to form Intermerkopum, she gave us the boot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Intermerkopum_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Failed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see. Now that we can no longer get you into GRACE, you don't want to have anything to do with Rizia anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[230]`
Mówca: **Axel Reinhart**
> ""Isn't the Queen still your sister?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`
  - -> `[237]`

### Węzeł `[231]`
Mówca: **Axel Reinhart**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[232]`
Mówca: **Axel Reinhart**
> ""Like the marriage you just arranged for your daughter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[233]`
Mówca: **Axel Reinhart**
> ""I see. A very vindictive woman, your sister-in-law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you crazy? She's not my *sister*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She is my sister-in-law, which means nothing at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, yes. That's why I can afford to do this in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Intermerkopum == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Intermerkopum == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_Intermerkopum == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[242]`
Mówca: **Axel Reinhart**
> ""Fine. I get it. Excuse me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Intermerkopum == false && RiziaDLC.Policy_Diplomacy_GRACEMember == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Intermerkopum == false && RiziaDLC.Policy_Diplomacy_GRACEMember == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == false  and  Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_Intermerkopum == false && RiziaDLC.Policy_Diplomacy_GRACEMember == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == false  and  Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Revolution == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Revolution == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Revolution"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Revolution == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Revolution"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ViolentProtests_Valenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_ViolentProtests_Valenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ViolentProtests_Valenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_ViolentProtests_Valenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ViolentProtests_Valenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[254]`
Mówca: **Axel Reinhart**
> ""I'm surprised you never mentioned the true gravity of the situation around here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
Mówca: **Axel Reinhart**
> ""Well... Not just here but the entire country. Revolutionaries are getting quite massive and violent from what I've been reading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[260]`
  - -> `[261]`
  - -> `[262]`

### Węzeł `[256]`
Mówca: **Axel Reinhart**
> ""I'm surprised you've never mentioned the true gravity of the situation here in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[257]`
Mówca: **Axel Reinhart**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You shouldn't trust everything you read in the newspapers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[259]`
Mówca: **Axel Reinhart**
> ""Rizian revolutionaries have been getting quite massive, haven't they? Violent, even.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[260]`
  - -> `[261]`
  - -> `[262]`

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. It's quite worrying, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They can march wherever they want. The roads are not worn by walking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why does it concern you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Axel Reinhart**
> ""You know perfectly well why.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[264]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[265]`
Mówca: **Axel Reinhart**
> ""You're right about that one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Axel Reinhart**
> ""Just don't forget. The same roads may lead them to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Axel Reinhart**
> ""I seriously am concerned about the chaos, though. I'll be honest with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[268]`
Mówca: **Axel Reinhart**
> ""Oh, you're playing that card now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[270]`
Mówca: **Axel Reinhart**
> ""I want Vina to pause her regular travels back home until the danger is neutralized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[271]`
  - -> `[273]`
  - -> `[272]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why are you so concerned about this? There is no way Vina would be harmed here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It seems to me like you're looking for an excuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't understand, Axel. What unrest are you talking about? We are on a beach, and as you can see, everything is fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand, Axel. But that is for Vina to decide, not you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Axel Reinhart**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[276]`
Mówca: **Axel Reinhart**
> ""An excuse for what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[281]`
  - -> `[278]`
  - -> `[280]`
  - -> `[279]`

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To stop the reunification efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To leave Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To spend more time with Vina.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To go back on your promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
Mówca: **Axel Reinhart**
> ""I don't recall making any promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[283]`
Mówca: **Narrator**
> "He did not respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Axel Reinhart**
> ""You got me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Narrator**
> "He smiled and took another sip from his glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 3)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[287]`
Mówca: **Axel Reinhart**
> ""Either you are not being honest with me, or you are not aware of what's been happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Axel Reinhart**
> ""I didn't mean to criticize or offend you at all. But as this concerns both my wife and my Grand Duchy, I hope you can get the situation under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned < 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned < 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.AxelConcerned"] < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.AxelConcerned < 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.AxelConcerned"] < 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Axel Reinhart**
> ""Given some concerns of ours, as well as certain other changes that have occurred since my wedding to Princess Vina...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[293]`
Mówca: **Axel Reinhart**
> ""Tell me. Can I trust that Rizia will take care of Pales as its own and respect our unique culture?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[306]`
  - -> `[307]`

### Węzeł `[294]`
Mówca: **Axel Reinhart**
> ""I think it's time we strengthen our bonds and achieve this long-awaited reunification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Axel Reinhart**
> ""I've had some concerns, but in principle, I want to proceed with turning Rizia and Pales into a single kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Regions_Centralized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Regions_Centralized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[299]`
Mówca: **Axel Reinhart**
> ""One thing that bothers me, though, is the centralization of your regional system in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Axel Reinhart**
> ""If we were to be united, Palesian culture and traditions must be respected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Axel Reinhart**
> ""Tell me. Can I trust that Rizia will take care of Pales as its own while respecting us as a semi-autonomous region?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`
  - -> `[304]`
  - -> `[305]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. We can definitely make an exception for Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Axel. If that's your demand for unification, consider it done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can trust Rizia to take care of Pales as its own, but we cannot grant you special privileges. Once you unify with us, you will be a region of Rizia like any other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Axel. We are not playing that game. You married my daughter, and now you're going to agree to unification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. Pales is of such enormous value to all of us. I will make sure it gets the attention it deserves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Axel. We are not playing that game. You married my daughter already and now I need you to stop asking questions and agree to the unification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. That goes without saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[312]`
Mówca: **Axel Reinhart**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[313]`
Mówca: **Axel Reinhart**
> ""I'm not sure if that's going to be enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[314]`
Mówca: **Axel Reinhart**
> ""We will see... We will see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Axel Reinhart**
> ""That was uncalled for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Narrator**
> "Realizing that I was being serious, he averted his eyes from me and sipped his drink again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Narrator**
> "He sighed and went quiet for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned < 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned < 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.AxelConcerned"] < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.AxelConcerned < 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.AxelConcerned"] < 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[321]`
Mówca: **Axel Reinhart**
> ""You know what...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned < 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned < 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.AxelConcerned"] < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.AxelConcerned < 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.AxelConcerned"] < 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[325]`
Mówca: **Narrator**
> "He looked at me with a huge smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Axel Reinhart**
> ""Let's do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[327]`
Mówca: **Axel Reinhart**
> ""To our unity!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[328]`
Mówca: **Axel Reinhart**
> ""I just don't think Pales is ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`
  - -> `[333]`
  - -> `[334]`

### Węzeł `[329]`
Mówca: **Axel Reinhart**
> ""I believe our countries should put the reunfication process on hold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Axel Reinhart**
> ""You know I'm not against it in principle. But now might not be the right time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. I hope we can regain your trust in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't make us wait any longer, Axel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you kidding me? After everything I've done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You seem not to understand the situation, Axel. I only sanctioned this marriage so that Rizia could get Pales back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Narrator**
> "He raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[336]`
Mówca: **Axel Reinhart**
> ""You know what, Romus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Axel Reinhart**
> ""It's time the Princess and I were on our way back home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[338]`
Mówca: **Narrator**
> "He finished the rest of his glass in one go and stood up, waving at Vina as he did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[339]`
Mówca: **Axel Reinhart**
> ""We will see about that, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Axel Reinhart**
> ""But for now...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[341]`
Mówca: **Axel Reinhart**
> ""Thanks for your understanding, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Axel Reinhart**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_Rizia_Unification = true;
RiziaDLCSupport.Reports_Turn10_Pales_Peace = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] = true;
Variable["RiziaDLCSupport.Reports_Turn10_Pales_Peace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[347]`
  - -> `[348]`

### Węzeł `[344]`
Mówca: **Axel Reinhart**
> ""Once I'm back in Pales, I'll approve all the reunification documents and swear my undying fealty to the Rizian kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[345]`
Mówca: **Narrator**
> "He raised his glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To our unity!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia axa Pales!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To new beginnings, and to the enduring strength of the bonds forged not by politics, but by hearts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Narrator**
> "He motioned for an embrace and we hugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Narrator**
> "It was finally real. Pales was coming back home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[351]`
Mówca: **Axel Reinhart**
> ""If you'll excuse me, I want to join Vina at the beach before the sun sets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[353]`
Mówca: **Axel Reinhart**
> ""Sweetheart! Didn't you say you knew the perfect spot to watch the sunset? You simply must show me right this second.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Narrator**
> "He abruptly stood up and walked away towards the sandy beach."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `AddConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Breather", "R_Breather_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Breather","R_Breather_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Toras", "R_Toras_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Toras","R_Toras_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EvaluateConditionalInstruction("MapChange_Pales");)*
- **Efekt (`userScript`):** `EvaluateConditionalInstruction("MapChange_Pales");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Speaking of preparations, shall we discuss our progress?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[361]`
Mówca: **Axel Reinhart**
> ""Yes, I was getting to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Marrying Lucita was the only way to keep House Azaro happy. You know they're still disappointed we never invaded you a second time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our marriage is a mere footnote to yours. You and Vina are the future. Lucita and I are relics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I couldn't be happier, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[365]`
Mówca: **Axel Reinhart**
> ""They're getting what they wanted, aren't they? Pales and Rizia, together at last.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Axel Reinhart**
> ""Although I suppose if it went the way your wife's family envisioned, they'd be on my throne and I'd be facing the guillotine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[367]`
Mówca: **Axel Reinhart**
> ""A second chance at fatherhood, at your age. It must feel like a gift from God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[368]`
Mówca: **Axel Reinhart**
> ""I gave away the Reinhart name for this union, as you well know. And I am on the verge of giving up the Grand Duchy's hard-won independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[369]`
Mówca: **Axel Reinhart**
> ""Are you sure about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_KeepsLastName == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_KeepsLastName == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_KeepsLastName"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_KeepsLastName == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_KeepsLastName"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Axel Reinhart**
> ""I'm giving away the Grand Duchy's hard-won independence for this union, as you well know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseToras_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Narrator**
> "Axel, seated next to me, looked out at the Antacean wistfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[378]`
Mówca: **Narrator**
> "The owner bowed deferentially several times in a row before rushing to set our places."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_GreatUnification");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_GreatUnification");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Riza_PeacefulUnification");)*
- **Efekt (`userScript`):** `UnlockAchievement("Riza_PeacefulUnification");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_GlovuriusAxaRizia += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn09_RH_Decision_Unification_Agree = true;
RiziaDLCSupport.News_Turn09_G_Decision_Unification_Agree = true;
RiziaDLCSupport.Reports_Turn09_Sordland_Decision_Unification_Agree = true;
RiziaDLCSupport.Codex_Locations_Regions_PAD = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_RH_Decision_Unification_Agree"] = true;
Variable["RiziaDLCSupport.News_Turn09_G_Decision_Unification_Agree"] = true;
Variable["RiziaDLCSupport.Reports_Turn09_Sordland_Decision_Unification_Agree"] = true;
Variable["RiziaDLCSupport.Codex_Locations_Regions_PAD"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_GRACEMember == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.FactionReports_Turn10_GRACE_Decision_Unification_Agree = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.FactionReports_Turn10_GRACE_Decision_Unification_Agree"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`
  - -> `[393]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Axel Reinhart**
> ""Overdone it lately, have you? I know the feeling. I'll have some water as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[395]`
Mówca: **Axel Reinhart**
> ""Oh, I see. This is some sort of test. Listen, Your Majesty, I enjoy a drink as much as the next man, but I assure you I'm no Patricio Alvarez. I'll have some water as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[396]`
Mówca: **Axel Reinhart**
> ""I'm speaking hypothetically, Your Majesty. For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[397]`
Mówca: **Axel Reinhart**
> ""I'm beginning to get the sense that's how it works in your kingdom. Whatever King Romus says, goes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Theocracy_Full == true || RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`
  - -> `[400]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Theocracy_Full == true || RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true  or  Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Theocracy_Full == true || RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true  or  Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[401]`
Mówca: **Axel Reinhart**
> ""Hmm. I hope you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[402]`
Mówca: **Axel Reinhart**
> ""Well, I'm glad you're optimistic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[403]`
Mówca: **Axel Reinhart**
> ""No, no. That door has slammed shut.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[404]`
Mówca: **Axel Reinhart**
> ""Nobody will dare to toy with us now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[405]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[406]`
Mówca: **Narrator**
> "HIs face darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[407]`
Mówca: **Axel Reinhart**
> ""Either that, or the other guys...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[408]`
Mówca: **Axel Reinhart**
> ""Nothing, Your Majesty. Just making small talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GRACEApplication == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GRACEApplication == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GRACEApplication"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GRACEApplication == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GRACEApplication"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[412]`
Mówca: **Axel Reinhart**
> ""Why would Rizia isolate itself from GRACE? Right on the cusp of Pales becoming a member, no less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[224]`
  - -> `[229]`
  - -> `[419]`
  - -> `[415]`

### Węzeł `[413]`
Mówca: **Axel Reinhart**
> ""But without the protection of GRACE or an alliance like Intermerkopum, our reunified kingdom will have to go it alone...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[414]`
Mówca: **Axel Reinhart**
> ""Please, Your Majesty. I never said that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`
  - -> `[417]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[418]`
Mówca: **Narrator**
> "Axel frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our partnership with Rumburg served its purpose. But now it is time for Rizia and Pales to forge our own way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Axel Reinhart**
> ""We'll have a hard time doing that without other allies, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC.Diplomacy_Pales_GRACEApplication == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC.Diplomacy_Pales_GRACEApplication == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_GRACEApplication"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC.Diplomacy_Pales_GRACEApplication == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_GRACEApplication"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[424]`
Mówca: **Axel Reinhart**
> ""I have to thank you once more for getting Pales into GRACE, Your Majesty. Although the Lespians are furious about it, as you can imagine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`
  - -> `[433]`
  - -> `[431]`
  - -> `[427]`

### Węzeł `[425]`
Mówca: **Axel Reinhart**
> ""Nobody will dare to toy with us now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[426]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, I'd rather try to have a good relationship with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[428]`
Mówca: **Axel Reinhart**
> ""Alvarez should be the one trying to appease us. Not the other way around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[429]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[430]`
Mówca: **Axel Reinhart**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sooner or later, they will all have to realize and respect the power of our band of monarchies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[432]`
Mówca: **Axel Reinhart**
> ""What's bad for Lespia is good for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What did you expect? We took their favorite toy away from them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. That means we are on the right track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`
  - -> `[437]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[438]`
Mówca: **Axel Reinhart**
> ""I confess I don't like the rumors I'm hearing about an impending conflict between Rumburg and Sordland. I trust Pales would never be dragged into such a conflagration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`
  - -> `[441]`
  - -> `[442]`
  - -> `[440]`

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure it'll blow over. Nothing to worry about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What impending conflict?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The members of GRACE must support each other, Duke Reinhart. If we don't come to Rumburg's aid in such a situation, they will never come to ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me, I will do everything I can to keep Rizia and Pales out of such a conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[443]`
Mówca: **Narrator**
> "He wrinkled his brow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[444]`
Mówca: **Axel Reinhart**
> ""Have your butler read you a newspaper sometime, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[445]`
Mówca: **Axel Reinhart**
> ""That's the answer I was hoping for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[446]`
Mówca: **Axel Reinhart**
> ""You would support Rumburg like you supported Vendonesam?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vendonesam_Lose == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`
  - -> `[449]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vendonesam_Lose == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vendonesam_Lose"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vendonesam_Lose == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vendonesam_Lose"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[450]`
Mówca: **Narrator**
> "He frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[451]`
Mówca: **Axel Reinhart**
> ""But I suppose you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[452]`
Mówca: **Axel Reinhart**
> ""I suppose you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[453]`
Mówca: **Axel Reinhart**
> ""I suppose you're right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[454]`
Mówca: **Narrator**
> "He looked unconvinced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`
  - -> `[457]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[458]`
Mówca: **Axel Reinhart**
> ""One thing I did not expect from Rizia was your sudden coziness with Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[459]`
Mówca: **Axel Reinhart**
> ""Caleqabiz, Your Majesty? You've practically put the Valgs at Pales' doorstep.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`
  - -> `[462]`
  - -> `[468]`
  - -> `[466]`

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a necessary business arrangement. We would've lost control of the MITZ without it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[461]`
Mówca: **Axel Reinhart**
> ""I am sure you had your reasons. But you've got to understand how this looks to my people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is not the Valgos Empire of old, Duke Reinhart. Hegel and his republic are different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not disparage our Valgslandian comrades. We are all one people, fighting the good fight on behalf of the common man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[464]`
Mówca: **Axel Reinhart**
> ""...Comrades?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[465]`
Mówca: **Axel Reinhart**
> ""You were there at the AN. You heard what Hegel thinks of me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "'Your concerns are misplaced, Your Grace. Valgsland isn't planning anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[467]`
Mówca: **Axel Reinhart**
> ""Then why would they want a base so far south? Something here doesn't smell right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`
  - -> `[470]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 3)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[473]`
Mówca: **Axel Reinhart**
> ""But anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[474]`
Mówca: **Axel Reinhart**
> ""I had my doubts at first -- especially when Mr. Esquibel stopped leading the reunification talks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[475]`
Mówca: **Axel Reinhart**
> ""But my dear wife convinced me that both of our countries would be better off in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[476]`
Mówca: **Axel Reinhart**
> ""My wife sees it rather differently. Personally, though, I'm just happy you took her ex-paramour out of play.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[477]`
Mówca: **Axel Reinhart**
> ""King Valero was a man of many mistakes, I'll grant you that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[478]`
Mówca: **Axel Reinhart**
> ""I'm not sure the House of Delegates was one of them. But I'll take your word for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[479]`
Mówca: **Axel Reinhart**
> ""My wife has her qualms, as I'm sure you're aware. Personally, though, I'm just happy you took her ex-paramour out of play.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[480]`
Mówca: **Axel Reinhart**
> ""In fact...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[481]`
Mówca: **Axel Reinhart**
> ""Listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[482]`
Mówca: **Axel Reinhart**
> ""We are still allies, Your Majesty. I still value and treasure our partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Codex_Locations_Countries_Pales = false;
EnableCodexEntry("Locations_Regions_Pales_Unified");
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_UnifiedMarriedVina");
EnableCodexEntry("Locations_Cities_FortAles_Reunification");
EnableCodexEntry("Locations_Cities_Terador_Reunification");)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Codex_Locations_Countries_Pales"] = false;
EnableCodexEntry("Locations_Regions_Pales_Unified");
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_UnifiedMarriedVina");
EnableCodexEntry("Locations_Cities_FortAles_Reunification");
EnableCodexEntry("Locations_Cities_Terador_Reunification");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vendonesam_Lose == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`
  - -> `[486]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vendonesam_Lose == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vendonesam_Lose"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vendonesam_Lose == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vendonesam_Lose"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCText.GRACECountries = "the United Kingdom of Rizia and Pales")*
- **Efekt (`userScript`):** `Variable["RiziaDLCText.GRACECountries"] ="the United Kingdom of Rizia and Pales";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCText.GRACECountries = "the United Kingdom of Rizia and Pales, the Confederacy of Vendonesam")*
- **Efekt (`userScript`):** `Variable["RiziaDLCText.GRACECountries"] ="the United Kingdom of Rizia and Pales, the Confederacy of Vendonesam";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[489]`
Mówca: **Axel Reinhart**
> ""The least that I can expect is that this... development won't interfere with the Princess of Rizia's birthright.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`
  - -> `[494]`
  - -> `[493]`
  - -> `[509]`
  - -> `[563]`

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at all I've done for you. Isn't it enough to be part of a prospering alliance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will be honest with you. I already promised to House Azaro that if my second child is a boy, he will succeed me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[492]`
Mówca: **Axel Reinhart**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The child could be a girl, in which case you have nothing to worry about. But if it is a boy, tradition dictates he will be my heir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[494]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`
  - -> `[496]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Birthrights don't mean much these days, Axel. Whether you're a prince or King Consort, your status will remain the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[498]`
Mówca: **Narrator**
> "He looked over at Lucita. She had met a young girl on the beach and was gleefully instructing her how to hold a stick as if it were a sword."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You might as well come straight out with it. You're worried about losing your claim to the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[500]`
Mówca: **Axel Reinhart**
> ""The thought has crossed my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[501]`
Mówca: **Narrator**
> "He laced his fingers behind his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[502]`
Mówca: **Axel Reinhart**
> ""Hm. Yes, that's another thing I wanted to bring up with you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[503]`
Mówca: **Axel Reinhart**
> ""I do treasure our alliance. And I worry an Azaro heir on the throne will jeopardize it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[504]`
Mówca: **Axel Reinhart**
> ""You yourself have broken royal tradition on a number of occasions. Why should this one mean so much to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_RoyalTraditions_Broken == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`
  - -> `[507]`

### Węzeł `[506]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Law_RoyalTraditions_Broken == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_RoyalTraditions_Broken"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Law_RoyalTraditions_Broken == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_RoyalTraditions_Broken"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[508]`
Mówca: **Axel Reinhart**
> ""If Pales and Rizia are to forge a new kingdom together, we must put old traditions aside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[509]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina is my eldest child. As far as I'm concerned, she is and will remain my heir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[510]`
Mówca: **Axel Reinhart**
> ""Great. I hope Her Majesty isn't too put out about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`
  - -> `[513]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[513]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_RelationshipPublic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[514]`
Mówca: **Axel Reinhart**
> ""And what of your own... unconventional partnership, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[515]`
Mówca: **Axel Reinhart**
> ""It took real strength to come out and announce it like that. I've got to say I'm impressed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[516]`
Mówca: **Axel Reinhart**
> ""And, well, I admit I'm relieved to know you won't be bearing any more children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`
  - -> `[519]`
  - -> `[535]`
  - -> `[526]`
  - -> `[531]`

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come, now. Even if I was with a woman, I would never jeopardize Vina's inheritance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Never say never. Like the metaphorical door between Pales and Rizia, this king swings both ways.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`
  - -> `[521]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[521]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[522]`
Mówca: **Axel Reinhart**
> ""I, uh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[523]`
Mówca: **Axel Reinhart**
> ""I'll keep that in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[524]`
Mówca: **Axel Reinhart**
> ""It's awfully hard to say no to Her Highness, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[525]`
Mówca: **Narrator**
> "He grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm too old to go through parenthood again, Axel. You two, on the other hand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[527]`
Mówca: **Narrator**
> "He grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[528]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. And as a matter of fact, should reunification go as planned, you and Vina will inherit the Rizian throne *very* soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Axel Reinhart**
> ""Thank you for telling me that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[530]`
Mówca: **Narrator**
> "He drew in a breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PromiseToAbdicate == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`
  - -> `[533]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PromiseToAbdicate == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PromiseToAbdicate == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[534]`
Mówca: **Axel Reinhart**
> ""The topic has come up, Your Majesty. But we're in no rush.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[535]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. It wasn't easy, but I couldn't go on living a lie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[536]`
Mówca: **Axel Reinhart**
> ""I hope your relatives will come around in time. It's as valid a lifestyle choice as any, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Drinking += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Drinking"] = Variable["RiziaDLC.PersonalValue_Drinking"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`
  - -> `[540]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[541]`
Mówca: **Axel Reinhart**
> ""Especially after what happened at your mother's birthday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`
  - -> `[555]`
  - -> `[556]`
  - -> `[557]`

### Węzeł `[542]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`
  - -> `[544]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[545]`
Mówca: **Axel Reinhart**
> ""However, the tactics you used to get these reforms passed struck me as highly concerning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[546]`
Mówca: **Axel Reinhart**
> ""I'm just being honest with you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`
  - -> `[550]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`
  - -> `[553]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[554]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you talking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[555]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There was an emergency, but it was handled swiftly by the Rizian Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[556]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is only beginning its transformation. I assure you there is nothing for Pales to worry about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you have a problem with that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[558]`
Mówca: **Narrator**
> "He smiled nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 3)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[560]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[561]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.AxelConcerned += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Promised_Succession_Son_RespectTradition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`
  - -> `[565]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Promised_Succession_Son_RespectTradition == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Promised_Succession_Son_RespectTradition == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[566]`
Mówca: **Axel Reinhart**
> ""This is all stll hypothetical for now. But I hope you'll keep in mind that our alliance goes back further than yours and Her Majesty's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`
  - -> `[569]`

### Węzeł `[568]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseToras_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[569]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseToras_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[570]`
Mówca: **Narrator**
> "The waiter penciled down the order with shaking hands, then practically raced to the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`
  - -> `[575]`
  - -> `[576]`
  - -> `[580]`

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's right, worm. Remember who owns these lands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[572]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`
  - -> `[574]`

### Węzeł `[573]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[575]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why is everyone here so scared of me? They should be grateful I've purged the kingdom of traitors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[576]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's taking the province some time to adjust to the Crown's direct rule. I assure you, they'll be happier in the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[577]`
Mówca: **Axel Reinhart**
> ""Mm. Yes, seems like it's been quite the shake-up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[578]`
Mówca: **Axel Reinhart**
> ""Mm. You must admit it's been quite the shake-up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[579]`
Mówca: **Narrator**
> "Axel raised an eyebrow, but didn't say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[580]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Romus_Italic**
> "I didn't say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_PalesReunification_NoDrink = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDrink"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_PalesReunification_NoDrink = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDrink"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_PalesReunification_NoDrink = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDrink"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[584]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`
  - -> `[586]`

### Węzeł `[585]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDrink"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDrink"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[587]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`
  - -> `[589]`

### Węzeł `[588]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDrink"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[589]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDrink"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[590]`
Mówca: **Narrator**
> "The waiter returned with our drinks a few moments later."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[591]`
Mówca: **Narrator**
> "The waiter returned with Axel's drink a few moments later."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[592]`
Mówca: **Axel Reinhart**
> ""Ehm... Your Majesty, Rizia's provincial semi-autonomy was a large reason why I agreed to these reunification efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[593]`
Mówca: **Axel Reinhart**
> ""The idea that the Crown can simply seize control of any province at any time... you'll excuse me if it doesn't sit right with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`
  - -> `[597]`
  - -> `[596]`
  - -> `[604]`

### Węzeł `[594]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relax, Your Grace. As long as Pales behaves itself, you'll never befall such a fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`

### Węzeł `[595]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There was a plot to overthrow me. I did what I had to in order to protect Princess Vina's inheritance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[596]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I promise you, this was strictly between me and the nobles in question. It won't go any further than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[597]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Birthday_WarnedAboutCoup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`
  - -> `[599]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Birthday_WarnedAboutCoup == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[599]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Birthday_WarnedAboutCoup == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[600]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I acted in pure self-defense. Had I not, I wouldn't be sitting here talking to you right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[601]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Think about it, Axel. Thanks to me, House Azaro is no longer sitting at your doorstep. They'll never threaten Pales again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`

### Węzeł `[602]`
Mówca: **Axel Reinhart**
> ""All right. I suppose the inner workings of Rizia are still confusing to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[603]`
Mówca: **Axel Reinhart**
> ""We will behave ourselves. You won't have to worry about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[604]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseAzaro_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`
  - -> `[606]`

### Węzeł `[605]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseAzaro_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseAzaro_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[606]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseAzaro_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[607]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`
  - -> `[609]`

### Węzeł `[608]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[609]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[610]`
Mówca: **Axel Reinhart**
> ""I suppose I should be grateful about that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[611]`
Mówca: **Axel Reinhart**
> ""If there truly was not other option, then I cannot fault you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[612]`
Mówca: **Axel Reinhart**
> ""Still, striking all three provinces at once? Not even my ancestor Otto would've tried to pull that off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[613]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`
  - -> `[615]`

### Węzeł `[614]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[615]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[616]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`
  - -> `[618]`

### Węzeł `[617]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[618]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[619]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relax. I myself enjoy a drink or two from time to time. I'll join you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`
