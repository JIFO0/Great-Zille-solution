# Rizia/Turn 7/Public Opinion

- **ID konwersacji:** `387`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/387_Public_Opinion.md`
- **Liczba węzłów dialogowych:** 548
- **Liczba wyborów gracza:** 60

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_HouseAzaro`
- `RiziaDLC.Country_HouseSazon`
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.Country_QuelledProtests`
- `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban`
- `RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike`
- `RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest`
- `RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.LeaningValue_ProBusiness`
- `RiziaDLC.MITZ_Nationalization_NoShare`
- `RiziaDLC.MITZ_Nationalization_SmallerShare`
- `RiziaDLC.MITZ_Renegotiation_Failed`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Law_Media_State`
- `RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization`
- `RiziaDLC.Policy_RD_Economy_BusinessTaxCredits`
- `RiziaDLC.Policy_RD_Economy_EnactInheritanceTax`
- `RiziaDLC.Policy_RD_Economy_LandOwnersTax`
- `RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed`
- `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax`
- `RiziaDLC.Policy_RD_Order_ExpandBorderGuards`
- `RiziaDLC.Policy_RD_Welfare_FreePress`
- `RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds`
- `RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws`
- `RiziaDLC.Protests_AntiAureus_Happened`
- `RiziaDLC.Protests_LivingStandards_Happened`
- `RiziaDLC.Protests_MalenyevistStrike_Happened`
- `RiziaDLC.Protests_MediaCensorship_Happened`
- `RiziaDLC.Protests_PoliceBrutality_Happened`
- `RiziaDLC.Protests_Welfare_Happened`
- `RiziaDLC.Reform_Movement_Radicalism`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Economy_EnergyCrisis`
- `RiziaDLC.Situation_Economy_NewBusiness_Reduction`
- `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair`
- `RiziaDLC.Situation_Welfare_Housing_LackOfAffordable`
- `RiziaDLC.Situation_Welfare_Housing_WorseningCrisis`
- `RiziaDLC.Situation_Welfare_LivingStandards_Bad`
- `RiziaDLC.Situation_Welfare_LivingStandards_Horrible`
- `RiziaDLC.Situation_Welfare_WorkersRights_Bad`
- `RiziaDLC.Situation_Welfare_WorkersRights_Horrible`
- `RiziaDLC.Trait_TyrantKing`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[384] Rizia/Turn 7/A_HouseOfDelegatesII** (../Turn_07/384_A_HouseOfDelegatesII.md), Węzeł `[145]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[19]` | **""That is correct. What we are seeing is nothing but retaliation from Morella after..."** | `[18]` **Daria de Rava**: ""Furthermore, at least some of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Manus Sazon**: ""Even if that were true, the Mor..." |
| `[20]` | **""Both of you are getting worked up over nothing. The 'red menace' is not going to ..."** | `[18]` **Daria de Rava**: ""Furthermore, at least some of t..."<br>`[17]` **Daria de Rava**: ""Objection. You are suggesting o..." | `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false` | *Brak zmian stanu* | `[28]` **Daria de Rava**: ""That's simply not true, Your Ma..." |
| `[21]` | **""There is no appeasing Malenyevists. This movement must be crushed, or it's all of..."** | `[18]` **Daria de Rava**: ""Furthermore, at least some of t..."<br>`[17]` **Daria de Rava**: ""Objection. You are suggesting o..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0`<br>`(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false` | *Brak zmian stanu* | `[29]` **Manus Sazon**: ""Your Majesty, my party's electi..." |
| `[25]` | **""Protests or no protests, reducing inequality in Rizian society is a worthy goal.""** | `[18]` **Daria de Rava**: ""Furthermore, at least some of t..."<br>`[17]` **Daria de Rava**: ""Objection. You are suggesting o..." | `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false`<br>`(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false` | *Brak zmian stanu* | `[30]` **Daria de Rava**: ""Inequality exists, yes. But we ..." |
| `[26]` | **""Malenyevism started as a fringe movement in United Contana, too. And look what ha..."** | `[18]` **Daria de Rava**: ""Furthermore, at least some of t..."<br>`[17]` **Daria de Rava**: ""Objection. You are suggesting o..." | `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false` | *Brak zmian stanu* | `[31]` **Daria de Rava**: ""We have Rumburg and GRACE on ou..." |
| `[49]` | **""Both of you are getting worked up over nothing. The 'red menace' is not going to ..."** | `[47]` **Daria de Rava**: ""Do not be naive, Mr. Sazon. Thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Daria de Rava**: ""That's simply not true, Your Ma..." |
| `[50]` | **""There is no appeasing Malenyevists. This movement must be crushed, or it's all of..."** | `[47]` **Daria de Rava**: ""Do not be naive, Mr. Sazon. Thi..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0` | *Brak zmian stanu* | `[55]` **Daria de Rava**: ""Yes, Mr. Sazon, we should not c..." |
| `[51]` | **""Protests or no protests, reducing inequality in Rizian society is a worthy goal.""** | `[47]` **Daria de Rava**: ""Do not be naive, Mr. Sazon. Thi..." | `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false` | *Brak zmian stanu* | `[56]` **Daria de Rava**: ""Inequality exists, yes. But not..." |
| `[52]` | **""Malenyevism started as a fringe movement in United Contana, too. And look what ha..."** | `[47]` **Daria de Rava**: ""Do not be naive, Mr. Sazon. Thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Daria de Rava**: ""We have Rumburg and GRACE on ou..." |
| `[61]` | **""Correct. What we are seeing is nothing but retaliation from Morella after we refu..."** | `[47]` **Daria de Rava**: ""Do not be naive, Mr. Sazon. Thi..." | `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true` | *Brak zmian stanu* | `[53]` **Manus Sazon**: ""Even if that were true, the Mor..." |
| `[98]` | **""We can't focus on them while overlooking the plight of the commoners who actually..."** | `[126]` **Daria de Rava**: ""If anything, we should be doing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Manus Sazon**: ""Agreed. My party's election gai..." |
| `[99]` | **""More often than not, the gentry class has been the source of those crises. It doe..."** | `[126]` **Daria de Rava**: ""If anything, we should be doing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Manus Sazon**: ""Exactly. My party's election ga..." |
| `[100]` | **""The commoners have nothing to complain about. They live in a rich country.""** | `[126]` **Daria de Rava**: ""If anything, we should be doing..." | `Variable["RiziaDLC.Resources_Budget"] > 4` | *Brak zmian stanu* | `[105]` **Manus Sazon**: ""And yet so little of that wealt..."<br>`[130]` **Manus Sazon**: ""But it took centuries before th..." |
| `[101]` | **""We've got to throw the commoners a bone. I don't want to have to contend with ano..."** | `[126]` **Daria de Rava**: ""If anything, we should be doing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Daria de Rava**: ""If we begin giving into their d..." |
| `[131]` | **""I agree. We need to boost our economy before we can even talk about helping commo..."** | `[126]` **Daria de Rava**: ""If anything, we should be doing..." | `(Variable["RiziaDLC.Resources_Budget"] > 4) == false` | *Brak zmian stanu* | `[132]` **Manus Sazon**: ""If the populace is suffering, o..." |
| `[144]` | **""We can't focus on them while overlooking the plight of the commoners who actually..."** | `[162]` **Daria de Rava**: ""If anything, we should be doing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Daria de Rava**: ""I'm sorry, Your Majesty, but th..." |
| `[145]` | **""More often than not, the gentry class has been the source of those crises. It doe..."** | `[162]` **Daria de Rava**: ""If anything, we should be doing..."<br>`[195]` **Narrator**: "Next to me, Hugo shook his head ..."<br>*(oraz 20 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Manus Sazon**: ""Exactly. I have spoken to const..." |
| `[146]` | **""The commoners have nothing to complain about. They live in a rich country.""** | `[162]` **Daria de Rava**: ""If anything, we should be doing..." | `Variable["RiziaDLC.Resources_Budget"] > 4` | *Brak zmian stanu* | `[152]` **Manus Sazon**: ""And yet so little of that wealt..."<br>`[166]` **Manus Sazon**: ""But it took centuries before th..." |
| `[147]` | **""We've got to throw the commoners a bone. I don't want to have to contend with ano..."** | `[162]` **Daria de Rava**: ""If anything, we should be doing..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Daria de Rava**: ""If we begin giving into their d..." |
| `[167]` | **""I agree. We need to boost our economy before we can even talk about helping commo..."** | `[162]` **Daria de Rava**: ""If anything, we should be doing..." | `(Variable["RiziaDLC.Resources_Budget"] > 4) == false` | *Brak zmian stanu* | `[168]` **Manus Sazon**: ""If the populace is suffering, o..." |
| `[189]` | **""Thank you, Mr. Sazon. But I doubt any of them will help.""** | `[188]` **Manus Sazon**: ""My party -- which I will remind..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Narrator**: "Next to me, Hugo shook his head ..." |
| `[190]` | **""Very good. I will see what I can do.""** | `[188]` **Manus Sazon**: ""My party -- which I will remind..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Manus Sazon**: ""That is all we ask."" |
| `[194]` | **""I'll think about it. But I have a hunch this can only be solved with Morella's co..."** | `[188]` **Manus Sazon**: ""My party -- which I will remind..." | `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true` | *Brak zmian stanu* | `[197]` **Manus Sazon**: ""Whether or not Morella admits t..." |
| `[206]` | **""Thank you, Madame Speaker. But I doubt any of that will help.""** | `[205]` **Daria de Rava**: ""My party -- which I will remind..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Daria de Rava**: ""Unrest or not, it is worth tryi..." |
| `[207]` | **""Very good. I'll have another look over them.""** | `[205]` **Daria de Rava**: ""My party -- which I will remind..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Daria de Rava**: ""That is all we ask."" |
| `[211]` | **""I'll think about it. But I have a hunch this can only be solved with Morella's co..."** | `[205]` **Daria de Rava**: ""My party -- which I will remind..." | `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true` | *Brak zmian stanu* | `[214]` **Daria de Rava**: ""Whether or not Morella admits t..." |
| `[218]` | **""Please refrain from personal jabs at the opposition leader. Mr. Sazon's relations..."** | `[205]` **Daria de Rava**: ""My party -- which I will remind..." | `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true` | *Brak zmian stanu* | `[219]` **Daria de Rava**: ""You're right, Your Majesty. I a..." |
| `[354]` | **""Madame Speaker said that public opinion of me was high. That includes commoners.""** | `[353]` **Manus Sazon**: ""Excuse me. All of this talk abo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Manus Sazon**: ""Some commoners, perhaps. But no..."<br>`[368]` **Manus Sazon**: ""That may happen to be true. But..." |
| `[355]` | **""A very good point. Tell me, what do the commoners think of me?""** | `[353]` **Manus Sazon**: ""Excuse me. All of this talk abo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[378]` **Manus Sazon**: ""As it happens, Your Majesty...""<br>`[437]` **Manus Sazon**: ""As a matter of fact, they are f..." |
| `[356]` | **""All of my subjects love me. End of conversation.""** | `[353]` **Manus Sazon**: ""Excuse me. All of this talk abo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[376]` **Manus Sazon**: ""As a matter of fact, Your Majes..."<br>`[402]` **Manus Sazon**: ""You're not wrong, Your Majesty,..." |
| `[357]` | **""I trust my House Speaker to know what's going on in this kingdom.""** | `[352]` **Manus Sazon**: ""Objection. How can we gauge app..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[401]` **Daria de Rava**: ""Thank you, Your Majesty."" |
| `[358]` | **""And I suppose you have a better sense of what the public thinks of me?""** | `[352]` **Manus Sazon**: ""Objection. How can we gauge app..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[379]` **Manus Sazon**: ""As a matter of fact, I do.""<br>`[400]` **Manus Sazon**: ""As a matter of fact, commoners ..." |
| `[359]` | **""My subjects love me. End of conversation.""** | `[352]` **Manus Sazon**: ""Objection. How can we gauge app..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[376]` **Manus Sazon**: ""As a matter of fact, Your Majes..."<br>`[402]` **Manus Sazon**: ""You're not wrong, Your Majesty,..." |
| `[366]` | **""You will refrain from speaking out of turn, Mr. Sazon.""** | `[353]` **Manus Sazon**: ""Excuse me. All of this talk abo..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[403]` **Manus Sazon**: ""Of course. Forgive me."" |
| `[415]` | **""And I suppose you know how to fix everything?""** | `[399]` **Manus Sazon**: ""Not quite as rosy a picture as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[435]` **Manus Sazon**: ""Not everything, but..."" |
| `[416]` | **""That doesn't sound bad at all. Certainly not bad enough to make me lose sleep.""** | `[399]` **Manus Sazon**: ""Not quite as rosy a picture as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[434]` **Manus Sazon**: ""But--"" |
| `[418]` | **""I've already enacted plenty of RNC proposals. Don't get too greedy.""** | `[417]` **Daria de Rava**: ""My party -- which I will remind..." | `(Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true)  or  (Variable["RiziaDLC.Policy_RD_Order_ExpandBorderGuards"] == true  and  (Variable["RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_BusinessTaxCredits"] == true))` | *Brak zmian stanu* | `[421]` **Daria de Rava**: ""We are grateful your Majesty. W..." |
| `[419]` | **""Very good. I'll have another look over them.""** | `[417]` **Daria de Rava**: ""My party -- which I will remind..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Daria de Rava**: ""That is all we ask."" |
| `[420]` | **""I don't know about that. Perhaps I should be paying more attention to the plight ..."** | `[417]` **Daria de Rava**: ""My party -- which I will remind..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[423]` **Daria de Rava**: ""A rising tide lifts all boats, ..." |
| `[428]` | **""Please refrain from personal jabs at the opposition leader. Mr. Sazon's relations..."** | `[417]` **Daria de Rava**: ""My party -- which I will remind..." | `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true` | *Brak zmian stanu* | `[424]` **Daria de Rava**: ""You're right, Your Majesty. I a..." |
| `[429]` | **""If that's true, then I have work to do.""** | `[399]` **Manus Sazon**: ""Not quite as rosy a picture as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[436]` **Manus Sazon**: ""I am glad you see it that way."" |
| `[430]` | **""Stop spewing lies. The commoners in Rizia are happier than ever.""** | `[399]` **Manus Sazon**: ""Not quite as rosy a picture as ..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[434]` **Manus Sazon**: ""But--"" |
| `[439]` | **""Thank you, Mr. Sazon. But I doubt any of them will help.""** | `[438]` **Manus Sazon**: ""My party has suggested a number..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[442]` **Narrator**: "Next to me, Hugo shook his head ..." |
| `[440]` | **""Very good. I'll have another look over them.""** | `[438]` **Manus Sazon**: ""My party has suggested a number..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[443]` **Manus Sazon**: ""That is all we ask."" |
| `[441]` | **""I will not promise the opposition anything. But I will think about it.""** | `[438]` **Manus Sazon**: ""My party has suggested a number..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[443]` **Manus Sazon**: ""That is all we ask."" |
| `[445]` | **""The Speaker said that public opinion of me was high. That includes the wealthy.""** | `[444]` **Daria de Rava**: ""Objection. You speak of the imp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[453]` **Daria de Rava**: ""Not necessarily.""<br>`[465]` **Daria de Rava**: ""As it happens, Your Majesty, yo..." |
| `[446]` | **""A very good point. Tell me, Ms. de Rava, what do the rich and famous think of me?""** | `[444]` **Daria de Rava**: ""Objection. You speak of the imp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Daria de Rava**: ""As it happens...""<br>`[463]` **Daria de Rava**: ""As it happens, they're quite sa..." |
| `[447]` | **""All of my subjects love me. End of conversation.""** | `[444]` **Daria de Rava**: ""Objection. You speak of the imp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[448]` **Narrator**: "Manus spoke animatedly." |
| `[467]` | **""I've already enacted plenty of RPP proposals. Don't get too greedy.""** | `[466]` **Manus Sazon**: ""Now. My party -- which I will r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Manus Sazon**: ""No, Your Majesty. We won't."" |
| `[468]` | **""Very good. I'll have another look over them.""** | `[466]` **Manus Sazon**: ""Now. My party -- which I will r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[471]` **Manus Sazon**: ""That is all we ask."" |
| `[469]` | **""I don't know about that. Perhaps I should be paying more attention to the plight ..."** | `[466]` **Manus Sazon**: ""Now. My party -- which I will r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[472]` **Manus Sazon**: ""Respectfully, Your Majesty, my ..." |
| `[505]` | **""And I suppose you know how to fix everything?""** | `[504]` **Daria de Rava**: ""Not quite as rosy a picture as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[510]` **Daria de Rava**: ""No, not everything, but..."" |
| `[506]` | **""That doesn't sound bad at all. Certainly not bad enough to make me lose sleep.""** | `[504]` **Daria de Rava**: ""Not quite as rosy a picture as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[511]` **Daria de Rava**: ""It's a mistake not to take this..." |
| `[507]` | **""If that's true, then I have work to do.""** | `[504]` **Daria de Rava**: ""Not quite as rosy a picture as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[509]` **Daria de Rava**: ""I'm happy you see it that way."" |
| `[508]` | **""Let the bourgeoisie suffer a little bit. They've had their time on top.""** | `[504]` **Daria de Rava**: ""Not quite as rosy a picture as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[511]` **Daria de Rava**: ""It's a mistake not to take this..." |
| `[514]` | **""I've already enacted plenty of RNC proposals. Don't get too greedy.""** | `[513]` **Daria de Rava**: ""My party has suggested a number..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[517]` **Daria de Rava**: ""No, Your Majesty. We won't."" |
| `[515]` | **""Very good. I'll have another look over them.""** | `[513]` **Daria de Rava**: ""My party has suggested a number..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[518]` **Daria de Rava**: ""That is all we ask."" |
| `[516]` | **""I don't know about that. Perhaps I should be paying more attention to the plight ..."** | `[513]` **Daria de Rava**: ""My party has suggested a number..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[519]` **Daria de Rava**: ""A rising tide lifts all boats, ..." |
| `[523]` | **""I've already enacted a RNC proposal. We can do more, but in the future.""** | `[417]` **Daria de Rava**: ""My party -- which I will remind..." | `Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true  or  Variable["RiziaDLC.Policy_RD_Order_ExpandBorderGuards"] == true  or    Variable["RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_BusinessTaxCredits"] == true`<br>`((Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true)  or  (Variable["RiziaDLC.Policy_RD_Order_ExpandBorderGuards"] == true  and  (Variable["RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_BusinessTaxCredits"] == true))) == false` | *Brak zmian stanu* | `[527]` **Daria de Rava**: ""The RNC is here to aid the crow..." |
| `[543]` | **""I will have a look. But I am wary of granting the public too many favors.""** | `[188]` **Manus Sazon**: ""My party -- which I will remind..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[544]` **Manus Sazon**: ""Be kind to them, and they will ..." |

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
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Radicalism >= 5"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player_Romus: ""More often than not, the gentry class has been the sourc..."*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Manus Sazon: ""Finally... it is imperative that we discuss the growing ..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Daria de Rava: ""Finally... it is imperative that we discuss the growing ..."*)

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""Finally... it is imperative that we discuss the growing radicalism among the populace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == t..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Manus Sazon: ""Despite the King's efforts to ban propaganda from Valgsl..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Manus Sazon: ""Talk of a 'worker's movement' has begun to percolate, un..."*)

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""Despite the King's efforts to ban propaganda from Valgsland and United Contana, it appears talk of a 'worker's movement' has begun to percolate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[11]`
Mówca: **Manus Sazon**
> ""Talk of a 'worker's movement' has begun to percolate, undoubtedly aided by propaganda from Valgsland and United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[12]`
Mówca: **Manus Sazon**
> ""The recent Malenyevist union strike was only the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || Rizia..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Protests_MalenyevistStrike_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Protests_MalenyevistStrike_Happened == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Protests_MalenyevistStrike_Happened == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Protests_MalenyevistStrike_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Protests_MalenyevistStrike_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Manus Sazon: ""The recent Malenyevist union strike was only the beginni..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Protests_MalenyevistStrike_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Protests_MalenyevistStrike_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Protests_Welfare_Happened == true || RiziaDLC.Pr..."*)

### Węzeł `[16]`
Mówca: **Manus Sazon**
> ""Despite few overt protests, I assure you citizens' dissatisfaction is growing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || Rizia..."*)

### Węzeł `[17]`
Mówca: **Daria de Rava**
> ""Objection. You are suggesting our government appease an extremist fringe movement that does not represent the majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true"*)

### Węzeł `[18]`
Mówca: **Daria de Rava**
> ""Furthermore, at least some of the Malenyevist activity might be the work of foreign provocateurs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""That is correct. What we are seeing is nothing but retal..."*)
  - -> `[20]` (*Player_Romus: ""Both of you are getting worked up over nothing. The 'red..."*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist < 0"*)
  - -> `[26]` (*Player_Romus: ""Malenyevism started as a fringe movement in United Conta..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That is correct. What we are seeing is nothing but retaliation from Morella after we refused to support their PM's half-baked nationalization plans.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Manus Sazon: ""Even if that were true, the Morellan agents could not pr..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Both of you are getting worked up over nothing. The 'red menace' is not going to touch us here in Rizia.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[18]` (Daria de Rava), `[17]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Daria de Rava: ""That's simply not true, Your Majesty. The East and its a..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no appeasing Malenyevists. This movement must be crushed, or it's all of our heads on the line.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0` AND `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[18]` (Daria de Rava), `[17]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Manus Sazon: ""Your Majesty, my party's election gains should be proof ..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist < 0"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist < 0)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""There is no appeasing Malenyevists. This movement must b..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""Protests or no protests, reducing inequality in Rizian s..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Protests or no protests, reducing inequality in Rizian society is a worthy goal.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false` AND `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[18]` (Daria de Rava), `[17]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Daria de Rava: ""Inequality exists, yes. But we can address it without gi..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Malenyevism started as a fringe movement in United Contana, too. And look what happened.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[18]` (Daria de Rava), `[17]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Daria de Rava: ""We have Rumburg and GRACE on our side. As long as we hew..."*)

### Węzeł `[27]`
Mówca: **Manus Sazon**
> ""Even if that were true, the Morellan agents could not produce a movement from thin air. These sentiments are already deeply felt within Rizian society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Daria de Rava: ""If anything, we should be doing more to empower the land..."*)

### Węzeł `[28]`
Mówca: **Daria de Rava**
> ""That's simply not true, Your Majesty. The East and its allies have their sights trained on all monarchies, including us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Daria de Rava: ""If anything, we should be doing more to empower the land..."*)

### Węzeł `[29]`
Mówca: **Manus Sazon**
> ""Your Majesty, my party's election gains should be proof that oppression is not the answer. If we want Rizia's monarchy to survive, it must evolve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Daria de Rava: ""If anything, we should be doing more to empower the land..."*)

### Węzeł `[30]`
Mówca: **Daria de Rava**
> ""Inequality exists, yes. But we can address it without giving in to the demands of a radical minority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Daria de Rava: ""If anything, we should be doing more to empower the land..."*)

### Węzeł `[31]`
Mówca: **Daria de Rava**
> ""We have Rumburg and GRACE on our side. As long as we hew close to our monarchist allies, we will not meet the same fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Daria de Rava: ""If anything, we should be doing more to empower the land..."*)

### Węzeł `[32]`
Mówca: **Daria de Rava**
> ""As long as we retain their favor, we will not have to worry about the threat of an uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Manus Sazon: ""Please, Ms. de Rava...""*)

### Węzeł `[33]`
Mówca: **Daria de Rava**
> ""Finally... it is imperative that we discuss the growing Malenyevist movement within Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == t..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Daria de Rava: ""Despite the King's efforts to ban propaganda from Valgsl..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Daria de Rava: ""We are seeing an uptick in pamphlets and other propagand..."*)

### Węzeł `[37]`
Mówca: **Daria de Rava**
> ""Despite the King's efforts to ban propaganda from Valgsland and United Contana, it is still reaching our shores.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[38]`
Mówca: **Daria de Rava**
> ""We are seeing an uptick in pamphlets and other propaganda from Valgsland and United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[39]`
Mówca: **Daria de Rava**
> ""I fear the recent Malenyevist strike was only the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Manus Sazon: ""Madame Speaker, I must point out that this movement is p..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true || RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike =..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true || RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike"] == true  or  Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Daria de Rava: ""I fear the recent Malenyevist strike was only the beginn..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true || RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike"] == true  or  Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise == true"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise == ..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Daria de Rava: ""I fear giving in to the recent workers' strike has only ..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_Promise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Manus Sazon: ""Madame Speaker, I must point out that this movement is p..."*)

### Węzeł `[46]`
Mówca: **Daria de Rava**
> ""I fear giving in to the recent workers' strike has only made this faction more determined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Manus Sazon: ""Madame Speaker, I must point out that this movement is p..."*)

### Węzeł `[47]`
Mówca: **Daria de Rava**
> ""Do not be naive, Mr. Sazon. This is obviously the work of foreign agents seeking to destabilize us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true"*)
  - -> `[49]` (*Player_Romus: ""Both of you are getting worked up over nothing. The 'red..."*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist < 0"*)
  - -> `[52]` (*Player_Romus: ""Malenyevism started as a fringe movement in United Conta..."*)

### Węzeł `[48]`
Mówca: **Manus Sazon**
> ""Madame Speaker, I must point out that this movement is protesting the existing inequalities within Rizian society. Work to address those, and Malenyevist revolution will no longer be a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Daria de Rava: ""Do not be naive, Mr. Sazon. This is obviously the work o..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Both of you are getting worked up over nothing. The 'red menace' is not going to touch us here in Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Daria de Rava: ""That's simply not true, Your Majesty. The East and its a..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no appeasing Malenyevists. This movement must be crushed, or it's all of our heads on the line.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0`
- **Kontekst wejściowy (poprzednik):** `[47]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Daria de Rava: ""Yes, Mr. Sazon, we should not compromise the values of t..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Protests or no protests, reducing inequality in Rizian society is a worthy goal.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false`
- **Kontekst wejściowy (poprzednik):** `[47]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Daria de Rava: ""Inequality exists, yes. But not to the extent that this ..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Malenyevism started as a fringe movement in United Contana, too. And look what happened.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Daria de Rava: ""We have Rumburg and GRACE on our side. As long as we hew..."*)

### Węzeł `[53]`
Mówca: **Manus Sazon**
> ""Even if that were true, the Morellans could not produce a movement from thin air. They are playing on sentiments that are deeply felt in our populace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Daria de Rava: ""We can beat back the Malenyevist threat by doing more to..."*)

### Węzeł `[54]`
Mówca: **Daria de Rava**
> ""That's simply not true, Your Majesty. The East and its allies have their sights trained on all monarchies, including us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Daria de Rava: ""We can beat back the Malenyevist threat by doing more to..."*)

### Węzeł `[55]`
Mówca: **Daria de Rava**
> ""Yes, Mr. Sazon, we should not compromise the values of this monarchy simply to meet the demands of a radical fringe group.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Daria de Rava: ""We can beat back the Malenyevist threat by doing more to..."*)

### Węzeł `[56]`
Mówca: **Daria de Rava**
> ""Inequality exists, yes. But not to the extent that this radical fringe group would have us believe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Daria de Rava: ""We can beat back the Malenyevist threat by doing more to..."*)

### Węzeł `[57]`
Mówca: **Daria de Rava**
> ""We have Rumburg and GRACE on our side. As long as we hew close to our monarchist allies, we will not meet the same fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Daria de Rava: ""We can beat back the Malenyevist threat by doing more to..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist < 0"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist < 0)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: ""There is no appeasing Malenyevists. This movement must b..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player_Romus: ""Protests or no protests, reducing inequality in Rizian s..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Correct. What we are seeing is nothing but retaliation from Morella after we refused to support their PM's half-baked nationalization plans.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Kontekst wejściowy (poprzednik):** `[47]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Manus Sazon: ""Even if that were true, the Morellans could not produce ..."*)

### Węzeł `[62]`
Mówca: **Manus Sazon**
> ""Go out on the streets of our cities, and you will hear citizens openly mentioning revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_QuelledProtests > 2"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Manus Sazon: ""Go out on the streets of our cities, and you will hear c..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Manus Sazon: ""My constituents have informed me of covert gatherings wh..."*)

