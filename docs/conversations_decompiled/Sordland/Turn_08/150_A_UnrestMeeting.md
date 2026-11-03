# Sordland/Turn08/A_UnrestMeeting

- **ID konwersacji:** `150`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/150_A_UnrestMeeting.md`
- **Liczba węzłów dialogowych:** 734
- **Liczba wyborów gracza:** 96

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[44]** Lileas Graf
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_CapitalistRayne`
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Archetype_SollistRayne`
- `BaseGame.BFF_EliminationOperation`
- `BaseGame.BergiaSteel_Nationalization`
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Bill_Turn07_LanguageBill_Signed`
- `BaseGame.BlackTuesdayHappened`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn04_RiotGear_Buy`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn08_AschrafSupport_DontGo`
- `BaseGame.Decision_Turn08_AschrafSupport_Go`
- `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity`
- `BaseGame.Economy`
- `BaseGame.HeartOfSordland_Nationalization`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.NedamMiningGroup_Privatization`
- `BaseGame.Policy_Law_SpecialZoneOfBergia`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Security_Unrest_Military`
- `BaseGame.Security_Unrest_Police`
- `BaseGame.Situation_Order_BFF_ThreatEliminated`
- `BaseGame.SordishStateCorporation_Privatization`
- `BaseGame.SuperpowerTradeWarHappened`
- `BaseGame.Turn03_EnT_Education_Budget_Decrease`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`
- `BaseGame.Turn04_SnO_LE_Justice_Decreased`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_SecretState_Detained_FrensRicter`
- `BaseGame.Turn07_SecretState_Detained_KesaroKibener`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGame.Unrest_Peaceful_Happened`
- `BaseGame.Unrest_Violent_Happened`
- `BaseGame.Wehlen_JointOperation`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Democratic`
- `BaseGame.Economy`
- `BaseGame.Economy_Bergia`
- `BaseGame.LateGameCrisis`
- `BaseGame.Public_Opinion`
- `BaseGame.Security_Unrest_Diplomatic`
- `BaseGame.Security_Unrest_Military`
- `BaseGame.Security_Unrest_Police`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.Situation_Law_BludishProblem`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Situation_Order_BFF_ThreatAlarming`
- `BaseGame.Situation_Order_BFF_ThreatContinues`
- `BaseGame.Situation_Order_BFF_ThreatEliminated`
- `BaseGame.Situation_Order_BludishUprising`
- `BaseGame.Situation_Order_Nationwide_Protests`
- `BaseGame.Situation_Order_Nationwide_Quelled`
- `BaseGame.Situation_Order_Nationwide_Revolt`
- `BaseGame.Sollist`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGame.Unrest_Peaceful_Happened`
- `BaseGame.Unrest_Violent_Happened`
- `BaseGameSupport.Journal_Turn08_Unrest_Diplomatic`
- `BaseGameSupport.Journal_Turn08_Unrest_Military`
- `BaseGameSupport.Journal_Turn08_Unrest_Police`
- `GameCondition.Turn08_A_UnrestMeeting`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 44

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`
- `BaseGame.Economy_Bergia`
- `BaseGame.Security_Unrest_Diplomatic`
- `BaseGame.Security_Unrest_Military`
- `BaseGame.Security_Unrest_Police`
- `BaseGame.Sollist`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGame.Unrest_Peaceful_Happened`
- `BaseGame.Unrest_Violent_Happened`
- `BaseGameSupport.Journal_Turn08_Unrest_Diplomatic`
- `BaseGameSupport.Journal_Turn08_Unrest_Military`
- `BaseGameSupport.Journal_Turn08_Unrest_Police`
- *...oraz 1 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[486]` (Lucian Galade): `Variable["GameCondition.Turn08_A_UnrestMeeting"] = true;`
- Węzeł `[535]` (Lucian Galade): `Variable["BaseGame.Unrest_BFF_Happened"] = true; Variable["BaseGame.Economy"] = Variable["BaseGam...`
- Węzeł `[536]` (Lucian Galade): `Variable["BaseGame.Unrest_Peaceful_Happened"] = true; Variable["BaseGame.Economy"] = Variable["Ba...`
- Węzeł `[537]` (Lucian Galade): `Variable["BaseGame.Unrest_Peaceful_Happened"] = true; Variable["BaseGame.Economy"] = Variable["Ba...`
- Węzeł `[538]` (Lucian Galade): `Variable["BaseGame.Unrest_Peaceful_Happened"] = true; Variable["BaseGame.Economy"] = Variable["Ba...`
- Węzeł `[539]` (Lucian Galade): `Variable["BaseGame.Unrest_Peaceful_Happened"] = true; Variable["BaseGame.Economy"] = Variable["Ba...`
- Węzeł `[540]` (Lucian Galade): `Variable["BaseGame.Unrest_Violent_Happened"] = true; Variable["BaseGame.Economy"] = Variable["Bas...`
- Węzeł `[541]` (Lucian Galade): `Variable["BaseGame.Unrest_Violent_Happened"] = true; Variable["BaseGame.Economy"] = Variable["Bas...`
- *...oraz 36 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Lileas entered my office and took a seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[4]`
Mówca: **Lileas Graf**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "“A problem? Like what?”"]** — Mówca: **Player**
> "“A problem? Like what?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[6]`
Mówca: **Narrator**
> "She was frowning intensely. She didn't talk at first, just fixed me with a steady gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "When she did speak up, it was in strained tones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[8]`
Mówca: **Lileas Graf**
> "“We have a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[5]`
  - -> `[10]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Explain. Now.”"]** — Mówca: **Player**
> "“Explain. Now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= -12)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion <= -12)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= -12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`

### Węzeł `[13]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion <= -12))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= -12) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[19]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion <= -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_SollistRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[23]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion <= -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[26]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_CapitalistRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_CapitalistRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_CapitalistRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[29]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[31]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion <= -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[32]`
Mówca: **Narrator**
> "The report was titled 'BFF Attack on Soll Dam'. I looked up immediately after reading the title."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "Take a look at the report."]** — Mówca: **Player_Italic**
> "I took the document from her hands and started reading it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`

### Węzeł `[34]`
Mówca: **Lileas Graf**
> "“This just came in. Here, take a look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[35]`
Mówca: **Lileas Graf**
> "“Yes. You read that right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[36]`
Mówca: **Narrator**
> "The report was titled 'Violent Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[37]`
Mówca: **Narrator**
> "The report was titled 'Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[38]`
Mówca: **Lileas Graf**
> "“I can't say this is unexpected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Lileas Graf**
> "“What is unexpected, however, is the sheer size of the protests and the level of violence. A few people have been killed already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Lileas Graf**
> "“Sordland hasn't seen this much civil unrest since the death of Bernard Circas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[70]`
  - -> `[69]`

### Węzeł `[41]`
Mówca: **Narrator**
> "The report was titled 'Violent Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[42]`
Mówca: **Lileas Graf**
> "“They are protesting you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Lileas Graf**
> "“They are asking for your resignation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[44]`
Mówca: **Lileas Graf**
> "“I can't say this is unexpected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[77]`
  - -> `[76]`

