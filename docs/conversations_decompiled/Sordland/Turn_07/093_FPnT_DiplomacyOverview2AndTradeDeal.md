# Sordland/Turn07/FPnT_DiplomacyOverview2AndTradeDeal

- **ID konwersacji:** `93`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/093_FPnT_DiplomacyOverview2AndTradeDeal.md`
- **Liczba węzłów dialogowych:** 362
- **Liczba wyborów gracza:** 38

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[21]** Deivid Wisci
- **[38]** Lucian Galade
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_Alliance`
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Agnolia_TradeDeal`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn04_RegionalInvestment_Lorren`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.Economy`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Diplomacy_West`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Reform_EmergencyDecree_Embargo_UC`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Maintain`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGame.Turn04_InT_RailwayIssue_Solved`
- `BaseGame.Turn06_InT_OnTime`
- `BaseGame.Turn06_PSnW_Healthcare_Hospitals`
- `BaseGame.Turn06_PSnW_Healthcare_ImproveRural`
- `BaseGame.Turn06_PSnW_Healthcare_Salary`
- `BaseGame.Wehlen_TradeDeal`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`
- `BaseGame.TradeDeal_Negotiation_Lespia`
- `BaseGame.TradeDeal_Negotiation_Valgsland`
- `BaseGameSupport.Journal_Turn07_Negotiation_Lespia`
- `BaseGameSupport.Journal_Turn07_Negotiation_LespiaAndValgsland`
- `BaseGameSupport.Journal_Turn07_Negotiation_None`
- `BaseGameSupport.Journal_Turn07_Negotiation_Valgsland`
- `BaseGameSupport.News_Turn07_G_RayneWillVisitBoth`
- `BaseGameSupport.News_Turn07_G_RayneWillVisitLespia`
- `BaseGameSupport.News_Turn07_G_RayneWillVisitValgsland`
- `BaseGameSupport.News_Turn07_HP_Polio`
- `BaseGameSupport.News_Turn07_LT_Polio`
- `BaseGameSupport.Report_Turn07_Arvory_H3Result`
- `BaseGameSupport.Report_Turn07_Deyr_HomelessnessDecrease`
- `BaseGameSupport.Report_Turn07_Deyr_WehlenTradeReport`
- `BaseGameSupport.Report_Turn07_Gelsord_RecessionHitsWorkers`
- `BaseGameSupport.Report_Turn07_Holsord_CurrencyLosesValue`
- `BaseGameSupport.Report_Turn07_Lachaven_L1Result`
- `BaseGameSupport.Report_Turn07_Laren_MedicalQualityIncreased`
- `BaseGameSupport.Report_Turn07_Morna_UnemploymentReduced`
- `BaseGameSupport.Report_Turn07_Narbel_MedicalSalariesIncreased`
- `BaseGameSupport.Report_Turn07_Sarna_IncreasedAgriculturalProduction`
- `BaseGameSupport.Report_Turn07_Uziren_NewHospitalBuilt`
- `GameCondition.Turn07_FPnT_DiplomacyOverview2AndTradeDeal`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[15]` | **"Nod and gesture for Deivid to begin."** | `[14]` **Deivid Wisci**: "“Mr. President, if I may, I woul..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Deivid Wisci**: "“We have successfully passed tra..."<br>`[24]` **Deivid Wisci**: "“Although we did not make a trad..."<br>*(oraz 2 innych odgałęzień)* |
| `[16]` | **"“Go ahead.”"** | `[14]` **Deivid Wisci**: "“Mr. President, if I may, I woul..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Deivid Wisci**: "“We have successfully passed tra..."<br>`[24]` **Deivid Wisci**: "“Although we did not make a trad..."<br>*(oraz 2 innych odgałęzień)* |
| `[28]` | **"“What do you mean by looking towards the future?”"** | `[27]` **Deivid Wisci**: "“We must now look towards the fu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Narrator**: "Deivid sat down, pulled out a fe..." |
| `[29]` | **"“Go on.”"** | `[27]` **Deivid Wisci**: "“We must now look towards the fu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Narrator**: "Deivid sat down, pulled out a fe..." |
| `[30]` | **"“It's time to take the next steps.”"** | `[27]` **Deivid Wisci**: "“We must now look towards the fu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Deivid Wisci**: "“Precisely.”" |
| `[43]` | **"“Nonsense. Our country can defend itself just fine without allies.”"** | `[41]` **Lucian Galade**: "“We ought to head General Lancea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Iosef Lancea**: "“Let future generations of Sordi..." |
| `[44]` | **"“Thank you for your input. I will consider it.”"** | `[41]` **Lucian Galade**: "“We ought to head General Lancea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Deivid Wisci**: "“A military perspective is impor..." |
| `[45]` | **"“I trust your assessment, Iosef.”"** | `[41]` **Lucian Galade**: "“We ought to head General Lancea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Iosef Lancea**: "“Thank you, Mr. President.”" |
| `[51]` | **"“But being friendly won't hurt, right?""** | `[50]` **Iosef Lancea**: "“We don't need to beg for help f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Lucian Galade**: "“I agree. There is nothing to be..." |
| `[52]` | **"“You are right. I will not let Sordland look weak.”"** | `[50]` **Iosef Lancea**: "“We don't need to beg for help f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Deivid Wisci**: "“A military perspective is impor..." |
| `[53]` | **"“Thank you for your input. I will consider it.”"** | `[50]` **Iosef Lancea**: "“We don't need to beg for help f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Deivid Wisci**: "“A military perspective is impor..." |
| `[76]` | **""Which events exactly?""** | `[75]` **Deivid Wisci**: "“Unfortunately, due to certain e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Deivid Wisci**: "“In Valgsland's case, their inte..."<br>`[94]` **Deivid Wisci**: "“In Valgsland's case, their inte..."<br>*(oraz 1 innych odgałęzień)* |
| `[77]` | **"“Good riddance.”"** | `[75]` **Deivid Wisci**: "“Unfortunately, due to certain e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "Deivid frowned." |
| `[78]` | **"“I did what had to be done.”"** | `[75]` **Deivid Wisci**: "“Unfortunately, due to certain e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Deivid Wisci**: "“And this is the result.”" |
| `[111]` | **"“We will not rely on anyone but ourselves.”"** | `[109]` **Deivid Wisci**: "“Blacklisting the superpower lea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "Deivid looked me up and down bef..." |
| `[112]` | **"“You don't seem satisfied with my decision.”"** | `[109]` **Deivid Wisci**: "“Blacklisting the superpower lea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Deivid Wisci**: "“That is because I am not.”" |
| `[161]` | **"“Dealing with countries in CSP is dangerous.”"** | `[128]` **Deivid Wisci**: "“Because they are one of the mos..." | `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false` | *Brak zmian stanu* | `[165]` **Lucian Galade**: "“A simple trade deal wouldn't ca..." |
| `[162]` | **"“We should do whatever we can to get them on our side.”"** | `[139]` **Deivid Wisci**: "“Indeed. This trade deal could a..."<br>`[128]` **Deivid Wisci**: "“Because they are one of the mos..." | `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false` | *Brak zmian stanu* | `[167]` **Lucian Galade**: "“I agree. Vaglsland is certainly..." |
| `[163]` | **"“We don't need the help of other countries.”"** | `[139]` **Deivid Wisci**: "“Indeed. This trade deal could a..."<br>`[128]` **Deivid Wisci**: "“Because they are one of the mos..." | `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false` | *Brak zmian stanu* | `[168]` **Lucian Galade**: "“As we all know, times change, M..." |
| `[164]` | **"“Sordland will get to its rightful place within CSP.”"** | `[139]` **Deivid Wisci**: "“Indeed. This trade deal could a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Lucian Galade**: "“That would be the best outcome.”" |
| `[169]` | **"“We won't let Agnolia get bullied by Valgsland.”"** | `[89]` **Deivid Wisci**: "“True, but as a result, we won't..."<br>`[95]` **Deivid Wisci**: "“As a result, we won't be able t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Deivid Wisci**: "“Now that we have an alliance wi..."<br>`[357]` **Deivid Wisci**: "“Now that we have recognized Hel..."<br>*(oraz 1 innych odgałęzień)* |
| `[170]` | **"“Unfortunate. So much needless dispute over such a small island...”"** | `[89]` **Deivid Wisci**: "“True, but as a result, we won't..."<br>`[95]` **Deivid Wisci**: "“As a result, we won't be able t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Deivid Wisci**: "“I'm afraid it might get much wo..." |
| `[171]` | **"“What is done is done. Let's look forward.”"** | `[89]` **Deivid Wisci**: "“True, but as a result, we won't..."<br>`[95]` **Deivid Wisci**: "“As a result, we won't be able t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Deivid Wisci**: "“As you wish.”" |
| `[175]` | **"“Sordland will never get closer to Valgsland.”"** | `[109]` **Deivid Wisci**: "“Blacklisting the superpower lea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "Deivid looked me up and down bef..." |
| `[176]` | **"“Sordland will get to its rightful place within ATO.”"** | `[137]` **Deivid Wisci**: "“Indeed. This deal could also be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Lucian Galade**: "“That would be the best outcome.”" |
| `[177]` | **"“A trade deal with Lespia could open many doors for us.""** | `[137]` **Deivid Wisci**: "“Indeed. This deal could also be..."<br>`[132]` **Deivid Wisci**: "“Not to mention that they are in..." | `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false` | *Brak zmian stanu* | `[179]` **Lucian Galade**: "“True. A country as influential ..." |
| `[178]` | **"“I do not wish to get closer with any country in ATO.”"** | `[132]` **Deivid Wisci**: "“Not to mention that they are in..." | `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false` | *Brak zmian stanu* | `[183]` **Lucian Galade**: "“That's a valid concern. Dealing..." |
| `[182]` | **"“I don't trust Lespia.”"** | `[137]` **Deivid Wisci**: "“Indeed. This deal could also be..."<br>`[132]` **Deivid Wisci**: "“Not to mention that they are in..." | `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false` | *Brak zmian stanu* | `[181]` **Lucian Galade**: "“Nor do I, but it would certainl..." |
| `[184]` | **"“I hope you are not questioning my decisions.”"** | `[147]` **Deivid Wisci**: "“In any case, a deal won't be ha..."<br>`[154]` **Deivid Wisci**: "“In any case, a deal won't be ha..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Deivid Wisci**: "“Of course not, sir.”" |
| `[185]` | **"“Good. We will never make a deal with a country in ATO.”"** | `[147]` **Deivid Wisci**: "“In any case, a deal won't be ha..."<br>`[154]` **Deivid Wisci**: "“In any case, a deal won't be ha..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Deivid Wisci**: "“As you wish.”" |
| `[186]` | **"“Unfortunate but necessary.”"** | `[147]` **Deivid Wisci**: "“In any case, a deal won't be ha..."<br>`[156]` **Deivid Wisci**: "“Lespia is rather sore over our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Deivid Wisci**: "“I agree.”" |
| `[229]` | **"“Begin negotiations with both Valgsland and Lespia.”"** | `[242]` **Iosef Lancea**: "“If Rumburg attacks, we will fall.”"<br>`[232]` **Deivid Wisci**: "“What should we do?”" | `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== false`<br>`(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false` | `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] = true;...`<br>`Variable["BaseGameSupport.Journal_Turn07_Negotiation_Lesp...`<br>*(+3 skryptów)* | `[257]` **Deivid Wisci**: "“Excellent news. I will begin at..." |
| `[230]` | **"“Begin negotiations with Lespia.”"** | `[242]` **Iosef Lancea**: "“If Rumburg attacks, we will fall.”"<br>`[232]` **Deivid Wisci**: "“What should we do?”" | `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== false`<br>`(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false` | `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] = true; ;`<br>`Variable["BaseGameSupport.Journal_Turn07_Negotiation_Lesp...`<br>*(+2 skryptów)* | `[258]` **Deivid Wisci**: "“Excellent news. I will begin at..." |
| `[231]` | **"“Begin negotiations with Valgsland.”"** | `[242]` **Iosef Lancea**: "“If Rumburg attacks, we will fall.”"<br>`[232]` **Deivid Wisci**: "“What should we do?”" | `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== false`<br>`(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false` | `Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] = tr...`<br>`Variable["BaseGameSupport.Journal_Turn07_Negotiation_Valg...`<br>*(+2 skryptów)* | `[259]` **Deivid Wisci**: "“Excellent news. I will begin at..." |
| `[233]` | **"“We will not make any trade deals.”"** | `[242]` **Iosef Lancea**: "“If Rumburg attacks, we will fall.”"<br>`[232]` **Deivid Wisci**: "“What should we do?”" | `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== false`<br>`(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false` | `Variable["BaseGameSupport.Journal_Turn07_Negotiation_None...` | `[260]` **Deivid Wisci**: "“Anton, I think that's a mistake."" |
| `[250]` | **"“Thank you. You're dismissed.""** | `[249]` **Iosef Lancea**: "“If Rumburg attacks, we will fall.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Narrator**: "Iosef spoke softly." |
| `[251]` | **"“I will think about it.”"** | `[249]` **Iosef Lancea**: "“If Rumburg attacks, we will fall.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Narrator**: "Iosef spoke softly." |
| `[252]` | **"“I trust your capabilities Iosef.”"** | `[249]` **Iosef Lancea**: "“If Rumburg attacks, we will fall.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Narrator**: "Iosef spoke softly." |

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
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The doors to the White Room, like everything else in the Maroon Palace's main nerve center, were painted white. I took a deep breath before pushing them open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Time for yet another meeting. At least this time, it was ..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The attendees rose up from their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Lucian Galade: "“Mr. President.”"*)

### Węzeł `[5]`
Mówca: **Deivid Wisci**
> "“Now that you are here, let's talk about our diplomatic strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Deivid cleared his throat."*)

