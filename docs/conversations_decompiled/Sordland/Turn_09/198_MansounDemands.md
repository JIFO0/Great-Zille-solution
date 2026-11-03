# Sordland/Turn09/MansounDemands

- **ID konwersacji:** `198`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/198_MansounDemands.md`
- **Liczba węzłów dialogowych:** 267
- **Liczba wyborów gracza:** 35

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[15]** Mansoun Leke

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Arrest_FetihEjall`
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bill_Turn07_LanguageBill_Signed`
- `BaseGame.Decision_Turn07_BludishRightsMeeting_Accept`
- `BaseGame.Decision_Turn07_BludishRightsMeeting_Reject`
- `BaseGame.Decision_Turn08_VPSelection_Gloria`
- `BaseGame.ErsenCase_Statement_ProSollist`
- `BaseGame.Media_Censored`
- `BaseGame.Policy_Law_AutonomousZoneOfBergia`
- `BaseGame.Policy_Law_Ban_BFP`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Law_Decree_Removed`
- `BaseGame.Policy_Law_Decree_Weaker`
- `BaseGame.Policy_Law_SpecialZoneOfBergia`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_Law_Veto_Removed`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Turn07_Results_Decision_TrySoll`
- `BaseGame.Turn08_Action_Court_GloriaJustice`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bill_Turn07_LanguageBill_Signed`
- `BaseGame.Bill_Turn09_BludishCommission_Signed`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Democratic`
- `BaseGame.Malenyevist`
- `BaseGame.NoUnrest_Mansoun_Deal_Failed`
- `BaseGame.NoUnrest_Mansoun_Deal_Promised`
- `BaseGame.Policy_Law_Ban_BFP`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Law_EducationUnification`
- `BaseGame.Policy_Law_MinorityRights`
- `BaseGame.Policy_Law_ReligiousHarmony`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.Situation_Law_BludishProblem`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Situation_Law_RestrictiononReligious`
- `BaseGame.Sollist`
- `BaseGameSupport.Journal_Turn09_NoUnrest_Decree`
- `BaseGameSupport.Journal_Turn09_NoUnrest_Promise`
- `BaseGameSupport.Journal_Turn09_NoUnrest_Refuse`
- `BaseGameSupport.News_Turn09_HP_BludishRights_Decree`
- `BaseGameSupport.News_Turn09_R_BludishRights_Decree`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[197] Sordland/Turn09/A_Talks** (../Turn_09/197_A_Talks.md), Węzeł `[47]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 11

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.NoUnrest_Mansoun_Deal_Failed`
- `BaseGame.NoUnrest_Mansoun_Deal_Promised`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Sollist`
- `BaseGameSupport.Journal_Turn09_NoUnrest_Decree`
- `BaseGameSupport.Journal_Turn09_NoUnrest_Promise`
- `BaseGameSupport.Journal_Turn09_NoUnrest_Refuse`
- `BaseGameSupport.News_Turn09_HP_BludishRights_Decree`
- `BaseGameSupport.News_Turn09_R_BludishRights_Decree`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[128]` (Paskal Beniwoll): `Variable["BaseGame.NoUnrest_Mansoun_Deal_Promised"] = true; Variable["BaseGame.Bludish_Opinion"] ...`
- Węzeł `[129]` (Paskal Beniwoll): `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] = true; Variable["BaseGame.Policy_Law_M...`
- Węzeł `[133]` (Paskal Beniwoll): `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] = true; Variable["BaseGame.Policy_Law_M...`
- Węzeł `[134]` (Paskal Beniwoll): `Variable["BaseGame.NoUnrest_Mansoun_Deal_Promised"] = true; Variable["BaseGame.Bludish_Opinion"] ...`
- Węzeł `[143]` (Paskal Beniwoll): `Variable["BaseGame.NoUnrest_Mansoun_Deal_Failed"] = true; Variable["BaseGame.Bludish_Opinion"] = ...`
- Węzeł `[144]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Promise"] = true;`
- Węzeł `[145]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Decree"] = true;`
- Węzeł `[146]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Promise"] = true;`
- *...oraz 3 innych węzłów ze skryptami.*

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `197` (*Sordland/Turn09/A_Talks*), Węzeł `[47]`

### Węzeł `[3]`
Mówca: **Mansoun Leke**
> ""As I said earlier, we've been working on this bill for a long time, Mr. President. I've always done my best to represent my people... only to keep getting blocked in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[4]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[5]`
**[WYBÓR GRACZA: ""How can I help you, Mr. Leke?""]** — Mówca: **Player**
> ""How can I help you, Mr. Leke?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[6]`
Mówca: **Mansoun Leke**
> ""But all that we get is disrespect. MPs shouting racial slurs at us, not allowing us to speak. And it's not only the National Front...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[7]`
Mówca: **Mansoun Leke**
> ""Now I can speak freely without Mrs. Tory leading the floor, but the outcome is no different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true || BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_Action_Court_GloriaJustice == true || BaseGame.Decision_Turn08_VPSelection_Gloria == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true  or  Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_Action_Court_GloriaJustice == true || BaseGame.Decision_Turn08_VPSelection_Gloria == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true  or  Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[11]`
Mówca: **Mansoun Leke**
> ""I've always brought my people's concerns to the Assembly and raised my voice whenever our rights were in question. All we ask is that the Assembly at least have a proper discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[12]`
Mówca: **Mansoun Leke**
> ""The Assembly does not take us independents seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[13]`
Mówca: **Mansoun Leke**
> ""I don't even remember a time when Mrs. Tory allowed me to finish a speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[14]`
Mówca: **Mansoun Leke**
> ""We need your help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I understand you, Mr. Leke. This discrimination against you is unacceptable.""]** — Mówca: **Player**
> ""I understand you, Mr. Leke. This discrimination against you is unacceptable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""I don't see what I can do. This is the cold truth of Sordish politics.""]** — Mówca: **Player**
> ""I don't see what I can do. This is the cold truth of Sordish politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
Mówca: **Mansoun Leke**
> ""We can't have the same happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[18]`
Mówca: **Mansoun Leke**
> ""That's where your help would be very valuable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
Mówca: **Mansoun Leke**
> ""I don't think you are taking this issue seriously, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Mansoun Leke**
> ""If you wanted to help, you could do that very easily. You cannot let this vicious cycle run its course. The USP's Bludish voters have high expectations of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Mansoun Leke**
> ""All we need is your support for our bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Narrator**
> "He gestured at the papers that I had received from him earlier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[23]`
Mówca: **Mansoun Leke**
> ""It's time to undo the mistakes of the Sordish state against its citizens. I only ask you to help us make this single step for good instead of staying idle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  or  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  or  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[27]`
Mówca: **Mansoun Leke**
> ""And you, Mr. President, have approved anti-Bludish policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Mansoun Leke**
> ""I know, or want to believe, that you only did this to appease your base.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Mansoun Leke**
> ""I am here to ask you to reconsider your stance. We can make a difference in Sordland. Together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`
  - -> `[32]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""What makes you think that I only had political reasons?""]** — Mówca: **Player**
