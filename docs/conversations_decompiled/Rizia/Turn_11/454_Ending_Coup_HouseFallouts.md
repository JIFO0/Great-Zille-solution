# Rizia/Turn 11/Ending_Coup_HouseFallouts

- **ID konwersacji:** `454`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Rizia/Turn_11/454_Ending_Coup_HouseFallouts.md`
- **Liczba węzłów dialogowych:** 878
- **Liczba wyborów gracza:** 138

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[79]** Vina Toras
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[85]** Sevrio Castellanus
- **[87]** Sal Ignacius
- **[91]** Rico Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.Rumburg_War`
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.CoupWarning_BoatCancelled`
- `RiziaDLC.Coup_Leader_Hugo`
- `RiziaDLC.Coup_Leader_Lucita`
- `RiziaDLC.Coup_Leader_Rico`
- `RiziaDLC.Coup_Leader_Taddeus`
- `RiziaDLC.Ending_Coup_Azaro`
- `RiziaDLC.Ending_Coup_Sazon`
- `RiziaDLC.Ending_Coup_Toras`
- `RiziaDLC.HouseAzaro_Conquered`
- `RiziaDLC.HouseSazon_Conquered`
- `RiziaDLC.HouseToras_Conquered`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Manus_DiesInWar`
- `RiziaDLC.Manus_Executed`
- `RiziaDLC.Pabel_Lord`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Policy_Diplomacy_GRACEMember`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialPolice`
- `RiziaDLC.Relations_HouseSazon_AngelicaPardoned`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Relations_Vina_Estranged`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Deposed`
- `RiziaDLC.Rico_Executed`
- `RiziaDLC.Rico_Extradited`
- `RiziaDLC.Rico_PoliceChief_PorteDrazon`
- `RiziaDLC.Rusty_Hostile`
- `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown`
- `RiziaDLC.Situation_Order_SuOmina_Destabilizing`
- `RiziaDLC.SuOmina_OrderedToKillManus`
- `RiziaDLC.Successor_Vina`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Titus_Arrested`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vina_DuchessOfValenqiris`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_FuneralHappened`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLC.Vina_Rescue_Success`
- `RiziaDLC.Vina_Wedding_Happened`
- `RiziaDLC.War_Outcome_NoPeace_KeepFighting`
- `RiziaDLC.War_Pales_Loss`
- `RiziaDLCIsolated.Coup_BringFamily`
- `RiziaDLCIsolated.Coup_BringGuards`
- `RiziaDLCIsolated.Coup_ToldToOpenFire`
- `RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Coup_Leader_Angelica`
- `RiziaDLC.Coup_Leader_Hugo`
- `RiziaDLC.Coup_Leader_Lucita`
- `RiziaDLC.Coup_Leader_Rico`
- `RiziaDLC.Coup_Leader_Taddeus`
- `RiziaDLC.Epilogue_Coup_Survived_WithEstela`
- `RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina`
- `RiziaDLC.Epilogue_Death_HouseFallouts`
- `RiziaDLC.Epilogue_Prison_HouseFallouts`
- `RiziaDLC.Epilogue_Survived_HouseFallouts`
- `RiziaDLC.Epilogue_Usurped_HouseFallouts`
- `RiziaDLC.LateGameCoup_TitusBetrays`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.SkipToEpilogue`
- `RiziaDLCIsolated.Coup_BringFamily`
- `RiziaDLCIsolated.Coup_BringGuards`
- `RiziaDLCIsolated.Coup_GuardsStay`
- `RiziaDLCIsolated.Coup_ToldToOpenFire`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 13
- **Węzły modyfikujące stan gry:** 43

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[59]` (Paskal Beniwoll): `--;`
- Węzeł `[65]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Coup_GuardsStay"] = true;`
- Węzeł `[85]` (Paskal Beniwoll): `Variable["RiziaDLC.Coup_Leader_Rico"] = true;`
- Węzeł `[86]` (Paskal Beniwoll): `Variable["RiziaDLC.Coup_Leader_Hugo"] = true;`
- Węzeł `[87]` (Paskal Beniwoll): `Variable["RiziaDLC.Coup_Leader_Lucita"] = true;`
- Węzeł `[88]` (Paskal Beniwoll): `Variable["RiziaDLC.Coup_Leader_Taddeus"] = true;`
- Węzeł `[89]` (Paskal Beniwoll): `Variable["RiziaDLC.Coup_Leader_Angelica"] = true;`
- Węzeł `[110]` (Paskal Beniwoll): `AddConversant("Titus Gordion");`
- *...oraz 35 innych węzłów ze skryptami.*

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
  - -> `[877]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "As I entered the study and shifted my gaze toward the window, the sudden extinguishing of the lights at the palace gates drew my attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I tossed and turned all night. Despite the exhaustion of a busy day, sleep eluded me entirely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[5]`
Mówca: **Narrator**
> "In the hope of clearing my mind, I got out of bed and made my way through the palace corridors to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Before evening fell, I had received news of my sister-in-law's speech at the Alliance of Nations, openly threatening Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_GRACEMember == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Narrator**
> "As her ally, I feared the repercussions her actions might bring to the Kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Despite distancing ourselves from Rumburg, I feared the repercussions her actions might have on our region of Merkopa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_War == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_War == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Narrator**
> "While she assured me earlier that she didn't intend to go to war, her speech was making headlines in Rizia, sparking questions about our position in the event of a conflict."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[16]`
Mówca: **Narrator**
> "I knew she desired war from the start. And her unprecedented speech was now making headlines in Rizia, sparking questions about our position in the event of a conflict."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "Take a closer look."]** — Mówca: **Player_Romus_Italic**
> "I stood up and approached the window to take a closer look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "Ignore it."]** — Mówca: **Player_Romus_Italic**
> "Not giving it a second thought, I moved to my desk and started looking through my recent correspondence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[782]`

### Węzeł `[19]`
Mówca: **Narrator**
> "I strained to discern anything in the dark, only to realize that the entire palace gardens had turned pitch-black."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[20]`
Mówca: **Narrator**
> "And then, out of nowhere, I caught sight of large shadows hurtling from the gates toward the palace at full speed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[384]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "Keep watching."]** — Mówca: **Player_Romus_Italic**
> "I kept my eyes fixed on the shapes as they approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "Call the guards."]** — Mówca: **Player_Romus_Italic**
> "I stepped outside my chambers and alerted two Wruhec's Guardian sentries."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`

### Węzeł `[23]`
Mówca: **Narrator**
> "As I rummaged through the papers on my desk, I heard the hum of engines outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[24]`
Mówca: **Narrator**
> "It was then that the sound of roaring engines filled the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "Look out the window."]** — Mówca: **Player_Romus_Italic**
> "I stood up and moved toward the window to get a closer look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "Ignore the noise."]** — Mówca: **Player_Romus_Italic**
> "I ignored the noise and kept looking at the letters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Turning back toward the window, I saw armored personnel carriers with mounted guns. Their headlights were shining straight up at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[28]`
Mówca: **Narrator**
> "Several pairs of headlights suddenly pierced the darkness. They belonged to armored personnel carriers with mounted guns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[29]`
Mówca: **Narrator**
> "All of a sudden, the doors swung open. Sevrio and several Wruhec's Guardians hurried in, visibly relieved to see me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]`