### Węzeł `[6]`
Mówca: **Lucian Galade**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Iosef nodded. He and Lucian sat down, while Deivid remain..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Iosef nodded. He and Lucian sat down, while Deivid remained standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Deivid Wisci: "“Now that you are here, let's talk about our diplomatic s..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true && BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true && BaseGame.Agnolia_Tra..."*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_TradeDeal == true && BaseGame.Agnolia_T..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true && BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true  and  Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Deivid Wisci: "“We have successfully passed trade deals with both Wehlen..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_TradeDeal == true && BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true  and  Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[11]`
Mówca: **Deivid Wisci**
> "“We have successfully passed trade deals with both Wehlen and Agnolia, which means we have increased our presence in those regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Deivid Wisci: "“These deals were important pieces of leverage and signif..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Time for yet another meeting. At least this time, it was with people who liked me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The attendees rose up from their seats."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "Deivid cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Deivid Wisci: "“Mr. President, if I may, I would like to provide you wit..."*)

### Węzeł `[14]`
Mówca: **Deivid Wisci**
> "“Mr. President, if I may, I would like to provide you with a short overview of where we are at right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: "“Go ahead.”"*)
  - -> `[15]` (*Player_Italic: "Nod and gesture for Deivid to begin."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "Nod and gesture for Deivid to begin."]** — Mówca: **Player_Italic**
> "I nodded and gestured for Deivid to begin."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true && BaseGame.Agnolia_Tra..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“Go ahead.”"]** — Mówca: **Player**
> "“Go ahead.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true && BaseGame.Agnolia_Tra..."*)

### Węzeł `[17]`
Mówca: **Deivid Wisci**
> "“We decided not to pursue any deals with Wehlen and Agnolia, which means our presence in both regions is lacking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Deivid Wisci: "“We must now look towards the future.”"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_TradeDeal == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Deivid Wisci: "“Although we did not make a trade deal with Agnolia, we s..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_TradeDeal == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Deivid Wisci: "“Although we did not make a trade deal with Wehlen, we su..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Deivid Wisci: "“We decided not to pursue any deals with Wehlen and Agnol..."*)