### Węzeł `[66]`
Mówca: **Manus Sazon**
> ""My constituents have informed me of covert gatherings where revolution is discussed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_QuelledProtests > 2"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || Rizia..."*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || Riz..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Manus Sazon: ""I applaud His Majesty's efforts to address the inequalit..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Manus Sazon: ""And I believe the protesters have a point. We should be ..."*)

### Węzeł `[70]`
Mówca: **Manus Sazon**
> ""And I believe the protesters have a point. We should be passing more measures to address the inequality in Rizian society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Daria de Rava: ""Objection. You are suggesting our government appease an ..."*)

### Węzeł `[71]`
Mówca: **Manus Sazon**
> ""I applaud His Majesty's efforts to address the inequality in Rizian society. But obviously, we still have some way to go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Daria de Rava: ""Objection. You are suggesting our government appease an ..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || Rizia..."*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || Riz..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Daria de Rava: ""They have already begun to lose faith in the Crown in th..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Daria de Rava: ""As long as we retain their favor, we will not have to wo..."*)

### Węzeł `[75]`
Mówca: **Daria de Rava**
> ""Go out on the streets of our cities, and you will hear citizens openly mentioning revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike =..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Daria de Rava: ""Go out on the streets of our cities, and you will hear c..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Daria de Rava: ""We have received reports of covert gatherings where revo..."*)

