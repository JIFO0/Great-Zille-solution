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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[10]` | **"“The Court needs to pass that review for us to continue uninterrupted. The decree ..."** | `[13]` **Lucian Galade**: "“I have to ask. Why? What is you..." | `Variable["BaseGame.Reform_Autocrat_Path"] == true` | *Brak zmian stanu* | `[9]` **Lucian Galade**: "“It's true, we are in the hornet..." |
| `[11]` | **"“We will privatize these companies.” [Privatization Path]"** | `[8]` **Lucian Galade**: "“What are you leaning towards? H..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.EconomicDirection_Privatization"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Privatization"] ...` | `[14]` **Lucian Galade**: "“I have to ask. Why? What is you..." |
| `[12]` | **"“Our administration will avoid upsetting the economic structure and maintain the s..."** | `[8]` **Lucian Galade**: "“What are you leaning towards? H..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.EconomicDirection_StatusQuo"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_StatusQuo"] = true;`<br>*(+1 skryptów)* | `[111]` **Lucian Galade**: "“Excellent. This is the safest w..." |
| `[25]` | **"“You look a bit tired. Are you getting enough sleep?”"** | `[24]` **Narrator**: "Lucian had dark circles below hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Lucian Galade**: "“I am trying to, sir.”" |
| `[26]` | **"“Let's discuss this upcoming meeting.”"** | `[24]` **Narrator**: "Lucian had dark circles below hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Lucian Galade**: "“I booked some of your time to p..." |
| `[28]` | **"“Very well.”"** | `[27]` **Lucian Galade**: "“I am trying to, sir.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Lucian Galade**: "“I booked some of your time to p..." |
| `[29]` | **"“Don't push yourself too much.”"** | `[27]` **Lucian Galade**: "“I am trying to, sir.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Lucian Galade**: "“I will try not to.”" |
| `[38]` | **"“That makes sense. I will think about it.”"** | `[36]` **Lucian Galade**: "“It is well known that the Old G..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Lucian Galade**: "“Very well.”" |
| `[39]` | **"“I won't let the Old Guard decide the future of our country in any way.”"** | `[36]` **Lucian Galade**: "“It is well known that the Old G..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Lucian Galade**: "“While I agree, it doesn't chang..." |
| `[40]` | **"“I will do what I want. It's as simple as that.”"** | `[36]` **Lucian Galade**: "“It is well known that the Old G..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Lucian Galade**: "“Of course.”" |
| `[48]` | **"“We will nationalize these companies.” [Nationalization Path]"** | `[8]` **Lucian Galade**: "“What are you leaning towards? H..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.EconomicDirection_Nationalization"] = ...`<br>`Variable["BaseGameSupport.Journal_Turn07_Nationalization"...` | `[13]` **Lucian Galade**: "“I have to ask. Why? What is you..." |
| `[50]` | **"“I cannot allow a major part of the country to run without my input as President. ..."** | `[13]` **Lucian Galade**: "“I have to ask. Why? What is you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Lucian Galade**: "“It's true that the more control..." |
| `[51]` | **"“Truth to be told, I don't care what anyone thinks or says. I will do what I belie..."** | `[13]` **Lucian Galade**: "“I have to ask. Why? What is you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Lucian Galade**: "“I understand. However, we need ..." |
| `[55]` | **"“If we want to improve our relations with the east, we need to nationalize our eco..."** | `[13]` **Lucian Galade**: "“I have to ask. Why? What is you..." | `Variable["BaseGame.Promise_Diplomacy_East"] == true` | *Brak zmian stanu* | `[56]` **Lucian Galade**: "“It's true that Valgsland would ..." |
| `[64]` | **"“If we want to improve our relations with the west, we need to privatize our econo..."** | `[14]` **Lucian Galade**: "“I have to ask. Why? What is you..." | `Variable["BaseGame.Promise_Diplomacy_West"] == true` | *Brak zmian stanu* | `[69]` **Lucian Galade**: "“It's true, Lespia would look ve..." |
| `[65]` | **"“Privatisation will help bring the country out of recession.”"** | `[14]` **Lucian Galade**: "“I have to ask. Why? What is you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Lucian Galade**: "“That may be true. But taking ev..." |
| `[66]` | **"“Truth to be told I don't care what anyone thinks or says. I will do what I believ..."** | `[14]` **Lucian Galade**: "“I have to ask. Why? What is you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Lucian Galade**: "“I understand, but we need to th..." |
| `[70]` | **"“The Oligarchs are powerful. They might aid us in Assembly if we help them.”"** | `[14]` **Lucian Galade**: "“I have to ask. Why? What is you..." | `Variable["BaseGame.Reform_Autocrat_Path"] == false` | *Brak zmian stanu* | `[74]` **Lucian Galade**: "“It's good to think strategicall..." |
| `[116]` | **"“We don't want the Lotherberg Group to be our enemies. It'll endanger our re-elect..."** | `[125]` **Lucian Galade**: "“If our nationalization plan hur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Lucian Galade**: "“Indeed. They have their hands i..." |
| `[117]` | **"“If we nationalize only a part of their companies, perhaps we can avoid confrontat..."** | `[125]` **Lucian Galade**: "“If our nationalization plan hur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Lucian Galade**: "“Yes, that's the only kind of na..." |
| `[118]` | **"“It's good to know that Tusk is actively supporting our administration.”"** | `[114]` **Lucian Galade**: "“Walter Tusk seems to be organiz..."<br>`[115]` **Lucian Galade**: "“Walter Tusk seems to be organiz..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Lucian Galade**: "“Just be careful with him. Remem..." |
| `[119]` | **"“It's all a show. He and the others won't lift a finger without clear benefit. Bes..."** | `[114]` **Lucian Galade**: "“Walter Tusk seems to be organiz..."<br>`[115]` **Lucian Galade**: "“Walter Tusk seems to be organiz..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Lucian Galade**: "“Just be careful with him. Remem..." |
| `[123]` | **"“I'm confident that we will overcome the next hurdle without his help.”"** | `[114]` **Lucian Galade**: "“Walter Tusk seems to be organiz..."<br>`[115]` **Lucian Galade**: "“Walter Tusk seems to be organiz..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Lucian Galade**: "“Just be careful with him. Remem..." |
| `[130]` | **"“The Oligarchs must be destroyed. Seizing their assets is the way to go.”"** | `[125]` **Lucian Galade**: "“If our nationalization plan hur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Lucian Galade**: "“The only way to avoid being dam..." |
| `[137]` | **"“To save our country from recession, privatization is a must.”"** | `[153]` **Lucian Galade**: "“Still, we need to make sure tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Lucian Galade**: "“As I mentioned, we need to be c..." |
| `[140]` | **"“If we privatize only a part of their companies, perhaps we can get out of this un..."** | `[153]` **Lucian Galade**: "“Still, we need to make sure tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Lucian Galade**: "“That would certainly be a wise ..." |
| `[141]` | **"“It's good to know that Tusk is actively supporting our administration.”"** | `[138]` **Lucian Galade**: "“Walter Tusk seems be organising..."<br>`[139]` **Lucian Galade**: "“Walter Tusk seems be organizing..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Lucian Galade**: "“Just be careful with him. Remem..." |
| `[142]` | **"“It's all a show. He and the others won't lift a finger without clear benefit. Bes..."** | `[138]` **Lucian Galade**: "“Walter Tusk seems be organising..."<br>`[139]` **Lucian Galade**: "“Walter Tusk seems be organizing..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Lucian Galade**: "“Just be careful with him. Remem..." |
| `[146]` | **"“I'm confident that we will overcome the next hurdle without his help.”"** | `[138]` **Lucian Galade**: "“Walter Tusk seems be organising..."<br>`[139]` **Lucian Galade**: "“Walter Tusk seems be organizing..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Lucian Galade**: "“Just be careful with him. Remem..." |
| `[174]` | **"“I received a call from Marcel.”"** | `[173]` **Lucian Galade**: "“Did Marcel or Tusk contact you?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Lucian Galade**: "“What did he ask for?”" |
| `[175]` | **"“No, they haven't.”"** | `[173]` **Lucian Galade**: "“Did Marcel or Tusk contact you?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Narrator**: "Lucian gave me a long, measured ..." |
| `[178]` | **"“Don't worry. I have it under control.”"** | `[176]` **Lucian Galade**: "“What did he ask for?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Lucian Galade**: "“Mr. President, if you are not t..." |
| `[181]` | **"“He wanted to make a deal to leave HOS untouched.”"** | `[176]` **Lucian Galade**: "“What did he ask for?”" | `Variable["BaseGameIsolated.Turn07_MarcelCall_NotListened"] == false` | *Brak zmian stanu* | `[182]` **Lucian Galade**: "“And then?”" |
| `[185]` | **"“I threatened him with nationalization in return for his support. It worked.”"** | `[182]` **Lucian Galade**: "“And then?”" | `Variable["BaseGame.Turn07_A_Marcel_OwnershipDeal"] == true` | *Brak zmian stanu* | `[193]` **Lucian Galade**: "“Well done.”" |
| `[192]` | **"“He threatened me, so I told him I'm taking him down.”"** | `[182]` **Lucian Galade**: "“And then?”" | `Variable["BaseGame.Turn07_A_Marcel_Threatened"] == true` | *Brak zmian stanu* | `[195]` **Lucian Galade**: "“You did what?"" |
| `[200]` | **"“I said I'd think about it.”"** | `[182]` **Lucian Galade**: "“And then?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Lucian Galade**: "“Very well.”" |
| `[201]` | **"“Don't worry about it. I have it all under control.”"** | `[182]` **Lucian Galade**: "“And then?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Lucian Galade**: ""All right, sir. I trust you tha..." |
| `[205]` | **"“Yes, that was it.”"** | `[204]` **Lucian Galade**: "“Was that all that he wanted?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Lucian Galade**: "“All right.”" |
| `[206]` | **"“He also wants me to nationalize Bergia Steel to take down Tusk.”"** | `[204]` **Lucian Galade**: "“Was that all that he wanted?"" | `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true` | *Brak zmian stanu* | `[207]` **Lucian Galade**: "“As I expected.”" |
| `[234]` | **"“He also wants me to give him the shares from privatization to lower Tusk's influe..."** | `[204]` **Lucian Galade**: "“Was that all that he wanted?"" | `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false` | *Brak zmian stanu* | `[207]` **Lucian Galade**: "“As I expected.”" |
| `[236]` | **"“We don't want the Lotherberg Group to be our enemies. It'll endanger our re-elect..."** | `[153]` **Lucian Galade**: "“Still, we need to make sure tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Lucian Galade**: "“Indeed. They have their hands i..." |
| `[268]` | **"“I stopped him before he could say anything.""** | `[176]` **Lucian Galade**: "“What did he ask for?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Lucian Galade**: "“Not involving ourselves in The ..." |
| `[302]` | **""This is very troubling. Do you have any idea how we can proceed?""** | `[286]` **Lucian Galade**: ""This, of course, allows Governo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Lucian Galade**: ""I don't think there is anything..." |
| `[303]` | **""Ms. Morgna was right about how extreme Mr. Hawker's opinions were. I should have ..."** | `[286]` **Lucian Galade**: ""This, of course, allows Governo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Lucian Galade**: ""There was nothing you could do,..." |
| `[304]` | **""Orso Hawker is going too far with this.""** | `[286]` **Lucian Galade**: ""This, of course, allows Governo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Lucian Galade**: ""He is. That's why taking away t..." |
| `[309]` | **""Sollist or not, this is good news. Bergia will finally be free from Governor Bron..."** | `[296]` **Lucian Galade**: ""Activists, radicals and BFF sym..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Lucian Galade**: ""I agree, sir."" |
| `[310]` | **""What more do these *activists* want? They only want to see the bad side of everyt..."** | `[296]` **Lucian Galade**: ""Activists, radicals and BFF sym..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Lucian Galade**: ""As long as we can ride the afte..." |
| `[311]` | **""Thank you for informing me, Lucian. Do you have any idea on how we proceed?""** | `[296]` **Lucian Galade**: ""Activists, radicals and BFF sym..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Lucian Galade**: ""I don't think there's anything ..." |
| `[319]` | **""What!? How can they just decide to do that?""** | `[318]` **Lucian Galade**: ""Mr. Kibener might have played y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Lucian Galade**: ""Unfortunately, there's nothing ..." |
| `[320]` | **""I'm really questioning Ms. Morgna's advice on this now. She should have seen this..."** | `[318]` **Lucian Galade**: ""Mr. Kibener might have played y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[324]` **Lucian Galade**: ""She's a competent woman, but sh..." |
| `[321]` | **""This is very bad news. What do we do now?""** | `[318]` **Lucian Galade**: ""Mr. Kibener might have played y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Lucian Galade**: ""Unfortunately, there's nothing ..." |
| `[322]` | **""Screw Hawker! Screw Kibener! This whole system is broken!""** | `[318]` **Lucian Galade**: ""Mr. Kibener might have played y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Lucian Galade**: ""And thanks to you, we are doing..." |
| `[379]` | **""This is very disappointing.""** | `[378]` **Lucian Galade**: ""Ms. Morgna has informed me that..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[447]` **Lucian Galade**: ""These changes were not part of ..." |
| `[380]` | **""This is ridiculous. Tell her to work faster. It needs to be finished before the v..."** | `[355]` **Lucian Galade**: ""And I doubt they'll support any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[385]` **Lucian Galade**: ""I'll tell her immediately after..." |
| `[381]` | **""I'm sure we can find a way to convince the party by then.""** | `[355]` **Lucian Galade**: ""And I doubt they'll support any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Lucian Galade**: ""Of course, sir."" |
| `[382]` | **""Well... who knows whether our reforms will pass.""** | `[355]` **Lucian Galade**: ""And I doubt they'll support any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Lucian Galade**: ""For the sake of our administrat..." |
| `[389]` | **""Great news. Tell her I'm grateful for her work on this.""** | `[345]` **Lucian Galade**: ""You'd be free to enact it then."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[401]` **Lucian Galade**: ""Of course, sir."" |
| `[390]` | **""Thank you for letting me know.""** | `[345]` **Lucian Galade**: ""You'd be free to enact it then."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[401]` **Lucian Galade**: ""Of course, sir."" |
| `[391]` | **""Good to know. I'm looking forward to signing it.""** | `[345]` **Lucian Galade**: ""You'd be free to enact it then."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[399]` **Lucian Galade**: ""There is one more thing."" |
| `[393]` | **""I'm not doing this for the elections, Lucian.""** | `[392]` **Lucian Galade**: ""We should use every future oppo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[398]` **Lucian Galade**: ""Of course, sir."" |
| `[394]` | **""Thank you for the input.""** | `[392]` **Lucian Galade**: ""We should use every future oppo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[398]` **Lucian Galade**: ""Of course, sir."" |
| `[395]` | **""I don't think their influence is large enough for us to care.""** | `[392]` **Lucian Galade**: ""We should use every future oppo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Lucian Galade**: ""Their numbers are not that larg..." |
| `[404]` | **""This is ridiculous. Tell her to work faster. It needs to be finished before the v..."** | `[403]` **Lucian Galade**: ""It will be very hard to convinc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[409]` **Lucian Galade**: ""I'll tell her immediately after..." |
| `[405]` | **""I'm sure we can find a way to convince the party by then.""** | `[403]` **Lucian Galade**: ""It will be very hard to convinc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Lucian Galade**: ""Of course, sir."" |
| `[406]` | **""Well... It's not certain our reforms will pass.""** | `[403]` **Lucian Galade**: ""It will be very hard to convinc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[407]` **Lucian Galade**: ""We have to make sure that doesn..." |
| `[410]` | **""Great news. Tell her I'm grateful for her work on this.""** | `[362]` **Lucian Galade**: ""You'd be free to enact it then."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Lucian Galade**: ""Of course, sir."" |
| `[411]` | **""Thank you for letting me know.""** | `[362]` **Lucian Galade**: ""You'd be free to enact it then."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Lucian Galade**: ""Of course, sir."" |
| `[412]` | **""Good to know. I'm looking forward to signing it.""** | `[362]` **Lucian Galade**: ""You'd be free to enact it then."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Lucian Galade**: ""Of course, sir."" |
| `[413]` | **""This is worrying. We must look to other ways to increase our standing with our Bl..."** | `[377]` **Lucian Galade**: ""But there is not much we can do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[417]` **Lucian Galade**: ""Of course, sir."" |
| `[414]` | **""I don't think this is a negative result. I'm sure Mr. Krull will do a good job.""** | `[377]` **Lucian Galade**: ""But there is not much we can do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[416]` **Lucian Galade**: ""We'll congratulate him when he ..." |
| `[415]` | **""This is bad news, Lucian. This was not my intention.""** | `[377]` **Lucian Galade**: ""But there is not much we can do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[418]` **Lucian Galade**: ""There's no use pondering on the..." |
| `[422]` | **""I'm sure this is a positive development. I'd be happy to meet them.""** | `[400]` **Lucian Galade**: ""I am not sure exactly which top..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Lucian Galade**: ""I'll let them know, sir."" |
| `[423]` | **""Do you think I should accept their meeting?""** | `[400]` **Lucian Galade**: ""I am not sure exactly which top..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Lucian Galade**: ""It might be risky being seen wi..." |
| `[424]` | **""I don't want to be seen with them right before the vote. This can be detrimental ..."** | `[400]` **Lucian Galade**: ""I am not sure exactly which top..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[425]` **Lucian Galade**: ""It holds some risk, it's true."" |
| `[430]` | **""That's great news. I'm looking forward to discussing the changes.""** | `[360]` **Lucian Galade**: ""If you are insistent on adding ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[433]` **Lucian Galade**: ""Understood, sir."" |
| `[431]` | **""So you don't approve of this?""** | `[360]` **Lucian Galade**: ""If you are insistent on adding ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[434]` **Lucian Galade**: ""I'm afraid it would be almost i..." |
| `[432]` | **""I'm not completely sure if I'm going to add that to the proposal yet. I'll decide..."** | `[360]` **Lucian Galade**: ""If you are insistent on adding ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[433]` **Lucian Galade**: ""Understood, sir."" |
| `[438]` | **""Who will be representing the movement?""** | `[360]` **Lucian Galade**: ""If you are insistent on adding ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[439]` **Lucian Galade**: ""Mr. Leke and Mr. Ejall."" |
| `[441]` | **""We should paint Mr. Krull as a threat to the party's rule. I believe we can take ..."** | `[403]` **Lucian Galade**: ""It will be very hard to convinc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[442]` **Lucian Galade**: ""Of course. That's a clever stra..." |
| `[445]` | **""They pull out after we include them in the process? So be it. I'm done fighting f..."** | `[378]` **Lucian Galade**: ""Ms. Morgna has informed me that..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[436]` **Lucian Galade**: ""No harm done, sir. It would hav..." |
| `[446]` | **""Not great. But it would probably have been worse for us if we included those chan..."** | `[378]` **Lucian Galade**: ""Ms. Morgna has informed me that..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[436]` **Lucian Galade**: ""No harm done, sir. It would hav..." |
| `[488]` | **""What? Why?""** | `[487]` **Lucian Galade**: ""The proposal was unfortunately ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[491]` **Lucian Galade**: ""They criticized both you and th..." |
| `[489]` | **""I wasn't sure if I was going to add that to our reform proposal anyway.""** | `[487]` **Lucian Galade**: ""The proposal was unfortunately ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[493]` **Lucian Galade**: ""But I have to say that this tur..." |
| `[490]` | **""That's not good.""** | `[487]` **Lucian Galade**: ""The proposal was unfortunately ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[492]` **Lucian Galade**: ""I don't think they are convince..." |

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
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Lucian scheduled some time with me to discuss the potential political repercussions of the upcoming economy meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He arrived on time as usual and took his seat right acros..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucian Galade: "“I want to give you a short status update.”"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Lucian Galade: "“But before going into the economic direction, I want to ..."*)

