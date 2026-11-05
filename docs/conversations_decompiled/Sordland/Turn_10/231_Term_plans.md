# Sordland/Turn10/Term plans

- **ID konwersacji:** `231`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/231_Term_plans.md`
- **Liczba węzłów dialogowych:** 356
- **Liczba wyborów gracza:** 31

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
- `BaseGame.Archetype_DemocraticRayne`
- `BaseGame.Arrest_FetihEjall`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed`
- `BaseGame.Bill_Turn07_LanguageBill_Vetoed`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn10_Term2Focus_Education`
- `BaseGame.Decision_Turn10_Term2Focus_Military`
- `BaseGame.Decision_Turn10_Term2Focus_Security`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Law_Decree_Removed`
- `BaseGame.Policy_Law_Decree_Stronger`
- `BaseGame.Policy_Law_Decree_Weaker`
- `BaseGame.Policy_Law_Honorary_Abolished`
- `BaseGame.Policy_Law_Impeachment_Removed`
- `BaseGame.Policy_Law_TermLimits_2`
- `BaseGame.Policy_Law_Threshold_15`
- `BaseGame.Policy_Law_Threshold_3`
- `BaseGame.Policy_Law_Threshold_8`
- `BaseGame.Policy_Law_Veto_Loophole`
- `BaseGame.Policy_Welfare_EvolutionNotMandatory`
- `BaseGame.Reform_Alliance_PFJP`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Rumburg_PeaceSummit`
- `BaseGame.Security_Unrest_Police`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Situation_Law_ExcellentWomenRights`
- `BaseGame.Situation_Military_DecayingCombatReadiness`
- `BaseGame.Situation_Military_GreenGenerals`
- `BaseGame.Situation_Military_LackOfEquipment`
- `BaseGame.Situation_Military_OutdatedMilitaryEquipment`
- `BaseGame.Situation_Order_Nationwide_Protests`
- `BaseGame.Situation_Order_Nationwide_Revolt`
- `BaseGame.Situation_Welfare_EpidemicSpreads`
- `BaseGame.Situation_Welfare_FailedEducationReform`
- `BaseGame.Situation_Welfare_GenderEqualityInEducation`
- `BaseGame.Situation_Welfare_HealthCrisis`
- `BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors`
- `BaseGame.Turn03_EnT_Education_Budget_Decrease`
- `BaseGame.Turn03_EnT_Education_Budget_Maintain`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Maintain`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Maintain`
- `BaseGame.Turn04_PSnW_Education_Privatization`
- `BaseGame.Turn07_SecretState_Kill_FrensRicter`
- `BaseGame.Unrest_BFF_Deal_Promised`
- `BaseGame.Unrest_BFF_Deal_Signed`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGame.Unrest_Peaceful_Happened`
- `BaseGame.Unrest_Violent_Happened`
- `BaseGameIsolated.Debate_Enable_FrensRicter`
- `BaseGameIsolated.Debate_Enable_KesaroKibener`
- `BaseGameIsolated.Debate_Enable_LileasGraf`
- `BaseGameIsolated.Debate_Enable_ManolySuheil`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn10_Debate_SmallPartiesSilenced`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[232] Sordland/Turn10/Grander Plans** (../Turn_10/232_Grander_Plans.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""You already know what I'm going to say.""** | `[3]` **Moderator**: ""President Rayne has already out..." | `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true` | *Brak zmian stanu* | `[27]` **Frens Ricter**: ""Sordland has been denied change..."<br>`[28]` **Frens Ricter**: ""President Rayne has pointed us ..."<br>*(oraz 1 innych odgałęzień)* |
| `[12]` | **""I don't need to. My decision speaks for itself.""** | `[26]` **Moderator**: ""You've already pledged to make ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Frens Ricter**: ""You had a chance to reform Sord..."<br>`[255]` **Manoly Suheil**: ""You had a chance to reform Sord..."<br>*(oraz 4 innych odgałęzień)* |
| `[22]` | **""You already know what I'm going to say.""** | `[3]` **Moderator**: ""President Rayne has already out..." | `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`<br>`(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false` | *Brak zmian stanu* | `[38]` **Manoly Suheil**: ""Sordland has been denied change..."<br>`[39]` **Manoly Suheil**: ""President Rayne has pointed us ..."<br>*(oraz 1 innych odgałęzień)* |
| `[27]` | **""Sordland has been denied change for too long, and President Rayne's promised refo..."** | `[4]` **Frens Ricter**: ""You already know what I'm going..." | `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true` | *Brak zmian stanu* | `[109]` **Frens Ricter**: ""The moment I take office, I wil..."<br>`[110]` **Frens Ricter**: ""My constitutional reforms will ..." |
| `[28]` | **""President Rayne has pointed us in the right direction, but only the PFJP can tran..."** | `[4]` **Frens Ricter**: ""You already know what I'm going..." | `Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true  or  Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true  or  Variable["BaseGame.Policy_Law_TermLimits_2"] == true  or  Variable["BaseGame.Policy_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Archetype_DemocraticRayne"] == true`<br>`(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true) == false` | *Brak zmian stanu* | `[99]` **Frens Ricter**: ""Governing together, our parties..."<br>`[278]` **Frens Ricter**: ""I will use his new reforms as a..."<br>*(oraz 2 innych odgałęzień)* |
| `[30]` | **""President Rayne's sham 'emergency' has made it abundantly clear how much Sordland..."** | `[4]` **Frens Ricter**: ""You already know what I'm going..." | `Variable["BaseGame.Reform_Autocrat_Path"] == true`<br>`(Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true  or  Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true  or  Variable["BaseGame.Policy_Law_TermLimits_2"] == true  or  Variable["BaseGame.Policy_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Archetype_DemocraticRayne"] == true) == false`<br>`(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true) == false` | *Brak zmian stanu* | `[283]` **Frens Ricter**: ""The moment I take office, I wil..." |
| `[34]` | **""President Rayne's sham 'emergency' has made it abundantly clear how much Sordland..."** | `[22]` **Manoly Suheil**: ""You already know what I'm going..." | `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`<br>`(Variable["BaseGame.Reform_Dictator_Path"] == true) == false` | *Brak zmian stanu* | `[42]` **Manoly Suheil**: ""My very presence at this debate..." |
| `[38]` | **""Sordland has been denied change for too long, and President Rayne's promised refo..."** | `[22]` **Manoly Suheil**: ""You already know what I'm going..." | `Variable["BaseGame.Reform_Dictator_Path"] == true` | *Brak zmian stanu* | `[42]` **Manoly Suheil**: ""My very presence at this debate..." |
| `[39]` | **""President Rayne has pointed us in the right direction, but only the PFJP can tran..."** | `[22]` **Manoly Suheil**: ""You already know what I'm going..." | `Variable["BaseGame.Reform_Reformist_Path"] == true`<br>`(Variable["BaseGame.Reform_Dictator_Path"] == true) == false` | *Brak zmian stanu* | `[42]` **Manoly Suheil**: ""My very presence at this debate..." |
| `[41]` | **""Recent events have shown just how unprepared our military is in the face of a pot..."** | `[100]` **Moderator**: ""You've already pledged to make ..." | `Variable["BaseGame.Situation_Military_OutdatedMilitaryEquipment"] == true  or  Variable["BaseGame.Situation_Military_DecayingCombatReadiness"] == true  or  Variable["BaseGame.Situation_Military_GreenGenerals"] == true  or  Variable["BaseGame.Situation_Military_LackOfEquipment"] == true` | *Brak zmian stanu* | `[193]` **Kesaro Kibener**: ""Don't pretend to be a proud mil..."<br>`[200]` **Frens Ricter**: ""That money would be better spen..."<br>*(oraz 3 innych odgałęzień)* |
| `[42]` | **""My very presence at this debate is proof of the lengths this man will go to cling..."** | `[34]` **Manoly Suheil**: ""President Rayne's sham 'emergen..."<br>`[38]` **Manoly Suheil**: ""Sordland has been denied change..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Player_Italic**: "I clenched my jaw and stayed sil..."<br>`[59]` **Player**: ""What are you insinuating? Ricte..."<br>*(oraz 1 innych odgałęzień)* |
| `[59]` | **""What are you insinuating? Ricter's death had nothing to do with me.""** | `[42]` **Manoly Suheil**: ""My very presence at this debate..." | `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true` | *Brak zmian stanu* | `[78]` **Moderator**: ""Ms. Suheil, the circumstances o..."<br>`[75]` **Moderator**: ""Please let the other candidates..." |
| `[61]` | **""Ricter was an enemy of the state. He had to be dealt with.""** | `[42]` **Manoly Suheil**: ""My very presence at this debate..." | `(Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false` | *Brak zmian stanu* | `[79]` **Moderator**: ""Ms. Suheil, the circumstances o..."<br>`[75]` **Moderator**: ""Please let the other candidates..." |
| `[63]` | **"Don't interrupt."** | `[42]` **Manoly Suheil**: ""My very presence at this debate..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Narrator**: "Kesaro cleared his throat."<br>`[52]` **Narrator**: "Remus raised his fist."<br>*(oraz 2 innych odgałęzień)* |
| `[64]` | **""We were lucky enough to stop the recent polio outbreak, but we must be prepared i..."** | `[143]` **Moderator**: ""You've already pledged to make ..." | `(Variable["BaseGame.Situation_Welfare_EpidemicSpreads"] == true) == false` | *Brak zmian stanu* | `[68]` **Lileas Graf**: ""The outbreak would have ended o..."<br>`[173]` **Kesaro Kibener**: ""The outbreak happened because o..."<br>*(oraz 1 innych odgałęzień)* |
| `[114]` | **""Polio is continuing to ravage our country. Ending the epidemic is of the utmost i..."** | `[143]` **Moderator**: ""You've already pledged to make ..." | `Variable["BaseGame.Situation_Welfare_EpidemicSpreads"] == true` | *Brak zmian stanu* | `[76]` **Frens Ricter**: ""If you truly believed that, you..."<br>`[62]` **Manoly Suheil**: ""If you truly believed that, you..."<br>*(oraz 1 innych odgałęzień)* |
| `[115]` | **""Recent events have shown how important it is for the government to keep a handle ..."** | `[134]` **Moderator**: ""You've already pledged to make ..." | `Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true` | *Brak zmian stanu* | `[186]` **Lileas Graf**: ""I watched this man turn Sordlan..."<br>`[187]` **Lileas Graf**: ""Everything this man knows about..."<br>*(oraz 4 innych odgałęzień)* |
| `[116]` | **""A strong military is the backbone of Sordland. It's as simple as that.""** | `[100]` **Moderator**: ""You've already pledged to make ..." | `(Variable["BaseGame.Situation_Military_OutdatedMilitaryEquipment"] == true  or  Variable["BaseGame.Situation_Military_DecayingCombatReadiness"] == true  or  Variable["BaseGame.Situation_Military_GreenGenerals"] == true  or  Variable["BaseGame.Situation_Military_LackOfEquipment"] == true) == false` | *Brak zmian stanu* | `[193]` **Kesaro Kibener**: ""Don't pretend to be a proud mil..."<br>`[200]` **Frens Ricter**: ""That money would be better spen..."<br>*(oraz 3 innych odgałęzień)* |
| `[118]` | **""Without an educated populace, Sordland is doomed to be stuck in the past. It's as..."** | `[26]` **Moderator**: ""You've already pledged to make ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Frens Ricter**: ""You had a chance to reform Sord..."<br>`[255]` **Manoly Suheil**: ""You had a chance to reform Sord..."<br>*(oraz 4 innych odgałęzień)* |
| `[121]` | **""Devoting more resources towards education already paid enormous dividends during ..."** | `[26]` **Moderator**: ""You've already pledged to make ..." | `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true) == false` | *Brak zmian stanu* | `[251]` **Frens Ricter**: ""You had a chance to reform Sord..."<br>`[255]` **Manoly Suheil**: ""You had a chance to reform Sord..."<br>*(oraz 4 innych odgałęzień)* |
| `[122]` | **""Budget constraints during my first term meant Sordland's education system went un..."** | `[26]` **Moderator**: ""You've already pledged to make ..." | `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true` | *Brak zmian stanu* | `[251]` **Frens Ricter**: ""You had a chance to reform Sord..."<br>`[255]` **Manoly Suheil**: ""You had a chance to reform Sord..."<br>*(oraz 4 innych odgałęzień)* |
| `[124]` | **""Enough! This is a debate, not a platform for your racist hate-mongering.""** | `[138]` **Remus Holstron**: ""Good. One less terrorist on the..."<br>`[165]` **Kesaro Kibener**: ""What happened to Fetih is a sha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Narrator**: "Mansoun nodded appreciatively an..." |
| `[137]` | **"Don't interrupt."** | `[138]` **Remus Holstron**: ""Good. One less terrorist on the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "His face calm, he turned directl..." |
| `[158]` | **""Mansoun, don't speak out of turn.""** | `[138]` **Remus Holstron**: ""Good. One less terrorist on the..."<br>`[165]` **Kesaro Kibener**: ""What happened to Fetih is a sha..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn10_Debate_SmallPartiesSile...` | `[117]` **Narrator**: "Mansoun glared at me and turned ..." |
| `[169]` | **""Sordland needs a president who is tough on crime. It's as simple as that.""** | `[134]` **Moderator**: ""You've already pledged to make ..." | `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true) == false` | *Brak zmian stanu* | `[186]` **Lileas Graf**: ""I watched this man turn Sordlan..."<br>`[187]` **Lileas Graf**: ""Everything this man knows about..."<br>*(oraz 4 innych odgałęzień)* |
| `[179]` | **""Budget constraints during my first term meant I couldn't devote as many resources..."** | `[143]` **Moderator**: ""You've already pledged to make ..." | `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Maintain"] == true` | *Brak zmian stanu* | `[244]` **Moderator**: ""Moving on....""<br>`[208]` **Frens Ricter**: ""You allowed Sordland to descend..."<br>*(oraz 2 innych odgałęzień)* |
| `[180]` | **""Devoting more resources towards health care already paid enormous dividends durin..."** | `[143]` **Moderator**: ""You've already pledged to make ..." | `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Maintain"] == true) == false` | *Brak zmian stanu* | `[244]` **Moderator**: ""Moving on....""<br>`[208]` **Frens Ricter**: ""You allowed Sordland to descend..."<br>*(oraz 2 innych odgałęzień)* |
| `[181]` | **""Budget constraints during my first term meant I couldn't devote enough resources ..."** | `[134]` **Moderator**: ""You've already pledged to make ..." | `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true` | *Brak zmian stanu* | `[186]` **Lileas Graf**: ""I watched this man turn Sordlan..."<br>`[187]` **Lileas Graf**: ""Everything this man knows about..."<br>*(oraz 4 innych odgałęzień)* |
| `[182]` | **""Devoting more resources towards law enforcement already paid enormous dividends d..."** | `[134]` **Moderator**: ""You've already pledged to make ..." | `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true) == false` | *Brak zmian stanu* | `[186]` **Lileas Graf**: ""I watched this man turn Sordlan..."<br>`[187]` **Lileas Graf**: ""Everything this man knows about..."<br>*(oraz 4 innych odgałęzień)* |
| `[188]` | **""Budget constraints during my first term meant the military went underfunded. I re..."** | `[100]` **Moderator**: ""You've already pledged to make ..." | `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true` | *Brak zmian stanu* | `[193]` **Kesaro Kibener**: ""Don't pretend to be a proud mil..."<br>`[200]` **Frens Ricter**: ""That money would be better spen..."<br>*(oraz 3 innych odgałęzień)* |
| `[189]` | **""Devoting more resources towards the military already paid enormous dividends duri..."** | `[100]` **Moderator**: ""You've already pledged to make ..." | `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true) == false` | *Brak zmian stanu* | `[193]` **Kesaro Kibener**: ""Don't pretend to be a proud mil..."<br>`[200]` **Frens Ricter**: ""That money would be better spen..."<br>*(oraz 3 innych odgałęzień)* |

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
  - -> `[3]` (*Moderator: ""President Rayne has already outlined some of his second-..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
Mówca: **Moderator**
> ""President Rayne has already outlined some of his second-term plans. What about the rest of you? What will your first priority be when you take office?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""You already know what I'm going to say.""]** — Mówca: **Frens Ricter**
> ""You already know what I'm going to say.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.P..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Frens Ricter: ""You already know what I'm going to say.""*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[8]`
Mówca: **Mansoun Leke**
> ""This simply proves the point I was about to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishReconciliation == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Threshold_15 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.P..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Stronger == true || BaseGame..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Threshold_15 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Frens Ricter: ""Sordland has been denied change for too long, and Presid..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Threshold_15 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Pol..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""I don't need to. My decision speaks for itself.""]** — Mówca: **Player**
> ""I don't need to. My decision speaks for itself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true || BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true || BaseGame.Policy_Law_TermLimits_2 == true || BaseGame.Policy_Law_Honorary_Abolished == true || BaseGame.Archetype_DemocraticRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Pol..."*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.P..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true || BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true || BaseGame.Policy_Law_TermLimits_2 == true || BaseGame.Policy_Law_Honorary_Abolished == true || BaseGame.Archetype_DemocraticRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true  or  Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true  or  Variable["BaseGame.Policy_Law_TermLimits_2"] == true  or  Variable["BaseGame.Policy_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Archetype_DemocraticRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Frens Ricter: ""President Rayne has pointed us in the right direction, b..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true || BaseGame.Policy_Law_Threshold_3 == true || BaseGame.Policy_Law_Threshold_8 == true || BaseGame.Policy_Law_TermLimits_2 == true || BaseGame.Policy_Law_Honorary_Abolished == true || BaseGame.Archetype_DemocraticRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true  or  Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true  or  Variable["BaseGame.Policy_Law_TermLimits_2"] == true  or  Variable["BaseGame.Policy_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Archetype_DemocraticRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn10_Term2Focus_Education == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn10_Term2Focus_Education == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn10_Term2Focus_Education == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn10_Term2Focus_Education == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn10_Term2Focus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Moderator: ""You've already pledged to make education a focus of your..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn10_Term2Focus_Education == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn10_Term2Focus_Education"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn10_Term2Focus_Military == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Frens Ricter: ""If you truly believed that, you would have had the popul..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""You already know what I'm going to say.""]** — Mówca: **Manoly Suheil**
> ""You already know what I'm going to say.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true` AND `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Manoly Suheil: ""Sordland has been denied change for too long, and Presid..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[26]`
Mówca: **Moderator**
> ""You've already pledged to make education a focus of your second term. Would you care to elaborate on that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: ""I don't need to. My decision speaks for itself.""*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true || ..."*)
  - -> `[118]` (*Player: ""Without an educated populace, Sordland is doomed to be s..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Sordland has been denied change for too long, and President Rayne's promised reforms turned out to be a giant step in the wrong direction.""]** — Mówca: **Frens Ricter**
> ""Sordland has been denied change for too long, and President Rayne's promised reforms turned out to be a giant step in the wrong direction.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""President Rayne has pointed us in the right direction, but only the PFJP can transform Sordland into a true democracy.""]** — Mówca: **Frens Ricter**
> ""President Rayne has pointed us in the right direction, but only the PFJP can transform Sordland into a true democracy.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true  or  Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true  or  Variable["BaseGame.Policy_Law_TermLimits_2"] == true  or  Variable["BaseGame.Policy_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Archetype_DemocraticRayne"] == true` AND `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[29]`
Mówca: **Moderator**
> ""President Rayne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn10_Term2Focus_Education == true"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""President Rayne's sham 'emergency' has made it abundantly clear how much Sordland needs true democracy.""]** — Mówca: **Frens Ricter**
> ""President Rayne's sham 'emergency' has made it abundantly clear how much Sordland needs true democracy.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Path"] == true` AND `(Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true  or  Variable["BaseGame.Policy_Law_Threshold_3"] == true  or  Variable["BaseGame.Policy_Law_Threshold_8"] == true  or  Variable["BaseGame.Policy_Law_TermLimits_2"] == true  or  Variable["BaseGame.Policy_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Archetype_DemocraticRayne"] == true) == false` AND `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Frens Ricter: ""The moment I take office, I will bring an end to his ter..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn10_Term2Focus_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn10_Term2Focus_Military == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn10_Term2Focus_Military == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn10_Term2Focus_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn10_Term2Focus_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Moderator: ""You've already pledged to make the military a focus of y..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn10_Term2Focus_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn10_Term2Focus_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn10_Term2Focus_Security == true"*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""President Rayne's sham 'emergency' has made it abundantly clear how much Sordland needs true democracy.""]** — Mówca: **Manoly Suheil**
> ""President Rayne's sham 'emergency' has made it abundantly clear how much Sordland needs true democracy.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false` AND `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[22]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Manoly Suheil: ""My very presence at this debate is proof of the lengths ..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Manoly Suheil: ""President Rayne has pointed us in the right direction, b..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Manoly Suheil: ""President Rayne's sham 'emergency' has made it abundantl..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Sordland has been denied change for too long, and President Rayne's promised reforms turned out to be a giant step in the wrong direction.""]** — Mówca: **Manoly Suheil**
> ""Sordland has been denied change for too long, and President Rayne's promised reforms turned out to be a giant step in the wrong direction.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[22]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Manoly Suheil: ""My very presence at this debate is proof of the lengths ..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""President Rayne has pointed us in the right direction, but only the PFJP can transform Sordland into a true democracy.""]** — Mówca: **Manoly Suheil**
> ""President Rayne has pointed us in the right direction, but only the PFJP can transform Sordland into a true democracy.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true` AND `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[22]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Manoly Suheil: ""My very presence at this debate is proof of the lengths ..."*)

### Węzeł `[40]`
Mówca: **Moderator**
> ""Thank you. Now, President Rayne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn10_Term2Focus_Education == true"*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Recent events have shown just how unprepared our military is in the face of a potential foreign invasion. We will no longer be weak.""]** — Mówca: **Player**
> ""Recent events have shown just how unprepared our military is in the face of a potential foreign invasion. We will no longer be weak.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Military_OutdatedMilitaryEquipment"] == true  or  Variable["BaseGame.Situation_Military_DecayingCombatReadiness"] == true  or  Variable["BaseGame.Situation_Military_GreenGenerals"] == true  or  Variable["BaseGame.Situation_Military_LackOfEquipment"] == true`
- **Kontekst wejściowy (poprzednik):** `[100]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_PeaceSummit == true"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""My very presence at this debate is proof of the lengths this man will go to cling to power. Sordland doesn't need another leader like that.""]** — Mówca: **Manoly Suheil**
> ""My very presence at this debate is proof of the lengths this man will go to cling to power. Sordland doesn't need another leader like that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Manoly Suheil), `[38]` (Manoly Suheil), `[39]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_FrensRicter == true"*)
  - -> `[63]` (*Player_Italic: "Don't interrupt."*)

### Węzeł `[43]`
Mówca: **Lileas Graf**
> ""I am just as committed to Sordland's security as I was as the Minister of Interior. And I will devote my presidency to strengthening that security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Moderator: ""Thank you. Now, President Rayne...""*)

### Węzeł `[44]`
Mówca: **Lileas Graf**
> ""Well, it strikes me that none of my opponents' grand plans are possible as long as our country is still vulnerable to threats from within and without its borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lileas Graf: ""I am just as committed to Sordland's security as I was a..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_Debate_SmallPartiesSilenced += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn10_Debate_SmallPartiesSilenced"] = Variable["BaseGameIsolated.Turn10_Debate_SmallPartiesSilenced"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "Mansoun glared at me and turned to the camera."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Kesaro cleared his throat."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Remus raised his fist."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Remus raised his fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Remus Holstron: ""This country is under attack from undesirable elements w..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_FrensRicter == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Kill_FrensRicter == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: ""What are you insinuating? Ricter's death had nothing to ..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Kill_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: ""Ricter was an enemy of the state. He had to be dealt with.""*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn10_Term2Focus_Security == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn10_Term2Focus_Security == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn10_Term2Focus_Security == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn10_Term2Focus_Security == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn10_Term2Focus_Security"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Moderator: ""You've already pledged to make security a focus of your ..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn10_Term2Focus_Security == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn10_Term2Focus_Security"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Moderator: ""You've already pledged to make health care a focus of yo..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: ""What are you insinuating? Ricter's death had nothing to do with me.""]** — Mówca: **Player**
> ""What are you insinuating? Ricter's death had nothing to do with me.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Kontekst wejściowy (poprzednik):** `[42]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[60]`
Mówca: **Moderator**
> ""Ms. Graf?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: ""Well, it strikes me that none of my opponents' grand pla..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Ricter was an enemy of the state. He had to be dealt with.""]** — Mówca: **Player**
> ""Ricter was an enemy of the state. He had to be dealt with.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[62]`
Mówca: **Manoly Suheil**
> ""If you truly believed that, you would have had the populace vaccinated. As in every other developed country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "Don't interrupt."]** — Mówca: **Player_Italic**
> "I clenched my jaw and stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""We were lucky enough to stop the recent polio outbreak, but we must be prepared in the event of further epidemics.""]** — Mówca: **Player**
> ""We were lucky enough to stop the recent polio outbreak, but we must be prepared in the event of further epidemics.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Situation_Welfare_EpidemicSpreads"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[143]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true || BaseGame.Media_Sordl..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Moderator: ""Ms. Suheil, the circumstances of Mr. Ricter's death are ..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Moderator: ""Please let the other candidates speak, Mr. President.""*)

### Węzeł `[68]`
Mówca: **Lileas Graf**
> ""The outbreak would have ended on its own without you pumping Sordish citizens full of chemicals. It was the Lord's will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true || BaseGame.Media_Sordl..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Moderator: ""Ms. Suheil, the circumstances of Mr. Ricter's detainment..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Moderator: ""Please let the other candidates speak, Mr. President.""*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Moderator: ""Ms. Graf?""*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Moderator: ""President Rayne...""*)

### Węzeł `[75]`
Mówca: **Moderator**
> ""Please let the other candidates speak, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[76]`
Mówca: **Frens Ricter**
> ""If you truly believed that, you would have had the populace vaccinated. As in every other developed country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[77]`
Mówca: **Moderator**
> ""Okay. Let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[78]`
Mówca: **Moderator**
> ""Ms. Suheil, the circumstances of Mr. Ricter's death are well known. Don't promote conspiracy theories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[79]`
Mówca: **Moderator**
> ""Ms. Suheil, the circumstances of Mr. Ricter's detainment are well known. Don't promote conspiracy theories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Mansoun Leke leaned forward in his chair."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "Denis Stahler leaned forward in his chair."*)

### Węzeł `[83]`
Mówca: **Remus Holstron**
> ""This country is under attack from undesirable elements who would see it torn apart from within. They deserve nothing but expulsion from our services.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Signed == true || BaseGame.Unres..."*)

### Węzeł `[84]`
Mówca: **Mansoun Leke**
> ""One *could* say that, but--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Moderator: ""Okay. Let's move on.""*)

### Węzeł `[85]`
Mówca: **Narrator**
> "His face calm, he turned directly to the camera."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Mansoun Leke: ""This simply proves the point I was about to make.""*)

### Węzeł `[86]`
Mówca: **Denis Stahler**
> ""And of course, the number-one mechanism of oppression is capitalism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Mansoun Leke: ""One *could* say that, but--""*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true || BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true ||..."*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true ..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true || BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player: ""Budget constraints during my first term meant I couldn't..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true || BaseGame.Turn03_EnT_Healthcare_Budget_Maintain == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player: ""Devoting more resources towards health care already paid..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Manoly Suheil: ""If you truly believed that, you would have had the popul..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lileas Graf: ""The outbreak would have ended on its own without you pum..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)

### Węzeł `[99]`
Mówca: **Frens Ricter**
> ""Governing together, our parties will use the new reforms as a launchpad for new laws that ensure representation for every single Sordish citizen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[100]`
Mówca: **Moderator**
> ""You've already pledged to make the military a focus of your second term. Would you care to elaborate on that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true || B..."*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_OutdatedMilitaryEquipment == ..."*)

### Węzeł `[101]`
Mówca: **Frens Ricter**
> ""I will work hard to pass the constitutional reforms that he could not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[102]`
Mówca: **Narrator**
> "Mansoun nodded appreciatively and turned to the camera."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Mansoun Leke: ""This simply proves the point I was about to make.""*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_Nationwide_Revolt == true || Bas..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Frens Ricter: ""The moment I take office, I will undo his constitutional..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Frens Ricter: ""My constitutional reforms will succeed where his failed ..."*)

### Węzeł `[109]`
Mówca: **Frens Ricter**
> ""The moment I take office, I will undo his constitutional changes and give power back to the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[110]`
Mówca: **Frens Ricter**
> ""My constitutional reforms will succeed where his failed and give power back to the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Manoly Suheil: ""You already know what I'm going to say.""*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Polio is continuing to ravage our country. Ending the epidemic is of the utmost importance.""]** — Mówca: **Player**
> ""Polio is continuing to ravage our country. Ending the epidemic is of the utmost importance.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Welfare_EpidemicSpreads"] == true`
- **Kontekst wejściowy (poprzednik):** `[143]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[115]`
**[WYBÓR GRACZA: ""Recent events have shown how important it is for the government to keep a handle on unrest.""]** — Mówca: **Player**
> ""Recent events have shown how important it is for the government to keep a handle on unrest.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true`
- **Kontekst wejściowy (poprzednik):** `[134]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""A strong military is the backbone of Sordland. It's as simple as that.""]** — Mówca: **Player**
> ""A strong military is the backbone of Sordland. It's as simple as that.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Situation_Military_OutdatedMilitaryEquipment"] == true  or  Variable["BaseGame.Situation_Military_DecayingCombatReadiness"] == true  or  Variable["BaseGame.Situation_Military_GreenGenerals"] == true  or  Variable["BaseGame.Situation_Military_LackOfEquipment"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[100]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_PeaceSummit == true"*)

### Węzeł `[117]`
Mówca: **Narrator**
> "Mansoun glared at me and turned to the camera."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Mansoun Leke: ""This simply proves the point I was about to make.""*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Without an educated populace, Sordland is doomed to be stuck in the past. It's as simple as that.""]** — Mówca: **Player**
> ""Without an educated populace, Sordland is doomed to be stuck in the past. It's as simple as that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true"*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Kesaro cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Kesaro Kibener: ""As president, I would crack down on the enemies of the s..."*)

### Węzeł `[120]`
Mówca: **Mansoun Leke**
> ""Sordland is not free as long as its women and minorities are still discriminated against. Only once we dismantle the mechanisms of oppression can we begin to move this country forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Denis Stahler: ""And of course, the number-one mechanism of oppression is..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""Devoting more resources towards education already paid enormous dividends during my first term. Why stop now?""]** — Mówca: **Player**
> ""Devoting more resources towards education already paid enormous dividends during my first term. Why stop now?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[26]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""Budget constraints during my first term meant Sordland's education system went underfunded. I regret that now.""]** — Mówca: **Player**
> ""Budget constraints during my first term meant Sordland's education system went underfunded. I regret that now.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true`
- **Kontekst wejściowy (poprzednik):** `[26]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true"*)

### Węzeł `[123]`
Mówca: **Kesaro Kibener**
> ""As president, I would crack down on the enemies of the state who are threatening to tear this country apart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Signed == true || BaseGame.Unres..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Enough! This is a debate, not a platform for your racist hate-mongering.""]** — Mówca: **Player**
> ""Enough! This is a debate, not a platform for your racist hate-mongering.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Remus Holstron), `[165]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "Mansoun nodded appreciatively and turned to the camera."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Deal_Signed == true || BaseGame.Unrest_BFF_Deal_Promised == true || BaseGame.Bludish_Opinion > 0 || BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true || BaseGame.Bill_Turn07_LanguageBill_Vetoed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Signed == true || BaseGame.Unres..."*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Deal_Signed == true || BaseGame.Unr..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Deal_Signed == true || BaseGame.Unrest_BFF_Deal_Promised == true || BaseGame.Bludish_Opinion > 0 || BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true || BaseGame.Bill_Turn07_LanguageBill_Vetoed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Deal_Signed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Promised"] == true  or  Variable["BaseGame.Bludish_Opinion"] > 0  or  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed"] == true  or  Variable["BaseGame.Bill_Turn07_LanguageBill_Vetoed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Kesaro Kibener: ""Separatists, militants, foreign agents, criminal cartels..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Deal_Signed == true || BaseGame.Unrest_BFF_Deal_Promised == true || BaseGame.Bludish_Opinion > 0 || BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true || BaseGame.Bill_Turn07_LanguageBill_Vetoed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Deal_Signed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Promised"] == true  or  Variable["BaseGame.Bludish_Opinion"] > 0  or  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed"] == true  or  Variable["BaseGame.Bill_Turn07_LanguageBill_Vetoed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Kesaro Kibener: ""President Rayne has the right idea, but he hasn't gone f..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Deal_Signed == true || BaseGame.Unrest_BFF_Deal_Promised == true || BaseGame.Bludish_Opinion > 0 || BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true || BaseGame.Bill_Turn07_LanguageBill_Vetoed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Signed == true || BaseGame.Unres..."*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Deal_Signed == true || BaseGame.Unr..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Deal_Signed == true || BaseGame.Unrest_BFF_Deal_Promised == true || BaseGame.Bludish_Opinion > 0 || BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true || BaseGame.Bill_Turn07_LanguageBill_Vetoed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Deal_Signed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Promised"] == true  or  Variable["BaseGame.Bludish_Opinion"] > 0  or  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed"] == true  or  Variable["BaseGame.Bill_Turn07_LanguageBill_Vetoed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Remus Holstron: ""We are a weak country ruled by a weak man. Bludish seper..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Deal_Signed == true || BaseGame.Unrest_BFF_Deal_Promised == true || BaseGame.Bludish_Opinion > 0 || BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true || BaseGame.Bill_Turn07_LanguageBill_Vetoed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Deal_Signed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Promised"] == true  or  Variable["BaseGame.Bludish_Opinion"] > 0  or  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed"] == true  or  Variable["BaseGame.Bill_Turn07_LanguageBill_Vetoed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Remus Holstron: ""President Rayne has the right idea, but he hasn't gone f..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_OutdatedMilitaryEquipment == true || BaseGame.Situation_Military_DecayingCombatReadiness == true || BaseGame.Situation_Military_GreenGenerals == true || BaseGame.Situation_Military_LackOfEquipment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_OutdatedMilitaryEquipment == ..."*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Military_OutdatedMilitaryEquipment =..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_OutdatedMilitaryEquipment == true || BaseGame.Situation_Military_DecayingCombatReadiness == true || BaseGame.Situation_Military_GreenGenerals == true || BaseGame.Situation_Military_LackOfEquipment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Military_OutdatedMilitaryEquipment"] == true  or  Variable["BaseGame.Situation_Military_DecayingCombatReadiness"] == true  or  Variable["BaseGame.Situation_Military_GreenGenerals"] == true  or  Variable["BaseGame.Situation_Military_LackOfEquipment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: ""Recent events have shown just how unprepared our militar..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Military_OutdatedMilitaryEquipment == true || BaseGame.Situation_Military_DecayingCombatReadiness == true || BaseGame.Situation_Military_GreenGenerals == true || BaseGame.Situation_Military_LackOfEquipment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Military_OutdatedMilitaryEquipment"] == true  or  Variable["BaseGame.Situation_Military_DecayingCombatReadiness"] == true  or  Variable["BaseGame.Situation_Military_GreenGenerals"] == true  or  Variable["BaseGame.Situation_Military_LackOfEquipment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: ""A strong military is the backbone of Sordland. It's as s..."*)

