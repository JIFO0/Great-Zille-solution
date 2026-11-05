# Sordland/Turn07/Personal_UniversityChoice

- **ID konwersacji:** `98`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/098_Personal_UniversityChoice.md`
- **Liczba węzłów dialogowych:** 371
- **Liczba wyborów gracza:** 73

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[31]** Franc

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Malenyevist`
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Military_CompulsoryMilitaryService`
- `BaseGame.Prologue_Studyplace_Holsord_Law`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Turn04_PSnW_Education_Privatization`
- `BaseGame.Turn05_Admin_Monica_Barred`
- `BaseGame.Turn06_PSnW_Education_ImproveRural`
- `BaseGame.Turn06_PSnW_Education_Salary`
- `BaseGame.Turn06_PSnW_Education_Schools`
- `BaseGame.Turn06_P_SupportedMonicaAtConfrontation`
- `BaseGame.Turn07_Personal_FrancMilitarySchool`
- `BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia`
- `BaseGameIsolated.Turn07_P_Franc_DiscussedContana`
- `BaseGameIsolated.Turn07_P_Franc_Reconsidered`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.PersonalWealth`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Turn07_Personal_FrancConscripted`
- `BaseGame.Turn07_Personal_FrancMilitarySchool`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn07_Personal_University_Home_Public`
- `BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia`
- `BaseGameIsolated.Turn07_P_Franc_DiscussedContana`
- `BaseGameIsolated.Turn07_P_Franc_Reconsidered`
- `BaseGameSupport.FactionReport_Turn07_ATO_CondemsDrugTraffic`
- `BaseGameSupport.Journal_Turn07_University_Arcasia`
- `BaseGameSupport.Journal_Turn07_University_Conscription`
- `BaseGameSupport.Journal_Turn07_University_HolsordState`
- `BaseGameSupport.Journal_Turn07_University_MilitarySchool`
- `BaseGameSupport.Journal_Turn07_University_UnitedContana`
- `BaseGameSupport.News_Turn07_HP_ErsenResult`
- `BaseGameSupport.News_Turn07_LT_AschrafUpcoming`
- `BaseGameSupport.News_Turn07_LT_BludishProtests`
- `BaseGameSupport.News_Turn07_R_EducationPrivatised`
- `BaseGameSupport.News_Turn07_R_ErsenResult`
- `BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ReligiousBillSigned`
- `BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ReligiousBillVetoed`
- `BaseGameSupport.Report_Turn07_Holsord_KibenerShowSupportEmergency`
- `BaseGameSupport.Report_Turn07_Narbel_NewSchoolBuilt`
- `BaseGameSupport.Report_Turn07_Ribel_EducationQualityIncreased`
- `BaseGameSupport.Report_Turn07_Vesord_EducationSalariesIncreased`
- `GameCondition.Turn07_Personal_FrancUniversityChoice`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Darling, what's wrong?""** | `[76]` **Narrator**: "I entered to find Monica sitting..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "Monica briefly rested her head o..."<br>`[81]` **Narrator**: "Monica pointedly moved a few inc..." |
| `[5]` | **""Who is it from?""** | `[76]` **Narrator**: "I entered to find Monica sitting..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "Monica briefly rested her head o..."<br>`[81]` **Narrator**: "Monica pointedly moved a few inc..." |
| `[6]` | **"Sit down next to Monica."** | `[76]` **Narrator**: "I entered to find Monica sitting..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "Monica briefly rested her head o..."<br>`[81]` **Narrator**: "Monica pointedly moved a few inc..." |
| `[8]` | **""How did he do?""** | `[7]` **Monica**: ""It's from the Department of Edu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Monica**: ""See for yourself."" |
| `[9]` | **""Why are you so worried, then?""** | `[7]` **Monica**: ""It's from the Department of Edu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Monica**: ""See for yourself."" |
| `[10]` | **""He failed, didn't he?""** | `[7]` **Monica**: ""It's from the Department of Edu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Monica**: ""Just read the letter."" |
| `[15]` | **""Maybe it'll be good for him to learn from his mistakes.""** | `[82]` **Monica**: ""You know what this means -- he'..."<br>`[14]` **Monica**: ""All those years of effort, all ..." | `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false` | *Brak zmian stanu* | `[18]` **Monica**: ""This isn't just about Franc, yo..." |
| `[16]` | **""Does he know the results yet?""** | `[82]` **Monica**: ""You know what this means -- he'..."<br>`[14]` **Monica**: ""All those years of effort, all ..." | `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false` | *Brak zmian stanu* | `[19]` **Monica**: ""No, but he should be back from ..." |
| `[17]` | **""He brought this upon himself.""** | `[82]` **Monica**: ""You know what this means -- he'..."<br>`[14]` **Monica**: ""All those years of effort, all ..." | `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false` | *Brak zmian stanu* | `[18]` **Monica**: ""This isn't just about Franc, yo..." |
| `[22]` | **"Wait for Monica to start the conversation."** | `[90]` **Franc**: ""Hi, Mom. What's going on?""<br>`[91]` **Franc**: ""Mom? Dad? What's going on?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Monica**: ""Your exam results arrived today."" |
| `[23]` | **""Have a seat, Franc.""** | `[90]` **Franc**: ""Hi, Mom. What's going on?""<br>`[91]` **Franc**: ""Mom? Dad? What's going on?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Narrator**: "He took a seat across from us, a..." |
| `[31]` | **""It's my fault. I should have been around to help you study.""** | `[30]` **Franc**: ""I never thought this would happ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[101]` **Franc**: ""Right, you should've taken a br..." |
| `[32]` | **""How could you let us down like this?""** | `[30]` **Franc**: ""I never thought this would happ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Franc**: ""I know, I know, I can't do anyt..." |
| `[33]` | **""You made your mother cry with your actions.""** | `[30]` **Franc**: ""I never thought this would happ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Franc**: ""I know, I know, I can't do anyt..." |
| `[34]` | **""It's not the end of the world.""** | `[30]` **Franc**: ""I never thought this would happ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Franc**: ""Pretty close, though, isn't it?"" |
| `[37]` | **""So it seems.""** | `[127]` **Franc**: ""I guess it's the army for me, t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Monica**: ""Anton. Isn't there *anything* y..." |
| `[38]` | **""Not so fast. There might be something I can do.""** | `[127]` **Franc**: ""I guess it's the army for me, t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Monica**: ""Yes!"" |
| `[42]` | **""Leave him be. He needs time.""** | `[41]` **Monica**: ""I'm going upstairs after him."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Monica**: ""I suppose I need some time as w..." |
| `[43]` | **"Say nothing."** | `[41]` **Monica**: ""I'm going upstairs after him."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Narrator**: "Monica went upstairs after Franc..." |
| `[44]` | **""Suit yourself.""** | `[41]` **Monica**: ""I'm going upstairs after him."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Narrator**: "Monica went upstairs after Franc..." |
| `[53]` | **""With enough money, I could get you into Harcard in Arcasia. It's one of the best ..."** | `[137]` **Player**: ""Wait. You could also study abro..."<br>`[138]` **Player**: ""It's true, you could study abro..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGame.PersonalWealth"] > 1` | `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedArcasi...` | `[54]` **Franc**: ""That sounds... great, actually!"" |
| `[58]` | **""United People's University in United Contana is free. It also has an excellent me..."** | `[137]` **Player**: ""Wait. You could also study abro..."<br>`[138]` **Player**: ""It's true, you could study abro..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Malenyevist"] < 0) == false`<br>`(Variable["BaseGame.PersonalWealth"] > 1) == false` | `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedContan...` | `[59]` **Franc**: ""Communism, I can dig that."" |
| `[62]` | **""It's been decided. You're going to United Contana, Franc.""** | `[61]` **Monica**: ""This is the future of our boy, ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Personal_University_Abroad_Unit...`<br>`Variable["BaseGameSupport.Journal_Turn07_University_Unite...` | `[245]` **Franc**: ""I don't care. Whichever gets me..."<br>`[246]` **Franc**: ""Thanks, Dad. Holsord State stil..." |
| `[64]` | **""He must have made us proud.""** | `[7]` **Monica**: ""It's from the Department of Edu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Monica**: ""See for yourself."" |
| `[92]` | **""Franc! Language!""** | `[27]` **Franc**: ""Oh, shit."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Franc**: ""Do you think I give a fuck?""<br>`[28]` **Franc**: ""I... I need a moment."" |
| `[93]` | **""That's all you have to say?""** | `[27]` **Franc**: ""Oh, shit."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Franc**: ""Do you think I give a fuck?""<br>`[28]` **Franc**: ""I... I need a moment."" |
| `[94]` | **""Son, we're not angry at you...""** | `[27]` **Franc**: ""Oh, shit."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[99]` **Franc**: ""Do you think I give a fuck?""<br>`[28]` **Franc**: ""I... I need a moment."" |
| `[95]` | **""You're a disappointment to this family, Franc.""** | `[27]` **Franc**: ""Oh, shit."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[99]` **Franc**: ""Do you think I give a fuck?""<br>`[28]` **Franc**: ""I... I need a moment."" |
| `[104]` | **""How dare you speak to your parents that way!""** | `[103]` **Franc**: ""It's all about you, isn't it? Y..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[108]` **Narrator**: "Monica put her hand on his shoul..." |
| `[105]` | **""My image doesn't matter. This is your future we're talking about.""** | `[103]` **Franc**: ""It's all about you, isn't it? Y..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[108]` **Narrator**: "Monica put her hand on his shoul..." |
| `[106]` | **""You're right. The President of Sordland cannot have a failure for a son!""** | `[103]` **Franc**: ""It's all about you, isn't it? Y..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[107]` **Narrator**: "Monica put her hand on his shoul..." |
| `[114]` | **""I'm not going to take life lessons from Ewald Alphonso.""** | `[40]` **Monica**: ""If Alphonso could get his dimwi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Franc**: ""Holsord State would be amazing!..."<br>`[136]` **Franc**: ""If you're going to abuse your p..." |
| `[121]` | **""I am a respected alumnus, it's true.""** | `[40]` **Monica**: ""If Alphonso could get his dimwi..." | `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true` | *Brak zmian stanu* | `[368]` **Franc**: ""Holsord State would be amazing!..."<br>`[136]` **Franc**: ""If you're going to abuse your p..." |
| `[122]` | **""I do have connections to the board.""** | `[40]` **Monica**: ""If Alphonso could get his dimwi..." | `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false` | *Brak zmian stanu* | `[368]` **Franc**: ""Holsord State would be amazing!..."<br>`[136]` **Franc**: ""If you're going to abuse your p..." |
| `[123]` | **""It would be nice to have him closer to home.""** | `[40]` **Monica**: ""If Alphonso could get his dimwi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Franc**: ""Holsord State would be amazing!..."<br>`[136]` **Franc**: ""If you're going to abuse your p..." |
| `[129]` | **""Well, there's always military school. But you're the president's son. You still h..."** | `[128]` **Franc**: ""So, what am I supposed to do now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Monica**: ""Yes!"" |
| `[130]` | **""You'll go to military school, of course. It's the only place that will have you.""** | `[128]` **Franc**: ""So, what am I supposed to do now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Monica**: ""Anton. Isn't there *anything* y..." |
| `[137]` | **""Wait. You could also study abroad...""** | `[135]` **Franc**: ""But I failed the exam. This suc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Player**: ""With enough money, I could get ..."<br>`[360]` **Player**: ""Actually... never mind.""<br>*(oraz 2 innych odgałęzień)* |
| `[138]` | **""It's true, you could study abroad...""** | `[136]` **Franc**: ""If you're going to abuse your p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Player**: ""With enough money, I could get ..."<br>`[360]` **Player**: ""Actually... never mind.""<br>*(oraz 2 innych odgałęzień)* |
| `[139]` | **""No. I won't influence your life. You've got to live with what you've done.""** | `[136]` **Franc**: ""If you're going to abuse your p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Monica**: ""Really? President Anton Rayne s..."<br>`[163]` **Monica**: ""I understand principles are imp..." |
| `[144]` | **""That's beside the point. You were the one who caused that whole deal in the first..."** | `[143]` **Monica**: ""Really? President Anton Rayne s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Monica**: ""Come on, Anton. This is the lea..." |
| `[146]` | **""There was more at play there than just you or me or any of us. I have a duty to t..."** | `[143]` **Monica**: ""Really? President Anton Rayne s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Monica**: ""I'm so sorry that duty required..." |
| `[148]` | **""Don't change the subject from Franc to you.""** | `[143]` **Monica**: ""Really? President Anton Rayne s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Monica**: ""Come on, Anton. This is the lea..." |
| `[165]` | **""Franc, wait--""** | `[153]` **Franc**: ""I don't want to cause any more ..."<br>`[155]` **Franc**: ""I'm sick of this house and I'm ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Narrator**: "Franc ran upstairs to his room." |
| `[166]` | **""Good. It's time you learned some discipline.""** | `[153]` **Franc**: ""I don't want to cause any more ..."<br>`[155]` **Franc**: ""I'm sick of this house and I'm ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Narrator**: "Franc ran upstairs to his room." |
| `[169]` | **""My principles, of course.""** | `[163]` **Monica**: ""I understand principles are imp..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[172]` **Franc**: ""I knew it."" |
| `[170]` | **""My son's future, of course.""** | `[163]` **Monica**: ""I understand principles are imp..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[171]` **Monica**: ""Then I believe you will make th..." |
| `[182]` | **""No, I've made my decision. You're going to military school.""** | `[171]` **Monica**: ""Then I believe you will make th..." | `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false` | `Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] ...` | `[191]` **Franc**: ""Great. See you when I come home..."<br>`[192]` **Franc**: ""All right, Dad. Serves me right..." |
| `[183]` | **""No, I've made my decision. You're joining the army.""** | `[171]` **Monica**: ""Then I believe you will make th..." | `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true` | `Variable["BaseGame.Turn07_Personal_FrancConscripted"] = t...` | `[191]` **Franc**: ""Great. See you when I come home..."<br>`[192]` **Franc**: ""All right, Dad. Serves me right..." |
| `[184]` | **""Fine. Let me think about this.""** | `[171]` **Monica**: ""Then I believe you will make th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Monica**: ""Thank you, Anton."" |
| `[193]` | **""There's Holsord State, or you could study abroad...""** | `[185]` **Monica**: ""Thank you, Anton."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_P_Franc_Reconsidered"] ...` | `[53]` **Player**: ""With enough money, I could get ..."<br>`[360]` **Player**: ""Actually... never mind."" |
| `[199]` | **""You know how I feel about communists, but United People's University in Contana i..."** | `[137]` **Player**: ""Wait. You could also study abro..."<br>`[138]` **Player**: ""It's true, you could study abro..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Malenyevist"] < 0`<br>`(Variable["BaseGame.PersonalWealth"] > 1) == false` | `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedContan...` | `[59]` **Franc**: ""Communism, I can dig that."" |
| `[203]` | **""Holsord State University is the right decision after all. [Nepotism]""** | `[61]` **Monica**: ""This is the future of our boy, ..."<br>`[206]` **Monica**: ""What do you think, Anton?""<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false` | `Variable["BaseGame.Turn07_Personal_University_Home_Public...`<br>`Variable["BaseGameSupport.Journal_Turn07_University_Holso...` | `[235]` **Franc**: ""The better to keep me under you..."<br>`[236]` **Franc**: ""Thanks so much, Dad. I swear I ..." |
| `[204]` | **""I won't influence your life, Franc. The military is the right choice.""** | `[61]` **Monica**: ""This is the future of our boy, ..."<br>`[206]` **Monica**: ""What do you think, Anton?""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_P_Franc_Reconsidered"] == false` | *Brak zmian stanu* | `[143]` **Monica**: ""Really? President Anton Rayne s..."<br>`[163]` **Monica**: ""I understand principles are imp..." |
| `[213]` | **""There's also Harcard in Arcasia. It's one of the best universities in the world. ..."** | `[61]` **Monica**: ""This is the future of our boy, ..." | `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia"] == false`<br>`Variable["BaseGame.PersonalWealth"] > 1` | *Brak zmian stanu* | `[54]` **Franc**: ""That sounds... great, actually!"" |
| `[217]` | **""On second thought, I'd rather send Franc to Harcard in Arcasia." [-2 Personal Wea..."** | `[61]` **Monica**: ""This is the future of our boy, ..." | `(Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia"] == false) == false`<br>`Variable["BaseGame.PersonalWealth"] > 1` | `Variable["BaseGame.Turn07_Personal_University_Abroad_Arca...`<br>`Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....`<br>*(+1 skryptów)* | *Koniec sceny / Terminal* |
| `[218]` | **""It's been decided. I'll pay for Franc to go to Harcard." [-2 Personal Wealth]"** | `[206]` **Monica**: ""What do you think, Anton?"" | `Variable["BaseGame.PersonalWealth"] > 1` | `Variable["BaseGame.Turn07_Personal_University_Abroad_Arca...`<br>`Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....`<br>*(+1 skryptów)* | *Koniec sceny / Terminal* |
| `[219]` | **""On the other hand, United People's University in United Contana is free and has a..."** | `[206]` **Monica**: ""What do you think, Anton?"" | `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedContana"] == false` | *Brak zmian stanu* | `[59]` **Franc**: ""Communism, I can dig that."" |
| `[223]` | **""On second thought, I'd rather send Franc to United Contana.""** | `[206]` **Monica**: ""What do you think, Anton?"" | `(Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedContana"] == false) == false` | `Variable["BaseGame.Turn07_Personal_University_Abroad_Unit...`<br>`Variable["BaseGameSupport.Journal_Turn07_University_Unite...` | `[245]` **Franc**: ""I don't care. Whichever gets me..."<br>`[246]` **Franc**: ""Thanks, Dad. Holsord State stil..." |
| `[306]` | **""Holsord State University is the right decision after all. It will cost a little e..."** | `[61]` **Monica**: ""This is the future of our boy, ..."<br>`[206]` **Monica**: ""What do you think, Anton?""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.PersonalWealth"] > 0`<br>`Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true` | `Variable["BaseGame.Turn07_Personal_University_Home_Public...`<br>`Variable["BaseGameSupport.Journal_Turn07_University_Holso...`<br>*(+1 skryptów)* | *Koniec sceny / Terminal* |
| `[319]` | **""No. I won't influence your life. You've got to live with what you've done.""** | `[135]` **Franc**: ""But I failed the exam. This suc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Monica**: ""Really? President Anton Rayne s..."<br>`[163]` **Monica**: ""I understand principles are imp..." |
| `[328]` | **""Terrific. Holsord State it is, then. [Nepotism]""** | `[135]` **Franc**: ""But I failed the exam. This suc..." | `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false` | `Variable["BaseGame.Turn07_Personal_University_Home_Public...`<br>`Variable["BaseGameSupport.Journal_Turn07_University_Holso...` | `[235]` **Franc**: ""The better to keep me under you..."<br>`[236]` **Franc**: ""Thanks so much, Dad. I swear I ..." |
| `[330]` | **""Terrific. Holsord State it is, then. Though, It is going to cost us a little bit ..."** | `[135]` **Franc**: ""But I failed the exam. This suc..." | `(Variable["BaseGame.PersonalWealth"] <= 0) == false`<br>`Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true` | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....`<br>`Variable["BaseGame.Turn07_Personal_University_Home_Public...`<br>*(+1 skryptów)* | *Koniec sceny / Terminal* |
| `[332]` | **""Unfortunately, Holsord is a no go. We don't have the money, right now.""** | `[135]` **Franc**: ""But I failed the exam. This suc..." | `Variable["BaseGame.PersonalWealth"] <= 0`<br>`Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true` | *Brak zmian stanu* | `[333]` **Franc**: ""All thanks to you and your priv..." |
| `[334]` | **""You could also study abroad...""** | `[333]` **Franc**: ""All thanks to you and your priv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Player**: ""With enough money, I could get ..."<br>`[360]` **Player**: ""Actually... never mind.""<br>*(oraz 2 innych odgałęzień)* |
| `[335]` | **""No. I won't influence your life. You've got to live with what you've done.""** | `[333]` **Franc**: ""All thanks to you and your priv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Narrator**: "Franc sneered at my statement." |
| `[338]` | **""No, I've made my decision. I'm sending you to Holsord State. [Nepotism]""** | `[136]` **Franc**: ""If you're going to abuse your p..." | `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false` | `Variable["BaseGame.Turn07_Personal_University_Home_Public...`<br>`Variable["BaseGameSupport.Journal_Turn07_University_Holso...` | `[235]` **Franc**: ""The better to keep me under you..."<br>`[236]` **Franc**: ""Thanks so much, Dad. I swear I ..." |
| `[348]` | **""You could also study abroad...""** | `[355]` **Franc**: ""All thanks to you and your priv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Player**: ""With enough money, I could get ..."<br>`[360]` **Player**: ""Actually... never mind.""<br>*(oraz 2 innych odgałęzień)* |
| `[349]` | **""You're right. Besides, We don't have the money for Holsord, right now.""** | `[136]` **Franc**: ""If you're going to abuse your p..." | `Variable["BaseGame.PersonalWealth"] <= 0`<br>`Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true` | *Brak zmian stanu* | `[355]` **Franc**: ""All thanks to you and your priv..." |
| `[351]` | **""No, I've made my decision. I'm sending you to Holsord State, even if it is going ..."** | `[136]` **Franc**: ""If you're going to abuse your p..." | `(Variable["BaseGame.PersonalWealth"] <= 0) == false`<br>`Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true` | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....`<br>`Variable["BaseGame.Turn07_Personal_University_Home_Public...`<br>*(+1 skryptów)* | *Koniec sceny / Terminal* |
| `[353]` | **""So, I guess, you've got to live with what you've done.""** | `[355]` **Franc**: ""All thanks to you and your priv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[358]` **Narrator**: "Franc sneered at my statement." |
| `[360]` | **""Actually... never mind.""** | `[137]` **Player**: ""Wait. You could also study abro..."<br>`[138]` **Player**: ""It's true, you could study abro..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGame.PersonalWealth"] > 1) == false` | *Brak zmian stanu* | `[361]` **Monica**: ""This is the future of our boy, ..." |
| `[370]` | **""There's nothing for us to decide. Franc's going into the military.""** | `[61]` **Monica**: ""This is the future of our boy, ..."<br>`[206]` **Monica**: ""What do you think, Anton?""<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGameIsolated.Turn07_P_Franc_Reconsidered"] == false) == false` | *Brak zmian stanu* | `[143]` **Monica**: ""Really? President Anton Rayne s..."<br>`[163]` **Monica**: ""I understand principles are imp..." |

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
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I arrived home from work, hung my jacket up, and put my briefcase in the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Darling, what's wrong?""]** — Mówca: **Player**
> ""Darling, what's wrong?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion > 2"*)

### Węzeł `[5]`
**[WYBÓR GRACZA: ""Who is it from?""]** — Mówca: **Player**
> ""Who is it from?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion > 2"*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "Sit down next to Monica."]** — Mówca: **Player_Italic**
> "I sat down on the couch next to Monica."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion > 2"*)

### Węzeł `[7]`
Mówca: **Monica**
> ""It's from the Department of Education. Franc's university exam results are in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: ""He must have made us proud.""*)
  - -> `[8]` (*Player: ""How did he do?""*)
  - -> `[9]` (*Player: ""Why are you so worried, then?""*)
  - -> `[10]` (*Player: ""He failed, didn't he?""*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""How did he do?""]** — Mówca: **Player**
> ""How did he do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Monica: ""See for yourself.""*)

### Węzeł `[9]`
**[WYBÓR GRACZA: ""Why are you so worried, then?""]** — Mówca: **Player**
> ""Why are you so worried, then?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Monica: ""See for yourself.""*)

### Węzeł `[10]`
**[WYBÓR GRACZA: ""He failed, didn't he?""]** — Mówca: **Player**
> ""He failed, didn't he?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Monica: ""Just read the letter.""*)

### Węzeł `[11]`
Mówca: **Monica**
> ""Just read the letter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "I looked at the page. Below Franc's name and address, his..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "I looked at the page. Below Franc's name and address, his score was written: 435 points, out of a total of 1000."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "At the bottom of the letter, the word "Failed" was stampe..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "At the bottom of the letter, the word "Failed" was stamped in red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Monica: ""All those years of effort, all those private lessons... ..."*)

### Węzeł `[14]`
Mówca: **Monica**
> ""All those years of effort, all those private lessons... all down the drain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService == true"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""Maybe it'll be good for him to learn from his mistakes.""]** — Mówca: **Player**
> ""Maybe it'll be good for him to learn from his mistakes.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[82]` (Monica), `[14]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Monica: ""This isn't just about Franc, you know. Him failing will ..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""Does he know the results yet?""]** — Mówca: **Player**
> ""Does he know the results yet?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[82]` (Monica), `[14]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Monica: ""No, but he should be back from school soon.""*)

### Węzeł `[17]`
**[WYBÓR GRACZA: ""He brought this upon himself.""]** — Mówca: **Player**
> ""He brought this upon himself.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[82]` (Monica), `[14]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Monica: ""This isn't just about Franc, you know. Him failing will ..."*)

### Węzeł `[18]`
Mówca: **Monica**
> ""This isn't just about Franc, you know. Him failing will reflect badly on you. On us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)

### Węzeł `[19]`
Mówca: **Monica**
> ""No, but he should be back from school soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)

### Węzeł `[20]`
Mówca: **Monica**
> ""I just don't understand. Franc's a smart boy -- why would he sabotage himself like this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "I heard a key turning in the front door. Franc stomped in..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "I heard a key turning in the front door. Franc stomped in and was about to go straight upstairs when he noticed us both in the living room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "Wait for Monica to start the conversation."]** — Mówca: **Player_Italic**
> "I waited for Monica to start the conversation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Franc), `[91]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Monica: ""Your exam results arrived today.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""Have a seat, Franc.""]** — Mówca: **Player**
> ""Have a seat, Franc.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Franc), `[91]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He took a seat across from us, and I handed him the lette..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "He took a seat across from us, and I handed him the letter. He started reading it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Franc: ""Oh, shit.""*)

### Węzeł `[25]`
Mówca: **Monica**
> ""Your exam results arrived today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Franc sat down, and Monica handed him the letter. He star..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Franc sat down, and Monica handed him the letter. He started reading it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Franc: ""Oh, shit.""*)

### Węzeł `[27]`
Mówca: **Franc**
> ""Oh, shit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: ""Franc! Language!""*)
  - -> `[93]` (*Player: ""That's all you have to say?""*)
  - -> `[94]` (*Player: ""Son, we're not angry at you...""*)
  - -> `[95]` (*Player: ""You're a disappointment to this family, Franc.""*)

### Węzeł `[28]`
Mówca: **Franc**
> ""I... I need a moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "He went to the kitchen sink and washed his face. A moment..."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "He went to the kitchen sink and washed his face. A moment later, he came back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Franc: ""I never thought this would happen. I'm so sorry.""*)

### Węzeł `[30]`
Mówca: **Franc**
> ""I never thought this would happen. I'm so sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: ""It's my fault. I should have been around to help you stu..."*)
  - -> `[32]` (*Player: ""How could you let us down like this?""*)
  - -> `[33]` (*Player: ""You made your mother cry with your actions.""*)
  - -> `[34]` (*Player: ""It's not the end of the world.""*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""It's my fault. I should have been around to help you study.""]** — Mówca: **Player**
> ""It's my fault. I should have been around to help you study.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1;"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""How could you let us down like this?""]** — Mówca: **Player**
> ""How could you let us down like this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Franc: ""I know, I know, I can't do anything right!""*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""You made your mother cry with your actions.""]** — Mówca: **Player**
> ""You made your mother cry with your actions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Franc: ""I know, I know, I can't do anything right!""*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""It's not the end of the world.""]** — Mówca: **Player**
> ""It's not the end of the world.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Franc: ""Pretty close, though, isn't it?""*)

### Węzeł `[35]`
Mówca: **Franc**
> ""Pretty close, though, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1;"*)

### Węzeł `[36]`
Mówca: **Franc**
> ""I know, I know, I can't do anything right!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1;"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""So it seems.""]** — Mówca: **Player**
> ""So it seems.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Monica: ""Anton. Isn't there *anything* you can do?""*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Not so fast. There might be something I can do.""]** — Mówca: **Player**
> ""Not so fast. There might be something I can do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Monica: ""Yes!""*)

### Węzeł `[39]`
Mówca: **Monica**
> ""Anton. Isn't there *anything* you can do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Monica: ""If Alphonso could get his dimwit son into Kingshill Univ..."*)

### Węzeł `[40]`
Mówca: **Monica**
> ""If Alphonso could get his dimwit son into Kingshill University, I'm sure Holsord State would have room for a bright boy like Franc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: ""I'm not going to take life lessons from Ewald Alphonso.""*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)
  - -> `[123]` (*Player: ""It would be nice to have him closer to home.""*)

### Węzeł `[41]`
Mówca: **Monica**
> ""I'm going upstairs after him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: ""Leave him be. He needs time.""*)
  - -> `[44]` (*Player: ""Suit yourself.""*)
  - -> `[43]` (*Player_Italic: "Say nothing."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Leave him be. He needs time.""]** — Mówca: **Player**
> ""Leave him be. He needs time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Monica: ""I suppose I need some time as well.""*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Monica went upstairs after Franc and I started reading do..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""Suit yourself.""]** — Mówca: **Player**
> ""Suit yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Monica went upstairs after Franc and I started reading do..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "Monica went upstairs after Franc and I started reading documents before dinner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_Personal_FrancUniversityChoice = true"*)

### Węzeł `[46]`
Mówca: **Monica**
> ""I suppose I need some time as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "Monica left the living room and I started reading newspap..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "Monica left the living room and I started reading newspapers before dinner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_Personal_FrancUniversityChoice = true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_Personal_FrancUniversityChoice = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_Personal_FrancUniversityChoice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion < 0"*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Monica went upstairs after Franc and I started reading documents before dinner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_Personal_FrancUniversityChoice = true"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 1)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""With enough money, I could get you into Harcard in Arcas..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist < 0"*)
  - -> `[360]` (*Player: ""Actually... never mind.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""With enough money, I could get you into Harcard in Arcasia. It's one of the best universities in the world.""]** — Mówca: **Player**
> ""With enough money, I could get you into Harcard in Arcasia. It's one of the best universities in the world.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Kontekst wejściowy (poprzednik):** `[137]` (Player), `[138]` (Player), `[334]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia = true"*)

### Węzeł `[54]`
Mówca: **Franc**
> ""That sounds... great, actually!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Monica: ""Anton! I want him to stay in Sordland.""*)

### Węzeł `[55]`
Mówca: **Monica**
> ""Anton! I want him to stay in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Franc: ""Mom. I've got to get out and experience the world someti..."*)

### Węzeł `[56]`
Mówca: **Franc**
> ""Mom. I've got to get out and experience the world sometime. And in Arcasia, people might see me as something more than just the president's son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Monica: ""I still don't like it, but I understand.""*)

### Węzeł `[57]`
Mówca: **Monica**
> ""I still don't like it, but I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Monica: ""What do you think, Anton?""*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""United People's University in United Contana is free. It also has an excellent medical program.""]** — Mówca: **Player**
> ""United People's University in United Contana is free. It also has an excellent medical program.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Malenyevist"] < 0) == false` AND `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Kontekst wejściowy (poprzednik):** `[137]` (Player), `[138]` (Player), `[334]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_P_Franc_DiscussedContana = true"*)

