# Sordland/Turn07/MinistryReports

- **ID konwersacji:** `119`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/119_MinistryReports.md`
- **Liczba węzłów dialogowych:** 612
- **Liczba wyborów gracza:** 61

---

## 1. Uczestnicy Sceny

- **[2]** Paskal Beniwoll
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[21]** Deivid Wisci
- **[35]** Gus Manger
- **[40]** Ciara Walda
- **[44]** Lileas Graf
- **[51]** Symon Holl
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_Alliance`
- `BaseGame.Agnolia_TradeDeal`
- `BaseGame.Arrest_FetihEjall`
- `BaseGame.BergiaSpecialZone_Proposal_Centralization`
- `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10`
- `BaseGame.Decision_Turn01_InfrastructureProject_Invest`
- `BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch`
- `BaseGame.Decision_Turn04_GruniRuralDev_NoFunding`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn04_RegionalInvestment_DontInvest`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn06_GasomSaleResult_High`
- `BaseGame.Decision_Turn06_GasomSaleResult_Low`
- `BaseGame.Decision_Turn06_GasomSaleResult_Medium`
- `BaseGame.Decision_Turn06_GasomSaleResult_VeryHigh`
- `BaseGame.Decision_Turn06_GasomStake_Keep`
- `BaseGame.Decision_Turn06_GasomStake_SellOneThird`
- `BaseGame.Decision_Turn06_GasomStake_SellTwoThird`
- `BaseGame.Decision_Turn06_Megaproject_Benfi`
- `BaseGame.Decision_Turn06_Megaproject_Conriat`
- `BaseGame.Decision_Turn06_Megaproject_Morna`
- `BaseGame.Decision_Turn06_Megaproject_NoInvestment`
- `BaseGame.Decision_Turn06_Megaproject_Sarna`
- `BaseGame.EconomicDirection_Nationalization`
- `BaseGame.Economy`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Diplomacy_EmbargoingRumburg`
- `BaseGame.Policy_Diplomacy_Wehlen_DefendBorder`
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Removed`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Order_AntiCorruptionPolice`
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Reform_Turn07_Emergency_Detained_Frens`
- `BaseGame.Relations_Nia_Opposition`
- `BaseGame.TradeDeal_Negotiation_Lespia`
- `BaseGame.TradeDeal_Negotiation_Valgsland`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn03_EnT_Education_Budget_Decrease`
- `BaseGame.Turn03_EnT_Education_Budget_Increase`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Increase`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn04_PSnW_Education_Progressive`
- `BaseGame.Turn04_SnO_LE_Interior_Decreased`
- `BaseGame.Turn05_SnO_Investigate_Oligarchs`
- `BaseGame.Turn05_SnO_Investigate_Opposition`
- `BaseGame.Turn06_InT_OnTime`
- `BaseGame.Turn06_PSnW_Education_ImproveRural`
- `BaseGame.Turn06_PSnW_Education_Salary`
- `BaseGame.Turn06_PSnW_Education_Schools`
- `BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso`
- `BaseGame.Turn07_Results_Decision_NewJusticesList`
- `BaseGame.Wehlen_TradeDeal`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.BFF_EliminationOperation`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Policy_Order_CounterTerrorismOperation`
- `BaseGame.Relations_Lileas_GendermariePromise`
- `BaseGame.Sollist`
- `BaseGameSupport.Journal_Turn07_OrderedBFFOperation`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[117] Sordland/Turn07/PlayerHub** (../Turn_07/117_PlayerHub.md), Węzeł `[43]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[47]` | **""This is all great news. Are there any concerning developments?""** | `[49]` **Narrator**: "He paused for a moment." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Symon Holl**: ""Well... One major concern is ou..."<br>`[68]` **Symon Holl**: ""Well... I don't want to get int..." |
| `[50]` | **""That's good to hear. Are there any concerning developments?""** | `[48]` **Narrator**: "He paused for a moment." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Symon Holl**: ""Well... One major concern is ou..."<br>`[68]` **Symon Holl**: ""Well... I don't want to get int..." |
| `[51]` | **""This is bad. Are there any other concerning developments?""** | `[52]` **Narrator**: "He paused for a moment." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Symon Holl**: ""Well... One major concern is ou..."<br>`[68]` **Symon Holl**: ""Well... I don't want to get int..." |
| `[54]` | **""This is terrible. Is there more to it?""** | `[53]` **Narrator**: "He paused for a moment." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Symon Holl**: ""Well... One major concern is ou..."<br>`[68]` **Symon Holl**: ""Well... I don't want to get int..." |
| `[55]` | **""Thank you, Mr. Holl.""** | `[102]` **Symon Holl**: ""I'll keep it brief for the sake..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Narrator**: "Gus stood up as soon as Symon sa..." |
| `[56]` | **""Okay. I think I've heard enough. Let's hear the next report.""** | `[48]` **Narrator**: "He paused for a moment."<br>`[49]` **Narrator**: "He paused for a moment."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Symon Holl**: ""Very well, Mr. President."" |
| `[57]` | **"Stay silent."** | `[48]` **Narrator**: "He paused for a moment."<br>`[49]` **Narrator**: "He paused for a moment."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Symon Holl**: ""Well... One major concern is ou..."<br>`[68]` **Symon Holl**: ""Well... I don't want to get int..." |
| `[103]` | **""Your concerns have been heard.""** | `[102]` **Symon Holl**: ""I'll keep it brief for the sake..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Narrator**: "Gus stood up as soon as Symon sa..." |
| `[104]` | **""Good. Let's move on to the next report.""** | `[102]` **Symon Holl**: ""I'll keep it brief for the sake..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Narrator**: "Gus stood up as soon as Symon sa..." |
| `[134]` | **""Good. Let's move on to the next report.""** | `[578]` **Gus Manger**: ""That will be all."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Narrator**: "Next up was Paskal." |
| `[135]` | **""Thank you, Mr. Manger.""** | `[578]` **Gus Manger**: ""That will be all."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Narrator**: "Next up was Paskal." |
| `[136]` | **""That was it?""** | `[578]` **Gus Manger**: ""That will be all."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Gus Manger**: ""Yes, Mr. President. We can have..." |
| `[138]` | **""Okay. We'll do that.""** | `[137]` **Gus Manger**: ""Yes, Mr. President. We can have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Narrator**: "Next up was Paskal." |
| `[139]` | **""It's fine. Let's move on.""** | `[137]` **Gus Manger**: ""Yes, Mr. President. We can have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Narrator**: "Next up was Paskal." |
| `[153]` | **""Thank you, Mr. Beniwoll.""** | `[141]` **Paskal Beniwoll**: ""I believe we can get into more ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Narrator**: "Iosef stepped up." |
| `[154]` | **""Good. Let's move on to the next report.""** | `[141]` **Paskal Beniwoll**: ""I believe we can get into more ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Narrator**: "Iosef stepped up." |
| `[155]` | **""These reports keep getting shorter.""** | `[141]` **Paskal Beniwoll**: ""I believe we can get into more ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Narrator**: "Iosef stepped up." |
| `[170]` | **""We should bring our military forces closer with Agnolia.""** | `[169]` **Iosef Lancea**: ""We cannot let them threaten us ..." | `Variable["BaseGame.Agnolia_Alliance"] == true` | *Brak zmian stanu* | `[176]` **Iosef Lancea**: ""Of course, sir. We already star..." |
| `[171]` | **""Make the necessary arrangements, Mr. Lancea. We'll have to use whatever we have t..."** | `[169]` **Iosef Lancea**: ""We cannot let them threaten us ..."<br>`[178]` **Iosef Lancea**: ""We can only trust ourselves."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Iosef Lancea**: ""Of course, sir."" |
| `[172]` | **""I don't think we should escalate. Let's refrain from sending them a response.""** | `[169]` **Iosef Lancea**: ""We cannot let them threaten us ..."<br>`[178]` **Iosef Lancea**: ""We can only trust ourselves."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Iosef Lancea**: ""Of course, sir."" |
| `[179]` | **""I've heard enough. Let's move on to the next report.""** | `[178]` **Iosef Lancea**: ""We can only trust ourselves."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "Deivid stood up." |
| `[208]` | **""Good. Let's move on to the next report.""** | `[207]` **Deivid Wisci**: ""We can talk in more detail at o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Narrator**: "Ciara was next." |
| `[209]` | **""Thank you, Mr. Wisci.""** | `[207]` **Deivid Wisci**: ""We can talk in more detail at o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Narrator**: "Ciara was next." |
| `[210]` | **""Your concerns have been heard.""** | `[207]` **Deivid Wisci**: ""We can talk in more detail at o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Narrator**: "Ciara was next." |
| `[288]` | **"“I will support you in the Gendarmerie authority transfer. Now it's your turn.”"** | `[304]` **Lileas Graf**: "“Will you transfer the Gendarmer..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Lileas_GendermariePromise"] ...` | `[284]` **Lileas Graf**: "“Excellent.”" |
| `[289]` | **"“I can't make that promise. Iosef would be furious.”"** | `[304]` **Lileas Graf**: "“Will you transfer the Gendarmer..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Lileas Graf**: "“That is unfortunate.”" |
| `[290]` | **"“I don't see Iosef accepting this.”"** | `[291]` **Lileas Graf**: "“There is one more important thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Lileas Graf**: "“Well, he just might have to agr..." |
| `[293]` | **"“I haven't heard of this before.”"** | `[291]` **Lileas Graf**: "“There is one more important thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Lileas Graf**: "“I'm still working on the propos..." |
| `[294]` | **"“If you need more help I can surely arrange a transfer.”"** | `[291]` **Lileas Graf**: "“There is one more important thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[295]` **Lileas Graf**: "“Wouldn't have brought it up if ..." |
| `[298]` | **"“Well if the security situations gets more problematic then it might be necessary.”"** | `[297]` **Lileas Graf**: "“We had several incidents where ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[302]` **Lileas Graf**: "“It will eventually cause a prob..." |
| `[299]` | **"“I am not so sure how this would help.”"** | `[297]` **Lileas Graf**: "“We had several incidents where ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Lileas Graf**: "“I can assure a better internal ..." |
| `[300]` | **"“The military is always a little too harsh.”"** | `[297]` **Lileas Graf**: "“We had several incidents where ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Lileas Graf**: "“And it results in more unrest. ..." |
| `[389]` | **""Great work as always. Thank you.""** | `[374]` **Lileas Graf**: ""I will send the final documents..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Lileas Graf**: "“There is one more important thi..."<br>`[278]` **Lileas Graf**: ""Oh also... Mr. Greiser had a re..." |
| `[390]` | **""Thank you, Lileas.""** | `[374]` **Lileas Graf**: ""I will send the final documents..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Lileas Graf**: "“There is one more important thi..."<br>`[278]` **Lileas Graf**: ""Oh also... Mr. Greiser had a re..." |
| `[391]` | **""Good to know. I'm expecting them soon, Ms. Graf.""** | `[374]` **Lileas Graf**: ""I will send the final documents..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Lileas Graf**: "“There is one more important thi..."<br>`[278]` **Lileas Graf**: ""Oh also... Mr. Greiser had a re..." |
| `[420]` | **""Great work as always. Thank you.""** | `[419]` **Nia Morgna**: ""I will send the final documents..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Nia Morgna**: ""Of course."" |
| `[421]` | **""Thank you, Nia.""** | `[419]` **Nia Morgna**: ""I will send the final documents..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Nia Morgna**: ""Of course."" |
| `[422]` | **""Good to know. I'm expecting them soon, Ms. Morgna.""** | `[419]` **Nia Morgna**: ""I will send the final documents..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Nia Morgna**: ""Of course."" |
| `[431]` | **""Great work as always. Thank you.""** | `[430]` **Nia Morgna**: ""I will send the final documents..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[479]` **Nia Morgna**: ""Of course."" |
| `[432]` | **""Thank you, Nia.""** | `[430]` **Nia Morgna**: ""I will send the final documents..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[479]` **Nia Morgna**: ""Of course."" |
| `[433]` | **""Good to know. I'm expecting them soon, Ms. Morgna.""** | `[430]` **Nia Morgna**: ""I will send the final documents..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[479]` **Nia Morgna**: ""Of course."" |
| `[443]` | **""I expected some suggestions.""** | `[405]` **Nia Morgna**: ""I'm afraid if this goes on for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[468]` **Nia Morgna**: ""I can update you more in anothe..." |
| `[444]` | **""Don't worry. We will get rid of the governor after I sign off Ms. Graf's project.""** | `[405]` **Nia Morgna**: ""I'm afraid if this goes on for ..." | `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true` | *Brak zmian stanu* | `[469]` **Nia Morgna**: ""I hope so, Mr. President."" |
| `[445]` | **""All noted. Thank you, Ms. Morgna.""** | `[405]` **Nia Morgna**: ""I'm afraid if this goes on for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[462]` **Narrator**: "Nia took her seat." |
| `[449]` | **""Thank you all for your reports.""** | `[451]` **Nia Morgna**: ""That's the extent of my report."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[462]` **Narrator**: "Nia took her seat." |
| `[450]` | **""Duly noted. Thank you, Ms. Morgna.""** | `[451]` **Nia Morgna**: ""That's the extent of my report."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[462]` **Narrator**: "Nia took her seat." |
| `[453]` | **""I think it's time we wrap up the reports and move on.""** | `[452]` **Narrator**: "Lileas smiled faintly." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[454]` | **""Thank you for your reports.""** | `[452]` **Narrator**: "Lileas smiled faintly." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[455]` | **""Do you have anything to share, Mrs. Morgna?""** | `[452]` **Narrator**: "Lileas smiled faintly." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Narrator**: "Nia shook her head." |
| `[461]` | **""So be it, Mrs. Morgna.""** | `[456]` **Nia Morgna**: ""Not at this moment, Mr. Preside..." | `Variable["BaseGame.Relations_Nia_Opposition"] == true` | *Brak zmian stanu* | `[462]` **Narrator**: "Nia took her seat." |
| `[463]` | **""I understand.""** | `[460]` **Nia Morgna**: ""I will update you on our next s..."<br>`[456]` **Nia Morgna**: ""Not at this moment, Mr. Preside..." | `Variable["BaseGame.Relations_Nia_Opposition"] == true` | *Brak zmian stanu* | `[462]` **Narrator**: "Nia took her seat." |
| `[464]` | **""Thank you.""** | `[460]` **Nia Morgna**: ""I will update you on our next s..."<br>`[456]` **Nia Morgna**: ""Not at this moment, Mr. Preside..." | `Variable["BaseGame.Relations_Nia_Opposition"] == true` | *Brak zmian stanu* | `[462]` **Narrator**: "Nia took her seat." |
| `[471]` | **""I expected some suggestions.""** | `[401]` **Nia Morgna**: ""I'm afraid if Mr. Krull retains..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[477]` **Nia Morgna**: ""I can update you more in anothe..." |
| `[472]` | **""Don't worry. We will get rid of the governor after I sign off Ms. Graf's project.""** | `[401]` **Nia Morgna**: ""I'm afraid if Mr. Krull retains..." | `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true` | *Brak zmian stanu* | `[478]` **Nia Morgna**: ""I hope so, Mr. President."" |
| `[473]` | **""All noted. Thank you, Ms. Morgna.""** | `[401]` **Nia Morgna**: ""I'm afraid if Mr. Krull retains..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[462]` **Narrator**: "Nia took her seat." |
| `[510]` | **""Actually, the circumstances have changed and I want you to hold off the operation..."** | `[524]` **Lileas Graf**: ""Our forces are now getting read..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[512]` **Lileas Graf**: ""What do you mean, Mr. President?"" |
| `[511]` | **""Good. I'll sign it now. I trust you to eliminate them once and for all.""** | `[524]` **Lileas Graf**: ""Our forces are now getting read..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[519]` **Lileas Graf**: ""Of course."" |
| `[514]` | **""I've been reading your reports and you've already done a good job. I think we can..."** | `[524]` **Lileas Graf**: ""Our forces are now getting read..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[512]` **Lileas Graf**: ""What do you mean, Mr. President?"" |
| `[516]` | **""Oh, but I can, Ms. Graf. And you will need to respect my decision.""** | `[515]` **Lileas Graf**: ""We already have very valuable f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[521]` **Lileas Graf**: ""You can't be serious."" |
| `[517]` | **""You might be right but we cannot afford to damage the tense situation in Bergia a..."** | `[515]` **Lileas Graf**: ""We already have very valuable f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[521]` **Lileas Graf**: ""You can't be serious."" |
| `[518]` | **""You might be right. I'll trust your judgement and sign the operation off.""** | `[515]` **Lileas Graf**: ""We already have very valuable f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[520]` **Lileas Graf**: ""Thank you."" |

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
  - -> `[3]` (*Narrator: "Petr gestured at Symon and he immediately stood up."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[3]`
Mówca: **Narrator**
> "Petr gestured at Symon and he immediately stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Symon Holl: ""Mr. President. Dear colleagues.""*)

### Węzeł `[4]`
Mówca: **Symon Holl**
> ""Mr. President. Dear colleagues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Symon Holl: ""Mr. Vice President was pretty on point with his summary ..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 3  and  Variable["BaseGame.GovernmentBudget"] >= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Symon Holl: ""The recession is still our number one concern. This year..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 3  and  Variable["BaseGame.GovernmentBudget"] >= -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Symon Holl: ""He also used the word 'depression.' He couldn't have bee..."*)

### Węzeł `[8]`
Mówca: **Symon Holl**
> ""The recession has been brought under control. Initial economic reports display a GDP growth of at least 2 percent this year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 0"*)

### Węzeł `[9]`
Mówca: **Iosef Lancea**
> ""The Ministry of Defense has a very important report regarding our situation with Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Iosef Lancea: ""The investigations showed that Rumburg was in fact, weap..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Symon Holl: ""The recession has been brought under control. Initial ec..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 5  and  Variable["BaseGame.GovernmentBudget"] >= -4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Symon Holl: ""The recession is slowly getting under control. We still ..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 5 && BaseGame.GovernmentBudget >= -4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 5  and  Variable["BaseGame.GovernmentBudget"] >= -4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 3 && BaseGame.GovernmentBudget >= -2"*)

### Węzeł `[16]`
Mówca: **Symon Holl**
> ""He also used the word 'depression.' He couldn't have been more correct. Our GDP has shrank by 15 percent last year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Symon Holl: ""This downward trend has broken our economy over the last..."*)

### Węzeł `[17]`
Mówca: **Symon Holl**
> ""The recession is slowly getting under control. We still couldn't reach a positive GDP growth. This year the projected value was recorded as -4 percent growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 0"*)

### Węzeł `[18]`
Mówca: **Symon Holl**
> ""The recession is still our number one concern. This year we have seen 10 percent decrease in our GDP. A shocking number.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 0"*)

### Węzeł `[19]`
Mówca: **Symon Holl**
> ""Mr. Vice President was pretty on point with his summary of the current economic status.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)

### Węzeł `[20]`
Mówca: **Symon Holl**
> ""On the other hand, unemployment has greatly declined. We have managed to cut it by almost sixty percent since we took office. It is currently projected to be 6.6 percent this year. A great achievement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Symon Holl: ""We have successfully put millions of people back to work.""*)

### Węzeł `[21]`
Mówca: **Symon Holl**
> ""This downward trend has broken our economy over the last years. If we cannot contain this in time, we will end our term -- in the truest of sense of the word -- in a depression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 0"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -4"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= -4)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= -4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Symon Holl: ""However, this has not yet reflected well with our debt s..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= -4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= -4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Symon Holl: ""However, this has not yet reflected well with our debt s..."*)

### Węzeł `[25]`
Mówca: **Symon Holl**
> ""However, this has not yet reflected well with our debt situation. Our total national debt has increased about 25 billion SR this  year. If we enter a higher deficit over the next years we will face a massive debt crisis which could crash the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)

### Węzeł `[26]`
Mówca: **Symon Holl**
> ""On the other hand, unemployment has declined. Projections display that we have managed to cut it by five percent, from 16 percent to 11.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Symon Holl: ""We have successfully put hundreds of thousands back to w..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 10 && BaseGame.GovernmentBudget >= -8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 10 && BaseGame.GovernmentBudget >= -8"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 10 && BaseGame.GovernmentBudget >= -8)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 10 && BaseGame.GovernmentBudget >= -8`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 10  and  Variable["BaseGame.GovernmentBudget"] >= -8`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Symon Holl: ""On the other hand, unemployment has greatly declined. We..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 10 && BaseGame.GovernmentBudget >= -8)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 10  and  Variable["BaseGame.GovernmentBudget"] >= -8) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)

### Węzeł `[30]`
Mówca: **Symon Holl**
> ""We have successfully put millions of people back to work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "He paused for a moment."*)

### Węzeł `[31]`
Mówca: **Symon Holl**
> ""On the other hand, unemployment reports indicate that we are going for a slight increase in employment. We have managed to cut it from 16 percent to 14 percent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Symon Holl: ""We have successfully put hundreds of thousands back to w..."*)

### Węzeł `[32]`
Mówca: **Symon Holl**
> ""We have successfully put hundreds of thousands back to work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "He paused for a moment."*)

### Węzeł `[33]`
Mówca: **Symon Holl**
> ""On the other hand, unemployment reports indicate that we achieved stability by avoiding an increase in joblessness. We are at 16 percent, the same number at the start of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "He paused for a moment."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -2"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= -2)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Symon Holl: ""On the other hand, unemployment has seen no positive cha..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGame.Decision_Turn04_RegionalInvestment_DontInvest == false && BaseGame.Decision_Turn06_Megaproject_NoInvestment == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_InfrastructureProject_Invest =..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGame.Decision_Turn04_RegionalInvestment_DontInvest == false && BaseGame.Decision_Turn06_Megaproject_NoInvestment == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true  and  Variable["BaseGame.Decision_Turn04_RegionalInvestment_DontInvest"] == false  and  Variable["BaseGame.Decision_Turn06_Megaproject_NoInvestment"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Symon Holl: ""On the other hand, unemployment reports indicate that we..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGame.Decision_Turn04_RegionalInvestment_DontInvest == false && BaseGame.Decision_Turn06_Megaproject_NoInvestment == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true  and  Variable["BaseGame.Decision_Turn04_RegionalInvestment_DontInvest"] == false  and  Variable["BaseGame.Decision_Turn06_Megaproject_NoInvestment"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Symon Holl: ""On the other hand, unemployment has seen no positive cha..."*)

### Węzeł `[40]`
Mówca: **Symon Holl**
> ""On the other hand, unemployment has seen no positive changes. On the contrary there has been an increase in joblessness. It is now at 18 percent. This is a bad indicator.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Symon Holl: ""Thousands lost their jobs.""*)

### Węzeł `[41]`
Mówca: **Symon Holl**
> ""On the other hand, unemployment has seen no positive changes. On the contrary there has been an increase in joblessness. It is now at 21 percent. This is very worrying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Symon Holl: ""Hundreds of thousands lost their jobs.""*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGame.Decision_Turn04_RegionalInvestment_DontInvest == false && BaseGame.Decision_Turn06_Megaproject_NoInvestment == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_InfrastructureProject_Invest =..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGame.Decision_Turn04_RegionalInvestment_DontInvest == false && BaseGame.Decision_Turn06_Megaproject_NoInvestment == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true  and  Variable["BaseGame.Decision_Turn04_RegionalInvestment_DontInvest"] == false  and  Variable["BaseGame.Decision_Turn06_Megaproject_NoInvestment"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Symon Holl: ""On the other hand, unemployment has seen no positive cha..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGame.Decision_Turn04_RegionalInvestment_DontInvest == false && BaseGame.Decision_Turn06_Megaproject_NoInvestment == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true  and  Variable["BaseGame.Decision_Turn04_RegionalInvestment_DontInvest"] == false  and  Variable["BaseGame.Decision_Turn06_Megaproject_NoInvestment"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Symon Holl: ""On the other hand, unemployment has seen no positive cha..."*)

### Węzeł `[45]`
Mówca: **Symon Holl**
> ""On the other hand, unemployment has seen no positive changes. There has been an increase in joblessness. It is now at 22 percent. We need immediate measures to tackle this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Symon Holl: ""Hundreds of thousands lost their jobs.""*)

### Węzeł `[46]`
Mówca: **Symon Holl**
> ""On the other hand, unemployment has seen no positive changes. There has been an increase in joblessness. It is now at 26 percent. We have lost control of the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Symon Holl: ""We caused millions of people to lose their jobs.""*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""This is all great news. Are there any concerning developments?""]** — Mówca: **Player**
> ""This is all great news. Are there any concerning developments?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[48]`
Mówca: **Narrator**
> "He paused for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: ""Okay. I think I've heard enough. Let's hear the next rep..."*)
  - -> `[50]` (*Player: ""That's good to hear. Are there any concerning developmen..."*)
  - -> `[57]` (*Player_Italic: "Stay silent."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "He paused for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: ""This is all great news. Are there any concerning develop..."*)
  - -> `[56]` (*Player: ""Okay. I think I've heard enough. Let's hear the next rep..."*)
  - -> `[57]` (*Player_Italic: "Stay silent."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""That's good to hear. Are there any concerning developments?""]** — Mówca: **Player**
> ""That's good to hear. Are there any concerning developments?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""This is bad. Are there any other concerning developments?""]** — Mówca: **Player**
> ""This is bad. Are there any other concerning developments?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "He paused for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: ""Okay. I think I've heard enough. Let's hear the next rep..."*)
  - -> `[51]` (*Player: ""This is bad. Are there any other concerning developments?""*)
  - -> `[57]` (*Player_Italic: "Stay silent."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "He paused for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: ""Okay. I think I've heard enough. Let's hear the next rep..."*)
  - -> `[57]` (*Player_Italic: "Stay silent."*)
  - -> `[54]` (*Player: ""This is terrible. Is there more to it?""*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""This is terrible. Is there more to it?""]** — Mówca: **Player**
> ""This is terrible. Is there more to it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Thank you, Mr. Holl.""]** — Mówca: **Player**
> ""Thank you, Mr. Holl.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "Gus stood up as soon as Symon sat down."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""Okay. I think I've heard enough. Let's hear the next report.""]** — Mówca: **Player**
> ""Okay. I think I've heard enough. Let's hear the next report.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator), `[49]` (Narrator), `[52]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Symon Holl: ""Very well, Mr. President.""*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I waited for him to speak."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator), `[49]` (Narrator), `[52]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)

