# Sordland/Turn04/EnT_TaxReform

- **ID konwersacji:** `52`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Sordland/Turn_04/052_EnT_TaxReform.md`
- **Liczba węzłów dialogowych:** 501
- **Liczba wyborów gracza:** 44

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[13]** Mikail Aven
- **[25]** Edith Agnoc
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn04_WorkersRights_Signed`
- `BaseGame.Country_Unrest`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople`
- `BaseGame.Decision_Turn02_StatusReaction_BoostPolice`
- `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors`
- `BaseGame.Decision_Turn04_RegionalInvestment_Agnland`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn04_RegionalInvestment_Lorren`
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`
- `BaseGame.Promise_Immigration_Relaxed`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg`
- `BaseGame.Reform_EmergencyDecree_Embargo_UC`
- `BaseGame.Relations_Walter_Promise_Privatization`
- `BaseGame.Relations_Walter_Promise_Tax`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses`
- `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses`
- `BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations`
- `BaseGame.Turn04_InT_Issue_SSC_Money`
- `BaseGame.Turn04_SnO_LE_Justice_Increased`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Increase`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Question`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Capitalist`
- `BaseGame.Economy`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.GovernmentBudget`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Economy_IncreasedTaxCorps`
- `BaseGame.Policy_Economy_IncreasedTaxSME`
- `BaseGame.Policy_Economy_TaxBreakForSME`
- `BaseGame.Policy_Economy_TaxBreaksForPrivateCorps`
- `BaseGame.Public_Opinion`
- `BaseGame.Relations_Walter_Promise_TaxFulfilled`
- `BaseGame.Situation_Economy_LargeBusiness_CreateJobs`
- `BaseGame.Situation_Economy_LargeBusiness_Downsize`
- `BaseGame.Situation_Economy_SmallBusiness_Growth`
- `BaseGame.Situation_Economy_SmallBusiness_Stagnate`
- `BaseGame.Situation_Economy_TaxAvoidance`
- `BaseGame.Situation_Economy_TaxEfficientEconomy`
- `BaseGame.Situation_Economy_TaxEvasion`
- `BaseGame.Sollist`
- `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses`
- `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses`
- `BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxMaintain_SmallMediumBusinesses`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain`
- `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Increase`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain`
- `BaseGameIsolated.Turn04_EnT_SmallMedium_Question`
- `BaseGameSupport.CountryReport_Turn04_Rumburg_QueenThreat`
- `BaseGameSupport.CountryReport_Turn04_Rumburg_QueenThreat2`
- `BaseGameSupport.FactionReport_Turn04_ATO_DwightWalkerSupport`
- `BaseGameSupport.FactionReport_Turn04_ATO_EconomicSummit`
- `BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Decrease`
- `BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Increase`
- `BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Maintain`
- `BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Decrease`
- `BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Increase`
- `BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Maintain`
- `BaseGameSupport.News_Turn04_E_TaxReform_Decreased_Large`
- `BaseGameSupport.News_Turn04_E_TaxReform_Increased_Large`
- `BaseGameSupport.News_Turn04_G_SmolakThreatensBFF`
- `BaseGameSupport.News_Turn04_HP_RemusRelaxedMigration`
- `BaseGameSupport.News_Turn04_HP_RemusTightMigration`
- `BaseGameSupport.News_Turn04_HP_TaxReform_Decreased_Small`
- `BaseGameSupport.News_Turn04_HP_TaxReform_Increased_Small`
- `BaseGameSupport.News_Turn04_LT_DeyrLockdown`
- `BaseGameSupport.News_Turn04_LT_PoliceShotProtester`
- `BaseGameSupport.News_Turn04_LT_ProtestersTraitors`
- `BaseGameSupport.News_Turn04_LT_TorrenSchoolAward`
- `BaseGameSupport.News_Turn04_LT_YSDeclaration`
- `BaseGameSupport.News_Turn04_R_RYDeclaration`
- `BaseGameSupport.News_Turn04_R_TaxReform_Increased_Small`
- `BaseGameSupport.News_Turn04_R_TaxReform_Increased_Small_Decreased_Large`
- `BaseGameSupport.Report_Turn04_Holsord_ArcasiaEmbargo`
- `BaseGameSupport.Report_Turn04_Holsord_ConstructionFixed`
- `BaseGameSupport.Report_Turn04_Holsord_RumburgEmbargo`
- `BaseGameSupport.Report_Turn04_Holsord_UnitedContanaEmbargo`
- `BaseGameSupport.Report_Turn04_Valgen_GruniRuralDev`
- `GameCondition.Turn04_EnT_TaxReform`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[13]` | **"“Good afternoon.”"** | `[10]` **Mikail Aven**: "“Good afternoon, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Narrator**: "Symon put down his bag on the ta..." |
| `[14]` | **"“It's great to see you all again.”"** | `[10]` **Mikail Aven**: "“Good afternoon, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Narrator**: "Symon put down his bag on the ta..." |
| `[15]` | **"“Take a seat and let's begin.”"** | `[10]` **Mikail Aven**: "“Good afternoon, Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Narrator**: "Symon put down his bag on the ta..." |
| `[24]` | **"“What is the outcome if we increase the taxes for large corporations?”"** | `[23]` **Symon Holl**: "“Let's start with the large corp..."<br>`[75]` **Player**: "“Maybe you are right.”"<br>*(oraz 10 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] == false` | *Brak zmian stanu* | `[44]` **Symon Holl**: "“Simply put, if we increase the ..."<br>`[264]` **Symon Holl**: "“It's not an option at this poin..." |
| `[25]` | **"“What if we decrease the taxes for large corporations?”"** | `[23]` **Symon Holl**: "“Let's start with the large corp..."<br>`[75]` **Player**: "“Maybe you are right.”"<br>*(oraz 10 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] == false` | *Brak zmian stanu* | `[46]` **Symon Holl**: "“Our government budget will be h..."<br>`[275]` **Symon Holl**: "“It's not an option at this poin..." |
| `[26]` | **"“What does everyone think we should do?”"** | `[23]` **Symon Holl**: "“Let's start with the large corp..."<br>`[75]` **Player**: "“Maybe you are right.”"<br>*(oraz 10 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] == false` | *Brak zmian stanu* | `[53]` **Symon Holl**: "“My personal opinion is that we ..."<br>`[291]` **Symon Holl**: "“I don't think we can do anythin..." |
| `[27]` | **"“I am ready to make a decision.”"** | `[23]` **Symon Holl**: "“Let's start with the large corp..."<br>`[75]` **Player**: "“Maybe you are right.”"<br>*(oraz 10 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] == true` | *Brak zmian stanu* | `[71]` **Symon Holl**: "“Very well, Mr. President. We wa..." |
| `[51]` | **"“Is there any downside to keeping the things as they are?”"** | `[23]` **Symon Holl**: "“Let's start with the large corp..."<br>`[75]` **Player**: "“Maybe you are right.”"<br>*(oraz 10 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] == false` | *Brak zmian stanu* | `[286]` **Symon Holl**: "“Unfortunately, that's the only ..."<br>`[52]` **Symon Holl**: "“I am of the opinion that if we ..." |
| `[72]` | **"“They better try to stay on *my* good side.”"** | `[66]` **Mikail Aven**: "“Me too. You would have the Grou..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrea...` | `[24]` **Player**: "“What is the outcome if we incre..."<br>`[25]` **Player**: "“What if we decrease the taxes f..."<br>*(oraz 3 innych odgałęzień)* |
| `[73]` | **"“I have to agree. Being their ally would come in handy.”"** | `[66]` **Mikail Aven**: "“Me too. You would have the Grou..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrea...` | `[24]` **Player**: "“What is the outcome if we incre..."<br>`[25]` **Player**: "“What if we decrease the taxes f..."<br>*(oraz 3 innych odgałęzień)* |
| `[74]` | **"“It goes both ways, Mr. Aven.”"** | `[64]` **Mikail Aven**: "“I will go a step further. Incre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Mikail Aven**: "“Of course.”" |
| `[75]` | **"“Maybe you are right.”"** | `[64]` **Mikail Aven**: "“I will go a step further. Incre..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increa...` | `[24]` **Player**: "“What is the outcome if we incre..."<br>`[25]` **Player**: "“What if we decrease the taxes f..."<br>*(oraz 3 innych odgałęzień)* |
| `[82]` | **"“Decrease the taxes for large corporations.” [-4 Government Budget]"** | `[71]` **Symon Holl**: "“Very well, Mr. President. We wa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"...`<br>`Variable["BaseGameSupport.Journal_Turn04_TaxReform_LargeC...`<br>*(+1 skryptów)* | `[87]` **Mikail Aven**: "“An excellent decision.”" |
| `[83]` | **"“Maintain the taxes for large corporations.”"** | `[71]` **Symon Holl**: "“Very well, Mr. President. We wa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_EnT_TaxMaintain_LargeCorporatio...`<br>`Variable["BaseGameSupport.Journal_Turn04_TaxReform_LargeC...` | `[86]` **Mikail Aven**: "“This will not change anything.”" |
| `[84]` | **"“Increase the taxes for large corporations.” [+3 Government Budget]"** | `[71]` **Symon Holl**: "“Very well, Mr. President. We wa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporatio...`<br>`Variable["BaseGame.Policy_Economy_IncreasedTaxCorps"] = t...`<br>*(+1 skryptów)* | `[85]` **Mikail Aven**: "“You are making a mistake.”" |
| `[99]` | **"“What is the outcome if we increase the taxes for small and medium businesses?”"** | `[95]` **Symon Holl**: "“Let's move on to the small and ..."<br>`[139]` **Mikail Aven**: "“I am with Edith and Symon on th..."<br>*(oraz 8 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] == false` | *Brak zmian stanu* | `[112]` **Symon Holl**: "“They are the backbone of our ec..."<br>`[320]` **Symon Holl**: "“Unfortunately this is not a pos..." |
| `[100]` | **"“What if we decrease the taxes for small and medium businesses?”"** | `[95]` **Symon Holl**: "“Let's move on to the small and ..."<br>`[139]` **Mikail Aven**: "“I am with Edith and Symon on th..."<br>*(oraz 8 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] == false` | *Brak zmian stanu* | `[113]` **Symon Holl**: "“It should be helpful in curbing..."<br>`[321]` **Symon Holl**: "“Unfortunately this is not a pos..." |
| `[109]` | **"“Increase the taxes for small and medium businesses.” [+2 Government Budget]"** | `[131]` **Symon Holl**: "“Very well.”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusi...`<br>`Variable["BaseGame.Policy_Economy_IncreasedTaxSME"] = true;`<br>*(+1 skryptów)* | `[119]` **Symon Holl**: "“Very well. I have taken another..." |
| `[110]` | **"“You might be right.”"** | `[132]` **Mikail Aven**: "“In the long run, increasing the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increas...` | `[99]` **Player**: "“What is the outcome if we incre..."<br>`[100]` **Player**: "“What if we decrease the taxes f..."<br>*(oraz 3 innych odgałęzień)* |
| `[111]` | **"“People need their hard earned money.”"** | `[132]` **Mikail Aven**: "“In the long run, increasing the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increas...` | `[99]` **Player**: "“What is the outcome if we incre..."<br>`[100]` **Player**: "“What if we decrease the taxes f..."<br>*(oraz 3 innych odgałęzień)* |
| `[114]` | **"“Is there any downside to keeping the things as they are?”"** | `[95]` **Symon Holl**: "“Let's move on to the small and ..."<br>`[139]` **Mikail Aven**: "“I am with Edith and Symon on th..."<br>*(oraz 8 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] == false` | *Brak zmian stanu* | `[115]` **Symon Holl**: "“Sordland needs change to get ou..."<br>`[325]` **Symon Holl**: "“Sordland needs change to get ou..." |
| `[120]` | **"“Decrease the taxes for small and medium businesses.” [-3 Government Budget]"** | `[131]` **Symon Holl**: "“Very well.”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusines...`<br>`Variable["BaseGame.Policy_Economy_TaxBreakForSME"] = true;`<br>*(+1 skryptów)* | `[119]` **Symon Holl**: "“Very well. I have taken another..." |
| `[133]` | **"“I am ready to make a decision.”"** | `[95]` **Symon Holl**: "“Let's move on to the small and ..."<br>`[139]` **Mikail Aven**: "“I am with Edith and Symon on th..."<br>*(oraz 8 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] == true` | *Brak zmian stanu* | `[131]` **Symon Holl**: "“Very well.”" |
| `[134]` | **"“What does everyone think we should do?”"** | `[95]` **Symon Holl**: "“Let's move on to the small and ..."<br>`[139]` **Mikail Aven**: "“I am with Edith and Symon on th..."<br>*(oraz 8 innych węzłów)* | `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] == false  and  Variable["BaseGame.GovernmentBudget"] >= 0  and 
Variable["BaseGame.Economy"] >= 3` | *Brak zmian stanu* | `[108]` **Symon Holl**: "“My personal opinion is, we shou..."<br>`[329]` **Symon Holl**: "“Unfortunately there is not much..." |
| `[147]` | **"“Maintain the taxes for small and medium businesses.”"** | `[131]` **Symon Holl**: "“Very well.”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_EnT_TaxMaintain_SmallMediumBusi...`<br>`Variable["BaseGameSupport.Journal_Turn04_TaxReform_SmallM...` | `[119]` **Symon Holl**: "“Very well. I have taken another..." |
| `[149]` | **"“I can't risk the popularity loss.”"** | `[132]` **Mikail Aven**: "“In the long run, increasing the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increas...` | `[99]` **Player**: "“What is the outcome if we incre..."<br>`[100]` **Player**: "“What if we decrease the taxes f..."<br>*(oraz 3 innych odgałęzień)* |
| `[151]` | **"“Good work.”"** | `[150]` **Symon Holl**: "“Well then... Thank you everyone..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Narrator**: "They left the meeting room. I de..." |
| `[152]` | **"“Enjoy Lachaven.”"** | `[150]` **Symon Holl**: "“Well then... Thank you everyone..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Narrator**: "They left the meeting room. I de..." |
| `[153]` | **"“Thanks Symon.”"** | `[150]` **Symon Holl**: "“Well then... Thank you everyone..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Narrator**: "They left the meeting room. I de..." |
| `[170]` | **"“What is unfortunate was that this bill was enacted this late.”"** | `[164]` **Edith Agnoc**: "“Unfortunate, really. Especially..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Narrator**: "Neither of them responded." |
| `[171]` | **"“You are in no position to question my decision.”"** | `[164]` **Edith Agnoc**: "“Unfortunate, really. Especially..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Narrator**: "Neither of them responded." |
| `[172]` | **"“I don't care about rumours. If someone wants to say something, they can say it to..."** | `[164]` **Edith Agnoc**: "“Unfortunate, really. Especially..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Narrator**: "Neither of them responded." |
| `[174]` | **"“I wanted to sign it but I had to make the right call.”"** | `[168]` **Edith Agnoc**: "“A good decision I'd say. Especi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Edith Agnoc**: "“You have done the right thing.”" |
| `[175]` | **"“You are in no position to evaluate my decision.”"** | `[168]` **Edith Agnoc**: "“A good decision I'd say. Especi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Narrator**: "Neither of them responded." |
| `[176]` | **"“I don't care about rumours. If someone wants to say something, they can say it to..."** | `[168]` **Edith Agnoc**: "“A good decision I'd say. Especi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Narrator**: "Neither of them responded." |
| `[266]` | **"“We could balance it by decreasing taxes of small businesses to put some relief on..."** | `[265]` **Symon Holl**: "“Taking what's remaining from th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Symon Holl**: "“I see. I'm not sure if that's a..." |
| `[268]` | **"“I see.”"** | `[265]` **Symon Holl**: "“Taking what's remaining from th..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increa...` | `[24]` **Player**: "“What is the outcome if we incre..."<br>`[25]` **Player**: "“What if we decrease the taxes f..."<br>*(oraz 3 innych odgałęzień)* |
| `[269]` | **"“So, we can't do it?”"** | `[265]` **Symon Holl**: "“Taking what's remaining from th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Symon Holl**: "“It's not a possibility. Unless ..." |
| `[277]` | **"“So, we can't do it?”"** | `[276]` **Symon Holl**: "“We are barely functioning with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Symon Holl**: "“It's not a possibility. Unless ..." |
| `[278]` | **"“I see.”"** | `[276]` **Symon Holl**: "“We are barely functioning with ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrea...` | `[24]` **Player**: "“What is the outcome if we incre..."<br>`[25]` **Player**: "“What if we decrease the taxes f..."<br>*(oraz 3 innych odgałęzień)* |
| `[280]` | **"“We could balance it by increasing the taxes of small businesses.”"** | `[276]` **Symon Holl**: "“We are barely functioning with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Symon Holl**: "“I see. I'm not sure if that's a..." |
| `[304]` | **"“We'll increase the taxes for large corporations and balance it with a decrease fo..."** | `[71]` **Symon Holl**: "“Very well, Mr. President. We wa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporatio...`<br>`Variable["BaseGame.Policy_Economy_IncreasedTaxCorps"] = t...`<br>*(+1 skryptów)* | `[85]` **Mikail Aven**: "“You are making a mistake.”" |
| `[305]` | **"“We'll decrease the taxes for large corporations and balance the budget with an in..."** | `[71]` **Symon Holl**: "“Very well, Mr. President. We wa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"...`<br>`Variable["BaseGame.Policy_Economy_IncreasedTaxSME"] = tru...`<br>*(+2 skryptów)* | `[312]` **Mikail Aven**: "“An excellent decision.”" |
| `[467]` | **"“I didn't want to hamper our businesses and their employment drive.”"** | `[168]` **Edith Agnoc**: "“A good decision I'd say. Especi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Edith Agnoc**: "“You have done the right thing.”" |

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
  - -> `[3]` (*Narrator: "We were at the top floor of the business council building..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "We were at the top floor of the business council building which had a great view of the beautiful Lachaven. I looked outside from the tall glass windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Tracing back the paths of the ships, I looked at the harbour. Lachaven was home to one of the largest harbours in the entire continent. Many dockyard workers were loading or unloading the containers. Work never stopped here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The door opened. Symon, Mikail and Edith entered the meet..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "The Markian Sea stretched as far as the eye could see and it was dotted with many ships towards the horizon. They were mostly cargo ships, carrying precious goods in and out of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Tracing back the paths of the ships, I looked at the harb..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "The door opened. Symon, Mikail and Edith entered the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Symon Holl: "“Mr. President.”"*)

### Węzeł `[7]`
Mówca: **Symon Holl**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Edith Agnoc: "“Mr. President. So nice to see you again.”"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Symon put down his bag on the table and started collecting his documents while the others slowly took their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Symon waited patiently. Once everyone was ready, he adjusted his glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Symon Holl: "“First of all, I would like to thank everyone here for th..."*)

### Węzeł `[10]`
Mówca: **Mikail Aven**
> "“Good afternoon, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: "“It's great to see you all again.”"*)
  - -> `[13]` (*Player: "“Good afternoon.”"*)
  - -> `[15]` (*Player: "“Take a seat and let's begin.”"*)

### Węzeł `[11]`
Mówca: **Edith Agnoc**
> "“Mr. President. So nice to see you again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Mikail Aven: "“Good afternoon, Mr. President.”"*)

### Węzeł `[12]`
Mówca: **Symon Holl**
> "“First of all, I would like to thank everyone here for their work on our tax system reform.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Symon Holl: "“We all know how complicated our current system is and th..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Good afternoon.”"]** — Mówca: **Player**
> "“Good afternoon.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Symon put down his bag on the table and started collectin..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“It's great to see you all again.”"]** — Mówca: **Player**
> "“It's great to see you all again.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Symon put down his bag on the table and started collectin..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Take a seat and let's begin.”"]** — Mówca: **Player**
> "“Take a seat and let's begin.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Symon put down his bag on the table and started collectin..."*)

### Węzeł `[16]`
Mówca: **Symon Holl**
> "“We all know how complicated our current system is and this work wouldn't be possible without you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "He turned to me."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Symon Holl: "“The ultimate goal here is to end the recession.”"*)

### Węzeł `[18]`
Mówca: **Symon Holl**
> "“Before we move ahead and start formulating a plan, we need you to determine our direction, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Symon Holl: "“We have a few possibilities as a result of the work we h..."*)

### Węzeł `[19]`
Mówca: **Symon Holl**
> "“We have a few possibilities as a result of the work we have done so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Symon Holl: "“We can increase, maintain or decrease the taxes for larg..."*)

### Węzeł `[20]`
Mówca: **Symon Holl**
> "“We can increase, maintain or decrease the taxes for large corporations. I believe some of us in the room have a few strong opinions about this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Symon Holl: "“In parallel, we can increase, maintain or decrease the t..."*)

### Węzeł `[21]`
Mówca: **Symon Holl**
> "“In parallel, we can increase, maintain or decrease the taxes for small and medium businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Symon Holl: "“Let's start with the large corporations. And we'll move ..."*)

### Węzeł `[22]`
Mówca: **Symon Holl**
> "“The ultimate goal here is to end the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Symon Holl: "“Before we move ahead and start formulating a plan, we ne..."*)

### Węzeł `[23]`
Mówca: **Symon Holl**
> "“Let's start with the large corporations. And we'll move on to small businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "LargeCorpTaxQuestions"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“What is the outcome if we increase the taxes for large corporations?”"]** — Mówca: **Player**
> "“What is the outcome if we increase the taxes for large corporations?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Symon Holl), `[75]` (Player), `[76]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 3"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“What if we decrease the taxes for large corporations?”"]** — Mówca: **Player**
> "“What if we decrease the taxes for large corporations?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Symon Holl), `[75]` (Player), `[76]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -1"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“What does everyone think we should do?”"]** — Mówca: **Player**
> "“What does everyone think we should do?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Symon Holl), `[75]` (Player), `[76]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 0"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“I am ready to make a decision.”"]** — Mówca: **Player**
> "“I am ready to make a decision.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] == true`
- **Kontekst wejściowy (poprzednik):** `[23]` (Symon Holl), `[75]` (Player), `[76]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Symon Holl: "“Very well, Mr. President. We want to ensure the economy ..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LargeCorpTaxQuestions`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == false"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == false"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == false"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == false"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == true..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == false"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == fa..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: "“What is the outcome if we increase the taxes for large c..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == false"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == fa..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: "“What if we decrease the taxes for large corporations?”"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == false"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == fa..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: "“What does everyone think we should do?”"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == true..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == tr..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "“I am ready to make a decision.”"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease == true || BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "Jump to: [LargeCorpTaxQuestions]"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "Jump to: [LargeCorpTaxQuestions]"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "Jump to: [LargeCorpTaxQuestions]"*)

