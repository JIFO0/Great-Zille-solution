# Sordland/Turn10/A_Resignations

- **ID konwersacji:** `211`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/211_A_Resignations.md`
- **Liczba węzłów dialogowych:** 843
- **Liczba wyborów gracza:** 77

---

## 1. Uczestnicy Sceny

- **[2]** Paskal Beniwoll
- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[35]** Gus Manger
- **[38]** Lucian Galade
- **[40]** Ciara Walda
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Democratic`
- `BaseGame.Fired_Symon`
- `BaseGame.LeakedScandal_GusManger_UnderhallCollusion`
- `BaseGame.LeakedScandal_SecretState_DetainFrensRicter`
- `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener`
- `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno`
- `BaseGame.LeakedScandal_SecretState_DetainPetrVectern`
- `BaseGame.LeakedScandal_SecretState_KillFrensRicter`
- `BaseGame.LeakedScandal_SecretState_KillKesaroKibener`
- `BaseGame.LeakedScandal_SecretState_KillLiviaSuno`
- `BaseGame.LeakedScandal_SecretState_KillOrsoHawker`
- `BaseGame.LeakedScandal_SecretState_KillPetrVectern`
- `BaseGame.Pandemic_Severity`
- `BaseGame.Policy_Economy_RailwayProject`
- `BaseGame.Policy_Law_Decree_Default`
- `BaseGame.Policy_Law_Decree_Stronger`
- `BaseGame.Policy_Law_Honorary_Presidents`
- `BaseGame.Policy_Law_Impeachment_Removed`
- `BaseGame.Policy_Law_Judges_Impeachment_President`
- `BaseGame.Policy_Law_TermLimits_Default`
- `BaseGame.Policy_Law_Threshold_15`
- `BaseGame.Policy_Law_Threshold_Default`
- `BaseGame.Policy_Law_Veto_Loophole`
- `BaseGame.Policy_Welfare_HealthReform`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Nia_Opposition`
- `BaseGame.Resigned_CiaraWalda`
- `BaseGame.Resigned_GusManger`
- `BaseGame.Resigned_NiaMorgna`
- `BaseGame.Resigned_PaskalBeniwoll`
- `BaseGame.Resigned_SymonHoll`
- `BaseGame.Situation_Law_MediaCensored`
- `BaseGame.Situation_Welfare_EpidemicPrevented`
- `BaseGame.Situation_Welfare_ModernEducationTechniques`
- `BaseGame.Situation_Welfare_QualityRuralHealthServices`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn03_EnT_Education_Budget_Decrease`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Increase`
- `BaseGame.Turn04_PSnW_Education_Progressive`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn05_P_Underhall`
- `BaseGame.Turn05_P_Vineyard`
- `BaseGame.Turn09_EnT_SordishDepression`
- `BaseGame.Turn09_EnT_SordishRecovery`
- `BaseGame.WomensRightCommission`
- `BaseGameIsolated.Turn10_A_NumberOfResignations`
- `BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingAnrakaLife`
- `BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingROGRiziaLife`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Public_Opinion`
- `BaseGameIsolated.Turn10_A_NumberOfResignations`
- `BaseGameSupport.Codex_Characters_Cabinet_CiaraWalda`
- `BaseGameSupport.Codex_Characters_Cabinet_CiaraWalda_Resigned`
- `BaseGameSupport.Codex_Characters_Cabinet_GusManger`
- `BaseGameSupport.Codex_Characters_Cabinet_GusManger_Resigned`
- `BaseGameSupport.Codex_Characters_Cabinet_NiaMorgna`
- `BaseGameSupport.Codex_Characters_Cabinet_NiaMorgna_Resigned`
- `BaseGameSupport.Codex_Characters_Cabinet_PaskalBeniwoll`
- `BaseGameSupport.Codex_Characters_Cabinet_PaskalBeniwoll_Resigned`
- `BaseGameSupport.Codex_Characters_Cabinet_SymonHoll`
- `BaseGameSupport.Codex_Characters_Cabinet_SymonHoll_Resigned`
- `BaseGameSupport.Journal_Turn10_Resignations_Ciara`
- `BaseGameSupport.Journal_Turn10_Resignations_Gus`
- `BaseGameSupport.Journal_Turn10_Resignations_Nia`
- `BaseGameSupport.Journal_Turn10_Resignations_Paskal`
- `BaseGameSupport.Journal_Turn10_Resignations_Symon`
- `BaseGameSupport.News_Turn10_HP_Resignations_MoreThanOne`
- `BaseGameSupport.News_Turn10_LT_Resignations_MoreThanOne`
- `BaseGameSupport.News_Turn10_LT_Resignations_One`
- `BaseGameSupport.News_Turn10_LT_Resignations_TooMany`
- `BaseGameSupport.News_Turn10_R_Resignations_MoreThanOne`
- `GameCondition.Turn10_A_Resignations`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[25]` | **""What is it now?""** | `[24]` **Lucian Galade**: ""Mr. President. There is a probl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Lucian Galade**: ""Some cabinet members said they ..."<br>`[46]` **Lucian Galade**: ""Mrs. Walda wants to speak with ..."<br>*(oraz 1 innych odgałęzień)* |
| `[26]` | **""What kind of a problem?""** | `[24]` **Lucian Galade**: ""Mr. President. There is a probl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Lucian Galade**: ""Some cabinet members said they ..."<br>`[46]` **Lucian Galade**: ""Mrs. Walda wants to speak with ..."<br>*(oraz 1 innych odgałęzień)* |
| `[27]` | **""And?""** | `[24]` **Lucian Galade**: ""Mr. President. There is a probl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Lucian Galade**: ""Some cabinet members said they ..."<br>`[46]` **Lucian Galade**: ""Mrs. Walda wants to speak with ..."<br>*(oraz 1 innych odgałęzień)* |
| `[54]` | **""What's so urgent?""** | `[53]` **Narrator**: "We started walking." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Lucian Galade**: ""I was just told to come get you..." |
| `[55]` | **""Do you know what it's about?""** | `[53]` **Narrator**: "We started walking." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Lucian Galade**: ""I was just told to come get you..." |
| `[86]` | **""Good evening.""** | `[82]` **Narrator**: "Paskal looked incredibly stresse..."<br>`[79]` **Narrator**: "Symon and Gus were seated. They ..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false` | *Brak zmian stanu* | `[104]` **Ciara Walda**: ""Mr. President. I'll cut to the ..."<br>`[375]` **Ciara Walda**: ""Mr. President. I'll cut to the ..."<br>*(oraz 2 innych odgałęzień)* |
| `[87]` | **""What is going on here?""** | `[82]` **Narrator**: "Paskal looked incredibly stresse..."<br>`[79]` **Narrator**: "Symon and Gus were seated. They ..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false` | *Brak zmian stanu* | `[104]` **Ciara Walda**: ""Mr. President. I'll cut to the ..."<br>`[375]` **Ciara Walda**: ""Mr. President. I'll cut to the ..."<br>*(oraz 2 innych odgałęzień)* |
| `[88]` | **""So. Why did you call me here?""** | `[82]` **Narrator**: "Paskal looked incredibly stresse..."<br>`[79]` **Narrator**: "Symon and Gus were seated. They ..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false` | *Brak zmian stanu* | `[104]` **Ciara Walda**: ""Mr. President. I'll cut to the ..."<br>`[375]` **Ciara Walda**: ""Mr. President. I'll cut to the ..."<br>*(oraz 2 innych odgałęzień)* |
| `[114]` | **""Your resignations? What is the meaning of this?""** | `[105]` **Ciara Walda**: ""We are here to let you know tha..."<br>`[106]` **Nia Morgna**: ""We are here to let you know tha..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Ciara Walda**: ""Exactly what it looks like. We ..."<br>`[159]` **Nia Morgna**: ""Exactly what it looks like. We ..."<br>*(oraz 1 innych odgałęzień)* |
| `[115]` | **""I see. You are trying to sabotage me before the elections.""** | `[105]` **Ciara Walda**: ""We are here to let you know tha..."<br>`[106]` **Nia Morgna**: ""We are here to let you know tha..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Ciara Walda**: ""That is not why. We simply can ..."<br>`[142]` **Nia Morgna**: ""That is not why. We simply can ..."<br>*(oraz 1 innych odgałęzień)* |
| `[116]` | **""Let's all calm down. We can work something out.""** | `[105]` **Ciara Walda**: ""We are here to let you know tha..."<br>`[106]` **Nia Morgna**: ""We are here to let you know tha..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Ciara Walda**: ""I'm afraid we can't calm down. ..."<br>`[125]` **Nia Morgna**: ""I'm afraid we can't calm down. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[168]` | **""You're betraying me, then.""** | `[117]` **Paskal Beniwoll**: ""I'm afraid we can't calm down. ..."<br>`[124]` **Symon Holl**: ""I'm afraid we can't calm down. ..."<br>*(oraz 13 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Ciara Walda**: ""This is nothing as grandiose as..."<br>`[195]` **Nia Morgna**: ""This is nothing as grandiose as..."<br>*(oraz 1 innych odgałęzień)* |
| `[169]` | **""But why? What are your reasons?""** | `[117]` **Paskal Beniwoll**: ""I'm afraid we can't calm down. ..."<br>`[124]` **Symon Holl**: ""I'm afraid we can't calm down. ..."<br>*(oraz 13 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[385]` **Ciara Walda**: ""I suppose we owe you an explana..."<br>`[384]` **Nia Morgna**: ""I suppose we owe you an explana..."<br>*(oraz 1 innych odgałęzień)* |
| `[170]` | **""Talk to me. What can I do? How can I help you better?""** | `[117]` **Paskal Beniwoll**: ""I'm afraid we can't calm down. ..."<br>`[124]` **Symon Holl**: ""I'm afraid we can't calm down. ..."<br>*(oraz 13 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Ciara Walda**: ""I'm sorry, but everyone in this..."<br>`[178]` **Nia Morgna**: ""I'm sorry, but everyone in this..."<br>*(oraz 1 innych odgałęzień)* |
| `[229]` | **""I was going to announce it to the cabinet at some point.""** | `[228]` **Paskal Beniwoll**: ""What is most upsetting is the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Nia Morgna**: ""Can you not even see that's not..." |
| `[230]` | **""I did what I have done in order to protect this country.""** | `[228]` **Paskal Beniwoll**: ""What is most upsetting is the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Nia Morgna**: ""No. You did what you have done ..." |
| `[231]` | **""Enough. If you don't have what it takes to improve this country, then you don't d..."** | `[228]` **Paskal Beniwoll**: ""What is most upsetting is the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Nia Morgna**: ""You have completely changed. I ..." |
| `[256]` | **""I will not stand by while you accuse me of treachery. Get out.""** | `[255]` **Nia Morgna**: ""Or about how you deceived your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Nia Morgna**: ""Not until we say our final words."" |
| `[257]` | **""Deceived? I brought reforms when no one else could.""** | `[255]` **Nia Morgna**: ""Or about how you deceived your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Nia Morgna**: ""By giving yourself more power? ..." |
| `[258]` | **""Presidential power must be maintained in a country like Sordland. Why don't you u..."** | `[255]` **Nia Morgna**: ""Or about how you deceived your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Nia Morgna**: ""You will reform the country by ..." |
| `[265]` | **""You are fools if you can't see the real threats. I don't need fools in my cabinet.""** | `[254]` **Nia Morgna**: ""What's next? You are going to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Nia Morgna**: ""There is only one threat in Sor..." |
| `[266]` | **""A King? That does sound nice, doesn't it?""** | `[254]` **Nia Morgna**: ""What's next? You are going to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Nia Morgna**: ""I have absolutely no words."" |
| `[267]` | **""Surely you jest! I did all I did for Sordland and Sordland alone!""** | `[254]` **Nia Morgna**: ""What's next? You are going to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Nia Morgna**: ""Your puppeteers have you so bra..." |
| `[278]` | **""You are taking responsibility by resigning? That doesn't even make sense.""** | `[277]` **Paskal Beniwoll**: ""If you are not going to take re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Paskal Beniwoll**: ""I am resigning because someone ..." |
| `[279]` | **""Please, Paskal. We need you in the government to solve this crisis once and for a..."** | `[277]` **Paskal Beniwoll**: ""If you are not going to take re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Paskal Beniwoll**: ""I'm sorry, Mr. President."" |
| `[280]` | **""This is because you have brought this to my attention so late.""** | `[277]` **Paskal Beniwoll**: ""If you are not going to take re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Paskal Beniwoll**: ""Please don't blame me, Mr. Pres..." |
| `[283]` | **""We can fix our mistakes if we work together.""** | `[246]` **Ciara Walda**: ""Thanks to you, gender inequalit..."<br>`[225]` **Ciara Walda**: ""I don't even know why I joined ..."<br>*(oraz 6 innych węzłów)* | `((Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)) == false`<br>`((Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == false  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true)) == false`<br>`Variable["BaseGame.Resigned_CiaraWalda"] == true` | *Brak zmian stanu* | `[288]` **Ciara Walda**: ""It's too late."" |
| `[284]` | **""And who is at fault there? Don't blame everything on me.""** | `[246]` **Ciara Walda**: ""Thanks to you, gender inequalit..."<br>`[225]` **Ciara Walda**: ""I don't even know why I joined ..."<br>*(oraz 6 innych węzłów)* | `((Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)) == false`<br>`((Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == false  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true)) == false`<br>`Variable["BaseGame.Resigned_CiaraWalda"] == true` | *Brak zmian stanu* | `[286]` **Ciara Walda**: ""We are all to blame because we ..." |
| `[285]` | **""There were other high priority issues we had to handle.""** | `[246]` **Ciara Walda**: ""Thanks to you, gender inequalit..."<br>`[225]` **Ciara Walda**: ""I don't even know why I joined ..."<br>*(oraz 6 innych węzłów)* | `((Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)) == false`<br>`((Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == false  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true)) == false`<br>`Variable["BaseGame.Resigned_CiaraWalda"] == true` | *Brak zmian stanu* | `[287]` **Ciara Walda**: ""What is more important than edu..." |
| `[306]` | **""Good. At least you have some dignity.""** | `[310]` **Symon Holl**: ""I will resign at the end of our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Symon Holl**: ""Thank you, Mr. President."" |
| `[307]` | **""Thank you. It's been a pleasure to work with you.""** | `[310]` **Symon Holl**: ""I will resign at the end of our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Symon Holl**: ""Likewise, Mr. President."" |
| `[308]` | **""Please don't do this, Symon. I am to blame, not you.""** | `[310]` **Symon Holl**: ""I will resign at the end of our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Symon Holl**: ""I'm afraid things are already i..." |
| `[319]` | **""Good. At least you have some dignity.""** | `[317]` **Symon Holl**: ""I will resign at the end of our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Symon Holl**: ""Thank you, Mr. President."" |
| `[320]` | **""Please don't do this, Symon. We can overcome our differences.""** | `[317]` **Symon Holl**: ""I will resign at the end of our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[322]` **Symon Holl**: ""I'm afraid things are already i..." |
| `[323]` | **""Thank you. It's been a pleasure to work with you.""** | `[317]` **Symon Holl**: ""I will resign at the end of our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Symon Holl**: ""Likewise, Mr. President."" |
| `[327]` | **""Good. Leave it on my desk on your way out.""** | `[326]` **Symon Holl**: ""I will resign at the end of our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[330]` **Symon Holl**: ""As you wish, Mr. President."" |
| `[328]` | **""Thank you. That will be all then.""** | `[326]` **Symon Holl**: ""I will resign at the end of our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Symon Holl**: ""Thank you, Mr. President."" |
| `[342]` | **""Very well. I understand.""** | `[341]` **Gus Manger**: ""I will resign immediately to br..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Gus Manger**: ""Thank you for understanding, Mr..." |
| `[343]` | **""Thank you. Regardless, it was nice to have you here.""** | `[341]` **Gus Manger**: ""I will resign immediately to br..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Gus Manger**: ""Thank you, Mr. President. It wa..." |
| `[344]` | **""I don't want to see you ever again.""** | `[341]` **Gus Manger**: ""I will resign immediately to br..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[345]` **Gus Manger**: ""Yes, Mr. President."" |
| `[353]` | **""Family comes first. I understand.""** | `[352]` **Gus Manger**: ""I will be handing you my resign..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Gus Manger**: ""Thank you for understanding, Mr..." |
| `[354]` | **""Thank you, Gus. It was nice to have you here.""** | `[352]` **Gus Manger**: ""I will be handing you my resign..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[358]` **Gus Manger**: ""Thank you, Mr. President. It wa..." |
| `[355]` | **""Let's keep in touch about more potential investments.""** | `[352]` **Gus Manger**: ""I will be handing you my resign..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Gus Manger**: ""Of course, Mr. President. I wil..." |
| `[360]` | **""I have no choice but to accept your resignations.""** | `[619]` **Narrator**: "I looked at their determined faces." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[362]` **Narrator**: "The ministers left and I took a ..." |
| `[361]` | **""I accept your resignations. Now get out of my face.""** | `[619]` **Narrator**: "I looked at their determined faces." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[362]` **Narrator**: "The ministers left and I took a ..." |
| `[409]` | **""Let's just calm down. We can work something out.""** | `[403]` **Paskal Beniwoll**: ""I'm here to let you know that I..."<br>`[405]` **Gus Manger**: ""I'm here to let you know that I..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[454]` **Ciara Walda**: ""I'm afraid I can't calm down. I..."<br>`[453]` **Nia Morgna**: ""I'm afraid I can't calm down. I..."<br>*(oraz 1 innych odgałęzień)* |
| `[460]` | **""I see. You are trying to sabotage me before the elections.""** | `[403]` **Paskal Beniwoll**: ""I'm here to let you know that I..."<br>`[405]` **Gus Manger**: ""I'm here to let you know that I..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[464]` **Ciara Walda**: ""That is not why. I simply can n..."<br>`[463]` **Nia Morgna**: ""That is not why. I simply can n..."<br>*(oraz 1 innych odgałęzień)* |
| `[461]` | **""Your resignation? What is the meaning of this?""** | `[403]` **Paskal Beniwoll**: ""I'm here to let you know that I..."<br>`[405]` **Gus Manger**: ""I'm here to let you know that I..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[471]` **Ciara Walda**: ""Exactly what it looks like. I a..."<br>`[470]` **Nia Morgna**: ""Exactly what it looks like. I a..."<br>*(oraz 1 innych odgałęzień)* |
| `[488]` | **""Talk to me. What can I do? How can I help you better?""** | `[404]` **Symon Holl**: ""Exactly what it looks like. I a..."<br>`[435]` **Paskal Beniwoll**: ""I'm afraid I can't calm down. I..."<br>*(oraz 13 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[400]` **Ciara Walda**: ""I'm sorry but I have already ma..."<br>`[399]` **Nia Morgna**: ""I'm sorry but I have already ma..."<br>*(oraz 1 innych odgałęzień)* |
| `[525]` | **""You're betraying me, then.""** | `[404]` **Symon Holl**: ""Exactly what it looks like. I a..."<br>`[435]` **Paskal Beniwoll**: ""I'm afraid I can't calm down. I..."<br>*(oraz 13 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[415]` **Ciara Walda**: ""This is nothing as grandiose as..."<br>`[414]` **Nia Morgna**: ""This is nothing as grandiose as..."<br>*(oraz 1 innych odgałęzień)* |
| `[526]` | **""But why? What are your reasons?""** | `[404]` **Symon Holl**: ""Exactly what it looks like. I a..."<br>`[435]` **Paskal Beniwoll**: ""I'm afraid I can't calm down. I..."<br>*(oraz 13 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Ciara Walda**: ""I suppose I owe you an explanat..."<br>`[422]` **Nia Morgna**: ""I suppose I owe you an explanat..."<br>*(oraz 1 innych odgałęzień)* |
| `[527]` | **""You are fools if you can't see the real threats. I don't need fools in my cabinet.""** | `[549]` **Ciara Walda**: ""What's next? You are going to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[528]` **Ciara Walda**: ""There is only one threat in Sor..." |
| `[530]` | **""I was going to announce it to the cabinet at one point.""** | `[529]` **Ciara Walda**: ""What is most upsetting is the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[538]` **Ciara Walda**: ""Can you not even see that's not..." |
| `[531]` | **""I did what I have done in order to protect this country.""** | `[529]` **Ciara Walda**: ""What is most upsetting is the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[540]` **Ciara Walda**: ""No. You did what you have done ..." |
| `[532]` | **""Enough. If you don't have what it takes to better this country, then you don't de..."** | `[529]` **Ciara Walda**: ""What is most upsetting is the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[544]` **Ciara Walda**: ""You have completely changed. I ..." |
| `[547]` | **""Surely you jest! I did all I did for Sordland and Sordland alone!""** | `[549]` **Ciara Walda**: ""What's next? You are going to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[555]` **Ciara Walda**: ""Your puppeteers have you so bra..." |
| `[556]` | **""A King? That does sound nice, doesn't it?""** | `[549]` **Ciara Walda**: ""What's next? You are going to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[536]` **Ciara Walda**: ""I have absolutely no words."" |
| `[566]` | **""I was going to announce it to the cabinet at some point.""** | `[563]` **Nia Morgna**: ""What is most upsetting is the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[569]` **Nia Morgna**: ""Can you not even see that's not..." |
| `[567]` | **""I did what I have done in order to protect this country.""** | `[563]` **Nia Morgna**: ""What is most upsetting is the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[570]` **Nia Morgna**: ""No. You did what you have done ..." |
| `[568]` | **""Enough. If you don't have what it takes to improve this country, then you don't d..."** | `[563]` **Nia Morgna**: ""What is most upsetting is the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[571]` **Nia Morgna**: ""You have completely changed. I ..." |
| `[577]` | **""I was going to announce it to the cabinet at one point.""** | `[574]` **Paskal Beniwoll**: ""What is most upsetting is the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[580]` **Paskal Beniwoll**: ""Unfortunately, that is not the ..." |
| `[578]` | **""I did what I have done in order to protect this country.""** | `[574]` **Paskal Beniwoll**: ""What is most upsetting is the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[581]` **Paskal Beniwoll**: ""This seems to serve the positio..." |
| `[579]` | **""Enough. If you don't have what it takes to improve this country, then you don't d..."** | `[574]` **Paskal Beniwoll**: ""What is most upsetting is the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[582]` **Paskal Beniwoll**: ""You have changed, Mr. President."" |
| `[591]` | **""Presidential power must be maintained in a country like Sordland. Why don't you u..."** | `[588]` **Ciara Walda**: ""Or about how you deceived your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[589]` **Ciara Walda**: ""You will reform the country by ..." |
| `[593]` | **""I will not stand by while you accuse me of treachery. Get out.""** | `[588]` **Ciara Walda**: ""Or about how you deceived your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[590]` **Ciara Walda**: ""Not until we said our final wor..." |
| `[594]` | **""Deceived? I brought reforms when no one else could.""** | `[588]` **Ciara Walda**: ""Or about how you deceived your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[592]` **Ciara Walda**: ""By giving yourself more power? ..." |
| `[599]` | **""Presidential power must be maintained in a country like Sordland. Why don't you u..."** | `[596]` **Nia Morgna**: ""Or about how you deceived your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[597]` **Nia Morgna**: ""You will reform the country by ..." |
| `[601]` | **""I will not stand by while you accuse me of treachery. Get out.""** | `[596]` **Nia Morgna**: ""Or about how you deceived your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[598]` **Nia Morgna**: ""Not until we say our final words."" |
| `[602]` | **""Deceived? I brought reforms when no one else could.""** | `[596]` **Nia Morgna**: ""Or about how you deceived your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[600]` **Nia Morgna**: ""By giving yourself more power? ..." |
| `[606]` | **""You are fools if you can't see the real threats. I don't need fools in my cabinet.""** | `[610]` **Nia Morgna**: ""What's next? You are going to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[607]` **Nia Morgna**: ""There is only one threat in Sor..." |
| `[609]` | **""Surely you jest! I did all I did for Sordland and Sordland alone!""** | `[610]` **Nia Morgna**: ""What's next? You are going to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[611]` **Nia Morgna**: ""Your puppeteers have you so bra..." |
| `[612]` | **""A King? That does sound nice, doesn't it?""** | `[610]` **Nia Morgna**: ""What's next? You are going to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[608]` **Nia Morgna**: ""I have absolutely no words."" |
| `[637]` | **""I accept your resignation. Now get out of my face.""** | `[632]` **Narrator**: "I looked at Ciara's determined f..."<br>`[633]` **Narrator**: "I looked at Nia's determined face."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `UpdateCharacterTitle("Ciara Walda","Former Minister");`<br>`UpdateCharacterTitle("Nia Morgna","Former Minister");`<br>*(+1 skryptów)* | `[652]` **Narrator**: "Ciara and Lucian left and I took..."<br>`[654]` **Narrator**: "Nia and Lucian left and I took a..." |
| `[638]` | **""I have no choice but to accept your resignation.""** | `[632]` **Narrator**: "I looked at Ciara's determined f..."<br>`[633]` **Narrator**: "I looked at Nia's determined face."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `UpdateCharacterTitle("Ciara Walda","Former Minister");`<br>`UpdateCharacterTitle("Nia Morgna","Former Minister");`<br>*(+1 skryptów)* | `[652]` **Narrator**: "Ciara and Lucian left and I took..."<br>`[654]` **Narrator**: "Nia and Lucian left and I took a..." |
| `[759]` | **""Deceived? I brought reforms when no one else could.""** | `[768]` **Nia Morgna**: ""Or about how you deceived your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[760]` **Nia Morgna**: ""By giving yourself more power? ..." |
| `[772]` | **""I will not stand by while you accuse me of treachery. Get out.""** | `[768]` **Nia Morgna**: ""Or about how you deceived your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[775]` **Nia Morgna**: ""Not until we say our final words."" |
| `[773]` | **""Presidential power must be maintained in a country like Sordland. Why don't you u..."** | `[768]` **Nia Morgna**: ""Or about how you deceived your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[774]` **Nia Morgna**: ""You will reform the country by ..." |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true )"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_Resignations_Ciara = true;..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_Resignations_Gus = true; B..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations += 1;
BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations += 1;
BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations += 1;
BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_Resignations_Nia = true; B..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations += 1;
BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_PaskalBeniwoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_PaskalBeniwoll == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_PaskalBeniwoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_PaskalBeniwoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_Resignations_Paskal = true..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_PaskalBeniwoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations += 1;
BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] = Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations >= 3 && Ba..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_Resignations_Symon = true;..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations >= 3 && Ba..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "The door opened and Lucian entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: ""Mr. President. There is a problem.""*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> ""Mr. President. There is a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: ""What kind of a problem?""*)
  - -> `[25]` (*Player: ""What is it now?""*)
  - -> `[27]` (*Player: ""And?""*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""What is it now?""]** — Mówca: **Player**
> ""What is it now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""What kind of a problem?""]** — Mówca: **Player**
> ""What kind of a problem?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""And?""]** — Mówca: **Player**
> ""And?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn10_A_NumberOfResignations > 1)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucian Galade: ""Some cabinet members said they wanted to speak to you ur..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn10_A_NumberOfResignations > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""Some cabinet members said they wanted to speak to you urgently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucian Galade: ""They are in the White Room.""*)