### Węzeł `[30]`
Mówca: **Narrator**
> "With an abrupt thud, the doors opened and my guards rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Wearing puzzled expressions, the guards gestured at the vehicles outside, specifically pointing to the flags on them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Azaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Azaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Azaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Azaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Azaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Toras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_PoliceChief_PorteDrazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_PoliceChief_PorteDrazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_PoliceChief_PorteDrazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[41]`
Mówca: **Narrator**
> "It was the coat of arms of House Azaro."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
Mówca: **Narrator**
> "It was the coat of arms of House Toras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[43]`
Mówca: **Narrator**
> "It was the coat of arms of House Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true && RiziaDLC.Ending_Coup_Sazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true && RiziaDLC.Ending_Coup_Sazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true  and  Variable["RiziaDLC.Ending_Coup_Sazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Toras == true && RiziaDLC.Ending_Coup_Sazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true  and  Variable["RiziaDLC.Ending_Coup_Sazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Sazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Sazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Sazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Sazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Sazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Toras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[53]`
Mówca: **Narrator**
> "Behind the leading vehicles, I also noticed the flags of House Toras and Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`

### Węzeł `[54]`
Mówca: **Narrator**
> "Behind the leading vehicles, I also noticed the flags of House Toras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`

### Węzeł `[55]`
Mówca: **Narrator**
> "Behind the leading vehicles, I also noticed the flags of House Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`

### Węzeł `[56]`
Mówca: **Narrator**
> "As we attempted to figure out what was happening, the guards informed me that their radio had stopped picking up any signal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[57]`
Mówca: **Narrator**
> "Several cars from the Porte Drazon Police Department barreled through the gates, sirens blaring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Titus anxiously punched a code on his radio and held it to his ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean the radio doesn't work? Go and tell the other guards what's happening! Now!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go and make sure my mother is safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't go anywhere. Stay with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[63]`
Mówca: **Narrator**
> "The guards, shouting "Yes, Your Majesty," readied their weapons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Narrator**
> "At that moment, a man outside in full military uniform seized a megaphone and began to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_GuardsStay = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Coup_GuardsStay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[66]`
Mówca: **Narrator**
> ""Romus Toras. We have Palas Rezna completely surrounded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[67]`
Mówca: **Narrator**
> ""Abdicate the throne to Angelica Sazon, and your life and noble status will be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Azaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Azaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Azaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Azaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Azaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[865]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Toras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[77]`
Mówca: **Narrator**
> ""Abdicate the throne to Lucita Azaro, and your life and noble status will be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Narrator**
> ""Abdicate the throne to Taddeus Azaro, and your life and noble status will be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[82]`
Mówca: **Narrator**
> ""Abdicate the throne to Hugo Toras, and your life and noble status will be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[83]`
Mówca: **Narrator**
> ""Abdicate the throne to Ricardus Toras, and your life and noble status will be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Narrator**
> ""He's just been released from prison, and shall be recognized as the true King of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Rico"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[839]`
  - -> `[91]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Angelica = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Angelica"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Narrator**
> ""I'll say it again. If you abdicate, your noble status will be preserved. All we ask is that you step down in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[91]`
Mówca: **Narrator**
> ""I repeat. If you abdicate, your noble status will be preserved. All we ask is that you step down in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_BringGuards"] == true  and  Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_BringGuards"] == true  and  Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[95]`
Mówca: **Narrator**
> "His words resonated in my skull."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[96]`
Mówca: **Narrator**
> "The guards cast nervous glances my way, waiting for instructions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`
  - -> `[128]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[100]`
Mówca: **Narrator**
> "While she assured me it was the Sords who were readying for war and not Rumburg, I knew that she wanted to attack Sordland from the start."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[101]`
Mówca: **Narrator**
> "It was at that moment that Titus, accompanied by a group of guardsmen, rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_BringFamily == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_BringFamily == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_BringFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Coup_BringFamily == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_BringFamily"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Narrator**
> "It was at that moment my mother and Vina, accompanied by the guards, rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Narrator**
> "It was at that moment that my mother, accompanied by the guards, rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Estela Toras");
AddConversant("Vina Toras");)*
- **Efekt (`userScript`):** `AddConversant("Estela Toras");
AddConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Estela Toras");)*
- **Efekt (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[113]`
Mówca: **Titus Gordion**
> ""Your Majesty!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[114]`
Mówca: **Titus Gordion**
> ""The Golden Guard has taken their positions and are prepared to defend the palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Titus Gordion**
> ""What are your orders?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[125]`
  - -> `[126]`
  - -> `[432]`

### Węzeł `[116]`
Mówca: **Estela Toras**
> ""That's a wrap on your reign, darling. Don't say I didn't warn you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Estela Toras**
> ""That's a wrap on your reign, darling. Don't say I didn't warn you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Vina Toras**
> ""Father. Is this really happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[119]`
Mówca: **Estela Toras**
> ""Although I imagined something a little more subtle than this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[120]`
Mówca: **Estela Toras**
> ""What are you going to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[123]`
  - -> `[434]`
  - -> `[124]`

### Węzeł `[121]`
Mówca: **Narrator**
> "Vina's complexion paled noticeably as she caught sight of the armored vehicles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must address their demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing. I'm afraid I have no choice but to do as they say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fight back. Guards! Get in position and open fire!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Tell them to open fire!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have a choice. We must listen to the rebels' demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me talk to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have to get my family out of here this instant. In the meantime, I will talk to the soldiers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm going to go out and talk to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We hold our ground, no exceptions. Is that understood? Now open fire!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_BringGuards = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Coup_BringGuards"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_BringFamily = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Coup_BringFamily"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[133]`
Mówca: **Narrator**
> "The soldiers saluted me as I grabbed a coat and walked out on the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[134]`
Mówca: **Titus Gordion**
> ""Are you suggesting we negotiate? I'm sorry, sir, but I doubt the enemy is receptive to your arguments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`
  - -> `[135]`
  - -> `[136]`
  - -> `[137]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Given our limited numbers, we don't stand a chance. There's no other way out of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know. However, while they're focusing on me, you can better assess the situation and determine the best course of action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It will buy us time. While their attention is on me, you can catch them off guard and ambush them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[138]`
Mówca: **Titus Gordion**
> ""But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[139]`
Mówca: **Titus Gordion**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_ToldToOpenFire = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[141]`
Mówca: **Narrator**
> "He saluted as I grabbed a coat and stepped out onto the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[142]`
Mówca: **Narrator**
> "My mother and daughter watched in wordless terror as I grabbed a coat and stepped out onto the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[143]`
Mówca: **Estela Toras**
> ""Romus. Please think before you do or say anything stupid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[148]`
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a distraction. While I'm talking to the rebels, Titus will coordinate everyone's position and commence firing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have to do this to save our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. I'll be right back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Talking to them should distract them long enough for you to make your escape from the palace. Is that clear?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_ToldToOpenFire = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[152]`
Mówca: **Narrator**
> "Upon catching sight of me, the insurgents outside displayed a mix of astonishment and relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[153]`
  - -> `[171]`
  - -> `[172]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen carefully. Take your weapons and depart from my palace, and I will disregard this... misunderstanding. You still have the opportunity to withdraw.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where the hell is my cousin? You're carrying out the orders of someone who lacks the courage to confront me directly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[454]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where the hell is my uncle? You're carrying out the orders of someone who lacks the courage to confront me directly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where the hell is Lucita? You're carrying out the orders of someone who lacks the courage to confront me directly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where the hell is Taddeus? You're carrying out the orders of someone who lacks the courage to confront me directly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where the hell is Angelica? You're carrying out the orders of someone who lacks the courage to confront me directly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stand down. I'm not here to fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[172]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Romus_Italic**
> "I remained silent, fixing them with a steady gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[173]`
Mówca: **Narrator**
> "None of the soldiers reacted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_ToldToOpenFire == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_ToldToOpenFire == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Coup_ToldToOpenFire == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Narrator**
> "The guards within the palace reluctantly dropped their weapons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[178]`
Mówca: **Narrator**
> "At that moment, the stable doors burst open with a thunderous crash, and two regal horses galloped wildly through the palace gardens."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Soldier! Lower that gun at once! You're pointing your weapon at your king!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go ahead. Shoot me. You can pry my crown from my cold dead hands!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`

### Węzeł `[181]`
Mówca: **Narrator**
> "Soon after, an ear-splitting explosion shattered the tranquility of the courtyard, plunging the rebel soldiers into a panic as a thick cloud of smoke engulfed them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[182]`
Mówca: **Narrator**
> "I hurled myself back inside as gunshots erupted from every direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_BringGuards"] == true  and  Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Coup_BringGuards == true && RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_BringGuards"] == true  and  Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop! I surrender. Guards, drop your weapons!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards! Open fire!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[188]`
Mówca: **Titus Gordion**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Titus Gordion**
> ""But first, I need to escort you to a secure location.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[190]`
Mówca: **Narrator**
> "The guards insisted on escorting me to a safe room before initiating the attack."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Vina Toras**
> ""What? No!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[195]`
Mówca: **Estela Toras**
> ""What? No!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no time. Open fire immediately!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "Follow them to the safe room."]** — Mówca: **Player_Romus_Italic**
> "I heeded their pleas and followed them to the safe room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have no time. Open fire immediately!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. Lead the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[200]`
Mówca: **Narrator**
> "He nodded and gave a series of hand signals."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "A thunderous barrage erupted as my..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Narrator**
> "The guards, displaying utmost professionalism, saluted me before taking firing positions around the windows, their guns aimed at the rebels below."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[203]`
Mówca: **Narrator**
> "A thunderous barrage erupted as my guards started firing at the soldiers below."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "A thunderous barrage erupted as my..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[205]`
Mówca: **Narrator**
> "I threw myself to the floor as an ear-splitting explosion engulfed the courtyard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[206]`
Mówca: **Narrator**
> "Hearing my orders, the guards opened fire below."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[208]`
Mówca: **Narrator**
> "As we rushed through corridors and descended a back stairwell, the sound of gunshots reverberated from outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "I threw myself to the floor as an e..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_BringFamily == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_BringFamily == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_BringFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Coup_BringFamily == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_BringFamily"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[213]`
Mówca: **Narrator**
> "My mother looked at me in shock as the chaos unfolded around us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[214]`
Mówca: **Narrator**
> "Titus seized my arm and dragged me out of the room, rushing me through the palace corridors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[215]`
Mówca: **Vina Toras**
> ""Father! What do we do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`
  - -> `[679]`
  - -> `[226]`
  - -> `[225]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Estela Toras**