### Węzeł `[24]`
Mówca: **Deivid Wisci**
> "“Although we did not make a trade deal with Agnolia, we succeeded in making one with Wehlen, which means we have increased our presence in the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Deivid Wisci: "“These deals were important pieces of leverage and signif..."*)

### Węzeł `[25]`
Mówca: **Deivid Wisci**
> "“Although we did not make a trade deal with Wehlen, we succeeded in making one with Agnolia, which means we have increased our presence in the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Deivid Wisci: "“These deals were important pieces of leverage and signif..."*)

### Węzeł `[26]`
Mówca: **Deivid Wisci**
> "“These deals were important pieces of leverage and significant first steps into the global arena.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Deivid Wisci: "“We must now look towards the future.”"*)

### Węzeł `[27]`
Mówca: **Deivid Wisci**
> "“We must now look towards the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "“Go on.”"*)
  - -> `[28]` (*Player: "“What do you mean by looking towards the future?”"*)
  - -> `[30]` (*Player: "“It's time to take the next steps.”"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“What do you mean by looking towards the future?”"]** — Mówca: **Player**
> "“What do you mean by looking towards the future?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Deivid sat down, pulled out a few papers and started goin..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Deivid sat down, pulled out a few papers and started goin..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“It's time to take the next steps.”"]** — Mówca: **Player**
> "“It's time to take the next steps.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Deivid Wisci: "“Precisely.”"*)

### Węzeł `[31]`
Mówca: **Deivid Wisci**
> "“Precisely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Deivid sat down, pulled out a few papers and started goin..."*)

### Węzeł `[32]`
Mówca: **Deivid Wisci**
> "“Wehlen and Agnolia were practice runs. We must begin improving our relationship with greater nations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Deivid Wisci: "“We need to elevate our international standing, especiall..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Maintain == true || B..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Maintain == true ||..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Iosef Lancea: "“Mr. President.”"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Iosef Lancea: "“Thanks to your wise investment, Sordland's army is on it..."*)

### Węzeł `[36]`
Mówca: **Iosef Lancea**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Iosef Lancea: "“You know me. I don't trust the 'helping hands' other cou..."*)

### Węzeł `[37]`
Mówca: **Iosef Lancea**
> "“You know me. I don't trust the 'helping hands' other countries offer us. For a good reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Iosef Lancea: "“But I also know when those helping hands are necessary. ..."*)

### Węzeł `[38]`
Mówca: **Iosef Lancea**
> "“But I also know when those helping hands are necessary. And right now, we need all the help we can get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Iosef Lancea: "“I've said this over and over, but I will repeat it until..."*)

### Węzeł `[39]`
Mówca: **Iosef Lancea**
> "“I've said this over and over, but I will repeat it until you get it through your skull: Rumburg will come. Sooner or later. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Iosef Lancea: "“And with the current state of our military, if a Rumburg..."*)

### Węzeł `[40]`
Mówca: **Iosef Lancea**
> "“And with the current state of our military, if a Rumburg invasion happens, Sordland will cease to exist.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Iosef Lancea: "“We need allies.”"*)

### Węzeł `[41]`
Mówca: **Lucian Galade**
> "“We ought to head General Lancea's advice, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: "“I trust your assessment, Iosef.”"*)
  - -> `[44]` (*Player: "“Thank you for your input. I will consider it.”"*)
  - -> `[43]` (*Player: "“Nonsense. Our country can defend itself just fine withou..."*)

### Węzeł `[42]`
Mówca: **Iosef Lancea**
> "“We need allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“We ought to head General Lancea's advice, Mr. President.”"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Nonsense. Our country can defend itself just fine without allies.”"]** — Mówca: **Player**
> "“Nonsense. Our country can defend itself just fine without allies.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Iosef Lancea: "“Let future generations of Sordish people know I did all ..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Thank you for your input. I will consider it.”"]** — Mówca: **Player**
> "“Thank you for your input. I will consider it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Deivid Wisci: "“A military perspective is important, but these deals are..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“I trust your assessment, Iosef.”"]** — Mówca: **Player**
> "“I trust your assessment, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Iosef Lancea: "“Thank you, Mr. President.”"*)

### Węzeł `[46]`
Mówca: **Iosef Lancea**
> "“Let future generations of Sordish people know I did all I could to protect them. If there *are* any future generations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Deivid Wisci: "“A military perspective is important, but these deals are..."*)

### Węzeł `[47]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Deivid Wisci: "“A military perspective is important, but these deals are..."*)

### Węzeł `[48]`
Mówca: **Iosef Lancea**
> "“Thanks to your wise investment, Sordland's army is on its way to becoming a force to be reckoned with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Iosef Lancea: "“Whether it be Rumburg or anyone else, we can handle outs..."*)

### Węzeł `[49]`
Mówca: **Iosef Lancea**
> "“Whether it be Rumburg or anyone else, we can handle outside threats just fine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Iosef Lancea: "“We don't need to beg for help from anyone.""*)

### Węzeł `[50]`
Mówca: **Iosef Lancea**
> "“We don't need to beg for help from anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“But being friendly won't hurt, right?""*)
  - -> `[53]` (*Player: "“Thank you for your input. I will consider it.”"*)
  - -> `[52]` (*Player: "“You are right. I will not let Sordland look weak.”"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“But being friendly won't hurt, right?""]** — Mówca: **Player**
> "“But being friendly won't hurt, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lucian Galade: "“I agree. There is nothing to be lost by making alliances.""*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“You are right. I will not let Sordland look weak.”"]** — Mówca: **Player**
> "“You are right. I will not let Sordland look weak.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Deivid Wisci: "“A military perspective is important, but these deals are..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Thank you for your input. I will consider it.”"]** — Mówca: **Player**
> "“Thank you for your input. I will consider it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Deivid Wisci: "“A military perspective is important, but these deals are..."*)

### Węzeł `[54]`
Mówca: **Lucian Galade**
> "“I agree. There is nothing to be lost by making alliances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Deivid Wisci: "“A military perspective is important, but these deals are..."*)

### Węzeł `[55]`
Mówca: **Deivid Wisci**
> "“We also need to consider the benefits to our economy such deals will provide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy <= 6"*)

### Węzeł `[56]`
Mówca: **Deivid Wisci**
> "“A military perspective is important, but these deals are about more than just gaining allies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Deivid Wisci: "“We also need to consider the benefits to our economy suc..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy <= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy <= 6"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy <= 6)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy <= 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] <= 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: "“Especially when we are *still* struggling to end the rec..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy <= 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] <= 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Deivid Wisci: "“We may be close to ending the recession, yes.”"*)

### Węzeł `[60]`
Mówca: **Deivid Wisci**
> "“We may be close to ending the recession, yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Deivid Wisci: "“But why not go a step further?”"*)

### Węzeł `[61]`
Mówca: **Deivid Wisci**
> "“But why not go a step further?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: "“Agreed.”"*)

### Węzeł `[62]`
Mówca: **Deivid Wisci**
> "“At the start of our term, I had a comprehensive trade deal plan laid out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Deivid Wisci: "“Following the visits to Wehlen and Agnolia, we were to p..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "Deivid sat down, pulled out a few papers and started going through them as he kept talking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Deivid Wisci: "“Wehlen and Agnolia were practice runs. We must begin imp..."*)

### Węzeł `[64]`
Mówca: **Deivid Wisci**
> "“We need to elevate our international standing, especially with the threat of Rumburg looming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Iosef cleared his throat."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Iosef cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Maintain == true || B..."*)

### Węzeł `[66]`
Mówca: **Lucian Galade**
> "“Especially when we are *still* struggling to end the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Deivid took a seat and brought out two stacks of documents."*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Deivid took a seat and brought out two stacks of documents."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Deivid took a seat and brought out two stacks of documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)

