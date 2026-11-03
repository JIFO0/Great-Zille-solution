# Sordland/Turn07/A_EconomicDirection

- **ID konwersacji:** `103`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/103_A_EconomicDirection.md`
- **Liczba węzłów dialogowych:** 508
- **Liczba wyborów gracza:** 84

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Autocrat_YoungSords_NFP_Deal`
- `BaseGame.BergiaSpecialZone_Proposal_Amendment`
- `BaseGame.BergiaSpecialZone_Proposal_Centralization`
- `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Decision_Turn05_SPAid_AcceptArcasia`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.EconomicDirection_Nationalization`
- `BaseGame.EconomicDirection_StatusQuo`
- `BaseGame.ErsenCase_Statement_ProBlud`
- `BaseGame.ErsenCase_Statement_ProSollist`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Order_AntiCorruptionPolice`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Diplomacy_West`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Weaker`
- `BaseGame.Reform_Reform_NFP_Convinced`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn07_A_Marcel_OwnershipDeal`
- `BaseGame.Turn07_A_Marcel_Threatened`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.Turn07_MarcelCall_NotListened`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.EconomicDirection_Nationalization`
- `BaseGame.EconomicDirection_Privatization`
- `BaseGame.EconomicDirection_StatusQuo`
- `BaseGame.Situation_Order_Corruption`
- `BaseGame.Situation_Order_CorruptionTackled`
- `BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull`
- `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron`
- `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_ReplacedByCourt`
- `BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Bron`
- `BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Krull`
- `BaseGameSupport.FactionReport_Turn07_CSP_SpySatellite`
- `BaseGameSupport.Journal_Turn07_Nationalization`
- `BaseGameSupport.Journal_Turn07_Privatization`
- `BaseGameSupport.Journal_Turn07_StatusQuo`
- `BaseGameSupport.News_Turn07_G_ArcasiaAtCrossroads`
- `BaseGameSupport.News_Turn07_G_TensionsRise_AgnoliaAlone`
- `BaseGameSupport.News_Turn07_G_TensionsRise_AgnoliaSide`
- `BaseGameSupport.News_Turn07_G_UCValgslandShipsTogether`
- `BaseGameSupport.News_Turn07_HP_ConriatJointDrills`
- `BaseGameSupport.News_Turn07_HP_ErloryJointDrills`
- `BaseGameSupport.News_Turn07_LT_WPBCondemnsCourtDecision`
- `BaseGameSupport.News_Turn07_R_YSWithPolice`
- `BaseGameSupport.News_Turn07_ST_IncreasedSupportForBludishRights`
- `BaseGameSupport.News_Turn07_ST_NewGovernorKrull`
- `BaseGameSupport.Report_Turn07_Anrica_YoungSordsSupportPolice`
- `BaseGameSupport.Report_Turn07_Arvory_ValgslandianNavyActive_AgnoliaAlone`
- `BaseGameSupport.Report_Turn07_Arvory_ValgslandianNavyActive_AgnoliaSide`
- `BaseGameSupport.Report_Turn07_Deyr_GovernorKrullStartsDuty`
- `BaseGameSupport.Report_Turn07_Erzaren_ErsenCase_ProtestAgainstDelay`
- `BaseGameSupport.Report_Turn07_Erzaren_ErsenCase_ProtestAgainstSollistOutcome`
- `BaseGameSupport.Report_Turn07_Holsord_WPB_CondemnsCourtDecision`
- `BaseGameSupport.Report_Turn07_Ribel_ProBludOrDefault_BFFThreatensJustices`
- `BaseGameSupport.Report_Turn07_Ribel_ProSollist_BFFThreatensPresidentAndNFP`
- `BaseGameSupport.Report_Turn07_Ribel_WPBBanned_BFFThreatensPresident`
- `BaseGameSupport.Report_Turn07_Uziren_BFFRecruitmentKrull`
- `GameCondition.Turn07_A_EconomicDirection`
- `GameCondition.Turn07_EnT_Feedback_NationalizationPrivatization`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 8
- **Węzły modyfikujące stan gry:** 31

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Situation_Order_Corruption`
- `BaseGame.Situation_Order_CorruptionTackled`
- `BaseGameSupport.Report_Turn07_Erzaren_ErsenCase_ProtestAgainstSollistOutcome`
- `BaseGameSupport.Report_Turn07_Ribel_ProSollist_BFFThreatensPresidentAndNFP`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[90]` (Lucian Galade): `Variable["BaseGame.EconomicDirection_Nationalization"] = true;`
- Węzeł `[91]` (Lucian Galade): `Variable["BaseGame.EconomicDirection_StatusQuo"] = true;`
- Węzeł `[92]` (Lucian Galade): `Variable["BaseGame.EconomicDirection_Privatization"] = true;`
- Węzeł `[213]` (Lucian Galade): `Variable["GameCondition.Turn07_A_EconomicDirection"] = true;`
- Węzeł `[230]` (Lucian Galade): `Variable["GameCondition.Turn07_EnT_Feedback_NationalizationPrivatization"] = true;`
- Węzeł `[238]` (Lucian Galade): `Variable["BaseGameSupport.Journal_Turn07_Nationalization"] = true;`
- Węzeł `[239]` (Lucian Galade): `Variable["BaseGameSupport.Journal_Turn07_StatusQuo"] = true;`
- Węzeł `[240]` (Lucian Galade): `Variable["BaseGameSupport.Journal_Turn07_Privatization"] = true;`
- *...oraz 23 innych węzłów ze skryptami.*

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
  - -> `[504]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Lucian scheduled some time with me to discuss the potential political repercussions of the upcoming economy meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[4]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
> "“My efforts to ensure a court rejection for the legal arguments put forward by Mr. Ricter are continuing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[8]`
Mówca: **Lucian Galade**
> "“What are you leaning towards? How should we move forward?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[12]`
  - -> `[11]`

