# Sordland/Turn03/PSnW_Overview

- **ID konwersacji:** `28`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/028_PSnW_Overview.md`
- **Liczba węzłów dialogowych:** 345
- **Liczba wyborów gracza:** 78

---

## 1. Uczestnicy Sceny

- **[2]** Paskal Beniwoll
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[40]** Ciara Walda

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople`
- `BaseGame.Decision_Turn02_StatusReaction_BoostPolice`
- `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Promise_TermFocus_Education`
- `BaseGame.Promise_TermFocus_Health`
- `BaseGame.Reform_Autocrat_Abandon`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education_Students`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality`
- `BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education_Students`
- `BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses`
- `BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality`
- `BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan`
- `BaseGameSupport.CountryReport_Turn03_Lespia_ArcasianMilitaryBase`
- `BaseGameSupport.FactionReport_Turn03_CSP_SummitForHelji`
- `BaseGameSupport.News_Turn03_HP_EPA_RepealFails`
- `BaseGameSupport.News_Turn03_R_Protest_CalledProtestersTraitors`
- `BaseGameSupport.News_Turn03_R_Protest_ExpandedPolice`
- `BaseGameSupport.Report_Turn03_Estord_YSFoundDead`
- `BaseGameSupport.Report_Turn03_Holsord_EPARepealFails`
- `BaseGameSupport.Report_Turn03_Holsord_NFPReport`
- `BaseGameSupport.Report_Turn03_Holsord_WorkersRightsPrep`
- `BaseGameSupport.Report_Turn03_Morbel_MineDisaster`
- `BaseGameSupport.Report_Turn03_Narbel_CPSLUSOrganize`
- `BaseGameSupport.Report_Turn03_Narbel_LaborStrike`
- `BaseGameSupport.Report_Turn03_Valgen_CalledProtestersTraitors`
- `GameCondition.Turn03_A_LateBriefing`
- `GameCondition.Turn03_Decision_StabilityOrder`
- `GameCondition.Turn03_PSnW_Overview`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[10]` | **"“Let's start with your health overview, Paskal.”"** | `[9]` **Narrator**: "The meeting room was already pre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Paskal Beniwoll**: "“As you wish, Mr. President.”" |
| `[11]` | **"“Tell me more about your plans, Ciara.”"** | `[9]` **Narrator**: "The meeting room was already pre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Ciara Walda**: "“With pleasure.”" |
| `[16]` | **"“How many doctors and nurses are employed?”"** | `[46]` **Paskal Beniwoll**: "“I am doing my best to ensure th..."<br>`[181]` **Ciara Walda**: "“In other words, rural citizens ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] == false` | *Brak zmian stanu* | `[40]` **Paskal Beniwoll**: "“We have 31,594 doctors and 73,6..." |
| `[17]` | **"“How many hospital beds are there per ten thousand citizens?”"** | `[46]` **Paskal Beniwoll**: "“I am doing my best to ensure th..."<br>`[181]` **Ciara Walda**: "“In other words, rural citizens ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] == false` | *Brak zmian stanu* | `[41]` **Paskal Beniwoll**: "“There are ten beds per ten thou..." |
| `[18]` | **"“What's the life expectancy and mortality rates?”"** | `[46]` **Paskal Beniwoll**: "“I am doing my best to ensure th..."<br>`[181]` **Ciara Walda**: "“In other words, rural citizens ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] == false` | *Brak zmian stanu* | `[42]` **Paskal Beniwoll**: "“Our life expectancy is 65 years..." |
| `[28]` | **"“Tell me about the difference between urban and rural education.”"** | `[70]` **Ciara Walda**: "“My highest priority is to get e..."<br>`[128]` **Ciara Walda**: "“I think there needs to be a cha..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] == false` | *Brak zmian stanu* | `[45]` **Ciara Walda**: "“Urban areas have three times th..." |
| `[29]` | **"“What is the literacy rate of Sordland?”"** | `[70]` **Ciara Walda**: "“My highest priority is to get e..."<br>`[128]` **Ciara Walda**: "“I think there needs to be a cha..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] == false` | *Brak zmian stanu* | `[44]` **Ciara Walda**: "“The literacy rate of Sordland i..." |
| `[33]` | **"“How many students and teachers do we have?”"** | `[70]` **Ciara Walda**: "“My highest priority is to get e..."<br>`[128]` **Ciara Walda**: "“I think there needs to be a cha..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] == false` | *Brak zmian stanu* | `[43]` **Ciara Walda**: "“Currently there are about five ..." |
| `[48]` | **"“Good point, Ciara. Paskal?”"** | `[47]` **Ciara Walda**: "“I don't want to be rude, but ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Paskal Beniwoll**: "“The data shows that per ten tho..." |
| `[49]` | **"“Let's not interrupt each other.”"** | `[47]` **Ciara Walda**: "“I don't want to be rude, but ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Paskal Beniwoll**: "“That's not a problem. The numbe..." |
| `[54]` | **"“I want to hear about the healthcare system.”"** | `[296]` **Player**: "“Thank you, Ciara. I can fill in..." | `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health"] == false` | *Brak zmian stanu* | `[149]` **Paskal Beniwoll**: "“As you wish, Mr. President.”" |
| `[64]` | **"“I expect nothing but your best efforts to improve the situation.”"** | `[65]` **Ciara Walda**: "“Those numbers are saddening ind..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Paskal Beniwoll**: "“We are working very hard on imp..." |
| `[66]` | **"“I agree. We must do everything we can.”"** | `[65]` **Ciara Walda**: "“Those numbers are saddening ind..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Paskal Beniwoll**: "“We are working very hard on imp..." |
| `[74]` | **"“We should keep striving to make education available for all.”"** | `[73]` **Paskal Beniwoll**: "“Sordland is full of young and b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Ciara Walda**: "“I think there needs to be a cha..." |
| `[75]` | **"“Our country is indeed full of potential.”"** | `[73]` **Paskal Beniwoll**: "“Sordland is full of young and b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Ciara Walda**: "“I think there needs to be a cha..." |
| `[79]` | **"“I can imagine teachers not preferring desolate areas.”"** | `[45]` **Ciara Walda**: "“Urban areas have three times th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Ciara Walda**: "“Salaries for teachers are very ..." |
| `[80]` | **"“That's not a very good ratio.”"** | `[45]` **Ciara Walda**: "“Urban areas have three times th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Ciara Walda**: "“This is one of the most importa..." |
| `[84]` | **"“I want to hear about the education system.”"** | `[295]` **Player**: "“Thank you, Paskal. Your in-dept..." | `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education"] == true) == false` | *Brak zmian stanu* | `[146]` **Ciara Walda**: "“With pleasure.”" |
| `[86]` | **"“What is it, Ciara?”"** | `[69]` **Narrator**: "Ciara stood up and moved towards..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Ciara Walda**: "“Look at this impoverished city...." |
| `[87]` | **"“I hope both of you are preparing your reform plans for improvement.”"** | `[69]` **Narrator**: "Ciara stood up and moved towards..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "She ignored my statement." |
| `[91]` | **"“Paskal, what do you think?”"** | `[90]` **Ciara Walda**: "“This is not just about Soll or ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Paskal Beniwoll**: "“There is not much to be said, s..." |
| `[92]` | **"“We are here to change that trend and to provide for the people.”"** | `[90]` **Ciara Walda**: "“This is not just about Soll or ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Ciara Walda**: "“That remains to be seen. I'm wo..." |
| `[93]` | **"“Tarquin Soll did more for the country than any of us.”"** | `[90]` **Ciara Walda**: "“This is not just about Soll or ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Ciara Walda**: "“Really? I must agree to disagre..." |
| `[105]` | **""Interesting. I thought our problem was with the quality of education in Sordland ..."** | `[104]` **Ciara Walda**: "“By building schools in these le..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Ciara Walda**: "“Our statistics show the dispari..." |
| `[106]` | **"“Improving the situation in rural areas is indeed a good idea.”"** | `[104]` **Ciara Walda**: "“By building schools in these le..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Ciara Walda**: "“It's an investment in the futur..." |
| `[111]` | **"“What are you working towards, Paskal?”"** | `[130]` **Ciara Walda**: "“One way or another, we need cha..."<br>`[110]` **Ciara Walda**: "“Yes, but at what cost? I'm not ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan"] == false` | *Brak zmian stanu* | `[112]` **Paskal Beniwoll**: "“I personally want to improve th..." |
| `[114]` | **"“Isn't access to healthcare in rural areas an issue?”"** | `[113]` **Paskal Beniwoll**: "“I can do more with an increased..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Paskal Beniwoll**: "“Access is an issue, but not as ..." |
| `[115]` | **"“Improving the quality of healthcare in less fortunate areas should be our highest..."** | `[113]` **Paskal Beniwoll**: "“I can do more with an increased..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Paskal Beniwoll**: "“Exactly. It would directly dimi..." |
| `[118]` | **"“Lileas Graf will take care of crime. She's an expert on the subject.""** | `[6]` **Ciara Walda**: "“Hopelessness and a lack of oppo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Paskal Beniwoll**: "“She is certainly a proven admin..." |
| `[119]` | **"“Those issues must be tackled from different directions. We need to engage it holi..."** | `[6]` **Ciara Walda**: "“Hopelessness and a lack of oppo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Paskal Beniwoll**: "“I'm planning to help by using a..." |
| `[120]` | **"“If only we could stop the recession, create jobs and growth...”"** | `[6]` **Ciara Walda**: "“Hopelessness and a lack of oppo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Paskal Beniwoll**: "“The economic situation does pla..." |
| `[131]` | **"“Tell me more about your plans, Ciara.”"** | `[130]` **Ciara Walda**: "“One way or another, we need cha..."<br>`[110]` **Ciara Walda**: "“Yes, but at what cost? I'm not ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan"] == false` | *Brak zmian stanu* | `[103]` **Ciara Walda**: "“My plans require an increase in..." |
| `[155]` | **"“My intention is to help the working class.”"** | `[202]` **Ciara Walda**: "“Most of the people living in Na..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Ciara Walda**: "“I am glad we see eye to eye on ..." |
| `[168]` | **"“We knew less fortunate families, even though we belonged to the middle class ours..."** | `[161]` **Paskal Beniwoll**: "“Well put, Ms. Walda. I don't ne..." | `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true` | *Brak zmian stanu* | `[170]` **Paskal Beniwoll**: "“So, you could at least sympathi..." |
| `[169]` | **""Thankfully, we never had any problems with money.”"** | `[161]` **Paskal Beniwoll**: "“Well put, Ms. Walda. I don't ne..." | `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true` | *Brak zmian stanu* | `[172]` **Paskal Beniwoll**: "“You know the saying; you don't ..." |
| `[174]` | **"“It feels like the cards are stacked against you.”"** | `[159]` **Paskal Beniwoll**: "“Well put, Ms. Walda. I don't ne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Paskal Beniwoll**: "“Exactly. It feels as if there i..." |
| `[176]` | **"“We have all gone through difficult times.”"** | `[159]` **Paskal Beniwoll**: "“Well put, Ms. Walda. I don't ne..."<br>`[161]` **Paskal Beniwoll**: "“Well put, Ms. Walda. I don't ne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Paskal Beniwoll**: "“True but some lives are more di..." |
| `[180]` | **"“The capital must be prioritised towards the resources that matter the most.”"** | `[6]` **Ciara Walda**: "“Hopelessness and a lack of oppo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Ciara Walda**: "“Sordland needs more schools ful..." |
| `[183]` | **"“Let's not get into an ideological debate. We need to focus on the issues.”"** | `[90]` **Ciara Walda**: "“This is not just about Soll or ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Ciara Walda**: "“One cannot be separated from th..." |
| `[191]` | **"“We are elected representatives of our people and we will prioritize their needs.”"** | `[132]` **Ciara Walda**: "“My expectation from our governm..." | `(Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true) == false` | *Brak zmian stanu* | `[194]` **Paskal Beniwoll**: "“That's reassuring to hear.”" |
| `[192]` | **"“There are other significant issues that we need to focus on, like security.”"** | `[132]` **Ciara Walda**: "“My expectation from our governm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Paskal Beniwoll**: "“There have been a lot of negati..." |
| `[193]` | **"“I appreciate your briefings and plans. We will re-convene at the budget meeting.”"** | `[132]` **Ciara Walda**: "“My expectation from our governm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Paskal Beniwoll**: "“It was a pleasure.”" |
| `[200]` | **"“Whatever. I'd much rather be in Holsord right now.”"** | `[202]` **Ciara Walda**: "“Most of the people living in Na..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Ciara Walda**: "“Our presence here will show tha..." |
| `[205]` | **"“We can't really blame the companies. That's just how they work.”"** | `[202]` **Ciara Walda**: "“Most of the people living in Na..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Ciara Walda**: "“Yes we can. Similar companies a..." |
| `[209]` | **"“I personally promised that our health systems were to be improved in our term. I ..."** | `[113]` **Paskal Beniwoll**: "“I can do more with an increased..." | `Variable["BaseGame.Promise_TermFocus_Health"] == true` | *Brak zmian stanu* | `[213]` **Paskal Beniwoll**: "“This is one of the reasons I'm ..." |
| `[217]` | **"“Our election mandate was to improve education. We will deliver on this.”"** | `[104]` **Ciara Walda**: "“By building schools in these le..." | `Variable["BaseGame.Promise_TermFocus_Education"] == true` | *Brak zmian stanu* | `[218]` **Ciara Walda**: "“This brings hope to the table, ..." |
| `[222]` | **"“Welfare is my top priority. Both education and health will be improved significan..."** | `[132]` **Ciara Walda**: "“My expectation from our governm..." | `Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true` | *Brak zmian stanu* | `[224]` **Paskal Beniwoll**: "“The people will rejoice if they..." |
| `[226]` | **"“I agree. We need to improve the standards for our workers.”"** | `[227]` **Paskal Beniwoll**: "“Mr. Clavin has already backed m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Paskal Beniwoll**: "“Exactly. Sordland must provide ..." |
| `[228]` | **"“There is always room for improvement and it is good to hear that you are pushing ..."** | `[227]` **Paskal Beniwoll**: "“Mr. Clavin has already backed m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Paskal Beniwoll**: "“Appreciate the kind words, Mr. ..." |
| `[229]` | **"“We shouldn't upset the businesses who are already struggling to stay afloat in th..."** | `[227]` **Paskal Beniwoll**: "“Mr. Clavin has already backed m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Paskal Beniwoll**: "“This wouldn't alter the balance..." |
| `[243]` | **"“Minister Walda, I have bailed out people in need instead of businesses. Trust me,..."** | `[132]` **Ciara Walda**: "“My expectation from our governm..." | `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true` | *Brak zmian stanu* | `[241]` **Ciara Walda**: "“It has shown your dedication, b..." |
| `[245]` | **"“I would be very interested in supporting it once it is finished.”"** | `[244]` **Paskal Beniwoll**: "“So, will you back the bill when..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Paskal Beniwoll**: "“I'm relieved to hear that.”" |
| `[247]` | **"“To make a decision, I would need to evaluate the contents in detail.”"** | `[244]` **Paskal Beniwoll**: "“So, will you back the bill when..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[248]` **Paskal Beniwoll**: "“Understandable. You will receiv..." |
| `[254]` | **"“Sounds like a costly bill for such a low-priority issue.""** | `[227]` **Paskal Beniwoll**: "“Mr. Clavin has already backed m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Paskal Beniwoll**: "“If the very lives of our worker..." |
| `[256]` | **"“I am not necessarily opposed to it. I'm sceptical.”"** | `[233]` **Ciara Walda**: "“Why would you turn away from th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Ciara Walda**: "“This is worth considering, Mr. ..." |
| `[257]` | **"“Times have changed.”"** | `[233]` **Ciara Walda**: "“Why would you turn away from th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Ciara Walda**: "“One would hope ideals haven't c..." |
| `[262]` | **"“I don't think this is the time for such a change. We have bigger issues to fix.”"** | `[244]` **Paskal Beniwoll**: "“So, will you back the bill when..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Paskal Beniwoll**: "“Maybe by the time the bill is d..." |
| `[293]` | **"“I believe that is everything.”"** | `[295]` **Player**: "“Thank you, Paskal. Your in-dept..." | `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education"] == true` | *Brak zmian stanu* | `[69]` **Narrator**: "Ciara stood up and moved towards..." |
| `[294]` | **"“I believe that is everything.”"** | `[296]` **Player**: "“Thank you, Ciara. I can fill in..." | `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health"] == false) == false` | *Brak zmian stanu* | `[69]` **Narrator**: "Ciara stood up and moved towards..." |
| `[295]` | **"“Thank you, Paskal. Your in-depth briefing is much appreciated.”"** | `[46]` **Paskal Beniwoll**: "“I am doing my best to ensure th..."<br>`[181]` **Ciara Walda**: "“In other words, rural citizens ..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] == true` | `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health"] ...` | `[293]` **Player**: "“I believe that is everything.”"<br>`[84]` **Player**: "“I want to hear about the educat..." |
| `[296]` | **"“Thank you, Ciara. I can fill in the blanks from here.”"** | `[70]` **Ciara Walda**: "“My highest priority is to get e..."<br>`[128]` **Ciara Walda**: "“I think there needs to be a cha..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] == true` | `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education...` | `[54]` **Player**: "“I want to hear about the health..."<br>`[294]` **Player**: "“I believe that is everything.”" |
| `[305]` | **""I've been wondering about that, actually.""** | `[304]` **Ciara Walda**: ""Meanwhile, those of us who don'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Paskal Beniwoll**: ""All right, Ciara. You've made y..." |
| `[306]` | **""Leave Lucian out of this.""** | `[304]` **Ciara Walda**: ""Meanwhile, those of us who don'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Paskal Beniwoll**: ""All right, Ciara. You've made y..." |
| `[307]` | **""You've veered off-topic, Ms. Walda.""** | `[304]` **Ciara Walda**: ""Meanwhile, those of us who don'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[309]` **Ciara Walda**: ""Mr. Beniwoll asked. I answered."" |
| `[308]` | **""I agree with you completely. Sordland's women deserve better.""** | `[304]` **Ciara Walda**: ""Meanwhile, those of us who don'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Ciara Walda**: ""I'm glad to hear that."" |
| `[317]` | **""What good is job creation if the workers are treated poorly? Of course I'll deman..."** | `[314]` **Paskal Beniwoll**: ""Nevertheless, it's worth acknow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Paskal Beniwoll**: ""I covered this topic extensivel..." |
| `[318]` | **""I know how slippery Alphonso can be. Bringing this up with him will indeed be a c..."** | `[314]` **Paskal Beniwoll**: ""Nevertheless, it's worth acknow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Paskal Beniwoll**: ""Try a diplomatic approach. Deep..." |
| `[319]` | **""If we do this right, we can find a solution that advances both the economy and th..."** | `[314]` **Paskal Beniwoll**: ""Nevertheless, it's worth acknow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[322]` **Paskal Beniwoll**: ""That would be quite the impress..." |
| `[325]` | **""In this world, nothing is truly free. I wouldn't anticipate anything less.""** | `[324]` **Ciara Walda**: "“It would be difficult to imagin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[328]` **Ciara Walda**: "“We must be cautious about these..." |
| `[326]` | **""Gasom relies on us just as we rely on them. We can find a path to compromise.""** | `[324]` **Ciara Walda**: "“It would be difficult to imagin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Ciara Walda**: "“The middle way often sways peri..." |
| `[327]` | **""Gasom has profited from the labor of workers for far too long. It's time for them..."** | `[324]` **Ciara Walda**: "“It would be difficult to imagin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[330]` **Ciara Walda**: "“We shouldn't settle for anythin..." |
| `[334]` | **""My foremost priorities lie in improving the economy. Once that is achieved, upwar..."** | `[314]` **Paskal Beniwoll**: ""Nevertheless, it's worth acknow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Paskal Beniwoll**: ""Economic improvements don't alw..." |
| `[336]` | **""Considering our need for greater energy security, we might find ourselves forced ..."** | `[324]` **Ciara Walda**: "“It would be difficult to imagin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Ciara Walda**: ""Remember, these 'collaborations..." |
| `[339]` | **""I'm encouraged by the willingness of Mr. Manger and Mr. Alphonso to meet with me...."** | `[332]` **Paskal Beniwoll**: ""Ideology should never get in th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Paskal Beniwoll**: "“We shall keep you no longer. Th..." |
| `[340]` | **""I disagree. Only by holding firm to my convictions can I bring about the change S..."** | `[332]` **Paskal Beniwoll**: ""Ideology should never get in th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Paskal Beniwoll**: "“We shall keep you no longer. Th..." |
| `[341]` | **""I'm skeptical that these discussions with Gasom will lead to any meaningful chang..."** | `[332]` **Paskal Beniwoll**: ""Ideology should never get in th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Paskal Beniwoll**: "“We shall keep you no longer. Th..." |
| `[342]` | **""I can't promise anything to either of you. I've got to get a grasp of the situati..."** | `[332]` **Paskal Beniwoll**: ""Ideology should never get in th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Paskal Beniwoll**: "“We shall keep you no longer. Th..." |
| `[343]` | **""No need for the briefing, I'm up to speed.""** | `[9]` **Narrator**: "The meeting room was already pre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Ciara Walda**: "“Oh, okay.”" |

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
  - -> `[199]` (*Narrator: "I arrived at the meeting room for my talk with Ciara and ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
> "“Such a spectacular view.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Ciara Walda, the Minister of Education, joined us on the ..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Ciara Walda, the Minister of Education, joined us on the balcony, dressed in a sky-blue pantsuit. Her preference for trousers over dresses had made her the subject of much Palace gossip, but it didn't seem to bother her in the slightest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Ciara Walda: "“Spectacular indeed. But if you look in the opposite dire..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "While I was mesmerized by the scenery, Paskal Beniwoll walked up to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "My Minister of Health was, ironically, somewhat portly, h..."*)

### Węzeł `[6]`
Mówca: **Ciara Walda**
> "“Hopelessness and a lack of opportunities can drive people to extreme solutions. We're seeing increased crime, domestic violence, and yes, rising inequality between men and women...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: "“Lileas Graf will take care of crime. She's an expert on ..."*)
  - -> `[119]` (*Player: "“Those issues must be tackled from different directions. ..."*)
  - -> `[120]` (*Player: "“If only we could stop the recession, create jobs and gro..."*)
  - -> `[180]` (*Player: "“The capital must be prioritised towards the resources th..."*)

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
> "“There is another subject I want to mention. I have been working on improving the rights of workers in our country and have proposed a draft bill that is currently being reviewed by our party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Paskal Beniwoll: "“Mr. Clavin has already backed me and given his support. ..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "We headed back inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "The meeting room was already prepared for state business...."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "The meeting room was already prepared for state business. Small gifts for each of us had been placed on the table by the municipality. We took our seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“Let's start with your health overview, Paskal.”"*)
  - -> `[11]` (*Player: "“Tell me more about your plans, Ciara.”"*)
  - -> `[343]` (*Player: ""No need for the briefing, I'm up to speed.""*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Let's start with your health overview, Paskal.”"]** — Mówca: **Player**
> "“Let's start with your health overview, Paskal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Paskal Beniwoll: "“As you wish, Mr. President.”"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Tell me more about your plans, Ciara.”"]** — Mówca: **Player**
> "“Tell me more about your plans, Ciara.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Ciara Walda: "“With pleasure.”"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Paskal Beniwoll: "“As you wish, Mr. President.”"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Paskal Beniwoll: "“As you wish, Mr. President.”"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Education = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Health == false"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Healthcare Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurse..."*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == false"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortalit..."*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurse..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Education Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education_Students ..."*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy ..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRura..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education_Students ..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“How many doctors and nurses are employed?”"]** — Mówca: **Player**
> "“How many doctors and nurses are employed?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] == false`
- **Kontekst wejściowy (poprzednik):** `[46]` (Paskal Beniwoll), `[181]` (Ciara Walda), `[127]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Paskal Beniwoll: "“We have 31,594 doctors and 73,680 nurses working for the..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“How many hospital beds are there per ten thousand citizens?”"]** — Mówca: **Player**
> "“How many hospital beds are there per ten thousand citizens?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] == false`
- **Kontekst wejściowy (poprzednik):** `[46]` (Paskal Beniwoll), `[181]` (Ciara Walda), `[127]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Paskal Beniwoll: "“There are ten beds per ten thousand citizens. Compared t..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“What's the life expectancy and mortality rates?”"]** — Mówca: **Player**
> "“What's the life expectancy and mortality rates?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] == false`
- **Kontekst wejściowy (poprzednik):** `[46]` (Paskal Beniwoll), `[181]` (Ciara Walda), `[127]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Paskal Beniwoll: "“Our life expectancy is 65 years. The infant mortality ra..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurse..."*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNur..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: "“How many doctors and nurses are employed?”"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == false"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == fa..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: "“How many hospital beds are there per ten thousand citize..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortalit..."*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortal..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: "“What's the life expectancy and mortality rates?”"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Tell me about the difference between urban and rural education.”"]** — Mówca: **Player**
> "“Tell me about the difference between urban and rural education.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] == false`
- **Kontekst wejściowy (poprzednik):** `[70]` (Ciara Walda), `[128]` (Ciara Walda), `[77]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Ciara Walda: "“Urban areas have three times the number of schools per t..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“What is the literacy rate of Sordland?”"]** — Mówca: **Player**
> "“What is the literacy rate of Sordland?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] == false`
- **Kontekst wejściowy (poprzednik):** `[70]` (Ciara Walda), `[128]` (Ciara Walda), `[77]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Ciara Walda: "“The literacy rate of Sordland is at eighty percent. This..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy ..."*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_PSnW_Listened_Education_Literac..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "“What is the literacy rate of Sordland?”"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[33]`
**[WYBÓR GRACZA: "“How many students and teachers do we have?”"]** — Mówca: **Player**
> "“How many students and teachers do we have?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] == false`
- **Kontekst wejściowy (poprzednik):** `[70]` (Ciara Walda), `[128]` (Ciara Walda), `[77]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Ciara Walda: "“Currently there are about five million students. Three m..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRura..."*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRu..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: "“Tell me about the difference between urban and rural edu..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Education_Students == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education_Students ..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_PSnW_Listened_Education_Student..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Education_Students == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: "“How many students and teachers do we have?”"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_PSnW_Listened_Education_Students == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
> "“We have 31,594 doctors and 73,680 nurses working for the Ministry of Health. This is a high number. What I think is--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Ciara Walda: "“I don't want to be rude, but out of those numbers. how m..."*)

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
> "“There are ten beds per ten thousand citizens. Compared to most of our neighbors, this is a very good number.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Paskal Beniwoll: "“Our amount of beds is higher than the countries of Agnol..."*)

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
> "“Our life expectancy is 65 years. The infant mortality rate is a worrying 121 per one thousand births, while our maternal mortality is at 5 per thousand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Paskal Beniwoll: "“I assure you that we are doing everything we can to save..."*)

### Węzeł `[43]`
Mówca: **Ciara Walda**
> "“Currently there are about five million students. Three million in primary education, one million in secondary and one million in tertiary. There are 155,316 teachers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Paskal Beniwoll: "“Sordland is full of young and bright minds.”"*)

### Węzeł `[44]`
Mówca: **Ciara Walda**
> "“The literacy rate of Sordland is at eighty percent. This is a very good indicator for future growth, but it needs to increase. It's also far lower among girls than boys.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Paskal Beniwoll: "“If I remember correctly, the most illiterate areas are B..."*)

### Węzeł `[45]`
Mówca: **Ciara Walda**
> "“Urban areas have three times the number of schools per ten thousand people compared to rural areas. Rural areas also suffer from a lack of teachers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: "“I can imagine teachers not preferring desolate areas.”"*)
  - -> `[80]` (*Player: "“That's not a very good ratio.”"*)

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
> "“I am doing my best to ensure that citizens of all ages receive the best healthcare they can. I also personally want to solve our high infant and maternal mortality problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "Healthcare Hub"*)

### Węzeł `[47]`
Mówca: **Ciara Walda**
> "“I don't want to be rude, but out of those numbers. how many are in urban and in rural areas?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "“Good point, Ciara. Paskal?”"*)
  - -> `[49]` (*Player: "“Let's not interrupt each other.”"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Good point, Ciara. Paskal?”"]** — Mówca: **Player**
> "“Good point, Ciara. Paskal?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Paskal Beniwoll: "“The data shows that per ten thousand people in urban are..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“Let's not interrupt each other.”"]** — Mówca: **Player**
> "“Let's not interrupt each other, please.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Paskal Beniwoll: "“That's not a problem. The number of doctors per ten thou..."*)

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
> "“That's not a problem. The number of doctors per ten thousand citizens is far lower in rural areas compared to urban areas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Ciara Walda: "“In other words, rural citizens with medical emergencies ..."*)

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
> "“The data shows that per ten thousand people in urban areas there are about eleven doctors, while in rural areas there are only three.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Ciara Walda: "“In other words, rural citizens with medical emergencies ..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "Jump to: [Healthcare Hub]"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Healthcare Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "Healthcare Hub"*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "“I want to hear about the healthcare system.”"]** — Mówca: **Player**
> "“I want to hear about the healthcare system.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health"] == false`
- **Kontekst wejściowy (poprzednik):** `[296]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "Jump to: [Paskal Beniwoll: "“As you wish, Mr. President.”"]"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Education_Students == true || BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy == true || BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education_Students ..."*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_PSnW_Listened_Education_Student..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Education_Students == true || BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy == true || BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Player: "“Thank you, Ciara. I can fill in the blanks from here.”"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_PSnW_Listened_Education_Students == true || BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy == true || BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses == true || BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == true || BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurse..."*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNur..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses == true || BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == true || BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Player: "“Thank you, Paskal. Your in-depth briefing is much apprec..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses == true || BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds == true || BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
> "“Our amount of beds is higher than the countries of Agnolia and Wehlen, but we obviously can't match Lespia or Valgsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Ciara Walda: "“Agnolia and Wehlen should hardly be used as a standard, ..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "Jump to: [Healthcare Hub]"*)

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
> "“I assure you that we are doing everything we can to save mothers and their newborns.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Ciara Walda: "“Those numbers are saddening indeed.”"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“I expect nothing but your best efforts to improve the situation.”"]** — Mówca: **Player**
> "“I expect nothing but your best efforts to improve the situation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Paskal Beniwoll: "“We are working very hard on improving the quality of the..."*)

### Węzeł `[65]`
Mówca: **Ciara Walda**
> "“Those numbers are saddening indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“I agree. We must do everything we can.”"*)
  - -> `[64]` (*Player: "“I expect nothing but your best efforts to improve the si..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“I agree. We must do everything we can.”"]** — Mówca: **Player**
> "“I agree. We must do everything we can.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Paskal Beniwoll: "“We are working very hard on improving the quality of the..."*)

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
> "“We are working very hard on improving the quality of the services.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortalit..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "Jump to: [Healthcare Hub]"*)

### Węzeł `[69]`
Mówca: **Narrator**
> "Ciara stood up and moved towards the window. She took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: "“What is it, Ciara?”"*)
  - -> `[87]` (*Player: "“I hope both of you are preparing your reform plans for i..."*)

### Węzeł `[70]`
Mówca: **Ciara Walda**
> "“My highest priority is to get enough funding to be able to build schools in rural areas while I cleanse our educational system of its nationalistic indoctrination and sexist teachings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "Education Hub"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Education Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "Education Hub"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Education_Students = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "Jump to: [Education Hub]"*)

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
> "“Sordland is full of young and bright minds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "“We should keep striving to make education available for ..."*)
  - -> `[75]` (*Player: "“Our country is indeed full of potential.”"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“We should keep striving to make education available for all.”"]** — Mówca: **Player**
> "“We should keep striving to make education available for all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Ciara Walda: "“I think there needs to be a change in what is being taug..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Our country is indeed full of potential.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Ciara Walda: "“I think there needs to be a change in what is being taug..."*)

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
> "“If I remember correctly, the most illiterate areas are Bergia and Agnland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Ciara Walda: "“That is correct. Although Lachaven skews the statistics ..."*)

### Węzeł `[77]`
Mówca: **Ciara Walda**
> "“That is correct. Although Lachaven skews the statistics for the Nargis region, which also has a vast number of illiterate citizens. This underlines my point about the lack of access to education.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy ..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "Jump to: [Education Hub]"*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“I can imagine teachers not preferring desolate areas.”"]** — Mówca: **Player**
> "“I can imagine teachers not preferring desolate areas for work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Ciara Walda: "“Salaries for teachers are very low here. We need to incr..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“That's not a very good ratio.”"]** — Mówca: **Player**
> "“That's not a very good ratio. The situation is worse than expected.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Ciara Walda: "“This is one of the most important problems we face, if n..."*)

### Węzeł `[81]`
Mówca: **Ciara Walda**
> "“This is one of the most important problems we face, if not the most important. A huge part of the population is forgotten in terms of welfare.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRura..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "Jump to: [Education Hub]"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Health = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education == true"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“I want to hear about the education system.”"]** — Mówca: **Player**
> "“I want to hear about the education system.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[295]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "Jump to: [Ciara Walda: "“With pleasure.”"]"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Ciara Walda: "“With pleasure.”"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Ciara Walda: "“With pleasure.”"*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "“What is it, Ciara?”"]** — Mówca: **Player**
> "“What is it, Ciara?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Ciara Walda: "“Look at this impoverished city. The streets full of poth..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "“I hope both of you are preparing your reform plans for improvement.”"]** — Mówca: **Player**
> "“I hope both of you are preparing your reform plans for improvement.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "She ignored my statement."*)

### Węzeł `[88]`
Mówca: **Ciara Walda**
> "“Look at this impoverished city. The streets full of potholes, the hospital barely functioning, the school half open.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Ciara Walda: "“This is not just about Soll or even Alphonso failing. Th..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "She ignored my statement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Ciara Walda: "“Look at this impoverished city. The streets full of poth..."*)

### Węzeł `[90]`
Mówca: **Ciara Walda**
> "“This is not just about Soll or even Alphonso failing. This decay in Sordland's forgotten regions has been going on for many decades due to structural corruption, which is fueled by capitalism.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“Tarquin Soll did more for the country than any of us.”"*)
  - -> `[183]` (*Player: "“Let's not get into an ideological debate. We need to foc..."*)
  - -> `[92]` (*Player: "“We are here to change that trend and to provide for the ..."*)
  - -> `[91]` (*Player: "“Paskal, what do you think?”"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Paskal, what do you think?”"]** — Mówca: **Player**
> "“Paskal, what do you think?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Paskal Beniwoll: "“There is not much to be said, sir. I agree with Ciara, b..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“We are here to change that trend and to provide for the people.”"]** — Mówca: **Player**
> "“We are here to change that trend and to provide for the people.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Ciara Walda: "“That remains to be seen. I'm working on the new educatio..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“Tarquin Soll did more for the country than any of us.”"]** — Mówca: **Player**
> "“Tarquin Soll did more for the country than any of us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Ciara Walda: "“Really? I must agree to disagree then.”"*)

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
> "“There is not much to be said, sir. I agree with Ciara, but it is also Gus Manger's job to improve these areas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Ciara Walda: "“It's the responsibility of each and every one of us.”"*)

### Węzeł `[95]`
Mówca: **Ciara Walda**
> "“It's the responsibility of each and every one of us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Ciara sat back down and sighed."*)

### Węzeł `[96]`
Mówca: **Ciara Walda**
> "“That remains to be seen. I'm working on the new education system, and your support would be welcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Ciara sat back down and sighed."*)

### Węzeł `[97]`
Mówca: **Ciara Walda**
> "“Really? I must agree to disagree then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Ciara sat back down and sighed."*)

### Węzeł `[98]`
Mówca: **Ciara Walda**
> "“Did we cover all the necessary subjects?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Paskal Beniwoll: ""One more thing. I wish to raise my concerns about your s..."*)

### Węzeł `[99]`
Mówca: **Ciara Walda**
> "“I do hope we won't repeat the same mistakes again and again. Have a good day, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "The ministers left, and I prepared to leave for other off..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "The ministers left, and I prepared to leave for other official business in the city. The Gasom meeting was just one of the many events I was scheduled to attend over the next few days."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "As I made my way out, the weather was noticeably cold, bu..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "By looking at the citizens’ attire, it was easy to understand the current state of Narbel. Some people were wearing clothes a few sizes too large. Some kids did not even have shoes. Yet there was hope in their eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "They were excited to see their president in their city."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_PSnW_Overview = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_PSnW_Overview"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[103]`
Mówca: **Ciara Walda**
> "“My plans require an increase in the government budget. I aim to solve the problems we highlighted with the allocated money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Ciara Walda: "“By building schools in these less fortunate rural areas ..."*)

### Węzeł `[104]`
Mówca: **Ciara Walda**
> "“By building schools in these less fortunate rural areas and through fundamental changes to the education system, I will unlock the potential of all our children. Boys and girls alike.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: "“Improving the situation in rural areas is indeed a good ..."*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)
  - -> `[105]` (*Player: ""Interesting. I thought our problem was with the quality ..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Interesting. I thought our problem was with the quality of education in Sordland as a whole.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Ciara Walda: "“Our statistics show the disparity between urban and rura..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Improving the situation in rural areas is indeed a good idea.”"]** — Mówca: **Player**
> "“Improving the situation in rural areas is indeed a good idea.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Ciara Walda: "“It's an investment in the future of Sordland. Imagine un..."*)

### Węzeł `[107]`
Mówca: **Ciara Walda**
> "“It's an investment in the future of Sordland. Imagine unlocking the full, untapped potential of our youth. The knowledge and wealth they will generate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Paskal Beniwoll: "“Wouldn't a promotion of private education help create ad..."*)

### Węzeł `[108]`
Mówca: **Ciara Walda**
> "“Our statistics show the disparity between urban and rural education. We can either do something about it, or wait until things get worse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Paskal Beniwoll: "“Wouldn't a promotion of private education help create ad..."*)

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
> "“Wouldn't a promotion of private education help create additional funds?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Ciara Walda: "“Yes, but at what cost? I'm not a supporter of the privat..."*)

### Węzeł `[110]`
Mówca: **Ciara Walda**
> "“Yes, but at what cost? I'm not a supporter of the private sector in education. At the end of the day, they are focused on profit first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan = true"*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“What are you working towards, Paskal?”"]** — Mówca: **Player**
> "“What are you working towards, Paskal?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan"] == false`
- **Kontekst wejściowy (poprzednik):** `[130]` (Ciara Walda), `[110]` (Ciara Walda), `[187]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Paskal Beniwoll: "“I personally want to improve the low quality of healthca..."*)

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
> "“I personally want to improve the low quality of healthcare in the rural areas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Paskal Beniwoll: "“So, I created draft plans to increase the salary of doct..."*)

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
> "“I can do more with an increased budget. Additionally, a privatization plan to promote private investments in the healthcare system could allocate extra funds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)
  - -> `[114]` (*Player: "“Isn't access to healthcare in rural areas an issue?”"*)
  - -> `[115]` (*Player: "“Improving the quality of healthcare in less fortunate ar..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Isn't access to healthcare in rural areas an issue?”"]** — Mówca: **Player**
