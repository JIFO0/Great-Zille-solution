# Sordland/Turn10/DINNER WITH ONLY FRANC

- **ID konwersacji:** `217`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/217_DINNER_WITH_ONLY_FRANC.md`
- **Liczba węzłów dialogowych:** 351
- **Liczba wyborów gracza:** 94

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[31]** Franc

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn09_StrongWomensRights_Vetoed`
- `BaseGame.Bill_Turn09_WeakWomensRights_Vetoed`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Decision_Turn08_VPSelection_Albin`
- `BaseGame.Decision_Turn08_VPSelection_Gloria`
- `BaseGame.Decision_Turn08_VPSelection_Lucian`
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.JoinParty_CPS`
- `BaseGame.JoinParty_NFP`
- `BaseGame.JoinParty_PFJP`
- `BaseGame.JoinParty_WPB`
- `BaseGame.LeakedScandal_Franc_StateUniversity`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Public_Opinion`
- `BaseGame.Relations_Monica_Slapped`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Rumburg_War`
- `BaseGame.Turn05_Admin_Monica_Barred`
- `BaseGame.Turn08_SecondScandal_ShareBlame`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_JoinedOtherParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn10_PartyCongress_Retired`
- `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation`
- `GameCondition.Turn09_Personal_PetrFuneral`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_Exile`
- `BaseGame.Exile_LeaveNow`
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[51]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""You're late.""** | `[4]` **Narrator**: "Nearly half an hour after he sai..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Franc**: ""Yeah, I know. I'm sorry."" |
| `[6]` | **""Is everything all right?""** | `[4]` **Narrator**: "Nearly half an hour after he sai..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Franc**: ""Yeah, yeah. I'm sorry."" |
| `[14]` | **""They might be.""** | `[9]` **Franc**: ""Are some of those guards outsid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Franc**: ""Well, I'd be more suspicious of..." |
| `[15]` | **""I'm starting to get suspicious of them, to be honest.""** | `[9]` **Franc**: ""Are some of those guards outsid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Narrator**: "He flung his backpack on the liv..." |
| `[23]` | **""It wasn't a 'close call' for Serge.""** | `[18]` **Franc**: ""Shit, Dad, that parade was a cl..." | `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true` | *Brak zmian stanu* | `[31]` **Franc**: ""I know. I can't believe he's go..." |
| `[24]` | **""I know. I still can't believe nobody was hurt.""** | `[18]` **Franc**: ""Shit, Dad, that parade was a cl..." | `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false` | *Brak zmian stanu* | `[30]` **Franc**: ""Mom would kill me for telling y..." |
| `[25]` | **""Language!""** | `[18]` **Franc**: ""Shit, Dad, that parade was a cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Franc**: ""Serge is dead, and your biggest..."<br>`[29]` **Franc**: ""You almost died *again*, and yo..." |
| `[33]` | **""How is your mother, anyway?""** | `[30]` **Franc**: ""Mom would kill me for telling y..."<br>`[32]` **Franc**: ""Mom was inconsolable about it.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "Franc shrugged uncomfortably." |
| `[36]` | **""I hope you two are being careful.""** | `[35]` **Narrator**: "He flung his backpack on the liv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Narrator**: "Franc rolled his eyes." |
| `[37]` | **""So when's the wedding?""** | `[35]` **Narrator**: "He flung his backpack on the liv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Narrator**: "Franc rolled his eyes." |
| `[38]` | **""You *know* those brats? I was going to ask the guards to have them tear-gassed.""** | `[13]` **Franc**: ""I ran into a couple of my frien..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Franc**: ""Don't do it. They brought goggl..." |
| `[39]` | **""You could've invited them in. There's enough food.""** | `[13]` **Franc**: ""I ran into a couple of my frien..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Franc**: ""Ha. Even if they would cross th..." |
| `[46]` | **""How is Deana?""** | `[30]` **Franc**: ""Mom would kill me for telling y..."<br>`[32]` **Franc**: ""Mom was inconsolable about it.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Franc**: ""I mean, I think between the div..."<br>`[70]` **Franc**: ""I mean, I think between the div..."<br>*(oraz 2 innych odgałęzień)* |
| `[53]` | **""That's a relief.""** | `[49]` **Franc**: ""She won't tell me who she's vot..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Franc**: ""Who will you vote for, Dad? Now..."<br>`[329]` **Franc**: ""Who would you vote for? I mean,..."<br>*(oraz 1 innych odgałęzień)* |
| `[54]` | **""Who are you voting for? Now that you're old enough.""** | `[49]` **Franc**: ""She won't tell me who she's vot..."<br>`[55]` **Franc**: ""She won't tell me who she's vot..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Franc**: ""Does it matter?""<br>`[98]` **Franc**: ""I'm voting for the candidate wh..." |
| `[56]` | **""That's not surprising.""** | `[55]` **Franc**: ""She won't tell me who she's vot..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Franc**: ""Although it doesn't matter, doe..."<br>`[97]` **Franc**: ""Who would you vote for? I mean,..." |
| `[57]` | **""Of course it does. Every vote counts.""** | `[80]` **Franc**: ""Does it matter?""<br>`[84]` **Franc**: ""Although it doesn't matter, doe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "The oven timer went off. I took ..." |
| `[72]` | **""And you haven't?""** | `[65]` **Franc**: ""I mean, I think between the div..."<br>`[69]` **Franc**: ""I mean, I think between the div..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Franc**: ""It's different. I'm older."" |
| `[73]` | **""And I haven't?""** | `[65]` **Franc**: ""I mean, I think between the div..."<br>`[69]` **Franc**: ""I mean, I think between the div..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Franc**: ""Jeez, Dad. Not everything is ab..." |
| `[75]` | **""What about your mother?""** | `[65]` **Franc**: ""I mean, I think between the div..."<br>`[69]` **Franc**: ""I mean, I think between the div..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "Franc shrugged uncomfortably." |
| `[76]` | **""Old enough to vote, even.""** | `[74]` **Franc**: ""It's different. I'm older."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Franc**: ""Who will you vote for, Dad? Now..."<br>`[329]` **Franc**: ""Who would you vote for? I mean,..."<br>*(oraz 1 innych odgałęzień)* |
| `[85]` | **""No, I suppose not.""** | `[80]` **Franc**: ""Does it matter?""<br>`[84]` **Franc**: ""Although it doesn't matter, doe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "The oven timer went off. I took ..." |
| `[90]` | **""I'd rather not say.""** | `[89]` **Franc**: ""Who will you vote for, Dad? Now..."<br>`[97]` **Franc**: ""Who would you vote for? I mean,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Franc**: ""Fair enough."" |
| `[91]` | **""Honestly, Lileas.""** | `[89]` **Franc**: ""Who will you vote for, Dad? Now..."<br>`[97]` **Franc**: ""Who would you vote for? I mean,..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.JoinParty_NFP"] == true` | *Brak zmian stanu* | `[94]` **Narrator**: "Franc raised his eyebrows." |
| `[92]` | **""Perhaps PFJP.""** | `[89]` **Franc**: ""Who will you vote for, Dad? Now..."<br>`[97]` **Franc**: ""Who would you vote for? I mean,..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.JoinParty_NFP"] == true` | *Brak zmian stanu* | `[94]` **Narrator**: "Franc raised his eyebrows." |
| `[93]` | **""Perhaps NFP.""** | `[89]` **Franc**: ""Who will you vote for, Dad? Now..."<br>`[97]` **Franc**: ""Who would you vote for? I mean,..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.JoinParty_NFP"] == true) == false` | *Brak zmian stanu* | `[94]` **Narrator**: "Franc raised his eyebrows." |
| `[99]` | **""Nice try, but no.""** | `[98]` **Franc**: ""I'm voting for the candidate wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "The oven timer went off. I took ..." |
| `[100]` | **""You want it, you got it.""** | `[98]` **Franc**: ""I'm voting for the candidate wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "The oven timer went off. I took ..." |
| `[101]` | **""Perhaps one of the small parties.""** | `[97]` **Franc**: ""Who would you vote for? I mean,..."<br>`[329]` **Franc**: ""Who would you vote for? I mean,..." | `Variable["BaseGame.JoinParty_NFP"] == true` | *Brak zmian stanu* | `[94]` **Narrator**: "Franc raised his eyebrows." |
| `[113]` | **""What is it?""** | `[112]` **Narrator**: "After we'd eaten, Franc kept toy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Narrator**: "Franc looked down at the tablecl..." |
| `[114]` | **""Was dinner all right?""** | `[112]` **Narrator**: "After we'd eaten, Franc kept toy..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Franc**: ""Yeah, it was great."" |
| `[120]` | **""Yes, I can see that.""** | `[74]` **Franc**: ""It's different. I'm older."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "The oven timer went off. I took ..." |
| `[126]` | **""What gave you that idea? The bullets just barely whistling past my skull?""** | `[125]` **Franc**: ""Dad, I think you should leave S..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Franc**: ""That might have had something t..." |
| `[127]` | **""That's ridiculous. I can take care of myself.""** | `[125]` **Franc**: ""Dad, I think you should leave S..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Franc**: ""I'm not talking about you."" |
| `[128]` | **""It's crossed my mind once or twice.""** | `[124]` **Franc**: ""Dad, have you thought about qui..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Franc**: ""It's just that... Deana told me..." |
| `[129]` | **""Never.""** | `[124]` **Franc**: ""Dad, have you thought about qui..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Franc**: ""It's just that... Deana told me..." |
| `[130]` | **""Are you insane, son?""** | `[124]` **Franc**: ""Dad, have you thought about qui..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Franc**: ""It's just that... Deana told me..." |
| `[136]` | **""No. I'm the target.""** | `[134]` **Franc**: ""There's no guarantee that the s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Franc**: ""They killed Serge, didn't they?""<br>`[143]` **Franc**: ""They almost killed Serge, didn'..." |
| `[137]` | **""You might be right.""** | `[134]` **Franc**: ""There's no guarantee that the s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Franc**: ""They killed Serge, didn't they?""<br>`[143]` **Franc**: ""They almost killed Serge, didn'..." |
| `[138]` | **""You're watching too many conspiracy thrillers.""** | `[134]` **Franc**: ""There's no guarantee that the s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Franc**: ""They killed Serge, didn't they?""<br>`[143]` **Franc**: ""They almost killed Serge, didn'..." |
| `[145]` | **""I already said I'd retire. Isn't that enough?""** | `[144]` **Franc**: ""Haven't you thought about just ..." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[164]` **Franc**: ""I don't know! Who knows what th..." |
| `[147]` | **""What? I'll show those eggheads!""** | `[146]` **Franc**: ""And my politics professors said..."<br>`[336]` **Franc**: ""And my politics professors say ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Franc**: ""Just think about it. Please."" |
| `[148]` | **""I can't give up now, Franc. You're too young to understand.""** | `[146]` **Franc**: ""And my politics professors said..."<br>`[336]` **Franc**: ""And my politics professors say ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Franc**: ""Trust me, I understand."" |
| `[149]` | **""I didn't know how hard it was for you kids. I'm sorry.""** | `[146]` **Franc**: ""And my politics professors said..."<br>`[336]` **Franc**: ""And my politics professors say ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Franc**: ""Just think about it. Please."" |
| `[152]` | **""I'd rather leave the country than admit defeat.""** | `[151]` **Franc**: ""Just think about it. Please."" | `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true` | *Brak zmian stanu* | `[156]` **Franc**: ""That's a little extreme. But su..." |
| `[157]` | **""I'll do better going forward. I won't let you down.""** | `[151]` **Franc**: ""Just think about it. Please."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Franc**: ""All right. Stay in denial."" |
| `[158]` | **""You've made your point. I will.""** | `[151]` **Franc**: ""Just think about it. Please."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Franc**: ""That's all I ask."" |
| `[162]` | **""Isn't it enough that your mother and I are divorced?""** | `[144]` **Franc**: ""Haven't you thought about just ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Franc**: ""I don't know! Who knows what th..." |
| `[163]` | **""I could go to Kyrute. It's the only truly neutral country on the continent.""** | `[144]` **Franc**: ""Haven't you thought about just ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Franc**: ""Yes! Why not?"" |
| `[167]` | **""All right, Franc. I will.""** | `[166]` **Franc**: ""Just think about it. I'm serious."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Franc**: ""Thanks, Dad. And thanks for din..." |
| `[168]` | **""You should go home, Franc.""** | `[166]` **Franc**: ""Just think about it. I'm serious."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Franc**: ""Yeah, I've got an exam tomorrow..." |
| `[169]` | **""Stay and have a beer with me?""** | `[166]` **Franc**: ""Just think about it. I'm serious."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Franc**: ""No, I've got an exam tomorrow. ..." |
| `[176]` | **""You should go home, Franc. It's late.""** | `[156]` **Franc**: ""That's a little extreme. But su..."<br>`[174]` **Franc**: ""All right. Stay in denial.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Franc**: ""Yeah, I've got an exam tomorrow..." |
| `[177]` | **""Stay and have a beer with me?""** | `[156]` **Franc**: ""That's a little extreme. But su..."<br>`[174]` **Franc**: ""All right. Stay in denial.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Franc**: ""No, I've got an exam tomorrow. ..." |
| `[182]` | **""What? Why?""** | `[181]` **Franc**: ""Dad, I can't keep coming over h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Franc**: ""Well..."" |
| `[183]` | **""Is it because of... how you got into Holsord State?""** | `[181]` **Franc**: ""Dad, I can't keep coming over h..." | `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false` | *Brak zmian stanu* | `[192]` **Franc**: ""Well, yeah."" |
| `[184]` | **""What has your mother been telling you about me?""** | `[181]` **Franc**: ""Dad, I can't keep coming over h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Narrator**: "Franc winced." |
| `[195]` | **""Would you rather have gone into the military?""** | `[194]` **Franc**: ""I worked so hard to prove I bel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[198]` **Franc**: ""Of course not."" |
| `[196]` | **""Cry me a river. Your problems are nothing compared to mine.""** | `[194]` **Franc**: ""I worked so hard to prove I bel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Franc**: ""That makes this easier."" |
| `[197]` | **""I'm sorry. I had no idea that would get leaked.""** | `[194]` **Franc**: ""I worked so hard to prove I bel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Franc**: ""I guess we both should have pre..." |
| `[205]` | **""All right. I understand.""** | `[204]` **Franc**: ""I need to show them I'm more th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Franc**: ""Thanks, Dad."" |
| `[206]` | **""Part of being your own man is not caring what other people think.""** | `[204]` **Franc**: ""I need to show them I'm more th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Franc**: ""You've got that luxury. I don't."" |
| `[207]` | **""Great. So my whole family won't see me now.""** | `[204]` **Franc**: ""I need to show them I'm more th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Narrator**: "Franc shifted nervously in his s..." |
| `[225]` | **""I didn't mean to hit her.""** | `[221]` **Franc**: ""But if it's anything like what ..." | `Variable["BaseGame.Relations_Monica_Slapped"] == true` | *Brak zmian stanu* | `[243]` **Franc**: ""It doesn't matter what you meant!"" |
| `[229]` | **""Curtan Leste made me do it.""** | `[221]` **Franc**: ""But if it's anything like what ..." | `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true` | *Brak zmian stanu* | `[238]` **Franc**: ""Come on, Dad. This was the one ..." |
| `[233]` | **""The Assembly members would've eaten her alive if I'd let her work with Ciara.""** | `[221]` **Franc**: ""But if it's anything like what ..." | `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == false`<br>`(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | *Brak zmian stanu* | `[238]` **Franc**: ""Come on, Dad. This was the one ..." |
| `[237]` | **""I had to veto that bill. There were bigger forces at work.""** | `[221]` **Franc**: ""But if it's anything like what ..." | `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Vetoed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Vetoed"] == true` | *Brak zmian stanu* | `[238]` **Franc**: ""Come on, Dad. This was the one ..." |
| `[241]` | **""Sordland is counting on me. I won't let the country down just because your classm..."** | `[151]` **Franc**: ""Just think about it. Please."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Franc**: ""This was never about Sordland! ..." |
| `[245]` | **""Franc, I know. I've been regretting it every day.""** | `[221]` **Franc**: ""But if it's anything like what ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Franc**: ""I don't know if that's enough."" |
| `[247]` | **""Great. So my whole family hates me now.""** | `[240]` **Franc**: ""It's wrong that you always trea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Franc**: ""I don't hate you. I just need s..." |
| `[248]` | **""You're too young to understand.""** | `[240]` **Franc**: ""It's wrong that you always trea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Franc**: ""That's bullshit. Listen, I just..." |
| `[249]` | **""Please, Franc. I've lost everyone else. I can't lose you too.""** | `[240]` **Franc**: ""It's wrong that you always trea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Franc**: ""You're not losing me. I just ne..." |
| `[260]` | **""You should go home, Franc. It's late.""** | `[212]` **Franc**: ""Well, Mom and Deana... you kind..."<br>`[244]` **Franc**: ""Well, the thing with Mom... you..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Franc**: ""Yeah, I've got an exam tomorrow..." |
| `[261]` | **""Stay and have a beer with me?""** | `[212]` **Franc**: ""Well, Mom and Deana... you kind..."<br>`[244]` **Franc**: ""Well, the thing with Mom... you..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[262]` **Franc**: ""No, I've got an exam tomorrow. ..." |
| `[276]` | **"Draft a speech announcing your retirement from politics."** | `[275]` **Narrator**: "Where would it end?" | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[282]` **Narrator**: "My entire life had built up to m..." |
| `[277]` | **"Go to bed."** | `[275]` **Narrator**: "Where would it end?" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[279]` | **"Think about leaving the country."** | `[275]` **Narrator**: "Where would it end?" | `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)` | *Brak zmian stanu* | `[281]` **Narrator**: "I could go to Kyrute. It was the..." |
| `[283]` | **"Leave now."** | `[281]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Exile_LeaveNow"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[285]` **Narrator**: "It was time for a fresh start." |
| `[284]` | **"Leave after covering up your tracks just in case."** | `[281]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[285]` **Narrator**: "It was time for a fresh start." |
| `[289]` | **"Write a letter to Monica."** | `[275]` **Narrator**: "Where would it end?" | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Reti...` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[290]` | **"Draft a speech announcing your retirement from politics."** | `[264]` **Narrator**: "After showing Franc to the door,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Narrator**: "My entire life had built up to t..." |
| `[297]` | **"Decide to ignore Franc's advice."** | `[264]` **Narrator**: "After showing Franc to the door,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "I went to bed, trying not to thi..." |
| `[299]` | **"Leave after covering up your tracks."** | `[298]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[292]` **Narrator**: "It was time for a fresh start." |
| `[300]` | **"Think about leaving the country."** | `[264]` **Narrator**: "After showing Franc to the door,..." | `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)` | *Brak zmian stanu* | `[298]` **Narrator**: "I could go to Kyrute. It was the..." |
| `[302]` | **"Leave now."** | `[298]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Exile_LeaveNow"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[292]` **Narrator**: "It was time for a fresh start." |
| `[304]` | **"Stay in Sordland and retire from politics."** | `[298]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Narrator**: "My entire life had built up to t..." |
| `[305]` | **"Stay in Sordland and continue in politics."** | `[298]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "I went to bed, trying not to thi..." |
| `[306]` | **"Leave now."** | `[307]` **Narrator**: "A little mountain house in the n..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Exile_LeaveNow"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[311]` **Narrator**: "It was time for a fresh start." |
| `[308]` | **"Take Franc's advice and leave the country."** | `[173]` **Narrator**: "After showing Franc to the door,..." | `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)` | *Brak zmian stanu* | `[307]` **Narrator**: "A little mountain house in the n..." |
| `[309]` | **"Ignore Franc's advice and stick with your plan to retire."** | `[173]` **Narrator**: "After showing Franc to the door,..." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[310]` **Narrator**: "I went to bed, trying not to thi..." |
| `[312]` | **"Leave after covering up your tracks just in case."** | `[307]` **Narrator**: "A little mountain house in the n..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[311]` **Narrator**: "It was time for a fresh start." |
| `[317]` | **"Stay in Sordland but end your political career."** | `[173]` **Narrator**: "After showing Franc to the door,..." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[319]` **Narrator**: "I went up to my office and began..." |
| `[318]` | **"Ignore Franc's advice and continue your political career."** | `[173]` **Narrator**: "After showing Franc to the door,..." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[310]` **Narrator**: "I went to bed, trying not to thi..." |
| `[328]` | **""Damn. I would've thought she'd be happy to vote for a woman.""** | `[49]` **Franc**: ""She won't tell me who she's vot..." | `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false` | *Brak zmian stanu* | `[89]` **Franc**: ""Who will you vote for, Dad? Now..."<br>`[329]` **Franc**: ""Who would you vote for? I mean,..."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[3]` (*Narrator: "I'd had the chef prepare barbecued ribs for the occasion...."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)