### Węzeł `[32]`
Mówca: **Lucian Galade**
> ""They are in the White Room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: ""Please follow me.""*)

### Węzeł `[33]`
Mówca: **Lucian Galade**
> ""Please follow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "We started walking."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lucian Galade: ""Mrs. Walda wants to speak with you.""*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: ""Mr. Manger wants to speak with you.""*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lucian Galade: ""Mrs. Morgna wants to speak with you.""*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_PaskalBeniwoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_PaskalBeniwoll == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_PaskalBeniwoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_PaskalBeniwoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""Mr. Beniwoll wants to speak with you.""*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_PaskalBeniwoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lucian Galade: ""Mr. Holl wants to speak with you.""*)

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""Mrs. Walda wants to speak with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucian Galade: ""She is in the White Room.""*)

### Węzeł `[47]`
Mówca: **Lucian Galade**
> ""Mr. Manger wants to speak with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucian Galade: ""He is in the White Room.""*)

### Węzeł `[48]`
Mówca: **Lucian Galade**
> ""Mrs. Morgna wants to speak with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucian Galade: ""She is in the White Room.""*)

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""Mr. Beniwoll wants to speak with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucian Galade: ""He is in the White Room.""*)

### Węzeł `[50]`
Mówca: **Lucian Galade**
> ""Mr. Holl wants to speak with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucian Galade: ""He is in the White Room.""*)

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""She is in the White Room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: ""Please follow me.""*)

### Węzeł `[52]`
Mówca: **Lucian Galade**
> ""He is in the White Room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: ""Please follow me.""*)

### Węzeł `[53]`
Mówca: **Narrator**
> "We started walking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: ""Do you know what it's about?""*)
  - -> `[54]` (*Player: ""What's so urgent?""*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""What's so urgent?""]** — Mówca: **Player**