> "“Isn't access to healthcare in rural areas an issue?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Paskal Beniwoll: "“Access is an issue, but not as critical as improving the..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Improving the quality of healthcare in less fortunate areas should be our highest priority.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Paskal Beniwoll: "“Exactly. It would directly diminish our depressingly hig..."*)

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
> "“Access is an issue, but not as critical as improving the quality in these areas. The lack of experienced personnel and equipment causes poor treatment, resulting in many deaths.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Paskal Beniwoll: "“I do hope to create competition and increase the quality..."*)

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
> "“Exactly. It would directly diminish our depressingly high infant and maternal mortality situation. Besides, such a push would also have economic benefits.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Paskal Beniwoll: "“I do hope to create competition and increase the quality..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Lileas Graf will take care of crime. She's an expert on the subject.""]** — Mówca: **Player**
> "“Lileas Graf will take care of crime. She's an expert on the subject.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Paskal Beniwoll: "“She is certainly a proven administrator. From what I hea..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“Those issues must be tackled from different directions. We need to engage it holistically.”"]** — Mówca: **Player**
> "“Those issues must be tackled from different directions. We need to engage it holistically.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Paskal Beniwoll: "“I'm planning to help by using an increased budget to imp..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“If only we could stop the recession, create jobs and growth...”"]** — Mówca: **Player**
> "“If only we could stop the recession, create jobs and growth...”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Paskal Beniwoll: "“The economic situation does play a huge role in living s..."*)

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
> "“I'm planning to help by using an increased budget to improve the quality of healthcare.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Ciara Walda: ""That could prove useful, but we need to be doing a lot m..."*)

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
> "“She is certainly a proven administrator. From what I heard she reduced crime in Arvory by 40% during her mayoral term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Ciara Walda: "“I don't think brute force will get us anywhere. Look at ..."*)

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
> "“The economic situation does play a huge role in living standards. Our urban and rural disparities are stark, and the recession hit the weakest harder.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Ciara Walda: "“We can't fix the economy by ourselves. We have to educat..."*)