### Węzeł `[9]`
Mówca: **Lucian Galade**
> "“It's true, we are in the hornet's nest if we can't get out of this situation. But they want us to seize the assets of the Oligarchs, an action that would drastically alter the power balance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“The Court needs to pass that review for us to continue uninterrupted. The decree must be deemed constitutional. Otherwise, we are weakened.”"]** — Mówca: **Player**
> "“The Court needs to pass that review for us to continue uninterrupted. The decree must be deemed constitutional. Otherwise, we are weakened.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“We will privatize these companies.” [Privatization Path]"]** — Mówca: **Player**
> "“We will privatize these companies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“Our administration will avoid upsetting the economic structure and maintain the status quo.”"]** — Mówca: **Player**
> "“Our administration will avoid upsetting the economic structure and maintain the status quo.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“I have to ask. Why? What is your intention?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[52]`
  - -> `[50]`
  - -> `[51]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“I have to ask. Why? What is your intention?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[65]`
  - -> `[71]`
  - -> `[66]`

### Węzeł `[15]`
Mówca: **Narrator**
> "Lucian took a note in his notebook."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[16]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget >= 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[18]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget >= 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“Changing the ownership of some of these assets would increase our budget even more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
> "“The plan to change the ownership of important assets could help us generate much needed resources to further improve economic development before the next election.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Lucian looked at his watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[22]`
Mówca: **Narrator**
> "He arrived on time as usual and took his seat right across from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Lucian Galade**
> "“Good morning, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Lucian had dark circles below his eyes. The plethora of political developments must've been weighing even on a workaholic like him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“You look a bit tired. Are you getting enough sleep?”"]** — Mówca: **Player**
> "“You look a bit tired. Are you getting enough sleep?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Let's discuss this upcoming meeting.”"]** — Mówca: **Player**
> "“Let's discuss this upcoming meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[27]`
Mówca: **Lucian Galade**
> "“I am trying to, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[28]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Very well.”"]** — Mówca: **Player**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Don't push yourself too much.”"]** — Mówca: **Player**
> "“Don't push yourself too much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
> "“I will try not to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Lucian Galade**
> "“I must say, you don't look much better.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Narrator**
> "I looked at myself in a small hand mirror. Similar circles were beneath my eyes as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Lucian Galade**
> "“I booked some of your time to pre-plan for today's meeting at the Ministry of Economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[34]`
Mówca: **Lucian Galade**
> "“I want to give you a short status update.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
Mówca: **Lucian Galade**
> "“A very important piece in succeeding will be this upcoming economy meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> "“It is well known that the Old Guard wants many of these large companies to be nationalized. If we do that, our chances of the court rejecting Mr. Ricter will increase.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`
  - -> `[40]`

### Węzeł `[37]`
Mówca: **Lucian Galade**
> "“As you know, I've been lobbying the Old Guard extensively after the constitutional review process began to ensure we don't end up in a weakened position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“That makes sense. I will think about it.”"]** — Mówca: **Player**
> "“That makes sense. I will think about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“I won't let the Old Guard decide the future of our country in any way.”"]** — Mówca: **Player**
> "“I won't let the Old Guard decide the future of our country in any way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“I will do what I want. It's as simple as that.”"]** — Mówca: **Player**
> "“I will do what I want. It's as simple as that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
> "“Of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[42]`
Mówca: **Lucian Galade**
> "“While I agree, it doesn't change the fact that if they accept Mr. Ricter's plea, we might be done for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
> "“We would be changing our relationship with the Old Guard, the Oligarchs and the opposition.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Lucian Galade**
> "“We need to be cautious. Any grand plans about the economy also heavily influence our political standing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""As you know, this meeting will give you the opportunity to alter the ownership of the Big Four, the corporations at the center of Sordland's ownership question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[47]`
Mówca: **Lucian Galade**
> "“I personally think we should stay out of this and keep things as they are. There is no need to make new political enemies at this stage in our term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“We will nationalize these companies.” [Nationalization Path]"]** — Mówca: **Player**
> "“We will nationalize these companies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
> "“It's true that the more control we have, the better. Your administration still bears responsibility If we let the Oligarchs determine the course of the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“I cannot allow a major part of the country to run without my input as President. The Oligarchs must submit to me.”"]** — Mówca: **Player**
> "“I cannot allow a major part of the country to run without my input as President. The Oligarchs must submit to me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Truth to be told, I don't care what anyone thinks or says. I will do what I believe in.”"]** — Mówca: **Player**
> "“Truth to be told, I don't care what anyone thinks or says. I will do what I believe in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[52]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_East == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
**[WYBÓR GRACZA: "“If we want to improve our relations with the east, we need to nationalize our economy.”"]** — Mówca: **Player**
> "“If we want to improve our relations with the east, we need to nationalize our economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
> "“It's true that Valgsland would look very favorably on such changes in any upcoming negotiations. And United Contana would see it as a positive step towards a potential membership in the CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[57]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[59]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[60]`
Mówca: **Lucian Galade**
> "“I understand. However, we need to think carefully about the effects of your actions. Especially since the next election is getting closer every day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[61]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_West == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
**[WYBÓR GRACZA: "“If we want to improve our relations with the west, we need to privatize our economy.”"]** — Mówca: **Player**
> "“If we want to improve our relations with the west, we need to privatize our economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“Privatisation will help bring the country out of recession.”"]** — Mówca: **Player**
> "“Privatization will help bring the country out of recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Truth to be told I don't care what anyone thinks or says. I will do what I believe in.”"]** — Mówca: **Player**
> "“Truth to be told I don't care what anyone thinks or says. I will do what I believe in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“I understand, but we need to think carefully about the effects of your actions. Especially with the elections getting closer every day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
> "“That may be true. But taking everything out of state hands may have dire repercussions in a country like ours. We need to think about this carefully.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[69]`
Mówca: **Lucian Galade**
> "“It's true, Lespia would look very favorably on such changes in the upcoming negotiations. Arcasia would see it as a positive step towards membership in the ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“The Oligarchs are powerful. They might aid us in Assembly if we help them.”"]** — Mówca: **Player**
> "“The Oligarchs are powerful. They might aid us in Assembly if we help them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[73]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[74]`
Mówca: **Lucian Galade**
> "“It's good to think strategically like that. But if we make them too powerful, they might end up stabbing us in the back. There might be dire repercussions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
> "“One thing to remember is that since you've been transparent about promoting a planned economy, nationalization will not cost us much support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
> "“I have to remind you that nationalization goes against your initial plans for a market economy. We might lose support because of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
> "“One thing to remember is that since you've been transparent about promoting a market economy, privatization will not cost us much support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[81]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[83]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Lucian Galade**
> "“I have to remind you that privatization goes against your initial plans for a planned economy. We might lose support because of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[85]`
Mówca: **Lucian Galade**
> "“I received a report from the Ministry of Economy that may impact your decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
> "“We have a large government budget available to improve the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
> "“Unfortunately we have missed our government budget targets for the current quarter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> "“It's just something to consider. As is our relationship with the Oligarchs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[89]`
Mówca: **Lucian Galade**
> "“Although I think the Oligarchs would've liked us to privatize everything, maintaining the status quo will not disturb our relationship with them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[90]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.EconomicDirection_Nationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[91]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Privatization = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.EconomicDirection_Privatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[95]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_StatusQuo == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_StatusQuo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Lucian Galade**
> "“We might be aiming for nationalization, but we need to remember that they only care about their own profits.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[100]`
Mówca: **Lucian Galade**
> "“We need to remember that they only care about their own profits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[101]`
Mówca: **Lucian Galade**
> "“Unfortunately, we aren't on good terms with them. This situation has been obstructing some of our efforts in the economic recovery.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
> "“Thankfully, we are on good terms with them for now, which helps us with the economic recovery.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[105]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“Unfortunately, we aren't on good terms with them. This situation has been obstructing some of our efforts with the economic recovery.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[107]`
Mówca: **Lucian Galade**
> "“Thankfully, we are on good terms with them for now, which helps us with the economic recovery.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[108]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[111]`
Mówca: **Lucian Galade**
> "“Excellent. This is the safest way to victory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[112]`
Mówca: **Lucian Galade**
> "“This means more stability. Both economically and politically.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[113]`
Mówca: **Lucian Galade**
> "“If our nationalization plan hurts their assets too much, it can put us at odds with the men who control much of the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[114]`
Mówca: **Lucian Galade**
> "“Walter Tusk seems to be organizing several opposing centrist and liberal Assembly members to back us in the upcoming vote. If we maintain our standing with him, our reforms process will benefit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`
  - -> `[123]`