### Węzeł `[45]`
Mówca: **Lileas Graf**
> "“They are asking for your resignation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[46]`
Mówca: **Lileas Graf**
> "“They are protesting you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“Anti-communism protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[48]`
Mówca: **Lileas Graf**
> "“I don't know who is behind this, but protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Lileas Graf**
> "“These people have the gall to protest against the very foundations our country is based on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Lileas Graf**
> "“They seem to be anti-Sollist in nature.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[51]`
Mówca: **Lileas Graf**
> "“As if that is not enough, they are turning violent! A few people have been killed already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Lileas Graf**
> "“We need to put an end to this. We can't let them sully the name of Soll further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[82]`
  - -> `[81]`

### Węzeł `[53]`
Mówca: **Narrator**
> "The report was titled 'Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[54]`
Mówca: **Lileas Graf**
> "“I don't know who is behind this, but protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[55]`
Mówca: **Lileas Graf**
> "“These people have the gall to protest against the very foundations our country is based on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[90]`
  - -> `[93]`

### Węzeł `[56]`
Mówca: **Lileas Graf**
> "“They seem to be anti-Sollist in nature.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[57]`
Mówca: **Narrator**
> "The report was titled 'Violent Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[58]`
Mówca: **Lileas Graf**
> "“Anti-capitalism protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Lileas Graf**
> "“Anti-capitalism protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[60]`
Mówca: **Lileas Graf**
> "“They are protesting you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Lileas Graf**
> "“I can't say this is unexpected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[62]`
Mówca: **Lileas Graf**
> "“They are asking for your resignation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[63]`
Mówca: **Lileas Graf**
> "“Sordland hasn't seen this kind of unrest since the death of Bernard Circas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[98]`
  - -> `[97]`

### Węzeł `[64]`
Mówca: **Narrator**
> "The report was titled 'Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[65]`
Mówca: **Lileas Graf**
> "“They are asking for your resignation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
Mówca: **Lileas Graf**
> "“They are protesting you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[67]`
Mówca: **Lileas Graf**
> "“What is unexpected, however, is the sheer size of the protests and the level of violence. Several people have been killed already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[68]`
Mówca: **Lileas Graf**
> "“I can't say this is unexpected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[110]`
  - -> `[111]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Change doesn't come easy. There is always a cost.”"]** — Mówca: **Player**
> "“Change doesn't come easy. There is always a cost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“We need to look at *now*. We will need to handle these protests.”"]** — Mówca: **Player**
> "“We need to look at *now*. We will need to handle these protests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“Enough. We can't let the tensions rise to those levels again.”"]** — Mówca: **Player**
> "“Enough. We can't let the tensions rise to those levels again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[72]`
Mówca: **Lileas Graf**
> "“Yes, but we must do everything in our power to keep that cost low.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[73]`
Mówca: **Lileas Graf**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[74]`
Mówca: **Lileas Graf**
> "“We are on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[75]`
Mówca: **Lileas Graf**
> "“Yes, and it's our duty to keep that cost as low as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“Change doesn't come easy. There is always a cost.”"]** — Mówca: **Player**
> "“Change doesn't come easy. There is always a cost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“We will need to handle these protests.”"]** — Mówca: **Player**
> "“We will need to handle these protests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Lileas Graf**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "“I didn't ask you for your opinion.”"]** — Mówca: **Player**
> "“I didn't ask you for your opinion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Lileas Graf**
> "“No, you didn't. Yet here we are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“What do you want me to do? Detain all of them?”"]** — Mówca: **Player**
> "“What do you want me to do? Detain all of them?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“We must be careful not to suppress their freedom of speech.""]** — Mówca: **Player**
> "“We must be careful not to suppress their freedom of speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“I agree. They are committing borderline treason.”"]** — Mówca: **Player**
> "“I agree. They are committing borderline treason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
Mówca: **Lileas Graf**
> "“Detaining some people would certainly be a start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[85]`
Mówca: **Lileas Graf**
> "“How can you call this freedom of speech? They are spitting on the name of the founder of our country!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Lileas Graf**
> "“If they don't like it, they can go somewhere else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[87]`
Mówca: **Lileas Graf**
> "“We need to handle them immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "“I agree. They are committing borderline treason.”"]** — Mówca: **Player**
> "“I agree. They are committing borderline treason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Lileas Graf**
> "“We need to handle them immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“We must be careful not to suppress their freedom of speech.""]** — Mówca: **Player**
> "“We must be careful not to suppress their freedom of speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Lileas Graf**
> "“Detaining *some* of them is certainly a start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[92]`
Mówca: **Lileas Graf**
> "“How can you call this freedom of speech? They are spitting on the name of the founder of our country!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“What do you want me to do? Detain all of them?”"]** — Mówca: **Player**
> "“What do you want me to do? Detain all of them?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[94]`
Mówca: **Lileas Graf**
> "“If they don't like it, they can go somewhere else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[95]`
Mówca: **Lileas Graf**
> "“We are on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[96]`
Mówca: **Lileas Graf**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "“Change doesn't come easy. There is always a cost.”"]** — Mówca: **Player**
> "“Change doesn't come easy. There is always a cost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
**[WYBÓR GRACZA: "“We need to look at *now*. We will need to handle these protests.”"]** — Mówca: **Player**
> "“We need to look at *now*. We will need to handle these protests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[99]`
**[WYBÓR GRACZA: "“Enough. We can't let the tensions rise to those levels again.”"]** — Mówca: **Player**
> "“Enough. We can't let the tensions rise to those levels again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[100]`
Mówca: **Lileas Graf**
> "“Yes, and it's our duty to keep that cost as low as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[101]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[102]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[103]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`

### Węzeł `[104]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[105]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[106]`
Mówca: **Lileas Graf**
> "“Yes, and it's our duty to keep that cost as low as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Lileas Graf**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[109]`
Mówca: **Lileas Graf**
> "“No, you didn't. Yet here we are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“We will need to handle these protests.”"]** — Mówca: **Player**
> "“We will need to handle these protests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "“Change doesn't come easy. There is always a cost.”"]** — Mówca: **Player**
> "“Change doesn't come easy. There is always a cost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“I didn't ask you for your opinion.”"]** — Mówca: **Player**
> "“I didn't ask you for your opinion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[113]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[116]`
  - -> `[115]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[119]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[122]`
  - -> `[121]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[125]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[128]`
  - -> `[127]`

### Węzeł `[127]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[128]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[131]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[134]`
  - -> `[133]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[134]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[137]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[140]`
  - -> `[139]`

### Węzeł `[139]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[143]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[146]`
  - -> `[145]`

