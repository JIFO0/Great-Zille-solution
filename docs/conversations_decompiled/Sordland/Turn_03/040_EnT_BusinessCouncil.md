# Sordland/Turn03/EnT_BusinessCouncil

- **ID konwersacji:** `40`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/040_EnT_BusinessCouncil.md`
- **Liczba węzłów dialogowych:** 695
- **Liczba wyborów gracza:** 179

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[13]** Mikail Aven
- **[19]** Walter Tusk
- **[25]** Edith Agnoc
- **[51]** Symon Holl

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Decision_Turn02_Funeral_Attend`
- `BaseGame.Decision_Turn02_StatusReaction_BoostPolice`
- `BaseGame.Policy_Diplomacy_EmbargoingRumburg`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Prologue_Studyplace_Lachaven_Economics`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_EmergencyDecree_PoliceAuthority`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Walter_Promise_BailBusiness`
- `BaseGame.Relations_Walter_Promise_Company`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGameIsolated.Turn03_EnT_Business_GuardsOutside`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.AMorgnaWesCore`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Relations_Walter_Promise_Privatization`
- `BaseGame.Relations_Walter_Promise_Tax`
- `BaseGame.Situation_Order_Nationwide_Protests`
- `BaseGame.Situation_Order_Nationwide_Quelled`
- `BaseGame.Situation_Order_Nationwide_Revolt`
- `BaseGameIsolated.Turn03_EnT_Business_GuardsOutside`
- `BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall`
- `BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall_BludBan`
- `BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall_Poisoned`
- `BaseGameSupport.CountryReport_Turn03_Rumburg_Emergency_BannedRumburg`
- `BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedPrivatizationTusk`
- `BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedTusk`
- `BaseGameSupport.Journal_Turn03_BusinessCouncil_RejectedTusk`
- `BaseGameSupport.News_Turn03_HP_Emergency_WPBArrests`
- `BaseGameSupport.News_Turn03_HP_WorkerBillDrafted`
- `BaseGameSupport.News_Turn03_LT_LeagueWomenMarch`
- `BaseGameSupport.News_Turn03_LT_LeagueWomenStrike`
- `BaseGameSupport.News_Turn03_LT_MorbelMineDisaster`
- `BaseGameSupport.News_Turn03_ST_BusinessCouncil`
- `BaseGameSupport.Report_Turn03_Anrica_Emergency_SuspendedProtests`
- `BaseGameSupport.Report_Turn03_Arvory_BombAttack`
- `BaseGameSupport.Report_Turn03_Jen_Emergency_YSBanned`
- `BaseGameSupport.Report_Turn03_Laren_Emergency_DetentionWithoutTrial`
- `BaseGameSupport.Report_Turn03_Lenkurg_Emergency_PoliceAuthority`
- `BaseGameSupport.Report_Turn03_Ribel_SchoolPoisoning`
- `BaseGameSupport.Report_Turn03_Sarna_Emergency_Surveillance`
- `GameCondition.Turn03_EnT_BusinessCouncil`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"Enter the car."** | `[31]` **Narrator**: "Walter left and Serge came to pi..."<br>`[633]` **Player_Italic**: "I ignored him."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.CountryReport_Turn03_Rumburg_Em...`<br>`Variable["BaseGameSupport.News_Turn03_ST_BusinessCouncil"...`<br>*(+2 skryptów)* | *Koniec sceny / Terminal* |
| `[7]` | **"“I'm all ears.”"** | `[54]` **Walter Tusk**: "“Usually the Lotherberg spokesma..."<br>`[640]` **Walter Tusk**: "“Please let me briefly explain m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Walter Tusk**: "“It seems that you have decided ..."<br>`[36]` **Walter Tusk**: ""We are really concerned about t..."<br>*(oraz 1 innych odgałęzień)* |
| `[8]` | **"“Sure, if you have to.”"** | `[54]` **Walter Tusk**: "“Usually the Lotherberg spokesma..."<br>`[640]` **Walter Tusk**: "“Please let me briefly explain m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Walter Tusk**: "“It seems that you have decided ..."<br>`[36]` **Walter Tusk**: ""We are really concerned about t..."<br>*(oraz 1 innych odgałęzień)* |
| `[12]` | **"“I'm glad that the group is supportive.”"** | `[10]` **Walter Tusk**: "“The consensus is that we see ey..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Walter Tusk**: "“There are many who put their tr..." |
| `[13]` | **"“What can be done to amend the situation?”"** | `[50]` **Walter Tusk**: "“You broke that promise and didn..."<br>`[597]` **Walter Tusk**: "“You broke that promise. This ac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Walter Tusk**: "“If the administration were to p..." |
| `[14]` | **"“Promises made during the election had to be upheld. That was the main reason behi..."** | `[11]` **Walter Tusk**: "“Many in the group are disappoin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Walter Tusk**: "“Political motivations are admir..." |
| `[15]` | **"“The opinions of the Lotherberg group don't concern me. I will make choices on my ..."** | `[50]` **Walter Tusk**: "“You broke that promise and didn..."<br>`[597]` **Walter Tusk**: "“You broke that promise. This ac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Walter Tusk**: "“They represent a large collecti..." |
| `[22]` | **"“I will give large private corporations a tax reduction.” [Promise Tax Cut]"** | `[53]` **Walter Tusk**: "“To boost the economy with job c..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn03_BusinessCouncil_...` | `[24]` **Walter Tusk**: "“I'm very satisfied to hear this..." |
| `[23]` | **"“I will make tax decisions objectively. Can't promise you anything.”"** | `[53]` **Walter Tusk**: "“To boost the economy with job c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Walter Tusk**: "“Oh let's not be hasty. The rece..." |
| `[27]` | **"“Maybe meeting in the middle is the solution.”"** | `[26]` **Walter Tusk**: "“It's hard to argue against comp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Walter Tusk**: "“If the administration were to p..." |
| `[28]` | **"“This time it isn't. I won't change my mind.”"** | `[26]` **Walter Tusk**: "“It's hard to argue against comp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Walter Tusk**: "“Oh let's not be hasty. The rece..." |
| `[60]` | **"“I'm interested to collaborate further in our shared interests.”"** | `[10]` **Walter Tusk**: "“The consensus is that we see ey..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Walter Tusk**: "“Then we have the right attitude!”" |
| `[61]` | **"“I will give a private corporation tax cut and enable privatization in health and ..."** | `[59]` **Walter Tusk**: "“From our end the previous misha..."<br>`[87]` **Walter Tusk**: "“The last time obviously caused ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Walter_Promise_Privatization...`<br>`Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`<br>*(+2 skryptów)* | `[24]` **Walter Tusk**: "“I'm very satisfied to hear this..." |
| `[62]` | **"“I will make tax and privatization decisions objectively. Can't promise you anythi..."** | `[59]` **Walter Tusk**: "“From our end the previous misha..."<br>`[87]` **Walter Tusk**: "“The last time obviously caused ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Walter Tusk**: "“Oh let's not be hasty. The rece..." |
| `[73]` | **"“[Request Bribe] I would want a financial contribution from your end.”"** | `[59]` **Walter Tusk**: "“From our end the previous misha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Walter Tusk**: "“The last time obviously caused ..." |
| `[74]` | **"“We are certainly interested in maintaining a good relationship with Lotherberg.”"** | `[11]` **Walter Tusk**: "“Many in the group are disappoin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Walter Tusk**: "“In that case we can move toward..." |
| `[75]` | **"“Good to know but not sure how this concerns me.”"** | `[10]` **Walter Tusk**: "“The consensus is that we see ey..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Walter Tusk**: "“Oh it definitely should, Presid..." |
| `[76]` | **"“We don't share similar interests with Lotherberg.”"** | `[11]` **Walter Tusk**: "“Many in the group are disappoin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Walter Tusk**: "“Yet we live in the same country..." |
| `[83]` | **"“I will think about it but not now.”"** | `[72]` **Walter Tusk**: "“Either way... President, we are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "Walter left and Serge came to pi..." |
| `[84]` | **"“There is nothing to work together on. Good evening.”"** | `[72]` **Walter Tusk**: "“Either way... President, we are..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn03_BusinessCouncil_...` | `[31]` **Narrator**: "Walter left and Serge came to pi..." |
| `[85]` | **"“It is assuring to know that we are allies.”"** | `[66]` **Narrator**: "He smiled." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Walter Tusk**: "“See you, President.”" |
| `[86]` | **"“Glad we could come to an agreement, Walter.”"** | `[66]` **Narrator**: "He smiled." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Walter Tusk**: "“See you, President.”" |
| `[90]` | **"“I don't think so, I have other plans for the economy.”"** | `[89]` **Walter Tusk**: "“Why can't we all just be friends?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Walter Tusk**: "“That's a shame. I did offer you..." |
| `[91]` | **""Maybe we can. I'll see what I can do.""** | `[89]` **Walter Tusk**: "“Why can't we all just be friends?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Walter Tusk**: "“Excellent! Glad to hear this.”" |
| `[100]` | **"“I will give a private corporation tax cut and enable privatization in health and ..."** | `[96]` **Walter Tusk**: "“The group wants a private corpo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Walter_Promise_Privatization...`<br>`Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`<br>*(+2 skryptów)* | `[24]` **Walter Tusk**: "“I'm very satisfied to hear this..." |
| `[101]` | **"“That is too much of an ask. On third thought, I have to reject.”"** | `[96]` **Walter Tusk**: "“The group wants a private corpo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Walter Tusk**: "“That's a shame. I did offer you..." |
| `[102]` | **"“I will pass a private corporation tax cut.” [Promise Tax Cut]"** | `[97]` **Walter Tusk**: "“The only thing the Group wants ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn03_BusinessCouncil_...` | `[24]` **Walter Tusk**: "“I'm very satisfied to hear this..." |
| `[103]` | **"“That is too much of an ask. On third thought, I have to reject.”"** | `[97]` **Walter Tusk**: "“The only thing the Group wants ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Walter Tusk**: "“That's a shame. I did offer you..." |
| `[118]` | **"“Don't get me wrong, Mr. Tusk, but of course I've tasted this greatness many times..."** | `[122]` **Walter Tusk**: "“I recommend the Lachaven Salmon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Walter Tusk**: "“Excuse me, President. I should ..." |
| `[123]` | **"Order Lachaven Salmon."** | `[116]` **Walter Tusk**: "“I recommend the Lachaven Salmon..."<br>`[122]` **Walter Tusk**: "“I recommend the Lachaven Salmon..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Player_Italic**: "I ordered rice."<br>`[130]` **Player_Italic**: "I ordered salad."<br>*(oraz 1 innych odgałęzień)* |
| `[124]` | **"Order Lespian Pasta."** | `[116]` **Walter Tusk**: "“I recommend the Lachaven Salmon..."<br>`[127]` **Walter Tusk**: "“Really? Too bad. I guess that's..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Player_Italic**: "I ordered salad."<br>`[129]` **Player_Italic**: "I did not order any other dish a..."<br>*(oraz 1 innych odgałęzień)* |
| `[125]` | **"“I appreciate the advice but I don't like salmon.""** | `[116]` **Walter Tusk**: "“I recommend the Lachaven Salmon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Walter Tusk**: "“Really? Too bad. I guess that's..." |
| `[126]` | **"Order traditional Sordish bean stew."** | `[116]` **Walter Tusk**: "“I recommend the Lachaven Salmon..."<br>`[122]` **Walter Tusk**: "“I recommend the Lachaven Salmon..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Player_Italic**: "I ordered rice."<br>`[130]` **Player_Italic**: "I ordered salad."<br>*(oraz 1 innych odgałęzień)* |
| `[129]` | **"Order no more."** | `[123]` **Player_Italic**: "I ordered Lachaven Salmon for th..."<br>`[124]` **Player_Italic**: "I ordered Lespian pasta for the ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Walter Tusk**: ""You should couple that dish wit..." |
| `[130]` | **"Order salad."** | `[123]` **Player_Italic**: "I ordered Lachaven Salmon for th..."<br>`[124]` **Player_Italic**: "I ordered Lespian pasta for the ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Narrator**: "The servers placed glasses in fr..." |
| `[131]` | **"Order rice."** | `[123]` **Player_Italic**: "I ordered Lachaven Salmon for th..."<br>`[126]` **Player_Italic**: "I ordered traditional Sordish be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Narrator**: "The servers placed glasses in fr..." |
| `[132]` | **"Order rice."** | `[124]` **Player_Italic**: "I ordered Lespian pasta for the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Walter Tusk**: ""That's two starch dishes, Presi..." |
| `[139]` | **"“Thank you but I'm fine.""** | `[133]` **Walter Tusk**: ""You should couple that dish wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Walter Tusk**: ""However you please."" |
| `[140]` | **""You're right. I'll get some salad too.""** | `[133]` **Walter Tusk**: ""You should couple that dish wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Walter Tusk**: ""Good choice."" |
| `[141]` | **""Why don't you focus on your own order, Mr. Tusk?""** | `[133]` **Walter Tusk**: ""You should couple that dish wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Walter Tusk**: ""It was just a suggestion, Presi..." |
| `[142]` | **""Why don't you focus on your own order, Mr. Tusk?""** | `[134]` **Walter Tusk**: ""That's two starch dishes, Presi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Narrator**: "One of the servers quickly jumpe..." |
| `[143]` | **"“Thank you, but this is fine.""** | `[134]` **Walter Tusk**: ""That's two starch dishes, Presi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Narrator**: "One of the servers quickly jumpe..." |
| `[144]` | **""What is your suggestion?""** | `[134]` **Walter Tusk**: ""That's two starch dishes, Presi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Narrator**: "One of the servers quickly jumpe..." |
| `[150]` | **""No, I want exactly what I ordered.""** | `[145]` **Narrator**: "One of the servers quickly jumpe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Narrator**: "The server looked uneasy. He rep..." |
| `[151]` | **""Well... Okay then. Thank you.""** | `[145]` **Narrator**: "One of the servers quickly jumpe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Narrator**: "The server respectfully bowed hi..." |
| `[152]` | **""What is this? Can't I order what I want anymore?""** | `[145]` **Narrator**: "One of the servers quickly jumpe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Narrator**: "The server looked uneasy. He rep..." |
| `[159]` | **"“Thank you.”"** | `[158]` **Mikail Aven**: ""Indeed, sir. It's an honor to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Mikail Aven**: ""We should thank Symon for organ..." |
| `[160]` | **""It's great to be here with the members of the Business Council.""** | `[158]` **Mikail Aven**: ""Indeed, sir. It's an honor to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Mikail Aven**: ""We should thank Symon for organ..." |
| `[161]` | **""Likewise.""** | `[158]` **Mikail Aven**: ""Indeed, sir. It's an honor to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Mikail Aven**: ""We should thank Symon for organ..." |
| `[166]` | **""That looks amazing.""** | `[164]` **Symon Holl**: ""Mr. President?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Walter Tusk**: ""Well, it tastes even better! Be..." |
| `[167]` | **"Nod."** | `[164]` **Symon Holl**: ""Mr. President?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Narrator**: "I took a sip." |
| `[168]` | **""Yes?""** | `[164]` **Symon Holl**: ""Mr. President?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Symon Holl**: ""Do you want some, sir? It is Ch..." |
| `[169]` | **""No, thank you.""** | `[164]` **Symon Holl**: ""Mr. President?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Walter Tusk**: ""Are you serious, Mr. Rayne? Are..." |
| `[172]` | **""What kind of question is that? Of course.""** | `[170]` **Symon Holl**: ""Do you want some, sir? It is Ch..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Narrator**: "Symon poured some wine in my gla..." |
| `[173]` | **""Let's try it.""** | `[170]` **Symon Holl**: ""Do you want some, sir? It is Ch..."<br>`[171]` **Walter Tusk**: ""Are you serious, Mr. Rayne? Are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Narrator**: "Symon poured some wine in my gla..." |
| `[174]` | **""Thank you, but I'm not going to drink this evening.""** | `[171]` **Walter Tusk**: ""Are you serious, Mr. Rayne? Are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Walter Tusk**: ""I have to insist."" |
| `[175]` | **""I'd prefer something regional or at least Sordish.""** | `[171]` **Walter Tusk**: ""Are you serious, Mr. Rayne? Are..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Walter Tusk**: ""I see. Wine patriotism."" |
| `[179]` | **""As I've said, I'm not going to drink.""** | `[177]` **Walter Tusk**: ""I have to insist."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Walter Tusk**: ""Alright, President. Nobody is f..." |
| `[180]` | **""Fine... I can't turn down a man like you, Mr. Tusk.""** | `[177]` **Walter Tusk**: ""I have to insist."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Walter Tusk**: ""Well said, President."" |
| `[181]` | **""I can't drink now when the country is suffering.""** | `[177]` **Walter Tusk**: ""I have to insist."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Walter Tusk**: ""Sad times, indeed.""<br>`[191]` **Walter Tusk**: ""Sad times, indeed."" |
| `[213]` | **"“This can't get old. It's an experience. The chef must be tipped.”"** | `[212]` **Edith Agnoc**: ""So, how did you find the food o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Walter Tusk**: ""Definitely it doesn't. But I wi..." |
| `[216]` | **"“Fine food is like fine art. But this particular one is a masterpiece.”"** | `[212]` **Edith Agnoc**: ""So, how did you find the food o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Edith Agnoc**: ""I know exactly what you mean. A..." |
| `[217]` | **""It's okay.""** | `[212]` **Edith Agnoc**: ""So, how did you find the food o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Walter Tusk**: ""Oh?"" |
| `[224]` | **"“Not a big fan of fancy food, but I must admit that it's very tasty.”"** | `[212]` **Edith Agnoc**: ""So, how did you find the food o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Walter Tusk**: "“Says the man visiting one of th..." |
| `[226]` | **""No, I loved it. I just don't like this luxurious fine dining culture.""** | `[225]` **Edith Agnoc**: ""You didn't like the food?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Edith Agnoc**: ""Oh, I understand what you mean."" |
| `[227]` | **""I liked it but it is nothing special.""** | `[225]` **Edith Agnoc**: ""You didn't like the food?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Walter Tusk**: ""I hope the manager did not hear..." |
| `[233]` | **""The pressure was already high. Not much has changed.""** | `[230]` **Mikail Aven**: ""How are things going in the Mar..."<br>`[232]` **Mikail Aven**: ""How are things going in the Mar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Mikail Aven**: ""You will get through this."" |
| `[234]` | **""It did. But it was the right decision.""** | `[230]` **Mikail Aven**: ""How are things going in the Mar..."<br>`[232]` **Mikail Aven**: ""How are things going in the Mar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Mikail Aven**: ""Of course. I didn't mean to cri..." |
| `[235]` | **""I have to say, the future is looking good.""** | `[230]` **Mikail Aven**: ""How are things going in the Mar..."<br>`[232]` **Mikail Aven**: ""How are things going in the Mar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Mikail Aven**: ""That's great to hear."" |
| `[239]` | **""It's tough but our work on the new constitution continues.""** | `[230]` **Mikail Aven**: ""How are things going in the Mar..."<br>`[232]` **Mikail Aven**: ""How are things going in the Mar..." | `Variable["BaseGame.Reform_Dictator_Path"] == true  or  Variable["BaseGame.Reform_Reformist_Path"] == true` | *Brak zmian stanu* | `[245]` **Mikail Aven**: ""We all hope so."" |
| `[240]` | **""It's tough but the new laws will fix it.""** | `[230]` **Mikail Aven**: ""How are things going in the Mar..."<br>`[232]` **Mikail Aven**: ""How are things going in the Mar..." | `(Variable["BaseGame.Reform_Dictator_Path"] == true  or  Variable["BaseGame.Reform_Reformist_Path"] == true) == false` | *Brak zmian stanu* | `[245]` **Mikail Aven**: ""We all hope so."" |
| `[255]` | **"“Make sure to lay a good foundation for our negotiations to start on.”"** | `[282]` **Symon Holl**: "“Talking of which, we are prepar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Symon Holl**: "“Our talented team is lead by Mr..." |
| `[256]` | **"“I am looking forward to those visits. It's been a long time since I left the coun..."** | `[282]` **Symon Holl**: "“Talking of which, we are prepar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Symon Holl**: "“Staalport is a relatively calm ..." |
| `[259]` | **"“Money does turn the world around. Travel is the least you can buy with it.”"** | `[251]` **Edith Agnoc**: ""All countries are nice to visit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Walter Tusk**: "“Hear, hear.”" |
| `[262]` | **""Exactly. How about the people who don't have extra cash to spend?""** | `[251]` **Edith Agnoc**: ""All countries are nice to visit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Walter Tusk**: "“What about disease? What about ..." |
| `[263]` | **"“Certainly not all.”"** | `[251]` **Edith Agnoc**: ""All countries are nice to visit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Walter Tusk**: "“Half the globe isn't worth our ..." |
| `[266]` | **"“Old men plant trees whose shade they shall never sit under.”"** | `[277]` **Walter Tusk**: "“These are matters beyond our li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Walter Tusk**: "“An idealist at heart. You know ..." |
| `[268]` | **"“Truly an egotistical way to look at the world.”"** | `[277]` **Walter Tusk**: "“These are matters beyond our li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Walter Tusk**: "“It's just facts. Life is short ..." |
| `[270]` | **"“You are right, Walter. We only live once.”"** | `[277]` **Walter Tusk**: "“These are matters beyond our li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Walter Tusk**: "“There we go! You have to let lo..." |
| `[274]` | **"“Power controls money.”"** | `[276]` **Walter Tusk**: ""So you're saying money is power."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Walter Tusk**: "“Yet rulers always use their tre..." |
| `[275]` | **"“Money holds real power.”"** | `[276]` **Walter Tusk**: ""So you're saying money is power."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Walter Tusk**: ""We see eye to eye! What a privi..." |
| `[279]` | **"“The world isn't black and white.”"** | `[277]` **Walter Tusk**: "“These are matters beyond our li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Walter Tusk**: "“You would be surprised how much..." |
| `[280]` | **"“I am not a person to be motivated or influenced by money.”"** | `[276]` **Walter Tusk**: ""So you're saying money is power."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Walter Tusk**: ""Why would you, President? Or wh..." |
| `[291]` | **"Stay silent."** | `[251]` **Edith Agnoc**: ""All countries are nice to visit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[293]` **Mikail Aven**: "“It certainly depends on what yo..." |
| `[329]` | **""It tastes like heaven. Reminds me of my father's vineyard.""** | `[328]` **Symon Holl**: ""How is it? Is the taste to your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Walter Tusk**: ""I've heard that he was a big wi..." |
| `[331]` | **""Fine balance and a nice touch of gooseberries... I like it.""** | `[328]` **Symon Holl**: ""How is it? Is the taste to your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[376]` **Walter Tusk**: ""You know your wine, Mr. Rayne. ..." |
| `[332]` | **""It has a sour and delicate vegetal character. Is it Arcasia I'm tasting?""** | `[330]` **Symon Holl**: ""How is it? Is the taste to your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Walter Tusk**: ""What? No."" |
| `[333]` | **""It tastes like heaven.""** | `[330]` **Symon Holl**: ""How is it? Is the taste to your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Walter Tusk**: ""See?"" |
| `[334]` | **""It's fine.""** | `[328]` **Symon Holl**: ""How is it? Is the taste to your..."<br>`[330]` **Symon Holl**: ""How is it? Is the taste to your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[371]` **Walter Tusk**: ""What? This wine doesn't even ne..." |
| `[335]` | **""It tastes like any other wine.""** | `[328]` **Symon Holl**: ""How is it? Is the taste to your..."<br>`[330]` **Symon Holl**: ""How is it? Is the taste to your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[371]` **Walter Tusk**: ""What? This wine doesn't even ne..." |
| `[336]` | **""Thank you for your support, Mr. Aven.""** | `[300]` **Mikail Aven**: ""I have to congratulate Mr. Rayn..."<br>`[340]` **Mikail Aven**: ""I have to congratulate Mr. Rayn..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Mikail Aven**: ""Of course."" |
| `[337]` | **""No need for that, Mr. Aven. The State is just doing its job.""** | `[300]` **Mikail Aven**: ""I have to congratulate Mr. Rayn..."<br>`[340]` **Mikail Aven**: ""I have to congratulate Mr. Rayn..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Mikail Aven**: ""Of course."" |
| `[338]` | **""I hope the investment returns will be great.""** | `[300]` **Mikail Aven**: ""I have to congratulate Mr. Rayn..."<br>`[340]` **Mikail Aven**: ""I have to congratulate Mr. Rayn..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[407]` **Mikail Aven**: ""We all hope so, Mr. President. ..." |
| `[341]` | **""That's good to hear.""** | `[340]` **Mikail Aven**: ""I have to congratulate Mr. Rayn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[409]` **Mikail Aven**: ""Mr. Holl also deserves credit, ..." |
| `[348]` | **"“Where is the property?”"** | `[349]` **Symon Holl**: "“I don't comment on rumours, but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Symon Holl**: "“It is a small seaside villa at ..." |
| `[350]` | **"“You are doing a great job so you deserve it.”"** | `[349]` **Symon Holl**: "“I don't comment on rumours, but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Edith Agnoc**: "“He *is* one of the hardest work..." |
| `[351]` | **"“A new villa is a bit much. Especially in this economy when people are suffering.”"** | `[349]` **Symon Holl**: "“I don't comment on rumours, but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[355]` **Walter Tusk**: "“So what? My car collection is n..." |
| `[352]` | **"“Maybe it shows overcompensation somewhat. Everybody is free to do whatever they w..."** | `[355]` **Walter Tusk**: "“So what? My car collection is n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[363]` **Walter Tusk**: "“Don't expect the rich to become..." |
| `[358]` | **"“Rewards give the motivation to ensure people go that extra mile.”"** | `[356]` **Edith Agnoc**: "“He *is* one of the hardest work..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Walter Tusk**: "“Depends who you work for.”" |
| `[360]` | **"“Great city to buy real estate in. Conriat is seeing a surge of investments.”"** | `[354]` **Symon Holl**: "“It is a small seaside villa at ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[362]` **Edith Agnoc**: "“Underhall Construction made a f..." |
| `[361]` | **""So you're becoming a neighbour to Marcel Koronti?""** | `[354]` **Symon Holl**: "“It is a small seaside villa at ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[472]` **Symon Holl**: ""Not really. His place is very r..." |
| `[365]` | **"“I always advocate against ostentatious behaviour. Money shouldn't be wasted for l..."** | `[355]` **Walter Tusk**: "“So what? My car collection is n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[363]` **Walter Tusk**: "“Don't expect the rich to become..." |
| `[367]` | **"“Some prefer the carrot and stick approach. I'm more result oriented.”"** | `[356]` **Edith Agnoc**: "“He *is* one of the hardest work..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Walter Tusk**: "“Depends who you work for.”" |
| `[373]` | **""I think I'm good. I won't have anything for now.""** | `[372]` **Symon Holl**: ""Should I fill your glass or wou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[382]` **Symon Holl**: ""As you wish, Mr. President."" |
| `[374]` | **""It's okay. I'll drink it.""** | `[372]` **Symon Holl**: ""Should I fill your glass or wou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Narrator**: "Symon filled up my glass." |
| `[378]` | **""Thank you.""** | `[375]` **Walter Tusk**: ""I've heard that he was a big wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Narrator**: "Symon filled up my glass." |
| `[379]` | **""Honestly, I was never close to him. I can't recall too much apart from his lavish..."** | `[375]` **Walter Tusk**: ""I've heard that he was a big wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[381]` **Walter Tusk**: ""I'm sorry to hear that."" |
| `[380]` | **"Stay silent."** | `[375]` **Walter Tusk**: ""I've heard that he was a big wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Narrator**: "Symon filled up my glass." |
| `[385]` | **""I couldn't agree more.""** | `[356]` **Edith Agnoc**: "“He *is* one of the hardest work..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Walter Tusk**: "“But talking about rewards... It..." |
| `[397]` | **""It is a necessity, Mr. Tusk. There's nothing I can do about it.""** | `[396]` **Walter Tusk**: ""What are they protecting here? ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Walter Tusk**: ""I see."" |
| `[398]` | **""They have to be prepared for everything.""** | `[396]` **Walter Tusk**: ""What are they protecting here? ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Walter Tusk**: ""I see."" |
| `[399]` | **""I can take them out, if you want, Mr. Tusk.""** | `[396]` **Walter Tusk**: ""What are they protecting here? ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[401]` **Walter Tusk**: ""Please."" |
| `[400]` | **""You're right. Can you guys leave us alone here, please?""** | `[396]` **Walter Tusk**: ""What are they protecting here? ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Narrator**: "The guards bowed their heads and..." |
| `[402]` | **""Can you guys leave us alone here, please?""** | `[401]` **Walter Tusk**: ""Please."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Narrator**: "The guards bowed their heads and..." |
| `[403]` | **""You can stay outside the door.""** | `[401]` **Walter Tusk**: ""Please."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Narrator**: "The guards bowed their heads and..." |
| `[404]` | **""Please leave the room. You scared Mr. Tusk.""** | `[401]` **Walter Tusk**: ""Please."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[626]` **Narrator**: "Walter stared at me as the guard..." |
| `[413]` | **""How can you speak like that?""** | `[355]` **Walter Tusk**: "“So what? My car collection is n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Walter Tusk**: ""I'm just saying that he's free ..." |
| `[414]` | **""Modest? Are you being sarcastic with me?""** | `[354]` **Symon Holl**: "“It is a small seaside villa at ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[474]` **Symon Holl**: ""No. Is there a problem?"" |
| `[424]` | **""The kid can handle himself. He doesn't need anybody else.”"** | `[493]` **Walter Tusk**: "“Family is everything. My advice..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[461]` **Edith Agnoc**: ""I said that about my daughter t..." |
| `[430]` | **""My childhood was very difficult. But it definitely made me stronger.""** | `[426]` **Edith Agnoc**: ""I've heard that you had a diffi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[442]` **Walter Tusk**: "“Sometimes it impacts people mor..." |
| `[431]` | **"“My family cared for me as much as they could. I couldn't ask for more than that.”"** | `[426]` **Edith Agnoc**: ""I've heard that you had a diffi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[444]` **Edith Agnoc**: ""That's very humble of you."" |
| `[432]` | **"“I try to leave my past behind and focus on today. It's who we have become that ma..."** | `[426]` **Edith Agnoc**: ""I've heard that you had a diffi..."<br>`[428]` **Edith Agnoc**: ""I've heard that you were brough..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[440]` **Mikail Aven**: "“That's what I say after a good ..." |
| `[441]` | **"“I always had a gut feeling about his sudden fall.”"** | `[423]` **Walter Tusk**: ""A correction. It wasn't his pol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[435]` **Walter Tusk**: "“He threatened their economic po..." |
| `[443]` | **""Of course it was. They are a big threat.""** | `[423]` **Walter Tusk**: ""A correction. It wasn't his pol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[435]` **Walter Tusk**: "“He threatened their economic po..." |
| `[445]` | **"“What do you mean?”"** | `[423]` **Walter Tusk**: ""A correction. It wasn't his pol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[435]` **Walter Tusk**: "“He threatened their economic po..." |
| `[447]` | **"“Look at what he caused. Studying doesn't get you to the finish line.”"** | `[434]` **Mikail Aven**: "“Talking of which, it's great th..."<br>`[503]` **Mikail Aven**: ""Not that I mean anything agains..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[436]` **Mikail Aven**: "“True, but I think it was his am..." |
| `[449]` | **""We don't talk much since I became President.""** | `[446]` **Symon Holl**: "“I never met your family, Mr. Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[450]` **Mikail Aven**: ""It can happen. Sometimes work c..." |
| `[452]` | **""I prefer not to talk about my family.""** | `[446]` **Symon Holl**: "“I never met your family, Mr. Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[491]` **Symon Holl**: ""I understand."" |
| `[453]` | **"“We are in this mess because of him. His political failure nearly destroyed us.”"** | `[434]` **Mikail Aven**: "“Talking of which, it's great th..."<br>`[503]` **Mikail Aven**: ""Not that I mean anything agains..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[448]` **Edith Agnoc**: "“We are here because of him. I d..." |
| `[454]` | **""He is going through the teenager period. It's difficult to connect with him, he's..."** | `[460]` **Walter Tusk**: "“Family is everything. My advice..."<br>`[493]` **Walter Tusk**: "“Family is everything. My advice..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Mikail Aven**: "“Wish that was my son's biggest ..." |
| `[455]` | **""Mikail. What did you just say to me?""** | `[503]` **Mikail Aven**: ""Not that I mean anything agains..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[645]` **Narrator**: "Everyone fell silent and looked ..." |
| `[456]` | **"“Alphonso was an inspiration for all reformists.""** | `[434]` **Mikail Aven**: "“Talking of which, it's great th..."<br>`[503]` **Mikail Aven**: ""Not that I mean anything agains..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[459]` **Mikail Aven**: "“He was, he truly wanted to tran..." |
| `[462]` | **"“I'm trying my best to be a good father to him. He seems to be somewhat introverted.”"** | `[460]` **Walter Tusk**: "“Family is everything. My advice..."<br>`[493]` **Walter Tusk**: "“Family is everything. My advice..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Mikail Aven**: "“Wish that was my son's biggest ..." |
| `[463]` | **""We'll see about that.""** | `[363]` **Walter Tusk**: "“Don't expect the rich to become..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[471]` **Walter Tusk**: ""What's that supposed to mean?"" |
| `[464]` | **""Some people are more sensible. I believe balance is possible.""** | `[363]` **Walter Tusk**: "“Don't expect the rich to become..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[366]` **Symon Holl**: ""I agree."" |
| `[465]` | **""The gap between the rich and the poor is the root cause of this.""** | `[363]` **Walter Tusk**: "“Don't expect the rich to become..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[466]` **Symon Holl**: "“Some of us are more sensible th..." |
| `[467]` | **""Why?""** | `[349]` **Symon Holl**: "“I don't comment on rumours, but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[468]` **Symon Holl**: ""I already had my eye on the are..." |
| `[480]` | **""It didn't contribute much. My success has nothing to do with that.""** | `[481]` **Edith Agnoc**: "“Would you say that it contribut..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[487]` **Walter Tusk**: ""Of course not. You've worked ha..." |
| `[482]` | **""It was difficult times in the capital. But I've learned a lot about politics.""** | `[428]` **Edith Agnoc**: ""I've heard that you were brough..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[484]` **Walter Tusk**: ""It all makes sense now!"" |
| `[483]` | **""I didn't suffer much thanks to my family. We didn't have much but we were stable.""** | `[428]` **Edith Agnoc**: ""I've heard that you were brough..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[444]` **Edith Agnoc**: ""That's very humble of you."" |
| `[485]` | **""It certainly helped. Money opened a lot of doors.""** | `[481]` **Edith Agnoc**: "“Would you say that it contribut..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[488]` **Walter Tusk**: ""Of course it did. What kind of ..." |
| `[486]` | **""We had money but we weren't happy. I learned a lot about life thanks to my absent..."** | `[481]` **Edith Agnoc**: "“Would you say that it contribut..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[489]` **Edith Agnoc**: ""I'm sorry to hear that."" |
| `[490]` | **""They're doing great. We have no problems.""** | `[446]` **Symon Holl**: "“I never met your family, Mr. Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[492]` **Symon Holl**: ""That's great to hear. Your son ..." |
| `[494]` | **""I said: I don't want to talk about my family.""** | `[460]` **Walter Tusk**: "“Family is everything. My advice..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[495]` **Walter Tusk**: ""I'm sorry, President. Let me kn..." |
| `[496]` | **""Why do you even care?""** | `[493]` **Walter Tusk**: "“Family is everything. My advice..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[497]` **Walter Tusk**: ""I'm just giving advice, Preside..." |
| `[506]` | **""Thank you.""** | `[434]` **Mikail Aven**: "“Talking of which, it's great th..."<br>`[505]` **Mikail Aven**: ""I'm very confident in your abil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[507]` **Mikail Aven**: ""I hope we can repair the damage..." |
| `[508]` | **""I believe that too.""** | `[423]` **Walter Tusk**: ""A correction. It wasn't his pol..." | `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false` | *Brak zmian stanu* | `[435]` **Walter Tusk**: "“He threatened their economic po..." |
| `[520]` | **"“What do you mean?”"** | `[518]` **Narrator**: "Walter looked at the guards insi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Walter Tusk**: ""Let's just say that he threaten..." |
| `[521]` | **"“I always had a bad feeling about his sudden fall.”"** | `[518]` **Narrator**: "Walter looked at the guards insi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Walter Tusk**: ""Let's just say that he threaten..." |
| `[522]` | **"“Everybody knows that.”"** | `[518]` **Narrator**: "Walter looked at the guards insi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Walter Tusk**: ""Let's just say that he threaten..." |
| `[524]` | **""And?""** | `[518]` **Narrator**: "Walter looked at the guards insi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Walter Tusk**: ""Let's just say that he threaten..." |
| `[530]` | **""You don't want to say this again in public.""** | `[423]` **Walter Tusk**: ""A correction. It wasn't his pol..." | `Variable["BaseGame.Reform_Autocrat_Path"] == true` | *Brak zmian stanu* | `[531]` **Narrator**: "There was a brief silence." |
| `[533]` | **"“Symon would you give a toast again?”"** | `[536]` **Narrator**: "The waiters brought one of the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[534]` **Symon Holl**: "“Sure.”" |
| `[537]` | **"“I raise to our health and happiness.”"** | `[557]` **Player_Italic**: "I stood up to give a toast." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[544]` **Edith Agnoc**: "“I would gladly drink to that.”" |
| `[538]` | **"“To a constructive and beneficial future!”"** | `[557]` **Player_Italic**: "I stood up to give a toast." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[548]` **Walter Tusk**: "“They say hope dies last, to the..." |
| `[539]` | **"“To our wealth and success!”"** | `[557]` **Player_Italic**: "I stood up to give a toast." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[547]` **Symon Holl**: "“Aye.”" |
| `[543]` | **"“It's getting late. Let's call it a night.”"** | `[550]` **Edith Agnoc**: "“I want to thank you, Mr. Presid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[541]` **Walter Tusk**: "“I agree.”" |
| `[555]` | **""Thank you Edith, for joining with a bunch of ugly rich men.""** | `[550]` **Edith Agnoc**: "“I want to thank you, Mr. Presid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[553]` **Mikail Aven**: ""That's definitely not me."" |
| `[557]` | **"Toast."** | `[536]` **Narrator**: "The waiters brought one of the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[537]` **Player**: "“I raise to our health and happi..."<br>`[538]` **Player**: "“To a constructive and beneficia..."<br>*(oraz 2 innych odgałęzień)* |
| `[558]` | **""I'm not going to drink.""** | `[536]` **Narrator**: "The waiters brought one of the f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[565]` **Walter Tusk**: ""Fine."" |
| `[560]` | **"“To an equal society without class differences. A Morgna wes core!""** | `[557]` **Player_Italic**: "I stood up to give a toast." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame....` | `[562]` **Symon Holl**: ""Aye!"" |
| `[568]` | **""Thank you all for being here.""** | `[550]` **Edith Agnoc**: "“I want to thank you, Mr. Presid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[570]` **Mikail Aven**: ""It was great."" |
| `[623]` | **""What's that supposed to mean?""** | `[481]` **Edith Agnoc**: "“Would you say that it contribut..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[624]` **Edith Agnoc**: ""Oh. N-Nothing, Mr. President. I..." |
| `[631]` | **""What do you want?""** | `[70]` **Narrator**: "He called me inside the small VI..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Walter Tusk**: "“Usually the Lotherberg spokesma..." |
| `[632]` | **"Follow him."** | `[69]` **Narrator**: "He gestured at the guards and th..."<br>`[70]` **Narrator**: "He called me inside the small VI..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Walter Tusk**: "“Usually the Lotherberg spokesma..." |
| `[633]` | **"Ignore him and leave."** | `[69]` **Narrator**: "He gestured at the guards and th..."<br>`[70]` **Narrator**: "He called me inside the small VI..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Player_Italic**: "I entered the car and we drove t..." |
| `[635]` | **"“I couldn't care less.”"** | `[11]` **Walter Tusk**: "“Many in the group are disappoin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[636]` **Walter Tusk**: "“Oh but you definitely should, P..." |
| `[637]` | **"“I don't want to hear your comments, Mr. Tusk.”"** | `[54]` **Walter Tusk**: "“Usually the Lotherberg spokesma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[638]` **Walter Tusk**: "“You don't mean that.”" |
| `[641]` | **""Maybe some other time. Good evening.""** | `[640]` **Walter Tusk**: "“Please let me briefly explain m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[642]` **Narrator**: "I ignored him and left." |
| `[644]` | **"“Lotherberg will not influence me.”"** | `[53]` **Walter Tusk**: "“To boost the economy with job c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Walter Tusk**: "“Oh let's not be hasty. The rece..." |
| `[650]` | **""Fine.""** | `[648]` **Narrator**: "Walter laughed and Mikail joined..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[649]` **Edith Agnoc**: "“Enough with this Alphonso talk...." |
| `[651]` | **""No. What did he just say?""** | `[648]` **Narrator**: "Walter laughed and Mikail joined..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[652]` **Narrator**: "Nobody responded." |
| `[653]` | **""I thought so.""** | `[652]` **Narrator**: "Nobody responded." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[649]` **Edith Agnoc**: "“Enough with this Alphonso talk...." |
| `[654]` | **""WILL SOMEBODY ANSWER ME?""** | `[652]` **Narrator**: "Nobody responded." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[656]` **Mikail Aven**: ""No need to shout at the table, ..." |
| `[655]` | **""Looks like a cat caught our friend's tongue.""** | `[652]` **Narrator**: "Nobody responded." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[649]` **Edith Agnoc**: "“Enough with this Alphonso talk...." |
| `[657]` | **""Enough. I'm done with this dinner.""** | `[656]` **Mikail Aven**: ""No need to shout at the table, ..."<br>`[659]` **Mikail Aven**: ""I said 'Ewald Alphonso was the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[661]` **Narrator**: "I stood up and left the room." |
| `[658]` | **""You still didn't give me a response.""** | `[656]` **Mikail Aven**: ""No need to shout at the table, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[659]` **Mikail Aven**: ""I said 'Ewald Alphonso was the ..." |
| `[660]` | **""Fine. Watch your words next time.""** | `[659]` **Mikail Aven**: ""I said 'Ewald Alphonso was the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[649]` **Edith Agnoc**: "“Enough with this Alphonso talk...." |
| `[667]` | **"“I appreciate the advice but I don't like salmon.""** | `[122]` **Walter Tusk**: "“I recommend the Lachaven Salmon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[668]` **Walter Tusk**: "“Really? As a Lachavener, too?"" |

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
  - -> `[106]` (*Narrator: "We were in Lachaven to work with the Business Council to ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "Enter the car."]** — Mówca: **Player_Italic**
> "I entered the car and we drove to our residence in Lachaven. Serge took the seaside route."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator), `[633]` (Player_Italic), `[642]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Policy_..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Walter Tusk: "“The consensus is that we see eye to eye in the economic ..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Walter Tusk: "“Many in the group are disappointed in the economic direc..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“I'm all ears.”"]** — Mówca: **Player**
> "“Go ahead, I'm all ears.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Walter Tusk), `[640]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Sure, if you have to.”"]** — Mówca: **Player**
> "“Sure, if you have to.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Walter Tusk), `[640]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Walter lit his cigar and took a few drags before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[10]`
Mówca: **Walter Tusk**
> "“The consensus is that we see eye to eye in the economic direction you have taken by promoting a market economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "“I'm glad that the group is supportive.”"*)
  - -> `[60]` (*Player: "“I'm interested to collaborate further in our shared inte..."*)
  - -> `[75]` (*Player: "“Good to know but not sure how this concerns me.”"*)