### Węzeł `[44]`
Mówca: **Symon Holl**
> "“Simply put, if we increase the taxes, we will have more government budget to spend which may come in handy. On the other hand, it's not directly helping us revitalise the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= 0"*)

### Węzeł `[45]`
Mówca: **Symon Holl**
> "“Our government is already in debt. This might be a way to get out of that debt.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Edith Agnoc: "“I do believe there is one way to get out of recession. I..."*)

### Węzeł `[46]`
Mówca: **Symon Holl**
> "“Our government budget will be hit. But in return, due to the sheer size of the economic contribution coming from these companies, it should be helpful in curbing the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Symon Holl: "“I do think this is definitely a good option if we want t..."*)

### Węzeł `[47]`
Mówca: **Symon Holl**
> "“I do think this is definitely a good option if we want to end the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget == 0"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == false"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == fa..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“Is there any downside to keeping the things as they are?”"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Is there any downside to keeping the things as they are?”"]** — Mówca: **Player**
> "“Is there any downside to keeping the things as they are?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain"] == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Symon Holl), `[75]` (Player), `[76]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= -1 && BaseGame.Economy <= 1"*)

### Węzeł `[52]`
Mówca: **Symon Holl**
> "“I am of the opinion that if we don't make any changes, nothing will change. To stop the recession, we need to do something.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Edith Agnoc: "“I think so too.”"*)

### Węzeł `[53]`
Mówca: **Symon Holl**
> "“My personal opinion is that we should decrease the taxes for large corporations. Although in short term it would cost us, in the long run it would be the most helpful option in ending the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Edith Agnoc: "“Our international trade is driven mostly by the products..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= 0"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget <= 0)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Symon Holl: "“Our government is already in debt. This might be a way t..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Symon Holl: "“We already have a budget surplus. I don't see much value..."*)

### Węzeł `[57]`
Mówca: **Symon Holl**
> "“We already have a budget surplus. I don't see much value in increasing our capital without investing it in possibilities that might help end the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Edith Agnoc: "“I do believe there is one way to get out of recession. I..."*)

### Węzeł `[58]`
Mówca: **Symon Holl**
> "“However, there is one problem. The status of our budget. This might not be the greatest idea although it has its benefits. You will have to decide if it's worth the risk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Edith Agnoc: "“I think this is a viable idea. Upsetting the existing ba..."*)

### Węzeł `[59]`
Mówca: **Symon Holl**
> "“Especially with the current state of our budget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Edith Agnoc: "“I think this is a viable idea. Upsetting the existing ba..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget == 0"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget == 0)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Symon Holl: "“However, there is one problem. The status of our budget...."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] == 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Symon Holl: "“Especially with the current state of our budget.”"*)

### Węzeł `[63]`
Mówca: **Edith Agnoc**
> "“I do believe there is one way to get out of recession. It is through the trade and the economic contribution of large corporations. Increasing their taxes will turn them on you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Mikail Aven: "“I will go a step further. Increasing their taxes will ha..."*)

### Węzeł `[64]`
Mówca: **Mikail Aven**
> "“I will go a step further. Increasing their taxes will have disastrous results and it will make you an enemy of them. Trust me, Mr. President. Nobody wants to make an enemy of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: "“Maybe you are right.”"*)
  - -> `[74]` (*Player: "“It goes both ways, Mr. Aven.”"*)

### Węzeł `[65]`
Mówca: **Edith Agnoc**
> "“I think this is a viable idea. Upsetting the existing balance might be less than ideal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Mikail Aven: "“Me too. You would have the Group on your good side on to..."*)

### Węzeł `[66]`
Mówca: **Mikail Aven**
> "“Me too. You would have the Group on your good side on top of solving the recession crisis, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: "“I have to agree. Being their ally would come in handy.”"*)
  - -> `[72]` (*Player: "“They better try to stay on *my* good side.”"*)

### Węzeł `[67]`
Mówca: **Edith Agnoc**
> "“I think so too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Mikail Aven: "“Agreed. ”"*)

### Węzeł `[68]`
Mówca: **Mikail Aven**
> "“Agreed. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain = true"*)

### Węzeł `[69]`
Mówca: **Edith Agnoc**
> "“Our international trade is driven mostly by the products of these corporations. They are the backbone of our economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Mikail Aven: "“Exactly. If we let them perform better by decreasing the..."*)

### Węzeł `[70]`
Mówca: **Mikail Aven**
> "“Exactly. If we let them perform better by decreasing their taxes, this should in turn lead to Sordland receiving more investment. This means more capital which means a quicker way out of the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question = true"*)

### Węzeł `[71]`
Mówca: **Symon Holl**
> "“Very well, Mr. President. We want to ensure the economy is on a balanced track as further destabilization might have drastic consequences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "“Increase the taxes for large corporations.” [+3 Governme..."*)
  - -> `[304]` (*Player: "“We'll increase the taxes for large corporations and bala..."*)
  - -> `[83]` (*Player: "“Maintain the taxes for large corporations.”"*)
  - -> `[82]` (*Player: "“Decrease the taxes for large corporations.” [-4 Governme..."*)
  - -> `[305]` (*Player: "“We'll decrease the taxes for large corporations and bala..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“They better try to stay on *my* good side.”"]** — Mówca: **Player**
> "“They better try to stay on *my* good side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease = true"*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“I have to agree. Being their ally would come in handy.”"]** — Mówca: **Player**
> "“I have to agree. Being their ally would come in handy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease = true"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“It goes both ways, Mr. Aven.”"]** — Mówca: **Player**
> "“It goes both ways, Mr. Aven.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Mikail Aven: "“Of course.”"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Maybe you are right.”"]** — Mówca: **Player**
> "“Maybe you are right.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase = true"*)

### Węzeł `[76]`
Mówca: **Mikail Aven**
> "“Of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase = true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "Jump to: [LargeCorpTaxQuestions]"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [LargeCorpTaxQuestions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "LargeCorpTaxQuestions"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [LargeCorpTaxQuestions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "LargeCorpTaxQuestions"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [LargeCorpTaxQuestions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "LargeCorpTaxQuestions"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [LargeCorpTaxQuestions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "LargeCorpTaxQuestions"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Decrease the taxes for large corporations.” [-4 Government Budget]"]** — Mówca: **Player**
> "“Decrease the taxes for large corporations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations = true; Ba..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Maintain the taxes for large corporations.”"]** — Mówca: **Player**
> "“Maintain the taxes for large corporations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations = true"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Increase the taxes for large corporations.” [+3 Government Budget]"]** — Mówca: **Player**
> "“Increase the taxes for large corporations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations = true"*)

### Węzeł `[85]`
Mówca: **Mikail Aven**
> "“You are making a mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Edith Agnoc: "“This is going to have outrageous effects down the road.”"*)

### Węzeł `[86]`
Mówca: **Mikail Aven**
> "“This will not change anything.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Edith Agnoc: "“We won't gain anything by standing still where we are. I..."*)

### Węzeł `[87]`
Mówca: **Mikail Aven**
> "“An excellent decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Edith Agnoc: "“I agree. Thanks to this, the recession will be solved in..."*)

### Węzeł `[88]`
Mówca: **Edith Agnoc**
> "“This is going to have outrageous effects down the road.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Symon Holl: "“Enough. The President has made his choice.”"*)

### Węzeł `[89]`
Mówca: **Edith Agnoc**
> "“We won't gain anything by standing still where we are. I protest against this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Symon Holl: "“Enough. The President has made his choice.”"*)

### Węzeł `[90]`
Mówca: **Edith Agnoc**
> "“I agree. Thanks to this, the recession will be solved in no time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Symon Holl: "“I also think this was a good choice.”"*)

### Węzeł `[91]`
Mówca: **Symon Holl**
> "“Enough. The President has made his choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Symon Holl: "“Well then. I have taken a note of our action and I will ..."*)

### Węzeł `[92]`
Mówca: **Symon Holl**
> "“I also think this was a good choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Symon Holl: "“Well then. I have taken a note of our action and I will ..."*)

### Węzeł `[93]`
Mówca: **Symon Holl**
> "“Well then. I have taken a note of our action and I will put it to implementation as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Symon opened his briefcase and swapped out the stack of papers he had in front with another stack."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Symon Holl: "“Let's move on to the small and medium businesses.”"*)

### Węzeł `[95]`
Mówca: **Symon Holl**
> "“Let's move on to the small and medium businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "SmallMediumBusinessTaxQuestions"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == false"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == false)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player: "“What is the outcome if we increase the taxes for small a..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[99]`
**[WYBÓR GRACZA: "“What is the outcome if we increase the taxes for small and medium businesses?”"]** — Mówca: **Player**
> "“What is the outcome if we increase the taxes for small and medium businesses?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] == false`
- **Kontekst wejściowy (poprzednik):** `[95]` (Symon Holl), `[139]` (Mikail Aven), `[329]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_Lar..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“What if we decrease the taxes for small and medium businesses?”"]** — Mówca: **Player**
> "“What if we decrease the taxes for small and medium businesses?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] == false`
- **Kontekst wejściowy (poprzednik):** `[95]` (Symon Holl), `[139]` (Mikail Aven), `[329]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -1 || BaseGame.Turn04_EnT_Ta..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SmallMediumBusinessTaxQuestions`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == false"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == false"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == false"*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Question == false..."*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Question == true ..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == false"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == false)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: "“What if we decrease the taxes for small and medium busin..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SmallMediumBusinessTaxQuestions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "SmallMediumBusinessTaxQuestions"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "Jump to: [SmallMediumBusinessTaxQuestions]"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SmallMediumBusinessTaxQuestions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "SmallMediumBusinessTaxQuestions"*)