### Węzeł `[145]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[146]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[149]`
Mówca: **Karl Greiser**
> "“Your orders, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[152]`
  - -> `[546]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Search and destroy. Eliminate the enemies of the state.”"]** — Mówca: **Player**
> "“Search and destroy. Eliminate the enemies of the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "“I will involve the military. This has gotten out of hand.”"]** — Mówca: **Player**
> "“I will involve the military. This has gotten out of hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "“Infiltrate the dam quietly and take them out. No need to cause a ruckus.”"]** — Mówca: **Player**
> "“Infiltrate the dam quietly and take them out. No need to cause a ruckus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[153]`
Mówca: **Lileas Graf**
> "“The Bludish Freedom Front has taken over Soll Dam.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Lileas Graf**
> "“Thankfully, no casualties have been reported yet. We know that they have taken the staff as hostages.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`
  - -> `[159]`

### Węzeł `[155]`
Mówca: **Lileas Graf**
> "“That dam currently provides 90% of electricity to Bergia and its neighbouring regions. If they destroy the power station...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Lileas Graf**
> "“...I don't even want to think about the outcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[157]`
**[WYBÓR GRACZA: "“This is ridiculous. How could we let this happen?”"]** — Mówca: **Player**
> "“This is ridiculous. How could we let this happen?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[158]`
**[WYBÓR GRACZA: "“If news of this ever gets out, we will be the laughing stock of the entire world.”"]** — Mówca: **Player**
> "“If news of this ever gets out, we will be the laughing stock of the entire world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "“What are their demands?”"]** — Mówca: **Player**
> "“What are their demands?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[160]`
Mówca: **Lileas Graf**
> "“Yes. We need to solve this as quickly and quietly as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[161]`
Mówca: **Lileas Graf**
> "“The dam was not necessarily guarded well. No one thought they would be able to hit a power center.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Lileas Graf**
> "“We should be receiving a communication from them soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Lileas Graf**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`

### Węzeł `[164]`
Mówca: **Lileas Graf**
> "“I'm afraid that's not all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[165]`
Mówca: **Lileas Graf**
> "“They are holding him hostage as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[168]`
Mówca: **Narrator**
> "He handed me the file he was holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[169]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[170]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Karl Greiser**
> "“We have just received the demands from the terrorists.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[172]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[169]`
  - -> `[175]`

### Węzeł `[173]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[174]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[175]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[176]`
**[WYBÓR GRACZA: "Read the demands."]** — Mówca: **Player_Italic**
> "I started reading the file."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`

### Węzeł `[177]`
Mówca: **Narrator**
> "'President Rayne. In the name of peace, we have taken hold of the Soll Dam and the Governor of Bergia is our hostage.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[178]`
Mówca: **Lileas Graf**
> "“Karl. I already informed the president of the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Lileas Graf**
> "“Do you have any updates?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[180]`
Mówca: **Narrator**
> "'If our demands are not met, we will cut off electricity to the entirety of the Bergia and Nargis regions along with the governor's head.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[181]`
Mówca: **Narrator**
> "'Yollak Bluderat!'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[182]`
Mówca: **Narrator**
> "'The free people of Bludia have suffered enough under the tyranny of Sordland. Our villages were destroyed, our men and women assaulted, our children killed by our very own government in the name of this dam.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Narrator**
> "'We, the BFF, are with the people. We, the BFF, always defend the downtrodden. We, the BFF, fight for freedom.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Narrator**
> "'We, the BFF, are not like the Sordish government. We know compassion and we believe in a chance of reconciliation between our people.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Narrator**
> "'That's why we are demanding a delegation from the Sordish government to negotiate the price of our freedom. We are ready to sit at the table as equals.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Narrator**
> "'Make no mistake. We also know that true freedom comes at a cost. We will not hesitate to sacrifice as many lives as it takes to achieve our goals.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`

### Węzeł `[187]`
Mówca: **Narrator**
> "'Take this as your final warning.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[188]`
Mówca: **Narrator**
> "I handed the document to Lileas and she read it carefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Lileas Graf**
> "“As I thought.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[190]`
Mówca: **Lileas Graf**
> "“Mr. President, the BFF is a threat against our nation. They must be completely eradicated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[191]`

### Węzeł `[191]`
**[WYBÓR GRACZA: "“No. We need to approach this diplomatically. We will do what they say and send delegates.”"]** — Mówca: **Player**
> "“No. We need to approach this diplomatically. We will do what they say and send delegates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[192]`
**[WYBÓR GRACZA: "“We will not negotiate with terrorists.”"]** — Mówca: **Player**
> "“We will not negotiate with terrorists.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[193]`
Mówca: **Karl Greiser**
> "“As you command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[194]`
Mówca: **Lileas Graf**
> "“What? We can't negotiate with terrorists!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Karl Greiser**
> "“I agree with Ms. Graf, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Karl Greiser**
> "“Please think of the message it would send to other criminal elements in the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "“Now that I think of it, you are right. It might cause more issues down the road.”"]** — Mówca: **Player**
> "“Now that I think of it, you are right. It might cause more issues down the road.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[198]`
**[WYBÓR GRACZA: "“I gave you an order.”"]** — Mówca: **Player**
> "“I gave you an order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Karl Greiser**
> "“As you command, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Lileas Graf**
> "“This is ridiculous!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Lileas Graf**
> "“Our forefathers will be rolling in their graves!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`
  - -> `[204]`

### Węzeł `[202]`
**[WYBÓR GRACZA: "“And where are those forefathers now? Let me guess. They are dead.”"]** — Mówca: **Player**
> "“And where are those forefathers now? Let me guess. They are dead.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[203]`
**[WYBÓR GRACZA: "“Times change, Lileas. This is for the good of the nation.”"]** — Mówca: **Player**
> "“Times change, Lileas. This is for the good of the nation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
**[WYBÓR GRACZA: "“Don't you dare question my orders, Lileas.”"]** — Mówca: **Player**
> "“Don't you dare question my orders, Lileas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Lileas Graf**
> "“We will see about that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Lileas Graf**
> "“Such disrespect!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Lileas Graf**
> "“I am done with this meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[208]`
Mówca: **Lileas Graf**
> "“Come on Karl. We are leaving.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[209]`
Mówca: **Karl Greiser**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Narrator**
> "He followed after her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[211]`
Mówca: **Lileas Graf**
> "“It's good to see that we are taking immediate action.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Lileas Graf**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Lileas Graf**
> "“That's all I had for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[215]`
  - -> `[216]`

### Węzeł `[214]`
**[WYBÓR GRACZA: "“Thank you both.”"]** — Mówca: **Player**
> "“Thank you both.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[215]`
**[WYBÓR GRACZA: "“Do not let anything like this happen again. If you do, heads will roll.”"]** — Mówca: **Player**
> "“Do not let anything like this happen again. If you do, heads will roll.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
**[WYBÓR GRACZA: "“Keep me posted on the updates.”"]** — Mówca: **Player**
> "“Keep me posted on the updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Lileas Graf**
> "“Understood.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[218]`
Mówca: **Lileas Graf**
> "“I shall, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`