> ""What's so urgent?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: ""I was just told to come get you, sir.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Do you know what it's about?""]** — Mówca: **Player**
> ""Do you know what it's about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: ""I was just told to come get you, sir.""*)

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""I was just told to come get you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "I opened the doors and we entered the White Room. I looke..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "I opened the doors and we entered the White Room. I looked around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true && BaseGame.Resigned..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true && BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true && BaseGame.Resigned..."*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true && BaseGame.Resign..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true && BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true  and  Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Ciara and Nia were standing near the table with their arm..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true && BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true  and  Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[61]`
Mówca: **Narrator**
> "Ciara and Nia were standing near the table with their arms crossed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Resigned_..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Ciara was standing near the table with her arms crossed."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Nia was standing near the table with her arms crossed."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Resigned_..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Ciara was standing near the table with her arms crossed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Resigned_..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "Nia was standing near the table with her arms crossed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Resigned_..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Resigned_..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true && BaseGame.Resigne..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "Symon and Gus were seated. They looked at each other."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true && BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Symon was sitting, playing with the pen in front of him."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Gus was sitting, playing with the pen in front of him."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[79]`
Mówca: **Narrator**
> "Symon and Gus were seated. They looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Symon was sitting, playing with the pen in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[81]`
Mówca: **Narrator**
> "Gus was sitting, playing with the pen in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[82]`
Mówca: **Narrator**
> "Paskal looked incredibly stressed. He wiped off his sweat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""What is going on here?""*)
  - -> `[86]` (*Player: ""Good evening.""*)
  - -> `[88]` (*Player: ""So. Why did you call me here?""*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_PaskalBeniwoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_PaskalBeniwoll == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_PaskalBeniwoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_PaskalBeniwoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Paskal looked incredibly stressed. He wiped off his sweat."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_PaskalBeniwoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""What is going on here?""*)
  - -> `[86]` (*Player: ""Good evening.""*)
  - -> `[88]` (*Player: ""So. Why did you call me here?""*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Good evening.""]** — Mówca: **Player**
> ""Good evening.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[82]` (Narrator), `[79]` (Narrator), `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""What is going on here?""]** — Mówca: **Player**
> ""What is going on here?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[82]` (Narrator), `[79]` (Narrator), `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""So. Why did you call me here?""]** — Mówca: **Player**
> ""So. Why did you call me here?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[82]` (Narrator), `[79]` (Narrator), `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn10_A_NumberOfResignations > 1)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn10_A_NumberOfResignations > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Nia Morgna: ""Mr. President. I'll cut to the chase.""*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Gus Manger: ""Mr. President.""*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Paskal Beniwoll: ""Mr. President.""*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Ciara Walda: ""Mr. President. I'll cut to the chase.""*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Symon Holl: ""Mr. President.""*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[104]`
Mówca: **Ciara Walda**
> ""Mr. President. I'll cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Ciara Walda: ""We are here to let you know that we are handing you our ..."*)

### Węzeł `[105]`
Mówca: **Ciara Walda**
> ""We are here to let you know that we are handing you our resignations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: ""Your resignations? What is the meaning of this?""*)
  - -> `[115]` (*Player: ""I see. You are trying to sabotage me before the elections.""*)
  - -> `[116]` (*Player: ""Let's all calm down. We can work something out.""*)

### Węzeł `[106]`
Mówca: **Nia Morgna**
> ""We are here to let you know that we are handing you our resignations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: ""Your resignations? What is the meaning of this?""*)
  - -> `[115]` (*Player: ""I see. You are trying to sabotage me before the elections.""*)
  - -> `[116]` (*Player: ""Let's all calm down. We can work something out.""*)

### Węzeł `[107]`
Mówca: **Nia Morgna**
> ""Mr. President. I'll cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Nia Morgna: ""We are here to let you know that we are handing you our ..."*)

### Węzeł `[108]`
Mówca: **Symon Holl**
> ""We are here to let you know that we are handing you our resignations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: ""Your resignations? What is the meaning of this?""*)
  - -> `[115]` (*Player: ""I see. You are trying to sabotage me before the elections.""*)
  - -> `[116]` (*Player: ""Let's all calm down. We can work something out.""*)

### Węzeł `[109]`
Mówca: **Symon Holl**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Symon Holl: ""We are here to let you know that we are handing you our ..."*)

### Węzeł `[110]`
Mówca: **Gus Manger**
> ""We are here to let you know that we are handing you our resignations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: ""Your resignations? What is the meaning of this?""*)
  - -> `[115]` (*Player: ""I see. You are trying to sabotage me before the elections.""*)
  - -> `[116]` (*Player: ""Let's all calm down. We can work something out.""*)

### Węzeł `[111]`
Mówca: **Gus Manger**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Gus Manger: ""We are here to let you know that we are handing you our ..."*)

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
> ""We are here to let you know that we are handing you our resignations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: ""Your resignations? What is the meaning of this?""*)
  - -> `[115]` (*Player: ""I see. You are trying to sabotage me before the elections.""*)
  - -> `[116]` (*Player: ""Let's all calm down. We can work something out.""*)

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Paskal Beniwoll: ""We are here to let you know that we are handing you our ..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Your resignations? What is the meaning of this?""]** — Mówca: **Player**
> ""Your resignations? What is the meaning of this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Ciara Walda), `[106]` (Nia Morgna), `[108]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[115]`
**[WYBÓR GRACZA: ""I see. You are trying to sabotage me before the elections.""]** — Mówca: **Player**
> ""I see. You are trying to sabotage me before the elections.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Ciara Walda), `[106]` (Nia Morgna), `[108]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""Let's all calm down. We can work something out.""]** — Mówca: **Player**
> ""Let's all calm down. We can work something out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Ciara Walda), `[106]` (Nia Morgna), `[108]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
> ""I'm afraid we can't calm down. I'm sorry, Mr. President but this is the end of the road. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Gus Manger: ""I'm afraid we can't calm down. I'm sorry, Mr. President ..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Paskal Beniwoll: ""I'm afraid we can't calm down. I'm sorry, Mr. President ..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Sym..."*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_S..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Symon Holl: ""I'm afraid we can't calm down. I'm sorry, Mr. President ..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[124]`
Mówca: **Symon Holl**
> ""I'm afraid we can't calm down. I'm sorry, Mr. President but this is the end of the road. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[125]`
Mówca: **Nia Morgna**
> ""I'm afraid we can't calm down. I'm sorry, Mr. President but this is the end of the road. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[126]`
Mówca: **Ciara Walda**
> ""I'm afraid we can't calm down. I'm sorry, Mr. President but this is the end of the road. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[127]`
Mówca: **Gus Manger**
> ""I'm afraid we can't calm down. I'm sorry, Mr. President but this is the end of the road. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Ciara Walda: ""I'm afraid we can't calm down. I'm sorry, Mr. President ..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Nia Morgna: ""I'm afraid we can't calm down. I'm sorry, Mr. President ..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Sym..."*)

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
> ""That is not why. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Gus Manger: ""That is not why. We simply can not go on anymore after w..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Paskal Beniwoll: ""That is not why. We simply can not go on anymore after w..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Sym..."*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_S..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Symon Holl: ""That is not why. We simply can not go on anymore after w..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[141]`
Mówca: **Symon Holl**
> ""That is not why. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[142]`
Mówca: **Nia Morgna**
> ""That is not why. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[143]`
Mówca: **Ciara Walda**
> ""That is not why. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[144]`
Mówca: **Gus Manger**
> ""That is not why. We simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Ciara Walda: ""That is not why. We simply can not go on anymore after w..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Nia Morgna: ""That is not why. We simply can not go on anymore after w..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Sym..."*)

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
> ""Exactly what it looks like. We are resigning from our positions in the cabinet. We have our own reasons, but we simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Gus Manger: ""Exactly what it looks like. We are resigning from our po..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Paskal Beniwoll: ""Exactly what it looks like. We are resigning from our po..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Sym..."*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_S..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Symon Holl: ""Exactly what it looks like. We are resigning from our po..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[158]`
Mówca: **Symon Holl**
> ""Exactly what it looks like. We are resigning from our positions in the cabinet. We have our own reasons, but we simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[159]`
Mówca: **Nia Morgna**
> ""Exactly what it looks like. We are resigning from our positions in the cabinet. We have our own reasons, but we simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[160]`
Mówca: **Ciara Walda**
> ""Exactly what it looks like. We are resigning from our positions in the cabinet. We have our own reasons, but we simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[161]`
Mówca: **Gus Manger**
> ""Exactly what it looks like. We are resigning from our positions in the cabinet. We have our own reasons, but we simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""But why? What are your reasons?""*)
  - -> `[168]` (*Player: ""You're betraying me, then.""*)
  - -> `[170]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Ciara Walda: ""Exactly what it looks like. We are resigning from our po..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Nia Morgna: ""Exactly what it looks like. We are resigning from our po..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Sym..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA: ""You're betraying me, then.""]** — Mówca: **Player**
> ""You're betraying me, then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Paskal Beniwoll), `[124]` (Symon Holl), `[125]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""But why? What are your reasons?""]** — Mówca: **Player**
> ""But why? What are your reasons?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Paskal Beniwoll), `[124]` (Symon Holl), `[125]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""Talk to me. What can I do? How can I help you better?""]** — Mówca: **Player**
> ""Talk to me. What can I do? How can I help you better?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Paskal Beniwoll), `[124]` (Symon Holl), `[125]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Ciara Walda: ""I'm sorry, but everyone in this room has already made th..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Sym..."*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_S..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Symon Holl: ""I'm sorry, but everyone in this room has already made th..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[177]`
Mówca: **Symon Holl**
> ""I'm sorry, but everyone in this room has already made their decision and we won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[178]`
Mówca: **Nia Morgna**
> ""I'm sorry, but everyone in this room has already made their decision and we won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[179]`
Mówca: **Ciara Walda**
> ""I'm sorry, but everyone in this room has already made their decision and we won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[180]`
Mówca: **Gus Manger**
> ""I'm sorry, but everyone in this room has already made their decision and we won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Nia Morgna: ""I'm sorry, but everyone in this room has already made th..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Sym..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Gus Manger: ""I'm sorry, but everyone in this room has already made th..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Paskal Beniwoll: ""I'm sorry, but everyone in this room has already made th..."*)

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
> ""I'm sorry, but everyone in this room has already made their decision and we won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Ciara Walda: ""This is nothing as grandiose as a betrayal but...""*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Sym..."*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_S..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Symon Holl: ""This is nothing as grandiose as a betrayal but...""*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[194]`
Mówca: **Symon Holl**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[195]`
Mówca: **Nia Morgna**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[196]`
Mówca: **Ciara Walda**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[197]`
Mówca: **Gus Manger**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Nia Morgna: ""This is nothing as grandiose as a betrayal but...""*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Sym..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Gus Manger: ""This is nothing as grandiose as a betrayal but...""*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Paskal Beniwoll: ""This is nothing as grandiose as a betrayal but...""*)

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Ciara Walda: ""I suppose we owe your our reasons.""*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[208]`
Mówca: **Symon Holl**
> ""I suppose we owe your our reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[209]`
Mówca: **Nia Morgna**
> ""I suppose we owe your our reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[210]`
Mówca: **Ciara Walda**
> ""I suppose we owe your our reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Nia Morgna: ""I suppose we owe your our reasons.""*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Sym..."*)

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
> ""I suppose we owe your our reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Sym..."*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_S..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Symon Holl: ""I suppose we owe your our reasons.""*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Gus Manger: ""I suppose we owe your our reasons.""*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Paskal Beniwoll: ""I suppose we owe your our reasons.""*)

### Węzeł `[221]`
Mówca: **Gus Manger**
> ""I suppose we owe your our reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter ==..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Ciara Walda: ""How could you create the Secret State Police? How dare y..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_..."*)

### Węzeł `[225]`
Mówca: **Ciara Walda**
> ""I don't even know why I joined the cabinet at this point. You managed to bring education in this country 20 years back in time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_PresiPower_Default_GenderEqualityInEduca..."*)

### Węzeł `[226]`
Mówca: **Ciara Walda**
> ""How could you create the Secret State Police? How dare you attack the very values this country stands on? You will go down in history as a dictator.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Nia Morgna: ""This is a direct breach of the democratic process. You a..."*)

### Węzeł `[227]`
Mówca: **Nia Morgna**
> ""This is a direct breach of the democratic process. You are responsible for destroying the lives of the representatives that this country has picked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Paskal Beniwoll: ""What is most upsetting is the fact that we would not kno..."*)

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
> ""What is most upsetting is the fact that we would not know any of this if not for these leaks. Your very own cabinet did not know of this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player: ""I was going to announce it to the cabinet at some point.""*)
  - -> `[230]` (*Player: ""I did what I have done in order to protect this country.""*)
  - -> `[231]` (*Player: ""Enough. If you don't have what it takes to improve this ..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA: ""I was going to announce it to the cabinet at some point.""]** — Mówca: **Player**
> ""I was going to announce it to the cabinet at some point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Nia Morgna: ""Can you not even see that's not the problem? You are bey..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA: ""I did what I have done in order to protect this country.""]** — Mówca: **Player**
> ""I did what I have done in order to protect this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Nia Morgna: ""No. You did what you have done to protect yourself!""*)

### Węzeł `[231]`
**[WYBÓR GRACZA: ""Enough. If you don't have what it takes to improve this country, then you don't deserve to be in my cabinet.""]** — Mówca: **Player**
> ""Enough. If you don't have what it takes to improve this country, then you don't deserve to be in my cabinet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Nia Morgna: ""You have completely changed. I don't know how I could've..."*)

### Węzeł `[232]`
Mówca: **Nia Morgna**
> ""Can you not even see that's not the problem? You are beyond hope and salvation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Ciara Walda: ""I guess this is what power does to people.""*)

### Węzeł `[233]`
Mówca: **Nia Morgna**
> ""No. You did what you have done to protect yourself!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Ciara Walda: ""I guess this is what power does to people.""*)

### Węzeł `[234]`
Mówca: **Nia Morgna**
> ""You have completely changed. I don't know how I could've ever believed in you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Ciara Walda: ""I guess this is what power does to people.""*)

