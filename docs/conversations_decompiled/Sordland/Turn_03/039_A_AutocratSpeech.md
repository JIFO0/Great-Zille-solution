# Sordland/Turn03/A_AutocratSpeech

- **ID konwersacji:** `39`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/039_A_AutocratSpeech.md`
- **Liczba węzłów dialogowych:** 351
- **Liczba wyborów gracza:** 41

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[15]** Mansoun Leke
- **[34]** Gloria Tory
- **[50]** Kesaro Kibener

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Law_Ban_YoungSords`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Reform_EmergencyDecree_Embargo_None`
- `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg`
- `BaseGame.Reform_EmergencyDecree_Embargo_UC`
- `BaseGame.Reform_EmergencyDecree_PoliceAuthority`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGameIsolated.Turn04_A_Speech_Hub_A`
- `BaseGameIsolated.Turn04_A_Speech_Hub_B`
- `BaseGameIsolated.Turn04_A_Speech_Hub_C`
- `BaseGameIsolated.Turn04_A_Speech_Hub_D`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Capitalist`
- `BaseGame.Democratic`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Diplomacy_EmbargoingArcasia`
- `BaseGame.Policy_Diplomacy_EmbargoingRumburg`
- `BaseGame.Policy_Diplomacy_EmbargoingUnitedContana`
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Law_Ban_YoungSords`
- `BaseGame.Policy_Law_Decree_Default`
- `BaseGame.Policy_Law_Decree_Stronger`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Policy_Order_Authority`
- `BaseGame.Policy_Order_DetentionWithoutTrial`
- `BaseGame.Policy_Order_SuspendedProtests`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.Situation_Law_BludishProblem`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Situation_Law_ExpandedHumanRights`
- `BaseGame.Situation_Law_LimitedHumanRights`
- `BaseGame.Situation_Law_SomeHumanRights`
- `BaseGame.Situation_Order_LittleSecurityPowers`
- `BaseGame.Situation_Order_Prisons_Crowded`
- `BaseGame.Situation_Order_SomeSecurityPowers`
- `BaseGame.Situation_Order_WideRangingSecurityPowers`
- `BaseGame.Sollist`
- `BaseGameIsolated.Turn04_A_Speech_Hub_A`
- `BaseGameIsolated.Turn04_A_Speech_Hub_B`
- `BaseGameIsolated.Turn04_A_Speech_Hub_C`
- `BaseGameIsolated.Turn04_A_Speech_Hub_D`
- `BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia`
- `BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC`
- `BaseGameSupport.Journal_Turn03_Autocrat_Speech`
- `BaseGameSupport.News_Turn03_E_Emergency`
- `BaseGameSupport.News_Turn03_G_Emergency`
- `BaseGameSupport.News_Turn03_HP_Emergency_AREmbargo`
- `BaseGameSupport.News_Turn03_HP_Emergency_AllEmbargo`
- `BaseGameSupport.News_Turn03_HP_Emergency_ArcasiaEmbargo`
- `BaseGameSupport.News_Turn03_HP_Emergency_NoEmbargo`
- `BaseGameSupport.News_Turn03_HP_Emergency_RumburgEmbargo`
- `BaseGameSupport.News_Turn03_HP_Emergency_UCAEmbargo`
- `BaseGameSupport.News_Turn03_HP_Emergency_UCEmbargo`
- `BaseGameSupport.News_Turn03_HP_Emergency_UCREmbargo`
- `BaseGameSupport.News_Turn03_LT_Emergency_AllBanned`
- `BaseGameSupport.News_Turn03_LT_Emergency_BludBanned`
- `BaseGameSupport.News_Turn03_LT_Emergency_RYBanned`
- `BaseGameSupport.News_Turn03_LT_Emergency_RYBludBanned`
- `BaseGameSupport.News_Turn03_LT_Emergency_YSBanned`
- `BaseGameSupport.News_Turn03_LT_Emergency_YSBludBanned`
- `BaseGameSupport.News_Turn03_LT_Emergency_YSRYBanned`
- `BaseGameSupport.News_Turn03_R_Emergency`
- `BaseGameSupport.News_Turn03_ST_Emergency_Deal`
- `BaseGameSupport.News_Turn03_ST_Emergency_NoDeal`
- `BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned`
- `BaseGameSupport.Report_Turn03_Erzaren_Emergency_BludBanned`
- `BaseGameSupport.Report_Turn03_Holsord_Emergency`
- `GameCondition.Turn03_A_AutocratSpeech`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 19
- **Węzły modyfikujące stan gry:** 66

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Policy_Law_Decree_Default`
- `BaseGame.Policy_Law_Decree_Stronger`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Policy_Order_Authority`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Sollist`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[99]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"] = true;`
- Węzeł `[100]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"] = true;`
- Węzeł `[101]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"] = true;`
- Węzeł `[102]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] = true;`
- Węzeł `[199]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn03_Autocrat_Speech"] = true;`
- Węzeł `[200]` (Paskal Beniwoll): `Variable["GameCondition.Turn03_A_AutocratSpeech"] = true;`
- Węzeł `[204]` (Paskal Beniwoll): `Variable["BaseGame.Policy_Law_EmergencyDecree"] = true; Variable["BaseGame.Policy_Law_Decree_Stro...`
- Węzeł `[205]` (Paskal Beniwoll): `Variable["BaseGame.Situation_Law_SomeHumanRights"] = false; Variable["BaseGame.Situation_Law_Limi...`
- *...oraz 58 innych węzłów ze skryptami.*

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
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I had recently signed the Emergency Act, which created a ruckus in the Sordish Police Forces and the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Now it was time to make a speech in the Assembly and declare the emergency in public."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I walked with quick steps in the corridors of the Grand National Assembly, giving my greetings to the people I encountered on my way towards the parliamentary hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[6]`
Mówca: **Narrator**
> "When I entered the hall, the Assembly was in complete chaos, with shouting and cursing between the parties. There was a heavy argument about a proposal made by an MP from NFP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I took my seat inside the special area reserved for the ministers. Gloria was shouting from her seat at the center of the hall as she hit the gavel three times, with each strike heavier than the one before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Gloria Tory**
> "<shout>"ORDER! ORDER!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Despite her efforts, the argument continued for a couple of minutes before everybody took back to their seats and finally went quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Gloria Tory**
> ""Mr. Kibener, next time when I tell you to do so, either take your seat or leave the hall; so we can proceed with the procedures of this Assembly and continue our duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Some MP's from the NFP side shouted back at her in protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Gloria Tory**
> ""Honorable ladies and gentlemen, if you allow me to continue...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[13]`
Mówca: **Gloria Tory**
> ""We have the President here with us today. He has an important declaration to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[14]`
Mówca: **Narrator**
> "I saw Kesaro Kibener standing up from his seat and shouting towards the members of the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Gloria Tory**
> ""Mr. Kibener! Calm yourself! Show respect to the procedures of this Assembly!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[16]`
Mówca: **Narrator**
> "She pointed at me with her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[17]`
Mówca: **Gloria Tory**
> ""The President has the floor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Narrator**
> "The Assembly fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[19]`
Mówca: **Narrator**
> "I walked to the stand as loud clapping started in the USP's side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[197]`
  - -> `[198]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""Ladies and Gentlemen...""]** — Mówca: **Player**
> ""Ladies and Gentlemen of the Grand National Assembly of Sordland! I am here today to present an important decision of the State concerning the recent troubling developments in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[27]`
  - -> `[30]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "Focus on the shooting of Bernard Circas."]** — Mówca: **Player**
> ""Sordland has gone through a critical day on January when Bernard Circas was shot by a militant member of the Young Sords. That day marked the beginning of terror against Sordland and its citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "Focus on the clashes between the Red Youth and Young Sords."]** — Mówca: **Player**
> ""Sordland is going through critical times! The clashes between extremist political organizations have taken their fights to the streets and started threatening the national security of our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "Focus on the Bludish Freedom Front and Rumburg's aid."]** — Mówca: **Player**
> ""Sordland has long been plagued by Bludish separatist groups inside our borders. Their threat, however, has never been greater. They have been heavily arming themselves with military aid from Rumburg against Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Narrator**
> "I brought attention to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[25]`
Mówca: **Narrator**
> "I brought attention to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[37]`
  - -> `[39]`

