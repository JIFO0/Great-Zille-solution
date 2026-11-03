# Rizia/Survived

- **ID konwersacji:** `429`
- **StoryPack:** `Rizia`
- **Tura:** `Epilogue (Survived)`
- **Lokalizacja pliku:** `Rizia/Epilogue/429_Survived.md`
- **Liczba węzłów dialogowych:** 351
- **Liczba wyborów gracza:** 48

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_Executed`
- `RiziaDLC.AxelVina_Married_Official`
- `RiziaDLC.Azaro_HasPowerToCoup`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Invited_Vina`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Coup_Leader_Hugo`
- `RiziaDLC.Coup_Leader_Lucita`
- `RiziaDLC.Coup_Leader_Rico`
- `RiziaDLC.Coup_Leader_Taddeus`
- `RiziaDLC.Ending_Coup_Toras`
- `RiziaDLC.Ending_Reform_Coup_Toras`
- `RiziaDLC.Epilogue_Coup_Survived_WithEstela`
- `RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina`
- `RiziaDLC.Epilogue_Revolution_Survived_WithLucita`
- `RiziaDLC.Epilogue_Revolution_Survived_WithPabel`
- `RiziaDLC.Epilogue_Survived_BirthdayStrike`
- `RiziaDLC.Epilogue_Survived_ConstitutionSigning`
- `RiziaDLC.Epilogue_Survived_HouseFallouts`
- `RiziaDLC.Epilogue_Survived_Revolution`
- `RiziaDLC.Epilogue_Survived_RevolutionaryFail`
- `RiziaDLC.Estela_EarlyExile`
- `RiziaDLC.HouseToras_Conquered`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Executed`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_InjuredInRevolution`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Lucita_Pregnant`
- `RiziaDLC.Manus_Arrested`
- `RiziaDLC.Manus_Executed`
- `RiziaDLC.Pabel_InjuredInRevolution`
- `RiziaDLC.Policy_Diplomacy_GRACEMember`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_Vina_Estranged`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Successor_Son`
- `RiziaDLC.Vina_DuchessOfValenqiris`
- `RiziaDLC.Vina_EarlyExile`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Manus`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Coup_Leader_Hugo`
- `RiziaDLC.Coup_Leader_Lucita`
- `RiziaDLC.Coup_Leader_Taddeus`
- `RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue`
- `RiziaDLC.Epilogue_CivilWar_Monqiz`
- `RiziaDLC.Epilogue_CivilWar_TorasAlly`
- `RiziaDLC.Epilogue_CivilWar_WinPoints`
- `RiziaDLC.Epilogue_ExileTogether_Estela`
- `RiziaDLC.Epilogue_ExileTogether_Lucita`
- `RiziaDLC.Epilogue_ExileTogether_Manus`
- `RiziaDLC.Epilogue_ExileTogether_Pabel`
- `RiziaDLC.Epilogue_ExileTogether_Vina`
- `RiziaDLC.Epilogue_Exile_DecidedInEpilogue`
- `RiziaDLC.Epilogue_Exile_Forced`
- `RiziaDLC.Epilogue_Exile_Rumburg`
- `RiziaDLC.Epilogue_LeftForExileAlone`
- `RiziaDLC.Estela_EarlyExile`
- `RiziaDLC.Manus_EarlyExile`
- `RiziaDLC.Vina_EarlyExile`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[425] Rizia/Epilogue** (../Epilogue/425_Epilogue.md), Węzeł `[19]`
- Węzeł `[152]` -> **[428] Rizia/Prison** (../Epilogue/428_Prison.md), Węzeł `[53]`
- Węzeł `[252]` -> **[426] Rizia/Exile** (../Epilogue/426_Exile.md), Węzeł `[720]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 60

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue`
- `RiziaDLC.Epilogue_CivilWar_Monqiz`
- `RiziaDLC.Epilogue_CivilWar_TorasAlly`
- `RiziaDLC.Epilogue_CivilWar_WinPoints`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[62]` (Paskal Beniwoll): `--;`
- Węzeł `[68]` (Paskal Beniwoll): `--;`
- Węzeł `[69]` (Paskal Beniwoll): `--;`
- Węzeł `[70]` (Paskal Beniwoll): `Variable["RiziaDLC.Epilogue_CivilWar_Monqiz"] = true;`
- Węzeł `[71]` (Paskal Beniwoll): `Variable["RiziaDLC.Epilogue_Exile_Rumburg"] = true;`
- Węzeł `[72]` (Paskal Beniwoll): `--;`
- Węzeł `[73]` (Paskal Beniwoll): `Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = true;`
- Węzeł `[74]` (Paskal Beniwoll): `Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = true;`
- *...oraz 52 innych węzłów ze skryptami.*

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
  - -> `[224]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `425` (*Rizia/Epilogue*), Węzeł `[19]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_ConstitutionSigning == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_ConstitutionSigning == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Survived_ConstitutionSigning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Survived_ConstitutionSigning == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Survived_ConstitutionSigning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_HouseFallouts == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_HouseFallouts == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Survived_HouseFallouts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Survived_HouseFallouts == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Survived_HouseFallouts"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Survived Constitution Signing)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Survived House Fallouts Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Survived Constitution Signing])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Survived House Fallouts Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[13]`