### Węzeł `[235]`
Mówca: **Ciara Walda**
> ""I guess this is what power does to people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Paskal Beniwoll: ""I refuse to work under such circumstances.""*)

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
> ""I refuse to work under such circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn04_PSnW_Education_Progressive == false && B..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn04_PSnW_Education_Progressive == false && BaseGame.Turn03_EnT_Education_Budget_Decrease == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn04_PSnW_Education_Progressive == false && B..."*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn04_PSnW_Education_Progressive == false &&..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn04_PSnW_Education_Progressive == false && BaseGame.Turn03_EnT_Education_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == false  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Ciara Walda: ""I don't even know why I joined the cabinet at this point..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn04_PSnW_Education_Progressive == false && BaseGame.Turn03_EnT_Education_Budget_Decrease == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == false  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_PresiPower_Default_GenderEqualityInEduca..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == false && BaseGame.WomensRightCommission == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_PresiPower_Default_GenderEqualityInEduca..."*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_PresiPower_Default_GenderEqualityInEdu..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == false && BaseGame.WomensRightCommission == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Ciara Walda: ""Thanks to you, gender inequality is at an all-time high ..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == false && BaseGame.WomensRightCommission == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player: ""We can fix our mistakes if we work together.""*)
  - -> `[285]` (*Player: ""There were other high priority issues we had to handle.""*)
  - -> `[284]` (*Player: ""And who is at fault there? Don't blame everything on me.""*)

### Węzeł `[246]`
Mówca: **Ciara Walda**
> ""Thanks to you, gender inequality is at an all-time high in Sordland. We are falling way behind modern countries and I don't see that changing anytime soon with leadership like this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player: ""We can fix our mistakes if we work together.""*)
  - -> `[285]` (*Player: ""There were other high priority issues we had to handle.""*)
  - -> `[284]` (*Player: ""And who is at fault there? Don't blame everything on me.""*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Pol..."*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.P..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Threshold_15"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Ciara Walda: ""Why don't we talk about the permanent *emergency* situat..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[253]`
Mówca: **Nia Morgna**
> ""Why don't we talk a bit about your *reforms*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Nia Morgna: ""Or about how you deceived your cabinet and your entire c..."*)

### Węzeł `[254]`
Mówca: **Nia Morgna**
> ""What's next? You are going to declare yourself the King of Sordland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player: ""You are fools if you can't see the real threats. I don't..."*)
  - -> `[267]` (*Player: ""Surely you jest! I did all I did for Sordland and Sordla..."*)
  - -> `[266]` (*Player: ""A King? That does sound nice, doesn't it?""*)

### Węzeł `[255]`
Mówca: **Nia Morgna**
> ""Or about how you deceived your cabinet and your entire country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player: ""Deceived? I brought reforms when no one else could.""*)
  - -> `[258]` (*Player: ""Presidential power must be maintained in a country like ..."*)
  - -> `[256]` (*Player: ""I will not stand by while you accuse me of treachery. Ge..."*)

### Węzeł `[256]`
**[WYBÓR GRACZA: ""I will not stand by while you accuse me of treachery. Get out.""]** — Mówca: **Player**
> ""I will not stand by while you accuse me of treachery. Get out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Nia Morgna: ""Not until we say our final words.""*)

### Węzeł `[257]`
**[WYBÓR GRACZA: ""Deceived? I brought reforms when no one else could.""]** — Mówca: **Player**
> ""Deceived? I brought reforms when no one else could.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Nia Morgna: ""By giving yourself more power? By exploiting the law? Yo..."*)

### Węzeł `[258]`
**[WYBÓR GRACZA: ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""]** — Mówca: **Player**
> ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Nia Morgna: ""You will reform the country by turning it into a dictato..."*)

### Węzeł `[259]`
Mówca: **Nia Morgna**
> ""By giving yourself more power? By exploiting the law? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[260]`
Mówca: **Nia Morgna**
> ""You will reform the country by turning it into a dictatorship? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[261]`
Mówca: **Nia Morgna**
> ""Not until we say our final words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[262]`
Mówca: **Ciara Walda**
> ""Why don't we talk about the permanent *emergency* situation that you have put our country under?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Ciara Walda: ""What emergency? You are just creating enemies out of thi..."*)

### Węzeł `[263]`
Mówca: **Ciara Walda**
> ""What emergency? You are just creating enemies out of thin air to firm your grasp on the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Ciara Walda: ""It's all a ploy to grab more and more power.""*)

### Węzeł `[264]`
Mówca: **Ciara Walda**
> ""It's all a ploy to grab more and more power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Nia Morgna: ""What's next? You are going to declare yourself the King ..."*)

### Węzeł `[265]`
**[WYBÓR GRACZA: ""You are fools if you can't see the real threats. I don't need fools in my cabinet.""]** — Mówca: **Player**
> ""You are fools if you can't see the real threats. I don't need fools in my cabinet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Nia Morgna: ""There is only one threat in Sordland and that's you.""*)

### Węzeł `[266]`
**[WYBÓR GRACZA: ""A King? That does sound nice, doesn't it?""]** — Mówca: **Player**
> ""A King? That does sound nice, doesn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Nia Morgna: ""I have absolutely no words.""*)

### Węzeł `[267]`
**[WYBÓR GRACZA: ""Surely you jest! I did all I did for Sordland and Sordland alone!""]** — Mówca: **Player**
> ""Surely you jest! I did all I did for Sordland and Sordland alone!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Nia Morgna: ""Your puppeteers have you so brainwashed that you forgot ..."*)

### Węzeł `[268]`
Mówca: **Nia Morgna**
> ""I have absolutely no words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[269]`
Mówca: **Nia Morgna**
> ""Your puppeteers have you so brainwashed that you forgot you have a mind of your own!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[270]`
Mówca: **Nia Morgna**
> ""There is only one threat in Sordland and that's you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_PaskalBeniwoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_PaskalBeniwoll == true)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_PaskalBeniwoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_PaskalBeniwoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "BaseGame.Pandemic_Severity >= 1"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_PaskalBeniwoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
> ""The government has not done enough and now we have polio cases popping up everywhere around Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Paskal Beniwoll: ""Even in Holsord.""*)

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
> ""Even in Holsord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Paskal Beniwoll: ""Who knows? Soon it might be you or your own family.""*)

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
> ""Who knows? Soon it might be you or your own family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Paskal Beniwoll: ""If you are not going to take responsibility for it, then..."*)

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
> ""If you are not going to take responsibility for it, then I will as the Minister of Health.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player: ""You are taking responsibility by resigning? That doesn't..."*)
  - -> `[280]` (*Player: ""This is because you have brought this to my attention so..."*)
  - -> `[279]` (*Player: ""Please, Paskal. We need you in the government to solve t..."*)

### Węzeł `[278]`
**[WYBÓR GRACZA: ""You are taking responsibility by resigning? That doesn't even make sense.""]** — Mówca: **Player**
> ""You are taking responsibility by resigning? That doesn't even make sense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Paskal Beniwoll: ""I am resigning because someone in the government has to ..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA: ""Please, Paskal. We need you in the government to solve this crisis once and for all.""]** — Mówca: **Player**
> ""Please, Paskal. We need you in the government to solve this crisis once and for all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Paskal Beniwoll: ""I'm sorry, Mr. President.""*)

### Węzeł `[280]`
**[WYBÓR GRACZA: ""This is because you have brought this to my attention so late.""]** — Mówca: **Player**
> ""This is because you have brought this to my attention so late.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Paskal Beniwoll: ""Please don't blame me, Mr. President. Instead, blame you..."*)

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
> ""I am resigning because someone in the government has to admit that we have made mistakes. Our people are dying, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Paskal Beniwoll: ""We are clearly not fit to lead. Otherwise we would've do..."*)

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
> ""We are clearly not fit to lead. Otherwise we would've done something about this situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[283]`
**[WYBÓR GRACZA: ""We can fix our mistakes if we work together.""]** — Mówca: **Player**
> ""We can fix our mistakes if we work together.""
- **Wymagania odblokowania (kod gry):** `((Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)) == false` AND `((Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == false  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true)) == false` AND `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Kontekst wejściowy (poprzednik):** `[246]` (Ciara Walda), `[225]` (Ciara Walda), `[268]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Ciara Walda: ""It's too late.""*)

### Węzeł `[284]`
**[WYBÓR GRACZA: ""And who is at fault there? Don't blame everything on me.""]** — Mówca: **Player**
> ""And who is at fault there? Don't blame everything on me.""
- **Wymagania odblokowania (kod gry):** `((Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)) == false` AND `((Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == false  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true)) == false` AND `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Kontekst wejściowy (poprzednik):** `[246]` (Ciara Walda), `[225]` (Ciara Walda), `[268]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Ciara Walda: ""We are all to blame because we believed in you! Another ..."*)

### Węzeł `[285]`
**[WYBÓR GRACZA: ""There were other high priority issues we had to handle.""]** — Mówca: **Player**
> ""There were other high priority issues we had to handle.""
- **Wymagania odblokowania (kod gry):** `((Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)) == false` AND `((Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == false  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true)) == false` AND `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Kontekst wejściowy (poprzednik):** `[246]` (Ciara Walda), `[225]` (Ciara Walda), `[268]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Ciara Walda: ""What is more important than education? Attending unneces..."*)

### Węzeł `[286]`
Mówca: **Ciara Walda**
> ""We are all to blame because we believed in you! Another disappointment in our country's history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[287]`
Mówca: **Ciara Walda**
> ""What is more important than education? Attending unnecessary speeches? Shaking hands with priests?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[288]`
Mówca: **Ciara Walda**
> ""It's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
> ""Please don't blame me, Mr. President. Instead, blame yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Paskal Beniwoll: ""I brought you the data as soon as I could but you chose ..."*)

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
> ""I brought you the data as soon as I could but you chose not to act on it. You are at fault here, not me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
> ""I'm sorry, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Paskal Beniwoll: ""I have already decided and nothing will turn me back fro..."*)

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
> ""I have already decided and nothing will turn me back from my decision. I have a duty to my people and I failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[293]`
Mówca: **Symon Holl**
> ""I have failed my mission as the Minister of Economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Symon Holl: ""During our term, instead of stopping the recession, we h..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_Symon == true"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_Symon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_Symon == true"*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_Symon == true)"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_Symon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_Symon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Symon Holl: ""As you have requested, I have come to deliver my resigna..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_Symon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_Symon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishDepression == true)"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Symon Holl: ""I have failed my mission as the Minister of Economy.""*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishDepression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Symon Holl: ""I am afraid that I find myself too ideologically differe..."*)

### Węzeł `[303]`
Mówca: **Symon Holl**
> ""During our term, instead of stopping the recession, we have made it even worse and entered the 'Sordish Depression'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Symon Holl: ""I blame myself for this. I couldn't offer you better sol..."*)

### Węzeł `[304]`
Mówca: **Symon Holl**
> ""I blame myself for this. I couldn't offer you better solutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Symon Holl: ""I have proven that I am unfit to serve as the Minister o..."*)

### Węzeł `[305]`
Mówca: **Symon Holl**
> ""I have proven that I am unfit to serve as the Minister of Economy in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Symon Holl: ""I will resign at the end of our term.""*)

### Węzeł `[306]`
**[WYBÓR GRACZA: ""Good. At least you have some dignity.""]** — Mówca: **Player**
> ""Good. At least you have some dignity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Symon Holl: ""Thank you, Mr. President.""*)

### Węzeł `[307]`
**[WYBÓR GRACZA: ""Thank you. It's been a pleasure to work with you.""]** — Mówca: **Player**
> ""Thank you. It's been a pleasure to work with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Symon Holl: ""Likewise, Mr. President.""*)

### Węzeł `[308]`
**[WYBÓR GRACZA: ""Please don't do this, Symon. I am to blame, not you.""]** — Mówca: **Player**
> ""Please don't do this, Symon. I am to blame, not you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Symon Holl: ""I'm afraid things are already in motion, Mr. President.""*)

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
> ""I will hand you my resignation once our term is done, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[310]`
Mówca: **Symon Holl**
> ""I will resign at the end of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Player: ""Thank you. It's been a pleasure to work with you.""*)
  - -> `[308]` (*Player: ""Please don't do this, Symon. I am to blame, not you.""*)
  - -> `[306]` (*Player: ""Good. At least you have some dignity.""*)

### Węzeł `[311]`
Mówca: **Symon Holl**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[312]`
Mówca: **Symon Holl**
> ""I'm afraid things are already in motion, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[313]`
Mówca: **Symon Holl**
> ""Likewise, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[314]`
Mówca: **Symon Holl**
> ""I am afraid that I find myself too ideologically different to work as the Minister of Economy for this government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Symon Holl: ""The decisions we made have proven that to me.""*)

### Węzeł `[315]`
Mówca: **Symon Holl**
> ""The decisions we made have proven that to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Symon Holl: ""I know when to leave my seat.""*)

### Węzeł `[316]`
Mówca: **Symon Holl**
> ""I know when to leave my seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Symon Holl: ""I will resign at the end of our term.""*)

### Węzeł `[317]`
Mówca: **Symon Holl**
> ""I will resign at the end of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Player: ""Thank you. It's been a pleasure to work with you.""*)
  - -> `[320]` (*Player: ""Please don't do this, Symon. We can overcome our differe..."*)
  - -> `[319]` (*Player: ""Good. At least you have some dignity.""*)

### Węzeł `[318]`
Mówca: **Symon Holl**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[319]`
**[WYBÓR GRACZA: ""Good. At least you have some dignity.""]** — Mówca: **Player**
> ""Good. At least you have some dignity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Symon Holl: ""Thank you, Mr. President.""*)

### Węzeł `[320]`
**[WYBÓR GRACZA: ""Please don't do this, Symon. We can overcome our differences.""]** — Mówca: **Player**
> ""Please don't do this, Symon. We can overcome our differences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Symon Holl: ""I'm afraid things are already in motion, Mr. President.""*)

### Węzeł `[321]`
Mówca: **Symon Holl**
> ""Likewise, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[322]`
Mówca: **Symon Holl**
> ""I'm afraid things are already in motion, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[323]`
**[WYBÓR GRACZA: ""Thank you. It's been a pleasure to work with you.""]** — Mówca: **Player**
> ""Thank you. It's been a pleasure to work with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Symon Holl: ""Likewise, Mr. President.""*)

### Węzeł `[324]`
Mówca: **Symon Holl**
> ""As you have requested, I have come to deliver my resignation letter, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Symon Holl: ""I am sorry for not being up to your standards as the Min..."*)

### Węzeł `[325]`
Mówca: **Symon Holl**
> ""I am sorry for not being up to your standards as the Minister of Economy""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Symon Holl: ""I will resign at the end of our term.""*)

### Węzeł `[326]`
Mówca: **Symon Holl**
> ""I will resign at the end of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Player: ""Thank you. That will be all then.""*)
  - -> `[327]` (*Player: ""Good. Leave it on my desk on your way out.""*)

### Węzeł `[327]`
**[WYBÓR GRACZA: ""Good. Leave it on my desk on your way out.""]** — Mówca: **Player**
> ""Good. Leave it on my desk on your way out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[326]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Symon Holl: ""As you wish, Mr. President.""*)

### Węzeł `[328]`
**[WYBÓR GRACZA: ""Thank you. That will be all then.""]** — Mówca: **Player**
> ""Thank you. That will be all then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[326]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Symon Holl: ""Thank you, Mr. President.""*)