### Węzeł `[26]`
Mówca: **Narrator**
> "I brought attention to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[37]`
  - -> `[39]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
**[WYBÓR GRACZA: "The threat of the Young Sords and the right wing agenda."]** — Mówca: **Player**
> ""Young Sords and their actions against the public and the State can no longer be tolerated. Thus, the Sordish ultranationalist movement must be regarded as a national security threat from today onwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WYBÓR GRACZA: "The threat of extreme left and right wing groups in Sordland."]** — Mówca: **Player**
> ""Sordland is clearly experiencing a dangerous civil strife between left and right wing extremist groups, which put our citizens lives in danger and act against our State in hopes of toppling our government. Today we find ourselves in a time of emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "The threat of the Red Youth and the left wing agenda."]** — Mówca: **Player**
> ""Red Youth and their actions against the public and the State can no longer be tolerated. Thus, the Sordish communist movement must be regarded as a national security threat from today onwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
**[WYBÓR GRACZA: "The threat of the Bludish separatists."]** — Mówca: **Player**
> ""All Bludish separatist groups and the supporters of Bludish Freedom Front must be regarded as national security threats from today onwards. Sordland can no longer harbour these paramilitary organizations who plans to attack our sovereign nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "The threat of Rumburg."]** — Mówca: **Player**
> ""With the armament of the BFF, Rumburg has shown a clear aggressive stance against Sordland. They pose a major national security threat for our country. We must stay strong and be ready against their treacherous actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[44]`
Mówca: **Narrator**
> "Applauses came from the NFP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[54]`
  - -> `[51]`
  - -> `[60]`