### Węzeł `[115]`
Mówca: **Lucian Galade**
> "“Walter Tusk seems to be organizing several opposing conservative and nationalist Assembly members to back us in the upcoming vote. If we maintain our standing with him, our reforms process will benefit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`
  - -> `[123]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“We don't want the Lotherberg Group to be our enemies. It'll endanger our re-election.”"]** — Mówca: **Player**
> "“We don't want the Lotherberg Group to be our enemies. It'll endanger our re-election.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[117]`
**[WYBÓR GRACZA: "“If we nationalize only a part of their companies, perhaps we can avoid confrontation.”"]** — Mówca: **Player**
> "“If we nationalize only a part of their companies, perhaps we can avoid confrontation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“It's good to know that Tusk is actively supporting our administration.”"]** — Mówca: **Player**
> "“It's good to know that Tusk is actively supporting our administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“It's all a show. He and the others won't lift a finger without clear benefit. Besides, we don't need them.”"]** — Mówca: **Player**
> "“It's all a show. He and the others won't lift a finger without clear benefit. Besides, we don't need them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[120]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[122]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "“I'm confident that we will overcome the next hurdle without his help.”"]** — Mówca: **Player**
> "“I'm confident that we will overcome the next hurdle without his help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[124]`
Mówca: **Lucian Galade**
> "“Walter Tusk seems to be organizing several centrist Assembly members to pressure the court on behalf. If we maintain our standing with him, it might positively influence the court decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`
  - -> `[123]`

### Węzeł `[125]`
Mówca: **Lucian Galade**
> "“If our nationalization plan hurts their assets too much, we may end up at war with the men who control much of the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`
  - -> `[130]`

### Węzeł `[126]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[128]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
> "“Yes, that's the only kind of nationalization they'd accept. I am sure that Tusk will have further requests afterwards, though.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“The Oligarchs must be destroyed. Seizing their assets is the way to go.”"]** — Mówca: **Player**
> "“The Oligarchs must be destroyed. Seizing their assets is the way to go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Lucian Galade**
> "“Just be careful with him. Remember, any path we take here could very well determine what battles we fight in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[132]`
Mówca: **Lucian Galade**
> "“The only way to avoid being damaged by such a dramatic action is a swift surprise takeover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[133]`
Mówca: **Lucian Galade**
> "“Indeed. They have their hands in many pockets, and the last thing we want is another powerful force to fight when our main goal should be to maintain public opinion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[134]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[136]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“To save our country from recession, privatization is a must.”"]** — Mówca: **Player**
> "“To save our country from recession, privatization is a must.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[138]`
Mówca: **Lucian Galade**
> "“Walter Tusk seems be organising several opposing centrist and liberal Assembly members to back us in the upcoming vote. If we maintain our standing with him, our reforms process will benefit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`
  - -> `[146]`

### Węzeł `[139]`
Mówca: **Lucian Galade**
> "“Walter Tusk seems be organizing several opposing conservative and nationalist Assembly members to back us in the upcoming vote. If we maintain our standing with him, our reforms process will benefit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`
  - -> `[146]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "“If we privatize only a part of their companies, perhaps we can get out of this unscratched.”"]** — Mówca: **Player**
> "“If we privatize only a part of their companies, perhaps we can get out of this unscratched.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“It's good to know that Tusk is actively supporting our administration.”"]** — Mówca: **Player**
> "“It's good to know that Tusk is actively supporting our administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "“It's all a show. He and the others won't lift a finger without clear benefit. Besides, we don't need them in the future.”"]** — Mówca: **Player**
> "“It's all a show. He and the others won't lift a finger without clear benefit. Besides, we don't need them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[143]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[145]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[146]`
**[WYBÓR GRACZA: "“I'm confident that we will overcome the next hurdle without his help.”"]** — Mówca: **Player**
> "“I'm confident that we will overcome the next hurdle without his help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[147]`
Mówca: **Lucian Galade**
> "“Walter Tusk seems be organising several centrist Assembly members to pressure the court on behalf. If we maintain our standing with him, it might positively influence the court decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`
  - -> `[146]`

### Węzeł `[148]`
Mówca: **Lucian Galade**
> "“As I mentioned, we need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
> "“That would certainly be a wise compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[150]`
Mówca: **Lucian Galade**
> "“Just be careful with him. Remember, any path we take here could very well determine what battles we fight in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[151]`
Mówca: **Lucian Galade**
> "“If we implement a privatization plan, it will boost our relationship even further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[152]`
Mówca: **Lucian Galade**
> "“However, if we implement a privatization plan, they would surely be delighted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Lucian Galade**
> "“Still, we need to make sure that we don't go overboard with it. If we do, we might lose our base both in the USP and among the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[140]`
  - -> `[137]`

