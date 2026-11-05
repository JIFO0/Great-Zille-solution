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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[32]` | **""What? How could this happen?""** | `[23]` **Narrator**: "Vina made no effort to hide her ..."<br>`[24]` **Narrator**: "Vina struggled to maintain a neu..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`<br>`(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`<br>`(Variable["BaseGame.Reform_Reformist_Path"] == false) == false` | *Brak zmian stanu* | `[48]` **Hugo Toras**: ""You know as well as I."" |
| `[33]` | **""This shows that the public is hungry for a change in our kingdom's direction. We ..."** | `[23]` **Narrator**: "Vina made no effort to hide her ..."<br>`[24]` **Narrator**: "Vina struggled to maintain a neu..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`<br>`(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`<br>`(Variable["BaseGame.Reform_Reformist_Path"] == false) == false` | *Brak zmian stanu* | `[40]` **Hugo Toras**: ""Should we?"" |
| `[37]` | **""Who cares about the election? I make the laws in this country, not the Delegates.""** | `[23]` **Narrator**: "Vina made no effort to hide her ..."<br>`[24]` **Narrator**: "Vina struggled to maintain a neu..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`<br>`(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`<br>`(Variable["BaseGame.Reform_Reformist_Path"] == false) == false` | *Brak zmian stanu* | `[53]` **Hugo Toras**: ""You are right, Your Majesty."" |
| `[38]` | **""Brilliant. I'm glad to hear that the majority of the Rizian public still respects..."** | `[23]` **Narrator**: "Vina made no effort to hide her ..."<br>`[24]` **Narrator**: "Vina struggled to maintain a neu..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`<br>`(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`<br>`(Variable["BaseGame.Reform_Reformist_Path"] == false) == false` | *Brak zmian stanu* | `[57]` **Hugo Toras**: ""Indeed, Your Majesty."" |
| `[39]` | **""Who cares about the election? I make the laws in this country, not the Delegates.""** | `[23]` **Narrator**: "Vina made no effort to hide her ..."<br>`[24]` **Narrator**: "Vina struggled to maintain a neu..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`<br>`(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`<br>`(Variable["BaseGame.Reform_Reformist_Path"] == false) == false` | *Brak zmian stanu* | `[55]` **Hugo Toras**: ""You are right, Your Majesty."" |
| `[58]` | **""The RNC? You're sure they won?""** | `[23]` **Narrator**: "Vina made no effort to hide her ..."<br>`[24]` **Narrator**: "Vina struggled to maintain a neu..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`<br>`(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`<br>`(Variable["BaseGame.Reform_Reformist_Path"] == false) == false` | *Brak zmian stanu* | `[60]` **Narrator**: "His expression turned quizzical." |
| `[84]` | **""Say what you will about Mr. Sazon, but he has earned that seat.""** | `[23]` **Narrator**: "Vina made no effort to hide her ..."<br>`[24]` **Narrator**: "Vina struggled to maintain a neu..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`<br>`(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`<br>`(Variable["BaseGame.Reform_Reformist_Path"] == false) == false` | *Brak zmian stanu* | `[85]` **Hugo Toras**: ""Has he?"" |
| `[91]` | **""Give the new Delegates a chance, Your Grace. Their ideas could invigorate all of ..."** | `[51]` **Hugo Toras**: ""And I am not certain the votes ..."<br>`[90]` **Hugo Toras**: ""Whether in the House of Delegat..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false` | *Brak zmian stanu* | `[94]` **Hugo Toras**: ""If they don't destroy it first."" |
| `[92]` | **""The Delegates are still far away from the levers of power. They can't actually do..."** | `[51]` **Hugo Toras**: ""And I am not certain the votes ..."<br>`[90]` **Hugo Toras**: ""Whether in the House of Delegat..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false` | *Brak zmian stanu* | `[93]` **Hugo Toras**: ""No. Not for now."" |
| `[95]` | **""Look on the bright side. We finally have a parliament that represents the people ..."** | `[51]` **Hugo Toras**: ""And I am not certain the votes ..."<br>`[90]` **Hugo Toras**: ""Whether in the House of Delegat..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false` | *Brak zmian stanu* | `[96]` **Hugo Toras**: ""Indeed. Down to the last villag..." |
| `[121]` | **""Thank you for the update.""** | `[67]` **Hugo Toras**: ""And the hordes of foreigners su..."<br>`[72]` **Hugo Toras**: ""Despite the hordes of foreigner..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false` | *Brak zmian stanu* | `[76]` **Hugo Toras**: ""Unfortunately, today's meeting ..."<br>`[77]` **Hugo Toras**: ""In other news..."" |
| `[122]` | **""Don't be so negative, Your Grace.""** | `[67]` **Hugo Toras**: ""And the hordes of foreigners su..."<br>`[72]` **Hugo Toras**: ""Despite the hordes of foreigner..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`<br>`(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false` | *Brak zmian stanu* | `[76]` **Hugo Toras**: ""Unfortunately, today's meeting ..."<br>`[77]` **Hugo Toras**: ""In other news..."" |
| `[126]` | **""Well, I'm pleased with the outcome.""** | `[67]` **Hugo Toras**: ""And the hordes of foreigners su..."<br>`[72]` **Hugo Toras**: ""Despite the hordes of foreigner..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false` | *Brak zmian stanu* | `[76]` **Hugo Toras**: ""Unfortunately, today's meeting ..."<br>`[77]` **Hugo Toras**: ""In other news..."" |
| `[127]` | **""What? Is that true?""** | `[23]` **Narrator**: "Vina made no effort to hide her ..."<br>`[24]` **Narrator**: "Vina struggled to maintain a neu..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`<br>`(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`<br>`(Variable["BaseGame.Reform_Reformist_Path"] == false) == false` | *Brak zmian stanu* | `[128]` **Hugo Toras**: ""Yes."" |
| `[129]` | **""What about the voter demographics? I want to know who voted for what.""** | `[67]` **Hugo Toras**: ""And the hordes of foreigners su..."<br>`[72]` **Hugo Toras**: ""Despite the hordes of foreigner..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false` | `--;` | `[132]` **Hugo Toras**: ""Certainly."" |
| `[130]` | **""What about the voter demographics? I want to know who voted for what.""** | `[51]` **Hugo Toras**: ""And I am not certain the votes ..."<br>`[90]` **Hugo Toras**: ""Whether in the House of Delegat..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false` | `--;` | `[132]` **Hugo Toras**: ""Certainly."" |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Hugo Toras: ""Before we begin in earnest, we must acknowledge the resu..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Hugo Toras: ""Unsurprisingly, all of them gave their support to the op..."*)

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""Before we begin in earnest, we must acknowledge the results of the recent House of Delegates election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_V_ElectionRPPWin = true; Rizi..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RNCWinsSeats == true"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "He had a dour look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Hugo Toras: ""In a historic first for our kingdom, the Rizian People's..."*)

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""In a historic first for our kingdom, the Rizian People's Party won the majority of seats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""By unanimous vote, Manus Sazon was named House Speaker.""*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RNCWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RNCWinsSeats == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RNCWinsSeats == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RNCWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_V_ElectionRNCWin = true; Rizi..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RNCWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_V_ElectionStatusQuo = true; R..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Hugo had a wide smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Hugo Toras: ""The Rizian National Coalition had an excellent showing. ..."*)