### Węzeł `[79]`
Mówca: **Daria de Rava**
> ""We have received reports of covert gatherings where revolution is discussed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike =..."*)

### Węzeł `[80]`
Mówca: **Daria de Rava**
> ""We can beat back the Malenyevist threat by doing more to support the beating heart of this country. Its employers and landowners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || Rizia..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Radicalism >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Radicalism >= 5"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Radicalism >= 5)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Radicalism >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Radicalism >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Radicalism"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion < 0"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Manus Sazon: ""Finally... it is imperative that we discuss the growing ..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Daria de Rava: ""Finally... I have to bring up the rising sentiments of d..."*)

### Węzeł `[87]`
Mówca: **Manus Sazon**
> ""Finally... it is imperative that we discuss the growing dissatisfaction within our populace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[88]`
Mówca: **Manus Sazon**
> ""Unless workers' rights improve, I fear strikes like the one we had recently will become more common.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Rizia..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike =..."*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Manus Sazon: ""Unless workers' rights improve, I fear strikes like the ..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProte..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProte..."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn06_MalenyevistWorkers_DispersePro..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Manus Sazon: ""Suppressing the recent Malenyevist strike has only made ..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Manus Sazon: ""Despite our promise of better conditions, we are still f..."*)

### Węzeł `[95]`
Mówca: **Manus Sazon**
> ""Suppressing the recent Malenyevist strike has only made this faction more determined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Rizia..."*)

### Węzeł `[96]`
Mówca: **Manus Sazon**
> ""Despite our promise of better conditions, we are still facing dissent from workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Rizia..."*)

### Węzeł `[97]`
Mówca: **Daria de Rava**
> ""Objection. Our efforts as a kingdom should be focused on winning the war in Pales, not on costly policies that will satisfy no one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Daria de Rava: ""If anything, we should be doing more to protect the land..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can't focus on them while overlooking the plight of the commoners who actually generate their wealth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Manus Sazon: ""Agreed. My party's election gains are proof that Rizia w..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More often than not, the gentry class has been the source of those crises. It doesn't need the government's help.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Manus Sazon: ""Exactly. My party's election gains are proof that the pe..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The commoners have nothing to complain about. They live in a rich country.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] > 4`
- **Kontekst wejściowy (poprzednik):** `[126]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Rizia..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got to throw the commoners a bone. I don't want to have to contend with another uprising.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Daria de Rava: ""If we begin giving into their demands now, where will it..."*)

### Węzeł `[102]`
Mówca: **Manus Sazon**
> ""Agreed. My party's election gains are proof that Rizia wants the era of nobility privilege to come to an end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Manus Sazon: ""My party -- which I will remind you is the majority -- h..."*)

### Węzeł `[103]`
Mówca: **Manus Sazon**
> ""Exactly. My party's election gains are proof that the people of this country no longer trust the nobility to solve their problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Manus Sazon: ""My party -- which I will remind you is the majority -- h..."*)

### Węzeł `[104]`
Mówca: **Daria de Rava**
> ""If we begin giving into their demands now, where will it end? You must be careful not to overindulge them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Manus Sazon: ""My party -- which I will remind you is the majority -- h..."*)

### Węzeł `[105]`
Mówca: **Manus Sazon**
> ""And yet so little of that wealth reaches them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Manus Sazon: ""My party -- which I will remind you is the majority -- h..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Rizia..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Riz..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Manus Sazon: ""I applaud His Majesty's efforts to address the inequalit..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Manus Sazon: ""The fact is, Rizian society is still rife with inequalit..."*)

### Węzeł `[109]`
Mówca: **Manus Sazon**
> ""The fact is, Rizian society is still rife with inequality. If we do not do more to address it, the demand for change will only grow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Rizia..."*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Riz..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Manus Sazon: ""And yet so little of that wealth reaches them.""*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Manus Sazon: ""But it took centuries before they began seeing the benef..."*)

### Węzeł `[113]`
Mówca: **Manus Sazon**
> ""I applaud His Majesty's efforts to address the inequality in Rizian society. But we still have some way to go before commoners feel empowered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Manus Sazon: ""The continuing energy crisis has sparked complaints from..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[117]`
Mówca: **Manus Sazon**
> ""The continuing energy crisis has sparked complaints from citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == ..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Manus Sazon: ""Rizia's unfair treatment of foreigners is still a sticki..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike =..."*)