### Węzeł `[3]`
Mówca: **Narrator**
> "I'd had the chef prepare barbecued ribs for the occasion. I hoped they were still his favorite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Nearly half an hour after he said he'd be there, Franc bu..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Nearly half an hour after he said he'd be there, Franc burst through the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: ""You're late.""*)
  - -> `[6]` (*Player: ""Is everything all right?""*)

### Węzeł `[5]`
**[WYBÓR GRACZA: ""You're late.""]** — Mówca: **Player**
> ""You're late.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Franc: ""Yeah, I know. I'm sorry.""*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""Is everything all right?""]** — Mówca: **Player**
> ""Is everything all right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Franc: ""Yeah, yeah. I'm sorry.""*)

### Węzeł `[7]`
Mówca: **Franc**
> ""Yeah, I know. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[8]`
Mówca: **Franc**
> ""Yeah, yeah. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[9]`
Mówca: **Franc**
> ""Are some of those guards outside new? I had to convince them I was really your son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""They might be.""*)
  - -> `[15]` (*Player: ""I'm starting to get suspicious of them, to be honest.""*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Franc: ""I ran into a couple of my friends protesting outside you..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Franc: ""I was with Sheyna. We were, uh, studying.""*)

### Węzeł `[13]`
Mówca: **Franc**
> ""I ran into a couple of my friends protesting outside your gates. It was pretty awkward, telling them I was having dinner with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""You *know* those brats? I was going to ask the guards to..."*)
  - -> `[39]` (*Player: ""You could've invited them in. There's enough food.""*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""They might be.""]** — Mówca: **Player**
> ""They might be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Franc: ""Well, I'd be more suspicious of them if I were you.""*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I'm starting to get suspicious of them, to be honest.""]** — Mówca: **Player**
> ""I'm starting to get suspicious of them, to be honest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "He flung his backpack on the living room sofa and sprawle..."*)