### Węzeł `[11]`
Mówca: **Walter Tusk**
> "“Many in the group are disappointed in the economic direction that you took by promoting an inefficient planned economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: "“Promises made during the election had to be upheld. That..."*)
  - -> `[74]` (*Player: "“We are certainly interested in maintaining a good relati..."*)
  - -> `[76]` (*Player: "“We don't share similar interests with Lotherberg.”"*)
  - -> `[635]` (*Player: "“I couldn't care less.”"*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“I'm glad that the group is supportive.”"]** — Mówca: **Player**
> "“I'm glad that the group is supportive of the decision. It was calculated.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Walter Tusk: "“There are many who put their trust in you.”"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“What can be done to amend the situation?”"]** — Mówca: **Player**
> "“I want the situation to be resolved. What can be done to amend the situation?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Walter Tusk), `[597]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Walter Tusk: "“If the administration were to pass a private corporation..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“Promises made during the election had to be upheld. That was the main reason behind the decision.”"]** — Mówca: **Player**
> "“Promises made during the election had to be upheld. That was the main reason behind the decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Walter Tusk: "“Political motivations are admirable but economics is abo..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“The opinions of the Lotherberg group don't concern me. I will make choices on my own accord.”"]** — Mówca: **Player**
> "“The opinions of the Lotherberg group don't concern me. I will make choices on my own accord.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Walter Tusk), `[597]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Walter Tusk: "“They represent a large collective of economic power. Coo..."*)