### Węzeł `[121]`
Mówca: **Manus Sazon**
> ""Rizia's unfair treatment of foreigners is still a sticking point for many.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike =..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Daria de Rava: ""Objection. Our efforts as a kingdom should be focused on..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Daria de Rava: ""Objection. We cannot let the policy of this kingdom be d..."*)

### Węzeł `[125]`
Mówca: **Daria de Rava**
> ""Objection. We cannot let the policy of this kingdom be dictated by a few dissenting voices, no matter how loud they make themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Daria de Rava: ""If anything, we should be doing more to protect the land..."*)

### Węzeł `[126]`
Mówca: **Daria de Rava**
> ""If anything, we should be doing more to protect the landowners and employers who keep this country afloat even in times of crisis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""We can't focus on them while overlooking the plight of t..."*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 4"*)
  - -> `[99]` (*Player_Romus: ""More often than not, the gentry class has been the sourc..."*)
  - -> `[101]` (*Player_Romus: ""We've got to throw the commoners a bone. I don't want to..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 4"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 4)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player_Romus: ""The commoners have nothing to complain about. They live ..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player_Romus: ""I agree. We need to boost our economy before we can even..."*)

### Węzeł `[130]`
Mówca: **Manus Sazon**
> ""But it took centuries before they began seeing the benefits of that wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Manus Sazon: ""My party -- which I will remind you is the majority -- h..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. We need to boost our economy before we can even talk about helping commoners.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] > 4) == false`
- **Kontekst wejściowy (poprzednik):** `[126]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Manus Sazon: ""If the populace is suffering, our economy will as well.""*)

### Węzeł `[132]`
Mówca: **Manus Sazon**
> ""If the populace is suffering, our economy will as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Manus Sazon: ""My party -- which I will remind you is the majority -- h..."*)

### Węzeł `[133]`
Mówca: **Daria de Rava**
> ""Finally... I have to bring up the rising sentiments of discontent among our lower orders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis"*)

### Węzeł `[134]`
Mówca: **Daria de Rava**
> ""I fear the recent Malenyevist strike was a bellwether of what's to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Rizia..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike =..."*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Daria de Rava: ""I fear the recent Malenyevist strike was a bellwether of..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProte..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProte..."*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn06_MalenyevistWorkers_DispersePro..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Daria de Rava: ""We suppressed the recent Malenyevist strike, but I fear ..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn06_MalenyevistWorkers_DisperseProtest"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Daria de Rava: ""Giving in to workers' demands for unsustainably luxuriou..."*)

### Węzeł `[141]`
Mówca: **Daria de Rava**
> ""We suppressed the recent Malenyevist strike, but I fear more will follow in its wake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Rizia..."*)

### Węzeł `[142]`
Mówca: **Daria de Rava**
> ""Giving in to workers' demands for unsustainably luxurious conditions has only made them want more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Rizia..."*)

### Węzeł `[143]`
Mówca: **Daria de Rava**
> ""Mr Sazon. Our efforts as a kingdom should be focused on winning the war in Pales, not on costly policies that will satisfy no one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Daria de Rava: ""If anything, we should be doing more to protect the land..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can't focus on them while overlooking the plight of the commoners who actually generate their wealth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Daria de Rava: ""I'm sorry, Your Majesty, but there is no 'plight'. This ..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More often than not, the gentry class has been the source of those crises. It doesn't need the government's help.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Daria de Rava), `[195]` (Narrator), `[196]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Manus Sazon: ""Exactly. I have spoken to constituents who no longer tru..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The commoners have nothing to complain about. They live in a rich country.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] > 4`
- **Kontekst wejściowy (poprzednik):** `[162]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Rizia..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got to throw the commoners a bone. I don't want to have to contend with another uprising.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Daria de Rava: ""If we begin giving into their demands now, where will it..."*)

### Węzeł `[148]`
Mówca: **Daria de Rava**
> ""I'm sorry, Your Majesty, but there is no 'plight'. This could well be the work of foreign agents trying to sow instability within our population.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Manus Sazon: ""We have no evidence that's the case. And even if it was,..."*)

### Węzeł `[149]`
Mówca: **Manus Sazon**
> ""We have no evidence that's the case. And even if it was, foreign agents cannot create unrest out of thin air.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Daria de Rava: ""I don't recall asking you for your input, Mr. Sazon.""*)

### Węzeł `[150]`
Mówca: **Manus Sazon**
> ""Exactly. I have spoken to constituents who no longer trust the nobility to solve their problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Daria de Rava: ""I don't recall asking you for your input, Mr. Sazon.""*)

### Węzeł `[151]`
Mówca: **Daria de Rava**
> ""If we begin giving into their demands now, where will it end? You must be careful not to overindulge them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Manus Sazon: ""It is not 'overindulgence' to grant people rights.""*)

### Węzeł `[152]`
Mówca: **Manus Sazon**
> ""And yet so little of that wealth reaches them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Daria de Rava: ""I don't recall asking you for your input, Mr. Sazon.""*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Rizia..."*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Riz..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Manus Sazon: ""We should look at the success of the King's decrees aime..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Manus Sazon: ""The fact is, Madame Speaker, Rizian society is still rif..."*)

### Węzeł `[156]`
Mówca: **Manus Sazon**
> ""The fact is, Madame Speaker, Rizian society is still rife with inequality. If we do not do more to address it, the demand for change will only grow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Rizia..."*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && Riz..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Manus Sazon: ""And yet so little of that wealth reaches them.""*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true && RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true && RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Manus Sazon: ""But it took centuries before they began seeing the benef..."*)

### Węzeł `[160]`
Mówca: **Manus Sazon**
> ""We should look at the success of the King's decrees aimed at empowering commoners. It is clear they are hungry for more of the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[161]`
Mówca: **Daria de Rava**
> ""Mr. Sazon. We cannot let the policy of this kingdom be dictated by a few dissenting voices, no matter how loud they make themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Daria de Rava: ""If anything, we should be doing more to protect the land..."*)

### Węzeł `[162]`
Mówca: **Daria de Rava**
> ""If anything, we should be doing more to protect the landowners and employers who keep this country afloat even in times of crisis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player_Romus: ""We can't focus on them while overlooking the plight of t..."*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 4"*)
  - -> `[145]` (*Player_Romus: ""More often than not, the gentry class has been the sourc..."*)
  - -> `[147]` (*Player_Romus: ""We've got to throw the commoners a bone. I don't want to..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 4"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 4)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player_Romus: ""The commoners have nothing to complain about. They live ..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Romus: ""I agree. We need to boost our economy before we can even..."*)

### Węzeł `[166]`
Mówca: **Manus Sazon**
> ""But it took centuries before they began seeing the benefits of that wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Daria de Rava: ""I don't recall asking you for your input, Mr. Sazon.""*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. We need to boost our economy before we can even talk about helping commoners.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] > 4) == false`
- **Kontekst wejściowy (poprzednik):** `[162]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Manus Sazon: ""If the populace is suffering, our economy will as well.""*)

### Węzeł `[168]`
Mówca: **Manus Sazon**
> ""If the populace is suffering, our economy will as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Daria de Rava: ""I don't recall asking you for your input, Mr. Sazon.""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Daria de Rava: ""The continuing energy crisis has sparked many complaints.""*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == ..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Daria de Rava: ""Foreigners continue to protest what they claim is unfair..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike =..."*)

### Węzeł `[175]`
Mówca: **Daria de Rava**
> ""The continuing energy crisis has sparked many complaints.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[176]`
Mówca: **Daria de Rava**
> ""Foreigners continue to protest what they claim is unfair treatment, despite the fact that they are guests in this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn06_MalenyevistWorkers_AllowStrike =..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Daria de Rava: ""Mr Sazon. Our efforts as a kingdom should be focused on ..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Daria de Rava: ""Mr. Sazon. We cannot let the policy of this kingdom be d..."*)

### Węzeł `[180]`
Mówca: **Daria de Rava**
> ""If anything, we should be doing more to empower the landowners and employers who keep our kingdom's heart beating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || Rizia..."*)

### Węzeł `[181]`
Mówca: **Daria de Rava**
> ""They have already begun to lose faith in the Crown in the wake of certain royal decrees. It would behoove us not to offend them any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Manus Sazon: ""Please, Ms. de Rava...""*)

### Węzeł `[182]`
Mówca: **Daria de Rava**
> ""As long as we retain their favor, we will not have to worry about the threat of an uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Manus Sazon: ""Please, Madame Speaker...""*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || Rizia..."*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || Riz..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Daria de Rava: ""They have already begun to lose faith in the Crown in th..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ||RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true ||RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true  or Variable["RiziaDLC.Policy_RD_Welfare_IncreasedHealthEducationFunds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Daria de Rava: ""As long as we retain their favor, we will not have to wo..."*)

### Węzeł `[186]`
Mówca: **Daria de Rava**
> ""They have already begun to lose faith in the Crown in the wake of certain royal decrees. It would behoove us not to offend them any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Manus Sazon: ""Please, Madame Speaker...""*)

### Węzeł `[187]`
Mówca: **Manus Sazon**
> ""We cannot forget that we serve the people of Rizia. To lose their allegiance is to lose hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Daria de Rava: ""I don't recall asking you for your input, Mr. Sazon.""*)

### Węzeł `[188]`
Mówca: **Manus Sazon**
> ""My party -- which I will remind you is the majority -- has already suggested a number of proposals that might benefit ordinary citizens and the Crown alike. It is my hope that His Majesty reviews them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player_Romus: ""Thank you, Mr. Sazon. But I doubt any of them will help.""*)
  - -> `[190]` (*Player_Romus: ""Very good. I will see what I can do.""*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true"*)
  - -> `[543]` (*Player_Romus: ""I will have a look. But I am wary of granting the public..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Mr. Sazon. But I doubt any of them will help.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Next to me, Hugo shook his head adamantly."*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. I will see what I can do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Manus Sazon: ""That is all we ask.""*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Renegotiation_Failed == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player_Romus: ""I'll think about it. But I have a hunch this can only be..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Renegotiation_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll think about it. But I have a hunch this can only be solved with Morella's cooperation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Kontekst wejściowy (poprzednik):** `[188]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Manus Sazon: ""Whether or not Morella admits to interference, the under..."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "Next to me, Hugo shook his head adamantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[196]`
Mówca: **Manus Sazon**
> ""That is all we ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[197]`
Mówca: **Manus Sazon**
> ""Whether or not Morella admits to interference, the underlying problems will still be there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[198]`
Mówca: **Daria de Rava**
> ""I don't recall asking you for your input, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)

### Węzeł `[199]`
Mówca: **Manus Sazon**
> ""It is not 'overindulgence' to grant people rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Daria de Rava: ""I don't recall asking you for your input, Mr. Sazon.""*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve == true)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Daria de Rava: ""You may have the ear of a certain Princess of Rizia, but..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "She turned to look at me."*)

### Węzeł `[203]`
Mówca: **Daria de Rava**
> ""You may have the ear of a certain Princess of Rizia, but you do not control this assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "She turned to look at me."*)

### Węzeł `[204]`
Mówca: **Narrator**
> "She turned to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Daria de Rava: ""My party -- which I will remind you is the majority part..."*)

