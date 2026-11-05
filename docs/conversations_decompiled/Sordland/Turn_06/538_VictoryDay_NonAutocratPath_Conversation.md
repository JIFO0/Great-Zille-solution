# Sordland/Turn06/VictoryDay_NonAutocratPath/VictoryDay_NonAutocratPath Conversation

- **ID konwersacji:** `538`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/538_VictoryDay_NonAutocratPath_Conversation.md`
- **Liczba węzłów dialogowych:** 586
- **Liczba wyborów gracza:** 112

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[16]** Manoly Suheil
- **[32]** Frens Ricter
- **[50]** Kesaro Kibener
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.BergiaSpecialZone_Proposal_Amendment`
- `BaseGame.BergiaSpecialZone_Proposal_Centralization`
- `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Policy_Diplomacy_Wehlen_DefendBorder`
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Reform_NFP_Convinced`
- `BaseGame.Reform_Reform_PFJP_Convinced`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Frens_Bribed`
- `BaseGame.Relations_Frens_Promise_Taurus`
- `BaseGame.Relations_Kesaro_Promise_Bill`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4`
- `BaseGameIsolated.VictoryDay_ChoiceHub_Nothing`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4`
- `BaseGameIsolated.VictoryDay_Hub_Option1`
- `BaseGameIsolated.VictoryDay_Hub_Option2`
- `BaseGameIsolated.VictoryDay_Hub_Option3`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.ErsenCase_Statement_ProBlud`
- `BaseGame.ErsenCase_Statement_ProSollist`
- `BaseGame.Sollist`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3`
- `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3`
- `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4`
- `BaseGameIsolated.VictoryDay_Hub_Option1`
- `BaseGameIsolated.VictoryDay_Hub_Option2`
- `BaseGameIsolated.VictoryDay_Hub_Option3`
- `BaseGameSupport.Journal_Turn06_VictoryDay_GaveNoSupport`
- `BaseGameSupport.Journal_Turn06_VictoryDay_SupportedErsen`
- `BaseGameSupport.Journal_Turn06_VictoryDay_SupportedSollism`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[90] Sordland/Turn06/A_VictoryDayBludishMeeting** (../Turn_06/090_A_VictoryDayBludishMeeting.md), Węzeł `[59]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **""Thank you, Mr. Kibener.""** | `[6]` **Kesaro Kibener**: ""As the former mayor of Jen, it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "We shook hands." |
| `[8]` | **""It looks like you were a good mayor. Maybe you should think about running for loc..."** | `[6]` **Kesaro Kibener**: ""As the former mayor of Jen, it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Kesaro Kibener**: ""Thanks for the kind words, but ..." |
| `[9]` | **""It is good to be here.""** | `[6]` **Kesaro Kibener**: ""As the former mayor of Jen, it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "We shook hands." |
| `[10]` | **"Shake his hand in silence."** | `[6]` **Kesaro Kibener**: ""As the former mayor of Jen, it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Petr Vectern**: ""Thank you for organizing this, ..." |
| `[17]` | **""Please.""** | `[16]` **Kesaro Kibener**: ""Shall we?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Kesaro Kibener**: ""Just follow me."" |
| `[18]` | **"Nod."** | `[16]` **Kesaro Kibener**: ""Shall we?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Kesaro Kibener**: ""Just follow me."" |
| `[19]` | **""Before we go in... Is everything ready within your party? You know the vote is ap..."** | `[16]` **Kesaro Kibener**: ""Shall we?"" | `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`<br>`Variable["BaseGame.Reform_Dictator_Path"] == true` | *Brak zmian stanu* | `[27]` **Kesaro Kibener**: ""I am aware, Mr. President. Don'..." |
| `[26]` | **""Before we go in... Is there a way to get you back on the table regarding the cons..."** | `[16]` **Kesaro Kibener**: ""Shall we?"" | `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`<br>`Variable["BaseGame.Reform_Dictator_Path"] == true` | *Brak zmian stanu* | `[33]` **Kesaro Kibener**: ""I'm afraid not."" |
| `[37]` | **""Before we go in... is there any way we can discuss how you can help us with the c..."** | `[16]` **Kesaro Kibener**: ""Shall we?"" | `Variable["BaseGame.Reform_Reformist_Path"] == true`<br>`(Variable["BaseGame.Reform_Dictator_Path"] == true) == false` | *Brak zmian stanu* | `[33]` **Kesaro Kibener**: ""I'm afraid not."" |
| `[39]` | **""So be it.""** | `[38]` **Kesaro Kibener**: ""Besides, this is neither the ti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[468]` **Kesaro Kibener**: ""Of course, I'm not saying nothi..." |
| `[40]` | **""I understand.""** | `[38]` **Kesaro Kibener**: ""Besides, this is neither the ti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[468]` **Kesaro Kibener**: ""Of course, I'm not saying nothi..." |
| `[41]` | **""You're making a mistake.""** | `[38]` **Kesaro Kibener**: ""Besides, this is neither the ti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Kesaro Kibener**: ""Come now, Mr. President. There ..." |
| `[56]` | **""Honestly, it says more about Frens and the PFJP.""** | `[55]` **Petr Vectern**: ""How did this clown convince the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Petr Vectern**: ""I don't trust them."" |
| `[57]` | **""Probably the same reason why we're here. It's Victory Day, remember?""** | `[55]` **Petr Vectern**: ""How did this clown convince the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Petr Vectern**: ""How can I forget? Lucian nagged..." |
| `[58]` | **""He's a dangerously competent man, Petr. We should be cautious with him.""** | `[55]` **Petr Vectern**: ""How did this clown convince the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Petr Vectern**: ""I agree."" |
| `[62]` | **""Try not to agitate him, Petr. Don't forget, he's our partner for now and we need ..."** | `[55]` **Petr Vectern**: ""How did this clown convince the..."<br>`[403]` **Petr Vectern**: ""We appreciate all your comments..." | `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true` | *Brak zmian stanu* | `[66]` **Petr Vectern**: ""Of course."" |
| `[81]` | **""Why are we discussing this on Victory Day?""** | `[69]` **Kesaro Kibener**: ""Of course, Ms. Suheil. Mr. Hols..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Remus Holstron**: ""It seemed fitting."" |
| `[82]` | **""I refuse to discuss this topic without any Bludish representation.""** | `[69]` **Kesaro Kibener**: ""Of course, Ms. Suheil. Mr. Hols..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[446]` **Nia Morgna**: ""Actually, Mr. President is comp..." |
| `[90]` | **""I'm surprised that your parties have conducted a joint analysis.""** | `[69]` **Kesaro Kibener**: ""Of course, Ms. Suheil. Mr. Hols..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Manoly Suheil**: ""We thank the NFP for assisting ..." |
| `[100]` | **""It's good to see that the new laws are working.""** | `[96]` **Kesaro Kibener**: ""As the threat the BFF poses is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Remus Holstron**: ""They are working, but it is not..." |
| `[101]` | **""I'm regretting my decision to sign that bill.""** | `[96]` **Kesaro Kibener**: ""As the threat the BFF poses is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Manoly Suheil**: ""You should have controlled your..." |
| `[102]` | **""Do you have any suggestions?""** | `[96]` **Kesaro Kibener**: ""As the threat the BFF poses is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Kesaro Kibener**: ""One of my suggestions to you wa..."<br>`[114]` **Kesaro Kibener**: ""Our suggestion is to finally en..." |
| `[104]` | **""Your bill would have unnecessarily raised the already high tensions.""** | `[103]` **Kesaro Kibener**: ""I'm disappointed by the lack of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Manoly Suheil**: ""You did well by vetoing it, Mr...." |
| `[105]` | **""And what do you suggest we do?""** | `[103]` **Kesaro Kibener**: ""I'm disappointed by the lack of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Kesaro Kibener**: ""One of my suggestions to you wa..."<br>`[114]` **Kesaro Kibener**: ""Our suggestion is to finally en..." |
| `[106]` | **""I'm regretting my decision to veto that bill.""** | `[103]` **Kesaro Kibener**: ""I'm disappointed by the lack of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Remus Holstron**: ""We can still right our wrongs."" |
| `[123]` | **""As I've promised before, I'll sign the bill when it reaches me.""** | `[122]` **Kesaro Kibener**: ""I disagree. The language is qui..." | `Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true` | *Brak zmian stanu* | `[145]` **Manoly Suheil**: ""The PFJP will not allow this bi..." |
| `[128]` | **""I'll sign the bill if it reaches me.""** | `[122]` **Kesaro Kibener**: ""I disagree. The language is qui..." | `(Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true) == false` | *Brak zmian stanu* | `[145]` **Manoly Suheil**: ""The PFJP will not allow this bi..." |
| `[129]` | **""I'll have to read it in detail to decide if I can support it.""** | `[122]` **Kesaro Kibener**: ""I disagree. The language is qui..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Manoly Suheil**: ""The PFJP will not allow this bi..." |
| `[130]` | **""I don't see how this helps with the situation.""** | `[122]` **Kesaro Kibener**: ""I disagree. The language is qui..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Manoly Suheil**: ""It doesn't. It's simple as that."" |
| `[133]` | **""Even if the Assembly supports it, I will surely be using my veto on it.""** | `[122]` **Kesaro Kibener**: ""I disagree. The language is qui..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Kesaro Kibener**: ""Is that so?""<br>`[142]` **Kesaro Kibener**: ""I wouldn't be so quick, if I we..."<br>*(oraz 1 innych odgałęzień)* |
| `[159]` | **""That's why we have to remove the authority of the governor.""** | `[154]` **Frens Ricter**: ""The situation is also connected..." | `Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true` | *Brak zmian stanu* | `[568]` **Frens Ricter**: ""It's great that we're aligned o..." |
| `[160]` | **""With all due respect, I already received this information from Internal Affairs. ..."** | `[154]` **Frens Ricter**: ""The situation is also connected..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Frens Ricter**: ""Just let me finish, Mr. Preside..." |
| `[161]` | **""Maybe the NFP influences you more than you think, Mr. Ricter.""** | `[154]` **Frens Ricter**: ""The situation is also connected..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Frens Ricter**: ""Just let me finish, Mr. Preside..." |
| `[173]` | **""From now on, nobody speaks until the speaker finishes their point.""** | `[175]` **Narrator**: "Everybody went silent and looked..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "Kesaro and Petr nodded." |
| `[177]` | **""Can we return to the topic?""** | `[174]` **Petr Vectern**: ""What is that supposed to mean?""<br>`[175]` **Narrator**: "Everybody went silent and looked..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "Kesaro and Petr nodded." |
| `[180]` | **""Enough!""** | `[174]` **Petr Vectern**: ""What is that supposed to mean?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Narrator**: "Everybody went silent and looked..." |
| `[181]` | **""This is a mess. I thought we were here for a proper meeting.""** | `[174]` **Petr Vectern**: ""What is that supposed to mean?""<br>`[175]` **Narrator**: "Everybody went silent and looked..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "Kesaro and Petr nodded." |
| `[183]` | **""Your bill would have made everything worse.""** | `[103]` **Kesaro Kibener**: ""I'm disappointed by the lack of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Manoly Suheil**: ""You did well by vetoing it, Mr...." |
| `[196]` | **""What's the significance of this case?""** | `[199]` **Kesaro Kibener**: ""For peace and harmony in Sordla..."<br>`[201]` **Frens Ricter**: ""What do you want to know, Mr. P..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == false` | *Brak zmian stanu* | `[233]` **Kesaro Kibener**: ""I'll be straight with you, Mr. ..." |
| `[206]` | **""And why do you think it would influence the Court's decision?""** | `[195]` **Frens Ricter**: ""Not if all three parties of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Frens Ricter**: ""This never happened before, Mr...." |
| `[207]` | **""All parties? Is the NFP really willing to support Ersen, Mr. Kibener?""** | `[195]` **Frens Ricter**: ""Not if all three parties of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Kesaro Kibener**: ""For peace and harmony in Sordla..." |
| `[208]` | **""I'm listening.""** | `[195]` **Frens Ricter**: ""Not if all three parties of the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Frens Ricter**: ""What do you want to know, Mr. P..." |
| `[213]` | **""What is the most likely outcome of this case?""** | `[199]` **Kesaro Kibener**: ""For peace and harmony in Sordla..."<br>`[201]` **Frens Ricter**: ""What do you want to know, Mr. P..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == false` | *Brak zmian stanu* | `[231]` **Nia Morgna**: ""The first and most likely optio..." |
| `[215]` | **""I hope you are right.""** | `[214]` **Frens Ricter**: ""Besides, if the NFP can see the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Frens Ricter**: ""We must be hopeful."" |
| `[216]` | **""Oh, Frens. How naive of you.""** | `[214]` **Frens Ricter**: ""Besides, if the NFP can see the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Narrator**: "Manoly glanced at Frens. Her eye..." |
| `[218]` | **""Don't worry. Our armed forces are capable of handling any threat.""** | `[241]` **Kesaro Kibener**: ""This is exactly what those damn..."<br>`[292]` **Kesaro Kibener**: ""This is exactly what those damn..." | `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == false` | *Brak zmian stanu* | `[226]` **Remus Holstron**: ""May Nur bless our valiant warri..." |
| `[222]` | **""I think the threat is exaggerated.""** | `[241]` **Kesaro Kibener**: ""This is exactly what those damn..."<br>`[292]` **Kesaro Kibener**: ""This is exactly what those damn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Frens Ricter**: ""I can't believe I'm saying this..." |
| `[223]` | **""We can't allow that to happen.""** | `[241]` **Kesaro Kibener**: ""This is exactly what those damn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Frens Ricter**: ""We definitely can't."" |
| `[224]` | **""I'll be honest with you. I'm not feeling very comfortable talking about Bludish r..."** | `[241]` **Kesaro Kibener**: ""This is exactly what those damn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Kesaro Kibener**: ""I understand where this comes f..." |
| `[234]` | **""What do you really think will happen if the Court ignores it?""** | `[232]` **Frens Ricter**: ""I'm afraid Mr. Kibener is right..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Kesaro Kibener**: ""Another all-out BFF rebellion, ..." |
| `[237]` | **""So you just *believe* in Hawker and hope for the best? I thought you would have a..."** | `[214]` **Frens Ricter**: ""Besides, if the NFP can see the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Narrator**: "Manoly glanced at Frens. Her eye..." |
| `[244]` | **""We definitely can't let that happen.""** | `[243]` **Nia Morgna**: ""It would effectively erase any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[423]` **Manoly Suheil**: ""Exactly."" |
| `[245]` | **""And how does that affect the administration?""** | `[243]` **Nia Morgna**: ""It would effectively erase any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[419]` **Petr Vectern**: ""Honestly, it doesn't. As long a..." |
| `[246]` | **""That would be disastrous for our Bludish citizens.""** | `[243]` **Nia Morgna**: ""It would effectively erase any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[423]` **Manoly Suheil**: ""Exactly."" |
| `[247]` | **""Bludish rights and the BFF have been major issues for many decades now. I don't s..."** | `[243]` **Nia Morgna**: ""It would effectively erase any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Manoly Suheil**: ""What part of it don't you under..." |
| `[248]` | **""And how do you think the Supreme Court will react if we do it your way?""** | `[279]` **Frens Ricter**: ""We can show the people of Sordl..." | `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] == true) == false` | *Brak zmian stanu* | `[310]` **Manoly Suheil**: ""We have to try. If they truly c..." |
| `[249]` | **""What do you think, Petr?""** | `[279]` **Frens Ricter**: ""We can show the people of Sordl..." | `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] == true) == false` | *Brak zmian stanu* | `[312]` **Narrator**: "Petr leaned in and whispered." |
| `[254]` | **""You might be right.""** | `[292]` **Kesaro Kibener**: ""This is exactly what those damn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Frens Ricter**: ""I can't believe I'm saying this..." |
| `[257]` | **""I see your point. But I still don't understand why the NFP suddenly had a change ..."** | `[290]` **Kesaro Kibener**: ""I do not understand why someone..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Kesaro Kibener**: ""I disagree. This case is import..." |
| `[258]` | **""Why are you even comparing Sordland with United Contana? Are you alright, Mr. Kib..."** | `[290]` **Kesaro Kibener**: ""I do not understand why someone..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Kesaro Kibener**: ""Very funny, Mr. President."" |
| `[261]` | **""Because Contana has nothing to do with this and Article 6 is inherently racist.""** | `[290]` **Kesaro Kibener**: ""I do not understand why someone..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[302]` **Kesaro Kibener**: ""Does *the Malenyev* call himsel..." |
| `[264]` | **""Mr. Kibener has a point.""** | `[270]` **Nia Morgna**: ""I can't believe the words being..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[369]` **Frens Ricter**: ""He has. But our position as PFJ..." |
| `[269]` | **""I agree with Mr. Kibener. A United Sordland is what we need.""** | `[290]` **Kesaro Kibener**: ""I do not understand why someone..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Kesaro Kibener**: ""Exactly."" |
| `[271]` | **""And what is the position of the PFJP?""** | `[270]` **Nia Morgna**: ""I can't believe the words being..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Frens Ricter**: ""I personally somewhat agree wit..." |
| `[273]` | **""Neither can I. I think it's time we wrap this up.""** | `[270]` **Nia Morgna**: ""I can't believe the words being..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Petr Vectern**: ""Ladies and gentlemen. You've he..." |
| `[277]` | **""Tell me why we should pressure the Court to admit discrimination within the Const..."** | `[276]` **Petr Vectern**: ""I'm not sure if it's worth the ..."<br>`[362]` **Player**: ""I think I have enough informati..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true) == false` | `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] = ...` | `[278]` **Manoly Suheil**: ""Because it is the right thing t..." |
| `[280]` | **""And the NFP is willing to join in with that statement?""** | `[279]` **Frens Ricter**: ""We can show the people of Sordl..." | `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] == true) == false` | *Brak zmian stanu* | `[309]` **Kesaro Kibener**: ""No. We are willing to give our ..." |
| `[282]` | **""I have decided.""** | `[276]` **Petr Vectern**: ""I'm not sure if it's worth the ..."<br>`[362]` **Player**: ""I think I have enough informati..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_Nothing"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true` | *Brak zmian stanu* | `[320]` **Player**: ""The USP will join the statement..."<br>`[319]` **Player**: ""The USP will join the statement..."<br>*(oraz 1 innych odgałęzień)* |
| `[283]` | **""What do you think, Petr?""** | `[293]` **Remus Holstron**: ""I still think this is admitting..." | `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3"] == true) == false` | *Brak zmian stanu* | `[393]` **Narrator**: "Petr leaned in and whispered." |
| `[288]` | **""And how do you think the Supreme Court will react if we do it your way?""** | `[293]` **Remus Holstron**: ""I still think this is admitting..." | `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] == true) == false` | *Brak zmian stanu* | `[370]` **Kesaro Kibener**: ""I truly believe they will be co..." |
| `[308]` | **""Tell me why we should try to convince them to reiterate their position on Article..."** | `[276]` **Petr Vectern**: ""I'm not sure if it's worth the ..."<br>`[362]` **Player**: ""I think I have enough informati..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true) == false` | `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] = t...` | `[287]` **Kesaro Kibener**: ""Because it is the only way to d..." |
| `[315]` | **""Is the PFJP willing to join in with that statement?""** | `[293]` **Remus Holstron**: ""I still think this is admitting..." | `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] == true) == false` | *Brak zmian stanu* | `[316]` **Frens Ricter**: ""As much as I don't agree with i..." |
| `[317]` | **""I don't want to release a unified statement with the opposition. We will not invo..."** | `[384]` **Player**: ""I have already decided.""<br>`[485]` **Player**: ""I think I've heard enough.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Narrator**: "The representatives of both part..." |
| `[319]` | **""The USP will join the statement. We will argue that Bludish people are considered..."** | `[384]` **Player**: ""I have already decided.""<br>`[485]` **Player**: ""I think I've heard enough.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Kesaro Kibener**: ""That's great to hear. We will g..." |
| `[320]` | **""The USP will join the statement. We will argue that Articles 6 and 7 are inherent..."** | `[384]` **Player**: ""I have already decided.""<br>`[485]` **Player**: ""I think I've heard enough.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Frens Ricter**: ""That's great to hear. We will g..." |
| `[338]` | **""We will stay out of it. This isn't worth the risk.""** | `[364]` **Petr Vectern**: ""What are you saying, Anton?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Narrator**: "The representatives of both part..." |
| `[339]` | **""The USP will join the statement with the NFP. We will argue that Bludish people a..."** | `[364]` **Petr Vectern**: ""What are you saying, Anton?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Kesaro Kibener**: ""That's great to hear. We will g..." |
| `[362]` | **""I think I have enough information about the NFP's position. Let's hear the other ..."** | `[293]` **Remus Holstron**: ""I still think this is admitting..." | `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true) == false` | *Brak zmian stanu* | `[485]` **Player**: ""I think I've heard enough.""<br>`[277]` **Player**: ""Tell me why we should pressure ..."<br>*(oraz 2 innych odgałęzień)* |
| `[365]` | **""What do you suggest we do, Ms. Morgna?""** | `[293]` **Remus Holstron**: ""I still think this is admitting..." | `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] == true) == false` | *Brak zmian stanu* | `[376]` **Narrator**: "Nia leaned in and whispered." |
| `[384]` | **""I have already decided.""** | `[293]` **Remus Holstron**: ""I still think this is admitting..." | `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true` | *Brak zmian stanu* | `[320]` **Player**: ""The USP will join the statement..."<br>`[319]` **Player**: ""The USP will join the statement..."<br>*(oraz 1 innych odgałęzień)* |
| `[428]` | **""Why would I want to lose a governor from our party?""** | `[191]` **Manoly Suheil**: ""Because of the argument and the..." | `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true) == false`<br>`(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false` | *Brak zmian stanu* | `[443]` **Petr Vectern**: ""Exactly. This looks awfully lik..." |
| `[429]` | **""We are already aware of this case.""** | `[191]` **Manoly Suheil**: ""Because of the argument and the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Narrator**: "Nia raised her hand and spoke." |
| `[430]` | **""Please explain.""** | `[191]` **Manoly Suheil**: ""Because of the argument and the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Narrator**: "Nia raised her hand and spoke." |
| `[431]` | **""But what about those who don't want to be called a Sord?""** | `[344]` **Nia Morgna**: ""That is correct, Mr. President.""<br>`[427]` **Kesaro Kibener**: ""As a result, the resettlement p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Manoly Suheil**: ""Exactly. Unfortunately, our cur..." |
| `[432]` | **""As concerning as this all is, the Supreme Court must make its decision independen..."** | `[232]` **Frens Ricter**: ""I'm afraid Mr. Kibener is right..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[433]` **Frens Ricter**: ""How about your amendments? Will..." |
| `[434]` | **""Why do you even care? You and your party are not even giving support to it.""** | `[433]` **Frens Ricter**: ""How about your amendments? Will..." | `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true) == false` | *Brak zmian stanu* | `[299]` **Frens Ricter**: ""That is precisely why we care."" |
| `[435]` | **""Of course not. Their current say in the amendments is wrong, as that shouldn't be..."** | `[433]` **Frens Ricter**: ""How about your amendments? Will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Frens Ricter**: ""I agree with you...""<br>`[298]` **Frens Ricter**: ""Interesting..."" |
| `[437]` | **""I trust that they will do the right thing.""** | `[433]` **Frens Ricter**: ""How about your amendments? Will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Frens Ricter**: ""I agree with you...""<br>`[298]` **Frens Ricter**: ""Interesting..."" |
| `[438]` | **""I am just telling you how it should be, not what will happen.""** | `[433]` **Frens Ricter**: ""How about your amendments? Will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Frens Ricter**: ""I see."" |
| `[453]` | **""This doesn't fix the core of the problem.""** | `[344]` **Nia Morgna**: ""That is correct, Mr. President.""<br>`[427]` **Kesaro Kibener**: ""As a result, the resettlement p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Manoly Suheil**: ""Exactly. Unfortunately, our cur..." |
| `[454]` | **""That actually makes a lot of sense.""** | `[344]` **Nia Morgna**: ""That is correct, Mr. President.""<br>`[427]` **Kesaro Kibener**: ""As a result, the resettlement p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Frens Ricter**: ""It can work for the time being,..." |
| `[455]` | **""Sordland will not be threatened nor blackmailed by some 'massive' response from a..."** | `[232]` **Frens Ricter**: ""I'm afraid Mr. Kibener is right..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[457]` **Remus Holstron**: ""I agree with Mr. President."" |
| `[458]` | **""Hold on. If this meeting is going to turn into a racist summit, I will take my le..."** | `[84]` **Remus Holstron**: ""It seemed fitting.""<br>`[91]` **Manoly Suheil**: ""We thank the NFP for assisting ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[462]` **Frens Ricter**: ""No, Mr. President. It won't... ..." |
| `[459]` | **""I will hear you out. But know that I will not act on anything before talking to t..."** | `[84]` **Remus Holstron**: ""It seemed fitting.""<br>`[91]` **Manoly Suheil**: ""We thank the NFP for assisting ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Kesaro Kibener**: ""Let's get back on track, ladies..." |
| `[460]` | **""Alright. I'm listening.""** | `[84]` **Remus Holstron**: ""It seemed fitting.""<br>`[91]` **Manoly Suheil**: ""We thank the NFP for assisting ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Kesaro Kibener**: ""Let's get back on track, ladies..." |
| `[461]` | **""I am aware of this case. In fact, we are already working on revoking the current ..."** | `[191]` **Manoly Suheil**: ""Because of the argument and the..." | `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`<br>`(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false` | *Brak zmian stanu* | `[480]` **Manoly Suheil**: ""That's great to hear. We would ..." |
| `[463]` | **""I agree completely. In fact, we are already working on the possibility of changin..."** | `[191]` **Manoly Suheil**: ""Because of the argument and the..." | `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true` | *Brak zmian stanu* | `[493]` **Kesaro Kibener**: ""I'll be damned! So the rumors w..." |
| `[464]` | **""You sound like Ms. Graf.""** | `[154]` **Frens Ricter**: ""The situation is also connected..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Narrator**: "Nia smiled for a brief moment an..." |
| `[465]` | **""Doesn't that mean the existence of the Bludish people is literally not being ackn..."** | `[344]` **Nia Morgna**: ""That is correct, Mr. President.""<br>`[427]` **Kesaro Kibener**: ""As a result, the resettlement p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Manoly Suheil**: ""Exactly. Our current Constituti..." |
| `[476]` | **""What are your plans and suggestions?""** | `[199]` **Kesaro Kibener**: ""For peace and harmony in Sordla..."<br>`[201]` **Frens Ricter**: ""What do you want to know, Mr. P..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == false` | *Brak zmian stanu* | `[445]` **Kesaro Kibener**: ""In short, the plan is to releas..." |
| `[484]` | **""Is that true, Ms. Morgna?""** | `[427]` **Kesaro Kibener**: ""As a result, the resettlement p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Nia Morgna**: ""That is correct, Mr. President."" |
| `[485]` | **""I think I've heard enough.""** | `[276]` **Petr Vectern**: ""I'm not sure if it's worth the ..."<br>`[362]` **Player**: ""I think I have enough informati..."<br>*(oraz 14 innych węzłów)* | `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] == true`<br>`Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] == true` | *Brak zmian stanu* | `[320]` **Player**: ""The USP will join the statement..."<br>`[319]` **Player**: ""The USP will join the statement..."<br>*(oraz 1 innych odgałęzień)* |
| `[517]` | **""What do you suggest we do, Ms. Morgna?""** | `[279]` **Frens Ricter**: ""We can show the people of Sordl..." | `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] == true) == false` | *Brak zmian stanu* | `[549]` **Narrator**: "Nia leaned in and whispered." |
| `[521]` | **""So you're suggesting we join in with the PFJP's statement?""** | `[520]` **Nia Morgna**: ""We should push the Court from a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[565]` **Nia Morgna**: ""Of course."" |
| `[522]` | **""I disagree. We have to concede one point so as not to agitate them too much. Othe..."** | `[520]` **Nia Morgna**: ""We should push the Court from a..."<br>`[565]` **Nia Morgna**: ""Of course."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[364]` **Petr Vectern**: ""What are you saying, Anton?"" |
| `[523]` | **""I agree. We should pressure the Court to admit the discrimination within the Cons..."** | `[520]` **Nia Morgna**: ""We should push the Court from a..."<br>`[565]` **Nia Morgna**: ""Of course."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Frens Ricter**: ""That's great to hear. We will g..." |
| `[524]` | **""I'm not convinced. I want to hear from Mr. Ricter and Mr. Kibener first.""** | `[364]` **Petr Vectern**: ""What are you saying, Anton?""<br>`[520]` **Nia Morgna**: ""We should push the Court from a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[563]` **Petr Vectern**: ""Sure."" |
| `[543]` | **""I have already decided.""** | `[279]` **Frens Ricter**: ""We can show the people of Sordl..." | `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true` | *Brak zmian stanu* | `[320]` **Player**: ""The USP will join the statement..."<br>`[319]` **Player**: ""The USP will join the statement..."<br>*(oraz 1 innych odgałęzień)* |
| `[550]` | **""I think I have enough information about the PFJP's position. Let's hear the other..."** | `[279]` **Frens Ricter**: ""We can show the people of Sordl..." | `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true) == false` | *Brak zmian stanu* | `[485]` **Player**: ""I think I've heard enough.""<br>`[277]` **Player**: ""Tell me why we should pressure ..."<br>*(oraz 2 innych odgałęzień)* |
| `[582]` | **""I've heard enough.""** | `[199]` **Kesaro Kibener**: ""For peace and harmony in Sordla..."<br>`[201]` **Frens Ricter**: ""What do you want to know, Mr. P..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == false) == false` | *Brak zmian stanu* | `[508]` **Petr Vectern**: ""I think I have enough informati..." |
| `[584]` | **""Let's just jump straight into your proposal.""** | `[199]` **Kesaro Kibener**: ""For peace and harmony in Sordla..."<br>`[201]` **Frens Ricter**: ""What do you want to know, Mr. P..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == false` | *Brak zmian stanu* | `[445]` **Kesaro Kibener**: ""In short, the plan is to releas..." |
| `[585]` | **""I understand. And what does the PFJP think?""** | `[344]` **Nia Morgna**: ""That is correct, Mr. President.""<br>`[427]` **Kesaro Kibener**: ""As a result, the resettlement p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Frens Ricter**: ""I personally somewhat agree wit..." |

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
  - -> `[4]` (*Narrator: "The comically large amount of flags almost fully envelope..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)

### Węzeł `[3]`
Mówca: **Kesaro Kibener**
> ""Thank you for being here on this glorious day, Mr. President and Mr. Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Kesaro Kibener: ""As the former mayor of Jen, it is an honor to welcome yo..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The comically large amount of flags almost fully enveloped the buildings around the plaza in maroon, white and gold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "At the entrance, Kesaro Kibener, the head of the National..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "At the entrance, Kesaro Kibener, the head of the National Front Party, was waiting for us in his iconic brown suit, watching the sky."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Petr Vectern: ""Look at this guy. So full of himself.""*)

### Węzeł `[6]`
Mówca: **Kesaro Kibener**
> ""As the former mayor of Jen, it is an honor to welcome you to this fine city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: ""Thank you, Mr. Kibener.""*)
  - -> `[8]` (*Player: ""It looks like you were a good mayor. Maybe you should th..."*)
  - -> `[9]` (*Player: ""It is good to be here.""*)
  - -> `[10]` (*Player_Italic: "Shake his hand in silence."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Kibener.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "We shook hands."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It looks like you were a good mayor. Maybe you should think about running for local office again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Kesaro Kibener: ""Thanks for the kind words, but I'm sure I'll do an even ..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It is good to be here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "We shook hands."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "Shake his hand in silence."]** — Mówca: **Player_Italic**
> "I did not reply and simply shook his hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Petr Vectern: ""Thank you for organizing this, Mr. Kibener.""*)

### Węzeł `[11]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Petr Vectern: ""Thank you for organizing this, Mr. Kibener.""*)

### Węzeł `[12]`
Mówca: **Kesaro Kibener**
> ""Thanks for the kind words, but I'm sure I'll do an even better job as president. Besides, as you can see, our current mayor doesn't need my help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "We shook hands."*)

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""Thank you for organizing this, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Kesaro Kibener: ""The representatives of the PFJP and Minister Morgna are ..."*)

### Węzeł `[14]`
Mówca: **Kesaro Kibener**
> ""The representatives of the PFJP and Minister Morgna are already inside the private meeting room. Hopefully we'll be finished before the festivities start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Kesaro gestured at the doors behind him."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "Kesaro gestured at the doors behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Kesaro Kibener: ""Shall we?""*)

### Węzeł `[16]`
Mówca: **Kesaro Kibener**
> ""Shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: ""Please.""*)
  - -> `[18]` (*Player_Italic: "Nod."*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Please.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Kesaro Kibener: ""Just follow me.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Kesaro Kibener: ""Just follow me.""*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Before we go in... Is everything ready within your party? You know the vote is approaching.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true` AND `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Kesaro Kibener: ""I am aware, Mr. President. Don't worry.""*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_NFP_Convinced == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: ""Before we go in... Is everything ready within your party..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_NFP_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: ""Before we go in... Is there a way to get you back on the..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Before we go in... Is there a way to get you back on the table regarding the constitutional changes?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false` AND `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Kesaro Kibener: ""I'm afraid not.""*)