### Węzeł `[329]`
Mówca: **Symon Holl**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[330]`
Mówca: **Symon Holl**
> ""As you wish, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "I took a deep breath."*)

### Węzeł `[334]`
Mówca: **Gus Manger**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Gus Manger: ""I must say that I am very ashamed to be part of a scandal.""*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == ..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Gus Manger: ""Mr. President.""*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Gus Manger: ""Mr. President.""*)

### Węzeł `[338]`
Mówca: **Gus Manger**
> ""I must say that I am very ashamed to be part of a scandal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Gus Manger: ""I will not beg for my innocence.""*)

### Węzeł `[339]`
Mówca: **Gus Manger**
> ""I will not beg for my innocence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Gus Manger: ""My involvement in the Underhall Construction affair cann..."*)

### Węzeł `[340]`
Mówca: **Gus Manger**
> ""My involvement in the Underhall Construction affair cannot be denied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Gus Manger: ""I will resign immediately to bring no further shame to t..."*)

### Węzeł `[341]`
Mówca: **Gus Manger**
> ""I will resign immediately to bring no further shame to the administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Player: ""Thank you. Regardless, it was nice to have you here.""*)
  - -> `[344]` (*Player: ""I don't want to see you ever again.""*)
  - -> `[342]` (*Player: ""Very well. I understand.""*)

### Węzeł `[342]`
**[WYBÓR GRACZA: ""Very well. I understand.""]** — Mówca: **Player**
> ""Very well. I understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Gus Manger: ""Thank you for understanding, Mr. President.""*)

### Węzeł `[343]`
**[WYBÓR GRACZA: ""Thank you. Regardless, it was nice to have you here.""]** — Mówca: **Player**
> ""Thank you. Regardless, it was nice to have you here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Gus Manger: ""Thank you, Mr. President. It was nice to work with you.""*)

### Węzeł `[344]`
**[WYBÓR GRACZA: ""I don't want to see you ever again.""]** — Mówca: **Player**
> ""I don't want to see you ever again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Gus Manger: ""Yes, Mr. President.""*)

### Węzeł `[345]`
Mówca: **Gus Manger**
> ""Yes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "I took a deep breath."*)

### Węzeł `[346]`
Mówca: **Gus Manger**
> ""Thank you, Mr. President. It was nice to work with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "I took a deep breath."*)

### Węzeł `[347]`
Mówca: **Gus Manger**
> ""Thank you for understanding, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "I took a deep breath."*)

### Węzeł `[348]`
Mówca: **Gus Manger**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Gus Manger: ""I must say I have been a minister for a very long time n..."*)

### Węzeł `[349]`
Mówca: **Gus Manger**
> ""I must say I have been a minister for a very long time now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Cabinet_GusManger_Resign..."*)

### Węzeł `[350]`
Mówca: **Gus Manger**
> ""I have to look into other ventures in life and spend some time with my family. It's been a long time since I re-connected with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Gus Manger: ""I was very happy to be the part of the team you have cre..."*)

### Węzeł `[351]`
Mówca: **Gus Manger**
> ""I was very happy to be the part of the team you have created.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Gus Manger: ""I will be handing you my resignation at the end of our t..."*)

### Węzeł `[352]`
Mówca: **Gus Manger**
> ""I will be handing you my resignation at the end of our term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Player: ""Thank you, Gus. It was nice to have you here.""*)
  - -> `[355]` (*Player: ""Let's keep in touch about more potential investments.""*)
  - -> `[353]` (*Player: ""Family comes first. I understand.""*)

### Węzeł `[353]`
**[WYBÓR GRACZA: ""Family comes first. I understand.""]** — Mówca: **Player**
> ""Family comes first. I understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Gus Manger: ""Thank you for understanding, Mr. President.""*)

### Węzeł `[354]`
**[WYBÓR GRACZA: ""Thank you, Gus. It was nice to have you here.""]** — Mówca: **Player**
> ""Thank you, Gus. It was nice to have you here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Gus Manger: ""Thank you, Mr. President. It was nice to work with you.""*)

### Węzeł `[355]`
**[WYBÓR GRACZA: ""Let's keep in touch about more potential investments.""]** — Mówca: **Player**
> ""Let's keep in touch about more potential investments.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Gus Manger: ""Of course, Mr. President. I will be in touch.""*)

### Węzeł `[356]`
Mówca: **Gus Manger**
> ""Of course, Mr. President. I will be in touch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "I took a deep breath."*)

### Węzeł `[357]`
Mówca: **Gus Manger**
> ""Thank you for understanding, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "I took a deep breath."*)

### Węzeł `[358]`
Mówca: **Gus Manger**
> ""Thank you, Mr. President. It was nice to work with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "I took a deep breath."*)

### Węzeł `[359]`
Mówca: **Narrator**
> "I took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)

### Węzeł `[360]`
**[WYBÓR GRACZA: ""I have no choice but to accept your resignations.""]** — Mówca: **Player**
> ""I have no choice but to accept your resignations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[619]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "The ministers left and I took a seat alone in the White R..."*)

### Węzeł `[361]`
**[WYBÓR GRACZA: ""I accept your resignations. Now get out of my face.""]** — Mówca: **Player**
> ""I accept your resignations. Now get out of my face.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[619]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "The ministers left and I took a seat alone in the White R..."*)

### Węzeł `[362]`
Mówca: **Narrator**
> "The ministers left and I took a seat alone in the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Ciara Walda: ""Mr. President. I'll cut to the chase.""*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Nia Morgna: ""Mr. President. I'll cut to the chase.""*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[369]`
Mówca: **Nia Morgna**
> ""Mr. President. I'll cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Nia Morgna: ""I'm here to let you know that I will be handing you my r..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Symon Holl: ""Mr. President.""*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[373]`
Mówca: **Gus Manger**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Gus Manger: ""I'm here to let you know that I will be handing you my r..."*)

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Paskal Beniwoll: ""I'm here to let you know that I will be handing you my r..."*)

### Węzeł `[375]`
Mówca: **Ciara Walda**
> ""Mr. President. I'll cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Ciara Walda: ""I'm here to let you know that I will be handing you my r..."*)

### Węzeł `[376]`
Mówca: **Symon Holl**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_Symon == true"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Gus Manger: ""Mr. President.""*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Paskal Beniwoll: ""Mr. President.""*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Ciara Walda: ""I suppose we owe you an explanation.""*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[383]`
Mówca: **Symon Holl**
> ""I suppose we owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[384]`
Mówca: **Nia Morgna**
> ""I suppose we owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[385]`
Mówca: **Ciara Walda**
> ""I suppose we owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Nia Morgna: ""I suppose we owe you an explanation.""*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Sym..."*)

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
> ""I suppose we owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Sym..."*)
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_S..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Symon Holl: ""I suppose we owe you an explanation.""*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true && BaseGame.Fired_Symon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true  and  Variable["BaseGame.Fired_Symon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Gus Manger: ""I suppose we owe you an explanation.""*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Paskal Beniwoll: ""I suppose we owe you an explanation.""*)

### Węzeł `[396]`
Mówca: **Gus Manger**
> ""I suppose we owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
> ""I suppose I owe your my reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[398]`
Mówca: **Symon Holl**
> ""I'm sorry but I have already made my decision and I won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[399]`
Mówca: **Nia Morgna**
> ""I'm sorry but I have already made my decision and I won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[400]`
Mówca: **Ciara Walda**
> ""I'm sorry but I have already made my decision and I won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[401]`
Mówca: **Gus Manger**
> ""I'm sorry but I have already made my decision and I won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
> ""I'm sorry but I have already made my decision and I won't turn back from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
> ""I'm here to let you know that I will be handing you my resignation shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player: ""Your resignation? What is the meaning of this?""*)
  - -> `[460]` (*Player: ""I see. You are trying to sabotage me before the elections.""*)
  - -> `[409]` (*Player: ""Let's just calm down. We can work something out.""*)

### Węzeł `[404]`
Mówca: **Symon Holl**
> ""Exactly what it looks like. I am resigning from my position in the cabinet. I simply can not go on anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[405]`
Mówca: **Gus Manger**
> ""I'm here to let you know that I will be handing you my resignation shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player: ""Your resignation? What is the meaning of this?""*)
  - -> `[460]` (*Player: ""I see. You are trying to sabotage me before the elections.""*)
  - -> `[409]` (*Player: ""Let's just calm down. We can work something out.""*)

### Węzeł `[406]`
Mówca: **Symon Holl**
> ""I'm here to let you know that I will be handing you my resignation shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player: ""Your resignation? What is the meaning of this?""*)
  - -> `[460]` (*Player: ""I see. You are trying to sabotage me before the elections.""*)
  - -> `[409]` (*Player: ""Let's just calm down. We can work something out.""*)

### Węzeł `[407]`
Mówca: **Nia Morgna**
> ""I'm here to let you know that I will be handing you my resignation shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player: ""Your resignation? What is the meaning of this?""*)
  - -> `[460]` (*Player: ""I see. You are trying to sabotage me before the elections.""*)
  - -> `[409]` (*Player: ""Let's just calm down. We can work something out.""*)

### Węzeł `[408]`
Mówca: **Ciara Walda**
> ""I'm here to let you know that I will be handing you my resignation shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player: ""Your resignation? What is the meaning of this?""*)
  - -> `[460]` (*Player: ""I see. You are trying to sabotage me before the elections.""*)
  - -> `[409]` (*Player: ""Let's just calm down. We can work something out.""*)

### Węzeł `[409]`
**[WYBÓR GRACZA: ""Let's just calm down. We can work something out.""]** — Mówca: **Player**
> ""Let's just calm down. We can work something out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Paskal Beniwoll), `[405]` (Gus Manger), `[406]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Gus Manger: ""That is not why. I simply can not go on anymore.""*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Paskal Beniwoll: ""That is not why. I simply can not go on anymore after wh..."*)

### Węzeł `[413]`
Mówca: **Symon Holl**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[414]`
Mówca: **Nia Morgna**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[415]`
Mówca: **Ciara Walda**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[416]`
Mówca: **Gus Manger**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
> ""This is nothing as grandiose as a betrayal but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Nia Morgna: ""I suppose I owe you an explanation.""*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[421]`
Mówca: **Ciara Walda**
> ""I suppose I owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[422]`
Mówca: **Nia Morgna**
> ""I suppose I owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Ciara Walda: ""I suppose I owe you an explanation.""*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Symon Holl: ""That is not why. I simply can not go on anymore.""*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Gus Manger: ""This is nothing as grandiose as a betrayal but...""*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Paskal Beniwoll: ""This is nothing as grandiose as a betrayal but...""*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Nia Morgna: ""This is nothing as grandiose as a betrayal but...""*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
> ""I'm afraid I can't calm down. I'm sorry, Mr. President but this is the end of the road. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Ciara Walda: ""I suppose I owe your my reasons.""*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[439]`
Mówca: **Symon Holl**
> ""I suppose I owe your my reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[440]`
Mówca: **Nia Morgna**
> ""I suppose I owe your my reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[441]`
Mówca: **Ciara Walda**
> ""I suppose I owe your my reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Nia Morgna: ""I suppose I owe your my reasons.""*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Symon Holl: ""I suppose I owe your my reasons.""*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Gus Manger: ""I suppose I owe your my reasons.""*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Paskal Beniwoll: ""I suppose I owe your my reasons.""*)

### Węzeł `[451]`
Mówca: **Gus Manger**
> ""I suppose I owe your my reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[452]`
Mówca: **Symon Holl**
> ""I'm afraid I can't calm down. I'm sorry, Mr. President but this is the end of the road. I simply can not go on anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[453]`
Mówca: **Nia Morgna**
> ""I'm afraid I can't calm down. I'm sorry, Mr. President but this is the end of the road. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[454]`
Mówca: **Ciara Walda**
> ""I'm afraid I can't calm down. I'm sorry, Mr. President but this is the end of the road. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[455]`
Mówca: **Gus Manger**
> ""I'm afraid I can't calm down. I'm sorry, Mr. President but this is the end of the road. I simply can not go on anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
> ""That is not why. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Gus Manger: ""Exactly what it looks like. I am resigning from my posit..."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Paskal Beniwoll: ""Exactly what it looks like. I am resigning from my posit..."*)

### Węzeł `[460]`
**[WYBÓR GRACZA: ""I see. You are trying to sabotage me before the elections.""]** — Mówca: **Player**
> ""I see. You are trying to sabotage me before the elections.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Paskal Beniwoll), `[405]` (Gus Manger), `[406]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[461]`
**[WYBÓR GRACZA: ""Your resignation? What is the meaning of this?""]** — Mówca: **Player**
> ""Your resignation? What is the meaning of this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Paskal Beniwoll), `[405]` (Gus Manger), `[406]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[462]`
Mówca: **Symon Holl**
> ""That is not why. I simply can not go on anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[463]`
Mówca: **Nia Morgna**
> ""That is not why. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[464]`
Mówca: **Ciara Walda**
> ""That is not why. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[465]`
Mówca: **Gus Manger**
> ""That is not why. I simply can not go on anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
> ""Exactly what it looks like. I am resigning from my position in the cabinet. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Symon Holl: ""This is nothing as grandiose as a betrayal but...""*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[470]`
Mówca: **Nia Morgna**
> ""Exactly what it looks like. I am resigning from my position in the cabinet. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[471]`
Mówca: **Ciara Walda**
> ""Exactly what it looks like. I am resigning from my position in the cabinet. I simply can not go on anymore after what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[472]`
Mówca: **Gus Manger**
> ""Exactly what it looks like. I am resigning from my position in the cabinet. I simply can not go on anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: ""But why? What are your reasons?""*)
  - -> `[525]` (*Player: ""You're betraying me, then.""*)
  - -> `[488]` (*Player: ""Talk to me. What can I do? How can I help you better?""*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Gus Manger: ""I'm afraid I can't calm down. I'm sorry, Mr. President b..."*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Paskal Beniwoll: ""I'm afraid I can't calm down. I'm sorry, Mr. President b..."*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Symon Holl: ""I'm afraid I can't calm down. I'm sorry, Mr. President b..."*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Nia Morgna: ""Exactly what it looks like. I am resigning from my posit..."*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Ciara Walda: ""Exactly what it looks like. I am resigning from my posit..."*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Symon Holl: ""Exactly what it looks like. I am resigning from my posit..."*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[488]`
**[WYBÓR GRACZA: ""Talk to me. What can I do? How can I help you better?""]** — Mówca: **Player**
> ""Talk to me. What can I do? How can I help you better?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[404]` (Symon Holl), `[435]` (Paskal Beniwoll), `[452]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[489]`
Mówca: **Symon Holl**
> ""I suppose I owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
> ""I suppose I owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Symon Holl: ""I suppose I owe you an explanation.""*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Gus Manger: ""I suppose I owe you an explanation.""*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Paskal Beniwoll: ""I suppose I owe you an explanation.""*)

### Węzeł `[497]`
Mówca: **Gus Manger**
> ""I suppose I owe you an explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Ciara Walda: ""I'm afraid I can't calm down. I'm sorry, Mr. President b..."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Nia Morgna: ""I'm afraid I can't calm down. I'm sorry, Mr. President b..."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Ciara Walda: ""This is nothing as grandiose as a betrayal but...""*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Ciara Walda: ""That is not why. I simply can not go on anymore after wh..."*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Gus Manger: ""I'm sorry but I have already made my decision and I won'..."*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Paskal Beniwoll: ""I'm sorry but I have already made my decision and I won'..."*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Nia Morgna: ""I'm sorry but I have already made my decision and I won'..."*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Symon Holl: ""I'm sorry but I have already made my decision and I won'..."*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Ciara Walda: ""I'm sorry but I have already made my decision and I won'..."*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Nia Morgna: ""That is not why. I simply can not go on anymore after wh..."*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[525]`
**[WYBÓR GRACZA: ""You're betraying me, then.""]** — Mówca: **Player**
> ""You're betraying me, then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[404]` (Symon Holl), `[435]` (Paskal Beniwoll), `[452]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[526]`
**[WYBÓR GRACZA: ""But why? What are your reasons?""]** — Mówca: **Player**
> ""But why? What are your reasons?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[404]` (Symon Holl), `[435]` (Paskal Beniwoll), `[452]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[527]`
**[WYBÓR GRACZA: ""You are fools if you can't see the real threats. I don't need fools in my cabinet.""]** — Mówca: **Player**
> ""You are fools if you can't see the real threats. I don't need fools in my cabinet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[549]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Ciara Walda: ""There is only one threat in Sordland and that's you.""*)

### Węzeł `[528]`
Mówca: **Ciara Walda**
> ""There is only one threat in Sordland and that's you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[529]`
Mówca: **Ciara Walda**
> ""What is most upsetting is the fact that we would not know any of this if not for these leaks. Your very own cabinet did not know of this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Player: ""I was going to announce it to the cabinet at one point.""*)
  - -> `[531]` (*Player: ""I did what I have done in order to protect this country.""*)
  - -> `[532]` (*Player: ""Enough. If you don't have what it takes to better this c..."*)

### Węzeł `[530]`
**[WYBÓR GRACZA: ""I was going to announce it to the cabinet at one point.""]** — Mówca: **Player**
> ""I was going to announce it to the cabinet at one point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[529]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Ciara Walda: ""Can you not even see that's not the problem? You are bey..."*)

### Węzeł `[531]`
**[WYBÓR GRACZA: ""I did what I have done in order to protect this country.""]** — Mówca: **Player**
> ""I did what I have done in order to protect this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[529]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Ciara Walda: ""No. You did what you have done to protect yourself!""*)

### Węzeł `[532]`
**[WYBÓR GRACZA: ""Enough. If you don't have what it takes to better this country, then you don't deserve to be in my cabinet.""]** — Mówca: **Player**
> ""Enough. If you don't have what it takes to better this country, then you don't deserve to be in my cabinet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[529]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Ciara Walda: ""You have completely changed. I don't know how I could've..."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter ==..."*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Po..."*)

### Węzeł `[536]`
Mówca: **Ciara Walda**
> ""I have absolutely no words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[537]`
Mówca: **Ciara Walda**
> ""Why don't we talk about the permanent *emergency* situation that you have put our country under?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Ciara Walda: ""What emergency? You are just creating enemies out of thi..."*)

### Węzeł `[538]`
Mówca: **Ciara Walda**
> ""Can you not even see that's not the problem? You are beyond hope and salvation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Ciara Walda: ""I guess this is what power does to people.""*)

### Węzeł `[539]`
Mówca: **Ciara Walda**
> ""How could you do create the Secret State Police? How dare you attack the very values this country stands on? You will go down the history as a dictator.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Ciara Walda: ""This is a direct breach of democratic process and you ar..."*)

### Węzeł `[540]`
Mówca: **Ciara Walda**
> ""No. You did what you have done to protect yourself!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Ciara Walda: ""I guess this is what power does to people.""*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[544]`
Mówca: **Ciara Walda**
> ""You have completely changed. I don't know how I could've ever believed in you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Ciara Walda: ""I guess this is what power does to people.""*)

### Węzeł `[545]`
Mówca: **Ciara Walda**
> ""This is a direct breach of democratic process and you are responsible for destroying lives of the representatives that this country has picked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Ciara Walda: ""What is most upsetting is the fact that we would not kno..."*)

### Węzeł `[546]`
Mówca: **Ciara Walda**
> ""I guess this is what power does to people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Ciara Walda: ""I refuse to work under such circumstances.""*)

