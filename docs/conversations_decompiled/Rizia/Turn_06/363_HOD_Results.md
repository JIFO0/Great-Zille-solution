# Rizia/Turn 6/HOD Results

- **ID konwersacji:** `363`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/363_HOD_Results.md`
- **Liczba węzłów dialogowych:** 258
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Reform_Reformist_Path`
- `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal`
- `RiziaDLC.HouseElections_RNCWinsSeats`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.Policy_RD_Welfare_ElectoralReform`
- `RiziaDLC.Policy_RD_Welfare_FreePress`
- `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Situation_Economy_EnergyCrisis`
- `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Voting_Foreigners_RNC`
- `RiziaDLCIsolated.Voting_Foreigners_RPP`
- `RiziaDLCIsolated.Voting_LowerClass_RNC`
- `RiziaDLCIsolated.Voting_LowerClass_RPP`
- `RiziaDLCIsolated.Voting_MiddleClass_RNC`
- `RiziaDLCIsolated.Voting_MiddleClass_RPP`
- `RiziaDLCIsolated.Voting_Nobility_RPP`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCSupport.News_Turn06_RH_ElectionRNCWin`
- `RiziaDLCSupport.News_Turn06_RH_ElectionRPPWin`
- `RiziaDLCSupport.News_Turn06_RH_ElectionStatusQuo`
- `RiziaDLCSupport.News_Turn06_V_ElectionRNCWin`
- `RiziaDLCSupport.News_Turn06_V_ElectionRPPWin`
- `RiziaDLCSupport.News_Turn06_V_ElectionStatusQuo`
- `RiziaDLCSupport.Reports_Turn06_Iza_SuOminaIntimidatesVoters`
- `RiziaDLCSupport.Reports_Turn06_Kyrute_CongratulateSuccesfulElections`
- `RiziaDLCSupport.Reports_Turn06_Lespia_CongratulateFreeElections`
- `RiziaDLCSupport.Reports_Turn06_Morella_CongraltulateRPPWin`
- `RiziaDLCSupport.Reports_Turn06_Rumburg_CongratulateRNCWin`
- `RiziaDLCSupport.Reports_Turn06_Sordland_CongratulateRNCWin`
- `RiziaDLCSupport.Reports_Turn06_Sordland_CongratulateRPPWin`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[361] Rizia/Turn 6/A_CouncilMeeting** (../Turn_06/361_A_CouncilMeeting.md), Węzeł `[239]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 8
- **Węzły modyfikujące stan gry:** 15

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[104]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Reports_Turn06_Iza_SuOminaIntimidatesVoters"] = true;`
- Węzeł `[105]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn06_V_ElectionRPPWin"] = true; Variable["RiziaDLCSupport.News_T...`
- Węzeł `[106]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn06_V_ElectionRNCWin"] = true; Variable["RiziaDLCSupport.News_T...`
- Węzeł `[107]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn06_V_ElectionStatusQuo"] = true; Variable["RiziaDLCSupport.New...`
- Węzeł `[111]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Reports_Turn06_Lespia_CongratulateFreeElections"] = true;`
- Węzeł `[115]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Reports_Turn06_Sordland_CongratulateRPPWin"] = true; ;`
- Węzeł `[119]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Reports_Turn06_Sordland_CongratulateRNCWin"] = true; ;`
- Węzeł `[120]` (Paskal Beniwoll): `--;`
- *...oraz 7 innych węzłów ze skryptami.*

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `361` (*Rizia/Turn 6/A_CouncilMeeting*), Węzeł `[239]`

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""Before we begin in earnest, we must acknowledge the results of the recent House of Delegates election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
Mówca: **Narrator**
> "He had a dour look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""In a historic first for our kingdom, the Rizian People's Party won the majority of seats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RNCWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RNCWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RNCWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Hugo had a wide smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Hugo Toras**
> ""The Rizian National Coalition had an excellent showing. They now make up over three-quarters of delegates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Hugo smiled confidently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Hugo Toras**
> ""As usual, the Rizian National Coalition secured the majority of seats. No significant gains were made, but no losses, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""By unanimous vote, Manus Sazon was named House Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Narrator**
> "Vina made no effort to hide her joy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Vina struggled to maintain a neutral expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Vina made no effort to hide her dismay."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? How could this happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This shows that the public is hungry for a change in our kingdom's direction. We should listen to what they have to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[32]`
  - -> `[33]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`
  - -> `[58]`
  - -> `[127]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who cares about the election? I make the laws in this country, not the Delegates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Brilliant. I'm glad to hear that the majority of the Rizian public still respects the authority of their monarch and his supporters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who cares about the election? I make the laws in this country, not the Delegates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""Should we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Narrator**
> "His expression turned quizzical."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[91]`
  - -> `[92]`
  - -> `[95]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[48]`