### Węzeł `[27]`
Mówca: **Kesaro Kibener**
> ""I am aware, Mr. President. Don't worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Bill == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Bill == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Bill == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Kesaro_Promise_Bill == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Bill == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Kesaro Kibener: ""The NFP will support the proposal if you hold up your en..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Kesaro_Promise_Bill == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Kesaro Kibener: ""The NFP will support the proposal if you don't bring us ..."*)

### Węzeł `[31]`
Mówca: **Kesaro Kibener**
> ""The NFP will support the proposal if you hold up your end of your bargain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Kesaro Kibener: ""But let's just go inside now. Please follow me.""*)

### Węzeł `[32]`
Mówca: **Kesaro Kibener**
> ""The NFP will support the proposal if you don't bring us new surprises at the last minute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Kesaro Kibener: ""But let's just go inside now. Please follow me.""*)

### Węzeł `[33]`
Mówca: **Kesaro Kibener**
> ""I'm afraid not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Kesaro Kibener: ""Besides, this is neither the time nor place to have such..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""Before we go in... is there any way we can discuss how y..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Before we go in... is there any way we can discuss how you can help us with the constitutional changes?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true` AND `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[16]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Kesaro Kibener: ""I'm afraid not.""*)

### Węzeł `[38]`
Mówca: **Kesaro Kibener**
> ""Besides, this is neither the time nor place to have such a conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: ""So be it.""*)
  - -> `[40]` (*Player: ""I understand.""*)
  - -> `[41]` (*Player: ""You're making a mistake.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So be it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Kesaro Kibener: ""Of course, I'm not saying nothing can change. The result..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Kesaro Kibener: ""Of course, I'm not saying nothing can change. The result..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're making a mistake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Kesaro Kibener: ""Come now, Mr. President. There is no need for such talk.""*)