### Węzeł `[16]`
Mówca: **Franc**
> ""Well, I'd be more suspicious of them if I were you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "He flung his backpack on the living room sofa and sprawle..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "He flung his backpack on the living room sofa and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Franc: ""Shit, Dad, that parade was a close call. I thought the b..."*)

### Węzeł `[18]`
Mówca: **Franc**
> ""Shit, Dad, that parade was a close call. I thought the ball was bad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[25]` (*Player: ""Language!""*)

### Węzeł `[19]`
Mówca: **Franc**
> ""Serge is dead, and your biggest concern is swear words?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Franc: ""Mom was inconsolable about it.""*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: ""It wasn't a 'close call' for Serge.""*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: ""I know. I still can't believe nobody was hurt.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""It wasn't a 'close call' for Serge.""]** — Mówca: **Player**
> ""It wasn't a 'close call' for Serge.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Kontekst wejściowy (poprzednik):** `[18]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Franc: ""I know. I can't believe he's gone.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""I know. I still can't believe nobody was hurt.""]** — Mówca: **Player**
> ""I know. I still can't believe nobody was hurt.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[18]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Franc: ""Mom would kill me for telling you this, but she was real..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Language!""]** — Mówca: **Player**
> ""Language!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Franc: ""Serge is dead, and your biggest concern is swear words?""*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Franc: ""You almost died *again*, and your biggest concern is swe..."*)

### Węzeł `[29]`
Mówca: **Franc**
> ""You almost died *again*, and your biggest concern is swear words?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Franc: ""Mom would kill me for telling you this, but she was real..."*)

### Węzeł `[30]`
Mówca: **Franc**
> ""Mom would kill me for telling you this, but she was really worried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: ""How is your mother, anyway?""*)
  - -> `[46]` (*Player: ""How is Deana?""*)

### Węzeł `[31]`
Mówca: **Franc**
> ""I know. I can't believe he's gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Franc: ""Mom was inconsolable about it.""*)

### Węzeł `[32]`
Mówca: **Franc**
> ""Mom was inconsolable about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: ""How is your mother, anyway?""*)
  - -> `[46]` (*Player: ""How is Deana?""*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""How is your mother, anyway?""]** — Mówca: **Player**
> ""How is your mother, anyway?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Franc), `[32]` (Franc), `[43]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "Franc shrugged uncomfortably."*)

### Węzeł `[34]`
Mówca: **Franc**
> ""I was with Sheyna. We were, uh, studying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "He flung his backpack on the living room sofa and sprawle..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "He flung his backpack on the living room sofa and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""I hope you two are being careful.""*)
  - -> `[37]` (*Player: ""So when's the wedding?""*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""I hope you two are being careful.""]** — Mówca: **Player**
> ""I hope you two are being careful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Franc rolled his eyes."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""So when's the wedding?""]** — Mówca: **Player**
> ""So when's the wedding?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Franc rolled his eyes."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""You *know* those brats? I was going to ask the guards to have them tear-gassed.""]** — Mówca: **Player**
> ""You *know* those brats? I was going to ask the guards to have them tear-gassed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Franc: ""Don't do it. They brought goggles.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""You could've invited them in. There's enough food.""]** — Mówca: **Player**
> ""You could've invited them in. There's enough food.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Franc: ""Ha. Even if they would cross the picket line, they're ve..."*)

### Węzeł `[40]`
Mówca: **Franc**
> ""Ha. Even if they would cross the picket line, they're vegetarians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "He flung his backpack on the living room sofa, sprawled o..."*)

### Węzeł `[41]`
Mówca: **Franc**
> ""Don't do it. They brought goggles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "He flung his backpack on the living room sofa, sprawled o..."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "He flung his backpack on the living room sofa, sprawled out in a chair and sniffed the air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Franc: ""Nice. Mom never makes ribs at her new place.""*)

### Węzeł `[43]`
Mówca: **Franc**
> ""Nice. Mom never makes ribs at her new place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: ""How is your mother, anyway?""*)
  - -> `[46]` (*Player: ""How is Deana?""*)

### Węzeł `[44]`
Mówca: **Narrator**
> "Franc rolled his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Franc: ""That's what Mom always says.""*)

### Węzeł `[45]`
Mówca: **Franc**
> ""That's what Mom always says.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: ""How is your mother, anyway?""*)
  - -> `[46]` (*Player: ""How is Deana?""*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""How is Deana?""]** — Mówca: **Player**
> ""How is Deana?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Franc), `[32]` (Franc), `[43]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[47]`
Mówca: **Narrator**
> "Franc shrugged uncomfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Franc: ""She's fine, I guess. She's spending a lot of time volunt..."*)

### Węzeł `[48]`
Mówca: **Franc**
> ""She's fine, I guess. She's spending a lot of time volunteering with the Sordish League of Women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)

### Węzeł `[49]`
Mówca: **Franc**
> ""She won't tell me who she's voting for, except that it sure as hell isn't Lileas Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false &..."*)
  - -> `[53]` (*Player: ""That's a relief.""*)
  - -> `[54]` (*Player: ""Who are you voting for? Now that you're old enough.""*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Franc: ""She won't tell me who she's voting for, except that it s..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Franc: ""She won't tell me who she's voting for, but I think she'..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""That's a relief.""]** — Mówca: **Player**
> ""That's a relief.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Who are you voting for? Now that you're old enough.""]** — Mówca: **Player**
> ""Who are you voting for? Now that you're old enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Franc), `[55]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[55]`
Mówca: **Franc**
> ""She won't tell me who she's voting for, but I think she's leaning PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: ""Who are you voting for? Now that you're old enough.""*)
  - -> `[56]` (*Player: ""That's not surprising.""*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""That's not surprising.""]** — Mówca: **Player**
> ""That's not surprising.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course it does. Every vote counts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Franc), `[84]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The oven timer went off. I took out the ribs and brought ..."*)