### Węzeł `[205]`
Mówca: **Daria de Rava**
> ""My party -- which I will remind you is the majority party in Rizia -- has already suggested a number of proposals to strengthen our kingdom and quell the unrest. It is our hope His Majesty will enact them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)
  - -> `[206]` (*Player_Romus: ""Thank you, Madame Speaker. But I doubt any of that will ..."*)
  - -> `[207]` (*Player_Romus: ""Very good. I'll have another look over them.""*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true"*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Madame Speaker. But I doubt any of that will help.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Daria de Rava: ""Unrest or not, it is worth trying.""*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. I'll have another look over them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Daria de Rava: ""That is all we ask.""*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Renegotiation_Failed == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player_Romus: ""I'll think about it. But I have a hunch this can only be..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Renegotiation_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll think about it. But I have a hunch this can only be solved with Morella's cooperation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Kontekst wejściowy (poprzednik):** `[205]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Daria de Rava: ""Whether or not Morella admits to interference, the under..."*)

### Węzeł `[212]`
Mówca: **Daria de Rava**
> ""Unrest or not, it is worth trying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[213]`
Mówca: **Daria de Rava**
> ""That is all we ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[214]`
Mówca: **Daria de Rava**
> ""Whether or not Morella admits to interference, the underlying problems will still be there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player_Romus: ""Please refrain from personal jabs at the opposition lead..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please refrain from personal jabs at the opposition leader. Mr. Sazon's relationship with Princess Vina has no impact on what happens in this building.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Kontekst wejściowy (poprzednik):** `[205]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Daria de Rava: ""You're right, Your Majesty. I apologize.""*)

### Węzeł `[219]`
Mówca: **Daria de Rava**
> ""You're right, Your Majesty. I apologize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Daria de Rava: ""Commoners have been hurling accusations of subpar living..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)

### Węzeł `[223]`
Mówca: **Daria de Rava**
> ""Commoners have been hurling accusations of subpar living standards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion < 0"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_PublicOpinion < 0)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_PublicOpinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Manus Sazon: ""Living standards among the lower classes remain less tha..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)

### Węzeł `[230]`
Mówca: **Manus Sazon**
> ""Living standards among the lower classes remain less than satisfactory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)

### Węzeł `[231]`
Mówca: **Manus Sazon**
> ""Please, Madame Speaker...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Manus Sazon: ""Our citizens are worried about how to heat their homes i..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[235]`
Mówca: **Manus Sazon**
> ""Our citizens are worried about how to heat their homes in winter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == ..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Manus Sazon: ""Foreigners still do not have access to basic services.""*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Manus Sazon: ""We cannot forget that we serve the people of Rizia. To l..."*)

### Węzeł `[239]`
Mówca: **Manus Sazon**
> ""Foreigners still do not have access to basic services.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Manus Sazon: ""We cannot forget that we serve the people of Rizia. To l..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Manus Sazon: ""Living standards among the lower classes are worse than ..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)

### Węzeł `[243]`
Mówca: **Manus Sazon**
> ""Living standards among the lower classes are worse than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)

### Węzeł `[244]`
Mówca: **Manus Sazon**
> ""We cannot forget that we serve the people of Rizia. To lose their allegiance is to lose hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Manus Sazon: ""My party -- which I will remind you is the majority -- h..."*)

### Węzeł `[245]`
Mówca: **Manus Sazon**
> ""Please, Ms. de Rava...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == true"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == true)"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Manus Sazon: ""Our citizens are worried about how to heat their homes i..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[249]`
Mówca: **Manus Sazon**
> ""Our citizens are worried about how to heat their homes in winter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == ..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Manus Sazon: ""Foreigners still do not have access to basic services.""*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Manus Sazon: ""We cannot forget that we serve the people of Rizia. To l..."*)

### Węzeł `[253]`
Mówca: **Manus Sazon**
> ""Foreigners still do not have access to basic services.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Manus Sazon: ""We cannot forget that we serve the people of Rizia. To l..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Manus Sazon: ""Living standards among the lower classes are worse than ..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)

### Węzeł `[257]`
Mówca: **Manus Sazon**
> ""Living standards among the lower classes are worse than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Manus Sazon: ""To end on a more positive note... The House of Delegates..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Daria de Rava: ""To end on a more positive note... I am happy to inform H..."*)

### Węzeł `[261]`
Mówca: **Manus Sazon**
> ""To end on a more positive note... The House of Delegates is pleased to report that the Rizian public has a favorable opinion of the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[262]`
Mówca: **Daria de Rava**
> ""To end on a more positive note... I am happy to inform His Majesty that the Rizian public has a favorable opinion of the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Manus Sazon: ""Even despite the war.""*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[266]`
Mówca: **Manus Sazon**
> ""Even despite the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Manus Sazon: ""Living standards among the lower classes unfortunately r..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Manus Sazon: ""Living standards for the lower classes have improved.""*)

### Węzeł `[270]`
Mówca: **Manus Sazon**
> ""Living standards for the lower classes have improved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == false"*)

### Węzeł `[271]`
Mówca: **Manus Sazon**
> ""Living standards among the lower classes unfortunately remain subpar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == false"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == false"*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == false )"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Manus Sazon: ""Our energy stores are no longer a cause for anxiety.""*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Manus Sazon: ""But our energy stores are still a cause for anxiety.""*)

### Węzeł `[275]`
Mówca: **Manus Sazon**
> ""Our energy stores are no longer a cause for anxiety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == false"*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == false )"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Manus Sazon: ""But our energy stores are thankfully no longer a cause f..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Manus Sazon: ""And our energy stores are still a cause for anxiety.""*)

### Węzeł `[279]`
Mówca: **Manus Sazon**
> ""But our energy stores are thankfully no longer a cause for anxiety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false"*)

### Węzeł `[280]`
Mówca: **Manus Sazon**
> ""And our energy stores are still a cause for anxiety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false"*)

### Węzeł `[281]`
Mówca: **Manus Sazon**
> ""But our energy stores are still a cause for anxiety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == ..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Manus Sazon: ""And Rizians of foreign descent are finally beginning to ..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Manus Sazon: ""Sadly, Rizians of foreign descent still lack the same ri..."*)

### Węzeł `[285]`
Mówca: **Manus Sazon**
> ""And Rizians of foreign descent are finally beginning to gain the same rights and privileges as everyone else in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == false"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == ..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Manus Sazon: ""Happily, Rizians of foreign descent are finally beginnin..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Manus Sazon: ""Sadly, Rizians of foreign descent still lack the same ri..."*)

### Węzeł `[289]`
Mówca: **Manus Sazon**
> ""Happily, Rizians of foreign descent are finally beginning to gain the same rights and privileges as everyone else in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == false"*)

### Węzeł `[290]`
Mówca: **Manus Sazon**
> ""Sadly, Rizians of foreign descent still lack the same rights and privileges as everyone else in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == false"*)

### Węzeł `[291]`
Mówca: **Manus Sazon**
> ""Sadly, Rizians of foreign descent still lack the same rights and privileges as everyone else in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == false"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Bad == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == false"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_WorkersRights_Bad == false)"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Bad == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Manus Sazon: ""Satisfaction among our workers is higher than ever.""*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_WorkersRights_Bad == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Manus Sazon: ""We still have some way to go before workers are treated ..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Bad == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == false"*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_WorkersRights_Bad == false)"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Bad == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Manus Sazon: ""But satisfaction among our workers is higher than ever.""*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_WorkersRights_Bad == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Manus Sazon: ""And we still have some way to go before workers are trea..."*)

### Węzeł `[298]`
Mówca: **Manus Sazon**
> ""Satisfaction among our workers is higher than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Manus Sazon: ""Overall, our government cannot rest on our laurels. We a..."*)

### Węzeł `[299]`
Mówca: **Manus Sazon**
> ""We still have some way to go before workers are treated with the respect they deserve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Manus Sazon: ""Overall, our government cannot rest on our laurels. We a..."*)

### Węzeł `[300]`
Mówca: **Manus Sazon**
> ""And we still have some way to go before workers are treated with the respect they deserve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Manus Sazon: ""Overall, our government cannot rest on our laurels. We a..."*)

### Węzeł `[301]`
Mówca: **Manus Sazon**
> ""But satisfaction among our workers is higher than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Manus Sazon: ""Overall, our government cannot rest on our laurels. We a..."*)

### Węzeł `[302]`
Mówca: **Manus Sazon**
> ""Overall, our government cannot rest on our laurels. We are still trying to make up for hundreds of years of inequality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Daria de Rava: ""Objection. You speak of the improved lot of commoners wh..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Daria de Rava: ""The majority of citizens support the war.""*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == false"*)

### Węzeł `[306]`
Mówca: **Daria de Rava**
> ""The majority of citizens support the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == false"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_ProBusiness > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_ProBusiness > 0"*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_ProBusiness > 0)"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_ProBusiness > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_ProBusiness"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Daria de Rava: ""Business owners are appreciative of all we have done for..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_ProBusiness > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_ProBusiness"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Daria de Rava: ""Business owners feel we could be doing more for them.""*)

### Węzeł `[310]`
Mówca: **Daria de Rava**
> ""They are happy that our energy stores are stable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_ProBusiness > 0"*)

### Węzeł `[311]`
Mówca: **Daria de Rava**
> ""Our energy stores are, unfortunately, still a cause for anxiety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_ProBusiness > 0"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_EnergyCrisis == false"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_EnergyCrisis == false)"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_EnergyCrisis == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Daria de Rava: ""They are happy that our energy stores are stable.""*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_EnergyCrisis == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_EnergyCrisis"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Daria de Rava: ""Our energy stores are, unfortunately, still a cause for ..."*)

### Węzeł `[315]`
Mówca: **Daria de Rava**
> ""Business owners are appreciative of all we have done for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras > 0 && RiziaDLC.Country_House..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_ProBusiness > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_ProBusiness > 0"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_ProBusiness > 0)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_ProBusiness > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_ProBusiness"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Daria de Rava: ""But business owners are appreciative of all we have done..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_ProBusiness > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_ProBusiness"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Daria de Rava: ""And business owners feel we could be doing more for them.""*)

### Węzeł `[319]`
Mówca: **Daria de Rava**
> ""Business owners feel we could be doing more for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras > 0 && RiziaDLC.Country_House..."*)