### Węzeł `[58]`
Mówca: **Symon Holl**
> ""Very well, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "Gus stood up as soon as Symon sat down."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_OnTime == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_OnTime == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_InT_OnTime == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_OnTime == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_InT_OnTime"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_InT_OnTime == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_InT_OnTime"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Symon Holl: ""But I have to say that the failure to open our first inf..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_InfrastructureProject_Invest =..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_OnTime == true"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_InfrastructureProject_Invest == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomicDirection_Nationalization == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.EconomicDirection_Nationalization == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomicDirection_Nationalization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.EconomicDirection_Nationalization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Symon Holl: ""Well... One major concern is our nationalization decisio..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.EconomicDirection_Nationalization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.EconomicDirection_Nationalization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Symon Holl: ""Well... I don't want to get into too much detail right n..."*)

### Węzeł `[68]`
Mówca: **Symon Holl**
> ""Well... I don't want to get into too much detail right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[69]`
Mówca: **Symon Holl**
> ""Well... One major concern is our nationalization decision. Our expenses have increased.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Symon Holl: ""And it did not send a very positive signal to the global..."*)

### Węzeł `[70]`
Mówca: **Symon Holl**
> ""And it did not send a very positive signal to the global and local market. I believe this will have negative effects on our growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_TradeDeal == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Gus Manger: ""We have only recorded some development in the Agnland re..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_InfrastructureProject_Invest =..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_OnTime == true"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_InfrastructureProject_Invest == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_OnTime == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_InT_OnTime == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_InT_OnTime == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_InT_OnTime == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_InT_OnTime"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Symon Holl: ""And unfortunately, the benefits from our first infrastru..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_InT_OnTime == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_InT_OnTime"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Symon Holl: ""Also I have to say that the failure to open our first in..."*)