### Węzeł `[58]`
Mówca: **Franc**
> ""Jeez, Dad. Not everything is about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The oven timer went off. I took out the ribs and brought ..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_Personal_PetrFuneral == true"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_Personal_PetrFuneral == true"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_Personal_PetrFuneral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_Personal_PetrFuneral == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(GameCondition.Turn09_Personal_PetrFuneral == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_Personal_PetrFuneral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["GameCondition.Turn09_Personal_PetrFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Franc: ""I mean, I think between the divorce, Serge and Petr, she..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(GameCondition.Turn09_Personal_PetrFuneral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["GameCondition.Turn09_Personal_PetrFuneral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Franc: ""I mean, I think between the divorce and Serge, she's bee..."*)

### Węzeł `[65]`
Mówca: **Franc**
> ""I mean, I think between the divorce, Serge and Petr, she's been having a rough time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: ""And you haven't?""*)
  - -> `[73]` (*Player: ""And I haven't?""*)
  - -> `[75]` (*Player: ""What about your mother?""*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_Personal_PetrFuneral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_Personal_PetrFuneral == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(GameCondition.Turn09_Personal_PetrFuneral == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_Personal_PetrFuneral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["GameCondition.Turn09_Personal_PetrFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Franc: ""I mean, I think between the divorce and Petr, she's been..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(GameCondition.Turn09_Personal_PetrFuneral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["GameCondition.Turn09_Personal_PetrFuneral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Franc: ""I mean, I think she's been taking the divorce pretty hard.""*)

### Węzeł `[69]`
Mówca: **Franc**
> ""I mean, I think between the divorce and Petr, she's been having a rough time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: ""And you haven't?""*)
  - -> `[73]` (*Player: ""And I haven't?""*)
  - -> `[75]` (*Player: ""What about your mother?""*)

### Węzeł `[70]`
Mówca: **Franc**
> ""I mean, I think between the divorce and Serge, she's been having a rough time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: ""And you haven't?""*)
  - -> `[73]` (*Player: ""And I haven't?""*)
  - -> `[75]` (*Player: ""What about your mother?""*)

### Węzeł `[71]`
Mówca: **Franc**
> ""I mean, I think she's been taking the divorce pretty hard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: ""And you haven't?""*)
  - -> `[73]` (*Player: ""And I haven't?""*)
  - -> `[75]` (*Player: ""What about your mother?""*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""And you haven't?""]** — Mówca: **Player**
> ""And you haven't?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Franc), `[69]` (Franc), `[70]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Franc: ""It's different. I'm older.""*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""And I haven't?""]** — Mówca: **Player**
> ""And I haven't?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Franc), `[69]` (Franc), `[70]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Franc: ""Jeez, Dad. Not everything is about you.""*)

### Węzeł `[74]`
Mówca: **Franc**
> ""It's different. I'm older.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: ""Old enough to vote, even.""*)
  - -> `[120]` (*Player: ""Yes, I can see that.""*)

### Węzeł `[75]`
**[WYBÓR GRACZA: ""What about your mother?""]** — Mówca: **Player**
> ""What about your mother?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Franc), `[69]` (Franc), `[70]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "Franc shrugged uncomfortably."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Old enough to vote, even.""]** — Mówca: **Player**
> ""Old enough to vote, even.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Franc: ""Does it matter?""*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Franc: ""I'm voting for the candidate who...buys me a car?""*)

### Węzeł `[80]`
Mówca: **Franc**
> ""Does it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: ""Of course it does. Every vote counts.""*)
  - -> `[85]` (*Player: ""No, I suppose not.""*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Franc: ""Although it doesn't matter, does it?""*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Franc: ""Who would you vote for? I mean, if you weren't in the ru..."*)

### Węzeł `[84]`
Mówca: **Franc**
> ""Although it doesn't matter, does it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: ""Of course it does. Every vote counts.""*)
  - -> `[85]` (*Player: ""No, I suppose not.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, I suppose not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Franc), `[84]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The oven timer went off. I took out the ribs and brought ..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Franc: ""Who will you vote for, Dad? Now that you're out of the r..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)

### Węzeł `[89]`
Mówca: **Franc**
> ""Who will you vote for, Dad? Now that you're out of the running.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: ""I'd rather not say.""*)
  - -> `[91]` (*Player: ""Honestly, Lileas.""*)
  - -> `[92]` (*Player: ""Perhaps PFJP.""*)
  - -> `[93]` (*Player: ""Perhaps NFP.""*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'd rather not say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Franc), `[97]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Franc: ""Fair enough.""*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, Lileas.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.JoinParty_NFP"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Franc), `[97]` (Franc), `[329]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Franc raised his eyebrows."*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Perhaps PFJP.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.JoinParty_NFP"] == true`
- **Kontekst wejściowy (poprzednik):** `[89]` (Franc), `[97]` (Franc), `[329]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Franc raised his eyebrows."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Perhaps NFP.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.JoinParty_NFP"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Franc), `[97]` (Franc), `[329]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Franc raised his eyebrows."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Franc raised his eyebrows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Franc: ""Huh. Okay.""*)

### Węzeł `[95]`
Mówca: **Franc**
> ""Huh. Okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The oven timer went off. I took out the ribs and brought ..."*)

### Węzeł `[96]`
Mówca: **Franc**
> ""Fair enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The oven timer went off. I took out the ribs and brought ..."*)

### Węzeł `[97]`
Mówca: **Franc**
> ""Who would you vote for? I mean, if you weren't in the running.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: ""I'd rather not say.""*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_NFP == true"*)

### Węzeł `[98]`
Mówca: **Franc**
> ""I'm voting for the candidate who...buys me a car?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player: ""Nice try, but no.""*)
  - -> `[100]` (*Player: ""You want it, you got it.""*)

### Węzeł `[99]`
**[WYBÓR GRACZA: ""Nice try, but no.""]** — Mówca: **Player**
> ""Nice try, but no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The oven timer went off. I took out the ribs and brought ..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: ""You want it, you got it.""]** — Mówca: **Player**
> ""You want it, you got it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The oven timer went off. I took out the ribs and brought ..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Perhaps one of the small parties.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.JoinParty_NFP"] == true`
- **Kontekst wejściowy (poprzednik):** `[97]` (Franc), `[329]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Franc raised his eyebrows."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_NFP == true"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.JoinParty_NFP == true)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.JoinParty_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: ""Honestly, Lileas.""*)
  - -> `[92]` (*Player: ""Perhaps PFJP.""*)
  - -> `[101]` (*Player: ""Perhaps one of the small parties.""*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.JoinParty_NFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.JoinParty_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: ""Perhaps NFP.""*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_PFJP == true"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_PFJP == true"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.JoinParty_PFJP == true)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.JoinParty_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: ""Honestly, Lileas.""*)
  - -> `[101]` (*Player: ""Perhaps one of the small parties.""*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.JoinParty_PFJP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.JoinParty_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: ""Perhaps PFJP.""*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_CPS == true || BaseGame.JoinParty_WPB ..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_CPS == true || BaseGame.JoinParty_WPB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_CPS == true || BaseGame.JoinParty_WPB ..."*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.JoinParty_CPS == true || BaseGame.JoinParty_WP..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.JoinParty_CPS == true || BaseGame.JoinParty_WPB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.JoinParty_CPS"] == true  or  Variable["BaseGame.JoinParty_WPB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: ""Honestly, Lileas.""*)
  - -> `[93]` (*Player: ""Perhaps NFP.""*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.JoinParty_CPS == true || BaseGame.JoinParty_WPB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.JoinParty_CPS"] == true  or  Variable["BaseGame.JoinParty_WPB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: ""Perhaps one of the small parties.""*)

### Węzeł `[111]`
Mówca: **Narrator**
> "The oven timer went off. I took out the ribs and brought them to the dining room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "After we'd eaten, Franc kept toying with his fork. He loo..."*)

### Węzeł `[112]`
Mówca: **Narrator**
> "After we'd eaten, Franc kept toying with his fork. He looked preoccupied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: ""What is it?""*)
  - -> `[114]` (*Player: ""Was dinner all right?""*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""What is it?""]** — Mówca: **Player**
> ""What is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Franc looked down at the tablecloth."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Was dinner all right?""]** — Mówca: **Player**
> ""Was dinner all right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Franc: ""Yeah, it was great.""*)

### Węzeł `[115]`
Mówca: **Franc**
> ""Yeah, it was great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Franc looked down at the tablecloth."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "Franc looked down at the tablecloth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Franc: ""Dad, I think you should leave Sordland. It isn't safe he..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == false && (BaseGa..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""Yes, I can see that.""]** — Mówca: **Player**
> ""Yes, I can see that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The oven timer went off. I took out the ribs and brought ..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == false && (BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Public_Opinion < 0)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == false && (BaseGa..."*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == false && (Base..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == false && (BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Public_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == false  and  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Public_Opinion"] < 0)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Franc: ""Dad, have you thought about quitting politics? I don't j..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == false && (BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Public_Opinion < 0))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == false  and  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Public_Opinion"] < 0)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Franc: ""Dad, I can't keep coming over here.""*)

### Węzeł `[124]`
Mówca: **Franc**
> ""Dad, have you thought about quitting politics? I don't just mean dropping out of the race -- I mean retiring altogether.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: ""It's crossed my mind once or twice.""*)
  - -> `[129]` (*Player: ""Never.""*)
  - -> `[130]` (*Player: ""Are you insane, son?""*)

### Węzeł `[125]`
Mówca: **Franc**
> ""Dad, I think you should leave Sordland. It isn't safe here anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player: ""What gave you that idea? The bullets just barely whistli..."*)
  - -> `[127]` (*Player: ""That's ridiculous. I can take care of myself.""*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""What gave you that idea? The bullets just barely whistling past my skull?""]** — Mówca: **Player**
> ""What gave you that idea? The bullets just barely whistling past my skull?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Franc: ""That might have had something to do with it, yeah.""*)

### Węzeł `[127]`
**[WYBÓR GRACZA: ""That's ridiculous. I can take care of myself.""]** — Mówca: **Player**
> ""That's ridiculous. I can take care of myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Franc: ""I'm not talking about you.""*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""It's crossed my mind once or twice.""]** — Mówca: **Player**
> ""It's crossed my mind once or twice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Franc: ""It's just that... Deana told me she's getting bullied in..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Never.""]** — Mówca: **Player**
> ""Never.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Franc: ""It's just that... Deana told me she's getting bullied in..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""Are you insane, son?""]** — Mówca: **Player**
> ""Are you insane, son?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Franc: ""It's just that... Deana told me she's getting bullied in..."*)

### Węzeł `[131]`
Mówca: **Franc**
> ""It's just that... Deana told me she's getting bullied in school because of you. I've lost friends in the past months just for having the last name Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)

### Węzeł `[132]`
Mówca: **Franc**
> ""Everything was so much easier before this. I think you were happier, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)

### Węzeł `[133]`
Mówca: **Franc**
> ""I'm not talking about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Franc: ""There's no guarantee that the same people who want you d..."*)

### Węzeł `[134]`
Mówca: **Franc**
> ""There's no guarantee that the same people who want you dead won't also come after Monica and Deana. Or me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: ""You might be right.""*)
  - -> `[136]` (*Player: ""No. I'm the target.""*)
  - -> `[138]` (*Player: ""You're watching too many conspiracy thrillers.""*)

### Węzeł `[135]`
Mówca: **Franc**
> ""That might have had something to do with it, yeah.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Franc: ""There's no guarantee that the same people who want you d..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: ""No. I'm the target.""]** — Mówca: **Player**
> ""No. I'm the target.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""You might be right.""]** — Mówca: **Player**
> ""You might be right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""You're watching too many conspiracy thrillers.""]** — Mówca: **Player**
> ""You're watching too many conspiracy thrillers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Franc: ""They killed Serge, didn't they?""*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Franc: ""They almost killed Serge, didn't they?""*)

### Węzeł `[142]`
Mówca: **Franc**
> ""They killed Serge, didn't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Franc: ""Haven't you thought about just laying low for a while?""*)

### Węzeł `[143]`
Mówca: **Franc**
> ""They almost killed Serge, didn't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Franc: ""Haven't you thought about just laying low for a while?""*)

### Węzeł `[144]`
Mówca: **Franc**
> ""Haven't you thought about just laying low for a while?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[162]` (*Player: ""Isn't it enough that your mother and I are divorced?""*)
  - -> `[163]` (*Player: ""I could go to Kyrute. It's the only truly neutral countr..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I already said I'd retire. Isn't that enough?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[144]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Franc: ""I don't know! Who knows what these people want?""*)

### Węzeł `[146]`
Mówca: **Franc**
> ""And my politics professors said you don't have a chance of winning anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player: ""What? I'll show those eggheads!""*)
  - -> `[148]` (*Player: ""I can't give up now, Franc. You're too young to understa..."*)
  - -> `[149]` (*Player: ""I didn't know how hard it was for you kids. I'm sorry.""*)

### Węzeł `[147]`
**[WYBÓR GRACZA: ""What? I'll show those eggheads!""]** — Mówca: **Player**
> ""What? I'll show those eggheads!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Franc), `[336]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Franc: ""Just think about it. Please.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""I can't give up now, Franc. You're too young to understand.""]** — Mówca: **Player**
> ""I can't give up now, Franc. You're too young to understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Franc), `[336]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Franc: ""Trust me, I understand.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I didn't know how hard it was for you kids. I'm sorry.""]** — Mówca: **Player**
> ""I didn't know how hard it was for you kids. I'm sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Franc), `[336]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Franc: ""Just think about it. Please.""*)

### Węzeł `[150]`
Mówca: **Franc**
> ""Trust me, I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Franc: ""Just think about it. Please.""*)

### Węzeł `[151]`
Mówca: **Franc**
> ""Just think about it. Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player: ""You've made your point. I will.""*)
  - -> `[157]` (*Player: ""I'll do better going forward. I won't let you down.""*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame..."*)
  - -> `[241]` (*Player: ""Sordland is counting on me. I won't let the country down..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""I'd rather leave the country than admit defeat.""]** — Mówca: **Player**
> ""I'd rather leave the country than admit defeat.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Kontekst wejściowy (poprzednik):** `[151]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Franc: ""That's a little extreme. But sure, it might not hurt to ..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame..."*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGa..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: ""I'd rather leave the country than admit defeat.""*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[156]`
Mówca: **Franc**
> ""That's a little extreme. But sure, it might not hurt to lay low for a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: ""You should go home, Franc. It's late.""*)
  - -> `[177]` (*Player: ""Stay and have a beer with me?""*)

### Węzeł `[157]`
**[WYBÓR GRACZA: ""I'll do better going forward. I won't let you down.""]** — Mówca: **Player**
> ""I'll do better going forward. I won't let you down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Franc: ""All right. Stay in denial.""*)