### Węzeł `[108]`
Mówca: **Symon Holl**
> "“My personal opinion is, we should increase the taxes for small and medium corporations. It will make people angry, yes. But we can make them happier in the future *after* we end the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Edith Agnoc: "“People tend to be... forgetful as well.”"*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Increase the taxes for small and medium businesses.” [+2 Government Budget]"]** — Mówca: **Player**
> "“Increase the taxes for small and medium businesses.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses = true"*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“You might be right.”"]** — Mówca: **Player**
> "“You might be right.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Increase = true"*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“People need their hard earned money.”"]** — Mówca: **Player**
> "“People need their hard earned money.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Increase = true"*)

### Węzeł `[112]`
Mówca: **Symon Holl**
> "“They are the backbone of our economy and they are comprised of mostly regular people. If we start demanding more money from them in taxes, it might cause the public to harbour ill will towards the government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= -2"*)

### Węzeł `[113]`
Mówca: **Symon Holl**
> "“It should be helpful in curbing the recession for sure. Of course that will come at the cost of losing some of our government budget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= 0"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Is there any downside to keeping the things as they are?”"]** — Mówca: **Player**
> "“Is there any downside to keeping the things as they are?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] == false`
- **Kontekst wejściowy (poprzednik):** `[95]` (Symon Holl), `[139]` (Mikail Aven), `[329]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -1 && BaseGame.Economy >= 3"*)

### Węzeł `[115]`
Mówca: **Symon Holl**
> "“Sordland needs change to get out of recession. One way or another. I don't think we will come back on our feet by not doing anything to change our status quo.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain = true"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == false"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == false)"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: "“Is there any downside to keeping the things as they are?”"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[119]`
Mówca: **Symon Holl**
> "“Very well. I have taken another note. We will look into how to go about implementing these changes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Symon Holl: "“Well then... Thank you everyone. That will be all for to..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Decrease the taxes for small and medium businesses.” [-3 Government Budget]"]** — Mówca: **Player**
> "“Decrease the taxes for small and medium businesses.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses = true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "Jump to: [SmallMediumBusinessTaxQuestions]"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= -2"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget <= -2)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= -2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= -2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Symon Holl: "“On the other hand, we need to get out of debt one way or..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget <= -2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= -2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Symon Holl: "“Our budget is in a good shape. I don't see the need to i..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_SmallMedium_Increase = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "Jump to: [SmallMediumBusinessTaxQuestions]"*)