### Węzeł `[124]`
Mówca: **Ciara Walda**
> "“I don't think brute force will get us anywhere. Look at where the tight grip of Tarquin Soll got us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Paskal Beniwoll: "“There is another subject I want to mention. I have been ..."*)

### Węzeł `[125]`
Mówca: **Ciara Walda**
> ""That could prove useful, but we need to be doing a lot more. Education has similar issues.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Paskal Beniwoll: "“There is another subject I want to mention. I have been ..."*)

### Węzeł `[126]`
Mówca: **Ciara Walda**
> "“We can't fix the economy by ourselves. We have to educate the people and let them create new opportunities too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Paskal Beniwoll: "“There is another subject I want to mention. I have been ..."*)

### Węzeł `[127]`
Mówca: **Ciara Walda**
> "“Agnolia and Wehlen should hardly be used as a standard, but it is good to know we aren't in a massive health crisis. Yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds = true"*)

### Węzeł `[128]`
Mówca: **Ciara Walda**
> "“I think there needs to be a change in what is being taught. We should help children to ask questions and educate themselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education_Students ..."*)

### Węzeł `[129]`
Mówca: **Narrator**
> "Ciara sat back down and sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Ciara Walda: "“One way or another, we need change in Sordland. Greed an..."*)

### Węzeł `[130]`
Mówca: **Ciara Walda**
> "“One way or another, we need change in Sordland. Greed and unchecked capitalism will not magically provide for the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "Plans Hub"*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“Tell me more about your plans, Ciara.”"]** — Mówca: **Player**
> "“Tell me more about your plans, Ciara.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan"] == false`
- **Kontekst wejściowy (poprzednik):** `[130]` (Ciara Walda), `[110]` (Ciara Walda), `[187]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Ciara Walda: "“My plans require an increase in the government budget. I..."*)

