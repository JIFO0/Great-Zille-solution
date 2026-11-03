# Sordland/Turn06/A_ReformistConvincePFJP

- **ID konwersacji:** `81`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/081_A_ReformistConvincePFJP.md`
- **Liczba węzłów dialogowych:** 488
- **Liczba wyborów gracza:** 118

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[32]** Frens Ricter

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Decision_Turn06_Megaproject_NoInvestment`
- `BaseGame.PersonalWealth`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Law_TermLimits_2`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Reform_Reform_PFJP_Convinced`
- `BaseGame.Relations_Frens_Bribed`
- `BaseGame.Relations_Frens_Promise_Seat`
- `BaseGame.Relations_Frens_Promise_Taurus`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGame.Turn04_InT_RailwayIssue_Solved`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.PersonalWealth`
- `BaseGame.Reform_Reform_PFJP_Convinced`
- `BaseGame.Relations_Frens_Bribed`
- `BaseGame.Relations_Frens_Promise_Seat`
- `BaseGame.Relations_Frens_Promise_Taurus`
- `BaseGameSupport.Journal_Turn06_Frens_Bribed`
- `BaseGameSupport.Journal_Turn06_Frens_Convinced`
- `BaseGameSupport.Journal_Turn06_Frens_PromisedSeat`
- `BaseGameSupport.Journal_Turn06_Frens_Taurus`
- `BaseGameSupport.News_Turn06_LT_PFJPConvinced`
- `BaseGameSupport.News_Turn06_LT_PFJPNotConvinced`
- `BaseGameSupport.News_Turn06_ST_RayneMeetsRicter`
- `BaseGameSupport.News_Turn06_ST_VictoryDay`
- `BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced`
- `BaseGameSupport.Report_Turn06_Holsord_PFJP_NotConvinced`
- `GameCondition.Turn06_A_Reform`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 15

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.PersonalWealth`
- `BaseGame.Relations_Frens_Bribed`
- `BaseGame.Relations_Frens_Promise_Seat`
- `BaseGame.Relations_Frens_Promise_Taurus`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[304]` (Frens Ricter): `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] = true;`
- Węzeł `[337]` (Frens Ricter): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;`
- Węzeł `[344]` (Frens Ricter): `Variable["BaseGame.Relations_Frens_Promise_Taurus"] = true;`
- Węzeł `[379]` (Frens Ricter): `Variable["BaseGame.Relations_Frens_Promise_Seat"] = true;`
- Węzeł `[380]` (Frens Ricter): `Variable["GameCondition.Turn06_A_Reform"] = true; Variable["BaseGameSupport.News_Turn06_ST_RayneM...`
- Węzeł `[426]` (Frens Ricter): `Variable["BaseGame.Relations_Frens_Bribed"] = true;`
- Węzeł `[467]` (Frens Ricter): `Variable["BaseGameSupport.Journal_Turn06_Frens_Bribed"] = true; Variable["BaseGameSupport.News_Tu...`
- Węzeł `[471]` (Frens Ricter): `Variable["BaseGameSupport.Journal_Turn06_Frens_Taurus"] = true; Variable["BaseGameSupport.News_Tu...`
- *...oraz 7 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Frens Ricter)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "But we desperately needed more support. That's why I had invited Frens Ricter for a chat about the upcoming vote. He and his party held the key to our success."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The preparations for the new Constitution were nearly complete. Soon we were going to propose it in the Grand National Assembly. A huge step for our administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[5]`
Mówca: **Narrator**
> "We met in the presidential office at the end of the day. He arrived in his signature navy blue suit and handed me a box of famous Arcasian chocolates before settling down on the couch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`
  - -> `[8]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""It's good to have you here, Mr. Ricter.""]** — Mówca: **Player**
> ""It's good to have you here, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""Thank you for the gift.""]** — Mówca: **Player**
> ""Thank you for the gift.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""You are a fan of Arcasia, aren't you?""]** — Mówca: **Player**
> ""You are a fan of Arcasia, aren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[9]`
Mówca: **Frens Ricter**
> ""Likewise. It's nice to finally have some time to talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[10]`
Mówca: **Frens Ricter**
> ""Oh, it's nothing, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[11]`
Mówca: **Frens Ricter**
> ""A fan of their chocolates, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Frens Ricter**
> ""You don't like them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`
  - -> `[16]`

### Węzeł `[13]`
Mówca: **Narrator**
> "He pointed to the box."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Oh, that's not what I meant. Thanks for the gift.""]** — Mówca: **Player**
> ""Oh, that's not what I meant. Thanks for the gift.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I don't like chocolate.""]** — Mówca: **Player**
> ""I don't like chocolate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""I don't like Arcasia.""]** — Mówca: **Player**
> ""I don't like Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Frens Ricter**
> ""Oh, come on. You can't deny there are a few things they do well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[18]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[19]`
Mówca: **Frens Ricter**
> ""Oh, I didn't know that, Mr. Rayne. Maybe your kids would like them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Frens Ricter**
> ""But I'll keep that in mind for next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Frens Ricter**
> ""It's nothing, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Narrator**
> "He took a folder from his briefcase and flipped it open. I could see the scribbles he'd made in the margins of my draft proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Frens Ricter**
> ""I have to say...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Frens Ricter**
> ""I am surprised by this proposal you've prepared for the new Constitution. I really do not understand your reasoning behind some of the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[36]`