### Węzeł `[154]`
Mówca: **Lucian Galade**
> "“Some of my connections indicate that there seems to be a contest for leadership in the Lotherberg Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Lucian Galade**
> "“Speaking of stability...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[156]`
Mówca: **Lucian Galade**
> "“It looks like Marcel Koronti is making moves to become the key figure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Lucian Galade**
> "“Koronti probably wants his father's seat as the head of the Group and Tusk doesn't want to let go of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[158]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[160]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_StatusQuo == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_StatusQuo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_Nationalization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_Nationalization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
Mówca: **Lucian Galade**
> "“Because we are going down the path of nationalization, we will have the power to tip the balance towards either side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[165]`
Mówca: **Lucian Galade**
> "“It's a significant power struggle considering these are the heads of Sordland's two largest private corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[166]`
Mówca: **Lucian Galade**
> "“If we over-privatize our state owned companies, the Sordish State Corporation and Nedam Mining Group, it could result in the balance tipping to one side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[167]`
Mówca: **Lucian Galade**
> "“Another reason why I am supporting your decision to leave the situation as it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[168]`
Mówca: **Lucian Galade**
> "“Since you have already made the decision to nationalize, you need to be decisive in your follow-up actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[169]`
Mówca: **Lucian Galade**
> "“They would fight over buying up shares and cause chaos.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Lucian Galade**
> "“Since you have already made the decision to privatize, you need to be decisive in your follow-up actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[171]`
Mówca: **Lucian Galade**
> "“Our relationship with Walter Tusk hasn't been good so far. Any move we make now has to be calculated and thought through.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[172]`
Mówca: **Lucian Galade**
> "“Our relationship with Walter Tusk has been very strong so far and we have the backing of the Oligarchs thanks to that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[173]`
Mówca: **Lucian Galade**
> "“Did Marcel or Tusk contact you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
**[WYBÓR GRACZA: "“I received a call from Marcel.”"]** — Mówca: **Player**
> "“I received a call from Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[175]`
**[WYBÓR GRACZA: "“No, they haven't.”"]** — Mówca: **Player**
> "“No, they haven't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[176]`
Mówca: **Lucian Galade**
> "“What did he ask for?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[268]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Lucian Galade**
> "“Strange.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[178]`
**[WYBÓR GRACZA: "“Don't worry. I have it under control.”"]** — Mówca: **Player**
> "“Don't worry. I have it under control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[179]`
Mówca: **Narrator**
> "Lucian gave me a long, measured look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[180]`
Mówca: **Lucian Galade**
> "“I was sure one of them would contact you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[181]`
**[WYBÓR GRACZA: "“He wanted to make a deal to leave HOS untouched.”"]** — Mówca: **Player**
> "“He wanted to make a deal to leave HOS untouched.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Lucian Galade**
> "“And then?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[189]`
  - -> `[200]`
  - -> `[201]`

### Węzeł `[183]`
Mówca: **Lucian Galade**
> "“Mr. President, if you are not transparent with me, I can't help you to the best of my ability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Lucian Galade**
> "“Very well, sir. I won't push you further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[185]`
**[WYBÓR GRACZA: "“I threatened him with nationalization in return for his support. It worked.”"]** — Mówca: **Player**
> "“I threatened him with nationalization in return for his support. It worked.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[186]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_A_Marcel_OwnershipDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_A_Marcel_OwnershipDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_A_Marcel_OwnershipDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[188]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_A_Marcel_OwnershipDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_A_Marcel_OwnershipDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[189]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_A_Marcel_Threatened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_A_Marcel_Threatened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_A_Marcel_Threatened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_A_Marcel_Threatened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_A_Marcel_Threatened"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[192]`
**[WYBÓR GRACZA: "“He threatened me, so I told him I'm taking him down.”"]** — Mówca: **Player**
> "“He threatened me, so I told him I'm taking him down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[193]`
Mówca: **Lucian Galade**
> "“Well done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Lucian Galade**
> "“I hope he will keep his word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[195]`
Mówca: **Lucian Galade**
> "“You did what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Lucian Galade**
> "“Never mind whatever I said before. This changes everything.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Lucian Galade**
> "“Marcel Koronti is too dangerous and too powerful to have as an enemy. We need to take him down now or we might not get another chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Lucian Galade**
> "“Mr. President. We need to nationalize HOS.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[199]`
Mówca: **Lucian Galade**
> "“Otherwise, we might not stand a chance of re-election.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[200]`
**[WYBÓR GRACZA: "“I said I'd think about it.”"]** — Mówca: **Player**
> "“I said I'd think about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[201]`
**[WYBÓR GRACZA: "“Don't worry about it. I have it all under control.”"]** — Mówca: **Player**
> "“Don't worry about it. I have it all under control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Lucian Galade**
> ""All right, sir. I trust you that you will make the best decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Lucian Galade**
> "“Was that all that he wanted?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[231]`