### Węzeł `[80]`
Mówca: **Symon Holl**
> ""Also I have to say that the failure to open our first infrastructure project was costly. But we expect to see it finished in the next months.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)

### Węzeł `[81]`
Mówca: **Symon Holl**
> ""But I have to say that the failure to open our first infrastructure project was costly. Fortunately, we expect to see it finished in the next months.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 5)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Symon Holl: ""But I have to say that sadly, our first infrastructure p..."*)

### Węzeł `[85]`
Mówca: **Symon Holl**
> ""But I have to say that sadly, our first infrastructure project has not resulted in much growth yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Benfi == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Benfi == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Symon Holl: ""But apart from all that, I'll finish with an update on o..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Benfi == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Conriat == true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Conriat == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Conriat == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Conriat == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Conriat == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Symon Holl: ""But apart from all that, I'll finish with an update on o..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Conriat == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Morna == true"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Morna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Morna == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Morna == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Morna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Symon Holl: ""But apart from all that, I'll finish with an update on o..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Morna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Sarna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Sarna == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Sarna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Symon Holl: ""But apart from all that, I'll finish with an update on o..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Sarna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Symon Holl: ""I'll keep it brief for the sake of the whole meeting, an..."*)

### Węzeł `[98]`
Mówca: **Symon Holl**
> ""But apart from all that, I'll finish with an update on our latest project. The manager reported that everything is going well and very fast with the Benfi Airport.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Symon Holl: ""I'll keep it brief for the sake of the whole meeting, an..."*)

### Węzeł `[99]`
Mówca: **Symon Holl**
> ""But apart from all that, I'll finish with an update on our latest project. The manager reported that everything is going well and very fast with the Conriat Industrial Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Symon Holl: ""I'll keep it brief for the sake of the whole meeting, an..."*)

### Węzeł `[100]`
Mówca: **Symon Holl**
> ""But apart from all that, I'll finish with an update on our latest project. The manager reported that everything is going well and very fast with the Morna Port.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Symon Holl: ""I'll keep it brief for the sake of the whole meeting, an..."*)

### Węzeł `[101]`
Mówca: **Symon Holl**
> ""But apart from all that, I'll finish with an update on our latest project. The manager reported that everything is going well and very fast with the Sarna Agricultural Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Symon Holl: ""I'll keep it brief for the sake of the whole meeting, an..."*)

### Węzeł `[102]`
Mówca: **Symon Holl**
> ""I'll keep it brief for the sake of the whole meeting, and end my report on that note.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: ""Thank you, Mr. Holl.""*)
  - -> `[103]` (*Player: ""Your concerns have been heard.""*)
  - -> `[104]` (*Player: ""Good. Let's move on to the next report.""*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""Your concerns have been heard.""]** — Mówca: **Player**
> ""Your concerns have been heard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "Gus stood up as soon as Symon sat down."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: ""Good. Let's move on to the next report.""]** — Mówca: **Player**
> ""Good. Let's move on to the next report.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "Gus stood up as soon as Symon sat down."*)

### Węzeł `[105]`
Mówca: **Gus Manger**
> ""I will also keep it very brief, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true && BaseGam..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Sarna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_Sarna == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_Sarna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Gus Manger: ""With the completion of the Sarna Agricultural Zone, we e..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_Sarna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == t..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Gus Manger: ""Investments in the region have greatly increased our agr..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5 && (BaseGame.Decision_Turn04_Region..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Turn06_InT_OnTime == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true && BaseGam..."*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Railway == true && BaseG..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Turn06_InT_OnTime == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  and  Variable["BaseGame.Turn06_InT_OnTime"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Gus Manger: ""The L-1 railway has already proven to be a success. We h..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Turn06_InT_OnTime == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  and  Variable["BaseGame.Turn06_InT_OnTime"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_TradeDeal == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Gus Manger: ""The trade deal with Wehlen increased our agricultural ex..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5 && (BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true || BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5 && (BaseGame.Decision_Turn04_Region..."*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 5 && (BaseGame.Decision_Turn04_Regi..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 5 && (BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true || BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 5  and  (Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true  or  Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch"] == true  or  Variable["BaseGame.Decision_Turn04_GruniRuralDev_NoFunding"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Gus Manger: ""We are slowly but surely, reigniting our agricultural pr..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 5 && (BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true || BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch == true || BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 5  and  (Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true  or  Variable["BaseGame.Decision_Turn04_GruniRuralDev_FundedCropResearch"] == true  or  Variable["BaseGame.Decision_Turn04_GruniRuralDev_NoFunding"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Gus Manger: ""Our farmers are still suffering. Our ministry did it's b..."*)

### Węzeł `[121]`
Mówca: **Gus Manger**
> ""The L-1 railway has already proven to be a success. We have managed to bring food prices down in the Greater Holsord and Gelsland regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Gus Manger: ""Our agricultural output has increased and we are already..."*)

### Węzeł `[122]`
Mówca: **Gus Manger**
> ""Our agricultural output has increased and we are already seeing investments coming into rural areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[123]`
Mówca: **Gus Manger**
> ""The trade deal with Wehlen increased our agricultural exports from the Bergia region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == t..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Gus Manger: ""Our investments in Bergia have greatly increased our agr..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 5 && (BaseGame.Decision_Turn04_Region..."*)

### Węzeł `[127]`
Mówca: **Gus Manger**
> ""Investments in the region have greatly increased our agricultural capacity. The investments also led to a decrease in homelessness and unemployment in rural Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)

### Węzeł `[128]`
Mówca: **Gus Manger**
> ""Our investments in Bergia have greatly increased our agricultural capacity. The investments also led to a decrease in homelessness and unemployment in rural Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Sarna == true"*)

### Węzeł `[129]`
Mówca: **Gus Manger**
> ""We are slowly but surely, reigniting our agricultural production. Our ministry is aiding the farmers with government subsidies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Gus Manger: ""We're sure this will have a positive reflection on our e..."*)

### Węzeł `[130]`
Mówca: **Gus Manger**
> ""Our farmers are still suffering. Our ministry did it's best by giving out subsidies to local farmers but our agricultural production remains the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[131]`
Mówca: **Gus Manger**
> ""We're sure this will have a positive reflection on our economy in the near future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)

### Węzeł `[132]`
Mówca: **Gus Manger**
> ""With the completion of the Sarna Agricultural Zone, we expect to see Bergia as a new economic powerhouse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)

### Węzeł `[133]`
Mówca: **Gus Manger**
> ""We have only recorded some development in the Agnland region, but our farmers in Gelsland and Bergia are still suffering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)

### Węzeł `[134]`
**[WYBÓR GRACZA: ""Good. Let's move on to the next report.""]** — Mówca: **Player**
> ""Good. Let's move on to the next report.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[578]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "Next up was Paskal."*)

### Węzeł `[135]`
**[WYBÓR GRACZA: ""Thank you, Mr. Manger.""]** — Mówca: **Player**
> ""Thank you, Mr. Manger.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[578]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "Next up was Paskal."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: ""That was it?""]** — Mówca: **Player**
> ""That was it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[578]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Gus Manger: ""Yes, Mr. President. We can have a separate meeting to ta..."*)

### Węzeł `[137]`
Mówca: **Gus Manger**
> ""Yes, Mr. President. We can have a separate meeting to take a deep look at the numbers at the Ministry, if you'd like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player: ""Okay. We'll do that.""*)
  - -> `[139]` (*Player: ""It's fine. Let's move on.""*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""Okay. We'll do that.""]** — Mówca: **Player**
> ""Okay. We'll do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "Next up was Paskal."*)

### Węzeł `[139]`
**[WYBÓR GRACZA: ""It's fine. Let's move on.""]** — Mówca: **Player**
> ""It's fine. Let's move on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "Next up was Paskal."*)

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true"*)

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
> ""I believe we can get into more details in our policy meeting soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player: ""Thank you, Mr. Beniwoll.""*)
  - -> `[155]` (*Player: ""These reports keep getting shorter.""*)
  - -> `[154]` (*Player: ""Good. Let's move on to the next report.""*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Paskal Beniwoll: ""The same problems we previously discussed are still pers..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Paskal Beniwoll: ""Our state facilities require immediate attention. We are..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Paskal Beniwoll: ""There are currently no major problems within the Ministr..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true"*)

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
> ""There are currently no major problems within the Ministry of Health.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Paskal Beniwoll: ""We are currently investigating some reports of a small p..."*)

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
> ""The same problems we previously discussed are still persisting. But our ministry is not facing any immediate issues at this moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Paskal Beniwoll: ""We are currently investigating some reports of a small p..."*)

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
> ""We are currently investigating some reports of a small polio outbreak around a village called Heymir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Paskal Beniwoll: ""I believe we can get into more details in our policy mee..."*)

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
> ""Our state facilities require immediate attention. We are experiencing long lines in front of hospitals everywhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Paskal Beniwoll: ""We are also currently investigating some reports of a sm..."*)

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
> ""We are also currently investigating some reports of a small polio outbreak around a village called Heymir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Paskal Beniwoll: ""I believe we can get into more details in our policy mee..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: ""Thank you, Mr. Beniwoll.""]** — Mówca: **Player**
> ""Thank you, Mr. Beniwoll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Iosef stepped up."*)