### Węzeł `[7]`
Mówca: **Lucian Galade**
> "“My efforts to ensure a court rejection for the legal arguments put forward by Mr. Ricter are continuing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lucian Galade: "“A very important piece in succeeding will be this upcomi..."*)

### Węzeł `[8]`
Mówca: **Lucian Galade**
> "“What are you leaning towards? How should we move forward?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "“We will nationalize these companies.” [Nationalization P..."*)
  - -> `[12]` (*Player: "“Our administration will avoid upsetting the economic str..."*)
  - -> `[11]` (*Player: "“We will privatize these companies.” [Privatization Path]"*)

### Węzeł `[9]`
Mówca: **Lucian Galade**
> "“It's true, we are in the hornet's nest if we can't get out of this situation. But they want us to seize the assets of the Oligarchs, an action that would drastically alter the power balance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“The Court needs to pass that review for us to continue uninterrupted. The decree must be deemed constitutional. Otherwise, we are weakened.”"]** — Mówca: **Player**
> "“The Court needs to pass that review for us to continue uninterrupted. The decree must be deemed constitutional. Otherwise, we are weakened.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[13]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucian Galade: "“It's true, we are in the hornet's nest if we can't get o..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“We will privatize these companies.” [Privatization Path]"]** — Mówca: **Player**
> "“We will privatize these companies.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Privatization = true"*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“Our administration will avoid upsetting the economic structure and maintain the status quo.”"]** — Mówca: **Player**
> "“Our administration will avoid upsetting the economic structure and maintain the status quo.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo = true"*)

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“I have to ask. Why? What is your intention?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)
  - -> `[50]` (*Player: "“I cannot allow a major part of the country to run withou..."*)
  - -> `[51]` (*Player: "“Truth to be told, I don't care what anyone thinks or say..."*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“I have to ask. Why? What is your intention?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)
  - -> `[65]` (*Player: "“Privatisation will help bring the country out of recessi..."*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false"*)
  - -> `[66]` (*Player: "“Truth to be told I don't care what anyone thinks or says..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "Lucian took a note in his notebook."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 2"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= 2)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: "“We have a large government budget available to improve t..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: "“Unfortunately we have missed our government budget targe..."*)

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“Changing the ownership of some of these assets would increase our budget even more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: "“It's just something to consider. As is our relationship ..."*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> "“The plan to change the ownership of important assets could help us generate much needed resources to further improve economic development before the next election.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: "“It's just something to consider. As is our relationship ..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Lucian looked at his watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == true"*)

### Węzeł `[22]`
Mówca: **Narrator**
> "He arrived on time as usual and took his seat right across from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lucian Galade: "“Good morning, Mr. President.”"*)

### Węzeł `[23]`
Mówca: **Lucian Galade**
> "“Good morning, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Lucian had dark circles below his eyes. The plethora of p..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Lucian had dark circles below his eyes. The plethora of political developments must've been weighing even on a workaholic like him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: "“You look a bit tired. Are you getting enough sleep?”"*)
  - -> `[26]` (*Player: "“Let's discuss this upcoming meeting.”"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“You look a bit tired. Are you getting enough sleep?”"]** — Mówca: **Player**
> "“You look a bit tired. Are you getting enough sleep?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Lucian Galade: "“I am trying to, sir.”"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Let's discuss this upcoming meeting.”"]** — Mówca: **Player**
> "“Let's discuss this upcoming meeting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: "“I booked some of your time to pre-plan for today's meeti..."*)

### Węzeł `[27]`
Mówca: **Lucian Galade**
> "“I am trying to, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "“Don't push yourself too much.”"*)
  - -> `[28]` (*Player: "“Very well.”"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Very well.”"]** — Mówca: **Player**
> "“Very well.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: "“I booked some of your time to pre-plan for today's meeti..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Don't push yourself too much.”"]** — Mówca: **Player**
> "“Don't push yourself too much.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: "“I will try not to.”"*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> "“I will try not to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucian Galade: "“I must say, you don't look much better.”"*)

### Węzeł `[31]`
Mówca: **Lucian Galade**
> "“I must say, you don't look much better.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "I looked at myself in a small hand mirror. Similar circle..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "I looked at myself in a small hand mirror. Similar circles were beneath my eyes as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: "“I booked some of your time to pre-plan for today's meeti..."*)

### Węzeł `[33]`
Mówca: **Lucian Galade**
> "“I booked some of your time to pre-plan for today's meeting at the Ministry of Economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[34]`
Mówca: **Lucian Galade**
> "“I want to give you a short status update.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucian Galade: "“As you know, I've been lobbying the Old Guard extensivel..."*)

### Węzeł `[35]`
Mówca: **Lucian Galade**
> "“A very important piece in succeeding will be this upcoming economy meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: "“It is well known that the Old Guard wants many of these ..."*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> "“It is well known that the Old Guard wants many of these large companies to be nationalized. If we do that, our chances of the court rejecting Mr. Ricter will increase.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "“That makes sense. I will think about it.”"*)
  - -> `[39]` (*Player: "“I won't let the Old Guard decide the future of our count..."*)
  - -> `[40]` (*Player: "“I will do what I want. It's as simple as that.”"*)