### Węzeł `[126]`
Mówca: **Symon Holl**
> "“On the other hand, we need to get out of debt one way or another. This can be a solution for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Edith Agnoc: "“I think increasing taxes for these smaller corporations ..."*)

### Węzeł `[127]`
Mówca: **Symon Holl**
> "“Our budget is in a good shape. I don't see the need to increase the taxes at the cost of popularity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Edith Agnoc: "“I think increasing taxes for these smaller corporations ..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= 0"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget <= 0)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Symon Holl: "“It is risky when we have no money left, and we still hav..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease = true"*)

### Węzeł `[131]`
Mówca: **Symon Holl**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: "“Increase the taxes for small and medium businesses.” [+2..."*)
  - -> `[147]` (*Player: "“Maintain the taxes for small and medium businesses.”"*)
  - -> `[120]` (*Player: "“Decrease the taxes for small and medium businesses.” [-3..."*)

### Węzeł `[132]`
Mówca: **Mikail Aven**
> "“In the long run, increasing the taxes for small and medium businesses would make people happier with the services the government provides.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: "“You might be right.”"*)
  - -> `[111]` (*Player: "“People need their hard earned money.”"*)
  - -> `[149]` (*Player: "“I can't risk the popularity loss.”"*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "“I am ready to make a decision.”"]** — Mówca: **Player**
