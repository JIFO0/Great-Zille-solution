# Sordland/Turn10/Bludish Issues + Scandals

- **ID konwersacji:** `236`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/236_Bludish_Issues_+_Scandals.md`
- **Liczba węzłów dialogowych:** 382
- **Liczba wyborów gracza:** 47

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[12]** Moderator
- **[15]** Mansoun Leke
- **[16]** Manoly Suheil
- **[22]** Denis Stahler
- **[32]** Frens Ricter
- **[44]** Lileas Graf
- **[50]** Kesaro Kibener
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Bill_Turn09_BludishCommission_Signed`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn03_Extraction_AddressProtestors`
- `BaseGame.Decision_Turn08_VPSelection_Albin`
- `BaseGame.Democratic`
- `BaseGame.Faction_NFP_Destroyed`
- `BaseGame.Faction_PFJP_Destroyed`
- `BaseGame.Killed_MarcelKoronti`
- `BaseGame.LeakedScandal_AlbinClavin_Bribe`
- `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP`
- `BaseGame.LeakedScandal_FrensRicter_Bribe`
- `BaseGame.LeakedScandal_FrensRicter_TaurusBribe`
- `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal`
- `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation`
- `BaseGame.LeakedScandal_PrivatizationShares_Both`
- `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti`
- `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk`
- `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses`
- `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp`
- `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Malenyevist`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.NoUnrest_Mansoun_Deal_Failed`
- `BaseGame.Policy_Law_Threshold_15`
- `BaseGame.Policy_Law_Threshold_Default`
- `BaseGame.Reform_Alliance_PFJP`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.Situation_Law_BludishProblem`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Situation_Law_MediaCensored`
- `BaseGame.Turn03_A_Protestors_Calm`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk`
- `BaseGame.Unrest_BFF_Deal_Failed`
- `BaseGame.Unrest_BFF_Deal_Signed`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGameIsolated.Debate_Enable_FrensRicter`
- `BaseGameIsolated.Debate_Enable_KesaroKibener`
- `BaseGameIsolated.Debate_Enable_LileasGraf`
- `BaseGameIsolated.Debate_Enable_ManolySuheil`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameIsolated.Turn10_A_NumberOfResignations`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Debate_DenisChallenge`
- `BaseGameIsolated.Debate_Enable_DenisStahler`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_ScandalConfronted`
- `BaseGameSupport.News_Turn10_R_SordlandFirstDebate_ScandalIgnored`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[238] Sordland/Turn10/Election + closing statements** (../Turn_10/238_Election_+_closing_statements.md), Węzeł `[1]`
- Węzeł `[10]` -> **[237] Sordland/Turn10/Denis Challenge** (../Turn_10/237_Denis_Challenge.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 13
- **Węzły modyfikujące stan gry:** 6

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[280]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_ScandalConfronted"] = true;`
- Węzeł `[281]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_ScandalConfronted"] = true;`
- Węzeł `[282]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn10_R_SordlandFirstDebate_ScandalIgnored"] = true; ;`
- Węzeł `[306]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- Węzeł `[308]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] = false; Variable["BaseGameIsolated.Debate...`
- Węzeł `[362]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Debate_DenisChallenge"] = true;`

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
  - -> `[6]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `238` (*Sordland/Turn10/Election + closing statements*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishReconciliation == true || BaseGame.Bludish_Opinion >= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishReconciliation == true || BaseGame.Bludish_Opinion >= 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[9]`
  - -> `[286]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_BludishReconciliation == true || BaseGame.Bludish_Opinion >= 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[14]`
  - -> `[11]`

### Węzeł `[6]`
Mówca: **Moderator**
> ""That brings me to my next question. What about the status of Sordland's minorities? I'm speaking particularly about the Bluds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[46]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""I'm proud to say that under my administration, the Bludish community has been given a voice.""]** — Mówca: **Player**
> ""I'm proud to say that under my administration, the Bludish community has been given a voice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[8]`
Mówca: **Frens Ricter**
> ""I will work with the WPB to ensure the Bludish people get the equal status they have been denied for so long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[40]`
  - -> `[78]`
  - -> `[117]`

### Węzeł `[9]`
**[WYBÓR GRACZA: ""The work I've done to further the Bludish cause was just the beginning. We still have a long way to go.""]** — Mówca: **Player**
> ""The work I've done to further the Bludish cause was just the beginning. We still have a long way to go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[10]`
Mówca: **Moderator**
> ""Ah. Um, right. Onto the next question--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `237` (*Sordland/Turn10/Denis Challenge*), Węzeł `[1]`

### Węzeł `[11]`
**[WYBÓR GRACZA: ""The events of the past four years have proven that peaceful coexistence between Sords and Bluds is a mere pipe dream.""]** — Mówca: **Player**
> ""The events of the past four years have proven that peaceful coexistence between Sords and Bluds is a mere pipe dream.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""Yes, we will all work together.""]** — Mówca: **Player**
> ""Yes, we will all work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""I'd like to yield the floor to Mr. Leke.""]** — Mówca: **Player**
> ""I'd like to yield the floor to Mr. Leke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""I have shown nothing but kindness towards the Bluds, and they have reacted only with violence.""]** — Mówca: **Player**
> ""I have shown nothing but kindness towards the Bluds, and they have reacted only with violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "Signal to the moderator to skip this question."]** — Mówca: **Player_Italic**
> "I signaled to the moderator to move on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[19]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I didn't say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I have no problem with the Bludish community as long as they make an effort to integrate into Sordish society. Like Mr. Leke here.""]** — Mówca: **Player**
> ""I have no problem with the Bludish community as long as they make an effort to integrate into Sordish society. Like Mr. Leke here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Thousands suffered under Soll. We cannot go back to that.""]** — Mówca: **Player**
> ""Thousands suffered under Soll. We cannot go back to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[22]`
**[WYBÓR GRACZA: ""You, ma'am, are no Tarquin Soll.""]** — Mówca: **Player**
> ""You, ma'am, are no Tarquin Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""He's in prison, Lileas. For a reason.""]** — Mówca: **Player**
> ""He's in prison, Lileas. For a reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""He's dead, Lileas. For a reason.""]** — Mówca: **Player**
> ""He's dead, Lileas. For a reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[25]`
Mówca: **Narrator**
> "Mansoun smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[26]`
Mówca: **Frens Ricter**
> ""I will work with the WPB to ensure the Bludish people get the representation he has denied them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[40]`
  - -> `[117]`

### Węzeł `[27]`
Mówca: **Manoly Suheil**
> ""I will work with the WPB to ensure the Bludish people get the equal status they have been denied for so long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[40]`
  - -> `[78]`
  - -> `[117]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[37]`