### Węzeł `[42]`
Mówca: **Kesaro Kibener**
> ""Come now, Mr. President. There is no need for such talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Kesaro Kibener: ""Of course, I'm not saying nothing can change. The result..."*)

### Węzeł `[43]`
Mówca: **Kesaro Kibener**
> ""Just follow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "We entered the building and walked through a massive conf..."*)

### Węzeł `[44]`
Mówca: **Kesaro Kibener**
> ""But let's just go inside now. Please follow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "We entered the building and walked through a massive conf..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "We entered the building and walked through a massive conference hall until we approached a door towards the back of the building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Kesaro Kibener: ""We'll have the meeting here.""*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Kesaro opened the doors for us and we entered the meeting room. PFJP leader Frens Ricter and his deputy Manoly Suheil was already seated at the left side of the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "As soon as we entered, Nia came to greet us. After showin..."*)

### Węzeł `[47]`
Mówca: **Kesaro Kibener**
> ""We'll have the meeting here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Kesaro opened the doors for us and we entered the meeting..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "As soon as we entered, Nia came to greet us. After showing our seats, Kesaro sat down next to his deputy, Remus Holstron."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Kesaro Kibener: ""This is such a meaningful day. Thank you for coming here..."*)

### Węzeł `[49]`
Mówca: **Kesaro Kibener**
> ""This is such a meaningful day. Thank you for coming here on behalf of your parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Kesaro Kibener: ""But despite the festive atmosphere, we and the PFJP want..."*)

### Węzeł `[50]`
Mówca: **Kesaro Kibener**
> ""But despite the festive atmosphere, we and the PFJP want to raise a few important concerns about the worrying state of affairs in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Kesaro stopped for a moment to check his notes."*)

### Węzeł `[51]`
Mówca: **Manoly Suheil**
> ""I'm sorry to interrupt, but the analysis is about racism and radicalization in Sordland. And our main topic is the case of 'Ersen v. Sordland'. Please don't try to spin it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Kesaro Kibener: ""Of course, Ms. Suheil. Mr. Holstron just wanted to point..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Kesaro stopped for a moment to check his notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Remus Holstron: ""Very worrying, indeed.""*)

### Węzeł `[53]`
Mówca: **Remus Holstron**
> ""Mr. Ricter and his analysts have been working on an analysis of the Blud problem. As soon as they brought it up, we gave our support without reservations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Nia Morgna: ""The *Blud problem*?""*)

### Węzeł `[54]`
Mówca: **Petr Vectern**
> ""Look at this guy. So full of himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Petr Vectern: ""How did this clown convince the PFJP to have trilateral ..."*)

### Węzeł `[55]`
Mówca: **Petr Vectern**
> ""How did this clown convince the PFJP to have trilateral talks with them anyway?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: ""Probably the same reason why we're here. It's Victory Da..."*)
  - -> `[56]` (*Player: ""Honestly, it says more about Frens and the PFJP.""*)
  - -> `[58]` (*Player: ""He's a dangerously competent man, Petr. We should be cau..."*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, it says more about Frens and the PFJP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Petr Vectern: ""I don't trust them.""*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Probably the same reason why we're here. It's Victory Day, remember?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Petr Vectern: ""How can I forget? Lucian nagged about the importance of ..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He's a dangerously competent man, Petr. We should be cautious with him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Petr Vectern: ""I agree.""*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_NFP_Convinced == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: ""Try not to agitate him, Petr. Don't forget, he's our par..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_NFP_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Try not to agitate him, Petr. Don't forget, he's our partner for now and we need his vote.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Kontekst wejściowy (poprzednik):** `[55]` (Petr Vectern), `[403]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Petr Vectern: ""Of course.""*)

### Węzeł `[63]`
Mówca: **Petr Vectern**
> ""How can I forget? Lucian nagged about the importance of the day for 20 minutes straight. It broke my soul.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Seeing us arrive, Kesaro approached us with a smile."*)

### Węzeł `[64]`
Mówca: **Petr Vectern**
> ""I don't trust them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Seeing us arrive, Kesaro approached us with a smile."*)

### Węzeł `[65]`
Mówca: **Petr Vectern**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Seeing us arrive, Kesaro approached us with a smile."*)

### Węzeł `[66]`
Mówca: **Petr Vectern**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Seeing us arrive, Kesaro approached us with a smile."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Seeing us arrive, Kesaro approached us with a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Kesaro Kibener: ""Thank you for being here on this glorious day, Mr. Presi..."*)

### Węzeł `[68]`
Mówca: **Kesaro Kibener**
> ""Mr. Hol-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Manoly Suheil: ""I'm sorry to interrupt, but the analysis is about racism..."*)

### Węzeł `[69]`
Mówca: **Kesaro Kibener**
> ""Of course, Ms. Suheil. Mr. Holstron just wanted to point out that this analysis was focused mainly on topics related to the Bludish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: ""Why are we discussing this on Victory Day?""*)
  - -> `[90]` (*Player: ""I'm surprised that your parties have conducted a joint a..."*)
  - -> `[82]` (*Player: ""I refuse to discuss this topic without any Bludish repre..."*)

### Węzeł `[70]`
Mówca: **Kesaro Kibener**
> ""I want to give the word to Mr. Ricter to explain the issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Frens Ricter: ""Thank you.""*)

### Węzeł `[71]`
Mówca: **Frens Ricter**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Frens Ricter: ""Our analysis of the current tensions between the Bludish..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "He gestured at Frens."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Kesaro Kibener: ""I want to give the word to Mr. Ricter to explain the iss..."*)

### Węzeł `[73]`
Mówca: **Frens Ricter**
> ""Our analysis of the current tensions between the Bludish and Sordish population in Sordland displays a worrying picture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Frens Ricter: ""As much as I hate to say it, the threat of the Bludish F..."*)

### Węzeł `[74]`
Mówca: **Frens Ricter**
> ""The increasingly discriminatory actions of the Governor of Bergia are resulting in the radicalization of many young Bludish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Frens Ricter: ""Distressingly, it exploded out of control after the pres..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Frens Ricter: ""Distressingly, the number of radicals have almost double..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Frens Ricter: ""Distressingly, the number of radicals have increased sig..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why are we discussing this on Victory Day?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Remus Holstron: ""It seemed fitting.""*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I refuse to discuss this topic without any Bludish representation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Nia Morgna: ""Actually, Mr. President is completely right.""*)

### Węzeł `[83]`
Mówca: **Remus Holstron**
> ""Very worrying, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Remus Holstron: ""Mr. Ricter and his analysts have been working on an anal..."*)

