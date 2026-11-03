# Sordland/Turn09/A_LileasPrisonVisit

- **ID konwersacji:** `202`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/202_A_LileasPrisonVisit.md`
- **Liczba węzłów dialogowych:** 179
- **Liczba wyborów gracza:** 25

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[44]** Lileas Graf

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Democratic`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Diplomacy_ATO`
- `BaseGame.Policy_Diplomacy_CSP`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_Detained_WalterTusk`
- `BaseGame.Turn07_SecretState_Detained_FrensRicter`
- `BaseGame.Turn07_SecretState_Detained_KesaroKibener`
- `BaseGame.Turn08_SecondScandal_Detained_Livia`
- `BaseGame.Turn08_SecondScandal_Detained_Petr`
- `BaseGame.Turn08_SecondScandal_LiviaTrialled`
- `BaseGame.Turn08_SecondScandal_PetrTrialled`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro`
- `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso`
- `BaseGame.Turn09_A_Investigation_Oligarchs_MarcelTrialled`
- `BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk`
- `BaseGame.Turn09_A_Investigation_PFJP_RicterFramed`
- `BaseGame.Turn09_A_MarcelArrested`
- `BaseGame.Turn09_Military_WeakAgainstRumburg`
- `BaseGame.YoungSords_Kill_OrsoHawker`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.News_Turn09_HP_Lileas_Jailed`
- `BaseGameSupport.News_Turn09_ST_Lileas_Jailed`
- `BaseGameSupport.Report_Turn09_Conriat_CSPShips`
- `BaseGameSupport.Report_Turn09_Erlory_ATOPlanes`
- `BaseGameSupport.Report_Turn09_Holsord_WPB_CPS_InTalks`
- `GameCondition.Turn09_A_LileasDiscussion`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 8

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Paskal Beniwoll): `Variable["GameCondition.Turn09_A_LileasDiscussion"] = true;`
- Węzeł `[160]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn09_HP_Lileas_Jailed"] = true; Variable["BaseGameSupport.News_T...`
- Węzeł `[161]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn09_Holsord_WPB_CPS_InTalks"] = true;`
- Węzeł `[171]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn09_Erlory_ATOPlanes"] = true;`
- Węzeł `[175]` (Paskal Beniwoll): `Variable["BaseGameSupport.Report_Turn09_Conriat_CSPShips"] = true;`
- Węzeł `[176]` (Paskal Beniwoll): `UpdateCharacterTitle("Lileas Graf","Inmate 64498");`
- Węzeł `[177]` (Paskal Beniwoll): `PlaySoundEffect("Helicopter");`
- Węzeł `[178]` (Paskal Beniwoll): `End();`

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
  - -> `[165]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn09_A_LileasDiscussion = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn09_A_LileasDiscussion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The thrum of the helicopter engine, the first of its kind in Sordland, was deafening as we touched down on the landing pad of Antel Rock Prison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I stepped out, bracing myself against the salty winds. The noise of the helicopter was replaced by that of squawking seabirds and waves furiously crashing on the jagged rocks below."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Flanked by my guards, I walked into Antel Rock Prison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "A team of security personnel led me through the winding corridors on the ground floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_PetrTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Passing by the rows of cells, I wondered how Petr was doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[12]`