Mówca: **Manoly Suheil**
> ""I will work with the WPB to ensure the Bludish people get the representation he has denied them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[40]`
  - -> `[117]`

### Węzeł `[38]`
Mówca: **Mansoun Leke**
> ""The BFF and the Bludish people are not one and the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Mansoun shook his head sadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Good luck getting the Assembly to agree on that.""]** — Mówca: **Player**
> ""Good luck getting the Assembly to agree on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishReconciliation == true || BaseGame.Unrest_BFF_Deal_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishReconciliation == true || BaseGame.Unrest_BFF_Deal_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_BludishReconciliation == true || BaseGame.Unrest_BFF_Deal_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[44]`
Mówca: **Frens Ricter**
> ""It is true that President Rayne has only stoked the fires of xenophobia in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[45]`
Mówca: **Frens Ricter**
> ""As you can tell, xenophobia is alive and well in Sordland. Despite the president's best efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
Mówca: **Lileas Graf**
> ""It isn't too late to go back to the way things were. Under the USP, the glorious republic envisioned by Tarquin Soll can still become a reality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[21]`
  - -> `[142]`
  - -> `[19]`

### Węzeł `[50]`
Mówca: **Kesaro Kibener**
> ""We talk about safety when our country is facing conditions of insurgency?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[51]`
Mówca: **Remus Holstron**
> ""Safe? Safe?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[52]`
Mówca: **Mansoun Leke**
> ""Mr. President, I won't allow you to bring me into this. Not after the way our last talk ended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.NoUnrest_Mansoun_Deal_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.NoUnrest_Mansoun_Deal_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Deal_Failed"] == true  or  Variable["BaseGame.NoUnrest_Mansoun_Deal_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.NoUnrest_Mansoun_Deal_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Deal_Failed"] == true  or  Variable["BaseGame.NoUnrest_Mansoun_Deal_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Manoly Suheil**
> ""As you can tell, xenophobia is alive and well in Sordland. Despite the president's best efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[57]`
Mówca: **Mansoun Leke**
> ""Mr. President, I won't allow you to bring me into this. Not after the way you've treated my compatriots.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[58]`
Mówca: **Lileas Graf**
> ""To speak more generally, haven't we all had enough of upheaval? Of promises of radical change? Of having to check newspaper headlines daily to be sure our country is still intact?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[59]`
Mówca: **Narrator**
> "Mansoun struggled to stay calm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[60]`
Mówca: **Manoly Suheil**
> ""It is true that President Rayne has only stoked the fires of xenophobia in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[61]`
Mówca: **Denis Stahler**
> ""How dare you say that, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Narrator**
> "Mansoun struggled to stay calm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[63]`
Mówca: **Denis Stahler**
> ""The absence of the WPB in this studio speaks louder than your lies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[64]`
Mówca: **Mansoun Leke**
> ""President Rayne was only able to grant the Bludish people a small modicum of justice by exercising his executive powers. This has not magically erased centuries of anti-Bludish sentiment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Negotiating with terrorists. A dangerous mistake.""]** — Mówca: **Player**
> ""Negotiating with terrorists. A dangerous mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[66]`
Mówca: **Mansoun Leke**
> ""President Rayne has proven himself a more tolerant leader than his predecessors, but anti-Bludish sentiment remains deeply ingrained in our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[67]`
Mówca: **Lileas Graf**
> ""Surely there's a compromise between meeting the demands of violent militants and oppressing innocent civilians in a way that only incites further violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[68]`
Mówca: **Manoly Suheil**
> ""I'll spare you viewers another of the NFP's racist tirades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[69]`
Mówca: **Narrator**
> "The moderator hurriedly flipped a few pages ahead in her notepad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[70]`
Mówca: **Denis Stahler**
> ""As long as this man is in office, Bludish citizens in Sordland will never be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Moderator**
> ""Unsubstantiated rumors have no place in this debate, Mr. Stahler.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Unrest_BFF_Deal_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Unrest_BFF_Deal_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Unrest_BFF_Deal_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
Mówca: **Remus Holstron**
> ""It's the President's job to look after the safety of the Sordish people, and that's exactly what he has done. Although, of course, I believe more extreme actions must be taken--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[82]`
Mówca: **Kesaro Kibener**
> ""It's the President's job to look after the safety of the Sordish people, and that's exactly what he has done. Although, of course, I believe more safety measures could have been taken--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[83]`
Mówca: **Mansoun Leke**
> ""But a radical response was inevitable given the way the President continued the oppressive policies of his predecessors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[84]`
Mówca: **Narrator**
> "Lileas' voice was syrupy-sweet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[85]`
Mówca: **Mansoun Leke**
> ""As long as this man remains in office, no minority in Sordland will be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression == true || BaseGame.Situation_Law_BludishProblem == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression == true || BaseGame.Situation_Law_BludishProblem == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishOppression"] == true  or  Variable["BaseGame.Situation_Law_BludishProblem"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_BludishOppression == true || BaseGame.Situation_Law_BludishProblem == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishOppression"] == true  or  Variable["BaseGame.Situation_Law_BludishProblem"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishOppression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_BludishOppression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishOppression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[95]`
Mówca: **Lileas Graf**
> ""Gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[96]`
Mówca: **Denis Stahler**
> ""Well? Nobody else is going to address the allegations of bribery and corruption between Rayne and Ricter here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[97]`
Mówca: **Mansoun Leke**
> ""Electing Sordland's first leader of Bludish descent would help to create a bridge of lasting peace between our communities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
Mówca: **Remus Holstron**
> ""What about the governor's safety? What about the Soll Dam employees? The Bludish scum cannot be trusted to--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[99]`
Mówca: **Kesaro Kibener**
> ""What about the governor's safety? What about the Soll Dam employees? The Bludish people must recognize that this isn't right--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_LileasGraf == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[112]`
Mówca: **Kesaro Kibener**
> ""For someone who is against the different treatment of races you seem to put one race ahead of the other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[113]`
Mówca: **Denis Stahler**
> ""We all know how well you two work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[114]`
Mówca: **Remus Holstron**
> ""No. No!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[115]`
Mówca: **Denis Stahler**
> ""Look at you lovebirds, pretending to bicker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[116]`
Mówca: **Frens Ricter**
> ""I'll spare you viewers another of the NFP's racist tirades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[117]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I sat back and said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[118]`
Mówca: **Narrator**
> "His eyes focused on him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""Your so-called democracy will result in the Bludish people losing the rights I have won for them.""]** — Mówca: **Player**
> ""Your so-called democracy will result in the Bludish people losing the rights I have won for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[120]`
Mówca: **Narrator**
> "His eyes were practically bulging."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[121]`
Mówca: **Narrator**
> "Manoly smoothly cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[122]`
Mówca: **Narrator**
> "His eyes focused on him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[123]`
Mówca: **Narrator**
> "His eyes were practically bulging."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.LeakedScandal_FrensRicter_Bribe == true || BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.LeakedScandal_FrensRicter_Bribe == true || BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true)  and  Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.LeakedScandal_FrensRicter_Bribe == true || BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true)  and  Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[127]`
Mówca: **Narrator**
> "Frens smoothly cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.LeakedScandal_FrensRicter_Bribe == true || BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.LeakedScandal_FrensRicter_Bribe == true || BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true)  and  Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.LeakedScandal_FrensRicter_Bribe == true || BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true)  and  Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[140]`
Mówca: **Kesaro Kibener**
> ""Sordland must be led by capable people who understand and can represent the majority of the population. This has been the case since our great country was founded. I find it very dangerous that merits are thrown out of the window in support of an agenda. A blinded thought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[141]`
Mówca: **Remus Holstron**
> ""Sordland must be led by a maroon-blooded Sord, as has been the case since our great country was founded. It's exactly this kind of dangerous talk that proves why the Bludish question must be solved once and for--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[142]`
**[WYBÓR GRACZA: ""What are you talking about? I've made Sordland more stable than ever.""]** — Mówca: **Player**
> ""What are you talking about? I've made Sordland more stable than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[143]`
Mówca: **Lileas Graf**
> ""That's exactly what I mean. Such a rash and vindictive decision from an acting president. Is this what Sordland wants?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[144]`
Mówca: **Lileas Graf**
> ""No. I disagreed with certain of the Colonel's more brutally oppressive policies. I shall bring Soll's core values into a more enlightened, morally correct administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[145]`
Mówca: **Lileas Graf**
> ""Your willingness to rebel against the wishes of your own party means you cannot be trusted as a leader.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[146]`
Mówca: **Moderator**
> ""This seems a good enough a time as any to bring up the allegations that President Rayne has abused his power while in office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`
  - -> `[166]`
  - -> `[167]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Moderator**
> ""You've gone over your speaking time, Ms. Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Narrator**
> "Lileas neatly folded her arms and sat back in her chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[155]`
Mówca: **Moderator**
> ""You've gone over your speaking time, Ms. Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[156]`
Mówca: **Moderator**
> ""I believe it's time to move on to another subject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Narrator**
> "She hurriedly flipped through her notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandals_Severity >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandals_Severity >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[164]`
**[WYBÓR GRACZA: ""Nothing but a smear campaign to prevent my re-election.""]** — Mówca: **Player**
> ""Nothing but a smear campaign to prevent my re-election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[165]`
**[WYBÓR GRACZA: ""Compared to the blatant corruption of my predecessors, I'd say I'm doing pretty well for myself.""]** — Mówca: **Player**
> ""Compared to the blatant corruption of my predecessors, I'd say I'm doing pretty well for myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[166]`
**[WYBÓR GRACZA: ""The mistakes I made were those of a young and inexperienced president. They will not be repeated again.""]** — Mówca: **Player**
> ""The mistakes I made were those of a young and inexperienced president. They will not be repeated again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
**[WYBÓR GRACZA: ""I refuse to comment on said allegations at this time.""]** — Mówca: **Player**
> ""I refuse to comment on said allegations at this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.LeakedScandal_FrensRicter_Bribe == true ||BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.LeakedScandal_FrensRicter_Bribe == true ||BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true  or Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true)  and  Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.LeakedScandal_FrensRicter_Bribe == true ||BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true ))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true  or Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true)  and  Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[171]`
Mówca: **Denis Stahler**
> ""What does the esteemed head of the PFJP have to say about that, I wonder?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Narrator**
> "Frens fixed Denis with an icy stare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Frens Ricter**
> ""My press spokesperson has already issued a statement regarding the innocent misunderstanding between Mr. Rayne and myself. I will not rehash it here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_PFJP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Alliance_PFJP == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Frens Ricter**
> ""My press spokesperson has already issued a statement regarding how Mr. Rayne threatened and intimidated me into accepting his offer. I will not rehash it here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[213]`
  - -> `[218]`
  - -> `[215]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_LileasGraf == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_LileasGraf == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true)  and  Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true)  and  Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true  or  Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true  or  Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[190]`