> ""Romus! What do we do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`
  - -> `[679]`
  - -> `[226]`
  - -> `[225]`

### Węzeł `[220]`
Mówca: **Narrator**
> "Nearby guards dragged me out of the room, rushing me through the palace corridors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[221]`
Mówca: **Narrator**
> "It wasn't until we were deep within the bowels of the palace that the clamor of the battle above gradually subsided."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[222]`
Mówca: **Narrator**
> "We could still hear the exchange of gunfire from outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[223]`
Mówca: **Narrator**
> "It was a simple, fortified space devoid of any luxury, designed solely for one purpose..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[224]`
Mówca: **Narrator**
> "Before long, we came to a heavy metal door -- the entrance to the safe room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got to get you to safety. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Take cover! We'll wait here until the situation stabilizes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is out of our hands now. We must pray.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[228]`
Mówca: **Narrator**
> "However, just as the captain extended his hand toward the handle, a sudden, resounding crash reverberated through the passages."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Narrator**
> "Behind us, we heard someone shout, "Everyone down on the ground!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Narrator**
> "Glancing back, I saw a group of rebels, each concealed behind a mask, aiming their KA-74's at us with deadly precision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[234]`
**[WYBÓR GRACZA: "Comply."]** — Mówca: **Player_Romus_Italic**
> "With no options left, I pressed my face to the cold floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[235]`
**[WYBÓR GRACZA: "Stand still."]** — Mówca: **Player_Romus_Italic**
> "I remained still, locking eyes with them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[236]`
Mówca: **Narrator**
> "The rebels moved with quick steps, pinning us down, their boots heavy against the backs of our necks. And with a clink of their handcuffs, they secured our wrists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_BringFamily == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_BringFamily == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_BringFamily"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Coup_BringFamily == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_BringFamily"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[240]`
Mówca: **Narrator**
> "Vina and my mother threw themselves to the ground. There was fear in their eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[241]`
Mówca: **Narrator**
> "My mother threw herself to the ground. There was fear in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[245]`
Mówca: **Narrator**
> "Emboldened by my reaction, Titus turned toward them, his rifle drawn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[246]`
Mówca: **Narrator**
> "Upon reaching our location, they swiftly subdued and restrained us, securing our wrists with a click of their handcuffs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Narrator**
> "They confidently brandished their weaponry aloft as a testament to their newfound authority within the palace walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This isn't necessary. We're not resisting!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not some petty criminal. Release me from these restraints!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do what you must.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One day, you will pay for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Narrator**
> "Ignoring my words, they simply smiled and escorted us outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[254]`
Mówca: **Narrator**
> ""Get down or we'll shoot!" one of the masked men shouted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]`
  - -> `[773]`
  - -> `[248]`
  - -> `[249]`
  - -> `[250]`

### Węzeł `[256]`
**[WYBÓR GRACZA: "Stay standing."]** — Mówca: **Player_Romus_Italic**
> "Once again, I refused to comply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[260]`
Mówca: **Titus Gordion**
> ""Good news, Your Majesty. Our communications are active again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Titus Gordion**
> ""I've just received word that we've identified collaborators among the rebels as well as their locations. Our forces are ready to respond.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Titus Gordion**
> ""In the meantime, we must leave the palace as soon as the perimeter is secured.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[271]`
  - -> `[272]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[266]`
Mówca: **Narrator**
> "Sal, Sevrio and a number of Wruhec's Guardians were huddled in a corner, conversing. They turned back to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[267]`
Mówca: **Sevrio Castellanus**
> ""I've just been informed that collaborators among the rebels have been identified, along with their locations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Sevrio Castellanus**
> ""Wruhec's Guardians stand ready to respond, bringing the wrath of God in their wake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Sal Ignacius**
> ""We must leave the palace as soon as the perimeter is cleared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[271]`
  - -> `[272]`
  - -> `[273]`

### Węzeł `[270]`
Mówca: **Sevrio Castellanus**
> ""You'll be pleased to know that our communications are active again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you certain we can clear the perimeter? There were tanks stationed outside the palace!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where will we go?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lord help us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See to it that all who played a part in this are brought to justice. Do I make myself clear?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Titus Gordion**
> ""Yes, Your Majesty. I will make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[279]`
Mówca: **Sal Ignacius**
> ""Gladly. I'll make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[280]`
Mówca: **Sal Ignacius**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Titus Gordion**
> ""We'll regroup with our armed forces, who can provide us with enhanced protection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[285]`
Mówca: **Sal Ignacius**
> ""We'll regroup with our armed forces, who can provide us with enhanced protection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Titus Gordion**
> ""My guards are equipped to withstand a professional force significantly larger than their own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Sevrio Castellanus**
> ""Wruhec's Guardians are capable of resisting a professional force much larger than their size.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[291]`
Mówca: **Titus Gordion**
> ""This includes anti-tank and anti-air capabilities. I assure you, there's no need for concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[292]`
Mówca: **Narrator**
> "After a few minutes, the clamor from the recent skirmish between the rebels and palace guards outside gradually subsided."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[293]`
Mówca: **Narrator**
> "I embraced my mother and daughter. Together, we emerged from the safety of our underground stronghold and returned to the surface."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[294]`
Mówca: **Narrator**
> "After hugging my mother, we emerged from the safety of our underground stronghold, returning to the surface together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[298]`
Mówca: **Narrator**
> "The guards informed us that the perimeter was momentarily secured and that we had a window of opportunity to evacuate the palace. It was now or never."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[299]`
Mówca: **Narrator**
> "As we stepped into the courtyard, I beheld the once immaculate garden strewn with the scattered remnants of armored vehicles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Narrator**
> "The ground was littered with bodies, shattered weapons, and fragments of uniforms, making it difficult to navigate without stepping on them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Narrator**
> "Before long, our escort brought us to an armored truck that would transport us to safety."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Narrator**
> "Despite surviving tonight's attack, I knew this was just the beginning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[304]`
Mówca: **Narrator**
> "The culprit behind it all was still out there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Breather", "R_Breather_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Breather","R_Breather_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[310]`
Mówca: **Narrator**
> "Without a moment of hesitation, he discharged his firearm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.SkipToEpilogue = true;
RiziaDLC.Epilogue_Death_HouseFallouts = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.SkipToEpilogue"] = true;
Variable["RiziaDLC.Epilogue_Death_HouseFallouts"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "Without a moment of hesitation, he..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_HouseFallouts = true; RiziaDLC.SkipToEpilogue = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Survived_HouseFallouts"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Usurped_HouseFallouts = true; RiziaDLC.SkipToEpilogue = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Usurped_HouseFallouts"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Prison_HouseFallouts = true; RiziaDLC.SkipToEpilogue = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Prison_HouseFallouts"] = true;
Variable["RiziaDLC.SkipToEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Coup_Survived_WithEstela = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Explosion");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Explosion");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Explosion");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Explosion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Gunfight");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Gunfight");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Gunfight");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Gunfight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CoupGunshot");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CoupGunshot");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: StopMusic();)*
- **Efekt (`userScript`):** `StopMusic();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
**[WYBÓR GRACZA: "Call the guards."]** — Mówca: **Player_Romus_Italic**
> "I stepped outside my chambers and alerted two Golden Guard sentries."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Narrator**
> "All of a sudden, the doors swung open, and several Golden Guardsmen hurried in, visibly relieved to see me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Theocracy_Full == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Theocracy_Full == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[336]`
Mówca: **Titus Gordion**
> ""Wruhec's Guardians have taken their positions and are prepared to defend the palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[337]`
Mówca: **Narrator**
> "And her unprecedented speech was now making headlines in Rizia, sparking questions about our position in the event of a conflict."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will speak to these traitors at once. I refuse to cower in fear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[342]`
Mówca: **Narrator**
> "Titus clenched his jaw, his muscles tensing with determination. After a second, he reluctantly nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[343]`
Mówca: **Titus Gordion**
> ""Understood, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_ToldToOpenFire = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[345]`
Mówca: **Narrator**
> "Mother's complexion paled noticeably as she regarded the armored vehicles outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will address these traitors at once. I refuse to cower in fear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[350]`
Mówca: **Vina Toras**
> ""What are you going to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[123]`
  - -> `[434]`
  - -> `[124]`

### Węzeł `[351]`
Mówca: **Narrator**
> "The armored vehicle had been obliterated, leaving behind a scene of blood and metal strewn across the cobblestone. My would-be usurper disappeared into the haze, surrounded by a cordon of guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[352]`
Mówca: **Narrator**
> "In response, the rebels surged forward, their determined strides echoing through the halls as they breached the once-secure threshold of the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[353]`
Mówca: **Narrator**
> "The door shut behind us with a definitive clang, sealing us off from the outside world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[354]`
Mówca: **Narrator**
> "Survival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`

