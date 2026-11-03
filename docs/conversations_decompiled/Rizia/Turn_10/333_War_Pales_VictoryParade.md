# Rizia/Turn 10/War_Pales_VictoryParade

- **ID konwersacji:** `333`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/333_War_Pales_VictoryParade.md`
- **Liczba węzłów dialogowych:** 376
- **Liczba wyborów gracza:** 47

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Enable_Policy_RD_Welfare_KingsCars`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.HouseSazon_Conquered`
- `RiziaDLC.Manus_DiesInWar`
- `RiziaDLC.Manus_SendToWar`
- `RiziaDLC.Reform_PrimeMinister_Adarfo`
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Reform_Success`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Relations_VinaManus_ApproveAfterPales`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Situation_Military_Airforce_Defence_Strong`
- `RiziaDLC.Situation_Military_Airforce_Offence_Strong`
- `RiziaDLC.Situation_Military_Airforce_Total_Large`
- `RiziaDLC.Situation_Military_LostPrideOfNavy`
- `RiziaDLC.Situation_Military_Manpower_Average`
- `RiziaDLC.Situation_Military_Manpower_High`
- `RiziaDLC.Situation_Military_Manpower_Massive`
- `RiziaDLC.Situation_Military_Marines_LargeForce`
- `RiziaDLC.Situation_Military_MobileForces_Large`
- `RiziaDLC.Situation_Military_MobileForces_Medium`
- `RiziaDLC.Situation_Military_MorellanAirPlanes`
- `RiziaDLC.Situation_Military_RiziaFleet_Large`
- `RiziaDLC.Situation_Military_RiziaFleet_Medium`
- `RiziaDLC.Situation_Military_StrongPalesResistance`
- `RiziaDLC.Titus_Arrested`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_FuneralHappened`
- `RiziaDLC.Vina_Wedding_Happened`
- `RiziaDLC.War_Control_Skipped`
- `RiziaDLC.War_Operation1Briefing_Frontline`
- `RiziaDLC.War_Used_ExperimentalWeapons_Pales`
- `RiziaDLC.War_Used_ExperimentalWeapons_Remaz`
- `RiziaDLC.War_Used_ExperimentalWeapons_Solles`
- `RiziaDLC.War_Used_ExperimentalWeapons_Ziqes`
- `RiziaDLC.War_WehlenJoined`
- `RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Axel_Arrested`
- `RiziaDLC.Faction_HouseSazon_Angelica`
- `RiziaDLC.Faction_HouseSazon_Leona`
- `RiziaDLC.Faction_HouseSazon_Manus`
- `RiziaDLC.Manus_Gone`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.War_Pales_Won_AxelTortured`
- `RiziaDLC.Win_Renamed_CastlePales`
- `RiziaDLC.Win_Renamed_CastleRomus`
- `RiziaDLC.Win_Renamed_CastleToras`
- `RiziaDLC.Win_Renamed_CastleVictory`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_ArrestAxel`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleNotRenamed`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastlePales`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleRomus`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleToras`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleVictory`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel`
- `RiziaDLCSupport.News_Turn10_RH_Gossip_VinaManusEngaged_PostWar`
- `RiziaDLCSupport.News_Turn10_V_ManusBackFromWarEngaged`
- `RiziaDLCSupport.Reports_Turn10_Pales_ChemicalCleanup`
- `RiziaDLCSupport.Reports_Turn10_Pales_War`
- `RiziaDLCSupport.Reports_Turn10_Remaz_ChemicalCleanup`
- `RiziaDLCSupport.Reports_Turn10_Sallabes_ManusWarHero`
- `RiziaDLCSupport.Reports_Turn10_Solles_ChemicalCleanup`
- `RiziaDLCSupport.Reports_Turn10_Ziqes_ChemicalCleanup`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 33

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.War_Pales_Won_AxelTortured`
- `RiziaDLC.Win_Renamed_CastlePales`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_ArrestAxel`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleNotRenamed`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastlePales`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleRomus`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleToras`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleVictory`
- `RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel`
- `RiziaDLCSupport.News_Turn10_RH_Gossip_VinaManusEngaged_PostWar`
- *...oraz 5 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[117]` (Paskal Beniwoll): `End();`
- Węzeł `[118]` (Paskal Beniwoll): `AddConversant("Axel Reinhart");`
- Węzeł `[119]` (Paskal Beniwoll): `RemoveConversant("Axel Reinhart");`
- Węzeł `[124]` (Paskal Beniwoll): `Variable["RiziaDLC.War_Pales_Won_AxelTortured"] = true; Variable["RiziaDLC.Axel_Arrested"] = true...`
- Węzeł `[129]` (Paskal Beniwoll): `Variable["RiziaDLC.Win_Renamed_CastleRomus"] = true; Variable["RiziaDLCSupport.Journal_Turn10_War...`
- Węzeł `[130]` (Paskal Beniwoll): `Variable["RiziaDLC.Win_Renamed_CastleToras"] = true; Variable["RiziaDLCSupport.Journal_Turn10_War...`
- Węzeł `[131]` (Paskal Beniwoll): `Variable["RiziaDLC.Win_Renamed_CastleVictory"] = true; Variable["RiziaDLCSupport.Journal_Turn10_W...`
- Węzeł `[132]` (Paskal Beniwoll): `Variable["RiziaDLC.Win_Renamed_CastlePales"] = true; Variable["RiziaDLCSupport.Journal_Turn10_War...`
- *...oraz 25 innych węzłów ze skryptami.*

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
  - -> `[133]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was a beautiful, sunny day in Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Narrator**
> "From within the courtyard of Castle Reinhart, near the front gate, I admired the fortress's timeless grandeur."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Most of the city center was prepared for the Victory Parade. Everything seemed clean, as if the war had never happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "However, if anyone went into the back alleys, to government buildings, to residential areas, one would find sandbags lying around and bullet holes on the walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Nothing that couldn't be fixed in due time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[8]`
Mówca: **Narrator**
> "I wondered if I should have it renamed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[11]`
  - -> `[10]`
  - -> `[13]`
  - -> `[9]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "No need."]** — Mówca: **Player_Romus_Italic**
> "I found it unnecessary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "Castle Victory."]** — Mówca: **Player_Romus_Italic**
> "I gestured to an aide and commanded him to rename the castle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "Castle Toras."]** — Mówca: **Player_Romus_Italic**
> "I gestured to an aide and commanded him to rename the castle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "Castle Romus."]** — Mówca: **Player_Romus_Italic**
> "I gestured to an aide and commanded him to rename the castle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "Castle Pales."]** — Mówca: **Player_Romus_Italic**
> "I gestured to an aide and commanded him to rename the castle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[14]`
Mówca: **Narrator**
> "The gates creaked open with a heavy groan, and I spurred my horse, following the parade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Narrator**
> "The marching band started their song. Loud cheers rose from the crowds all around me as I slowly made my way through the capital."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[16]`
Mówca: **Narrator**
> "A child tried to approach my horse with a bouquet of roses. The Golden Guard held her back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "Gesture for her to approach and take the bouquet."]** — Mówca: **Player_Romus_Italic**
> "I gestured for her to approach and I took the bouquet. People clapped and cameras flashed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "Disregard her and follow the protocol."]** — Mówca: **Player_Romus_Italic**
> "I disregarded her and stuck with the protocol."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[19]`
Mówca: **Narrator**
> "The guards grabbed him roughly and took him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_StrongPalesResistance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_StrongPalesResistance == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_StrongPalesResistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_StrongPalesResistance == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_StrongPalesResistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[23]`
Mówca: **Narrator**
> "An old man from the crowd tried to approach my horse with what looked like a cane. He was swinging it over his head, swearing and cursing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Multiple guards immediately jumped on him and held him on the ground. The crowd looked disturbed and curious about what would happen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's just an old man. Let him go. What is he even going to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Straight to prison. Make sure he learns his place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Titus looked towards me for orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`
  - -> `[29]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Off with his head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[32]`
Mówca: **Narrator**
> "The guards let him go. He cursed and disappeared into the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_MorellanAirPlanes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_MorellanAirPlanes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_MorellanAirPlanes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_MorellanAirPlanes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_MorellanAirPlanes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Narrator**
> "A few of our Morellan fighter jets flew by close to the ground, deafening everyone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[37]`
Mówca: **Narrator**
> "Rizian airplanes flew very close to the ground, deafening everyone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[38]`
Mówca: **Narrator**
> "I rode past by tanks and mechanized forces. The long lines of drivers and vehicles simply did not end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_MobileForces_Large == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_MobileForces_Large == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_MobileForces_Large"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_MobileForces_Large == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_MobileForces_Large"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_MobileForces_Medium == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_MobileForces_Medium == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_MobileForces_Medium"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_MobileForces_Medium == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_MobileForces_Medium"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[45]`
Mówca: **Narrator**
> "I rode past by a great number of tanks and mechanized vehicles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[46]`
Mówca: **Narrator**
> "I rode past our tanks and mechanized forces, marveling at how such a small number of them were able to subdue the Palesian army."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[47]`
Mówca: **Narrator**
> "The infantry column, an unending sea of uniforms, was awaiting my salute. There was a thunderous sound as their boots all hit the ground at the same time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Manpower_Massive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Manpower_Massive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_Manpower_Massive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Manpower_Massive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Manpower_High == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Manpower_High == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Manpower_High"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_Manpower_High == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Manpower_High"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Manpower_Average == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Manpower_Average == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Manpower_Average"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_Manpower_Average == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Manpower_Average"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[57]`
Mówca: **Narrator**
> "The infantry column was awaiting my salute. A grand number of troops all hit the ground with their boots and saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[58]`
Mówca: **Narrator**
> "The infantry column was awaiting my salute. They all hit the ground with their boots and saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[59]`
Mówca: **Narrator**
> "The infantry column was awaiting my salute. They all hit the ground with their boots and saluted. Only a few hundred troops were in sight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[60]`
Mówca: **Narrator**
> "I looked at the horizon towards the port of Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_LostPrideOfNavy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_LostPrideOfNavy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_LostPrideOfNavy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_LostPrideOfNavy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_LostPrideOfNavy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[64]`
Mówca: **Narrator**
> "What a shame it was to not have the pride of our navy, our flagship."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Narrator**
> "The Rizian fleet was covering the entirety of the Gulf of Pales, leaving no space for any other vessel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_RiziaFleet_Large == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_RiziaFleet_Large == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_RiziaFleet_Large"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_RiziaFleet_Large == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_RiziaFleet_Large"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_RiziaFleet_Medium == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_RiziaFleet_Medium == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_RiziaFleet_Medium"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_RiziaFleet_Medium == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_RiziaFleet_Medium"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Narrator**
> "The Rizian fleet was covering the Gulf of Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
Mówca: **Narrator**
> "The Rizian fleet -- comprising just a handful of battleships -- floated on the Gulf of Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Narrator**
> "Each battleship deck was full of marines. I could see them saluting from a distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Marines_LargeForce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Marines_LargeForce == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Marines_LargeForce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_Marines_LargeForce == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Marines_LargeForce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Narrator**
> "I could see the marines saluting from a distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[79]`
Mówca: **Narrator**
> "The parade finally stopped and I got off my horse. I patted him on the back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Narrator**
> "In celebration, battleships cannons fired into the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[81]`
Mówca: **Narrator**
> "In front of me, on the grand stairs to my new palace, was Duke Reinhart. Behind him was the Throne of Pales. He was kneeling and looking at the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Narrator**
> "A half-burned Palesian flag landed on my foot. The wind must have brought it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[85]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "Pick it up and handle it with care and honor."]** — Mówca: **Player_Romus_Italic**
> "I picked it up and handled it with care and honor, giving the flag to a nearby guard. The crowd started clapping and chanting my name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "Step on the flag."]** — Mówca: **Player_Romus_Italic**
> "I stepped on the flag intentionally as I walked to the Duke. I heard some gasps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "Rip it up in front of the crowd."]** — Mówca: **Player_Romus_Italic**
> "I picked up the flag and ripped it in front of the crowd. Some began clapping and cheering, others were frowning in silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "Salute them."]** — Mówca: **Player_Romus_Italic**
> "I saluted our brave sailors. I was proud of every single one of them for defeating our enemy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[87]`
Mówca: **Narrator**
> "I approached the defeated man before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[88]`
Mówca: **Axel Reinhart**
> ""That's it, Your Majesty. You've won. Pales surrenders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't be satisfied until you get down and lick my boots.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[90]`
Mówca: **Narrator**
> "He took the crown from his head and presented it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "Put the crown on your head."]** — Mówca: **Player_Romus_Italic**
> "I put the crown on my head. Cheers and chants of my name ensued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "Shove the crown aside."]** — Mówca: **Player_Romus_Italic**
> "I shoved the crown aside. It fell on the ground. Gasps were heard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Axel Reinhart**
> ""I hope that you are satisfied. I have nothing else to say to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[316]`
  - -> `[89]`
  - -> `[94]`
  - -> `[95]`
  - -> `[97]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Apologize to your King. In front of everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Kiss my ring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you enjoy your time in prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You fought valiantly, Axel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[98]`
Mówca: **Axel Reinhart**
> ""What? That's ridiculous. We're both gentlemen here--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Narrator**
> "The guards grabbed him and made him kneel down further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "I smiled as he reluctantly stuck his tongue out and licked my boot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[184]`
  - -> `[183]`

### Węzeł `[101]`
Mówca: **Axel Reinhart**
> ""I won't. I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Narrator**
> "The guards grabbed him and made him kneel down further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Axel Reinhart**
> ""I apologize. Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[184]`
  - -> `[183]`

### Węzeł `[104]`
Mówca: **Axel Reinhart**
> ""Come on. There's no need for--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Narrator**
> "The guards grabbed him and made him kneel down further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Narrator**
> "He kissed the ring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[184]`
  - -> `[183]`

### Węzeł `[107]`
Mówca: **Axel Reinhart**
> ""As did you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Axel Reinhart**
> ""The Grand Duchy is all yours now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Axel Reinhart**
> ""Take good care of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[184]`
  - -> `[183]`

### Węzeł `[110]`
Mówca: **Axel Reinhart**
> ""Prison? I-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[120]`
  - -> `[182]`
  - -> `[191]`
  - -> `[193]`

### Węzeł `[111]`
Mówca: **Narrator**
> "The guards roughly pushed Axel and he fell to the ground. I watched as he was dragged away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[112]`
Mówca: **Narrator**
> "The guards carefully watched him as he walked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[113]`
Mówca: **Narrator**
> "I turned around and looked at Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Narrator**
> "The rays of sun were coming down from the clouds to paint the rooftops golden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[115]`
Mówca: **Narrator**
> "I sat down on the Throne of Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Narrator**
> "My throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `AddConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `RemoveConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you heard of a device called 'Saint Mercy'? We haven't used it since last century. But we're going to break it out of retirement especially for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Won_AxelTortured = true;
RiziaDLC.Axel_Arrested = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel = true;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.War_Pales_Won_AxelTortured"] = true;
Variable["RiziaDLC.Axel_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel"] = true;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[125]`
Mówca: **Narrator**
> "My eyes caught Major Tigris -- now Colonel -- in front of the column."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1Briefing_Frontline == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Operation1Briefing_Frontline == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Operation1Briefing_Frontline"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Operation1Briefing_Frontline == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Operation1Briefing_Frontline"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Win_Renamed_CastleRomus = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleRomus = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Win_Renamed_CastleRomus"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleRomus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Win_Renamed_CastleToras = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleToras = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Win_Renamed_CastleToras"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleToras"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Win_Renamed_CastleVictory = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleVictory = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Win_Renamed_CastleVictory"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleVictory"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Win_Renamed_CastlePales = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastlePales = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Win_Renamed_CastlePales"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastlePales"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleNotRenamed = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_CastleNotRenamed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_ForThePeople", "R_ForThePeople_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_ForThePeople","R_ForThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn10_Pales_War = true;
EnableCollectionItem("CollectionItem_PalesCrown");)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Pales_War"] = true;
EnableCollectionItem("CollectionItem_PalesCrown");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn10_Pales_ChemicalCleanup = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Pales_ChemicalCleanup"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn10_Remaz_ChemicalCleanup = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Remaz_ChemicalCleanup"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn10_Solles_ChemicalCleanup = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Solles_ChemicalCleanup"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn10_Ziqes_ChemicalCleanup = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn10_Ziqes_ChemicalCleanup"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Used_ExperimentalWeapons_Pales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Used_ExperimentalWeapons_Pales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Used_ExperimentalWeapons_Pales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Used_ExperimentalWeapons_Pales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Used_ExperimentalWeapons_Pales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Used_ExperimentalWeapons_Remaz == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Used_ExperimentalWeapons_Remaz == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Used_ExperimentalWeapons_Remaz"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Used_ExperimentalWeapons_Remaz == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Used_ExperimentalWeapons_Remaz"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Used_ExperimentalWeapons_Solles == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Used_ExperimentalWeapons_Solles == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Used_ExperimentalWeapons_Solles"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Used_ExperimentalWeapons_Solles == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Used_ExperimentalWeapons_Solles"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Used_ExperimentalWeapons_Ziqes == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Used_ExperimentalWeapons_Ziqes == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Used_ExperimentalWeapons_Ziqes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Used_ExperimentalWeapons_Ziqes == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Used_ExperimentalWeapons_Ziqes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_Conqueror");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_Conqueror");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Control_Skipped == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Control_Skipped == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Control_Skipped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Control_Skipped == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Control_Skipped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_DiesInWar == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_DiesInWar == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Manus_SendToWar == true && RiziaDLC.Manus_DiesInWar == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Manus_SendToWar"] == true  and  Variable["RiziaDLC.Manus_DiesInWar"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[160]`
Mówca: **Narrator**
> "Manus Sazon led the provincial troops from Brenas. He looked much older and more hardened than the last time I'd seen him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_Gone = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Manus_Gone"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true) && RiziaDLC.Vina_Wedding_Happened == false && RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_FuneralHappened == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true) && RiziaDLC.Vina_Wedding_Happened == false && RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_FuneralHappened == false)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true  or  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true)  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true) && RiziaDLC.Vina_Wedding_Happened == false && RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_FuneralHappened == false))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.Relations_VinaManus_Approve"] == true  or  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true)  and  Variable["RiziaDLC.Vina_Wedding_Happened"] == false  and  Variable["RiziaDLC.Vina_Escapes"] == false  and  Variable["RiziaDLC.Vina_FuneralHappened"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[165]`
Mówca: **Narrator**
> "After returning from the front, the first thing he'd done was request Vina's hand in marriage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "Now that he'd proven himself, it was finally time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus_Italic**
> "I'd refused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus = true; 
RiziaDLC.Relations_Vina += 3; RiziaDLCSupport.News_Turn10_RH_Gossip_VinaManusEngaged_PostWar = true;
RiziaDLCSupport.News_Turn10_V_ManusBackFromWarEngaged = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] = true;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 3;
Variable["RiziaDLCSupport.News_Turn10_RH_Gossip_VinaManusEngaged_PostWar"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_ManusBackFromWarEngaged"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 3;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Faction_HouseSazon_Leona = false;
RiziaDLC.Faction_HouseSazon_Angelica = false;
RiziaDLC.Faction_HouseSazon_Manus = true;
RiziaDLCSupport.Reports_Turn10_Sallabes_ManusWarHero = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Faction_HouseSazon_Leona"] = false;
Variable["RiziaDLC.Faction_HouseSazon_Angelica"] = false;
Variable["RiziaDLC.Faction_HouseSazon_Manus"] = true;
Variable["RiziaDLCSupport.Reports_Turn10_Sallabes_ManusWarHero"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseOfDelegates_Abolished == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_HouseOfDelegates", "HODPosition_Speaker", "HOD_Speaker_ManusSazon");)*
- **Efekt (`userScript`):** `AssignConnection("Page_HouseOfDelegates","HODPosition_Speaker","HOD_Speaker_ManusSazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AssignConnection("Page_HouseOfDelegates", "HODPosition_NotableMember_2", "HOD_RPP_Member_ManusSazon");)*
- **Efekt (`userScript`):** `AssignConnection("Page_HouseOfDelegates","HODPosition_NotableMember_2","HOD_RPP_Member_ManusSazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Much appreciated. Guards, arrest this man for his many, many violent acts against Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will. Guards, arrest this man for his many, many violent acts against Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Axel Reinhart**
> ""What? But--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[191]`
  - -> `[193]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are a war criminal and you must be treated appropriately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As you walk free today, remember the mercy King Romus Toras showed you. It is more than you deserve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have done what any monarch would in your situation. You have my blessing to leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One more thing. I want him tortured. The so-called Duke will beg for his life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[189]`
Mówca: **Axel Reinhart**
> ""A war criminal? How dare y--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Axel_Arrested = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_ArrestAxel = true;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Axel_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_ArrestAxel"] = true;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will stay there until you have repented for your infringement on my kingdom's sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Axel Reinhart**
> ""I swear to you, I've repented already--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not another word from you, Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Narrator**
> "He shut his mouth, resigned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[195]`
Mówca: **Narrator**
> "He bowed low to the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Axel Reinhart**
> ""Thank you, Your Majesty. I will not forget this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_WehlenJoined == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_WehlenJoined == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_WehlenJoined"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_WehlenJoined == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_WehlenJoined"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[200]`
Mówca: **Narrator**
> "I rode past a small number of tanks and mechanized forces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_WehlenJoined == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_WehlenJoined == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_WehlenJoined"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_WehlenJoined == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_WehlenJoined"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[204]`
Mówca: **Narrator**
> "Behind them was a massive swell of soldiers from the Wehzek Armed Forces. They marched with grim-faced determination, a contrast to the jubilation of my own troops."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Enable_Policy_RD_Welfare_KingsCars == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Enable_Policy_RD_Welfare_KingsCars == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Enable_Policy_RD_Welfare_KingsCars"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Enable_Policy_RD_Welfare_KingsCars == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Enable_Policy_RD_Welfare_KingsCars"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[217]`
Mówca: **Narrator**
> "The gates opened with a heavy groan, revealing Rizia's interim prime minister, Daria de Rava, seated in the back of a luxurious open-top car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[218]`
Mówca: **Narrator**
> "An oversized Rizian flag flapped majestically in the wind, a proud emblem against its imposing stone walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[219]`
Mówca: **Daria de Rava**
> ""What a glorious day for a parade, Your Majesty. The skies seem to be celebrating with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[221]`
  - -> `[222]`
  - -> `[228]`
  - -> `[224]`

### Węzeł `[220]`
Mówca: **Narrator**
> "I nudged my horse forward until I was alongside her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A reminder of why we keep fighting for Rizia’s future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A parade is just a show. The real work remains ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is a celebration of those who earned victory, not merely observed it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, yes, the skies. Always so supportive in matters of war and statecraft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, the heavens themselves seem to honor the sacrifices made for this victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[232]`
Mówca: **Narrator**
> "Daria’s smile faltered, but she quickly regained her composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[233]`
Mówca: **Daria de Rava**
> ""A future worth fighting for, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[234]`
Mówca: **Daria de Rava**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[235]`
Mówca: **Daria de Rava**
> ""Indeed, Your Majesty. But even victories deserve a moment in the sun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[236]`
Mówca: **Daria de Rava**
> ""The skies were certainly kind to us in this war. Our brave air force helped save the day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[237]`
Mówca: **Narrator**
> "The gates opened with a heavy groan, revealing Rizia's interim prime minister, Manus Sazon, seated in the back of a luxurious open-top car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Narrator**
> "I nudged my horse forward until I was alongside him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Manus Sazon**
> ""A glorious day for a parade, Your Majesty. The skies seem to be celebrating with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[221]`
  - -> `[231]`
  - -> `[222]`
  - -> `[224]`

### Węzeł `[240]`
Mówca: **Narrator**
> "Manus' smile wavered, but he quickly regained his composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[244]`
Mówca: **Manus Sazon**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[245]`
Mówca: **Manus Sazon**
> "Of course, Your Majesty. But even victories deserve a moment in the sun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[246]`
Mówca: **Manus Sazon**
> ""Indeed, a future worth fighting for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[247]`
Mówca: **Narrator**
> "The gates opened with a heavy groan, revealing Rizia's interim prime minister, Adarfo Sotelato, seated in the back of one of the vehicles from the King's Cars initiative."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Narrator**
> "Recently renamed The People's Car, it was simple and unadorned, embodying practicality over extravagance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Narrator**
> "The gates opened with a heavy groan, revealing Rizia's interim prime minister, Adarfo Sotelato, seated in the back of a open-top car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Narrator**
> "I nudged my horse forward until I was alongside him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Adarfo Sotelato**
> ""Parades like this mask the true cost of war, glossing over the sacrifices of the working class who fought and died.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[222]`
  - -> `[253]`
  - -> `[252]`

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps, but even the working class needs to see that their sacrifices weren't in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""War demands sacrifice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Adarfo Sotelato**
> ""Sacrifice from some, profit for others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[255]`
Mówca: **Adarfo Sotelato**
> ""Agreed. Those who bled for this victory must reap the rewards, not just the privileged few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Narrator**
> "Manus' smile faltered, but he quickly regained his composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[275]`
Mówca: **Narrator**
> "Adarfo’s gaze hardened before slowly turning away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[276]`
**[WYBÓR GRACZA: "Allow the Prime Minister to go ahead of you."]** — Mówca: **Player_Romus_Italic**
> "I allowed the Prime Minister to go ahead of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[277]`
**[WYBÓR GRACZA: "Ride alongside them."]** — Mówca: **Player_Romus_Italic**
> "I rode alongside the Prime Minister to stand as equals."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[278]`
**[WYBÓR GRACZA: "Have them follow behind you."]** — Mówca: **Player_Romus_Italic**
> "I had the Prime Minister follow behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Narrator**
> "The sound of drums began, signaling the start of the grand procession."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`
  - -> `[278]`

### Węzeł `[280]`
Mówca: **Narrator**
> "Loud cheers rose from the crowds all around as I slowly made my way through the capital."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[287]`
Mówca: **Narrator**
> "Daria followed alongside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[288]`
Mówca: **Narrator**
> "Manus followed alongside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[292]`
Mówca: **Narrator**
> "Adarfo followed alongside me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Daria de Rava");)*
- **Efekt (`userScript`):** `AddConversant("Daria de Rava");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Manus Sazon");)*
- **Efekt (`userScript`):** `AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Adarfo Sotelato");)*
- **Efekt (`userScript`):** `AddConversant("Adarfo Sotelato");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[305]`
Mówca: **Daria de Rava**
> ""Your Majesty, I agree with your order to take Duke Reinhart into custody, but torture is a bridge too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`
  - -> `[313]`

### Węzeł `[306]`
Mówca: **Manus Sazon**
> ""Your Majesty, I agree with your order to take Duke Reinhart into custody, but I will not condone such an inhumane punishment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[311]`
  - -> `[312]`
  - -> `[313]`

### Węzeł `[307]`
Mówca: **Adarfo Sotelato**
> ""Your Majesty, I agree with your order to take Duke Reinhart into custody, but I forbid you to have him tortured.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`
  - -> `[313]`

### Węzeł `[308]`
Mówca: **Axel Reinhart**
> ""Torture?! Now wait a sec--"""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Won_AxelTortured = true;
RiziaDLC.Axel_Arrested = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel = true;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.War_Pales_Won_AxelTortured"] = true;
Variable["RiziaDLC.Axel_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel"] = true;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[310]`
Mówca: **Axel Reinhart**
> ""You mean to torture me?! Now wait a sec--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, of course. My apologies. I got ahead of myself there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Damned rules and their constraints! But fine. I'll allow it to stand, for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. You win this round.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Narrator**
> "Rizia's new prime minister signaled to the guards, who took hold of Axel and dragged him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Won_AxelTortured = false;
RiziaDLC.Axel_Arrested = true; RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel = false;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.War_Pales_Won_AxelTortured"] = false;
Variable["RiziaDLC.Axel_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_War_Pales_Operation2_Success_TortureAxel"] = false;
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_Arrested");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry for everything that happened. But trust me, this is for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Titus_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Titus_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[323]`
Mówca: **Narrator**
> "My guards looked towards me for orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`
  - -> `[29]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Manus == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_PrimeMinister_Daria == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[333]`
Mówca: **Narrator**
> "Daria nodded, confirming the order. The guards grabbed him roughly and took him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[334]`
Mówca: **Adarfo Sotelato**
> ""What?! Absolutely not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[335]`
Mówca: **Manus Sazon**
> ""Disregard His Majesty's order. The man goes free.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[339]`
Mówca: **Narrator**
> "The Prime Minister and I watched as the guards dragged him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Airforce_Total_Large == true || RiziaDLC.Situation_Military_Airforce_Defence_Strong == true || RiziaDLC.Situation_Military_Airforce_Offence_Strong == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Airforce_Total_Large == true || RiziaDLC.Situation_Military_Airforce_Defence_Strong == true || RiziaDLC.Situation_Military_Airforce_Offence_Strong == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Airforce_Total_Large"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Defence_Strong"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Offence_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_Airforce_Total_Large == true || RiziaDLC.Situation_Military_Airforce_Defence_Strong == true || RiziaDLC.Situation_Military_Airforce_Offence_Strong == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Airforce_Total_Large"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Defence_Strong"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Offence_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
Mówca: **Narrator**
> "Daria's smile wavered, but she quickly regained her composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Airforce_Total_Large == true || RiziaDLC.Situation_Military_Airforce_Defence_Strong == true || RiziaDLC.Situation_Military_Airforce_Offence_Strong == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Military_Airforce_Total_Large == true || RiziaDLC.Situation_Military_Airforce_Defence_Strong == true || RiziaDLC.Situation_Military_Airforce_Offence_Strong == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Military_Airforce_Total_Large"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Defence_Strong"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Offence_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Military_Airforce_Total_Large == true || RiziaDLC.Situation_Military_Airforce_Defence_Strong == true || RiziaDLC.Situation_Military_Airforce_Offence_Strong == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Military_Airforce_Total_Large"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Defence_Strong"] == true  or  Variable["RiziaDLC.Situation_Military_Airforce_Offence_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[347]`
Mówca: **Manus Sazon**
> ""The skies were certainly kind to us in this war. It was our air force that helped us best Pales, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_PrimeMinister_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true  and  Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_FuneralHappened == true && RiziaDLC.Reform_PrimeMinister_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == true  and  Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[351]`
Mówca: **Manus Sazon**
> ""I only wish Vina -- Her Highness -- had lived to see this day...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Manus. It's his fault she's dead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_FuneralHappened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_FuneralHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_FuneralHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_FuneralHappened"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[356]`
Mówca: **Narrator**
> "Pain mixed with anger on the Prime Minister's face. He could barely choke out his next words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Manus Sazon**
> ""Fine. Do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_PalesCrown");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_PalesCrown");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[362]`
Mówca: **Narrator**
> "A child tried to approach my horse with a bouquet of roses. Wruhec's Guardians held her back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseSazon_Conquered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseSazon_Conquered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseSazon_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseSazon_Conquered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseSazon_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[366]`
Mówca: **Narrator**
> "He'd returned from the front only to find his home province in Crown hands, his family in disarray and the House of Delegates dismantled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseOfDelegates_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Narrator**
> "He'd returned from the front only to find his home province in Crown hands and his family in disarray."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Narrator**
> "I almost felt bad for him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[372]`
Mówca: **Narrator**
> "Rows of polished medals gleamed across his chest, their ribbons crisp and colors sharp against the dark fabric of his uniform."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("Rizia_OfficerSazon");)*
- **Efekt (`userScript`):** `UnlockAchievement("Rizia_OfficerSazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Winning the War against the Grand-Duchy of Pales", "Old Town", "Grand-Duchy of Pales");)*
- **Efekt (`userScript`):** `SetRichPresence("Winning the War against the Grand-Duchy of Pales","Old Town","Grand-Duchy of Pales");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Making the Grand-Duke kiss their boot", "Old Town", "Grand-Duchy of Pales");)*
- **Efekt (`userScript`):** `SetRichPresence("Making the Grand-Duke kiss their boot","Old Town","Grand-Duchy of Pales");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