### Węzeł `[37]`
Mówca: **Lucian Galade**
> "“As you know, I've been lobbying the Old Guard extensively after the constitutional review process began to ensure we don't end up in a weakened position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Lucian Galade: "“My efforts to ensure a court rejection for the legal arg..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“That makes sense. I will think about it.”"]** — Mówca: **Player**
> "“That makes sense. I will think about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: "“Very well.”"*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“I won't let the Old Guard decide the future of our country in any way.”"]** — Mówca: **Player**
> "“I won't let the Old Guard decide the future of our country in any way.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lucian Galade: "“While I agree, it doesn't change the fact that if they a..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“I will do what I want. It's as simple as that.”"]** — Mówca: **Player**
> "“I will do what I want. It's as simple as that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“Of course.”"*)

### Węzeł `[41]`
Mówca: **Lucian Galade**
> "“Of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: "“We need to be cautious. Any grand plans about the econom..."*)

### Węzeł `[42]`
Mówca: **Lucian Galade**
> "“While I agree, it doesn't change the fact that if they accept Mr. Ricter's plea, we might be done for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: "“We need to be cautious. Any grand plans about the econom..."*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: "“We need to be cautious. Any grand plans about the econom..."*)

### Węzeł `[44]`
Mówca: **Lucian Galade**
> "“We would be changing our relationship with the Old Guard, the Oligarchs and the opposition.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lucian Galade: ""As you know, this meeting will give you the opportunity ..."*)

### Węzeł `[45]`
Mówca: **Lucian Galade**
> "“We need to be cautious. Any grand plans about the economy also heavily influence our political standing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: "“We would be changing our relationship with the Old Guard..."*)

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""As you know, this meeting will give you the opportunity to alter the ownership of the Big Four, the corporations at the center of Sordland's ownership question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Lucian Galade: "“We can start the process of nationalization or privatiza..."*)

### Węzeł `[47]`
Mówca: **Lucian Galade**
> "“I personally think we should stay out of this and keep things as they are. There is no need to make new political enemies at this stage in our term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Lucian Galade: "“But ultimately, the decision is yours.”"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“We will nationalize these companies.” [Nationalization Path]"]** — Mówca: **Player**
> "“We will nationalize these companies.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization = true"*)

### Węzeł `[49]`
Mówca: **Lucian Galade**
> "“It's true that the more control we have, the better. Your administration still bears responsibility If we let the Oligarchs determine the course of the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“I cannot allow a major part of the country to run without my input as President. The Oligarchs must submit to me.”"]** — Mówca: **Player**
> "“I cannot allow a major part of the country to run without my input as President. The Oligarchs must submit to me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: "“It's true that the more control we have, the better. You..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Truth to be told, I don't care what anyone thinks or says. I will do what I believe in.”"]** — Mówca: **Player**
> "“Truth to be told, I don't care what anyone thinks or says. I will do what I believe in.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lucian Galade: "“I understand. However, we need to think carefully about ..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_East == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: "“If we want to improve our relations with the east, we ne..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_East == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
**[WYBÓR GRACZA: "“If we want to improve our relations with the east, we need to nationalize our economy.”"]** — Mówca: **Player**
> "“If we want to improve our relations with the east, we need to nationalize our economy.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Kontekst wejściowy (poprzednik):** `[13]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: "“It's true that Valgsland would look very favorably on su..."*)

### Węzeł `[56]`
Mówca: **Lucian Galade**
> "“It's true that Valgsland would look very favorably on such changes in any upcoming negotiations. And United Contana would see it as a positive step towards a potential membership in the CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“The Court needs to pass that review for us to continue u..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[60]`
Mówca: **Lucian Galade**
> "“I understand. However, we need to think carefully about the effects of your actions. Especially since the next election is getting closer every day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_West == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: "“If we want to improve our relations with the west, we ne..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_West == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
**[WYBÓR GRACZA: "“If we want to improve our relations with the west, we need to privatize our economy.”"]** — Mówca: **Player**
> "“If we want to improve our relations with the west, we need to privatize our economy.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Kontekst wejściowy (poprzednik):** `[14]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: "“It's true, Lespia would look very favorably on such chan..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“Privatisation will help bring the country out of recession.”"]** — Mówca: **Player**
> "“Privatization will help bring the country out of recession.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucian Galade: "“That may be true. But taking everything out of state han..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Truth to be told I don't care what anyone thinks or says. I will do what I believe in.”"]** — Mówca: **Player**
> "“Truth to be told I don't care what anyone thinks or says. I will do what I believe in.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: "“I understand, but we need to think carefully about the e..."*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“I understand, but we need to think carefully about the effects of your actions. Especially with the elections getting closer every day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[68]`
Mówca: **Lucian Galade**
> "“That may be true. But taking everything out of state hands may have dire repercussions in a country like ours. We need to think about this carefully.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[69]`
Mówca: **Lucian Galade**
> "“It's true, Lespia would look very favorably on such changes in the upcoming negotiations. Arcasia would see it as a positive step towards membership in the ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“The Oligarchs are powerful. They might aid us in Assembly if we help them.”"]** — Mówca: **Player**
> "“The Oligarchs are powerful. They might aid us in Assembly if we help them.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Kontekst wejściowy (poprzednik):** `[14]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucian Galade: "“It's good to think strategically like that. But if we ma..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: "“The Oligarchs are powerful. They might aid us in Assembl..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[74]`
Mówca: **Lucian Galade**
> "“It's good to think strategically like that. But if we make them too powerful, they might end up stabbing us in the back. There might be dire repercussions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucian Galade: "“One thing to remember is that since you've been transpar..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: "“I have to remind you that nationalization goes against y..."*)

### Węzeł `[78]`
Mówca: **Lucian Galade**
> "“One thing to remember is that since you've been transparent about promoting a planned economy, nationalization will not cost us much support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Lucian took a note in his notebook."*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> "“I have to remind you that nationalization goes against your initial plans for a market economy. We might lose support because of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Lucian took a note in his notebook."*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> "“One thing to remember is that since you've been transparent about promoting a market economy, privatization will not cost us much support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Lucian took a note in his notebook."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: "“One thing to remember is that since you've been transpar..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lucian Galade: "“I have to remind you that privatization goes against you..."*)

### Węzeł `[84]`
Mówca: **Lucian Galade**
> "“I have to remind you that privatization goes against your initial plans for a planned economy. We might lose support because of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Lucian took a note in his notebook."*)

### Węzeł `[85]`
Mówca: **Lucian Galade**
> "“I received a report from the Ministry of Economy that may impact your decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 2"*)

### Węzeł `[86]`
Mówca: **Lucian Galade**
> "“We have a large government budget available to improve the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucian Galade: "“Changing the ownership of some of these assets would inc..."*)

### Węzeł `[87]`
Mówca: **Lucian Galade**
> "“Unfortunately we have missed our government budget targets for the current quarter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: "“The plan to change the ownership of important assets cou..."*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> "“It's just something to consider. As is our relationship with the Oligarchs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == true"*)

### Węzeł `[89]`
Mówca: **Lucian Galade**
> "“Although I think the Oligarchs would've liked us to privatize everything, maintaining the status quo will not disturb our relationship with them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucian Galade: "“This means more stability. Both economically and politic..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.EconomicDirection_Nationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Nationalization = true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_StatusQuo = true"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Privatization = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.EconomicDirection_Privatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Privatization = true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_StatusQuo == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: "“Although I think the Oligarchs would've liked us to priv..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_StatusQuo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_StatusQuo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Nationalization == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucian Galade: "“We might be aiming for nationalization, but we need to r..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucian Galade: "“We need to remember that they only care about their own ..."*)

### Węzeł `[99]`
Mówca: **Lucian Galade**
> "“We might be aiming for nationalization, but we need to remember that they only care about their own profits.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[100]`
Mówca: **Lucian Galade**
> "“We need to remember that they only care about their own profits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[101]`
Mówca: **Lucian Galade**
> "“Unfortunately, we aren't on good terms with them. This situation has been obstructing some of our efforts in the economic recovery.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Lucian Galade: "“If our nationalization plan hurts their assets too much,..."*)

### Węzeł `[102]`
Mówca: **Lucian Galade**
> "“Thankfully, we are on good terms with them for now, which helps us with the economic recovery.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Lucian Galade: "“If our nationalization plan hurts their assets too much,..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: "“Thankfully, we are on good terms with them for now, whic..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucian Galade: "“Unfortunately, we aren't on good terms with them. This s..."*)

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“Unfortunately, we aren't on good terms with them. This situation has been obstructing some of our efforts with the economic recovery.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Lucian Galade: "“However, if we implement a privatization plan, they woul..."*)

### Węzeł `[107]`
Mówca: **Lucian Galade**
> "“Thankfully, we are on good terms with them for now, which helps us with the economic recovery.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Lucian Galade: "“If we implement a privatization plan, it will boost our ..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lucian Galade: "“Thankfully, we are on good terms with them for now, whic..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lucian Galade: "“Unfortunately, we aren't on good terms with them. This s..."*)

### Węzeł `[111]`
Mówca: **Lucian Galade**
> "“Excellent. This is the safest way to victory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Lucian took a note in his notebook."*)

### Węzeł `[112]`
Mówca: **Lucian Galade**
> "“This means more stability. Both economically and politically.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Lucian Galade: "“Speaking of stability...”"*)

### Węzeł `[113]`
Mówca: **Lucian Galade**
> "“If our nationalization plan hurts their assets too much, it can put us at odds with the men who control much of the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[114]`
Mówca: **Lucian Galade**
> "“Walter Tusk seems to be organizing several opposing centrist and liberal Assembly members to back us in the upcoming vote. If we maintain our standing with him, our reforms process will benefit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: "“It's good to know that Tusk is actively supporting our a..."*)
  - -> `[119]` (*Player: "“It's all a show. He and the others won't lift a finger w..."*)
  - -> `[123]` (*Player: "“I'm confident that we will overcome the next hurdle with..."*)

### Węzeł `[115]`
Mówca: **Lucian Galade**
> "“Walter Tusk seems to be organizing several opposing conservative and nationalist Assembly members to back us in the upcoming vote. If we maintain our standing with him, our reforms process will benefit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: "“It's good to know that Tusk is actively supporting our a..."*)
  - -> `[119]` (*Player: "“It's all a show. He and the others won't lift a finger w..."*)
  - -> `[123]` (*Player: "“I'm confident that we will overcome the next hurdle with..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“We don't want the Lotherberg Group to be our enemies. It'll endanger our re-election.”"]** — Mówca: **Player**
> "“We don't want the Lotherberg Group to be our enemies. It'll endanger our re-election.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucian Galade: "“Indeed. They have their hands in many pockets, and the l..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“If we nationalize only a part of their companies, perhaps we can avoid confrontation.”"]** — Mówca: **Player**
> "“If we nationalize only a part of their companies, perhaps we can avoid confrontation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucian Galade: "“Yes, that's the only kind of nationalization they'd acce..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“It's good to know that Tusk is actively supporting our administration.”"]** — Mówca: **Player**
> "“It's good to know that Tusk is actively supporting our administration.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Lucian Galade), `[115]` (Lucian Galade), `[124]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucian Galade: "“Just be careful with him. Remember, any path we take her..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“It's all a show. He and the others won't lift a finger without clear benefit. Besides, we don't need them.”"]** — Mówca: **Player**
> "“It's all a show. He and the others won't lift a finger without clear benefit. Besides, we don't need them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Lucian Galade), `[115]` (Lucian Galade), `[124]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucian Galade: "“Just be careful with him. Remember, any path we take her..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lucian Galade: "“Walter Tusk seems to be organizing several opposing cons..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "“I'm confident that we will overcome the next hurdle without his help.”"]** — Mówca: **Player**
> "“I'm confident that we will overcome the next hurdle without his help.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Lucian Galade), `[115]` (Lucian Galade), `[124]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucian Galade: "“Just be careful with him. Remember, any path we take her..."*)