### Węzeł `[132]`
Mówca: **Ciara Walda**
> "“My expectation from our government is that we understand and focus on the needs of the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true && BaseGame...."*)
  - -> `[192]` (*Player: "“There are other significant issues that we need to focus..."*)
  - -> `[193]` (*Player: "“I appreciate your briefings and plans. We will re-conven..."*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == false"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == false)"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: "“Tell me more about your plans, Ciara.”"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == false"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == false)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player: "“What are you working towards, Paskal?”"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "Jump to: [Plans Hub]"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "Jump to: [Plans Hub]"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Plans Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == false"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == true ..."*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == false"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Plans Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "Plans Hub"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == true && BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == true ..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == tru..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == true && BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan"] == true  and  Variable["BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Ciara Walda: "“My expectation from our government is that we understand..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan == true && BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan"] == true  and  Variable["BaseGameIsolated.Turn03_PSnW_Listened_CiaraPlan"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[146]`
Mówca: **Ciara Walda**
> "“With pleasure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Ciara Walda: "“Sordish education is free, but we have a very outdated s..."*)

### Węzeł `[147]`
Mówca: **Ciara Walda**
> "“Sordish education is free, but we have a very outdated system that I want to reform. The other important issue is the lack of access to education in rural areas, especially for young girls. Your administration has the power to solve both problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Ciara Walda: "“My highest priority is to get enough funding to be able ..."*)

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
> "“Sordland has a free healthcare system, except for a few private hospitals operating under it. Most of the populace receives adequate treatment. Health issues primarily appear in rural areas due to a lack of quality services.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Paskal Beniwoll: "“I am doing my best to ensure that citizens of all ages r..."*)

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
> "“As you wish, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Paskal Beniwoll: "“Sordland has a free healthcare system, except for a few ..."*)

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
> "“I do hope to create competition and increase the quality of healthcare with the privatization effort.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Ciara Walda: "“But you must realize that privatizing our health care sy..."*)

### Węzeł `[151]`
Mówca: **Ciara Walda**
> "“But you must realize that privatizing our health care system would increase the price of treatment and make access worse for the average citizen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[152]`
Mówca: **Ciara Walda**
> "“Salaries for teachers are very low here. We need to increase their pay to give them more incentive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRura..."*)

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
> "“So, I created draft plans to increase the salary of doctors and to upgrade the equipment of the hospitals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Paskal Beniwoll: "“I can do more with an increased budget. Additionally, a ..."*)