### Węzeł `[59]`
Mówca: **Franc**
> ""Communism, I can dig that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Franc: ""Not exactly how I was expecting to spend my student year..."*)

### Węzeł `[60]`
Mówca: **Franc**
> ""Not exactly how I was expecting to spend my student years, but anything's better than the military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Monica: ""This is the future of our boy, Anton. What should we do?""*)

### Węzeł `[61]`
Mówca: **Monica**
> ""This is the future of our boy, Anton. What should we do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: ""It's been decided. You're going to United Contana, Franc.""*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_P_Franc_Reconsidered == false"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""It's been decided. You're going to United Contana, Franc.""]** — Mówca: **Player**
> ""It's been decided. You're going to United Contana, Franc.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_University_UnitedContana =..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""He must have made us proud.""]** — Mówca: **Player**
> ""He must have made us proud.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Monica: ""See for yourself.""*)

### Węzeł `[65]`
Mówca: **Monica**
> ""See for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "I looked at the page. Below Franc's name and address, his..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Monica_Barred == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Gone were the days when I could expect a warm welcome fro..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Monica_Barred == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_P_SupportedMonicaAtConfrontation == false"*)

### Węzeł `[69]`
Mówca: **Narrator**
> "Gone were the days when I could expect a warm welcome from my family. Franc was either at school, barricaded in his room or out with friends. Deana spent more and more time at her after-school art classes, and Monica... well, Monica avoided me at all costs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "From the living room, I heard a muffled sob."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "I awaited my usual welcome from Deana before realizing she was out at one of her art classes. Franc was still at school, and Monica... it had been a long time since she'd come to the door to greet me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "From the living room, I heard a muffled sob."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_P_SupportedMonicaAtConfrontation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_P_SupportedMonicaAtConfrontation == false"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_P_SupportedMonicaAtConfrontation == false)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_P_SupportedMonicaAtConfrontation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_P_SupportedMonicaAtConfrontation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "I awaited my usual welcome from Deana before realizing sh..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_P_SupportedMonicaAtConfrontation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_P_SupportedMonicaAtConfrontation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "I paused, awaiting my usual greeting from my wife and dau..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "I paused, awaiting my usual greeting from my wife and daughter. Deana was out at one of her after-school art classes, I remembered. But where was Monica?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "From the living room, I heard a muffled sob."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "From the living room, I heard a muffled sob."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "I entered to find Monica sitting on the sofa, a letter in..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "I entered to find Monica sitting on the sofa, a letter in her hands and a look of despair on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""Darling, what's wrong?""*)
  - -> `[5]` (*Player: ""Who is it from?""*)
  - -> `[6]` (*Player_Italic: "Sit down next to Monica."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "Monica briefly rested her head on my shoulder, then handed me the letter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Monica: ""It's from the Department of Education. Franc's universit..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion > 2"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Opinion > 2 )"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Monica briefly rested her head on my shoulder, then hande..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Opinion > 2 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Monica pointedly moved a few inches away from me, then ha..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "Monica pointedly moved a few inches away from me, then handed me the letter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Monica: ""It's from the Department of Education. Franc's universit..."*)