### Węzeł `[134]`
Mówca: **Moderator**
> ""You've already pledged to make security a focus of your second term. Would you care to elaborate on that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == tru..."*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unr..."*)

### Węzeł `[135]`
Mówca: **Denis Stahler**
> ""Sordland is not free as long as its workers are still oppressed. Only once we have completely given the means of production back to the people can we begin to move this country forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Moderator: ""Okay. Let's move on.""*)

### Węzeł `[136]`
Mówca: **Narrator**
> "Denis Stahler leaned forward in his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Denis Stahler: ""Sordland is not free as long as its workers are still op..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "Don't interrupt."]** — Mówca: **Player_Italic**
> "I waited to see how Mansoun would respond."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "His face calm, he turned directly to the camera."*)

### Węzeł `[138]`
Mówca: **Remus Holstron**
> ""Good. One less terrorist on the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: ""Enough! This is a debate, not a platform for your racist..."*)
  - -> `[158]` (*Player: ""Mansoun, don't speak out of turn.""*)
  - -> `[137]` (*Player_Italic: "Don't interrupt."*)

### Węzeł `[139]`
Mówca: **Kesaro Kibener**
> ""Separatists, militants, foreign agents, criminal cartels -- we shall show them all the meaning of Sordish justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[140]`
Mówca: **Remus Holstron**
> ""We are a weak country ruled by a weak man. Bludish seperatists, Wehzek militants, Malenyevist foreign agents, Oligarch's criminal cartels -- I will show them all the meaning of Sordish justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[141]`
Mówca: **Kesaro Kibener**
> ""President Rayne has the right idea, but he hasn't gone far enough. Separatists, militants, foreign agents, criminal cartels -- we shall show them all the meaning of Sordish justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[142]`
Mówca: **Remus Holstron**
> ""President Rayne has the right idea, but he hasn't gone far enough. Bludish seperatists, Wehzek militants, Malenyevist foreign agents, Oligarch's criminal cartels -- I will show them all the meaning of Sordish justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[143]`
Mówca: **Moderator**
> ""You've already pledged to make health care a focus of your second term. Would you care to elaborate on that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true ||..."*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true || BaseGame.Turn03_EnT_Education_Budget_Maintain == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true || ..."*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true |..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true || BaseGame.Turn03_EnT_Education_Budget_Maintain == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""Budget constraints during my first term meant Sordland's..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true || BaseGame.Turn03_EnT_Education_Budget_Maintain == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Education_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""Devoting more resources towards education already paid e..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_EpidemicSpreads == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicSpreads == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_EpidemicSpreads == true)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_EpidemicSpreads == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_EpidemicSpreads"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: ""Polio is continuing to ravage our country. Ending the ep..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_EpidemicSpreads == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_EpidemicSpreads"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: ""We were lucky enough to stop the recent polio outbreak, ..."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "Mansoun Leke leaned forward in his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishReconciliation == true"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && ..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "Denis Stahler leaned forward in his chair."*)

### Węzeł `[154]`
Mówca: **Mansoun Leke**
> ""The way you showed Fetih Ejall? They say he might never walk again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true || B..."*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true ||..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: ""Budget constraints during my first term meant the milita..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player: ""Devoting more resources towards the military already pai..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: ""Mansoun, don't speak out of turn.""]** — Mówca: **Player**
> ""Mansoun, don't speak out of turn.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Remus Holstron), `[165]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_Debate_SmallPartiesSilenced += 1"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == tru..."*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == t..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player: ""Budget constraints during my first term meant I couldn't..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: ""Devoting more resources towards law enforcement already ..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Kesaro Kibener: ""What happened to Fetih is a shame. I would say that caut..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Remus Holstron: ""Good. One less terrorist on the streets.""*)

### Węzeł `[165]`
Mówca: **Kesaro Kibener**
> ""What happened to Fetih is a shame. I would say that caution is advised to all who tread a path against our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: ""Enough! This is a debate, not a platform for your racist..."*)
  - -> `[158]` (*Player: ""Mansoun, don't speak out of turn.""*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unr..."*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_Peaceful_Happened == true || BaseGame.U..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: ""Recent events have shown how important it is for the gov..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Peaceful_Happened == true || BaseGame.Unrest_Violent_Happened == true || BaseGame.Unrest_BFF_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""Sordland needs a president who is tough on crime. It's a..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""Sordland needs a president who is tough on crime. It's as simple as that.""]** — Mówca: **Player**
> ""Sordland needs a president who is tough on crime. It's as simple as that.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true  or  Variable["BaseGame.Unrest_Violent_Happened"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[134]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Kesaro Kibener: ""The outbreak happened because of government negligence i..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[173]`
Mówca: **Kesaro Kibener**
> ""The outbreak happened because of government negligence in the first place. No reason to blow your own whistle when you solve the problems you create.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[174]`
Mówca: **Remus Holstron**
> ""The outbreak would have ended on its own without you pumping Sordish citizens full of chemicals. It is the reality of natural selection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Remus Holstron: ""The outbreak would have ended on its own without you pum..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors..."*)

### Węzeł `[178]`
Mówca: **Kesaro Kibener**
> ""The outbreak is a shame and my condolences to all who lost relatives to it. We hope to see a quicker end a better management.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[179]`
**[WYBÓR GRACZA: ""Budget constraints during my first term meant I couldn't devote as many resources to health care as I had planned. I regret that now.""]** — Mówca: **Player**
> ""Budget constraints during my first term meant I couldn't devote as many resources to health care as I had planned. I regret that now.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Maintain"] == true`
- **Kontekst wejściowy (poprzednik):** `[143]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_HealthCrisis == true"*)

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Devoting more resources towards health care already paid enormous dividends during my first term. Why stop now?""]** — Mówca: **Player**
> ""Devoting more resources towards health care already paid enormous dividends during my first term. Why stop now?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Maintain"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[143]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_HealthCrisis == true"*)

### Węzeł `[181]`
**[WYBÓR GRACZA: ""Budget constraints during my first term meant I couldn't devote enough resources to this vital area. I regret that now.""]** — Mówca: **Player**
> ""Budget constraints during my first term meant I couldn't devote as many resources towards law enforcement as I had planned. I regret that now.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true`
- **Kontekst wejściowy (poprzednik):** `[134]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""Devoting more resources towards law enforcement already paid enormous dividends during my first term. Why stop now?""]** — Mówca: **Player**
> ""Devoting more resources towards law enforcement already paid enormous dividends during my first term. Why stop now?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[134]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_Nationwide_Revolt == true || BaseGame.Situation_Order_Nationwide_Protests == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_Nationwide_Revolt == true || Bas..."*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Order_Nationwide_Revolt == true || B..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_Nationwide_Revolt == true || BaseGame.Situation_Order_Nationwide_Protests == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Order_Nationwide_Revolt"] == true  or  Variable["BaseGame.Situation_Order_Nationwide_Protests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Lileas Graf: ""I watched this man turn Sordland into a powder keg. I wa..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Order_Nationwide_Revolt == true || BaseGame.Situation_Order_Nationwide_Protests == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Order_Nationwide_Revolt"] == true  or  Variable["BaseGame.Situation_Order_Nationwide_Protests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Lileas Graf: ""Everything this man knows about national security, he le..."*)

### Węzeł `[186]`
Mówca: **Lileas Graf**
> ""I watched this man turn Sordland into a powder keg. I warn you, he is not to be trusted with our national security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[187]`
Mówca: **Lileas Graf**
> ""Everything this man knows about national security, he learned from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA: ""Budget constraints during my first term meant the military went underfunded. I regret that now.""]** — Mówca: **Player**
> ""Budget constraints during my first term meant the military went underfunded. I regret that now.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true`
- **Kontekst wejściowy (poprzednik):** `[100]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_PeaceSummit == true"*)

### Węzeł `[189]`
**[WYBÓR GRACZA: ""Devoting more resources towards the military already paid enormous dividends during my first term. Why stop now?""]** — Mówca: **Player**
> ""Devoting more resources towards the military already paid enormous dividends during my first term. Why stop now?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[100]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_PeaceSummit == true"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_PeaceSummit == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_PeaceSummit == true"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_PeaceSummit == true)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_PeaceSummit == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_PeaceSummit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_PeaceSummit == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_PeaceSummit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[193]`
Mówca: **Kesaro Kibener**
> ""Don't pretend to be a proud military man after the way you caved to Rumburg like a coward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Frens Ricter: ""That money would be better spent helping Sordland's peop..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Manoly Suheil: ""That money would be better spent helping Sordland's peop..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Denis Stahler: ""That money would be better spent helping Sordland's peop..."*)

### Węzeł `[200]`
Mówca: **Frens Ricter**
> ""That money would be better spent helping Sordland's people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[201]`
Mówca: **Manoly Suheil**
> ""That money would be better spent helping Sordland's people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_HealthCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_HealthCrisis == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_HealthCrisis == true )"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_HealthCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_HealthCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_HealthCrisis == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_HealthCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Moderator: ""Moving on....""*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Frens Ricter: ""You allowed Sordland to descend into a health crisis. Fu..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[208]`
Mówca: **Frens Ricter**
> ""You allowed Sordland to descend into a health crisis. Funding health care is useless unless the money is well allocated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Manoly Suheil: ""You allowed Sordland to descend into a health crisis. Fu..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Denis Stahler: ""You allowed Sordland to descend into a health crisis. Fu..."*)

### Węzeł `[212]`
Mówca: **Manoly Suheil**
> ""You allowed Sordland to descend into a health crisis. Funding health care is useless unless the money is well allocated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[213]`
Mówca: **Denis Stahler**
> ""You allowed Sordland to descend into a health crisis. Funding health care is useless unless the money is well allocated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Security_Unrest_Police == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true || Base..."*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true || Ba..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Security_Unrest_Police == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Security_Unrest_Police"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Mansoun Leke: ""Your police are jailing innocents and you want *more* la..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Security_Unrest_Police == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Security_Unrest_Police"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Mansoun Leke: ""That money could be better spent helping Sordland's peop..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true || Base..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true || Base..."*)

### Węzeł `[220]`
Mówca: **Mansoun Leke**
> ""Your police are jailing innocents and you want *more* law enforcement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[221]`
Mówca: **Mansoun Leke**
> ""That money could be better spent helping Sordland's people, not greasing the wheels of an unjust system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[222]`
Mówca: **Denis Stahler**
> ""Your police are jailing innocents and you want *more* law enforcement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[223]`
Mówca: **Denis Stahler**
> ""That money could be better spent helping Sordland's people, not greasing the wheels of an unjust system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Security_Unrest_Police == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true || Base..."*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true || Ba..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Security_Unrest_Police == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Security_Unrest_Police"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Denis Stahler: ""Your police are jailing innocents and you want *more* la..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Security_Unrest_Police == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Security_Unrest_Police"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Denis Stahler: ""That money could be better spent helping Sordland's peop..."*)

### Węzeł `[227]`
Mówca: **Denis Stahler**
> ""That money would be better spent helping Sordland's people, not greasing the wheels of the military industrial complex.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Kesaro Kibener: ""Don't pretend to be a proud military man after the way y..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Remus Holstron: ""Rumburg has you cowering in a corner and here you are pr..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[234]`
Mówca: **Remus Holstron**
> ""Rumburg has you cowering in a corner and here you are pretending to be a hero. What a disgrace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[235]`
Mówca: **Lileas Graf**
> ""A true military man would have shown strength against Rumburg, rather than broker a one-sided 'peace'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Lileas Graf: ""A true military man would have shown strength against Ru..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true || BaseGame.Media_Sordl..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Moderator: ""I asked the president a question. I did not ask for crit..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Moderator: ""We can address those comments later, if there's time.""*)

### Węzeł `[242]`
Mówca: **Moderator**
> ""We can address those comments later, if there's time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Moderator: ""Moving on....""*)

### Węzeł `[243]`
Mówca: **Moderator**
> ""I asked the president a question. I did not ask for criticism of his policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Moderator: ""Moving on....""*)

### Węzeł `[244]`
Mówca: **Moderator**
> ""Moving on....""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FailedEducationReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_FailedEducationReform == true)"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FailedEducationReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_FailedEducationReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EvolutionNotMandatory == false ||..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Frens Ricter: ""You had a chance to reform Sordland's education system, ..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[251]`
Mówca: **Frens Ricter**
> ""You had a chance to reform Sordland's education system, but you left it in shambles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Manoly Suheil: ""You had a chance to reform Sordland's education system, ..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Denis Stahler: ""You had a chance to reform Sordland's education system, ..."*)

### Węzeł `[255]`
Mówca: **Manoly Suheil**
> ""You had a chance to reform Sordland's education system, but you left it in shambles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors..."*)

### Węzeł `[256]`
Mówca: **Denis Stahler**
> ""You had a chance to reform Sordland's education system, but you left it in shambles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EvolutionNotMandatory == false || BaseGame.Situation_Welfare_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EvolutionNotMandatory == false ||..."*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Welfare_EvolutionNotMandatory == false ..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EvolutionNotMandatory == false || BaseGame.Situation_Welfare_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_EvolutionNotMandatory"] == false  or  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Welfare_EvolutionNotMandatory == false || BaseGame.Situation_Welfare_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_EvolutionNotMandatory"] == false  or  Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Lileas Graf: ""Give this man a chance and he'll continue to warp our ch..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Kesaro Kibener: ""Give this man a chance and he'll continue to warp your c..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron)"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Remus Holstron: ""Give this man a chance and he'll continue to warp your c..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[269]`
Mówca: **Lileas Graf**
> ""Give this man a chance and he'll continue to warp our children's minds with his 'progressive' education reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[270]`
Mówca: **Kesaro Kibener**
> ""Give this man a chance and he'll continue to warp your children's minds 'progressive' reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[271]`
Mówca: **Remus Holstron**
> ""Give this man a chance and he'll continue to warp your children's minds with his anti-nationalist 'progressive' reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors..."*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_RelocationOfTeachersAndDocto..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Frens Ricter: ""And then tried to make up for it by forcing precious tea..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_PFJP == true)"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Frens Ricter: ""Governing together, our parties will use the new reforms..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_PFJP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Frens Ricter: ""I will use his new reforms as a launchpad for new laws t..."*)

### Węzeł `[278]`
Mówca: **Frens Ricter**
> ""I will use his new reforms as a launchpad for new laws that ensure representation for every single Sordish citizen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_PFJP == true)"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Frens Ricter: ""Governing together, we will push twice as hard to achiev..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_PFJP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Frens Ricter: ""I will work hard to pass the constitutional reforms that..."*)

### Węzeł `[282]`
Mówca: **Frens Ricter**
> ""Governing together, we will push twice as hard to achieve the constitutional reforms that the people deserve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[283]`
Mówca: **Frens Ricter**
> ""The moment I take office, I will bring an end to his terror and push for the reforms the people have demanded for so long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishReconciliation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishReconciliation == true"*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_BludishReconciliation == true)"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishReconciliation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Mansoun Leke: ""While President Rayne has made great strides in dismantl..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_BludishReconciliation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishReconciliation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_ExcellentWomenRights == true"*)

### Węzeł `[287]`
Mówca: **Mansoun Leke**
> ""While President Rayne has made great strides in dismantling the mechanisms of oppression in Sordland, the hateful attitudes that built them are still very much present. We will never be free as long as minorities and women are still seen as second-class citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Denis Stahler: ""And of course, the number-one mechanism of oppression is..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Privatization == true)"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Denis Stahler: ""You kept the worst elements of Soll's system while putti..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Denis Stahler: ""Unless you eradicate Soll's backwards education system, ..."*)