Mówca: **Lileas Graf**
> ""I wonder what your vice president would have to say about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[201]`
  - -> `[212]`
  - -> `[220]`

### Węzeł `[191]`
Mówca: **Lileas Graf**
> ""I wonder what certain oligarchs would have to say about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[201]`
  - -> `[220]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true)  and  Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true)  and  Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Frens Ricter**
> ""I wonder what certain oligarchs would have to say about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[201]`
  - -> `[220]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true  or  Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true  or  Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[199]`
Mówca: **Frens Ricter**
> ""I wonder what your vice president would have to say about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[201]`
  - -> `[212]`
  - -> `[220]`

### Węzeł `[200]`
**[WYBÓR GRACZA: ""I was pressured into those actions by individuals who have since resigned.""]** — Mówca: **Player**
> ""I was pressured into those actions by individuals who have since resigned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_A_NumberOfResignations > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn10_A_NumberOfResignations > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true)  and  Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true)  and  Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true  or  Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true  or  Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[210]`
Mówca: **Denis Stahler**
> ""I wonder what your vice president would have to say about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[212]`
  - -> `[220]`

### Węzeł `[211]`
Mówca: **Denis Stahler**
> ""I wonder what certain oligarchs would have to say about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[201]`
  - -> `[220]`

### Węzeł `[212]`
**[WYBÓR GRACZA: ""My press spokesperson has already issued a statement regarding the innocent misunderstanding between Mr. Clavin and myself. I will not rehash it here.""]** — Mówca: **Player**
> ""My press spokesperson has already issued a statement regarding the innocent misunderstanding between Mr. Clavin and myself. I will not rehash it here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[213]`
**[WYBÓR GRACZA: ""I will remember your lack of loyalty during my next term.""]** — Mówca: **Player**
> ""I will remember your lack of loyalty during my next term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[214]`
**[WYBÓR GRACZA: ""You liar! You practically begged me for that check.""]** — Mówca: **Player**
> ""You liar! You practically begged me for that check.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[215]`
**[WYBÓR GRACZA: ""This is politics. You know the saying: You've got to kill the cow to make the zabla.""]** — Mówca: **Player**
> ""This is politics. You know the saying: You've got to kill the cow to make the zabla.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[216]`
**[WYBÓR GRACZA: ""Thank you, Frens.""]** — Mówca: **Player**
> ""Thank you, Frens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[217]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I kept my mouth shut."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[218]`
**[WYBÓR GRACZA: ""Is this a debate or a witch hunt? Can we move on?""]** — Mówca: **Player**
> ""Is this a debate or a witch hunt? Can we move on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Narrator**
> "The other candidates tittered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[223]`
  - -> `[224]`