### Węzeł `[124]`
Mówca: **Lucian Galade**
> "“Walter Tusk seems to be organizing several centrist Assembly members to pressure the court on behalf. If we maintain our standing with him, it might positively influence the court decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: "“It's good to know that Tusk is actively supporting our a..."*)
  - -> `[119]` (*Player: "“It's all a show. He and the others won't lift a finger w..."*)
  - -> `[123]` (*Player: "“I'm confident that we will overcome the next hurdle with..."*)

### Węzeł `[125]`
Mówca: **Lucian Galade**
> "“If our nationalization plan hurts their assets too much, we may end up at war with the men who control much of the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: "“We don't want the Lotherberg Group to be our enemies. It..."*)
  - -> `[117]` (*Player: "“If we nationalize only a part of their companies, perhap..."*)
  - -> `[130]` (*Player: "“The Oligarchs must be destroyed. Seizing their assets is..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lucian Galade: "“Walter Tusk seems to be organizing several opposing cent..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Lucian Galade: "“Walter Tusk seems to be organizing several centrist Asse..."*)

### Węzeł `[129]`
Mówca: **Lucian Galade**
> "“Yes, that's the only kind of nationalization they'd accept. I am sure that Tusk will have further requests afterwards, though.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucian Galade: "“Some of my connections indicate that there seems to be a..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“The Oligarchs must be destroyed. Seizing their assets is the way to go.”"]** — Mówca: **Player**
> "“The Oligarchs must be destroyed. Seizing their assets is the way to go.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Lucian Galade: "“The only way to avoid being damaged by such a dramatic a..."*)

### Węzeł `[131]`
Mówca: **Lucian Galade**
> "“Just be careful with him. Remember, any path we take here could very well determine what battles we fight in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucian Galade: "“Some of my connections indicate that there seems to be a..."*)

### Węzeł `[132]`
Mówca: **Lucian Galade**
> "“The only way to avoid being damaged by such a dramatic action is a swift surprise takeover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucian Galade: "“Some of my connections indicate that there seems to be a..."*)

### Węzeł `[133]`
Mówca: **Lucian Galade**
> "“Indeed. They have their hands in many pockets, and the last thing we want is another powerful force to fight when our main goal should be to maintain public opinion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucian Galade: "“Some of my connections indicate that there seems to be a..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lucian Galade: "“Walter Tusk seems be organising several opposing centris..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Walter Tusk seems be organising several centrist Assembl..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“To save our country from recession, privatization is a must.”"]** — Mówca: **Player**
> "“To save our country from recession, privatization is a must.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Lucian Galade: "“As I mentioned, we need to be careful.”"*)

### Węzeł `[138]`
Mówca: **Lucian Galade**
> "“Walter Tusk seems be organising several opposing centrist and liberal Assembly members to back us in the upcoming vote. If we maintain our standing with him, our reforms process will benefit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: "“It's good to know that Tusk is actively supporting our a..."*)
  - -> `[142]` (*Player: "“It's all a show. He and the others won't lift a finger w..."*)
  - -> `[146]` (*Player: "“I'm confident that we will overcome the next hurdle with..."*)

### Węzeł `[139]`
Mówca: **Lucian Galade**
> "“Walter Tusk seems be organizing several opposing conservative and nationalist Assembly members to back us in the upcoming vote. If we maintain our standing with him, our reforms process will benefit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: "“It's good to know that Tusk is actively supporting our a..."*)
  - -> `[142]` (*Player: "“It's all a show. He and the others won't lift a finger w..."*)
  - -> `[146]` (*Player: "“I'm confident that we will overcome the next hurdle with..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“If we privatize only a part of their companies, perhaps we can get out of this unscratched.”"]** — Mówca: **Player**
> "“If we privatize only a part of their companies, perhaps we can get out of this unscratched.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lucian Galade: "“That would certainly be a wise compromise.""*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“It's good to know that Tusk is actively supporting our administration.”"]** — Mówca: **Player**
> "“It's good to know that Tusk is actively supporting our administration.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Lucian Galade), `[139]` (Lucian Galade), `[147]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucian Galade: "“Just be careful with him. Remember, any path we take her..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "“It's all a show. He and the others won't lift a finger without clear benefit. Besides, we don't need them in the future.”"]** — Mówca: **Player**
> "“It's all a show. He and the others won't lift a finger without clear benefit. Besides, we don't need them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Lucian Galade), `[139]` (Lucian Galade), `[147]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucian Galade: "“Just be careful with him. Remember, any path we take her..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucian Galade: "“Walter Tusk seems be organizing several opposing conserv..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)

### Węzeł `[146]`
**[WYBÓR GRACZA: "“I'm confident that we will overcome the next hurdle without his help.”"]** — Mówca: **Player**
> "“I'm confident that we will overcome the next hurdle without his help.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Lucian Galade), `[139]` (Lucian Galade), `[147]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucian Galade: "“Just be careful with him. Remember, any path we take her..."*)

### Węzeł `[147]`
Mówca: **Lucian Galade**
> "“Walter Tusk seems be organising several centrist Assembly members to pressure the court on behalf. If we maintain our standing with him, it might positively influence the court decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: "“It's good to know that Tusk is actively supporting our a..."*)
  - -> `[142]` (*Player: "“It's all a show. He and the others won't lift a finger w..."*)
  - -> `[146]` (*Player: "“I'm confident that we will overcome the next hurdle with..."*)

### Węzeł `[148]`
Mówca: **Lucian Galade**
> "“As I mentioned, we need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucian Galade: "“Some of my connections indicate that there seems to be a..."*)

### Węzeł `[149]`
Mówca: **Lucian Galade**
> "“That would certainly be a wise compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucian Galade: "“Some of my connections indicate that there seems to be a..."*)

### Węzeł `[150]`
Mówca: **Lucian Galade**
> "“Just be careful with him. Remember, any path we take here could very well determine what battles we fight in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucian Galade: "“Some of my connections indicate that there seems to be a..."*)

### Węzeł `[151]`
Mówca: **Lucian Galade**
> "“If we implement a privatization plan, it will boost our relationship even further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[152]`
Mówca: **Lucian Galade**
> "“However, if we implement a privatization plan, they would surely be delighted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Lucian Galade: "“Still, we need to make sure that we don't go overboard w..."*)

### Węzeł `[153]`
Mówca: **Lucian Galade**
> "“Still, we need to make sure that we don't go overboard with it. If we do, we might lose our base both in the USP and among the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Player: "“We don't want the Lotherberg Group to be our enemies. It..."*)
  - -> `[140]` (*Player: "“If we privatize only a part of their companies, perhaps ..."*)
  - -> `[137]` (*Player: "“To save our country from recession, privatization is a m..."*)

### Węzeł `[154]`
Mówca: **Lucian Galade**
> "“Some of my connections indicate that there seems to be a contest for leadership in the Lotherberg Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Lucian Galade: "“It looks like Marcel Koronti is making moves to become t..."*)

### Węzeł `[155]`
Mówca: **Lucian Galade**
> "“Speaking of stability...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucian Galade: "“Some of my connections indicate that there seems to be a..."*)

### Węzeł `[156]`
Mówca: **Lucian Galade**
> "“It looks like Marcel Koronti is making moves to become the key figure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Lucian Galade: "“Koronti probably wants his father's seat as the head of ..."*)

### Węzeł `[157]`
Mówca: **Lucian Galade**
> "“Koronti probably wants his father's seat as the head of the Group and Tusk doesn't want to let go of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Lucian Galade: "“It's a significant power struggle considering these are ..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_StatusQuo == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Lucian Galade: "“Another reason why I am supporting your decision to leav..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_StatusQuo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_StatusQuo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Nationalization == true)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Lucian Galade: "“Because we are going down the path of nationalization, w..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lucian Galade: "“If we over-privatize our state owned companies, the Sord..."*)

### Węzeł `[164]`
Mówca: **Lucian Galade**
> "“Because we are going down the path of nationalization, we will have the power to tip the balance towards either side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucian Galade: "“Since you have already made the decision to nationalize,..."*)

### Węzeł `[165]`
Mówca: **Lucian Galade**
> "“It's a significant power struggle considering these are the heads of Sordland's two largest private corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == true"*)

### Węzeł `[166]`
Mówca: **Lucian Galade**
> "“If we over-privatize our state owned companies, the Sordish State Corporation and Nedam Mining Group, it could result in the balance tipping to one side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Lucian Galade: "“They would fight over buying up shares and cause chaos.”"*)

### Węzeł `[167]`
Mówca: **Lucian Galade**
> "“Another reason why I am supporting your decision to leave the situation as it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Lucian Galade: "“There is no reason for us to interfere, directly or indi..."*)

### Węzeł `[168]`
Mówca: **Lucian Galade**
> "“Since you have already made the decision to nationalize, you need to be decisive in your follow-up actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Lucian Galade: "“Did Marcel or Tusk contact you?”"*)

### Węzeł `[169]`
Mówca: **Lucian Galade**
> "“They would fight over buying up shares and cause chaos.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Lucian Galade: "“Since you have already made the decision to privatize, y..."*)

### Węzeł `[170]`
Mówca: **Lucian Galade**
> "“Since you have already made the decision to privatize, you need to be decisive in your follow-up actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Lucian Galade: "“Did Marcel or Tusk contact you?”"*)

### Węzeł `[171]`
Mówca: **Lucian Galade**
> "“Our relationship with Walter Tusk hasn't been good so far. Any move we make now has to be calculated and thought through.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Lucian looked at his watch."*)

### Węzeł `[172]`
Mówca: **Lucian Galade**
> "“Our relationship with Walter Tusk has been very strong so far and we have the backing of the Oligarchs thanks to that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Lucian looked at his watch."*)

### Węzeł `[173]`
Mówca: **Lucian Galade**
> "“Did Marcel or Tusk contact you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player: "“I received a call from Marcel.”"*)
  - -> `[175]` (*Player: "“No, they haven't.”"*)

### Węzeł `[174]`
**[WYBÓR GRACZA: "“I received a call from Marcel.”"]** — Mówca: **Player**
> "“I received a call from Marcel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Lucian Galade: "“What did he ask for?”"*)

### Węzeł `[175]`
**[WYBÓR GRACZA: "“No, they haven't.”"]** — Mówca: **Player**
> "“No, they haven't.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Lucian gave me a long, measured look."*)

### Węzeł `[176]`
Mówca: **Lucian Galade**
> "“What did he ask for?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_MarcelCall_NotListened == false"*)
  - -> `[268]` (*Player: "“I stopped him before he could say anything.""*)
  - -> `[178]` (*Player: "“Don't worry. I have it under control.”"*)

### Węzeł `[177]`
Mówca: **Lucian Galade**
> "“Strange.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Lucian Galade: "“I was sure one of them would contact you.”"*)

### Węzeł `[178]`
**[WYBÓR GRACZA: "“Don't worry. I have it under control.”"]** — Mówca: **Player**
> "“Don't worry. I have it under control.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Lucian Galade: "“Mr. President, if you are not transparent with me, I can..."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "Lucian gave me a long, measured look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Lucian Galade: "“Strange.”"*)

### Węzeł `[180]`
Mówca: **Lucian Galade**
> "“I was sure one of them would contact you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lucian Galade: "“At any rate, this internal conflict among the Oligarchs ..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA: "“He wanted to make a deal to leave HOS untouched.”"]** — Mówca: **Player**
> "“He wanted to make a deal to leave HOS untouched.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_MarcelCall_NotListened"] == false`
- **Kontekst wejściowy (poprzednik):** `[176]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucian Galade: "“And then?”"*)

### Węzeł `[182]`
Mówca: **Lucian Galade**
> "“And then?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_A_Marcel_OwnershipDeal == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_A_Marcel_Threatened == true"*)
  - -> `[200]` (*Player: "“I said I'd think about it.”"*)
  - -> `[201]` (*Player: "“Don't worry about it. I have it all under control.”"*)