### Węzeł `[291]`
Mówca: **Denis Stahler**
> ""You kept the worst elements of Soll's system while putting education in the hands of corporations. I fear for our children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[292]`
Mówca: **Denis Stahler**
> ""Unless you eradicate Soll's backwards education system, our children are doomed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Privatization == true)"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Lileas Graf: ""Not to mention that he's putting their future in the han..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[296]`
Mówca: **Lileas Graf**
> ""Not to mention that he's putting their future in the hands of private corporations...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[297]`
Mówca: **Frens Ricter**
> ""And then tried to make up for it by forcing precious teachers to uproot their lives...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[298]`
Mówca: **Manoly Suheil**
> ""And then tried to make up for it by forcing precious teachers to uproot their lives...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors..."*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_RelocationOfTeachersAndDocto..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Manoly Suheil: ""And then tried to make up for it by forcing precious tea..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors..."*)
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_RelocationOfTeachersAndDocto..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_RelocationOfTeachersAndDoctors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Frens Ricter: ""There's preparedness, and then there's forcing our preci..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[308]`
Mówca: **Frens Ricter**
> ""There's preparedness, and then there's forcing our precious doctors to uproot their lives...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[309]`
Mówca: **Manoly Suheil**
> ""There's preparedness, and then there's forcing our precious doctors to uproot their lives...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Frens Ricter: ""On this topic, our parties are in absolute agreement.""*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[313]`
Mówca: **Frens Ricter**
> ""On this topic, our parties are in absolute agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Moderator: ""Moving on....""*)