### Węzeł `[25]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_TermLimits_2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[27]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_TermLimits_2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[28]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[30]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[31]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[33]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""I thought we were on the same page.""]** — Mówca: **Player**
> ""I thought we were on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
**[WYBÓR GRACZA: ""What parts don't you understand?""]** — Mówca: **Player**
> ""What parts don't you understand?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""What's on your mind?""]** — Mówca: **Player**
> ""What's on your mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[37]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[40]`
Mówca: **Frens Ricter**
> ""I thought so too. But it seems I was wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[41]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[44]`
Mówca: **Frens Ricter**
> ""I don't know where to begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[47]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Frens Ricter**
> ""Don't get me wrong, I like your draft. As I've already stated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[49]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[52]`
Mówca: **Frens Ricter**
> ""You want to remove the impeachment procedure from the Constitution. Why is that even part of the proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`
  - -> `[58]`

### Węzeł `[53]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[55]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[56]`
**[WYBÓR GRACZA: ""I'll need protection from the Supreme Court.""]** — Mówca: **Player**
> ""I'll need protection from the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""That was necessary for the whole package to work.""]** — Mówca: **Player**
> ""That was necessary for the whole package to work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""How about you look at the bigger picture instead?""]** — Mówca: **Player**
> ""How about you look at the bigger picture instead?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[59]`
Mówca: **Frens Ricter**
> ""Come on, Mr. Rayne. We are not in front of cameras right now. You already know that there is no way we could support this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[60]`
Mówca: **Frens Ricter**
> ""Protection? By eliminating the whole process?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[61]`
Mówca: **Frens Ricter**
> ""What bigger picture? This law would destroy the balances and checks of presidential power. I cannot create another Soll with my own hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[62]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[65]`
Mówca: **Frens Ricter**
> ""On top of that, you are not reforming the presidential decree process. This was not at all what we talked about. This has become the opposite of democratic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[66]`
Mówca: **Frens Ricter**
> ""You are not reforming the presidential decree process. This was not at all what we talked about. This has become the opposite of democratic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[67]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true && BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default == true && BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[69]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Default == true && BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[70]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[73]`
Mówca: **Frens Ricter**
> ""On top of that, you are expanding the Member of Honor laws to give yourself immunity after your term. This has turned into a power grab.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[74]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[77]`
Mówca: **Frens Ricter**
> ""You are expanding the Member of Honor laws to give yourself immunity after your term. Your proposal has turned into a power grab.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[78]`
Mówca: **Frens Ricter**
> ""On top of that, you're not reforming the presidential decree process *and* you're expanding the Member of Honor laws to give yourself total immunity after your term?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Frens Ricter**
> ""You have successfully hijacked our constitutional reform talks and created a proposal for your own benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Frens Ricter**
> ""Although we clearly want a new Constitution, this is not it, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[81]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[84]`
Mówca: **Frens Ricter**
> ""You're daring to strengthen presidential decree powers while expanding the Member of Honor laws to give yourself total immunity after your term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[85]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[87]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[88]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Frens Ricter**
> ""Not to mention that you have ignored our demands for a reform in the appointment of ministers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[92]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[95]`
Mówca: **Frens Ricter**
> ""Not to mention that you have ignored our demands to lower the undemocratic electoral threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[96]`
Mówca: **Frens Ricter**
> ""You have ignored our demands for a reform in the appointment of ministers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[97]`
Mówca: **Frens Ricter**
> ""You have ignored our demands to lower the undemocratic electoral threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Frens Ricter**
> ""How are you calling this a democratic package?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[100]`
  - -> `[99]`

### Węzeł `[99]`
**[WYBÓR GRACZA: ""You prefer Soll's Constitution then?""]** — Mówca: **Player**
> ""You prefer Soll's Constitution then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Be a realist, Mr. Ricter. This proposal is the best we can do.""]** — Mówca: **Player**
> ""Be a realist, Mr. Ricter. This proposal is the best we can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
**[WYBÓR GRACZA: ""These are all necessary to maintain stability.""]** — Mówca: **Player**
> ""These are all necessary to maintain stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[102]`
Mówca: **Frens Ricter**
> ""A realist?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[103]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[106]`
Mówca: **Frens Ricter**
> ""And you're refusing to lower our undemocratic electoral threshold...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[107]`
Mówca: **Frens Ricter**
> ""Is that your excuse, Mr. President? So this proposal is realistic but what we demand is not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Frens Ricter**
> ""And you're saying this while you're begging me for my party's support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[109]`
Mówca: **Frens Ricter**
> ""Necessary?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Frens Ricter**
> ""What kind of an excuse is that, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[111]`
Mówca: **Frens Ricter**
> ""This is not a contest, Mr. President. You know how I feel about the current Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Frens Ricter**
> ""But we must fix its shortcomings, not pronounce them further...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""I can't deny that we are desperate for your support.""]** — Mówca: **Player**
> ""I can't deny that we are desperate for your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Be it small or great, a step forward is a step forward.""]** — Mówca: **Player**
> ""Be it small or great, a step forward is a step forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[115]`
**[WYBÓR GRACZA: ""I still believe we can accomplish meaningful change together.""]** — Mówca: **Player**
> ""I still believe we can accomplish meaningful change together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""Yes, Frens. And you will give me your support.""]** — Mówca: **Player**
> ""Yes, Frens. And you will give me your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[117]`
Mówca: **Frens Ricter**
> ""I'm just shocked you listened to our demands. Decreasing the electoral threshold and the term limits... that's more than we hoped for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[118]`
Mówca: **Frens Ricter**
> ""I'm just shocked you listened to our demands. Decreasing the electoral threshold... that's more than we hoped for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[119]`
Mówca: **Frens Ricter**
> ""And I completely did not expect you to go against Tarquin Soll and abolish the Member of Honor laws. It's a bold move, and I respect it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Frens Ricter**
> ""How does the USP feel about that, Mr. President? Is this political suicide or did you actually manage to get the party behind your changes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[122]`
  - -> `[121]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""Why would you care if this was a political suicide for me?""]** — Mówca: **Player**
> ""Why would you care if this was a political suicide for me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""The USP is in agreement. It is up to you to support it now.""]** — Mówca: **Player**
> ""The USP is in agreement. It is up to you to support it now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""The party listens to what I say.""]** — Mówca: **Player**
> ""The party listens to what I say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[124]`
Mówca: **Frens Ricter**
> ""I cannot afford to support another set of failed reforms... I am the opposition leader after all, Mr. President. People expect me to be hard against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Frens Ricter**
> ""I've been campaigning for a new Constitution for years and I cannot just let it vanish because of Tarquin Soll's party again. No offense intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[126]`
Mówca: **Frens Ricter**
> ""Mrs. Tory didn't seem to be extremely enthusiastic about the new Constitution. Are you sure you have all the votes needed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Frens Ricter**
> ""I believe that the Chief Justice has her ear. And the Old Guard is doing their best to make sure you fail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Frens Ricter**
> ""Are you aware the Old Guard has been reaching out even to PFJP members? I hope you're doing something to contain this mess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[130]`
  - -> `[129]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""You're saying the PFJP can be bought?""]** — Mówca: **Player**
> ""You're saying the PFJP can be bought?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""Who would have thought? Of course they are, but we shouldn't worry.""]** — Mówca: **Player**
> ""Who would have thought? Of course they are, but we shouldn't worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""My hands are tied. We just need to focus on the upcoming vote.""]** — Mówca: **Player**
> ""My hands are tied. We just need to focus on the upcoming vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[132]`
Mówca: **Frens Ricter**
> ""What? No.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Frens Ricter**
> ""I am saying the circumstances might be stacked against you without your knowledge. That's it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[134]`
Mówca: **Frens Ricter**
> ""So you have a plan...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[135]`
Mówca: **Frens Ricter**
> ""I hope it works out, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[136]`
Mówca: **Frens Ricter**
> ""But even if the changes pass in Assembly, how are you going to win the Supreme Court over when your draft takes away the Justices' immunity?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`
  - -> `[140]`