### Węzeł `[45]`
Mówca: **Narrator**
> "Applauses came from the NFP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[54]`
  - -> `[51]`
  - -> `[60]`

### Węzeł `[46]`
Mówca: **Narrator**
> "The opposition members started yelling in protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[54]`
  - -> `[51]`
  - -> `[60]`

### Węzeł `[47]`
Mówca: **Narrator**
> "NFP members started yelling in protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[54]`
  - -> `[51]`
  - -> `[60]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "Blame the Bludish separatists for a plan to occupy Bergia."]** — Mówca: **Player**
> ""On top of that, we have found that the Bludish separatists are planning to occupy the region of Bergia and form a new nation inside our borders. Therefore, the State has decided to take extraordinary measures to handle these threats swiftly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "Blame the communists for a plan to overthrow the government."]** — Mówca: **Player**
> ""On top of that, we have found that the communists are planning to stage a communist revolution in Sordland by toppling our government. Therefore, the State has decided to take extraordinary measures to handle these threats swiftly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "Blame the ultranationalists for a plan to overthrow the government."]** — Mówca: **Player**
> ""On top of that, we have found that the ultranationalists are planning to overthrow our government and bring a totalist maximist state. Therefore, the State has decided to take extraordinary measures to handle these threats swiftly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[60]`
**[WYBÓR GRACZA: "Blame foreign powers for supporting extremist groups."]** — Mówca: **Player**
> ""The foreign powers are to be blamed! They are disrespecting the sovereignty of our nation and agitate and support these extremist groups against our country in hopes of toppling our government to establish a puppet state. The State will now react swiftly to these threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""The police will be given increased authority...""]** — Mówca: **Player**
> ""The police will be given increased authority in regard to their use of force. Searching civilians and orders for confiscations will be permissible beyond their legal limits for the duration of the Emergency period.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[78]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Surveillance capabilities of the State will be increased...""]** — Mówca: **Player**
> ""Surveillance capabilities of the State will be increased beyond their limits until further notice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Suspects will not require a trial to be detained...""]** — Mówca: **Player**
> ""Suspects will not require a trial to be detained if said crime endangers the State and the wellbeing of its citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
**[WYBÓR GRACZA: ""The right to assemble in protest will be suspended...""]** — Mówca: **Player**
> ""The right to assemble in protest will be suspended for the duration of the Emergency. All citizens are expected to abide by the law and the police is given permission to use force against assembled crowds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SpeechHub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[66]`
  - -> `[70]`
  - -> `[87]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Speech_Hub_A == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Speech_Hub_A == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_A_Speech_Hub_A == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Speech_Hub_B == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Speech_Hub_B == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_A_Speech_Hub_B == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Speech_Hub_C == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Speech_Hub_C == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_A_Speech_Hub_C == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Speech_Hub_D == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Speech_Hub_D == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_A_Speech_Hub_D == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Speech_Hub_A || BaseGameIsolated.Turn04_A_Speech_Hub_B || BaseGameIsolated.Turn04_A_Speech_Hub_C || BaseGameIsolated.Turn04_A_Speech_Hub_D == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Speech_Hub_A || BaseGameIsolated.Turn04_A_Speech_Hub_B || BaseGameIsolated.Turn04_A_Speech_Hub_C || BaseGameIsolated.Turn04_A_Speech_Hub_D == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn04_A_Speech_Hub_A || BaseGameIsolated.Turn04_A_Speech_Hub_B || BaseGameIsolated.Turn04_A_Speech_Hub_C || BaseGameIsolated.Turn04_A_Speech_Hub_D == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"]  or  Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[90]`