> ""What makes you think that I only had political reasons?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""I don't believe I've done anything against the Bludish people.""]** — Mówca: **Player**
> ""I don't believe I've done anything against the Bludish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""It's true that I have some regrets over my actions. But how can I help you?""]** — Mówca: **Player**
> ""It's true that I have some regrets over my actions. But how can I help you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist == true && BaseGame.Policy_Law_AutonomousZoneOfBergia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist == true && BaseGame.Policy_Law_AutonomousZoneOfBergia == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true  and  Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ErsenCase_Statement_ProSollist == true && BaseGame.Policy_Law_AutonomousZoneOfBergia == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true  and  Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[36]`
Mówca: **Mansoun Leke**
> ""You banned the only pro-Bludish democratic party in Sordland. For alleged links to the BFF...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[40]`
Mówca: **Mansoun Leke**
> ""Are you aware of the numbers of Bludish people who were arrested because of that decision? Do you know how your police acted against us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn07_LanguageBill_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[50]`
Mówca: **Mansoun Leke**
> ""And you effectively removed our language in Sordland. First from religion, and then from schools.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
Mówca: **Mansoun Leke**
> ""You targeted our faith and banned our language and our priests from the sanctuaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Mansoun Leke**
> ""You targeted our language and banned it in schools.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Mansoun Leke**
> ""What are these laws if not an attempt at cultural genocide?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[54]`
Mówca: **Narrator**
> "He eyed me closely for a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Mansoun Leke**
> ""Then please tell me, Mr. President. What was your motivation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`
  - -> `[31]`