### Węzeł `[183]`
Mówca: **Lucian Galade**
> "“Mr. President, if you are not transparent with me, I can't help you to the best of my ability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: "“Very well, sir. I won't push you further.”"*)

### Węzeł `[184]`
Mówca: **Lucian Galade**
> "“Very well, sir. I won't push you further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lucian Galade: "“At any rate, this internal conflict among the Oligarchs ..."*)

### Węzeł `[185]`
**[WYBÓR GRACZA: "“I threatened him with nationalization in return for his support. It worked.”"]** — Mówca: **Player**
> "“I threatened him with nationalization in return for his support. It worked.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_A_Marcel_OwnershipDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[182]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Lucian Galade: "“Well done.”"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_A_Marcel_OwnershipDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_A_Marcel_OwnershipDeal == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_A_Marcel_OwnershipDeal == true)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_A_Marcel_OwnershipDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_A_Marcel_OwnershipDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: "“I threatened him with nationalization in return for his ..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_A_Marcel_OwnershipDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_A_Marcel_OwnershipDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_A_Marcel_Threatened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_A_Marcel_Threatened == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_A_Marcel_Threatened == true)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_A_Marcel_Threatened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_A_Marcel_Threatened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Player: "“He threatened me, so I told him I'm taking him down.”"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_A_Marcel_Threatened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_A_Marcel_Threatened"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[192]`
**[WYBÓR GRACZA: "“He threatened me, so I told him I'm taking him down.”"]** — Mówca: **Player**
> "“He threatened me, so I told him I'm taking him down.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_A_Marcel_Threatened"] == true`
- **Kontekst wejściowy (poprzednik):** `[182]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Lucian Galade: "“You did what?""*)

### Węzeł `[193]`
Mówca: **Lucian Galade**
> "“Well done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Lucian Galade: "“I hope he will keep his word.”"*)

### Węzeł `[194]`
Mówca: **Lucian Galade**
> "“I hope he will keep his word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Lucian Galade: "“Was that all that he wanted?""*)

### Węzeł `[195]`
Mówca: **Lucian Galade**
> "“You did what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Lucian Galade: "“Never mind whatever I said before. This changes everythi..."*)

### Węzeł `[196]`
Mówca: **Lucian Galade**
> "“Never mind whatever I said before. This changes everything.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucian Galade: "“Marcel Koronti is too dangerous and too powerful to have..."*)

### Węzeł `[197]`
Mówca: **Lucian Galade**
> "“Marcel Koronti is too dangerous and too powerful to have as an enemy. We need to take him down now or we might not get another chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Lucian Galade: "“Mr. President. We need to nationalize HOS.”"*)

### Węzeł `[198]`
Mówca: **Lucian Galade**
> "“Mr. President. We need to nationalize HOS.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Lucian Galade: "“And we need to do it quickly.”"*)

### Węzeł `[199]`
Mówca: **Lucian Galade**
> "“Otherwise, we might not stand a chance of re-election.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Lucian looked at his watch."*)

### Węzeł `[200]`
**[WYBÓR GRACZA: "“I said I'd think about it.”"]** — Mówca: **Player**
> "“I said I'd think about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Lucian Galade: "“Very well.”"*)

### Węzeł `[201]`
**[WYBÓR GRACZA: "“Don't worry about it. I have it all under control.”"]** — Mówca: **Player**
> "“Don't worry about it. I have it all under control.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Lucian Galade: ""All right, sir. I trust you that you will make the best ..."*)

### Węzeł `[202]`
Mówca: **Lucian Galade**
> ""All right, sir. I trust you that you will make the best decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Lucian Galade: "“Was that all that he wanted?""*)

### Węzeł `[203]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Lucian Galade: "“Was that all that he wanted?""*)

### Węzeł `[204]`
Mówca: **Lucian Galade**
> "“Was that all that he wanted?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player: "“Yes, that was it.”"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[205]`
**[WYBÓR GRACZA: "“Yes, that was it.”"]** — Mówca: **Player**
> "“Yes, that was it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Lucian Galade: "“All right.”"*)

### Węzeł `[206]`
**[WYBÓR GRACZA: "“He also wants me to nationalize Bergia Steel to take down Tusk.”"]** — Mówca: **Player**
> "“He also wants me to nationalize Bergia Steel to take down Tusk.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Kontekst wejściowy (poprzednik):** `[204]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Lucian Galade: "“As I expected.”"*)

### Węzeł `[207]`
Mówca: **Lucian Galade**
> "“As I expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Lucian Galade: "“This internal conflict among the Oligarchs puts us in an..."*)

### Węzeł `[208]`
Mówca: **Lucian Galade**
> "“All right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lucian Galade: "“At any rate, this internal conflict among the Oligarchs ..."*)

### Węzeł `[209]`
Mówca: **Lucian Galade**
> "“At any rate, this internal conflict among the Oligarchs puts us in an interesting position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[210]`
Mówca: **Lucian Galade**
> "“And we need to do it quickly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Lucian Galade: "“Otherwise, we might not stand a chance of re-election.”"*)

### Węzeł `[211]`
Mówca: **Lucian Galade**
> "“Very well then. It's almost time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Lucian Galade: "“I will inform Mr. Holl of your decision and he will make..."*)

### Węzeł `[212]`
Mówca: **Lucian Galade**
> "“I will inform Mr. Holl of your decision and he will make the necessary preparations to formulate a plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lucian Galade: "“I must get back to work now. See you at the next meeting.”"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_A_EconomicDirection = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_A_EconomicDirection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)

### Węzeł `[214]`
Mówca: **Lucian Galade**
> "“We can start the process of nationalization or privatization, or we can just keep the status quo.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Lucian Galade: "“Again, I remind you that any change will tip an already-..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_StatusQuo == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Lucian Galade: "“Very well then. I'll cancel the meeting since we are not..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_StatusQuo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_StatusQuo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Lucian Galade: "“Very well then. It's almost time.”"*)

### Węzeł `[218]`
Mówca: **Lucian Galade**
> "“Very well then. I'll cancel the meeting since we are not taking any actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Lucian Galade: "“I must get back to work.”"*)

### Węzeł `[219]`
Mówca: **Lucian Galade**
> "“I am glad you have made this decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucian Galade: "“Thank you for your time, sir.”"*)

### Węzeł `[220]`
Mówca: **Narrator**
> "Lucian got up from his chair and left the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_EconomicDirection = true"*)

### Węzeł `[221]`
Mówca: **Lucian Galade**
> "“I must get back to work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucian Galade: "“I am glad you have made this decision.”"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_StatusQuo == true)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == true"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_StatusQuo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_StatusQuo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucian Galade: "“I received a report from the Ministry of Economy that ma..."*)

### Węzeł `[225]`
Mówca: **Lucian Galade**
> "“There is no reason for us to interfere, directly or indirectly, in their internal struggles.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Lucian Galade: "“Did Marcel or Tusk contact you?”"*)

### Węzeł `[226]`
Mówca: **Lucian Galade**
> "“Thank you for your time, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "Lucian got up from his chair and left the office."*)

### Węzeł `[227]`
Mówca: **Lucian Galade**
> "“Again, I remind you that any change will tip an already-fragile balance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: "“I personally think we should stay out of this and keep t..."*)

### Węzeł `[228]`
Mówca: **Lucian Galade**
> "“But ultimately, the decision is yours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Lucian Galade: "“What are you leaning towards? How should we move forward?”"*)

### Węzeł `[229]`
Mówca: **Lucian Galade**
> "“I must get back to work now. See you at the next meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucian Galade: "“Thank you for your time, sir.”"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_EnT_Feedback_NationalizationPrivatization = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_EnT_Feedback_NationalizationPrivatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lucian Galade: "“Excellent. This is the safest way to victory.”"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player: "“He also wants me to nationalize Bergia Steel to take dow..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player: "“He also wants me to give him the shares from privatizati..."*)

### Węzeł `[234]`
**[WYBÓR GRACZA: "“He also wants me to give him the shares from privatization to lower Tusk's influence.”"]** — Mówca: **Player**
> "“He also wants me to give him the shares from privatization to lower Tusk's influence.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[204]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Lucian Galade: "“As I expected.”"*)

### Węzeł `[235]`
Mówca: **Lucian Galade**
> "“Indeed. They have their hands in many pockets, and the last thing we want is another powerful force to fight when our main goal should be to maintain public opinion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucian Galade: "“Some of my connections indicate that there seems to be a..."*)

### Węzeł `[236]`
**[WYBÓR GRACZA: "“We don't want the Lotherberg Group to be our enemies. It'll endanger our re-election.”"]** — Mówca: **Player**
> "“We don't want the Lotherberg Group to be our enemies. It'll endanger our re-election.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Lucian Galade: "“Indeed. They have their hands in many pockets, and the l..."*)