Mówca: **Narrator**
> "And Orso Hawker..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[13]`
Mówca: **Narrator**
> "At the back of the building, we came to an elevator. The guards punched in a code, and we rode all the way to the top floor of the prison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Narrator**
> "And Livia..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Passing by the rows of cells, I wondered how Livia was doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGame.Turn09_A_MarcelArrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGame.Turn09_A_MarcelArrested == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true  or  Variable["BaseGame.Turn09_A_MarcelArrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGame.Turn09_A_MarcelArrested == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true  or  Variable["BaseGame.Turn09_A_MarcelArrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[25]`
Mówca: **Narrator**
> "And Marcel..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGame.Turn09_A_MarcelArrested == true || BaseGame.Turn09_A_Investigation_Oligarchs_MarcelTrialled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGame.Turn09_A_MarcelArrested == true || BaseGame.Turn09_A_Investigation_Oligarchs_MarcelTrialled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true  or  Variable["BaseGame.Turn09_A_MarcelArrested"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_MarcelTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGame.Turn09_A_MarcelArrested == true || BaseGame.Turn09_A_Investigation_Oligarchs_MarcelTrialled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true  or  Variable["BaseGame.Turn09_A_MarcelArrested"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_MarcelTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Narrator**
> "Passing by the rows of cells, I wondered how Marcel was doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Passing by the rows of cells, I wondered how Walter Tusk was doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[34]`
Mówca: **Narrator**
> "And Walter..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == true && BaseGame.YoungSords_Kill_OrsoHawker == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == true && BaseGame.YoungSords_Kill_OrsoHawker == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == true && BaseGame.YoungSords_Kill_OrsoHawker == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[41]`
Mówca: **Narrator**
> "Passing by the rows of cells, I wondered how Orso Hawker was doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == true && BaseGame.YoungSords_Kill_OrsoHawker == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == true && BaseGame.YoungSords_Kill_OrsoHawker == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == true && BaseGame.YoungSords_Kill_OrsoHawker == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[48]`
Mówca: **Narrator**
> "And Frens Ricter..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[55]`
Mówca: **Narrator**
> "And Kesaro Kibener..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[56]`
Mówca: **Narrator**
> "Passing by the rows of cells, I wondered how Frens Ricter was doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Narrator**
> "Passing by the rows of cells, I wondered how Kesaro Kibener was doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Narrator**
> "But that wasn't who I was here to see."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[62]`
Mówca: **Narrator**
> "Passing by the rows of cells, I heard prisoners pounding on their doors and pleading me for a pardon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[63]`
Mówca: **Narrator**
> "Lileas had a corner cell, with large windows overlooking the seaside. It was equipped with a comfortable-looking bed and a modest writing desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[64]`
Mówca: **Narrator**
> "She appeared to be busy writing letters as the guards opened the door to the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`
  - -> `[67]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Hello, Lileas.""]** — Mówca: **Player**
> ""Hello, Lileas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""Who are you writing to?""]** — Mówca: **Player**
> ""Who are you writing to?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Stop writing at once and speak to me.""]** — Mówca: **Player**
> ""Stop writing at once and speak to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[68]`
Mówca: **Lileas Graf**
> ""Mr. President. What brings you all this way?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`
  - -> `[74]`

### Węzeł `[69]`
Mówca: **Lileas Graf**
> ""Just catching up with a few old friends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Lileas Graf**
> ""What brings you all this way, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`
  - -> `[74]`

### Węzeł `[71]`
Mówca: **Lileas Graf**
> ""No need for the imperatives. You already have me in a prison cell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""Why did you kill Bernard Circas?""]** — Mówca: **Player**
> ""Why did you kill Bernard Circas?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""You spent my entire term trying to undermine me. Why?""]** — Mówca: **Player**
> ""You spent my entire term trying to undermine me. Why?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Who was really behind the Circas assassination?""]** — Mówca: **Player**
> ""Who was really behind the Circas assassination?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
Mówca: **Lileas Graf**
> ""I thought you already knew the answer to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Lileas Graf**
> ""I and my colleagues judged you to be a threat to Sordland. From the start of your term, we felt you were putting the country at risk of succumbing to outside influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[77]`
Mówca: **Narrator**
> "Lileas blinked and smiled benignly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Lileas Graf**
> ""I thought the court already established that during my trial. I drafted the order to the Young Sords, Hawker signed off on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""But whose idea was it, really?""]** — Mówca: **Player**
> ""But whose idea was it, really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Come off it, Lileas. How long have you been Soll's puppet?""]** — Mówca: **Player**
> ""Come off it, Lileas. How long have you been Soll's puppet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Lileas Graf**
> ""I know what you're implying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Narrator**
> "Lileas drew herself up, her back straight as a rod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Lileas Graf**
> ""Tarquin Soll was a great man with whom I shared many ideals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Death))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Lileas Graf**
> ""Tarquin Soll was -- is -- a great man, with whom I share many ideals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Lileas Graf**
> ""But my decisions have always been my own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 5 || BaseGame.Democratic > 5 || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Faction_OldGuard_Content == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 5 || BaseGame.Democratic > 5 || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Faction_OldGuard_Content == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 5  or  Variable["BaseGame.Democratic"] > 5  or  (Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist > 5 || BaseGame.Democratic > 5 || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Faction_OldGuard_Content == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 5  or  Variable["BaseGame.Democratic"] > 5  or  (Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Lileas Graf**
> ""Obviously, we were right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[93]`
Mówca: **Lileas Graf**
> ""Without our interference, who knows what kind of radical change you would have brought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
**[WYBÓR GRACZA: ""The Sordish people wanted change. You can't just disregard their will.""]** — Mówca: **Player**
> ""The Sordish people wanted change. You can't just disregard their will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""I'm the President, and I wanted change. You can't just disregard my will.""]** — Mówca: **Player**
> ""I'm the President, and I wanted change. You can't just disregard my will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_CSP == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_CSP == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_CSP"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_CSP == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_CSP"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[107]`

### Węzeł `[99]`
Mówca: **Lileas Graf**
> ""The President doesn't always know best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Lileas Graf**
> ""The people don't always know best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_CSP == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_CSP == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_CSP"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_CSP == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_CSP"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[108]`

### Węzeł `[104]`
Mówca: **Lileas Graf**
> ""As shown by their willingness to follow you into a foolish war that Sordland is ill-prepared to win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Lileas Graf**
> ""As shown by your leading the country into a foolish war that it is ill-prepared to win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[106]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""I'm going to crush Rumburg. Just like I crushed you and the rest of the Old Guard.""]** — Mówca: **Player**
> ""I'm going to crush Rumburg. Just like I crushed you and the rest of the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""They knew enough to vote me in. And I knew enough to force you out.""]** — Mówca: **Player**
> ""They knew enough to vote me in. And I knew enough to force you out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""I knew enough to get rid of you and the rest of your Old Guard chums.""]** — Mówca: **Player**
> ""I knew enough to get rid of you and the rest of your Old Guard chums.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Lileas Graf**
> ""You're going to regret that. Sordland without Sollism is a ship without a rudder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`
  - -> `[134]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""And you think you would have done a better job?""]** — Mówca: **Player**
> ""And you think you would have done a better job?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Lileas Graf**
> ""I would not have let our proud republic stray so far from its Sollist roots.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[134]`