### Węzeł `[82]`
Mówca: **Monica**
> ""You know what this means -- he's going to have to join the military. He could die, Anton!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: ""Maybe it'll be good for him to learn from his mistakes.""*)
  - -> `[16]` (*Player: ""Does he know the results yet?""*)
  - -> `[17]` (*Player: ""He brought this upon himself.""*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < 0)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Monica: ""He did this to get back at you, you know. Maybe if you h..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Monica: ""I just don't understand. Franc's a smart boy -- why woul..."*)

### Węzeł `[86]`
Mówca: **Monica**
> ""He did this to get back at you, you know. Maybe if you had been there for him more often...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "I heard a key turning in the front door. Franc stomped in..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < 0)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Franc: ""Hi, Mom. What's going on?""*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Franc: ""Mom? Dad? What's going on?""*)

### Węzeł `[90]`
Mówca: **Franc**
> ""Hi, Mom. What's going on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: ""Have a seat, Franc.""*)
  - -> `[22]` (*Player_Italic: "Wait for Monica to start the conversation."*)

### Węzeł `[91]`
Mówca: **Franc**
> ""Mom? Dad? What's going on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: ""Have a seat, Franc.""*)
  - -> `[22]` (*Player_Italic: "Wait for Monica to start the conversation."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Franc! Language!""]** — Mówca: **Player**