### Węzeł `[547]`
**[WYBÓR GRACZA: ""Surely you jest! I did all I did for Sordland and Sordland alone!""]** — Mówca: **Player**
> ""Surely you jest! I did all I did for Sordland and Sordland alone!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[549]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Ciara Walda: ""Your puppeteers have you so brainwashed that you forgot ..."*)

### Węzeł `[548]`
Mówca: **Ciara Walda**
> ""What emergency? You are just creating enemies out of thin air to firm your grasp on the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Ciara Walda: ""It's all a ploy to grab more and more power.""*)

### Węzeł `[549]`
Mówca: **Ciara Walda**
> ""What's next? You are going to declare yourself the King of Sordland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Player: ""You are fools if you can't see the real threats. I don't..."*)
  - -> `[547]` (*Player: ""Surely you jest! I did all I did for Sordland and Sordla..."*)
  - -> `[556]` (*Player: ""A King? That does sound nice, doesn't it?""*)

### Węzeł `[550]`
Mówca: **Ciara Walda**
> ""I refuse to work under such circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Po..."*)

### Węzeł `[551]`
Mówca: **Ciara Walda**
> ""It's all a ploy to grab more and more power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Ciara Walda: ""What's next? You are going to declare yourself the King ..."*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true) && BaseGame.Reform_Reform_Court_Success == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Po..."*)
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "!(((BaseGame.Policy_Law_Threshold_15 == true || BaseGame...."*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true) && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Threshold_15"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true) && BaseGame.Reform_Reform_Court_Success == true))`
- **Warunek bezpośredni (`conditionsString`):** `(((Variable["BaseGame.Policy_Law_Threshold_15"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[555]`
Mówca: **Ciara Walda**
> ""Your puppeteers have you so brainwashed that you forgot that you have a mind of your own!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[556]`
**[WYBÓR GRACZA: ""A King? That does sound nice, doesn't it?""]** — Mówca: **Player**
> ""A King? That does sound nice, doesn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[549]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Ciara Walda: ""I have absolutely no words.""*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Ciara Walda: ""How could you do create the Secret State Police? How dar..."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Nia Morgna: ""How could you create the Secret State Police? How dare y..."*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Paskal Beniwoll: ""Your creation of the Secret State Police is a direct bre..."*)

### Węzeł `[563]`
Mówca: **Nia Morgna**
> ""What is most upsetting is the fact that we would not know any of this if not for these leaks. Your very own cabinet did not know of this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Player: ""I was going to announce it to the cabinet at some point.""*)
  - -> `[567]` (*Player: ""I did what I have done in order to protect this country.""*)
  - -> `[568]` (*Player: ""Enough. If you don't have what it takes to improve this ..."*)

### Węzeł `[564]`
Mówca: **Nia Morgna**
> ""How could you create the Secret State Police? How dare you attack the very values this country stands on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Nia Morgna: ""This is a direct breach of the democratic process. You a..."*)

### Węzeł `[565]`
Mówca: **Nia Morgna**
> ""This is a direct breach of the democratic process. You are responsible for destroying lives of the representatives that this country has picked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Nia Morgna: ""What is most upsetting is the fact that we would not kno..."*)

### Węzeł `[566]`
**[WYBÓR GRACZA: ""I was going to announce it to the cabinet at some point.""]** — Mówca: **Player**
> ""I was going to announce it to the cabinet at some point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[563]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Nia Morgna: ""Can you not even see that's not the problem? You are bey..."*)

### Węzeł `[567]`
**[WYBÓR GRACZA: ""I did what I have done in order to protect this country.""]** — Mówca: **Player**
> ""I did what I have done in order to protect this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[563]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Nia Morgna: ""No. You did what you have done to protect yourself!""*)

### Węzeł `[568]`
**[WYBÓR GRACZA: ""Enough. If you don't have what it takes to improve this country, then you don't deserve to be in my cabinet.""]** — Mówca: **Player**
> ""Enough. If you don't have what it takes to improve this country, then you don't deserve to be in my cabinet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[563]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Nia Morgna: ""You have completely changed. I don't know how I could've..."*)

### Węzeł `[569]`
Mówca: **Nia Morgna**
> ""Can you not even see that's not the problem? You are beyond hope and salvation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Nia Morgna: ""I guess this is what power does to people.""*)

### Węzeł `[570]`
Mówca: **Nia Morgna**
> ""No. You did what you have done to protect yourself!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Nia Morgna: ""I guess this is what power does to people.""*)

### Węzeł `[571]`
Mówca: **Nia Morgna**
> ""You have completely changed. I don't know how I could've ever believed in you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Nia Morgna: ""I guess this is what power does to people.""*)

### Węzeł `[572]`
Mówca: **Nia Morgna**
> ""I guess this is what power does to people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Nia Morgna: ""I refuse to work under such circumstances.""*)

### Węzeł `[573]`
Mówca: **Nia Morgna**
> ""I refuse to work under such circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Po..."*)

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
> ""What is most upsetting is the fact that we would not know any of this if not for these leaks. Your very own cabinet did not know of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Player: ""I was going to announce it to the cabinet at one point.""*)
  - -> `[578]` (*Player: ""I did what I have done in order to protect this country.""*)
  - -> `[579]` (*Player: ""Enough. If you don't have what it takes to improve this ..."*)

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
> ""Your creation of the Secret State Police is a direct breach of the democratic process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Paskal Beniwoll: ""Lives were destroyed using this completely illegal organ..."*)

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
> ""Lives were destroyed using this completely illegal organisation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Paskal Beniwoll: ""What is most upsetting is the fact that we would not kno..."*)

### Węzeł `[577]`
**[WYBÓR GRACZA: ""I was going to announce it to the cabinet at one point.""]** — Mówca: **Player**
> ""I was going to announce it to the cabinet at one point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[574]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Paskal Beniwoll: ""Unfortunately, that is not the problem, Mr. President.""*)

### Węzeł `[578]`
**[WYBÓR GRACZA: ""I did what I have done in order to protect this country.""]** — Mówca: **Player**
> ""I did what I have done in order to protect this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[574]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Paskal Beniwoll: ""This seems to serve the position of President more than ..."*)

### Węzeł `[579]`
**[WYBÓR GRACZA: ""Enough. If you don't have what it takes to improve this country, then you don't deserve to be in my cabinet.""]** — Mówca: **Player**
> ""Enough. If you don't have what it takes to improve this country, then you don't deserve to be in my cabinet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[574]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Paskal Beniwoll: ""You have changed, Mr. President.""*)

### Węzeł `[580]`
Mówca: **Paskal Beniwoll**
> ""Unfortunately, that is not the problem, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Paskal Beniwoll: ""You have changed, Mr. President.""*)

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
> ""This seems to serve the position of President more than the country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Paskal Beniwoll: ""You have changed, Mr. President.""*)

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
> ""You have changed, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Paskal Beniwoll: ""I refuse to work under such circumstances.""*)

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
> ""I refuse to work under such circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Po..."*)

### Węzeł `[584]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Ciara Walda: ""Why don't we talk a bit about your *reforms*?""*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[587]`
Mówca: **Ciara Walda**
> ""Why don't we talk a bit about your *reforms*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Ciara Walda: ""Or about how you deceived your cabinet and your entire c..."*)

### Węzeł `[588]`
Mówca: **Ciara Walda**
> ""Or about how you deceived your cabinet and your entire country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Player: ""Deceived? I brought reforms when no one else could.""*)
  - -> `[591]` (*Player: ""Presidential power must be maintained in a country like ..."*)
  - -> `[593]` (*Player: ""I will not stand by while you accuse me of treachery. Ge..."*)

### Węzeł `[589]`
Mówca: **Ciara Walda**
> ""You will reform the country by turning it into a dictatorship? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[590]`
Mówca: **Ciara Walda**
> ""Not until we said our final words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[591]`
**[WYBÓR GRACZA: ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""]** — Mówca: **Player**
> ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[588]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Ciara Walda: ""You will reform the country by turning it into a dictato..."*)

### Węzeł `[592]`
Mówca: **Ciara Walda**
> ""By giving yourself more power? By exploiting the law? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[593]`
**[WYBÓR GRACZA: ""I will not stand by while you accuse me of treachery. Get out.""]** — Mówca: **Player**
> ""I will not stand by while you accuse me of treachery. Get out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[588]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Ciara Walda: ""Not until we said our final words.""*)

### Węzeł `[594]`
**[WYBÓR GRACZA: ""Deceived? I brought reforms when no one else could.""]** — Mówca: **Player**
> ""Deceived? I brought reforms when no one else could.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[588]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Ciara Walda: ""By giving yourself more power? By exploiting the law? Yo..."*)

### Węzeł `[595]`
Mówca: **Nia Morgna**
> ""Why don't we talk a bit about your *reforms*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Nia Morgna: ""Or about how you deceived your cabinet and your entire c..."*)

### Węzeł `[596]`
Mówca: **Nia Morgna**
> ""Or about how you deceived your cabinet and your entire country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Player: ""Deceived? I brought reforms when no one else could.""*)
  - -> `[599]` (*Player: ""Presidential power must be maintained in a country like ..."*)
  - -> `[601]` (*Player: ""I will not stand by while you accuse me of treachery. Ge..."*)

### Węzeł `[597]`
Mówca: **Nia Morgna**
> ""You will reform the country by turning it into a dictatorship? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[598]`
Mówca: **Nia Morgna**
> ""Not until we say our final words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[599]`
**[WYBÓR GRACZA: ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""]** — Mówca: **Player**
> ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[596]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Nia Morgna: ""You will reform the country by turning it into a dictato..."*)

### Węzeł `[600]`
Mówca: **Nia Morgna**
> ""By giving yourself more power? By exploiting the law? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[601]`
**[WYBÓR GRACZA: ""I will not stand by while you accuse me of treachery. Get out.""]** — Mówca: **Player**
> ""I will not stand by while you accuse me of treachery. Get out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[596]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Nia Morgna: ""Not until we say our final words.""*)

### Węzeł `[602]`
**[WYBÓR GRACZA: ""Deceived? I brought reforms when no one else could.""]** — Mówca: **Player**
> ""Deceived? I brought reforms when no one else could.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[596]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Nia Morgna: ""By giving yourself more power? By exploiting the law? Yo..."*)

### Węzeł `[603]`
Mówca: **Nia Morgna**
> ""Why don't we talk about the permanent *emergency* situation that you have put our country under?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Nia Morgna: ""What emergency? You are just creating enemies out of thi..."*)

### Węzeł `[604]`
Mówca: **Nia Morgna**
> ""What emergency? You are just creating enemies out of thin air to firm your grasp on the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Nia Morgna: ""It's all a ploy to grab more and more power.""*)

### Węzeł `[605]`
Mówca: **Nia Morgna**
> ""It's all a ploy to grab more and more power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Nia Morgna: ""What's next? You are going to declare yourself the King ..."*)

### Węzeł `[606]`
**[WYBÓR GRACZA: ""You are fools if you can't see the real threats. I don't need fools in my cabinet.""]** — Mówca: **Player**
> ""You are fools if you can't see the real threats. I don't need fools in my cabinet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[610]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Nia Morgna: ""There is only one threat in Sordland and that's you.""*)

### Węzeł `[607]`
Mówca: **Nia Morgna**
> ""There is only one threat in Sordland and that's you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[608]`
Mówca: **Nia Morgna**
> ""I have absolutely no words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[609]`
**[WYBÓR GRACZA: ""Surely you jest! I did all I did for Sordland and Sordland alone!""]** — Mówca: **Player**
> ""Surely you jest! I did all I did for Sordland and Sordland alone!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[610]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Nia Morgna: ""Your puppeteers have you so brainwashed that you forgot ..."*)

### Węzeł `[610]`
Mówca: **Nia Morgna**
> ""What's next? You are going to declare yourself the King of Sordland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Player: ""You are fools if you can't see the real threats. I don't..."*)
  - -> `[609]` (*Player: ""Surely you jest! I did all I did for Sordland and Sordla..."*)
  - -> `[612]` (*Player: ""A King? That does sound nice, doesn't it?""*)

### Węzeł `[611]`
Mówca: **Nia Morgna**
> ""Your puppeteers have you so brainwashed that you forgot that you have a mind of your own!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[612]`
**[WYBÓR GRACZA: ""A King? That does sound nice, doesn't it?""]** — Mówca: **Player**
> ""A King? That does sound nice, doesn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[610]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Nia Morgna: ""I have absolutely no words.""*)

### Węzeł `[613]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[615]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[614]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Ciara Walda: ""Why don't we talk about the permanent *emergency* situat..."*)

### Węzeł `[615]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[616]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)
  - -> `[618]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn10_A_NumberOfResignations > 1)"*)

### Węzeł `[617]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Narrator: "I looked at their determined faces."*)

### Węzeł `[618]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn10_A_NumberOfResignations > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[619]`
Mówca: **Narrator**
> "I looked at their determined faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Player: ""I have no choice but to accept your resignations.""*)
  - -> `[361]` (*Player: ""I accept your resignations. Now get out of my face.""*)

### Węzeł `[620]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[622]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[621]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Narrator: "I looked at Ciara's determined face."*)

### Węzeł `[622]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[623]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[625]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[624]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Narrator: "I looked at Nia's determined face."*)