**[WYBÓR GRACZA: ""In accordance with Article 57...""]** — Mówca: **Player**
> ""In accordance with Article 57 and 58 of the Constitution, the State holds the right to order for these measures to be taken in a situation of emergency like we have today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[91]`
Mówca: **Narrator**
> "There was a loud reaction from the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
Mówca: **Gloria Tory**
> ""The President has not finished!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Gloria hit the gavel again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Mansoun Leke, a Bludish MP, who was regarded as the leader of the independents, jumped from his seat and started shouting at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Mansoun Leke**
> "<shout>"THIS IS TOTALISM!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "Continue with the speech."]** — Mówca: **Player**
> ""These measures, although extraordinary, were completely necessary for us to take. We must be vigilant as a nation in times of crisis and surely we will be triumphant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [SpeechHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[98]`
Mówca: **Narrator**
> "I found a time to take a breather during the loud commotion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[103]`
  - -> `[284]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Speech_Hub_C = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_C"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Speech_Hub_B = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_B"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Speech_Hub_A = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn04_A_Speech_Hub_D = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn04_A_Speech_Hub_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""Can you please be quiet when I'm speaking, Mr. Leke?""]** — Mówca: **Player**
> ""Can you please be quiet when I'm speaking, Mr. Leke?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Narrator**
> "I continued among applauses from the USP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""Ladies and gentlemen of the Assembly! We must set aside our differences.""]** — Mówca: **Player**
> ""Ladies and gentlemen of the Assembly! We must set aside our differences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_None == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_None == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_None"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_None == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_None"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Narrator**
> ""We will be resuming with our foreign policy as usual during this period of Emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[110]`
Mówca: **Narrator**
> ""In accordance with the Emergency Act, Sordland will sever all diplomatic ties with Rumburg for their treacherous actions. We will be responding with an embargo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[117]`
Mówca: **Narrator**
> ""In accordance with the Emergency Act, Sordland will sever all diplomatic ties with United Contana for their treacherous actions. We will be responding with an embargo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[121]`
Mówca: **Narrator**
> ""Same measures will also be taken against United Contana...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[125]`
Mówca: **Narrator**
> ""In accordance with the Emergency Act, Sordland will sever all diplomatic ties with Arcasia for their actions of treason against Sordland. We will be responding with an embargo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[129]`
Mówca: **Narrator**
> ""Same measures will also be taken against Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Narrator**
> ""Sordland will stand alone if needs be. Whatever the case may be, we must be strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[134]`
Mówca: **Narrator**
> ""...And Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[135]`
Mówca: **Narrator**
> ""We must be strong as a nation and preserve our connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Narrator**
> "I paused and took a look at the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[137]`
  - -> `[138]`
  - -> `[139]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Today, we must fight for Sordland!""]** — Mówca: **Player**
> ""Today, we must fight for Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[138]`
**[WYBÓR GRACZA: ""I ask everyone to understand our situation.""]** — Mówca: **Player**
> ""I ask everyone to understand our situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
**[WYBÓR GRACZA: ""We must finally be brave and strike down the red threat!""]** — Mówca: **Player**
> ""We must finally be brave and strike down the red threat!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Narrator**
> "USP seats applauded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[150]`
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
**[WYBÓR GRACZA: ""I ask everybody to be patient.""]** — Mówca: **Player**
> ""I ask everybody to be patient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[152]`
  - -> `[153]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[148]`
**[WYBÓR GRACZA: ""We will fight against the maximists together!""]** — Mówca: **Player**
> ""We will fight against the maximists together!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[152]`
  - -> `[153]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I assure you that this period will not last long.""]** — Mówca: **Player**
> ""I assure you that this period will not last long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""We will eliminate all who oppose the State!""]** — Mówca: **Player**
> ""We will eliminate all who oppose the State!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[152]`
  - -> `[153]`