### Węzeł `[158]`
**[WYBÓR GRACZA: ""You've made your point. I will.""]** — Mówca: **Player**
> ""You've made your point. I will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Franc: ""That's all I ask.""*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player: ""I already said I'd retire. Isn't that enough?""*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Isn't it enough that your mother and I are divorced?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Franc: ""I don't know! Who knows what these people want?""*)

### Węzeł `[163]`
**[WYBÓR GRACZA: ""I could go to Kyrute. It's the only truly neutral country on the continent.""]** — Mówca: **Player**
> ""I could go to Kyrute. It's the only truly neutral country on the continent.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Franc: ""Yes! Why not?""*)

### Węzeł `[164]`
Mówca: **Franc**
> ""I don't know! Who knows what these people want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Franc: ""Just think about it. I'm serious.""*)

### Węzeł `[165]`
Mówca: **Franc**
> ""Yes! Why not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Franc: ""Just think about it. I'm serious.""*)

### Węzeł `[166]`
Mówca: **Franc**
> ""Just think about it. I'm serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player: ""All right, Franc. I will.""*)
  - -> `[168]` (*Player: ""You should go home, Franc.""*)
  - -> `[169]` (*Player: ""Stay and have a beer with me?""*)

### Węzeł `[167]`
**[WYBÓR GRACZA: ""All right, Franc. I will.""]** — Mówca: **Player**
> ""All right, Franc. I will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Franc: ""Thanks, Dad. And thanks for dinner.""*)