### Węzeł `[355]`
Mówca: **Titus Gordion**
> ""We must avoid any other encounters with the rebels until loyalist troops can intervene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[356]`
Mówca: **Sal Ignacius**
> ""We must avoid any other encounters with the rebels until loyalist troops, guided by Divine providence, can intervene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[357]`
Mówca: **Narrator**
> "There was no telling when the enemy would regroup and return for another assault."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[358]`
Mówca: **Narrator**
> "The sheets felt clammy against my skin, and the soft glow of the moon through the curtains offered no solace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Narrator**
> "Every creak of the floorboards and rustle of the wind outside seemed to amplify in the stillness of the night, further unsettling my restless mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[360]`
Mówca: **Narrator**
> "I tossed and turned all night. Despite my utter exhaustion, sleep eluded me entirely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CoupWarning_BoatCancelled == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CoupWarning_BoatCancelled == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CoupWarning_BoatCancelled"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CoupWarning_BoatCancelled == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CoupWarning_BoatCancelled"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[364]`
Mówca: **Narrator**
> "The sheets felt clammy against my skin, and the soft glow of the moon through the curtains offered no solace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[365]`
Mówca: **Narrator**
> "Each creak of the floorboards and rustle of the wind outside seemed to amplify in the stillness of the night, setting off alarms in my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Narrator**
> "They were coming for me. Or were they?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[370]`
Mówca: **Narrator**
> "Bruno had abandoned his usual resting spot and was pacing back and forth in front of the door, as he'd begun doing every night since my mother's warning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[371]`
Mówca: **Narrator**
> "In the hope of distracting myself, I got out of bed and made my way through the palace corridors to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_Lord == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_Lord == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Narrator**
> "I had told Pabel to lay low on his estate until the threat blew over. The palace felt empty without him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel > 2 || RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel > 2 || RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] > 2  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel > 2 || RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] > 2  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[379]`
Mówca: **Narrator**
> "I had told Pabel to lay low at a friend's place in the capital until the threat blew over. The palace felt empty without him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[380]`
Mówca: **Narrator**
> "Lucita had called me from the hospital, telling me she had experienced some premature contractions and was being kept overnight for observation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[391]`
Mówca: **Narrator**
> "All of a sudden, the doors swung open and Titus hurried in, visibly relieved to see me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[392]`
Mówca: **Narrator**
> "The doors swung open and Captain Gordion burst in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Titus Gordion**
> ""Your Majesty. Forgive me. They surrounded us before we could--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[394]`
Mówca: **Narrator**
> "As he stared out the window, Titus' eyes widened in horror. I followed his gaze to the flag mounted on the lead vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Narrator**
> "Wearing puzzled expressions, the guards gestured outside. I followed their gaze to the flag mounted on the lead vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
  - -> `[401]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`

### Węzeł `[402]`
Mówca: **Narrator**
> "With an abrupt thud, the doors opened and Titus rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[403]`
Mówca: **Titus Gordion**
> ""Your Majesty. Forgive me. They surrounded us before we could--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[404]`
Mówca: **Titus Gordion**
> ""Wait. Is that what I think it is?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]`

### Węzeł `[408]`
Mówca: **Titus Gordion**
> ""Nothing. The signal's gone dead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]`

### Węzeł `[412]`
Mówca: **Titus Gordion**
> ""I will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`
  - -> `[415]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]`

### Węzeł `[416]`
Mówca: **Titus Gordion**
> ""Of course, Your Majesty. I'll be back in an instant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Narrator**
> ""Yes, Your Majesty," the guards shouted as they rushed out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[418]`
Mówca: **Narrator**
> "Titus bowed and rushed out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");
RemoveConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Coup_Leader_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is my wife we're talking about. I'm sure we can reach an understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is my uncle we're talking about. I'm sure we can reach an understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`
  - -> `[430]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is my cousin we're talking about. I'm sure we can reach an understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just get me out of here. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[433]`
Mówca: **Titus Gordion**
> ""Right away, sir. Follow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`
  - -> `[436]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus is going to get us all out of here alive. Aren't you, Captain?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards! Get us out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[439]`
Mówca: **Narrator**
> "My protectors nodded their assent and motioned for us to follow them to the safe room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`
  - -> `[442]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[443]`
Mówca: **Narrator**
> "My mother watched in wordless terror as I grabbed a coat and stepped out onto the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[446]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[848]`

### Węzeł `[447]`
Mówca: **Narrator**
> "Titus cast an agitated glance my way, waiting for my instructions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`
  - -> `[128]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[843]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`
  - -> `[453]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[456]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get me in contact with Lucita. If my wife knew about this, she'd put an end to it immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[458]`
Mówca: **Narrator**
> "A hush suddenly came over the crowd. The people below me parted ways as a heavily armored car slowly made its way through the throng."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[459]`
Mówca: **Narrator**
> "It rolled over the garden's succulents and rose bushes with a series of sickening crunches before coming to a halt in front of the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[460]`
Mówca: **Narrator**
> "The soldiers formed a protective circle around the vehicle. The back door opened, and Rico stepped out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`
  - -> `[463]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`
  - -> `[466]`

### Węzeł `[465]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[467]`
Mówca: **Narrator**
> "The soldiers formed a protective circle around the vehicle. The back door opened, and Hugo stepped out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`
  - -> `[470]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[471]`
Mówca: **Narrator**
> "The soldiers formed a protective circle around the vehicle. One of them opened the back door, and Lucita stepped out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`
  - -> `[474]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[475]`