### Węzeł `[625]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[626]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[627]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Narrator: "I looked at Symon's determined face."*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[631]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[630]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Narrator: "I looked at Gus's determined face."*)

### Węzeł `[631]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Narrator: "I looked at Paskal's determined face."*)

### Węzeł `[632]`
Mówca: **Narrator**
> "I looked at Ciara's determined face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Player: ""I have no choice but to accept your resignation.""*)
  - -> `[637]` (*Player: ""I accept your resignation. Now get out of my face.""*)

### Węzeł `[633]`
Mówca: **Narrator**
> "I looked at Nia's determined face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Player: ""I have no choice but to accept your resignation.""*)
  - -> `[637]` (*Player: ""I accept your resignation. Now get out of my face.""*)

### Węzeł `[634]`
Mówca: **Narrator**
> "I looked at Symon's determined face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Player: ""I have no choice but to accept your resignation.""*)
  - -> `[637]` (*Player: ""I accept your resignation. Now get out of my face.""*)

### Węzeł `[635]`
Mówca: **Narrator**
> "I looked at Gus's determined face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Player: ""I have no choice but to accept your resignation.""*)
  - -> `[637]` (*Player: ""I accept your resignation. Now get out of my face.""*)

### Węzeł `[636]`
Mówca: **Narrator**
> "I looked at Paskal's determined face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Player: ""I have no choice but to accept your resignation.""*)
  - -> `[637]` (*Player: ""I accept your resignation. Now get out of my face.""*)

### Węzeł `[637]`
**[WYBÓR GRACZA: ""I accept your resignation. Now get out of my face.""]** — Mówca: **Player**
> ""I accept your resignation. Now get out of my face.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[632]` (Narrator), `[633]` (Narrator), `[634]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[638]`
**[WYBÓR GRACZA: ""I have no choice but to accept your resignation.""]** — Mówca: **Player**
> ""I have no choice but to accept your resignation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[632]` (Narrator), `[633]` (Narrator), `[634]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[639]`
Mówca: **Narrator**
> "Paskal and Lucian left and I took a seat alone in the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn10_A_Resignations = true"*)

### Węzeł `[640]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[642]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[641]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Ciara Walda", "Former Minister");"*)

### Węzeł `[642]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[643]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[645]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[644]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[791]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Nia Morgna", "Former Minister");"*)

### Węzeł `[645]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[646]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[648]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[647]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Symon Holl", "Former Minister");"*)

### Węzeł `[648]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[649]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[651]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[650]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Gus Manger", "Former Minister");"*)

### Węzeł `[651]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Paskal Beniwoll", "Former Minister");"*)

### Węzeł `[652]`
Mówca: **Narrator**
> "Ciara and Lucian left and I took a seat alone in the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn10_A_Resignations = true"*)

### Węzeł `[653]`
Mówca: **Narrator**
> "Gus and Lucian left and I took a seat alone in the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn10_A_Resignations = true"*)

### Węzeł `[654]`
Mówca: **Narrator**
> "Nia and Lucian left and I took a seat alone in the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn10_A_Resignations = true"*)

### Węzeł `[655]`
Mówca: **Narrator**
> "Symon and Lucian left and I took a seat alone in the White Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn10_A_Resignations = true"*)

### Węzeł `[656]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn10_A_Resignations = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn10_A_Resignations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[657]`
Mówca: **Narrator**
> "Ciara was too radical for this country anyway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[658]`
Mówca: **Narrator**
> "Symon had failed his job and could always be replaced by another expert. His departure wouldn't be felt and the damage he has done won't be forgotten."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[659]`
Mówca: **Narrator**
> "Paskal's heart was at the right place and it's sad that he is leaving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Narrator: "People come and people go. Such is life."*)

### Węzeł `[660]`
Mówca: **Narrator**
> "Mr. Manger didn't leave much of a mark both positive and negative during his time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[661]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)
  - -> `[663]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_GusManger == true)"*)

### Węzeł `[662]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_GusManger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_GusManger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Gus Manger", "Former Minister");"*)

### Węzeł `[663]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_GusManger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_GusManger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[664]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[666]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[665]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Nia Morgna", "Former Minister");"*)

### Węzeł `[666]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)
  - -> `[669]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_SymonHoll == true)"*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_SymonHoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_SymonHoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Symon Holl", "Former Minister");"*)

### Węzeł `[669]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_SymonHoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_SymonHoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
  - -> `[672]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_CiaraWalda == true)"*)

### Węzeł `[671]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_CiaraWalda == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_CiaraWalda"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Ciara Walda", "Former Minister");"*)

### Węzeł `[672]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_CiaraWalda == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_CiaraWalda"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[673]`
Mówca: **Narrator**
> "People come and people go. Such is life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn10_A_Resignations = true"*)

### Węzeł `[674]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_Symon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_Symon == true"*)
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_Symon == true)"*)

### Węzeł `[675]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_Symon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_Symon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "Jump to: [SymonFired]"*)

### Węzeł `[676]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_Symon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_Symon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Symon Holl: ""I'm here to let you know that I will be handing you my r..."*)

### Węzeł `[677]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [SymonFired]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Węzeł Logiki Narracyjnej: "SymonFired"*)

### Węzeł `[678]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SymonFired`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Symon Holl: ""As you have requested, I have come to deliver my resigna..."*)

### Węzeł `[679]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_Resignations_Ciara = true;
BaseGameSupport.Codex_Characters_Cabinet_CiaraWalda_Resigned = true;
BaseGameSupport.Codex_Characters_Cabinet_CiaraWalda = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_Resignations_Ciara"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_CiaraWalda_Resigned"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_CiaraWalda"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Cabinet", "Position_EducationMinis..."*)

### Węzeł `[680]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_Resignations_Gus = true;
BaseGameSupport.Codex_Characters_Cabinet_GusManger_Resigned = true;
BaseGameSupport.Codex_Characters_Cabinet_GusManger = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_Resignations_Gus"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_GusManger_Resigned"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_GusManger"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Cabinet", "Position_AgricultureMin..."*)

### Węzeł `[681]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_Resignations_Nia = true;
BaseGameSupport.Codex_Characters_Cabinet_NiaMorgna_Resigned = true;
BaseGameSupport.Codex_Characters_Cabinet_NiaMorgna = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_Resignations_Nia"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_NiaMorgna_Resigned"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_NiaMorgna"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[782]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Judiciary", "Position_NotableJusti..."*)

### Węzeł `[682]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_Resignations_Paskal = true;
BaseGameSupport.Codex_Characters_Cabinet_PaskalBeniwoll_Resigned = true;
BaseGameSupport.Codex_Characters_Cabinet_PaskalBeniwoll = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_Resignations_Paskal"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PaskalBeniwoll_Resigned"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PaskalBeniwoll"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Cabinet", "Position_HealthMinister..."*)

### Węzeł `[683]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_Resignations_Symon = true;
BaseGameSupport.Codex_Characters_Cabinet_SymonHoll_Resigned = true;
BaseGameSupport.Codex_Characters_Cabinet_SymonHoll = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_Resignations_Symon"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_SymonHoll_Resigned"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_SymonHoll"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Cabinet", "Position_EconomyMiniste..."*)

### Węzeł `[684]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations >= 3"*)
  - -> `[686]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn10_A_NumberOfResignations >= 3)"*)

### Węzeł `[685]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_LT_Resignations_TooMany = true"*)

### Węzeł `[686]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn10_A_NumberOfResignations >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_LT_Resignations_One = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_LT_Resignations_One"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)
  - -> `[690]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn10_A_NumberOfResignations > 1)"*)

### Węzeł `[689]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_LT_Resignations_MoreThanOne =..."*)

### Węzeł `[690]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn10_A_NumberOfResignations > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_LT_Resignations_One = true"*)

### Węzeł `[691]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_LT_Resignations_MoreThanOne = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_LT_Resignations_MoreThanOne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)

### Węzeł `[692]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_LT_Resignations_TooMany = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_LT_Resignations_TooMany"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 1"*)
  - -> `[695]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn10_A_NumberOfResignations > 1)"*)

### Węzeł `[694]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_R_Resignations_MoreThanOne = ..."*)

### Węzeł `[695]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn10_A_NumberOfResignations > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "The door opened and Lucian entered."*)

### Węzeł `[696]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_R_Resignations_MoreThanOne = true;
BaseGameSupport.News_Turn10_HP_Resignations_MoreThanOne = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_R_Resignations_MoreThanOne"] = true;
Variable["BaseGameSupport.News_Turn10_HP_Resignations_MoreThanOne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "The door opened and Lucian entered."*)

### Węzeł `[697]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_PaskalBeniwoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)
  - -> `[699]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_PaskalBeniwoll == true)"*)

### Węzeł `[698]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_PaskalBeniwoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_PaskalBeniwoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Paskal Beniwoll", "Former Minister");"*)

### Węzeł `[699]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_PaskalBeniwoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_PaskalBeniwoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Narrator: "People come and people go. Such is life."*)

### Węzeł `[700]`
Mówca: **Paskal Beniwoll**
> ""Even though you acted against the epidemic which saved millions of Sords, I cannot and will not stand with your abuse of power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Paskal Beniwoll: ""The things you did behind closed doors shook me to my bo..."*)

### Węzeł `[701]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Pandemic_Severity >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Węzeł Logiki Narracyjnej: "BaseGame.Pandemic_Severity >= 1"*)
  - -> `[703]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Pandemic_Severity >= 1)"*)

### Węzeł `[702]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Pandemic_Severity >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Pandemic_Severity"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Paskal Beniwoll: ""The government has not done enough and now we have polio..."*)

### Węzeł `[703]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Pandemic_Severity >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Pandemic_Severity"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Paskal Beniwoll: ""Even though you acted against the epidemic which saved m..."*)

### Węzeł `[704]`
Mówca: **Paskal Beniwoll**
> ""The things you did behind closed doors shook me to my bones when the news came to my knowledge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Paskal Beniwoll: ""You may have your reasons, Mr. President, that it is for..."*)

### Węzeł `[705]`
Mówca: **Paskal Beniwoll**
> ""Even worst is the things you did behind closed doors. It shook me to my bones when I heard of the dreadful news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Paskal Beniwoll: ""I will hand you my resignation once our term is done, Mr..."*)

### Węzeł `[706]`
Mówca: **Paskal Beniwoll**
> ""You may have your reasons, Mr. President, that it is for the greater good. But the same line of reasoning will simply lead to more atrocious actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Paskal Beniwoll: ""I will hand you my resignation once our term is done, Mr..."*)

### Węzeł `[707]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)
  - -> `[709]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter ==..."*)

### Węzeł `[708]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Paskal Beniwoll: ""Even worst is the things you did behind closed doors. It..."*)

### Węzeł `[709]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Paskal Beniwoll: ""I will hand you my resignation once our term is done, Mr..."*)

### Węzeł `[710]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations >= 3 && BaseGame.Situation_Law_MediaCensored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations >= 3 && Ba..."*)
  - -> `[712]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn10_A_NumberOfResignations >= 3 && ..."*)

### Węzeł `[711]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations >= 3 && BaseGame.Situation_Law_MediaCensored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] >= 3  and  Variable["BaseGame.Situation_Law_MediaCensored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 5;"*)

### Węzeł `[712]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn10_A_NumberOfResignations >= 3 && BaseGame.Situation_Law_MediaCensored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] >= 3  and  Variable["BaseGame.Situation_Law_MediaCensored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations >= 3"*)

### Węzeł `[713]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations >= 3"*)

### Węzeł `[714]`
Mówca: **Narrator**
> "Ciara was a great asset to the administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[715]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_ModernEducationTechniques == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_ModernEducationTechniques == true"*)
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_ModernEducationTechniques ==..."*)

### Węzeł `[716]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_ModernEducationTechniques == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_ModernEducationTechniques"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Narrator: "Ciara had accomplished the difficult education reforms. A..."*)

### Węzeł `[717]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_ModernEducationTechniques == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_ModernEducationTechniques"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true && Bas..."*)

### Węzeł `[718]`
Mówca: **Narrator**
> "Ciara had accomplished the difficult education reforms. A task many would have failed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[719]`
Mówca: **Narrator**
> "Her ideas were beyond acceptable for the conservative base of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[720]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Autocrat_Path == true || BaseGame.Democratic < -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_..."*)
  - -> `[722]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true || BaseGame.Refor..."*)

### Węzeł `[721]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Autocrat_Path == true || BaseGame.Democratic < -15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true  or  Variable["BaseGame.Democratic"] < -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]` (*Narrator: "She just didn't have the guts to do what was necessary to..."*)

### Węzeł `[722]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Autocrat_Path == true || BaseGame.Democratic < -15)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true  or  Variable["BaseGame.Democratic"] < -15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[723]`
Mówca: **Narrator**
> "We could have established much more with the Ministry of Justice. Her departure will be felt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[724]`
Mówca: **Narrator**
> "Nia was a true moralist. The world would never be perfect or just enough for her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[725]`
Mówca: **Narrator**
> "She just didn't have the guts to do what was necessary to make Sordland a better place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_SymonHoll == true"*)

### Węzeł `[726]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[728]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[727]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Narrator: "Nia was a true moralist. The world would never be perfect..."*)

### Węzeł `[728]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Narrator: "We could have established much more with the Ministry of ..."*)

### Węzeł `[729]`
Mówca: **Narrator**
> "Mr. Holl achieved the great economic miracle but still decided to leave. It will be a saddening loss for the administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[730]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == true"*)
  - -> `[732]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishRecovery == true)"*)

### Węzeł `[731]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Narrator: "Mr. Holl achieved the great economic miracle but still de..."*)

### Węzeł `[732]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true && BaseGame..."*)

### Węzeł `[733]`
Mówca: **Narrator**
> "He was a true bureaucrat with clear purpose. I respected that about Holl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[734]`
Mówca: **Narrator**
> "My skepticism about Symon had never ceased and this departure was expected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_GusManger == true"*)

### Węzeł `[735]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true || BaseGame.Turn05_P_Underhall == true || BaseGame.Turn05_P_Vineyard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true || BaseGame.Turn05_P_U..."*)
  - -> `[737]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true || BaseGame.Turn05_P..."*)

### Węzeł `[736]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true || BaseGame.Turn05_P_Underhall == true || BaseGame.Turn05_P_Vineyard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true  or  Variable["BaseGame.Turn05_P_Underhall"] == true  or  Variable["BaseGame.Turn05_P_Vineyard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Narrator: "Gus provided great investment opportunities but outside o..."*)

### Węzeł `[737]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true || BaseGame.Turn05_P_Underhall == true || BaseGame.Turn05_P_Vineyard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true  or  Variable["BaseGame.Turn05_P_Underhall"] == true  or  Variable["BaseGame.Turn05_P_Vineyard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[738]`
Mówca: **Narrator**
> "We got the L-1 project completed with Gus and the mark of that investment was felt in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[739]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_EpidemicPrevented == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicPrevented == true"*)
  - -> `[741]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_EpidemicPrevented == true)"*)

### Węzeł `[740]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_EpidemicPrevented == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_EpidemicPrevented"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]` (*Narrator: "Mr. Beniwoll helped prevent the Polio Crisis from becomin..."*)