### Węzeł `[69]`
Mówca: **Deivid Wisci**
> "“That is it for the overview.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Deivid Wisci: "“As to the actual contents of the trade deal...”"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Agnolia_HeljilandRecognised == true || BaseGa..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true)  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Deivid Wisci: "“At the start of our term, I had a comprehensive trade de..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true)  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Deivid Wisci: "“At the start of our term, I had a comprehensive trade de..."*)

### Węzeł `[73]`
Mówca: **Deivid Wisci**
> "“At the start of our term, I had a comprehensive trade deal plan laid out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Deivid Wisci: "“Following the visits to Wehlen and Agnolia, we were to p..."*)

### Węzeł `[74]`
Mówca: **Deivid Wisci**
> "“Following the visits to Wehlen and Agnolia, we were to pursue potential trade deals with Lespia and Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Deivid Wisci: "“Unfortunately, due to certain events that have since occ..."*)

### Węzeł `[75]`
Mówca: **Deivid Wisci**
> "“Unfortunately, due to certain events that have since occurred, this course of action is no longer possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: ""Which events exactly?""*)
  - -> `[77]` (*Player: "“Good riddance.”"*)
  - -> `[78]` (*Player: "“I did what had to be done.”"*)

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Which events exactly?""]** — Mówca: **Player**
> ""Which events exactly?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true && BaseGame...."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“Good riddance.”"]** — Mówca: **Player**
> "“Good riddance.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Deivid frowned."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“I did what had to be done.”"]** — Mówca: **Player**
> "“I did what had to be done.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Deivid Wisci: "“And this is the result.”"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true && BaseGame.Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true && BaseGame...."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true && BaseGam..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true && BaseGame.Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  and  Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Deivid Wisci: "“In Valgsland's case, their intentions on Heljiland have ..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true && BaseGame.Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  and  Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[82]`
Mówca: **Deivid Wisci**
> "“In Valgsland's case, their intentions on Heljiland have been clear for many years. Our deal with Agnolia regarding the island did not sit well with them,""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: "“That's an understatement. The Alliance of Nations has sp..."*)

### Węzeł `[83]`
Mówca: **Deivid Wisci**
> "“The alliance with Agnolia itself was also a slap in the face where Valgsland was concerned.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Iosef Lancea: "“Now those commies won't be able to invade Agnolia withou..."*)

### Węzeł `[84]`
Mówca: **Deivid Wisci**
> "“And this is the result.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true && BaseGame...."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "Deivid frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true && BaseGame...."*)

### Węzeł `[86]`
Mówca: **Iosef Lancea**
> "“Now those commies won't be able to invade Agnolia without facing the might of the Sordish Armed Forces.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Iosef Lancea: "“It will make them think twice.”"*)

### Węzeł `[87]`
Mówca: **Lucian Galade**
> "“That's an understatement. The Alliance of Nations has spent years debating the status of Heljiland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Lucian Galade: "“Becoming one of the first world leaders to recognise the..."*)

### Węzeł `[88]`
Mówca: **Iosef Lancea**
> "“It will make them think twice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Deivid Wisci: "“True, but as a result, we won't be able to conduct a tra..."*)

### Węzeł `[89]`
Mówca: **Deivid Wisci**
> "“True, but as a result, we won't be able to conduct a trade deal, let alone proceed with any diplomatic missions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: "“We won't let Agnolia get bullied by Valgsland.”"*)
  - -> `[170]` (*Player: "“Unfortunate. So much needless dispute over such a small ..."*)
  - -> `[171]` (*Player: "“What is done is done. Let's look forward.”"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Deivid Wisci: "“In Valgsland's case, their intentions on Heljiland have ..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[93]`
Mówca: **Lucian Galade**
> "“That's an understatement. The Alliance of Nations has spent years debating the status of Heljiland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: "“Becoming one of the first world leaders to recognise the..."*)

### Węzeł `[94]`
Mówca: **Deivid Wisci**
> "“In Valgsland's case, their intentions on Heljiland have been clear for many years. Our deal with Agnolia regarding the island did not sit well with them,""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucian Galade: "“That's an understatement. The Alliance of Nations has sp..."*)

### Węzeł `[95]`
Mówca: **Deivid Wisci**
> "“As a result, we won't be able to conduct a trade deal let alone proceed with any diplomatic missions at the moment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: "“We won't let Agnolia get bullied by Valgsland.”"*)
  - -> `[170]` (*Player: "“Unfortunate. So much needless dispute over such a small ..."*)
  - -> `[171]` (*Player: "“What is done is done. Let's look forward.”"*)

### Węzeł `[96]`
Mówca: **Lucian Galade**
> "“Becoming one of the first world leaders to recognise the island as Agnolian was quite the statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Deivid Wisci: "“As a result, we won't be able to conduct a trade deal le..."*)

### Węzeł `[97]`
Mówca: **Lucian Galade**
> "“Becoming one of the first world leaders to recognise the island as Agnolian was quite the statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Deivid Wisci: "“The alliance with Agnolia itself was also a slap in the ..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Deivid Wisci: "“In Valgsland's case, given the country's territorial amb..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[101]`
Mówca: **Deivid Wisci**
> "“In Valgsland's case, given the country's territorial ambitions, our alliance with Agnolia was rather a slap in the face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Iosef Lancea: "“Now those commies won't be able to invade Agnolia withou..."*)

### Węzeł `[102]`
Mówca: **Iosef Lancea**
> "“Now those commies won't be able to invade Agnolia without facing the might of the Sordish Armed Forces.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Iosef Lancea: "“It will make them think twice.”"*)

### Węzeł `[103]`
Mówca: **Iosef Lancea**
> "“It will make them think twice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Deivid Wisci: "“True, but as a result, we won't be able to conduct a tra..."*)

### Węzeł `[104]`
Mówca: **Deivid Wisci**
> "“True, but as a result, we won't be able to conduct a trade deal let alone proceed with any diplomatic missions at the moment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: "“We won't let Agnolia get bullied by Valgsland.”"*)
  - -> `[170]` (*Player: "“Unfortunate. So much needless dispute over such a small ..."*)
  - -> `[171]` (*Player: "“What is done is done. Let's look forward.”"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Deivid Wisci: "“I can't discuss Valgsland without bringing up your decre..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Deivid Wisci: "“As we stand right now, any kind of deal with Valgsland i..."*)

### Węzeł `[108]`
Mówca: **Deivid Wisci**
> "“I can't discuss Valgsland without bringing up your decree to embargo United Contana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Deivid Wisci: "“Blacklisting the superpower leading the CSP was naturall..."*)

### Węzeł `[109]`
Mówca: **Deivid Wisci**
> "“Blacklisting the superpower leading the CSP was naturally going to anger one of the alliance's most important members.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player: "“Sordland will never get closer to Valgsland.”"*)
  - -> `[112]` (*Player: "“You don't seem satisfied with my decision.”"*)
  - -> `[111]` (*Player: "“We will not rely on anyone but ourselves.”"*)

### Węzeł `[110]`
Mówca: **Deivid Wisci**
> "“As we stand right now, any kind of deal with Valgsland is simply out of the question.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Deivid Wisci: "“Moving on to Lespia.”"*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“We will not rely on anyone but ourselves.”"]** — Mówca: **Player**
> "“We will not rely on anyone but ourselves.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Deivid looked me up and down before returning to his papers."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“You don't seem satisfied with my decision.”"]** — Mówca: **Player**
> "“You don't seem satisfied with my decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Deivid Wisci: "“That is because I am not.”"*)

### Węzeł `[113]`
Mówca: **Deivid Wisci**
> "“That is because I am not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Deivid Wisci: "“As we stand right now, any kind of deal with Valgsland i..."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "Deivid looked me up and down before returning to his papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Deivid Wisci: "“As we stand right now, any kind of deal with Valgsland i..."*)