> "“I am ready to make a decision.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] == true`
- **Kontekst wejściowy (poprzednik):** `[95]` (Symon Holl), `[139]` (Mikail Aven), `[329]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Symon Holl: "“Very well.”"*)

### Węzeł `[134]`
**[WYBÓR GRACZA: "“What does everyone think we should do?”"]** — Mówca: **Player**
> "“What does everyone think we should do?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] == false  and  Variable["BaseGame.GovernmentBudget"] >= 0  and 
Variable["BaseGame.Economy"] >= 3`
- **Kontekst wejściowy (poprzednik):** `[95]` (Symon Holl), `[139]` (Mikail Aven), `[329]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_Lar..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SmallMediumBusinessTaxQuestions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "SmallMediumBusinessTaxQuestions"*)

### Węzeł `[136]`
Mówca: **Symon Holl**
> "“It is risky when we have no money left, and we still have loans to pay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease = true"*)

### Węzeł `[137]`
Mówca: **Edith Agnoc**
> "“I think increasing taxes for these smaller corporations is a good way to earn some extra capital so that the government can give it back to people in due time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Mikail Aven: "“In the long run, increasing the taxes for small and medi..."*)

### Węzeł `[138]`
Mówca: **Edith Agnoc**
> "“People tend to be... forgetful as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Mikail Aven: "“I am with Edith and Symon on that one.”"*)

### Węzeł `[139]`
Mówca: **Mikail Aven**
> "“I am with Edith and Symon on that one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Question = true"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_SmallMedium_Question == false && BaseGame.GovernmentBudget >= 0 &&
BaseGame.Economy >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Question == false..."*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_EnT_SmallMedium_Question == fal..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_SmallMedium_Question == false && BaseGame.GovernmentBudget >= 0 &&
BaseGame.Economy >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] == false  and  Variable["BaseGame.GovernmentBudget"] >= 0  and 
Variable["BaseGame.Economy"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player: "“What does everyone think we should do?”"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_EnT_SmallMedium_Question == false && BaseGame.GovernmentBudget >= 0 &&
BaseGame.Economy >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] == false  and  Variable["BaseGame.GovernmentBudget"] >= 0  and 
Variable["BaseGame.Economy"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_SmallMedium_Question = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "Jump to: [SmallMediumBusinessTaxQuestions]"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_SmallMedium_Question == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Question == true ..."*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn04_EnT_SmallMedium_Question == tru..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn04_EnT_SmallMedium_Question == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player: "“I am ready to make a decision.”"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn04_EnT_SmallMedium_Question == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Increase == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease == true || BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Question"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Increase"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Decrease"] == true  or  Variable["BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[147]`
**[WYBÓR GRACZA: "“Maintain the taxes for small and medium businesses.”"]** — Mówca: **Player**
> "“Maintain the taxes for small and medium businesses.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxMaintain_SmallMediumBusinesses = true"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SmallMediumBusinessTaxQuestions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "SmallMediumBusinessTaxQuestions"*)

### Węzeł `[149]`
**[WYBÓR GRACZA: "“I can't risk the popularity loss.”"]** — Mówca: **Player**
> "“I can't risk the popularity loss.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Increase = true"*)

### Węzeł `[150]`
Mówca: **Symon Holl**
> "“Well then... Thank you everyone. That will be all for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: "“Good work.”"*)
  - -> `[152]` (*Player: "“Enjoy Lachaven.”"*)
  - -> `[153]` (*Player: "“Thanks Symon.”"*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "They left the meeting room. I decided to stay a bit longer."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "“Enjoy Lachaven.”"]** — Mówca: **Player**
> "“Enjoy Lachaven.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "They left the meeting room. I decided to stay a bit longer."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "“Thanks Symon.”"]** — Mówca: **Player**
> "“Thanks Symon.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "They left the meeting room. I decided to stay a bit longer."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "They left the meeting room. I decided to stay a bit longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "I went by the windows again and kept watching the sea in silence for some more time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn04_EnT_TaxReform = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn04_EnT_TaxReform"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn04_WorkersRights_Signed == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn04_WorkersRights_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Mikail Aven: "“Mr. President. Before we start, I would like to mention ..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn04_WorkersRights_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn04_WorkersRights_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Mikail Aven: "“Mr. President. Before we start, I would like to mention ..."*)

### Węzeł `[160]`
Mówca: **Mikail Aven**
> "“Mr. President. Before we start, I would like to mention some rumours that I heard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Mikail Aven: "“Workers' Rights Act did not sit well with many business ..."*)

### Węzeł `[161]`
Mówca: **Mikail Aven**
> "“Especially the first section about the minimum wages.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Edith Agnoc: "“I heard the same. This has caused these businesses to lo..."*)

### Węzeł `[162]`
Mówca: **Mikail Aven**
> "“Workers' Rights Act did not sit well with many business holders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Mikail Aven: "“Especially the first section about the minimum wages.”"*)

### Węzeł `[163]`
Mówca: **Edith Agnoc**
> "“I heard the same. This has caused these businesses to lose millions of Rens just overnight.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Edith Agnoc: "“Unfortunate, really. Especially during a recession.”"*)

### Węzeł `[164]`
Mówca: **Edith Agnoc**
> "“Unfortunate, really. Especially during a recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player: "“What is unfortunate was that this bill was enacted this ..."*)
  - -> `[171]` (*Player: "“You are in no position to question my decision.”"*)
  - -> `[172]` (*Player: "“I don't care about rumours. If someone wants to say some..."*)

### Węzeł `[165]`
Mówca: **Mikail Aven**
> "“Mr. President. Before we start, I would like to mention some rumours that I heard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Mikail Aven: "“Vetoing the recent Workers' Rights Act was welcomed by a..."*)

### Węzeł `[166]`
Mówca: **Mikail Aven**
> "“The first section about the minimum wages would've been very damaging to many corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Edith Agnoc: "“I heard the same.”"*)

### Węzeł `[167]`
Mówca: **Mikail Aven**
> "“Vetoing the recent Workers' Rights Act was welcomed by a lot of business owners.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Mikail Aven: "“The first section about the minimum wages would've been ..."*)

### Węzeł `[168]`
Mówca: **Edith Agnoc**
> "“A good decision I'd say. Especially during a recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player: "“I wanted to sign it but I had to make the right call.”"*)
  - -> `[467]` (*Player: "“I didn't want to hamper our businesses and their employm..."*)
  - -> `[175]` (*Player: "“You are in no position to evaluate my decision.”"*)
  - -> `[176]` (*Player: "“I don't care about rumours. If someone wants to say some..."*)