### Węzeł `[237]`
Mówca: **Lucian Galade**
> "“This internal conflict among the Oligarchs puts us in an interesting position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Nationalization = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Nationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucian Galade: "“I have to ask. Why? What is your intention?”"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_StatusQuo = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_StatusQuo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_EnT_Feedback_NationalizationPrivatiz..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Privatization = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Privatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucian Galade: "“I have to ask. Why? What is your intention?”"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Arvory_ValgslandianNavyActi..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Arvory_ValgslandianNavyActi..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Arvory_ValgslandianNavyActive_AgnoliaSide = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Arvory_ValgslandianNavyActive_AgnoliaSide"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "BaseGame.Autocrat_YoungSords_NFP_Deal == true"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Arvory_ValgslandianNavyActive_AgnoliaAlone = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Arvory_ValgslandianNavyActive_AgnoliaAlone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "BaseGame.Autocrat_YoungSords_NFP_Deal == true"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_HP_ErloryJointDrills = true"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == t..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_HP_ConriatJointDrills = true;..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_HP_ErloryJointDrills = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_ErloryJointDrills"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_HP_ConriatJointDrills = true; BaseGameSupport.News_Turn07_G_UCValgslandShipsTogether = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_ConriatJointDrills"] = true;
Variable["BaseGameSupport.News_Turn07_G_UCValgslandShipsTogether"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_G_TensionsRise_AgnoliaSide = ..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_G_TensionsRise_AgnoliaAlone =..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_G_TensionsRise_AgnoliaSide = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_G_TensionsRise_AgnoliaSide"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn07_CSP_SpySatellite = t..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_G_TensionsRise_AgnoliaAlone = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_G_TensionsRise_AgnoliaAlone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn07_CSP_SpySatellite = t..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.FactionReport_Turn07_CSP_SpySatellite = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn07_CSP_SpySatellite"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_AntiCorruptionPolice == true)"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_Corruption = false; BaseGame.Sit..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "// End"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_Corruption = false;
BaseGame.Situation_Order_CorruptionTackled = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_Corruption"] = false;
Variable["BaseGame.Situation_Order_CorruptionTackled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "// End"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// End`
- **Efekt skryptowy (`userScript`):** `-- End;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_MarcelCall_NotListened == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_MarcelCall_NotListened == false"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_MarcelCall_NotListened == false)"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_MarcelCall_NotListened == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_MarcelCall_NotListened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player: "“He wanted to make a deal to leave HOS untouched.”"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_MarcelCall_NotListened == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_MarcelCall_NotListened"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[268]`
**[WYBÓR GRACZA: "“I stopped him before he could say anything.""]** — Mówca: **Player**
> "“I stopped him before he could say anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Lucian Galade: "“Not involving ourselves in The Oligarchs businesses will..."*)

### Węzeł `[269]`
Mówca: **Lucian Galade**
> "“Not involving ourselves in The Oligarchs businesses will save us from potential headaches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == false"*)

### Węzeł `[270]`
Mówca: **Lucian Galade**
> "“But with the decisions, we're about to make today. I doubt that we can stay neutral for long. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lucian Galade: "“At any rate, this internal conflict among the Oligarchs ..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_StatusQuo == false"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_StatusQuo == false)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_StatusQuo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_StatusQuo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Lucian Galade: "“But with the decisions, we're about to make today. I dou..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_StatusQuo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_StatusQuo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lucian Galade: "“At any rate, this internal conflict among the Oligarchs ..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true)"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Lucian Galade: "“Our relationship with Walter Tusk has been very strong s..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Lucian Galade: "“Our relationship with Walter Tusk hasn't been good so fa..."*)

### Węzeł `[277]`
Mówca: **Lucian Galade**
> "“But before going into the economic direction, I want to give you a short status update.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProBlud == true)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lucian Galade: ""After your supportive statements of Ishval Ersen togethe..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ErsenCase_Statement_ProBlud == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist == true"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist == true"*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProSollist == true)"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Lucian Galade: ""After you and Mr. Kibener made your statement in support..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ErsenCase_Statement_ProSollist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Lucian Galade: ""We've just received word about the case of Ishval Ersen...."*)

### Węzeł `[284]`
Mówca: **Lucian Galade**
> ""After your supportive statements of Ishval Ersen together with Mr. Ricter, the Supreme Court decided not to act at all, and delayed the case until further notice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Lucian Galade: ""I'm afraid Chief Justice Hawker seems to be protecting G..."*)

### Węzeł `[285]`
Mówca: **Lucian Galade**
> ""Moreover, the Bludish community in Bergia is getting increasingly restless over this topic. Nobody knows how long they'll keep delaying the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Lucian Galade: ""This, of course, allows Governor Bron to keep his seat a..."*)

### Węzeł `[286]`
Mówca: **Lucian Galade**
> ""This, of course, allows Governor Bron to keep his seat and continue his resettlement policies in Bergia, among others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player: ""This is very troubling. Do you have any idea how we can ..."*)
  - -> `[303]` (*Player: ""Ms. Morgna was right about how extreme Mr. Hawker's opin..."*)
  - -> `[304]` (*Player: ""Orso Hawker is going too far with this.""*)

### Węzeł `[287]`
Mówca: **Lucian Galade**
> ""I'm afraid Chief Justice Hawker seems to be protecting Governor Bron from persecution. This will only increase tensions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Lucian Galade: ""Antagonizing him before the vote for the constitution wa..."*)

### Węzeł `[288]`
Mówca: **Lucian Galade**
> ""Antagonizing him before the vote for the constitution was perhaps not the best idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Lucian Galade: ""Moreover, the Bludish community in Bergia is getting inc..."*)

### Węzeł `[289]`
Mówca: **Lucian Galade**
> ""After you and Mr. Kibener made your statement in support of Sollist constitutionalism, the Supreme Court prioritized the case and quickly announced a verdict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Lucian Galade: ""It was very clever of you to use Sollism against them. T..."*)

### Węzeł `[290]`
Mówca: **Lucian Galade**
> ""It was very clever of you to use Sollism against them. They couldn't afford to look like hypocrites, so they must have moved on it very quickly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lucian Galade: ""The Court ruled that Phelix Bron is to be relieved from ..."*)

### Węzeł `[291]`
Mówca: **Lucian Galade**
> ""The Court ruled that Phelix Bron is to be relieved from his position as governor for abusing his powers to discriminate against Sordish citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Lucian Galade: ""He is banned from serving in any political positions in ..."*)

### Węzeł `[292]`
Mówca: **Lucian Galade**
> ""He is banned from serving in any political positions in the future and will be charged with a fine of five million Sordish Ren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Lucian Galade: ""The resettlements policies of Bergia are ruled to be unc..."*)

### Węzeł `[293]`
Mówca: **Lucian Galade**
> ""However, the Court has also rejected Ersen's arguments about the Constitution, ruling that all citizens of Sordland are Sords regardless of ethnicity and are completely equal before the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Lucian Galade: ""The results received a mixed response from the Bludish c..."*)

### Węzeł `[294]`
Mówca: **Lucian Galade**
> ""The results received a mixed response from the Bludish community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Lucian Galade: ""Activists, radicals and BFF sympathizers have condemned ..."*)

### Węzeł `[295]`
Mówca: **Lucian Galade**
> ""The resettlements policies of Bergia are ruled to be unconstitutional and have been revoked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Lucian Galade: ""However, the Court has also rejected Ersen's arguments a..."*)

### Węzeł `[296]`
Mówca: **Lucian Galade**
> ""Activists, radicals and BFF sympathizers have condemned the ruling. However, the majority seems to recognize that justice has been served.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player: ""Sollist or not, this is good news. Bergia will finally b..."*)
  - -> `[310]` (*Player: ""What more do these *activists* want? They only want to s..."*)
  - -> `[311]` (*Player: ""Thank you for informing me, Lucian. Do you have any idea..."*)

### Węzeł `[297]`
Mówca: **Lucian Galade**
> ""We've just received word about the case of Ishval Ersen. The Supreme Court has decided not to act at all, and delayed the case indefinitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Lucian Galade: ""I'm afraid Chief Justice Hawker seems to be protecting G..."*)

### Węzeł `[298]`
Mówca: **Lucian Galade**
> ""I'm afraid Chief Justice Hawker seems to be protecting Governor Bron from persecution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Lucian Galade: ""Moreover, the Bludish community in Bergia is getting inc..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist == false"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true"*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is very troubling. Do you have any idea how we can proceed?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Lucian Galade: ""I don't think there is anything we can do about it at th..."*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Ms. Morgna was right about how extreme Mr. Hawker's opinions were. I should have known this would be the outcome.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Lucian Galade: ""There was nothing you could do, sir.""*)

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Orso Hawker is going too far with this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Lucian Galade: ""He is. That's why taking away the Court's authority with..."*)

### Węzeł `[305]`
Mówca: **Lucian Galade**
> ""There was nothing you could do, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Lucian Galade: ""Our strategy should be to get public opinion behind us.""*)

### Węzeł `[306]`
Mówca: **Lucian Galade**
> ""He is. That's why taking away the Court's authority with our proposal was our highest priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Lucian Galade: ""Our strategy should be to get public opinion behind us.""*)

### Węzeł `[307]`
Mówca: **Lucian Galade**
> ""I don't think there is anything we can do about it at this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Lucian Galade: ""Our strategy should be to get public opinion behind us.""*)

### Węzeł `[308]`
Mówca: **Lucian Galade**
> ""Our strategy should be to get public opinion behind us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sollist or not, this is good news. Bergia will finally be free from Governor Bron's racist rule.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Lucian Galade: ""I agree, sir.""*)

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What more do these *activists* want? They only want to see the bad side of everything. Maybe Soll wasn't so wrong about his policies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Lucian Galade: ""As long as we can ride the aftermath of these results to..."*)

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for informing me, Lucian. Do you have any idea on how we proceed?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Lucian Galade: ""I don't think there's anything we need to do at this mom..."*)

### Węzeł `[312]`
Mówca: **Lucian Galade**
> ""I agree, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Lucian Galade: ""There is one more important detail. The seat of Governor..."*)

### Węzeł `[313]`
Mówca: **Lucian Galade**
> ""As long as we can ride the aftermath of these results to our advantage, the fringe of Bludish society won't matter for us. They can't affect the vote too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Lucian Galade: ""There is one more important detail. The seat of Governor..."*)

### Węzeł `[314]`
Mówca: **Lucian Galade**
> ""I don't think there's anything we need to do at this moment, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Lucian Galade: ""There is one more important detail. The seat of Governor..."*)

### Węzeł `[315]`
Mówca: **Lucian Galade**
> ""There is one more important detail. The seat of Governor of Bergia must be filled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Lucian Galade: ""Normally, the President appoints the Governor of the Spe..."*)

### Węzeł `[316]`
Mówca: **Lucian Galade**
> ""Normally, the President appoints the Governor of the Special Zone directly. I'm afraid despite Ms. Morgna's protests, the Court decided to take a completely different route on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Lucian Galade: ""Mr. Hawker argued that a premature departure of a govern..."*)

### Węzeł `[317]`
Mówca: **Lucian Galade**
> ""Mr. Hawker argued that a premature departure of a governor during their term is an exceptional case. They ruled that the deputy of Governor Bron will assume his duty until the end of the term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Lucian Galade: ""Mr. Kibener might have played you, unfortunately. The de..."*)

### Węzeł `[318]`
Mówca: **Lucian Galade**
> ""Mr. Kibener might have played you, unfortunately. The deputy in question -- Mr. Krull -- is a member of the NFP. I'm afraid the Court delivered Bergia straight into the NFP's hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Player: ""What!? How can they just decide to do that?""*)
  - -> `[320]` (*Player: ""I'm really questioning Ms. Morgna's advice on this now. ..."*)
  - -> `[321]` (*Player: ""This is very bad news. What do we do now?""*)
  - -> `[322]` (*Player: ""Screw Hawker! Screw Kibener! This whole system is broken!""*)

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What!? How can they just decide to do that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Lucian Galade: ""Unfortunately, there's nothing we can do about it, sir.""*)

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm really questioning Ms. Morgna's advice on this now. She should have seen this coming.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Lucian Galade: ""She's a competent woman, but she keeps underestimating t..."*)

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is very bad news. What do we do now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Lucian Galade: ""Unfortunately, there's nothing we can do about it, sir.""*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Screw Hawker! Screw Kibener! This whole system is broken!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Lucian Galade: ""And thanks to you, we are doing our best to fix it, sir.""*)

### Węzeł `[323]`
Mówca: **Lucian Galade**
> ""And thanks to you, we are doing our best to fix it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Lucian Galade: ""Luckily, Mr. Krull will not be able to resume any of his..."*)

### Węzeł `[324]`
Mówca: **Lucian Galade**
> ""She's a competent woman, but she keeps underestimating the Old Guard. Her naive idealism gets the better of her at times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Lucian Galade: ""Luckily, Mr. Krull will not be able to resume any of his..."*)

### Węzeł `[325]`
Mówca: **Lucian Galade**
> ""Unfortunately, there's nothing we can do about it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Lucian Galade: ""Luckily, Mr. Krull will not be able to resume any of his..."*)

### Węzeł `[326]`
Mówca: **Lucian Galade**
> ""Luckily, Mr. Krull will not be able to resume any of his predecessor's unconstitutional activities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron = false; BaseGame.Bergia_Go..."*)

### Węzeł `[327]`
Mówca: **Lucian Galade**
> ""Of course, giving such a powerful position to a far-right nationalist is still very concerning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Centralization == t..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Lucian Galade: ""Luckily, Ms. Graf is already working on the revocation o..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Lucian Galade: ""Luckily, Ms. Morgna is already working on the semi-auton..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Lucian Galade: ""But there is not much we can do about it at the moment.""*)

### Węzeł `[334]`
Mówca: **Lucian Galade**
> ""Luckily, Ms. Graf is already working on the revocation of the Special Zone in Bergia. We may still be able to get rid of Mr. Krull that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)

### Węzeł `[335]`
Mówca: **Lucian Galade**
> ""Luckily, Ms. Morgna is already working on the semi-autonomous zone in Bergia. We may still be able to get rid of Mr. Krull that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Centralization == t..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Lucian Galade: ""Luckily, Ms. Graf is already working on the revocation o..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true"*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Lucian Galade: ""Luckily, Ms. Morgna is already working on the semi-auton..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Lucian Galade: ""We should use every future opportunity we get to increas..."*)

### Węzeł `[342]`
Mówca: **Lucian Galade**
> ""It would likely be ready after the vote for the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Lucian Galade: ""You'd be free to enact it then.""*)

### Węzeł `[343]`
Mówca: **Lucian Galade**
> ""Luckily, Ms. Graf is already working on the revocation of the Special Zone in Bergia. We may still be able to get rid of the governor that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)

### Węzeł `[344]`
Mówca: **Lucian Galade**
> ""Luckily, Ms. Morgna is already working on the semi-autonomous zone in Bergia. We may still be able to get rid of the governor that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)