### Węzeł `[741]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_EpidemicPrevented == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_EpidemicPrevented"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]` (*Narrator: "Paskal wasn't that useful to the administration anyway. T..."*)

### Węzeł `[742]`
Mówca: **Narrator**
> "Gus provided great investment opportunities but outside of that did little to contribute to the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[743]`
Mówca: **Narrator**
> "Gus was nothing but a leech that survived on connections alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_PaskalBeniwoll == true"*)

### Węzeł `[744]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_RailwayProject == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_RailwayProject == true"*)
  - -> `[746]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_RailwayProject == true)"*)

### Węzeł `[745]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_RailwayProject == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_RailwayProject"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Narrator: "We got the L-1 project completed with Gus and the mark of..."*)

### Węzeł `[746]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_RailwayProject == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_RailwayProject"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true || BaseGame.Turn05_P_U..."*)

### Węzeł `[747]`
Mówca: **Narrator**
> "Mr. Beniwoll helped prevent the Polio Crisis from becoming a regional epidemic or even a global pandemic. For this I will remember them well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Narrator: "People come and people go. Such is life."*)

### Węzeł `[748]`
Mówca: **Narrator**
> "Paskal wasn't that useful to the administration anyway. The polio crisis wasn't fixed during the term and the damages of that were felt in the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Narrator: "People come and people go. Such is life."*)

### Węzeł `[749]`
Mówca: **Narrator**
> "Paskal could have done much more but decided to leave the administration behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Narrator: "People come and people go. Such is life."*)

### Węzeł `[750]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_..."*)
  - -> `[752]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true && BaseGame.Refor..."*)

### Węzeł `[751]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Pol..."*)

### Węzeł `[752]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true && BaseGame.Reform..."*)

### Węzeł `[753]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true && BaseGame.Reform..."*)
  - -> `[755]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true && BaseGame.Refo..."*)

### Węzeł `[754]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Default == true && BaseGame.P..."*)

### Węzeł `[755]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[756]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Decree_Default == true && BaseGame.Policy_Law_Impeachment_Removed == true) || (BaseGame.Policy_Law_TermLimits_Default == true || BaseGame.Policy_Law_Honorary_Presidents == true && BaseGame.Policy_Law_Threshold_Default == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Default == true && BaseGame.P..."*)
  - -> `[758]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Policy_Law_Decree_Default == true && BaseGame..."*)

### Węzeł `[757]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Decree_Default == true && BaseGame.Policy_Law_Impeachment_Removed == true) || (BaseGame.Policy_Law_TermLimits_Default == true || BaseGame.Policy_Law_Honorary_Presidents == true && BaseGame.Policy_Law_Threshold_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  and  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)  or  (Variable["BaseGame.Policy_Law_TermLimits_Default"] == true  or  Variable["BaseGame.Policy_Law_Honorary_Presidents"] == true  and  Variable["BaseGame.Policy_Law_Threshold_Default"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[758]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Policy_Law_Decree_Default == true && BaseGame.Policy_Law_Impeachment_Removed == true) || (BaseGame.Policy_Law_TermLimits_Default == true || BaseGame.Policy_Law_Honorary_Presidents == true && BaseGame.Policy_Law_Threshold_Default == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Decree_Default"] == true  and  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)  or  (Variable["BaseGame.Policy_Law_TermLimits_Default"] == true  or  Variable["BaseGame.Policy_Law_Honorary_Presidents"] == true  and  Variable["BaseGame.Policy_Law_Threshold_Default"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[759]`
**[WYBÓR GRACZA: ""Deceived? I brought reforms when no one else could.""]** — Mówca: **Player**
> ""Deceived? I brought reforms when no one else could.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[768]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]` (*Nia Morgna: ""By giving yourself more power? By exploiting the law? Yo..."*)

### Węzeł `[760]`
Mówca: **Nia Morgna**
> ""By giving yourself more power? By exploiting the law? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[761]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Pol..."*)
  - -> `[763]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.P..."*)

### Węzeł `[762]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_15"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[763]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Policy_Law_Veto_Loophole == true || BaseGame.Policy_Law_Judges_Impeachment_President == true || BaseGame.Policy_Law_Decree_Stronger == true || BaseGame.Policy_Law_Impeachment_Removed == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Threshold_15"] == true  or  Variable["BaseGame.Policy_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Policy_Law_Judges_Impeachment_President"] == true  or  Variable["BaseGame.Policy_Law_Decree_Stronger"] == true  or  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[764]`
Mówca: **Nia Morgna**
> ""Why don't we talk a bit about your *reforms*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Nia Morgna: ""Or about how you deceived your cabinet and your entire c..."*)

### Węzeł `[765]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_..."*)
  - -> `[767]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true && BaseGame.Refor..."*)

### Węzeł `[766]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Threshold_15 == true || BaseGame.Pol..."*)

### Węzeł `[767]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true && BaseGame.Reform..."*)

### Węzeł `[768]`
Mówca: **Nia Morgna**
> ""Or about how you deceived your cabinet and your entire country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Player: ""Deceived? I brought reforms when no one else could.""*)
  - -> `[773]` (*Player: ""Presidential power must be maintained in a country like ..."*)
  - -> `[772]` (*Player: ""I will not stand by while you accuse me of treachery. Ge..."*)

### Węzeł `[769]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Decree_Default == true && BaseGame.Policy_Law_Impeachment_Removed == true) || (BaseGame.Policy_Law_TermLimits_Default == true || BaseGame.Policy_Law_Honorary_Presidents == true && BaseGame.Policy_Law_Threshold_Default == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Default == true && BaseGame.P..."*)
  - -> `[771]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Policy_Law_Decree_Default == true && BaseGame..."*)

### Węzeł `[770]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Decree_Default == true && BaseGame.Policy_Law_Impeachment_Removed == true) || (BaseGame.Policy_Law_TermLimits_Default == true || BaseGame.Policy_Law_Honorary_Presidents == true && BaseGame.Policy_Law_Threshold_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Default"] == true  and  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)  or  (Variable["BaseGame.Policy_Law_TermLimits_Default"] == true  or  Variable["BaseGame.Policy_Law_Honorary_Presidents"] == true  and  Variable["BaseGame.Policy_Law_Threshold_Default"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[771]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Policy_Law_Decree_Default == true && BaseGame.Policy_Law_Impeachment_Removed == true) || (BaseGame.Policy_Law_TermLimits_Default == true || BaseGame.Policy_Law_Honorary_Presidents == true && BaseGame.Policy_Law_Threshold_Default == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Decree_Default"] == true  and  Variable["BaseGame.Policy_Law_Impeachment_Removed"] == true)  or  (Variable["BaseGame.Policy_Law_TermLimits_Default"] == true  or  Variable["BaseGame.Policy_Law_Honorary_Presidents"] == true  and  Variable["BaseGame.Policy_Law_Threshold_Default"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[772]`
**[WYBÓR GRACZA: ""I will not stand by while you accuse me of treachery. Get out.""]** — Mówca: **Player**
> ""I will not stand by while you accuse me of treachery. Get out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[768]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]` (*Nia Morgna: ""Not until we say our final words.""*)

### Węzeł `[773]`
**[WYBÓR GRACZA: ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""]** — Mówca: **Player**
> ""Presidential power must be maintained in a country like Sordland. Why don't you understand?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[768]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]` (*Nia Morgna: ""You will reform the country by turning it into a dictato..."*)

### Węzeł `[774]`
Mówca: **Nia Morgna**
> ""You will reform the country by turning it into a dictatorship? You are delusional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[775]`
Mówca: **Nia Morgna**
> ""Not until we say our final words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[776]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true && BaseGame.Reform..."*)
  - -> `[778]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true && BaseGame.Refo..."*)

### Węzeł `[777]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Default == true && BaseGame.P..."*)

### Węzeł `[778]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[779]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[781]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[780]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true && BaseGame.Reform_..."*)

### Węzeł `[781]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)

### Węzeł `[782]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Judiciary", "Position_NotableJustice_3", "Judiciary_NotableJustice_ArnoldDalton");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Judiciary","Position_NotableJustice_3","Judiciary_NotableJustice_ArnoldDalton");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Cabinet", "Position_JusticeMiniste..."*)

### Węzeł `[783]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Cabinet", "Position_EducationMinister", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Cabinet","Position_EducationMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations += 1; Base..."*)

### Węzeł `[784]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Cabinet", "Position_AgricultureMinister", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Cabinet","Position_AgricultureMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations += 1; Base..."*)

### Węzeł `[785]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Cabinet", "Position_HealthMinister", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Cabinet","Position_HealthMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations += 1; Base..."*)

### Węzeł `[786]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Cabinet", "Position_JusticeMinister", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Cabinet","Position_JusticeMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations += 1; Base..."*)

### Węzeł `[787]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Cabinet", "Position_EconomyMinister", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Cabinet","Position_EconomyMinister","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations += 1; Base..."*)

### Węzeł `[788]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Paskal Beniwoll", "Former Minister");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Paskal Beniwoll","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Narrator: "Paskal and Lucian left and I took a seat alone in the Whi..."*)

### Węzeł `[789]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Gus Manger", "Former Minister");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Gus Manger","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Narrator: "Gus and Lucian left and I took a seat alone in the White ..."*)

### Węzeł `[790]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Symon Holl", "Former Minister");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Symon Holl","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Narrator: "Symon and Lucian left and I took a seat alone in the Whit..."*)

### Węzeł `[791]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Nia Morgna", "Former Minister");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Nia Morgna","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Narrator: "Nia and Lucian left and I took a seat alone in the White ..."*)

### Węzeł `[792]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Ciara Walda", "Former Minister");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Ciara Walda","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "Ciara and Lucian left and I took a seat alone in the Whit..."*)

### Węzeł `[793]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true && BaseGame.Turn03_EnT_Education_Budget_Decrease == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true && Bas..."*)
  - -> `[795]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Progressive == true && B..."*)

### Węzeł `[794]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true && BaseGame.Turn03_EnT_Education_Budget_Decrease == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Narrator: "Ciara was a great asset to the administration."*)

### Węzeł `[795]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Progressive == true && BaseGame.Turn03_EnT_Education_Budget_Decrease == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true  and  Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)

### Węzeł `[796]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)
  - -> `[798]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)"*)

### Węzeł `[797]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Narrator: "Ciara was too radical for this country anyway."*)

### Węzeł `[798]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Narrator: "Her ideas were beyond acceptable for the conservative bas..."*)

### Węzeł `[799]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Ciara Walda", "Former Minister");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Ciara Walda","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_ModernEducationTechniques == true"*)

### Węzeł `[800]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Nia Morgna", "Former Minister");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Nia Morgna","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_..."*)

### Węzeł `[801]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Symon Holl", "Former Minister");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Symon Holl","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == true"*)

### Węzeł `[802]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true && BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true && BaseGame..."*)
  - -> `[804]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishDepression == true && BaseGa..."*)

### Węzeł `[803]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true && BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Narrator: "Symon had failed his job and could always be replaced by ..."*)

### Węzeł `[804]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishDepression == true && BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true  and  Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == false"*)

### Węzeł `[805]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == false"*)
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishDepression == false)"*)

### Węzeł `[806]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]` (*Narrator: "He was a true bureaucrat with clear purpose. I respected ..."*)

### Węzeł `[807]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishDepression == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[808]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[810]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[809]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Narrator: "My skepticism about Symon had never ceased and this depar..."*)

### Węzeł `[810]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]` (*Narrator: "He was a true bureaucrat with clear purpose. I respected ..."*)

### Węzeł `[811]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Gus Manger", "Former Minister");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Gus Manger","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_RailwayProject == true"*)

### Węzeł `[812]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[814]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[813]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Narrator: "Gus was nothing but a leech that survived on connections ..."*)

### Węzeł `[814]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Narrator: "Mr. Manger didn't leave much of a mark both positive and ..."*)

### Węzeł `[815]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Paskal Beniwoll", "Former Minister");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Paskal Beniwoll","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_QualityRuralHealthServices == ..."*)

### Węzeł `[816]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_QualityRuralHealthServices == true || BaseGame.Policy_Welfare_HealthReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_QualityRuralHealthServices == ..."*)
  - -> `[818]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_QualityRuralHealthServices =..."*)

### Węzeł `[817]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_QualityRuralHealthServices == true || BaseGame.Policy_Welfare_HealthReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] == true  or  Variable["BaseGame.Policy_Welfare_HealthReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Narrator: "Paskal's heart was at the right place and it's sad that h..."*)

### Węzeł `[818]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_QualityRuralHealthServices == true || BaseGame.Policy_Welfare_HealthReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_QualityRuralHealthServices"] == true  or  Variable["BaseGame.Policy_Welfare_HealthReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true"*)

### Węzeł `[819]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true"*)
  - -> `[821]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)"*)

### Węzeł `[820]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]` (*Narrator: "Paskal could have done much more but decided to leave the..."*)

### Węzeł `[821]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_EpidemicPrevented == true"*)

### Węzeł `[822]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[823]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[825]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[824]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Nia Morgna: ""Why don't we talk a bit about your *reforms*?""*)

### Węzeł `[825]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[826]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[828]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[827]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Nia Morgna: ""Why don't we talk about the permanent *emergency* situat..."*)

### Węzeł `[828]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[829]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingAnrakaLife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Cabinet_GusManger_Resign..."*)
  - -> `[831]` (*Węzeł Logiki Narracyjnej: "!(BaseGameSupport.Codex_Characters_Cabinet_GusManger_Resi..."*)

### Węzeł `[830]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingAnrakaLife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingAnrakaLife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Gus Manger: ""I have to look into other ventures in life and spend som..."*)

### Węzeł `[831]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingAnrakaLife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingAnrakaLife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Cabinet_GusManger_Resign..."*)

### Węzeł `[832]`
Mówca: **Gus Manger**
> ""I have to look into other ventures in life and spend some time with my family in Anraka. It's been a long time since I re-connected with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Gus Manger: ""I was very happy to be the part of the team you have cre..."*)

### Węzeł `[833]`
Mówca: **Gus Manger**
> ""I have to look into other ventures in life and spend some time with my family in Rizia. It's been a long time since I re-connected with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Gus Manger: ""I was very happy to be the part of the team you have cre..."*)

### Węzeł `[834]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingROGRiziaLife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Cabinet_GusManger_Resign..."*)
  - -> `[836]` (*Węzeł Logiki Narracyjnej: "!(BaseGameSupport.Codex_Characters_Cabinet_GusManger_Resi..."*)

### Węzeł `[835]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingROGRiziaLife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingROGRiziaLife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Gus Manger: ""I have to look into other ventures in life and spend som..."*)

### Węzeł `[836]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingROGRiziaLife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameSupport.Codex_Characters_Cabinet_GusManger_ResignedGasomBoomingROGRiziaLife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Gus Manger: ""I have to look into other ventures in life and spend som..."*)

### Węzeł `[837]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[838]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[839]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[838]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Nia Morgna: ""Why don't we talk a bit about your *reforms*?""*)

### Węzeł `[839]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[840]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[841]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[842]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[841]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]` (*Nia Morgna: ""Why don't we talk a bit about your *reforms*?""*)

### Węzeł `[842]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_CiaraWalda == true"*)