### Węzeł `[115]`
Mówca: **Deivid Wisci**
> "“Following the visits to Wehlen and Agnolia, we were to pursue potential trade deals with two greater nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true || BaseGame...."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true || BaseGame...."*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true || BaseGam..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Deivid Wisci: "“Valgsland is one of them. Or at least *was*.”"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Deivid Wisci: "“Valgsland is one of them.”"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == t..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Deivid Wisci: "“Our southern neighbour is one of the wealthiest countrie..."*)

### Węzeł `[122]`
Mówca: **Deivid Wisci**
> "“Valgsland is one of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Deivid Wisci: "“If we can manage to get them to the table, there is much..."*)

### Węzeł `[123]`
Mówca: **Deivid Wisci**
> "“If we can manage to get them to the table, there is much more potential here than in Wehlen or Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Deivid Wisci: "“Because they are one of the most important countries in ..."*)

### Węzeł `[124]`
Mówca: **Deivid Wisci**
> "“Valgsland is one of them. Or at least *was*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Deivid Wisci: "“Unfortunately, a trade deal with them no longer seems po..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_East == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lucian Galade: "“It would also strengthen our voter base, since they're e..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_East == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player: "“Dealing with countries in CSP is dangerous.”"*)
  - -> `[162]` (*Player: "“We should do whatever we can to get them on our side.”"*)
  - -> `[163]` (*Player: "“We don't need the help of other countries.”"*)

### Węzeł `[128]`
Mówca: **Deivid Wisci**
> "“Because they are one of the most important countries in CSP, a deal with Valgsland is a ticket to bring Sordland closer to the United Contanan sphere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)

### Węzeł `[129]`
Mówca: **Deivid Wisci**
> "“Moving on to Lespia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)

### Węzeł `[130]`
Mówca: **Deivid Wisci**
> "“Our southern neighbour is one of the wealthiest countries in Eastern Merkopa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Deivid Wisci: "“A trade deal with them would be very beneficial, not jus..."*)

### Węzeł `[131]`
Mówca: **Deivid Wisci**
> "“A trade deal with them would be very beneficial, not just for our economy, but also for our regional and international presence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Deivid Wisci: "“Not to mention that they are in the Arcasian sphere.”"*)

### Węzeł `[132]`
Mówca: **Deivid Wisci**
> "“Not to mention that they are in the Arcasian sphere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)

### Węzeł `[133]`
Mówca: **Lucian Galade**
> "“Because we would be following through with our promise to lean westwards, this would also strengthen our voter base.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Deivid Wisci: "“Indeed. This deal could also be the first step in allyin..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_West == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucian Galade: "“Because we would be following through with our promise t..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_West == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: "“A trade deal with Lespia could open many doors for us.""*)
  - -> `[178]` (*Player: "“I do not wish to get closer with any country in ATO.”"*)
  - -> `[182]` (*Player: "“I don't trust Lespia.”"*)

### Węzeł `[137]`
Mówca: **Deivid Wisci**
> "“Indeed. This deal could also be the first step in allying ourselves with Lespia or maybe even entering ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: "“Sordland will get to its rightful place within ATO.”"*)
  - -> `[177]` (*Player: "“A trade deal with Lespia could open many doors for us.""*)
  - -> `[182]` (*Player: "“I don't trust Lespia.”"*)

### Węzeł `[138]`
Mówca: **Lucian Galade**
> "“It would also strengthen our voter base, since they're expecting us to follow through on our promise to lean eastwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Deivid Wisci: "“Indeed. This trade deal could also be the first step in ..."*)

### Węzeł `[139]`
Mówca: **Deivid Wisci**
> "“Indeed. This trade deal could also be the first step in allying ourselves with Valgsland or maybe even entering CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player: "“Sordland will get to its rightful place within CSP.”"*)
  - -> `[162]` (*Player: "“We should do whatever we can to get them on our side.”"*)
  - -> `[163]` (*Player: "“We don't need the help of other countries.”"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == t..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Deivid Wisci: "“Our southern neighbor is rather sore over our embargo of..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[143]`
Mówca: **Deivid Wisci**
> "“Our southern neighbor is rather sore over our embargo of Arcasia, as are all the countries in ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Deivid Wisci: "“Another factor is our decision to accept financial aid f..."*)

### Węzeł `[144]`
Mówca: **Deivid Wisci**
> "“Another factor is our decision to accept financial aid from United Contana, allowing its ships to dock at our naval base in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Deivid Wisci: "“Granting those docking rights essentially gave United Co..."*)

### Węzeł `[145]`
Mówca: **Deivid Wisci**
> "“Granting those docking rights essentially gave United Contana a foothold in Eastern Merkopa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Deivid Wisci: "“It is no wonder ATO felt threatened by this move.”"*)

### Węzeł `[146]`
Mówca: **Deivid Wisci**
> "“It is no wonder ATO felt threatened by this move.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Deivid Wisci: "“In any case, a deal won't be happening with Lespia. That..."*)

### Węzeł `[147]`
Mówca: **Deivid Wisci**
> "“In any case, a deal won't be happening with Lespia. That is for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player: "“I hope you are not questioning my decisions.”"*)
  - -> `[185]` (*Player: "“Good. We will never make a deal with a country in ATO.”"*)
  - -> `[186]` (*Player: "“Unfortunate but necessary.”"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == t..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Deivid Wisci: "“Our southern neighbor is rather sore over our decision t..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Deivid Wisci: "“Unfortunately, it doesn't seem possible for us to attemp..."*)

### Węzeł `[151]`
Mówca: **Deivid Wisci**
> "“Our southern neighbor is rather sore over our decision to accept financial aid from United Contana, allowing its ships to dock at our naval base in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Deivid Wisci: "“Granting those docking rights essentially gave United Co..."*)

### Węzeł `[152]`
Mówca: **Deivid Wisci**
> "“Granting those docking rights essentially gave United Contana a foothold in Eastern Merkopa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Deivid Wisci: "“It is no wonder ATO felt threatened by this move.”"*)

### Węzeł `[153]`
Mówca: **Deivid Wisci**
> "“It is no wonder ATO felt threatened by this move.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Deivid Wisci: "“In any case, a deal won't be happening with Lespia. That..."*)

### Węzeł `[154]`
Mówca: **Deivid Wisci**
> "“In any case, a deal won't be happening with Lespia. That is for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player: "“I hope you are not questioning my decisions.”"*)
  - -> `[185]` (*Player: "“Good. We will never make a deal with a country in ATO.”"*)

### Węzeł `[155]`
Mówca: **Deivid Wisci**
> "“Unfortunately, it doesn't seem possible for us to attempt a trade deal with our southern neighbor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Deivid Wisci: "“Lespia is rather sore over our embargo of Arcasia, as ar..."*)

### Węzeł `[156]`
Mówca: **Deivid Wisci**
> "“Lespia is rather sore over our embargo of Arcasia, as are all the countries in ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player: "“I hope you are not questioning my decisions.”"*)
  - -> `[185]` (*Player: "“Good. We will never make a deal with a country in ATO.”"*)
  - -> `[186]` (*Player: "“Unfortunate but necessary.”"*)

### Węzeł `[157]`
Mówca: **Deivid Wisci**
> "“Unfortunately, a trade deal with them no longer seems possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true && BaseGame...."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Agnolia_HeljilandRecognised == true || BaseGa..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true)  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Deivid Wisci: "“In light of all this, I will begin researching other pot..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true)  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Deivid Wisci: "“That is it for the overview.”"*)

### Węzeł `[161]`
**[WYBÓR GRACZA: "“Dealing with countries in CSP is dangerous.”"]** — Mówca: **Player**
> "“Dealing with countries in CSP is dangerous.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[128]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Lucian Galade: "“A simple trade deal wouldn't cause issues unless we deci..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA: "“We should do whatever we can to get them on our side.”"]** — Mówca: **Player**
> "“We should do whatever we can to get them on our side.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[139]` (Deivid Wisci), `[128]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Lucian Galade: "“I agree. Vaglsland is certainly powerful enough to deter..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: "“We don't need the help of other countries.”"]** — Mówca: **Player**
> "“We don't need the help of other countries.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[139]` (Deivid Wisci), `[128]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucian Galade: "“As we all know, times change, Mr. President.”"*)

### Węzeł `[164]`
**[WYBÓR GRACZA: "“Sordland will get to its rightful place within CSP.”"]** — Mówca: **Player**
> "“Sordland will get to its rightful place within CSP.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lucian Galade: "“That would be the best outcome.”"*)

### Węzeł `[165]`
Mówca: **Lucian Galade**
> "“A simple trade deal wouldn't cause issues unless we decide to go further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Deivid Wisci: "“Moving on to Lespia.”"*)

### Węzeł `[166]`
Mówca: **Lucian Galade**
> "“That would be the best outcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Deivid Wisci: "“Moving on to Lespia.”"*)

### Węzeł `[167]`
Mówca: **Lucian Galade**
> "“I agree. Vaglsland is certainly powerful enough to deter Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Deivid Wisci: "“Moving on to Lespia.”"*)

### Węzeł `[168]`
Mówca: **Lucian Galade**
> "“As we all know, times change, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Deivid Wisci: "“Moving on to Lespia.”"*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "“We won't let Agnolia get bullied by Valgsland.”"]** — Mówca: **Player**
> "“We won't let Agnolia get bullied by Valgsland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Deivid Wisci), `[95]` (Deivid Wisci), `[104]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[170]`
**[WYBÓR GRACZA: "“Unfortunate. So much needless dispute over such a small island...”"]** — Mówca: **Player**
> "“Unfortunate. So much needless dispute over such a small island...”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Deivid Wisci), `[95]` (Deivid Wisci), `[104]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Deivid Wisci: "“I'm afraid it might get much worse in the future.”"*)

### Węzeł `[171]`
**[WYBÓR GRACZA: "“What is done is done. Let's look forward.”"]** — Mówca: **Player**
> "“What is done is done. Let's look forward.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Deivid Wisci), `[95]` (Deivid Wisci), `[104]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Deivid Wisci: "“As you wish.”"*)

### Węzeł `[172]`
Mówca: **Deivid Wisci**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[173]`
Mówca: **Deivid Wisci**
> "“I'm afraid it might get much worse in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[174]`
Mówca: **Deivid Wisci**
> "“Now that we have an alliance with them, I agree. We can't leave them alone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Sordland will never get closer to Valgsland.”"]** — Mówca: **Player**
> "“Sordland will never get closer to Valgsland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Deivid looked me up and down before returning to his papers."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: "“Sordland will get to its rightful place within ATO.”"]** — Mówca: **Player**
> "“Sordland will get to its rightful place within ATO.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Lucian Galade: "“That would be the best outcome.”"*)