> ""Franc! Language!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""That's all you have to say?""]** — Mówca: **Player**
> ""That's all you have to say?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)

### Węzeł `[94]`
**[WYBÓR GRACZA: ""Son, we're not angry at you...""]** — Mówca: **Player**
> ""Son, we're not angry at you...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 2;"*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""You're a disappointment to this family, Franc.""]** — Mówca: **Player**
> ""You're a disappointment to this family, Franc.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 3;"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < 0)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Franc: ""Do you think I give a fuck?""*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Franc: ""I... I need a moment.""*)

### Węzeł `[99]`
Mówca: **Franc**
> ""Do you think I give a fuck?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Monica gasped."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Monica gasped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Franc: ""It's all about you, isn't it? You don't care that I bomb..."*)

### Węzeł `[101]`
Mówca: **Franc**
> ""Right, you should've taken a break from running the country to help your loser son!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "Franc looked close to tears. Monica put her hand on his s..."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "Franc looked close to tears. Monica put her hand on his shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Monica: ""It's going to be okay. But you really should have studie..."*)

### Węzeł `[103]`
Mówca: **Franc**
> ""It's all about you, isn't it? You don't care that I bombed the test. You just care how it makes you look!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""My image doesn't matter. This is your future we're talki..."*)
  - -> `[104]` (*Player: ""How dare you speak to your parents that way!""*)
  - -> `[106]` (*Player: ""You're right. The President of Sordland cannot have a fa..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: ""How dare you speak to your parents that way!""]** — Mówca: **Player**
> ""How dare you speak to your parents that way!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1;"*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""My image doesn't matter. This is your future we're talking about.""]** — Mówca: **Player**
> ""My image doesn't matter. This is your future we're talking about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 2;"*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""You're right. The President of Sordland cannot have a failure for a son!""]** — Mówca: **Player**
> ""You're right. The President of Sordland cannot have a failure for a son!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 2; BaseGame.Relations..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Monica put her hand on his shoulder. She glared at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Monica: ""I know it's been a rough time. But you really should hav..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Monica put her hand on his shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Monica: ""I know it's been a rough time. But you really should hav..."*)

### Węzeł `[109]`
Mówca: **Monica**
> ""I know it's been a rough time. But you really should have studied harder, Franc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Franc's face crumpled."*)

### Węzeł `[110]`
Mówca: **Franc**
> ""I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService == true"*)

### Węzeł `[111]`
Mówca: **Narrator**
> "Franc's face crumpled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Franc: ""I know.""*)

### Węzeł `[112]`
Mówca: **Monica**
> ""It's going to be okay. But you really should have studied harder, Franc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Franc: ""I know.""*)

### Węzeł `[113]`
Mówca: **Monica**
> ""Yes!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "Monica surprised me with her enthusiasm."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""I'm not going to take life lessons from Ewald Alphonso.""]** — Mówca: **Player**
> ""I'm not going to take life lessons from Ewald Alphonso.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion > 0"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Military_CompulsoryMilitaryService == t..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Franc: ""I guess it's the army for me, then...""*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Military_CompulsoryMilitaryService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Franc: ""So, what am I supposed to do now?""*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Holsord_Law == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""I am a respected alumnus, it's true.""*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Holsord_Law == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""I do have connections to the board.""*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I am a respected alumnus, it's true.""]** — Mówca: **Player**
> ""I am a respected alumnus, it's true.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Kontekst wejściowy (poprzednik):** `[40]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion > 0"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""I do have connections to the board.""]** — Mówca: **Player**
> ""I do have connections to the board.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[40]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion > 0"*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""It would be nice to have him closer to home.""]** — Mówca: **Player**
> ""It would be nice to have him closer to home.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion > 0"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Military_CompulsoryMilitaryService == t..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Monica: ""You know what this means -- he's going to have to join t..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Military_CompulsoryMilitaryService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: ""Maybe it'll be good for him to learn from his mistakes.""*)
  - -> `[16]` (*Player: ""Does he know the results yet?""*)
  - -> `[17]` (*Player: ""He brought this upon himself.""*)