Mówca: **Narrator**
> "The soldiers formed a protective circle around the vehicle. One of them brought a wheelchair around to the back door and helped General Taddeus into it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[476]`
Mówca: **Narrator**
> "The soldiers formed a protective circle around the vehicle. One of them opened the back door, and Angelica Sazon stepped out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[477]`
Mówca: **Narrator**
> "I saw profound regret etched onto my uncle's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`
  - -> `[486]`
  - -> `[488]`
  - -> `[490]`

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo. You don't have to do this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[479]`
Mówca: **Narrator**
> "My cousin looked up at me in grim satisfaction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`
  - -> `[481]`
  - -> `[482]`
  - -> `[484]`

### Węzeł `[480]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ricardus. Listen to me. You don't have to do this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By order of the King, you and your men will stand down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[482]`
**[WYBÓR GRACZA: "Spit on him."]** — Mówca: **Player_Romus_Italic**
> "I spit off the balcony, aiming for Rico's face. His guards shielded him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[483]`
Mówca: **Rico Toras**
> ""Please, cousin. Just cooperate. It'll be so much easier that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`
  - -> `[532]`
  - -> `[522]`
  - -> `[533]`

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've gotten my attention. What do you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[485]`
Mówca: **Hugo Toras**
> ""Believe me, Romus. I wish there was another way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By order of the King, you and your men will stand down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[487]`
Mówca: **Hugo Toras**
> ""Please, Romus... I urge you to cooperate. You must know you're outnumbered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`
  - -> `[548]`
  - -> `[549]`
  - -> `[553]`

### Węzeł `[488]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've gotten my attention. What do you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[489]`
Mówca: **Hugo Toras**
> ""I want what is best for our house, Romus. Please just cooperate with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`
  - -> `[548]`
  - -> `[549]`
  - -> `[553]`

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You bastard. This was your plan all along, wasn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`
  - -> `[493]`

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[493]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[494]`
Mówca: **Narrator**
> "She put a protective hand over her belly as she looked up at me. I saw sadness in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`
  - -> `[498]`
  - -> `[499]`
  - -> `[507]`

### Węzeł `[495]`
Mówca: **Narrator**
> "Her eyes were stone cold as she looked up at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`
  - -> `[505]`
  - -> `[507]`

### Węzeł `[496]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, Luce. You don't have to do this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you ever love me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[498]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bitch. Traitor. You'll burn in hell for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have my attention. What do you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[500]`
Mówca: **Lucita Azaro**
> ""I'm sorry, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[501]`
Mówca: **Narrator**
> "She briefly looked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[502]`
Mówca: **Lucita Azaro**
> ""Please just cooperate. It'll be easier for all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`
  - -> `[563]`
  - -> `[569]`
  - -> `[570]`

### Węzeł `[503]`
Mówca: **Lucita Azaro**
> ""Watch your mouth, Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[504]`
Mówca: **Lucita Azaro**
> ""I believe my men have already told you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to do this, Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[506]`
Mówca: **Lucita Azaro**
> ""Neither do you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[507]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By order of the King, you and your men will stand down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[508]`
Mówca: **Lucita Azaro**
> ""Your orders mean nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[509]`
Mówca: **Lucita Azaro**
> ""If you know what's best for you, you'll cooperate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`
  - -> `[563]`
  - -> `[569]`
  - -> `[570]`

### Węzeł `[510]`
Mówca: **Narrator**
> "He looked up at me, his eyes stern."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`
  - -> `[512]`
  - -> `[513]`
  - -> `[514]`

### Węzeł `[511]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't usurp me. You can't even walk!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've gotten my attention. What do you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""General. You don't have to do this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By order of the King, you and your men will stand down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[515]`
Mówca: **Taddeus Azaro**
> ""Even half an Azaro is twice the king you'll ever be, Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[516]`
Mówca: **Taddeus Azaro**
> ""My men have already told you. Forsake your title and cede the throne to House Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`
  - -> `[596]`
  - -> `[598]`
  - -> `[601]`

### Węzeł `[517]`
Mówca: **Hugo Toras**
> ""Please just cooperate with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`
  - -> `[548]`
  - -> `[549]`
  - -> `[553]`

### Węzeł `[518]`
Mówca: **Taddeus Azaro**
> ""Your orders don't mean anything anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[519]`
Mówca: **Taddeus Azaro**
> ""The time for bargaining is over, Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[520]`
Mówca: **Taddeus Azaro**
> ""Cooperate with us, and you will be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`
  - -> `[596]`
  - -> `[598]`
  - -> `[601]`

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need your word that you won't hurt my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[522]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You couldn't even handle Iza. What makes you fit to rule over a whole kingdom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[523]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need your word that you won't hurt my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`
  - -> `[526]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[527]`
Mówca: **Rico Toras**
> ""Don't be ridiculous. Your family is my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[528]`
Mówca: **Rico Toras**
> ""We won't even lay a finger on your husband. Wife? Whatever you people call it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`
  - -> `[531]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_RelationshipPublic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_RelationshipPublic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[532]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was this Hugo's idea?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[533]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll die before I bend the knee to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[534]`
Mówca: **Rico Toras**
> ""Before you killed him, you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[535]`
Mówca: **Rico Toras**
> ""House Toras had our doubts about you from the start. All you've done since then is prove us right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[536]`
Mówca: **Rico Toras**
> ""Treasonous words. I have to say you're not off to a good start with the new regime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[537]`
Mówca: **Rico Toras**
> ""Do you think we have any problem with killing you? After what you did to my father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`
  - -> `[540]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[540]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[541]`
Mówca: **Narrator**
> "As his officer took up a position directly beneath the balcony, Rico spoke once more in a hushed voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[542]`
Mówca: **Narrator**
> "He nodded to one of his officers. The man strode towards the palace door, flanked by a group of soldiers. The remaining soldiers maintained their vigilant watch, their guns trained on the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[543]`
Mówca: **Rico Toras**
> ""Then you'll die. You have my sincerest apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[544]`
Mówca: **Rico Toras**
> ""I'll give you one chance. Tell your guards to surrender their weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`
  - -> `[546]`
  - -> `[547]`

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards! You heard him. Relinquish your weapons right away!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[547]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you surrender *your* weapons before it's too late?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[548]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll die before I bend the knee to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`
  - -> `[551]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Executed == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[552]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I should've killed you along with your son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[553]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What makes you think you'll be a better king than me? You'll be dead in a few years anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[554]`
Mówca: **Hugo Toras**
> ""Your family is my family. Do you really believe me capable of such cruelty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[555]`
Mówca: **Hugo Toras**
> ""You don't mean that. Think of your mother. She'll die of a broken heart if she loses you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[556]`
Mówca: **Narrator**
> "Hugo didn't respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[557]`
Mówca: **Narrator**
> "As his officer took up a position directly beneath the balcony, Hugo spoke once more in a hushed voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[558]`
Mówca: **Narrator**
> "He motioned to one of his officers. The man strode towards the palace door, flanked by a group of soldiers. The remaining soldiers maintained their vigilant watch, their guns trained on the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[559]`
Mówca: **Hugo Toras**
> ""I am begging you, my nephew. Tell your guards to surrender their weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`
  - -> `[561]`
  - -> `[562]`

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards! You heard him. Relinquish your weapons right away!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[561]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[562]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you surrender *your* weapons before it's too late?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Vina == true && RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`
  - -> `[565]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Vina == true && RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Successor_Vina"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Successor_Vina == true && RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Successor_Vina"] == true  and  Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[566]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I take it all back. Our son will inherit the throne after all. Now can we put this nonsense behind us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[567]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need your word that you won't hurt my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[568]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I should've killed you along with your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll die before I bend the knee to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`
  - -> `[572]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Taddeus_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[572]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Taddeus_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[573]`
Mówca: **Narrator**
> "Rage flashed across her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[574]`
Mówca: **Lucita Azaro**
> ""You don't mean that. I know you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`
  - -> `[577]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[578]`