### Węzeł `[320]`
Mówca: **Daria de Rava**
> ""But business owners are appreciative of all we have done for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras > 0 && RiziaDLC.Country_House..."*)

### Węzeł `[321]`
Mówca: **Daria de Rava**
> ""And business owners feel we could be doing more for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras > 0 && RiziaDLC.Country_House..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras > 0 && RiziaDLC.Country_HouseAzaro > 0 && RiziaDLC.Country_HouseSazon > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras > 0 && RiziaDLC.Country_House..."*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras > 0 && RiziaDLC.Country_Hou..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras > 0 && RiziaDLC.Country_HouseAzaro > 0 && RiziaDLC.Country_HouseSazon > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] > 0  and  Variable["RiziaDLC.Country_HouseAzaro"] > 0  and  Variable["RiziaDLC.Country_HouseSazon"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Daria de Rava: ""Surprisingly, all three royal houses approve of His Maje..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras > 0 && RiziaDLC.Country_HouseAzaro > 0 && RiziaDLC.Country_HouseSazon > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] > 0  and  Variable["RiziaDLC.Country_HouseAzaro"] > 0  and  Variable["RiziaDLC.Country_HouseSazon"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras > 0"*)

### Węzeł `[325]`
Mówca: **Daria de Rava**
> ""Surprisingly, all three royal houses approve of His Majesty's reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Daria de Rava: ""All in all, we cannot rest on our laurels. We are still ..."*)

### Węzeł `[326]`
Mówca: **Daria de Rava**
> ""As expected, the Valenqiris nobility still approves of His Majesty's reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro > 0"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras > 0"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras > 0 )"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Daria de Rava: ""As expected, the Valenqiris nobility still approves of H..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras > 0 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro> 0"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro> 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro> 0"*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseAzaro> 0 )"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro> 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"]> 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Daria de Rava: ""As expected, the nobility of Cardesse-Montaklar still ap..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseAzaro> 0 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"]> 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon > 0"*)

### Węzeł `[333]`
Mówca: **Daria de Rava**
> ""As expected, the nobility of Cardesse-Montaklar still approves of His Majesty's reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon > 0"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon > 0"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseSazon > 0)"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Daria de Rava: ""Only the nobility of Brenas approves of His Majesty's re..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseSazon > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Daria de Rava: ""Support for His Majesty's reign is lacking among the nob..."*)

### Węzeł `[337]`
Mówca: **Daria de Rava**
> ""Only the nobility of Brenas approves of His Majesty's reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Daria de Rava: ""All in all, we cannot rest on our laurels. We are still ..."*)

### Węzeł `[338]`
Mówca: **Daria de Rava**
> ""Support for His Majesty's reign is lacking among the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Daria de Rava: ""All in all, we cannot rest on our laurels. We are still ..."*)

### Węzeł `[339]`
Mówca: **Daria de Rava**
> ""As does that of Cardesse-Montaklar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Daria de Rava: ""All in all, we cannot rest on our laurels. We are still ..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro > 0"*)
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseAzaro > 0)"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Daria de Rava: ""As does that of Cardesse-Montaklar.""*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseAzaro > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon > 0"*)

### Węzeł `[343]`
Mówca: **Daria de Rava**
> ""As does that of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Daria de Rava: ""All in all, we cannot rest on our laurels. We are still ..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon > 0"*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseSazon > 0)"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Daria de Rava: ""As does that of Brenas.""*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseSazon > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Daria de Rava: ""Support is lacking among the rest of the nobility, howev..."*)

### Węzeł `[347]`
Mówca: **Daria de Rava**
> ""Support is lacking among the rest of the nobility, however.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Daria de Rava: ""All in all, we cannot rest on our laurels. We are still ..."*)

### Węzeł `[348]`
Mówca: **Daria de Rava**
> ""All in all, we cannot rest on our laurels. We are still far from the universal approval of the Lyza era.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_Media_State == true"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_Media_State == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_Media_State == true"*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Law_Media_State == true)"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_Media_State == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_Media_State"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Manus Sazon: ""Objection. How can we gauge approval when our people lac..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Law_Media_State == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_Media_State"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Manus Sazon: ""Excuse me. All of this talk about nobles, and none about..."*)

### Węzeł `[352]`
Mówca: **Manus Sazon**
> ""Objection. How can we gauge approval when our people lack freedom of speech?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Player_Romus: ""I trust my House Speaker to know what's going on in this..."*)
  - -> `[358]` (*Player_Romus: ""And I suppose you have a better sense of what the public..."*)
  - -> `[359]` (*Player_Romus: ""My subjects love me. End of conversation.""*)

### Węzeł `[353]`
Mówca: **Manus Sazon**
> ""Excuse me. All of this talk about nobles, and none about commoners?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Player_Romus: ""Madame Speaker said that public opinion of me was high. ..."*)
  - -> `[355]` (*Player_Romus: ""A very good point. Tell me, what do the commoners think ..."*)
  - -> `[356]` (*Player_Romus: ""All of my subjects love me. End of conversation.""*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Madame Speaker said that public opinion of me was high. That includes commoners.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A very good point. Tell me, what do the commoners think of me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All of my subjects love me. End of conversation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust my House Speaker to know what's going on in this kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Daria de Rava: ""Thank you, Your Majesty.""*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I suppose you have a better sense of what the public thinks of me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My subjects love me. End of conversation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Manus Sazon: ""Some commoners, perhaps. But not all.""*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Manus Sazon: ""That may happen to be true. But to only focus on the nob..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Player_Romus: ""You will refrain from speaking out of turn, Mr. Sazon.""*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will refrain from speaking out of turn, Mr. Sazon.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[353]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Manus Sazon: ""Of course. Forgive me.""*)

### Węzeł `[367]`
Mówca: **Manus Sazon**
> ""Some commoners, perhaps. But not all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[368]`
Mówca: **Manus Sazon**
> ""That may happen to be true. But to only focus on the nobility, while making no mention of the improved situation of the less fortunate--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Daria de Rava: ""The fortune of the nobility trickles down to the very bo..."*)

### Węzeł `[369]`
Mówca: **Daria de Rava**
> ""The fortune of the nobility trickles down to the very bottom rungs of our society. We are seeing that now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Daria de Rava: ""Now please refrain from any further interruptions, Mr. S..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ..."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Manus Sazon: ""As it happens, Your Majesty...""*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Manus Sazon: ""As a matter of fact, they are fairly satisfied with your..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Manus Sazon: ""As a matter of fact, Your Majesty--""*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Manus Sazon: ""You're not wrong, Your Majesty, but--""*)

### Węzeł `[376]`
Mówca: **Manus Sazon**
> ""As a matter of fact, Your Majesty--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Daria de Rava: ""The King has spoken, Mr. Sazon. There will be no further..."*)

### Węzeł `[377]`
Mówca: **Daria de Rava**
> ""The King has spoken, Mr. Sazon. There will be no further interruptions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)

### Węzeł `[378]`
Mówca: **Manus Sazon**
> ""As it happens, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[379]`
Mówca: **Manus Sazon**
> ""As a matter of fact, I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Manus Sazon: ""As a matter of fact, I do.""*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true || RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true || RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true  or  Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Manus Sazon: ""As a matter of fact, commoners are fairly satisfied with..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Manus Sazon: ""Living standards among the lower classes unfortunately r..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == tr..."*)

### Węzeł `[386]`
Mówca: **Manus Sazon**
> ""Living standards among the lower classes unfortunately remain subpar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == tr..."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == tr..."*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == ..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Manus Sazon: ""Affordable housing has become increasingly hard to secur..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_Housing_LackOfAffordable == true || RiziaDLC.Situation_Welfare_Housing_WorseningCrisis == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_Housing_LackOfAffordable"] == true  or  Variable["RiziaDLC.Situation_Welfare_Housing_WorseningCrisis"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)

### Węzeł `[390]`
Mówca: **Manus Sazon**
> ""Affordable housing has become increasingly hard to secure, to the point of impending crisis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true"*)
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == ..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Manus Sazon: ""Rizians of foreign descent still lack the same rights an..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_TreatmentOfForeigners_Unfair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || R..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || R..."*)
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true ||..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Manus Sazon: ""After all this time, our workers are still demanding the..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || RiziaDLC.Situation_Welfare_WorkersRights_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_WorkersRights_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_WorkersRights_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == false"*)

### Węzeł `[397]`
Mówca: **Manus Sazon**
> ""After all this time, our workers are still demanding the most basic of protections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == false"*)

### Węzeł `[398]`
Mówca: **Manus Sazon**
> ""Rizians of foreign descent still lack the same rights and privileges as everyone else in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_WorkersRights_Bad == true || R..."*)

### Węzeł `[399]`
Mówca: **Manus Sazon**
> ""Not quite as rosy a picture as Madame Speaker is painting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Player_Romus: ""And I suppose you know how to fix everything?""*)
  - -> `[416]` (*Player_Romus: ""That doesn't sound bad at all. Certainly not bad enough ..."*)
  - -> `[429]` (*Player_Romus: ""If that's true, then I have work to do.""*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[400]`
Mówca: **Manus Sazon**
> ""As a matter of fact, commoners are fairly satisfied with your reign. But the fact that they are not allowed to express dissent--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Daria de Rava: ""What dissent? You said yourself that they are satisfied.""*)

### Węzeł `[401]`
Mówca: **Daria de Rava**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Daria de Rava: ""Now please refrain from any further interruptions, Mr. S..."*)

### Węzeł `[402]`
Mówca: **Manus Sazon**
> ""You're not wrong, Your Majesty, but--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Daria de Rava: ""The King has spoken, Mr. Sazon. There will be no further..."*)

### Węzeł `[403]`
Mówca: **Manus Sazon**
> ""Of course. Forgive me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Daria de Rava: ""Now please refrain from any further interruptions, Mr. S..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == false"*)
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == false)"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Manus Sazon: ""Compounding their misery is the fact that they cannot sp..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Manus Sazon: ""Not quite as rosy a picture as Madame Speaker is painting.""*)

### Węzeł `[407]`
Mówca: **Manus Sazon**
> ""Compounding their misery is the fact that they cannot speak out about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Manus Sazon: ""Not quite as rosy a picture as Madame Speaker is painting.""*)

### Węzeł `[408]`
Mówca: **Daria de Rava**
> ""Now please refrain from any further interruptions, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)

### Węzeł `[409]`
Mówca: **Daria de Rava**
> ""What dissent? You said yourself that they are satisfied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Daria de Rava: ""Now please refrain from any further interruptions, Mr. S..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve == true)"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Daria de Rava: ""You may have the ear of a certain Princess of Rizia, but..."*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Narrator: "She turned to look at me."*)

### Węzeł `[413]`
Mówca: **Daria de Rava**
> ""You may have the ear of a certain Princess of Rizia, but you do not control this assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Narrator: "She turned to look at me."*)

### Węzeł `[414]`
Mówca: **Narrator**
> "She turned to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Daria de Rava: ""My party -- which I will remind you is the majority -- h..."*)

### Węzeł `[415]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I suppose you know how to fix everything?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Manus Sazon: ""Not everything, but...""*)

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That doesn't sound bad at all. Certainly not bad enough to make me lose sleep.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Manus Sazon: ""But--""*)