### Węzeł `[168]`
**[WYBÓR GRACZA: ""You should go home, Franc.""]** — Mówca: **Player**
> ""You should go home, Franc.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Franc: ""Yeah, I've got an exam tomorrow anyway. Thanks for dinne..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""Stay and have a beer with me?""]** — Mówca: **Player**
> ""Stay and have a beer with me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Franc: ""No, I've got an exam tomorrow. Thanks for dinner, Dad.""*)

### Węzeł `[170]`
Mówca: **Franc**
> ""No, I've got an exam tomorrow. Thanks for dinner, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "After showing Franc to the door, I sat and thought for a ..."*)

### Węzeł `[171]`
Mówca: **Franc**
> ""Yeah, I've got an exam tomorrow anyway. Thanks for dinner, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "After showing Franc to the door, I sat and thought for a ..."*)

### Węzeł `[172]`
Mówca: **Franc**
> ""Thanks, Dad. And thanks for dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "After showing Franc to the door, I sat and thought for a ..."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "After showing Franc to the door, I sat and thought for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[174]`
Mówca: **Franc**
> ""All right. Stay in denial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: ""You should go home, Franc. It's late.""*)
  - -> `[177]` (*Player: ""Stay and have a beer with me?""*)

### Węzeł `[175]`
Mówca: **Franc**
> ""That's all I ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: ""You should go home, Franc. It's late.""*)
  - -> `[177]` (*Player: ""Stay and have a beer with me?""*)

### Węzeł `[176]`
**[WYBÓR GRACZA: ""You should go home, Franc. It's late.""]** — Mówca: **Player**
> ""You should go home, Franc. It's late.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Franc), `[174]` (Franc), `[175]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Franc: ""Yeah, I've got an exam tomorrow anyway. Thanks for dinne..."*)

### Węzeł `[177]`
**[WYBÓR GRACZA: ""Stay and have a beer with me?""]** — Mówca: **Player**
> ""Stay and have a beer with me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Franc), `[174]` (Franc), `[175]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Franc: ""No, I've got an exam tomorrow. Thanks for dinner, Dad.""*)

### Węzeł `[178]`
Mówca: **Franc**
> ""Yeah, I've got an exam tomorrow anyway. Thanks for dinner, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Franc: ""And seriously, think about it.""*)

### Węzeł `[179]`
Mówca: **Franc**
> ""No, I've got an exam tomorrow. Thanks for dinner, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Franc: ""And seriously, think about it.""*)

### Węzeł `[180]`
Mówca: **Franc**
> ""And seriously, think about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "After showing Franc to the door, I sat and thought for a ..."*)

### Węzeł `[181]`
Mówca: **Franc**
> ""Dad, I can't keep coming over here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: ""What? Why?""*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)
  - -> `[184]` (*Player: ""What has your mother been telling you about me?""*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""What? Why?""]** — Mówca: **Player**
> ""What? Why?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Franc: ""Well...""*)

### Węzeł `[183]`
**[WYBÓR GRACZA: ""Is it because of... how you got into Holsord State?""]** — Mówca: **Player**
> ""Is it because of... how you got into Holsord State?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Kontekst wejściowy (poprzednik):** `[181]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Franc: ""Well, yeah.""*)

### Węzeł `[184]`
**[WYBÓR GRACZA: ""What has your mother been telling you about me?""]** — Mówca: **Player**
> ""What has your mother been telling you about me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "Franc winced."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true &&..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player: ""Is it because of... how you got into Holsord State?""*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true &&..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Franc: ""Not to mention the way everyone's been treating me since..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Franc: ""Everything was so much easier before this. I think you w..."*)

### Węzeł `[191]`
Mówca: **Franc**
> ""Not to mention the way everyone's been treating me since they found out how I really got into Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Franc: ""Everything was so much easier before this. I think you w..."*)

### Węzeł `[192]`
Mówca: **Franc**
> ""Well, yeah.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Franc: ""I've been the laughing stock of the school since the new..."*)

### Węzeł `[193]`
Mówca: **Franc**
> ""I've been the laughing stock of the school since the news came out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Franc: ""I worked so hard to prove I belonged there. I was actual..."*)

### Węzeł `[194]`
Mówca: **Franc**
> ""I worked so hard to prove I belonged there. I was actually getting good grades for the first time in my life! But now everyone thinks I'm just a daddy's boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player: ""Would you rather have gone into the military?""*)
  - -> `[196]` (*Player: ""Cry me a river. Your problems are nothing compared to mi..."*)
  - -> `[197]` (*Player: ""I'm sorry. I had no idea that would get leaked.""*)

### Węzeł `[195]`
**[WYBÓR GRACZA: ""Would you rather have gone into the military?""]** — Mówca: **Player**
> ""Would you rather have gone into the military?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Franc: ""Of course not.""*)

### Węzeł `[196]`
**[WYBÓR GRACZA: ""Cry me a river. Your problems are nothing compared to mine.""]** — Mówca: **Player**
> ""Cry me a river. Your problems are nothing compared to mine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Franc: ""That makes this easier.""*)

### Węzeł `[197]`
**[WYBÓR GRACZA: ""I'm sorry. I had no idea that would get leaked.""]** — Mówca: **Player**
> ""I'm sorry. I had no idea that would get leaked.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Franc: ""I guess we both should have prepared for something like ..."*)

### Węzeł `[198]`
Mówca: **Franc**
> ""Of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Franc: ""But I think I need to distance myself from you for a whi..."*)

### Węzeł `[199]`
Mówca: **Franc**
> ""That makes this easier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Franc: ""I need to distance myself from you for a while. Until af..."*)

### Węzeł `[200]`
Mówca: **Franc**
> ""I guess we both should have prepared for something like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Franc: ""In any case, I think I need to distance myself from you ..."*)

### Węzeł `[201]`
Mówca: **Franc**
> ""But I think I need to distance myself from you for a while. Until after the election, at least. Maybe longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Franc: ""I need to show them I'm more than just Anton Rayne's son..."*)

### Węzeł `[202]`
Mówca: **Franc**
> ""In any case, I think I need to distance myself from you for a while. Until after the election, at least. Maybe longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Franc: ""I need to show them I'm more than just Anton Rayne's son..."*)

### Węzeł `[203]`
Mówca: **Franc**
> ""I need to distance myself from you for a while. Until after the election, at least. Maybe longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Franc: ""I need to show them I'm more than just Anton Rayne's son..."*)

### Węzeł `[204]`
Mówca: **Franc**
> ""I need to show them I'm more than just Anton Rayne's son. And the more contact I have with you, the harder that will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player: ""All right. I understand.""*)
  - -> `[206]` (*Player: ""Part of being your own man is not caring what other peop..."*)
  - -> `[207]` (*Player: ""Great. So my whole family won't see me now.""*)

### Węzeł `[205]`
**[WYBÓR GRACZA: ""All right. I understand.""]** — Mówca: **Player**
> ""All right. I understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Franc: ""Thanks, Dad.""*)

### Węzeł `[206]`
**[WYBÓR GRACZA: ""Part of being your own man is not caring what other people think.""]** — Mówca: **Player**
> ""Part of being your own man is not caring what other people think.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Franc: ""You've got that luxury. I don't.""*)

### Węzeł `[207]`
**[WYBÓR GRACZA: ""Great. So my whole family won't see me now.""]** — Mówca: **Player**
> ""Great. So my whole family won't see me now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Franc shifted nervously in his seat."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "Franc shifted nervously in his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Slapped == true"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Slapped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Slapped == true"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Slapped == true)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Slapped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Slapped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Franc: ""Well, Mom and Deana... you kind of brought that on yours..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Slapped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Franc: ""Well, the thing with Mom... you kind of brought that on ..."*)

### Węzeł `[212]`
Mówca: **Franc**
> ""Well, Mom and Deana... you kind of brought that on yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player: ""You should go home, Franc. It's late.""*)
  - -> `[261]` (*Player: ""Stay and have a beer with me?""*)

### Węzeł `[213]`
Mówca: **Franc**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true &&..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Franc: ""I've been the laughing stock of Holsord State since the ..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_SordlandToday_Bias == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Franc: ""I've been talking to Mom. About why she left.""*)

### Węzeł `[217]`
Mówca: **Franc**
> ""I've been talking to Mom. About why she left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Franc: ""Look, I don't know the full story.""*)

### Węzeł `[218]`
Mówca: **Franc**
> ""I've been the laughing stock of Holsord State since the news came out about how I got in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Franc: ""I worked so hard to prove I belonged there. I was actual..."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "Franc winced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Franc: ""Look, I don't know the full story.""*)

### Węzeł `[220]`
Mówca: **Franc**
> ""Look, I don't know the full story.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Franc: ""But if it's anything like what she said, it was bad.""*)