### Węzeł `[13]`
Mówca: **Hugo Toras**
> ""The Rizian National Coalition had an excellent showing. They now make up over three-quarters of delegates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Hugo Toras: ""By unanimous vote, Daria de Rava has retained the positi..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Hugo smiled confidently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Hugo Toras: ""As usual, the Rizian National Coalition secured the majo..."*)

### Węzeł `[15]`
Mówca: **Hugo Toras**
> ""As usual, the Rizian National Coalition secured the majority of seats. No significant gains were made, but no losses, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Hugo Toras: ""By unanimous vote, Daria de Rava has retained the positi..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_P..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""By unanimous vote, Manus Sazon was named House Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Vina made no effort to hide her joy."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Vina struggled to maintain a neutral expression."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Vina made no effort to hide her joy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Vina struggled to maintain a neutral expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_P..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Vina made no effort to hide her dismay."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Vina struggled to maintain a neutral expression."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Vina made no effort to hide her dismay."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? How could this happen?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true` AND `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false` AND `(Variable["BaseGame.Reform_Reformist_Path"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator), `[24]` (Narrator), `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Hugo Toras: ""You know as well as I.""*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This shows that the public is hungry for a change in our kingdom's direction. We should listen to what they have to say.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true` AND `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false` AND `(Variable["BaseGame.Reform_Reformist_Path"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator), `[24]` (Narrator), `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""Should we?""*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""Say what you will about Mr. Sazon, but he has earned tha..."*)
  - -> `[32]` (*Player_Romus: ""What? How could this happen?""*)
  - -> `[33]` (*Player_Romus: ""This shows that the public is hungry for a change in our..."*)
  - -> `[37]` (*Player_Romus: ""Who cares about the election? I make the laws in this co..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Romus: ""Brilliant. I'm glad to hear that the majority of the Riz..."*)
  - -> `[39]` (*Player_Romus: ""Who cares about the election? I make the laws in this co..."*)
  - -> `[58]` (*Player_Romus: ""The RNC? You're sure they won?""*)
  - -> `[127]` (*Player_Romus: ""What? Is that true?""*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who cares about the election? I make the laws in this country, not the Delegates.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true` AND `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false` AND `(Variable["BaseGame.Reform_Reformist_Path"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator), `[24]` (Narrator), `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""You are right, Your Majesty.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Brilliant. I'm glad to hear that the majority of the Rizian public still respects the authority of their monarch and his supporters.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false` AND `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false` AND `(Variable["BaseGame.Reform_Reformist_Path"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator), `[24]` (Narrator), `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Hugo Toras: ""Indeed, Your Majesty.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who cares about the election? I make the laws in this country, not the Delegates.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false` AND `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false` AND `(Variable["BaseGame.Reform_Reformist_Path"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator), `[24]` (Narrator), `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Hugo Toras: ""You are right, Your Majesty.""*)

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""Should we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "His expression turned quizzical."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "His expression turned quizzical."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""And I am not certain the votes of the foreigners who flo..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player_Romus: ""What about the voter demographics? I want to know who vo..."*)
  - -> `[91]` (*Player_Romus: ""Give the new Delegates a chance, Your Grace. Their ideas..."*)
  - -> `[92]` (*Player_Romus: ""The Delegates are still far away from the levers of powe..."*)
  - -> `[95]` (*Player_Romus: ""Look on the bright side. We finally have a parliament th..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""With some aid from the so-called free press, of course.""*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[48]`
Mówca: **Hugo Toras**
> ""You know as well as I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "His expression darkened."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "His expression darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""I wouldn't be surprised if House Sazon had a hand in manipulating the voting results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""And I am not certain the votes of the foreigners who flocked to the polls should even be counted as legitimate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player_Romus: ""What about the voter demographics? I want to know who vo..."*)
  - -> `[91]` (*Player_Romus: ""Give the new Delegates a chance, Your Grace. Their ideas..."*)
  - -> `[92]` (*Player_Romus: ""The Delegates are still far away from the levers of powe..."*)
  - -> `[95]` (*Player_Romus: ""Look on the bright side. We finally have a parliament th..."*)

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""With some aid from the so-called free press, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""You are right, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Hugo Toras: ""But you must consider that they weren't elected out of n..."*)

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""But you must consider that they weren't elected out of nowhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""You are right, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""But the continued dominance of the RNC is proof that you..."*)

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""But the continued dominance of the RNC is proof that you should stay the course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""Indeed, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The RNC? You're sure they won?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false` AND `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false` AND `(Variable["BaseGame.Reform_Reformist_Path"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator), `[24]` (Narrator), `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "His expression turned quizzical."*)

### Węzeł `[59]`
Mówca: **Hugo Toras**
> ""Quite sure, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[60]`
Mówca: **Narrator**
> "His expression turned quizzical."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Hugo Toras: ""Quite sure, Your Majesty.""*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""And the hordes of foreigners suddenly clamoring to have ..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""In spite of the lies told by the so-called free press...""*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""And the hordes of foreigners suddenly clamoring to have their votes counted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""In spite of the lies told by the so-called free press...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Hugo Toras: ""Despite the hordes of foreigners suddenly clamoring to h..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[72]`
Mówca: **Hugo Toras**
> ""Despite the hordes of foreigners suddenly clamoring to have their votes counted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Hugo Toras: ""Unfortunately, today's meeting is not all good news.""*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Hugo Toras: ""In other news...""*)

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""Unfortunately, today's meeting is not all good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""In other news...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Hugo Toras: ""That isn't the only unpleasant news I have to share today.""*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Hugo Toras: ""But moving on to other news...""*)

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""That isn't the only unpleasant news I have to share today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[82]`
Mówca: **Hugo Toras**
> ""But moving on to other news...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[83]`
Mówca: **Hugo Toras**
> ""By unanimous vote, Daria de Rava has retained the position of House Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == false"*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Say what you will about Mr. Sazon, but he has earned that seat.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true` AND `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false` AND `(Variable["BaseGame.Reform_Reformist_Path"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator), `[24]` (Narrator), `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Hugo Toras: ""Has he?""*)

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""Has he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "His expression turned quizzical."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Hugo Toras: ""Thanks to the reform of our electoral system, hundreds o..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Hugo Toras: ""I wouldn't be surprised if House Sazon had a hand in man..."*)

### Węzeł `[89]`
Mówca: **Hugo Toras**
> ""Thanks to the reform of our electoral system, hundreds of experienced politicians lost their provincial council seats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Hugo Toras: ""Whether in the House of Delegates or across the country,..."*)

### Węzeł `[90]`
Mówca: **Hugo Toras**
> ""Whether in the House of Delegates or across the country, we now have a glut of newcomers, all of whom believe the country needs sweeping change without having the faintest clue how to accomplish it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player_Romus: ""What about the voter demographics? I want to know who vo..."*)
  - -> `[91]` (*Player_Romus: ""Give the new Delegates a chance, Your Grace. Their ideas..."*)
  - -> `[92]` (*Player_Romus: ""The Delegates are still far away from the levers of powe..."*)
  - -> `[95]` (*Player_Romus: ""Look on the bright side. We finally have a parliament th..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Give the new Delegates a chance, Your Grace. Their ideas could invigorate all of Rizia.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[51]` (Hugo Toras), `[90]` (Hugo Toras), `[52]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Hugo Toras: ""If they don't destroy it first.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Delegates are still far away from the levers of power. They can't actually do anything.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[51]` (Hugo Toras), `[90]` (Hugo Toras), `[52]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Hugo Toras: ""No. Not for now.""*)

### Węzeł `[93]`
Mówca: **Hugo Toras**
> ""No. Not for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""If they don't destroy it first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look on the bright side. We finally have a parliament that represents the people of this nation.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[51]` (Hugo Toras), `[90]` (Hugo Toras), `[52]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Hugo Toras: ""Indeed. Down to the last village idiot.""*)

### Węzeł `[96]`
Mówca: **Hugo Toras**
> ""Indeed. Down to the last village idiot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""I admit I questioned your reform of the Rizian electoral..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""I admit I questioned your reform of the Rizian electoral system at first. But we now know for a fact that the people of this kingdom favor stability and tradition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_Iza_SuOminaIntimidatesVote..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn06_Iza_SuOminaIntimidatesVoters = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Iza_SuOminaIntimidatesVoters"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_V_ElectionRPPWin = true;
RiziaDLCSupport.News_Turn06_RH_ElectionRPPWin = true;
RiziaDLCSupport.Reports_Turn06_Morella_CongraltulateRPPWin = true;
RiziaDLCSupport.Reports_Turn06_Kyrute_CongratulateSuccesfulElections = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_V_ElectionRPPWin"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_ElectionRPPWin"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Morella_CongraltulateRPPWin"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Kyrute_CongratulateSuccesfulElections"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_V_ElectionRNCWin = true;
RiziaDLCSupport.News_Turn06_RH_ElectionRNCWin = true;
RiziaDLCSupport.Reports_Turn06_Kyrute_CongratulateSuccesfulElections = true;
RiziaDLCSupport.Reports_Turn06_Rumburg_CongratulateRNCWin = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_V_ElectionRNCWin"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_ElectionRNCWin"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Kyrute_CongratulateSuccesfulElections"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Rumburg_CongratulateRNCWin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Hugo had a wide smile on his face."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_V_ElectionStatusQuo = true;
RiziaDLCSupport.News_Turn06_RH_ElectionStatusQuo = true;
RiziaDLCSupport.Reports_Turn06_Kyrute_CongratulateSuccesfulElections = true;
RiziaDLCSupport.Reports_Turn06_Rumburg_CongratulateRNCWin = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_V_ElectionStatusQuo"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_ElectionStatusQuo"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Kyrute_CongratulateSuccesfulElections"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_Rumburg_CongratulateRNCWin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Hugo smiled confidently."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_Lespia_CongratulateFreeEle..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn06_Lespia_CongratulateFreeElections = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Lespia_CongratulateFreeElections"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_Sordland_CongratulateRPPWi..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "He had a dour look on his face."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn06_Sordland_CongratulateRPPWin = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Sordland_CongratulateRPPWin"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "He had a dour look on his face."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == false"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == false)"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_Sordland_CongratulateRNCWi..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn06_Sordland_CongratulateRNCWin = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Sordland_CongratulateRNCWin"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Diplomacy_Pal..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player_Romus: ""What about the voter demographics? I want to know who vo..."*)
  - -> `[121]` (*Player_Romus: ""Thank you for the update.""*)
  - -> `[126]` (*Player_Romus: ""Well, I'm pleased with the outcome.""*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || Riz..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the update.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[67]` (Hugo Toras), `[72]` (Hugo Toras), `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't be so negative, Your Grace.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true` AND `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[67]` (Hugo Toras), `[72]` (Hugo Toras), `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || Riz..."*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || R..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player_Romus: ""Don't be so negative, Your Grace.""*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I'm pleased with the outcome.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[67]` (Hugo Toras), `[72]` (Hugo Toras), `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? Is that true?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false` AND `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false` AND `(Variable["BaseGame.Reform_Reformist_Path"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator), `[24]` (Narrator), `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Hugo Toras: ""Yes.""*)

### Węzeł `[128]`
Mówca: **Hugo Toras**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "His expression turned quizzical."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about the voter demographics? I want to know who voted for what.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[67]` (Hugo Toras), `[72]` (Hugo Toras), `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about the voter demographics? I want to know who voted for what.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[51]` (Hugo Toras), `[90]` (Hugo Toras), `[52]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Hugo Toras: ""Certainly.""*)

### Węzeł `[132]`
Mówca: **Hugo Toras**
> ""Certainly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "He started reading the documents in front of him."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "He started reading the documents in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolated.Voting_MiddleClass_RPP == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolate..."*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsola..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolated.Voting_MiddleClass_RPP == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] - Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Hugo Toras: ""The middle class appears divided in their support, almos..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolated.Voting_MiddleClass_RPP == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] - Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_MiddleClass_RNC >= 4"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && Riz..."*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && R..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Hugo Toras: ""Due to the inclusion of millions of new voters from fore..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Hugo Toras: ""Due to the inclusion of millions of new voters from fore..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Hugo Toras: ""The nobility, of course, is firmly supporting the RNC, a..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Hugo Toras: ""Due to the electoral reform which took the reserved seat..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[146]`
Mówca: **Hugo Toras**
> ""Due to the inclusion of millions of new voters from foreign origin, as well as the electoral reform which took the reserved seats for the nobles...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Hugo Toras: ""...The nobility had only an influence of around ten perc..."*)

### Węzeł `[147]`
Mówca: **Hugo Toras**
> ""...The nobility had only an influence of around ten percent on the overall election results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "He had a chastising look on his face."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == false)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && Riz..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && Riz..."*)

### Węzeł `[151]`
Mówca: **Hugo Toras**
> ""Despite the inclusion of millions of new voters from foreign origin, as well as the electoral reform which took the reserved seats for the nobles...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Hugo Toras: ""...The nobility is firmly supporting the RNC, and thus, ..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && Riz..."*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && R..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Hugo Toras: ""Despite the inclusion of millions of new voters from for..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Hugo Toras: ""Despite the electoral reform which took the reserved sea..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Hugo Toras: ""The nobility, of course, is firmly supporting the RNC, a..."*)

### Węzeł `[158]`
Mówca: **Hugo Toras**
> ""...The nobility is firmly supporting the RNC, and thus, the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_Nobility_RPP > 0"*)

### Węzeł `[159]`
Mówca: **Hugo Toras**
> ""Despite the electoral reform which took the reserved seats for the nobles...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Hugo Toras: ""...The nobility is firmly supporting the RNC, and thus, ..."*)

### Węzeł `[160]`
Mówca: **Hugo Toras**
> ""The nobility, of course, is firmly supporting the RNC, and thus, the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_Nobility_RPP > 0"*)

### Węzeł `[161]`
Mówca: **Hugo Toras**
> ""Due to the electoral reform which took the reserved seats for the nobles...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Hugo Toras: ""...The nobility's influence on the election results were..."*)

### Węzeł `[162]`
Mówca: **Hugo Toras**
> ""...The nobility's influence on the election results were more than halved in this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "He had a chastising look on his face."*)

### Węzeł `[163]`
Mówca: **Hugo Toras**
> ""Due to the inclusion of millions of new voters from foreign origin...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Hugo Toras: ""...The nobility's influence on the election results were..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_Nobility_RPP > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_Nobility_RPP > 0"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Voting_Nobility_RPP > 0)"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_Nobility_RPP > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Hugo Toras: ""However, there are rumors of certain members of the nobi..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Voting_Nobility_RPP > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_Nobility_RPP"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[167]`
Mówca: **Hugo Toras**
> ""However, there are rumors of certain members of the nobility to be supporting the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "He had a chastising look on his face."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolate..."*)

### Węzeł `[169]`
Mówca: **Narrator**
> "He had a chastising look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_MiddleClass_RNC >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_MiddleClass_RNC >= 4"*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Voting_MiddleClass_RNC >= 4)"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_MiddleClass_RNC >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Hugo Toras: ""We're doing better than ever with the middle class. We h..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Voting_MiddleClass_RNC >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_MiddleClass_RNC == 3"*)

### Węzeł `[173]`
Mówca: **Hugo Toras**
> ""We're doing reasonably well among the middle class. About two-thirds of them are supporting the RNC.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[174]`
Mówca: **Hugo Toras**
> ""The middle class appears divided in their support, almost exactly in half.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[175]`
Mówca: **Hugo Toras**
> ""We're doing better than ever with the middle class. We have an overwhelming majority of them behind the RNC.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_MiddleClass_RNC == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_MiddleClass_RNC == 3"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Voting_MiddleClass_RNC == 3)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_MiddleClass_RNC == 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Hugo Toras: ""We're doing reasonably well among the middle class. Abou..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Voting_MiddleClass_RNC == 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_MiddleClass_RNC == 2"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_MiddleClass_RNC == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_MiddleClass_RNC == 2"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Voting_MiddleClass_RNC == 2)"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_MiddleClass_RNC == 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Hugo Toras: ""We've fallen out of favor with the middle class. About t..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Voting_MiddleClass_RNC == 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] == 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_MiddleClass_RNC == 1"*)

### Węzeł `[182]`
Mówca: **Hugo Toras**
> ""We've fallen out of favor with the middle class. About two-thirds of them are now supporting the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[183]`
Mówca: **Hugo Toras**
> ""Our support among the middle class has plummeted. Only the upper middle class, which makes up a mere quarter are supporting the RNC.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_MiddleClass_RNC == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_MiddleClass_RNC == 1"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Voting_MiddleClass_RNC == 1)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_MiddleClass_RNC == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Hugo Toras: ""Our support among the middle class has plummeted. Only t..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Voting_MiddleClass_RNC == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Hugo Toras: ""To be frank, we have lost almost all of our support from..."*)

### Węzeł `[187]`
Mówca: **Hugo Toras**
> ""To be frank, we have lost almost all of our support from the middle class. They have given their support to the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_LowerClass_RNC - RiziaDLCIsolated.Voting_LowerClass_RPP == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_LowerClass_RNC - RiziaDLCIsolated..."*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Voting_LowerClass_RNC - RiziaDLCIsolat..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_LowerClass_RNC - RiziaDLCIsolated.Voting_LowerClass_RPP == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] - Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolate..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Voting_LowerClass_RNC - RiziaDLCIsolated.Voting_LowerClass_RPP == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] - Variable["RiziaDLCIsolated.Voting_LowerClass_RPP"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_LowerClass_RNC >= 3"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_LowerClass_RNC - RiziaDLCIsolated..."*)

### Węzeł `[192]`
Mówca: **Hugo Toras**
> ""Interestingly, the support of the lower class also appears to be divided in half.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_LowerClass_RNC >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_LowerClass_RNC >= 3"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Voting_LowerClass_RNC >= 3)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_LowerClass_RNC >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Hugo Toras: ""Fortunately, the RNC's popularity among our lower class ..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Voting_LowerClass_RNC >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_LowerClass_RNC == 2"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_LowerClass_RNC == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_LowerClass_RNC == 2"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Voting_LowerClass_RNC == 2)"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_LowerClass_RNC == 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] == 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && Riz..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Voting_LowerClass_RNC == 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] == 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_LowerClass_RNC == 1"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolated.Voting_MiddleClass_RPP == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolate..."*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsola..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolated.Voting_MiddleClass_RPP == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] - Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Hugo Toras: ""Interestingly, the support of the lower class also appea..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Voting_MiddleClass_RNC - RiziaDLCIsolated.Voting_MiddleClass_RPP == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_MiddleClass_RNC"] - Variable["RiziaDLCIsolated.Voting_MiddleClass_RPP"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Hugo Toras: ""However, the lower class citizens appear divided in thei..."*)