### Węzeł `[314]`
Mówca: **Manoly Suheil**
> ""On this topic, our parties are in absolute agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Moderator: ""Moving on....""*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Kesaro Kibener: ""The outbreak is a shame and my condolences to all who lo..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[318]`
Mówca: **Denis Stahler**
> ""If you truly believed that, you would have had the populace vaccinated. As in every other developed country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Manoly Suheil: ""There's preparedness, and then there's forcing our preci..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Denis Stahler: ""On this topic, our parties are in absolute agreement.""*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Manoly Suheil: ""On this topic, our parties are in absolute agreement.""*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Denis Stahler: ""On this topic, our parties are in absolute agreement.""*)

### Węzeł `[325]`
Mówca: **Denis Stahler**
> ""On this topic, our parties are in absolute agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[326]`
Mówca: **Denis Stahler**
> ""On this topic, our parties are in absolute agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Frens Ricter: ""President Rayne's sham 'emergency' has made it abundantl..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[330]`
Mówca: **Frens Ricter**
> ""The moment I take office, I will push for the reforms the people have demanded for so long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Remus Holstron: ""The outbreak will end on its own. It's natural selection..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Denis Stahler: ""If you truly believed that, you would have had the popul..."*)

### Węzeł `[334]`
Mówca: **Remus Holstron**
> ""The outbreak will end on its own. It's natural selection. The strongest people with healthy immune systems will survive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Arrest_FetihEjall == false && BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && ..."*)
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == false &..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Arrest_FetihEjall == false && BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false  and  Variable["BaseGame.Arrest_FetihEjall"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Mansoun Leke: ""The way you showed Fetih Ejall? They say he might never ..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Arrest_FetihEjall == false && BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false  and  Variable["BaseGame.Arrest_FetihEjall"] == false  and  Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||Ba..."*)

### Węzeł `[338]`
Mówca: **Mansoun Leke**
> ""The way the government showed Fetih Ejall?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||BaseGame.Arrest_FetihEjall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||Ba..."*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||BaseGame.Arrest_FetihEjall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Mansoun Leke: ""The way the government showed Fetih Ejall?"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||BaseGame.Arrest_FetihEjall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Mansoun Leke: ""Unbelievable.""*)