### Węzeł `[154]`
**[WYBÓR GRACZA: ""Good. Let's move on to the next report.""]** — Mówca: **Player**
> ""Good. Let's move on to the next report.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Iosef stepped up."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: ""These reports keep getting shorter.""]** — Mówca: **Player**
> ""These reports keep getting shorter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Iosef stepped up."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "Iosef stepped up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Iosef Lancea: ""The Ministry of Defense has a very important report rega..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Iosef Lancea: ""We urgently need to increase our own military production.""*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Iosef Lancea: ""Our military has no means to stand against such a superi..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Iosef Lancea: ""Our military forces don't have the budget to prepare aga..."*)

### Węzeł `[163]`
Mówca: **Iosef Lancea**
> ""The investigations showed that Rumburg was in fact, weaponizing rebels against our state. We have learned that they have been aiding the Bludish rebels in Wehlen too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Iosef Lancea: ""Our military must stand ready for any possible attack co..."*)

### Węzeł `[164]`
Mówca: **Iosef Lancea**
> ""Our military must stand ready for any possible attack coming from Rumburg. We have gathered intelligence regarding their military research and production.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Iosef Lancea: ""They are building a massive army.""*)

### Węzeł `[165]`
Mówca: **Iosef Lancea**
> ""They are building a massive army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)

### Węzeł `[166]`
Mówca: **Iosef Lancea**
> ""We urgently need to increase our own military production.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Iosef Lancea: ""We cannot let them threaten us like this.""*)

### Węzeł `[167]`
Mówca: **Iosef Lancea**
> ""Our military has no means to stand against such a superior force if we do not deploy new tactics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Iosef Lancea: ""We cannot let them threaten us like this.""*)

### Węzeł `[168]`
Mówca: **Iosef Lancea**
> ""Our military forces don't have the budget to prepare against such a force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Iosef Lancea: ""We cannot let them threaten us like this.""*)

### Węzeł `[169]`
Mówca: **Iosef Lancea**
> ""We cannot let them threaten us like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player: ""Make the necessary arrangements, Mr. Lancea. We'll have ..."*)
  - -> `[172]` (*Player: ""I don't think we should escalate. Let's refrain from sen..."*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""We should bring our military forces closer with Agnolia.""]** — Mówca: **Player**
> ""We should bring our military forces closer to Agnolia.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Kontekst wejściowy (poprzednik):** `[169]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Iosef Lancea: ""Of course, sir. We already started cooperating. But I mu..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA: ""Make the necessary arrangements, Mr. Lancea. We'll have to use whatever we have to its limit.""]** — Mówca: **Player**
> ""Make the necessary arrangements, Mr. Lancea. We'll have to use whatever we have to its limit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Iosef Lancea), `[178]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Iosef Lancea: ""Of course, sir.""*)

### Węzeł `[172]`
**[WYBÓR GRACZA: ""I don't think we should escalate. Let's refrain from sending them a response.""]** — Mówca: **Player**
> ""I don't think we should escalate. Let's refrain from sending them a response.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Iosef Lancea), `[178]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Iosef Lancea: ""Of course, sir.""*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player: ""We should bring our military forces closer with Agnolia.""*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[176]`
Mówca: **Iosef Lancea**
> ""Of course, sir. We already started cooperating. But I must highlight that Agnolia cannot stand against Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Iosef Lancea: ""We can only trust ourselves.""*)

### Węzeł `[177]`
Mówca: **Iosef Lancea**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Deivid stood up."*)

### Węzeł `[178]`
Mówca: **Iosef Lancea**
> ""We can only trust ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player: ""Make the necessary arrangements, Mr. Lancea. We'll have ..."*)
  - -> `[172]` (*Player: ""I don't think we should escalate. Let's refrain from sen..."*)
  - -> `[179]` (*Player: ""I've heard enough. Let's move on to the next report.""*)

### Węzeł `[179]`
**[WYBÓR GRACZA: ""I've heard enough. Let's move on to the next report.""]** — Mówca: **Player**
> ""I've heard enough. Let's move on to the next report.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Deivid stood up."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "Deivid stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGame..."*)

### Węzeł `[181]`
Mówca: **Deivid Wisci**
> ""Mr. President. Perla and Haelm have agreed to begin deal negotiations. We will be moving on with that very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGame.TradeDeal_Negotiation_Valgsland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGame..."*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGa..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGame.TradeDeal_Negotiation_Valgsland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == true  and  Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Deivid Wisci: ""Mr. President. Perla and Haelm have agreed to begin deal..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGame.TradeDeal_Negotiation_Valgsland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == true  and  Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Lespia == true || BaseGame..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Lespia == true || BaseGame.TradeDeal_Negotiation_Valgsland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Lespia == true || BaseGame..."*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.TradeDeal_Negotiation_Lespia == true || BaseGa..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Lespia == true || BaseGame.TradeDeal_Negotiation_Valgsland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == true  or  Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Lespia == true"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.TradeDeal_Negotiation_Lespia == true || BaseGame.TradeDeal_Negotiation_Valgsland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == true  or  Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Deivid Wisci: ""Mr. President.""*)

### Węzeł `[188]`
Mówca: **Deivid Wisci**
> ""Mr. President. Perla has agreed to begin deal negotiations. We will be moving on with that very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Lespia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Lespia == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.TradeDeal_Negotiation_Lespia == true)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Lespia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Deivid Wisci: ""Mr. President. Perla has agreed to begin deal negotiatio..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.TradeDeal_Negotiation_Lespia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Deivid Wisci: ""Mr. President. Haelm has agreed to begin deal negotiatio..."*)

### Węzeł `[192]`
Mówca: **Deivid Wisci**
> ""Mr. President. Haelm has agreed to begin deal negotiations. We will be moving on with that very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_TradeDeal == true)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Deivid Wisci: ""Our relations with Agnolia have greatly improved. Our mi..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[196]`
Mówca: **Deivid Wisci**
> ""Our relations with Agnolia have greatly improved. Our ministries have scheduled many joint projects together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_TradeDeal == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Deivid Wisci: ""Cooperation between Wehlen and Sordland has increased to..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Lespia == true || BaseGame..."*)

### Węzeł `[200]`
Mówca: **Deivid Wisci**
> ""Cooperation between Wehlen and Sordland has increased to a new level. However, we are seeing its negative impact with Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Deivid Wisci: ""The region is very unstable. With the incidents at Rumbu..."*)

### Węzeł `[201]`
Mówca: **Deivid Wisci**
> ""Today, we are more isolated than ever. We have no good relations with any of our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Deivid Wisci: ""The region is very unstable. With the incidents at Rumbu..."*)

### Węzeł `[202]`
Mówca: **Deivid Wisci**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Lespia == true || BaseGame.TradeDeal_Negotiation_Valgsland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Lespia == true || BaseGame..."*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.TradeDeal_Negotiation_Lespia == true || BaseGa..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Lespia == true || BaseGame.TradeDeal_Negotiation_Valgsland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == true  or  Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Deivid Wisci: ""The region is very unstable. With the incidents at Rumbu..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.TradeDeal_Negotiation_Lespia == true || BaseGame.TradeDeal_Negotiation_Valgsland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == true  or  Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Deivid Wisci: ""Today, we are more isolated than ever. We have no good r..."*)

### Węzeł `[206]`
Mówca: **Deivid Wisci**
> ""The region is very unstable. With the incidents at Rumburg, Wehlen and Heljiland, we must be very cautious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Deivid Wisci: ""We can talk in more detail at our foreign policy meeting.""*)

### Węzeł `[207]`
Mówca: **Deivid Wisci**
> ""We can talk in more detail at our foreign policy meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player: ""Thank you, Mr. Wisci.""*)
  - -> `[210]` (*Player: ""Your concerns have been heard.""*)
  - -> `[208]` (*Player: ""Good. Let's move on to the next report.""*)

### Węzeł `[208]`
**[WYBÓR GRACZA: ""Good. Let's move on to the next report.""]** — Mówca: **Player**
> ""Good. Let's move on to the next report.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "Ciara was next."*)

### Węzeł `[209]`
**[WYBÓR GRACZA: ""Thank you, Mr. Wisci.""]** — Mówca: **Player**
> ""Thank you, Mr. Wisci.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "Ciara was next."*)

### Węzeł `[210]`
**[WYBÓR GRACZA: ""Your concerns have been heard.""]** — Mówca: **Player**
> ""Your concerns have been heard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "Ciara was next."*)

### Węzeł `[211]`
Mówca: **Narrator**
> "Ciara was next."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)

### Węzeł `[212]`
Mówca: **Ciara Walda**
> ""Our Ministry is working day and night to improve our education system and increase its accessibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_ImproveRural == true"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Increase == true"*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Ciara Walda: ""Our Ministry is working day and night to improve our edu..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Ciara Walda: ""Our Ministry is working day and night to improve our edu..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Ciara Walda: ""Our Ministry is working day and night to improve our edu..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_ImproveRural == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_ImproveRural == true"*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Education_ImproveRural == true)"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_ImproveRural == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Ciara Walda: ""We have since greatly improved our rural education, buil..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Education_ImproveRural == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Salary == true"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Salary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Salary == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Education_Salary == true)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Salary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_Salary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Ciara Walda: ""We have since greatly improved the standards of our teac..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Education_Salary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_Salary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Schools == true"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Schools == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Schools == true"*)
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Education_Schools == true)"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Schools == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_Schools"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Ciara Walda: ""We have since built about 100 new schools and improved a..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Education_Schools == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_Schools"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[228]`
Mówca: **Ciara Walda**
> ""We have since greatly improved our rural education, building new schools and bringing new equipment and books.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[229]`
Mówca: **Ciara Walda**
> ""We have since greatly improved the standards of our teachers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[230]`
Mówca: **Ciara Walda**
> ""We have since built about 100 new schools and improved accessibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[231]`
Mówca: **Ciara Walda**
> ""Our Ministry is working day and night to improve our education system and increase its accessibility. But the lack of funding has made it very difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Ciara Walda: ""The situation remains the same as before.""*)

### Węzeł `[232]`
Mówca: **Ciara Walda**
> ""The situation remains the same as before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "Her eyes were filled with fury."*)

### Węzeł `[233]`
Mówca: **Narrator**
> "Her eyes were filled with fury."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "Lileas suddenly stood up."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Progressive == true)"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Ciara Walda: ""We have accomplished a lot with our new curriculum. Our ..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Progressive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Ciara Walda: ""It doesn't mean we are not plagued with problems. You ar..."*)

### Węzeł `[237]`
Mówca: **Ciara Walda**
> ""It doesn't mean we are not plagued with problems. You are already aware of those.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "Lileas suddenly stood up."*)

### Węzeł `[238]`
Mówca: **Ciara Walda**
> ""We have accomplished a lot with our new curriculum. Our reforms will be greatly improving our output as a society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "Lileas suddenly stood up."*)

### Węzeł `[239]`
Mówca: **Narrator**
> "Lileas suddenly stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Lileas Graf: ""Mr. President.""*)

### Węzeł `[240]`
Mówca: **Lileas Graf**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Lileas Graf: ""Oh also... Mr. Greiser had a report for you. Regarding a..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Opposition == true"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Opposition == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_Opposition == true)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Lileas Graf: ""Oh also... Mr. Greiser had a report for you. Regarding a..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lileas Graf: "“There is one more important thing to ask of you. I would..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= -1"*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= -1)"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= -1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Lileas Graf: ""There is an important report from our intelligence offic..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= -1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true || BaseGa..."*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true || Base..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  or  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  or  Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lileas Graf: "“There is one more important thing to ask of you. I would..."*)

### Węzeł `[253]`
Mówca: **Lileas Graf**
> ""There is an important report from our intelligence officers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Lileas Graf: ""We have disrupted the radio signals of several active Bl..."*)

### Węzeł `[254]`
Mówca: **Lileas Graf**
> ""We have disrupted the radio signals of several active Bludish Freedom Front militants in Bergia. There seems to be some sort of preparation going on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Lileas Graf: ""Our forces managed to eliminate 22 militants. They were ..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -3"*)

### Węzeł `[258]`
Mówca: **Lileas Graf**
> ""Our forces managed to eliminate 22 militants. They were carrying Rumburg-made KA-74s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -3"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -3"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion <= -3)"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Lileas Graf: ""Our police is also under pressure from people beginning ..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion <= -3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn07_Emergency_Detained_Frens == true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion <= -5)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Lileas Graf: ""There is an important report from our intelligence offic..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion <= -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true"*)

### Węzeł `[265]`
Mówca: **Lileas Graf**
> ""There is an important report from our intelligence officers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Lileas Graf: ""We have disrupted an illegal arms deal that was taking p..."*)

### Węzeł `[266]`
Mówca: **Lileas Graf**
> ""We have disrupted an illegal arms deal that was taking place inside our borders. There seems to be several anti-government groups organizing against large-scale attacks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Lileas Graf: ""Our forces managed to arrest 53 suspects already. 20 of ..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn07_Emergency_Detained_Frens == true"*)

### Węzeł `[270]`
Mówca: **Lileas Graf**
> ""Our forces managed to arrest 53 suspects already. 20 of them had military grade Rumburg-made KA-74s stashed in their private properties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn07_Emergency_Detained_Frens == true"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == t..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Lileas Graf: ""Our police forces are still suffering. The regions of Be..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lileas Graf: ""We have important equipment missing from several of our ..."*)

### Węzeł `[274]`
Mówca: **Lileas Graf**
> ""Our police forces are still suffering. The regions of Bergia and Nargis are ridden with crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn07_Emergency_Detained_Frens == true"*)

### Węzeł `[275]`
Mówca: **Lileas Graf**
> ""We have important equipment missing from several of our major police departments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn07_Emergency_Detained_Frens == true"*)

### Węzeł `[276]`
Mówca: **Lileas Graf**
> ""We might need to implement some new measures soon. We will provide you with a more detailed report at a later date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[277]`
Mówca: **Lileas Graf**
> ""Our police is also under pressure from people beginning to protest again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn07_Emergency_Detained_Frens == true"*)