### Węzeł `[112]`
**[WYBÓR GRACZA: ""Have you always been Soll's puppet? Or just since you entered my cabinet?""]** — Mówca: **Player**
> ""Have you always been Soll's puppet? Or just since you entered my cabinet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""To hell with Soll, and to hell with you.""]** — Mówca: **Player**
> ""To hell with Soll, and to hell with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[114]`
Mówca: **Lileas Graf**
> ""Mr. Rayne. Did you really take a helicopter to Antel Rock just to provoke me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[132]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 15)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 15)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist > 15))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Lileas Graf**
> ""As I tried to tell you many times when we were working together, Sordland is not United Contana. Your heedless shift towards Malenyevism will bring only chaos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic > 20)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic > 20)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Democratic"] > 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Democratic > 20))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Democratic"] > 20) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Lileas Graf**
> ""As I tried to tell you many times when we were working together, Sordland is not Arcasia. Your heedless shift towards liberalism will bring only chaos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[123]`
Mówca: **Lileas Graf**
> ""Your hapless attempts to reform the Constitution have gone against everything this country stands for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[124]`
Mówca: **Narrator**
> "Lileas drew herself up, her back straight as a rod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""Is that what you're writing? An obituary for your beloved Tarquin Soll?""]** — Mówca: **Player**
> ""Is that what you're writing? An obituary for your beloved Tarquin Soll?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[126]`
Mówca: **Lileas Graf**
> ""Including the decision to sacrifice one man's life to save millions of Sordish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
**[WYBÓR GRACZA: ""That decision wasn't yours to make.""]** — Mówca: **Player**
> ""That decision wasn't yours to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""Save them from what, Lileas?""]** — Mówca: **Player**
> ""Save them from what, Lileas?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""I thought you religious freaks were against playing God.""]** — Mówca: **Player**
> ""I thought you religious freaks were against playing God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[130]`
Mówca: **Narrator**
> "Lileas' face darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Lileas Graf**
> ""Oh, you'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[132]`
**[WYBÓR GRACZA: ""I-- I suppose I did.""]** — Mówca: **Player**
> ""I-- I suppose I did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[133]`
**[WYBÓR GRACZA: ""Of course not. I just wanted to understand your motivations.""]** — Mówca: **Player**
> ""Of course not. I just wanted to understand your motivations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Is that who those letters are for? Your beloved Tarquin Soll?""]** — Mówca: **Player**
> ""Is that who those letters are for? Your beloved Tarquin Soll?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[138]`
Mówca: **Lileas Graf**
> ""History will redeem me. Even if you won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[139]`
Mówca: **Lileas Graf**
> ""My motivations are and have always been crystal clear. It's yours I would worry about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Lileas Graf**
> ""Then allow me to return the favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Lileas Graf**
> ""All this change you've attempted to bring to Sordland... is it truly for the betterment of the country, or to cement a place for Anton Rayne in the history books?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < 1  or  Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < 1  or  Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[145]`
Mówca: **Lileas Graf**
> ""You're hanging on by a thread, dear. Time is running out to choose how you want to be remembered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[146]`
Mówca: **Lileas Graf**
> ""But as for you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[147]`
Mówca: **Lileas Graf**
> ""Sooner or later, the people will realize that Soll was the best leader they'll ever have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Guards! Take this woman's pens and paper away. They're too dangerous to have lying around.""]** — Mówca: **Player**
> ""Guards! Take this woman's pens and paper away. They're too dangerous to have lying around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I've had enough of this. I'm leaving.""]** — Mówca: **Player**
> ""I've had enough of this. I'm leaving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[150]`
Mówca: **Narrator**
> "The guards moved in and roughly grabbed Lileas' writing materials off her desk. She looked unfazed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Lileas Graf**
> ""Thanks for the visit, Mr. President. I'm sure this isn't the last we'll see of each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Narrator**
> "Lileas nodded and turned back to her correspondence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[153]`
Mówca: **Narrator**
> "The guards re-locked her cell door and escorted me away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Narrator**
> "On the way back to Holsord, I couldn't help thinking about what she said."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Severity > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Severity > 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < 1  or  Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Severity > 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < 1  or  Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Narrator**
> "How would I be remembered?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[159]`
Mówca: **Narrator**
> "Would I ever be able to escape Soll's shadow?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn09_HP_Lileas_Jailed = true; BaseGameSupport.News_Turn09_ST_Lileas_Jailed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Lileas_Jailed"] = true;
Variable["BaseGameSupport.News_Turn09_ST_Lileas_Jailed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn09_Holsord_WPB_CPS_InTalks = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Holsord_WPB_CPS_InTalks"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Reform_EmergencyDecree_Banned_RY == false && (BaseGame.Reform_Law_Threshold_15 == true || BaseGame.Reform_Law_Threshold_Default == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Reform_EmergencyDecree_Banned_RY == false && (BaseGame.Reform_Law_Threshold_15 == true || BaseGame.Reform_Law_Threshold_Default == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and  (Variable["BaseGame.Reform_Law_Threshold_15"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Reform_EmergencyDecree_Banned_RY == false && (BaseGame.Reform_Law_Threshold_15 == true || BaseGame.Reform_Law_Threshold_Default == true && BaseGame.Reform_Reform_Court_Success == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and  (Variable["BaseGame.Reform_Law_Threshold_15"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_CSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_CSP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_CSP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn09_Erlory_ATOPlanes = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Erlory_ATOPlanes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn09_Conriat_CSPShips = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Conriat_CSPShips"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Lileas Graf", "Inmate 64498");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Lileas Graf","Inmate 64498");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Helicopter");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Helicopter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