### Węzeł `[127]`
Mówca: **Franc**
> ""I guess it's the army for me, then...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""Not so fast. There might be something I can do.""*)
  - -> `[37]` (*Player: ""So it seems.""*)

### Węzeł `[128]`
Mówca: **Franc**
> ""So, what am I supposed to do now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: ""Well, there's always military school. But you're the pre..."*)
  - -> `[130]` (*Player: ""You'll go to military school, of course. It's the only p..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Well, there's always military school. But you're the president's son. You still have options.""]** — Mówca: **Player**
> ""Well, there's always military school. But you're the president's son. You still have options.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Monica: ""Yes!""*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""You'll go to military school, of course. It's the only place that will have you.""]** — Mówca: **Player**
> ""You'll go to military school, of course. It's the only place that will have you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Monica: ""Anton. Isn't there *anything* you can do?""*)

### Węzeł `[131]`
Mówca: **Narrator**
> "Monica surprised me with her enthusiasm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Monica: ""If Alphonso could get his dimwit son into Kingshill Univ..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion > 0"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion > 0)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Franc: ""Holsord State would be amazing! A bunch of my friends ar..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Franc: ""If you're going to abuse your power to get me into a sch..."*)

### Węzeł `[135]`
Mówca: **Franc**
> ""But I failed the exam. This sucks. Are you sure about all of this. Isn't it technically illegal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: ""Wait. You could also study abroad...""*)
  - -> `[319]` (*Player: ""No. I won't influence your life. You've got to live with..."*)
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[136]`
Mówca: **Franc**
> ""If you're going to abuse your power to get me into a school, I want it to be as far away from this family as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player: ""It's true, you could study abroad...""*)
  - -> `[139]` (*Player: ""No. I won't influence your life. You've got to live with..."*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Wait. You could also study abroad...""]** — Mówca: **Player**
> ""Wait. You could also study abroad...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "Jump to: [Study Abroad]"*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""It's true, you could study abroad...""]** — Mówca: **Player**
> ""It's true, you could study abroad...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "Jump to: [Study Abroad]"*)

### Węzeł `[139]`
**[WYBÓR GRACZA: ""No. I won't influence your life. You've got to live with what you've done.""]** — Mówca: **Player**
> ""No. I won't influence your life. You've got to live with what you've done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "Jump to: [Military Convo]"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Monica_Barred == true)"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Monica: ""Really? President Anton Rayne suddenly refuses to influe..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Monica_Barred == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Monica: ""I understand principles are important. But, Anton, which..."*)

### Węzeł `[143]`
Mówca: **Monica**
> ""Really? President Anton Rayne suddenly refuses to influence his family members' lives? After banning his wife from politics?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player: ""That's beside the point. You were the one who caused tha..."*)
  - -> `[148]` (*Player: ""Don't change the subject from Franc to you.""*)
  - -> `[146]` (*Player: ""There was more at play there than just you or me or any ..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA: ""That's beside the point. You were the one who caused that whole deal in the first place.""]** — Mówca: **Player**
> ""That's beside the point. You were the one who caused that whole deal in the first place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Monica: ""Come on, Anton. This is the least you can do after what ..."*)

### Węzeł `[145]`
Mówca: **Monica**
> ""Come on, Anton. This is the least you can do after what you did to me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Franc: ""Mom! Dad! Stop fighting!""*)

### Węzeł `[146]`
**[WYBÓR GRACZA: ""There was more at play there than just you or me or any of us. I have a duty to this nation.""]** — Mówca: **Player**
> ""There was more at play there than just you or me or any of us. I have a duty to this nation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Monica: ""I'm so sorry that duty required you to publicly ridicule..."*)

### Węzeł `[147]`
Mówca: **Monica**
> ""I'm so sorry that duty required you to publicly ridicule me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Franc: ""Mom! Dad! Stop fighting!""*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Don't change the subject from Franc to you.""]** — Mówca: **Player**
> ""Don't change the subject from Franc to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Monica: ""Come on, Anton. This is the least you can do after what ..."*)

### Węzeł `[149]`
Mówca: **Franc**
> ""Mom! Dad! Stop fighting!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < 0)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService == true"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService == true"*)

### Węzeł `[153]`
Mówca: **Franc**
> ""I don't want to cause any more trouble than I already have. I'll go to military school.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancMilitarySchool = true"*)

### Węzeł `[154]`
Mówca: **Franc**
> ""I don't want to cause any more trouble than I already have. I'll join the army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted = true"*)

### Węzeł `[155]`
Mówca: **Franc**
> ""I'm sick of this house and I'm sick of both of you. I'll go to military school.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancMilitarySchool = true"*)

### Węzeł `[156]`
Mówca: **Franc**
> ""I'm sick of this house and I'm sick of both of you. I'll join the goddamn army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted = true"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Military_CompulsoryMilitaryService == t..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Franc: ""I don't want to cause any more trouble than I already ha..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Military_CompulsoryMilitaryService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Franc: ""I don't want to cause any more trouble than I already ha..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Military_CompulsoryMilitaryService == t..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Franc: ""I'm sick of this house and I'm sick of both of you. I'll..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Military_CompulsoryMilitaryService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Franc: ""I'm sick of this house and I'm sick of both of you. I'll..."*)

### Węzeł `[163]`
Mówca: **Monica**
> ""I understand principles are important. But, Anton, which is more important? Your principles or your son's future?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""My principles, of course.""*)
  - -> `[170]` (*Player: ""My son's future, of course.""*)

### Węzeł `[164]`
Mówca: **Narrator**
> "Franc ran upstairs to his room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancMilitarySchool == true"*)

### Węzeł `[165]`
**[WYBÓR GRACZA: ""Franc, wait--""]** — Mówca: **Player**
> ""Franc, wait--""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Franc), `[155]` (Franc), `[178]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Franc ran upstairs to his room."*)

### Węzeł `[166]`
**[WYBÓR GRACZA: ""Good. It's time you learned some discipline.""]** — Mówca: **Player**
> ""Good. It's time you learned some discipline.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Franc), `[155]` (Franc), `[178]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Franc ran upstairs to his room."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_University_Conscription = ..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancMilitarySchool = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_University_MilitarySchool ..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""My principles, of course.""]** — Mówca: **Player**
> ""My principles, of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1; BaseGame.Relations..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""My son's future, of course.""]** — Mówca: **Player**
> ""My son's future, of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1; BaseGame.Relations..."*)

### Węzeł `[171]`
Mówca: **Monica**
> ""Then I believe you will make the right choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService == true"*)
  - -> `[184]` (*Player: ""Fine. Let me think about this.""*)

### Węzeł `[172]`
Mówca: **Franc**
> ""I knew it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService == true"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1;
BaseGame.Relations_Monica_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;
Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Franc: ""I knew it.""*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Military_CompulsoryMilitaryService == t..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Franc: ""If it's so important to you, I'll join the goddamn army...."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Military_CompulsoryMilitaryService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Franc: ""If it's so important to you, I'll go to goddamn military..."*)

### Węzeł `[177]`
Mówca: **Franc**
> ""If it's so important to you, I'll join the goddamn army. I won't be around to disgrace you any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted = true"*)

### Węzeł `[178]`
Mówca: **Franc**
> ""If it's so important to you, I'll go to goddamn military school. I won't be around to disgrace you any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancMilitarySchool = true"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService == true"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Military_CompulsoryMilitaryService == t..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player: ""No, I've made my decision. You're joining the army.""*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Military_CompulsoryMilitaryService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: ""No, I've made my decision. You're going to military scho..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""No, I've made my decision. You're going to military school.""]** — Mówca: **Player**
> ""No, I've made my decision. You're going to military school, Franc.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[171]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancMilitarySchool = true"*)

### Węzeł `[183]`
**[WYBÓR GRACZA: ""No, I've made my decision. You're joining the army.""]** — Mówca: **Player**
> ""No, I've made my decision. You're joining the army, Franc.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == true`
- **Kontekst wejściowy (poprzednik):** `[171]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted = true"*)

### Węzeł `[184]`
**[WYBÓR GRACZA: ""Fine. Let me think about this.""]** — Mówca: **Player**
> ""Fine. Let me think about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Monica: ""Thank you, Anton.""*)