### Węzeł `[16]`
Mówca: **Walter Tusk**
> "“If the administration were to pass a private corporation tax cut and privatise both healthcare and education, it would do wonders in the attitude of Lotherberg towards the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Walter Tusk: "“Privatization can lead to a many good things, President ..."*)

### Węzeł `[17]`
Mówca: **Walter Tusk**
> "“Dissatisfaction of Lotherberg should concern you, Mr. President. It should concern you very much. Especially after you took our 'contribution' and didn't act on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Walter Tusk: "“It's hard to argue against compromise.”"*)

### Węzeł `[18]`
Mówca: **Walter Tusk**
> "“They represent a large collective of economic power. Cooperation would be helpful in solving the recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Walter didn't look satisfied."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "Walter didn't look satisfied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Walter Tusk: "“Dissatisfaction of Lotherberg should concern you, Mr. Pr..."*)

### Węzeł `[20]`
Mówca: **Walter Tusk**
> "“Political motivations are admirable but economics is about numbers and the current reality, not the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "He looked me in the eye."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Tax = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedTu..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“I will give large private corporations a tax reduction.” [Promise Tax Cut]"]** — Mówca: **Player**
> "“I will give large private corporations a tax reduction.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Tax = true"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“I will make tax decisions objectively. Can't promise you anything.”"]** — Mówca: **Player**
> "“I will make tax decisions objectively. Can't promise you anything.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Walter Tusk: "“Oh let's not be hasty. The recession will end if Lotherb..."*)

### Węzeł `[24]`
Mówca: **Walter Tusk**
> "“I'm very satisfied to hear this. To us and the prosperous future of Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "He smiled."*)

### Węzeł `[25]`
Mówca: **Walter Tusk**
> "“Oh let's not be hasty. The recession will end if Lotherberg is on your side, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Walter Tusk: "“Why can't we all just be friends?”"*)

### Węzeł `[26]`
Mówca: **Walter Tusk**
> "“It's hard to argue against compromise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "“Maybe meeting in the middle is the solution.”"*)
  - -> `[28]` (*Player: "“This time it isn't. I won't change my mind.”"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Maybe meeting in the middle is the solution.”"]** — Mówca: **Player**
> "“Maybe meeting in the middle is the solution.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Walter Tusk: "“If the administration were to pass a private corporation..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“This time it isn't. I won't change my mind.”"]** — Mówca: **Player**
> "“This time it isn't. I won't change my mind.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Walter Tusk: "“Oh let's not be hasty. The recession will end if Lotherb..."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "Walter smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "He looked me in the eye."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_EnT_BusinessCouncil = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_EnT_BusinessCouncil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Walter left and Serge came to pick me up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player_Italic: "Enter the car."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Walter Tusk: "“It seems that you have decided to tackle the Old Guard i..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[35]`
Mówca: **Walter Tusk**
> "“It seems that you have decided to tackle the Old Guard in the new Constitution. That is brave indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Walter Tusk: ""We could be a strong ally in breaking that status quo, i..."*)

### Węzeł `[36]`
Mówca: **Walter Tusk**
> ""We are really concerned about the state of emergency. We found ourselves worrying about the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Walter Tusk: "“We need stability for business to function. So if you wa..."*)

### Węzeł `[37]`
Mówca: **Walter Tusk**
> "“Finally a President that listens to the people. It won't be easy to pass the new Constitution through the Assembly and the Supreme Court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Walter Tusk: "“We could help you get it through, if you in return help ..."*)

### Węzeł `[38]`
Mówca: **Walter Tusk**
> ""We could be a strong ally in breaking that status quo, if you fulfil our requests. We can help with the Assembly and perhaps the Court...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Walter lit his cigar and took a few drags before continuing."*)

### Węzeł `[39]`
Mówca: **Walter Tusk**
> "“We could help you get it through, if you in return help us with a few economic requests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Walter lit his cigar and took a few drags before continuing."*)

### Węzeł `[40]`
Mówca: **Walter Tusk**
> "“We need stability for business to function. So if you want us on your side with our capital there are a few requests on our end.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Walter lit his cigar and took a few drags before continuing."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_Company == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Walter Tusk: "“We had a deal about the first mega infrastructure project.”"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_Company == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Walter Tusk: "“You rejected our previous discrete offer to pick Underha..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_CompanyFulfilled == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_CompanyFulfilled == t..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Walter Tusk: "“You held on to that promise and awarded the contract to ..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Walter Tusk: "“You broke that promise and didn't award the contract to ..."*)

### Węzeł `[47]`
Mówca: **Walter Tusk**
> "“We had a deal about the first mega infrastructure project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_CompanyFulfilled == true"*)

### Węzeł `[48]`
Mówca: **Walter Tusk**
> "“You rejected our previous discrete offer to pick Underhall Construction for the execution of the first mega infrastructure project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[49]`
Mówca: **Walter Tusk**
> "“You held on to that promise and awarded the contract to Underhall Construction. This went well in our book.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content = true"*)

### Węzeł `[50]`
Mówca: **Walter Tusk**
> "“You broke that promise and didn't award the contract to Underhall Construction. This action led to a huge disappointment in the Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "“What can be done to amend the situation?”"*)
  - -> `[15]` (*Player: "“The opinions of the Lotherberg group don't concern me. I..."*)

### Węzeł `[51]`
Mówca: **Walter Tusk**
> "“However, you still made the right choice. Your party not getting that donation is unfortunate though. Why someone wouldn't want that money is beyond me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content = true"*)

### Węzeł `[52]`
Mówca: **Walter Tusk**
> "“We are aware of the upcoming tax meeting and it would be a step in the right direction if private corporations would get a tax cut.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Walter Tusk: "“To boost the economy with job creation, of course... And..."*)

### Węzeł `[53]`
Mówca: **Walter Tusk**
> "“To boost the economy with job creation, of course... And the positive side effect would be our support to the administration throughout the entire term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“I will give large private corporations a tax reduction.”..."*)
  - -> `[23]` (*Player: "“I will make tax decisions objectively. Can't promise you..."*)
  - -> `[644]` (*Player: "“Lotherberg will not influence me.”"*)

### Węzeł `[54]`
Mówca: **Walter Tusk**
> "“Usually the Lotherberg spokesman doesn't directly comment on the administration, but I'd like to say a few things since this was a special evening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "“I'm all ears.”"*)
  - -> `[8]` (*Player: "“Sure, if you have to.”"*)
  - -> `[637]` (*Player: "“I don't want to hear your comments, Mr. Tusk.”"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction =..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Walter Tusk: "“However, you still made the right choice. Your party not..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Walter Tusk: "“This action led to disappointment in the Group.”"*)

### Węzeł `[58]`
Mówca: **Walter Tusk**
> "“This action led to disappointment in the Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Walter Tusk: "“We are aware of the upcoming tax meeting and it would be..."*)

### Węzeł `[59]`
Mówca: **Walter Tusk**
> "“From our end the previous mishap would be cleared and confidence in the new administration from the business community would be restored.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: "“[Request Bribe] I would want a financial contribution fr..."*)
  - -> `[61]` (*Player: "“I will give a private corporation tax cut and enable pri..."*)
  - -> `[62]` (*Player: "“I will make tax and privatization decisions objectively...."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“I'm interested to collaborate further in our shared interests.”"]** — Mówca: **Player**
> "“I'm interested to collaborate further in our shared interests.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Walter Tusk: "“Then we have the right attitude!”"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“I will give a private corporation tax cut and enable privatization in health and education.” [Promise Tax Cut]"]** — Mówca: **Player**
> "“I will give a private corporation tax cut and enable privatization in health and education.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Walter Tusk), `[87]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Privatization = true"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“I will make tax and privatization decisions objectively. Can't promise you anything.”"]** — Mówca: **Player**
> "“I will make tax and privatization decisions objectively. Can't promise you anything.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Walter Tusk), `[87]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Walter Tusk: "“Oh let's not be hasty. The recession will end if Lotherb..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Privatization = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Privatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Tax = true"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Tax = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedPr..."*)

### Węzeł `[65]`
Mówca: **Walter Tusk**
> "“Privatization can lead to a many good things, President Rayne. It is certainly an opportunity to raise further money inside the welfare branches.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Walter Tusk: "“From our end the previous mishap would be cleared and co..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "“It is assuring to know that we are allies.”"*)
  - -> `[86]` (*Player: "“Glad we could come to an agreement, Walter.”"*)

### Węzeł `[67]`
Mówca: **Narrator**
> "There was an awkward silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Walter Tusk: "“Either way... President, we are here and always ready to..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Walter Tusk: "“We are aware of the upcoming tax meeting and it would be..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "He gestured at the guards and then called me inside the small VIP lounge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Player_Italic: "Ignore him and leave."*)
  - -> `[632]` (*Player_Italic: "Follow him."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "He called me inside the small VIP lounge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Player_Italic: "Ignore him and leave."*)
  - -> `[632]` (*Player_Italic: "Follow him."*)
  - -> `[631]` (*Player: ""What do you want?""*)

### Węzeł `[71]`
Mówca: **Walter Tusk**
> "“President. A moment alone please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[72]`
Mówca: **Walter Tusk**
> "“Either way... President, we are here and always ready to work with you if you change your mind. Don't forget that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "“There is nothing to work together on. Good evening.”"*)
  - -> `[83]` (*Player: "“I will think about it but not now.”"*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“[Request Bribe] I would want a financial contribution from your end.”"]** — Mówca: **Player**
> "“I would want a financial contribution from your end.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Walter Tusk: "“The last time obviously caused some trust issues between..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“We are certainly interested in maintaining a good relationship with Lotherberg.”"]** — Mówca: **Player**
> "“We are certainly interested in maintaining a good relationship with Lotherberg.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Walter Tusk: "“In that case we can move towards a better future together.”"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Good to know but not sure how this concerns me.”"]** — Mówca: **Player**
> "“Good to know but not sure how this concerns me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Walter Tusk: "“Oh it definitely should, President.”"*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“We don't share similar interests with Lotherberg.”"]** — Mówca: **Player**
> "“We don't share similar interests with Lotherberg.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Walter Tusk: "“Yet we live in the same country don't we? Let's settle o..."*)

### Węzeł `[77]`
Mówca: **Walter Tusk**
> "“Then we have the right attitude!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "He looked me in the eye."*)

### Węzeł `[78]`
Mówca: **Walter Tusk**
> "“Oh it definitely should, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "He looked me in the eye."*)

### Węzeł `[79]`
Mówca: **Walter Tusk**
> "“In that case we can move towards a better future together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "He looked me in the eye."*)

### Węzeł `[80]`
Mówca: **Walter Tusk**
> "“Yet we live in the same country don't we? Let's settle our differences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "He looked me in the eye."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "He looked me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true || BaseGam..."*)

### Węzeł `[82]`
Mówca: **Walter Tusk**
> "“There are many who put their trust in you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Walter smiled."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“I will think about it but not now.”"]** — Mówca: **Player**
> "“I will think about it but not now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Walter left and Serge came to pick me up."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“There is nothing to work together on. Good evening.”"]** — Mówca: **Player**
> "“There is nothing to work together on. Good evening.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn03_BusinessCouncil_RejectedTu..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "“It is assuring to know that we are allies.”"]** — Mówca: **Player**
> "“It is assuring to know that we are allies.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Walter Tusk: "“See you, President.”"*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "“Glad we could come to an agreement, Walter.”"]** — Mówca: **Player**
> "“Glad we could come to an agreement, Walter.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Walter Tusk: "“See you, President.”"*)

### Węzeł `[87]`
Mówca: **Walter Tusk**
> "“The last time obviously caused some trust issues between us. We would love to contribute in the future if you agree to the terms.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: "“I will give a private corporation tax cut and enable pri..."*)
  - -> `[62]` (*Player: "“I will make tax and privatization decisions objectively...."*)

### Węzeł `[88]`
Mówca: **Walter Tusk**
> "“That's a shame. I did offer you a peace branch.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "There was an awkward silence."*)

### Węzeł `[89]`
Mówca: **Walter Tusk**
> "“Why can't we all just be friends?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: ""Maybe we can. I'll see what I can do.""*)
  - -> `[90]` (*Player: "“I don't think so, I have other plans for the economy.”"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“I don't think so, I have other plans for the economy.”"]** — Mówca: **Player**
> "“I don't think so, I have other plans for the economy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Walter Tusk: "“That's a shame. I did offer you a peace branch.”"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""Maybe we can. I'll see what I can do.""]** — Mówca: **Player**
> ""Maybe we can. I'll see what I can do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Walter Tusk: "“Excellent! Glad to hear this.”"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_CompanyFulfilled == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_CompanyFulfilled == t..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_CompanyFulfilled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Walter Tusk: "“The only thing the Group wants is a private corporation ..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_CompanyFulfilled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Walter Tusk: "“The group wants a private corporation tax cut and privat..."*)

### Węzeł `[95]`
Mówca: **Walter Tusk**
> "“Excellent! Glad to hear this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_CompanyFulfilled == true"*)

### Węzeł `[96]`
Mówca: **Walter Tusk**
> "“The group wants a private corporation tax cut and privatization in healthcare and education.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: "“I will give a private corporation tax cut and enable pri..."*)
  - -> `[101]` (*Player: "“That is too much of an ask. On third thought, I have to ..."*)

### Węzeł `[97]`
Mówca: **Walter Tusk**
> "“The only thing the Group wants is a private corporation tax cut and we will fully support your administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "“I will pass a private corporation tax cut.” [Promise Tax..."*)
  - -> `[103]` (*Player: "“That is too much of an ask. On third thought, I have to ..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Privatization = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Privatization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Tax = true"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Tax = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedPr..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“I will give a private corporation tax cut and enable privatization in health and education.” [Promise Tax Cut]"]** — Mówca: **Player**
> "“I will give a private corporation tax cut and enable privatization in health and education.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Privatization = true"*)

### Węzeł `[101]`
**[WYBÓR GRACZA: "“That is too much of an ask. On third thought, I have to reject.”"]** — Mówca: **Player**
> "“That is too much of an ask. On third thought, I have to reject.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Walter Tusk: "“That's a shame. I did offer you a peace branch.”"*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "“I will pass a private corporation tax cut.” [Promise Tax Cut]"]** — Mówca: **Player**
> "“I will pass a private corporation tax cut.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Tax = true"*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "“That is too much of an ask. On third thought, I have to reject.”"]** — Mówca: **Player**
> "“That is too much of an ask. On third thought, I have to reject.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Walter Tusk: "“That's a shame. I did offer you a peace branch.”"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Tax = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Tax"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedTu..."*)

### Węzeł `[105]`
Mówca: **Walter Tusk**
> "“See you, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Walter left and Serge came to pick me up."*)

### Węzeł `[106]`
Mówca: **Narrator**
> "We were in Lachaven to work with the Business Council to assess weaknesses in the economy. Symon organised a dinner with the affluent economic figureheads of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "We were escorted by heavily armed police forces as well a..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "When we arrived, the streets were bustling with activity ..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "Beaming with pride, he led us to a private room and got us seated at a large table, covered for the occasion with a maroon tablecloth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "We were quickly served by a group of servers. Walter spok..."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "When we arrived, the streets were quiet and police forces were patrolling everywhere. The emergency was felt in the vacant city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Together with Walter Tusk, Edith Agnoc, Mikail Aven and S..."*)

### Węzeł `[112]`
Mówca: **Narrator**
> "When we arrived, the streets were bustling with activity even though the atmosphere in the country was tense. Lachaveners didn't seem very worried."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Together with Walter Tusk, Edith Agnoc, Mikail Aven and S..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Together with Walter Tusk, Edith Agnoc, Mikail Aven and Symon Holl, we entered the renowned Esteria restaurant by the coast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "A short blonde man whose embroidered pocket read "Manager..."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "A short blonde man whose embroidered pocket read "Manager," greeted us and waved his arms in excitement as he told us how pleased he was to have us in his establishment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Beaming with pride, he led us to a private room and got u..."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "We were quickly served by a group of servers. Walter spoke as they started taking our orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)

### Węzeł `[116]`
Mówca: **Walter Tusk**
> "“I recommend the Lachaven Salmon, President. You have to taste this local delicacy here, the best in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "“I appreciate the advice but I don't like salmon.""*)
  - -> `[123]` (*Player_Italic: "Order Lachaven Salmon."*)
  - -> `[126]` (*Player_Italic: "Order traditional Sordish bean stew."*)
  - -> `[124]` (*Player_Italic: "Order Lespian Pasta."*)

### Węzeł `[117]`
Mówca: **Symon Holl**
> ""No need for that. I hope everybody enjoys the evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "Symon gestured at the expensive looking red wine bottle t..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Don't get me wrong, Mr. Tusk, but of course I've tasted this greatness many times here already."]** — Mówca: **Player**
> "“Don't get me wrong, Mr. Tusk, but of course I've tasted this greatness many times here already."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Walter Tusk: "“Excuse me, President. I should have known that a man of ..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Walter Tusk: "“I recommend the Lachaven Salmon of this place, President..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Walter Tusk: "“I recommend the Lachaven Salmon, President. You have to ..."*)

### Węzeł `[122]`
Mówca: **Walter Tusk**
> "“I recommend the Lachaven Salmon of this place, President. I know that you're from Lachaven, but I bet you haven't tasted anything like this before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Player: "“I appreciate the advice but I don't like salmon.""*)
  - -> `[118]` (*Player: "“Don't get me wrong, Mr. Tusk, but of course I've tasted ..."*)
  - -> `[123]` (*Player_Italic: "Order Lachaven Salmon."*)
  - -> `[126]` (*Player_Italic: "Order traditional Sordish bean stew."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "Order Lachaven Salmon."]** — Mówca: **Player_Italic**