Mówca: **Narrator**
> "You were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the plotters had already taken control of key locations around the capital and arrested the entirety of the Rizian People's Party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the plotters had already taken control of key locations around the capital, with scattered forces lurking in the city's shadows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had no idea who was on your side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Survived Revolution Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Survived Revolution Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the revolutionaries had already taken control of key locations around the capital, and that several low-ranking commanders had given them their support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had no idea who was on your side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had no idea of knowing who was on your side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Coup_Survived_WithEstela == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Coup_Survived_WithEstela == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstela"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Coup_Survived_WithEstela == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstela"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[39]`
Mówca: **Narrator**
> "According to the intelligence you received, militants from Su Omina commanded by Ricardus Toras were fighting with the forces that still remained loyal to you. 

The capital was in complete chaos and there was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Revolution_Survived_WithLucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Revolution_Survived_WithLucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Revolution_Survived_WithPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Revolution_Survived_WithPabel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_InjuredInRevolution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_InjuredInRevolution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_InjuredInRevolution == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pabel_InjuredInRevolution == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pabel_InjuredInRevolution == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pabel_InjuredInRevolution"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "Together with Pabel, you were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the revolutionaries had already taken control of key locations around the capital, and that several low-ranking commanders had given them their support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

As the guards tended to Pabel's wounds, you learned that the revolutionaries had already taken control of key locations around the capital, and that several low-ranking commanders had given them their support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "Together with Lucita, you were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the revolutionaries had already taken control of key locations around the capital, and that several low-ranking commanders had given them their support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

As the guards tended to Lucita's wounds, you learned that the revolutionaries had already taken control of key locations around the capital, and that several low-ranking commanders had given them their support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You and your mother were both taken to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the plotters had already taken control of key locations around the capital, with scattered forces lurking in the city's shadows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You, Vina and your mother were taken to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the plotters had already taken control of key locations around the capital, with scattered forces lurking in the city's shadows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[58]`
Mówca: **Narrator**
> "According to the intelligence you received, Toras divisions commanded by Hugo were fighting with the forces that still remained loyal to you. 

The capital was in complete chaos and there was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[59]`
Mówca: **Narrator**
> "According to the intelligence you received, Azaro divisions commanded by Lucita were fighting with the forces that still remained loyal to you. 

The capital was in complete chaos and there was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Narrator**
> "According to the intelligence you received, Azaro divisions commanded by Taddeus were fighting with the forces that still remained loyal to you. 

The capital was in complete chaos and there was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Narrator**
> "According to the intelligence you received, Sazon divisions commanded by Angelica were fighting with the forces that still remained loyal to you. 

The capital was in complete chaos and there was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...stayed where you were to organize a defense."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to regroup in Monqiz."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You decided to flee to Rumburg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...planned your escape from Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[67]`
Mówca: **Narrator**
> "According to the intelligence you received, after a declaration made by the revolutionaries, the royal divisions stationed in Rizia Imperii had surrendered their weapons.