### Węzeł `[137]`
Mówca: **Frens Ricter**
> ""But even if the changes pass in Assembly, how are you going to get such an anti-Sollist proposal past the Supreme Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`
  - -> `[140]`

### Węzeł `[138]`
**[WYBÓR GRACZA: ""We have a few connections on the inside. I'm going to handle that.""]** — Mówca: **Player**
> ""We have a few connections on the inside. I'm going to handle that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[139]`
**[WYBÓR GRACZA: ""Trust me, the Justices care about money more than anything else.""]** — Mówca: **Player**
> ""Trust me, the Justices care about money more than anything else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[140]`
**[WYBÓR GRACZA: ""If we unite together, they will be forced to support us.""]** — Mówca: **Player**
> ""If we unite together, they will be forced to support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Frens Ricter**
> ""I'm not so sure about that. A few Justices will sympathize with us, but the ultimate decision will be up to the centrists... And Orso has them locked up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[142]`
Mówca: **Frens Ricter**
> ""That's your plan? You're going to bribe them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Frens Ricter**
> ""Just be careful not to let it go public, Mr. President. It could hurt the whole reformist movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[144]`
Mówca: **Frens Ricter**
> ""Oh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Frens Ricter**
> ""Is Mrs. Edmonds one of them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`
  - -> `[224]`

### Węzeł `[146]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[148]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[149]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[151]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[152]`
Mówca: **Frens Ricter**
> ""I know. And we can help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[153]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[155]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[156]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[158]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[159]`
Mówca: **Frens Ricter**
> ""Isn't it funny how life works?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[160]`
Mówca: **Frens Ricter**
> ""While that's true, that shouldn't stop anyone from trying their best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[161]`
Mówca: **Frens Ricter**
> ""While that's true, we cannot settle for 'just enough' when we can achieve more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[162]`
Mówca: **Frens Ricter**
> ""Maybe we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[163]`
Mówca: **Frens Ricter**
> ""The only problem is... your proposal does not contain anything meaningful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[164]`
Mówca: **Frens Ricter**
> ""I'm not sure if that was a threat, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`
  - -> `[171]`

### Węzeł `[165]`
Mówca: **Frens Ricter**
> ""That being said, I may be willing to support this proposal even though I don't find it sufficient. However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[166]`
Mówca: **Frens Ricter**
> ""But I do not find the proposal by any means sufficient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Frens Ricter**
> ""But I do not find the proposal by any means sufficient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Frens Ricter**
> ""I'm still not sure what to make of it...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`
  - -> `[195]`

### Węzeł `[169]`
**[WYBÓR GRACZA: ""Of course not.""]** — Mówca: **Player**
> ""Of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""It was.""]** — Mówca: **Player**
> ""It was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[171]`
**[WYBÓR GRACZA: ""I just know that you will do the right thing.""]** — Mówca: **Player**
> ""I just know that you will do the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Frens Ricter**
> ""Is that so?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[173]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[175]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Frens Ricter**
> ""Which is to push for real reform right after your inevitable political suicide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[177]`
Mówca: **Frens Ricter**
> ""Look, Mr. Rayne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Frens Ricter**
> ""There is simply no way that we can support this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Frens Ricter**
> ""Let's not kid ourselves any longer. You're trying to destroy the Old Guard only so you can take their place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[204]`
  - -> `[203]`

### Węzeł `[180]`
Mówca: **Frens Ricter**
> ""Look, Mr. Rayne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Frens Ricter**
> ""There is simply no way that we can support this proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Frens Ricter**
> ""Let's not kid ourselves any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Frens Ricter**
> ""There is nothing in this for me or my party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[205]`
  - -> `[200]`