### Węzeł `[221]`
Mówca: **Franc**
> ""But if it's anything like what she said, it was bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Slapped == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Vetoed == true ||..."*)
  - -> `[245]` (*Player: ""Franc, I know. I've been regretting it every day.""*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Slapped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Slapped == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Slapped == true)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Slapped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Slapped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player: ""I didn't mean to hit her.""*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Slapped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[225]`
**[WYBÓR GRACZA: ""I didn't mean to hit her.""]** — Mówca: **Player**
> ""I didn't mean to hit her.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Monica_Slapped"] == true`
- **Kontekst wejściowy (poprzednik):** `[221]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Franc: ""It doesn't matter what you meant!""*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Monica_Barred == true)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player: ""Curtan Leste made me do it.""*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Monica_Barred == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA: ""Curtan Leste made me do it.""]** — Mówca: **Player**
> ""Curtan Leste made me do it.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Kontekst wejściowy (poprzednik):** `[221]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Franc: ""Come on, Dad. This was the one thing she wanted out of y..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player: ""The Assembly members would've eaten her alive if I'd let..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[233]`
**[WYBÓR GRACZA: ""The Assembly members would've eaten her alive if I'd let her work with Ciara.""]** — Mówca: **Player**
> ""The Assembly members would've eaten her alive if I'd let her work with Ciara.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == false` AND `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[221]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Franc: ""Come on, Dad. This was the one thing she wanted out of y..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Vetoed == true || BaseGame.Bill_Turn09_WeakWomensRights_Vetoed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_StrongWomensRights_Vetoed == true ||..."*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_StrongWomensRights_Vetoed == true ..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_StrongWomensRights_Vetoed == true || BaseGame.Bill_Turn09_WeakWomensRights_Vetoed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Vetoed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Vetoed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Player: ""I had to veto that bill. There were bigger forces at work.""*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_StrongWomensRights_Vetoed == true || BaseGame.Bill_Turn09_WeakWomensRights_Vetoed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_StrongWomensRights_Vetoed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Vetoed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[237]`
**[WYBÓR GRACZA: ""I had to veto that bill. There were bigger forces at work.""]** — Mówca: **Player**
> ""I had to veto that bill. There were bigger forces at work.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Bill_Turn09_StrongWomensRights_Vetoed"] == true  or  Variable["BaseGame.Bill_Turn09_WeakWomensRights_Vetoed"] == true`
- **Kontekst wejściowy (poprzednik):** `[221]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Franc: ""Come on, Dad. This was the one thing she wanted out of y..."*)

### Węzeł `[238]`
Mówca: **Franc**
> ""Come on, Dad. This was the one thing she wanted out of your presidency, and you took it away from her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Franc: ""I've been learning a lot about women's rights at univers..."*)

### Węzeł `[239]`
Mówca: **Franc**
> ""I've been learning a lot about women's rights at university. I mean, I'm not one of those crazy 'male feminists', but I can sympathize.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Franc: ""It's wrong that you always treated me so well while putt..."*)

### Węzeł `[240]`
Mówca: **Franc**
> ""It's wrong that you always treated me so well while putting her down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player: ""Great. So my whole family hates me now.""*)
  - -> `[248]` (*Player: ""You're too young to understand.""*)
  - -> `[249]` (*Player: ""Please, Franc. I've lost everyone else. I can't lose you..."*)

### Węzeł `[241]`
**[WYBÓR GRACZA: ""Sordland is counting on me. I won't let the country down just because your classmates are calling you names.""]** — Mówca: **Player**
> ""Sordland is counting on me. I won't let the country down just because your classmates are calling you names.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Franc: ""This was never about Sordland! It was only ever about yo..."*)

### Węzeł `[242]`
Mówca: **Franc**
> ""This was never about Sordland! It was only ever about you! God, Dad, can't you see that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: ""You should go home, Franc. It's late.""*)
  - -> `[177]` (*Player: ""Stay and have a beer with me?""*)

### Węzeł `[243]`
Mówca: **Franc**
> ""It doesn't matter what you meant!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Franc: ""I've been learning a lot about women's rights at univers..."*)

### Węzeł `[244]`
Mówca: **Franc**
> ""Well, the thing with Mom... you kind of brought that on yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player: ""You should go home, Franc. It's late.""*)
  - -> `[261]` (*Player: ""Stay and have a beer with me?""*)

### Węzeł `[245]`
**[WYBÓR GRACZA: ""Franc, I know. I've been regretting it every day.""]** — Mówca: **Player**
> ""Franc, I know. I've been regretting it every day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Franc: ""I don't know if that's enough.""*)

### Węzeł `[246]`
Mówca: **Franc**
> ""I don't know if that's enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Franc: ""I've been learning a lot about women's rights at univers..."*)

### Węzeł `[247]`
**[WYBÓR GRACZA: ""Great. So my whole family hates me now.""]** — Mówca: **Player**
> ""Great. So my whole family hates me now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Franc: ""I don't hate you. I just need some space.""*)

### Węzeł `[248]`
**[WYBÓR GRACZA: ""You're too young to understand.""]** — Mówca: **Player**
> ""You're too young to understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Franc: ""That's bullshit. Listen, I just need some space.""*)

### Węzeł `[249]`
**[WYBÓR GRACZA: ""Please, Franc. I've lost everyone else. I can't lose you too.""]** — Mówca: **Player**
> ""Please, Franc. I've lost everyone else. I can't lose you too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Franc: ""You're not losing me. I just need some space.""*)

### Węzeł `[250]`
Mówca: **Franc**
> ""I don't hate you. I just need some space.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player: ""You should go home, Franc. It's late.""*)
  - -> `[261]` (*Player: ""Stay and have a beer with me?""*)

### Węzeł `[251]`
Mówca: **Franc**
> ""That's bullshit. Listen, I just need some space.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player: ""You should go home, Franc. It's late.""*)
  - -> `[261]` (*Player: ""Stay and have a beer with me?""*)

### Węzeł `[252]`
Mówca: **Franc**
> ""You're not losing me. I just need some space.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player: ""You should go home, Franc. It's late.""*)
  - -> `[261]` (*Player: ""Stay and have a beer with me?""*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Franc: ""Good luck with retirement.""*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Franc: ""Good luck with the campaign.""*)

### Węzeł `[256]`
Mówca: **Franc**
> ""Thanks, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player: ""You should go home, Franc. It's late.""*)
  - -> `[261]` (*Player: ""Stay and have a beer with me?""*)

### Węzeł `[257]`
Mówca: **Franc**
> ""You've got that luxury. I don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player: ""You should go home, Franc. It's late.""*)
  - -> `[261]` (*Player: ""Stay and have a beer with me?""*)

### Węzeł `[258]`
Mówca: **Franc**
> ""Good luck with the campaign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "After showing Franc to the door, I sat and thought for a ..."*)

### Węzeł `[259]`
Mówca: **Franc**
> ""Good luck with retirement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "After showing Franc to the door, I sat and thought for a ..."*)

### Węzeł `[260]`
**[WYBÓR GRACZA: ""You should go home, Franc. It's late.""]** — Mówca: **Player**
> ""You should go home, Franc. It's late.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Franc), `[244]` (Franc), `[250]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Franc: ""Yeah, I've got an exam tomorrow anyway. Thanks for dinne..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA: ""Stay and have a beer with me?""]** — Mówca: **Player**
> ""Stay and have a beer with me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Franc), `[244]` (Franc), `[250]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Franc: ""No, I've got an exam tomorrow. Thanks for dinner, Dad.""*)

### Węzeł `[262]`
Mówca: **Franc**
> ""No, I've got an exam tomorrow. Thanks for dinner, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[263]`
Mówca: **Franc**
> ""Yeah, I've got an exam tomorrow anyway. Thanks for dinner, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[264]`
Mówca: **Narrator**
> "After showing Franc to the door, I sat and thought for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player_Italic: "Draft a speech announcing your retirement from politics."*)
  - -> `[297]` (*Player_Italic: "Decide to ignore Franc's advice."*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)

### Węzeł `[265]`
Mówca: **Narrator**
> "After showing Franc to the door, I sat and thought for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "My political career had taken so much away from me. My wi..."*)

### Węzeł `[266]`
Mówca: **Narrator**
> "My political career had taken so much away from me. My wife and daughter, and now my son..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == false &&(Base..."*)

### Węzeł `[267]`
Mówca: **Narrator**
> "And poor Serge..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "Where would it end?"*)