### Węzeł `[342]`
Mówca: **Mansoun Leke**
> ""Unbelievable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Mansoun Leke: ""This simply proves the point I was about to make.""*)

### Węzeł `[343]`
Mówca: **Remus Holstron**
> ""Exactly. Thankfully, that's one less terrorist on the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Mansoun Leke: ""This simply proves the point I was about to make.""*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Kesaro Kibener: ""Mr. Ejall was arrested for his crimes against the state,..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Remus Holstron: ""Exactly. Thankfully, that's one less terrorist on the st..."*)

### Węzeł `[347]`
Mówca: **Kesaro Kibener**
> ""Mr. Ejall was arrested for his crimes against the state, Mr. Leke. I would say that caution is advised to all who tread a path against our country's justice system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Mansoun Leke: ""The same justice system that prosecuted thousands of inn..."*)

### Węzeł `[348]`
Mówca: **Mansoun Leke**
> ""The same justice system that prosecuted thousands of innocent people for their political beliefs and cultural differences?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Mansoun Leke: ""This simply proves the point I was about to make.""*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_ExcellentWomenRights == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_ExcellentWomenRights == true"*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_ExcellentWomenRights == true )"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_ExcellentWomenRights == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Mansoun Leke: ""While President Rayne has taken steps to improve the sta..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_ExcellentWomenRights == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Mansoun Leke: ""Sordland is not free as long as its women and minorities..."*)

### Węzeł `[352]`
Mówca: **Mansoun Leke**
> ""While President Rayne has taken steps to improve the standing of some Sordish citizens, minorities such as the Bludish people have been left behind. Only once we fully dismantle the mechanisms of oppression can we begin to move this country forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Denis Stahler: ""And of course, the number-one mechanism of oppression is..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Frens Ricter: ""President Rayne has pointed us in the right direction, b..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Frens Ricter: ""The moment I take office, I will push for the reforms th..."*)