### Węzeł `[345]`
Mówca: **Lucian Galade**
> ""You'd be free to enact it then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Player: ""Great news. Tell her I'm grateful for her work on this.""*)
  - -> `[390]` (*Player: ""Thank you for letting me know.""*)
  - -> `[391]` (*Player: ""Good to know. I'm looking forward to signing it.""*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true)"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Lucian Galade: ""However... There might be a problem with its timing. It ..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker == true"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Weaker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker == true"*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Weaker == true)"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Weaker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Lucian Galade: ""However... There might be a problem with its timing. It ..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Weaker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Lucian Galade: ""It would likely be ready after the vote for the amendmen..."*)

### Węzeł `[352]`
Mówca: **Lucian Galade**
> ""However... There might be a problem with its timing. It would likely only be ready after the vote for the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Lucian Galade: ""If the vote succeeds as we've been working for, we'd be ..."*)

### Węzeł `[353]`
Mówca: **Lucian Galade**
> ""If the vote succeeds as we've been working for, we'd be removing all of your authority to enact presidential decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Lucian Galade: ""I'm afraid you'll need the approval of the Assembly in t..."*)

### Węzeł `[354]`
Mówca: **Lucian Galade**
> ""I'm afraid you'll need the approval of the Assembly in that scenario.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Lucian Galade: ""And I doubt they'll support any change to Mr. Bron's spe..."*)

### Węzeł `[355]`
Mówca: **Lucian Galade**
> ""And I doubt they'll support any change to Mr. Bron's special authority. He's been a very important member of the party, as well as an important... fundraiser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Player: ""This is ridiculous. Tell her to work faster. It needs to..."*)
  - -> `[381]` (*Player: ""I'm sure we can find a way to convince the party by then.""*)
  - -> `[382]` (*Player: ""Well... who knows whether our reforms will pass.""*)

### Węzeł `[356]`
Mówca: **Lucian Galade**
> ""However... There might be a problem with its timing. It would likely only be ready after the vote for the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Lucian Galade: ""If the vote succeeds as we've been working for, your lim..."*)

### Węzeł `[357]`
Mówca: **Lucian Galade**
> ""If the vote succeeds as we've been working for, your limited decree powers won't be enough to enact a change this grand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Lucian Galade: ""I'm afraid you'll need the approval of the Assembly in t..."*)

### Węzeł `[358]`
Mówca: **Lucian Galade**
> ""As hesitant as I am to support your decision to include changes to Article 6 and 7 in your proposal at this stage, it might allow us to bring him to justice, if the vote succeeds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Lucian Galade: ""Ms. Morgna has informed me that most of the work on the ..."*)

### Węzeł `[359]`
Mówca: **Lucian Galade**
> ""Ms. Morgna has informed me that most of the work on the wording is already done and she had reached out to the representatives of the Bludish community to get their input.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Lucian Galade: ""If you are insistent on adding this change to our propos..."*)

### Węzeł `[360]`
Mówca: **Lucian Galade**
> ""If you are insistent on adding this change to our proposal, we can discuss this in detail when the representatives arrive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Player: ""That's great news. I'm looking forward to discussing the..."*)
  - -> `[431]` (*Player: ""So you don't approve of this?""*)
  - -> `[432]` (*Player: ""I'm not completely sure if I'm going to add that to the ..."*)
  - -> `[438]` (*Player: ""Who will be representing the movement?""*)

### Węzeł `[361]`
Mówca: **Lucian Galade**
> ""It would likely be ready after the vote for the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Lucian Galade: ""You'd be free to enact it then.""*)

### Węzeł `[362]`
Mówca: **Lucian Galade**
> ""You'd be free to enact it then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Player: ""Great news. Tell her I'm grateful for her work on this.""*)
  - -> `[411]` (*Player: ""Thank you for letting me know.""*)
  - -> `[412]` (*Player: ""Good to know. I'm looking forward to signing it.""*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true)"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: ""However... There might be a problem with its timing. It ..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker == true"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Weaker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker == true"*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Weaker == true)"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Weaker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Lucian Galade: ""However... There might be a problem with its timing. It ..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Weaker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Lucian Galade: ""It would likely be ready after the vote for the amendmen..."*)

### Węzeł `[369]`
Mówca: **Lucian Galade**
> ""However... There might be a problem with its timing. It would likely be ready after the vote for the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Lucian Galade: ""If the vote succeeds as we've been working for, we'd be ..."*)

### Węzeł `[370]`
Mówca: **Lucian Galade**
> ""If the vote succeeds as we've been working for, we'd be removing all of your authority to enact presidential decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Lucian Galade: ""I'm afraid you won't be able to enact this change withou..."*)

### Węzeł `[371]`
Mówca: **Lucian Galade**
> ""However... There might be a problem with its timing. It would likely be ready after the vote for the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Lucian Galade: ""If the vote succeeds as we've been working for, your lim..."*)

### Węzeł `[372]`
Mówca: **Lucian Galade**
> ""If the vote succeeds as we've been working for, your limited decree powers won't be enough to enact a change this grand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Lucian Galade: ""I'm afraid you won't be able to enact this change withou..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Lucian Galade: ""There is one more thing.""*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He took a look at his watch."*)

### Węzeł `[376]`
Mówca: **Lucian Galade**
> ""Unfortunately, changing Articles 6 and 7 is no longer a possibility. After your statements to pressure the Court, the mood has shifted quite a bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Lucian Galade: ""Ms. Morgna has informed me that the Bludish movement has..."*)

### Węzeł `[377]`
Mówca: **Lucian Galade**
> ""But there is not much we can do about it at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Player: ""This is worrying. We must look to other ways to increase..."*)
  - -> `[414]` (*Player: ""I don't think this is a negative result. I'm sure Mr. Kr..."*)
  - -> `[415]` (*Player: ""This is bad news, Lucian. This was not my intention.""*)

### Węzeł `[378]`
Mówca: **Lucian Galade**
> ""Ms. Morgna has informed me that the Bludish movement has pulled their support from the committee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Player: ""This is very disappointing.""*)
  - -> `[445]` (*Player: ""They pull out after we include them in the process? So b..."*)
  - -> `[446]` (*Player: ""Not great. But it would probably have been worse for us ..."*)

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is very disappointing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[378]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Lucian Galade: ""These changes were not part of our initial proposal and ..."*)

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is ridiculous. Tell her to work faster. It needs to be finished before the vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Lucian Galade: ""I'll tell her immediately after our meeting, sir. But I ..."*)

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sure we can find a way to convince the party by then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well... who knows whether our reforms will pass.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Lucian Galade: ""For the sake of our administration, I certainly hope the..."*)

### Węzeł `[383]`
Mówca: **Lucian Galade**
> ""For the sake of our administration, I certainly hope they do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Lucian Galade: ""There is one more thing.""*)

### Węzeł `[384]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Lucian Galade: ""There is one more thing.""*)

### Węzeł `[385]`
Mówca: **Lucian Galade**
> ""I'll tell her immediately after our meeting, sir. But I don't think it will make any difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Lucian Galade: ""There is one more thing.""*)

### Węzeł `[386]`
Mówca: **Lucian Galade**
> ""The representatives of the Bludish community -- namely Mansoun Leke and Fetih Ejall -- have just informed me that they wish to meet with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Lucian Galade: ""They also wanted me to relay their surprise and support ..."*)

### Węzeł `[387]`
Mówca: **Lucian Galade**
> ""They also wanted me to relay their surprise and support for your statement in defense of Ishval Ersen. After all, not every USP president calls the constitution racist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Lucian Galade: ""This might have made them soften up to you. If you accep..."*)

### Węzeł `[388]`
Mówca: **Lucian Galade**
> ""This might have made them soften up to you. If you accept the meeting, it would be the first ever meeting between the WPB and a standing president. A major event for their community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Lucian Galade: ""I am not sure exactly which topics they want to bring up..."*)

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Great news. Tell her I'm grateful for her work on this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[345]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for letting me know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[345]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good to know. I'm looking forward to signing it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[345]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Lucian Galade: ""There is one more thing.""*)

### Węzeł `[392]`
Mówca: **Lucian Galade**
> ""We should use every future opportunity we get to increase our standing with the Bludish community. They may have a considerable influence on the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Player: ""I'm not doing this for the elections, Lucian.""*)
  - -> `[394]` (*Player: ""Thank you for the input.""*)
  - -> `[395]` (*Player: ""I don't think their influence is large enough for us to ..."*)

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not doing this for the elections, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[392]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for the input.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[392]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't think their influence is large enough for us to care.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[392]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Lucian Galade: ""Their numbers are not that large, but they might make a ..."*)

### Węzeł `[396]`
Mówca: **Lucian Galade**
> ""Their numbers are not that large, but they might make a critical difference if we lose the favor of the general public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Lucian Galade: ""But I agree, sir. Flirting with the Bludish community on..."*)

### Węzeł `[397]`
Mówca: **Lucian Galade**
> ""But I agree, sir. Flirting with the Bludish community only results in more loss from the nationalists. We cannot afford to do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Lucian Galade: ""There is one more thing.""*)

### Węzeł `[398]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Lucian Galade: ""There is one more thing.""*)

### Węzeł `[399]`
Mówca: **Lucian Galade**
> ""There is one more thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[400]`
Mówca: **Lucian Galade**
> ""I am not sure exactly which topics they want to bring up. But we can talk about that later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Player: ""I'm sure this is a positive development. I'd be happy to..."*)
  - -> `[423]` (*Player: ""Do you think I should accept their meeting?""*)
  - -> `[424]` (*Player: ""I don't want to be seen with them right before the vote...."*)

### Węzeł `[401]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Lucian Galade: ""There is one more thing.""*)

### Węzeł `[402]`
Mówca: **Lucian Galade**
> ""I'm afraid you won't be able to enact this change without the approval of the Assembly in that scenario.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Lucian Galade: ""It will be very hard to convince them to revoke the Spec..."*)

### Węzeł `[403]`
Mówca: **Lucian Galade**
> ""It will be very hard to convince them to revoke the Special Zone. But with Mr. Bron -- an important fundraiser for the USP -- gone, the party may be willing to move against Governor Krull.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Player: ""This is ridiculous. Tell her to work faster. It needs to..."*)
  - -> `[405]` (*Player: ""I'm sure we can find a way to convince the party by then.""*)
  - -> `[406]` (*Player: ""Well... It's not certain our reforms will pass.""*)
  - -> `[441]` (*Player: ""We should paint Mr. Krull as a threat to the party's rul..."*)

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is ridiculous. Tell her to work faster. It needs to be finished before the vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Lucian Galade: ""I'll tell her immediately after our meeting, sir. But I ..."*)

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sure we can find a way to convince the party by then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[406]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well... It's not certain our reforms will pass.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Lucian Galade: ""We have to make sure that doesn't happen for the sake of..."*)

### Węzeł `[407]`
Mówca: **Lucian Galade**
> ""We have to make sure that doesn't happen for the sake of our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He took a look at his watch."*)

### Węzeł `[408]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He took a look at his watch."*)

### Węzeł `[409]`
Mówca: **Lucian Galade**
> ""I'll tell her immediately after our meeting, sir. But I don't think that will make any difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He took a look at his watch."*)

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Great news. Tell her I'm grateful for her work on this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[362]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for letting me know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[362]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good to know. I'm looking forward to signing it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[362]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is worrying. We must look to other ways to increase our standing with our Bludish community.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't think this is a negative result. I'm sure Mr. Krull will do a good job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Lucian Galade: ""We'll congratulate him when he assumes office.""*)

### Węzeł `[415]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is bad news, Lucian. This was not my intention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Lucian Galade: ""There's no use pondering on the past, sir. We can still ..."*)

### Węzeł `[416]`
Mówca: **Lucian Galade**
> ""We'll congratulate him when he assumes office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[417]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[418]`
Mówca: **Lucian Galade**
> ""There's no use pondering on the past, sir. We can still find other ways to help the Bludish community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[419]`
Mówca: **Lucian Galade**
> ""There is one more thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Lucian Galade: ""Unfortunately, changing Articles 6 and 7 is no longer a ..."*)

### Węzeł `[420]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He took a look at his watch."*)

### Węzeł `[421]`
Mówca: **Narrator**
> "He took a look at his watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Lucian Galade: ""For now, let's return back to the real reason we are her..."*)

### Węzeł `[422]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sure this is a positive development. I'd be happy to meet them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Lucian Galade: ""I'll let them know, sir.""*)

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you think I should accept their meeting?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Lucian Galade: ""It might be risky being seen with the leader of the WPB ..."*)

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't want to be seen with them right before the vote. This can be detrimental for us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Lucian Galade: ""It holds some risk, it's true.""*)

### Węzeł `[425]`
Mówca: **Lucian Galade**
> ""It holds some risk, it's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Lucian Galade: ""They haven't officially reached out yet. When they do, i..."*)

### Węzeł `[426]`
Mówca: **Lucian Galade**
> ""They haven't officially reached out yet. When they do, it will be up to you whether you want to listen to them or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Lucian Galade: ""You can always reject their meeting altogether of course..."*)

### Węzeł `[427]`
Mówca: **Lucian Galade**
> ""I'll let them know, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Lucian Galade: ""They haven't officially reached out yet. When they do, i..."*)

### Węzeł `[428]`
Mówca: **Lucian Galade**
> ""It might be risky being seen with the leader of the WPB before the vote, but it's worth hearing them out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Lucian Galade: ""I don't think we should outright ignore our Bludish comm..."*)

### Węzeł `[429]`
Mówca: **Lucian Galade**
> ""I don't think we should outright ignore our Bludish community. However, I have to note that this is a very risky move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Lucian Galade: ""They haven't officially reached out yet. When they do, i..."*)

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's great news. I'm looking forward to discussing the changes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[360]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Lucian Galade: ""Understood, sir.""*)

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So you don't approve of this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[360]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Lucian Galade: ""I'm afraid it would be almost impossible to pass this ch..."*)

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not completely sure if I'm going to add that to the proposal yet. I'll decide on the meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[360]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Lucian Galade: ""Understood, sir.""*)

### Węzeł `[433]`
Mówca: **Lucian Galade**
> ""Understood, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He took a look at his watch."*)

### Węzeł `[434]`
Mówca: **Lucian Galade**
> ""I'm afraid it would be almost impossible to pass this change. I don't think it is worth tanking our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Lucian Galade: ""It is still not too late to cancel the meeting. But if y..."*)

### Węzeł `[435]`
Mówca: **Lucian Galade**
> ""It is still not too late to cancel the meeting. But if you do decide to meet them, I'll be there to discuss everything in detail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He took a look at his watch."*)

### Węzeł `[436]`
Mówca: **Lucian Galade**
> ""No harm done, sir. It would have been impossible to pass our reforms with these.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He took a look at his watch."*)

### Węzeł `[437]`
Mówca: **Lucian Galade**
> ""For now, let's return back to the real reason we are here. Our economic direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: "“We need to be cautious. Any grand plans about the econom..."*)

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Who will be representing the movement?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[360]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Lucian Galade: ""Mr. Leke and Mr. Ejall.""*)