### Węzeł `[185]`
Mówca: **Monica**
> ""Thank you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player: ""There's Holsord State, or you could study abroad...""*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < 0)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Franc: ""Great. See you when I come home in a body bag.""*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Franc: ""All right, Dad. Serves me right for not studying.""*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancMilitarySchool = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)

### Węzeł `[191]`
Mówca: **Franc**
> ""Great. See you when I come home in a body bag.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Franc ran upstairs to his room."*)

### Węzeł `[192]`
Mówca: **Franc**
> ""All right, Dad. Serves me right for not studying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Franc ran upstairs to his room."*)

### Węzeł `[193]`
**[WYBÓR GRACZA: ""There's Holsord State, or you could study abroad...""]** — Mówca: **Player**
> ""There's Holsord State, or you could study abroad...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_P_Franc_Reconsidered = true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Study Abroad`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Study Abroad]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "Study Abroad"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Study Abroad]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "Study Abroad"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Study Abroad]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "Study Abroad"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_P_Franc_Reconsidered = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_P_Franc_Reconsidered"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "Jump to: [Study Abroad]"*)

### Węzeł `[199]`
**[WYBÓR GRACZA: ""You know how I feel about communists, but United People's University in Contana is free. It also has an excellent medical program.""]** — Mówca: **Player**
> ""You know how I feel about communists, but United People's University in Contana is free. It also has an excellent medical program.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Malenyevist"] < 0` AND `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Kontekst wejściowy (poprzednik):** `[137]` (Player), `[138]` (Player), `[334]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_P_Franc_DiscussedContana = true"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist < 0"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist < 0)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player: ""You know how I feel about communists, but United People'..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: ""United People's University in United Contana is free. It..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA: ""Holsord State University is the right decision after all. [Nepotism]""]** — Mówca: **Player**
> ""Holsord State University is the right decision after all.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[61]` (Monica), `[206]` (Monica), `[361]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public = true"*)

### Węzeł `[204]`
**[WYBÓR GRACZA: ""I won't influence your life, Franc. The military is the right choice.""]** — Mówca: **Player**
> ""I won't influence your life, Franc. The military is the right choice.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_P_Franc_Reconsidered"] == false`
- **Kontekst wejściowy (poprzednik):** `[61]` (Monica), `[206]` (Monica), `[361]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "Jump to: [Military Convo]"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Military Convo`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)

### Węzeł `[206]`
Mówca: **Monica**
> ""What do you think, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_P_Franc_DiscussedContana == false"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_P_Franc_Reconsidered == false"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_P_Franc_Reconsidered == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_P_Franc_Reconsidered == false"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_P_Franc_Reconsidered == false)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_P_Franc_Reconsidered == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_P_Franc_Reconsidered"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player: ""I won't influence your life, Franc. The military is the ..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_P_Franc_Reconsidered == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_P_Franc_Reconsidered"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Player: ""There's nothing for us to decide. Franc's going into the..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 1)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia == false"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[213]`
**[WYBÓR GRACZA: ""There's also Harcard in Arcasia. It's one of the best universities in the world. With enough money, I could get you in.""]** — Mówca: **Player**
> ""There's also Harcard in Arcasia. It's one of the best universities in the world. With enough money, I could get you in.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia"] == false` AND `Variable["BaseGame.PersonalWealth"] > 1`
- **Kontekst wejściowy (poprzednik):** `[61]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Franc: ""That sounds... great, actually!""*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_University_HolsordState = ..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Military Convo]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "Military Convo"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_P_Franc_DiscussedContana = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedContana"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Franc: ""Communism, I can dig that.""*)

### Węzeł `[217]`
**[WYBÓR GRACZA: ""On second thought, I'd rather send Franc to Harcard in Arcasia." [-2 Personal Wealth]"]** — Mówca: **Player**
> ""On second thought, I'd rather send Franc to Harcard in Arcasia.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia"] == false) == false` AND `Variable["BaseGame.PersonalWealth"] > 1`
- **Kontekst wejściowy (poprzednik):** `[61]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia = true"*)

### Węzeł `[218]`
**[WYBÓR GRACZA: ""It's been decided. I'll pay for Franc to go to Harcard." [-2 Personal Wealth]"]** — Mówca: **Player**
> ""It's been decided. I'll pay for Franc to go to Harcard.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Kontekst wejściowy (poprzednik):** `[206]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia = true"*)

### Węzeł `[219]`
**[WYBÓR GRACZA: ""On the other hand, United People's University in United Contana is free and has an excellent medical program...""]** — Mówca: **Player**
> ""On the other hand, United People's University in United Contana is free and has an excellent medical program...""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedContana"] == false`
- **Kontekst wejściowy (poprzednik):** `[206]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Franc: ""Communism, I can dig that.""*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_P_Franc_DiscussedContana == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_P_Franc_DiscussedContana == false"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_P_Franc_DiscussedContana == false)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_P_Franc_DiscussedContana == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedContana"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player: ""On the other hand, United People's University in United ..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_P_Franc_DiscussedContana == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedContana"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player: ""On second thought, I'd rather send Franc to United Conta..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA: ""On second thought, I'd rather send Franc to United Contana.""]** — Mówca: **Player**
> ""On second thought, I'd rather send Franc to United Contana.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedContana"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[206]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Franc: ""That sounds... great, actually!""*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Military Convo]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "Military Convo"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 2"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_University_Arcasia = true"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 2"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_University_Arcasia = true"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_University_UnitedContana =..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Holsord State Decided`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < 0)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Franc: ""The better to keep me under your thumb at all times.""*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Franc: ""Thanks so much, Dad. I swear I won't let you down this t..."*)

### Węzeł `[235]`
Mówca: **Franc**
> ""The better to keep me under your thumb at all times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Franc: ""But fine, I accept. It's better than the army.""*)

### Węzeł `[236]`
Mówca: **Franc**
> ""Thanks so much, Dad. I swear I won't let you down this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "Monica let out a long exhale."*)

### Węzeł `[237]`
Mówca: **Franc**
> ""But fine, I accept. It's better than the army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "Monica let out a long exhale."*)

### Węzeł `[238]`
Mówca: **Narrator**
> "Monica let out a long exhale."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Monica: ""What a day! Who's hungry for dinner?""*)

### Węzeł `[239]`
Mówca: **Monica**
> ""What a day! Who's hungry for dinner?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Monica disappeared to the kitchen; Franc to his room. I w..."*)

### Węzeł `[240]`
Mówca: **Narrator**
> "Monica disappeared to the kitchen; Franc to his room. I went to my office and began making some phone calls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_Personal_FrancUniversityChoice = true"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Study Abroad Decided`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion < 0)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Franc: ""I don't care. Whichever gets me out of here the fastest!""*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Franc: ""Thanks, Dad. Holsord State still would have been my firs..."*)

### Węzeł `[245]`
Mówca: **Franc**
> ""I don't care. Whichever gets me out of here the fastest!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "Monica let out a long exhale."*)

### Węzeł `[246]`
Mówca: **Franc**
> ""Thanks, Dad. Holsord State still would have been my first choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Monica: ""Not only yours.""*)

### Węzeł `[247]`
Mówca: **Monica**
> ""Not only yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Franc: ""But it's your call to make, after the way I messed up.""*)

### Węzeł `[248]`
Mówca: **Franc**
> ""But it's your call to make, after the way I messed up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "Monica let out a long exhale."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Study Abroad Decided]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "Study Abroad Decided"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Study Abroad Decided]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "Study Abroad Decided"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Study Abroad Decided]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "Study Abroad Decided"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Holsord State Decided]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "Holsord State Decided"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Study Abroad Decided]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "Study Abroad Decided"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_University_UnitedContana = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_UnitedContana"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "Jump to: [Study Abroad Decided]"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_University_HolsordState = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_HolsordState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "Jump to: [Holsord State Decided]"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_University_Arcasia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_Arcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "Jump to: [Study Abroad Decided]"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_University_Arcasia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_Arcasia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "Jump to: [Study Abroad Decided]"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_University_UnitedContana = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_UnitedContana"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "Jump to: [Study Abroad Decided]"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_University_MilitarySchool = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_MilitarySchool"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player: ""Franc, wait--""*)
  - -> `[166]` (*Player: ""Good. It's time you learned some discipline.""*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_University_Conscription = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_Conscription"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player: ""Franc, wait--""*)
  - -> `[166]` (*Player: ""Good. It's time you learned some discipline.""*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Monica put her hand on his shoulder."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 2;
BaseGame.Relations_Monica_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 2;
Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Monica put her hand on his shoulder. She glared at me."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Franc: ""Right, you should've taken a break from running the coun..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "Franc looked close to tears. Monica put her hand on his s..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "Franc looked close to tears. Monica put her hand on his s..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1;
BaseGame.Relations_Monica_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;
Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Monica: ""Then I believe you will make the right choice.""*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Monica: ""I'm going upstairs after him.""*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancMilitarySchool == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancMilitarySchool == true"*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_FrancMilitarySchool == true)"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancMilitarySchool == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1;"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_FrancMilitarySchool == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Monica: ""I'm going upstairs after him.""*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_ImproveRural == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_ImproveRural == true"*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Education_ImproveRural == true)"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_ImproveRural == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Ribel_EducationQualityIncre..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Education_ImproveRural == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_ImproveRural"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Salary == true"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Salary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Salary == true"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Education_Salary == true)"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Salary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_Salary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Vesord_EducationSalariesInc..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Education_Salary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_Salary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Schools == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Schools == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Schools == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_PSnW_Education_Schools == true)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_PSnW_Education_Schools == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_PSnW_Education_Schools"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Narbel_NewSchoolBuilt = true"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_PSnW_Education_Schools == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_PSnW_Education_Schools"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I arrived home from work, hung my jacket up, and put my b..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Ribel_EducationQualityIncreased = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Ribel_EducationQualityIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Salary == true"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Vesord_EducationSalariesIncreased = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Vesord_EducationSalariesIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_Schools == true"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Narbel_NewSchoolBuilt = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Narbel_NewSchoolBuilt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I arrived home from work, hung my jacket up, and put my b..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_ErsenCase_Religious..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_ErsenCase_Religious..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ReligiousBillSigned = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ReligiousBillSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_HP_ErsenResult = true; BaseGa..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ReligiousBillVetoed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_ErsenCase_ReligiousBillVetoed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_HP_ErsenResult = true; BaseGa..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_EmergencyDecree_Banned_YS == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_EmergencyDecree_Banned_YS == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn07_Holsord_KibenerShowSupportE..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_EmergencyDecree_Banned_YS == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn07_Holsord_KibenerShowSupportEmergency = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn07_Holsord_KibenerShowSupportEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_HP_ErsenResult = true;
BaseGameSupport.News_Turn07_R_ErsenResult = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_ErsenResult"] = true;
Variable["BaseGameSupport.News_Turn07_R_ErsenResult"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_ImproveRural == true"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion < 0"*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion < 0)"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_LT_BludishProtests = true"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_LT_AschrafUpcoming = true; Ba..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_LT_BludishProtests = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_LT_BludishProtests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_LT_AschrafUpcoming = true; Ba..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_LT_AschrafUpcoming = true; BaseGameSupport.FactionReport_Turn07_ATO_CondemsDrugTraffic = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_LT_AschrafUpcoming"] = true;
Variable["BaseGameSupport.FactionReport_Turn07_ATO_CondemsDrugTraffic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Privatization == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_R_EducationPrivatised = true"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_R_EducationPrivatised = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_EducationPrivatised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Privatization == true)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Privatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player: ""Holsord State University is the right decision after all..."*)

### Węzeł `[306]`
**[WYBÓR GRACZA: ""Holsord State University is the right decision after all. It will cost a little extra due to the privatization changes." [-1 Personal Wealth], [Nepotism]"]** — Mówca: **Player**
> ""Holsord State University is the right decision after all. It will cost a little extra due to the privatization changes.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 0` AND `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Kontekst wejściowy (poprzednik):** `[61]` (Monica), `[206]` (Monica), `[361]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public = true"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "Jump to: [Holsord State Decided]"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_University_HolsordState = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_HolsordState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 1"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_University_HolsordState = ..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 1"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 1)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player: ""It's been decided. I'll pay for Franc to go to Harcard."..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion < 0"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Monica put her hand on his shoulder."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia == false"*)
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia == false)"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player: ""There's also Harcard in Arcasia. It's one of the best un..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_P_Franc_DiscussedArcasia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player: ""On second thought, I'd rather send Franc to Harcard in A..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Military Convo]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "Military Convo"*)

### Węzeł `[319]`
**[WYBÓR GRACZA: ""No. I won't influence your life. You've got to live with what you've done.""]** — Mówca: **Player**
> ""No. I won't influence your life. You've got to live with what you've done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "Jump to: [Military Convo]"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Privatization == true )"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth <= 0"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Privatization == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Player: ""Terrific. Holsord State it is, then. [Nepotism]""*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth <= 0"*)
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth <= 0)"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Player: ""Unfortunately, Holsord is a no go. We don't have the mon..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player: ""Terrific. Holsord State it is, then. Though, It is going..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_University_HolsordState = ..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_University_HolsordState = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_HolsordState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "Jump to: [Holsord State Decided]"*)

### Węzeł `[328]`
**[WYBÓR GRACZA: ""Terrific. Holsord State it is, then. [Nepotism]""]** — Mówca: **Player**
> ""Terrific. Holsord State it is, then.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[135]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public = true"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Holsord State Decided]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "Holsord State Decided"*)

### Węzeł `[330]`
**[WYBÓR GRACZA: ""Terrific. Holsord State it is, then. Though, It is going to cost us a little bit extra due to the privatization changes. [-1 Personal Wealth], [Nepotism]""]** — Mówca: **Player**
> ""Terrific. Holsord State it is, then. Though, It going to cost us a little bit extra due to the privatization changes.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PersonalWealth"] <= 0) == false` AND `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Kontekst wejściowy (poprzednik):** `[135]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 1"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public = true"*)

### Węzeł `[332]`
**[WYBÓR GRACZA: ""Unfortunately, Holsord is a no go. We don't have the money, right now.""]** — Mówca: **Player**
> ""Unfortunately, Holsord is a no go. We don't have the money, right now.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] <= 0` AND `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Kontekst wejściowy (poprzednik):** `[135]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Franc: ""All thanks to you and your privatization changes!""*)

### Węzeł `[333]`
Mówca: **Franc**
> ""All thanks to you and your privatization changes!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Player: ""You could also study abroad...""*)
  - -> `[335]` (*Player: ""No. I won't influence your life. You've got to live with..."*)

### Węzeł `[334]`
**[WYBÓR GRACZA: ""You could also study abroad...""]** — Mówca: **Player**
> ""You could also study abroad...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[333]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "Jump to: [Study Abroad]"*)

### Węzeł `[335]`
**[WYBÓR GRACZA: ""No. I won't influence your life. You've got to live with what you've done.""]** — Mówca: **Player**
> ""So, I guess, you've got to live with what you've done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[333]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "Franc sneered at my statement."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Study Abroad]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "Study Abroad"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Military Convo]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "Military Convo"*)