### Węzeł `[417]`
Mówca: **Daria de Rava**
> ""My party -- which I will remind you is the majority -- has already suggested a number of proposals to strengthen our kingdom and keep public satisfaction high.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_C..."*)
  - -> `[419]` (*Player_Romus: ""Very good. I'll have another look over them.""*)
  - -> `[420]` (*Player_Romus: ""I don't know about that. Perhaps I should be paying more..."*)

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already enacted plenty of RNC proposals. Don't get too greedy.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true)  or  (Variable["RiziaDLC.Policy_RD_Order_ExpandBorderGuards"] == true  and  (Variable["RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_BusinessTaxCredits"] == true))`
- **Kontekst wejściowy (poprzednik):** `[417]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Daria de Rava: ""We are grateful your Majesty. We won't. That is my word.""*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. I'll have another look over them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[417]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Daria de Rava: ""That is all we ask.""*)

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know about that. Perhaps I should be paying more attention to the plight of the common man.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[417]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Daria de Rava: ""A rising tide lifts all boats, Your Majesty -- pardon th..."*)

### Węzeł `[421]`
Mówca: **Daria de Rava**
> ""We are grateful your Majesty. We won't. That is my word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[422]`
Mówca: **Daria de Rava**
> ""That is all we ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[423]`
Mówca: **Daria de Rava**
> ""A rising tide lifts all boats, Your Majesty -- pardon the inappropriate metaphor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[424]`
Mówca: **Daria de Rava**
> ""You're right, Your Majesty. I apologize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve == true)"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Player_Romus: ""Please refrain from personal jabs at the opposition lead..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[428]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please refrain from personal jabs at the opposition leader. Mr. Sazon's relationship with Princess Vina has no impact on what happens in this building.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Kontekst wejściowy (poprzednik):** `[417]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Daria de Rava: ""You're right, Your Majesty. I apologize.""*)

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that's true, then I have work to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Manus Sazon: ""I am glad you see it that way.""*)

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop spewing lies. The commoners in Rizia are happier than ever.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[399]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Manus Sazon: ""But--""*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Player_Romus: ""Stop spewing lies. The commoners in Rizia are happier th..."*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[434]`
Mówca: **Manus Sazon**
> ""But--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Daria de Rava: ""The King has spoken, Mr. Sazon. There will be no further..."*)

### Węzeł `[435]`
Mówca: **Manus Sazon**
> ""Not everything, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Manus Sazon: ""My party has suggested a number of proposals that might ..."*)

### Węzeł `[436]`
Mówca: **Manus Sazon**
> ""I am glad you see it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Manus Sazon: ""My party has suggested a number of proposals that might ..."*)

### Węzeł `[437]`
Mówca: **Manus Sazon**
> ""As a matter of fact, they are fairly satisfied with your reign. But to only focus on the nobility, while making no mention of the improved situation of the less fortunate--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Daria de Rava: ""The fortune of the nobility trickles down to the very bo..."*)

### Węzeł `[438]`
Mówca: **Manus Sazon**
> ""My party has suggested a number of proposals that might improve the situation. It is our hope His Majesty will enact them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Player_Romus: ""Thank you, Mr. Sazon. But I doubt any of them will help.""*)
  - -> `[440]` (*Player_Romus: ""Very good. I'll have another look over them.""*)
  - -> `[441]` (*Player_Romus: ""I will not promise the opposition anything. But I will t..."*)

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Mr. Sazon. But I doubt any of them will help.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Narrator: "Next to me, Hugo shook his head adamantly."*)

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. I'll have another look over them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Manus Sazon: ""That is all we ask.""*)

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will not promise the opposition anything. But I will think about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Manus Sazon: ""That is all we ask.""*)

### Węzeł `[442]`
Mówca: **Narrator**
> "Next to me, Hugo shook his head adamantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[443]`
Mówca: **Manus Sazon**
> ""That is all we ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[444]`
Mówca: **Daria de Rava**
> ""Objection. You speak of the improved lot of commoners while ignoring the businesses and noble institutions that make up the beating heart of this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Player_Romus: ""The Speaker said that public opinion of me was high. Tha..."*)
  - -> `[446]` (*Player_Romus: ""A very good point. Tell me, Ms. de Rava, what do the ric..."*)
  - -> `[447]` (*Player_Romus: ""All of my subjects love me. End of conversation.""*)

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Speaker said that public opinion of me was high. That includes the wealthy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[444]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country..."*)

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A very good point. Tell me, Ms. de Rava, what do the rich and famous think of me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[444]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country..."*)

### Węzeł `[447]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All of my subjects love me. End of conversation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[444]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Narrator: "Manus spoke animatedly."*)

### Węzeł `[448]`
Mówca: **Narrator**
> "Manus spoke animatedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Manus Sazon: ""Corporations and landowners are doing just fine, Your Ma..."*)

### Węzeł `[449]`
Mówca: **Manus Sazon**
> ""Corporations and landowners are doing just fine, Your Majesty. They always have been.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Manus Sazon: ""Now. My party -- which I will remind you is the majority..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country..."*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Count..."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_ProBusiness"] < 0  or  Variable["RiziaDLC.Country_HouseToras"] < 0  or  Variable["RiziaDLC.Country_HouseSazon"] < 0  or  Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Daria de Rava: ""Not necessarily.""*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_ProBusiness"] < 0  or  Variable["RiziaDLC.Country_HouseToras"] < 0  or  Variable["RiziaDLC.Country_HouseSazon"] < 0  or  Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Daria de Rava: ""As it happens, Your Majesty, you're right. But for the H..."*)

### Węzeł `[453]`
Mówca: **Daria de Rava**
> ""Not necessarily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_ProBusiness < 0"*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country..."*)
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Count..."*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_ProBusiness"] < 0  or  Variable["RiziaDLC.Country_HouseToras"] < 0  or  Variable["RiziaDLC.Country_HouseSazon"] < 0  or  Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Daria de Rava: ""As it happens...""*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_ProBusiness < 0 || RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_ProBusiness"] < 0  or  Variable["RiziaDLC.Country_HouseToras"] < 0  or  Variable["RiziaDLC.Country_HouseSazon"] < 0  or  Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Daria de Rava: ""As it happens, they're quite satisfied with your reign t..."*)

### Węzeł `[457]`
Mówca: **Daria de Rava**
> ""As it happens...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_ProBusiness < 0"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_ProBusiness < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_ProBusiness < 0"*)
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_ProBusiness < 0)"*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_ProBusiness < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_ProBusiness"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Daria de Rava: ""Rizia's business owners are quite unhappy with some of t..."*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_ProBusiness < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_ProBusiness"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Daria de Rava: ""Your approval has been slipping among the nobility.""*)

### Węzeł `[461]`
Mówca: **Daria de Rava**
> ""Rizia's business owners are quite unhappy with some of the policies you've enacted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC..."*)

### Węzeł `[462]`
Mówca: **Daria de Rava**
> ""Your approval has been slipping among the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0 && RiziaDLC.Country_House..."*)

### Węzeł `[463]`
Mówca: **Daria de Rava**
> ""As it happens, they're quite satisfied with your reign thus far. But to fail to even mention them--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Manus Sazon: ""I didn't mention them because they're doing just fine. T..."*)

### Węzeł `[464]`
Mówca: **Manus Sazon**
> ""I didn't mention them because they're doing just fine. They always have been.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Manus Sazon: ""Now. My party -- which I will remind you is the majority..."*)

### Węzeł `[465]`
Mówca: **Daria de Rava**
> ""As it happens, Your Majesty, you're right. But for the House Speaker to not even mention the nobility--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Manus Sazon: ""I didn't mention them because they're doing just fine. T..."*)

### Węzeł `[466]`
Mówca: **Manus Sazon**
> ""Now. My party -- which I will remind you is the majority -- has suggested a number of proposals to further improve the status of ordinary Rizians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Player_Romus: ""I've already enacted plenty of RPP proposals. Don't get ..."*)
  - -> `[468]` (*Player_Romus: ""Very good. I'll have another look over them.""*)
  - -> `[469]` (*Player_Romus: ""I don't know about that. Perhaps I should be paying more..."*)

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already enacted plenty of RPP proposals. Don't get too greedy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Manus Sazon: ""No, Your Majesty. We won't.""*)

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. I'll have another look over them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Manus Sazon: ""That is all we ask.""*)

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know about that. Perhaps I should be paying more attention to the plight of nobles.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Manus Sazon: ""Respectfully, Your Majesty, my party is in charge of thi..."*)

### Węzeł `[470]`
Mówca: **Manus Sazon**
> ""No, Your Majesty. We won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[471]`
Mówca: **Manus Sazon**
> ""That is all we ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[472]`
Mówca: **Manus Sazon**
> ""Respectfully, Your Majesty, my party is in charge of this assembly precisely because nobles were getting too much attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC..."*)
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaD..."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true  or  Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Daria de Rava: ""Your handling of the MITZ renegotiations has them fearin..."*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Nationalization_NoShare == true || RiziaDLC.MITZ_Nationalization_SmallerShare == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Nationalization_NoShare"] == true  or  Variable["RiziaDLC.MITZ_Nationalization_SmallerShare"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Reduction == true"*)

### Węzeł `[476]`
Mówca: **Daria de Rava**
> ""Your handling of the MITZ renegotiations has them fearing that their own companies will undergo nationalization as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Reduction == true"*)

### Węzeł `[477]`
Mówca: **Daria de Rava**
> ""The reduction in the number of new businesses being founded is sure to hurt us in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_House..."*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Reduction == true"*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Daria de Rava: ""The reduction in the number of new businesses being foun..."*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_House..."*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_House..."*)
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_Hou..."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0  or  Variable["RiziaDLC.Country_HouseSazon"] < 0  or  Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Daria de Rava: ""Furthermore, your approval has been slipping among the n..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras < 0 || RiziaDLC.Country_HouseSazon < 0 || RiziaDLC.Country_HouseAzaro < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0  or  Variable["RiziaDLC.Country_HouseSazon"] < 0  or  Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Daria de Rava: ""Not quite as rosy a picture as Mr. Speaker is painting.""*)

### Węzeł `[484]`
Mówca: **Daria de Rava**
> ""Furthermore, your approval has been slipping among the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0 && RiziaDLC.Country_House..."*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0 && RiziaDLC.Country_HouseAzaro < 0 && RiziaDLC.Country_HouseSazon < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0 && RiziaDLC.Country_House..."*)
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras < 0 && RiziaDLC.Country_Hou..."*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0 && RiziaDLC.Country_HouseAzaro < 0 && RiziaDLC.Country_HouseSazon < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0  and  Variable["RiziaDLC.Country_HouseAzaro"] < 0  and  Variable["RiziaDLC.Country_HouseSazon"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Daria de Rava: ""You've lost support from every single noble house.""*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras < 0 && RiziaDLC.Country_HouseAzaro < 0 && RiziaDLC.Country_HouseSazon < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0  and  Variable["RiziaDLC.Country_HouseAzaro"] < 0  and  Variable["RiziaDLC.Country_HouseSazon"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)

