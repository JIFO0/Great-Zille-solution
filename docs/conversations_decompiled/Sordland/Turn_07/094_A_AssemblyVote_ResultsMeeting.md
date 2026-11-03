# Sordland/Turn07/A_AssemblyVote_ResultsMeeting

- **ID konwersacji:** `94`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/094_A_AssemblyVote_ResultsMeeting.md`
- **Liczba węzłów dialogowych:** 54
- **Liczba wyborów gracza:** 7

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Amendment_PFJP_Frens_Convinced`
- `BaseGame.Bill_Turn07_LanguageBill_Signed`
- `BaseGame.Reform_Reform_AssemblyVote_Success`
- `BaseGame.Reform_Reform_NFP_Convinced`
- `BaseGame.Reform_Reform_PFJP_Convinced`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.Report_Turn07_Holsord_VoteFail_USPCriticizes`
- `BaseGameSupport.Report_Turn07_Holsord_VoteWon_KibenerCongratulates`
- `BaseGameSupport.Report_Turn07_Holsord_VoteWon_RicterCongratulates`
- `GameCondition.Turn07_A_AssemblyVote_ResultsMeeting`

### Skoki między-konwersacyjne:
- Węzeł `[4]` -> **[96] Sordland/Turn07/VoteWon** (../Turn_07/096_VoteWon.md), Węzeł `[1]`
- Węzeł `[5]` -> **[95] Sordland/Turn07/VoteLost** (../Turn_07/095_VoteLost.md), Węzeł `[1]`
- Węzeł `[10]` -> **[97] Sordland/Turn07/Kesaro&FrensDialogue** (../Turn_07/097_Kesaro&FrensDialogue.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 6

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[36]` (Lucian Galade): `Variable["GameCondition.Turn07_A_AssemblyVote_ResultsMeeting"] = true;`
- Węzeł `[40]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn07_Holsord_VoteWon_KibenerCongratulates"] = true;`
- Węzeł `[41]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn07_Holsord_VoteFail_USPCriticizes"] = true;`
- Węzeł `[48]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn07_Holsord_VoteWon_RicterCongratulates"] = true;`
- Węzeł `[52]` (Lucian Galade): `End();`
- Węzeł `[53]` (Lucian Galade): `SetRichPresence("Signed a bill which restricts teaching in other languages","Maroon Palace","Hols...`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `96` (*Sordland/Turn07/VoteWon*), Węzeł `[1]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_AssemblyVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `95` (*Sordland/Turn07/VoteLost*), Węzeł `[1]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
> ""I think it's time to conclude our little meeting, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Lucian looked at his watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[8]`
Mówca: **Narrator**
> "There was a tap on my shoulder. Livia Suno had joined us on the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[9]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true || BaseGame.Reform_Reform_PFJP_Convinced == true || BaseGame.Amendment_PFJP_Frens_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true || BaseGame.Reform_Reform_PFJP_Convinced == true || BaseGame.Amendment_PFJP_Frens_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true  or  Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true  or  Variable["BaseGame.Amendment_PFJP_Frens_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `97` (*Sordland/Turn07/Kesaro&FrensDialogue*), Węzeł `[1]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_NFP_Convinced == true || BaseGame.Reform_Reform_PFJP_Convinced == true || BaseGame.Amendment_PFJP_Frens_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true  or  Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true  or  Variable["BaseGame.Amendment_PFJP_Frens_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[12]`
Mówca: **Petr Vectern**
> ""Getting pretty hot out here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Livia Suno**
> ""Pardon the interruption, gentlemen. Mr. President, Deivid Wisci is calling about the upcoming foreign policy meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""I need a drink.""]** — Mówca: **Player**
> ""I need a drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""Okay. Let's call it finished. You may both go.""]** — Mówca: **Player**
> ""Okay. Let's call it finished. You may both go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[16]`
Mówca: **Petr Vectern**
> ""I can help you with that. If you want...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Petr Vectern**
> ""After I'm finished with the arrangements, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[18]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Not today, Petr. Please focus on your duties for now.""]** — Mówca: **Player**
> ""Not today, Petr. Please focus on your duties for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Of course. Find me when you're done. We'll go have some nice whiskey.""]** — Mówca: **Player**
> ""Of course. Find me when you're done. We'll go have some nice whiskey.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Petr Vectern**
> ""Great. My mouth's already watering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
Mówca: **Petr Vectern**
> ""Y-yeah, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""All right, gentlemen. See you later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[24]`
Mówca: **Narrator**
> "They both left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Perfect timing. Tell him I'll be right there.""]** — Mówca: **Player**
> ""Perfect timing. Tell him I'll be right there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Tell him I'm busy.""]** — Mówca: **Player**
> ""Tell him I'm busy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""You know the details. Handle him yourself.""]** — Mówca: **Player**
> ""You know the details. Handle him yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Livia Suno**
> ""I will, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Narrator**
> "She turned to leave the balcony, then back to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_AssemblyVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Livia Suno**
> ""Congratulations on the victory, Mr. Rayne. Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Livia Suno**
> ""My condolences on the vote results, Mr. Rayne. Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Narrator**
> "She looked Petr in the eye as she said this, and ignored Lucian altogether. Petr's eyes followed her as she walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_A_AssemblyVote_ResultsMeeting = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_A_AssemblyVote_ResultsMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[37]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_AssemblyVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_AssemblyVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_AssemblyVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_VoteWon_KibenerCongratulates = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_VoteWon_KibenerCongratulates"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_VoteFail_USPCriticizes = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_VoteFail_USPCriticizes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[42]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_NFP_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_PFJP_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[48]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_VoteWon_RicterCongratulates = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_VoteWon_RicterCongratulates"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn07_LanguageBill_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[52]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: SetRichPresence("Signed a bill which restricts teaching in other languages", "Maroon Palace", "Holsord");)*
- **Efekt (`userScript`):** `SetRichPresence("Signed a bill which restricts teaching in other languages","Maroon Palace","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