### Węzeł `[205]`
**[WYBÓR GRACZA: "“Yes, that was it.”"]** — Mówca: **Player**
> "“Yes, that was it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[206]`
**[WYBÓR GRACZA: "“He also wants me to nationalize Bergia Steel to take down Tusk.”"]** — Mówca: **Player**
> "“He also wants me to nationalize Bergia Steel to take down Tusk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Lucian Galade**
> "“As I expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[208]`
Mówca: **Lucian Galade**
> "“All right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Lucian Galade**
> "“At any rate, this internal conflict among the Oligarchs puts us in an interesting position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[210]`
Mówca: **Lucian Galade**
> "“And we need to do it quickly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[211]`
Mówca: **Lucian Galade**
> "“Very well then. It's almost time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Lucian Galade**
> "“I will inform Mr. Holl of your decision and he will make the necessary preparations to formulate a plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[213]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_A_EconomicDirection = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_A_EconomicDirection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[214]`
Mówca: **Lucian Galade**
> "“We can start the process of nationalization or privatization, or we can just keep the status quo.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[215]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_StatusQuo == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_StatusQuo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[218]`
Mówca: **Lucian Galade**
> "“Very well then. I'll cancel the meeting since we are not taking any actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[219]`
Mówca: **Lucian Galade**
> "“I am glad you have made this decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[220]`
Mówca: **Narrator**
> "Lucian got up from his chair and left the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[221]`
Mówca: **Lucian Galade**
> "“I must get back to work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[222]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[224]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_StatusQuo == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_StatusQuo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[225]`
Mówca: **Lucian Galade**
> "“There is no reason for us to interfere, directly or indirectly, in their internal struggles.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[226]`
Mówca: **Lucian Galade**
> "“Thank you for your time, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[227]`
Mówca: **Lucian Galade**
> "“Again, I remind you that any change will tip an already-fragile balance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[228]`
Mówca: **Lucian Galade**
> "“But ultimately, the decision is yours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[229]`
Mówca: **Lucian Galade**
> "“I must get back to work now. See you at the next meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[230]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn07_EnT_Feedback_NationalizationPrivatization = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn07_EnT_Feedback_NationalizationPrivatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[231]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[233]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
**[WYBÓR GRACZA: "“He also wants me to give him the shares from privatization to lower Tusk's influence.”"]** — Mówca: **Player**
> "“He also wants me to give him the shares from privatization to lower Tusk's influence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[235]`
Mówca: **Lucian Galade**
> "“Indeed. They have their hands in many pockets, and the last thing we want is another powerful force to fight when our main goal should be to maintain public opinion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[236]`
**[WYBÓR GRACZA: "“We don't want the Lotherberg Group to be our enemies. It'll endanger our re-election.”"]** — Mówca: **Player**
> "“We don't want the Lotherberg Group to be our enemies. It'll endanger our re-election.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[237]`
Mówca: **Lucian Galade**
> "“This internal conflict among the Oligarchs puts us in an interesting position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[238]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Nationalization = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Nationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[239]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_StatusQuo = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_StatusQuo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[240]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn07_Privatization = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Privatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[241]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Arvory_ValgslandianNavyActive_AgnoliaSide = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Arvory_ValgslandianNavyActive_AgnoliaSide"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[245]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Arvory_ValgslandianNavyActive_AgnoliaAlone = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Arvory_ValgslandianNavyActive_AgnoliaAlone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[246]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[248]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[251]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[252]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_HP_ErloryJointDrills = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_ErloryJointDrills"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_HP_ConriatJointDrills = true; BaseGameSupport.News_Turn07_G_UCValgslandShipsTogether = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_ConriatJointDrills"] = true;
Variable["BaseGameSupport.News_Turn07_G_UCValgslandShipsTogether"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_G_TensionsRise_AgnoliaSide = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_G_TensionsRise_AgnoliaSide"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_G_TensionsRise_AgnoliaAlone = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_G_TensionsRise_AgnoliaAlone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[259]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.FactionReport_Turn07_CSP_SpySatellite = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn07_CSP_SpySatellite"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[260]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_Corruption = false;
BaseGame.Situation_Order_CorruptionTackled = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_Corruption"] = false;
Variable["BaseGame.Situation_Order_CorruptionTackled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: // End)*
- **Efekt (`userScript`):** `-- End;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[265]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_MarcelCall_NotListened == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_MarcelCall_NotListened == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_MarcelCall_NotListened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[267]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_MarcelCall_NotListened == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_MarcelCall_NotListened"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[268]`
**[WYBÓR GRACZA: "“I stopped him before he could say anything.""]** — Mówca: **Player**
> "“I stopped him before he could say anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Lucian Galade**
> "“Not involving ourselves in The Oligarchs businesses will save us from potential headaches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Lucian Galade**
> "“But with the decisions, we're about to make today. I doubt that we can stay neutral for long. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[271]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.EconomicDirection_StatusQuo == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[273]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.EconomicDirection_StatusQuo == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_StatusQuo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[274]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[276]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[277]`
Mówca: **Lucian Galade**
> "“But before going into the economic direction, I want to give you a short status update.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[280]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.ErsenCase_Statement_ProBlud == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[283]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.ErsenCase_Statement_ProSollist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[284]`
Mówca: **Lucian Galade**
> ""After your supportive statements of Ishval Ersen together with Mr. Ricter, the Supreme Court decided not to act at all, and delayed the case until further notice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[285]`
Mówca: **Lucian Galade**
> ""Moreover, the Bludish community in Bergia is getting increasingly restless over this topic. Nobody knows how long they'll keep delaying the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Lucian Galade**
> ""This, of course, allows Governor Bron to keep his seat and continue his resettlement policies in Bergia, among others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`
  - -> `[304]`

### Węzeł `[287]`
Mówca: **Lucian Galade**
> ""I'm afraid Chief Justice Hawker seems to be protecting Governor Bron from persecution. This will only increase tensions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Lucian Galade**
> ""Antagonizing him before the vote for the constitution was perhaps not the best idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[289]`
Mówca: **Lucian Galade**
> ""After you and Mr. Kibener made your statement in support of Sollist constitutionalism, the Supreme Court prioritized the case and quickly announced a verdict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Lucian Galade**
> ""It was very clever of you to use Sollism against them. They couldn't afford to look like hypocrites, so they must have moved on it very quickly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Lucian Galade**
> ""The Court ruled that Phelix Bron is to be relieved from his position as governor for abusing his powers to discriminate against Sordish citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Lucian Galade**
> ""He is banned from serving in any political positions in the future and will be charged with a fine of five million Sordish Ren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[293]`
Mówca: **Lucian Galade**
> ""However, the Court has also rejected Ersen's arguments about the Constitution, ruling that all citizens of Sordland are Sords regardless of ethnicity and are completely equal before the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Lucian Galade**
> ""The results received a mixed response from the Bludish community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Lucian Galade**
> ""The resettlements policies of Bergia are ruled to be unconstitutional and have been revoked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[296]`
Mówca: **Lucian Galade**
> ""Activists, radicals and BFF sympathizers have condemned the ruling. However, the majority seems to recognize that justice has been served.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`
  - -> `[311]`

### Węzeł `[297]`
Mówca: **Lucian Galade**
> ""We've just received word about the case of Ishval Ersen. The Supreme Court has decided not to act at all, and delayed the case indefinitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Lucian Galade**
> ""I'm afraid Chief Justice Hawker seems to be protecting Governor Bron from persecution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[299]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[301]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is very troubling. Do you have any idea how we can proceed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Ms. Morgna was right about how extreme Mr. Hawker's opinions were. I should have known this would be the outcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Orso Hawker is going too far with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Lucian Galade**
> ""There was nothing you could do, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[306]`
Mówca: **Lucian Galade**
> ""He is. That's why taking away the Court's authority with our proposal was our highest priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Lucian Galade**
> ""I don't think there is anything we can do about it at this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Lucian Galade**
> ""Our strategy should be to get public opinion behind us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sollist or not, this is good news. Bergia will finally be free from Governor Bron's racist rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What more do these *activists* want? They only want to see the bad side of everything. Maybe Soll wasn't so wrong about his policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for informing me, Lucian. Do you have any idea on how we proceed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[312]`
Mówca: **Lucian Galade**
> ""I agree, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[313]`
Mówca: **Lucian Galade**
> ""As long as we can ride the aftermath of these results to our advantage, the fringe of Bludish society won't matter for us. They can't affect the vote too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[314]`
Mówca: **Lucian Galade**
> ""I don't think there's anything we need to do at this moment, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Lucian Galade**
> ""There is one more important detail. The seat of Governor of Bergia must be filled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Lucian Galade**
> ""Normally, the President appoints the Governor of the Special Zone directly. I'm afraid despite Ms. Morgna's protests, the Court decided to take a completely different route on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Lucian Galade**
> ""Mr. Hawker argued that a premature departure of a governor during their term is an exceptional case. They ruled that the deputy of Governor Bron will assume his duty until the end of the term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[318]`
Mówca: **Lucian Galade**
> ""Mr. Kibener might have played you, unfortunately. The deputy in question -- Mr. Krull -- is a member of the NFP. I'm afraid the Court delivered Bergia straight into the NFP's hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[320]`
  - -> `[321]`
  - -> `[322]`

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What!? How can they just decide to do that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm really questioning Ms. Morgna's advice on this now. She should have seen this coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is very bad news. What do we do now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Screw Hawker! Screw Kibener! This whole system is broken!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Lucian Galade**
> ""And thanks to you, we are doing our best to fix it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[324]`
Mówca: **Lucian Galade**
> ""She's a competent woman, but she keeps underestimating the Old Guard. Her naive idealism gets the better of her at times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Lucian Galade**
> ""Unfortunately, there's nothing we can do about it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Lucian Galade**
> ""Luckily, Mr. Krull will not be able to resume any of his predecessor's unconstitutional activities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[327]`
Mówca: **Lucian Galade**
> ""Of course, giving such a powerful position to a far-right nationalist is still very concerning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Centralization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Centralization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[330]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Centralization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[333]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[334]`
Mówca: **Lucian Galade**
> ""Luckily, Ms. Graf is already working on the revocation of the Special Zone in Bergia. We may still be able to get rid of Mr. Krull that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[335]`
Mówca: **Lucian Galade**
> ""Luckily, Ms. Morgna is already working on the semi-autonomous zone in Bergia. We may still be able to get rid of Mr. Krull that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[336]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Centralization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Centralization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[338]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Centralization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[339]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[341]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[342]`
Mówca: **Lucian Galade**
> ""It would likely be ready after the vote for the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[343]`
Mówca: **Lucian Galade**
> ""Luckily, Ms. Graf is already working on the revocation of the Special Zone in Bergia. We may still be able to get rid of the governor that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[344]`
Mówca: **Lucian Galade**
> ""Luckily, Ms. Morgna is already working on the semi-autonomous zone in Bergia. We may still be able to get rid of the governor that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Lucian Galade**
> ""You'd be free to enact it then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`
  - -> `[390]`
  - -> `[391]`

### Węzeł `[346]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`
  - -> `[348]`

### Węzeł `[347]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[348]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Weaker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Weaker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[351]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Weaker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[352]`
Mówca: **Lucian Galade**
> ""However... There might be a problem with its timing. It would likely only be ready after the vote for the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[353]`
Mówca: **Lucian Galade**
> ""If the vote succeeds as we've been working for, we'd be removing all of your authority to enact presidential decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Lucian Galade**
> ""I'm afraid you'll need the approval of the Assembly in that scenario.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[355]`
Mówca: **Lucian Galade**
> ""And I doubt they'll support any change to Mr. Bron's special authority. He's been a very important member of the party, as well as an important... fundraiser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[381]`
  - -> `[382]`

### Węzeł `[356]`
Mówca: **Lucian Galade**
> ""However... There might be a problem with its timing. It would likely only be ready after the vote for the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Lucian Galade**
> ""If the vote succeeds as we've been working for, your limited decree powers won't be enough to enact a change this grand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[358]`
Mówca: **Lucian Galade**
> ""As hesitant as I am to support your decision to include changes to Article 6 and 7 in your proposal at this stage, it might allow us to bring him to justice, if the vote succeeds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Lucian Galade**
> ""Ms. Morgna has informed me that most of the work on the wording is already done and she had reached out to the representatives of the Bludish community to get their input.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
Mówca: **Lucian Galade**
> ""If you are insistent on adding this change to our proposal, we can discuss this in detail when the representatives arrive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`
  - -> `[431]`
  - -> `[432]`
  - -> `[438]`

### Węzeł `[361]`
Mówca: **Lucian Galade**
> ""It would likely be ready after the vote for the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Lucian Galade**
> ""You'd be free to enact it then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[411]`
  - -> `[412]`

### Węzeł `[363]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[365]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Weaker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Weaker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[368]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Weaker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[369]`
Mówca: **Lucian Galade**
> ""However... There might be a problem with its timing. It would likely be ready after the vote for the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Lucian Galade**
> ""If the vote succeeds as we've been working for, we'd be removing all of your authority to enact presidential decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[371]`
Mówca: **Lucian Galade**
> ""However... There might be a problem with its timing. It would likely be ready after the vote for the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[372]`
Mówca: **Lucian Galade**
> ""If the vote succeeds as we've been working for, your limited decree powers won't be enough to enact a change this grand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[373]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BergiaSpecialZone_Proposal_Amendment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[375]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.BergiaSpecialZone_Proposal_Amendment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[376]`
Mówca: **Lucian Galade**
> ""Unfortunately, changing Articles 6 and 7 is no longer a possibility. After your statements to pressure the Court, the mood has shifted quite a bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Lucian Galade**
> ""But there is not much we can do about it at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`
  - -> `[414]`
  - -> `[415]`

### Węzeł `[378]`
Mówca: **Lucian Galade**
> ""Ms. Morgna has informed me that the Bludish movement has pulled their support from the committee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[445]`
  - -> `[446]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is very disappointing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is ridiculous. Tell her to work faster. It needs to be finished before the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sure we can find a way to convince the party by then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well... who knows whether our reforms will pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[383]`
Mówca: **Lucian Galade**
> ""For the sake of our administration, I certainly hope they do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[384]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[385]`
Mówca: **Lucian Galade**
> ""I'll tell her immediately after our meeting, sir. But I don't think it will make any difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[386]`
Mówca: **Lucian Galade**
> ""The representatives of the Bludish community -- namely Mansoun Leke and Fetih Ejall -- have just informed me that they wish to meet with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[387]`
Mówca: **Lucian Galade**
> ""They also wanted me to relay their surprise and support for your statement in defense of Ishval Ersen. After all, not every USP president calls the constitution racist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[388]`
Mówca: **Lucian Galade**
> ""This might have made them soften up to you. If you accept the meeting, it would be the first ever meeting between the WPB and a standing president. A major event for their community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Great news. Tell her I'm grateful for her work on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for letting me know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good to know. I'm looking forward to signing it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[392]`
Mówca: **Lucian Galade**
> ""We should use every future opportunity we get to increase our standing with the Bludish community. They may have a considerable influence on the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`
  - -> `[395]`

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not doing this for the elections, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for the input.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't think their influence is large enough for us to care.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[396]`
Mówca: **Lucian Galade**
> ""Their numbers are not that large, but they might make a critical difference if we lose the favor of the general public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[397]`
Mówca: **Lucian Galade**
> ""But I agree, sir. Flirting with the Bludish community only results in more loss from the nationalists. We cannot afford to do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[399]`
Mówca: **Lucian Galade**
> ""There is one more thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[400]`
Mówca: **Lucian Galade**
> ""I am not sure exactly which topics they want to bring up. But we can talk about that later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`
  - -> `[423]`
  - -> `[424]`

### Węzeł `[401]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[402]`
Mówca: **Lucian Galade**
> ""I'm afraid you won't be able to enact this change without the approval of the Assembly in that scenario.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[403]`
Mówca: **Lucian Galade**
> ""It will be very hard to convince them to revoke the Special Zone. But with Mr. Bron -- an important fundraiser for the USP -- gone, the party may be willing to move against Governor Krull.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`
  - -> `[405]`
  - -> `[406]`
  - -> `[441]`

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is ridiculous. Tell her to work faster. It needs to be finished before the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sure we can find a way to convince the party by then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[406]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well... It's not certain our reforms will pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[407]`
Mówca: **Lucian Galade**
> ""We have to make sure that doesn't happen for the sake of our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[408]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[409]`
Mówca: **Lucian Galade**
> ""I'll tell her immediately after our meeting, sir. But I don't think that will make any difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Great news. Tell her I'm grateful for her work on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for letting me know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good to know. I'm looking forward to signing it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is worrying. We must look to other ways to increase our standing with our Bludish community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't think this is a negative result. I'm sure Mr. Krull will do a good job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[415]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is bad news, Lucian. This was not my intention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[416]`
Mówca: **Lucian Galade**
> ""We'll congratulate him when he assumes office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[417]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[418]`
Mówca: **Lucian Galade**
> ""There's no use pondering on the past, sir. We can still find other ways to help the Bludish community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[419]`
Mówca: **Lucian Galade**
> ""There is one more thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[420]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[421]`
Mówca: **Narrator**
> "He took a look at his watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[422]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sure this is a positive development. I'd be happy to meet them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you think I should accept their meeting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't want to be seen with them right before the vote. This can be detrimental for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[425]`
Mówca: **Lucian Galade**
> ""It holds some risk, it's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[426]`
Mówca: **Lucian Galade**
> ""They haven't officially reached out yet. When they do, it will be up to you whether you want to listen to them or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[427]`
Mówca: **Lucian Galade**
> ""I'll let them know, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[428]`
Mówca: **Lucian Galade**
> ""It might be risky being seen with the leader of the WPB before the vote, but it's worth hearing them out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[429]`
Mówca: **Lucian Galade**
> ""I don't think we should outright ignore our Bludish community. However, I have to note that this is a very risky move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's great news. I'm looking forward to discussing the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So you don't approve of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not completely sure if I'm going to add that to the proposal yet. I'll decide on the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[433]`
Mówca: **Lucian Galade**
> ""Understood, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[434]`
Mówca: **Lucian Galade**
> ""I'm afraid it would be almost impossible to pass this change. I don't think it is worth tanking our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[435]`
Mówca: **Lucian Galade**
> ""It is still not too late to cancel the meeting. But if you do decide to meet them, I'll be there to discuss everything in detail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[436]`
Mówca: **Lucian Galade**
> ""No harm done, sir. It would have been impossible to pass our reforms with these.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[437]`
Mówca: **Lucian Galade**
> ""For now, let's return back to the real reason we are here. Our economic direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Who will be representing the movement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[439]`
Mówca: **Lucian Galade**
> ""Mr. Leke and Mr. Ejall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[440]`
Mówca: **Lucian Galade**
> ""I'm afraid it will be very bad press to be seen with the current and former leaders of the WPB.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We should paint Mr. Krull as a threat to the party's rule. I believe we can take advantage of partisanship and get them behind us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[442]`
Mówca: **Lucian Galade**
> ""Of course. That's a clever strategy, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[443]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron = false;
BaseGame.Bergia_Governor_Krull = true;
BaseGameSupport.News_Turn07_ST_NewGovernorKrull = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Bergia_Governor_Bron"] = false;
Variable["BaseGame.Bergia_Governor_Krull"] = true;
Variable["BaseGameSupport.News_Turn07_ST_NewGovernorKrull"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[444]`
Mówca: **Lucian Galade**
> ""You can always reject their meeting altogether of course, so we don't lose support among Sordish nationalists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They pull out after we include them in the process? So be it. I'm done fighting for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Not great. But it would probably have been worse for us if we included those changes at the last minute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[447]`
Mówca: **Lucian Galade**
> ""These changes were not part of our initial proposal and target, sir. I don't think much has changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[448]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Autocrat_YoungSords_NFP_Deal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Autocrat_YoungSords_NFP_Deal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[450]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Autocrat_YoungSords_NFP_Deal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[451]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Anrica_YoungSordsSupportPolice = true;
BaseGameSupport.News_Turn07_R_YSWithPolice = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Anrica_YoungSordsSupportPolice"] = true;
Variable["BaseGameSupport.News_Turn07_R_YSWithPolice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[452]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`
  - -> `[454]`

### Węzeł `[453]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[454]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.ErsenCase_Statement_ProBlud == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[455]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`
  - -> `[457]`

### Węzeł `[456]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[457]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.ErsenCase_Statement_ProSollist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[458]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`
  - -> `[460]`

### Węzeł `[459]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[460]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[461]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Erzaren_ErsenCase_ProtestAgainstDelay = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Erzaren_ErsenCase_ProtestAgainstDelay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[462]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Erzaren_ErsenCase_ProtestAgainstSollistOutcome = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Erzaren_ErsenCase_ProtestAgainstSollistOutcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[463]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Deyr_GovernorKrullStartsDuty = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Deyr_GovernorKrullStartsDuty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[464]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Ribel_ProBludOrDefault_BFFThreatensJustices = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Ribel_ProBludOrDefault_BFFThreatensJustices"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[465]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Ribel_ProSollist_BFFThreatensPresidentAndNFP = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Ribel_ProSollist_BFFThreatensPresidentAndNFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[466]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[468]`

### Węzeł `[467]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[468]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Ban_WPB == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_WPB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[469]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Ribel_WPBBanned_BFFThreatensPresident = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Ribel_WPBBanned_BFFThreatensPresident"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[470]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Holsord_WPB_CondemnsCourtDecision = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_WPB_CondemnsCourtDecision"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[471]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`
  - -> `[473]`

### Węzeł `[472]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[473]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[474]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_LT_WPBCondemnsCourtDecision = true;
BaseGameSupport.News_Turn07_ST_IncreasedSupportForBludishRights = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_LT_WPBCondemnsCourtDecision"] = true;
Variable["BaseGameSupport.News_Turn07_ST_IncreasedSupportForBludishRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[475]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[476]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == false && (BaseGame.Bill_Turn01_CampaignFinance_Signed == true && BaseGame.Wehlen_DefendBorder == true) == false &&
BaseGame.Wehlen_JointOperation == false && BaseGame.Reform_Reform_NFP_Convinced == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`
  - -> `[478]`

### Węzeł `[477]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == false && (BaseGame.Bill_Turn01_CampaignFinance_Signed == true && BaseGame.Wehlen_DefendBorder == true) == false &&
BaseGame.Wehlen_JointOperation == false && BaseGame.Reform_Reform_NFP_Convinced == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == false  and  (Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and  Variable["BaseGame.Wehlen_DefendBorder"] == true) == false  and 
Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Reform_Reform_NFP_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[478]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == false && (BaseGame.Bill_Turn01_CampaignFinance_Signed == true && BaseGame.Wehlen_DefendBorder == true) == false &&
BaseGame.Wehlen_JointOperation == false && BaseGame.Reform_Reform_NFP_Convinced == false
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == false  and  (Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and  Variable["BaseGame.Wehlen_DefendBorder"] == true) == false  and 
Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Reform_Reform_NFP_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[479]`
Mówca: **Lucian Galade**
> ""The representatives of the Bludish community -- namely Mansoun Leke and Fetih Ejall -- have just released statements condemning our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[480]`
Mówca: **Lucian Galade**
> ""They criticized your inactions on the Ersen case. And they used a very strong language doing so, I must add.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[481]`
Mówca: **Lucian Galade**
> ""They have enormous influence over our Bludish population. Just something to be aware of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[482]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull = true;
BaseGameSupport.Codex_Characters_StateFigures_PhelixBron = false;
BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_ReplacedByCourt = true;

BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Bron = false;
BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Krull = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull"] = true;
Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron"] = false;
Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_ReplacedByCourt"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Bron"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Krull"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[483]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`
  - -> `[485]`

### Węzeł `[484]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProSollist == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[485]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.ErsenCase_Statement_ProSollist == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProSollist"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[486]`
Mówca: **Lucian Galade**
> ""Ms. Morgna has informed me that the representatives of the Bludish community have abandoned the reform committee after the developments regarding the Ersen case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[487]`
Mówca: **Lucian Galade**
> ""The proposal was unfortunately not finalized yet -- meaning that changes to Articles 6 and 7 must be delayed for the time being.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`
  - -> `[489]`
  - -> `[490]`

### Węzeł `[488]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What? Why?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wasn't sure if I was going to add that to our reform proposal anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's not good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[491]`
Mówca: **Lucian Galade**
> ""They criticized both you and the Supreme Court for protecting Sollism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[492]`
Mówca: **Lucian Galade**
> ""I don't think they are convinced to cooperate with us, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[493]`
Mówca: **Lucian Galade**
> ""But I have to say that this turned out to be a better outcome. Adding those changes to the reforms would have been disastrous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[494]`
Mówca: **Lucian Galade**
> ""They criticized your cooperation with the NFP and called your pro-Ersen statement 'an attempt of populist manipulation'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[495]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.ErsenCase_Statement_ProBlud == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[497]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.ErsenCase_Statement_ProBlud == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[498]`
Mówca: **Lucian Galade**
> ""Despite showing support after your statements about Ishval Ersen, the representatives of the Bludish community -- namely Mansoun Leke and Fetih Ejall -- have just released statements condemning our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[499]`
Mówca: **Lucian Galade**
> ""They criticized your policies against the Bludish community and called your pro-Ersen statement 'a poor attempt of tricking the Bludish people'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[500]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`
  - -> `[502]`

### Węzeł `[501]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[502]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_NFP_Convinced == true
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[503]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn07_G_ArcasiaAtCrossroads = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn07_G_ArcasiaAtCrossroads"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[504]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`
  - -> `[506]`

### Węzeł `[505]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[506]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[507]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn07_Uziren_BFFRecruitmentKrull = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Uziren_BFFRecruitmentKrull"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`