> "I ordered Lachaven Salmon for the main course. The servers took their notes and asked about the second dish."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Walter Tusk), `[122]` (Walter Tusk), `[128]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player_Italic: "Order rice."*)
  - -> `[130]` (*Player_Italic: "Order salad."*)
  - -> `[129]` (*Player_Italic: "Order no more."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "Order Lespian Pasta."]** — Mówca: **Player_Italic**
> "I ordered Lespian pasta for the main course. The servers took their notes and asked about the second dish."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Walter Tusk), `[127]` (Walter Tusk), `[128]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player_Italic: "Order salad."*)
  - -> `[129]` (*Player_Italic: "Order no more."*)
  - -> `[132]` (*Player_Italic: "Order rice."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“I appreciate the advice but I don't like salmon.""]** — Mówca: **Player**
> "“I appreciate the advice but I don't like salmon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Walter Tusk: "“Really? Too bad. I guess that's your loss.""*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "Order traditional Sordish bean stew."]** — Mówca: **Player_Italic**
> "I ordered traditional Sordish bean stew for the main course. The servers took their notes and asked about the second dish."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Walter Tusk), `[122]` (Walter Tusk), `[127]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player_Italic: "Order rice."*)
  - -> `[130]` (*Player_Italic: "Order salad."*)
  - -> `[129]` (*Player_Italic: "Order no more."*)

### Węzeł `[127]`
Mówca: **Walter Tusk**
> "“Really? Too bad. I guess that's your loss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player_Italic: "Order traditional Sordish bean stew."*)
  - -> `[124]` (*Player_Italic: "Order Lespian Pasta."*)

### Węzeł `[128]`
Mówca: **Walter Tusk**
> "“Excuse me, President. I should have known that a man of your calibre would be a regular at Esteria.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player_Italic: "Order Lachaven Salmon."*)
  - -> `[126]` (*Player_Italic: "Order traditional Sordish bean stew."*)
  - -> `[124]` (*Player_Italic: "Order Lespian Pasta."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: "Order no more."]** — Mówca: **Player_Italic**
> "I did not order any other dish and thanked the servers."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Player_Italic), `[124]` (Player_Italic), `[126]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Walter Tusk: ""You should couple that dish with some Lespian salad, Pre..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "Order salad."]** — Mówca: **Player_Italic**
> "I ordered salad."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Player_Italic), `[124]` (Player_Italic), `[126]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "The servers placed glasses in front of each of us and ser..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "Order rice."]** — Mówca: **Player_Italic**
> "I ordered rice."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Player_Italic), `[126]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "The servers placed glasses in front of each of us and ser..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "Order rice."]** — Mówca: **Player_Italic**
> "I ordered rice."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Walter Tusk: ""That's two starch dishes, President. That's no good.""*)

### Węzeł `[133]`
Mówca: **Walter Tusk**
> ""You should couple that dish with some Lespian salad, President. It's no good when it's by itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player: "“Thank you but I'm fine.""*)
  - -> `[140]` (*Player: ""You're right. I'll get some salad too.""*)
  - -> `[141]` (*Player: ""Why don't you focus on your own order, Mr. Tusk?""*)

### Węzeł `[134]`
Mówca: **Walter Tusk**
> ""That's two starch dishes, President. That's no good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "“Thank you, but this is fine.""*)
  - -> `[144]` (*Player: ""What is your suggestion?""*)
  - -> `[142]` (*Player: ""Why don't you focus on your own order, Mr. Tusk?""*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_Funeral_Attend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_Attend == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_Funeral_Attend == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_Funeral_Attend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Mikail Aven: ""How are things going in the Maroon Palace? The pressure ..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_Funeral_Attend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Mikail Aven: ""How are things going in the Maroon Palace? The pressure ..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "The servers placed glasses in front of each of us and served bread and water. After they were done taking orders, they quickly left us alone in the private room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "“Thank you but I'm fine.""]** — Mówca: **Player**
> "“Thank you but I'm fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Walter Tusk: ""However you please.""*)

### Węzeł `[140]`
**[WYBÓR GRACZA: ""You're right. I'll get some salad too.""]** — Mówca: **Player**
> ""You're right. I'll get some salad too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Walter Tusk: ""Good choice.""*)

### Węzeł `[141]`
**[WYBÓR GRACZA: ""Why don't you focus on your own order, Mr. Tusk?""]** — Mówca: **Player**
> ""Why don't you focus on your own order, Mr. Tusk?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Walter Tusk: ""It was just a suggestion, President... Come now, relax.""*)

### Węzeł `[142]`
**[WYBÓR GRACZA: ""Why don't you focus on your own order, Mr. Tusk?""]** — Mówca: **Player**
> ""Why don't you focus on your own order, Mr. Tusk?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "One of the servers quickly jumped in the conversation and..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA: "“Thank you, but this is fine.""]** — Mówca: **Player**
> "“Thank you, but this is fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "One of the servers quickly jumped in the conversation and..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA: ""What is your suggestion?""]** — Mówca: **Player**
> ""What is your suggestion?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "One of the servers quickly jumped in the conversation and..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "One of the servers quickly jumped in the conversation and told me that Mr. Tusk was right, and went on to explain why two starch dishes do not go together. He then offered to prepare me something special."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: ""No, I want exactly what I ordered.""*)
  - -> `[151]` (*Player: ""Well... Okay then. Thank you.""*)
  - -> `[152]` (*Player: ""What is this? Can't I order what I want anymore?""*)

### Węzeł `[146]`
Mówca: **Walter Tusk**
> ""It was just a suggestion, President... Come now, relax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Walter Tusk: ""I only wanted you to have the best possible experience!""*)

### Węzeł `[147]`
Mówca: **Walter Tusk**
> ""I only wanted you to have the best possible experience!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "The servers placed glasses in front of each of us and ser..."*)

### Węzeł `[148]`
Mówca: **Walter Tusk**
> ""However you please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "The servers placed glasses in front of each of us and ser..."*)

### Węzeł `[149]`
Mówca: **Walter Tusk**
> ""Good choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "The servers placed glasses in front of each of us and ser..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""No, I want exactly what I ordered.""]** — Mówca: **Player**
> ""No, I want exactly what I ordered.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "The server looked uneasy. He replied, "I'm sorry, Mr. Pre..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""Well... Okay then. Thank you.""]** — Mówca: **Player**
> ""Well... Okay then. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "The server respectfully bowed his head and took notes."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""What is this? Can't I order what I want anymore?""]** — Mówca: **Player**
> ""What is this? Can't I order what I want anymore?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "The server looked uneasy. He replied, "I'm sorry, Mr. Pre..."*)

### Węzeł `[153]`
Mówca: **Walter Tusk**
> ""Oh come on. He is the President! Serve him what he wants!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "After a brief argument, the server agreed to prepare my o..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "The server looked uneasy. He replied, "I'm sorry, Mr. President. This is a very special establishment and we want to provide the best quality service. Therefore, we cannot serve two starch dishes as they do not complement each ot-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Walter Tusk: ""Oh come on. He is the President! Serve him what he wants!""*)

### Węzeł `[155]`
Mówca: **Narrator**
> "The server respectfully bowed his head and took notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "The servers placed glasses in front of each of us and ser..."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "After a brief argument, the server agreed to prepare my order and apologized."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "The servers placed glasses in front of each of us and ser..."*)

### Węzeł `[157]`
Mówca: **Edith Agnoc**
> "“Mr. President, I didn't have the possibility to thank you for coming today. Your presence means a great deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Mikail Aven: ""Indeed, sir. It's an honor to dine with you.""*)

### Węzeł `[158]`
Mówca: **Mikail Aven**
> ""Indeed, sir. It's an honor to dine with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player: "“Thank you.”"*)
  - -> `[160]` (*Player: ""It's great to be here with the members of the Business C..."*)
  - -> `[161]` (*Player: ""Likewise.""*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Mikail Aven: ""We should thank Symon for organizing this meeting.""*)

### Węzeł `[160]`
**[WYBÓR GRACZA: ""It's great to be here with the members of the Business Council.""]** — Mówca: **Player**
> ""It's great to be here with the members of the Business Council.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Mikail Aven: ""We should thank Symon for organizing this meeting.""*)

### Węzeł `[161]`
**[WYBÓR GRACZA: ""Likewise.""]** — Mówca: **Player**
> ""Likewise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Mikail Aven: ""We should thank Symon for organizing this meeting.""*)

### Węzeł `[162]`
Mówca: **Mikail Aven**
> ""We should thank Symon for organizing this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Symon Holl: ""No need for that. I hope everybody enjoys the evening.""*)

### Węzeł `[163]`
Mówca: **Walter Tusk**
> ""Well, it tastes even better! Best of Lespia, the Chateau de Falenco 1934.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "Symon poured some wine in my glass and waited for me to t..."*)

### Węzeł `[164]`
Mówca: **Symon Holl**
> ""Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Italic: "Nod."*)
  - -> `[166]` (*Player: ""That looks amazing.""*)
  - -> `[168]` (*Player: ""Yes?""*)
  - -> `[169]` (*Player: ""No, thank you.""*)

### Węzeł `[165]`
Mówca: **Narrator**
> "Symon gestured at the expensive looking red wine bottle that one of the servers had just brought to the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Symon Holl: ""Mr. President?""*)

### Węzeł `[166]`
**[WYBÓR GRACZA: ""That looks amazing.""]** — Mówca: **Player**
> ""That looks amazing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Walter Tusk: ""Well, it tastes even better! Best of Lespia, the Chateau..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded at him. He started to carefully pour some wine in my glass and waited for me to taste it before filling it up."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "I took a sip."*)

### Węzeł `[168]`
**[WYBÓR GRACZA: ""Yes?""]** — Mówca: **Player**
> ""Yes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Symon Holl: ""Do you want some, sir? It is Chateau de Falenco, from 19..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""No, thank you.""]** — Mówca: **Player**
> ""No, thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Walter Tusk: ""Are you serious, Mr. Rayne? Are you going to pass on a C..."*)

### Węzeł `[170]`
Mówca: **Symon Holl**
> ""Do you want some, sir? It is Chateau de Falenco, from 1934.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: ""What kind of question is that? Of course.""*)
  - -> `[173]` (*Player: ""Let's try it.""*)

### Węzeł `[171]`
Mówca: **Walter Tusk**
> ""Are you serious, Mr. Rayne? Are you going to pass on a Chateau de Falenco 1934?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player: ""Let's try it.""*)
  - -> `[174]` (*Player: ""Thank you, but I'm not going to drink this evening.""*)
  - -> `[175]` (*Player: ""I'd prefer something regional or at least Sordish.""*)

### Węzeł `[172]`
**[WYBÓR GRACZA: ""What kind of question is that? Of course.""]** — Mówca: **Player**
> ""What kind of question is that? Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "Symon poured some wine in my glass and waited for me to t..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA: ""Let's try it.""]** — Mówca: **Player**
> ""Let's try it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Symon Holl), `[171]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "Symon poured some wine in my glass and waited for me to t..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA: ""Thank you, but I'm not going to drink this evening.""]** — Mówca: **Player**
> ""Thank you, but I'm not going to drink this evening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Walter Tusk: ""I have to insist.""*)

### Węzeł `[175]`
**[WYBÓR GRACZA: ""I'd prefer something regional or at least Sordish.""]** — Mówca: **Player**
> ""I'd prefer something regional or at least Sordish.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Walter Tusk: ""I see. Wine patriotism.""*)

### Węzeł `[176]`
Mówca: **Walter Tusk**
> ""I see. Wine patriotism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "He laughed and gestured at the waiter to bring the best S..."*)

### Węzeł `[177]`
Mówca: **Walter Tusk**
> ""I have to insist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player: ""As I've said, I'm not going to drink.""*)
  - -> `[180]` (*Player: ""Fine... I can't turn down a man like you, Mr. Tusk.""*)
  - -> `[181]` (*Player: ""I can't drink now when the country is suffering.""*)

### Węzeł `[178]`
Mówca: **Narrator**
> "After filling everybody's glasses, Symon stood up and raised his glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Symon Holl: ""I'd like to raise a toast to all of you here today.""*)

### Węzeł `[179]`
**[WYBÓR GRACZA: ""As I've said, I'm not going to drink.""]** — Mówca: **Player**
> ""As I've said, I'm not going to drink.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Walter Tusk: ""Alright, President. Nobody is forcing you.""*)

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Fine... I can't turn down a man like you, Mr. Tusk.""]** — Mówca: **Player**
> ""Fine... I can't turn down a man like you, Mr. Tusk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Walter Tusk: ""Well said, President.""*)

### Węzeł `[181]`
**[WYBÓR GRACZA: ""I can't drink now when the country is suffering.""]** — Mówca: **Player**
> ""I can't drink now when the country is suffering.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[182]`
Mówca: **Narrator**
> "He laughed and gestured at the waiter to bring the best Sordish wine that they had."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Walter Tusk: ""It is solved.""*)

### Węzeł `[183]`
Mówca: **Walter Tusk**
> ""It is solved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "The waiter brought a bottle of 'Dandelion.' The world fam..."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "The waiter brought a bottle of 'Dandelion.' The world famous red wine from Borin. Symon went ahead and grabbed the bottle from the waiter. He poured some in my glass and waited for me to taste it before filling it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Walter Tusk: ""Ah, of course. Nobody can say no to a bottle of wine by ..."*)

### Węzeł `[185]`
Mówca: **Walter Tusk**
> ""Alright, President. Nobody is forcing you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "After everybody was served their preferred drinks, Symon ..."*)

### Węzeł `[186]`
Mówca: **Walter Tusk**
> ""Well said, President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "Symon poured some wine in my glass and waited for me to t..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Walter Tusk: ""Sad times, indeed.""*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Walter Tusk: ""Sad times, indeed.""*)

### Węzeł `[190]`
Mówca: **Walter Tusk**
> ""Sad times, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Walter Tusk: ""But don't you think you overreacted with this emergency ..."*)

### Węzeł `[191]`
Mówca: **Walter Tusk**
> ""Sad times, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "There was a brief silence at the table before Symon cut in."*)

### Węzeł `[192]`
Mówca: **Walter Tusk**
> ""But don't you think you overreacted with this emergency situation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Symon cut in."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "Symon cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Symon Holl: ""Let's not get ourselves down, gentlemen.""*)

### Węzeł `[194]`
Mówca: **Narrator**
> "There was a brief silence at the table before Symon cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Symon Holl: ""Let's not get ourselves down, gentlemen.""*)

### Węzeł `[195]`
Mówca: **Symon Holl**
> ""Let's not get ourselves down, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "After everybody was served their preferred drinks, Symon ..."*)

### Węzeł `[196]`
Mówca: **Narrator**
> "After everybody was served their preferred drinks, Symon stood up with his glass raised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Symon Holl: ""I'd like to raise a toast to all of you here today.""*)

### Węzeł `[197]`
Mówca: **Symon Holl**
> ""I'd like to raise a toast to all of you here today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Symon Holl: ""We're meeting here tonight in difficult times. But I bel..."*)

### Węzeł `[198]`
Mówca: **Symon Holl**
> ""We will get through this period as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[199]`
Mówca: **Symon Holl**
> ""We're meeting here tonight in difficult times. But I believe that, with hard work, cooperation and trust...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Symon Holl: ""We will get through this period as well.""*)

### Węzeł `[200]`
Mówca: **Symon Holl**
> ""I'd like to thank Mr. Rayne again for his decisiveness when it comes to economic policies... I'm sure we will stop this recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Symon Holl: ""I also thank Mr. Tusk for being here with us today... Hi..."*)

### Węzeł `[201]`
Mówca: **Symon Holl**
> ""I also thank Mr. Tusk for being here with us today... His presence is an honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Symon Holl: ""And of course, my colleagues from the Business Council, ..."*)

### Węzeł `[202]`
Mówca: **Symon Holl**
> ""And of course, my colleagues from the Business Council, Mrs. Agnoc and Mr. Aven. Without you, none of these would have been possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Symon Holl: ""Let's drink to future cooperation and growth.""*)

### Węzeł `[203]`
Mówca: **Symon Holl**
> ""Let's drink to future cooperation and growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Symon Holl: ""For a prosperous Sordland!""*)

### Węzeł `[204]`
Mówca: **Symon Holl**
> ""For a prosperous Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "Everybody raised their glasses and toasted each other."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "Everybody raised their glasses and toasted each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "After a couple of more minutes, the servers arrived with ..."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "After a couple of more minutes, the servers arrived with our meals."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)

### Węzeł `[207]`
Mówca: **Narrator**
> "When I tasted the food, I went back to my past. It reminded me of my childhood in this city. Even though I couldn't recall much about my father, I remembered that he also loved the food of Esteria."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "When I tasted the food, I went back to my past. It remind..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "The food tasted amazing. Walter was right, this place mus..."*)

### Węzeł `[211]`
Mówca: **Narrator**
> "The food tasted amazing. Walter was right, this place must have been the best place in all of Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[212]`
Mówca: **Edith Agnoc**
> ""So, how did you find the food of the best fine dining restaurant in Lachaven, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player: "“Not a big fan of fancy food, but I must admit that it's ..."*)
  - -> `[216]` (*Player: "“Fine food is like fine art. But this particular one is a..."*)
  - -> `[217]` (*Player: ""It's okay.""*)
  - -> `[213]` (*Player: "“This can't get old. It's an experience. The chef must be..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA: "“This can't get old. It's an experience. The chef must be tipped.”"]** — Mówca: **Player**
> "“This can't get old. It's an experience. The chef must be tipped.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Walter Tusk: ""Definitely it doesn't. But I will take care of the tip. ..."*)

### Węzeł `[214]`
Mówca: **Walter Tusk**
> ""Definitely it doesn't. But I will take care of the tip. Don't you worry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Edith Agnoc: "“Always generous when it comes to small things.”"*)

### Węzeł `[215]`
Mówca: **Mikail Aven**
> ""Tipping is no small thing. I actually don't like giving tips. People have salaries for a reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Mikail Aven: ""But anyway...""*)

### Węzeł `[216]`
**[WYBÓR GRACZA: "“Fine food is like fine art. But this particular one is a masterpiece.”"]** — Mówca: **Player**
> "“Fine food is like fine art. But this particular one is a masterpiece.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Edith Agnoc: ""I know exactly what you mean. Art is something else, it ..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA: ""It's okay.""]** — Mówca: **Player**
> ""It's okay.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Walter Tusk: ""Oh?""*)

### Węzeł `[218]`
Mówca: **Edith Agnoc**
> ""I know exactly what you mean. Art is something else, it embodies so much about us and the world surrounding our lives. And food ca-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Walter Tusk: ""There is an art of everything. The art of making money, ..."*)

### Węzeł `[219]`
Mówca: **Walter Tusk**
> ""Oh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Edith Agnoc: ""You didn't like the food?""*)

### Węzeł `[220]`
Mówca: **Walter Tusk**
> "“Says the man visiting one of the finest restaurants in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Edith Agnoc: "“Don't blame it on him. Mr. President didn't choose the p..."*)

### Węzeł `[221]`
Mówca: **Walter Tusk**
> ""There is an art of everything. The art of making money, food, wine and love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_Attend == true"*)

### Węzeł `[222]`
Mówca: **Edith Agnoc**
> "“Always generous when it comes to small things.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Mikail Aven: ""Tipping is no small thing. I actually don't like giving ..."*)

### Węzeł `[223]`
Mówca: **Edith Agnoc**
> "“Don't blame it on him. Mr. President didn't choose the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_Attend == true"*)

### Węzeł `[224]`
**[WYBÓR GRACZA: "“Not a big fan of fancy food, but I must admit that it's very tasty.”"]** — Mówca: **Player**
> "“Not a big fan of fancy food, but I must admit that it's very tasty.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Walter Tusk: "“Says the man visiting one of the finest restaurants in S..."*)

### Węzeł `[225]`
Mówca: **Edith Agnoc**
> ""You didn't like the food?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player: ""No, I loved it. I just don't like this luxurious fine di..."*)
  - -> `[227]` (*Player: ""I liked it but it is nothing special.""*)

### Węzeł `[226]`
**[WYBÓR GRACZA: ""No, I loved it. I just don't like this luxurious fine dining culture.""]** — Mówca: **Player**
> ""No, I loved it. I just don't like this luxurious fine dining culture.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Edith Agnoc: ""Oh, I understand what you mean.""*)

### Węzeł `[227]`
**[WYBÓR GRACZA: ""I liked it but it is nothing special.""]** — Mówca: **Player**
> ""I liked it but it is nothing special.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Walter Tusk: ""I hope the manager did not hear that.""*)

### Węzeł `[228]`
Mówca: **Edith Agnoc**
> ""Oh, I understand what you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_Attend == true"*)

### Węzeł `[229]`
Mówca: **Walter Tusk**
> ""I hope the manager did not hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_Attend == true"*)

### Węzeł `[230]`
Mówca: **Mikail Aven**
> ""How are things going in the Maroon Palace? The pressure must have increased after you attended that funeral.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player: ""The pressure was already high. Not much has changed.""*)
  - -> `[234]` (*Player: ""It did. But it was the right decision.""*)
  - -> `[235]` (*Player: ""I have to say, the future is looking good.""*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_..."*)

### Węzeł `[231]`
Mówca: **Mikail Aven**
> ""But anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_Attend == true"*)

### Węzeł `[232]`
Mówca: **Mikail Aven**
> ""How are things going in the Maroon Palace? The pressure must have increased after you did not attend that funeral.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player: ""The pressure was already high. Not much has changed.""*)
  - -> `[234]` (*Player: ""It did. But it was the right decision.""*)
  - -> `[235]` (*Player: ""I have to say, the future is looking good.""*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_..."*)

### Węzeł `[233]`
**[WYBÓR GRACZA: ""The pressure was already high. Not much has changed.""]** — Mówca: **Player**
> ""The pressure was already high. Not much has changed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Mikail Aven), `[232]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Mikail Aven: ""You will get through this.""*)

### Węzeł `[234]`
**[WYBÓR GRACZA: ""It did. But it was the right decision.""]** — Mówca: **Player**
> ""It did. But it was the right decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Mikail Aven), `[232]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Mikail Aven: ""Of course. I didn't mean to criticise your decision.""*)