### Węzeł `[278]`
Mówca: **Lileas Graf**
> ""Oh also... Mr. Greiser had a report for you. Regarding an investigation you wanted him to look at.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lileas Graf: "“There is one more important thing to ask of you. I would..."*)

### Węzeł `[279]`
Mówca: **Lileas Graf**
> ""Also, Mr. Ricter was arrested and transported to the Antel Rock prison facilities today among heavy protests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Lileas Graf: ""We might need to implement some new measures soon. We wi..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Turn07_Emergency_Detained_Frens == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn07_Emergency_Detained_Frens == true"*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Turn07_Emergency_Detained_Frens == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Lileas Graf: ""Also, Mr. Ricter was arrested and transported to the Ant..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Lileas Graf: ""We might need to implement some new measures soon. We wi..."*)

### Węzeł `[283]`
Mówca: **Symon Holl**
> ""And unfortunately, the benefits from our first infrastructure project don't look set to offset that loss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_Benfi == true"*)

### Węzeł `[284]`
Mówca: **Lileas Graf**
> "“Excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_..."*)

### Węzeł `[285]`
Mówca: **Lileas Graf**
> "“I'm still working on the proposal and have legal backing for it. I was going to mention it later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Lileas Graf: "“The Ministry of Defense shouldn't be meddling with inter..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lileas_GendermariePromise = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Lileas_GendermariePromise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lileas Graf: "“Excellent.”"*)

### Węzeł `[287]`
Mówca: **Lileas Graf**
> "“Well, he just might have to agree if the President of Sordland tells him to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Lileas Graf: "“The Ministry of Defense shouldn't be meddling with inter..."*)

### Węzeł `[288]`
**[WYBÓR GRACZA: "“I will support you in the Gendarmerie authority transfer. Now it's your turn.”"]** — Mówca: **Player**
> "“I will support you in the Gendarmerie authority transfer. Now it's your turn.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise = true"*)

### Węzeł `[289]`
**[WYBÓR GRACZA: "“I can't make that promise. Iosef would be furious.”"]** — Mówca: **Player**
> "“I can't make that promise. Iosef would be furious.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Lileas Graf: "“That is unfortunate.”"*)

### Węzeł `[290]`
**[WYBÓR GRACZA: "“I don't see Iosef accepting this.”"]** — Mówca: **Player**
> "“I don't see Iosef accepting this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[291]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Lileas Graf: "“Well, he just might have to agree if the President of So..."*)

### Węzeł `[291]`
Mówca: **Lileas Graf**
> "“There is one more important thing to ask of you. I would like to transfer the Gendarmerie under the Ministry of Interior to improve the internal security efforts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Player: "“I haven't heard of this before.”"*)
  - -> `[290]` (*Player: "“I don't see Iosef accepting this.”"*)
  - -> `[294]` (*Player: "“If you need more help I can surely arrange a transfer.”"*)

### Węzeł `[292]`
Mówca: **Lileas Graf**
> "“That is unfortunate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_..."*)

### Węzeł `[293]`
**[WYBÓR GRACZA: "“I haven't heard of this before.”"]** — Mówca: **Player**
> "“I haven't heard of this before.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[291]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Lileas Graf: "“I'm still working on the proposal and have legal backing..."*)

### Węzeł `[294]`
**[WYBÓR GRACZA: "“If you need more help I can surely arrange a transfer.”"]** — Mówca: **Player**
> "“If you need more help I can surely arrange a transfer.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[291]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Lileas Graf: "“Wouldn't have brought it up if it was not necessary.”"*)

### Węzeł `[295]`
Mówca: **Lileas Graf**
> "“Wouldn't have brought it up if it was not necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Lileas Graf: "“The Ministry of Defense shouldn't be meddling with inter..."*)

### Węzeł `[296]`
Mówca: **Lileas Graf**
> "“The Ministry of Defense shouldn't be meddling with internal security affairs through the Gendarmerie.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Lileas Graf: "“We had several incidents where they were too violent too..."*)

### Węzeł `[297]`
Mówca: **Lileas Graf**
> "“We had several incidents where they were too violent too quickly and it stems from military officers giving reckless orders at times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Player: "“The military is always a little too harsh.”"*)
  - -> `[298]` (*Player: "“Well if the security situations gets more problematic th..."*)
  - -> `[299]` (*Player: "“I am not so sure how this would help.”"*)

### Węzeł `[298]`
**[WYBÓR GRACZA: "“Well if the security situations gets more problematic then it might be necessary.”"]** — Mówca: **Player**
> "“Well if the security situations gets more problematic then it might be necessary.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Lileas Graf: "“It will eventually cause a problem between our forces. T..."*)

### Węzeł `[299]`
**[WYBÓR GRACZA: "“I am not so sure how this would help.”"]** — Mówca: **Player**
> "“I am not so sure how this would help.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Lileas Graf: "“I can assure a better internal security structure with c..."*)

### Węzeł `[300]`
**[WYBÓR GRACZA: "“The military is always a little too harsh.”"]** — Mówca: **Player**
> "“The military is always a little too harsh.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Lileas Graf: "“And it results in more unrest. Our police forces are tra..."*)

### Węzeł `[301]`
Mówca: **Lileas Graf**
> "“And it results in more unrest. Our police forces are trained to remain calm and suppress protests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lileas Graf: "“Will you transfer the Gendarmerie to the Interior in the..."*)

### Węzeł `[302]`
Mówca: **Lileas Graf**
> "“It will eventually cause a problem between our forces. There are already miscommunications going on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lileas Graf: "“Will you transfer the Gendarmerie to the Interior in the..."*)

### Węzeł `[303]`
Mówca: **Lileas Graf**
> "“I can assure a better internal security structure with cohesion and successful operations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lileas Graf: "“Will you transfer the Gendarmerie to the Interior in the..."*)

### Węzeł `[304]`
Mówca: **Lileas Graf**
> "“Will you transfer the Gendarmerie to the Interior in the future?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player: "“I will support you in the Gendarmerie authority transfer..."*)
  - -> `[289]` (*Player: "“I can't make that promise. Iosef would be furious.”"*)

### Węzeł `[305]`
Mówca: **Narrator**
> "Gus stood up as soon as Symon sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Gus Manger: ""I will also keep it very brief, Mr. President.""*)

### Węzeł `[306]`
Mówca: **Narrator**
> "Next up was Paskal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Paskal Beniwoll: ""Mr. President.""*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6"*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Symon Holl: ""On the other hand, unemployment has declined. Projection..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 7 && BaseGame.GovernmentBudget >= -6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 7  and  Variable["BaseGame.GovernmentBudget"] >= -6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Symon Holl: ""On the other hand, unemployment has declined very slight..."*)

### Węzeł `[310]`
Mówca: **Symon Holl**
> ""On the other hand, unemployment has declined very slightly. Initial reports indicate that we managed to cut it by three percentage points, from 16 percent to 13 percent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Symon Holl: ""We have successfully put hundreds of thousands back to w..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 6"*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 6)"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Symon Holl: ""On the other hand, unemployment reports indicate that we..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Symon Holl: ""On the other hand, unemployment reports indicate that we..."*)

### Węzeł `[314]`
Mówca: **Symon Holl**
> ""On the other hand, unemployment reports indicate that we achieved a minimal increase in employment. It looks like we managed to cut it from 16 percent to 15 percent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Symon Holl: ""Thousands were put back to work.""*)

### Węzeł `[315]`
Mówca: **Symon Holl**
> ""Thousands were put back to work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "He paused for a moment."*)

### Węzeł `[316]`
Mówca: **Symon Holl**
> ""We have successfully put hundreds of thousands back to work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "He paused for a moment."*)

### Węzeł `[317]`
Mówca: **Symon Holl**
> ""Hundreds of thousands lost their jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "He paused for a moment."*)

### Węzeł `[318]`
Mówca: **Symon Holl**
> ""Hundreds of thousands lost their jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "He paused for a moment."*)

### Węzeł `[319]`
Mówca: **Symon Holl**
> ""We caused millions of people to lose their jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "He paused for a moment."*)

### Węzeł `[320]`
Mówca: **Symon Holl**
> ""Thousands lost their jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "He paused for a moment."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 0"*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= 0)"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Symon Holl: ""Thanks to our balanced budget we are eyeing a sizeable r..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -4"*)

### Węzeł `[324]`
Mówca: **Symon Holl**
> ""Thanks to our balanced budget we are eyeing a sizeable reduction in our national debt at the end of the term. If my economic projections hold up along with the current trends of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)

### Węzeł `[325]`
Mówca: **Symon Holl**
> ""However, this has not yet reflected well with our debt situation. Our total national debt has increased about 45 billion SR this year. If we maintain such a deficit over the next years we will face a massive debt crisis which could crash the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)