### Węzeł `[202]`
Mówca: **Hugo Toras**
> ""However, the lower class citizens appear divided in their support, almost exactly in half.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[203]`
Mówca: **Hugo Toras**
> ""Fortunately, the RNC's popularity among our lower class citizens has gone through the roof. We seem to have gained almost all of their votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && Riz..."*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && R..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Hugo Toras: ""Fortunately, the RNC's popularity among our lower class ..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true && RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Hugo Toras: ""Fortunately, the RNC's popularity among our lower class ..."*)

### Węzeł `[207]`
Mówca: **Hugo Toras**
> ""Fortunately, the RNC's popularity among our lower class citizens has gone through the roof. We seem to have gained a sizeable number of votes away from the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_LowerClass_RNC == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_LowerClass_RNC == 1"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Voting_LowerClass_RNC == 1)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_LowerClass_RNC == 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] == 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Hugo Toras: ""Unfortunately, the RNC's popularity among our lower clas..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Voting_LowerClass_RNC == 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_LowerClass_RNC"] == 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Hugo Toras: ""Unfortunately, we have next to no support from our lower..."*)

### Węzeł `[211]`
Mówca: **Hugo Toras**
> ""Unfortunately, the RNC's popularity among our lower class citizens remain very low. Most of them have given their support to the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[212]`
Mówca: **Hugo Toras**
> ""Unfortunately, we have next to no support from our lower class citizens. They have given their support to the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Hugo Toras: ""Of course, it wasn't enough.""*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[217]`
Mówca: **Hugo Toras**
> ""Of course, it wasn't enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Hugo Toras: ""And there are millions of foreigners who were also allow..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[222]`
Mówca: **Hugo Toras**
> ""Despite this fact, it wasn't enough to influence the outcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_NaturalizationForForeigners ==..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Hugo Toras: ""Despite this fact, it wasn't enough to influence the out..."*)