### Węzeł `[235]`
**[WYBÓR GRACZA: ""I have to say, the future is looking good.""]** — Mówca: **Player**
> ""I have to say, the future is looking good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Mikail Aven), `[232]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Mikail Aven: ""That's great to hear.""*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_..."*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true || BaseGame.Refor..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true  or  Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Player: ""It's tough but our work on the new constitution continues.""*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true || BaseGame.Reform_Reformist_Path == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true  or  Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player: ""It's tough but the new laws will fix it.""*)

### Węzeł `[239]`
**[WYBÓR GRACZA: ""It's tough but our work on the new constitution continues.""]** — Mówca: **Player**
> ""It's tough but our work on the new constitution continues.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Dictator_Path"] == true  or  Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[230]` (Mikail Aven), `[232]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Mikail Aven: ""We all hope so.""*)

### Węzeł `[240]`
**[WYBÓR GRACZA: ""It's tough but the new laws will fix it.""]** — Mówca: **Player**
> ""It's tough but the new laws will fix it.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Dictator_Path"] == true  or  Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[230]` (Mikail Aven), `[232]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Mikail Aven: ""We all hope so.""*)

### Węzeł `[241]`
Mówca: **Narrator**
> "We were escorted by heavily armed police forces as well as the presidential guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "When we arrived, the streets were quiet and police forces..."*)

### Węzeł `[242]`
Mówca: **Mikail Aven**
> ""You will get through this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "As we conversed with Mikail, I heard Walter raise his voi..."*)

### Węzeł `[243]`
Mówca: **Mikail Aven**
> ""Of course. I didn't mean to criticise your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "As we conversed with Mikail, I heard Walter raise his voi..."*)

### Węzeł `[244]`
Mówca: **Mikail Aven**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "As we conversed with Mikail, I heard Walter raise his voi..."*)

### Węzeł `[245]`
Mówca: **Mikail Aven**
> ""We all hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "As we conversed with Mikail, I heard Walter raise his voi..."*)

### Węzeł `[246]`
Mówca: **Narrator**
> "As we conversed with Mikail, I heard Walter raise his voice in an apparent argument with Edith and Symon. We both stopped to listen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Walter Tusk: ""...Arcasia knows the right way of doing business. Their ..."*)

### Węzeł `[247]`
Mówca: **Walter Tusk**
> ""...Arcasia knows the right way of doing business. Their approach to the world is real and raw. I'd prefer that cutthroat approach in comparison to the niceties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Edith Agnoc: ""Well-""*)

### Węzeł `[248]`
Mówca: **Symon Holl**
> ""I mean... It's a nice country to visit too. I have travelled there often in business trips. Their attitude on-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Edith Agnoc: ""All countries are nice to visit if you have the cash.""*)

### Węzeł `[249]`
Mówca: **Edith Agnoc**
> ""Well-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Symon Holl: ""I mean... It's a nice country to visit too. I have trave..."*)

### Węzeł `[250]`
Mówca: **Narrator**
> "He smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Walter Tusk: ""You work day and night for the nation, surely you deserv..."*)

### Węzeł `[251]`
Mówca: **Edith Agnoc**
> ""All countries are nice to visit if you have the cash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player_Italic: "Stay silent."*)
  - -> `[259]` (*Player: "“Money does turn the world around. Travel is the least yo..."*)
  - -> `[263]` (*Player: "“Certainly not all.”"*)
  - -> `[262]` (*Player: ""Exactly. How about the people who don't have extra cash ..."*)

### Węzeł `[252]`
Mówca: **Walter Tusk**
> ""Why would you, President? Or why wouldn't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusiness == true ||..."*)

### Węzeł `[253]`
Mówca: **Mikail Aven**
> ""Where is this pile of gold you keep talking about Walter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Symon Holl: "“Walter is taking us down the rabbit hole again.”"*)

### Węzeł `[254]`
Mówca: **Mikail Aven**
> ""By the way...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true || BaseGam..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA: "“Make sure to lay a good foundation for our negotiations to start on.”"]** — Mówca: **Player**
> "“Make sure to lay a good foundation for our negotiations to start on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Symon Holl: "“Our talented team is lead by Mr. Wisci. His wealth of kn..."*)

### Węzeł `[256]`
**[WYBÓR GRACZA: "“I am looking forward to those visits. It's been a long time since I left the country.”"]** — Mówca: **Player**
> "“I am looking forward to those visits. It's been a long time since I left the country.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Symon Holl: "“Staalport is a relatively calm and nice seaside city. I'..."*)

### Węzeł `[257]`
Mówca: **Symon Holl**
> "“Walter is taking us down the rabbit hole again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Mikail Aven: ""By the way...""*)

### Węzeł `[258]`
Mówca: **Symon Holl**
> "“Our talented team is lead by Mr. Wisci. His wealth of knowledge and extensive connections will aid in our endeavour.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Mikail Aven: ""By the way...""*)

### Węzeł `[259]`
**[WYBÓR GRACZA: "“Money does turn the world around. Travel is the least you can buy with it.”"]** — Mówca: **Player**
> "“Money does turn the world around. Travel is the least you can buy with it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Walter Tusk: "“Hear, hear.”"*)

### Węzeł `[260]`
Mówca: **Symon Holl**
> "“Staalport is a relatively calm and nice seaside city. I'm sure you'll like it there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Mikail Aven: ""By the way...""*)

### Węzeł `[261]`
Mówca: **Walter Tusk**
> "“The picture would have been very different.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Symon Holl: "“Walter is taking us down the rabbit hole again.”"*)

### Węzeł `[262]`
**[WYBÓR GRACZA: ""Exactly. How about the people who don't have extra cash to spend?""]** — Mówca: **Player**
> ""Exactly. How about the people who don't have extra cash to spend?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Walter Tusk: "“What about disease? What about death? What about everyth..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA: "“Certainly not all.”"]** — Mówca: **Player**
> "“Certainly not all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Walter Tusk: "“Half the globe isn't worth our time nor attention. That ..."*)

### Węzeł `[264]`
Mówca: **Mikail Aven**
> ""Can't disagree. The President deserves a better wage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Symon Holl: "“Walter is taking us down the rabbit hole again.”"*)

### Węzeł `[265]`
Mówca: **Symon Holl**
> "“Walter is taking us down the rabbit hole again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Mikail Aven: ""By the way...""*)

### Węzeł `[266]`
**[WYBÓR GRACZA: "“Old men plant trees whose shade they shall never sit under.”"]** — Mówca: **Player**
> "“Old men plant trees whose shade they shall never sit under.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Walter Tusk: "“An idealist at heart. You know what they say, being a ro..."*)

### Węzeł `[267]`
Mówca: **Walter Tusk**
> "“Hear, hear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Walter Tusk: ""So you're saying money is power.""*)

### Węzeł `[268]`
**[WYBÓR GRACZA: "“Truly an egotistical way to look at the world.”"]** — Mówca: **Player**
> "“Truly an egotistical way to look at the world.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Walter Tusk: "“It's just facts. Life is short and there is only so much..."*)

### Węzeł `[269]`
Mówca: **Walter Tusk**
> "“What about disease? What about death? What about everything that is wrong with the world?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Walter Tusk: "“These are matters beyond our lives. We should focus on t..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA: "“You are right, Walter. We only live once.”"]** — Mówca: **Player**
> "“You are right, Walter. We only live once.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Walter Tusk: "“There we go! You have to let loose of that burden of you..."*)

### Węzeł `[271]`
Mówca: **Walter Tusk**
> ""You work day and night for the nation, surely you deserve a higher salary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Mikail Aven: ""Can't disagree. The President deserves a better wage.""*)

### Węzeł `[272]`
Mówca: **Walter Tusk**
> "“Half the globe isn't worth our time nor attention. That won't change unless profitability increases.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Mikail Aven: "“Walter's classic absolutes. But I do agree with you inve..."*)

### Węzeł `[273]`
Mówca: **Walter Tusk**
> ""As long as you hold the treasure the country is yours. We are all part of that treasure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Mikail Aven: ""Where is this pile of gold you keep talking about Walter?""*)

### Węzeł `[274]`
**[WYBÓR GRACZA: "“Power controls money.”"]** — Mówca: **Player**
> "“Power controls money.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Walter Tusk: "“Yet rulers always use their treasure to maintain power. ..."*)

### Węzeł `[275]`
**[WYBÓR GRACZA: "“Money holds real power.”"]** — Mówca: **Player**
> "“Money holds real power.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Walter Tusk: ""We see eye to eye! What a privilege to agree with the Pr..."*)

### Węzeł `[276]`
Mówca: **Walter Tusk**
> ""So you're saying money is power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player: "“I am not a person to be motivated or influenced by money.”"*)
  - -> `[274]` (*Player: "“Power controls money.”"*)
  - -> `[275]` (*Player: "“Money holds real power.”"*)

### Węzeł `[277]`
Mówca: **Walter Tusk**
> "“These are matters beyond our lives. We should focus on the betterment of ourselves and enjoy what we have, instead of worrying about what others don't have.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player: "“The world isn't black and white.”"*)
  - -> `[270]` (*Player: "“You are right, Walter. We only live once.”"*)
  - -> `[268]` (*Player: "“Truly an egotistical way to look at the world.”"*)
  - -> `[266]` (*Player: "“Old men plant trees whose shade they shall never sit und..."*)

### Węzeł `[278]`
Mówca: **Mikail Aven**
> "“Walter's classic absolutes. But I do agree with you investment-wise. There are only a select group of countries that guarantee a return on investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Symon Holl: "“Talking of which, we are preparing our visit to Agnolia ..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA: "“The world isn't black and white.”"]** — Mówca: **Player**
> "“The world isn't black and white.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Walter Tusk: "“You would be surprised how much it is so, it is but a ma..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA: "“I am not a person to be motivated or influenced by money.”"]** — Mówca: **Player**
> "“I am not a person to be motivated or influenced by money.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Walter Tusk: ""Why would you, President? Or why wouldn't you?""*)

### Węzeł `[281]`
Mówca: **Walter Tusk**
> "“There we go! You have to let loose of that burden of yours or it will consume you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Symon Holl: "“Walter is taking us down the rabbit hole again.”"*)

### Węzeł `[282]`
Mówca: **Symon Holl**
> "“Talking of which, we are preparing our visit to Agnolia and Wehlen where we will meet their governments to settle our trade negotiations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player: "“Make sure to lay a good foundation for our negotiations ..."*)
  - -> `[256]` (*Player: "“I am looking forward to those visits. It's been a long t..."*)

### Węzeł `[283]`
Mówca: **Walter Tusk**
> ""We see eye to eye! What a privilege to agree with the President of Sordland himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Walter Tusk: ""As long as you hold the treasure the country is yours. W..."*)

### Węzeł `[284]`
Mówca: **Walter Tusk**
> "“It's just facts. Life is short and there is only so much we can do. Why not focus all the energy on ourselves?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Symon Holl: "“Walter is taking us down the rabbit hole again.”"*)

### Węzeł `[285]`
Mówca: **Walter Tusk**
> "“An idealist at heart. You know what they say, being a romantic idealist is easy when you have the time and money to be able to just sit down, relax and dream.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Symon Holl: "“Walter is taking us down the rabbit hole again.”"*)

### Węzeł `[286]`
Mówca: **Walter Tusk**
> "“You would be surprised how much it is so, it is but a matter of price.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Symon Holl: "“Walter is taking us down the rabbit hole again.”"*)

### Węzeł `[287]`
Mówca: **Walter Tusk**
> "“Yet rulers always use their treasure to maintain power. If you did not control the Ministry of Economy or the Central Bank...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Walter Tusk: "“The picture would have been very different.”"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusiness == true ||..."*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_BailBusiness == true ..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or  Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "He smirked."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or  Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Walter Tusk: ""You work day and night for the nation, surely you deserv..."*)

### Węzeł `[291]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "Mikail joined in."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Mikail Aven: "“It certainly depends on what you are looking for. Cultur..."*)

### Węzeł `[292]`
Mówca: **Walter Tusk**
> "“Last time I went somewhere for that sort of thing was at university. And even then we had our wild times thanks to Konrath's connected entourage. Also-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Symon Holl: "“Walter is taking us down the rabbit hole again.”"*)

### Węzeł `[293]`
Mówca: **Mikail Aven**
> "“It certainly depends on what you are looking for. Cultural tourism doesn't require a fancy hotel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Walter Tusk: "“Last time I went somewhere for that sort of thing was at..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction =..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesse..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Mikail Aven: ""The business bailout package was a great investment. I h..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Mikail Aven: ""I've heard that you've bought a new villa, Symon.""*)

### Węzeł `[300]`
Mówca: **Mikail Aven**
> ""I have to congratulate Mr. Rayne for starting such a massive project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player: ""Thank you for your support, Mr. Aven.""*)
  - -> `[337]` (*Player: ""No need for that, Mr. Aven. The State is just doing its ..."*)
  - -> `[338]` (*Player: ""I hope the investment returns will be great.""*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true || BaseGame.Turn01_InT_Investment_Railway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true || BaseGam..."*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true || BaseG..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true || BaseGame.Turn01_InT_Investment_Railway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true  or  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true || BaseGame.Turn01_InT_Investment_Railway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true  or  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Mikail Aven: ""I saw that Underhall Construction has already started wi..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Mikail Aven: ""I saw that Underhall Construction has already started wi..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true)"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Mikail Aven: ""I saw that the construction of the highway has already s..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Mikail Aven: ""I saw that the construction of the railway has already s..."*)

### Węzeł `[310]`
Mówca: **Mikail Aven**
> ""I saw that Underhall Construction has already started with the highway construction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Mikail Aven: ""Hopefully that project will bring new investments from A..."*)

### Węzeł `[311]`
Mówca: **Mikail Aven**
> ""Hopefully that project will bring new investments from Agnolia. The mood is already becoming positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[312]`
Mówca: **Mikail Aven**
> ""I saw that the construction of the highway has already started. I have my concerns about the company, but I hope they do a good job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Mikail Aven: ""I expect that the project will bring new investments fro..."*)

### Węzeł `[313]`
Mówca: **Mikail Aven**
> ""I expect that the project will bring new investments from Agnolia. The mood is already becoming positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[314]`
Mówca: **Mikail Aven**
> ""I saw that Underhall Construction has already started with the railway construction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Mikail Aven: ""That project will surely boost our economy. The mood is ..."*)

### Węzeł `[315]`
Mówca: **Mikail Aven**
> ""That project will surely boost our economy. The mood is already very positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[316]`
Mówca: **Mikail Aven**
> ""I saw that the construction of the railway has already started. I have my concerns about the company, but I hope they do a good job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Mikail Aven: ""That project will surely boost our economy if done corre..."*)

### Węzeł `[317]`
Mówca: **Mikail Aven**
> ""That project will surely boost our economy if done correctly. The mood is already becoming positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[318]`
Mówca: **Mikail Aven**
> ""The business bailout package was a great investment. I have already seen some positive results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Mikail Aven: ""It has already saved many businesses from declaring bank..."*)

### Węzeł `[319]`
Mówca: **Narrator**
> "Symon poured some wine in my glass and waited for me to taste it before filling it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "I took a sip."*)

### Węzeł `[320]`
Mówca: **Narrator**
> "I took a sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Narrator: "The taste of the wine was immediately stimulating and del..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "It was bitter."*)

### Węzeł `[324]`
Mówca: **Narrator**
> "The taste of the wine was immediately stimulating and delightful to my palate. It immediately reminded me of our visits to my father's vineyard when I was a little kid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Narrator: "The wine's sweet and bitter flavours exploded in my mouth..."*)

### Węzeł `[325]`
Mówca: **Narrator**
> "The wine's sweet and bitter flavours exploded in my mouth. The aroma of gooseberries and lilacs tumbled across my tongue, and my mouth tingled with them long after I'd swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Symon Holl: ""How is it? Is the taste to your liking?""*)

### Węzeł `[326]`
Mówca: **Narrator**
> "It was bitter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "Honestly, it tasted like any other wine."*)

### Węzeł `[327]`
Mówca: **Narrator**
> "Honestly, it tasted like any other wine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Symon Holl: ""How is it? Is the taste to your liking?""*)

### Węzeł `[328]`
Mówca: **Symon Holl**
> ""How is it? Is the taste to your liking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Player: ""It tastes like heaven. Reminds me of my father's vineyard.""*)
  - -> `[331]` (*Player: ""Fine balance and a nice touch of gooseberries... I like ..."*)
  - -> `[334]` (*Player: ""It's fine.""*)
  - -> `[335]` (*Player: ""It tastes like any other wine.""*)

### Węzeł `[329]`
**[WYBÓR GRACZA: ""It tastes like heaven. Reminds me of my father's vineyard.""]** — Mówca: **Player**
> ""It tastes like heaven. Reminds me of my father's vineyard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Walter Tusk: ""I've heard that he was a big wine connoisseur. May he re..."*)

### Węzeł `[330]`
Mówca: **Symon Holl**
> ""How is it? Is the taste to your liking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Player: ""It has a sour and delicate vegetal character. Is it Arca..."*)
  - -> `[333]` (*Player: ""It tastes like heaven.""*)
  - -> `[334]` (*Player: ""It's fine.""*)
  - -> `[335]` (*Player: ""It tastes like any other wine.""*)

### Węzeł `[331]`
**[WYBÓR GRACZA: ""Fine balance and a nice touch of gooseberries... I like it.""]** — Mówca: **Player**
> ""Fine balance and a nice touch of gooseberries... I like it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Walter Tusk: ""You know your wine, Mr. Rayne. I respect that.""*)

### Węzeł `[332]`
**[WYBÓR GRACZA: ""It has a sour and delicate vegetal character. Is it Arcasia I'm tasting?""]** — Mówca: **Player**
> ""It has a sour and delicate vegetal character. Is it Arcasia I'm tasting?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Walter Tusk: ""What? No.""*)

### Węzeł `[333]`
**[WYBÓR GRACZA: ""It tastes like heaven.""]** — Mówca: **Player**
> ""It tastes like heaven.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Walter Tusk: ""See?""*)

### Węzeł `[334]`
**[WYBÓR GRACZA: ""It's fine.""]** — Mówca: **Player**
> ""It's fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Symon Holl), `[330]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Walter Tusk: ""What? This wine doesn't even need testing.""*)

### Węzeł `[335]`
**[WYBÓR GRACZA: ""It tastes like any other wine.""]** — Mówca: **Player**
> ""It tastes like any other wine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Symon Holl), `[330]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Walter Tusk: ""What? This wine doesn't even need testing.""*)

### Węzeł `[336]`
**[WYBÓR GRACZA: ""Thank you for your support, Mr. Aven.""]** — Mówca: **Player**
> ""Thank you for your support, Mr. Aven.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Mikail Aven), `[340]` (Mikail Aven), `[346]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Mikail Aven: ""Of course.""*)

### Węzeł `[337]`
**[WYBÓR GRACZA: ""No need for that, Mr. Aven. The State is just doing its job.""]** — Mówca: **Player**
> ""No need for that, Mr. Aven. The State is just doing its job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Mikail Aven), `[340]` (Mikail Aven), `[346]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Mikail Aven: ""Of course.""*)

### Węzeł `[338]`
**[WYBÓR GRACZA: ""I hope the investment returns will be great.""]** — Mówca: **Player**
> ""I hope the investment returns will be great.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Mikail Aven), `[340]` (Mikail Aven), `[346]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Mikail Aven: ""We all hope so, Mr. President. But I think it will work ..."*)

### Węzeł `[339]`
Mówca: **Mikail Aven**
> ""It has already saved many businesses from declaring bankruptcy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Mikail Aven: ""I have to congratulate Mr. Rayne for spending a massive ..."*)

### Węzeł `[340]`
Mówca: **Mikail Aven**
> ""I have to congratulate Mr. Rayne for spending a massive amount of money for the businesses. This sets a good atmosphere for trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player: ""Thank you for your support, Mr. Aven.""*)
  - -> `[337]` (*Player: ""No need for that, Mr. Aven. The State is just doing its ..."*)
  - -> `[338]` (*Player: ""I hope the investment returns will be great.""*)
  - -> `[341]` (*Player: ""That's good to hear.""*)

### Węzeł `[341]`
**[WYBÓR GRACZA: ""That's good to hear.""]** — Mówca: **Player**
> ""That's good to hear.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Mikail Aven: ""Mr. Holl also deserves credit, of course. Our *great* ec..."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesse..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Mikail Aven: ""The relief package was also a great investment. It has a..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Mikail Aven: ""I have to congratulate Mr. Rayne for starting such a mas..."*)

### Węzeł `[345]`
Mówca: **Mikail Aven**
> ""The relief package was also a great investment. It has already saved many businesses from declaring bankruptcy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Mikail Aven: ""I have to congratulate Mr. Rayne for such major projects.""*)

### Węzeł `[346]`
Mówca: **Mikail Aven**
> ""I have to congratulate Mr. Rayne for such major projects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player: ""Thank you for your support, Mr. Aven.""*)
  - -> `[337]` (*Player: ""No need for that, Mr. Aven. The State is just doing its ..."*)
  - -> `[338]` (*Player: ""I hope the investment returns will be great.""*)

### Węzeł `[347]`
Mówca: **Mikail Aven**
> ""I've heard that you've bought a new villa, Symon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Symon Holl: "“I don't comment on rumours, but I'll make an exception s..."*)

### Węzeł `[348]`
**[WYBÓR GRACZA: "“Where is the property?”"]** — Mówca: **Player**
> "“Where is the property?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[349]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Symon Holl: "“It is a small seaside villa at the outskirts of Conriat...."*)

### Węzeł `[349]`
Mówca: **Symon Holl**
> "“I don't comment on rumours, but I'll make an exception since we are among friends. It's true.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Player: "“You are doing a great job so you deserve it.”"*)
  - -> `[351]` (*Player: "“A new villa is a bit much. Especially in this economy wh..."*)
  - -> `[348]` (*Player: "“Where is the property?”"*)
  - -> `[467]` (*Player: ""Why?""*)

### Węzeł `[350]`
**[WYBÓR GRACZA: "“You are doing a great job so you deserve it.”"]** — Mówca: **Player**
> "“You are doing a great job so you deserve it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[349]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Edith Agnoc: "“He *is* one of the hardest working ministers in the gove..."*)

### Węzeł `[351]`
**[WYBÓR GRACZA: "“A new villa is a bit much. Especially in this economy when people are suffering.”"]** — Mówca: **Player**
> "“A new villa is a bit much. Especially in this economy when people are suffering.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[349]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Walter Tusk: "“So what? My car collection is nearing the forty mark. Th..."*)

### Węzeł `[352]`
**[WYBÓR GRACZA: "“Maybe it shows overcompensation somewhat. Everybody is free to do whatever they want.”"]** — Mówca: **Player**
> "“Maybe it shows overcompensation somewhat. Everybody is free to do whatever they want.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Walter Tusk: "“Don't expect the rich to become modest in the near futur..."*)

### Węzeł `[353]`
Mówca: **Walter Tusk**
> "“Where there is demand there is supply. The market rules supreme as always.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "Edith, who was sitting to my left, gently put her hand ov..."*)

### Węzeł `[354]`
Mówca: **Symon Holl**
> "“It is a small seaside villa at the outskirts of Conriat. It's just a modest house with a swimming pool and a small golf course in the property.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Player: "“Great city to buy real estate in. Conriat is seeing a su..."*)
  - -> `[361]` (*Player: ""So you're becoming a neighbour to Marcel Koronti?""*)
  - -> `[414]` (*Player: ""Modest? Are you being sarcastic with me?""*)

### Węzeł `[355]`
Mówca: **Walter Tusk**
> "“So what? My car collection is nearing the forty mark. They are all old timer models.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Player: "“Maybe it shows overcompensation somewhat. Everybody is f..."*)
  - -> `[365]` (*Player: "“I always advocate against ostentatious behaviour. Money ..."*)
  - -> `[413]` (*Player: ""How can you speak like that?""*)

### Węzeł `[356]`
Mówca: **Edith Agnoc**
> "“He *is* one of the hardest working ministers in the government. He has surely deserved it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Player: ""I couldn't agree more.""*)
  - -> `[367]` (*Player: "“Some prefer the carrot and stick approach. I'm more resu..."*)
  - -> `[358]` (*Player: "“Rewards give the motivation to ensure people go that ext..."*)

### Węzeł `[357]`
Mówca: **Walter Tusk**
> "“Depends who you work for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Walter Tusk: "“But talking about rewards... It is a fact that the gover..."*)

### Węzeł `[358]`
**[WYBÓR GRACZA: "“Rewards give the motivation to ensure people go that extra mile.”"]** — Mówca: **Player**
> "“Rewards give the motivation to ensure people go that extra mile.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Walter Tusk: "“Depends who you work for.”"*)

### Węzeł `[359]`
Mówca: **Walter Tusk**
> "“But talking about rewards... It is a fact that the government pays far less than the private sector.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Symon Holl: "“That's true but that was a change made on purpose to pus..."*)

### Węzeł `[360]`
**[WYBÓR GRACZA: "“Great city to buy real estate in. Conriat is seeing a surge of investments.”"]** — Mówca: **Player**
> "“Great city to buy real estate in. Conriat is seeing a surge of investments.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Edith Agnoc: "“Underhall Construction made a fortune constructing house..."*)

### Węzeł `[361]`
**[WYBÓR GRACZA: ""So you're becoming a neighbour to Marcel Koronti?""]** — Mówca: **Player**
> ""So you're becoming a neighbour to Marcel Koronti?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Symon Holl: ""Not really. His place is very remote.""*)

### Węzeł `[362]`
Mówca: **Edith Agnoc**
> "“Underhall Construction made a fortune constructing houses there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Walter Tusk: "“Where there is demand there is supply. The market rules ..."*)

### Węzeł `[363]`
Mówca: **Walter Tusk**
> "“Don't expect the rich to become modest in the near future. That would be a pipe dream.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Player: ""Some people are more sensible. I believe balance is poss..."*)
  - -> `[465]` (*Player: ""The gap between the rich and the poor is the root cause ..."*)
  - -> `[463]` (*Player: ""We'll see about that.""*)

### Węzeł `[364]`
Mówca: **Symon Holl**
> "“That's true but that was a change made on purpose to push for improvements from the inside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "Edith, who was sitting to my left, gently put her hand ov..."*)

### Węzeł `[365]`
**[WYBÓR GRACZA: "“I always advocate against ostentatious behaviour. Money shouldn't be wasted for luxury.""]** — Mówca: **Player**
> "“I always advocate against ostentatious behaviour. Money shouldn't be wasted for luxury.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Walter Tusk: "“Don't expect the rich to become modest in the near futur..."*)

### Węzeł `[366]`
Mówca: **Symon Holl**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "Edith, who was sitting to my left, gently put her hand ov..."*)

### Węzeł `[367]`
**[WYBÓR GRACZA: "“Some prefer the carrot and stick approach. I'm more result oriented.”"]** — Mówca: **Player**
> "“Some prefer the carrot and stick approach. I'm more result oriented.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Walter Tusk: "“Depends who you work for.”"*)

### Węzeł `[368]`
Mówca: **Walter Tusk**
> ""What? No.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Symon Holl: ""You may be tasting the oak from the barrels, or maybe it..."*)

### Węzeł `[369]`
Mówca: **Symon Holl**
> ""You may be tasting the oak from the barrels, or maybe its the gooseberries. It's definitely not Arcasia, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "Symon filled up my glass."*)

### Węzeł `[370]`
Mówca: **Walter Tusk**
> ""See?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "Symon filled up my glass."*)

### Węzeł `[371]`
Mówca: **Walter Tusk**
> ""What? This wine doesn't even need testing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Symon Holl: ""Should I fill your glass or would you want another drink..."*)

### Węzeł `[372]`
Mówca: **Symon Holl**
> ""Should I fill your glass or would you want another drink, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Player: ""It's okay. I'll drink it.""*)
  - -> `[373]` (*Player: ""I think I'm good. I won't have anything for now.""*)

### Węzeł `[373]`
**[WYBÓR GRACZA: ""I think I'm good. I won't have anything for now.""]** — Mówca: **Player**
> ""I think I'm good. I won't have anything for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Symon Holl: ""As you wish, Mr. President.""*)

### Węzeł `[374]`
**[WYBÓR GRACZA: ""It's okay. I'll drink it.""]** — Mówca: **Player**
> ""It's okay. I'll drink it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "Symon filled up my glass."*)