### Węzeł `[154]`
Mówca: **Ciara Walda**
> "“I am glad we see eye to eye on the issue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Ciara Walda: "“If you look past the view, you can see the real problems.”"*)

### Węzeł `[155]`
**[WYBÓR GRACZA: "“My intention is to help the working class.”"]** — Mówca: **Player**
> "“My intention is to help the working class.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Ciara Walda: "“I am glad we see eye to eye on the issue.”"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Paskal Beniwoll: "“Well put, Ms. Walda. I don't need to tell you about my o..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Paskal Beniwoll: "“Well put, Ms. Walda. I don't need to tell you about my o..."*)

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
> "“Well put, Ms. Walda. I don't need to tell you about my own experiences with poverty. And you've been through similar hardships yourself, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player: "“It feels like the cards are stacked against you.”"*)
  - -> `[176]` (*Player: "“We have all gone through difficult times.”"*)

### Węzeł `[160]`
Mówca: **Ciara Walda**
> "“If you look past the view, you can see the real problems.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Ciara Walda: "“Real problems like poverty.”"*)

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
> "“Well put, Ms. Walda. I don't need to tell you about my own experiences with poverty. I'm sure you have similar stories, am I right, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: "“We have all gone through difficult times.”"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Holsord_Middle == true)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player: "“We knew less fortunate families, even though we belonged..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Holsord_Middle == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""Thankfully, we never had any problems with money.”"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[168]`
**[WYBÓR GRACZA: "“We knew less fortunate families, even though we belonged to the middle class ourselves.”"]** — Mówca: **Player**
> "“We knew less fortunate families, even though we belonged to the middle class ourselves.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true`
- **Kontekst wejściowy (poprzednik):** `[161]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Paskal Beniwoll: "“So, you could at least sympathize with the plight of the..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""Thankfully, we never had any problems with money.”"]** — Mówca: **Player**
> "“Thankfully, we never had any problems with money.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Kontekst wejściowy (poprzednik):** `[161]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Paskal Beniwoll: "“You know the saying; you don't know what you have until ..."*)

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
> "“So, you could at least sympathize with the plight of these people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Ciara Walda: "“You don't have to have been born poor to sympathize with..."*)

### Węzeł `[171]`
Mówca: **Ciara Walda**
> "“You don't have to have been born poor to sympathize with the plight of the impoverished. Much as you don't have to have been born a woman to recognize Sordland's need for parity among the sexes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Paskal Beniwoll: "“Parity among the sexes shouldn't be our first priority. ..."*)

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
> "“You know the saying; you don't know what you have until it is taken from you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Ciara Walda: "“You don't have to have been born poor to sympathize with..."*)

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
> "“Exactly. It feels as if there is no way out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Ciara Walda: "“You don't have to have been born poor to sympathize with..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA: "“It feels like the cards are stacked against you.”"]** — Mówca: **Player**
> "“It feels like the cards are stacked against you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Paskal Beniwoll: "“Exactly. It feels as if there is no way out.”"*)

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
> "“True but some lives are more difficult than others. Like ours was, and still is for hundreds of thousands in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Ciara Walda: "“You don't have to have been born poor to sympathize with..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: "“We have all gone through difficult times.”"]** — Mówca: **Player**
> "“We have all gone through difficult times.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Paskal Beniwoll), `[161]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Paskal Beniwoll: "“True but some lives are more difficult than others. Like..."*)

### Węzeł `[177]`
Mówca: **Ciara Walda**
> "“As I was saying -- isn't it about time Holsord addressed this country's real issues? Rather than bowing to the wishes of the hawks and fearmongerers in the establishment, and diverting yet more resources to the military and law enforcement?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Ciara Walda: "“Our welfare, healthcare and education systems have been ..."*)

### Węzeł `[178]`
Mówca: **Ciara Walda**
> "“Our welfare, healthcare and education systems have been decaying since the recession. Sordland's poorer communities are losing hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Ciara Walda: "“Hopelessness and a lack of opportunities can drive peopl..."*)

### Węzeł `[179]`
Mówca: **Ciara Walda**
> "“Sordland needs more schools full of children instead of barracks full of soldiers, more hospitals instead of police stations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true || BaseGame.Pro..."*)

### Węzeł `[180]`
**[WYBÓR GRACZA: "“The capital must be prioritised towards the resources that matter the most.”"]** — Mówca: **Player**
> "“The capital must be prioritised towards the resources that matter the most.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Ciara Walda: "“Sordland needs more schools full of children instead of ..."*)

### Węzeł `[181]`
Mówca: **Ciara Walda**
> "“In other words, rural citizens with medical emergencies have to wait an embarassingly long time before they are treated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurse..."*)