### Węzeł `[169]`
Mówca: **Edith Agnoc**
> "“I heard the same.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Edith Agnoc: "“A good decision I'd say. Especially during a recession.”"*)

### Węzeł `[170]`
**[WYBÓR GRACZA: "“What is unfortunate was that this bill was enacted this late.”"]** — Mówca: **Player**
> "“What is really unfortunate, Ms. Edith, was that this bill was enacted this late.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Neither of them responded."*)

### Węzeł `[171]`
**[WYBÓR GRACZA: "“You are in no position to question my decision.”"]** — Mówca: **Player**
> "“You are in no position to question my decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Neither of them responded."*)

### Węzeł `[172]`
**[WYBÓR GRACZA: "“I don't care about rumours. If someone wants to say something, they can say it to me directly.”"]** — Mówca: **Player**
> "“I don't care about rumours. If someone wants to say something, they can say it to me directly.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Neither of them responded."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "Neither of them responded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Symon waited patiently. Once everyone was ready, he adjus..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA: "“I wanted to sign it but I had to make the right call.”"]** — Mówca: **Player**
> "“I wanted to sign it but I had to make the right call.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Edith Agnoc: "“You have done the right thing.”"*)

### Węzeł `[175]`
**[WYBÓR GRACZA: "“You are in no position to evaluate my decision.”"]** — Mówca: **Player**
> "“You are in no position to evaluate my decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "Neither of them responded."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: "“I don't care about rumours. If someone wants to say something, they can say it to me directly.”"]** — Mówca: **Player**
> "“I don't care about rumours. If someone wants to say something, they can say it to me directly.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "Neither of them responded."*)

### Węzeł `[177]`
Mówca: **Edith Agnoc**
> "“You have done the right thing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Symon waited patiently. Once everyone was ready, he adjus..."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "Neither of them responded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Symon waited patiently. Once everyone was ready, he adjus..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_IncreasedTaxCorps = true"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations = true;
BaseGame.Policy_Economy_TaxBreaksForPrivateCorps = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] = true;
Variable["BaseGame.Policy_Economy_TaxBreaksForPrivateCorps"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_IncreasedTaxSME = true"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxMaintain_SmallMediumBusinesses = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxMaintain_SmallMediumBusinesses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusin..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_TaxBreakForSME = true"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Increase = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Increase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Mikail Aven: "“You are making a mistake.”"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Maintain = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Maintain"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Mikail Aven: "“This will not change anything.”"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Decrease = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Decrease"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Tax == true"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Increase = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Increase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Symon Holl: "“Very well. I have taken another note. We will look into ..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Maintain = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Maintain"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Symon Holl: "“Very well. I have taken another note. We will look into ..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Decrease = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Decrease"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Symon Holl: "“Very well. I have taken another note. We will look into ..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_G_SmolakThreatensBFF = true; BaseGameSupport.FactionReport_Turn04_ATO_EconomicSummit = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_G_SmolakThreatensBFF"] = true;
Variable["BaseGameSupport.FactionReport_Turn04_ATO_EconomicSummit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_LT_DeyrLockdown = true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_LT_DeyrLockdown = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_DeyrLockdown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_R_RYDeclaration = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_RYDeclaration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_R_RYDeclaration = true"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_LT_YSDeclaration = true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_LT_YSDeclaration = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_YSDeclaration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The Markian Sea stretched as far as the eye could see and..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest > 0"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest > 0"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Country_Unrest > 0)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Country_Unrest"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Country_Unrest > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Country_Unrest"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The Markian Sea stretched as far as the eye could see and..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == ..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_LT_PoliceShotProtester = true"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors ==..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_LT_ProtestersTraitors = true"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The Markian Sea stretched as far as the eye could see and..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_LT_PoliceShotProtester = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_PoliceShotProtester"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The Markian Sea stretched as far as the eye could see and..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_LT_ProtestersTraitors = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_ProtestersTraitors"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The Markian Sea stretched as far as the eye could see and..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_E_TaxReform_Increased_Large =..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_E_TaxReform_Decreased_Large =..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_E_TaxReform_Increased_Large = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_TaxReform_Increased_Large"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_E_TaxReform_Decreased_Large = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_TaxReform_Decreased_Large"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses =..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_R_TaxReform_Increased_Small =..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == t..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_HP_TaxReform_Decreased_Small ..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_G_SmolakThreatensBFF = true; ..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_HP_TaxReform_Increased_Small = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_TaxReform_Increased_Small"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_G_SmolakThreatensBFF = true; ..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_HP_TaxReform_Decreased_Small = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_TaxReform_Decreased_Small"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_G_SmolakThreatensBFF = true; ..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true && BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses =..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true && BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true  and  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_R_TaxReform_Increased_Small_D..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true && BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true  and  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_R_TaxReform_Increased_Small_Decreased_Large = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_TaxReform_Increased_Small_Decreased_Large"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_HP_TaxReform_Increased_Small ..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_R_TaxReform_Increased_Small = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_TaxReform_Increased_Small"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_HP_TaxReform_Increased_Small ..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn04_ATO_DwightWalkerSupp..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn04_Rumburg_QueenThreat ..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn04_Rumburg_QueenThreat2..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.FactionReport_Turn04_ATO_DwightWalkerSupport = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn04_ATO_DwightWalkerSupport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn04_Rumburg_QueenThreat = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn04_Rumburg_QueenThreat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Money == true"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Money == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Money == true"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_InT_Issue_SSC_Money == true)"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_Issue_SSC_Money == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_InT_Issue_SSC_Money"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Holsord_ConstructionFixed =..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_InT_Issue_SSC_Money == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_Issue_SSC_Money"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Holsord_ConstructionFixed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_ConstructionFixed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Holsord_ArcasiaEmbargo = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_ArcasiaEmbargo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Holsord_ArcasiaEmbargo = true"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_TaxBreakForSME = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Economy_TaxBreakForSME"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusin..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_IncreasedTaxSME = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Economy_IncreasedTaxSME"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusin..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_IncreasedTaxCorps = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Economy_IncreasedTaxCorps"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 3"*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 3)"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Symon Holl: "“Simply put, if we increase the taxes, we will have more ..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Symon Holl: "“It's not an option at this point. Our economy is in sham..."*)

### Węzeł `[264]`
Mówca: **Symon Holl**
> "“It's not an option at this point. Our economy is in shambles.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Symon Holl: "“Taking what's remaining from the businesses will destroy..."*)

### Węzeł `[265]`
Mówca: **Symon Holl**
> "“Taking what's remaining from the businesses will destroy the economy further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player: "“We could balance it by decreasing taxes of small busines..."*)
  - -> `[268]` (*Player: "“I see.”"*)
  - -> `[269]` (*Player: "“So, we can't do it?”"*)

### Węzeł `[266]`
**[WYBÓR GRACZA: "“We could balance it by decreasing taxes of small businesses to put some relief on them.”"]** — Mówca: **Player**
> "“We could balance it by decreasing taxes of small businesses to put some relief on them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Symon Holl: "“I see. I'm not sure if that's a good idea with the curre..."*)

### Węzeł `[267]`
Mówca: **Symon Holl**
> "“I see. I'm not sure if that's a good idea with the current state of our economy...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Edith Agnoc: "“I do believe there is one way to get out of recession. I..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA: "“I see.”"]** — Mówca: **Player**
> "“I see.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Increase = true"*)

### Węzeł `[269]`
**[WYBÓR GRACZA: "“So, we can't do it?”"]** — Mówca: **Player**
> "“So, we can't do it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Symon Holl: "“It's not a possibility. Unless if we try and balance it ..."*)

### Węzeł `[270]`
Mówca: **Symon Holl**
> "“It's not a possibility. Unless if we try and balance it with a tax decrease for small and medium businesses...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Symon Holl: "“I do not advise that though.”"*)

### Węzeł `[271]`
Mówca: **Symon Holl**
> "“I do not advise that though.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Edith Agnoc: "“I do believe there is one way to get out of recession. I..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -1"*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= -1)"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Symon Holl: "“Our government budget will be hit. But in return, due to..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= -1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Symon Holl: "“It's not an option at this point. Our state is broke.”"*)

### Węzeł `[275]`
Mówca: **Symon Holl**
> "“It's not an option at this point. Our state is broke.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Symon Holl: "“We are barely functioning with the help of the taxes.”"*)