### Węzeł `[177]`
**[WYBÓR GRACZA: "“A trade deal with Lespia could open many doors for us.""]** — Mówca: **Player**
> "“A trade deal with Lespia could open many doors for us.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[137]` (Deivid Wisci), `[132]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Lucian Galade: "“True. A country as influential as Lespia could help elev..."*)

### Węzeł `[178]`
**[WYBÓR GRACZA: "“I do not wish to get closer with any country in ATO.”"]** — Mówca: **Player**
> "“I do not wish to get closer with any country in ATO.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[132]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Lucian Galade: "“That's a valid concern. Dealing with them would mean fac..."*)

### Węzeł `[179]`
Mówca: **Lucian Galade**
> "“True. A country as influential as Lespia could help elevate our economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)

### Węzeł `[180]`
Mówca: **Lucian Galade**
> "“That would be the best outcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)

### Węzeł `[181]`
Mówca: **Lucian Galade**
> "“Nor do I, but it would certainly be profitable to have a business relationship with them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA: "“I don't trust Lespia.”"]** — Mówca: **Player**
> "“I don't trust Lespia.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[137]` (Deivid Wisci), `[132]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Lucian Galade: "“Nor do I, but it would certainly be profitable to have a..."*)

### Węzeł `[183]`
Mówca: **Lucian Galade**
> "“That's a valid concern. Dealing with them would mean facing CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)

### Węzeł `[184]`
**[WYBÓR GRACZA: "“I hope you are not questioning my decisions.”"]** — Mówca: **Player**
> "“I hope you are not questioning my decisions.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Deivid Wisci), `[154]` (Deivid Wisci), `[156]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Deivid Wisci: "“Of course not, sir.”"*)

### Węzeł `[185]`
**[WYBÓR GRACZA: "“Good. We will never make a deal with a country in ATO.”"]** — Mówca: **Player**
> "“Good. We will never make a deal with a country in ATO.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Deivid Wisci), `[154]` (Deivid Wisci), `[156]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Deivid Wisci: "“As you wish.”"*)

### Węzeł `[186]`
**[WYBÓR GRACZA: "“Unfortunate but necessary.”"]** — Mówca: **Player**
> "“Unfortunate but necessary.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Deivid Wisci), `[156]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Deivid Wisci: "“I agree.”"*)

### Węzeł `[187]`
Mówca: **Deivid Wisci**
> "“Of course not, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)

### Węzeł `[188]`
Mówca: **Deivid Wisci**
> "“I agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)

### Węzeł `[189]`
Mówca: **Deivid Wisci**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)

### Węzeł `[190]`
Mówca: **Deivid Wisci**
> "“In light of all this, I will begin researching other potential trading partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Deivid Wisci: "“That will be it for today. Thank you for coming.”"*)

### Węzeł `[191]`
Mówca: **Deivid Wisci**
> "“That will be it for today. Thank you for coming.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Maintain == true || B..."*)

### Węzeł `[192]`
Mówca: **Deivid Wisci**
> "“As to the actual contents of the trade deal...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Deivid Wisci: "“The investment we have made in the Agnland region has yi..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == t..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Deivid Wisci: "“The investment we have made in the Bergia region has yie..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == t..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Deivid Wisci: "“The investment we have done in the Lorren region has yie..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Deivid Wisci: "“Lucian?”"*)

### Węzeł `[202]`
Mówca: **Deivid Wisci**
> "“The investment we have made in the Agnland region has yielded positive results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Deivid Wisci: "“Lucian?”"*)

### Węzeł `[203]`
Mówca: **Deivid Wisci**
> "“The investment we have made in the Bergia region has yielded positive results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Deivid Wisci: "“Lucian?”"*)

### Węzeł `[204]`
Mówca: **Deivid Wisci**
> "“The investment we have done in the Lorren region has yielded positive results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Deivid Wisci: "“Lucian?”"*)

### Węzeł `[205]`
Mówca: **Deivid Wisci**
> "“Lucian?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "Lucian pulled out his small notebook and quickly flipped ..."*)

### Węzeł `[206]`
Mówca: **Deivid Wisci**
> "“Lucian?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "Lucian pulled out his small notebook and quickly flipped ..."*)

### Węzeł `[207]`
Mówca: **Deivid Wisci**
> "“Lucian?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "Lucian pulled out his small notebook and quickly flipped ..."*)

### Węzeł `[208]`
Mówca: **Lucian Galade**
> "“Looking at my stats here, the investment helped increase the coal output of the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lucian Galade: "“We now have a surplus.”"*)

### Węzeł `[209]`
Mówca: **Lucian Galade**
> "“We now have a surplus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Deivid Wisci: "“Which makes an excellent resource for trade.”"*)

### Węzeł `[210]`
Mówca: **Deivid Wisci**
> "“Which makes an excellent resource for trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Deivid Wisci: "“But let's not get ahead of ourselves.""*)

### Węzeł `[211]`
Mówca: **Lucian Galade**
> "“Looking at my stats here, the investment helped increase the wheat output of the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Lucian Galade: "“We now have a surplus.”"*)