### Węzeł `[182]`
Mówca: **Ciara Walda**
> "“One cannot be separated from the other, Mr. Rayne. The issues stem from the ideology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Ciara sat back down and sighed."*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Let's not get into an ideological debate. We need to focus on the issues.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Ciara Walda: "“One cannot be separated from the other, Mr. Rayne. The i..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Ciara Walda: "“Besides, it wouldn't fit into the planned economy Presid..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Ciara Walda: "“The decision not to promote more state control would cos..."*)

### Węzeł `[187]`
Mówca: **Ciara Walda**
> "“Besides, it wouldn't fit into the planned economy President Rayne has decided to promote.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan = true"*)

### Węzeł `[188]`
Mówca: **Ciara Walda**
> "“The decision not to promote more state control would cost the Sordish people dearly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_PaskalPlan = true"*)

### Węzeł `[189]`
Mówca: **Ciara Walda**
> "“I don't want to sound cynical, but almost all governments keep making the same promises. We must show we are different through our actions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Ciara Walda: "“Did we cover all the necessary subjects?”"*)

### Węzeł `[190]`
Mówca: **Ciara Walda**
> "“It is the same play and the same book. The security complex in the country keeps driving the agenda as usual.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Ciara Walda: "“Did we cover all the necessary subjects?”"*)

### Węzeł `[191]`
**[WYBÓR GRACZA: "“We are elected representatives of our people and we will prioritize their needs.”"]** — Mówca: **Player**
> "“We are elected representatives of our people and we will prioritize their needs.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[132]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Paskal Beniwoll: "“That's reassuring to hear.”"*)

### Węzeł `[192]`
**[WYBÓR GRACZA: "“There are other significant issues that we need to focus on, like security.”"]** — Mówca: **Player**
> "“There are other significant issues that we need to focus on, like security.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Paskal Beniwoll: "“There have been a lot of negative developments lately.”"*)

### Węzeł `[193]`
**[WYBÓR GRACZA: "“I appreciate your briefings and plans. We will re-convene at the budget meeting.”"]** — Mówca: **Player**
> "“I appreciate your briefings and plans. We will re-convene at the budget meeting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Paskal Beniwoll: "“It was a pleasure.”"*)

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
> "“That's reassuring to hear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Ciara Walda: "“I don't want to sound cynical, but almost all government..."*)

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
> "“There have been a lot of negative developments lately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Ciara Walda: "“It is the same play and the same book. The security comp..."*)

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
> "“It was a pleasure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Ciara Walda: "“See you at the meeting. I hope to see a change in direct..."*)

### Węzeł `[197]`
Mówca: **Ciara Walda**
> "“See you at the meeting. I hope to see a change in direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Ciara Walda: "“Did we cover all the necessary subjects?”"*)

### Węzeł `[198]`
Mówca: **Ciara Walda**
> "“Spectacular indeed. But if you look in the opposite direction, you will see what Soll's decades of neglect did to the city.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Ciara Walda: "“Most of the people living in Narbel are workers, farmers..."*)

### Węzeł `[199]`
Mówca: **Narrator**
> "I arrived at the meeting room for my talk with Ciara and Paskal. Before beginning, I took a moment to appreciate the view from the balcony. The mountains of Narbel were completely covered with snow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "While I was mesmerized by the scenery, Paskal Beniwoll wa..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA: "“Whatever. I'd much rather be in Holsord right now.”"]** — Mówca: **Player**
> "“Whatever. I'd much rather be in Holsord right now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Ciara Walda: "“Our presence here will show that we still remember Narbe..."*)

### Węzeł `[201]`
Mówca: **Ciara Walda**
> "“Our presence here will show that we still remember Narbel and other forgotten areas of our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Ciara Walda: "“It is important for the people.”"*)

### Węzeł `[202]`
Mówca: **Ciara Walda**
> "“Most of the people living in Narbel are workers, farmers and their wives and children. They're breaking their backs for close to no pay, all thanks to greedy corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Player: "“My intention is to help the working class.”"*)
  - -> `[200]` (*Player: "“Whatever. I'd much rather be in Holsord right now.”"*)
  - -> `[205]` (*Player: "“We can't really blame the companies. That's just how the..."*)

### Węzeł `[203]`
Mówca: **Ciara Walda**
> "“It is important for the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Ciara Walda: "“If you look past the view, you can see the real problems.”"*)

### Węzeł `[204]`
Mówca: **Ciara Walda**
> "“Real problems like poverty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "Paskal nodded gravely. This was a subject he knew quite a..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA: "“We can't really blame the companies. That's just how they work.”"]** — Mówca: **Player**
> "“We can't really blame the companies. That's just how they work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[202]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Ciara Walda: "“Yes we can. Similar companies are doing much better for ..."*)

### Węzeł `[206]`
Mówca: **Ciara Walda**
> "“Yes we can. Similar companies are doing much better for their workers in United Contana and Arcasia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Ciara Walda: "“If you look past the view, you can see the real problems.”"*)

### Węzeł `[207]`
Mówca: **Narrator**
> "As I made my way out, the weather was noticeably cold, but it didn’t keep a group of USP supporters from coming out to cheer us on the streets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "By looking at the citizens’ attire, it was easy to unders..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "They were excited to see their president in their city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn03_Lespia_ArcasianMilit..."*)

### Węzeł `[209]`
**[WYBÓR GRACZA: "“I personally promised that our health systems were to be improved in our term. I fully support you Paskal.”"]** — Mówca: **Player**
> "“I personally promised that our health systems were to be improved in our term. I fully support you, Paskal.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Kontekst wejściowy (poprzednik):** `[113]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Paskal Beniwoll: "“This is one of the reasons I'm optimistic about the upco..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Health == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player: "“I personally promised that our health systems were to be..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Health == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
> "“This is one of the reasons I'm optimistic about the upcoming budget debates. With enough funds, we can build new hospitals and expand the quality of our services.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Paskal Beniwoll: "“I do hope to create competition and increase the quality..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Education == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player: "“Our election mandate was to improve education. We will d..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Education == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Our election mandate was to improve education. We will deliver on this.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Kontekst wejściowy (poprzednik):** `[104]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Ciara Walda: "“This brings hope to the table, which needs to be followe..."*)

### Węzeł `[218]`
Mówca: **Ciara Walda**
> "“This brings hope to the table, which needs to be followed by action. There is much to be done, but if we're given the budget, we can implement policies that push education to the next level.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Paskal Beniwoll: "“Wouldn't a promotion of private education help create ad..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true && BaseGame.Promise_TermFocus_Health == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Education == true && BaseGame...."*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Education == true && BaseGam..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Education == true && BaseGame.Promise_TermFocus_Health == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player: "“Welfare is my top priority. Both education and health wi..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Education == true && BaseGame.Promise_TermFocus_Health == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Player: "“We are elected representatives of our people and we will..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA: "“Welfare is my top priority. Both education and health will be improved significantly under this administration.”"]** — Mówca: **Player**
> "“Welfare is my top priority. Both education and health will be improved significantly under this administration.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_TermFocus_Education"] == true  and  Variable["BaseGame.Promise_TermFocus_Health"] == true`
- **Kontekst wejściowy (poprzednik):** `[132]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Paskal Beniwoll: "“The people will rejoice if they see grand improvements i..."*)

### Węzeł `[223]`
Mówca: **Ciara Walda**
> "“Exactly. Increasing law enforcement isn't something that reflects nicely on society, in comparison to services that people use every day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Ciara Walda: "“Did we cover all the necessary subjects?”"*)

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
> "“The people will rejoice if they see grand improvements in welfare. Our public opinion ratings will increase drastically.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Ciara Walda: "“Exactly. Increasing law enforcement isn't something that..."*)

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
> "“It's getting a little cold out here. Shall we continue our discussion indoors?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "We headed back inside."*)

### Węzeł `[226]`
**[WYBÓR GRACZA: "“I agree. We need to improve the standards for our workers.”"]** — Mówca: **Player**
> "“I agree. We need to improve the standards for our workers.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Paskal Beniwoll: "“Exactly. Sordland must provide for its own people to mov..."*)

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
> "“Mr. Clavin has already backed me and given his support. Sordland has fallen behind most countries on this subject and it is my responsibility to ensure this is not the case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player: "“I agree. We need to improve the standards for our workers.”"*)
  - -> `[228]` (*Player: "“There is always room for improvement and it is good to h..."*)
  - -> `[229]` (*Player: "“We shouldn't upset the businesses who are already strugg..."*)
  - -> `[254]` (*Player: "“Sounds like a costly bill for such a low-priority issue.""*)

### Węzeł `[228]`
**[WYBÓR GRACZA: "“There is always room for improvement and it is good to hear that you are pushing for it.”"]** — Mówca: **Player**
> "“There is always room for improvement and it is good to hear that you are pushing for it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Paskal Beniwoll: "“Appreciate the kind words, Mr. President. I will not let..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA: "“We shouldn't upset the businesses who are already struggling to stay afloat in the crisis.”"]** — Mówca: **Player**
> "“We shouldn't upset the businesses who are already struggling to stay afloat in the crisis.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Paskal Beniwoll: "“This wouldn't alter the balance of operational companies..."*)

### Węzeł `[230]`
Mówca: **Ciara Walda**
> "“It also is a matter of life and death. Every decade we hear of some horrific accident due to employers' disregard for their workers' safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Paskal Beniwoll: "“So, will you back the bill when it arrives on your desk,..."*)

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
> "“Exactly. Sordland must provide for its own people to move forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Ciara Walda: "“It also is a matter of life and death. Every decade we h..."*)

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
> "“Appreciate the kind words, Mr. President. I will not let you down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Ciara Walda: "“It also is a matter of life and death. Every decade we h..."*)