### Węzeł `[219]`
Mówca: **Lileas Graf**
> "“Karl. I already informed the president of the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Lileas Graf**
> "“Do you have any updates?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Karl Greiser**
> "“As you know, protests have been organised in major cities like Holsord, Lachaven, Deyr and many more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Karl Greiser**
> "“So called *protesters* organised an attack with KA-74s. 26 policemen died. On the civilian side, there were 13 casualties. Many more were injured, of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[223]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[225]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[226]`
Mówca: **Karl Greiser**
> "“Two people fell off from a truck and that seems to be about it. However, there is potential for these protests to turn violent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[227]`
Mówca: **Lileas Graf**
> "“Do you have any updates?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Karl Greiser**
> "“As you know, protests have been popping up around Sordish cities. They seem to be peaceful. For now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[229]`
Mówca: **Lileas Graf**
> "“Karl. I already informed the president of the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[230]`
Mówca: **Karl Greiser**
> "“Thankfully, the demonstrations have been successfully suppressed for the time being.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[231]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Karl Greiser**
> "“Unfortunately we are having a hard time suppressing the unrest.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[235]`
Mówca: **Karl Greiser**
> "“Unfortunately my men on the ground are being overwhelmed by the protesters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[236]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RiotGear_Buy)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RiotGear_Buy)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RiotGear_Buy"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RiotGear_Buy))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RiotGear_Buy"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Karl Greiser**
> "“The President's wise decision to procure additional riot gear has immensely helped.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[240]`
Mówca: **Karl Greiser**
> "“Although I do believe we would have had an easier time dealing with them if we had additional riot gear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[241]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RiotGear_Buy)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RiotGear_Buy)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RiotGear_Buy"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RiotGear_Buy))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RiotGear_Buy"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Karl Greiser**
> "“The President's decision to procure additional riot gear has helped us, but our units are still outnumbered.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[245]`
Mówca: **Karl Greiser**
> "“This is partly due to the lack of riot gear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[246]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RiotGear_Buy)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_RiotGear_Buy)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RiotGear_Buy"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_RiotGear_Buy))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RiotGear_Buy"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Karl Greiser**
> "“The President's wise decision to procure additional riot gear has immensely helped. But we have been unable to prevent casualties.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[250]`
Mówca: **Karl Greiser**
> "“We are not well-equipped enough to tip the balance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[251]`
Mówca: **Karl Greiser**
> "“Two protesters were killed in retaliation to throwing a firebomb on our units. Aside from that, no injuries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[252]`
Mówca: **Karl Greiser**
> "“Two civilians and two policemen were killed due to a firebomb thrown by the protesters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[253]`
Mówca: **Karl Greiser**
> "“4 policemen and 2 protestors have been killed during the clashes. One of the said *protesters* seem to have had a KA-74.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[254]`
Mówca: **Karl Greiser**
> "“Eight policemen and two protesters have been killed during the clashes. One of the said *protesters* seem to have had a KA-74.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[255]`
Mówca: **Karl Greiser**
> "“So called *protesters* organised an attack with KA-74s. 13 policemen and nine civilians have died. Many were injured.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[256]`
Mówca: **Karl Greiser**
> "“The situation is completely under our control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[257]`
Mówca: **Karl Greiser**
> "“Aside from that small incident, the situation is mostly under our control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[258]`
Mówca: **Karl Greiser**
> "“The situation is escalating.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[259]`
Mówca: **Karl Greiser**
> "“The situation is escalating quickly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[260]`
Mówca: **Karl Greiser**
> "“The situation is dire.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[261]`
Mówca: **Karl Greiser**
> "“The situation is extremely dire, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[262]`
Mówca: **Karl Greiser**
> "“The main rhetoric they all share is that they are demanding the President's resignation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`
  - -> `[350]`
  - -> `[351]`