Mówca: **Lucita Azaro**
> ""If that's the way it has to be...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[579]`
Mówca: **Lucita Azaro**
> ""It's too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[580]`
Mówca: **Lucita Azaro**
> ""What kind of monster do you think I am?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`
  - -> `[583]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[584]`
Mówca: **Lucita Azaro**
> ""Step down peacefully, and nobody will be harmed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[585]`
Mówca: **Narrator**
> "As the officer took up a position directly beneath the balcony, Lucita spoke once more in a hushed voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[586]`
Mówca: **Narrator**
> "She motioned to one of her officers. The man strode towards the palace door, flanked by a group of soldiers. The remaining soldiers maintained their vigilant watch, their guns trained on the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[587]`
Mówca: **Lucita Azaro**
> ""This is your last chance. Tell your guards to surrender their weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`
  - -> `[589]`
  - -> `[591]`

### Węzeł `[588]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards! You heard her. Relinquish your weapons right away!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you surrender *your* weapons before it's too late?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[591]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`
  - -> `[593]`

### Węzeł `[592]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[593]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[594]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For the sake of our son, I am begging you to stand down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[595]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need your word that you won't hurt my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[596]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll die before I bend the knee to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[597]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You couldn't even take Pales. What makes you think you can rule the country?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Loss == true || RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`
  - -> `[600]`

### Węzeł `[599]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Loss == true || RiziaDLC.War_Outcome_NoPeace_KeepFighting == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Loss"] == true  or  Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[600]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Loss == true || RiziaDLC.War_Outcome_NoPeace_KeepFighting == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Loss"] == true  or  Variable["RiziaDLC.War_Outcome_NoPeace_KeepFighting"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[601]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`
  - -> `[603]`

### Węzeł `[602]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`

### Węzeł `[603]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[604]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should've died along with your daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[605]`
Mówca: **Narrator**
> "Rage flashed across his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[606]`
Mówca: **Taddeus Azaro**
> ""Step down peacefully, and I swear on my ancestors' graves that nobody will be harmed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[607]`
Mówca: **Taddeus Azaro**
> ""After what you did to Lucita, you deserve it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[608]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`
  - -> `[610]`

### Węzeł `[609]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Executed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[610]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Executed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[611]`
Mówca: **Taddeus Azaro**
> ""Then you will die.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`

### Węzeł `[612]`
Mówca: **Narrator**
> "As the officer took up a position directly beneath the balcony, Taddeus spoke once more in a hushed voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[613]`
Mówca: **Narrator**
> "He motioned to one of his officers. The man strode towards the palace door, flanked by a group of soldiers. The remaining soldiers maintained their vigilant watch, their guns trained on the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`

### Węzeł `[614]`
Mówca: **Taddeus Azaro**
> ""I will give you one chance. Tell your guards to surrender their weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`
  - -> `[616]`
  - -> `[617]`

### Węzeł `[615]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards! You heard him. Relinquish your weapons right away!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[616]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[617]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you surrender *your* weapons before it's too late?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[618]`
Mówca: **Narrator**
> "She looked up at me, her posture rigid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`
  - -> `[620]`
  - -> `[621]`
  - -> `[622]`

### Węzeł `[619]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Angelica. You don't have to do this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[620]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I let you out of prison, and this is how you repay me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[621]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By order of the King, you and your men will stand down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[622]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have my attention. What do you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[623]`
Mówca: **Angelica Sazon**
> ""You have already been told. Cede the throne to House Sazon, and we will let you live.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[624]`
Mówca: **Angelica Sazon**
> ""You will address me as Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[625]`
Mówca: **Angelica Sazon**
> ""Do you truly expect gratitude after you humiliated my family for all those years?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[626]`
Mówca: **Angelica Sazon**
> ""You are no king of mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[627]`
Mówca: **Angelica Sazon**
> ""I implore you to cooperate. No more blood needs to be shed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`
  - -> `[638]`
  - -> `[628]`

### Węzeł `[628]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesInWar == true || RiziaDLC.SuOmina_OrderedToKillManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`
  - -> `[630]`

### Węzeł `[629]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesInWar == true || RiziaDLC.SuOmina_OrderedToKillManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_Executed"] == true  or  Variable["RiziaDLC.Manus_DiesInWar"] == true  or  Variable["RiziaDLC.SuOmina_OrderedToKillManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]`

### Węzeł `[630]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_Executed == true || RiziaDLC.Manus_DiesInWar == true || RiziaDLC.SuOmina_OrderedToKillManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_Executed"] == true  or  Variable["RiziaDLC.Manus_DiesInWar"] == true  or  Variable["RiziaDLC.SuOmina_OrderedToKillManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`

### Węzeł `[631]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should've died along with your son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[632]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father should've killed you along with your husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[633]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need your word that you won't hurt my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[634]`
Mówca: **Angelica Sazon**
> ""Of course I won't. My son loves your daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[635]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`
  - -> `[637]`

### Węzeł `[636]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[637]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[638]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll die before I bend the knee to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[639]`
Mówca: **Angelica Sazon**
> ""I swear to you that nobody will be harmed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[640]`
Mówca: **Angelica Sazon**
> ""Please. Think of your mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[641]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`
  - -> `[643]`

### Węzeł `[642]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[643]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_FuneralHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[644]`
Mówca: **Angelica Sazon**
> ""Please. Think of your mother. Your daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[645]`
Mówca: **Narrator**
> "Her face turned white with rage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[646]`
Mówca: **Narrator**
> "As the officer took up a position directly beneath the balcony, Angelica spoke once more in a hushed voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[647]`
Mówca: **Narrator**
> "She motioned to one of her officers. The man strode towards the palace door, flanked by a group of soldiers. The remaining soldiers maintained their vigilant watch, their guns trained on the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[648]`
Mówca: **Angelica Sazon**
> ""This is your final chance. Tell your guards to surrender their weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`
  - -> `[650]`
  - -> `[651]`

### Węzeł `[649]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guards! You heard her. Relinquish your weapons right away!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[650]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you surrender *your* weapons before it's too late?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[652]`
Mówca: **Narrator**
> "The officer took another step forward. He lifted his gun and pointed it straight at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[653]`
  - -> `[180]`

### Węzeł `[653]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You wouldn't dare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[654]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`
  - -> `[656]`

### Węzeł `[655]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`

### Węzeł `[656]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[657]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`
  - -> `[659]`

### Węzeł `[658]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[659]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[660]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`
  - -> `[662]`

### Węzeł `[661]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[662]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[663]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_ToldToOpenFire == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`
  - -> `[665]`

### Węzeł `[664]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_ToldToOpenFire == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[665]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Coup_ToldToOpenFire == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_ToldToOpenFire"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[666]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`
  - -> `[668]`

### Węzeł `[667]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[668]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[669]`
Mówca: **Narrator**
> "The man's aim faltered slightly as he looked at Rico for confirmation. My cousin gave a single, short nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[670]`
Mówca: **Narrator**
> "The man's aim faltered slightly as he looked at Hugo for confirmation. My cousin gave a single, short nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[671]`
Mówca: **Narrator**
> "The man's aim faltered slightly as he looked at Lucita for confirmation. She gave a single, short nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[672]`
Mówca: **Narrator**
> "The man's aim faltered slightly as he looked at Taddeus for confirmation. The general gave a single, short nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[673]`
Mówca: **Narrator**
> "The man's aim faltered slightly as he looked at Angelica for confirmation. She gave a single, short nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[674]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Peaceful Surrender)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]`

### Węzeł `[675]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Peaceful Surrender])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[676]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`
  - -> `[678]`

### Węzeł `[677]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[678]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[679]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That traitor is still out there. I'm going after them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[680]`
Mówca: **Estela Toras**
> ""To hell with that. We've got to get to the safe room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[681]`
Mówca: **Narrator**
> "Titus appeared by our side. He took a moment to catch his breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[682]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`
  - -> `[684]`

### Węzeł `[683]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[684]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[685]`
Mówca: **Titus Gordion**
> ""We don't have much time, Your Majesty. This way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`