### Węzeł `[226]`
Mówca: **Hugo Toras**
> ""And there are millions of foreigners who were also allowed to vote in this election...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_Foreigners_RNC - RiziaDLCIsolated..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_Foreigners_RNC - RiziaDLCIsolated.Voting_Foreigners_RPP == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_Foreigners_RNC - RiziaDLCIsolated..."*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Voting_Foreigners_RNC - RiziaDLCIsolat..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_Foreigners_RNC - RiziaDLCIsolated.Voting_Foreigners_RPP == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] - Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Hugo Toras: ""Surprisingly, around half of them have voted for the RNC.""*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Voting_Foreigners_RNC - RiziaDLCIsolated.Voting_Foreigners_RPP == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] - Variable["RiziaDLCIsolated.Voting_Foreigners_RPP"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_Foreigners_RNC >= 3 || (RiziaDLC...."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_Foreigners_RNC >= 3 || (RiziaDLC.Policy_RD_Welfare_ElectoralReform == false && RiziaDLCIsolated.Voting_Foreigners_RNC >= 2)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_Foreigners_RNC >= 3 || (RiziaDLC...."*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Voting_Foreigners_RNC >= 3 || (RiziaDL..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_Foreigners_RNC >= 3 || (RiziaDLC.Policy_RD_Welfare_ElectoralReform == false && RiziaDLCIsolated.Voting_Foreigners_RNC >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] >= 3  or  (Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == false  and  Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] >= 2)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Hugo Toras: ""Surprisingly, an overwhelming majority of these people h..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Voting_Foreigners_RNC >= 3 || (RiziaDLC.Policy_RD_Welfare_ElectoralReform == false && RiziaDLCIsolated.Voting_Foreigners_RNC >= 2))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] >= 3  or  (Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == false  and  Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] >= 2)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_Foreigners_RNC >= 1"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_Foreigners_RNC >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Voting_Foreigners_RNC >= 1"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Voting_Foreigners_RNC >= 1)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Voting_Foreigners_RNC >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Hugo Toras: ""Surprisingly, a slight majority of these people have giv..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Voting_Foreigners_RNC >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Voting_Foreigners_RNC"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Hugo Toras: ""Unsurprisingly, all of them gave their support to the op..."*)

### Węzeł `[236]`
Mówca: **Hugo Toras**
> ""Surprisingly, around half of them have voted for the RNC.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[237]`
Mówca: **Hugo Toras**
> ""Surprisingly, an overwhelming majority of these people have given their support to the RNC.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[238]`
Mówca: **Hugo Toras**
> ""Surprisingly, a slight majority of these people have given their support to the RNC.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[239]`
Mówca: **Hugo Toras**
> ""Unsurprisingly, all of them gave their support to the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Hugo Toras: ""All in all, this election should make us concerned about..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Hugo Toras: ""All in all, I don't see anything that should concern us ..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Hugo Toras: ""Unfortunately, today's meeting is not all good news.""*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Hugo Toras: ""But moving on to other news...""*)

### Węzeł `[248]`
Mówca: **Hugo Toras**
> ""Unfortunately, today's meeting is not all good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[249]`
Mówca: **Hugo Toras**
> ""All in all, I don't see anything that should concern us at this moment regarding the House of Delegates. The RNC holds the power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "He stopped for a moment to gather his thoughts."*)

### Węzeł `[250]`
Mówca: **Hugo Toras**
> ""All in all, this election should make us concerned about the current climate within the House of Delegates. The RPP has now become a real threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "He stopped for a moment to gather his thoughts."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Hugo Toras: ""However, that isn't the only unpleasant news I have to s..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Hugo Toras: ""But moving on to other news...""*)

### Węzeł `[254]`
Mówca: **Hugo Toras**
> ""However, that isn't the only unpleasant news I have to share today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[255]`
Mówca: **Hugo Toras**
> ""But moving on to other news...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[256]`
Mówca: **Narrator**
> "He stopped for a moment to gather his thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[257]`
Mówca: **Narrator**
> "He stopped for a moment to gather his thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