### Węzeł `[326]`
Mówca: **Symon Holl**
> ""The assembly is working on introducing new tax bills which will generate more revenue for the government. These efforts will depend on the government deficit situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 10 && BaseGame.GovernmentBudget >= -8"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget < 0)"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Symon Holl: ""The assembly is working on introducing new tax bills whi..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 10 && BaseGame.GovernmentBudget >= -8"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -3"*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= -3)"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= -3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Symon Holl: ""However, this has not yet reflected well with our debt s..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= -3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= -3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Symon Holl: ""However, this has not yet reflected well with our debt s..."*)

### Węzeł `[333]`
Mówca: **Symon Holl**
> ""However, this has not yet reflected well with our debt situation. Our total national debt has increased about 35 billion SR this year. If we enter a higher deficit over the next years we will face a massive debt crisis which could crash the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget < 0)"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Symon Holl: ""The assembly is working on introducing new tax bills whi..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 6"*)

### Węzeł `[337]`
Mówca: **Symon Holl**
> ""Thanks to our balanced budget we are eyeing a slight reduction in our national debt at the end of the term. If my economic projections hold up along with the current trends of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)

### Węzeł `[338]`
Mówca: **Symon Holl**
> ""However, this has not yet reflected well with our debt situation. Our total national debt has increased about 55 billion SR this year. If we maintain such a deficit over the next years we will face a massive debt crisis which could crash the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 0"*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= 0)"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Symon Holl: ""Thanks to our balanced budget we are eyeing a slight red..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -3"*)

### Węzeł `[342]`
Mówca: **Symon Holl**
> ""The assembly is working on introducing new tax bills which will generate more revenue for the government. These efforts will depend on the government deficit situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 6"*)

### Węzeł `[343]`
Mówca: **Symon Holl**
> ""The assembly is working on introducing new tax bills which will generate more revenue for the government. These efforts will depend on the government deficit situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -2"*)

### Węzeł `[344]`
Mówca: **Symon Holl**
> ""However, this has not yet reflected well with our debt situation. Our total national debt has increased about 45 billion SR this year. If we enter a higher deficit over the next years we will face a massive debt crisis which could crash the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)

### Węzeł `[345]`
Mówca: **Symon Holl**
> ""Thanks to our balanced budget we are expecting a slight increase in our national debt at the end of the term. If my economic projections hold up along with the current trends of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)

### Węzeł `[346]`
Mówca: **Symon Holl**
> ""However, this has not yet reflected well with our debt situation. Our total national debt has increased about 65 billion SR this year. If we maintain such a deficit over the next years we will face a massive debt crisis which could crash the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -2"*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= -2)"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Symon Holl: ""However, this has not yet reflected well with our debt s..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Symon Holl: ""However, this has not yet reflected well with our debt s..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget < 0)"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Symon Holl: ""The assembly is working on introducing new tax bills whi..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -2"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 0"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= 0)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Symon Holl: ""Thanks to our balanced budget we are expecting a slight ..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -2"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget < 0)"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Symon Holl: ""The assembly is working on introducing new tax bills whi..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[359]`
Mówca: **Symon Holl**
> ""The assembly is working on introducing new tax bills which will generate more revenue for the government. These efforts will depend on the government deficit situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[360]`
Mówca: **Symon Holl**
> ""Thanks to our balanced budget we are eyeing a manageable increase in our national debt at the end of the term. If my economic projections hold up along with the current trends of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)

### Węzeł `[361]`
Mówca: **Symon Holl**
> ""However, this has not yet reflected well with our debt situation. Our total national debt has increased about 85 billion SR this year. If we maintain such a deficit over the next years we will face a massive debt crisis which could crash the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -1"*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= -1)"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Symon Holl: ""However, this has not yet reflected well with our debt s..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= -1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Symon Holl: ""However, this has not yet reflected well with our debt s..."*)

### Węzeł `[365]`
Mówca: **Symon Holl**
> ""However, this has not yet reflected well with our debt situation. Our total national debt has increased about 65 billion SR this year. If we enter a higher deficit over the next years we will face a massive debt crisis which could crash the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget < 0"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 0"*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= 0)"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Symon Holl: ""Thanks to our balanced budget we are eyeing a manageable..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -1"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Centralization == t..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Lileas Graf: ""I also have an update about the abolishment of the Bergi..."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true || BaseGa..."*)

### Węzeł `[372]`
Mówca: **Lileas Graf**
> ""I also have an update about the abolishment of the Bergia Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Lileas Graf: ""Apart from a few small details, the project is ready to ..."*)

### Węzeł `[373]`
Mówca: **Lileas Graf**
> ""Apart from a few small details, the project is ready to be implemented. We can get rid of the governor soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Lileas Graf: ""I will send the final documents for you to sign soon, Mr..."*)

### Węzeł `[374]`
Mówca: **Lileas Graf**
> ""I will send the final documents for you to sign soon, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Player: ""Thank you, Lileas.""*)
  - -> `[389]` (*Player: ""Great work as always. Thank you.""*)
  - -> `[391]` (*Player: ""Good to know. I'm expecting them soon, Ms. Graf.""*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Lileas Graf: ""Unfortunately, after the departure of Governor Bron, the..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[378]`
Mówca: **Lileas Graf**
> ""Unfortunately, after the departure of Governor Bron, the situation in the Special Zone had barely changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Lileas Graf: ""Despite not following the extreme policies of his predec..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Lileas Graf: ""Unfortunately, Governor Bron is continuing his discrimin..."*)

### Węzeł `[382]`
Mówca: **Lileas Graf**
> ""Unfortunately, Governor Bron is continuing his discriminatory policies against the Bluds in the Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Lileas Graf: ""I'm afraid if this continues, we will have a major probl..."*)

### Węzeł `[383]`
Mówca: **Lileas Graf**
> ""I'm afraid if this continues, we will have a major problem in our hands. The reports of the BFF organizing its forces is very concerning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Centralization == t..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Lileas Graf: ""Luckily, I have some good news about the abolishment of ..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true || BaseGa..."*)

### Węzeł `[387]`
Mówca: **Lileas Graf**
> ""Luckily, I have some good news about the abolishment of the Bergia Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Lileas Graf: ""Apart from a few small details, the project is ready to ..."*)

### Węzeł `[388]`
Mówca: **Lileas Graf**
> ""Despite not following the extreme policies of his predecessor, Governor Krull is continuing with discriminatory policies against the Bluds in Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Lileas Graf: ""I'm afraid if this continues, we will have a major probl..."*)

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Great work as always. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true || BaseGa..."*)

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Lileas.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true || BaseGa..."*)

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good to know. I'm expecting them soon, Ms. Graf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true || BaseGa..."*)

### Węzeł `[392]`
Mówca: **Nia Morgna**
> ""Since the removal of Governor Bron from office, there have been some positive results for our Bludish citizens in Bergia...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Nia Morgna: ""However, Governor Krull seems to be looking for new loop..."*)

### Węzeł `[393]`
Mówca: **Nia Morgna**
> ""Mr. Ersen gained a lot of popularity for his fight against Governor Bron, and is now leading a peaceful ground movement against Governor Krull.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_..."*)
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true || BaseGame.Refor..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true  or  Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "Lileas smiled faintly."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true  or  Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Narrator: "Lileas smiled faintly."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Nia Morgna: ""Since the removal of Governor Bron from office, there ha..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Nia Morgna: ""The Supreme Court has delayed the Ishval Ersen case agai..."*)

### Węzeł `[400]`
Mówca: **Nia Morgna**
> ""However, Governor Krull seems to be looking for new loopholes to continue Bron's racist policies in different ways.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Nia Morgna: ""Mr. Ersen gained a lot of popularity for his fight again..."*)

### Węzeł `[401]`
Mówca: **Nia Morgna**
> ""I'm afraid if Mr. Krull retains his position for long, we may see tensions rise again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)
  - -> `[471]` (*Player: ""I expected some suggestions.""*)
  - -> `[473]` (*Player: ""All noted. Thank you, Ms. Morgna.""*)

### Węzeł `[402]`
Mówca: **Nia Morgna**
> ""The Supreme Court has delayed the Ishval Ersen case again. Indefinitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Nia Morgna: ""Mr. Hawker and his cronies are adamant about protecting ..."*)

### Węzeł `[403]`
Mówca: **Nia Morgna**
> ""Mr. Hawker and his cronies are adamant about protecting Governor Bron and the Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Nia Morgna: ""In this process, Mr. Ersen gained a lot of popularity an..."*)

### Węzeł `[404]`
Mówca: **Nia Morgna**
> ""In this process, Mr. Ersen gained a lot of popularity and is now leading a peaceful protest movement against Governor Bron.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true && BaseGame...."*)

### Węzeł `[405]`
Mówca: **Nia Morgna**
> ""I'm afraid if this goes on for longer, there will be chaos in Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)
  - -> `[443]` (*Player: ""I expected some suggestions.""*)
  - -> `[445]` (*Player: ""All noted. Thank you, Ms. Morgna.""*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true && BaseGame...."*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true && BaseGam..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true"*)

### Węzeł `[409]`
Mówca: **Nia Morgna**
> ""According to the new constitution, Governor Bron should be charged. But with Mr. Hawker leading the Court and delaying the case, our only option to remove him is the removal of the Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Nia Morgna: ""And I have an update on that.""*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true"*)
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Nia Morgna: ""According to the new constitution, Governor Bron should ..."*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Nia Morgna: ""According to the new constitution, Governor Bron should ..."*)

### Węzeł `[413]`
Mówca: **Nia Morgna**
> ""And I have an update on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Nia Morgna: ""Apart from a few small details, the semi-autonomy projec..."*)

### Węzeł `[414]`
Mówca: **Nia Morgna**
> ""According to the new constitution, Governor Bron should be charged. But with Mr. Hawker leading the Court and delaying the case, my hands are tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso == t..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso == true || BaseGame.Turn07_Results_Decision_NewJusticesList == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso == t..."*)
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso ==..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso == true || BaseGame.Turn07_Results_Decision_NewJusticesList == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso"] == true  or  Variable["BaseGame.Turn07_Results_Decision_NewJusticesList"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Nia Morgna: ""However, now that we know your plans against the Court, ..."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso == true || BaseGame.Turn07_Results_Decision_NewJusticesList == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Decision_AssemblyAgainstOrso"] == true  or  Variable["BaseGame.Turn07_Results_Decision_NewJusticesList"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[418]`
Mówca: **Nia Morgna**
> ""Apart from a few small details, the semi-autonomy project is ready to be implemented. We can get rid of the governor soon this way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Nia Morgna: ""I will send the final documents for you to sign soon, Mr..."*)

### Węzeł `[419]`
Mówca: **Nia Morgna**
> ""I will send the final documents for you to sign soon, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Player: ""Thank you, Nia.""*)
  - -> `[420]` (*Player: ""Great work as always. Thank you.""*)
  - -> `[422]` (*Player: ""Good to know. I'm expecting them soon, Ms. Morgna.""*)

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Great work as always. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Nia Morgna: ""Of course.""*)

### Węzeł `[421]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Nia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Nia Morgna: ""Of course.""*)

### Węzeł `[422]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good to know. I'm expecting them soon, Ms. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Nia Morgna: ""Of course.""*)

### Węzeł `[423]`
Mówca: **Nia Morgna**
> ""However, now that we know your plans against the Court, we might still be able to get rid of the governor if Mr. Hawker can be replaced by someone who'd respect the new constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Nia Morgna: ""But of course, even if you can initiate the impeachment ..."*)

### Węzeł `[424]`
Mówca: **Nia Morgna**
> ""However, now that the new constitution allows for the impeachment of Justices, we might still be able to get rid of the governor if Mr. Hawker can be replaced by someone who'd respect the new constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Nia Morgna: ""But of course, even if you can initiate the impeachment ..."*)

### Węzeł `[425]`
Mówca: **Nia Morgna**
> ""But of course, even if you can initiate the impeachment process, the Chief Justice is elected by the members of the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Nia Morgna: ""That's the extent of my report.""*)

### Węzeł `[426]`
Mówca: **Nia Morgna**
> ""Luckily, I've been working on the semi-autonomous zone project for Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Nia Morgna: ""And I have an update on that.""*)