### Węzeł `[151]`
**[WYBÓR GRACZA: ""We ask for everybody's cooperation and support.""]** — Mówca: **Player**
> ""We ask for everybody's cooperation and support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""The State will swiftly address the situation.""]** — Mówca: **Player**
> ""The State will swiftly address the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[156]`
**[WYBÓR GRACZA: ""The Bludish Issue will finally be addressed!""]** — Mówca: **Player**
> ""The Bludish Issue will finally be addressed!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
**[WYBÓR GRACZA: ""Blud separatists will soon be eradicated!""]** — Mówca: **Player**
> ""Blud separatists will soon be eradicated!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Narrator**
> "I saluted the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`
  - -> `[161]`
  - -> `[162]`

### Węzeł `[159]`
**[WYBÓR GRACZA: ""For a free Sordland!""]** — Mówca: **Player**
> ""For a free Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[160]`
**[WYBÓR GRACZA: ""For a strong Sordland!""]** — Mówca: **Player**
> ""For a strong Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[161]`
**[WYBÓR GRACZA: ""For peace in Sordland!""]** — Mówca: **Player**
> ""For peace in Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[162]`
**[WYBÓR GRACZA: ""For the legacy of Soll!""]** — Mówca: **Player**
> ""For the legacy of Soll!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[163]`
Mówca: **Narrator**
> "The Assembly roared with all kinds of different reactions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Narrator**
> "While most of the USP members applauded, all of the opposition yelled in protest as I left the stand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Narrator**
> "The sounds of protest gradually increased as I walked towards my seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[166]`
Mówca: **Gloria Tory**
> ""Thank you for the announcement, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[167]`
Mówca: **Narrator**
> "Mansoun Leke started yelling at me again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Mansoun Leke**
> "<shout>"YOU ARE JUST LIKE SOLL!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[172]`
Mówca: **Mansoun Leke**
> "<shout>"LEAVE BLUDISH PEOPLE ALONE!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[173]`
Mówca: **Narrator**
> "Kesaro stood up from his seat and walked closer to me and yelled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[177]`
Mówca: **Kesaro Kibener**
> "<shout>"This is a mistake, Mr. President! How dare you target the nationalists?"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Kesaro Kibener**
> "<shout>"Young Sords are a group of people who love their country and Sordish culture! They are not the enemies!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Narrator**
> "Kesaro stood up from his seat and yelled back at Mansoun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Kesaro Kibener**
> "<shout>"YOU LIVE IN SORDLAND, MR. LEKE!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Kesaro Kibener**
> "<shout>"YOU CANNOT FIGHT AGAINST THIS COUNTRY AND EXPECT IT NOT TO REACT!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[185]`
Mówca: **Narrator**
> "Mansoun Leke started yelling at me again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Mansoun Leke**
> "<shout>"Wasn't it enough that the ultranationalists murdered Bernard Circas in cold blood!?"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Mansoun Leke**
> "<shout>"Now you are declaring a war against the left! You are just like Soll, Mr. President!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Mansoun Leke**
> "<shout>"A cold blooded nationalist!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Narrator**
> "Gloria started hitting the gavel again when the situation escalated further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[190]`
Mówca: **Narrator**
> "Kesaro stood up from his seat and yelled back at Mansoun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Kesaro Kibener**
> "<shout>"HOW DARE YOU TALK LIKE THAT IN HERE?"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Kesaro Kibener**
> "<shout>"YOU LIVE IN SORDLAND, MR. LEKE!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[193]`
Mówca: **Gloria Tory**
> "<shout>"ORDER!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Gloria Tory**
> ""Gentlemen, when will you learn to behave like adults?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Narrator**
> "Once I was sure the Assembly's attention was on Gloria, I left the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Narrator**
> "I walked back to the Palace in silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[197]`
**[WYBÓR GRACZA: ""Honorable Members of Assembly...""]** — Mówca: **Player**
> ""Honorable Members of the Grand National Assembly of Sordland! I am here today to present an important decision of the State concerning the recent troubling developments in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[27]`
  - -> `[30]`

### Węzeł `[198]`
**[WYBÓR GRACZA: ""Brothers and sisters...""]** — Mówca: **Player**
> ""Brothers and sisters! I am here today to present an important decision of the State concerning the recent troubling developments in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[27]`
  - -> `[30]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn03_Autocrat_Speech = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_Autocrat_Speech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_A_AutocratSpeech = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_A_AutocratSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_EmergencyDecree = true; BaseGame.Policy_Law_Decree_Stronger = true; BaseGame.Policy_Law_Decree_Default = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Law_EmergencyDecree"] = true;
Variable["BaseGame.Policy_Law_Decree_Stronger"] = true;
Variable["BaseGame.Policy_Law_Decree_Default"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_SomeHumanRights = false; BaseGame.Situation_Law_LimitedHumanRights = true; 
BaseGame.Situation_Law_ExpandedHumanRights = false;

BaseGame.Situation_Order_WideRangingSecurityPowers = true; 
BaseGame.Situation_Order_SomeSecurityPowers = false;
BaseGame.Situation_Order_LittleSecurityPowers = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_SomeHumanRights"] = false;
Variable["BaseGame.Situation_Law_LimitedHumanRights"] = true;
Variable["BaseGame.Situation_Law_ExpandedHumanRights"] = false;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = true;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishOppression = true; 
BaseGame.Policy_Law_Ban_WPB = true;
BaseGameSupport.Report_Turn03_Erzaren_Emergency_BludBanned = true;
BaseGame.Public_Opinion += 1;
BaseGame.Bludish_Opinion -= 5;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishOppression"] = true;
Variable["BaseGame.Policy_Law_Ban_WPB"] = true;
Variable["BaseGameSupport.Report_Turn03_Erzaren_Emergency_BludBanned"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingArcasia = true;
BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingUnitedContana = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingRumburg = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Emergency_AllEmbargo = true; BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia = true; BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_AllEmbargo"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Emergency_AREmbargo = true; BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_AREmbargo"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Emergency_UCAEmbargo = true; BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia = true; BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_UCAEmbargo"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Emergency_UCREmbargo = true; BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_UCREmbargo"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Emergency_ArcasiaEmbargo = true; BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_ArcasiaEmbargo"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_ATO_Emergency_BannedArcasia"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Emergency_RumburgEmbargo = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_RumburgEmbargo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Emergency_UCEmbargo = true; BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_UCEmbargo"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_CSP_Emergency_BannedUC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Emergency_NoEmbargo = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_NoEmbargo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_Emergency_AllBanned = true;
BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned = true; BaseGame.Policy_Law_Ban_WPB = true; BaseGame.Policy_Law_Ban_RedYouth = true;
BaseGame.Policy_Law_Ban_YoungSords = true;
BaseGame.Public_Opinion -= 2;
BaseGame.Bludish_Opinion -= 4;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Emergency_AllBanned"] = true;
Variable["BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned"] = true;
Variable["BaseGame.Policy_Law_Ban_WPB"] = true;
Variable["BaseGame.Policy_Law_Ban_RedYouth"] = true;
Variable["BaseGame.Policy_Law_Ban_YoungSords"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_Emergency_RYBludBanned = true;
BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned = true; BaseGame.Policy_Law_Ban_WPB = true; BaseGame.Policy_Law_Ban_RedYouth = true;
BaseGame.Public_Opinion -= 1;
BaseGame.Bludish_Opinion -= 4;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Emergency_RYBludBanned"] = true;
Variable["BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned"] = true;
Variable["BaseGame.Policy_Law_Ban_WPB"] = true;
Variable["BaseGame.Policy_Law_Ban_RedYouth"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_Emergency_YSBludBanned = true; BaseGame.Policy_Law_Ban_WPB = true; BaseGame.Policy_Law_Ban_YoungSords = true;
BaseGame.Public_Opinion -= 1;
BaseGame.Bludish_Opinion -= 4;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Emergency_YSBludBanned"] = true;
Variable["BaseGame.Policy_Law_Ban_WPB"] = true;
Variable["BaseGame.Policy_Law_Ban_YoungSords"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_Emergency_YSRYBanned = true;
BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned = true; BaseGame.Policy_Law_Ban_RedYouth = true;
BaseGame.Policy_Law_Ban_YoungSords = true;
BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Emergency_YSRYBanned"] = true;
Variable["BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned"] = true;
Variable["BaseGame.Policy_Law_Ban_RedYouth"] = true;
Variable["BaseGame.Policy_Law_Ban_YoungSords"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_Emergency_BludBanned = true; BaseGame.Policy_Law_Ban_WPB = true;
BaseGame.Public_Opinion += 1;
BaseGame.Bludish_Opinion -= 4;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Emergency_BludBanned"] = true;
Variable["BaseGame.Policy_Law_Ban_WPB"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_Emergency_RYBanned = true;
BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned = true; BaseGame.Policy_Law_Ban_RedYouth = true;
BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Emergency_RYBanned"] = true;
Variable["BaseGameSupport.Report_Turn03_Borin_Emergency_RYBanned"] = true;
Variable["BaseGame.Policy_Law_Ban_RedYouth"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_Emergency_YSBanned = true; BaseGame.Policy_Law_Ban_YoungSords = true;
BaseGame.Public_Opinion -= 1;
BaseGame.Bludish_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Emergency_YSBanned"] = true;
Variable["BaseGame.Policy_Law_Ban_YoungSords"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_Emergency_Deal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Emergency_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_Emergency_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Emergency_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_G_Emergency = true;
BaseGameSupport.News_Turn03_R_Emergency = true;
BaseGameSupport.News_Turn03_E_Emergency = true;
BaseGameSupport.Report_Turn03_Holsord_Emergency = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_G_Emergency"] = true;
Variable["BaseGameSupport.News_Turn03_R_Emergency"] = true;
Variable["BaseGameSupport.News_Turn03_E_Emergency"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_Emergency"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[282]`
**[WYBÓR GRACZA: ""On the basis of said Articles, I hereby declare a state of emergency and order the Emergency Act's swift execution.""]** — Mówca: **Player**
> ""On the basis of said Articles, I hereby declare a state of emergency and order the Emergency Act's swift execution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[283]`
**[WYBÓR GRACZA: ""I hereby declare a state of emergency in Sordland!""]** — Mówca: **Player**
> ""I hereby declare a state of emergency in Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[284]`
**[WYBÓR GRACZA: ""Show some respect!""]** — Mówca: **Player**
> ""Show some respect!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_DetentionWithoutTrial = true;
BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Order_DetentionWithoutTrial"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_Authority = true; 
BaseGame.Public_Opinion  -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Order_Authority"] = true;
Variable["BaseGame.Public_Opinion"]  =  - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SuspendedProtests = true; BaseGame.Situation_Order_Prisons_Crowded = true;
BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Order_SuspendedProtests"] = true;
Variable["BaseGame.Situation_Order_Prisons_Crowded"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Democratic -= 3;
BaseGame.Malenyevist -= 1;
BaseGame.Capitalist -= 2;
BaseGame.Sollist += 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 3;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 1;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 3;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_EmergencyDecree == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_EmergencyDecree == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_EmergencyDecree"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_EmergencyDecree == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_EmergencyDecree"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true && BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Sollist += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // End)*
- **Efekt (`userScript`):** `-- End;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_BludishOppression = true;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishReconciliation = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = true;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_LimitedHumanRights = true;
BaseGame.Situation_Law_SomeHumanRights = false;
BaseGame.Situation_Law_ExpandedHumanRights = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_LimitedHumanRights"] = true;
Variable["BaseGame.Situation_Law_SomeHumanRights"] = false;
Variable["BaseGame.Situation_Law_ExpandedHumanRights"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB == true
||
BaseGame.Policy_Law_Ban_RedYouth == true 
|| 
BaseGame.Policy_Law_Ban_YoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB == true
||
BaseGame.Policy_Law_Ban_RedYouth == true 
|| 
BaseGame.Policy_Law_Ban_YoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] == true
 or 
Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true 
 or  
Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Ban_WPB == true
||
BaseGame.Policy_Law_Ban_RedYouth == true 
|| 
BaseGame.Policy_Law_Ban_YoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_WPB"] == true
 or 
Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true 
 or  
Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // End)*
- **Efekt (`userScript`):** `-- End;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger = true; BaseGame.Reform_Law_Decrees_Default = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] = true;
Variable["BaseGame.Reform_Law_Decrees_Default"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Arvory", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Arvory","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Narbel", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Narbel","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Erzaren", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Erzaren","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Valgen", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Valgen","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Vesord", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Vesord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // Emergency Declared)*
- **Efekt (`userScript`):** `-- Emergency Declared;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Morna", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Morna","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Holsord", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Benfi", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Benfi","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Borin", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Borin","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Lachaven", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Lachaven","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Estord", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Estord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Erlory", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Erlory","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyShouting");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyShouting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("VoteRoar");)*
- **Efekt (`userScript`):** `PlaySoundEffect("VoteRoar");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("VoteRoar");)*
- **Efekt (`userScript`):** `PlaySoundEffect("VoteRoar");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplause2");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplause2");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplause2");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplause2");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplause2");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplause2");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyLoud");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyLoud");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplauseShouting");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplauseShouting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