### Węzeł `[84]`
Mówca: **Remus Holstron**
> ""It seemed fitting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Player: ""Hold on. If this meeting is going to turn into a racist ..."*)
  - -> `[459]` (*Player: ""I will hear you out. But know that I will not act on any..."*)
  - -> `[460]` (*Player: ""Alright. I'm listening.""*)

### Węzeł `[85]`
Mówca: **Kesaro Kibener**
> ""Let's get back on track, ladies and gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "He gestured at Frens."*)

### Węzeł `[86]`
Mówca: **Frens Ricter**
> ""Distressingly, it exploded out of control after the presidency gave support to Operation Bear Trap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[87]`
Mówca: **Frens Ricter**
> ""Distressingly, the number of radicals have almost doubled after the implication of our armed forces in the Operation Bear Trap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[88]`
Mówca: **Frens Ricter**
> ""Distressingly, the number of radicals have increased significantly after Wehlen's Operation Bear Trap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[89]`
Mówca: **Frens Ricter**
> ""Unfortunately, the NFP's Religious Harmony Bill was also signed into law despite our protests. Which did nothing to ease the tensions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Kesaro Kibener: ""That bill targets the secessionist propaganda apparatus...."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm surprised that your parties have conducted a joint analysis.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Manoly Suheil: ""We thank the NFP for assisting our research, of course. ..."*)

### Węzeł `[91]`
Mówca: **Manoly Suheil**
> ""We thank the NFP for assisting our research, of course. But this is by no means a joint analysis. Our parties have vastly different opinions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Player: ""Hold on. If this meeting is going to turn into a racist ..."*)
  - -> `[459]` (*Player: ""I will hear you out. But know that I will not act on any..."*)
  - -> `[460]` (*Player: ""Alright. I'm listening.""*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Frens Ricter: ""Unfortunately, the NFP's Religious Harmony Bill was also..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Kesaro Kibener: ""I must also point out that the recruitment numbers of th..."*)

### Węzeł `[95]`
Mówca: **Kesaro Kibener**
> ""That bill targets the secessionist propaganda apparatus. I must point out that the recruitment numbers of the BFF have significantly reduced since the law's implementation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Petr frantically looked through his papers."*)

### Węzeł `[96]`
Mówca: **Kesaro Kibener**
> ""As the threat the BFF poses is a direct one, this issue requires direct actions that lead to direct results -- which seem to be proving successful as fact-checked by the Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: ""It's good to see that the new laws are working.""*)
  - -> `[101]` (*Player: ""I'm regretting my decision to sign that bill.""*)
  - -> `[102]` (*Player: ""Do you have any suggestions?""*)

### Węzeł `[97]`
Mówca: **Kesaro Kibener**
> ""I must also point out that the recruitment numbers of the BFF have significantly increased within Nurist communities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Petr frantically looked through his papers."*)

### Węzeł `[98]`
Mówca: **Kesaro Kibener**
> ""The Religious Harmony Bill would have directly crippled this network they established within our sanctuaries. As the threat the BFF poses is a direct one, this issue requires direct actions that would bear direct results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Kesaro Kibener: ""I'm disappointed by the lack of action taken by the USP ..."*)

### Węzeł `[99]`
Mówca: **Frens Ricter**
> ""As much as I hate to say it, the threat of the Bludish Freedom Front is getting real again. The situation with Rumburg and Wehlen is very concerning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Frens Ricter: ""The increasingly discriminatory actions of the Governor ..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's good to see that the new laws are working.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Remus Holstron: ""They are working, but it is not enough.""*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm regretting my decision to sign that bill.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Manoly Suheil: ""You should have controlled your party before they gave s..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you have any suggestions?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Bill == true"*)

### Węzeł `[103]`
Mówca: **Kesaro Kibener**
> ""I'm disappointed by the lack of action taken by the USP administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: ""Your bill would have unnecessarily raised the already hi..."*)
  - -> `[106]` (*Player: ""I'm regretting my decision to veto that bill.""*)
  - -> `[183]` (*Player: ""Your bill would have made everything worse.""*)
  - -> `[105]` (*Player: ""And what do you suggest we do?""*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your bill would have unnecessarily raised the already high tensions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Manoly Suheil: ""You did well by vetoing it, Mr. President.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And what do you suggest we do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Bill == true"*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm regretting my decision to veto that bill.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Remus Holstron: ""We can still right our wrongs.""*)

### Węzeł `[107]`
Mówca: **Remus Holstron**
> ""We can still right our wrongs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Bill == true"*)

### Węzeł `[108]`
Mówca: **Manoly Suheil**
> ""You did well by vetoing it, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Bill == true"*)

### Węzeł `[109]`
Mówca: **Remus Holstron**
> ""They are working, but it is not enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Bill == true"*)

### Węzeł `[110]`
Mówca: **Manoly Suheil**
> ""You should have controlled your party before they gave support to that bill in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Petr Vectern: ""Let's refrain from making comments about the internal af..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Bill == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Bill == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Kesaro_Promise_Bill == true)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Bill == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Kesaro Kibener: ""One of my suggestions to you was to finally enforce the ..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Kesaro_Promise_Bill == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Kesaro Kibener: ""Our suggestion is to finally enforce the official langua..."*)

### Węzeł `[114]`
Mówca: **Kesaro Kibener**
> ""Our suggestion is to finally enforce the official language of our country as stated in the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Kesaro Kibener: ""We are working on the Unified Language Act. It is direct..."*)

### Węzeł `[115]`
Mówca: **Kesaro Kibener**
> ""One of my suggestions to you was to finally enforce the official language of our country as stated in the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Kesaro Kibener: ""Of course, you have already promised to support it, so w..."*)

### Węzeł `[116]`
Mówca: **Kesaro Kibener**
> ""Of course, you have already promised to support it, so we are already aligned on that matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Narrator: "Nia's eyes blazed with fury."*)

### Węzeł `[117]`
Mówca: **Kesaro Kibener**
> ""We are working on the Unified Language Act. It is directly aimed at the breeding grounds of the Bludish Freedom Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Remus Holstron: ""The police have infiltrated 32 BFF training grounds in r..."*)

### Węzeł `[118]`
Mówca: **Nia Morgna**
> ""You can't take away the Bludish people's right to be educated in their own language. This is insane.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Kesaro Kibener: ""Please read the proposal carefully. It does not take awa..."*)

### Węzeł `[119]`
Mówca: **Kesaro Kibener**
> ""Please read the proposal carefully. It does not take away anyone's rights. It only gives the state a way to control the radicalization in these schools that teach Bludish nationalist propaganda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Kesaro Kibener: ""And according to the Constitution, the language of Sordl..."*)

### Węzeł `[120]`
Mówca: **Kesaro Kibener**
> ""True. It does not ban Bludish language or Bludish education. It will instead make Sordish mandatory to learn for everyone living in this country. This will only decrease the tensions in the long term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Frens Ricter: ""That's a fair point. However, the wording of the bill is..."*)

### Węzeł `[121]`
Mówca: **Frens Ricter**
> ""That's a fair point. However, the wording of the bill is far too vague to work as intended. It gives the government too much power over educational institutes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Kesaro Kibener: ""I disagree. The language is quite clear and is in line w..."*)

### Węzeł `[122]`
Mówca: **Kesaro Kibener**
> ""I disagree. The language is quite clear and is in line with the Constitution. But we can still improve it, of course. It is true that it gives more control, but it is a necessary compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Bill == true"*)
  - -> `[129]` (*Player: ""I'll have to read it in detail to decide if I can suppor..."*)
  - -> `[130]` (*Player: ""I don't see how this helps with the situation.""*)
  - -> `[133]` (*Player: ""Even if the Assembly supports it, I will surely be using..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As I've promised before, I'll sign the bill when it reaches me.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true`
- **Kontekst wejściowy (poprzednik):** `[122]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Manoly Suheil: ""The PFJP will not allow this bill to pass the Assembly.""*)

### Węzeł `[124]`
Mówca: **Narrator**
> "Manoly looked furious. She opened her mouth to respond, then read the room and closed it again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Remus Holstron: ""As if the PFJP has the influence to change the outcome...""*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Bill == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Bill == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Kesaro_Promise_Bill == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Bill == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""As I've promised before, I'll sign the bill when it reac..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Kesaro_Promise_Bill == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: ""I'll sign the bill if it reaches me.""*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll sign the bill if it reaches me.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[122]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Manoly Suheil: ""The PFJP will not allow this bill to pass the Assembly.""*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll have to read it in detail to decide if I can support it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Manoly Suheil: ""The PFJP will not allow this bill to pass the Assembly.""*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't see how this helps with the situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Manoly Suheil: ""It doesn't. It's simple as that.""*)

### Węzeł `[131]`
Mówca: **Remus Holstron**
> ""The police have infiltrated 32 BFF training grounds in remote towns around Bergia that posed as middle schools. Despite all the evidence, similar schools keep popping up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Remus Holstron: ""And so-called activists are constantly blocking Governor..."*)

### Węzeł `[132]`
Mówca: **Remus Holstron**
> ""And so-called activists are constantly blocking Governor Bron's attempts to stop these schools, claiming he is attacking their *right to language*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Nia Morgna: ""You can't take away the Bludish people's right to be edu..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Even if the Assembly supports it, I will surely be using my veto on it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Bill == true"*)

### Węzeł `[134]`
Mówca: **Kesaro Kibener**
> ""Is that so?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Kesaro Kibener: ""Then you'll see what happens with your constitution.""*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Bill == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Bill == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Kesaro_Promise_Bill == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Bill == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Kesaro Kibener: ""Is that so?""*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Kesaro_Promise_Bill == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Kesaro_Promise_Bill"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)

### Węzeł `[138]`
Mówca: **Kesaro Kibener**
> ""Then you'll see what happens with your constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Manoly Suheil: ""The PFJP will not allow this bill to pass the Assembly.""*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_NFP_Convinced == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Kesaro Kibener: ""I wouldn't be so quick, if I were you.""*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_NFP_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_NFP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Kesaro Kibener: ""If I were you, I wouldn't stand in the way of the majori..."*)

### Węzeł `[142]`
Mówca: **Kesaro Kibener**
> ""I wouldn't be so quick, if I were you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Kesaro Kibener: ""The NFP would surely expect a gesture before the *big* v..."*)

### Węzeł `[143]`
Mówca: **Kesaro Kibener**
> ""The NFP would surely expect a gesture before the *big* vote, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Manoly Suheil: ""The PFJP will not allow this bill to pass the Assembly.""*)

### Węzeł `[144]`
Mówca: **Manoly Suheil**
> ""It doesn't. It's simple as that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Manoly Suheil: ""The PFJP will not allow this bill to pass the Assembly.""*)

### Węzeł `[145]`
Mówca: **Manoly Suheil**
> ""The PFJP will not allow this bill to pass the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Frens Ricter: ""Let's not make statements that the party hasn't agreed o..."*)

### Węzeł `[146]`
Mówca: **Frens Ricter**
> ""Let's not make statements that the party hasn't agreed on yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Manoly looked furious. She opened her mouth to respond, t..."*)

### Węzeł `[147]`
Mówca: **Kesaro Kibener**
> ""If I were you, I wouldn't stand in the way of the majority, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Manoly Suheil: ""The PFJP will not allow this bill to pass the Assembly.""*)

### Węzeł `[148]`
Mówca: **Petr Vectern**
> ""Hold up, guys. Let's hear them out first. We are representing the parties of the Assembly here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Frens Ricter: ""We did invite the representatives of the Workers Party o..."*)

### Węzeł `[149]`
Mówca: **Petr Vectern**
> ""That seems to be correct. The reports show that the new laws definitely struck a blow to the BFF's religious wing and their recruitment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Kesaro Kibener: ""As the threat the BFF poses is a direct one, this issue ..."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "Petr frantically looked through his papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Petr Vectern: ""That seems to be correct. The reports show that the new ..."*)

### Węzeł `[151]`
Mówca: **Petr Vectern**
> ""That is correct. The reports show that 39 Nurist sanctuaries in Bergia are now classified as 'red threats' by the authorities. Many priests in the region are also suspected of having ties to the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Kesaro Kibener: ""The Religious Harmony Bill would have directly crippled ..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "Petr frantically looked through his papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Petr Vectern: ""That is correct. The reports show that 39 Nurist sanctua..."*)

### Węzeł `[153]`
Mówca: **Frens Ricter**
> ""If I may continue with our analysis...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Frens Ricter: ""The situation is also connected to Rumburg, as everybody..."*)

### Węzeł `[154]`
Mówca: **Frens Ricter**
> ""The situation is also connected to Rumburg, as everybody already knows. In the case of a future incursion, BFF forces in Sordland could become an existential threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true ..."*)
  - -> `[160]` (*Player: ""With all due respect, I already received this informatio..."*)
  - -> `[464]` (*Player: ""You sound like Ms. Graf.""*)
  - -> `[161]` (*Player: ""Maybe the NFP influences you more than you think, Mr. Ri..."*)

### Węzeł `[155]`
Mówca: **Frens Ricter**
> ""As much I now support a strict response against the BFF, it must also be coupled with the expansion of rights for the Bludish people. This is the only way to fight against radicalization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Remus Holstron: ""That is BFF propaganda. What rights are we talking about..."*)

### Węzeł `[156]`
Mówca: **Remus Holstron**
> ""That is BFF propaganda. What rights are we talking about here? What can a Sord in Sordland do that a Blud cannot?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Remus Holstron: ""You are using soft language as a cover-up for your willi..."*)

### Węzeł `[157]`
Mówca: **Remus Holstron**
> ""You are using soft language as a cover-up for your willingness to negotiate with terrorists. You are a BFF apologist, Mr. Ricter!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "Remus shouted the last sentence. Petr tapped on the table..."*)

### Węzeł `[158]`
Mówca: **Petr Vectern**
> ""Let's refrain from making comments about the internal affairs of the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Bill == true"*)

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's why we have to remove the authority of the governor.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Kontekst wejściowy (poprzednik):** `[154]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Frens Ricter: ""It's great that we're aligned on that matter.""*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""With all due respect, I already received this information from Internal Affairs. Tell us something we don't know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Frens Ricter: ""Just let me finish, Mr. President.""*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Maybe the NFP influences you more than you think, Mr. Ricter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Frens Ricter: ""Just let me finish, Mr. President.""*)

### Węzeł `[162]`
Mówca: **Narrator**
> "He adjusted his tie and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Frens Ricter: ""Our analysis matches with what the Ministry of Interior ..."*)

### Węzeł `[163]`
Mówca: **Frens Ricter**
> ""Just let me finish, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "He adjusted his tie and continued."*)

### Węzeł `[164]`
Mówca: **Frens Ricter**
> ""Our analysis matches with what the Ministry of Interior shared with us. But despite this fact, we believe the ministry is hiding information from us, which is actively fuelling the tensions behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Frens Ricter: ""As much I now support a strict response against the BFF,..."*)

### Węzeł `[165]`
Mówca: **Petr Vectern**
> ""Please don't raise your voice, Mr. Holstron.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "The mood in the room had turned sour."*)

### Węzeł `[166]`
Mówca: **Remus Holstron**
> ""Is the USP that desperate for Mr. Ricter's support now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "Manoly bellowed out a loud laugh."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Remus Holstron: ""Is the USP that desperate for Mr. Ricter's support now?""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Remus Holstron: ""I didn't know you were Mr. Ricter's lawyer, Mr. Vice Pre..."*)

### Węzeł `[170]`
Mówca: **Remus Holstron**
> ""I didn't know you were Mr. Ricter's lawyer, Mr. Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "Manoly bellowed out a loud laugh."*)

### Węzeł `[171]`
Mówca: **Narrator**
> "Remus shouted the last sentence. Petr tapped on the table to get his attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Petr Vectern: ""Please don't raise your voice, Mr. Holstron.""*)

### Węzeł `[172]`
Mówca: **Narrator**
> "Manoly bellowed out a loud laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Manoly Suheil: ""Mr. Vectern is the last person that we'd rely on to defe..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""From now on, nobody speaks until the speaker finishes their point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Kesaro and Petr nodded."*)

### Węzeł `[174]`
Mówca: **Petr Vectern**
> ""What is that supposed to mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player: ""Enough!""*)
  - -> `[177]` (*Player: ""Can we return to the topic?""*)
  - -> `[181]` (*Player: ""This is a mess. I thought we were here for a proper meet..."*)

### Węzeł `[175]`
Mówca: **Narrator**
> "Everybody went silent and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player: ""From now on, nobody speaks until the speaker finishes th..."*)
  - -> `[177]` (*Player: ""Can we return to the topic?""*)
  - -> `[181]` (*Player: ""This is a mess. I thought we were here for a proper meet..."*)

### Węzeł `[176]`
Mówca: **Narrator**
> "Manoly bellowed out a loud laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Manoly Suheil: ""Mr. Vectern is the last person to sway the PFJP.""*)

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Can we return to the topic?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Petr Vectern), `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Kesaro and Petr nodded."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "The mood in the room had turned sour."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)

### Węzeł `[179]`
Mówca: **Manoly Suheil**
> ""Mr. Vectern is the last person to sway the PFJP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Petr Vectern: ""What is that supposed to mean?""*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Enough!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Everybody went silent and looked at me."*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is a mess. I thought we were here for a proper meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Petr Vectern), `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Kesaro and Petr nodded."*)

### Węzeł `[182]`
Mówca: **Manoly Suheil**
> ""Mr. Vectern is the last person that we'd rely on to defend us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Petr Vectern: ""What is that supposed to mean?""*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your bill would have made everything worse.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Manoly Suheil: ""You did well by vetoing it, Mr. President.""*)

### Węzeł `[184]`
Mówca: **Narrator**
> "Kesaro and Petr nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Kesaro Kibener: ""You heard the man.""*)

### Węzeł `[185]`
Mówca: **Kesaro Kibener**
> ""You heard the man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Kesaro Kibener: ""Please finish your point, Mr. Ricter.""*)

### Węzeł `[186]`
Mówca: **Kesaro Kibener**
> ""Please finish your point, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Frens Ricter: ""We require your support with a more pressing matter. Thi..."*)

### Węzeł `[187]`
Mówca: **Manoly Suheil**
> ""Mr. President. Mr. Vice President. And Ms. Minister. As you already know, there is a major Supreme Court case at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Manoly Suheil: ""Ishval Ersen is suing the Governor of Bergia, Phelix Bro..."*)

### Węzeł `[188]`
Mówca: **Frens Ricter**
> ""We require your support with a more pressing matter. This might have very significant consequences for our Bludish citizens and may serve as a dangerous trigger if we're not careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "Frens gestured at Manoly. She carefully placed several pi..."*)

### Węzeł `[189]`
Mówca: **Narrator**
> "Frens gestured at Manoly. She carefully placed several pieces of paper in front of her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Manoly Suheil: ""Mr. President. Mr. Vice President. And Ms. Minister. As ..."*)

### Węzeł `[190]`
Mówca: **Manoly Suheil**
> ""Ishval Ersen is suing the Governor of Bergia, Phelix Bron, for infringing upon the liberties of Bludish people and demands that the constitution be revised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Manoly Suheil: ""Because of the argument and the implications, Phelix Bro..."*)