### Węzeł `[276]`
Mówca: **Symon Holl**
> "“We are barely functioning with the help of the taxes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player: "“We could balance it by increasing the taxes of small bus..."*)
  - -> `[278]` (*Player: "“I see.”"*)
  - -> `[277]` (*Player: "“So, we can't do it?”"*)

### Węzeł `[277]`
**[WYBÓR GRACZA: "“So, we can't do it?”"]** — Mówca: **Player**
> "“So, we can't do it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Symon Holl: "“It's not a possibility. Unless if we try and balance it ..."*)

### Węzeł `[278]`
**[WYBÓR GRACZA: "“I see.”"]** — Mówca: **Player**
> "“I see.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease = true"*)

### Węzeł `[279]`
Mówca: **Symon Holl**
> "“I see. I'm not sure if that's a good idea with the current state of our economy...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Edith Agnoc: "“I think this is a viable idea. Upsetting the existing ba..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA: "“We could balance it by increasing the taxes of small businesses.”"]** — Mówca: **Player**
> "“We could balance it by increasing the taxes of small businesses.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Symon Holl: "“I see. I'm not sure if that's a good idea with the curre..."*)

### Węzeł `[281]`
Mówca: **Symon Holl**
> "“I do not advise that though.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Decrease = true"*)

### Węzeł `[282]`
Mówca: **Symon Holl**
> "“It's not a possibility. Unless if we try and balance it with a tax increase for small and medium businesses...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Symon Holl: "“I do not advise that though.”"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= -1 && BaseGame.Economy <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= -1 && BaseGame.Economy <= 1"*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget <= -1 && BaseGame.Economy <= 1)"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= -1 && BaseGame.Economy <= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= -1  and  Variable["BaseGame.Economy"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Symon Holl: "“Unfortunately, that's the only thing we can do at this p..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget <= -1 && BaseGame.Economy <= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= -1  and  Variable["BaseGame.Economy"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Symon Holl: "“I am of the opinion that if we don't make any changes, n..."*)

### Węzeł `[286]`
Mówca: **Symon Holl**
> "“Unfortunately, that's the only thing we can do at this point anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Edith Agnoc: "“The economy is completely destroyed, Mr. President. I do..."*)

### Węzeł `[287]`
Mówca: **Edith Agnoc**
> "“The economy is completely destroyed, Mr. President. I don't know how we'll get out of this mess...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Maintain = true"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= 0"*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= 0)"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Symon Holl: "“My personal opinion is that we should decrease the taxes..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Symon Holl: "“I don't think we can do anything at this point. Although..."*)

### Węzeł `[291]`
Mówca: **Symon Holl**
> "“I don't think we can do anything at this point. Although I would have preferred a decrease in taxes, it doesn't seem to be the best option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Edith Agnoc: "“Our international trade is driven mostly by the products..."*)

### Węzeł `[292]`
Mówca: **Edith Agnoc**
> "“Our international trade is driven mostly by the products of these corporations. They are the backbone of our economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Mikail Aven: "“Exactly. An increase should be out of the question. Thes..."*)

### Węzeł `[293]`
Mówca: **Mikail Aven**
> "“Exactly. An increase should be out of the question. These companies are the backbone of our economy and our way out of the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_LargeCorpTax_Question = true"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_Lar..."*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_L..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 3  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Symon Holl: "“They are the backbone of our economy and they are compri..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 3  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Symon Holl: "“Unfortunately this is not a possibility. People have no ..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true && BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true..."*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == tr..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true && BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true  and  Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Symon Holl: "“We will be giving people some relief by enacting tax bre..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true && BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true  and  Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true &&..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true &&
BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true &&..."*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true ..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true &&
BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  and 
Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Symon Holl: "“We will be increasing taxes for smaller businesses. And ..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true &&
BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  and 
Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Symon opened his briefcase and swapped out the stack of p..."*)

### Węzeł `[303]`
Mówca: **Symon Holl**
> "“We will be giving people some relief by enacting tax breaks for small and medium businesses. And there will be an increase for large corporation taxes, which will help us sustain our balance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "Symon organized the stack of papers he had in front and p..."*)

### Węzeł `[304]`
**[WYBÓR GRACZA: "“We'll increase the taxes for large corporations and balance it with a decrease for small businesses.”"]** — Mówca: **Player**
> "“We'll increase the taxes for large corporations and balance it with a decrease for small businesses.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations = true;..."*)

### Węzeł `[305]`
**[WYBÓR GRACZA: "“We'll decrease the taxes for large corporations and balance the budget with an increase for smaller businesses.” [-2 Government Budget]"]** — Mówca: **Player**
> "“We'll decrease the taxes for large corporations and balance the budget with an increase for smaller businesses.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations = true; Ba..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations = true;
BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] = true;
Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_IncreasedTaxCorps = true; BaseGam..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_IncreasedTaxCorps = true;
BaseGame.Policy_Economy_TaxBreakForSME = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Economy_IncreasedTaxCorps"] = true;
Variable["BaseGame.Policy_Economy_TaxBreakForSME"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Increase = true;
BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Decrease = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Increase"] = true;
Variable["BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Decrease"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Mikail Aven: "“You are making a mistake.”"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations = true;
BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] = true;
Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_IncreasedTaxSME = true; BaseGame...."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_IncreasedTaxSME = true; BaseGame.Policy_Economy_TaxBreaksForPrivateCorps = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Economy_IncreasedTaxSME"] = true;
Variable["BaseGame.Policy_Economy_TaxBreaksForPrivateCorps"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Decrease = true;
BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Increase = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_TaxReform_LargeCorporation_Decrease"] = true;
Variable["BaseGameSupport.Journal_Turn04_TaxReform_SmallMediumBusinesses_Increase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Tax == true"*)

### Węzeł `[312]`
Mówca: **Mikail Aven**
> "“An excellent decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Edith Agnoc: "“I agree. Thanks to this, the recession will be solved in..."*)

### Węzeł `[313]`
Mówca: **Edith Agnoc**
> "“I agree. Thanks to this, the recession will be solved in no time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Symon Holl: "“I think this will actually have negative effects on our ..."*)

### Węzeł `[314]`
Mówca: **Symon Holl**
> "“I think this will actually have negative effects on our economy. People will suffer... But anyway...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Symon Holl: "“Well then. I have taken a note of our action and I will ..."*)

### Węzeł `[315]`
Mówca: **Symon Holl**
> "“We will be increasing taxes for smaller businesses. And there will be a tax break large corporations. This will drain a lot from the smaller businesses to balance the state budget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "Symon organized the stack of papers he had in front and p..."*)

### Węzeł `[316]`
Mówca: **Narrator**
> "Symon organized the stack of papers he had in front and placed them back into his briefcase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Symon Holl: "“Well then... Thank you everyone. That will be all for to..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -1 || BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -1 || BaseGame.Turn04_EnT_Ta..."*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= -1 || BaseGame.Turn04_EnT_..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -1 || BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= -1  or  Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Symon Holl: "“It should be helpful in curbing the recession for sure. ..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= -1 || BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= -1  or  Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Symon Holl: "“Unfortunately this is not a possibility. Our state is br..."*)

### Węzeł `[320]`
Mówca: **Symon Holl**
> "“Unfortunately this is not a possibility. People have no money left to give to the state. Our economic development cannot support this. There's not much value in circulation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Increase = true"*)

### Węzeł `[321]`
Mówca: **Symon Holl**
> "“Unfortunately this is not a possibility. Our state is broke. We are barely functioning with the current taxes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= 0"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -1 &&
BaseGame.Economy >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget >= -1 && BaseGame.Economy >= 3"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget >= -1 && BaseGame.Economy >= 3)"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget >= -1 &&
BaseGame.Economy >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] >= -1  and 
Variable["BaseGame.Economy"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Symon Holl: "“Sordland needs change to get out of recession. One way o..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget >= -1 &&
BaseGame.Economy >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] >= -1  and 
Variable["BaseGame.Economy"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Symon Holl: "“Sordland needs change to get out of recession. But the c..."*)

### Węzeł `[325]`
Mówca: **Symon Holl**
> "“Sordland needs change to get out of recession. But the current state of the economy is in shambles. There is not much change we can do about taxes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Maintain = true"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_Lar..."*)
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_L..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 3  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Symon Holl: "“My personal opinion is, we should increase the taxes for..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 3 || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 3  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Symon Holl: "“Unfortunately there is not much to do but to maintain th..."*)