Mówca: **Hugo Toras**
> ""You know as well as I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Narrator**
> "His expression darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""I wouldn't be surprised if House Sazon had a hand in manipulating the voting results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""And I am not certain the votes of the foreigners who flocked to the polls should even be counted as legitimate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[91]`
  - -> `[92]`
  - -> `[95]`

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""With some aid from the so-called free press, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""You are right, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""But you must consider that they weren't elected out of nowhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""You are right, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""But the continued dominance of the RNC is proof that you should stay the course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""Indeed, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The RNC? You're sure they won?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Hugo Toras**
> ""Quite sure, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[60]`
Mówca: **Narrator**
> "His expression turned quizzical."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""And the hordes of foreigners suddenly clamoring to have their votes counted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""In spite of the lies told by the so-called free press...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[72]`
Mówca: **Hugo Toras**
> ""Despite the hordes of foreigners suddenly clamoring to have their votes counted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""Unfortunately, today's meeting is not all good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""In other news...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""That isn't the only unpleasant news I have to share today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[82]`
Mówca: **Hugo Toras**
> ""But moving on to other news...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[83]`
Mówca: **Hugo Toras**
> ""By unanimous vote, Daria de Rava has retained the position of House Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Say what you will about Mr. Sazon, but he has earned that seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""Has he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[89]`
Mówca: **Hugo Toras**
> ""Thanks to the reform of our electoral system, hundreds of experienced politicians lost their provincial council seats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Hugo Toras**
> ""Whether in the House of Delegates or across the country, we now have a glut of newcomers, all of whom believe the country needs sweeping change without having the faintest clue how to accomplish it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[91]`
  - -> `[92]`
  - -> `[95]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Give the new Delegates a chance, Your Grace. Their ideas could invigorate all of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Delegates are still far away from the levers of power. They can't actually do anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Hugo Toras**
> ""No. Not for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""If they don't destroy it first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look on the bright side. We finally have a parliament that represents the people of this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Hugo Toras**
> ""Indeed. Down to the last village idiot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""I admit I questioned your reform of the Rizian electoral system at first. But we now know for a fact that the people of this kingdom favor stability and tradition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn06_Iza_SuOminaIntimidatesVoters = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Iza_SuOminaIntimidatesVoters"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_V_ElectionRPPWin = true;
RiziaDLCSupport.News_Turn06_RH_ElectionRPPWin = true;
RiziaDLCSupport.Reports_Turn06_Morella_CongraltulateRPPWin = true;
RiziaDLCSupport.Reports_Turn06_Kyrute_CongratulateSuccesfulElections = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_V_ElectionRPPWin"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_ElectionRPPWin"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Morella_CongraltulateRPPWin"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Kyrute_CongratulateSuccesfulElections"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_V_ElectionRNCWin = true;
RiziaDLCSupport.News_Turn06_RH_ElectionRNCWin = true;
RiziaDLCSupport.Reports_Turn06_Kyrute_CongratulateSuccesfulElections = true;
RiziaDLCSupport.Reports_Turn06_Rumburg_CongratulateRNCWin = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_V_ElectionRNCWin"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_ElectionRNCWin"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Kyrute_CongratulateSuccesfulElections"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Rumburg_CongratulateRNCWin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn06_V_ElectionStatusQuo = true;
RiziaDLCSupport.News_Turn06_RH_ElectionStatusQuo = true;
RiziaDLCSupport.Reports_Turn06_Kyrute_CongratulateSuccesfulElections = true;
RiziaDLCSupport.Reports_Turn06_Rumburg_CongratulateRNCWin = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_V_ElectionStatusQuo"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_ElectionStatusQuo"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Kyrute_CongratulateSuccesfulElections"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Rumburg_CongratulateRNCWin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn06_Lespia_CongratulateFreeElections = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Lespia_CongratulateFreeElections"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn06_Sordland_CongratulateRPPWin = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Sordland_CongratulateRPPWin"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn06_Sordland_CongratulateRNCWin = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Sordland_CongratulateRNCWin"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[121]`
  - -> `[126]`
  - -> `[123]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the update.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't be so negative, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I'm pleased with the outcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? Is that true?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Hugo Toras**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about the voter demographics? I want to know who voted for what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about the voter demographics? I want to know who voted for what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Hugo Toras**
> ""Certainly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Narrator**
> "He started reading the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolated.Voting_MiddleClass_RPP == 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolated.Voting_MiddleClass_RPP == 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] - Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolated.Voting_MiddleClass_RPP == 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] - Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[146]`
Mówca: **Hugo Toras**
> ""Due to the inclusion of millions of new voters from foreign origin, as well as the electoral reform which took the reserved seats for the nobles...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Hugo Toras**
> ""...The nobility had only an influence of around ten percent on the overall election results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[151]`
Mówca: **Hugo Toras**
> ""Despite the inclusion of millions of new voters from foreign origin, as well as the electoral reform which took the reserved seats for the nobles...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[158]`
Mówca: **Hugo Toras**
> ""...The nobility is firmly supporting the RNC, and thus, the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[159]`
Mówca: **Hugo Toras**
> ""Despite the electoral reform which took the reserved seats for the nobles...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[160]`
Mówca: **Hugo Toras**
> ""The nobility, of course, is firmly supporting the RNC, and thus, the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[161]`
Mówca: **Hugo Toras**
> ""Due to the electoral reform which took the reserved seats for the nobles...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Hugo Toras**
> ""...The nobility's influence on the election results were more than halved in this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[163]`
Mówca: **Hugo Toras**
> ""Due to the inclusion of millions of new voters from foreign origin...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_Nobility_RPP > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_Nobility_RPP > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Voting_Nobility_RPP > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Hugo Toras**
> ""However, there are rumors of certain members of the nobility to be supporting the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[169]`
Mówca: **Narrator**
> "He had a chastising look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_MiddleClass_RNC >= 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_MiddleClass_RNC >= 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Voting_MiddleClass_RNC >= 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[173]`
Mówca: **Hugo Toras**
> ""We're doing reasonably well among the middle class. About two-thirds of them are supporting the RNC.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[174]`
Mówca: **Hugo Toras**
> ""The middle class appears divided in their support, almost exactly in half.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[175]`
Mówca: **Hugo Toras**
> ""We're doing better than ever with the middle class. We have an overwhelming majority of them behind the RNC.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_MiddleClass_RNC == 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_MiddleClass_RNC == 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Voting_MiddleClass_RNC == 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_MiddleClass_RNC == 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_MiddleClass_RNC == 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Voting_MiddleClass_RNC == 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] == 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[182]`
Mówca: **Hugo Toras**
> ""We've fallen out of favor with the middle class. About two-thirds of them are now supporting the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[183]`
Mówca: **Hugo Toras**
> ""Our support among the middle class has plummeted. Only the upper middle class, which makes up a mere quarter are supporting the RNC.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_MiddleClass_RNC == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_MiddleClass_RNC == 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Voting_MiddleClass_RNC == 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Hugo Toras**
> ""To be frank, we have lost almost all of our support from the middle class. They have given their support to the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_LowerClass_RNC - RiziaDLCIsolated.Voting_LowerClass_RPP == 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_LowerClass_RNC - RiziaDLCIsolated.Voting_LowerClass_RPP == 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] - Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Voting_LowerClass_RNC - RiziaDLCIsolated.Voting_LowerClass_RPP == 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] - Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[192]`
Mówca: **Hugo Toras**
> ""Interestingly, the support of the lower class also appears to be divided in half.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_LowerClass_RNC >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_LowerClass_RNC >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Voting_LowerClass_RNC >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_LowerClass_RNC == 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_LowerClass_RNC == 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Voting_LowerClass_RNC == 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] == 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolated.Voting_MiddleClass_RPP == 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolated.Voting_MiddleClass_RPP == 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] - Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolated.Voting_MiddleClass_RPP == 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] - Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Hugo Toras**
> ""However, the lower class citizens appear divided in their support, almost exactly in half.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[203]`
Mówca: **Hugo Toras**
> ""Fortunately, the RNC's popularity among our lower class citizens has gone through the roof. We seem to have gained almost all of their votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Hugo Toras**
> ""Fortunately, the RNC's popularity among our lower class citizens has gone through the roof. We seem to have gained a sizeable number of votes away from the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_LowerClass_RNC == 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_LowerClass_RNC == 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Voting_LowerClass_RNC == 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Hugo Toras**
> ""Unfortunately, the RNC's popularity among our lower class citizens remain very low. Most of them have given their support to the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[212]`
Mówca: **Hugo Toras**
> ""Unfortunately, we have next to no support from our lower class citizens. They have given their support to the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[217]`
Mówca: **Hugo Toras**
> ""Of course, it wasn't enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[222]`
Mówca: **Hugo Toras**
> ""Despite this fact, it wasn't enough to influence the outcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[226]`
Mówca: **Hugo Toras**
> ""And there are millions of foreigners who were also allowed to vote in this election...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_Foreigners_RNC - RiziaDLCIsolated.Voting_Foreigners_RPP == 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_Foreigners_RNC - RiziaDLCIsolated.Voting_Foreigners_RPP == 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] - Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Voting_Foreigners_RNC - RiziaDLCIsolated.Voting_Foreigners_RPP == 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] - Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_Foreigners_RNC >= 3 || (RiziaDLC.Policy_RD_Welfare_ElectoralReform == false && RiziaDLCIsolated.Voting_Foreigners_RNC >= 2))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_Foreigners_RNC >= 3 || (RiziaDLC.Policy_RD_Welfare_ElectoralReform == false && RiziaDLCIsolated.Voting_Foreigners_RNC >= 2))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] >= 3  or  (Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == false  and  Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] >= 2)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Voting_Foreigners_RNC >= 3 || (RiziaDLC.Policy_RD_Welfare_ElectoralReform == false && RiziaDLCIsolated.Voting_Foreigners_RNC >= 2)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] >= 3  or  (Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == false  and  Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] >= 2)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_Foreigners_RNC >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Voting_Foreigners_RNC >= 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Voting_Foreigners_RNC >= 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[236]`
Mówca: **Hugo Toras**
> ""Surprisingly, around half of them have voted for the RNC.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[237]`
Mówca: **Hugo Toras**
> ""Surprisingly, an overwhelming majority of these people have given their support to the RNC.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[238]`
Mówca: **Hugo Toras**
> ""Surprisingly, a slight majority of these people have given their support to the RNC.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[239]`
Mówca: **Hugo Toras**
> ""Unsurprisingly, all of them gave their support to the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[248]`
Mówca: **Hugo Toras**
> ""Unfortunately, today's meeting is not all good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[249]`
Mówca: **Hugo Toras**
> ""All in all, I don't see anything that should concern us at this moment regarding the House of Delegates. The RNC holds the power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[250]`
Mówca: **Hugo Toras**
> ""All in all, this election should make us concerned about the current climate within the House of Delegates. The RPP has now become a real threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_EnergyCrisis == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_EnergyCrisis == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Hugo Toras**
> ""However, that isn't the only unpleasant news I have to share today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[255]`
Mówca: **Hugo Toras**
> ""But moving on to other news...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[256]`
Mówca: **Narrator**
> "He stopped for a moment to gather his thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[257]`
Mówca: **Narrator**
> "He stopped for a moment to gather his thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