### Węzeł `[338]`
**[WYBÓR GRACZA: ""No, I've made my decision. I'm sending you to Holsord State. [Nepotism]""]** — Mówca: **Player**
> ""No, I've made my decision. I'm sending you to Holsord State.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[136]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public = true"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_University_HolsordState = ..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_University_HolsordState = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_University_HolsordState"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "Jump to: [Holsord State Decided]"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Privatization == true )"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Privatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth <= 0"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Privatization == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Player: ""No, I've made my decision. I'm sending you to Holsord St..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth <= 0"*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth <= 0)"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Player: ""You're right. Besides, We don't have the money for Holso..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player: ""No, I've made my decision. I'm sending you to Holsord St..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Study Abroad]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "Study Abroad"*)

### Węzeł `[348]`
**[WYBÓR GRACZA: ""You could also study abroad...""]** — Mówca: **Player**
> ""You could also study abroad...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "Jump to: [Study Abroad]"*)

### Węzeł `[349]`
**[WYBÓR GRACZA: ""You're right. Besides, We don't have the money for Holsord, right now.""]** — Mówca: **Player**
> ""You're right. Besides, We don't have the money for Holsord, right now.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] <= 0` AND `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Kontekst wejściowy (poprzednik):** `[136]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Franc: ""All thanks to you and your privatization changes!""*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Holsord State Decided]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "Holsord State Decided"*)

### Węzeł `[351]`
**[WYBÓR GRACZA: ""No, I've made my decision. I'm sending you to Holsord State, even if it is going to cost us a little bit extra due to the privatization changes. [-1 Personal Wealth], [Nepotism]""]** — Mówca: **Player**
> ""No, I've made my decision. I'm sending you to Holsord State, even if it is going to cost us a little bit extra due to the privatization changes.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PersonalWealth"] <= 0) == false` AND `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Kontekst wejściowy (poprzednik):** `[136]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 1"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public = true"*)