### Węzeł `[212]`
Mówca: **Lucian Galade**
> "“We now have a surplus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Deivid Wisci: "“Which makes an excellent resource for trade.”"*)

### Węzeł `[213]`
Mówca: **Deivid Wisci**
> "“Which makes an excellent resource for trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Deivid Wisci: "“But let's not get ahead of ourselves.""*)

### Węzeł `[214]`
Mówca: **Lucian Galade**
> "“Looking at my stats here, the investment helped increase the fishing output of the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Lucian Galade: "“We now have a surplus.”"*)

### Węzeł `[215]`
Mówca: **Lucian Galade**
> "“We now have a surplus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Deivid Wisci: "“Which makes an excellent resource for trade.”"*)

### Węzeł `[216]`
Mówca: **Deivid Wisci**
> "“Which makes an excellent resource for trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Deivid Wisci: "“But let's not get ahead of ourselves.""*)

### Węzeł `[217]`
Mówca: **Narrator**
> "Lucian pulled out his small notebook and quickly flipped through the pages until he landed on the right one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Lucian Galade: "“Looking at my stats here, the investment helped increase..."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "Lucian pulled out his small notebook and quickly flipped through the pages until he landed on the right one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Lucian Galade: "“Looking at my stats here, the investment helped increase..."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "Lucian pulled out his small notebook and quickly flipped through the pages until he landed on the right one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Lucian Galade: "“Looking at my stats here, the investment helped increase..."*)

### Węzeł `[220]`
Mówca: **Deivid Wisci**
> "“Lucian?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "Lucian pulled out his small notebook and quickly flipped ..."*)

### Węzeł `[221]`
Mówca: **Narrator**
> "Lucian pulled out his small notebook and quickly flipped through the pages until he landed on the right one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Lucian Galade: "“Looking at my stats here, we now have a small tungsten s..."*)

### Węzeł `[222]`
Mówca: **Lucian Galade**
> "“Looking at my stats here, we now have a small tungsten surplus.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Deivid Wisci: "“Which makes an excellent resource for trade.”"*)

### Węzeł `[223]`
Mówca: **Deivid Wisci**
> "“Which makes an excellent resource for trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Deivid Wisci: "“But let's not get ahead of ourselves.""*)

### Węzeł `[224]`
Mówca: **Deivid Wisci**
> "“But let's not get ahead of ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Deivid Wisci: "“I need to know your decision before we can proceed.""*)

### Węzeł `[225]`
Mówca: **Deivid Wisci**
> "“I need to know your decision before we can proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Deivid Wisci: "“What should we do?”"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) == false && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)== false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Agnolia_HeljilandRecognised == true || BaseGa..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) == false && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)== false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player: "“Begin negotiations with both Valgsland and Lespia.”"*)
  - -> `[230]` (*Player: "“Begin negotiations with Lespia.”"*)
  - -> `[231]` (*Player: "“Begin negotiations with Valgsland.”"*)
  - -> `[233]` (*Player: "“We will not make any trade deals.”"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) == false && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)== false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA: "“Begin negotiations with both Valgsland and Lespia.”"]** — Mówca: **Player**
> "“Begin negotiations with both Valgsland and Lespia.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== false` AND `(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[242]` (Iosef Lancea), `[232]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Lespia = true; BaseGame.Tr..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA: "“Begin negotiations with Lespia.”"]** — Mówca: **Player**
> "“Begin negotiations with Lespia.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== false` AND `(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[242]` (Iosef Lancea), `[232]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Lespia = true;"*)

### Węzeł `[231]`
**[WYBÓR GRACZA: "“Begin negotiations with Valgsland.”"]** — Mówca: **Player**
> "“Begin negotiations with Valgsland.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== false` AND `(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[242]` (Iosef Lancea), `[232]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.TradeDeal_Negotiation_Valgsland = true;"*)

### Węzeł `[232]`
Mówca: **Deivid Wisci**
> "“What should we do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Maintain == true || B..."*)

### Węzeł `[233]`
**[WYBÓR GRACZA: "“We will not make any trade deals.”"]** — Mówca: **Player**
> "“We will not make any trade deals.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== false` AND `(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[242]` (Iosef Lancea), `[232]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Negotiation_None = true"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) == false && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)== true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Agnolia_HeljilandRecognised == true || BaseGa..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) == false && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)== true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player: "“Begin negotiations with Valgsland.”"*)
  - -> `[233]` (*Player: "“We will not make any trade deals.”"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Agnolia_HeljilandRecognised == true || BaseGame.Agnolia_Alliance == true || BaseGame.Reform_EmergencyDecree_Embargo_UC == true) == false && (BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true || BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)== true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Agnolia_HeljilandRecognised"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false  and  (Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true)== true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player: "“Begin negotiations with Lespia.”"*)
  - -> `[233]` (*Player: "“We will not make any trade deals.”"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Maintain == true || B..."*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Maintain == true ||..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Iosef Lancea: "“Before you say anything, remember what I said.”"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)

### Węzeł `[240]`
Mówca: **Iosef Lancea**
> "“Before you say anything, remember what I said.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Iosef Lancea: "“We need allies. Not just a trade deal.”"*)

### Węzeł `[241]`
Mówca: **Iosef Lancea**
> "“We need allies. Not just a trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Iosef Lancea: "“If Rumburg attacks, we will fall.”"*)

### Węzeł `[242]`
Mówca: **Iosef Lancea**
> "“If Rumburg attacks, we will fall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Agnolia_HeljilandRecognised == true || BaseGame..."*)

### Węzeł `[243]`
Mówca: **Lucian Galade**
> "“Thank you. gentlemen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Narrator: "Iosef saluted as we left the White Room."*)

### Węzeł `[244]`
Mówca: **Iosef Lancea**
> "“Mr. President. Before we disperse, remember what I said.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Iosef Lancea: "“We need allies.”"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Maintain == true || B..."*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Maintain == true ||..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Iosef Lancea: "“Mr. President. Before we disperse, remember what I said.”"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Maintain == true || BaseGame.Turn03_EnT_Military_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Lucian Galade: "“Thank you. gentlemen.”"*)

### Węzeł `[248]`
Mówca: **Iosef Lancea**
> "“We need allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Iosef Lancea: "“If Rumburg attacks, we will fall.”"*)