### Węzeł `[56]`
Mówca: **Mansoun Leke**
> ""You did not protect Ishval Ersen and allowed the Court to appoint a ultranationalist as the governor of Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[57]`
Mówca: **Mansoun Leke**
> ""Are you aware of the actions of the governor? How he's oppressing our people? What he's doing in our villages?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[58]`
Mówca: **Mansoun Leke**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Mansoun Leke**
> ""You were not only silent about the racism in this country, you enabled it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[60]`
Mówca: **Mansoun Leke**
> ""We should start by undoing your regrets, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[61]`
Mówca: **Mansoun Leke**
> ""What are these policies if not an attempt to oppress Bludish people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Mansoun Leke**
> ""It is time to undo these mistakes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[72]`
  - -> `[74]`
  - -> `[76]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""The dangerous separatist sentiment in Bergia needed to be curbed.""]** — Mówca: **Player**
> ""The dangerous separatist sentiment in Bergia needed to be curbed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""True, it was political. I couldn't reject such popular requests from the nationalists.""]** — Mówca: **Player**
> ""True, it was political. I couldn't reject such popular requests from the nationalists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
Mówca: **Mansoun Leke**
> ""Dangerous separatist sentiment?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Mansoun Leke**
> ""We only want our rights as proper citizens of this country. But since the founding of this republic, we have only been further disenfranchised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[70]`
Mówca: **Mansoun Leke**
> ""Sometimes it's easier to ignore issues that do not directly affect you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Mansoun Leke**
> ""But this system of Sordland that feeds on the Bludish people's suffering will one day explode.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[72]`
**[WYBÓR GRACZA: ""What are you asking me to do?""]** — Mówca: **Player**
> ""What are you asking me to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""You are right, Mr. Leke. I'm not proud of my decisions.""]** — Mówca: **Player**
> ""You are right, Mr. Leke. I'm not proud of my decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Why should I undo what I did?""]** — Mówca: **Player**
> ""Why should I undo what I did?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
Mówca: **Mansoun Leke**
> ""I thought you would understand. As someone who made it to this position from the farmlands of outer Deyr...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Know your place, Mr. Leke.""]** — Mówca: **Player**
> ""Know your place, Mr. Leke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[77]`
Mówca: **Narrator**
> "Mansoun's eyes hardened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Deyr_Poor == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Mansoun Leke**
> ""I thought you were different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Mansoun Leke**
> ""Maybe I was wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[91]`
  - -> `[76]`