### Węzeł `[191]`
Mówca: **Manoly Suheil**
> ""Because of the argument and the implications, Phelix Bron and, consequently, the very constitution of Sordland is under trial. The fact is, he needs to be punished and the Constitution must be reviewed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[429]` (*Player: ""We are already aware of this case.""*)
  - -> `[430]` (*Player: ""Please explain.""*)

### Węzeł `[192]`
Mówca: **Remus Holstron**
> ""With all due respect, Mr. Kibener, this bill is not strong enough. The Bludish language should be completely banned. You know people like Ms. Suheil or Ms. Morgna will never even vote for your watered-down bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Kesaro Kibener: ""Remus.""*)

### Węzeł `[193]`
Mówca: **Nia Morgna**
> ""I was actively involved in this case. Because of the implications with the constitution, there is no way the Supreme Court will agree with Ishval Ersen on all of the points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Frens Ricter: ""Not if all three parties of the Assembly support Ersen t..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "Nia raised her hand and spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Nia Morgna: ""I was actively involved in this case. Because of the imp..."*)

### Węzeł `[195]`
Mówca: **Frens Ricter**
> ""Not if all three parties of the Assembly support Ersen together. We can put pressure on them. And we only need them to agree on a few of those points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player: ""And why do you think it would influence the Court's deci..."*)
  - -> `[207]` (*Player: ""All parties? Is the NFP really willing to support Ersen,..."*)
  - -> `[208]` (*Player: ""I'm listening.""*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's the significance of this case?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == false`
- **Kontekst wejściowy (poprzednik):** `[199]` (Kesaro Kibener), `[201]` (Frens Ricter), `[209]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Kesaro Kibener: ""I'll be straight with you, Mr. President. If the Court r..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ErsenQuestions`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 == false"*)
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option2 == false"*)
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option3 == false"*)

### Węzeł `[198]`
Mówca: **Narrator**
> "Kesaro repositioned himself on his chair and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Kesaro Kibener: ""True. It does not ban Bludish language or Bludish educat..."*)

### Węzeł `[199]`
Mówca: **Kesaro Kibener**
> ""For peace and harmony in Sordland, yes. But perhaps we must clarify the details first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "ErsenQuestions"*)

### Węzeł `[200]`
Mówca: **Frens Ricter**
> ""This never happened before, Mr. President. They surely cannot ignore us if all three parties are united and if we provide them with our analyses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Frens Ricter: ""Besides, if the NFP can see the necessity in de-escalati..."*)

### Węzeł `[201]`
Mówca: **Frens Ricter**
> ""What do you want to know, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "ErsenQuestions"*)

### Węzeł `[202]`
Mówca: **Kesaro Kibener**
> ""Remus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "Kesaro repositioned himself on his chair and continued."*)

### Węzeł `[203]`
Mówca: **Frens Ricter**
> ""We did invite the representatives of the Workers Party of Bludia to join us, but they refused.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Remus Holstron: ""Another proof that they have a different agenda. If they..."*)

### Węzeł `[204]`
Mówca: **Remus Holstron**
> ""Another proof that they have a different agenda. If they were genuinely concerned for the plight of their people, they would have come today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Remus Holstron: ""But their people shouldn't worry. The Sordish patriots a..."*)