### Węzeł `[375]`
Mówca: **Walter Tusk**
> ""I've heard that he was a big wine connoisseur. May he rest in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Player: ""Thank you.""*)
  - -> `[379]` (*Player: ""Honestly, I was never close to him. I can't recall too m..."*)
  - -> `[380]` (*Player_Italic: "Stay silent."*)

### Węzeł `[376]`
Mówca: **Walter Tusk**
> ""You know your wine, Mr. Rayne. I respect that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "Symon filled up my glass."*)

### Węzeł `[377]`
Mówca: **Narrator**
> "Symon filled up my glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "After filling everybody's glasses, Symon stood up and rai..."*)

### Węzeł `[378]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "Symon filled up my glass."*)

### Węzeł `[379]`
**[WYBÓR GRACZA: ""Honestly, I was never close to him. I can't recall too much apart from his lavish parties.""]** — Mówca: **Player**
> ""Honestly, I was never close to him. I can't recall too much apart from his lavish parties.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Walter Tusk: ""I'm sorry to hear that.""*)

### Węzeł `[380]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "Symon filled up my glass."*)

### Węzeł `[381]`
Mówca: **Walter Tusk**
> ""I'm sorry to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "Symon filled up my glass."*)

### Węzeł `[382]`
Mówca: **Symon Holl**
> ""As you wish, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Narrator: "He grabbed the bottle again to pour some into Walter Tusk..."*)

### Węzeł `[383]`
Mówca: **Narrator**
> "He grabbed the bottle again to pour some into Walter Tusk's glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Walter Tusk: ""You didn't have to serve us, Mr. Holl. There are servers..."*)

### Węzeł `[384]`
Mówca: **Walter Tusk**
> ""You didn't have to serve us, Mr. Holl. There are servers around here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "After filling everybody's glasses, Symon stood up and rai..."*)

### Węzeł `[385]`
**[WYBÓR GRACZA: ""I couldn't agree more.""]** — Mówca: **Player**
> ""I couldn't agree more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Walter Tusk: "“But talking about rewards... It is a fact that the gover..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "Several of the heavily armed guards were also inside with..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Edith Agnoc: "“Mr. President, I didn't have the possibility to thank yo..."*)

### Węzeł `[389]`
Mówca: **Narrator**
> "Several of the heavily armed guards were also inside with us, protecting every entrance and exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Edith Agnoc: "“Mr. President, I didn't have the possibility to thank yo..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Narrator: "As all of us started eating. Walter stopped and looked at..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Edith Agnoc: ""So, how did you find the food of the best fine dining re..."*)

### Węzeł `[393]`
Mówca: **Narrator**
> "The guards bowed their heads and went outside. Walter sighed in relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Business_GuardsOutside = true"*)

### Węzeł `[394]`
Mówca: **Narrator**
> "As all of us started eating. Walter stopped and looked at the guards before turning to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Walter Tusk: ""I know that we are in a state of emergency, Mr. Rayne. B..."*)

### Węzeł `[395]`
Mówca: **Walter Tusk**
> ""I know that we are in a state of emergency, Mr. Rayne. But can't we even eat alone?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Walter Tusk: ""What are they protecting here? They have already surroun..."*)

### Węzeł `[396]`
Mówca: **Walter Tusk**
> ""What are they protecting here? They have already surrounded the whole restaurant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Player: ""It is a necessity, Mr. Tusk. There's nothing I can do ab..."*)
  - -> `[398]` (*Player: ""They have to be prepared for everything.""*)
  - -> `[399]` (*Player: ""I can take them out, if you want, Mr. Tusk.""*)
  - -> `[400]` (*Player: ""You're right. Can you guys leave us alone here, please?""*)

### Węzeł `[397]`
**[WYBÓR GRACZA: ""It is a necessity, Mr. Tusk. There's nothing I can do about it.""]** — Mówca: **Player**
> ""It is a necessity, Mr. Tusk. There's nothing I can do about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Walter Tusk: ""I see.""*)

### Węzeł `[398]`
**[WYBÓR GRACZA: ""They have to be prepared for everything.""]** — Mówca: **Player**
> ""They have to be prepared for everything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Walter Tusk: ""I see.""*)

### Węzeł `[399]`
**[WYBÓR GRACZA: ""I can take them out, if you want, Mr. Tusk.""]** — Mówca: **Player**
> ""I can take them out, if you want, Mr. Tusk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Walter Tusk: ""Please.""*)

### Węzeł `[400]`
**[WYBÓR GRACZA: ""You're right. Can you guys leave us alone here, please?""]** — Mówca: **Player**
> ""You're right. Can you guys leave us alone here, please?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "The guards bowed their heads and went outside. Walter sig..."*)

### Węzeł `[401]`
Mówca: **Walter Tusk**
> ""Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Player: ""Can you guys leave us alone here, please?""*)
  - -> `[403]` (*Player: ""You can stay outside the door.""*)
  - -> `[404]` (*Player: ""Please leave the room. You scared Mr. Tusk.""*)

### Węzeł `[402]`
**[WYBÓR GRACZA: ""Can you guys leave us alone here, please?""]** — Mówca: **Player**
> ""Can you guys leave us alone here, please?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "The guards bowed their heads and went outside. Walter sig..."*)

### Węzeł `[403]`
**[WYBÓR GRACZA: ""You can stay outside the door.""]** — Mówca: **Player**
> ""You can stay outside the door.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "The guards bowed their heads and went outside. Walter sig..."*)

### Węzeł `[404]`
**[WYBÓR GRACZA: ""Please leave the room. You scared Mr. Tusk.""]** — Mówca: **Player**
> ""Please leave the room. You scared Mr. Tusk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Narrator: "Walter stared at me as the guards bowed their heads and w..."*)

### Węzeł `[405]`
Mówca: **Walter Tusk**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "He didn't look too pleased about the whole situation."*)

### Węzeł `[406]`
Mówca: **Narrator**
> "He didn't look too pleased about the whole situation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Edith Agnoc: ""So, how did you find the food of the best fine dining re..."*)

### Węzeł `[407]`
Mówca: **Mikail Aven**
> ""We all hope so, Mr. President. But I think it will work out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Mikail Aven: ""Mr. Holl also deserves credit, of course. Our *great* ec..."*)

### Węzeł `[408]`
Mówca: **Mikail Aven**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Mikail Aven: ""Mr. Holl also deserves credit, of course. Our *great* ec..."*)

### Węzeł `[409]`
Mówca: **Mikail Aven**
> ""Mr. Holl also deserves credit, of course. Our *great* economy minister...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Symon Holl: ""Is there a joke coming?""*)

### Węzeł `[410]`
Mówca: **Symon Holl**
> ""Is there a joke coming?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Mikail Aven: ""Why? I thought you said you were great at economy.""*)

### Węzeł `[411]`
Mówca: **Mikail Aven**
> ""Why? I thought you said you were great at economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Narrator: "He laughed."*)

### Węzeł `[412]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Mikail Aven: ""I've heard that you've bought a new villa, Symon.""*)

### Węzeł `[413]`
**[WYBÓR GRACZA: ""How can you speak like that?""]** — Mówca: **Player**
> ""How can you speak like that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Walter Tusk: ""I'm just saying that he's free to do what he please with..."*)

### Węzeł `[414]`
**[WYBÓR GRACZA: ""Modest? Are you being sarcastic with me?""]** — Mówca: **Player**
> ""Modest? Are you being sarcastic with me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Symon Holl: ""No. Is there a problem?""*)

### Węzeł `[415]`
Mówca: **Edith Agnoc**
> ""I've heard that your father was a very wealthy man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Edith Agnoc: "“Would you say that it contributed a lot to your success?""*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Edith Agnoc: ""I've heard that you had a difficult life in Deyr. Is tha..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle == true"*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle == true"*)
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Holsord_Middle == true)"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Edith Agnoc: ""I've heard that you were brought up in the capital and e..."*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Holsord_Middle == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Edith Agnoc: ""I've heard that your father was a very wealthy man.""*)

### Węzeł `[422]`
Mówca: **Narrator**
> "Edith, who was sitting to my left, gently put her hand over my arm for a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Edith Agnoc: ""Come on, let's not talk about finance or politics for no..."*)

### Węzeł `[423]`
Mówca: **Walter Tusk**
> ""A correction. It wasn't his policies that destroyed him. It was the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Player: "“What do you mean?”"*)
  - -> `[441]` (*Player: "“I always had a gut feeling about his sudden fall.”"*)
  - -> `[443]` (*Player: ""Of course it was. They are a big threat.""*)
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[424]`
**[WYBÓR GRACZA: ""The kid can handle himself. He doesn't need anybody else.”"]** — Mówca: **Player**
> ""The kid can handle himself. He doesn't need anybody else.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[493]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Edith Agnoc: ""I said that about my daughter too. And she dropped out o..."*)

### Węzeł `[425]`
Mówca: **Narrator**
> "Everyone went quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Narrator: "After a long silence, followed by some chit-chat, Walter ..."*)

### Węzeł `[426]`
Mówca: **Edith Agnoc**
> ""I've heard that you had a difficult life in Deyr. Is that right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Player: "“I try to leave my past behind and focus on today. It's w..."*)
  - -> `[430]` (*Player: ""My childhood was very difficult. But it definitely made ..."*)
  - -> `[431]` (*Player: "“My family cared for me as much as they could. I couldn't..."*)

### Węzeł `[427]`
Mówca: **Walter Tusk**
> ""That's a good choice. Having a degree in Sordland separates you from the rabble. And we especially need more people who understand economics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == true"*)

### Węzeł `[428]`
Mówca: **Edith Agnoc**
> ""I've heard that you were brought up in the capital and experienced all the power shift as it happened. Is that right? It must have been tough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Player: "“I try to leave my past behind and focus on today. It's w..."*)
  - -> `[482]` (*Player: ""It was difficult times in the capital. But I've learned ..."*)
  - -> `[483]` (*Player: ""I didn't suffer much thanks to my family. We didn't have..."*)

### Węzeł `[429]`
Mówca: **Mikail Aven**
> ""But I agree that we need more economists to enter politics. It's unfortunate that Ewald Alphonso was the only leader who actually studied economics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Narrator: "He turned to me."*)

### Węzeł `[430]`
**[WYBÓR GRACZA: ""My childhood was very difficult. But it definitely made me stronger.""]** — Mówca: **Player**
> ""My childhood was very difficult. But it definitely made me stronger.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[426]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Walter Tusk: "“Sometimes it impacts people more negatively. My father u..."*)

### Węzeł `[431]`
**[WYBÓR GRACZA: "“My family cared for me as much as they could. I couldn't ask for more than that.”"]** — Mówca: **Player**
> "“My family cared for me as much as they could. I couldn't ask for more than that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[426]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Edith Agnoc: ""That's very humble of you.""*)

### Węzeł `[432]`
**[WYBÓR GRACZA: "“I try to leave my past behind and focus on today. It's who we have become that matters.”"]** — Mówca: **Player**
> "“I try to leave my past behind and focus on today. It's who we have become that matters.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[426]` (Edith Agnoc), `[428]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Mikail Aven: "“That's what I say after a good night of drinking.”"*)

### Węzeł `[433]`
Mówca: **Mikail Aven**
> "“Walter stop with the conspiracy theories. I think we've had enough drinks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Narrator: "Everyone went quiet."*)

### Węzeł `[434]`
Mówca: **Mikail Aven**
> "“Talking of which, it's great that we have another leader who actually studied economics and understands it. Like Mr. Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Player: "“Look at what he caused. Studying doesn't get you to the ..."*)
  - -> `[456]` (*Player: "“Alphonso was an inspiration for all reformists.""*)
  - -> `[453]` (*Player: "“We are in this mess because of him. His political failur..."*)
  - -> `[506]` (*Player: ""Thank you.""*)

### Węzeł `[435]`
Mówca: **Walter Tusk**
> "“He threatened their economic power base over the country through a vast privatization plan. They removed him and backed you after.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Mikail Aven: "“Walter stop with the conspiracy theories. I think we've ..."*)

### Węzeł `[436]`
Mówca: **Mikail Aven**
> "“True, but I think it was his ambition that brought him down. Too many big changes in a short time frame.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == true"*)
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Lachaven_Economics == true)"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Mikail Aven: "“Talking of which, it's great that we have another leader..."*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Lachaven_Economics == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Walter Tusk: ""Maybe your son will be a great future economist!""*)

### Węzeł `[440]`
Mówca: **Mikail Aven**
> "“That's what I say after a good night of drinking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Symon Holl: "“I never met your family, Mr. President. How are they doi..."*)

### Węzeł `[441]`
**[WYBÓR GRACZA: "“I always had a gut feeling about his sudden fall.”"]** — Mówca: **Player**
> "“I always had a gut feeling about his sudden fall.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[423]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Walter Tusk: "“He threatened their economic power base over the country..."*)

### Węzeł `[442]`
Mówca: **Walter Tusk**
> "“Sometimes it impacts people more negatively. My father used to beat me up good when I crossed the line.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Symon Holl: "“I never met your family, Mr. President. How are they doi..."*)

### Węzeł `[443]`
**[WYBÓR GRACZA: ""Of course it was. They are a big threat.""]** — Mówca: **Player**
> ""Of course it was. They are a big threat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[423]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Walter Tusk: "“He threatened their economic power base over the country..."*)

### Węzeł `[444]`
Mówca: **Edith Agnoc**
> ""That's very humble of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Symon Holl: "“I never met your family, Mr. President. How are they doi..."*)

### Węzeł `[445]`
**[WYBÓR GRACZA: "“What do you mean?”"]** — Mówca: **Player**
> "“What do you mean?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[423]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Walter Tusk: "“He threatened their economic power base over the country..."*)

### Węzeł `[446]`
Mówca: **Symon Holl**
> "“I never met your family, Mr. President. How are they doing, if you don't mind me asking?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Player: ""I prefer not to talk about my family.""*)
  - -> `[449]` (*Player: ""We don't talk much since I became President.""*)
  - -> `[490]` (*Player: ""They're doing great. We have no problems.""*)

### Węzeł `[447]`
**[WYBÓR GRACZA: "“Look at what he caused. Studying doesn't get you to the finish line.”"]** — Mówca: **Player**
> "“Look at what he caused. Studying doesn't get you to the finish line.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[434]` (Mikail Aven), `[503]` (Mikail Aven), `[505]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Mikail Aven: "“True, but I think it was his ambition that brought him d..."*)

### Węzeł `[448]`
Mówca: **Edith Agnoc**
> "“We are here because of him. I don't think we had a chance, if he hadn't screwed up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[449]`
**[WYBÓR GRACZA: ""We don't talk much since I became President.""]** — Mówca: **Player**
> ""We don't talk much since I became President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[446]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Mikail Aven: ""It can happen. Sometimes work can get in the way. Don't ..."*)

### Węzeł `[450]`
Mówca: **Mikail Aven**
> ""It can happen. Sometimes work can get in the way. Don't stress yourself over it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Walter Tusk: "“Family is everything. My advice would be to make sure th..."*)

### Węzeł `[451]`
Mówca: **Mikail Aven**
> ""Well, the rascal didn't even ask for permission to use the yacht and just took it. He basically stole it...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Mikail Aven: ""Good news is that I finally convinced him to go to unive..."*)

### Węzeł `[452]`
**[WYBÓR GRACZA: ""I prefer not to talk about my family.""]** — Mówca: **Player**
> ""I prefer not to talk about my family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[446]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Symon Holl: ""I understand.""*)