### Węzeł `[233]`
Mówca: **Ciara Walda**
> "“Why would you turn away from the pro-labor cause when you yourself supported the Red Youth during your university years?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player: "“Times have changed.”"*)
  - -> `[256]` (*Player: "“I am not necessarily opposed to it. I'm sceptical.”"*)

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
> "“This wouldn't alter the balance of operational companies drastically. It would just punish them if they are treating their workers unfairly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == true)"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Ciara Walda: "“Why would you turn away from the pro-labor cause when yo..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Ciara Walda: "“It also is a matter of life and death. Every decade we h..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true"*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedPeople ==..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player: "“Minister Walda, I have bailed out people in need instead..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[241]`
Mówca: **Ciara Walda**
> "“It has shown your dedication, but there are many years ahead of us. This is just the beginning of the journey.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Paskal Beniwoll: "“No matter how small a step, it still is progress.”"*)

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
> "“No matter how small a step, it still is progress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Ciara Walda: "“Did we cover all the necessary subjects?”"*)

### Węzeł `[243]`
**[WYBÓR GRACZA: "“Minister Walda, I have bailed out people in need instead of businesses. Trust me, my priorities are correct.”"]** — Mówca: **Player**
> "“Minister Walda, I have bailed out people in need instead of businesses. Trust me, my priorities are correct.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true`
- **Kontekst wejściowy (poprzednik):** `[132]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Ciara Walda: "“It has shown your dedication, but there are many years a..."*)

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
> "“So, will you back the bill when it arrives on your desk, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player: "“I would be very interested in supporting it once it is f..."*)
  - -> `[247]` (*Player: "“To make a decision, I would need to evaluate the content..."*)
  - -> `[262]` (*Player: "“I don't think this is the time for such a change. We hav..."*)

### Węzeł `[245]`
**[WYBÓR GRACZA: "“I would be very interested in supporting it once it is finished.”"]** — Mówca: **Player**
> "“I would be very interested in supporting it once it is finished.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Paskal Beniwoll: "“I'm relieved to hear that.”"*)

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
> "“I'm relieved to hear that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "He smiled."*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“To make a decision, I would need to evaluate the contents in detail.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Paskal Beniwoll: "“Understandable. You will receive all the sections in an ..."*)

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
> "“Understandable. You will receive all the sections in an outline.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Paskal Beniwoll: "“It's getting a little cold out here. Shall we continue o..."*)

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
> "“It is obvious that the military has been overfunded for a long time. Perhaps it is time to change this trend.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Paskal Beniwoll: "“There is another subject I want to mention. I have been ..."*)

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
> "“It is obvious that the military has been overfunded for a long time and you have promised to change this trend.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Paskal Beniwoll: "“There is another subject I want to mention. I have been ..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true || BaseGame.Promise_TermFocus_Education == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Health == true || BaseGame.Pro..."*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Health == true || BaseGame.P..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Health == true || BaseGame.Promise_TermFocus_Education == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == true  or  Variable["BaseGame.Promise_TermFocus_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Paskal Beniwoll: "“It is obvious that the military has been overfunded for ..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Health == true || BaseGame.Promise_TermFocus_Education == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == true  or  Variable["BaseGame.Promise_TermFocus_Education"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Paskal Beniwoll: "“It is obvious that the military has been overfunded for ..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA: "“Sounds like a costly bill for such a low-priority issue.""]** — Mówca: **Player**
> "“Sounds like a costly bill for such a low-priority issue.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Paskal Beniwoll: "“If the very lives of our workers aren't a priority, than..."*)

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
> "“If the very lives of our workers aren't a priority, than what is? Our administration should be able to set a budget aside for these types of improvements.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)

### Węzeł `[256]`
**[WYBÓR GRACZA: "“I am not necessarily opposed to it. I'm sceptical.”"]** — Mówca: **Player**
> "“I am not necessarily opposed to it. I'm skeptical.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Ciara Walda: "“This is worth considering, Mr. President.”"*)

### Węzeł `[257]`
**[WYBÓR GRACZA: "“Times have changed.”"]** — Mówca: **Player**
> "“Times have changed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Ciara Walda: "“One would hope ideals haven't changed as drastically.”"*)

### Węzeł `[258]`
Mówca: **Ciara Walda**
> "“This is worth considering, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Ciara Walda: "“It also is a matter of life and death. Every decade we h..."*)

### Węzeł `[259]`
Mówca: **Ciara Walda**
> "“One would hope ideals haven't changed as drastically.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Ciara Walda: "“It also is a matter of life and death. Every decade we h..."*)

### Węzeł `[260]`
Mówca: **Ciara Walda**
> "“We shouldn't miss opportunities like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Paskal Beniwoll: "“It's getting a little cold out here. Shall we continue o..."*)

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
> "“Maybe by the time the bill is done, you will have changed your mind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "He sighed."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I don't think this is the time for such a change. We have bigger issues to fix.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Paskal Beniwoll: "“Maybe by the time the bill is done, you will have change..."*)

### Węzeł `[263]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Ciara Walda: "“We shouldn't miss opportunities like this.”"*)

### Węzeł `[264]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Paskal Beniwoll: "“It's getting a little cold out here. Shall we continue o..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == ..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_R_Protest_ExpandedPolice = true"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn03_Morbel_MineDisaster = true;..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors ==..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_R_Protest_CalledProtestersTra..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_R_Protest_CalledProtestersTraitors = true; BaseGameSupport.Report_Turn03_Valgen_CalledProtestersTraitors = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_Protest_CalledProtestersTraitors"] = true;
Variable["BaseGameSupport.Report_Turn03_Valgen_CalledProtestersTraitors"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn03_Morbel_MineDisaster = true;..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_R_Protest_ExpandedPolice = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_Protest_ExpandedPolice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn03_Morbel_MineDisaster = true;..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn03_Morbel_MineDisaster = true;
BaseGameSupport.Report_Turn03_Estord_YSFoundDead = true;
BaseGameSupport.Report_Turn03_Holsord_NFPReport = true; BaseGameSupport.Report_Turn03_Holsord_WorkersRightsPrep = true; BaseGameSupport.Report_Turn03_Holsord_EPARepealFails = true;
BaseGameSupport.FactionReport_Turn03_CSP_SummitForHelji = true;
BaseGameSupport.News_Turn03_HP_EPA_RepealFails = true;
BaseGameSupport.Report_Turn03_Narbel_CPSLUSOrganize = true;
BaseGameSupport.Report_Turn03_Narbel_LaborStrike = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Morbel_MineDisaster"] = true;
Variable["BaseGameSupport.Report_Turn03_Estord_YSFoundDead"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_NFPReport"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_WorkersRightsPrep"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_EPARepealFails"] = true;
Variable["BaseGameSupport.FactionReport_Turn03_CSP_SummitForHelji"] = true;
Variable["BaseGameSupport.News_Turn03_HP_EPA_RepealFails"] = true;
Variable["BaseGameSupport.Report_Turn03_Narbel_CPSLUSOrganize"] = true;
Variable["BaseGameSupport.Report_Turn03_Narbel_LaborStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_PSnW_Overview = true"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_Decision_StabilityOrder = true"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Abandon == false"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_Decision_StabilityOrder = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_Decision_StabilityOrder"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Abandon == false"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Abandon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Abandon == false"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Abandon == false)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Abandon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Abandon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_LateBriefing = true"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Abandon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Abandon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_A_LateBriefing = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_A_LateBriefing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[282]`
Mówca: **Narrator**
> "Paskal nodded gravely. This was a subject he knew quite a bit about himself. His best-known books were about the plight of Sordland's less fortunate, drawing from his own past growing up in squalor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)

### Węzeł `[283]`
Mówca: **Narrator**
> "My Minister of Health was, ironically, somewhat portly, having gained a few pounds since his breakthrough as a best-selling writer. But his authority on social affairs could not be questioned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Paskal Beniwoll: "“Such a spectacular view.”"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Health == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Health == false"*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_PSnW_Listened_Health == false)"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Health == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: "“I want to hear about the healthcare system.”"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_PSnW_Listened_Health == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player: "“I believe that is everything.”"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Briefing Done`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Ciara stood up and moved towards the window. She took a d..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Briefing Done]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "Briefing Done"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Education == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education == true"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_PSnW_Listened_Education == true)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_PSnW_Listened_Education == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Player: "“I believe that is everything.”"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_PSnW_Listened_Education == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "“I want to hear about the education system.”"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Briefing Done]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "Briefing Done"*)

### Węzeł `[293]`
**[WYBÓR GRACZA: "“I believe that is everything.”"]** — Mówca: **Player**
> "“I believe that is everything.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education"] == true`
- **Kontekst wejściowy (poprzednik):** `[295]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "Jump to: [Briefing Done]"*)

### Węzeł `[294]`
**[WYBÓR GRACZA: "“I believe that is everything.”"]** — Mówca: **Player**
> "“I believe that is everything.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[296]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "Jump to: [Briefing Done]"*)

### Węzeł `[295]`
**[WYBÓR GRACZA: "“Thank you, Paskal. Your in-depth briefing is much appreciated.”"]** — Mówca: **Player**
> "“Thank you, Paskal. Your in-depth briefing is much appreciated.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_DoctorsNurses"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_Beds"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Health_LifeMortality"] == true`
- **Kontekst wejściowy (poprzednik):** `[46]` (Paskal Beniwoll), `[181]` (Ciara Walda), `[127]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Health = true"*)