### Węzeł `[427]`
Mówca: **Nia Morgna**
> ""And I have an update on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Nia Morgna: ""Apart from a few small details, the project is ready to ..."*)

### Węzeł `[428]`
Mówca: **Nia Morgna**
> ""According to Court ruling, Governor Krull cannot resume Phelix Bron's oppressive policies. But with Mr. Hawker leading the Court, finding loopholes may still be a possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Nia Morgna: ""I'm afraid if Mr. Krull retains his position for long, w..."*)

### Węzeł `[429]`
Mówca: **Nia Morgna**
> ""Apart from a few small details, the project is ready to be implemented. We'll soon be able to get rid of the current governor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Nia Morgna: ""I will send the final documents for you to sign soon, Mr..."*)

### Węzeł `[430]`
Mówca: **Nia Morgna**
> ""I will send the final documents for you to sign soon, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Player: ""Thank you, Nia.""*)
  - -> `[431]` (*Player: ""Great work as always. Thank you.""*)
  - -> `[433]` (*Player: ""Good to know. I'm expecting them soon, Ms. Morgna.""*)

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Great work as always. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[430]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Nia Morgna: ""Of course.""*)

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Nia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[430]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Nia Morgna: ""Of course.""*)

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good to know. I'm expecting them soon, Ms. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[430]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Nia Morgna: ""Of course.""*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true"*)
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Nia Morgna: ""Luckily, I've been working on the semi-autonomous zone p..."*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Nia Morgna: ""According to Court ruling, Governor Krull cannot resume ..."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true"*)
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Nia Morgna: ""Luckily, I've been working on the semi-autonomous zone p..."*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Nia Morgna: ""I'm afraid if this goes on for longer, there will be cha..."*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Nia Morgna: ""However, now that the new constitution allows for the im..."*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Nia Morgna: ""I'm afraid if this goes on for longer, there will be cha..."*)

### Węzeł `[443]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I expected some suggestions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[405]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Nia Morgna: ""I can update you more in another meeting.""*)

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry. We will get rid of the governor after I sign off Ms. Graf's project.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Kontekst wejściowy (poprzednik):** `[405]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Nia Morgna: ""I hope so, Mr. President.""*)

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All noted. Thank you, Ms. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[405]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Nia took her seat."*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Centralization == t..."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player: ""Don't worry. We will get rid of the governor after I sig..."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you all for your reports.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[451]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Nia took her seat."*)

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Duly noted. Thank you, Ms. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[451]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Nia took her seat."*)

### Węzeł `[451]`
Mówca: **Nia Morgna**
> ""That's the extent of my report.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Player: ""Duly noted. Thank you, Ms. Morgna.""*)
  - -> `[449]` (*Player: ""Thank you all for your reports.""*)

### Węzeł `[452]`
Mówca: **Narrator**
> "Lileas smiled faintly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Player: ""Thank you for your reports.""*)
  - -> `[455]` (*Player: ""Do you have anything to share, Mrs. Morgna?""*)
  - -> `[453]` (*Player: ""I think it's time we wrap up the reports and move on.""*)

### Węzeł `[453]`
**[WYBÓR GRACZA: ""I think it's time we wrap up the reports and move on.""]** — Mówca: **Player**
> ""I think it's time we wrap up the reports and move on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[452]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[454]`
**[WYBÓR GRACZA: ""Thank you for your reports.""]** — Mówca: **Player**
> ""Thank you for your reports.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[452]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[455]`
**[WYBÓR GRACZA: ""Do you have anything to share, Mrs. Morgna?""]** — Mówca: **Player**
> ""Do you have anything to share, Mrs. Morgna?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[452]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Narrator: "Nia shook her head."*)

### Węzeł `[456]`
Mówca: **Nia Morgna**
> ""Not at this moment, Mr. President. You are already well aware of what's going on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player: ""So be it, Mrs. Morgna.""*)
  - -> `[464]` (*Player: ""Thank you.""*)
  - -> `[463]` (*Player: ""I understand.""*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Nia Morgna: ""I will update you on our next steps in the judiciary in ..."*)

### Węzeł `[460]`
Mówca: **Nia Morgna**
> ""I will update you on our next steps in the judiciary in another meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Player: ""Thank you.""*)
  - -> `[463]` (*Player: ""I understand.""*)

### Węzeł `[461]`
**[WYBÓR GRACZA: ""So be it, Mrs. Morgna.""]** — Mówca: **Player**
> ""So be it, Mrs. Morgna.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Kontekst wejściowy (poprzednik):** `[456]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Nia took her seat."*)

### Węzeł `[462]`
Mówca: **Narrator**
> "Nia took her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[463]`
**[WYBÓR GRACZA: ""I understand.""]** — Mówca: **Player**
> ""I understand.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Kontekst wejściowy (poprzednik):** `[460]` (Nia Morgna), `[456]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Nia took her seat."*)

### Węzeł `[464]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Kontekst wejściowy (poprzednik):** `[460]` (Nia Morgna), `[456]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Nia took her seat."*)

### Węzeł `[465]`
Mówca: **Narrator**
> "Nia shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Nia Morgna: ""Not at this moment, Mr. President. You are already well ..."*)

### Węzeł `[466]`
Mówca: **Narrator**
> "Lileas smiled faintly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Narrator: "Nia stood up."*)

### Węzeł `[467]`
Mówca: **Narrator**
> "Nia stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[468]`
Mówca: **Nia Morgna**
> ""I can update you more in another meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Nia took her seat."*)

### Węzeł `[469]`
Mówca: **Nia Morgna**
> ""I hope so, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Nia took her seat."*)

### Węzeł `[470]`
Mówca: **Nia Morgna**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Nia took her seat."*)

### Węzeł `[471]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I expected some suggestions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Nia Morgna: ""I can update you more in another meeting.""*)

### Węzeł `[472]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry. We will get rid of the governor after I sign off Ms. Graf's project.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Kontekst wejściowy (poprzednik):** `[401]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Nia Morgna: ""I hope so, Mr. President.""*)

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All noted. Thank you, Ms. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Nia took her seat."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Centralization == t..."*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Player: ""Don't worry. We will get rid of the governor after I sig..."*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[477]`
Mówca: **Nia Morgna**
> ""I can update you more in another meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Nia took her seat."*)

### Węzeł `[478]`
Mówca: **Nia Morgna**
> ""I hope so, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Nia took her seat."*)

### Węzeł `[479]`
Mówca: **Nia Morgna**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Nia took her seat."*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)"*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Lileas Graf: ""Our raids against BFF targets are continuing with no slo..."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[483]`
Mówca: **Lileas Graf**
> ""Our raids against BFF targets are continuing with no slowing down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Lileas Graf: ""I'm quite shocked that Mr. Ejall's intelligence has been..."*)

### Węzeł `[484]`
Mówca: **Lileas Graf**
> ""I'm quite shocked that Mr. Ejall's intelligence has been very reliable so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "BaseGame.Arrest_FetihEjall == true"*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Arrest_FetihEjall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "BaseGame.Arrest_FetihEjall == true"*)
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Arrest_FetihEjall == true)"*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Arrest_FetihEjall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Lileas Graf: ""It was the correct decision to lock him up.""*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Arrest_FetihEjall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "She pointed at the stack of papers in front of her."*)

### Węzeł `[488]`
Mówca: **Lileas Graf**
> ""It was the correct decision to lock him up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "She pointed at the stack of papers in front of her."*)

### Węzeł `[489]`
Mówca: **Narrator**
> "She pointed at the stack of papers in front of her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Decreased == true"*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Decreased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Decreased == true"*)
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Decreased == true)"*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Decreased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Lileas Graf: ""Unfortunately, during a night operation this week, we ha..."*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Decreased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Lileas Graf: ""We arrested three high ranking leaders of the BFF this w..."*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true"*)
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true)"*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Lileas Graf: ""They have already announced they will cooperate with our..."*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true"*)

### Węzeł `[496]`
Mówca: **Lileas Graf**
> ""Unfortunately, during a night operation this week, we had Awlan Arge, along with three other leaders of the BFF slip away from our grasp. Our forces are looking for them around the Sordish-Wehzek border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Lileas Graf: ""We have notified the Wehzek authorities to be on the loo..."*)

### Węzeł `[497]`
Mówca: **Lileas Graf**
> ""We arrested three high ranking leaders of the BFF this week, but unfortunately, Awlan Arge managed to slip away from our grasp. Our forces are looking for him around the Sordish-Wehzek border at this moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Lileas Graf: ""We have notified the Wehzek authorities to be on the loo..."*)

### Węzeł `[498]`
Mówca: **Lileas Graf**
> ""We have notified the Wehzek authorities to be on the lookout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true"*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true"*)
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)"*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Lileas Graf: ""They have assured us that they will be aiding our search..."*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Lileas Graf: ""We are still waiting for their response.""*)

### Węzeł `[502]`
Mówca: **Lileas Graf**
> ""We are still waiting for their response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Lileas Graf: ""Our forces are now getting ready for a much larger opera..."*)

### Węzeł `[503]`
Mówca: **Lileas Graf**
> ""They have assured us that they will be aiding our search from their border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Lileas Graf: ""Our forces are now getting ready for a much larger opera..."*)

### Węzeł `[504]`
Mówca: **Lileas Graf**
> ""They have already announced they will cooperate with our forces to finish the BFF off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Lileas Graf: ""Our forces are now getting ready for a much larger opera..."*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true"*)
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == t..."*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Lileas Graf: ""But I'll be honest. All of this is taking its toll on my..."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Lileas Graf: ""We might need to implement some new measures soon. We wi..."*)

### Węzeł `[508]`
Mówca: **Lileas Graf**
> ""But I'll be honest. All of this is taking its toll on my people. Our police forces are still suffering. The regions of Bergia and Nargis are ridden with crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Lileas Graf: ""We might need to implement some new measures soon. We wi..."*)

### Węzeł `[509]`
Mówca: **Lileas Graf**
> ""We might need to implement some new measures soon. We will provide you with a more detailed report at a later date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[510]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Actually, the circumstances have changed and I want you to hold off the operations against the BFF from now on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[524]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Lileas Graf: ""What do you mean, Mr. President?""*)

### Węzeł `[511]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good. I'll sign it now. I trust you to eliminate them once and for all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[524]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Lileas Graf: ""Of course.""*)