### Węzeł `[686]`
Mówca: **Narrator**
> "Accompanied by our guards, we sprinted into the corridor and raced toward a back stairwell, descending as quickly as possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[687]`
Mówca: **Narrator**
> "We sprinted into the corridor and raced toward a back stairwell, descending as quickly as possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[688]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`
  - -> `[690]`

### Węzeł `[689]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`

### Węzeł `[690]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[691]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`
  - -> `[693]`

### Węzeł `[692]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[693]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true || RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true  or  Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[694]`
Mówca: **Narrator**
> "A spatter of gunshots suddenly echoed through the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[695]`
Mówca: **Narrator**
> "A spatter of gunshots suddenly echoed through the hallway. I dropped to the floor to take cover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[696]`
Mówca: **Narrator**
> "I lifted my head to see my attackers lying dead on the ground. Above them stood Sal Ignacius and a group of Wruhec's Guardians."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`

### Węzeł `[697]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]`
  - -> `[699]`

### Węzeł `[698]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[699]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[700]`
Mówca: **Narrator**
> "I lifted my head to see my attackers lying dead on the ground. Above them, a backup contingent of Golden Guards slowly lowered their guns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[701]`
Mówca: **Sal Ignacius**
> ""Your Majesty. Thank the Divine you are safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`
  - -> `[702]`
  - -> `[703]`

### Węzeł `[702]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No time for prayers. Let's get inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`

### Węzeł `[703]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[704]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[710]`

### Węzeł `[705]`
Mówca: **Narrator**
> "Titus pulled me up off the floor, and we rushed inside the safe room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[706]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`
  - -> `[708]`

### Węzeł `[707]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[708]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`

### Węzeł `[709]`
Mówca: **Narrator**
> "One of them pulled me up off the floor, and we rushed inside the safe room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[710]`
Mówca: **Narrator**
> "Together with Sevrio and the guards, we rushed inside the safe room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[711]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank the Divine for you and the Guardians, Sal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`

### Węzeł `[712]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_BringFamily == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`
  - -> `[714]`

### Węzeł `[713]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Coup_BringFamily == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Coup_BringFamily"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`

### Węzeł `[714]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Coup_BringFamily == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Coup_BringFamily"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[715]`
Mówca: **Narrator**
> "I looked around the room and saw that my mother and Vina were already here, along with Bruno. The dog ran to greet me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`

### Węzeł `[716]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`
  - -> `[718]`

### Węzeł `[717]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`

### Węzeł `[718]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[719]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`
  - -> `[721]`

### Węzeł `[720]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[721]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[722]`
Mówca: **Narrator**
> "I looked around the room and saw that my mother and Bruno were already here. The dog ran to greet me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[723]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`
  - -> `[725]`

### Węzeł `[724]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[725]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[726]`
Mówca: **Narrator**
> "I looked around the room and saw that one of the guards had brought Bruno here already. The dog ran to greet me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[727]`
Mówca: **Narrator**
> "I looked around the room and saw that my mother and Vina were already here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`

### Węzeł `[728]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`
  - -> `[730]`

### Węzeł `[729]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[730]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`

### Węzeł `[731]`
Mówca: **Narrator**
> "I looked around the room and saw that my mother was already here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[732]`
Mówca: **Estela Toras**
> ""I hate to say I told you so -- oh, who am I kidding? I love it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`

### Węzeł `[733]`
Mówca: **Estela Toras**
> ""But in this particular case, I do so wish I was wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]`
  - -> `[738]`
  - -> `[741]`
  - -> `[742]`

### Węzeł `[734]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Estela Toras");
AddConversant("Vina Toras");
AddConversant("Bruno");)*
- **Efekt (`userScript`):** `AddConversant("Estela Toras");
AddConversant("Vina Toras");
AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`

### Węzeł `[735]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Estela Toras");)*
- **Efekt (`userScript`):** `AddConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`

### Węzeł `[736]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not over yet. We've got to fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`

### Węzeł `[737]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for remembering Bruno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[738]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`
  - -> `[740]`

### Węzeł `[739]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]`

### Węzeł `[740]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[741]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive me, Mother. We should have fled when we had the chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]`

### Węzeł `[742]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm just happy you're safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]`

### Węzeł `[743]`
Mówca: **Estela Toras**
> ""I wasn't about to make the same mistake twice. And I admit he is a very good boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[744]`
Mówca: **Vina Toras**
> ""What's the point, Father? Half the kingdom hates us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[745]`
Mówca: **Vina Toras**
> ""It's not too late. We can still escape.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[746]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]`
  - -> `[748]`

### Węzeł `[747]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`

### Węzeł `[748]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]`

### Węzeł `[749]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`
  - -> `[751]`

### Węzeł `[750]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]`

### Węzeł `[751]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`

### Węzeł `[752]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]`
  - -> `[754]`

### Węzeł `[753]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]`

### Węzeł `[754]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Ending_HouseFallouts_VinaInPalace"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`

### Węzeł `[755]`
Mówca: **Vina Toras**
> ""For now. We need to get out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[756]`
Mówca: **Estela Toras**
> ""For now. We need to get out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[757]`
Mówca: **Estela Toras**
> ""We still have a chance. Don't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[758]`
Mówca: **Estela Toras**
> ""You really don't know when to give up, do you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[759]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]`
  - -> `[761]`

### Węzeł `[760]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]`

### Węzeł `[761]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]`

### Węzeł `[762]`
Mówca: **Narrator**
> "Titus, Sal, Sevrio and a number of Wruhec's Guardians were huddled in a corner, conversing. They turned back to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[763]`
Mówca: **Narrator**
> "Titus and his guardsmen were huddled in a corner, conversing. They turned back to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[764]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]`
  - -> `[766]`

### Węzeł `[765]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]`

### Węzeł `[766]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]`

### Węzeł `[767]`
Mówca: **Narrator**
> "Titus reluctantly signaled to his guards to drop their weapons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[768]`
Mówca: **Narrator**
> "As they roughly shoved me into the back of a car, I turned my head and took one more look at Palas Rezna. My home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]`

### Węzeł `[769]`
Mówca: **Narrator**
> "I knew I would never return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[770]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]`
  - -> `[772]`

### Węzeł `[771]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[772]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[773]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`
  - -> `[775]`

### Węzeł `[774]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]`

### Węzeł `[775]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[776]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May God have mercy on your soul.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[777]`
**[WYBÓR GRACZA: "Get down."]** — Mówca: **Player_Romus_Italic**
> "With no options left, I pressed my face to the cold floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[778]`
Mówca: **Narrator**
> "I exchanged nods with the guards posted outside the Queen Mother's chambers. She was barely leaving her room these days."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[779]`
Mówca: **Narrator**
> "The palace felt empty without her, but at least she would be safe there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[780]`
Mówca: **Narrator**
> "Suddenly, the doors swung open and Sevrio hurried in, visibly relieved to see me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]`

### Węzeł `[781]`
Mówca: **Sevrio Castellanus**
> ""Your Majesty. Forgive me. They surrounded us before we could--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[782]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vina_Escapes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]`
  - -> `[784]`

### Węzeł `[783]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vina_Escapes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]`

### Węzeł `[784]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_Estranged == true || RiziaDLC.Vina_Escapes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[785]`
Mówca: **Narrator**
> "There was no word from my daughter. I hoped that she was safe, wherever she was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[786]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]`
  - -> `[788]`

### Węzeł `[787]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]`

### Węzeł `[788]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Axel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]`

### Węzeł `[789]`
Mówca: **Narrator**
> "There was a telegram from Vina, assuring me that her security team in Pales had been alerted to the possible danger and were taking precautions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[790]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[791]`
  - -> `[792]`

### Węzeł `[791]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]`

### Węzeł `[792]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]`

### Węzeł `[793]`
Mówca: **Narrator**
> "There was a telegram from Vina, assuring me that she and Manus were in a secure location."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[794]`
Mówca: **Narrator**
> "There was a telegram from Vina, assuring me that her palace in Monqiz was still secure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]`