### Węzeł `[353]`
**[WYBÓR GRACZA: ""So, I guess, you've got to live with what you've done.""]** — Mówca: **Player**
> ""So, I guess, you've got to live with what you've done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Narrator: "Franc sneered at my statement."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Military Convo]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "Military Convo"*)

### Węzeł `[355]`
Mówca: **Franc**
> ""All thanks to you and your privatization changes!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Player: ""You could also study abroad...""*)
  - -> `[353]` (*Player: ""So, I guess, you've got to live with what you've done.""*)

### Węzeł `[356]`
Mówca: **Franc**
> ""Wow, you're the best dad, ever!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "Jump to: [Military Convo]"*)

### Węzeł `[357]`
Mówca: **Narrator**
> "Franc sneered at my statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Franc: ""Wow, you're the best dad, ever!""*)

### Węzeł `[358]`
Mówca: **Narrator**
> "Franc sneered at my statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Franc: ""Wow, you're the best dad, ever!""*)

### Węzeł `[359]`
Mówca: **Franc**
> ""Wow, you're the best dad, ever!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "Jump to: [Military Convo]"*)

### Węzeł `[360]`
**[WYBÓR GRACZA: ""Actually... never mind.""]** — Mówca: **Player**
> ""Actually... never mind.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Kontekst wejściowy (poprzednik):** `[137]` (Player), `[138]` (Player), `[334]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Monica: ""This is the future of our boy, Anton. What should we do?""*)

### Węzeł `[361]`
Mówca: **Monica**
> ""This is the future of our boy, Anton. What should we do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Privatization == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_P_Franc_Reconsidered == false"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 0)"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Player: ""Holsord State University is the right decision after all..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_PSnW_Education_ImproveRural == true"*)

### Węzeł `[368]`
Mówca: **Franc**
> ""Holsord State would be amazing! A bunch of my friends are going there, I could still come home to do my laundry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Franc: ""But I failed the exam. This sucks. Are you sure about al..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[370]`
**[WYBÓR GRACZA: ""There's nothing for us to decide. Franc's going into the military.""]** — Mówca: **Player**
> ""There's nothing for us to decide. Franc's going into the military.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn07_P_Franc_Reconsidered"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[61]` (Monica), `[206]` (Monica), `[361]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "Jump to: [Military Convo]"*)