### Węzeł `[439]`
Mówca: **Lucian Galade**
> ""Mr. Leke and Mr. Ejall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Lucian Galade: ""I'm afraid it will be very bad press to be seen with the..."*)

### Węzeł `[440]`
Mówca: **Lucian Galade**
> ""I'm afraid it will be very bad press to be seen with the current and former leaders of the WPB.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Lucian Galade: ""It is still not too late to cancel the meeting. But if y..."*)

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We should paint Mr. Krull as a threat to the party's rule. I believe we can take advantage of partisanship and get them behind us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Lucian Galade: ""Of course. That's a clever strategy, sir.""*)

### Węzeł `[442]`
Mówca: **Lucian Galade**
> ""Of course. That's a clever strategy, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He took a look at his watch."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron = false;
BaseGame.Bergia_Governor_Krull = true;
BaseGameSupport.News_Turn07_ST_NewGovernorKrull = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bergia_Governor_Bron"] = false;
Variable["BaseGame.Bergia_Governor_Krull"] = true;
Variable["BaseGameSupport.News_Turn07_ST_NewGovernorKrull"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_StateFigures_HerbertKrul..."*)

### Węzeł `[444]`
Mówca: **Lucian Galade**
> ""You can always reject their meeting altogether of course, so we don't lose support among Sordish nationalists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He took a look at his watch."*)

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They pull out after we include them in the process? So be it. I'm done fighting for them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[378]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Lucian Galade: ""No harm done, sir. It would have been impossible to pass..."*)

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Not great. But it would probably have been worse for us if we included those changes at the last minute.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[378]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Lucian Galade: ""No harm done, sir. It would have been impossible to pass..."*)

### Węzeł `[447]`
Mówca: **Lucian Galade**
> ""These changes were not part of our initial proposal and target, sir. I don't think much has changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He took a look at his watch."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Autocrat_YoungSords_NFP_Deal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "BaseGame.Autocrat_YoungSords_NFP_Deal == true"*)
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Autocrat_YoungSords_NFP_Deal == true)"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Autocrat_YoungSords_NFP_Deal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Anrica_YoungSordsSupportPol..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Autocrat_YoungSords_NFP_Deal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Lucian scheduled some time with me to discuss the potenti..."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Anrica_YoungSordsSupportPolice = true;
BaseGameSupport.News_Turn07_R_YSWithPolice = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Anrica_YoungSordsSupportPolice"] = true;
Variable["BaseGameSupport.News_Turn07_R_YSWithPolice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Lucian scheduled some time with me to discuss the potenti..."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true"*)
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProBlud == true)"*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Erzaren_ErsenCase_ProtestAg..."*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ErsenCase_Statement_ProBlud == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist == true"*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist == true"*)
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProSollist == true)"*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Erzaren_ErsenCase_ProtestAg..."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ErsenCase_Statement_ProSollist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false"*)
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false)"*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Erzaren_ErsenCase_ProtestAg..."*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true"*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Erzaren_ErsenCase_ProtestAgainstDelay = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Erzaren_ErsenCase_ProtestAgainstDelay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Ribel_ProBludOrDefault_BFFT..."*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Erzaren_ErsenCase_ProtestAgainstSollistOutcome = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Erzaren_ErsenCase_ProtestAgainstSollistOutcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Deyr_GovernorKrullStartsDut..."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Deyr_GovernorKrullStartsDuty = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Deyr_GovernorKrullStartsDuty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Ribel_ProSollist_BFFThreate..."*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Ribel_ProBludOrDefault_BFFThreatensJustices = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Ribel_ProBludOrDefault_BFFThreatensJustices"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_WPB_CondemnsCourtDe..."*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Ribel_ProSollist_BFFThreatensPresidentAndNFP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Ribel_ProSollist_BFFThreatensPresidentAndNFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_WPB_CondemnsCourtDe..."*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true"*)
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Ban_WPB == true)"*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Ribel_WPBBanned_BFFThreaten..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Ban_WPB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_WPB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Ribel_WPBBanned_BFFThreatensPresident = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Ribel_WPBBanned_BFFThreatensPresident"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_WPB_CondemnsCourtDecision = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_WPB_CondemnsCourtDecision"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false"*)
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false)"*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_LT_WPBCondemnsCourtDecision =..."*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_LT_WPBCondemnsCourtDecision = true;
BaseGameSupport.News_Turn07_ST_IncreasedSupportForBludishRights = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_LT_WPBCondemnsCourtDecision"] = true;
Variable["BaseGameSupport.News_Turn07_ST_IncreasedSupportForBludishRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == false && (BaseGame.Bill_Turn01_CampaignFinance_Signed == true && BaseGame.Wehlen_DefendBorder == true) == false &&
BaseGame.Wehlen_JointOperation == false && BaseGame.Reform_Reform_NFP_Convinced == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == false && ..."*)
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == false &..."*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == false && (BaseGame.Bill_Turn01_CampaignFinance_Signed == true && BaseGame.Wehlen_DefendBorder == true) == false &&
BaseGame.Wehlen_JointOperation == false && BaseGame.Reform_Reform_NFP_Convinced == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == false  and  (Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and  Variable["BaseGame.Wehlen_DefendBorder"] == true) == false  and 
Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Reform_Reform_NFP_Convinced"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Lucian Galade: ""The representatives of the Bludish community -- namely M..."*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == false && (BaseGame.Bill_Turn01_CampaignFinance_Signed == true && BaseGame.Wehlen_DefendBorder == true) == false &&
BaseGame.Wehlen_JointOperation == false && BaseGame.Reform_Reform_NFP_Convinced == false
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == false  and  (Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and  Variable["BaseGame.Wehlen_DefendBorder"] == true) == false  and 
Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Reform_Reform_NFP_Convinced"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Lucian Galade: ""Despite showing support after your statements about Ishv..."*)

### Węzeł `[479]`
Mówca: **Lucian Galade**
> ""The representatives of the Bludish community -- namely Mansoun Leke and Fetih Ejall -- have just released statements condemning our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Lucian Galade: ""They criticized your inactions on the Ersen case. And th..."*)

### Węzeł `[480]`
Mówca: **Lucian Galade**
> ""They criticized your inactions on the Ersen case. And they used a very strong language doing so, I must add.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Lucian Galade: ""They have enormous influence over our Bludish population..."*)

### Węzeł `[481]`
Mówca: **Lucian Galade**
> ""They have enormous influence over our Bludish population. Just something to be aware of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He took a look at his watch."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull = true;
BaseGameSupport.Codex_Characters_StateFigures_PhelixBron = false;
BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_ReplacedByCourt = true;

BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Bron = false;
BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Krull = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull"] = true;
Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron"] = false;
Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_ReplacedByCourt"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Bron"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Krull"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Lucian Galade: ""Of course, giving such a powerful position to a far-righ..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist == false"*)
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProSollist == false)"*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Lucian Galade: ""As hesitant as I am to support your decision to include ..."*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ErsenCase_Statement_ProSollist == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProSollist"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Lucian Galade: ""Ms. Morgna has informed me that the representatives of t..."*)

### Węzeł `[486]`
Mówca: **Lucian Galade**
> ""Ms. Morgna has informed me that the representatives of the Bludish community have abandoned the reform committee after the developments regarding the Ersen case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Lucian Galade: ""The proposal was unfortunately not finalized yet -- mean..."*)

### Węzeł `[487]`
Mówca: **Lucian Galade**
> ""The proposal was unfortunately not finalized yet -- meaning that changes to Articles 6 and 7 must be delayed for the time being.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Player: ""What? Why?""*)
  - -> `[489]` (*Player: ""I wasn't sure if I was going to add that to our reform p..."*)
  - -> `[490]` (*Player: ""That's not good.""*)

### Węzeł `[488]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What? Why?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[487]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Lucian Galade: ""They criticized both you and the Supreme Court for prote..."*)

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wasn't sure if I was going to add that to our reform proposal anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[487]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Lucian Galade: ""But I have to say that this turned out to be a better ou..."*)

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's not good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[487]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Lucian Galade: ""I don't think they are convinced to cooperate with us, s..."*)

### Węzeł `[491]`
Mówca: **Lucian Galade**
> ""They criticized both you and the Supreme Court for protecting Sollism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Lucian Galade: ""I don't think they are convinced to cooperate with us, s..."*)

### Węzeł `[492]`
Mówca: **Lucian Galade**
> ""I don't think they are convinced to cooperate with us, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Lucian Galade: ""But I have to say that this turned out to be a better ou..."*)

### Węzeł `[493]`
Mówca: **Lucian Galade**
> ""But I have to say that this turned out to be a better outcome. Adding those changes to the reforms would have been disastrous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He took a look at his watch."*)

### Węzeł `[494]`
Mówca: **Lucian Galade**
> ""They criticized your cooperation with the NFP and called your pro-Ersen statement 'an attempt of populist manipulation'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Lucian Galade: ""They have enormous influence over our Bludish population..."*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud == true"*)
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProBlud == true)"*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == false && ..."*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ErsenCase_Statement_ProBlud == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProBlud"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Lucian Galade: ""The representatives of the Bludish community -- namely M..."*)

### Węzeł `[498]`
Mówca: **Lucian Galade**
> ""Despite showing support after your statements about Ishval Ersen, the representatives of the Bludish community -- namely Mansoun Leke and Fetih Ejall -- have just released statements condemning our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)

### Węzeł `[499]`
Mówca: **Lucian Galade**
> ""They criticized your policies against the Bludish community and called your pro-Ersen statement 'a poor attempt of tricking the Bludish people'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Lucian Galade: ""They have enormous influence over our Bludish population..."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_NFP_Convinced == true )"*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Lucian Galade: ""They criticized your cooperation with the NFP and called..."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_NFP_Convinced == true
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Lucian Galade: ""They criticized your policies against the Bludish commun..."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_G_ArcasiaAtCrossroads = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_G_ArcasiaAtCrossroads"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false"*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Uziren_BFFRecruitmentKrull ..."*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_G_ArcasiaAtCrossroads = true"*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Uziren_BFFRecruitmentKrull = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Uziren_BFFRecruitmentKrull"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_G_ArcasiaAtCrossroads = true"*)