They were now everywhere in the capital and there was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[221]`
  - -> `[66]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_CivilWar_Monqiz = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_CivilWar_Monqiz"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Exile_Rumburg = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Exile_Rumburg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_DuchessOfValenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_DuchessOfValenqiris == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_Reform_Coup_Toras == true || RiziaDLC.Coup_Leader_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_Reform_Coup_Toras == true || RiziaDLC.Coup_Leader_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Ending_Reform_Coup_Toras"] == true  or  Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_Reform_Coup_Toras == true || RiziaDLC.Coup_Leader_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Ending_Reform_Coup_Toras"] == true  or  Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[84]`
Mówca: **Narrator**
> "You were immediately pinned down and handcuffed by the guards. It was over.

Hugo's forces had taken control of the palace before your arrival. They escorted you to a cell.

It was where Vina was being kept."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "1957|Monqiz"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to Valenqiris.

You traveled incognito in a series of trains and taxicabs until you finally reached the gates of Palas Toras in Monqiz."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "1957|Monqiz"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to Valenqiris.

When you arrived in Monqiz, you were welcomed with open arms by your cousin, Hubertus, who offered to deploy the Toras forces to defend you.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "1957|Monqiz"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to Valenqiris.

When you arrived in Monqiz, you were welcomed by Vina, who offered to deploy House Toras' forces to help you reclaim the throne.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_Revolution == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_Revolution == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Survived_Revolution"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Survived_Revolution == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Survived_Revolution"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "1957|Monqiz"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to Valenqiris.