### Węzeł `[453]`
**[WYBÓR GRACZA: "“We are in this mess because of him. His political failure nearly destroyed us.”"]** — Mówca: **Player**
> "“We are in this mess because of him. His political failure nearly destroyed us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[434]` (Mikail Aven), `[503]` (Mikail Aven), `[505]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Edith Agnoc: "“We are here because of him. I don't think we had a chanc..."*)

### Węzeł `[454]`
**[WYBÓR GRACZA: ""He is going through the teenager period. It's difficult to connect with him, he's a little shy.""]** — Mówca: **Player**
> ""He is going through the teenager period. It's difficult to connect with him, he's a little shy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[460]` (Walter Tusk), `[493]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Mikail Aven: "“Wish that was my son's biggest problem...”"*)

### Węzeł `[455]`
**[WYBÓR GRACZA: ""Mikail. What did you just say to me?""]** — Mówca: **Player**
> ""Mikail. What did you just say to me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[503]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Narrator: "Everyone fell silent and looked at Mikail."*)

### Węzeł `[456]`
**[WYBÓR GRACZA: "“Alphonso was an inspiration for all reformists.""]** — Mówca: **Player**
> "“Alphonso was an inspiration for all reformists.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[434]` (Mikail Aven), `[503]` (Mikail Aven), `[505]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Mikail Aven: "“He was, he truly wanted to transform this country to a m..."*)

### Węzeł `[457]`
Mówca: **Mikail Aven**
> "“Wish that was my son's biggest problem...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Edith Agnoc: ""Darron seemed to be doing fine. I saw that his yacht par..."*)

### Węzeł `[458]`
Mówca: **Edith Agnoc**
> ""Darron seemed to be doing fine. I saw that his yacht party in Benfi made the local news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Mikail Aven: ""Well, the rascal didn't even ask for permission to use t..."*)

### Węzeł `[459]`
Mówca: **Mikail Aven**
> "“He was, he truly wanted to transform this country to a modern nation. His term was very difficult though. He got destroyed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[460]`
Mówca: **Walter Tusk**
> "“Family is everything. My advice would be to make sure that Franc has a solid relationship with you. He is your future, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Player: ""I said: I don't want to talk about my family.""*)
  - -> `[462]` (*Player: "“I'm trying my best to be a good father to him. He seems ..."*)
  - -> `[454]` (*Player: ""He is going through the teenager period. It's difficult ..."*)

### Węzeł `[461]`
Mówca: **Edith Agnoc**
> ""I said that about my daughter too. And she dropped out of university...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Mikail Aven: "“Wish that was my son's biggest problem...”"*)

### Węzeł `[462]`
**[WYBÓR GRACZA: "“I'm trying my best to be a good father to him. He seems to be somewhat introverted.”"]** — Mówca: **Player**
> "“I'm trying my best to be a good father to him. He seems to be somewhat introverted.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[460]` (Walter Tusk), `[493]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Mikail Aven: "“Wish that was my son's biggest problem...”"*)

### Węzeł `[463]`
**[WYBÓR GRACZA: ""We'll see about that.""]** — Mówca: **Player**
> ""We'll see about that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[363]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Walter Tusk: ""What's that supposed to mean?""*)

### Węzeł `[464]`
**[WYBÓR GRACZA: ""Some people are more sensible. I believe balance is possible.""]** — Mówca: **Player**
> ""Some people are more sensible. I believe balance is possible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[363]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Symon Holl: ""I agree.""*)

### Węzeł `[465]`
**[WYBÓR GRACZA: ""The gap between the rich and the poor is the root cause of this.""]** — Mówca: **Player**
> ""The gap between the rich and the poor is the root cause of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[363]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Symon Holl: "“Some of us are more sensible than others. Balance is pos..."*)

### Węzeł `[466]`
Mówca: **Symon Holl**
> "“Some of us are more sensible than others. Balance is possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "Edith, who was sitting to my left, gently put her hand ov..."*)

### Węzeł `[467]`
**[WYBÓR GRACZA: ""Why?""]** — Mówca: **Player**
> ""Why?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[349]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Symon Holl: ""I already had my eye on the area. Plus it wasn't intende..."*)

### Węzeł `[468]`
Mówca: **Symon Holl**
> ""I already had my eye on the area. Plus it wasn't intended to be public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Symon Holl: "“It is a small seaside villa at the outskirts of Conriat...."*)

### Węzeł `[469]`
Mówca: **Edith Agnoc**
> ""Come on, let's not talk about finance or politics for now. We came here to relax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Narrator: "She turned to Walter and Symon."*)

### Węzeł `[470]`
Mówca: **Walter Tusk**
> ""I'm just saying that he's free to do what he please with his hard earned money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "Edith, who was sitting to my left, gently put her hand ov..."*)

### Węzeł `[471]`
Mówca: **Walter Tusk**
> ""What's that supposed to mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "Edith, who was sitting to my left, gently put her hand ov..."*)

### Węzeł `[472]`
Mówca: **Symon Holl**
> ""Not really. His place is very remote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Walter Tusk: ""Conriat has a way of pulling certain people in, it seems.""*)

### Węzeł `[473]`
Mówca: **Walter Tusk**
> ""Conriat has a way of pulling certain people in, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "Edith, who was sitting to my left, gently put her hand ov..."*)

### Węzeł `[474]`
Mówca: **Symon Holl**
> ""No. Is there a problem?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Walter Tusk: ""Oh come on! Leave the man be, President.""*)

### Węzeł `[475]`
Mówca: **Walter Tusk**
> ""Oh come on! Leave the man be, President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "Edith, who was sitting to my left, gently put her hand ov..."*)

### Węzeł `[476]`
Mówca: **Edith Agnoc**
> ""Isn't that right, gentlemen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Narrator: "They nodded at her and took a sip from their drinks. She ..."*)

### Węzeł `[477]`
Mówca: **Narrator**
> "She turned to Walter and Symon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Edith Agnoc: ""Isn't that right, gentlemen?""*)

### Węzeł `[478]`
Mówca: **Narrator**
> "They nodded at her and took a sip from their drinks. She slightly leaned towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Edith Agnoc: ""So, Mr. Rayne, why don't you tell us what's behind that ..."*)

### Węzeł `[479]`
Mówca: **Edith Agnoc**
> ""So, Mr. Rayne, why don't you tell us what's behind that strong character of yours?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)

### Węzeł `[480]`
**[WYBÓR GRACZA: ""It didn't contribute much. My success has nothing to do with that.""]** — Mówca: **Player**
> ""It didn't contribute much. My success has nothing to do with that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[481]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Walter Tusk: ""Of course not. You've worked hard for it. After all, mon..."*)

### Węzeł `[481]`
Mówca: **Edith Agnoc**
> "“Would you say that it contributed a lot to your success?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Player: ""It didn't contribute much. My success has nothing to do ..."*)
  - -> `[485]` (*Player: ""It certainly helped. Money opened a lot of doors.""*)
  - -> `[486]` (*Player: ""We had money but we weren't happy. I learned a lot about..."*)
  - -> `[623]` (*Player: ""What's that supposed to mean?""*)

### Węzeł `[482]`
**[WYBÓR GRACZA: ""It was difficult times in the capital. But I've learned a lot about politics.""]** — Mówca: **Player**
> ""It was difficult times in the capital. But I've learned a lot about politics.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[428]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Walter Tusk: ""It all makes sense now!""*)

### Węzeł `[483]`
**[WYBÓR GRACZA: ""I didn't suffer much thanks to my family. We didn't have much but we were stable.""]** — Mówca: **Player**
> ""I didn't suffer much thanks to my family. We didn't have much but we were stable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[428]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Edith Agnoc: ""That's very humble of you.""*)

### Węzeł `[484]`
Mówca: **Walter Tusk**
> ""It all makes sense now!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Symon Holl: "“I never met your family, Mr. President. How are they doi..."*)

### Węzeł `[485]`
**[WYBÓR GRACZA: ""It certainly helped. Money opened a lot of doors.""]** — Mówca: **Player**
> ""It certainly helped. Money opened a lot of doors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[481]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Walter Tusk: ""Of course it did. What kind of question is that, Edith?""*)

### Węzeł `[486]`
**[WYBÓR GRACZA: ""We had money but we weren't happy. I learned a lot about life thanks to my absent father.""]** — Mówca: **Player**
> ""We had money but we weren't happy. I learned a lot about life thanks to my absent father.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[481]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Edith Agnoc: ""I'm sorry to hear that.""*)

### Węzeł `[487]`
Mówca: **Walter Tusk**
> ""Of course not. You've worked hard for it. After all, money can't buy diligence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Symon Holl: "“I never met your family, Mr. President. How are they doi..."*)

### Węzeł `[488]`
Mówca: **Walter Tusk**
> ""Of course it did. What kind of question is that, Edith?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Symon Holl: "“I never met your family, Mr. President. How are they doi..."*)

### Węzeł `[489]`
Mówca: **Edith Agnoc**
> ""I'm sorry to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Symon Holl: "“I never met your family, Mr. President. How are they doi..."*)

### Węzeł `[490]`
**[WYBÓR GRACZA: ""They're doing great. We have no problems.""]** — Mówca: **Player**
> ""They're doing great. We have no problems.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[446]` (Symon Holl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Symon Holl: ""That's great to hear. Your son must be very proud of you.""*)

### Węzeł `[491]`
Mówca: **Symon Holl**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Walter Tusk: "“Family is everything. My advice would be to make sure th..."*)

### Węzeł `[492]`
Mówca: **Symon Holl**
> ""That's great to hear. Your son must be very proud of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Walter Tusk: "“Family is everything. My advice would be to make sure th..."*)

### Węzeł `[493]`
Mówca: **Walter Tusk**
> "“Family is everything. My advice would be to make sure that Franc has a solid relationship with you. He is your future, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Player: "“I'm trying my best to be a good father to him. He seems ..."*)
  - -> `[454]` (*Player: ""He is going through the teenager period. It's difficult ..."*)
  - -> `[424]` (*Player: ""The kid can handle himself. He doesn't need anybody else.”"*)
  - -> `[496]` (*Player: ""Why do you even care?""*)

### Węzeł `[494]`
**[WYBÓR GRACZA: ""I said: I don't want to talk about my family.""]** — Mówca: **Player**
> ""I said: I don't want to talk about my family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[460]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Walter Tusk: ""I'm sorry, President. Let me know if I can help with any..."*)

### Węzeł `[495]`
Mówca: **Walter Tusk**
> ""I'm sorry, President. Let me know if I can help with anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Edith Agnoc: ""Maybe you should help Mikail instead. I saw Darron made ..."*)

### Węzeł `[496]`
**[WYBÓR GRACZA: ""Why do you even care?""]** — Mówca: **Player**
> ""Why do you even care?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[493]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Walter Tusk: ""I'm just giving advice, President!""*)

### Węzeł `[497]`
Mówca: **Walter Tusk**
> ""I'm just giving advice, President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Walter Tusk: ""Nobody would want a son that steals your yacht and make ..."*)

### Węzeł `[498]`
Mówca: **Walter Tusk**
> ""Nobody would want a son that steals your yacht and make the local news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Narrator: "He looked at Mikail."*)

### Węzeł `[499]`
Mówca: **Mikail Aven**
> ""Good news is that I finally convinced him to go to university. He will study economics in Lachaven Business School.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Walter Tusk: ""That's a good choice. Having a degree in Sordland separa..."*)

### Węzeł `[500]`
Mówca: **Narrator**
> "He looked at Mikail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Mikail Aven: ""Well, the rascal didn't even ask for permission to use t..."*)

### Węzeł `[501]`
Mówca: **Walter Tusk**
> ""Maybe your son will be a great future economist!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Mikail Aven: ""I wouldn't count on that.""*)

### Węzeł `[502]`
Mówca: **Mikail Aven**
> ""I wouldn't count on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[503]`
Mówca: **Mikail Aven**
> ""Not that I mean anything against you, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Player: "“Look at what he caused. Studying doesn't get you to the ..."*)
  - -> `[456]` (*Player: "“Alphonso was an inspiration for all reformists.""*)
  - -> `[453]` (*Player: "“We are in this mess because of him. His political failur..."*)
  - -> `[455]` (*Player: ""Mikail. What did you just say to me?""*)

### Węzeł `[504]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Mikail Aven: ""Not that I mean anything against you, Mr. Rayne.""*)

### Węzeł `[505]`
Mówca: **Mikail Aven**
> ""I'm very confident in your abilities to fix our recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Player: "“Look at what he caused. Studying doesn't get you to the ..."*)
  - -> `[456]` (*Player: "“Alphonso was an inspiration for all reformists.""*)
  - -> `[453]` (*Player: "“We are in this mess because of him. His political failur..."*)
  - -> `[506]` (*Player: ""Thank you.""*)

### Węzeł `[506]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[434]` (Mikail Aven), `[505]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Mikail Aven: ""I hope we can repair the damages to our economy. We can'..."*)

### Węzeł `[507]`
Mówca: **Mikail Aven**
> ""I hope we can repair the damages to our economy. We can't fail like Alphonso did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[508]`
**[WYBÓR GRACZA: ""I believe that too.""]** — Mówca: **Player**
> ""I believe that too.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[423]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Walter Tusk: "“He threatened their economic power base over the country..."*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Business_GuardsOutside = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Business_GuardsOutside"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Edith Agnoc: ""So, how did you find the food of the best fine dining re..."*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Business_GuardsOutside == true"*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Walter Tusk: ""A correction. It wasn't his policies that destroyed him...."*)

### Węzeł `[513]`
Mówca: **Edith Agnoc**
> ""Maybe you should help Mikail instead. I saw Darron made the local news with his yacht party in Benfi.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Narrator: "She looked at Mikail."*)

### Węzeł `[514]`
Mówca: **Narrator**
> "She looked at Mikail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Mikail Aven: ""Well, the rascal didn't even ask for permission to use t..."*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Business_GuardsOutside == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Business_GuardsOutside == true"*)
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Business_GuardsOutside == t..."*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Business_GuardsOutside == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Business_GuardsOutside"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Walter Tusk: ""A correction. It wasn't his policies that destroyed him...."*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Business_GuardsOutside == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Business_GuardsOutside"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Walter Tusk: ""A correction. It wasn't his policies that destroyed him.""*)

### Węzeł `[518]`
Mówca: **Narrator**
> "Walter looked at the guards inside the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Player: "“What do you mean?”"*)
  - -> `[522]` (*Player: "“Everybody knows that.”"*)
  - -> `[521]` (*Player: "“I always had a bad feeling about his sudden fall.”"*)
  - -> `[524]` (*Player: ""And?""*)

### Węzeł `[519]`
Mówca: **Walter Tusk**
> ""A correction. It wasn't his policies that destroyed him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Narrator: "Walter looked at the guards inside the room."*)

### Węzeł `[520]`
**[WYBÓR GRACZA: "“What do you mean?”"]** — Mówca: **Player**
> "“What do you mean?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[518]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Walter Tusk: ""Let's just say that he threatened the economic power bas..."*)

### Węzeł `[521]`
**[WYBÓR GRACZA: "“I always had a bad feeling about his sudden fall.”"]** — Mówca: **Player**
> "“I always had a bad feeling about his sudden fall.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[518]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Walter Tusk: ""Let's just say that he threatened the economic power bas..."*)

### Węzeł `[522]`
**[WYBÓR GRACZA: "“Everybody knows that.”"]** — Mówca: **Player**
> "“Everybody knows that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[518]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Walter Tusk: ""Let's just say that he threatened the economic power bas..."*)

### Węzeł `[523]`
Mówca: **Walter Tusk**
> ""Let's just say that he threatened the economic power base of some powerful figures within the government with his vast privatization plan. And they removed him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Narrator: "He lowered his voice."*)

### Węzeł `[524]`
**[WYBÓR GRACZA: ""And?""]** — Mówca: **Player**
> ""And?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[518]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Walter Tusk: ""Let's just say that he threatened the economic power bas..."*)

### Węzeł `[525]`
Mówca: **Walter Tusk**
> ""And now they're backing you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Mikail Aven: "“Walter stop with the conspiracy theories. I think we've ..."*)

### Węzeł `[526]`
Mówca: **Narrator**
> "He lowered his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Walter Tusk: ""And now they're backing you.""*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Player: ""You don't want to say this again in public.""*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Player: ""I believe that too.""*)

### Węzeł `[530]`
**[WYBÓR GRACZA: ""You don't want to say this again in public.""]** — Mówca: **Player**
> ""You don't want to say this again in public.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[423]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Narrator: "There was a brief silence."*)

### Węzeł `[531]`
Mówca: **Narrator**
> "There was a brief silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Mikail Aven: "“Walter stop with the conspiracy theories. I think we've ..."*)

### Węzeł `[532]`
Mówca: **Narrator**
> "After a long silence, followed by some chit-chat, Walter ordered a bottle of whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Mikail Aven: ""That's one good looking bottle.""*)

### Węzeł `[533]`
**[WYBÓR GRACZA: "“Symon would you give a toast again?”"]** — Mówca: **Player**
> "“Symon would you give a toast again?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[536]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Symon Holl: "“Sure.”"*)

### Węzeł `[534]`
Mówca: **Symon Holl**
> "“Sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Narrator: "Symon stood up. He seemed to have a slight issue with his..."*)

### Węzeł `[535]`
Mówca: **Mikail Aven**
> ""That's one good looking bottle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Narrator: "The waiters brought one of the finest Arcasian whiskeys. ..."*)

### Węzeł `[536]`
Mówca: **Narrator**
> "The waiters brought one of the finest Arcasian whiskeys. It was time for a toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Player_Italic: "Toast."*)
  - -> `[558]` (*Player: ""I'm not going to drink.""*)
  - -> `[533]` (*Player: "“Symon would you give a toast again?”"*)

### Węzeł `[537]`
**[WYBÓR GRACZA: "“I raise to our health and happiness.”"]** — Mówca: **Player**
> "“I raise to our health and happiness. The two things that one needs for a happy life.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[557]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Edith Agnoc: "“I would gladly drink to that.”"*)

### Węzeł `[538]`
**[WYBÓR GRACZA: "“To a constructive and beneficial future!”"]** — Mówca: **Player**
> "“To a constructive and beneficial future! May our differences be set aside for a good future.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[557]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Walter Tusk: "“They say hope dies last, to the future.”"*)

### Węzeł `[539]`
**[WYBÓR GRACZA: "“To our wealth and success!”"]** — Mówca: **Player**
> "“To our wealth and success! Let's be honest, that's all that truly matters to any of us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[557]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Symon Holl: "“Aye.”"*)

### Węzeł `[540]`
Mówca: **Narrator**
> "Edith stood up. Most of us were all a little tipsy at this point."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Edith Agnoc: "“I want to thank you, Mr. President for joining us and yo..."*)

### Węzeł `[541]`
Mówca: **Walter Tusk**
> "“I agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Edith Agnoc: "“Good night everybody. It was a pleasure.”"*)

### Węzeł `[542]`
Mówca: **Narrator**
> "The moon was shining bright as everyone except Walter left in their luxury cars."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Walter Tusk: "“President. A moment alone please.”"*)

### Węzeł `[543]`
**[WYBÓR GRACZA: "“It's getting late. Let's call it a night.”"]** — Mówca: **Player**
> "“It's getting late. Let's call it a night.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[550]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Walter Tusk: "“I agree.”"*)

### Węzeł `[544]`
Mówca: **Edith Agnoc**
> "“I would gladly drink to that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Mikail Aven: "“Me too.”"*)

### Węzeł `[545]`
Mówca: **Mikail Aven**
> "“Me too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Symon Holl: "“I think it's time we call it a night.”"*)

### Węzeł `[546]`
Mówca: **Walter Tusk**
> "“Cheers to that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Symon Holl: "“I think it's time we call it a night.”"*)

### Węzeł `[547]`
Mówca: **Symon Holl**
> "“Aye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Walter Tusk: "“Cheers to that.”"*)

### Węzeł `[548]`
Mówca: **Walter Tusk**
> "“They say hope dies last, to the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Mikail Aven: "“Raised.”"*)

### Węzeł `[549]`
Mówca: **Symon Holl**
> "“I think it's time we call it a night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Narrator: "Edith stood up. Most of us were all a little tipsy at thi..."*)