### Węzeł `[512]`
Mówca: **Lileas Graf**
> ""What do you mean, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Lileas Graf: ""We already have very valuable feedback about their plans..."*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation = true;
BaseGameSupport.Journal_Turn07_OrderedBFFOperation = true;
BaseGame.Policy_Order_CounterTerrorismOperation = true;
BaseGame.Bludish_Opinion -= 2;
BaseGame.Sollist += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.BFF_EliminationOperation"] = true;
Variable["BaseGameSupport.Journal_Turn07_OrderedBFFOperation"] = true;
Variable["BaseGame.Policy_Order_CounterTerrorismOperation"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true"*)

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I've been reading your reports and you've already done a good job. I think we can call off the operations now. I don't want to damage our relations with the Bludish community.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[524]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Lileas Graf: ""What do you mean, Mr. President?""*)

### Węzeł `[515]`
Mówca: **Lileas Graf**
> ""We already have very valuable feedback about their plans and hiding locations. You cannot cancel a historic operation like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Player: ""You might be right. I'll trust your judgement and sign t..."*)
  - -> `[517]` (*Player: ""You might be right but we cannot afford to damage the te..."*)
  - -> `[516]` (*Player: ""Oh, but I can, Ms. Graf. And you will need to respect my..."*)

### Węzeł `[516]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, but I can, Ms. Graf. And you will need to respect my decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[515]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Lileas Graf: ""You can't be serious.""*)

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You might be right but we cannot afford to damage the tense situation in Bergia any longer. Cancel the operation immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[515]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Lileas Graf: ""You can't be serious.""*)

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You might be right. I'll trust your judgement and sign the operation off.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[515]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Lileas Graf: ""Thank you.""*)

### Węzeł `[519]`
Mówca: **Lileas Graf**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation = true; BaseGameSupport..."*)

### Węzeł `[520]`
Mówca: **Lileas Graf**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation = true; BaseGameSupport..."*)

### Węzeł `[521]`
Mówca: **Lileas Graf**
> ""You can't be serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Narrator: "She looked furious."*)

### Węzeł `[522]`
Mówca: **Narrator**
> "She looked furious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Lileas Graf: ""In any case, we might need to implement some new measure..."*)

### Węzeł `[523]`
Mówca: **Lileas Graf**
> ""In any case, we might need to implement some new measures soon. I will provide you with a more detailed report at a later date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[524]`
Mówca: **Lileas Graf**
> ""Our forces are now getting ready for a much larger operation to finally finish them off. I just need you to sign the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Player: ""Good. I'll sign it now. I trust you to eliminate them on..."*)
  - -> `[514]` (*Player: ""I've been reading your reports and you've already done a..."*)
  - -> `[510]` (*Player: ""Actually, the circumstances have changed and I want you ..."*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Policy_Law_Ban_WPB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Policy_Law_Ban_WPB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Policy_Law_Ban_WPB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Lileas Graf: ""Our raids against BFF targets are continuing with no slo..."*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Policy_Law_Ban_WPB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Policy_Law_Ban_WPB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= -1"*)

### Węzeł `[528]`
Mówca: **Lileas Graf**
> ""Our raids against BFF targets are continuing with no slowing down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Narrator: "She pointed at the stack of papers in front of her."*)

### Węzeł `[529]`
Mówca: **Narrator**
> "She pointed at the stack of papers in front of her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Lileas Graf: ""Thanks to the emergency powers, we've managed to retain ..."*)

### Węzeł `[530]`
Mówca: **Lileas Graf**
> ""Thanks to the emergency powers, we've managed to retain some very sensitive information about the locations of the leaders of the secessionists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Decreased == true"*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true"*)
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)"*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true"*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomStake_Keep == true"*)

### Węzeł `[534]`
Mówca: **Gus Manger**
> ""The returns have come in from the shares that Sordland recently sold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomSaleResult_VeryHigh == true"*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_GasomStake_Keep == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomStake_Keep == true"*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_GasomStake_Keep == true)"*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_GasomStake_Keep == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_GasomStake_Keep"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_GasomStake_Keep == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_GasomStake_Keep"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomStake_SellOneThird == true ..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_GasomSaleResult_VeryHigh == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomSaleResult_VeryHigh == true"*)
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_GasomSaleResult_VeryHigh == true)"*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_GasomSaleResult_VeryHigh == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_GasomSaleResult_VeryHigh"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Gus Manger: ""I'm pleased to inform you that we have turned a massive ..."*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_GasomSaleResult_VeryHigh == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_GasomSaleResult_VeryHigh"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomSaleResult_High == true"*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_GasomSaleResult_High == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomSaleResult_High == true"*)
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_GasomSaleResult_High == true)"*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_GasomSaleResult_High == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_GasomSaleResult_High"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Gus Manger: ""I'm pleased to inform you that we have turned a signific..."*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_GasomSaleResult_High == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_GasomSaleResult_High"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomSaleResult_Medium == true"*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_GasomSaleResult_Medium == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomSaleResult_Medium == true"*)
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_GasomSaleResult_Medium == true)"*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_GasomSaleResult_Medium == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_GasomSaleResult_Medium"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Gus Manger: ""We have turned a medium-sized profit from the sale.""*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_GasomSaleResult_Medium == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_GasomSaleResult_Medium"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomSaleResult_Low == true"*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_GasomSaleResult_Low == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomSaleResult_Low == true"*)
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_GasomSaleResult_Low == true)"*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_GasomSaleResult_Low == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_GasomSaleResult_Low"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Gus Manger: ""Unfortunately, we have turned only a low profit from the..."*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_GasomSaleResult_Low == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_GasomSaleResult_Low"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Gus Manger: ""Unfortunately, we have barely managed to turn a profit f..."*)

### Węzeł `[550]`
Mówca: **Gus Manger**
> ""I'm pleased to inform you that we have turned a massive profit from the sale.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true"*)

### Węzeł `[551]`
Mówca: **Gus Manger**
> ""I'm pleased to inform you that we have turned a significant profit from the sale.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true"*)

### Węzeł `[552]`
Mówca: **Gus Manger**
> ""We have turned a medium-sized profit from the sale.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true"*)

### Węzeł `[553]`
Mówca: **Gus Manger**
> ""Unfortunately, we have turned only a low profit from the sale.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true"*)

### Węzeł `[554]`
Mówca: **Gus Manger**
> ""Unfortunately, we have barely managed to turn a profit from the sale.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true"*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true"*)
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true)"*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Gus Manger: ""However, the President's recent decision to revert the E..."*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[558]`
Mówca: **Gus Manger**
> ""However, the President's recent decision to revert the Energy Protection Act to its Soll-era 10 percent cap on foreign ownership had a severe impact on the company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Gus Manger: ""Gasom now appears to be on the verge of bankruptcy, if n..."*)

### Węzeł `[559]`
Mówca: **Gus Manger**
> ""Gasom now appears to be on the verge of bankruptcy, if not there already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Narrator: "Symon looked worried."*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true"*)
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true)"*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Gus Manger: ""The recent decision to revert the Energy Protection Act ..."*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[563]`
Mówca: **Gus Manger**
> ""The recent decision to revert the Energy Protection Act to its Soll-era 10 percent cap on foreign ownership had a severe impact on the company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Gus Manger: ""Gasom now appears to be on the verge of bankruptcy, if n..."*)

### Węzeł `[564]`
Mówca: **Gus Manger**
> ""Gasom now appears to be on the verge of bankruptcy, if not there already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Narrator: "Symon looked worried."*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Gus Manger: ""Due to the removal of the Energy Protection Act, the Kin..."*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Gus Manger: ""That will be all.""*)

### Węzeł `[568]`
Mówca: **Gus Manger**
> ""Due to the removal of the Energy Protection Act, the Kingdom of Rumburg now owns a larger stake in Gasom than Sordland does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Narrator: "Symon looked worried."*)

### Węzeł `[569]`
Mówca: **Narrator**
> "Symon looked worried."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Symon Holl: ""That development is bound to negatively affect energy pr..."*)

### Węzeł `[570]`
Mówca: **Symon Holl**
> ""That development is bound to negatively affect energy prices. Thank you for telling us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Symon Holl"); RemoveConversant("Deivid ..."*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Gus Manger: ""However, due to the removal of the Energy Protection Act..."*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Gus Manger: ""That will be all.""*)

### Węzeł `[574]`
Mówca: **Gus Manger**
> ""However, due to the removal of the Energy Protection Act, the Kingdom of Rumburg now owns a larger stake in Gasom than Sordland does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingRumburg == true"*)

### Węzeł `[575]`
Mówca: **Narrator**
> "Symon looked worried."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Symon Holl: ""That development is bound to negatively affect energy pr..."*)

### Węzeł `[576]`
Mówca: **Symon Holl**
> ""That development is bound to negatively affect energy prices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Deivid Wisci: ""What's more, tensions with Rumburg are still high. We wi..."*)

### Węzeł `[577]`
Mówca: **Deivid Wisci**
> ""What's more, tensions with Rumburg are still high. We will have to keep a close eye on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Symon Holl"); RemoveConversant("Deivid ..."*)

### Węzeł `[578]`
Mówca: **Gus Manger**
> ""That will be all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player: ""Thank you, Mr. Manger.""*)
  - -> `[136]` (*Player: ""That was it?""*)
  - -> `[134]` (*Player: ""Good. Let's move on to the next report.""*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true"*)
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true)"*)

### Węzeł `[580]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Gus Manger: ""Finally, although it is not strictly my purview, I'll pr..."*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[582]`
Mówca: **Gus Manger**
> ""Unfortunately, the President's recent decision to revert the Energy Protection Act to its Soll-era 10 percent cap on foreign ownership had a severe impact on the company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Gus Manger: ""Gasom now appears to be on the verge of bankruptcy, if n..."*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[584]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Gus Manger: ""Finally, although it is not strictly my purview, I'll pr..."*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Gus Manger: ""That will be all.""*)

### Węzeł `[586]`
Mówca: **Gus Manger**
> ""Unfortunately, due to the removal of the Energy Protection Act, the Kingdom of Rumburg was able to purchase a large stake in the company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Gus Manger: ""Gasom is now majority foreign owned.""*)

### Węzeł `[587]`
Mówca: **Gus Manger**
> ""Gasom is now majority foreign owned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Narrator: "Symon looked worried."*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[590]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)

### Węzeł `[590]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Gus Manger: ""That will be all.""*)

### Węzeł `[591]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)
  - -> `[593]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)"*)

### Węzeł `[592]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Gus Manger: ""Finally, although it is not strictly my purview, I'll pr..."*)

### Węzeł `[593]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Gus Manger: ""Finally, although it is not strictly my purview, I'll pr..."*)

### Węzeł `[594]`
Mówca: **Gus Manger**
> ""Due to the removal of the Energy Protection Act, the country of Anraka was able to purchase a quite large stake in the company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Gus Manger: ""Sordland still owns the largest stake in Gasom, but just..."*)

### Węzeł `[595]`
Mówca: **Gus Manger**
> ""Sordland still owns the largest stake in Gasom, but just barely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Narrator: "Symon looked worried."*)

### Węzeł `[596]`
Mówca: **Gus Manger**
> ""Finally, although it is not strictly my purview, I'll provide you all with a quick update on the situation with Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Gus Manger: ""Unfortunately, the President's recent decision to revert..."*)

### Węzeł `[597]`
Mówca: **Gus Manger**
> ""Finally, although it is not strictly my purview, I'll provide you all with a quick update on the situation with Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Gus Manger: ""Unfortunately, due to the removal of the Energy Protecti..."*)

### Węzeł `[598]`
Mówca: **Gus Manger**
> ""Finally, although it is not strictly my purview, I'll provide you all with a quick update on the situation with Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Gus Manger: ""Due to the removal of the Energy Protection Act, the cou..."*)

### Węzeł `[599]`
Mówca: **Gus Manger**
> ""Finally, although it is not strictly my purview, I'll provide you all with a quick update on the situation with Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Gus Manger: ""The returns have come in from the shares that Sordland r..."*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Symon Holl");
RemoveConversant("Deivid Wisci");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Symon Holl");
RemoveConversant("Deivid Wisci");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Gus Manger: ""That will be all.""*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_EmbargoingRumburg == true"*)
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)"*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_EmbargoingRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Gus Manger: ""They have circumvented the embargo by trading through th..."*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Narrator: "Symon looked worried."*)

### Węzeł `[604]`
Mówca: **Gus Manger**
> ""They have circumvented the embargo by trading through the Kingdom of Rizia and other smaller investment partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Narrator: "Symon looked worried."*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_GasomStake_SellOneThird == true || BaseGame.Decision_Turn06_GasomStake_SellTwoThird == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_GasomStake_SellOneThird == true ..."*)
  - -> `[607]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_GasomStake_SellOneThird == tru..."*)

### Węzeł `[606]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_GasomStake_SellOneThird == true || BaseGame.Decision_Turn06_GasomStake_SellTwoThird == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_GasomStake_SellOneThird"] == true  or  Variable["BaseGame.Decision_Turn06_GasomStake_SellTwoThird"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Gus Manger: ""Finally, although it is not strictly my purview, I'll pr..."*)

### Węzeł `[607]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_GasomStake_SellOneThird == true || BaseGame.Decision_Turn06_GasomStake_SellTwoThird == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_GasomStake_SellOneThird"] == true  or  Variable["BaseGame.Decision_Turn06_GasomStake_SellTwoThird"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true..."*)

### Węzeł `[608]`
Mówca: **Gus Manger**
> ""Finally, although it is not strictly my purview, I'll provide you all with a quick update on the situation with Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true"*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true || BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Węzeł Logiki Narracyjnej: "BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true..."*)
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == tr..."*)

### Węzeł `[610]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true || BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Gus Manger: ""Finally, although it is not strictly my purview, I'll pr..."*)

### Węzeł `[611]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true || BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Gus Manger: ""That will be all.""*)