### Węzeł `[488]`
Mówca: **Daria de Rava**
> ""You've lost support from every single noble house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Narrator: "I looked at Hugo. He avoided my gaze."*)

### Węzeł `[489]`
Mówca: **Daria de Rava**
> ""You've lost the support of your own province's noble families.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Narrator: "I looked at Hugo. He avoided my gaze."*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras < 0 )"*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Daria de Rava: ""You've lost the support of your own province's noble fam..."*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras < 0 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 0"*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 0"*)
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseAzaro < 0 )"*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Daria de Rava: ""The nobles of Cardesse-Montaklar have signalled their di..."*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseAzaro < 0 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon < 0"*)

### Węzeł `[496]`
Mówca: **Daria de Rava**
> ""The nobles of Cardesse-Montaklar have signalled their disproval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon < 0"*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseSazon < 0"*)
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseSazon < 0)"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseSazon < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseSazon"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Daria de Rava: ""The Sazons of Brenas now seem to despise you overtly.""*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseSazon < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseSazon"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Daria de Rava: ""Not quite as rosy a picture as Mr. Speaker is painting.""*)

### Węzeł `[500]`
Mówca: **Daria de Rava**
> ""The Sazons of Brenas now seem to despise you overtly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Narrator: "She looked pointedly at Manus. He gaped in outrage."*)

### Węzeł `[501]`
Mówca: **Narrator**
> "I looked at Hugo. He avoided my gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Daria de Rava: ""Not quite as rosy a picture as Mr. Speaker is painting.""*)

### Węzeł `[502]`
Mówca: **Narrator**
> "I looked at Hugo. He avoided my gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 0"*)

### Węzeł `[503]`
Mówca: **Narrator**
> "She looked pointedly at Manus. He gaped in outrage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Daria de Rava: ""Not quite as rosy a picture as Mr. Speaker is painting.""*)

### Węzeł `[504]`
Mówca: **Daria de Rava**
> ""Not quite as rosy a picture as Mr. Speaker is painting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Player_Romus: ""And I suppose you know how to fix everything?""*)
  - -> `[506]` (*Player_Romus: ""That doesn't sound bad at all. Certainly not bad enough ..."*)
  - -> `[507]` (*Player_Romus: ""If that's true, then I have work to do.""*)
  - -> `[508]` (*Player_Romus: ""Let the bourgeoisie suffer a little bit. They've had the..."*)

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I suppose you know how to fix everything?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[504]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Daria de Rava: ""No, not everything, but...""*)

### Węzeł `[506]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That doesn't sound bad at all. Certainly not bad enough to make me lose sleep.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[504]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Daria de Rava: ""It's a mistake not to take this seriously, Your Majesty.""*)

### Węzeł `[507]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that's true, then I have work to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[504]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Daria de Rava: ""I'm happy you see it that way.""*)

### Węzeł `[508]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let the bourgeoisie suffer a little bit. They've had their time on top.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[504]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Daria de Rava: ""It's a mistake not to take this seriously, Your Majesty.""*)

### Węzeł `[509]`
Mówca: **Daria de Rava**
> ""I'm happy you see it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Daria de Rava: ""My party has suggested a number of proposals to improve ..."*)

### Węzeł `[510]`
Mówca: **Daria de Rava**
> ""No, not everything, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Daria de Rava: ""My party has suggested a number of proposals to improve ..."*)

### Węzeł `[511]`
Mówca: **Daria de Rava**
> ""It's a mistake not to take this seriously, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Manus Sazon: ""You've made your point. Madame Speaker. Please don't int..."*)

### Węzeł `[512]`
Mówca: **Manus Sazon**
> ""You've made your point. Madame Speaker. Please don't interrupt any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Manus Sazon: ""Now. My party -- which I will remind you is the majority..."*)

### Węzeł `[513]`
Mówca: **Daria de Rava**
> ""My party has suggested a number of proposals to improve the situation. It is our hope you will enact them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Player_Romus: ""I've already enacted plenty of RNC proposals. Don't get ..."*)
  - -> `[515]` (*Player_Romus: ""Very good. I'll have another look over them.""*)
  - -> `[516]` (*Player_Romus: ""I don't know about that. Perhaps I should be paying more..."*)

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already enacted plenty of RNC proposals. Don't get too greedy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[513]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Daria de Rava: ""No, Your Majesty. We won't.""*)

### Węzeł `[515]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. I'll have another look over them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[513]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Daria de Rava: ""That is all we ask.""*)

### Węzeł `[516]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know about that. Perhaps I should be paying more attention to the plight of the common man.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[513]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Daria de Rava: ""A rising tide lifts all boats, Your Majesty -- pardon th..."*)

### Węzeł `[517]`
Mówca: **Daria de Rava**
> ""No, Your Majesty. We won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[518]`
Mówca: **Daria de Rava**
> ""That is all we ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[519]`
Mówca: **Daria de Rava**
> ""A rising tide lifts all boats, Your Majesty -- pardon the inappropriate metaphor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true && RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true) || (RiziaDLC.Policy_RD_Order_ExpandBorderGuards == true && (RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization == true || RiziaDLC.Policy_RD_Economy_BusinessTaxCredits == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_C..."*)
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion..."*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true && RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true) || (RiziaDLC.Policy_RD_Order_ExpandBorderGuards == true && (RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization == true || RiziaDLC.Policy_RD_Economy_BusinessTaxCredits == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true)  or  (Variable["RiziaDLC.Policy_RD_Order_ExpandBorderGuards"] == true  and  (Variable["RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_BusinessTaxCredits"] == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Player_Romus: ""I've already enacted plenty of RNC proposals. Don't get ..."*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true && RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true) || (RiziaDLC.Policy_RD_Order_ExpandBorderGuards == true && (RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization == true || RiziaDLC.Policy_RD_Economy_BusinessTaxCredits == true)))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true)  or  (Variable["RiziaDLC.Policy_RD_Order_ExpandBorderGuards"] == true  and  (Variable["RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_BusinessTaxCredits"] == true))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Co..."*)

### Węzeł `[523]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already enacted a RNC proposal. We can do more, but in the future.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true  or  Variable["RiziaDLC.Policy_RD_Order_ExpandBorderGuards"] == true  or    Variable["RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_BusinessTaxCredits"] == true` AND `((Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true)  or  (Variable["RiziaDLC.Policy_RD_Order_ExpandBorderGuards"] == true  and  (Variable["RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_BusinessTaxCredits"] == true))) == false`
- **Kontekst wejściowy (poprzednik):** `[417]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Daria de Rava: ""The RNC is here to aid the crown. Our proposals will eas..."*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true || RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Order_ExpandBorderGuards == true ||   RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization == true || RiziaDLC.Policy_RD_Economy_BusinessTaxCredits == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Co..."*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_..."*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true || RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Order_ExpandBorderGuards == true ||   RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization == true || RiziaDLC.Policy_RD_Economy_BusinessTaxCredits == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true  or  Variable["RiziaDLC.Policy_RD_Order_ExpandBorderGuards"] == true  or    Variable["RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_BusinessTaxCredits"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Player_Romus: ""I've already enacted a RNC proposal. We can do more, but..."*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed == true || RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Order_ExpandBorderGuards == true ||   RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization == true || RiziaDLC.Policy_RD_Economy_BusinessTaxCredits == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_MonqizPortShipyardExpansion_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true  or  Variable["RiziaDLC.Policy_RD_Order_ExpandBorderGuards"] == true  or    Variable["RiziaDLC.Policy_RD_Economy_AllowWelfarePrivatization"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_BusinessTaxCredits"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[527]`
Mówca: **Daria de Rava**
> ""The RNC is here to aid the crown. Our proposals will ease your burden and help our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_QuelledProtests > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_QuelledProtests > 2"*)
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_QuelledProtests > 2)"*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_QuelledProtests > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_QuelledProtests"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Manus Sazon: ""Suppressing the recent protests has only made this facti..."*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_QuelledProtests > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_QuelledProtests"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Protests_MalenyevistStrike_Happened == true"*)

### Węzeł `[531]`
Mówca: **Manus Sazon**
> ""Suppressing the recent protests has only made this faction more determined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || Rizia..."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Protests_Welfare_Happened == true || RiziaDLC.Protests_LivingStandards_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Protests_Welfare_Happened == true || RiziaDLC.Pr..."*)
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Protests_Welfare_Happened == true || RiziaDLC...."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Protests_Welfare_Happened == true || RiziaDLC.Protests_LivingStandards_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Protests_Welfare_Happened"] == true  or  Variable["RiziaDLC.Protests_LivingStandards_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Manus Sazon: ""The recent citizen welfare protests were only the beginn..."*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Protests_Welfare_Happened == true || RiziaDLC.Protests_LivingStandards_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Protests_Welfare_Happened"] == true  or  Variable["RiziaDLC.Protests_LivingStandards_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Protests_PoliceBrutality_Happened == true || Riz..."*)

### Węzeł `[535]`
Mówca: **Manus Sazon**
> ""The recent citizen welfare protests were only the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || Rizia..."*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Protests_PoliceBrutality_Happened == true || RiziaDLC.Protests_AntiAureus_Happened == true || RiziaDLC.Protests_MediaCensorship_Happened`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Protests_PoliceBrutality_Happened == true || Riz..."*)
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Protests_PoliceBrutality_Happened == true || R..."*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Protests_PoliceBrutality_Happened == true || RiziaDLC.Protests_AntiAureus_Happened == true || RiziaDLC.Protests_MediaCensorship_Happened`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Protests_PoliceBrutality_Happened"] == true  or  Variable["RiziaDLC.Protests_AntiAureus_Happened"] == true  or  Variable["RiziaDLC.Protests_MediaCensorship_Happened"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Manus Sazon: ""The recent protests against Crown policies were only the..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Protests_PoliceBrutality_Happened == true || RiziaDLC.Protests_AntiAureus_Happened == true || RiziaDLC.Protests_MediaCensorship_Happened)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Protests_PoliceBrutality_Happened"] == true  or  Variable["RiziaDLC.Protests_AntiAureus_Happened"] == true  or  Variable["RiziaDLC.Protests_MediaCensorship_Happened"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Manus Sazon: ""Despite few overt protests, I assure you citizens' dissa..."*)

### Węzeł `[539]`
Mówca: **Manus Sazon**
> ""The recent protests against Crown policies were only the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true || Rizia..."*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true"*)
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Renegotiation_Failed == true)"*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Daria de Rava: ""Furthermore, at least some of the Malenyevist activity m..."*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Renegotiation_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: ""Both of you are getting worked up over nothing. The 'red..."*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist < 0"*)
  - -> `[26]` (*Player_Romus: ""Malenyevism started as a fringe movement in United Conta..."*)

### Węzeł `[543]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will have a look. But I am wary of granting the public too many favors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Manus Sazon: ""Be kind to them, and they will support the Crown in retu..."*)

### Węzeł `[544]`
Mówca: **Manus Sazon**
> ""Be kind to them, and they will support the Crown in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true"*)
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Renegotiation_Failed == true)"*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player_Romus: ""Correct. What we are seeing is nothing but retaliation f..."*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Renegotiation_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