### Węzeł `[205]`
Mówca: **Remus Holstron**
> ""But their people shouldn't worry. The Sordish patriots are here to defend them instead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Player: ""Hold on. If this meeting is going to turn into a racist ..."*)
  - -> `[459]` (*Player: ""I will hear you out. But know that I will not act on any..."*)
  - -> `[460]` (*Player: ""Alright. I'm listening.""*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And why do you think it would influence the Court's decision?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Frens Ricter: ""This never happened before, Mr. President. They surely c..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All parties? Is the NFP really willing to support Ersen, Mr. Kibener?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Kesaro Kibener: ""For peace and harmony in Sordland, yes. But perhaps we m..."*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm listening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Frens Ricter: ""What do you want to know, Mr. President?""*)

### Węzeł `[209]`
Mówca: **Frens Ricter**
> ""We must be hopeful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "ErsenQuestions"*)

### Węzeł `[210]`
Mówca: **Kesaro Kibener**
> ""Because the case is now in the hands of the Supreme Court, this ruling will influence all future implementation of the law and the decision-making of the lower courts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Kesaro Kibener: ""We have the Minister of Justice here with us too. I'm su..."*)

### Węzeł `[211]`
Mówca: **Kesaro Kibener**
> ""I and the NFP are ready to push for de-escalation and aid our nation during this dangerous time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Nia Morgna: ""I'll be completely honest. I would never have expected t..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "Remus was visibly annoyed but kept himself silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Kesaro Kibener: ""Because the case is now in the hands of the Supreme Cour..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What is the most likely outcome of this case?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == false`
- **Kontekst wejściowy (poprzednik):** `[199]` (Kesaro Kibener), `[201]` (Frens Ricter), `[209]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Nia Morgna: ""The first and most likely option is that the Supreme Cou..."*)

### Węzeł `[214]`
Mówca: **Frens Ricter**
> ""Besides, if the NFP can see the necessity in de-escalation, I'm sure the Sollist judges can too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: ""I hope you are right.""*)
  - -> `[216]` (*Player: ""Oh, Frens. How naive of you.""*)
  - -> `[237]` (*Player: ""So you just *believe* in Hawker and hope for the best? I..."*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope you are right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Frens Ricter: ""We must be hopeful.""*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, Frens. How naive of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Manoly glanced at Frens. Her eyes showed her agreement wi..."*)

### Węzeł `[217]`
Mówca: **Remus Holstron**
> ""As if the PFJP has the influence to change the outcome...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Frens Ricter: ""If I may continue with our analysis...""*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry. Our armed forces are capable of handling any threat.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == false`
- **Kontekst wejściowy (poprzednik):** `[241]` (Kesaro Kibener), `[292]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Remus Holstron: ""May Nur bless our valiant warriors.""*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == false"*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Decrease == false)"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player: ""Don't worry. Our armed forces are capable of handling an..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Decrease == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think the threat is exaggerated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Kesaro Kibener), `[292]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Frens Ricter: ""I can't believe I'm saying this, but it's not. We normal..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We can't allow that to happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Frens Ricter: ""We definitely can't.""*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be honest with you. I'm not feeling very comfortable talking about Bludish rights with the NFP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Kesaro Kibener: ""I understand where this comes from, Mr. President. But p..."*)

### Węzeł `[225]`
Mówca: **Kesaro Kibener**
> ""I understand where this comes from, Mr. President. But please do not act like we are an anti-Blud party. Don't forget, we have members and supporters with Blud blood too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Petr Vectern: ""Oh, wow. Good for you guys.""*)

### Węzeł `[226]`
Mówca: **Remus Holstron**
> ""May Nur bless our valiant warriors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Frens Ricter: ""I hope the armed forces will not be necessary. For the s..."*)

### Węzeł `[227]`
Mówca: **Frens Ricter**
> ""I can't believe I'm saying this, but it's not. We normally don't trust government data, but our own analysis came up mostly in line with the reports from the Ministry of the Interior and the Ministry of Defense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Frens Ricter: ""I wouldn't say this for most other topics, but in the ca..."*)

### Węzeł `[228]`
Mówca: **Frens Ricter**
> ""We definitely can't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 = true"*)

### Węzeł `[229]`
Mówca: **Nia Morgna**
> ""If they ignore all of the points and strike against Ersen, Governor Bron will be free to follow his discriminatory policies without any obstacles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Nia Morgna: ""And in a possible future case, the Court's interpretatio..."*)

### Węzeł `[230]`
Mówca: **Nia Morgna**
> ""And in a possible future case, the Court's interpretation of the Ersen case will be the basis of all future rulings, which opens the way of suspending the rights of non-Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Nia Morgna: ""It would effectively erase any progress that has been ma..."*)

### Węzeł `[231]`
Mówca: **Nia Morgna**
> ""The first and most likely option is that the Supreme Court completely ignores the arguments and rejects it in its entirety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Nia Morgna: ""If they ignore all of the points and strike against Erse..."*)

### Węzeł `[232]`
Mówca: **Frens Ricter**
> ""I'm afraid Mr. Kibener is right about this. If the Court ignores this case now, this may turn into something... massive. Therefore we have to pressure the Court not to escalate the already high tensions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player: ""What do you really think will happen if the Court ignore..."*)
  - -> `[455]` (*Player: ""Sordland will not be threatened nor blackmailed by some ..."*)
  - -> `[432]` (*Player: ""As concerning as this all is, the Supreme Court must mak..."*)

### Węzeł `[233]`
Mówca: **Kesaro Kibener**
> ""I'll be straight with you, Mr. President. If the Court rules against Ersen, this will most likely turn into a BFF campaign for a Bludish revolution. We ask everybody to recognize this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Kesaro Kibener: ""I and the NFP are ready to push for de-escalation and ai..."*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What do you really think will happen if the Court ignores it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Kesaro Kibener: ""Another all-out BFF rebellion, Mr. President.""*)

### Węzeł `[235]`
Mówca: **Kesaro Kibener**
> ""Another all-out BFF rebellion, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Remus Holstron: ""In my opinion, that would be the preferred outcome. If e..."*)

### Węzeł `[236]`
Mówca: **Frens Ricter**
> ""I wouldn't say this for most other topics, but in the case of the threat of the BFF and radicalization, you should maybe listen to your cabinet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 = true"*)

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So you just *believe* in Hawker and hope for the best? I thought you would have a better plan than this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Manoly glanced at Frens. Her eyes showed her agreement wi..."*)

### Węzeł `[238]`
Mówca: **Remus Holstron**
> ""In my opinion, that would be the preferred outcome. If enemies do truly live within our borders, I'd rather have them show their true faces earlier than later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Kesaro Kibener: ""This is exactly what those damn Rums want. They are read..."*)

### Węzeł `[239]`
Mówca: **Petr Vectern**
> ""Oh, wow. Good for you guys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 = true"*)

### Węzeł `[240]`
Mówca: **Narrator**
> "Manoly glanced at Frens. Her eyes showed her agreement with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "ErsenQuestions"*)

### Węzeł `[241]`
Mówca: **Kesaro Kibener**
> ""This is exactly what those damn Rums want. They are readying for war and waiting to use the tensions inside Sordland against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == false"*)
  - -> `[222]` (*Player: ""I think the threat is exaggerated.""*)
  - -> `[223]` (*Player: ""We can't allow that to happen.""*)
  - -> `[224]` (*Player: ""I'll be honest with you. I'm not feeling very comfortabl..."*)

### Węzeł `[242]`
Mówca: **Frens Ricter**
> ""I hope the armed forces will not be necessary. For the sake of us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 = true"*)

### Węzeł `[243]`
Mówca: **Nia Morgna**
> ""It would effectively erase any progress that has been made regarding Bludish rights, and will embolden anti-Bludish proponents to follow their actions freely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: ""We definitely can't let that happen.""*)
  - -> `[246]` (*Player: ""That would be disastrous for our Bludish citizens.""*)
  - -> `[247]` (*Player: ""Bludish rights and the BFF have been major issues for ma..."*)
  - -> `[245]` (*Player: ""And how does that affect the administration?""*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We definitely can't let that happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Manoly Suheil: ""Exactly.""*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And how does that affect the administration?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Petr Vectern: ""Honestly, it doesn't. As long as there's no big Bludish ..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That would be disastrous for our Bludish citizens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Manoly Suheil: ""Exactly.""*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Bludish rights and the BFF have been major issues for many decades now. I don't see how this case makes either any worse than before.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Manoly Suheil: ""What part of it don't you understand? If these legitimat..."*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And how do you think the Supreme Court will react if we do it your way?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[279]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Manoly Suheil: ""We have to try. If they truly care for the people, they ..."*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What do you think, Petr?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[279]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "Petr leaned in and whispered."*)

### Węzeł `[250]`
Mówca: **Frens Ricter**
> ""Anyway... Do you have other questions, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 = true"*)

### Węzeł `[251]`
Mówca: **Remus Holstron**
> ""...so that they can cry about *injustice* and ask Sordland's enemies to come and *save* them. I personally do not agree with the 'Bluds are Sords' Sollist crap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Nia Morgna: ""I can't believe the words being thrown around at this me..."*)

### Węzeł `[252]`
Mówca: **Petr Vectern**
> ""You have a point. But I must point out that 'Contana' is the word for a geographic entity, unlike 'Sord'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Kesaro Kibener: ""This is Sordland. You can subscribe to whatever idea you..."*)

### Węzeł `[253]`
Mówca: **Remus Holstron**
> ""The reality is the Bluds do not respect nor recognize the laws and authority of Sordland. They'd rather separate themselves from Sords and protest the very laws that protect them...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Remus Holstron: ""...so that they can cry about *injustice* and ask Sordla..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You might be right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[292]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Frens Ricter: ""I can't believe I'm saying this, but he is right.""*)

### Węzeł `[255]`
Mówca: **Frens Ricter**
> ""We normally do not trust government data, but our own analysis came up mostly in line with the reports from the Ministry of the Interior and the Ministry of Defense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Frens Ricter: ""I wouldn't say this for most other topics, but in the ca..."*)

### Węzeł `[256]`
Mówca: **Narrator**
> "The threat in his tone was obvious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Frens Ricter: ""Anyway... Do you have other questions, Mr. President?""*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I see your point. But I still don't understand why the NFP suddenly had a change of heart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Kesaro Kibener: ""I disagree. This case is important for the greater good ..."*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why are you even comparing Sordland with United Contana? Are you alright, Mr. Kibener?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Kesaro Kibener: ""Very funny, Mr. President.""*)

### Węzeł `[259]`
Mówca: **Kesaro Kibener**
> ""My point is people like *the Malenyev* do not call themselves Kyovian over Contanan. Why is it that Bluds cannot do the same? Why does Sordland have to be divided?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Petr Vectern: ""You have a point. But I must point out that 'Contana' is..."*)

### Węzeł `[260]`
Mówca: **Kesaro Kibener**
> ""I disagree. This case is important for the greater good of the Sordish nation, and that is what the Nationalist Front stands for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Kesaro Kibener: ""All I'm asking is, if even in United Contana, *the Malen..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Because Contana has nothing to do with this and Article 6 is inherently racist.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Kesaro Kibener: ""Does *the Malenyev* call himself Kyovian before Contanan..."*)

### Węzeł `[262]`
Mówca: **Kesaro Kibener**
> ""All I'm asking is, if even in United Contana, *the Malenyev* doesn't call himself Kyovian before Contanan, why is it that Bluds cannot do the same? Why does Sordland have to be divided?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Petr Vectern: ""You have a point. But I must point out that 'Contana' is..."*)

### Węzeł `[263]`
Mówca: **Kesaro Kibener**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Kesaro Kibener: ""Does *the Malenyev* call himself Kyovian before Contanan..."*)

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Kibener has a point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Frens Ricter: ""He has. But our position as PFJP is that Article 6 does ..."*)

### Węzeł `[265]`
Mówca: **Kesaro Kibener**
> ""Very funny, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Kesaro Kibener: ""My point is people like *the Malenyev* do not call thems..."*)

### Węzeł `[266]`
Mówca: **Frens Ricter**
> ""We agree to come together in support of Ishval Ersen, but we believe our statement should include the acknowledgement of the inherent racism within the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Manoly Suheil: ""We must use this opportunity to show the flaws in the Co..."*)

### Węzeł `[267]`
Mówca: **Manoly Suheil**
> ""We must use this opportunity to show the flaws in the Constitution. If the Court agrees that there is in fact conflict between the Articles, or recognize the discrimi-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Kesaro Kibener: ""And the Hawker Court is going to listen to that?""*)

### Węzeł `[268]`
Mówca: **Frens Ricter**
> ""I can't believe I'm saying this, but he is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Frens Ricter: ""We normally do not trust government data, but our own an..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I agree with Mr. Kibener. A United Sordland is what we need.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Kesaro Kibener: ""Exactly.""*)

### Węzeł `[270]`
Mówca: **Nia Morgna**
> ""I can't believe the words being thrown around at this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player: ""And what is the position of the PFJP?""*)
  - -> `[273]` (*Player: ""Neither can I. I think it's time we wrap this up.""*)
  - -> `[264]` (*Player: ""Mr. Kibener has a point.""*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And what is the position of the PFJP?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Frens Ricter: ""I personally somewhat agree with Mr. Kibener on this. Ho..."*)

### Węzeł `[272]`
Mówca: **Frens Ricter**
> ""I personally somewhat agree with Mr. Kibener on this. However, our position as the PFJP is that Article 6 does indeed discriminate against non-Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Frens Ricter: ""And having a positive outcome for this case alone doesn'..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Neither can I. I think it's time we wrap this up.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Petr Vectern: ""Ladies and gentlemen. You've heard the president. Let's ..."*)

### Węzeł `[274]`
Mówca: **Petr Vectern**
> ""Ladies and gentlemen. You've heard the president. Let's sum it up and arrive at the point quickly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Frens Ricter: ""I personally somewhat agree with Mr. Kibener on this. Ho..."*)

### Węzeł `[275]`
Mówca: **Kesaro Kibener**
> ""And the Hawker Court is going to listen to that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Kesaro Kibener: ""Besides, we do not agree with your 'inherent racism' hog..."*)

### Węzeł `[276]`
Mówca: **Petr Vectern**
> ""I'm not sure if it's worth the risk right before the vote for our reforms. But the decision is yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "ChoiceHub_Main"*)

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me why we should pressure the Court to admit discrimination within the Constitution.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[276]` (Petr Vectern), `[362]` (Player), `[550]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP = true"*)

### Węzeł `[278]`
Mówca: **Manoly Suheil**
> ""Because it is the right thing to do, Mr. President. Now is not the time for weak and superficial actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Frens Ricter: ""We can show the people of Sordland the reality of the si..."*)

### Węzeł `[279]`
Mówca: **Frens Ricter**
> ""We can show the people of Sordland the reality of the situation and create a precedent for a future constitutional amendment of these Articles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "ChoiceHub_PFJP"*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And the NFP is willing to join in with that statement?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[279]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Kesaro Kibener: ""No. We are willing to give our support for Ersen for the..."*)

### Węzeł `[281]`
Mówca: **Kesaro Kibener**
> ""Besides, we do not agree with your 'inherent racism' hogwash. You have to state that it is your party's opinion and does not reflect the NFP. We won't take part in that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Petr Vectern: ""That would make the statement look weak and disorganized..."*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have decided.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_Nothing"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true`
- **Kontekst wejściowy (poprzednik):** `[276]` (Petr Vectern), `[362]` (Player), `[550]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "Jump to: [EndDecision]"*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What do you think, Petr?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[293]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "Petr leaned in and whispered."*)

### Węzeł `[284]`
Mówca: **Petr Vectern**
> ""That would make the statement look weak and disorganized. If there's no consistent strategy, I don't think it would work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option3 = true"*)

### Węzeł `[285]`
Mówca: **Frens Ricter**
> ""It can work for the time being, but I believe we can push for a more comprehensive outcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Manoly Suheil: ""Exactly. Our current Constitution fails to recognize the..."*)

### Węzeł `[286]`
Mówca: **Manoly Suheil**
> ""Exactly. Our current Constitution fails to recognize the Bludish people. It is time we abolish the inherent racism in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Kesaro Kibener: ""The citizens of Sordland are Sords. The constitution cle..."*)

### Węzeł `[287]`
Mówca: **Kesaro Kibener**
> ""Because it is the only way to decrease tensions. And the Supreme Court can't afford to look hypocritical, so they'll have to take the Sollist side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Remus Holstron: ""I still think this is admitting defeat against Sollism....."*)

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And how do you think the Supreme Court will react if we do it your way?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[293]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Kesaro Kibener: ""I truly believe they will be convinced. It is not agains..."*)

### Węzeł `[289]`
Mówca: **Manoly Suheil**
> ""Exactly. Unfortunately, our current constitution fails to recognize them. It is time we abolish the inherent racism in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Kesaro Kibener: ""The citizens of Sordland are Sords. The constitution cle..."*)

### Węzeł `[290]`
Mówca: **Kesaro Kibener**
> ""I do not understand why someone would go against such a broad and inclusive law. I don't see the commies criticizing their Contanan identity, when in fact that country is filled with different ethnicities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player: ""I agree with Mr. Kibener. A United Sordland is what we n..."*)
  - -> `[257]` (*Player: ""I see your point. But I still don't understand why the N..."*)
  - -> `[261]` (*Player: ""Because Contana has nothing to do with this and Article ..."*)
  - -> `[258]` (*Player: ""Why are you even comparing Sordland with United Contana?..."*)

### Węzeł `[291]`
Mówca: **Manoly Suheil**
> ""Exactly. Unfortunately, our current Constitution fails to recognize Bludish people. It is time we abolish the inherent racism in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Kesaro Kibener: ""The citizens of Sordland are Sords. The constitution cle..."*)

### Węzeł `[292]`
Mówca: **Kesaro Kibener**
> ""This is exactly what those damn Rums want. They are readying for war and waiting to use the tensions inside Sordland against us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == false"*)
  - -> `[222]` (*Player: ""I think the threat is exaggerated.""*)
  - -> `[254]` (*Player: ""You might be right.""*)

### Węzeł `[293]`
Mówca: **Remus Holstron**
> ""I still think this is admitting defeat against Sollism... But Mr. Kibener is right. The Rumburg situation demands extraordinary measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "ChoiceHub_NFP"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced == true && BaseGame.Relations_Frens_Bribed == false && BaseGame.Relations_Frens_Promise_Taurus == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == true && BaseGame..."*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_PFJP_Convinced == true && BaseGa..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced == true && BaseGame.Relations_Frens_Bribed == false && BaseGame.Relations_Frens_Promise_Taurus == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true  and  Variable["BaseGame.Relations_Frens_Bribed"] == false  and  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Frens Ricter: ""I agree with you...""*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_PFJP_Convinced == true && BaseGame.Relations_Frens_Bribed == false && BaseGame.Relations_Frens_Promise_Taurus == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true  and  Variable["BaseGame.Relations_Frens_Bribed"] == false  and  Variable["BaseGame.Relations_Frens_Promise_Taurus"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Frens Ricter: ""Interesting...""*)

### Węzeł `[297]`
Mówca: **Frens Ricter**
> ""I agree with you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "He gave me a questioning look."*)

### Węzeł `[298]`
Mówca: **Frens Ricter**
> ""Interesting...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "He gave me a questioning look."*)

### Węzeł `[299]`
Mówca: **Frens Ricter**
> ""That is precisely why we care.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Frens Ricter: ""But let's not spoil the mood. We are here to unite under..."*)

### Węzeł `[300]`
Mówca: **Petr Vectern**
> ""But the PFJP's stance would be too radical for our party. I think it might be better to keep our administration out of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Petr Vectern: ""I'm not sure if it's worth the risk right before the vot..."*)

### Węzeł `[301]`
Mówca: **Kesaro Kibener**
> ""The citizens of Sordland are Sords. The constitution clearly defines that in Article 6. It encompasses everybody. This shouldn't be up for debate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Kesaro Kibener: ""What racism are you talking about? Sollism is based on c..."*)

### Węzeł `[302]`
Mówca: **Kesaro Kibener**
> ""Does *the Malenyev* call himself Kyovian before Contanan? Why is it that Bluds cannot do the same? Why can't the Sord patriots wish for unity?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Petr Vectern: ""You have a point. But I must point out that 'Contana' is..."*)

### Węzeł `[303]`
Mówca: **Frens Ricter**
> ""But let's not spoil the mood. We are here to unite under another topic today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 = true"*)

### Węzeł `[304]`
Mówca: **Narrator**
> "He gave me a questioning look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Frens Ricter: ""I'm sure you will do your absolute best to pass the amen..."*)

### Węzeł `[305]`
Mówca: **Frens Ricter**
> ""I'm sure you will do your absolute best to pass the amendments nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "The threat in his tone was obvious."*)

### Węzeł `[306]`
Mówca: **Narrator**
> "He gave me a questioning look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 = true"*)

### Węzeł `[307]`
Mówca: **Frens Ricter**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 = true"*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me why we should try to convince them to reiterate their position on Article 6.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[276]` (Petr Vectern), `[362]` (Player), `[550]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP = true"*)

### Węzeł `[309]`
Mówca: **Kesaro Kibener**
> ""No. We are willing to give our support for Ersen for the violation of his right to property. But if you are going to go that way, we have to make two separate statements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 = true"*)

### Węzeł `[310]`
Mówca: **Manoly Suheil**
> ""We have to try. If they truly care for the people, they will agree to it. If not, people will see the reality of the Sollist state apparatus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 = true"*)

### Węzeł `[311]`
Mówca: **Petr Vectern**
> ""I don't think this would work, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Petr Vectern: ""Hawker won't be influenced. Plus, it could further antag..."*)

### Węzeł `[312]`
Mówca: **Narrator**
> "Petr leaned in and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[313]`
Mówca: **Petr Vectern**
> ""Hawker won't be influenced. Plus, it could further antagonize them against our reforms. We will definitely lose votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Petr Vectern: ""In my opinion, the PFJP has the most to gain from this. ..."*)

### Węzeł `[314]`
Mówca: **Petr Vectern**
> ""In my opinion, the PFJP has the most to gain from this. They would be seen as the leaders of this table, not us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 = true"*)

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is the PFJP willing to join in with that statement?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[293]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Frens Ricter: ""As much as I don't agree with it, we are willing to comp..."*)

### Węzeł `[316]`
Mówca: **Frens Ricter**
> ""As much as I don't agree with it, we are willing to compromise and join in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Frens Ricter: ""But if you are going to go this way, we will still need ..."*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't want to release a unified statement with the opposition. We will not involve ourselves in this case.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[384]` (Player), `[485]` (Player), `[543]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "The representatives of both parties looked at me with dis..."*)

### Węzeł `[318]`
Mówca: **Narrator**
> "The representatives of both parties looked at me with disappointment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Nia Morgna: ""Really?""*)

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The USP will join the statement. We will argue that Bludish people are considered Sords before the law, as Mr. Kibener suggested.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[384]` (Player), `[485]` (Player), `[543]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Kesaro Kibener: ""That's great to hear. We will get to work immediately af..."*)

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The USP will join the statement. We will argue that Articles 6 and 7 are inherently discriminatory and in conflict with the rights of people, as Mr. Ricter suggested.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[384]` (Player), `[485]` (Player), `[543]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Frens Ricter: ""That's great to hear. We will get to work immediately af..."*)

### Węzeł `[321]`
Mówca: **Kesaro Kibener**
> ""That's great to hear. We will get to work immediately after the celebrations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Nia Morgna: ""I don't like the sound of this.""*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ErsenQuestions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "ErsenQuestions"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true && B..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true && B..."*)

### Węzeł `[325]`
Mówca: **Nia Morgna**
> ""I also agree that Chief Justice Hawker won't have a sudden change of heart because of it. But we must put pressure on the Justices nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Nia Morgna: ""I think I have made my own position clear. In the end, i..."*)

### Węzeł `[326]`
Mówca: **Nia Morgna**
> ""I think I have made my own position clear. In the end, it is your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 = true"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true )"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Player: ""I have already decided.""*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Player: ""I think I have enough information about the NFP's positi..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true && Ba..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true && Ba..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ChoiceHub_PFJP]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "ChoiceHub_PFJP"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true && B..."*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true &&..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "Jump to: [ChoiceHub_Main]"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "Jump to: [ChoiceHub_PFJP]"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ChoiceHub_Main]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "ChoiceHub_Main"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EndDecision`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Player: ""The USP will join the statement. We will argue that Arti..."*)
  - -> `[319]` (*Player: ""The USP will join the statement. We will argue that Blud..."*)
  - -> `[317]` (*Player: ""I don't want to release a unified statement with the opp..."*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We will stay out of it. This isn't worth the risk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "The representatives of both parties looked at me with dis..."*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The USP will join the statement with the NFP. We will argue that Bludish people are considered Sords before the law, as Mr. Kibener suggested.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Kesaro Kibener: ""That's great to hear. We will get to work immediately af..."*)

### Węzeł `[340]`
Mówca: **Frens Ricter**
> ""But if you are going to go this way, we will still need to make our separate statement as party policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Narrator: "Manoly was shaking in her seat in fury but managed to kee..."*)

### Węzeł `[341]`
Mówca: **Narrator**
> "Manoly was shaking in her seat in fury but managed to keep herself silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 = true"*)

### Węzeł `[342]`
Mówca: **Frens Ricter**
> ""That's great to hear. We will get to work immediately after the celebrations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Manoly Suheil: ""I'll be honest, I didn't expect a USP president to agree..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Generichub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Player: ""Doesn't that mean the existence of the Bludish people is..."*)
  - -> `[454]` (*Player: ""That actually makes a lot of sense.""*)
  - -> `[431]` (*Player: ""But what about those who don't want to be called a Sord?""*)
  - -> `[453]` (*Player: ""This doesn't fix the core of the problem.""*)
  - -> `[585]` (*Player: ""I understand. And what does the PFJP think?""*)

### Węzeł `[344]`
Mówca: **Nia Morgna**
> ""That is correct, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "Generichub"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true && B..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true && B..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Petr Vectern: ""If you are going to add the amendment Nia's been working..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Petr Vectern: ""I don't think this would work, Anton.""*)

### Węzeł `[350]`
Mówca: **Petr Vectern**
> ""If you are going to add the amendment Nia's been working on, this is the stance we should take.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Petr Vectern: ""This could help get the winds of change behind us.""*)

### Węzeł `[351]`
Mówca: **Petr Vectern**
> ""This could help get the winds of change behind us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 = true"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Nia Morgna: ""As I already said, supporting the PFJP to put pressure o..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Nia Morgna: ""I agree with Mr. Ricter and Ms. Suheil. I personally thi..."*)

### Węzeł `[355]`
Mówca: **Nia Morgna**
> ""As I already said, supporting the PFJP to put pressure on the court and declare that our constitution is inherently discriminatory will only do good for our new amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Nia Morgna: ""This is what we believe in, so we should make it public.""*)

### Węzeł `[356]`
Mówca: **Nia Morgna**
> ""This is what we believe in, so we should make it public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 = true"*)

### Węzeł `[357]`
Mówca: **Nia Morgna**
> ""I agree with Mr. Ricter and Ms. Suheil. I personally think we should join them in their statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Nia Morgna: ""I also agree that Chief Justice Hawker won't have a sudd..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true )"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player: ""And how do you think the Supreme Court will react if we ..."*)

### Węzeł `[361]`
Mówca: **Nia Morgna**
> ""As I already said, supporting the NFP should be out of the question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Nia Morgna: ""I don't agree with either the Sollist or the neo-Sollist..."*)

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think I have enough information about the NFP's position. Let's hear the other side.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[293]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "Jump to: [ChoiceHub_Main]"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ChoiceHub_Main]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "ChoiceHub_Main"*)