### Węzeł `[263]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Economy <= 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Economy <= 5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] <= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy <= 5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] <= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[266]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BlackTuesdayHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BlackTuesdayHappened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BlackTuesdayHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[268]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.BlackTuesdayHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BlackTuesdayHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.SuperpowerTradeWarHappened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.SuperpowerTradeWarHappened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SuperpowerTradeWarHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[271]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.SuperpowerTradeWarHappened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SuperpowerTradeWarHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[272]`
Mówca: **Karl Greiser**
> "“The majority of the protests are about the Sordish markets crashing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[273]`
Mówca: **Karl Greiser**
> "“The majority of the protests are about the global trade war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[274]`
Mówca: **Karl Greiser**
> "“The majority of the protests are about the state of the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Narrator**
> "He pulled out a document from the folder he was carrying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[276]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization == 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization == 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"] == 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization == 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"] == 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Karl Greiser**
> "“There are some that are protesting against the state taking over Sordland's largest corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[280]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization == 3 && BaseGame.NedamMiningGroup_Privatization == 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization == 3 && BaseGame.NedamMiningGroup_Privatization == 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] == 3  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization == 3 && BaseGame.NedamMiningGroup_Privatization == 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] == 3  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Karl Greiser**
> "“There are some that are protesting against the full privatization of the Sordish State Corporation and Nedam Mining Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[284]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.NedamMiningGroup_Privatization == 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.NedamMiningGroup_Privatization == 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NedamMiningGroup_Privatization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.NedamMiningGroup_Privatization == 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NedamMiningGroup_Privatization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[287]`
Mówca: **Karl Greiser**
> "“There are some that are protesting against the full privatization of Nedam Mining Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[288]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization == 3 && BaseGame.HeartOfSordland_Nationalization == 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization == 3 && BaseGame.HeartOfSordland_Nationalization == 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] == 3  and  Variable["BaseGame.HeartOfSordland_Nationalization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSteel_Nationalization == 3 && BaseGame.HeartOfSordland_Nationalization == 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] == 3  and  Variable["BaseGame.HeartOfSordland_Nationalization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Karl Greiser**
> "“There are some that are protesting against the full nationalization of Bergia Steel and Heart of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[292]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization == 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.HeartOfSordland_Nationalization == 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.HeartOfSordland_Nationalization == 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[295]`
Mówca: **Karl Greiser**
> "“There are some that are protesting against the full nationalization of Heart of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Justice_Decreased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Justice_Decreased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Justice_Decreased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[298]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Justice_Decreased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Justice_Decreased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[299]`
Mówca: **Karl Greiser**
> "“There are some that are protesting against the full nationalization of Bergia Steel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[300]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization == 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSteel_Nationalization == 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[302]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSteel_Nationalization == 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[303]`
Mówca: **Karl Greiser**
> "“There are some that are protesting against the full privatization of the Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[304]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization == 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.SordishStateCorporation_Privatization == 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[306]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.SordishStateCorporation_Privatization == 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[307]`
Mówca: **Karl Greiser**
> "“Judges and various other civil servants are protesting against backlogs in court matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Karl Greiser**
> "“Teachers are protesting against the decreased education budget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Karl Greiser**
> "“Doctors are protesting against the decreased healthcare budget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Karl Greiser**
> "“The arrest of Frens Ricter has been a large factor in the protests. Members of PFJP and the reformist-leaning populace are at the forefront.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Detained_KesaroKibener == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Detained_KesaroKibener == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[323]`
Mówca: **Karl Greiser**
> "“The arrest of Kesaro Kibener angered many right-leaning citizens.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Karl Greiser**
> "“The arrest of Marcel Koronti has caused an uproar as he was a very public figure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[325]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MarcelKoronti == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MarcelKoronti == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[327]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_MarcelKoronti == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn07_LanguageBill_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Karl Greiser**
> "“The Language Unification Bill led to protests, particularly in the Bergia region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_DontGo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_DontGo == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_DontGo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[334]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_AschrafSupport_DontGo == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_DontGo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[337]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[338]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_Go == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_AschrafSupport_Go == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_Go"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[340]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_AschrafSupport_Go == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_Go"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[341]`
Mówca: **Karl Greiser**
> "“Thanks to the media, we are under fire for not showing support for the Aschraf Anniversary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[342]`
Mówca: **Karl Greiser**
> "“Thanks to the media, we are under fire for the dead protester at the Aschraf Anniversary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Karl Greiser**
> "“Thanks to the media, we are under fire for showing support at the Aschraf Anniversary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[347]`
Mówca: **Karl Greiser**
> "“Protesters are also demonstrating against the joint operation with Wehlen against the Bludish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[348]`
**[WYBÓR GRACZA: "“They dare defy me? Traitors!”"]** — Mówca: **Player**
> "“They dare defy me? Traitors!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[349]`
**[WYBÓR GRACZA: "“If my citizens are unhappy, then we should at least hear what they have to say.”"]** — Mówca: **Player**
> "“If my citizens are unhappy, then we should at least hear what they have to say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[350]`
**[WYBÓR GRACZA: "“Nonsense. If a president resigned whenever someone protested against him, there would be no presidents.”"]** — Mówca: **Player**
> "“Nonsense. If a president resigned whenever someone protested against him, there would be no presidents.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[351]`
**[WYBÓR GRACZA: "“There is freedom of speech in this country. They can say whatever they want.”"]** — Mówca: **Player**
> "“There is freedom of speech in this country. They can say whatever they want.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[352]`
Mówca: **Lileas Graf**
> "“We need to approach this in a calm, controlled manner. Otherwise the pot might boil over.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[353]`
Mówca: **Lileas Graf**
> "“I would refrain from giving them too much agency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[354]`
Mówca: **Lileas Graf**
> "“Well said.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Lileas Graf**
> "“I'm afraid soon they might start doing more than just saying things.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Lileas Graf**
> "“What does the protester profile look like?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[357]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[360]`
Mówca: **Lileas Graf**
> "“Protests against your emergency are erupting all over Sordland. Many anti-communists are among the instigators.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[361]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[364]`
Mówca: **Lileas Graf**
> "“Yes. Despite the emergency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[365]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[367]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[368]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[371]`
Mówca: **Lileas Graf**
> "“Yes. Despite the emergency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[372]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[375]`
Mówca: **Lileas Graf**
> "“Protests against your emergency are erupting all over Sordland. Many anti-capitalists are among the instigators.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[376]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[378]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[379]`
Mówca: **Lileas Graf**
> "“Yes. Despite the emergency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[380]`
Mówca: **Karl Greiser**
> "“We have investigated the various groups involved in the protests and compiled a list of their complaints. I will go through it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[381]`
Mówca: **Karl Greiser**
> "“In addition, there are many provocateurs that are not tied to any specific organization or cause.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[382]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[385]`
Mówca: **Karl Greiser**
> "“Regardless, these protests are happening during an emergency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[386]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[388]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[389]`
Mówca: **Lileas Graf**
> "“That's indeed cause for concern.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[390]`
Mówca: **Lileas Graf**
> "“That's indeed cause for concern.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[391]`
Mówca: **Karl Greiser**
> "“These protests happening during an emergency means they are aiming to destabilise the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[392]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[395]`
Mówca: **Karl Greiser**
> "“We currently have 467 protesters in custody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[396]`
Mówca: **Karl Greiser**
> "“We currently have 27 protesters in custody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[397]`
Mówca: **Karl Greiser**
> "“We currently have 1376 protesters in custody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[398]`
Mówca: **Karl Greiser**
> "“We currently have 137 protesters in custody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[399]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
  - -> `[401]`

### Węzeł `[400]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[401]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[402]`
Mówca: **Karl Greiser**
> "“Related to the protests, we have detained 642 people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[403]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`
  - -> `[405]`

### Węzeł `[404]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[405]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[406]`
Mówca: **Lileas Graf**
> "“That's indeed cause for concern.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[407]`
Mówca: **Karl Greiser**
> "“Staging these protests during a state of emergency... it's almost as if they are trying to trigger a civil war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[408]`
Mówca: **Karl Greiser**
> "“Related to the protests, we have detained 2364 people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[409]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`

### Węzeł `[410]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[411]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[412]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`
  - -> `[414]`

### Węzeł `[413]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[414]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[415]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`
  - -> `[417]`

### Węzeł `[416]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[417]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_SollistRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[418]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_CapitalistRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`
  - -> `[420]`

### Węzeł `[419]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_CapitalistRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[420]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_CapitalistRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[421]`
Mówca: **Karl Greiser**
> "“Among the detainees, we have found NFP and Young Sords members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[422]`
Mówca: **Karl Greiser**
> "“Among the detainees, we have found PFJP, Red Youth and BFF members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[423]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion < 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`
  - -> `[425]`

### Węzeł `[424]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion < 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion < 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[426]`
Mówca: **Karl Greiser**
> "“Among the detainees, we have found NFP, USP, Young Sords and BFF members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[427]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion < 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion < 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[429]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion < 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[430]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion < 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`
  - -> `[432]`

### Węzeł `[431]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion < 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[432]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion < 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Karl Greiser**
> "“Among the detainees, we have found PFJP and Red Youth members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[434]`
Mówca: **Karl Greiser**
> "“Among the detainees, we have found Red Youth members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[435]`
Mówca: **Karl Greiser**
> "“Among the detainees, we have found Red Youth members and BFF members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[436]`
Mówca: **Lileas Graf**
> "“We need to take action, Mr. President. Immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[437]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[439]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion <= -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[440]`
Mówca: **Lileas Graf**
> "“If the protests get even more violent than they already are...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[441]`
Mówca: **Lileas Graf**
> "“We are risking a civil war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[442]`
Mówca: **Lileas Graf**
> "“We need to take action, Mr. President. Immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[443]`
Mówca: **Lileas Graf**
> "“The protesters may be peaceful now, but any spark of violence might snowball into something I don't even want to think about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[444]`
Mówca: **Karl Greiser**
> "“Your orders, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`
  - -> `[467]`
  - -> `[465]`
  - -> `[466]`

### Węzeł `[445]`
Mówca: **Karl Greiser**
> "“Your orders, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`
  - -> `[585]`
  - -> `[582]`

### Węzeł `[446]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`
  - -> `[448]`

### Węzeł `[447]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[448]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[449]`
Mówca: **Karl Greiser**
> "“I would like to remind you that some of these groups are banned by decree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[450]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`
  - -> `[452]`

### Węzeł `[451]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[452]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[453]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`
  - -> `[455]`

### Węzeł `[454]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[455]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[456]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`
  - -> `[458]`

### Węzeł `[457]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[458]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[459]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`
  - -> `[461]`

### Węzeł `[460]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[461]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[462]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`
  - -> `[464]`

### Węzeł `[463]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[464]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[465]`
**[WYBÓR GRACZA: "“I won't risk civil war. Do whatever it takes to stop the protests. Use force if necessary.”"]** — Mówca: **Player**
> "“I won't risk civil war. Do whatever it takes to stop the protests. Use force if necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[466]`
**[WYBÓR GRACZA: "“Catch the ringleaders and sabotage their plans.”"]** — Mówca: **Player**
> "“Catch the ringleaders and sabotage their plans.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[467]`
**[WYBÓR GRACZA: "“I can't fight against my own people. Set up a meeting with their spokesperson, I'll listen to their demands.”"]** — Mówca: **Player**
> "“I can't fight against my own people. Set up a meeting with their spokesperson, I'll listen to their demands.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[468]`
**[WYBÓR GRACZA: "“They are peaceful. You said it yourself. I will speak with them and listen to their demands.”"]** — Mówca: **Player**
> "“They are peaceful. You said it yourself. I will speak with them and listen to their demands.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[469]`
Mówca: **Karl Greiser**
> "“I will keep you updated on the results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[470]`
Mówca: **Karl Greiser**
> "“As you command, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[471]`
Mówca: **Lileas Graf**
> "“I can't say I condone this. The people must respect the laws of this land. What you are doing right now is giving in to anarchists.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[472]`
Mówca: **Lileas Graf**
> "“Good call. We need to end this farce once and for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[473]`
Mówca: **Lileas Graf**
> "“Keep me in the loop as well. We need to end this farce once and for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[474]`
Mówca: **Karl Greiser**
> "“Of course, Ms. Graf.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[475]`
Mówca: **Karl Greiser**
> "“As you command, Mr. President. We will try to reach out to their spokesperson.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[476]`
Mówca: **Lileas Graf**
> "“I think you are playing with fire, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[477]`
Mówca: **Lileas Graf**
> "“Let's hope you don't burn yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[478]`
Mówca: **Lileas Graf**
> "“Come on, Karl. We are leaving.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[479]`
Mówca: **Karl Greiser**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[480]`
Mówca: **Lileas Graf**
> "“If you will excuse us, Mr. President, we have work to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`
  - -> `[482]`
  - -> `[483]`

### Węzeł `[481]`
**[WYBÓR GRACZA: "“Good luck.”"]** — Mówca: **Player**
> "“Good luck.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[482]`
**[WYBÓR GRACZA: "“Dismissed.”"]** — Mówca: **Player**
> "“Dismissed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[483]`
**[WYBÓR GRACZA: "“I expect results.”"]** — Mówca: **Player**
> "“I expect results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[484]`
Mówca: **Lileas Graf**
> "“Of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[485]`
Mówca: **Lileas Graf**
> "“I believe you will need more luck than we do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[486]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_A_UnrestMeeting = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_A_UnrestMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`

### Węzeł `[487]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`
  - -> `[489]`

### Węzeł `[488]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[489]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion <= -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[490]`
Mówca: **Narrator**
> "The report was titled 'Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[491]`
Mówca: **Lileas Graf**
> "“Protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[492]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[493]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[494]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`
  - -> `[496]`
  - -> `[495]`

### Węzeł `[495]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[496]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[497]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[498]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`
  - -> `[500]`

### Węzeł `[499]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[500]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[501]`
**[WYBÓR GRACZA: "“We will need to handle these protests.”"]** — Mówca: **Player**
> "“We will need to handle these protests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[502]`
Mówca: **Lileas Graf**
> "“What is unexpected, however, is the sheer size of the protests and the level of violence. Several people have been killed already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[503]`
Mówca: **Lileas Graf**
> "“I can't say this is unexpected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[504]`
Mówca: **Lileas Graf**
> "“We are on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[505]`
Mówca: **Lileas Graf**
> "“Sordland hasn't seen this much unrest since the death of Bernard Circas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`
  - -> `[501]`
  - -> `[511]`

### Węzeł `[506]`
Mówca: **Lileas Graf**
> "“They are protesting you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[507]`
Mówca: **Lileas Graf**
> "“Yes, and it's our duty to keep that cost as low as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[508]`
Mówca: **Lileas Graf**
> "“They are asking for your resignation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[509]`
**[WYBÓR GRACZA: "“Enough. We can't let the tensions rise to those levels again.”"]** — Mówca: **Player**
> "“Enough. We can't let the tensions rise to those levels again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[510]`
Mówca: **Lileas Graf**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[511]`
**[WYBÓR GRACZA: "“Change doesn't come easy. There is always a cost.”"]** — Mówca: **Player**
> "“Change doesn't come easy. There is always a cost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[512]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[513]`
Mówca: **Lileas Graf**
> "“Protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[514]`
Mówca: **Narrator**
> "The report was titled 'Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[515]`
Mówca: **Lileas Graf**
> "“They are asking for your resignation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[516]`
Mówca: **Lileas Graf**
> "“They are protesting you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[517]`
Mówca: **Lileas Graf**
> "“I can't say this is unexpected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[524]`
  - -> `[525]`

### Węzeł `[518]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[519]`
Mówca: **Lileas Graf**
> "“Yes. Despite the emergency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[520]`
Mówca: **Lileas Graf**
> "“Yes, and we have a duty to keep that cost as low as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[521]`
Mówca: **Lileas Graf**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[522]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[523]`
Mówca: **Lileas Graf**
> "“No, you didn't. Yet here we are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[524]`
**[WYBÓR GRACZA: "“We will need to handle these protests.”"]** — Mówca: **Player**
> "“We will need to handle these protests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[525]`
**[WYBÓR GRACZA: "“Change doesn't come easy. There is always a cost.”"]** — Mówca: **Player**
> "“Change doesn't come easy. There is always a cost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[526]`
**[WYBÓR GRACZA: "“I didn't ask you for your opinion.”"]** — Mówca: **Player**
> "“I didn't ask you for your opinion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[527]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[528]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[529]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`
  - -> `[533]`
  - -> `[527]`

### Węzeł `[530]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`
  - -> `[532]`

### Węzeł `[531]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[532]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[533]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[534]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[535]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened = true;
BaseGame.Economy -= 2;
BaseGame.Economy_Bergia = 0;
BaseGame.LateGameCrisis += 1;
BaseGame.Situation_Order_BludishUprising = true;
BaseGame.Situation_Order_BFF_ThreatContinues = false;
BaseGame.Situation_Order_BFF_ThreatAlarming = true;
BaseGame.Situation_Order_BFF_ThreatEliminated = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Unrest_BFF_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.Economy_Bergia"] = 0;
Variable["BaseGame.LateGameCrisis"] = Variable["BaseGame.LateGameCrisis"] + 1;
Variable["BaseGame.Situation_Order_BludishUprising"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatContinues"] = false;
Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[536]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened = true;
BaseGame.Economy -= 1;
BaseGame.Situation_Order_Nationwide_Protests = true;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Revolt = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[537]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened = true;
BaseGame.Economy -= 1;
BaseGame.Situation_Order_Nationwide_Protests = true;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Revolt = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[538]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened = true;
BaseGame.Economy -= 1;
BaseGame.Situation_Order_Nationwide_Protests = true;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Revolt = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[539]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened = true;
BaseGame.Economy -= 1;
BaseGame.Situation_Order_Nationwide_Protests = true;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Revolt = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[540]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened = true;
BaseGame.Economy -= 2;
BaseGame.LateGameCrisis += 1;
BaseGame.Situation_Order_Nationwide_Revolt = true;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Protests = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Unrest_Violent_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.LateGameCrisis"] = Variable["BaseGame.LateGameCrisis"] + 1;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[541]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened = true;
BaseGame.Economy -= 2;
BaseGame.LateGameCrisis += 1;
BaseGame.Situation_Order_Nationwide_Revolt = true;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Protests = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Unrest_Violent_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.LateGameCrisis"] = Variable["BaseGame.LateGameCrisis"] + 1;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[542]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened = true;
BaseGame.Economy -= 2;
BaseGame.LateGameCrisis += 1;
BaseGame.Situation_Order_Nationwide_Revolt = true;
BaseGame.Situation_Order_Nationwide_Protests = false;
BaseGame.Situation_Order_Nationwide_Quelled = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Unrest_Violent_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.LateGameCrisis"] = Variable["BaseGame.LateGameCrisis"] + 1;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[543]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened = true;
BaseGame.Economy -= 2;
BaseGame.LateGameCrisis += 1;
BaseGame.Situation_Order_Nationwide_Revolt = true;
BaseGame.Situation_Order_Nationwide_Protests = false;
BaseGame.Situation_Order_Nationwide_Quelled = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Unrest_Violent_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.LateGameCrisis"] = Variable["BaseGame.LateGameCrisis"] + 1;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[544]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Diplomatic = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Security_Unrest_Diplomatic"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[545]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Police = true;
BaseGame.Bludish_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Security_Unrest_Police"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[546]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`
  - -> `[548]`

### Węzeł `[547]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[548]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[549]`
Mówca: **Lileas Graf**
> "“What? You cannot use the Sordish Armed Forces inside our borders. That is against the constitution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`
  - -> `[554]`
  - -> `[555]`

### Węzeł `[550]`
**[WYBÓR GRACZA: "“We are in a state of emergency, Lileas. I will use my powers to give them authorization.""]** — Mówca: **Player**
> "“We are in a state of emergency, Lileas. I will use my powers to give them authorization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[551]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`
  - -> `[553]`

### Węzeł `[552]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[553]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[554]`
**[WYBÓR GRACZA: "“I will sign a presidential decree, giving them authorization to act inside our borders.""]** — Mówca: **Player**
> "“I will sign a presidential decree, giving them authorization to act inside our borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[555]`
**[WYBÓR GRACZA: "“Watch me.""]** — Mówca: **Player**
> "“Watch me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[556]`
Mówca: **Karl Greiser**
> "“Sir, you cannot simply authorize the army to work within our borders. This is under the jurisdiction of the police force.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`
  - -> `[558]`

### Węzeł `[557]`
**[WYBÓR GRACZA: ""Don't you dare question my decision.""]** — Mówca: **Player**
> ""Don't you dare question my decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[558]`
**[WYBÓR GRACZA: ""I will call Iosef immediately.""]** — Mówca: **Player**
> ""I will call Iosef immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[559]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military = true;
BaseGame.Bludish_Opinion -= 5;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Security_Unrest_Military"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 5;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[560]`
**[WYBÓR GRACZA: "“I will involve the military. This has gotten out of hand.”"]** — Mówca: **Player**
> "“I will involve the military. This has gotten out of hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[561]`
Mówca: **Lileas Graf**
> "“What? You cannot use the Sordish Armed Forces inside our borders. That is against the constitution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`
  - -> `[567]`
  - -> `[574]`

### Węzeł `[562]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`
  - -> `[564]`

### Węzeł `[563]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[564]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[565]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Security_Unrest_Military"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[566]`
Mówca: **Karl Greiser**
> "“Sir, you cannot simply authorize the army to work within our borders. This is under the jurisdiction of the police force.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`
  - -> `[573]`

### Węzeł `[567]`
**[WYBÓR GRACZA: "“I will sign a presidential decree, giving them authorization to act inside our borders.""]** — Mówca: **Player**
> "“I will sign a presidential decree, giving them authorization to act inside our borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[568]`
**[WYBÓR GRACZA: "“We are in a state of emergency, Lileas. I will use my powers to give them authorization.""]** — Mówca: **Player**
> "“We are in a state of emergency, Lileas. I will use my powers to give them authorization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[569]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`
  - -> `[571]`

### Węzeł `[570]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[571]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[572]`
**[WYBÓR GRACZA: ""Don't you dare question my decision.""]** — Mówca: **Player**
> ""Don't you dare question my decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[573]`
**[WYBÓR GRACZA: ""I will call Iosef immediately.""]** — Mówca: **Player**
> ""I will call Iosef immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[574]`
**[WYBÓR GRACZA: "“Watch me.""]** — Mówca: **Player**
> "“Watch me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[575]`
Mówca: **Lileas Graf**
> "“Fine. Come on Karl. We are leaving.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[576]`
Mówca: **Karl Greiser**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[577]`
Mówca: **Narrator**
> "Lileas left the room in a huff. Karl bowed to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[578]`
Mówca: **Narrator**
> "He followed after her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[579]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Police = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Security_Unrest_Police"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[580]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Diplomatic = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Security_Unrest_Diplomatic"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[581]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Diplomatic = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Security_Unrest_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[582]`
**[WYBÓR GRACZA: "“Catch the ringleaders and sabotage their plans.”"]** — Mówca: **Player**
> "“Catch the ringleaders and sabotage their plans.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`

### Węzeł `[583]`
Mówca: **Karl Greiser**
> "“Yes, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[584]`
Mówca: **Karl Greiser**
> "“I will keep you updated on the results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[585]`
**[WYBÓR GRACZA: "“I won't risk civil war. Do whatever it takes to stop the protests. Use force if necessary.”"]** — Mówca: **Player**
> "“I won't risk civil war. Do whatever it takes to stop the protests. Use force if necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[586]`
Mówca: **Lileas Graf**
> "“Good call. We need to end this farce once and for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[587]`
Mówca: **Karl Greiser**
> "“Of course, Ms. Graf.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[588]`
Mówca: **Karl Greiser**
> "“As you command, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[589]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Police = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Security_Unrest_Police"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[590]`
Mówca: **Lileas Graf**
> "“Keep me in the loop as well. We need to end this farce once and for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[591]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_Unrest_Police = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Police"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[592]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_Unrest_Military = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Military"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[593]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_Unrest_Diplomatic = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[594]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_Unrest_Diplomatic = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[595]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_Unrest_Diplomatic = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[596]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_Unrest_Police = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Police"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[597]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_Unrest_Police = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Police"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[598]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_Unrest_Military = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Military"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[599]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`
  - -> `[601]`

### Węzeł `[600]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[601]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Security_Unrest_Military == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[602]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Police == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[604]`

### Węzeł `[603]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Police == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Police"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[604]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Security_Unrest_Police == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Police"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[605]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`
  - -> `[607]`

### Węzeł `[606]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[607]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[608]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`
  - -> `[610]`

### Węzeł `[609]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[610]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[611]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`
  - -> `[613]`

### Węzeł `[612]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[613]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]`

### Węzeł `[614]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`
  - -> `[616]`

### Węzeł `[615]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[616]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[617]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[618]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 4)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[619]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 6;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 6;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]`

### Węzeł `[620]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[621]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[622]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[623]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Democratic -= 5;
BaseGame.Sollist += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 5;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`

### Węzeł `[624]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Democratic -= 1;
BaseGame.Sollist += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`

### Węzeł `[625]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[626]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Democratic += 2;
BaseGame.Sollist -= 5;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`

### Węzeł `[627]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[628]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression = true;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishReconciliation = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = true;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[629]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`
  - -> `[631]`

### Węzeł `[630]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`

### Węzeł `[631]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[632]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`
  - -> `[634]`

### Węzeł `[633]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[634]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`

### Węzeł `[635]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`
  - -> `[637]`

### Węzeł `[636]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[637]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[638]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`
  - -> `[640]`

### Węzeł `[639]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_SollistRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[640]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_SollistRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[641]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_CapitalistRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`
  - -> `[643]`

### Węzeł `[642]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_CapitalistRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[643]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_CapitalistRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[644]`
Mówca: **Lileas Graf**
> "“Anti-communism protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[645]`
Mówca: **Lileas Graf**
> "“Protests against your emergency have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[646]`
Mówca: **Lileas Graf**
> "“Protests against your emergency have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[647]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[648]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`
  - -> `[650]`

### Węzeł `[649]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_Violent_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`

### Węzeł `[650]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_Violent_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_Violent_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[651]`
Mówca: **Lileas Graf**
> "“People have died, Mr. Rayne. Freedom of speech no longer applies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[652]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[653]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[654]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[655]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[656]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[657]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[658]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[659]`
Mówca: **Narrator**
> "He followed after her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[660]`
Mówca: **Narrator**
> "Lileas hurriedly left the room. Karl bowed to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[661]`
Mówca: **Narrator**
> "Lileas hurriedly left the room. Karl bowed to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[662]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`
  - -> `[664]`

### Węzeł `[663]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[664]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Increased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[665]`
Mówca: **Karl Greiser**
> "“As you command, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[666]`
Mówca: **Karl Greiser**
> "“Yes, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[667]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`
  - -> `[669]`

### Węzeł `[668]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[669]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Increased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[670]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`
  - -> `[672]`

### Węzeł `[671]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`

### Węzeł `[672]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Increased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[673]`
Mówca: **Karl Greiser**
> "“Yes, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[674]`
Mówca: **Karl Greiser**
> "“As you command, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[675]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`
  - -> `[677]`

### Węzeł `[676]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[677]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Increased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[678]`
Mówca: **Karl Greiser**
> "“As you command, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[679]`
Mówca: **Karl Greiser**
> "“Yes, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[680]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`
  - -> `[682]`

### Węzeł `[681]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_Violent_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[682]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_Violent_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_Violent_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[683]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`
  - -> `[685]`

### Węzeł `[684]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Peaceful_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[685]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_Peaceful_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`

### Węzeł `[686]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Democratic -= 5;
BaseGame.Sollist += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 5;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[687]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Sollist += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[688]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`
  - -> `[690]`

### Węzeł `[689]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_Violent_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_Violent_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]`

### Węzeł `[690]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_Violent_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_Violent_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[691]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Democratic -= 3;
BaseGame.Sollist += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 3;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[692]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`
  - -> `[694]`

### Węzeł `[693]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Unrest_BFF_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[694]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Unrest_BFF_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[695]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Democratic += 2;
BaseGame.Sollist -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[696]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`
  - -> `[698]`

### Węzeł `[697]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`

### Węzeł `[698]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Increased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[699]`
Mówca: **Karl Greiser**
> "“As you command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[700]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`
  - -> `[702]`

### Węzeł `[701]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]`

### Węzeł `[702]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[703]`
Mówca: **Lileas Graf**
> "“What? You cannot use the Sordish Armed Forces inside our borders. That is against the constitution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`
  - -> `[554]`
  - -> `[555]`

### Węzeł `[704]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`
  - -> `[706]`

### Węzeł `[705]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`

### Węzeł `[706]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]`

### Węzeł `[707]`
Mówca: **Lileas Graf**
> "“With a simultaneous attack, the Bludish terrorists have raided the governor's office in Deyr and kidnapped Governor Bron.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[708]`
Mówca: **Lileas Graf**
> "“With a simultaneous attack, the Bludish terrorists have raided the governor's office in Deyr and kidnapped Governor Krull.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[709]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`
  - -> `[711]`

### Węzeł `[710]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[711]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[712]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`
  - -> `[714]`

### Węzeł `[713]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[714]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[715]`
Mówca: **Narrator**
> "'President Rayne. In the name of peace, we have taken hold of the Soll Dam.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[716]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`
  - -> `[718]`

### Węzeł `[717]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[718]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`

### Węzeł `[719]`
Mówca: **Narrator**
> "'If our demands are not met, we will cut off electricity to the entirety of the Bergia and Nargis regions.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[720]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BFF_EliminationOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`
  - -> `[722]`

### Węzeł `[721]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BFF_EliminationOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[722]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.BFF_EliminationOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[723]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`
  - -> `[725]`

### Węzeł `[724]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[725]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[726]`
Mówca: **Lileas Graf**
> "“Mr. President, the BFF is a threat against our nation. We had the chance to eradicate their leadership but not taking that chance resulted in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[727]`
Mówca: **Lileas Graf**
> ""We have to destroy them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[191]`

### Węzeł `[728]`
Mówca: **Lileas Graf**
> "“Mr. President, the BFF is a threat against our nation. Our failure in eliminating their leadership must have emboldened them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[729]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[730]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[731]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_BFF_ThreatEliminated == false || BaseGame.Policy_Law_SpecialZoneOfBergia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`
  - -> `[733]`

### Węzeł `[732]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_BFF_ThreatEliminated == false || BaseGame.Policy_Law_SpecialZoneOfBergia == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] == false  or  Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[733]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Order_BFF_ThreatEliminated == false || BaseGame.Policy_Law_SpecialZoneOfBergia == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] == false  or  Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