### Węzeł `[220]`
**[WYBÓR GRACZA: ""Is this a debate or a witch hunt? Can we move on?""]** — Mówca: **Player**
> ""Is this a debate or a witch hunt? Can we move on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[221]`
Mówca: **Lileas Graf**
> ""I was a part of the administration. It was every bit as bad as they say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[226]`
  - -> `[220]`

### Węzeł `[222]`
**[WYBÓR GRACZA: ""Shut up, all of you! I am your President!""]** — Mówca: **Player**
> ""Shut up, all of you! I am your President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[223]`
**[WYBÓR GRACZA: ""MODERATOR! Next question!""]** — Mówca: **Player**
> ""MODERATOR! Next question!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[224]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I ignored them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[225]`
Mówca: **Moderator**
> ""Ahem... it's time we moved on anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[226]`
**[WYBÓR GRACZA: ""Stop that high-and-mighty act. I know who you really are.""]** — Mówca: **Player**
> ""Stop that high-and-mighty act. I know who you really are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[227]`
Mówca: **Frens Ricter**
> ""Rest assured the PFJP is committed to purging corruption from the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[201]`
  - -> `[226]`
  - -> `[220]`

### Węzeł `[228]`
Mówca: **Denis Stahler**
> ""Rest assured my party is committed to purging corruption from the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[201]`
  - -> `[226]`
  - -> `[220]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and  (Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and  (Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[232]`
Mówca: **Mansoun Leke**
> ""I'm sure you recall that one of his very first acts in office was to effectively shut the country's only Bludish party off from campaign funding...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaCensored"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaCensored"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Moderator**
> ""Indeed I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[237]`
Mówca: **Moderator**
> ""The President had a perfectly good explanation for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Mansoun Leke**
> ""Uh... regardless, electing Sordland's first leader of Bludish descent would help to create a bridge of lasting peace between our communities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[239]`
Mówca: **Narrator**
> "Mansoun raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[240]`
Mówca: **Moderator**
> ""Yes, I remember that well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[241]`
Mówca: **Mansoun Leke**
> ""You've been attempting to undermine my people from the moment you took office. Beginning with that bill depriving our party of election funding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[245]`
Mówca: **Moderator**
> ""The President had a perfectly good explanation for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true &&  BaseGame.Policy_Law_Threshold_15 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true &&  BaseGame.Policy_Law_Threshold_15 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and   Variable["BaseGame.Policy_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Signed == true &&  BaseGame.Policy_Law_Threshold_15 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and   Variable["BaseGame.Policy_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[249]`
Mówca: **Narrator**
> "Mansoun raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Mansoun Leke**
> ""Uh... regardless, as long as this man is in the Maroon Palace, no minority in Sordland will be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[257]`
Mówca: **Moderator**
> ""Yes, I remember that well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[258]`
Mówca: **Denis Stahler**
> ""You've been attempting to undermine the Bludish people from the moment you took office. Beginning with that bill depriving their party -- and mine -- of election funding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and  (Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and  (Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaCensored"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaCensored"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[265]`
Mówca: **Denis Stahler**
> ""Uh... regardless, as long as this man is in the Maroon Palace, no minority in Sordland will be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[266]`
Mówca: **Moderator**
> ""The President had a perfectly good explanation for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Narrator**
> "Denis raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[268]`
Mówca: **Frens Ricter**
> ""It's true that xenophobia is alive and well in Sordland. Despite the president's best efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[269]`
Mówca: **Manoly Suheil**
> ""It's true that xenophobia is alive and well in Sordland. Despite the president's best efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[279]`
Mówca: **Lileas Graf**
> ""Gentlemen. Ms. Suheil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_ScandalConfronted = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_ScandalConfronted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_ScandalConfronted = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_ScandalConfronted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_R_SordlandFirstDebate_ScandalIgnored = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_R_SordlandFirstDebate_ScandalIgnored"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[295]`
Mówca: **Mansoun Leke**
> ""Denis, calm down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Denis Stahler**
> ""No. The charade has gone on long enough. How can the blatant censorship of the media go unremarked upon on this stage?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[297]`
Mówca: **Narrator**
> "Denis rose from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[298]`
Mówca: **Denis Stahler**
> ""Admiration? You had me thrown in prison!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[315]`
  - -> `[307]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[302]`
**[WYBÓR GRACZA: ""Denis, I have nothing but admiration for you and your ideology. Please do not test my goodwill.""]** — Mówca: **Player**
> ""Denis, I have nothing but admiration for you and your ideology. Please do not test my goodwill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[303]`
Mówca: **Denis Stahler**
> ""Unbelievable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[304]`
Mówca: **Denis Stahler**
> ""They're more violent than they used to be, I'll agree with you there. But your reaction crossed a line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[305]`
Mówca: **Denis Stahler**
> ""This charade has gone on long enough. Can't you others see he has the media rigged against us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_DenisStahler = false)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[307]`
**[WYBÓR GRACZA: ""The Red Youth was out of control. You should have done something.""]** — Mówca: **Player**
> ""The Red Youth was out of control. You should have done something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke = false; BaseGameIsolated.Debate_Enable_DenisStahler = false)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] = false;
Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true  or  Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true  or  Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true  or  Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[319]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true  or  Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[315]`
**[WYBÓR GRACZA: ""Don't make me do it again.""]** — Mówca: **Player**
> ""Don't make me do it again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[316]`
Mówca: **Narrator**
> "He and Denis walked out of the studio. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[317]`
**[WYBÓR GRACZA: ""I didn't give that order.""]** — Mówca: **Player**
> ""I didn't give that order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[318]`
Mówca: **Narrator**
> "Denis loudly pushed his chair back and stormed out of the studio. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[319]`
Mówca: **Denis Stahler**
> ""Not to mention the disappearance of one of the most prominent opposition leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[320]`
Mówca: **Denis Stahler**
> ""Not to mention the disappearance of one of the most prominent opposition parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[321]`
Mówca: **Denis Stahler**
> ""Let's go, Mansoun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[322]`
Mówca: **Mansoun Leke**
> ""It doesn't have to be this way. Vote People's Front for real change in '57.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true  or  Variable["BaseGame.Killed_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true  or  Variable["BaseGame.Killed_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[326]`
Mówca: **Denis Stahler**
> ""To say nothing of the mysterious deaths of certain individuals in the President's orbit...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[327]`
**[WYBÓR GRACZA: ""Leave this building. Now.""]** — Mówca: **Player**
> ""Leave this building. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[328]`
Mówca: **Mansoun Leke**
> ""Sorry, Denis, I can't risk it. You're on your own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[329]`
Mówca: **Narrator**
> "The studio went deathly silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[333]`
  - -> `[342]`
  - -> `[337]`

### Węzeł `[330]`
Mówca: **Narrator**
> "Mansoun got up and looked into the camera."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[331]`
**[WYBÓR GRACZA: ""Mr. Stahler. If I really am as powerful as you claim, wouldn't it be extremely foolish of you to speak against me?""]** — Mówca: **Player**
> ""Mr. Stahler. If I really am as powerful as you claim, wouldn't it be extremely foolish of you to speak against me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[332]`
**[WYBÓR GRACZA: ""Sit back down. Now.""]** — Mówca: **Player**
> ""Sit back down. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[333]`
**[WYBÓR GRACZA: ""Mr. Stahler. Leave this stage and do not ever show your face in front of me again.""]** — Mówca: **Player**
> ""Mr. Stahler. Leave this stage and do not ever show your face in front of me again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 15)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist > 15)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Malenyevist > 15))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 15) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[340]`
Mówca: **Denis Stahler**
> ""I'll find my own way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[341]`
Mówca: **Denis Stahler**
> ""The hell you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[346]`
  - -> `[345]`

### Węzeł `[342]`
**[WYBÓR GRACZA: ""I have no idea what you're talking about.""]** — Mówca: **Player**
> ""I have no idea what you're talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[343]`
Mówca: **Denis Stahler**
> ""I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[327]`

### Węzeł `[344]`
Mówca: **Denis Stahler**
> ""Abdicating responsibility. A good look for a President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[345]`
**[WYBÓR GRACZA: ""If I was censoring the media, would I permit you to make this kind of scene?""]** — Mówca: **Player**
> ""If I was censoring the media, would I permit you to make this kind of scene?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
**[WYBÓR GRACZA: ""Whatever you think you know about me, it's a lie.""]** — Mówca: **Player**
> ""Whatever you think you know about me, it's a lie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[347]`
Mówca: **Narrator**
> "Denis gaped at me indignantly, then sat, his face red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[348]`
**[WYBÓR GRACZA: ""Guards, this man is a danger to me. Please escort him out of the building at once.""]** — Mówca: **Player**
> ""Guards, this man is a danger to me. Please escort him out of the building at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[352]`
Mówca: **Narrator**
> "Denis sat, his face red. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[353]`
Mówca: **Narrator**
> "Denis paled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[354]`
Mówca: **Denis Stahler**
> ""I won't play this game a second longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_Enable_MansounLeke == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Debate_Enable_MansounLeke == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[358]`
Mówca: **Denis Stahler**
> ""Let's just get this dog and pony show over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[359]`
Mówca: **Denis Stahler**
> ""Gladly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[360]`
Mówca: **Denis Stahler**
> ""I cannot fucking believe this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[361]`
Mówca: **Narrator**
> "The moderator took a moment to regain her composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Debate_DenisChallenge = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Debate_DenisChallenge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic < -10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic < -10)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Democratic"] < -10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Democratic < -10))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Democratic"] < -10) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishOppression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_BludishOppression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishOppression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishOppression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_BludishOppression == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishOppression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[372]`
Mówca: **Denis Stahler**
> ""Bludish citizens in Sordland should be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[373]`
Mówca: **Mansoun Leke**
> ""The great Bludish people wish to be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_Extraction_AddressProtestors == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_Extraction_AddressProtestors == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_Extraction_AddressProtestors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn03_Extraction_AddressProtestors == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_Extraction_AddressProtestors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[377]`
Mówca: **Denis Stahler**
> ""Since our confrontation in Narbel, I've known exactly what kind of man you are, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Calm == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[380]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Calm == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_A_Protestors_Calm"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_A_Protestors_Calm == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_A_Protestors_Calm"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[381]`
Mówca: **Denis Stahler**
> ""When we met in Narbel, you presented yourself as a reasonable man. But it was all an act, wasn't it, President Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