### Węzeł `[296]`
**[WYBÓR GRACZA: "“Thank you, Ciara. I can fill in the blanks from here.”"]** — Mówca: **Player**
> "“Thank you, Ciara. I can fill in the blanks from here.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Students"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_Literacy"] == true  or  Variable["BaseGameIsolated.Turn03_PSnW_Listened_Education_UrbanRural"] == true`
- **Kontekst wejściowy (poprzednik):** `[70]` (Ciara Walda), `[128]` (Ciara Walda), `[77]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_PSnW_Listened_Education = true"*)

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
> "“Parity among the sexes shouldn't be our first priority. Look at how many high-ranking female politicians our country has.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Ciara Walda: ""Appearances can be deceiving, Paskal.""*)

### Węzeł `[298]`
Mówca: **Ciara Walda**
> ""Appearances can be deceiving, Paskal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Narrator: "Her voice sounded bitter."*)

### Węzeł `[299]`
Mówca: **Narrator**
> "Her voice sounded bitter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Ciara Walda: ""Think about how Lileas Graf got to her current position...."*)

### Węzeł `[300]`
Mówca: **Ciara Walda**
> ""Think about how Lileas Graf got to her current position. I don't necessarily believe the rumors about her and Soll, but she never could have risen so high if she didn't parrot his cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Ciara Walda: ""Gloria Tory -- is it an accident that the first female A..."*)

### Węzeł `[301]`
Mówca: **Ciara Walda**
> ""Gloria Tory -- is it an accident that the first female Assembly speaker is such a staunch conservative?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Ciara Walda: ""And then there was Alphonso's habit of promoting women t..."*)

### Węzeł `[302]`
Mówca: **Ciara Walda**
> ""And then there was Alphonso's habit of promoting women to prominent positions to give Sordland a progressive sheen while accomplishing nothing in reality...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Ciara Walda: ""While women in places like Narbel are denied any opportu..."*)

### Węzeł `[303]`
Mówca: **Ciara Walda**
> ""While women in places like Narbel are denied any opportunity to advance, the government can use a handful of female politicians from wealthy families -- myself included -- to pretend their only obstacle to success is their own lack of initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Ciara Walda: ""Meanwhile, those of us who don't use our clout to help p..."*)

### Węzeł `[304]`
Mówca: **Ciara Walda**
> ""Meanwhile, those of us who don't use our clout to help powerful men stay in power are denigrated as angry spinsters... I ask you, Mr. President, does anyone care that your strategist Mr. Galade doesn't have a wife?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Player: ""I've been wondering about that, actually.""*)
  - -> `[306]` (*Player: ""Leave Lucian out of this.""*)
  - -> `[307]` (*Player: ""You've veered off-topic, Ms. Walda.""*)
  - -> `[308]` (*Player: ""I agree with you completely. Sordland's women deserve be..."*)

### Węzeł `[305]`
**[WYBÓR GRACZA: ""I've been wondering about that, actually.""]** — Mówca: **Player**
> ""I've been wondering about that, actually.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Paskal Beniwoll: ""All right, Ciara. You've made your point.""*)

### Węzeł `[306]`
**[WYBÓR GRACZA: ""Leave Lucian out of this.""]** — Mówca: **Player**
> ""Leave Lucian out of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Paskal Beniwoll: ""All right, Ciara. You've made your point.""*)

### Węzeł `[307]`
**[WYBÓR GRACZA: ""You've veered off-topic, Ms. Walda.""]** — Mówca: **Player**
> ""You've veered off-topic, Ms. Walda.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Ciara Walda: ""Mr. Beniwoll asked. I answered.""*)

### Węzeł `[308]`
**[WYBÓR GRACZA: ""I agree with you completely. Sordland's women deserve better.""]** — Mówca: **Player**
> ""I agree with you completely. Sordland's women deserve better.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Ciara Walda: ""I'm glad to hear that.""*)

### Węzeł `[309]`
Mówca: **Ciara Walda**
> ""Mr. Beniwoll asked. I answered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Ciara Walda: "“As I was saying -- isn't it about time Holsord addressed..."*)

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
> ""All right, Ciara. You've made your point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Ciara Walda: "“As I was saying -- isn't it about time Holsord addressed..."*)

### Węzeł `[311]`
Mówca: **Ciara Walda**
> ""I'm glad to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Ciara Walda: "“As I was saying -- isn't it about time Holsord addressed..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn03_Lespia_ArcasianMilitaryBase = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn03_Lespia_ArcasianMilitaryBase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
> ""Nevertheless, it's worth acknowledging the corporation's significant contribution to job creation in Narbel and other poverty-stricken regions. Persuading the chairman to make concessions might prove to be a formidable task.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Player: ""My foremost priorities lie in improving the economy. Onc..."*)
  - -> `[317]` (*Player: ""What good is job creation if the workers are treated poo..."*)
  - -> `[318]` (*Player: ""I know how slippery Alphonso can be. Bringing this up wi..."*)
  - -> `[319]` (*Player: ""If we do this right, we can find a solution that advance..."*)

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
> ""One more thing. I wish to raise my concerns about your scheduled meeting with the Gasom chairman and former President, Mr. Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Paskal Beniwoll: ""By negotiating with Alphonso and his company, you have a..."*)

### Węzeł `[316]`
Mówca: **Ciara Walda**
> ""What is there to negotiate, Paskal? The standards for Gasom workers are already at rock bottom. President Rayne can and must demand better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Paskal Beniwoll: ""Nevertheless, it's worth acknowledging the corporation's..."*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What good is job creation if the workers are treated poorly? Of course I'll demand better from Alphonso.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[314]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Paskal Beniwoll: ""I covered this topic extensively in one of my books. Con..."*)

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I know how slippery Alphonso can be. Bringing this up with him will indeed be a challenge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[314]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Paskal Beniwoll: ""Try a diplomatic approach. Deep down, I believe he wants..."*)

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If we do this right, we can find a solution that advances both the economy and the interests of laborers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[314]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Paskal Beniwoll: ""That would be quite the impressive feat. You'd make head..."*)

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
> ""I covered this topic extensively in one of my books. Confrontation, if not handled prudently, could exacerbate the challenges these workers face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Paskal Beniwoll: "“This matter is close to my heart. I would personally be ..."*)

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
> ""Try a diplomatic approach. Deep down, I believe he wants what is best for the workers as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Paskal Beniwoll: "“This matter is close to my heart. I would personally be ..."*)

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
> ""That would be quite the impressive feat. You'd make headlines for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Paskal Beniwoll: "“This matter is close to my heart. I would personally be ..."*)

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
> "“This matter is close to my heart. I would personally be grateful if you are able to resolve the concerns raised by Katarina Horten and her fellow labor representatives.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Ciara Walda: "“It would be difficult to imagine a CEO like Alphonso giv..."*)

### Węzeł `[324]`
Mówca: **Ciara Walda**
> "“It would be difficult to imagine a CEO like Alphonso giving benefits to workers without him personally gaining from it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player: ""Considering our need for greater energy security, we mig..."*)
  - -> `[325]` (*Player: ""In this world, nothing is truly free. I wouldn't anticip..."*)
  - -> `[326]` (*Player: ""Gasom relies on us just as we rely on them. We can find ..."*)
  - -> `[327]` (*Player: ""Gasom has profited from the labor of workers for far too..."*)

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""In this world, nothing is truly free. I wouldn't anticipate anything less.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Ciara Walda: "“We must be cautious about these seemingly generous offer..."*)

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gasom relies on us just as we rely on them. We can find a path to compromise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Ciara Walda: "“The middle way often sways perilously close to the statu..."*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gasom has profited from the labor of workers for far too long. It's time for them to give back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Ciara Walda: "“We shouldn't settle for anything less than a complete ov..."*)

### Węzeł `[328]`
Mówca: **Ciara Walda**
> "“We must be cautious about these seemingly generous offers. They usually come with hidden costs that further tip the scales in favor of the privileged few.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Paskal Beniwoll: ""Thank you for your input, Ciara. But I will stress to Pr..."*)

### Węzeł `[329]`
Mówca: **Ciara Walda**
> "“The middle way often sways perilously close to the status quo. We must ensure that any negotiations genuinely benefit the people and not just uphold the interests of corporate giants.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Paskal Beniwoll: ""Thank you for your input, Ciara. But I will stress to Pr..."*)

### Węzeł `[330]`
Mówca: **Ciara Walda**
> "“We shouldn't settle for anything less than a complete overhaul of the exploitative structures Gasom and its fellow corporations have built.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Paskal Beniwoll: ""Thank you for your input, Ciara. But I will stress to Pr..."*)

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
> ""Thank you for your input, Ciara. But I will stress to President Rayne how important it is that the door to dialogue remain open.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Paskal Beniwoll: ""Ideology should never get in the way of bringing about t..."*)

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
> ""Ideology should never get in the way of bringing about tangible, lasting change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Player: ""I'm skeptical that these discussions with Gasom will lea..."*)
  - -> `[339]` (*Player: ""I'm encouraged by the willingness of Mr. Manger and Mr. ..."*)
  - -> `[342]` (*Player: ""I can't promise anything to either of you. I've got to g..."*)
  - -> `[340]` (*Player: ""I disagree. Only by holding firm to my convictions can I..."*)

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
> ""By negotiating with Alphonso and his company, you have an opportunity to secure better labor conditions for blue-collar Gasom employees. This could be a triumph for all of Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Ciara Walda: ""What is there to negotiate, Paskal? The standards for Ga..."*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My foremost priorities lie in improving the economy. Once that is achieved, upward mobility will naturally follow suit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[314]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Paskal Beniwoll: ""Economic improvements don't always automatically transla..."*)

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
> ""Economic improvements don't always automatically translate into greater happiness and well-being, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Paskal Beniwoll: "“This matter is close to my heart. I would personally be ..."*)

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Considering our need for greater energy security, we might find ourselves forced to collaborate with him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Ciara Walda: ""Remember, these 'collaborations' usually come with strin..."*)

### Węzeł `[337]`
Mówca: **Ciara Walda**
> ""Remember, these 'collaborations' usually come with strings attached. Often, they disproportionately favor corporations while placing the burden on the common people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Paskal Beniwoll: ""Thank you for your input, Ciara. But I will stress to Pr..."*)

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
> "“We shall keep you no longer. Thank you both for the discussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Ciara Walda: "“I do hope we won't repeat the same mistakes again and ag..."*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm encouraged by the willingness of Mr. Manger and Mr. Alphonso to meet with me. It's a step forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Paskal Beniwoll: "“We shall keep you no longer. Thank you both for the disc..."*)

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I disagree. Only by holding firm to my convictions can I bring about the change Sordland needs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Paskal Beniwoll: "“We shall keep you no longer. Thank you both for the disc..."*)

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm skeptical that these discussions with Gasom will lead to any meaningful change. We've seen empty promises before.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Paskal Beniwoll: "“We shall keep you no longer. Thank you both for the disc..."*)

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I can't promise anything to either of you. I've got to get a grasp of the situation at Gasom first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Paskal Beniwoll: "“We shall keep you no longer. Thank you both for the disc..."*)

### Węzeł `[343]`
**[WYBÓR GRACZA: ""No need for the briefing, I'm up to speed.""]** — Mówca: **Player**
> ""No need for the briefing, I'm up to speed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Ciara Walda: "“Oh, okay.”"*)

### Węzeł `[344]`
Mówca: **Ciara Walda**
> "“Oh, okay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Paskal Beniwoll: ""One more thing. I wish to raise my concerns about your s..."*)