### Węzeł `[184]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Frens Ricter**
> ""Look, Mr. President. I may be willing to give my support to the proposal. But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[188]`
Mówca: **Frens Ricter**
> ""I'm sure it wasn't...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[189]`
Mówca: **Frens Ricter**
> ""Oh, good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Narrator**
> "He repositioned himself on the couch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[191]`
Mówca: **Frens Ricter**
> ""Then I don't have to feel bad about watching you commit political suicide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Frens Ricter**
> ""We have survived Tarquin Soll, surely we will survive you as well. Don't expect me to be scared of your threats, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[193]`
**[WYBÓR GRACZA: ""You're going to miss our chance for reforms just because they don't contain everything you want?""]** — Mówca: **Player**
> ""You're going to miss our chance for reforms just because they don't contain everything you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[194]`
**[WYBÓR GRACZA: ""What are you thinking about?""]** — Mówca: **Player**
> ""What are you thinking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
**[WYBÓR GRACZA: ""All you need to do is say yes.""]** — Mówca: **Player**
> ""All you need to do is say yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[196]`
Mówca: **Frens Ricter**
> ""You're putting all the reformists in a tough spot like this, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Frens Ricter**
> ""I'm sure it was tough to persuade your party to support this proposal... But this is what happens when you expect the USP to bring change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Frens Ricter**
> ""Don't expect me to sympathize with you. Not only have you minimized the potential of the reforms, you're taking the spotlight away from PFJP members who campaigned for these reforms for years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[199]`
Mówca: **Frens Ricter**
> ""That would be very useful, wouldn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[200]`
**[WYBÓR GRACZA: ""Don't make a mistake, Frens. You might regret it.""]** — Mówca: **Player**
> ""Don't make a mistake, Frens. You might regret it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[201]`
**[WYBÓR GRACZA: ""So you're looking for political gain after all.""]** — Mówca: **Player**
> ""So you're looking for political gain after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[202]`
**[WYBÓR GRACZA: ""There are no other plans. This was the most we could do with the proposal.""]** — Mówca: **Player**
> ""There are no other plans. This was the most we could do with the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[203]`
**[WYBÓR GRACZA: ""Don't make a mistake, Frens. You might regret it.""]** — Mówca: **Player**
> ""Don't make a mistake, Frens. You might regret it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[204]`
**[WYBÓR GRACZA: ""Come on, Mr. Ricter. I'm sure we can agree on something.""]** — Mówca: **Player**
> ""Come on, Mr. Ricter. I'm sure we can agree on something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[205]`
**[WYBÓR GRACZA: ""Come on, Mr. Ricter. I'm sure we can agree on something.""]** — Mówca: **Player**
> ""Come on, Mr. Ricter. I'm sure we can agree on something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[206]`
Mówca: **Frens Ricter**
> ""I don't appreciate that talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[207]`
Mówca: **Frens Ricter**
> ""I don't see anything to agree on. Your so called 'democratic reforms' will not silence the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[208]`
Mówca: **Frens Ricter**
> ""Then it seems it's time that you accept that real change will not come from the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Frens Ricter**
> ""If you really wanted change, you would have pushed for it. You are accepting failure without even trying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Frens Ricter**
> ""It is time to finally accept that real change will never come from the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Frens Ricter**
> ""I am sorry to disappoint you, but you'll find no support from me or my fellow reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[212]`
**[WYBÓR GRACZA: ""So you're looking for political gain after all...""]** — Mówca: **Player**
> ""So you're looking for political gain after all...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[213]`
**[WYBÓR GRACZA: ""Oh, is the idealist reformist asking for a bribe?""]** — Mówca: **Player**
> ""Oh, is the idealist reformist asking for a bribe?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[214]`
Mówca: **Frens Ricter**
> ""You'd better have something else to offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
**[WYBÓR GRACZA: ""I have nothing to offer but democracy...""]** — Mówca: **Player**
> ""I have nothing to offer but democracy...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[216]`
**[WYBÓR GRACZA: ""I'm sure you have something in mind.""]** — Mówca: **Player**
> ""I'm sure you have something in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Frens Ricter**
> ""I value Sordland and democracy more than anything, Mr. President. And I also have to look out for myself and my party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Frens Ricter**
> ""Surely you understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[219]`
Mówca: **Frens Ricter**
> ""Who said anything about a bribe?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[220]`
Mówca: **Frens Ricter**
> ""You're still going to use that word?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[221]`
Mówca: **Frens Ricter**
> ""If there's nothing else you'd like to talk about, I'd like to get going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`
  - -> `[284]`

### Węzeł `[222]`
**[WYBÓR GRACZA: ""Mrs. Morgna assured me that she's a lock.""]** — Mówca: **Player**
> ""Mrs. Morgna assured me that she's a lock.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[223]`
**[WYBÓR GRACZA: ""Not yet, but we're working on it.""]** — Mówca: **Player**
> ""Not yet, but we're working on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[224]`
**[WYBÓR GRACZA: ""Yes, she is supporting us.""]** — Mówca: **Player**
> ""Yes, she is supporting us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[225]`
Mówca: **Frens Ricter**
> ""If we're doing this, we have to make it count.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[226]`
Mówca: **Frens Ricter**
> ""I respect the Minister of Justice. If she's sure about this, I believe we might actually have a chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[227]`
Mówca: **Frens Ricter**
> ""You can't afford to fail this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Frens Ricter**
> ""That's good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Frens Ricter**
> ""I hope that you will succeed, Mr. Rayne. I respect what you're doing inside the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[230]`
Mówca: **Frens Ricter**
> ""And if we're talking about democracy here... I first need your promise that you're not going to cast a shadow over the PFJP anymore. You will give us proper credit and finally do something about the unbalanced representation of our party on state television.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
**[WYBÓR GRACZA: ""I don't think there's unbalanced representation.""]** — Mówca: **Player**
> ""I don't think there's unbalanced representation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[232]`
**[WYBÓR GRACZA: ""I can't promise you anything out of my control.""]** — Mówca: **Player**
> ""I can't promise you anything out of my control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[233]`
**[WYBÓR GRACZA: ""Of course, Mr. Ricter. You can count on me.""]** — Mówca: **Player**
> ""Of course, Mr. Ricter. You can count on me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[234]`
Mówca: **Frens Ricter**
> ""Mr. President, I thought we've been through this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Frens Ricter**
> ""Your party has spent decades trying to keep my party from gaining significance. If we are to be on the same side...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Frens Ricter**
> ""...We expect you to properly acknowledge the wrongs that have been done, and finally act against the Sollist state apparatus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[237]`
  - -> `[239]`

### Węzeł `[237]`
**[WYBÓR GRACZA: ""I can't deny the wrongdoing. But there's nothing I can do about it.""]** — Mówca: **Player**
> ""I can't deny the wrongdoing. But there's nothing I can do about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[238]`
**[WYBÓR GRACZA: ""You're right. You can count on my support.""]** — Mówca: **Player**
> ""You're right. You can count on my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[239]`
**[WYBÓR GRACZA: ""Do not blame the state. It was the people who elected the USP.""]** — Mówca: **Player**
> ""Do not blame the state. It was the people who elected the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[240]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == false && BaseGame.Reform_Law_Ministers_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == false && BaseGame.Reform_Law_Ministers_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == false  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_Default == false && BaseGame.Reform_Law_Ministers_Default == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == false  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Frens Ricter**
> ""Mr. President... We just want proper credit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[244]`
Mówca: **Frens Ricter**
> ""It seems we will not be seeing eye to eye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[245]`
Mówca: **Frens Ricter**
> ""That's good to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[246]`
**[WYBÓR GRACZA: ""Of course, Mr. Ricter. Your support will not go unnoticed.""]** — Mówca: **Player**
> ""Of course, Mr. Ricter. Your support will not go unnoticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[247]`
**[WYBÓR GRACZA: ""You deserve no credit. You're still beating around the bush with no real intention of support.""]** — Mówca: **Player**
> ""You deserve no credit. You're still beating around the bush with no real intention of support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[248]`
Mówca: **Frens Ricter**
> ""I should hope not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Law_Honorary_Presidents == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Law_Honorary_Presidents == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Law_Honorary_Presidents == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Frens Ricter**
> ""Then I can say that I'll be happy to cooperate with you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[253]`
Mówca: **Frens Ricter**
> ""In any case... It will be very tough to persuade my party with such a proposal. The reformists are not happy with how things developed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Frens Ricter**
> ""Even in the case of success, we have very little to gain from this. Do you have anything else to offer, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
Mówca: **Frens Ricter**
> ""We are talking about a lot of votes here... for something that will shape the future of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`
  - -> `[317]`
  - -> `[315]`

### Węzeł `[256]`
Mówca: **Frens Ricter**
> ""I will do my best to flip the Supreme Court as well. You can count on the PFJP's votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Frens Ricter**
> ""I just want your promise that you will give us proper credit and finally do something about the unbalanced representation of our party on state television.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Frens Ricter**
> ""For decades, your party has been doing whatever it could to stay in power while keeping the PFJP silenced. If we're to be on the same side...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Frens Ricter**
> ""...I expect you to finally acknowledge all the wrongs that have been done, and act against the Sollist state apparatus in full force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`
  - -> `[262]`

### Węzeł `[260]`
**[WYBÓR GRACZA: ""Of course, we're in this together.""]** — Mówca: **Player**
> ""Of course, we're in this together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[261]`
**[WYBÓR GRACZA: ""Of course I can't deny my party's disreputable actions.""]** — Mówca: **Player**
> ""Of course I can't deny my party's disreputable actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[262]`
**[WYBÓR GRACZA: ""Do not blame the USP. Sordland has gone through a lot.""]** — Mówca: **Player**
> ""Do not blame the USP. Sordland has gone through a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Frens Ricter**
> ""Whatever you say, Mr. President. As long as you do something about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[264]`
Mówca: **Frens Ricter**
> ""I respect your honesty, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Frens Ricter**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Frens Ricter**
> ""I hope I can rely on you. In the upcoming vote, we expect the USP to rally behind your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Frens Ricter**
> ""I can assure you, you'll have the PFJP's full support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`
  - -> `[270]`

### Węzeł `[268]`
**[WYBÓR GRACZA: ""The USP will not be a problem. With your support, these reforms will pass.""]** — Mówca: **Player**
> ""The USP will not be a problem. With your support, these reforms will pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[269]`
**[WYBÓR GRACZA: ""I'm happy to cooperate with you, Mr. Ricter.""]** — Mówca: **Player**
> ""I'm happy to cooperate with you, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
**[WYBÓR GRACZA: ""Don't doubt it. We'll change the Constitution together.""]** — Mówca: **Player**
> ""Don't doubt it. We'll change the Constitution together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[271]`
Mówca: **Frens Ricter**
> ""Likewise, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[272]`
Mówca: **Frens Ricter**
> ""I'm looking forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Frens Ricter**
> ""I'm looking forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Frens Ricter**
> ""Was there anything else?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
**[WYBÓR GRACZA: ""No, Mr. Ricter. Thank you for coming. I'm looking forward to our cooperation.""]** — Mówca: **Player**
> ""No, Mr. Ricter. Thank you for coming. I'm looking forward to our cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[276]`
**[WYBÓR GRACZA: ""Before you leave, I'd like to address a few things I've heard about you.""]** — Mówca: **Player**
> ""Before you leave, I'd like to address a few things I've heard about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Frens Ricter**
> ""There are so many 'things' said about me that I can't keep track of them anymore. What exactly do you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[278]`
Mówca: **Frens Ricter**
> ""It's nice to have a president that we can finally have a dialogue with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[280]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Frens Ricter**
> ""I'll see you in the history books. Have a nice evening for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[282]`
**[WYBÓR GRACZA: ""I'm sorry, Mr. Ricter. I'm sure we can still agree on something.""]** — Mówca: **Player**
> ""I'm sorry, Mr. Ricter. I'm sure we can still agree on something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[283]`
**[WYBÓR GRACZA: ""You're not going anywhere before we have a deal.""]** — Mówca: **Player**
> ""You're not going anywhere before we have a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[284]`
**[WYBÓR GRACZA: ""You're free to do as you want, Mr. Ricter.""]** — Mówca: **Player**
> ""You're free to do as you want, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Frens Ricter**
> ""Then I'll be leaving, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Frens Ricter**
> ""Thank you for the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[287]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[290]`
Mówca: **Frens Ricter**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[291]`
Mówca: **Frens Ricter**
> ""Please calm down, Mr. President. You're making a fool of yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Frens Ricter**
> ""There's nothing to agree on. This proposal is designed to give you more power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Frens Ricter**
> ""It's getting late. I must be going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Frens Ricter**
> ""I'd rather get going before it's too late, Mr. President. I think our meeting is over anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[296]`
Mówca: **Frens Ricter**
> ""Good luck in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Narrator**
> "He left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[298]`
Mówca: **Narrator**
> "He stood up and offered his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Italic**
> "I shook his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[300]`
**[WYBÓR GRACZA: "Don't shake his hand."]** — Mówca: **Player_Italic**
> "I ignored it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Narrator**
> "He left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[302]`
Mówca: **Frens Ricter**
> ""Good luck in the Assembly, Mr. President. Have a good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[303]`
Mówca: **Narrator**
> "He left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[305]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[307]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[308]`
Mówca: **Frens Ricter**
> ""I will hold you to your promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`
  - -> `[311]`

### Węzeł `[309]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[310]`
**[WYBÓR GRACZA: ""And I'll hold you to yours.""]** — Mówca: **Player**
> ""And I'll hold you to yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[311]`
**[WYBÓR GRACZA: ""I'm happy to cooperate with you too.""]** — Mówca: **Player**
> ""I'm happy to cooperate with you too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: Jump to: [PersuadedRicter])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: PersuadedRicter)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[314]`
**[WYBÓR GRACZA: ""Tell me what you want.""]** — Mówca: **Player**
> ""Tell me what you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[315]`
**[WYBÓR GRACZA: ""You damn corrupt bastard.""]** — Mówca: **Player**
> ""You damn corrupt bastard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[316]`
**[WYBÓR GRACZA: ""Nothing a check addressed to your name couldn't handle." [Bribe Offer -1 Personal Wealth]"]** — Mówca: **Player**
> ""Nothing a check addressed to your name couldn't handle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[317]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[319]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[320]`
Mówca: **Frens Ricter**
> ""A company that I'm involved with, Taurus Holding, has been conducting research on new machines for construction megaprojects and created a construction force that's unmatched in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[321]`
Mówca: **Frens Ricter**
> ""They have a great track record with efficiency and high-quality materials. They have been waiting for a large project to show their capabilities and definitely have the potential to be a leading brand in the world if the state decides to support it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Frens Ricter**
> ""I'd like you to give them a chance with the next state project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[323]`

### Węzeł `[323]`
**[WYBÓR GRACZA: ""I can't do that.""]** — Mówca: **Player**
> ""I can't do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
**[WYBÓR GRACZA: ""Consider it done.""]** — Mówca: **Player**
> ""Consider it done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[325]`
Mówca: **Frens Ricter**
> ""It's a shame things won't work out between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[343]`
  - -> `[345]`

### Węzeł `[326]`
Mówca: **Narrator**
> "He did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[329]`
  - -> `[332]`

### Węzeł `[327]`
**[WYBÓR GRACZA: ""Okay, tell me what you want.""]** — Mówca: **Player**
> ""Okay, tell me what you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[328]`
**[WYBÓR GRACZA: ""Okay, how about a few checks addressed to your name then?" [BRIBE, -1 Personal Wealth]"]** — Mówca: **Player**
> ""Okay, how about a few checks addressed to your name then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[329]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[331]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[332]`
**[WYBÓR GRACZA: ""I can't give you anything else.""]** — Mówca: **Player**
> ""I can't give you anything else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[333]`
Mówca: **Frens Ricter**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[334]`
Mówca: **Frens Ricter**
> ""Now you've got my attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Narrator**
> "After some back-and-forth, we agreed on a sum and decided how to transfer it. Frens shook my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Frens Ricter**
> ""I'm glad we were able to cooperate, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[337]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[338]`
Mówca: **Frens Ricter**
> ""Then I think I can't promise you in persuading all my people. It's a tough job, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[339]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[342]`
**[WYBÓR GRACZA: ""Nothing a check worth close to a million couldn't handle." [BRIBE, -1 Personal Wealth]"]** — Mówca: **Player**
> ""Nothing a check worth a million couldn't handle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[343]`
**[WYBÓR GRACZA: ""I can try to give you a cabinet position.""]** — Mówca: **Player**
> ""I can try to give you a cabinet position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[344]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Taurus = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Frens_Promise_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[345]`
**[WYBÓR GRACZA: ""There won't be any deals.""]** — Mówca: **Player**
> ""There won't be any deals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[346]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Frens Ricter**
> ""I will hold you to your promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[349]`
  - -> `[350]`

### Węzeł `[348]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: Jump to: [PersuadedRicter])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[349]`
**[WYBÓR GRACZA: ""And I'll hold you to yours.""]** — Mówca: **Player**
> ""And I'll hold you to yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[350]`
**[WYBÓR GRACZA: ""I'm happy to have reached a deal.""]** — Mówca: **Player**
> ""I'm happy to have reached a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[351]`
Mówca: **Frens Ricter**
> ""...Then you have the support of the PFJP, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[352]`
Mówca: **Frens Ricter**
> ""I'll do my best to gather the support of my party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[356]`
  - -> `[353]`

### Węzeł `[353]`
**[WYBÓR GRACZA: ""I'm happy to have gotten to know the real you, Frens.""]** — Mówca: **Player**
> ""I'm happy to have gotten to know the real you, Frens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[354]`
**[WYBÓR GRACZA: ""That's great to hear.""]** — Mówca: **Player**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[355]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: Jump to: [PersuadedRicter])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[356]`
**[WYBÓR GRACZA: ""Likewise, Mr. Ricter. I like this cooperative spirit.""]** — Mówca: **Player**
> ""Likewise, Mr. Ricter. I like this cooperative spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[357]`
Mówca: **Frens Ricter**
> ""Are you joking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`
  - -> `[360]`

### Węzeł `[358]`
**[WYBÓR GRACZA: ""No. There may be some vacancies sooner or later.""]** — Mówca: **Player**
> ""No. There may be some vacancies sooner or later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[359]`
**[WYBÓR GRACZA: ""I can try and force someone to resign.""]** — Mówca: **Player**
> ""I can try and force someone to resign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[360]`
**[WYBÓR GRACZA: ""Obviously.""]** — Mówca: **Player**
> ""Obviously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[361]`
Mówca: **Narrator**
> "He did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[366]`

### Węzeł `[362]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[365]`
**[WYBÓR GRACZA: ""Okay, how about a few checks?" [BRIBE]"]** — Mówca: **Player**
> ""Okay, how about a few checks?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[366]`
**[WYBÓR GRACZA: ""It seems there won't be any deals.""]** — Mówca: **Player**
> ""It seems there won't be any deals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[367]`
Mówca: **Frens Ricter**
> ""So it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[368]`
Mówca: **Frens Ricter**
> ""I can't believe that you'd offer such a thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[369]`
Mówca: **Frens Ricter**
> ""But all right. Here's what I'll say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Frens Ricter**
> ""I'll try my best to convince my people to support this proposal, even though they have their problems with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Frens Ricter**
> ""I can't promise you full support. But then, you can't promise me anything either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[372]`
Mówca: **Frens Ricter**
> ""If everything works out, I'll expect you to at least try to fulfil your promise. If you can give me a cabinet position after we enact the reforms, I'd be a great partner to have inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`
  - -> `[375]`
  - -> `[376]`

### Węzeł `[373]`
**[WYBÓR GRACZA: ""Sounds good.""]** — Mówca: **Player**
> ""Sounds good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[374]`
**[WYBÓR GRACZA: ""I promise I'll figure something out.""]** — Mówca: **Player**
> ""I promise I'll figure something out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[375]`
**[WYBÓR GRACZA: ""I'll do my best.""]** — Mówca: **Player**
> ""I'll do my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[376]`
**[WYBÓR GRACZA: ""Finally! Thanks for the support.""]** — Mówca: **Player**
> ""Finally! Thanks for the support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Frens Ricter**
> ""Great. Then we have a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: Jump to: [PersuadedRicter])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[379]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Seat = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Frens_Promise_Seat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[380]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: GameCondition.Turn06_A_Reform = true;
BaseGameSupport.News_Turn06_ST_RayneMeetsRicter = true;)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn06_A_Reform"] = true;
Variable["BaseGameSupport.News_Turn06_ST_RayneMeetsRicter"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[381]`
**[WYBÓR GRACZA: ""I received intelligence that you made a deal with Arcasia and that you tried covering your tracks. What do you have to say about that?""]** — Mówca: **Player**
> ""I received intelligence that you made a deal with Arcasia and that you tried covering your tracks. What do you have to say about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[382]`
**[WYBÓR GRACZA: ""Do you have some sort of secret partnership with President Dwight Walker? There are rumors about his influence on you.""]** — Mówca: **Player**
> ""Do you have some sort of secret partnership with President Dwight Walker? There are rumors about his influence on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Frens Ricter**
> ""Oh, it did come to that, after all... Well, I will enlighten you about my relationship with Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Frens Ricter**
> ""Because I've met with Walker before? I am the leader of Sordland's largest opposition party and free to visit anyone I please. But since you asked, I will explain the context of our relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[385]`
Mówca: **Frens Ricter**
> ""As you know, the downfall of President Alphonso was abrupt. He was the only progressive hope we had in the USP. Our brief alliance with him accomplished great things, but we ran into a very concerning revelation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[386]`
**[WYBÓR GRACZA: ""Wait. What are you trying to say?""]** — Mówca: **Player**
> ""Wait. What are you trying to say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[387]`
Mówca: **Frens Ricter**
> ""In our last meeting before the USP abandoned him, President Alphonso said that Soll was not gone and still pulled the strings behind his back. He was suspicious about a conspiracy against his reformist agenda and he feared everything would collapse around him...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[388]`
Mówca: **Frens Ricter**
> ""...And it did. Afterwards the party voted you in. I don't think it was a coincidence, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`
  - -> `[389]`
  - -> `[404]`

### Węzeł `[389]`
**[WYBÓR GRACZA: ""You think Soll and the Old Guard orchestrated all of this?""]** — Mówca: **Player**
> ""You think Soll and the Old Guard orchestrated all of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[390]`
**[WYBÓR GRACZA: ""Act how?""]** — Mówca: **Player**
> ""Act how?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[391]`
Mówca: **Frens Ricter**
> ""I am trying to say that everything leading up to the 1953 election was orchestrated by the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[392]`
Mówca: **Frens Ricter**
> ""Yes. They knew that Alphonso's reforms would cripple their strength and remove them from power... So they removed him first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Frens Ricter**
> ""After realizing the true extent of the Sollist deep state's influence, I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Frens Ricter**
> ""We are in this together, so I will be honest. I lost hope that Sordland could ever achieve the liberties and democracy that I'd been working so hard for as long as Sollism was still alive and well. So I decided to act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[396]`
  - -> `[406]`

### Węzeł `[395]`
Mówca: **Narrator**
> "He looked down for a second and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[396]`
**[WYBÓR GRACZA: ""I hope you didn't do anything to compromise our country.""]** — Mówca: **Player**
> ""I hope you didn't do anything to compromise our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[397]`
Mówca: **Frens Ricter**
> ""Of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Frens Ricter**
> ""I was contacted by an Arcasian senator and one of Arcasia's biggest tycoons. And I decided to agree to their meeting in hopes of receiving support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`
  - -> `[408]`

### Węzeł `[399]`
Mówca: **Frens Ricter**
> ""I flew to Arcasia and I eventually met President Walker. He offered political and economic support for me and my party, asking us to lead Sordland into the democratic sphere and become a member of the ATO. But the exploitative conditions he was demanding would have had crippling effects on our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[400]`
**[WYBÓR GRACZA: ""I am grateful that you're telling me all this.""]** — Mówca: **Player**
> ""I am grateful that you're telling me all this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[401]`
**[WYBÓR GRACZA: ""So the intel was correct after all...""]** — Mówca: **Player**
> ""So the intel was correct after all...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[402]`
**[WYBÓR GRACZA: ""That was a big mistake from your side.""]** — Mówca: **Player**
> ""That was a big mistake from your side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[403]`
Mówca: **Frens Ricter**
> ""I told him that I was only there to increase economic cooperation and nothing else. I did not get their support, nor did I do anything illegal. To this day, I feel ashamed to have gone to the feet of Arcasia like that. But at least I managed to stop myself from becoming the very thing I've been fighting against.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[401]`
  - -> `[400]`
  - -> `[407]`

### Węzeł `[404]`
**[WYBÓR GRACZA: ""You're saying I was elected because Soll wanted it?""]** — Mówca: **Player**
> ""You're saying I was elected because Soll wanted it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[405]`
Mówca: **Frens Ricter**
> ""I don't know. But your candidacy was definitely connected to the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[406]`
**[WYBÓR GRACZA: ""I don't like where this is going.""]** — Mówca: **Player**
> ""I don't like where this is going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[407]`
**[WYBÓR GRACZA: ""I don't know if I can trust you after this.""]** — Mówca: **Player**
> ""I don't know if I can trust you after this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[408]`
**[WYBÓR GRACZA: ""You did what!?""]** — Mówca: **Player**
> ""You did what!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[409]`
**[WYBÓR GRACZA: "Let him continue."]** — Mówca: **Player_Italic**
> "I kept listening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[410]`
Mówca: **Frens Ricter**
> ""Please allow me to continue, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[411]`
Mówca: **Frens Ricter**
> ""I know...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[412]`
Mówca: **Frens Ricter**
> ""To some extent, yes. But now you know the real story.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[413]`
Mówca: **Frens Ricter**
> ""Thanks for taking it so well. We must always be honest with one another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[414]`
Mówca: **Frens Ricter**
> ""The fact that I've told you something this incriminating should be an indication that you can trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[415]`
Mówca: **Frens Ricter**
> ""You have the authority to investigate this and potentially prosecute me for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[416]`
Mówca: **Frens Ricter**
> ""I gave you my trust. I hope I have yours too. I will always acknowledge my wrongs and keep fighting for a better future. I believe we are not that different in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[418]`
  - -> `[419]`

### Węzeł `[417]`
**[WYBÓR GRACZA: ""I'll trust you, Mr. Ricter.""]** — Mówca: **Player**
> ""I'll trust you, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[418]`
**[WYBÓR GRACZA: ""You are correct. I hope to be together in this fight for a better future.""]** — Mówca: **Player**
> ""You are correct. I hope to be together in this fight for a better future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[419]`
**[WYBÓR GRACZA: ""I appreciate your trust in me, but I'll need to think more about this.""]** — Mówca: **Player**
> ""I appreciate your trust in me, but I'll need to think more about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Frens Ricter**
> ""That's fair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[421]`
Mówca: **Frens Ricter**
> ""As the revolutionaries once said, 'The morning will come', Mr. Rayne. We'll see it one day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Frens Ricter**
> ""That means a lot coming from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[423]`
Mówca: **Frens Ricter**
> ""Anyway, if you ever want to discuss this topic further, feel free to call me. I don't have anything to hide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[424]`
Mówca: **Frens Ricter**
> ""I'll get going now, if you'll excuse me. Thanks for the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[425]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[426]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Bribed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Frens_Bribed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[427]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_NoInvestment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_NoInvestment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_NoInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[429]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_NoInvestment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_NoInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Frens Ricter**
> ""I know you have already concluded the draft with your party, but the proposal is forcing our hand. Normally, this is not something we could support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[431]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_TaurusHolding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_TaurusHolding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_TaurusHolding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[434]`
Mówca: **Frens Ricter**
> ""A company that I'm involved with, Taurus Holding, has been conducting research on new machines for construction megaprojects and created a construction force that's unmatched in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[435]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`
  - -> `[437]`

### Węzeł `[436]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[437]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[438]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_HighwayIssue_Solved == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`
  - -> `[440]`

### Węzeł `[439]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_HighwayIssue_Solved == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[440]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_InT_HighwayIssue_Solved == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[441]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_RailwayIssue_Solved == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`
  - -> `[443]`

### Węzeł `[442]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_InT_RailwayIssue_Solved == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[443]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_InT_RailwayIssue_Solved == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[444]`
Mówca: **Frens Ricter**
> ""You already know about their efficiency and high-quality materials. They did a great job with the new H-3 Line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[445]`
Mówca: **Frens Ricter**
> ""I'd like you to give them another chance with the next state project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[449]`
  - -> `[323]`

### Węzeł `[446]`
Mówca: **Frens Ricter**
> ""You already know about their efficiency and high quality materials. They did a great job with the new L-1 railway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[447]`
Mówca: **Frens Ricter**
> ""I know you had some troubles with the H-3 Line, but they have greatly increased their capabilities and they now definitely surpass the potential to be a leading brand in the world. If the state decides to support it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[448]`
Mówca: **Frens Ricter**
> ""I know you had some troubles with the L-1 Line, but they have greatly increased their capabilities and they now definitely surpass the potential to be a leading brand in the world. If the State decides to support it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[449]`
**[WYBÓR GRACZA: ""Their work left much to be desired. I will not work with them again.""]** — Mówca: **Player**
> ""Their work left much to be desired. I will not work with them again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[450]`
Mówca: **Frens Ricter**
> ""All I wanted was a democratic constitution, Mr. Rayne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[451]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`
  - -> `[453]`

### Węzeł `[452]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[453]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[454]`
Mówca: **Frens Ricter**
> ""And if we're talking about democracy here... I first need to trust your agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[455]`
Mówca: **Frens Ricter**
> ""And I currently do not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[456]`
Mówca: **Frens Ricter**
> ""The first bill you signed effectively removed all other parties from funding. You are hijacking the elections from the very start. How can we trust you now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`
  - -> `[458]`
  - -> `[459]`

### Węzeł `[457]`
**[WYBÓR GRACZA: ""That bill also increased your funding, Mr. Ricter...""]** — Mówca: **Player**
> ""That bill also increased your funding, Mr. Ricter...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[458]`
**[WYBÓR GRACZA: ""It was passed by the Assembly. All I did was sign it into law.""]** — Mówca: **Player**
> ""It was passed by the Assembly. All I did was sign it into law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[459]`
**[WYBÓR GRACZA: ""The past is past, Mr. Ricter. Let's fix the future.""]** — Mówca: **Player**
> ""The past is past, Mr. Ricter. Let's fix the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[460]`
Mówca: **Frens Ricter**
> ""Oh, so I should be grateful for a small increase in funding? While your party gets all the rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[461]`
Mówca: **Frens Ricter**
> ""Exactly. You *did* sign it into law, and did not use your veto on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[462]`
Mówca: **Frens Ricter**
> ""Well, it's not so simple, Mr. Rayne. You came here with a proposal that ignored our demands. On top of it, you're not even acknowledging your mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[463]`
Mówca: **Frens Ricter**
> ""I think it's too late to fix anything now. I can't see any deals being made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[464]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Bribed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`
  - -> `[466]`

### Węzeł `[465]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Bribed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Bribed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[466]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Bribed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Bribed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[467]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Frens_Bribed = true;
BaseGameSupport.News_Turn06_LT_PFJPConvinced = true;
BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Frens_Bribed"] = true;
Variable["BaseGameSupport.News_Turn06_LT_PFJPConvinced"] = true;
Variable["BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[468]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Taurus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`
  - -> `[470]`

### Węzeł `[469]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Taurus == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[470]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Promise_Taurus == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[471]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Frens_Taurus = true;
BaseGameSupport.News_Turn06_LT_PFJPConvinced = true;
BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Frens_Taurus"] = true;
Variable["BaseGameSupport.News_Turn06_LT_PFJPConvinced"] = true;
Variable["BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[472]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Frens_PromisedSeat = true;
BaseGameSupport.News_Turn06_LT_PFJPConvinced = true;
BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Frens_PromisedSeat"] = true;
Variable["BaseGameSupport.News_Turn06_LT_PFJPConvinced"] = true;
Variable["BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[473]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Seat == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`
  - -> `[475]`

### Węzeł `[474]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Frens_Promise_Seat == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Seat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[475]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Frens_Promise_Seat == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Seat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[476]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`
  - -> `[478]`

### Węzeł `[477]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_PFJP_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[478]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_PFJP_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[479]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Frens_Convinced = true;
BaseGameSupport.News_Turn06_LT_PFJPConvinced = true;
BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Frens_Convinced"] = true;
Variable["BaseGameSupport.News_Turn06_LT_PFJPConvinced"] = true;
Variable["BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[480]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_LT_PFJPNotConvinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_LT_PFJPNotConvinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[481]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`
  - -> `[483]`

### Węzeł `[482]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[483]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[484]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn06_Holsord_PFJP_NotConvinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn06_Holsord_PFJP_NotConvinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[485]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[486]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_ST_VictoryDay = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_ST_VictoryDay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[487]`
Mówca: **Frens Ricter**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