When you arrived in Monqiz, you were welcomed with open arms by your cousin, Hubertus, who offered to help you gather support.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You were back home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC.Hugo_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC.Hugo_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC.Hugo_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true || (RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC.Hugo_Arrested == false && RiziaDLC.Hugo_Executed == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true || (RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC.Hugo_Arrested == false && RiziaDLC.Hugo_Executed == false))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true  or  (Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false  and  Variable["RiziaDLC.Hugo_Executed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Hugo == true || (RiziaDLC.Council_GrandVizier_Hugo == false && RiziaDLC.Hugo_Arrested == false && RiziaDLC.Hugo_Executed == false)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true  or  (Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false  and  Variable["RiziaDLC.Hugo_Arrested"] == false  and  Variable["RiziaDLC.Hugo_Executed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You embraced her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You asked for her forgiveness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[101]`
Mówca: **Narrator**
> "You were immediately pinned down and handcuffed by the guards. It was over.

Hubertus' men had already toppled Vina before your arrival. They escorted you to a cell.

It was where Vina was being kept."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[102]`
Mówca: **Narrator**
> "Inside, you were immediately pinned down and handcuffed by Hubertus' soldiers. It was over.

He told you that he was sorry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "They put you in a cell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[104]`
Mówca: **Narrator**
> "Inside, you were immediately pinned down and handcuffed by Hugo's soldiers. It was over.

He had already taken control of the region. He told you that he was sorry for what happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to fight back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to leave the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue = true; RiziaDLC.Epilogue_CivilWar_TorasAlly = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue"] = true;
Variable["RiziaDLC.Epilogue_CivilWar_TorasAlly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_ExileTogether_Estela = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Estela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // WAR)*
- **Efekt (`userScript`):** `-- WAR;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_EarlyExile == false && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC.AxelVina_Married_Official == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_EarlyExile == false && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC.AxelVina_Married_Official == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_EarlyExile"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Relations_Vina_Estranged"] == false  and  Variable["RiziaDLC.AxelVina_Married_Official"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_EarlyExile == false && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC.AxelVina_Married_Official == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_EarlyExile"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Relations_Vina_Estranged"] == false  and  Variable["RiziaDLC.AxelVina_Married_Official"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_ExileTogether_Vina = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Revolution_Survived_WithLucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Revolution_Survived_WithLucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Revolution_Survived_WithLucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Revolution_Survived_WithPabel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Revolution_Survived_WithPabel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Revolution_Survived_WithPabel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_ExileTogether_Lucita = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Lucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_ExileTogether_Pabel = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Pabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[125]`
Mówca: **Narrator**
> "After several rough nights of sleep in the cell, you were finally visited by Hubertus.

Hugo had been crowned king in Porte Drazon. 

He told you that you and your loved ones were allowed to leave the country by his royal permission."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Rico == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Rico == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_ExileTogether_Estela = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Estela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Coup_Survived_WithEstela == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Coup_Survived_WithEstela == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstela"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Coup_Survived_WithEstela == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstela"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Coup_Survived_WithEstelaVina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_ExileTogether_Estela = true; RiziaDLC.Epilogue_ExileTogether_Vina = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Estela"] = true;
Variable["RiziaDLC.Epilogue_ExileTogether_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_ExileTogether_Vina = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[148]`
Mówca: **Narrator**
> "After several rough nights of sleep in the cell, you were finally visited by Hubertus.

Rico had been crowned king in Porte Drazon. 

He told you that you and your loved ones were allowed to leave the country by his royal permission."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[149]`
Mówca: **Narrator**
> "After several rough nights of sleep in the cell, you were finally visited by Hubertus.

Lucita had been crowned queen in Porte Drazon. 

He told you that you and your loved ones were allowed to leave the country by her royal permission."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[150]`
Mówca: **Narrator**
> "After several rough nights of sleep in the cell, you were finally visited by Hubertus.

Angelica had been crowned queen in Porte Drazon. 

He told you that you and your loved ones were allowed to leave the country by her royal permission."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[151]`
Mówca: **Narrator**
> "After several rough nights of sleep in the cell, you were finally visited by Hubertus.

Taddeus had been crowned king in Porte Drazon. 

They transported you to another prison in the capital."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Epilogue Taddeus Coup Arrest])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `428` (*Rizia/Prison*), Węzeł `[53]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You were rushed to the airport."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[155]`
**[WYBÓR GRACZA: "1957|Escape from Rizia"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to a secret harbor on the Sudis Sea.

The moment your boat set out on the water, you let out a deep sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_GRACEMember == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_GRACEMember == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had made it out alive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[160]`
**[WYBÓR GRACZA: "1957|Escape from Rizia"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to a secret harbor on the Sudis Sea.

The moment your boat set out on the water, you let out a deep sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You went to Kyrute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_coup");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_coup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_coup");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_coup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_revolution"))*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_revolution");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to fight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to leave the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_CivilWar_DecidedInEpilogue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_civilwardemocrat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_civilwardemocrat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_navy_mutiny");)*
- **Efekt (`userScript`):** `PrologueImage("pe_navy_mutiny");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_monqiz");)*
- **Efekt (`userScript`):** `PrologueImage("pe_monqiz");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_monqiz");)*
- **Efekt (`userScript`):** `PrologueImage("pe_monqiz");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_jail");)*
- **Efekt (`userScript`):** `PrologueImage("pe_jail");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_civilwardemocrat2");)*
- **Efekt (`userScript`):** `PrologueImage("pe_civilwardemocrat2");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_suitcase");)*
- **Efekt (`userScript`):** `PrologueImage("pe_suitcase");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_exilethornbrough");)*
- **Efekt (`userScript`):** `PrologueImage("pe_exilethornbrough");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_exilekyrute");)*
- **Efekt (`userScript`):** `PrologueImage("pe_exilekyrute");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_suitcase");)*
- **Efekt (`userScript`):** `PrologueImage("pe_suitcase");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_plane");)*
- **Efekt (`userScript`):** `PrologueImage("pe_plane");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[179]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You managed to make it to a hidden emergency facility on the outskirts of Porte Drazon.

Days passed in darkness, with no news of how the incident at the library had ended or who had survived it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Birthday_HouseTakeoverFails)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had no idea who was on your side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[194]`
Mówca: **Narrator**
> "Eventually, you received word that divisions from Houses Toras, Sazon and Azaro were fighting with the forces that still remained loyal to you. 

They were rallying behind Hugo as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[195]`
Mówca: **Narrator**
> "Eventually, you received word that divisions from Houses Toras and Sazon were fighting with the forces that still remained loyal to you. 

They were rallying behind Hugo as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[196]`
Mówca: **Narrator**
> "Eventually, you received word that divisions from Houses Toras and Azaro were fighting with the forces that still remained loyal to you. 

They were rallying behind Hugo as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[197]`
Mówca: **Narrator**
> "Eventually, you received word that divisions from Houses Azaro and Sazon were fighting with the forces that still remained loyal to you. 

They were rallying behind Taddeus as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[198]`
Mówca: **Narrator**
> "Eventually, you received word that House Toras divisions commanded by Hugo were fighting with the forces that still remained loyal to you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[205]`
Mówca: **Narrator**
> "Eventually, you received word that divisions commanded by House Azaro were fighting with the forces that still remained loyal to you. 

They were rallying behind Taddeus as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[206]`
Mówca: **Narrator**
> "Eventually, you received news of the capital's descent into chaos. 

In the wake of the incident, House Sazon's forces had tried to strike Houses Toras and Azaro. In response, the Azaros rallied behind Hugo to stop them.

There was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Epilogue_Survived_BirthdayStrike == true) || RiziaDLC.HouseToras_Conquered == true || RiziaDLC.Epilogue_Survived_RevolutionaryFail == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Epilogue_Survived_BirthdayStrike == true) || RiziaDLC.HouseToras_Conquered == true || RiziaDLC.Epilogue_Survived_RevolutionaryFail == true)*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.Epilogue_Survived_BirthdayStrike"] == true)  or  Variable["RiziaDLC.HouseToras_Conquered"] == true  or  Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true && RiziaDLC.Epilogue_Survived_BirthdayStrike == true) || RiziaDLC.HouseToras_Conquered == true || RiziaDLC.Epilogue_Survived_RevolutionaryFail == true))*
- **Warunek (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  and  Variable["RiziaDLC.Epilogue_Survived_BirthdayStrike"] == true)  or  Variable["RiziaDLC.HouseToras_Conquered"] == true  or  Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_BirthdayStrike == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_BirthdayStrike == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Survived_BirthdayStrike"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Survived_BirthdayStrike == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Survived_BirthdayStrike"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Birthday_HouseTakeoverFails])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_coup");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_coup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Birthday_RevolutionaryFail)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[217]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You managed to make it to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that the Golden Guard had already taken control of key revolutionary locations around the capital. Adarfo Sotelato had been killed, and his movement was scattered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had no idea who was on your side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Consequence", "R_Consequence_Loop");
PrologueImage("pe_coup");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Consequence","R_Consequence_Loop");
PrologueImage("pe_coup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[220]`
Mówca: **Narrator**
> "According to the intelligence you received, Titus was personally leading the hunt for your head, and the royal divisions stationed in Rizia Imperii had sworn allegiance to Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_RevolutionaryFail == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_RevolutionaryFail == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Survived_RevolutionaryFail == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_RevolutionaryFail == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Survived_RevolutionaryFail == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Epilogue_Survived_RevolutionaryFail == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Epilogue_Survived_RevolutionaryFail"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Birthday_RevolutionaryFail])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Religious_WruhecsGuardians_Sal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Religious_WruhecsGuardians_Sal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[231]`
**[WYBÓR GRACZA: "1957|Porte Drazon"]** — Mówca: **Narrator**
> "You managed to make it to the hidden emergency facilities on the outskirts of Porte Drazon.

You learned that Wruhec's Guardians had already taken control of key revolutionary locations around the capital. Adarfo Sotelato had been killed, and his movement was scattered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC.Vina_EarlyExile == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC.Vina_EarlyExile == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_Estranged"] == false  and  Variable["RiziaDLC.Vina_EarlyExile"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_Estranged == false && RiziaDLC.Vina_EarlyExile == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_Estranged"] == false  and  Variable["RiziaDLC.Vina_EarlyExile"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coup_Leader_Lucita == false && RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coup_Leader_Lucita"] == false  and  Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_ExileTogether_Lucita = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Lucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_ExileTogether_Pabel = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Pabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Manus_Arrested"] == false  and  Variable["RiziaDLC.Manus_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.Manus_Arrested == false && RiziaDLC.Manus_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.Manus_Arrested"] == false  and  Variable["RiziaDLC.Manus_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_ExileTogether_Manus = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Manus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == false && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Relations_Vina_Estranged == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == false && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Relations_Vina_Estranged == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Relations_Vina_Estranged"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Axel == false && RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.Relations_Vina_Estranged == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == false  and  Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.Relations_Vina_Estranged"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_ExileTogether_Vina = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_ExileTogether_Estela = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_ExileTogether_Estela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Airplane Exile])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `426` (*Rizia/Exile*), Węzeł `[720]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_Exile_DecidedInEpilogue = true;
RiziaDLC.Epilogue_Exile_Forced = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_Exile_DecidedInEpilogue"] = true;
Variable["RiziaDLC.Epilogue_Exile_Forced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_EarlyExile == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_EarlyExile == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_EarlyExile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_EarlyExile == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_EarlyExile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[257]`
**[WYBÓR GRACZA: "1957|Escape from Rizia"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to a secret harbor on the Sudis Sea.

You knew your family was already at a hotel in Kyrute. Estela had some money set aside for a beachside villa there.

But Queen Beatrice had also offered you and your loved ones a safe haven in Rumburg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[161]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_EarlyExile == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_EarlyExile == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_EarlyExile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_EarlyExile == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_EarlyExile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[261]`
**[WYBÓR GRACZA: "1957|Escape from Rizia"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to a secret harbor on the Sudis Sea.

You knew your family was already at a hotel in Kyrute. Estela had some money set aside for a beachside villa there.

The moment your boat set out on the water, you let out a deep sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_LeftForExileAlone = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_LeftForExileAlone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[161]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_LeftForExileAlone = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_LeftForExileAlone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Taddeus = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Taddeus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Son == true && RiziaDLC.Azaro_HasPowerToCoup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Successor_Son == true && RiziaDLC.Azaro_HasPowerToCoup == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Successor_Son"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Successor_Son == true && RiziaDLC.Azaro_HasPowerToCoup == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Successor_Son"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[269]`
Mówca: **Narrator**
> "Eventually, you received news of the capital's descent into chaos. 

In the wake of the incident, House Sazon's forces had tried to strike Houses Toras and Azaro. In response, House Toras rallied behind General Taddeus to stop them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Estela_EarlyExile == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Estela_EarlyExile == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Estela_EarlyExile"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Estela_EarlyExile == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Estela_EarlyExile"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == true && RiziaDLC.Adarfo_Executed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Adarfo_Arrested == true && RiziaDLC.Adarfo_Executed == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == true  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Adarfo_Arrested == true && RiziaDLC.Adarfo_Executed == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == true  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[276]`
Mówca: **Narrator**
> "After another few days, you learned that the revolutionaries had freed Adarfo Sotelato from prison. The royal divisions stationed in Rizia Imperii had surrendered their weapons.

They were now everywhere in the capital and there was no guarantee of your security. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Hugo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Hugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_CivilWar_WinPoints += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_CivilWar_WinPoints"] = Variable["RiziaDLC.Epilogue_CivilWar_WinPoints"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[282]`
**[WYBÓR GRACZA: "1957|Monqiz"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to Valenqiris.

When you arrived in Monqiz, you were welcomed with open arms by your cousin, Hubertus, who offered to support you with House Toras' forces.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Epilogue_CivilWar_WinPoints += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Epilogue_CivilWar_WinPoints"] = Variable["RiziaDLC.Epilogue_CivilWar_WinPoints"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[287]`
**[WYBÓR GRACZA: "1957|Monqiz"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to Valenqiris.

When you arrived in Monqiz, you were welcomed with open arms by your cousin, Hubertus, who offered to help you gather support.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
**[WYBÓR GRACZA: "1957|Monqiz"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to Valenqiris.

When you arrived in Monqiz, you were welcomed by Vina, who offered to help you gather support to reclaim the throne.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Their forces were everywhere."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true && RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true && RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true && RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[296]`
Mówca: **Narrator**
> "Manus, suspected of plotting the revolutionary attack along with you, had fled the country together with Vina and your mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[297]`
Mówca: **Narrator**
> "Rather than swear allegiance herself, your mother opted to leave the country, accompanied by VIna."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.AxelVina_Married_Official"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.AxelVina_Married_Official"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[301]`
Mówca: **Narrator**
> "You learned that Vina and Axel had made it back to Pales. Rather than swear allegiance to Hugo herself, your mother opted to leave the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had no choice but to try to join them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had no choice but to try to join her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Revolutionary Fail Exile)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Revolutionary Fail Exile])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_EarlyExile = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Manus_EarlyExile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_EarlyExile = true;
RiziaDLC.Estela_EarlyExile = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Vina_EarlyExile"] = true;
Variable["RiziaDLC.Estela_EarlyExile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Estela_EarlyExile = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Estela_EarlyExile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The capital was in complete chaos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[313]`
Mówca: **Narrator**
> "Eventually, you received word that divisions from Houses Azaro and Sazon were fighting with the forces that still remained loyal to you. 

They were rallying behind Lucita as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coup_Leader_Lucita = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Coup_Leader_Lucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Pregnant == true && RiziaDLC.Azaro_HasPowerToCoup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Pregnant == true && RiziaDLC.Azaro_HasPowerToCoup == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Pregnant"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Pregnant == true && RiziaDLC.Azaro_HasPowerToCoup == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Pregnant"] == true  and  Variable["RiziaDLC.Azaro_HasPowerToCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[318]`
Mówca: **Narrator**
> "Eventually, you received word that divisions from Houses Toras and Azaro were fighting with the forces that still remained loyal to you. 

They were rallying behind Lucita as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Lucita_Arrested == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Lucita_Arrested == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[322]`
Mówca: **Narrator**
> "Eventually, you received word that divisions commanded by House Azaro were fighting with the forces that still remained loyal to you. 

They were rallying behind Lucita as the new claimant to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true && RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Manus == true && RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Manus == true && RiziaDLC.Vina_MarriageDecision_Manus == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true  and  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Narrator**
> "You learned that your mother had fled the country, fearing for her safety. Vina had chosen to accompany her.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.AxelVina_Married_Official"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.AxelVina_Married_Official"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[330]`
Mówca: **Narrator**
> "You learned that your mother had fled the country, fearing for her safety. 

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Manus_EarlyExile = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Manus_EarlyExile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_EarlyExile = true;
RiziaDLC.Estela_EarlyExile = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Vina_EarlyExile"] = true;
Variable["RiziaDLC.Estela_EarlyExile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Estela_EarlyExile = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Estela_EarlyExile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[334]`
Mówca: **Narrator**
> "You learned that your mother had fled the country, fearing for her safety. Vina and Manus had accompanied her.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.AxelVina_Married_Official == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.AxelVina_Married_Official"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.AxelVina_Married_Official == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.AxelVina_Married_Official"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[338]`
Mówca: **Narrator**
> "Rather than swear allegiance herself, your mother opted to leave the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.AxelVina_Married_Official"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_Invited_Vina == true && RiziaDLC.AxelVina_Married_Official == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true  and  Variable["RiziaDLC.AxelVina_Married_Official"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[342]`
Mówca: **Narrator**
> "You learned that Vina and Axel had made it back to Pales, which was untouched by the fighting so far. Meanwhile, your mother fled the country, fearing for her safety.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[343]`
**[WYBÓR GRACZA: "1957|Escape from Rizia"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to a secret harbor on the Sudis Sea.

You knew Estela was already at a hotel in Kyrute. She had some money set aside for a beachside villa there.

But Queen Beatrice had also offered you and your loved ones a safe haven in Rumburg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[161]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Estela_EarlyExile == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Estela_EarlyExile == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Estela_EarlyExile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Estela_EarlyExile == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Estela_EarlyExile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Estela_EarlyExile == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Estela_EarlyExile == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Estela_EarlyExile"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Estela_EarlyExile == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Estela_EarlyExile"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[350]`
**[WYBÓR GRACZA: "1957|Escape from Rizia"]** — Mówca: **Narrator**
> "After careful planning with your guards, you organized your escape from the capital to a secret harbor on the Sudis Sea.

You knew your mother was already at a hotel in Kyrute. She had some money set aside for a beachside villa there.

The moment your boat set out on the water, you let out a deep sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