### Węzeł `[364]`
Mówca: **Petr Vectern**
> ""What are you saying, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Player: ""The USP will join the statement with the NFP. We will ar..."*)
  - -> `[338]` (*Player: ""We will stay out of it. This isn't worth the risk.""*)
  - -> `[524]` (*Player: ""I'm not convinced. I want to hear from Mr. Ricter and Mr..."*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What do you suggest we do, Ms. Morgna?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[293]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Narrator: "Nia leaned in and whispered."*)

### Węzeł `[366]`
Mówca: **Frens Ricter**
> ""That's very disappointing. Even if we're alone in this, the PFJP will keep fighting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Manoly Suheil: ""With all due respect, Mr. Ricter, I think nobody expecte..."*)

### Węzeł `[367]`
Mówca: **Remus Holstron**
> ""The correct choice, I would say. The Hawker Court will do the right thing. Nobody should intervene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Frens Ricter: ""That's very disappointing. Even if we're alone in this, ..."*)

### Węzeł `[368]`
Mówca: **Manoly Suheil**
> ""With all due respect, Mr. Ricter, I think nobody expected a USP president to help with Bludish rights anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_VictoryDay_GaveNoSupport =..."*)

### Węzeł `[369]`
Mówca: **Frens Ricter**
> ""He has. But our position as PFJP is that Article 6 does indeed discriminate against non-Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Frens Ricter: ""And having a positive outcome for this case alone doesn'..."*)

### Węzeł `[370]`
Mówca: **Kesaro Kibener**
> ""I truly believe they will be convinced. It is not against their ideology and that is what Colonel Soll intended with the Constitution. We'll be shooting them with their own guns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Kesaro Kibener: ""Just imagine. All parties of the Assembly are reminding ..."*)

### Węzeł `[371]`
Mówca: **Kesaro Kibener**
> ""Yes. We'll talk about that later, Remus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProBlud = true; BaseGameSupp..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true"*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true )"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Player: ""What do you suggest we do, Ms. Morgna?""*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true && Ba..."*)

### Węzeł `[376]`
Mówca: **Narrator**
> "Nia leaned in and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Nia Morgna: ""As I already said, supporting the NFP should be out of t..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Nia Morgna: ""I definitely do not agree with Mr. Kibener or Mr. Holstr..."*)

### Węzeł `[380]`
Mówca: **Nia Morgna**
> ""I definitely do not agree with Mr. Kibener or Mr. Holstron. I don't see Sollism's unity working in reality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Nia Morgna: ""But I also have to say that pushing this position could ..."*)

### Węzeł `[381]`
Mówca: **Nia Morgna**
> ""I don't agree with either the Sollist or the neo-Sollist stance of this nation. You already know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 = true"*)

### Węzeł `[382]`
Mówca: **Nia Morgna**
> ""But I also have to say that pushing this position could have an effect on the outcome of the case. Mr. Hawker can agree with the traditional Sollist interpretation, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Nia Morgna: ""However, as long as our law enforcement forces are fille..."*)

### Węzeł `[383]`
Mówca: **Nia Morgna**
> ""However, as long as our law enforcement forces are filled with anti-Blud officers, I don't believe the change on the ground will be so visible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 = true"*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have already decided.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true`
- **Kontekst wejściowy (poprzednik):** `[293]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "Jump to: [EndDecision]"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [EndDecision]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "EndDecision"*)

### Węzeł `[386]`
Mówca: **Nia Morgna**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Remus Holstron: ""The correct choice, I would say. The Hawker Court will d..."*)

### Węzeł `[387]`
Mówca: **Nia Morgna**
> ""I don't like the sound of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Remus Holstron: ""Neither do I. As much as it may be needed, this will onl..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProBlud = true;
BaseGameSupport.Journal_Turn06_VictoryDay_SupportedErsen = true;
BaseGame.Bludish_Opinion += 2;
BaseGame.Sollist -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.ErsenCase_Statement_ProBlud"] = true;
Variable["BaseGameSupport.Journal_Turn06_VictoryDay_SupportedErsen"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Petr Vectern: ""We appreciate all your comments, ladies and gentlemen, b..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist = true;
BaseGameSupport.Journal_Turn06_VictoryDay_SupportedSollism = true;
BaseGame.Bludish_Opinion -= 2;
BaseGame.Sollist += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] = true;
Variable["BaseGameSupport.Journal_Turn06_VictoryDay_SupportedSollism"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Petr Vectern: ""We appreciate all your comments, ladies and gentlemen, b..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_VictoryDay_GaveNoSupport = true;
BaseGame.Bludish_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_VictoryDay_GaveNoSupport"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Petr Vectern: ""We appreciate all your comments, ladies and gentlemen, b..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ChoiceHub_NFP`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true"*)
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true"*)
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option1 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGa..."*)

### Węzeł `[393]`
Mówca: **Narrator**
> "Petr leaned in and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[394]`
Mówca: **Petr Vectern**
> ""I think this is risky, Anton. But if it works -- which it actually might -- it could make a difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Petr Vectern: ""If the Court really feels the pressure and accepts it, t..."*)

### Węzeł `[395]`
Mówca: **Petr Vectern**
> ""If the Court really feels the pressure and accepts it, the lower courts will need to adhere to their interpretation. It might not get rid of legal discrimination, but it could at least decrease it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Petr Vectern: ""But with the vote on our reforms coming so soon... It's ..."*)

### Węzeł `[396]`
Mówca: **Petr Vectern**
> ""But with the vote on our reforms coming so soon... It's a real leap of faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 = true"*)

### Węzeł `[397]`
Mówca: **Remus Holstron**
> ""With all due respect, Mr. Kibener, the NFP cannot merely stay out of it. We must condemn this decision and actively protest it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Kesaro Kibener: ""Yes. We'll talk about that later, Remus.""*)

### Węzeł `[398]`
Mówca: **Remus Holstron**
> ""Neither do I. As much as it may be needed, this will only strengthen the Sollism of the USP. We all know Sordists don't agree with Sollist nationalism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Kesaro Kibener: ""We'll talk about that later, Remus. Sordists will have t..."*)

### Węzeł `[399]`
Mówca: **Kesaro Kibener**
> ""We'll talk about that later, Remus. Sordists will have to listen to me this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Frens Ricter: ""We will also support the effort for the sake of a positi..."*)

### Węzeł `[400]`
Mówca: **Manoly Suheil**
> ""I'll be honest, I didn't expect a USP president to agree to this. You've proved me wrong, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Kesaro Kibener: ""That's a shame, really. Sadly, the NFP cannot take part ..."*)

### Węzeł `[401]`
Mówca: **Kesaro Kibener**
> ""That's a shame, really. Sadly, the NFP cannot take part in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Remus Holstron: ""With all due respect, Mr. Kibener, the NFP cannot merely..."*)

### Węzeł `[402]`
Mówca: **Frens Ricter**
> ""We will also support the effort for the sake of a positive result.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist = true; BaseGameS..."*)

### Węzeł `[403]`
Mówca: **Petr Vectern**
> ""We appreciate all your comments, ladies and gentlemen, but now that the USP's stance is clear, we should probably end the meeting here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[404]`
Mówca: **Frens Ricter**
> ""And having a positive outcome for this case alone doesn't suffice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Frens Ricter: ""We agree to come together in support of Ishval Ersen, bu..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true"*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true )"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player: ""What do you think, Petr?""*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true && Ba..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Petr Vectern: ""We shouldn't take this stance while we're trying to amen..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Petr Vectern: ""I think this is risky, Anton. But if it works -- which i..."*)

### Węzeł `[412]`
Mówca: **Petr Vectern**
> ""We shouldn't take this stance while we're trying to amend Article 6 and 7. That inconsistency would damage us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Petr Vectern: ""Then again, the Supreme Court agrees with it, the lower ..."*)

### Węzeł `[413]`
Mówca: **Petr Vectern**
> ""Then again, the Supreme Court agrees with it, the lower courts will have to adhere to the interpretation. It might not get rid of legal discrimination, but it could at least decrease it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 = true"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ChoiceHub_NFP]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "ChoiceHub_NFP"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true && Ba..."*)
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true && ..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "Jump to: [ChoiceHub_Main]"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3 == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "Jump to: [ChoiceHub_NFP]"*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ChoiceHub_Main]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "ChoiceHub_Main"*)

### Węzeł `[419]`
Mówca: **Petr Vectern**
> ""Honestly, it doesn't. As long as there's no big Bludish revolt or anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Petr Vectern: ""But regardless, we must do our best to decrease the tens..."*)

### Węzeł `[420]`
Mówca: **Petr Vectern**
> ""But regardless, we must do our best to decrease the tensions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Manoly Suheil: ""What part of it don't you understand? If these legitimat..."*)

### Węzeł `[421]`
Mówca: **Manoly Suheil**
> ""What part of it don't you understand? If these legitimate claims are rejected, they will not be raised again in other cases.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Manoly Suheil: ""This will, in practice, only end up legalizing discrimin..."*)

### Węzeł `[422]`
Mówca: **Manoly Suheil**
> ""This will, in practice, only end up legalizing discrimination against all non-Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Frens Ricter: ""That is precisely why our expectation is to see a differ..."*)

### Węzeł `[423]`
Mówca: **Manoly Suheil**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Frens Ricter: ""That is precisely why our expectation is to see a differ..."*)

### Węzeł `[424]`
Mówca: **Frens Ricter**
> ""That is precisely why our expectation is to see a different result this time. The stakes couldn't be higher.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option2 = true"*)

### Węzeł `[425]`
Mówca: **Kesaro Kibener**
> ""The only good result would be if the Supreme Court reiterates its commitment to the pillar of 'unity' in Sollism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Kesaro Kibener: ""Mr. President... Despite previously being against it, I ..."*)

### Węzeł `[426]`
Mówca: **Kesaro Kibener**
> ""If the Court reiterates the definition of 'Sord' in Article 6 as an all-encompassing term, they would be acknowledging that Ersen and others like him are indeed protected by the 'Rights of the Sord Peoples' -- which they are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Kesaro Kibener: ""As a result, the resettlement policy in Deyr would be re..."*)

### Węzeł `[427]`
Mówca: **Kesaro Kibener**
> ""As a result, the resettlement policy in Deyr would be reversed, opening the way for Governor Bron's removal and the de-escalation of tensions in Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Player: ""Is that true, Ms. Morgna?""*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "Generichub"*)

### Węzeł `[428]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why would I want to lose a governor from our party?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true) == false` AND `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[191]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Petr Vectern: ""Exactly. This looks awfully like a political strategy ag..."*)

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We are already aware of this case.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "Nia raised her hand and spoke."*)

### Węzeł `[430]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Please explain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "Nia raised her hand and spoke."*)

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""But what about those who don't want to be called a Sord?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Nia Morgna), `[427]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Manoly Suheil: ""Exactly. Unfortunately, our current constitution fails t..."*)

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As concerning as this all is, the Supreme Court must make its decision independently. This is not in our jurisdiction, just as lawmaking is not in theirs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Frens Ricter: ""How about your amendments? Will you leave the Court to d..."*)

### Węzeł `[433]`
Mówca: **Frens Ricter**
> ""How about your amendments? Will you leave the Court to decide for themselves there too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Player: ""I am just telling you how it should be, not what will ha..."*)
  - -> `[437]` (*Player: ""I trust that they will do the right thing.""*)
  - -> `[435]` (*Player: ""Of course not. Their current say in the amendments is wr..."*)
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == true"*)

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why do you even care? You and your party are not even giving support to it.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[433]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Frens Ricter: ""That is precisely why we care.""*)

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course not. Their current say in the amendments is wrong, as that shouldn't be the duty of the judiciary. This case, however, is actually their job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == true && BaseGame..."*)

### Węzeł `[436]`
Mówca: **Kesaro Kibener**
> ""Mr. President... Despite previously being against it, I now completely understand why Sordland still needs Sollism. We need unity more than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Kesaro Kibener: ""And Article 6 is that unity.""*)

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I trust that they will do the right thing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == true && BaseGame..."*)

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am just telling you how it should be, not what will happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Frens Ricter: ""I see.""*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == true"*)
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_PFJP_Convinced == true)"*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_PFJP_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Player: ""Why do you even care? You and your party are not even gi..."*)

### Węzeł `[442]`
Mówca: **Kesaro Kibener**
> ""And Article 6 is that unity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Remus Holstron: ""We do not need Sollist unity.""*)

### Węzeł `[443]`
Mówca: **Petr Vectern**
> ""Exactly. This looks awfully like a political strategy against the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Nia Morgna: ""I was actively involved in this case. Because of the imp..."*)

### Węzeł `[444]`
Mówca: **Nia Morgna**
> ""I was actively involved in this case. Because of the implications with the constitution, there is no way the Supreme Court will agree with Ishval Ersen on all of the points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Frens Ricter: ""Not if all three parties of the Assembly support Ersen t..."*)

### Węzeł `[445]`
Mówca: **Kesaro Kibener**
> ""In short, the plan is to release a unified statement to the Justices declaring our support for Ersen and explaining why this is so important.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Kesaro Kibener: ""The only good result would be if the Supreme Court reite..."*)

### Węzeł `[446]`
Mówca: **Nia Morgna**
> ""Actually, Mr. President is completely right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Petr Vectern: ""Hold up, guys. Let's hear them out first. We are represe..."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Player: ""I agree completely. In fact, we are already working on t..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == tru..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true || BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == tru..."*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Centralization == t..."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true || BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player: ""I am aware of this case. In fact, we are already working..."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Centralization == true || BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Player: ""Why would I want to lose a governor from our party?""*)

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This doesn't fix the core of the problem.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Nia Morgna), `[427]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Manoly Suheil: ""Exactly. Unfortunately, our current Constitution fails t..."*)

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That actually makes a lot of sense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Nia Morgna), `[427]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Frens Ricter: ""It can work for the time being, but I believe we can pus..."*)

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sordland will not be threatened nor blackmailed by some 'massive' response from a group of people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Remus Holstron: ""I agree with Mr. President.""*)

### Węzeł `[456]`
Mówca: **Remus Holstron**
> ""If enemies do truly live within our borders, I'd rather they show their true faces earlier than later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Kesaro Kibener: ""This is exactly what those damn Rums want. They are read..."*)

### Węzeł `[457]`
Mówca: **Remus Holstron**
> ""I agree with Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Remus Holstron: ""If enemies do truly live within our borders, I'd rather ..."*)

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Hold on. If this meeting is going to turn into a racist summit, I will take my leave immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Remus Holstron), `[91]` (Manoly Suheil), `[205]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Frens Ricter: ""No, Mr. President. It won't... Hopefully.""*)

### Węzeł `[459]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I will hear you out. But know that I will not act on anything before talking to the representatives of the Bludish community.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Remus Holstron), `[91]` (Manoly Suheil), `[205]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Kesaro Kibener: ""Let's get back on track, ladies and gentlemen.""*)

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Alright. I'm listening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Remus Holstron), `[91]` (Manoly Suheil), `[205]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Kesaro Kibener: ""Let's get back on track, ladies and gentlemen.""*)

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am aware of this case. In fact, we are already working on revoking the current special zone status of Bergia.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true` AND `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[191]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Manoly Suheil: ""That's great to hear. We would be very happy if you can ..."*)