### Węzeł `[329]`
Mówca: **Symon Holl**
> "“Unfortunately there is not much to do but to maintain their taxes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn04_EnT_SmallMedium_Question = true"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Tax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Tax == true"*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_Tax == true)"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Tax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Tax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_TaxFulfilled = true"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_Tax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Tax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Mikail Aven: "“An excellent decision.”"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_TaxFulfilled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Privatization == false"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Tax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Tax == true"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_Tax == true)"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Tax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Tax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_TaxFulfilled = true"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_Tax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Tax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Mikail Aven: "“An excellent decision.”"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_TaxFulfilled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Privatization == false"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Holsord_RumburgEmbargo = true"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Holsord_RumburgEmbargo = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_RumburgEmbargo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Holsord_UnitedContanaEmbarg..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_EnT_TaxReform = true"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Holsord_UnitedContanaEmbargo = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_UnitedContanaEmbargo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses =..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations == true"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1;"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations == true"*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations == true)"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1;"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxMaintain_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 3;"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2;"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true && 
BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses =..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true && 
BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist += 1; BaseGame.Capitalist -= 3; Base..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true && 
BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true &&..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist += 1;
BaseGame.Capitalist -= 3; BaseGame.Sollist += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 3;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "// Empty instruction to organize nodes"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Empty instruction to organize nodes`
- **Efekt skryptowy (`userScript`):** `-- Empty instruction to organize nodes;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_LT_TorrenSchoolAward = true"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn04_Rumburg_QueenThreat2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn04_Rumburg_QueenThreat2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_Issue_SSC_Money == true"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_LT_TorrenSchoolAward = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_TorrenSchoolAward"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Increased == true &&(BaseG..."*)

### Węzeł `[369]`
Mówca: **Narrator**
> "I went by the windows again and kept watching the sea in silence for some more time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_Highway", 75);"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true)"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "I went by the windows again and kept watching the sea in ..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Narrator: "I went by the windows again and kept watching the sea in ..."*)

### Węzeł `[373]`
Mówca: **Narrator**
> "I went by the windows again and kept watching the sea in silence for some more time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_Railway", 75);"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction =..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "I went by the windows again and kept watching the sea in ..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Justice_Increased == true &&(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true || BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true || BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Increased == true &&(BaseG..."*)
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Justice_Increased == true &&(Bas..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Justice_Increased == true &&(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true || BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true || BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true  and (Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true  or  Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_TaxEvasion = false; BaseGame.S..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Justice_Increased == true &&(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true || BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true || BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true  and (Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true  or  Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Increased == true && (Base..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_TaxEvasion = false;
BaseGame.Situation_Economy_TaxEfficientEconomy = false;
BaseGame.Situation_Economy_TaxAvoidance = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_TaxEvasion"] = false;
Variable["BaseGame.Situation_Economy_TaxEfficientEconomy"] = false;
Variable["BaseGame.Situation_Economy_TaxAvoidance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Justice_Increased == true && (BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true || BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true || BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Increased == true && (Base..."*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Justice_Increased == true && (Ba..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Justice_Increased == true && (BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true || BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true || BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true  and  (Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  or  Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_TaxEvasion = false; BaseGame.S..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Justice_Increased == true && (BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true || BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true || BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true  and  (Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  or  Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_TaxEvasion = false;
BaseGame.Situation_Economy_TaxEfficientEconomy = false;
BaseGame.Situation_Economy_TaxAvoidance = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_TaxEvasion"] = false;
Variable["BaseGame.Situation_Economy_TaxEfficientEconomy"] = false;
Variable["BaseGame.Situation_Economy_TaxAvoidance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_LargeBusiness_CreateJobs = true"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_LargeBusiness_CreateJobs = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_CreateJobs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_LargeBusiness_Downsize = true"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_LargeBusiness_Downsize = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_LargeBusiness_Downsize"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses =..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Stagnate = true"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == t..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_SmallBusiness_Growth = true"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_SmallBusiness_Growth = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_SmallBusiness_Growth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_SmallBusiness_Stagnate = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_SmallBusiness_Stagnate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true &&..."*)
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true ..."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist -= 2; BaseGame.Capitalist += 3; Base..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true &&..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist -= 2;
BaseGame.Capitalist += 3; BaseGame.Sollist -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 2;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 3;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "// Empty instruction to organize nodes"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true &&..."*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true ..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist -= 3; BaseGame.Capitalist += 2;"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist -= 3;
BaseGame.Capitalist += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 3;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "// Empty instruction to organize nodes"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true..."*)
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == tr..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist += 2; BaseGame.Capitalist -= 3;"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true && 
BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true  and  
Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist += 2;
BaseGame.Capitalist -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 2;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "// Empty instruction to organize nodes"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses =..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist -= 1; BaseGame.Capitalist -= 1;"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist -= 1;
BaseGame.Capitalist -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 1;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "// Empty instruction to organize nodes"*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)"*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist += 2; BaseGame.Capitalist -= 2;"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist += 2;
BaseGame.Capitalist -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 2;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "// Empty instruction to organize nodes"*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == t..."*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist += 1; BaseGame.Capitalist += 1;"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist += 1;
BaseGame.Capitalist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "// Empty instruction to organize nodes"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist -= 2; BaseGame.Capitalist += 2;"*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "// Empty instruction to organize nodes"*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist -= 2;
BaseGame.Capitalist += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 2;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "// Empty instruction to organize nodes"*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy -= 1;"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true"*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy -= 1;"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_EnT_TaxReform = true"*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy -= 1;"*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_EnT_TaxReform = true"*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true"*)
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)"*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 4;"*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 4;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 4;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 3;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses =..."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget += 2;"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)"*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget += 3;"*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 3;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true"*)
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == t..."*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 3;"*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == ..."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true"*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Privatization == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Privatization == false"*)
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_Privatization == false)"*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Privatization == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Privatization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content = true"*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_Privatization == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Privatization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Mikail Aven: "“An excellent decision.”"*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Privatization == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Privatization == false"*)
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_Privatization == false)"*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Privatization == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Privatization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content = true"*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_Privatization == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Privatization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Mikail Aven: "“An excellent decision.”"*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Mikail Aven: "“An excellent decision.”"*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Mikail Aven: "“An excellent decision.”"*)

### Węzeł `[467]`
**[WYBÓR GRACZA: "“I didn't want to hamper our businesses and their employment drive.”"]** — Mówca: **Player**
> "“I didn't want to hamper our businesses and their employment drive.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Edith Agnoc: "“You have done the right thing.”"*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_Highway", 75);`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_Highway", 75);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_Railway", 75);`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_Railway", 75);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true"*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true"*)
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == ..."*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Arvory", "City_IncreasedBus..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Agnland == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Agnland"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Arvory", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Arvory","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Laren", "City_HighLevels..."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Arvory", "City_RapidGrowth");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Arvory","City_RapidGrowth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true)"*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Arvory", "City_RapidGrowth");"*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Laren", "City_HighLevelsofPoverty");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Laren","City_HighLevelsofPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Laren", "City_DecreasingPov..."*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Laren", "City_DecreasingPoverty");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Laren","City_DecreasingPoverty");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// filler node`
- **Efekt skryptowy (`userScript`):** `-- filler node;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true"*)
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == t..."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Deyr", "City_IncreasedBusin..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Deyr", "City_DecreasingHomelessness");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Deyr","City_DecreasingHomelessness");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Sarna", "City_AgriculturalG..."*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Deyr", "City_Homelessness");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Deyr","City_Homelessness");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Deyr", "City_DecreasingHome..."*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Sarna", "City_AgriculturalGrowth");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Sarna","City_AgriculturalGrowth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Deyr", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Deyr","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Deyr", "City_Homelessnes..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true"*)
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == t..."*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Morna", "City_IncreasedBusi..."*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RegionalInvestment_Lorren == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RegionalInvestment_Lorren"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Morna", "City_IncreasedBusinessTrade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Morna","City_IncreasedBusinessTrade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Morna", "City_Decreasing..."*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Morna", "City_DecreasingUnemployment");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Morna","City_DecreasingUnemployment");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "// filler node"*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Morna", "City_DecreasingJobOpenings");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Morna","City_DecreasingJobOpenings");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Morna", "City_DecreasingUne..."*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Relaxed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true"*)
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Immigration_Relaxed == true)"*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Relaxed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Relaxed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_HP_RemusRelaxedMigration = true;"*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Immigration_Relaxed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_HP_RemusTightMigration = true;"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_HP_RemusRelaxedMigration = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_RemusRelaxedMigration"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Valgen_GruniRuralDev = true;"*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_HP_RemusTightMigration = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_RemusTightMigration"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Valgen_GruniRuralDev = true;"*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Valgen_GruniRuralDev = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Valgen_GruniRuralDev"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "End();"*)