### Węzeł `[83]`
Mówca: **Mansoun Leke**
> ""Then please help us, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true) && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true) && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true) && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[87]`
Mówca: **Mansoun Leke**
> ""Talk to your fellow USP members and put your support behind our bill. Our proposal will give amnesty to those who were falsely arrested for having ties to the democratic Bludish Freedom Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[88]`
Mówca: **Mansoun Leke**
> ""And it will form a Commission for Minority Rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[130]`

### Węzeł `[89]`
Mówca: **Mansoun Leke**
> ""We have a proposal to give amnesty to those who were falsely arrested for having ties to the democratic Bludish Freedom Party. Pass it as a decree. You don't need the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[90]`
Mówca: **Mansoun Leke**
> ""And let us independents form a Commission for Minority Rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[130]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""Yes, you were. And I think our meeting is now over.""]** — Mówca: **Player**
> ""Yes, you were. And I think our meeting is now over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""What do you want me to do?""]** — Mówca: **Player**
> ""What do you want me to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[93]`
Mówca: **Mansoun Leke**
> ""And it will lift the ban on the Bludish Freedom Party. As well as giving amnesty to all who were arrested for having ties to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
**[WYBÓR GRACZA: ""Okay, I'll do it.""]** — Mówca: **Player**
> ""Okay, I'll do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[95]`
Mówca: **Mansoun Leke**
> ""Their families are still waiting for them in Bergia..."'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[96]`
**[WYBÓR GRACZA: ""I don't think I can support this proposal, Mr. Leke.""]** — Mówca: **Player**
> ""I don't think I can support this proposal, Mr. Leke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""I agree with you completely, Mr. Leke. Thank you for representing this noble cause.""]** — Mówca: **Player**
> ""I agree with you completely, Mr. Leke. Thank you for representing this noble cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[98]`
Mówca: **Mansoun Leke**
> ""Our proposal aims to form a Committee for Minority Rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[99]`
Mówca: **Mansoun Leke**
> ""It's not Tarquin Soll's era anymore. It's time we try to clean up the taint he left on our history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[96]`
  - -> `[101]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Exactly. By the way, his trial is next month. You can attend it if you want to.""]** — Mówca: **Player**
> ""Exactly. By the way, his trial is next month. You can attend it if you want to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Decision_TrySoll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Results_Decision_TrySoll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Results_Decision_TrySoll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
**[WYBÓR GRACZA: ""I entirely disagree.""]** — Mówca: **Player**
> ""I entirely disagree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[105]`
Mówca: **Narrator**
> "Mansoun's eyes hardened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[106]`
Mówca: **Mansoun Leke**
> ""Oh, thank you. I will *definitely* be there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[107]`
Mówca: **Mansoun Leke**
> ""Glad to hear it, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[108]`
Mówca: **Narrator**
> "He looked at me with a stolid expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Mansoun Leke**
> ""What is that supposed to mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`
  - -> `[126]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""It's a no, Mr. Leke. I cannot help you.""]** — Mówca: **Player**
> ""It's a no, Mr. Leke. I cannot help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[111]`
**[WYBÓR GRACZA: ""It means stop hurling accusations at me and just tell me what you want.""]** — Mówca: **Player**
> ""It means stop hurling accusations at me and just tell me what you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[112]`
Mówca: **Narrator**
> "He rubbed his chin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Mansoun Leke**
> ""So we have your support?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[119]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true) && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true) && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true) && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""Yes. I'll form the commission and support your bill in the Assembly.""]** — Mówca: **Player**
> ""Yes. I'll form the commission and support your bill in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Yes. I'll form the commission and sign your proposal as a decree.""]** — Mówca: **Player**
> ""Yes. I'll form the commission and sign your proposal as a decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""As much as I want to, I don't think this is the right time. The nationalists would be furious.""]** — Mówca: **Player**
> ""As much as I want to, I don't think this is the right time. The nationalists would be furious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[120]`
Mówca: **Mansoun Leke**
> ""What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[121]`
Mówca: **Mansoun Leke**
> ""It's a no, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`
  - -> `[125]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""It's a no, Mr. Leke. I cannot help you.""]** — Mówca: **Player**
> ""It's a no, Mr. Leke. I cannot help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""This isn't the right time. The nationalists would have my head for this.""]** — Mówca: **Player**
> ""This isn't the right time. The nationalists would have my head for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[124]`
Mówca: **Mansoun Leke**
> ""You're that scared of losing your *racist* voters ahead of the elections?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""I can't help the Bluds while my own people suffer.""]** — Mówca: **Player**
> ""I can't help the Bluds while my own people suffer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""I can't help the Bluds while my own people suffer.""]** — Mówca: **Player**
> ""I can't help the Bluds while my own people suffer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Mansoun Leke**
> ""I never thought you were an ethnonationalist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NoUnrest_Mansoun_Deal_Promised = true;
BaseGame.Bludish_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.NoUnrest_Mansoun_Deal_Promised"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed = true;
BaseGame.Policy_Law_MinorityRights = true;
BaseGame.Policy_Law_Ban_BFP = false;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Bludish_Opinion += 4; BaseGame.Democratic += 2; BaseGame.Malenyevist += 1; BaseGame.Sollist -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] = true;
Variable["BaseGame.Policy_Law_MinorityRights"] = true;
Variable["BaseGame.Policy_Law_Ban_BFP"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 4;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 2;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""I don't think I can help you, Mr. Leke.""]** — Mówca: **Player**
> ""I don't think I can help you, Mr. Leke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Mansoun Leke**
> ""What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[132]`
**[WYBÓR GRACZA: ""Okay, I'll do it.""]** — Mówca: **Player**
> ""Okay, I'll do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn09_BludishCommission_Signed = true;
BaseGame.Policy_Law_MinorityRights = true;
BaseGame.Policy_Law_Ban_BFP = false;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_RestrictiononReligious = false;
BaseGame.Bill_Turn05_ReligiousHarmony_Signed = false;
BaseGame.Bill_Turn07_LanguageBill_Signed = false; BaseGame.Reform_EmergencyDecree_Banned_Bluds = false;
BaseGame.Policy_Law_ReligiousHarmony = false;
BaseGame.Policy_Law_EducationUnification
= false;
BaseGame.Situation_Law_BludishReconciliation = true;
BaseGame.Policy_Law_Ban_WPB = false;
BaseGame.Bludish_Opinion += 4; BaseGame.Democratic += 3; BaseGame.Malenyevist += 1; BaseGame.Sollist -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] = true;
Variable["BaseGame.Policy_Law_MinorityRights"] = true;
Variable["BaseGame.Policy_Law_Ban_BFP"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_RestrictiononReligious"] = false;
Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] = false;
Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] = false;
Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] = false;
Variable["BaseGame.Policy_Law_ReligiousHarmony"] = false;
Variable["BaseGame.Policy_Law_EducationUnification"]
= false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = true;
Variable["BaseGame.Policy_Law_Ban_WPB"] = false;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 4;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 3;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NoUnrest_Mansoun_Deal_Promised = true;
BaseGame.Bludish_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.NoUnrest_Mansoun_Deal_Promised"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[135]`
Mówca: **Mansoun Leke**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Narrator**
> "He rose up and walked up to me. He extended a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Mansoun Leke**
> ""It means a lot. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[139]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[140]`
Mówca: **Narrator**
> "He rose and walked up to me. He extended a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Mansoun Leke**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[142]`
Mówca: **Mansoun Leke**
> ""This means a lot. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NoUnrest_Mansoun_Deal_Failed = true;
BaseGame.Bludish_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.NoUnrest_Mansoun_Deal_Failed"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_NoUnrest_Promise = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Promise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_NoUnrest_Decree = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Decree"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_NoUnrest_Promise = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Promise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_NoUnrest_Decree = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Decree"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_NoUnrest_Refuse = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Refuse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn09_HP_BludishRights_Decree = true; BaseGameSupport.News_Turn09_R_BludishRights_Decree = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_BludishRights_Decree"] = true;
Variable["BaseGameSupport.News_Turn09_R_BludishRights_Decree"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[153]`
Mówca: **Mansoun Leke**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[154]`
**[WYBÓR GRACZA: ""I don't know what you're talking about, Mr. Leke. I had no power over these matters.""]** — Mówca: **Player**
> ""I don't know what you're talking about, Mr. Leke. I had no power over these matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Veto_Removed == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Veto_Removed == true && BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Veto_Removed"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Veto_Removed == true && BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Veto_Removed"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[158]`
Mówca: **Mansoun Leke**
> ""Mr. President, with all due respect, you should have realized removing your veto powers would lead to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Mansoun Leke**
> ""You knew full well the state of the assembly and the direction it would take on its own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[160]`
Mówca: **Mansoun Leke**
> ""By doing nothing, you are enabling the Assembly's bigotry, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Mansoun Leke**
> ""Whether it is intentional or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Mansoun Leke**
> ""However, today, I am giving you a chance to take long-overdue action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[163]`
Mówca: **Narrator**
> "Mansoun took a deep breath, calming himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[164]`
Mówca: **Narrator**
> "As he talked, he tightened his clenched fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_BludishRightsMeeting_Accept == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_BludishRightsMeeting_Accept == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_BludishRightsMeeting_Accept"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn07_BludishRightsMeeting_Accept == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_BludishRightsMeeting_Accept"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Mansoun Leke**
> ""Having said that, there has been a lot of new developments since we last spoke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_BludishRightsMeeting_Reject == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_BludishRightsMeeting_Reject == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_BludishRightsMeeting_Reject"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn07_BludishRightsMeeting_Reject == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_BludishRightsMeeting_Reject"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[172]`
Mówca: **Mansoun Leke**
> ""Having said that, there has been a lot of new developments since you rejected our offer to meet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[176]`
Mówca: **Mansoun Leke**
> ""And the Bludish rights movement is extremely happy with the new changes to the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Mansoun Leke**
> ""Despite failing to change the constitution, I should say that you earned the respect of the Bludish rights movement. I must thank you again for fighting with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Mansoun Leke**
> ""Unfortunately, the lack of cooperation from your side has been enabling the hardline nationalists to get bolder about their racist tirades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[185]`
Mówca: **Mansoun Leke**
> ""Luckily, you approved the new Autonomous Zone of Bergia. This was an historic accomplishment. And I must applaud you for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Mansoun Leke**
> ""On top of all that, you approved the new Autonomous Zone of Bergia. This was an historic accomplishment. And I must applaud you for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[193]`
Mówca: **Mansoun Leke**
> ""On top of all that, you managed to revoke the Special Zone. This was an historic accomplishment. And I must applaud you for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[194]`
Mówca: **Mansoun Leke**
> ""On top of all that, you managed to revoke the Special Zone. Although this was an historic accomplishment, I'm not sure if anything really changed that drastically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Mansoun Leke**
> ""And Governor Bron is still in charge of the Special Zone... Free to continue his oppressive policies against the Bludish community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[205]`
Mówca: **Mansoun Leke**
> ""And an ultranationalist is now governing the Special Zone... Continuing his oppressive policies against the Bludish community behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Mansoun Leke**
> ""But Governor Bron is still in charge of the Special Zone... Free to continue his oppressive policies against the Bludish community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[213]`
Mówca: **Mansoun Leke**
> ""But an ultranationalist is now governing the Special Zone... Continuing his oppressive policies against the Bludish community behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Mansoun Leke**
> ""However, there is still a lot to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[216]`
Mówca: **Mansoun Leke**
> ""And something must be done about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[217]`
Mówca: **Mansoun Leke**
> ""Luckily, we got rid of the governor. This has already helped with decreasing the tensions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist == true && BaseGame.Policy_Law_AutonomousZoneOfBergia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist == true && BaseGame.Policy_Law_AutonomousZoneOfBergia == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true  and  Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ErsenCase_Statement_ProSollist == true && BaseGame.Policy_Law_AutonomousZoneOfBergia == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true  and  Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Mansoun Leke: ""Our proposal aims to form a Commit..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[222]`
Mówca: **Mansoun Leke**
> ""The Bludish community it extremely happy about these developments. You've definitely earned their support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Mansoun Leke**
> ""I came here today to show you our gratitude and thank you again personally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Mansoun Leke**
> ""According to the movement, there is still one more thing to do. We'd appreciate your help on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`
  - -> `[227]`
  - -> `[228]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""How can I help you, Mr. Leke?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course. Just tell me what you need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not sure if I can do more after all I've done for your people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you still have demands? Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Mansoun Leke**
> ""I understand where you're coming from, Mr. President, but please hear us out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Mansoun Leke**
> ""We just want you to undo the mistakes of the Sordish state against Bludish political movements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[237]`
Mówca: **Mansoun Leke**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Mansoun Leke**
> ""After all you've done, is this really such a major thing for you or the nationalists?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Mansoun Leke**
> ""This is very disappointing. But I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Arrest_FetihEjall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Arrest_FetihEjall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Arrest_FetihEjall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[244]`
Mówca: **Narrator**
> "He stopped for a moment and repositioned himself on his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[245]`
Mówca: **Mansoun Leke**
> ""And considering now that I'm representing the Workers Party in the Assembly as its new leader...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Mansoun Leke**
> ""...I have a lot more responsibility against my people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Arrest_FetihEjall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Arrest_FetihEjall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Arrest_FetihEjall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[250]`
Mówca: **Mansoun Leke**
> ""The Assembly does not take the Workers Party seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_AutonomousZoneOfBergia == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_AutonomousZoneOfBergia == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false  and  Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_AutonomousZoneOfBergia == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false  and  Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Mansoun Leke**
> ""Are you aware of the actions of the Minister of Interior? How she's making life difficult for some locals? What her police is doing to our community leaders?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_AutonomousZoneOfBergia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_AutonomousZoneOfBergia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_AutonomousZoneOfBergia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[258]`
Mówca: **Mansoun Leke**
> ""The situation might be better now with the autonomous zone but the history of our people and their memories will remain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_BFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_BFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_BFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_BFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_BFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[262]`
Mówca: **Mansoun Leke**
> ""It will revoke the current ban and allow both the Worker's Party of Bludia and the Bludish Freedom Party into politics once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_BFP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_BFP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_BFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_BFP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_BFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[266]`
Mówca: **Mansoun Leke**
> ""Needless to say, your decree must also revoke the current ban and allow both the Worker's Party of Bludia and the Bludish Freedom Party into politics once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