### Węzeł `[249]`
Mówca: **Iosef Lancea**
> "“If Rumburg attacks, we will fall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player: "“I will think about it.”"*)
  - -> `[250]` (*Player: "“Thank you. You're dismissed.""*)
  - -> `[252]` (*Player: "“I trust your capabilities Iosef.”"*)

### Węzeł `[250]`
**[WYBÓR GRACZA: "“Thank you. You're dismissed.""]** — Mówca: **Player**
> "“Thank you. You're dismissed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[249]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "Iosef spoke softly."*)

### Węzeł `[251]`
**[WYBÓR GRACZA: "“I will think about it.”"]** — Mówca: **Player**
> "“I will think about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[249]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "Iosef spoke softly."*)

### Węzeł `[252]`
**[WYBÓR GRACZA: "“I trust your capabilities Iosef.”"]** — Mówca: **Player**
> "“I trust your capabilities, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[249]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "Iosef spoke softly."*)

### Węzeł `[253]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Lucian Galade: "“Thank you. gentlemen.”"*)

### Węzeł `[254]`
Mówca: **Narrator**
> "Iosef spoke softly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Iosef Lancea: "“Thank you, Mr. President.”"*)

### Węzeł `[255]`
Mówca: **Narrator**
> "Iosef saluted as we left the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_FPnT_DiplomacyOverview2AndTradeDeal ..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_FPnT_DiplomacyOverview2AndTradeDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_FPnT_DiplomacyOverview2AndTradeDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_LT_Polio = true"*)

### Węzeł `[257]`
Mówca: **Deivid Wisci**
> "“Excellent news. I will begin at once.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Deivid Wisci: "“That was all I had for today.”"*)

### Węzeł `[258]`
Mówca: **Deivid Wisci**
> "“Excellent news. I will begin at once.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Deivid Wisci: "“That was all I had for today.”"*)

### Węzeł `[259]`
Mówca: **Deivid Wisci**
> "“Excellent news. I will begin at once.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Deivid Wisci: "“That was all I had for today.”"*)

### Węzeł `[260]`
Mówca: **Deivid Wisci**
> "“Anton, I think that's a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Deivid Wisci: "“But I can't force you to heed my advice. You're not my s..."*)

### Węzeł `[261]`
Mówca: **Deivid Wisci**
> "“But I can't force you to heed my advice. You're not my student anymore, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Deivid Wisci: "“That was all I had for today.”"*)

### Węzeł `[262]`
Mówca: **Lucian Galade**
> "“Thank you, gentlemen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Narrator: "Iosef saluted as we left the White Room."*)

### Węzeł `[263]`
Mówca: **Deivid Wisci**
> "“Thank you for coming.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Lucian Galade: "“Thank you, gentlemen.”"*)

### Węzeł `[264]`
Mówca: **Deivid Wisci**
> "“That was all I had for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Deivid Wisci: "“Thank you for coming.”"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Lespia = true; BaseGame.TradeDeal_Negotiation_Valgsland = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] = true;
Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Negotiation_LespiaAndValgs..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Lespia = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Negotiation_Lespia = true"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TradeDeal_Negotiation_Valgsland = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Negotiation_Valgsland = true"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_TradeDeal == true)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 1;"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_TradeDeal == true)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 1;"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The doors to the White Room, like everything else in the ..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The doors to the White Room, like everything else in the ..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true && BaseGame.Turn06_InT_OnTime == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true && BaseGam..."*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true && BaseG..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true && BaseGame.Turn06_InT_OnTime == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true  and  Variable["BaseGame.Turn06_InT_OnTime"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true && BaseGame.Turn06_InT_OnTime == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true  and  Variable["BaseGame.Turn06_InT_OnTime"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true && BaseGam..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Turn06_InT_OnTime == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true && BaseGam..."*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Railway == true && BaseG..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Turn06_InT_OnTime == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  and  Variable["BaseGame.Turn06_InT_OnTime"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 1;"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Railway == true && BaseGame.Turn06_InT_OnTime == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  and  Variable["BaseGame.Turn06_InT_OnTime"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_TradeDeal == true)"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 1;"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == t..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 1;"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[291]`
Mówca: **Deivid Wisci**
> "“Moving on to Lespia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == tru..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Negotiation_LespiaAndValgsland = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Negotiation_LespiaAndValgsland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_G_RayneWillVisitBoth = true"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Negotiation_Lespia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Negotiation_Lespia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_G_RayneWillVisitLespia = true"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Negotiation_Valgsland = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Negotiation_Valgsland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_G_RayneWillVisitValgsland = true"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Negotiation_None = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Negotiation_None"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Deivid Wisci: "“Anton, I think that's a mistake.""*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy += 1;"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_TradeDeal == true"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Salary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Salary == true"*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_Salary == true)"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Salary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Narbel_MedicalSalariesIncre..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_Salary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Salary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_ImproveRural == true"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_ImproveRural == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_ImproveRural == true"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_ImproveRural == true)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_ImproveRural == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Laren_MedicalQualityIncreas..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_ImproveRural == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_ImproveRural"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Hospitals == true"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Hospitals == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Hospitals == true"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Healthcare_Hospitals == true)"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Healthcare_Hospitals == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Uziren_NewHospitalBuilt = true"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Healthcare_Hospitals == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Healthcare_Hospitals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true && BaseGam..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Narbel_MedicalSalariesIncreased = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Narbel_MedicalSalariesIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_ImproveRural == true"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Laren_MedicalQualityIncreased = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Laren_MedicalQualityIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Hospitals == true"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Uziren_NewHospitalBuilt = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Uziren_NewHospitalBuilt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true && BaseGam..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == t..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Sarna_IncreasedAgricultural..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Sarna_IncreasedAgriculturalProduction = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Sarna_IncreasedAgriculturalProduction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == tru..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == tru..."*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == t..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Deyr_HomelessnessDecrease =..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_HighwayIssue_Solved == true && BaseGa..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_HighwayIssue_Solved == true && BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_HighwayIssue_Solved == true && BaseGa..."*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_InT_HighwayIssue_Solved == true && Base..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_HighwayIssue_Solved == true && BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == true  and  Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Arvory_H3Result = true"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_InT_HighwayIssue_Solved == true && BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == true  and  Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_RailwayIssue_Solved == true && BaseGa..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_RailwayIssue_Solved == true && BaseGame.Turn01_InT_Investment_Railway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_RailwayIssue_Solved == true && BaseGa..."*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_InT_RailwayIssue_Solved == true && Base..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_RailwayIssue_Solved == true && BaseGame.Turn01_InT_Investment_Railway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == true  and  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Lachaven_L1Result = true"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_InT_RailwayIssue_Solved == true && BaseGame.Turn01_InT_Investment_Railway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == true  and  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == t..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Morna_UnemploymentReduced =..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_HighwayIssue_Solved == true && BaseGa..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Deyr_HomelessnessDecrease = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Deyr_HomelessnessDecrease"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_HighwayIssue_Solved == true && BaseGa..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Morna_UnemploymentReduced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Morna_UnemploymentReduced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_HighwayIssue_Solved == true && BaseGa..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Arvory_H3Result = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Arvory_H3Result"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Lachaven_L1Result = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Lachaven_L1Result"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_TradeDeal == true)"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Deyr_WehlenTradeReport = true"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy <= 4"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Deyr_WehlenTradeReport = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Deyr_WehlenTradeReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy <= 4"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy <= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy <= 4"*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy <= 4)"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy <= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] <= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Gelsord_RecessionHitsWorker..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy <= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] <= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Salary == true"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Gelsord_RecessionHitsWorkers = true;
BaseGameSupport.Report_Turn07_Holsord_CurrencyLosesValue = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Gelsord_RecessionHitsWorkers"] = true;
Variable["BaseGameSupport.Report_Turn07_Holsord_CurrencyLosesValue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Healthcare_Salary == true"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_LT_Polio = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_LT_Polio"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_HP_Polio = true"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_HP_Polio = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_Polio"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_G_RayneWillVisitValgsland = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_G_RayneWillVisitValgsland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Valgsland", "Progress_Di..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_G_RayneWillVisitLespia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_G_RayneWillVisitLespia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Lespia", "Progress_Diplo..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_G_RayneWillVisitBoth = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_G_RayneWillVisitBoth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Valgsland", "Progress_Di..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesse..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget += 1;"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Valgsland", "Progress_DiplomaticMission_Valgsland");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Valgsland","Progress_DiplomaticMission_Valgsland");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Lespia", "Progress_Diplo..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Lespia", "Progress_DiplomaticMission_Lespia");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Lespia","Progress_DiplomaticMission_Lespia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Deivid Wisci: "“Excellent news. I will begin at once.”"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Lespia", "Progress_DiplomaticMission_Lespia");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Lespia","Progress_DiplomaticMission_Lespia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Deivid Wisci: "“Excellent news. I will begin at once.”"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Valgsland", "Progress_DiplomaticMission_Valgsland");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Valgsland","Progress_DiplomaticMission_Valgsland");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Deivid Wisci: "“Excellent news. I will begin at once.”"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true)"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Deivid Wisci: "“Now that we have an alliance with them, I agree. We can'..."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[357]`
Mówca: **Deivid Wisci**
> "“Now that we have recognized Heljiland, I can only agree with you. Sordland shouldn't leave them alone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Deivid Wisci: "“Now that we have recognized Heljiland, I can only agree ..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Deivid Wisci: "“With limited support, I can only think that it will be d..."*)

### Węzeł `[361]`
Mówca: **Deivid Wisci**
> "“With limited support, I can only think that it will be difficult from our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