### Węzeł `[268]`
Mówca: **Narrator**
> "Petr..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "And poor Serge..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "Where would it end?"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == false &&(BaseGame.Decision_Turn08_VPSelection_Albin == true || BaseGame.Decision_Turn08_VPSelection_Gloria == true || BaseGame.Decision_Turn08_VPSelection_Lucian == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == false &&(Base..."*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_ShareBlame == false &&(Ba..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == false &&(BaseGame.Decision_Turn08_VPSelection_Albin == true || BaseGame.Decision_Turn08_VPSelection_Gloria == true || BaseGame.Decision_Turn08_VPSelection_Lucian == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == false  and (Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true  or  Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true  or  Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "Petr..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_ShareBlame == false &&(BaseGame.Decision_Turn08_VPSelection_Albin == true || BaseGame.Decision_Turn08_VPSelection_Gloria == true || BaseGame.Decision_Turn08_VPSelection_Lucian == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == false  and (Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true  or  Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true  or  Variable["BaseGame.Decision_Turn08_VPSelection_Lucian"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[275]`
Mówca: **Narrator**
> "Where would it end?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[277]` (*Player_Italic: "Go to bed."*)
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)

### Węzeł `[276]`
**[WYBÓR GRACZA: "Draft a speech announcing your retirement from politics."]** — Mówca: **Player_Italic**
> "I went up to my office and began drafting a speech announcing my decision to retire."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[275]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "My entire life had built up to my presidency. Now, I coul..."*)

### Węzeł `[277]`
**[WYBÓR GRACZA: "Go to bed."]** — Mówca: **Player_Italic**
> "I went to bed, trying not to think about my personal relationships. I had far too many other things on my plate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[275]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FinalSupper_Retired = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true"*)

### Węzeł `[279]`
**[WYBÓR GRACZA: "Think about leaving the country."]** — Mówca: **Player_Italic**
> "I went up to my office and spun the globe on my desk."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Kontekst wejściowy (poprzednik):** `[275]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "I could go to Kyrute. It was the one completely neutral c..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[281]`
Mówca: **Narrator**
> "I could go to Kyrute. It was the one completely neutral country I knew of, and a little house in the mountains wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player_Italic: "Leave now."*)
  - -> `[284]` (*Player_Italic: "Leave after covering up your tracks just in case."*)

### Węzeł `[282]`
Mówca: **Narrator**
> "My entire life had built up to my presidency. Now, I couldn't wait for it to be over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[283]`
**[WYBÓR GRACZA: "Leave now."]** — Mówca: **Player_Italic**
> "I started packing my suitcase. I wasn't going to stay in Sordland a second longer."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[284]`
**[WYBÓR GRACZA: "Leave after covering up your tracks just in case."]** — Mówca: **Player_Italic**
> "I decided to cover up my tracks just in case. There were some documents that needed to be incinerated."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[285]`
Mówca: **Narrator**
> "It was time for a fresh start."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Player_Italic: "Write a letter to Monica."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Player_Italic: "Draft a speech announcing your retirement from politics."*)

### Węzeł `[289]`
**[WYBÓR GRACZA: "Write a letter to Monica."]** — Mówca: **Player_Italic**
> "I went up to my office and began writing a letter to my ex-wife. Maybe after my retirement, we'd finally be able to work things out."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[275]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[290]`
**[WYBÓR GRACZA: "Draft a speech announcing your retirement from politics."]** — Mówca: **Player_Italic**
> "I went up to my office and began drafting a speech announcing my retirement from politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "My entire life had built up to this presidency. Now, I co..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FinalSupper_Retired = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[292]`
Mówca: **Narrator**
> "It was time for a fresh start."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Player_Italic: "Think about leaving the country."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[297]`
**[WYBÓR GRACZA: "Decide to ignore Franc's advice."]** — Mówca: **Player_Italic**
> "I wasn't going to take my son's advice. He was just a kid. What did he know?"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "I went to bed, trying not to think about what the next we..."*)

### Węzeł `[298]`
Mówca: **Narrator**
> "I could go to Kyrute. It was the one completely neutral country I knew of, and a little house in the mountains wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player_Italic: "Leave now."*)
  - -> `[299]` (*Player_Italic: "Leave after covering up your tracks."*)
  - -> `[304]` (*Player_Italic: "Stay in Sordland and retire from politics."*)
  - -> `[305]` (*Player_Italic: "Stay in Sordland and continue in politics."*)

### Węzeł `[299]`
**[WYBÓR GRACZA: "Leave after covering up your tracks."]** — Mówca: **Player_Italic**
> "I decided to cover up my tracks. There were some documents that needed to be incinerated."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[300]`
**[WYBÓR GRACZA: "Think about leaving the country."]** — Mówca: **Player_Italic**
> "I went up to my office and spun the globe on my desk."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Kontekst wejściowy (poprzednik):** `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "I could go to Kyrute. It was the one completely neutral c..."*)

### Węzeł `[301]`
Mówca: **Narrator**
> "My entire life had built up to this presidency. Now, I couldn't wait for it to be over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true"*)

### Węzeł `[302]`
**[WYBÓR GRACZA: "Leave now."]** — Mówca: **Player_Italic**
> "I started packing my suitcase. I wasn't going to stay in Sordland a second longer."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[303]`
Mówca: **Narrator**
> "I went to bed, trying not to think about what the next weeks would bring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[304]`
**[WYBÓR GRACZA: "Stay in Sordland and retire from politics."]** — Mówca: **Player_Italic**
> "I sat down and began drafting a speech announcing my decision to retire from politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "My entire life had built up to this presidency. Now, I co..."*)

### Węzeł `[305]`
**[WYBÓR GRACZA: "Stay in Sordland and continue in politics."]** — Mówca: **Player_Italic**
> "I shook my head. What did Franc know? He was just a kid."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "I went to bed, trying not to think about what the next we..."*)

### Węzeł `[306]`
**[WYBÓR GRACZA: "Leave now."]** — Mówca: **Player_Italic**
> "I started packing my suitcase. I wasn't going to stay in Sordland a second longer."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[307]`
Mówca: **Narrator**
> "A little mountain house in the neutral country of Kyrute wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Player_Italic: "Leave now."*)
  - -> `[312]` (*Player_Italic: "Leave after covering up your tracks just in case."*)

### Węzeł `[308]`
**[WYBÓR GRACZA: "Take Franc's advice and leave the country."]** — Mówca: **Player_Italic**
> "My son was right. Leaving Sordland was the safest thing I could do for myself and my family."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Kontekst wejściowy (poprzednik):** `[173]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "A little mountain house in the neutral country of Kyrute ..."*)

### Węzeł `[309]`
**[WYBÓR GRACZA: "Ignore Franc's advice and stick with your plan to retire."]** — Mówca: **Player_Italic**
> "I wasn't going to take my son's advice. He was just a kid. What did he know?"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[173]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "I went to bed, trying not to think about what the next we..."*)

### Węzeł `[310]`
Mówca: **Narrator**
> "I went to bed, trying not to think about what the next weeks would bring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[311]`
Mówca: **Narrator**
> "It was time for a fresh start."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[312]`
**[WYBÓR GRACZA: "Leave after covering up your tracks just in case."]** — Mówca: **Player_Italic**
> "I decided to cover up my tracks just in case. There were some documents that needed to be incinerated."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player_Italic: "Ignore Franc's advice and stick with your plan to retire."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Player_Italic: "Stay in Sordland but end your political career."*)
  - -> `[318]` (*Player_Italic: "Ignore Franc's advice and continue your political career."*)

### Węzeł `[317]`
**[WYBÓR GRACZA: "Stay in Sordland but end your political career."]** — Mówca: **Player_Italic**
> "Franc was right -- it was too dangerous to stay in politics. But I wasn't about to leave the country over it."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[173]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "I went up to my office and began drafting a speech announ..."*)

### Węzeł `[318]`
**[WYBÓR GRACZA: "Ignore Franc's advice and continue your political career."]** — Mówca: **Player_Italic**
> "I wasn't going to take my son's advice. He was just a kid. What did he know?"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[173]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "I went to bed, trying not to think about what the next we..."*)

### Węzeł `[319]`
Mówca: **Narrator**
> "I went up to my office and began drafting a speech announcing my retirement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "My entire life had built up to this presidency. Now, I co..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Franc: ""Are some of those guards outside new? I had to convince ..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Exile = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Exile = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_JoinedOtherParty == false && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_JoinedOtherParty == false &..."*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_JoinedOtherParty == false && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Player: ""Damn. I would've thought she'd be happy to vote for a wo..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_JoinedOtherParty == false && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[328]`
**[WYBÓR GRACZA: ""Damn. I would've thought she'd be happy to vote for a woman.""]** — Mówca: **Player**
> ""Damn. I would've thought she'd be happy to vote for a woman.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_JoinedOtherParty"] == false  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Kontekst wejściowy (poprzednik):** `[49]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[329]`
Mówca: **Franc**
> ""Who would you vote for? I mean, besides the folks you're backing now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.JoinParty_NFP == true"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame...."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Franc: ""Who would you vote for? I mean, besides the folks you're..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Franc: ""Who would you vote for? I mean, if you weren't in the ru..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame...."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Franc: ""And my politics professors say your campaigning might ac..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Franc: ""And my politics professors said you don't have a chance ..."*)

### Węzeł `[336]`
Mówca: **Franc**
> ""And my politics professors say your campaigning might actually hurt the candidate you're backing now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player: ""What? I'll show those eggheads!""*)
  - -> `[148]` (*Player: ""I can't give up now, Franc. You're too young to understa..."*)
  - -> `[149]` (*Player: ""I didn't know how hard it was for you kids. I'm sorry.""*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "It was time for a fresh start."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "It was time for a fresh start."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "It was time for a fresh start."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "It was time for a fresh start."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "It was time for a fresh start."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "It was time for a fresh start."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player_Italic: "Take Franc's advice and leave the country."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player_Italic: "Think about leaving the country."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