### Węzeł `[462]`
Mówca: **Frens Ricter**
> ""No, Mr. President. It won't... Hopefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Kesaro Kibener: ""Let's get back on track, ladies and gentlemen.""*)

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I agree completely. In fact, we are already working on the possibility of changing said articles.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Kontekst wejściowy (poprzednik):** `[191]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Kesaro Kibener: ""I'll be damned! So the rumors were true after all. Insan..."*)

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You sound like Ms. Graf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Narrator: "Nia smiled for a brief moment and nodded in approval."*)

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Doesn't that mean the existence of the Bludish people is literally not being acknowledged?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Nia Morgna), `[427]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Manoly Suheil: ""Exactly. Our current Constitution fails to recognize the..."*)

### Węzeł `[466]`
Mówca: **Remus Holstron**
> ""We do not need Sollist unity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Narrator: "Kesaro stared Remus down and continued."*)

### Węzeł `[467]`
Mówca: **Narrator**
> "Kesaro stared Remus down and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Kesaro Kibener: ""If the Court reiterates the definition of 'Sord' in Arti..."*)

### Węzeł `[468]`
Mówca: **Kesaro Kibener**
> ""Of course, I'm not saying nothing can change. The results of today's meeting can still, possibly, influence some of our members...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Kesaro Kibener: ""But let's just go inside now. Please follow me.""*)

### Węzeł `[469]`
Mówca: **Narrator**
> "Nia did not comment but nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Frens Ricter: ""I'm afraid Mr. Kibener is right about this. If the Court..."*)

### Węzeł `[470]`
Mówca: **Narrator**
> "Nia smiled for a brief moment and nodded in approval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Frens Ricter: ""Just let me finish, Mr. President.""*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true || BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true ..."*)
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == tru..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true || BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player: ""That's why we have to remove the authority of the govern..."*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true || BaseGame.BergiaSpecialZone_Proposal_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true  or  Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[474]`
Mówca: **Narrator**
> "Nia's eyes blazed with fury."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Kesaro Kibener: ""We are working on the Unified Language Act. It is direct..."*)

### Węzeł `[475]`
Mówca: **Nia Morgna**
> ""I'll be completely honest. I would never have expected that from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Remus was visibly annoyed but kept himself silent."*)

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What are your plans and suggestions?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == false`
- **Kontekst wejściowy (poprzednik):** `[199]` (Kesaro Kibener), `[201]` (Frens Ricter), `[209]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Kesaro Kibener: ""In short, the plan is to release a unified statement to ..."*)

### Węzeł `[477]`
Mówca: **Kesaro Kibener**
> ""We have the Minister of Justice here with us too. I'm sure she would not disagree with what I just said.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Narrator: "Nia did not comment but nodded."*)

### Węzeł `[478]`
Mówca: **Frens Ricter**
> ""You didn't bring this up in our meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Frens Ricter: ""We prefer to push for a precedent for these reforms firs..."*)

### Węzeł `[479]`
Mówca: **Nia Morgna**
> ""The *Blud problem*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Kesaro Kibener: ""Mr. Hol-""*)

### Węzeł `[480]`
Mówca: **Manoly Suheil**
> ""That's great to hear. We would be very happy if you can share the details once they're more concrete.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Frens Ricter: ""We will definitely give support to that when the time co..."*)

### Węzeł `[481]`
Mówca: **Frens Ricter**
> ""We prefer to push for a precedent for these reforms first. The Ishval Ersen case can give us exactly that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Frens Ricter: ""Even if you push for amendments, in the case of their fa..."*)

### Węzeł `[482]`
Mówca: **Frens Ricter**
> ""Even if you push for amendments, in the case of their failure the current interpretation of the Supreme Court will be the basis of law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Manoly Suheil: ""We must pressure the Courts to agree with Ersen.""*)

### Węzeł `[483]`
Mówca: **Manoly Suheil**
> ""We must pressure the Courts to agree with Ersen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "Nia raised her hand and spoke."*)

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is that true, Ms. Morgna?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[427]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Nia Morgna: ""That is correct, Mr. President.""*)

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think I've heard enough.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] == true` AND `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_3"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_4"] == true`
- **Kontekst wejściowy (poprzednik):** `[276]` (Petr Vectern), `[362]` (Player), `[550]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "Jump to: [EndDecision]"*)

### Węzeł `[486]`
Mówca: **Frens Ricter**
> ""We will definitely give support to that when the time comes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Frens Ricter: ""However, the case of Ishval Ersen has a bigger reach tha..."*)

### Węzeł `[487]`
Mówca: **Frens Ricter**
> ""However, the case of Ishval Ersen has a bigger reach than Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "Nia raised her hand and spoke."*)

### Węzeł `[488]`
Mówca: **Frens Ricter**
> ""That makes things much clearer for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == true"*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == true"*)
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_PFJP_Convinced == true)"*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Frens Ricter: ""However, we definitely do not see eye to eye with your l..."*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_PFJP_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Frens Ricter: ""I see that you finally realized that your proposal is do..."*)

### Węzeł `[492]`
Mówca: **Frens Ricter**
> ""I see that you finally realized that your proposal is doomed. It must be why you're trying to turn your defeat into a symbolic attempt for Bludish rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Frens Ricter: ""You didn't bring this up in our meeting.""*)

### Węzeł `[493]`
Mówca: **Kesaro Kibener**
> ""I'll be damned! So the rumors were true after all. Insanity reigns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Frens Ricter: ""That makes things much clearer for us.""*)

### Węzeł `[494]`
Mówca: **Frens Ricter**
> ""However, we definitely do not see eye to eye with your last-minute hidden details. Adding those to the proposal would destroy its chances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Frens Ricter: ""You didn't bring this up in our meeting.""*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGa..."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option3 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGa..."*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ErsenQuestions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "ErsenQuestions"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGa..."*)
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_Hub_Option1 == true && Base..."*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Petr Vectern: ""I think I have enough information to be able to say we a..."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "Jump to: [ErsenQuestions]"*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGa..."*)
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_Hub_Option1 == true && Base..."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "Jump to: [Petr Vectern: ""I think I have enough informati..."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "Jump to: [ErsenQuestions]"*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGa..."*)
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_Hub_Option1 == true && Base..."*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "Jump to: [Petr Vectern: ""I think I have enough informati..."*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_Hub_Option1 == true && BaseGameIsolated.VictoryDay_Hub_Option2 == true && BaseGameIsolated.VictoryDay_Hub_Option3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == true  and  Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "Jump to: [ErsenQuestions]"*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ErsenQuestions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "ErsenQuestions"*)

### Węzeł `[508]`
Mówca: **Petr Vectern**
> ""I think I have enough information to be able to say we are deep in the mud here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Narrator: "Petr laughed at his own joke attempt, but nobody else rea..."*)

### Węzeł `[509]`
Mówca: **Narrator**
> "Petr laughed at his own joke attempt, but nobody else reacted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Petr Vectern: ""I think I have enough information..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Petr Vectern: ""I think I have enough information to be able to say we a..."*)

### Węzeł `[511]`
Mówca: **Petr Vectern**
> ""Well... Judging from what Ms. Morgna's been working on, it's safe to say that we have one clear option here. Am I right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Petr Vectern: ""...Unless you want to completely stay out of it?""*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Petr Vectern: ""I think I have enough information..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Petr Vectern: ""I think I have enough information to be able to say we a..."*)

### Węzeł `[513]`
Mówca: **Petr Vectern**
> ""Well... I think the NFP's stance could do some good for the Bludish without provoking the establishment. But even that might be risky right before the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Petr Vectern: ""But the PFJP's stance would be too radical for our party..."*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)"*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Amendment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Petr Vectern: ""Well... Judging from what Ms. Morgna's been working on, ..."*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Amendment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Amendment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Petr Vectern: ""Well... I think the NFP's stance could do some good for ..."*)

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What do you suggest we do, Ms. Morgna?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[279]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Narrator: "Nia leaned in and whispered."*)

### Węzeł `[518]`
Mówca: **Narrator**
> "Petr looked at me and Nia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Nia Morgna: ""Well, if we are serious about including the amendments t..."*)

### Węzeł `[519]`
Mówca: **Nia Morgna**
> ""Well, if we are serious about including the amendments to Article 6 and 7 in the current proposal, our stance on this case should be very clear. If there's truly a right time to push for these changes, this is it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Nia Morgna: ""We should push the Court from all directions. If they re..."*)

### Węzeł `[520]`
Mówca: **Nia Morgna**
> ""We should push the Court from all directions. If they reject both the reforms and such a heavily charged court case, everybody will see them for who they are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Player: ""So you're suggesting we join in with the PFJP's statement?""*)
  - -> `[523]` (*Player: ""I agree. We should pressure the Court to admit the discr..."*)
  - -> `[522]` (*Player: ""I disagree. We have to concede one point so as not to ag..."*)
  - -> `[524]` (*Player: ""I'm not convinced. I want to hear from Mr. Ricter and Mr..."*)

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So you're suggesting we join in with the PFJP's statement?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[520]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Nia Morgna: ""Of course.""*)

### Węzeł `[522]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I disagree. We have to concede one point so as not to agitate them too much. Otherwise both attempts will end up being symbolic only.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[520]` (Nia Morgna), `[565]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Petr Vectern: ""What are you saying, Anton?""*)

### Węzeł `[523]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I agree. We should pressure the Court to admit the discrimination within the Constitution. Let's join in with the PFJP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[520]` (Nia Morgna), `[565]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Frens Ricter: ""That's great to hear. We will get to work immediately af..."*)

### Węzeł `[524]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not convinced. I want to hear from Mr. Ricter and Mr. Kibener first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Petr Vectern), `[520]` (Nia Morgna), `[565]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Petr Vectern: ""Sure.""*)

### Węzeł `[525]`
Mówca: **Petr Vectern**
> ""...Unless you want to completely stay out of it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Narrator: "Petr looked at me and Nia."*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Manoly Suheil: ""Because it is the right thing to do, Mr. President. Now ..."*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ChoiceHub_PFJP`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true"*)
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true"*)
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true"*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true"*)
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true"*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true"*)
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true )"*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1 == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player: ""And the NFP is willing to join in with that statement?""*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true"*)
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true )"*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2 == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Player: ""And how do you think the Supreme Court will react if we ..."*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true"*)
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true )"*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3 == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player: ""What do you think, Petr?""*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true"*)
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true )"*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4 == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP_4"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Player: ""What do you suggest we do, Ms. Morgna?""*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true"*)
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true )"*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Player: ""I have already decided.""*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Player: ""I think I have enough information about the PFJP's posit..."*)

### Węzeł `[543]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have already decided.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true`
- **Kontekst wejściowy (poprzednik):** `[279]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "Jump to: [EndDecision]"*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ChoiceHub_Main`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true"*)
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_Nothing == true && ..."*)
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true"*)
  - -> `[485]` (*Player: ""I think I've heard enough.""*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true"*)
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true )"*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player: ""Tell me why we should pressure the Court to admit discri..."*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Kesaro Kibener: ""Because it is the only way to decrease tensions. And the..."*)

### Węzeł `[549]`
Mówca: **Narrator**
> "Nia leaned in and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Amendment == true"*)

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think I have enough information about the PFJP's position. Let's hear the other side.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[279]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "Jump to: [ChoiceHub_Main]"*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ChoiceHub_Main]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "ChoiceHub_Main"*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true"*)
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true )"*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1 == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP_1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Player: ""Is the PFJP willing to join in with that statement?""*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true"*)
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true )"*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player: ""Tell me why we should try to convince them to reiterate ..."*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [EndDecision]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "EndDecision"*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_Nothing == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_Nothing == true && ..."*)
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_ChoiceHub_Nothing == true &..."*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_ChoiceHub_Nothing == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_ChoiceHub_Nothing"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player: ""I have decided.""*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_ChoiceHub_Nothing == true && BaseGameIsolated.VictoryDay_ChoiceHub_PFJP == true && BaseGameIsolated.VictoryDay_ChoiceHub_NFP == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_ChoiceHub_Nothing"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_PFJP"] == true  and  Variable["BaseGameIsolated.VictoryDay_ChoiceHub_NFP"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [EndDecision]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "EndDecision"*)

### Węzeł `[563]`
Mówca: **Petr Vectern**
> ""Sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "Jump to: [ChoiceHub_Main]"*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ChoiceHub_Main]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "ChoiceHub_Main"*)

### Węzeł `[565]`
Mówca: **Nia Morgna**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Player: ""I agree. We should pressure the Court to admit the discr..."*)
  - -> `[522]` (*Player: ""I disagree. We have to concede one point so as not to ag..."*)
  - -> `[524]` (*Player: ""I'm not convinced. I want to hear from Mr. Ricter and Mr..."*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [EndDecision]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "EndDecision"*)

### Węzeł `[567]`
Mówca: **Kesaro Kibener**
> ""And according to the Constitution, the language of Sordland is Sordish. If nothing is being done to enforce that, we are breaching the Constitution. This law simply enforces it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Remus Holstron: ""With all due respect, Mr. Kibener, this bill is not stro..."*)

### Węzeł `[568]`
Mówca: **Frens Ricter**
> ""It's great that we're aligned on that matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Frens Ricter: ""We have to do something about it. Because the reality is..."*)

### Węzeł `[569]`
Mówca: **Frens Ricter**
> ""We have to do something about it. Because the reality is, the secessionists are on the rise...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "He adjusted his tie and continued."*)

### Węzeł `[570]`
Mówca: **Kesaro Kibener**
> ""Just imagine. All parties of the Assembly are reminding them of their duty -- with their own beloved Constitution. Mr. Hawker can't take that pressure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_ChoiceHub_NFP_2 = true"*)

### Węzeł `[571]`
Mówca: **Kesaro Kibener**
> ""This is Sordland. You can subscribe to whatever idea you want, but if you are a citizen, you are a Sord. This is how nations work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Remus Holstron: ""The reality is the Bluds do not respect nor recognize th..."*)

### Węzeł `[572]`
Mówca: **Kesaro Kibener**
> ""What racism are you talking about? Sollism is based on civic nationalism, not ethnic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Kesaro Kibener: ""I do not understand why someone would go against such a ..."*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option1 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option1 == false"*)
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_Hub_Option1 == false)"*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option1 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: ""What's the significance of this case?""*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_Hub_Option1 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Hub_Option1"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option2 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option2 == false"*)
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_Hub_Option2 == false)"*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option2 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player: ""What is the most likely outcome of this case?""*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_Hub_Option2 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Hub_Option2"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option3 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Hub_Option3 == false"*)
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_Hub_Option3 == false)"*)

### Węzeł `[580]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Hub_Option3 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Player: ""What are your plans and suggestions?""*)
  - -> `[584]` (*Player: ""Let's just jump straight into your proposal.""*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_Hub_Option3 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Player: ""I've heard enough.""*)

### Węzeł `[582]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I've heard enough.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[199]` (Kesaro Kibener), `[201]` (Frens Ricter), `[209]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "Jump to: [Petr Vectern: ""I think I have enough informati..."*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Petr Vectern: ""I think I have enough information..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Petr Vectern: ""I think I have enough information to be able to say we a..."*)

### Węzeł `[584]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's just jump straight into your proposal.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.VictoryDay_Hub_Option3"] == false`
- **Kontekst wejściowy (poprzednik):** `[199]` (Kesaro Kibener), `[201]` (Frens Ricter), `[209]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Kesaro Kibener: ""In short, the plan is to release a unified statement to ..."*)

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand. And what does the PFJP think?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Nia Morgna), `[427]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Frens Ricter: ""I personally somewhat agree with Mr. Kibener on this. Ho..."*)