### Węzeł `[550]`
Mówca: **Edith Agnoc**
> "“I want to thank you, Mr. President for joining us and you Symon, for putting all this together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Player: ""Thank you all for being here.""*)
  - -> `[555]` (*Player: ""Thank you Edith, for joining with a bunch of ugly rich m..."*)
  - -> `[543]` (*Player: "“It's getting late. Let's call it a night.”"*)

### Węzeł `[551]`
Mówca: **Mikail Aven**
> "“Raised.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Symon Holl: "“I think it's time we call it a night.”"*)

### Węzeł `[552]`
Mówca: **Symon Holl**
> "“May the wheels of fortune always turn in our favour! The future of abundance awaits us!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Walter Tusk: "“Cheers to that.”"*)

### Węzeł `[553]`
Mówca: **Mikail Aven**
> ""That's definitely not me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Walter Tusk: ""The President of jokes.""*)

### Węzeł `[554]`
Mówca: **Edith Agnoc**
> "“Good night everybody. It was a pleasure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Narrator: "After bidding our farewells, we slowly walked out the res..."*)

### Węzeł `[555]`
**[WYBÓR GRACZA: ""Thank you Edith, for joining with a bunch of ugly rich men.""]** — Mówca: **Player**
> ""Thank you Edith, for joining with a bunch of ugly rich men.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[550]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Mikail Aven: ""That's definitely not me.""*)

### Węzeł `[556]`
Mówca: **Walter Tusk**
> ""The President of jokes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Mikail Aven: ""Thanks for being here.""*)

### Węzeł `[557]`
**[WYBÓR GRACZA: "Toast."]** — Mówca: **Player_Italic**
> "I stood up to give a toast."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[536]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Player: "“I raise to our health and happiness.”"*)
  - -> `[538]` (*Player: "“To a constructive and beneficial future!”"*)
  - -> `[539]` (*Player: "“To our wealth and success!”"*)
  - -> `[560]` (*Player: "“To an equal society without class differences. A Morgna ..."*)

### Węzeł `[558]`
**[WYBÓR GRACZA: ""I'm not going to drink.""]** — Mówca: **Player**
> ""I'm not going to drink.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[536]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Walter Tusk: ""Fine.""*)

### Węzeł `[559]`
Mówca: **Narrator**
> "Symon stood up. He seemed to have a slight issue with his balance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Symon Holl: "“May the wheels of fortune always turn in our favour! The..."*)

### Węzeł `[560]`
**[WYBÓR GRACZA: "“To an equal society without class differences. A Morgna wes core!""]** — Mówca: **Player**
> "“To an equal society without class differences. A Morgna wes core!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[557]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Węzeł Logiki Narracyjnej: "BaseGame.AMorgnaWesCore += 1"*)

### Węzeł `[561]`
Mówca: **Narrator**
> "Nobody else responded. And Symon looked like he had a little too much alcohol."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Narrator: "There was an awkward silence as they looked at each other..."*)

### Węzeł `[562]`
Mówca: **Symon Holl**
> ""Aye!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Narrator: "Nobody else responded. And Symon looked like he had a lit..."*)

### Węzeł `[563]`
Mówca: **Narrator**
> "There was an awkward silence as they looked at each other with glasses in their hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Edith Agnoc: ""Vectern sis da...""*)

### Węzeł `[564]`
Mówca: **Edith Agnoc**
> ""Vectern sis da...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Symon Holl: "“I think it's time we call it a night.”"*)

### Węzeł `[565]`
Mówca: **Walter Tusk**
> ""Fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Walter Tusk: ""Let's just drink this up and leave.""*)

### Węzeł `[566]`
Mówca: **Walter Tusk**
> ""Let's just drink this up and leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Walter Tusk: ""Symon?""*)

### Węzeł `[567]`
Mówca: **Walter Tusk**
> ""Symon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Narrator: "Symon stood up. He seemed to have a slight issue with his..."*)

### Węzeł `[568]`
**[WYBÓR GRACZA: ""Thank you all for being here.""]** — Mówca: **Player**
> ""Thank you all for being here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[550]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Mikail Aven: ""It was great.""*)

### Węzeł `[569]`
Mówca: **Walter Tusk**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Mikail Aven: ""Thanks for being here.""*)

### Węzeł `[570]`
Mówca: **Mikail Aven**
> ""It was great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Walter Tusk: ""Thank you.""*)

### Węzeł `[571]`
Mówca: **Mikail Aven**
> ""Thanks for being here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Narrator: "After bidding our farewells, we slowly walked out the res..."*)

### Węzeł `[572]`
Mówca: **Narrator**
> "After bidding our farewells, we slowly walked out the restaurant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Narrator: "The moon was shining bright as everyone except Walter lef..."*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "He gestured at the guards and then called me inside the s..."*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "He called me inside the small VIP lounge."*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Walter Tusk: ""We are really concerned about the state of emergency. We..."*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Walter Tusk: "“Finally a President that listens to the people. It won't..."*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusiness == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusiness == true"*)
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_BailBusiness == true)"*)

### Węzeł `[580]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusiness == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Walter Tusk: "“We had a deal about the business bailout package.""*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_BailBusiness == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Walter Tusk: "“You rejected our previous discrete offer to bail out bus..."*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true || BaseGame.Turn01_InT_Investment_Railway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true || BaseGam..."*)
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true || BaseG..."*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true || BaseGame.Turn01_InT_Investment_Railway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true  or  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company == true"*)

### Węzeł `[584]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true || BaseGame.Turn01_InT_Investment_Railway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true  or  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusiness == true"*)

### Węzeł `[585]`
Mówca: **Walter Tusk**
> "“You rejected our previous discrete offer to bail out businesses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesse..."*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Walter Tusk: "“You held on to that promise. This went well in our book.”"*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Walter Tusk: "“You broke that promise. This action led to a huge disapp..."*)

### Węzeł `[589]`
Mówca: **Walter Tusk**
> "“We had a deal about the business bailout package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[590]`
Mówca: **Walter Tusk**
> "“You held on to that promise. This went well in our book.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content = true"*)

### Węzeł `[591]`
Mówca: **Walter Tusk**
> "“This action led to disappointment in the Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Walter Tusk: "“We are aware of the upcoming tax meeting and it would be..."*)

### Węzeł `[592]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Walter Tusk: "“We are aware of the upcoming tax meeting and it would be..."*)

### Węzeł `[593]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)
  - -> `[595]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesse..."*)

### Węzeł `[594]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Walter Tusk: "“However, you still made the right choice. Your party not..."*)

### Węzeł `[595]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Walter Tusk: "“This action led to disappointment in the Group.”"*)

### Węzeł `[596]`
Mówca: **Walter Tusk**
> "“However, you still made the right choice. Your party not getting that donation is unfortunate though. Why someone wouldn't want that money is beyond me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content = true"*)

### Węzeł `[597]`
Mówca: **Walter Tusk**
> "“You broke that promise. This action led to a huge disappointment in the Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "“What can be done to amend the situation?”"*)
  - -> `[15]` (*Player: "“The opinions of the Lotherberg group don't concern me. I..."*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedTusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Walter Tusk: "“I'm very satisfied to hear this. To us and the prosperou..."*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn03_BusinessCouncil_RejectedTusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_BusinessCouncil_RejectedTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Walter left and Serge came to pick me up."*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedPrivatizationTusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedPrivatizationTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedTu..."*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedPrivatizationTusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedPrivatizationTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn03_BusinessCouncil_PromisedTu..."*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_BusinessCouncil = true; BaseGameSupport.News_Turn03_LT_MorbelMineDisaster = true;
BaseGameSupport.News_Turn03_HP_WorkerBillDrafted = true;
BaseGameSupport.Report_Turn03_Ribel_SchoolPoisoning = true;
BaseGameSupport.Report_Turn03_Arvory_BombAttack = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_BusinessCouncil"] = true;
Variable["BaseGameSupport.News_Turn03_LT_MorbelMineDisaster"] = true;
Variable["BaseGameSupport.News_Turn03_HP_WorkerBillDrafted"] = true;
Variable["BaseGameSupport.Report_Turn03_Ribel_SchoolPoisoning"] = true;
Variable["BaseGameSupport.Report_Turn03_Arvory_BombAttack"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true && Base..."*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true && Base..."*)
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true && Ba..."*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn03_Jen_Emergency_YSBanned = true"*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true  and  Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[606]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[607]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Erzaren", "City_Widespre..."*)

### Węzeł `[608]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn03_Jen_Emergency_YSBanned = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Jen_Emergency_YSBanned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Jen", "City_WidespreadPr..."*)

### Węzeł `[610]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Emergency_WPBArrests = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Emergency_WPBArrests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall ..."*)

### Węzeł `[611]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[612]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Laren", "City_Widespread..."*)

### Węzeł `[613]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)

### Węzeł `[614]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)"*)

### Węzeł `[615]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Lenkurg", "City_Widespre..."*)

### Węzeł `[616]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)

### Węzeł `[617]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)
  - -> `[619]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)"*)

### Węzeł `[618]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Anrica", "City_Widesprea..."*)

### Węzeł `[619]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Anrica", "City_Lockdown");"*)

### Węzeł `[620]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn03_Laren_Emergency_DetentionWithoutTrial = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Laren_Emergency_DetentionWithoutTrial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)

### Węzeł `[621]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn03_Lenkurg_Emergency_PoliceAuthority = true; BaseGameSupport.Report_Turn03_Sarna_Emergency_Surveillance = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Lenkurg_Emergency_PoliceAuthority"] = true;
Variable["BaseGameSupport.Report_Turn03_Sarna_Emergency_Surveillance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)

### Węzeł `[622]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn03_Anrica_Emergency_SuspendedProtests = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Anrica_Emergency_SuspendedProtests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Anrica", "City_Lockdown");"*)

### Węzeł `[623]`
**[WYBÓR GRACZA: ""What's that supposed to mean?""]** — Mówca: **Player**
> ""What's that supposed to mean?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[481]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Edith Agnoc: ""Oh. N-Nothing, Mr. President. I'm sorry if it came acros..."*)

### Węzeł `[624]`
Mówca: **Edith Agnoc**
> ""Oh. N-Nothing, Mr. President. I'm sorry if it came across wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Narrator: "The table went quiet for a few seconds."*)

### Węzeł `[625]`
Mówca: **Narrator**
> "The table went quiet for a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Symon Holl: "“I never met your family, Mr. President. How are they doi..."*)

### Węzeł `[626]`
Mówca: **Narrator**
> "Walter stared at me as the guards bowed their heads and went outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Business_GuardsOutside = true"*)

### Węzeł `[627]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Symon Holl: ""I'd like to thank Mr. Rayne again for his decisiveness i..."*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Symon Holl: ""I'd like to thank Mr. Rayne again for his decisiveness w..."*)

### Węzeł `[630]`
Mówca: **Symon Holl**
> ""I'd like to thank Mr. Rayne again for his decisiveness in office... I'm sure we will get through this emergency period and come out stronger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Symon Holl: ""I also thank Mr. Tusk for being here with us today... Hi..."*)

### Węzeł `[631]`
**[WYBÓR GRACZA: ""What do you want?""]** — Mówca: **Player**
> ""What do you want?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Walter Tusk: "“Usually the Lotherberg spokesman doesn't directly commen..."*)

### Węzeł `[632]`
**[WYBÓR GRACZA: "Follow him."]** — Mówca: **Player_Italic**
> "I followed him inside."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Narrator), `[70]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Walter Tusk: "“Usually the Lotherberg spokesman doesn't directly commen..."*)

### Węzeł `[633]`
**[WYBÓR GRACZA: "Ignore him and leave."]** — Mówca: **Player_Italic**
> "I ignored him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Narrator), `[70]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "Jump to: [Player_Italic: "I entered the car and we drove ..."*)

### Węzeł `[634]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Player_Italic: "I entered the car and we drove to o..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player_Italic: "Enter the car."*)

### Węzeł `[635]`
**[WYBÓR GRACZA: "“I couldn't care less.”"]** — Mówca: **Player**
> "“I couldn't care less.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Walter Tusk: "“Oh but you definitely should, President.”"*)

### Węzeł `[636]`
Mówca: **Walter Tusk**
> "“Oh but you definitely should, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "He looked me in the eye."*)

### Węzeł `[637]`
**[WYBÓR GRACZA: "“I don't want to hear your comments, Mr. Tusk.”"]** — Mówca: **Player**
> "“I don't want to hear your comments, Mr. Tusk.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Walter Tusk: "“You don't mean that.”"*)

### Węzeł `[638]`
Mówca: **Walter Tusk**
> "“You don't mean that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Walter Tusk: "“The comments of the Lotherberg Group should matter to yo..."*)

### Węzeł `[639]`
Mówca: **Walter Tusk**
> "“The comments of the Lotherberg Group should matter to you, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Walter Tusk: "“Please let me briefly explain myself.”"*)

### Węzeł `[640]`
Mówca: **Walter Tusk**
> "“Please let me briefly explain myself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "“I'm all ears.”"*)
  - -> `[8]` (*Player: "“Sure, if you have to.”"*)
  - -> `[641]` (*Player: ""Maybe some other time. Good evening.""*)

### Węzeł `[641]`
**[WYBÓR GRACZA: ""Maybe some other time. Good evening.""]** — Mówca: **Player**
> ""Maybe some other time. Good evening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[640]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Narrator: "I ignored him and left."*)

### Węzeł `[642]`
Mówca: **Narrator**
> "I ignored him and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "Jump to: [Player_Italic: "I entered the car and we drove ..."*)

### Węzeł `[643]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Player_Italic: "I entered the car and we drove to o..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player_Italic: "Enter the car."*)

### Węzeł `[644]`
**[WYBÓR GRACZA: "“Lotherberg will not influence me.”"]** — Mówca: **Player**
> "“Lotherberg will not influence me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Walter Tusk: "“Oh let's not be hasty. The recession will end if Lotherb..."*)

### Węzeł `[645]`
Mówca: **Narrator**
> "Everyone fell silent and looked at Mikail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Mikail Aven: ""Er... No. I didn't mean t-""*)

### Węzeł `[646]`
Mówca: **Walter Tusk**
> ""Oh, excuse him, President! He didn't mean anything bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Narrator: "Walter laughed and Mikail joined in with a nervous laught..."*)

### Węzeł `[647]`
Mówca: **Mikail Aven**
> ""Er... No. I didn't mean t-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Walter Tusk: ""Oh, excuse him, President! He didn't mean anything bad.""*)

### Węzeł `[648]`
Mówca: **Narrator**
> "Walter laughed and Mikail joined in with a nervous laughter soon after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Player: ""Fine.""*)
  - -> `[651]` (*Player: ""No. What did he just say?""*)

### Węzeł `[649]`
Mówca: **Edith Agnoc**
> "“Enough with this Alphonso talk. His policies already destroyed him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[650]`
**[WYBÓR GRACZA: ""Fine.""]** — Mówca: **Player**
> ""Fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[648]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Edith Agnoc: "“Enough with this Alphonso talk. His policies already des..."*)

### Węzeł `[651]`
**[WYBÓR GRACZA: ""No. What did he just say?""]** — Mówca: **Player**
> ""No. What did he just say?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[648]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "Nobody responded."*)

### Węzeł `[652]`
Mówca: **Narrator**
> "Nobody responded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Player: ""I thought so.""*)
  - -> `[655]` (*Player: ""Looks like a cat caught our friend's tongue.""*)
  - -> `[654]` (*Player: ""WILL SOMEBODY ANSWER ME?""*)

### Węzeł `[653]`
**[WYBÓR GRACZA: ""I thought so.""]** — Mówca: **Player**
> ""I thought so.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[652]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Edith Agnoc: "“Enough with this Alphonso talk. His policies already des..."*)

### Węzeł `[654]`
**[WYBÓR GRACZA: ""WILL SOMEBODY ANSWER ME?""]** — Mówca: **Player**
> ""WILL SOMEBODY ANSWER ME?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[652]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Mikail Aven: ""No need to shout at the table, Mr. President.""*)

### Węzeł `[655]`
**[WYBÓR GRACZA: ""Looks like a cat caught our friend's tongue.""]** — Mówca: **Player**
> ""Looks like a cat caught our friend's tongue.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[652]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Edith Agnoc: "“Enough with this Alphonso talk. His policies already des..."*)

### Węzeł `[656]`
Mówca: **Mikail Aven**
> ""No need to shout at the table, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Player: ""You still didn't give me a response.""*)
  - -> `[657]` (*Player: ""Enough. I'm done with this dinner.""*)

### Węzeł `[657]`
**[WYBÓR GRACZA: ""Enough. I'm done with this dinner.""]** — Mówca: **Player**
> ""Enough. I'm done with this dinner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[656]` (Mikail Aven), `[659]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Narrator: "I stood up and left the room."*)

### Węzeł `[658]`
**[WYBÓR GRACZA: ""You still didn't give me a response.""]** — Mówca: **Player**
> ""You still didn't give me a response.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[656]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Mikail Aven: ""I said 'Ewald Alphonso was the only leader who was well-..."*)

### Węzeł `[659]`
Mówca: **Mikail Aven**
> ""I said 'Ewald Alphonso was the only leader who was well-versed in economics'. Please forgive me, I didn't mean to offend you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Player: ""Fine. Watch your words next time.""*)
  - -> `[657]` (*Player: ""Enough. I'm done with this dinner.""*)

### Węzeł `[660]`
**[WYBÓR GRACZA: ""Fine. Watch your words next time.""]** — Mówca: **Player**
> ""Fine. Watch your words next time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[659]` (Mikail Aven)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Edith Agnoc: "“Enough with this Alphonso talk. His policies already des..."*)

### Węzeł `[661]`
Mówca: **Narrator**
> "I stood up and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Narrator: "Walter came running behind me as I walked outside."*)

### Węzeł `[662]`
Mówca: **Narrator**
> "Walter came running behind me as I walked outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Walter Tusk: "“President. A moment alone please.”"*)

### Węzeł `[663]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[665]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[664]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Mikail Aven: ""But I agree that we need more economists to enter politi..."*)

### Węzeł `[665]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Mikail Aven: ""But I agree that we need more economists to enter politi..."*)

### Węzeł `[666]`
Mówca: **Mikail Aven**
> ""But I agree that we need more economists to enter politics. Thankfully we have a president who seems to be as well-versed in economics as Alphonso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Narrator: "He turned to me."*)

### Węzeł `[667]`
**[WYBÓR GRACZA: "“I appreciate the advice but I don't like salmon.""]** — Mówca: **Player**
> "“I appreciate the advice but I don't like salmon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Walter Tusk: "“Really? As a Lachavener, too?""*)

### Węzeł `[668]`
Mówca: **Walter Tusk**
> "“Really? As a Lachavener, too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Walter Tusk: "“I guess that's your loss.""*)

### Węzeł `[669]`
Mówca: **Walter Tusk**
> "“I guess that's your loss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player_Italic: "Order traditional Sordish bean stew."*)
  - -> `[124]` (*Player_Italic: "Order Lespian Pasta."*)

### Węzeł `[670]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Mikail Aven: ""I'm very confident in your abilities to fix our recession.""*)

### Węzeł `[671]`
Mówca: **Walter Tusk**
> ""Ah, of course. Nobody can say no to a bottle of wine by Giralt of Ribery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "I took a sip."*)

### Węzeł `[672]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)"*)

### Węzeł `[673]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_LeagueWomenStrike = true"*)

### Węzeł `[674]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_LeagueWomenMarch = true"*)

### Węzeł `[675]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_LeagueWomenStrike = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_LeagueWomenStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[676]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_LeagueWomenMarch = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_LeagueWomenMarch"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[677]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)
  - -> `[679]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == ..."*)

### Węzeł `[678]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_Nationwide_Protests = true; Base..."*)

### Węzeł `[679]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_EnT_BusinessCouncil = true"*)

### Węzeł `[680]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_Nationwide_Protests = true;
BaseGame.Situation_Order_Nationwide_Revolt = false;
BaseGame.Situation_Order_Nationwide_Quelled = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_Nationwide_Protests"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_EnT_BusinessCouncil = true"*)

### Węzeł `[681]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall = false; BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall_BludBan = true; BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall_Poisoned = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall"] = false;
Variable["BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall_BludBan"] = true;
Variable["BaseGameSupport.Codex_Characters_PartyLeaders_FetihEjall_Poisoned"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Fetih Ejall", "Inmate 64284");"*)

### Węzeł `[682]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AMorgnaWesCore += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Symon Holl: ""Aye!""*)

### Węzeł `[683]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Anrica", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Anrica","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn03_Anrica_Emergency_SuspendedP..."*)

### Węzeł `[684]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Laren", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Laren","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn03_Laren_Emergency_DetentionWi..."*)

### Węzeł `[685]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Lenkurg", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Lenkurg","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn03_Lenkurg_Emergency_PoliceAut..."*)

### Węzeł `[686]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Erzaren", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Erzaren","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Emergency_WPBArrests = true"*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Jen", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Jen","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Anrica", "City_Lockdown");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Anrica","City_Lockdown");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)

### Węzeł `[689]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Policy_..."*)
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Polic..."*)

### Węzeł `[690]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn03_Rumburg_Emergency_Ba..."*)

### Węzeł `[691]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Policy_Diplomacy_EmbargoingRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_BusinessCouncil = true; Ba..."*)

### Węzeł `[692]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn03_Rumburg_Emergency_BannedRumburg = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn03_Rumburg_Emergency_BannedRumburg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_BusinessCouncil = true; Ba..."*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[694]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Fetih Ejall", "Inmate 64284");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Fetih Ejall","Inmate 64284");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