### Węzeł `[795]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]`
  - -> `[797]`

### Węzeł `[796]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`

### Węzeł `[797]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_DuchessOfValenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]`

### Węzeł `[798]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`
  - -> `[800]`

### Węzeł `[799]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Ending_Coup_Toras"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]`

### Węzeł `[800]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Rico == true && RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Ending_Coup_Toras"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]`

### Węzeł `[801]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Rico and Hubertus were there with her, ready to protect House Toras at all costs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[802]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Hubertus was nearby, ready to protect House Toras at all costs -- or so he had said."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[803]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Rescue_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`
  - -> `[805]`

### Węzeł `[804]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Rescue_Success == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false  and  Variable["RiziaDLC.Vina_Rescue_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]`

### Węzeł `[805]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true && RiziaDLC.Vina_FuneralHappened == false && RiziaDLC.Vina_Rescue_Success == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false  and  Variable["RiziaDLC.Vina_Rescue_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[806]`
Mówca: **Narrator**
> "There was a telegram from the war front, letting me know that Vina still hadn't been found."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[807]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.HouseToras_Conquered == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]`
  - -> `[809]`

### Węzeł `[808]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.HouseToras_Conquered == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == false  and  Variable["RiziaDLC.HouseToras_Conquered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]`

### Węzeł `[809]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Toras == false && RiziaDLC.HouseToras_Conquered == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == false  and  Variable["RiziaDLC.HouseToras_Conquered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]`

### Węzeł `[810]`
Mówca: **Narrator**
> "Hubertus had written from Monqiz, saying that he had heard the rumors and was covertly marshalling all the Toras loyalists he could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[811]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Ending_Coup_Azaro == false && RiziaDLC.HouseAzaro_Conquered == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]`
  - -> `[813]`

### Węzeł `[812]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Married == true && RiziaDLC.Ending_Coup_Azaro == false && RiziaDLC.HouseAzaro_Conquered == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Ending_Coup_Azaro"] == false  and  Variable["RiziaDLC.HouseAzaro_Conquered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]`

### Węzeł `[813]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Married == true && RiziaDLC.Ending_Coup_Azaro == false && RiziaDLC.HouseAzaro_Conquered == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Ending_Coup_Azaro"] == false  and  Variable["RiziaDLC.HouseAzaro_Conquered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`

### Węzeł `[814]`
Mówca: **Narrator**
> "My father-in-law had written from Montaklar, saying that he had heard the rumors and was covertly marshalling all the loyalists he could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[815]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true && RiziaDLC.HouseSazon_Conquered == false && RiziaDLC.Ending_Coup_Sazon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]`
  - -> `[817]`

### Węzeł `[816]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true && RiziaDLC.HouseSazon_Conquered == false && RiziaDLC.Ending_Coup_Sazon == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == false  and  Variable["RiziaDLC.Ending_Coup_Sazon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]`

### Węzeł `[817]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true && RiziaDLC.HouseSazon_Conquered == false && RiziaDLC.Ending_Coup_Sazon == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true  and  Variable["RiziaDLC.HouseSazon_Conquered"] == false  and  Variable["RiziaDLC.Ending_Coup_Sazon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[818]`
Mówca: **Narrator**
> "Angelica Sazon had written from Brenas, saying that she had heard the rumors and was covertly marshalling all the loyalists she could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[819]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`
  - -> `[821]`

### Węzeł `[820]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]`

### Węzeł `[821]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[822]`
Mówca: **Narrator**
> "With an abrupt thud, the doors opened and Sevrio rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]`

### Węzeł `[823]`
Mówca: **Sevrio Castellanus**
> ""Your Majesty. Forgive me. They surrounded us before we could--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]`

### Węzeł `[824]`
Mówca: **Sevrio Castellanus**
> ""Wait. Is that what I think it is?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[825]`
Mówca: **Narrator**
> "As he stared out the window, Sevrio's eyes widened in horror. I followed his gaze to the flag mounted on the lead vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[826]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]`
  - -> `[828]`

### Węzeł `[827]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]`

### Węzeł `[828]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[829]`
Mówca: **Sevrio Castellanus**
> ""Lord save us. The radio signal's gone dead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[830]`
Mówca: **Sevrio Castellanus**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[831]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`
  - -> `[833]`

### Węzeł `[832]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]`

### Węzeł `[833]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[834]`
Mówca: **Sevrio Castellanus**
> ""Yes, Your Majesty. I'll be back in an instant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[838]`

### Węzeł `[835]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]`
  - -> `[837]`

### Węzeł `[836]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]`

### Węzeł `[837]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[838]`
Mówca: **Narrator**
> "Sevrio bowed and rushed out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[839]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus < 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]`
  - -> `[841]`

### Węzeł `[840]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus < 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Titus"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]`

### Węzeł `[841]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Titus < 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Titus"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[842]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LateGameCoup_TitusBetrays = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LateGameCoup_TitusBetrays"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[843]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[844]`
  - -> `[845]`

### Węzeł `[844]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[845]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]`

### Węzeł `[846]`
Mówca: **Narrator**
> "Sevrio paled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[847]`

### Węzeł `[847]`
Mówca: **Sevrio Castellanus**
> ""Good luck, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[848]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[849]`
  - -> `[850]`

### Węzeł `[849]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[851]`

### Węzeł `[850]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[851]`
Mówca: **Narrator**
> "Sevrio muttered a prayer as he awaited my instructions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`
  - -> `[128]`

### Węzeł `[852]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]`
  - -> `[854]`

### Węzeł `[853]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[855]`

### Węzeł `[854]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[855]`
Mówca: **Sevrio Castellanus**
> ""Your Majesty, I really must insist on escorting you to a safe place before initiating anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[856]`

### Węzeł `[856]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Get me to the safe room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[857]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]`
  - -> `[859]`

### Węzeł `[858]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[859]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[860]`
Mówca: **Narrator**
> "Sevrio reluctantly signaled to his guards to drop their weapons."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[861]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Hostile == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[862]`
  - -> `[863]`

### Węzeł `[862]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_Hostile == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_Hostile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]`

### Węzeł `[863]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_Hostile == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Hostile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[864]`
Mówca: **Narrator**
> "Alongside them were a pair of vans bearing the Palantor Security Solutions logo. Rusty's men."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[865]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_PoliceChief_PorteDrazon == true || RiziaDLC.Situation_Order_SuOmina_Destabilizing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]`
  - -> `[867]`

### Węzeł `[866]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_PoliceChief_PorteDrazon == true || RiziaDLC.Situation_Order_SuOmina_Destabilizing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true  or  Variable["RiziaDLC.Situation_Order_SuOmina_Destabilizing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[871]`

### Węzeł `[867]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_PoliceChief_PorteDrazon == true || RiziaDLC.Situation_Order_SuOmina_Destabilizing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true  or  Variable["RiziaDLC.Situation_Order_SuOmina_Destabilizing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]`

### Węzeł `[868]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Deposed == false && RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == false && RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]`
  - -> `[870]`

### Węzeł `[869]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Deposed == false && RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == false && RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Deposed"] == false  and  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == false  and  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[871]`

### Węzeł `[870]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Deposed == false && RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == false && RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Deposed"] == false  and  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == false  and  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[874]`

### Węzeł `[871]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Extradited == false && RiziaDLC.Rico_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[872]`
  - -> `[873]`

### Węzeł `[872]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Extradited == false && RiziaDLC.Rico_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[873]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Executed == false && RiziaDLC.Rico_Extradited == false && RiziaDLC.Rico_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Executed"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false  and  Variable["RiziaDLC.Rico_Arrested"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[874]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]`
  - -> `[876]`

### Węzeł `[875]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[876]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Hugo_Executed == false && RiziaDLC.Hugo_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Executed"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[877]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Ending their reign with...", "Porte Drazon", "Kingdom of Rizia");)*
- **Efekt (`userScript`):** `SetRichPresence("Ending their reign with...","Porte Drazon","Kingdom of Rizia");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
