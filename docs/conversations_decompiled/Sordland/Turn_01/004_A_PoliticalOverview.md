# Sordland/Turn01/A_PoliticalOverview

- **ID konwersacji:** `4`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/004_A_PoliticalOverview.md`
- **Liczba węzłów dialogowych:** 294
- **Liczba wyborów gracza:** 85

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_Party_Takeover_PublicBlame`
- `BaseGame.Prologue_Speech_Democracy_Liberal`
- `BaseGame.Promise_TermFocus_Military`
- `BaseGame.Reform_Dictator_Intention`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Democratic`
- `BaseGame.Policy_Law_ReformCommittee`
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Dictator_Intention`
- `BaseGame.Reform_Reformist_Intention`
- `BaseGameSupport.Journal_Turn01_Reform_DestroyJudiciary`
- `BaseGameSupport.Journal_Turn01_Reform_MoreExecutivePower`
- `BaseGameSupport.Journal_Turn01_Reform_StrengthenYourPosition`
- `BaseGameSupport.Journal_Turn01_Reform_WorkWithOldGuards`
- `BaseGameSupport.Journal_Turn01_Reform_WorkWithReformists`
- `BaseGameSupport.News_Turn01_E_AlphonsoLeavesLotherberg`
- `BaseGameSupport.News_Turn01_G_RiziaGas`
- `BaseGameSupport.News_Turn01_HP_Committee`
- `BaseGameSupport.News_Turn01_HP_FireStrikesHSU`
- `BaseGameSupport.News_Turn01_LT_CampaignBill`
- `BaseGameSupport.News_Turn01_LT_NationalLeagueSeason`
- `BaseGameSupport.News_Turn01_R_RediscoveringIzzam`
- `BaseGameSupport.Report_Turn01_Deyr_IncreasingHomeless`
- `BaseGameSupport.Report_Turn01_Holsord_GNATourismBill`
- `BaseGameSupport.Report_Turn01_Holsord_PoliceFireReport`
- `BaseGameSupport.Report_Turn01_Holsord_PublicOpinion`
- `BaseGameSupport.Report_Turn01_Leiren_ProtectNatureMarch`
- `BaseGameSupport.Report_Turn01_Narbel_GasomDiscoveries`
- `GameCondition.Turn01_A_PoliticalOverview`

### Skoki między-konwersacyjne:
- Węzeł `[293]` -> **[5] Sordland/Turn01/Petr Opens Whisky** (../Turn_01/005_Petr_Opens_Whisky.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **"“This is not the time to celebrate, Petr. We have work to do.”"** | `[5]` **Petr Vectern**: "“But, hey, back in university, d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Petr Vectern**: "“Yes... I agree. We've got thing..." |
| `[7]` | **"“We will celebrate at the inaugural ball. Just hang in there until the evening.”"** | `[5]` **Petr Vectern**: "“But, hey, back in university, d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Petr Vectern**: "“Looking forward to it. Evelyn h..." |
| `[8]` | **"“Let's celebrate then. I got my hands on something special for us. An Erlory Maroo..."** | `[5]` **Petr Vectern**: "“But, hey, back in university, d..." | *Brak (Dostępna bezwarunkowo)* | `EnableCollectionItem("CollectionItem_WhiskeyBottle");` | `[4]` **Narrator**: "Petr Vectern arrived a couple of..." |
| `[10]` | **"“Good to know. It's been some time since the last time I saw her.""** | `[9]` **Petr Vectern**: "“Looking forward to it. Evelyn h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Petr Vectern**: "“I think it was Franc's birthday..." |
| `[11]` | **"“I'm sure the kids would love to see their Uncle Petr for the first time as the Vi..."** | `[9]` **Petr Vectern**: "“Looking forward to it. Evelyn h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Petr Vectern**: "“That is great to hear! It's cra..." |
| `[19]` | **"“Let's see if I see eye to eye.”"** | `[18]` **Petr Vectern**: "“We mostly see eye to eye, but I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "The door swung open and Lucian G..." |
| `[20]` | **"“Great. Let's go over this when Lucian arrives.”"** | `[18]` **Petr Vectern**: "“We mostly see eye to eye, but I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "The door swung open and Lucian G..." |
| `[27]` | **"“I am aware of Mr. Koronti's wide network. That could come in handy.”"** | `[26]` **Petr Vectern**: "“As far as I know, Konrath's son..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Petr Vectern**: "“We just need to be careful with..." |
| `[28]` | **"“The Group's influence is an important force. One that we should use to our admini..."** | `[26]` **Petr Vectern**: "“As far as I know, Konrath's son..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Petr Vectern**: "“If we can get them to side with..." |
| `[29]` | **"“That group is dependent on our economic policies. They can't move a finger withou..."** | `[26]` **Petr Vectern**: "“As far as I know, Konrath's son..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Petr Vectern**: "“I wouldn't be so optimistic. Th..." |
| `[32]` | **"“We'll see each other at the ball, then.""** | `[9]` **Petr Vectern**: "“Looking forward to it. Evelyn h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Petr Vectern**: "“Definitely!"" |
| `[35]` | **"“I hope things are looking good.”"** | `[18]` **Petr Vectern**: "“We mostly see eye to eye, but I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "The door swung open and Lucian G..." |
| `[50]` | **"“I agree with the reformists. Our responsibility is to democratize our broken syst..."** | `[227]` **Lucian Galade**: "“Frens Ricter, leader of the ref..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Democratic"] = Variable["BaseGame.Demo...` | `[57]` **Petr Vectern**: ""That's exactly what we campaign..."<br>`[48]` **Lucian Galade**: "“It will not be easy."" |
| `[51]` | **"“We need to listen to the people if we want to serve this country.""** | `[227]` **Lucian Galade**: "“Frens Ricter, leader of the ref..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Petr Vectern**: ""That's exactly what we campaign..."<br>`[48]` **Lucian Galade**: "“It will not be easy."" |
| `[53]` | **"“If we lose power, we won't be able to execute the changes we need to make for the..."** | `[227]` **Lucian Galade**: "“Frens Ricter, leader of the ref..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Lucian Galade**: "“It may create issues for us, yes."" |
| `[58]` | **"“Lucian. How are you?”"** | `[24]` **Narrator**: "Lucian then turned towards me. H..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Lucian Galade**: "“I am ready and able, sir."" |
| `[59]` | **"“Glad to see you, Lucian.”"** | `[24]` **Narrator**: "Lucian then turned towards me. H..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Lucian Galade**: "“It is a privilege to be here, s..." |
| `[60]` | **"“Let's not waste any time. Lucian, proceed with the overview.”"** | `[24]` **Narrator**: "Lucian then turned towards me. H..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Lucian Galade**: "“As you wish, sir."" |
| `[68]` | **"“We'll need a comprehensive bill to balance the power structure more fairly.""** | `[71]` **Petr Vectern**: ""The Court also has the final sa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Petr Vectern**: ""I agree. The Old Guard won't li..." |
| `[74]` | **"“We must break the power of the Supreme Court one way or another.""** | `[71]` **Petr Vectern**: ""The Court also has the final sa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Lucian Galade**: "“I agree. They have too much pow..." |
| `[76]` | **"“I support the reformists. We need a proper balance of power in this country.""** | `[75]` **Petr Vectern**: ""The reformists' demands are cle..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Petr Vectern**: ""I agree. We can't ignore the wi..." |
| `[77]` | **"“I'd rather not go against them. The risks are too high.""** | `[71]` **Petr Vectern**: ""The Court also has the final sa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Petr Vectern**: ""We need to work with the Suprem..." |
| `[80]` | **"“We must listen to their demands. Otherwise we are no different than the previous ..."** | `[75]` **Petr Vectern**: ""The reformists' demands are cle..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Petr Vectern**: ""I agree. We can't ignore the wi..." |
| `[81]` | **""I won't allow them to influence me. We will shape our own future.""** | `[75]` **Petr Vectern**: ""The reformists' demands are cle..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Lucian Galade**: "“I agree, sir."" |
| `[85]` | **"“We cannot allow obstructionists to exist.”"** | `[67]` **Lucian Galade**: "“Which means removing your absol..."<br>`[79]` **Lucian Galade**: "“True. But we can't let the Old ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Petr Vectern**: "“We can figure it out. Our party..." |
| `[86]` | **"“Looks like we have many challenges ahead.”"** | `[67]` **Lucian Galade**: "“Which means removing your absol..."<br>`[79]` **Lucian Galade**: "“True. But we can't let the Old ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Petr Vectern**: "“We can figure it out. Our party..." |
| `[87]` | **"“We can't underestimate this situation.""** | `[67]` **Lucian Galade**: "“Which means removing your absol..."<br>`[79]` **Lucian Galade**: "“True. But we can't let the Old ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Petr Vectern**: "“We can figure it out. Our party..." |
| `[88]` | **"“We will write a more democratic Constitution with the reformists.""** | `[188]` **Lucian Galade**: "“The entire process will take a ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Democratic"] = Variable["BaseGame.Demo...` | `[95]` **Petr Vectern**: ""That's what we've been preparin..."<br>`[98]` **Petr Vectern**: ""It will be tough to persuade ou..." |
| `[89]` | **"“The new Constitution should give the President wide-ranging powers to lead Sordla..."** | `[188]` **Lucian Galade**: "“The entire process will take a ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Democratic"] = Variable["BaseGame.Demo...` | `[101]` **Lucian Galade**: ""That's very bold. Then we must ..." |
| `[90]` | **"“We could work with the Old Guard to protect our existing extensive powers.""** | `[188]` **Lucian Galade**: "“The entire process will take a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Petr Vectern**: ""You must remember that we promi..."<br>`[108]` **Petr Vectern**: ""How? You know the public wants ..." |
| `[94]` | **"“How can we come out of this in the best shape?""** | `[112]` **Lucian Galade**: ""I don't think you should take t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Lucian Galade**: "“According to the initial draft ..." |
| `[97]` | **"“What do you suggest we do, then?""** | `[159]` **Lucian Galade**: "“They would try to paint you as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Lucian Galade**: "“According to the initial draft ..." |
| `[99]` | **"“Cut it out, you two. Are you with me or not?""** | `[143]` **Lucian Galade**: ""Mr. Vice President has a point."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Lucian Galade**: ""If you are serious about this, ..." |
| `[111]` | **"“What do you suggest we do?""** | `[112]` **Lucian Galade**: ""I don't think you should take t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Lucian Galade**: "“According to the initial draft ..." |
| `[113]` | **"“You might be right.""** | `[143]` **Lucian Galade**: ""Mr. Vice President has a point."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Lucian Galade**: ""I don't think you should take t..." |
| `[114]` | **"“Only a strong administration can make Sordland great.""** | `[136]` **Petr Vectern**: ""Why would you want to work with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Lucian Galade**: ""That is true, but if we don't e..." |
| `[115]` | **"“I will not limit my veto powers. We need them.""** | `[103]` **Petr Vectern**: ""Don't forget the reformists wan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Narrator**: "Petr looked troubled." |
| `[117]` | **"“They can remain. Some reform is better than none.""** | `[103]` **Petr Vectern**: ""Don't forget the reformists wan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Narrator**: "Petr looked troubled." |
| `[119]` | **"“Of course, it will be looked at in detail.""** | `[103]` **Petr Vectern**: ""Don't forget the reformists wan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Petr Vectern**: ""What everyone's expecting is a ..." |
| `[124]` | **"“We must draft a bill to destroy the power of the judiciary.""** | `[141]` **Lucian Galade**: ""The state is powerful as is. Th..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn01_Reform_DestroyJu...` | `[116]` **Lucian Galade**: ""Very well. We will begin to exp..." |
| `[127]` | **""Fair enough. Let's work with the reformists.""** | `[144]` **Lucian Galade**: ""I understand. We do not have to..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn01_Reform_WorkWithR...` | `[118]` **Lucian Galade**: "“As you wish. We will move forwa..." |
| `[128]` | **"“We can handle it, just like the previous governments did.""** | `[110]` **Lucian Galade**: ""If we go against the demands of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Lucian Galade**: ""It will be a dangerous path to ..." |
| `[129]` | **"“True, we can't do it. It is too dangerous.""** | `[110]` **Lucian Galade**: ""If we go against the demands of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Lucian Galade**: ""It is not a risk worth taking, ..." |
| `[130]` | **""We must draft a bill with more executive powers.""** | `[141]` **Lucian Galade**: ""The state is powerful as is. Th..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn01_Reform_MoreExecu...` | `[116]` **Lucian Galade**: ""Very well. We will begin to exp..." |
| `[132]` | **""No, I will only support a new constitution that strengthens my position. Forget t..."** | `[144]` **Lucian Galade**: ""I understand. We do not have to..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn01_Reform_Strengthe...` | `[116]` **Lucian Galade**: ""Very well. We will begin to exp..." |
| `[133]` | **""Then I don't intend to pursue constitutional change. We will reach out to the Old..."** | `[144]` **Lucian Galade**: ""I understand. We do not have to..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn01_Reform_WorkWithO...` | `[209]` **Narrator**: "Lucian scratched his head." |
| `[135]` | **"“I can handle them. It will be done under the Rayne administration.""** | `[159]` **Lucian Galade**: "“They would try to paint you as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Lucian Galade**: "“That would be tough, sir. But I..." |
| `[137]` | **"“Without the Sollists' support, we have no power.""** | `[136]` **Petr Vectern**: ""Why would you want to work with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Petr Vectern**: ""You're talking about going agai..." |
| `[139]` | **"“I need to maintain my powers.""** | `[136]` **Petr Vectern**: ""Why would you want to work with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Petr Vectern**: ""I don't know if we can survive ..." |
| `[140]` | **"“We can do it, Lucian! Look at what we accomplished so far.""** | `[102]` **Lucian Galade**: "“You would also be burning bridg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Lucian Galade**: "“Of course."" |
| `[146]` | **"“What do you suggest we do then? Maybe I can reconsider working with the reformists.""** | `[102]` **Lucian Galade**: "“You would also be burning bridg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Lucian Galade**: "“According to the initial draft ..." |
| `[147]` | **""No. This is not happening. I'd rather not include either of these points.""** | `[123]` **Lucian Galade**: "“Second, the President's absolut..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Lucian Galade**: "“That will not be accepted by th..." |
| `[148]` | **""I want to minimize the damage to my seat.""** | `[157]` **Lucian Galade**: "“To clarify before we head in an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Lucian Galade**: ""I understand. We do not have to..." |
| `[149]` | **"“I have no problems with these clauses. Let's work with the reformists.""** | `[123]` **Lucian Galade**: "“Second, the President's absolut..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn01_Reform_WorkWithR...` | `[122]` **Lucian Galade**: "“Yes, sir."" |
| `[150]` | **""The President needs to be able to exercise his powers with ease to maintain stabi..."** | `[157]` **Lucian Galade**: "“To clarify before we head in an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Lucian Galade**: ""I understand. We do not have to..." |
| `[151]` | **""We must strengthen the state by removing the power of the Old Guard.""** | `[157]` **Lucian Galade**: "“To clarify before we head in an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Lucian Galade**: ""The state is powerful as is. Th..." |
| `[152]` | **"“The real problem is the judiciary's power, not the president's.""** | `[159]` **Lucian Galade**: "“They would try to paint you as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Lucian Galade**: "“I somewhat agree with you, sir."" |
| `[154]` | **"“We need to address other more important problems, too.""** | `[182]` **Petr Vectern**: ""The reformists are pretty loud ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Petr Vectern**: ""Of course. We'll have time to d..." |
| `[155]` | **"“What is the best outcome for us then?""** | `[131]` **Lucian Galade**: ""It is not a risk worth taking, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Lucian Galade**: "“According to the initial draft ..." |
| `[160]` | **"“What do you suggest, Lucian?""** | `[131]` **Lucian Galade**: ""It is not a risk worth taking, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Lucian Galade**: "“According to the initial draft ..." |
| `[162]` | **"“What about you, Petr?""** | `[121]` **Lucian Galade**: ""However, I must stress that I a..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn01_Reform_WorkWithO...` | `[153]` **Petr Vectern**: ""Yes. Of course I'm with you."" |
| `[171]` | **""We don't need the reformists. We can always work with the NFP.""** | `[167]` **Petr Vectern**: ""Anton, we got elected by promis..."<br>`[169]` **Petr Vectern**: ""We would lose all reformist sup..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Narrator**: "Petr looked troubled." |
| `[173]` | **"“We can package it as a *democratic* reform.”"** | `[167]` **Petr Vectern**: ""Anton, we got elected by promis..."<br>`[169]` **Petr Vectern**: ""We would lose all reformist sup..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Lucian Galade**: "“The public might be persuaded, ..." |
| `[175]` | **"“You're right. Let's work with the reformists.""** | `[182]` **Petr Vectern**: ""The reformists are pretty loud ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn01_Reform_WorkWithR...` | `[172]` **Lucian Galade**: "“As you wish. We will move forwa..." |
| `[176]` | **"“No matter what you say, I intend to come out of this stronger as the President.”"** | `[167]` **Petr Vectern**: ""Anton, we got elected by promis..."<br>`[169]` **Petr Vectern**: ""We would lose all reformist sup..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Lucian Galade**: "“The public might be persuaded, ..." |
| `[181]` | **"“If it must be done, I will do it.""** | `[170]` **Petr Vectern**: ""That does include strengthening..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Lucian Galade**: "“According to the initial draft ..." |
| `[183]` | **"“Can't we avoid strengthening the Assembly?""** | `[170]` **Petr Vectern**: ""That does include strengthening..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Narrator**: "Petr looked troubled." |
| `[185]` | **"“I see that. But we will move towards this direction for now.""** | `[121]` **Lucian Galade**: ""However, I must stress that I a..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn01_Reform_WorkWithO...` | `[209]` **Narrator**: "Lucian scratched his head." |
| `[186]` | **"“I don't care what they think. We can handle them.""** | `[182]` **Petr Vectern**: ""The reformists are pretty loud ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Lucian Galade**: "“To clarify before we head in an..." |
| `[198]` | **"“Our party must fall in line with our position. We can't have a strong divide.""** | `[72]` **Lucian Galade**: "“While the reformist wing inside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Petr Vectern**: ""True. If our party fractures, i..." |
| `[199]` | **"“The USP reformists aren't wrong to agree that we need change, but we should be in..."** | `[72]` **Lucian Galade**: "“While the reformist wing inside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Petr Vectern**: ""We can't let the PFJP leadershi..." |
| `[202]` | **"“Mr. Ricter could be a potential ally in our goal to maintain a majority in the As..."** | `[72]` **Lucian Galade**: "“While the reformist wing inside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Lucian Galade**: "“He's definitely key in this."" |
| `[210]` | **"“I won't be bought, it won't happen.”"** | `[36]` **Lucian Galade**: "“According to reports, some memb..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Lucian Galade**: "“Alphonso said the same thing. I..." |
| `[211]` | **"“I will enter a dialogue with them eventually. We need to be diplomatic.”"** | `[36]` **Lucian Galade**: "“According to reports, some memb..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Lucian Galade**: "“Wise approach. It's good to und..." |
| `[263]` | **"“I want to work with them anyway. The new administration will be open to talk to b..."** | `[36]` **Lucian Galade**: "“According to reports, some memb..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Lucian Galade**: "“It's always easier for the admi..." |
| `[264]` | **"“The military can be close allies. And with the Rumburg threat on the horizon, we ..."** | `[261]` **Lucian Galade**: "“Our election campaign promised ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Lucian Galade**: "“Rumburg is a massive threat. On..." |
| `[265]` | **"“The Sordish Armed Forces represent our pride as a nation and will be funded as pr..."** | `[261]` **Lucian Galade**: "“Our election campaign promised ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Lucian Galade**: "“That will ensure they will be o..." |
| `[266]` | **"“With the Rumburg threat on the horizon, we can't reduce our defense capability an..."** | `[262]` **Lucian Galade**: "“The military and the general st..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Lucian Galade**: "“I would advise the same. The bu..." |
| `[267]` | **"“The military has been nothing but a burden on our society. We should do something..."** | `[262]` **Lucian Galade**: "“The military and the general st..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Lucian Galade**: "“That is possible, but we can be..." |
| `[268]` | **"“If they prove to be a political threat in the future, we can get rid of them.”"** | `[261]` **Lucian Galade**: "“Our election campaign promised ..."<br>`[262]` **Lucian Galade**: "“The military and the general st..." | `Variable["BaseGame.Reform_Dictator_Intention"] == true` | *Brak zmian stanu* | `[273]` **Lucian Galade**: "“Bold strategy Mr. President. On..." |
| `[277]` | **"“I don't want to die in prison just like Artor S. Wisci did.”"** | `[261]` **Lucian Galade**: "“Our election campaign promised ..."<br>`[262]` **Lucian Galade**: "“The military and the general st..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Lucian Galade**: "“None of us want to live through..." |
| `[279]` | **"“I want to receive the advice of the military before making up my mind.”"** | `[262]` **Lucian Galade**: "“The military and the general st..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Lucian Galade**: "“It is sound to listen to them b..." |
| `[283]` | **"“We won't let these privileged, greedy, and snobby capitalists run the country.”"** | `[36]` **Lucian Galade**: "“According to reports, some memb..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Lucian Galade**: "“Let's not underestimate their i..." |
| `[289]` | **"“Tusk is heading the group. We should make sure he is on our side.”"** | `[26]` **Petr Vectern**: "“As far as I know, Konrath's son..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Petr Vectern**: "“He'd be a useful ally as well. ..." |
| `[291]` | **""That's exactly what I'm aiming to do.""** | `[102]` **Lucian Galade**: "“You would also be burning bridg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Lucian Galade**: "“Of course."" |

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
  - -> `[4]` (*Narrator: "Petr Vectern arrived a couple of minutes early and sat ac..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The door swung open and Lucian Galade, my chief strategist, walked in. He was a compact man with sharp, birdlike features. After briefly surveying the room from wall to wall, he sat down, poured a glass of water and opened his briefcase in a series of quick, graceful movements."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucian Galade: "“Gentlemen.”"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Petr Vectern arrived a couple of minutes early and sat across from me. He was struggling to hold back his smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Holsord_PublicOpinion = true"*)

### Węzeł `[5]`
Mówca: **Petr Vectern**
> "“But, hey, back in university, did you ever imagine we would be sitting here in the Maroon Palace? We have to celebrate this great victory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: "“Let's celebrate then. I got my hands on something specia..."*)
  - -> `[7]` (*Player: "“We will celebrate at the inaugural ball. Just hang in th..."*)
  - -> `[6]` (*Player: "“This is not the time to celebrate, Petr. We have work to..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“This is not the time to celebrate, Petr. We have work to do.”"]** — Mówca: **Player**
> "“This is not the time to celebrate, Petr. We have work to do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Petr Vectern: "“Yes... I agree. We've got things to do today. We can let..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“We will celebrate at the inaugural ball. Just hang in there until the evening.”"]** — Mówca: **Player**
> "“We will celebrate at the inaugural ball. Just hang in there until the evening.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Petr Vectern: "“Looking forward to it. Evelyn hopes to congratulate you ..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Let's celebrate then. I got my hands on something special for us. An Erlory Maroon 30-year-old.”"]** — Mówca: **Player**
> "“Let's celebrate then. I got my hands on something special for us. An Erlory Maroon 30-year-old.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_WhiskeyBottle");"*)

### Węzeł `[9]`
Mówca: **Petr Vectern**
> "“Looking forward to it. Evelyn hopes to congratulate you in person there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“Good to know. It's been some time since the last time I ..."*)
  - -> `[11]` (*Player: "“I'm sure the kids would love to see their Uncle Petr for..."*)
  - -> `[32]` (*Player: "“We'll see each other at the ball, then.""*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Good to know. It's been some time since the last time I saw her.""]** — Mówca: **Player**
> "“Good to know. It's been some time since the last time I saw her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Petr Vectern: "“I think it was Franc's birthday. We've barely had enough..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“I'm sure the kids would love to see their Uncle Petr for the first time as the Vice President.”"]** — Mówca: **Player**
> "“I'm sure the kids would love to see their Uncle Petr for the first time as the Vice President.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Petr Vectern: "“That is great to hear! It's crazy how fast the two have ..."*)

### Węzeł `[12]`
Mówca: **Petr Vectern**
> "“I think it was Franc's birthday. We've barely had enough time for our families over these past months, haven't we?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Petr had a wistful look in his eyes. He and Evelyn had ne..."*)

### Węzeł `[13]`
Mówca: **Petr Vectern**
> "“That is great to hear! It's crazy how fast the two have grown up. You are a good father.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Petr had a wistful look in his eyes. He and Evelyn had ne..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Petr had a wistful look in his eyes. He and Evelyn had never been able to have kids of their own. During our campaign, the opposition had floated the rumor that he'd fathered illegitimate children during his wilder years, but it had never been substantiated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucian Arrives For Political Overview]"*)

### Węzeł `[15]`
Mówca: **Petr Vectern**
> "“Yes... I agree. We've got things to do today. We can let loose at the ball.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Petr Vectern: ""Let's move on with the meeting .""*)

### Węzeł `[16]`
Mówca: **Lucian Galade**
> "“Gentlemen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "The tall-case clock in the room struck three o'clock."*)

### Węzeł `[17]`
Mówca: **Petr Vectern**
> "“We'll be talking about our political strategy for this term. Lucian and I had a meeting with the party and the reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Petr Vectern: "“We mostly see eye to eye, but I would want to know what ..."*)

### Węzeł `[18]`
Mówca: **Petr Vectern**
> "“We mostly see eye to eye, but I would want to know what you think.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "“I hope things are looking good.”"*)
  - -> `[20]` (*Player: "“Great. Let's go over this when Lucian arrives.”"*)
  - -> `[19]` (*Player: "“Let's see if I see eye to eye.”"*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“Let's see if I see eye to eye.”"]** — Mówca: **Player**
> "“Let's see if I see eye to eye.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucian Arrives For Political Overview]"*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Great. Let's go over this when Lucian arrives.”"]** — Mówca: **Player**
> "“Great. Let's go over this when Lucian arrives.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucian Arrives For Political Overview]"*)

### Węzeł `[21]`
Mówca: **Narrator**
> "The tall-case clock in the room struck three o'clock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Petr Vectern: "“Damn. You are exactly on time.""*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> "“Hello, Petr.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Lucian then turned towards me. He very slightly bowed his..."*)

### Węzeł `[23]`
Mówca: **Petr Vectern**
> "“Damn. You are exactly on time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: "“Hello, Petr.”"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Lucian then turned towards me. He very slightly bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“Glad to see you, Lucian.”"*)
  - -> `[58]` (*Player: "“Lucian. How are you?”"*)
  - -> `[60]` (*Player: "“Let's not waste any time. Lucian, proceed with the overv..."*)

### Węzeł `[25]`
Mówca: **Lucian Galade**
> "“Another important point. We must be aware of the Lotherberg Group. The Oligarchs convene under this organization to influence economic policies. Konrath Koronti led it for a long time before falling ill. The new leader is Mr. Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: "“According to reports, some members of the National Busin..."*)

### Węzeł `[26]`
Mówca: **Petr Vectern**
> "“As far as I know, Konrath's son Marcel has strong ties to this group. His influence could definitely be an asset for us. But I'm sure he'll want something in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "“I am aware of Mr. Koronti's wide network. That could com..."*)
  - -> `[28]` (*Player: "“The Group's influence is an important force. One that we..."*)
  - -> `[29]` (*Player: "“That group is dependent on our economic policies. They c..."*)
  - -> `[289]` (*Player: "“Tusk is heading the group. We should make sure he is on ..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“I am aware of Mr. Koronti's wide network. That could come in handy.”"]** — Mówca: **Player**
> "“I am aware of Mr. Koronti's wide network. That could come in handy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Petr Vectern: "“We just need to be careful with him. He looks like the l..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“The Group's influence is an important force. One that we should use to our administration's advantage.”"]** — Mówca: **Player**
> "“The Group's influence is an important force. One that we should use to our administration's advantage.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Petr Vectern: "“If we can get them to side with us. It all depends on wh..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“That group is dependent on our economic policies. They can't move a finger without us.”"]** — Mówca: **Player**
> "“That group is dependent on our economic policies. They can't move a finger without us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Petr Vectern: "“I wouldn't be so optimistic. The capital they represent ..."*)

### Węzeł `[30]`
Mówca: **Petr Vectern**
> "“I wouldn't be so optimistic. The capital they represent could do a lot of damage if it was diverted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“We need to tread carefully on all sides with all power p..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Lucian took notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: "“Another important point. We must be aware of the Lotherb..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“We'll see each other at the ball, then.""]** — Mówca: **Player**
> "“We'll see each other at the ball, then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Petr Vectern: "“Definitely!""*)

### Węzeł `[33]`
Mówca: **Petr Vectern**
> "“Definitely!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Petr Vectern: ""Let's move on with the meeting .""*)

### Węzeł `[34]`
Mówca: **Petr Vectern**
> ""Let's move on with the meeting .""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Petr Vectern: "“We'll be talking about our political strategy for this t..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“I hope things are looking good.”"]** — Mówca: **Player**
> "“I hope things are looking good.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucian Arrives For Political Overview]"*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> "“According to reports, some members of the National Business Council are in their pockets. Tusk and the Group will surely try to bribe us in exchange for special economic protections.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Player: "“I want to work with them anyway. The new administration ..."*)
  - -> `[210]` (*Player: "“I won't be bought, it won't happen.”"*)
  - -> `[211]` (*Player: "“I will enter a dialogue with them eventually. We need to..."*)
  - -> `[283]` (*Player: "“We won't let these privileged, greedy, and snobby capita..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Lucian looked at Petr."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Petr Vectern: "“As far as I know, Konrath's son Marcel has strong ties t..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn01_A_PoliticalOverview = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn01_A_PoliticalOverview"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[39]`
Mówca: **Petr Vectern**
> "“If we can get them to side with us. It all depends on what benefits we can offer and what the leader wants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“We need to tread carefully on all sides with all power p..."*)

### Węzeł `[40]`
Mówca: **Petr Vectern**
> "“We just need to be careful with him. He looks like the lesser evil, but it could very quickly turn out to be the other way around.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“We need to tread carefully on all sides with all power p..."*)

### Węzeł `[41]`
Mówca: **Lucian Galade**
> "“We need to tread carefully on all sides with all power players to survive our term. I need to underline the seriousness of the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == true"*)

### Węzeł `[42]`
Mówca: **Lucian Galade**
> "“This concludes our political briefing for today. Our next meeting will be about our media strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lucian Galade: "“Talk to you soon, sir. I will keep in touch.”"*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Lucian and Petr bid their farewells and left. A mysterious amount of smoke was rising far away on the horizon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Deyr_IncreasingHomeless = t..."*)

### Węzeł `[44]`
Mówca: **Lucian Galade**
> "“Let's start by evaluating our current situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: "“The majority of the Sordish people demand change. They a..."*)

### Węzeł `[45]`
Mówca: **Lucian Galade**
> "“It may create issues for us, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lucian Galade: "“However, with the reformists gaining more popularity, we..."*)

### Węzeł `[46]`
Mówca: **Lucian Galade**
> "“However, with the reformists gaining more popularity, we may not be in a position to stand against them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: "“Mr. Ricter managed to persuade many members of Assembly ..."*)

### Węzeł `[47]`
Mówca: **Lucian Galade**
> "“The majority of the Sordish people demand change. They are more concerned about the economy than the Constitution, but they blame the system for their problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Petr Vectern: ""People are losing their trust in our democracy. Why do y..."*)

### Węzeł `[48]`
Mówca: **Lucian Galade**
> "“It will not be easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucian Galade: "“We will need many allies against the Old Guard in the go..."*)

### Węzeł `[49]`
Mówca: **Petr Vectern**
> ""People are losing their trust in our democracy. Why do you think radicals like Bernard Circas are becoming more popular? Everyone's expecting us to bring the change the last government did not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Lucian Galade: "“Frens Ricter, leader of the reformists, believes that tr..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“I agree with the reformists. Our responsibility is to democratize our broken system.""]** — Mówca: **Player**
> "“I agree with the reformists. Our responsibility is to democratize our broken system.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic += 1"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“We need to listen to the people if we want to serve this country.""]** — Mówca: **Player**
> "“We need to listen to the people if we want to serve this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true"*)

### Węzeł `[52]`
Mówca: **Lucian Galade**
> "“We will need many allies against the Old Guard in the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: "“Mr. Ricter managed to persuade many members of Assembly ..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“If we lose power, we won't be able to execute the changes we need to make for the good of the country.""]** — Mówca: **Player**
> "“If we lose power, we won't be able to execute the changes we need to make for the good of the country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: "“It may create issues for us, yes.""*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Speech_Democracy_Liberal == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Petr Vectern: ""That's exactly what we campaigned for. A true change tha..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Speech_Democracy_Liberal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lucian Galade: "“It will not be easy.""*)

### Węzeł `[57]`
Mówca: **Petr Vectern**
> ""That's exactly what we campaigned for. A true change that will move the country forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucian Galade: "“We will need many allies against the Old Guard in the go..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Lucian. How are you?”"]** — Mówca: **Player**
> "“Lucian. How are you?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucian Galade: "“I am ready and able, sir.""*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Glad to see you, Lucian.”"]** — Mówca: **Player**
> "“Glad to see you, Lucian.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucian Galade: "“It is a privilege to be here, sir.""*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Let's not waste any time. Lucian, proceed with the overview.”"]** — Mówca: **Player**
> "“Let's not waste any time. Lucian, go ahead with the overview.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucian Galade: "“As you wish, sir.""*)

### Węzeł `[61]`
Mówca: **Lucian Galade**
> "“It is a privilege to be here, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Lucian spoke in soft, clipped tones that immediately drew..."*)

### Węzeł `[62]`
Mówca: **Lucian Galade**
> "“I am ready and able, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Lucian spoke in soft, clipped tones that immediately drew..."*)

### Węzeł `[63]`
Mówca: **Lucian Galade**
> "“As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Lucian spoke in soft, clipped tones that immediately drew..."*)

### Węzeł `[64]`
Mówca: **Lucian Galade**
> "“A comprehensive reform that would make the reformists happy would mean maintaining a balance between all branches of government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: "“Which means removing your absolute veto as well. The ref..."*)

### Węzeł `[65]`
Mówca: **Petr Vectern**
> ""I agree. The Old Guard won't like this, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lucian Galade: "“A comprehensive reform that would make the reformists ha..."*)

### Węzeł `[66]`
Mówca: **Petr Vectern**
> ""We need to work with the Supreme Court one way or the other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“Which means removing your absolute veto as well. The reformists demand that all loopholes in the Constitution are closed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: "“Looks like we have many challenges ahead.”"*)
  - -> `[85]` (*Player: "“We cannot allow obstructionists to exist.”"*)
  - -> `[87]` (*Player: "“We can't underestimate this situation.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“We'll need a comprehensive bill to balance the power structure more fairly.""]** — Mówca: **Player**
> "“We'll need a comprehensive bill to balance the power structure more fairly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Petr Vectern: ""I agree. The Old Guard won't like this, though.""*)

### Węzeł `[69]`
Mówca: **Lucian Galade**
> "“The Old Guard will do its best to preserve the Constitution. Chief Justice Hawker and his allied judges have a great influence over the Supreme Court, which will be tough to break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Petr Vectern: ""The Court also has the final say over constitutional leg..."*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> "“Mr. Ricter managed to persuade many members of Assembly to give their support for drafting a new Constitution. Reformist politicians are quickly increasing in number.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: "“While the reformist wing inside our party is still a min..."*)

### Węzeł `[71]`
Mówca: **Petr Vectern**
> ""The Court also has the final say over constitutional legislation. Without their approval, we cannot even change it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: "“We'll need a comprehensive bill to balance the power str..."*)
  - -> `[74]` (*Player: "“We must break the power of the Supreme Court one way or ..."*)
  - -> `[77]` (*Player: "“I'd rather not go against them. The risks are too high.""*)

### Węzeł `[72]`
Mówca: **Lucian Galade**
> "“While the reformist wing inside our party is still a minority, they could have a tri-partisan majority in the assembly, especially if they unite under Frens Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player: "“The USP reformists aren't wrong to agree that we need ch..."*)
  - -> `[202]` (*Player: "“Mr. Ricter could be a potential ally in our goal to main..."*)
  - -> `[198]` (*Player: "“Our party must fall in line with our position. We can't ..."*)

### Węzeł `[73]`
Mówca: **Lucian Galade**
> "“I agree. They have too much power over Sordish politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Petr Vectern: ""We need to take away their vote in constitutional legisl..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“We must break the power of the Supreme Court one way or another.""]** — Mówca: **Player**
> "“We must break the power of the Supreme Court one way or another.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lucian Galade: "“I agree. They have too much power over Sordish politics.""*)

### Węzeł `[75]`
Mówca: **Petr Vectern**
> ""The reformists' demands are clear. They want to limit the President's veto powers, ensure that the Supreme Court is independent and take away the Court's right to vote on constitutional amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "“I support the reformists. We need a proper balance of po..."*)
  - -> `[80]` (*Player: "“We must listen to their demands. Otherwise we are no dif..."*)
  - -> `[81]` (*Player: ""I won't allow them to influence me. We will shape our ow..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“I support the reformists. We need a proper balance of power in this country.""]** — Mówca: **Player**
> "“I support the reformists. We need a proper balance of power in this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Petr Vectern: ""I agree. We can't ignore the winds of change, after all.""*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“I'd rather not go against them. The risks are too high.""]** — Mówca: **Player**
> "“I'd rather not go against them. The risks are too high.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Petr Vectern: ""We need to work with the Supreme Court one way or the ot..."*)

### Węzeł `[78]`
Mówca: **Lucian Galade**
> "“I agree, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: "“The Old Guard will do its best to preserve the Constitut..."*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> "“True. But we can't let the Old Guard manipulate us and then backstab us, like they did with Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: "“Looks like we have many challenges ahead.”"*)
  - -> `[85]` (*Player: "“We cannot allow obstructionists to exist.”"*)
  - -> `[87]` (*Player: "“We can't underestimate this situation.""*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“We must listen to their demands. Otherwise we are no different than the previous administrations.""]** — Mówca: **Player**
> "“We must listen to their demands. Otherwise we are no different than the previous administrations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Petr Vectern: ""I agree. We can't ignore the winds of change, after all.""*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""I won't allow them to influence me. We will shape our own future.""]** — Mówca: **Player**
> ""I won't allow them to influence me. We will shape our own future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucian Galade: "“I agree, sir.""*)

### Węzeł `[82]`
Mówca: **Petr Vectern**
> ""We need to take away their vote in constitutional legislation. It is absurd that they get to vote for bills when they aren't even elected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: "“Looks like we have many challenges ahead.”"*)
  - -> `[85]` (*Player: "“We cannot allow obstructionists to exist.”"*)
  - -> `[87]` (*Player: "“We can't underestimate this situation.""*)

### Węzeł `[83]`
Mówca: **Petr Vectern**
> ""I agree. We can't ignore the winds of change, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: "“The Old Guard will do its best to preserve the Constitut..."*)

### Węzeł `[84]`
Mówca: **Petr Vectern**
> "“We can figure it out. Our party still holds 130 out of 250 seats in the Assembly. We've got the power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Lucian Galade: "“However, to reform the constitution we must receive a tw..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "“We cannot allow obstructionists to exist.”"]** — Mówca: **Player**
> "“We cannot allow obstructionists to exist.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Lucian Galade), `[79]` (Lucian Galade), `[82]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Petr Vectern: "“We can figure it out. Our party still holds 130 out of 2..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "“Looks like we have many challenges ahead.”"]** — Mówca: **Player**
> "“Looks like we have many challenges ahead.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Lucian Galade), `[79]` (Lucian Galade), `[82]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Petr Vectern: "“We can figure it out. Our party still holds 130 out of 2..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "“We can't underestimate this situation.""]** — Mówca: **Player**
> "“We can't underestimate this situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Lucian Galade), `[79]` (Lucian Galade), `[82]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Petr Vectern: "“We can figure it out. Our party still holds 130 out of 2..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“We will write a more democratic Constitution with the reformists.""]** — Mówca: **Player**
> "“We will write a more democratic Constitution with the reformists.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic += 1"*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“The new Constitution should give the President wide-ranging powers to lead Sordland into the future.""]** — Mówca: **Player**
> "“The new Constitution should give the President wide-ranging powers to lead Sordland into the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic -= 1"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“We could work with the Old Guard to protect our existing extensive powers.""]** — Mówca: **Player**
> "“We could work with the Old Guard to protect our existing extensive powers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Speech_Democracy_Liberal == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Petr Vectern: ""That's what we've been preparing for internally. Don't f..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Speech_Democracy_Liberal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Petr Vectern: ""It will be tough to persuade our base if we work with Ri..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“How can we come out of this in the best shape?""]** — Mówca: **Player**
> "“How can we come out of this in the best shape?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: "“According to the initial draft we made with the reformis..."*)

### Węzeł `[95]`
Mówca: **Petr Vectern**
> ""That's what we've been preparing for internally. Don't forget that promise is what got us elected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: ""The key thing here will be strengthening the power of th..."*)

### Węzeł `[96]`
Mówca: **Lucian Galade**
> ""The key thing here will be strengthening the power of the Assembly, which we already lead with a majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "Petr nodded in agreement."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "“What do you suggest we do, then?""]** — Mówca: **Player**
> "“What do you suggest we do, then?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: "“According to the initial draft we made with the reformis..."*)

### Węzeł `[98]`
Mówca: **Petr Vectern**
> ""It will be tough to persuade our base if we work with Ricter and his band of reformists. But everyone agrees we need a new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: ""The key thing here will be strengthening the power of th..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA: "“Cut it out, you two. Are you with me or not?""]** — Mówca: **Player**
> "“Cut it out, you two. Are you with me or not?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Lucian Galade: ""If you are serious about this, I will explore the option..."*)

### Węzeł `[100]`
Mówca: **Lucian Galade**
> "“That will not be accepted by the reformists. This draft has been created with the advice of both our party and PFJP members.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Petr Vectern: ""Keeping your absolute veto over legislation but taking a..."*)

### Węzeł `[101]`
Mówca: **Lucian Galade**
> ""That's very bold. Then we must start with eliminating the Supreme Court's authority over constitutional legislation and perhaps take their immunity away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Petr Vectern: ""Don't forget the reformists want us to address the looph..."*)

### Węzeł `[102]`
Mówca: **Lucian Galade**
> "“You would also be burning bridges with the Reformists and the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player: ""That's exactly what I'm aiming to do.""*)
  - -> `[140]` (*Player: "“We can do it, Lucian! Look at what we accomplished so far.""*)
  - -> `[146]` (*Player: "“What do you suggest we do then? Maybe I can reconsider w..."*)

### Węzeł `[103]`
Mówca: **Petr Vectern**
> ""Don't forget the reformists want us to address the loopholes in the presidential veto system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: "“I will not limit my veto powers. We need them.""*)
  - -> `[117]` (*Player: "“They can remain. Some reform is better than none.""*)
  - -> `[119]` (*Player: "“Of course, it will be looked at in detail.""*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Speech_Democracy_Liberal == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Petr Vectern: ""You must remember that we promised people a democratic C..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Speech_Democracy_Liberal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Petr Vectern: ""How? You know the public wants us to enact extensive ref..."*)

### Węzeł `[107]`
Mówca: **Petr Vectern**
> ""You must remember that we promised people a democratic Constitution during the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "Lucian raised an eyebrow."*)

### Węzeł `[108]`
Mówca: **Petr Vectern**
> ""How? You know the public wants us to enact extensive reforms. And how do we know if the Old Guard would support you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "Lucian raised an eyebrow."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Lucian opened his dossier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Lucian Galade: "“First, the Supreme Court will no longer vote on constitu..."*)

### Węzeł `[110]`
Mówca: **Lucian Galade**
> ""If we go against the demands of the people, the reformists will be furious. It could backfire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: "“True, we can't do it. It is too dangerous.""*)
  - -> `[128]` (*Player: "“We can handle it, just like the previous governments did.""*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“What do you suggest we do?""]** — Mówca: **Player**
> "“What do you suggest we do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: "“According to the initial draft we made with the reformis..."*)

### Węzeł `[112]`
Mówca: **Lucian Galade**
> ""I don't think you should take the risk, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player: "“What do you suggest we do?""*)
  - -> `[94]` (*Player: "“How can we come out of this in the best shape?""*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“You might be right.""]** — Mówca: **Player**
> "“You might be right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucian Galade: ""I don't think you should take the risk, Mr. President.""*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Only a strong administration can make Sordland great.""]** — Mówca: **Player**
> "“Only a strong administration can make Sordland great.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucian Galade: ""That is true, but if we don't evolve we might become par..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“I will not limit my veto powers. We need them.""]** — Mówca: **Player**
> "“I will not limit my veto powers. We need them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "Petr looked troubled."*)

### Węzeł `[116]`
Mówca: **Lucian Galade**
> ""Very well. We will begin to explore how to realistically pass such a constitutional change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Intention = true"*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“They can remain. Some reform is better than none.""]** — Mówca: **Player**
> "“They can remain. Some reform is better than none.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "Petr looked troubled."*)

### Węzeł `[118]`
Mówca: **Lucian Galade**
> "“As you wish. We will move forward on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Lucian nodded."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“Of course, it will be looked at in detail.""]** — Mówca: **Player**
> "“Of course, it will be looked at in detail.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Petr Vectern: ""What everyone's expecting is a rebalance of power betwee..."*)

### Węzeł `[120]`
Mówca: **Lucian Galade**
> ""That is true, but if we don't evolve we might become part of the problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Petr Vectern: ""You're talking about going against the reformists and pu..."*)

### Węzeł `[121]`
Mówca: **Lucian Galade**
> ""However, I must stress that I am not for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: "“I see that. But we will move towards this direction for ..."*)
  - -> `[162]` (*Player: "“What about you, Petr?""*)

### Węzeł `[122]`
Mówca: **Lucian Galade**
> "“Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Lucian nodded."*)

### Węzeł `[123]`
Mówca: **Lucian Galade**
> "“Second, the President's absolute veto will be taken away. This can be replaced with a limited veto system by fixing the current loopholes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: "“I have no problems with these clauses. Let's work with t..."*)
  - -> `[147]` (*Player: ""No. This is not happening. I'd rather not include either..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "“We must draft a bill to destroy the power of the judiciary.""]** — Mówca: **Player**
> "“We must draft a bill to destroy the power of the judiciary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_Reform_DestroyJudiciary = ..."*)

### Węzeł `[125]`
Mówca: **Lucian Galade**
> "“Taking away the legislative power of the Supreme Court while holding your own absolute authority over legislation would look like an attempt to consolidate your own power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true"*)

### Węzeł `[126]`
Mówca: **Petr Vectern**
> ""Yes. The divisions of power need to be rebalanced for a better Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: "“According to the initial draft we made with the reformis..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Fair enough. Let's work with the reformists.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_Reform_WorkWithReformists ..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: "“We can handle it, just like the previous governments did.""]** — Mówca: **Player**
> "“We can handle it, just like the previous governments did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Lucian Galade: ""It will be a dangerous path to follow.""*)

### Węzeł `[129]`
**[WYBÓR GRACZA: "“True, we can't do it. It is too dangerous.""]** — Mówca: **Player**
> "“True, we can't do it. It is too dangerous.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lucian Galade: ""It is not a risk worth taking, Mr. President.""*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""We must draft a bill with more executive powers.""]** — Mówca: **Player**
> ""We must draft a bill with more executive powers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_Reform_MoreExecutivePower ..."*)

### Węzeł `[131]`
Mówca: **Lucian Galade**
> ""It is not a risk worth taking, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player: "“What do you suggest, Lucian?""*)
  - -> `[155]` (*Player: "“What is the best outcome for us then?""*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, I will only support a new constitution that strengthens my position. Forget the reformists and reach out to the NFP instead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_Reform_StrengthenYourPosit..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA: ""Then I don't intend to pursue constitutional change. We will reach out to the Old Guard.""]** — Mówca: **Player**
> ""Then I don't intend to pursue constitutional change. We will reach out to the Old Guard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_Reform_WorkWithOldGuards =..."*)

### Węzeł `[134]`
Mówca: **Lucian Galade**
> ""It will be a dangerous path to follow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Petr shook his head."*)

### Węzeł `[135]`
**[WYBÓR GRACZA: "“I can handle them. It will be done under the Rayne administration.""]** — Mówca: **Player**
> "“I can handle them. It will be done under the Rayne administration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucian Galade: "“That would be tough, sir. But I trust your judgement.""*)

### Węzeł `[136]`
Mówca: **Petr Vectern**
> ""Why would you want to work with the Old Guard?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: "“Without the Sollists' support, we have no power.""*)
  - -> `[139]` (*Player: "“I need to maintain my powers.""*)
  - -> `[114]` (*Player: "“Only a strong administration can make Sordland great.""*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“Without the Sollists' support, we have no power.""]** — Mówca: **Player**
> "“Without the Sollists' support, we have no power.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Petr Vectern: ""You're talking about going against the reformists and pu..."*)

### Węzeł `[138]`
Mówca: **Petr Vectern**
> ""Keeping your absolute veto over legislation but taking away the Supreme Court's influence over the Assembly would make it look like a power grab.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Petr Vectern: ""The reformists are pretty loud about their thoughts on t..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "“I need to maintain my powers.""]** — Mówca: **Player**
> "“I need to maintain my powers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Petr Vectern: ""I don't know if we can survive that politically.""*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“We can do it, Lucian! Look at what we accomplished so far.""]** — Mówca: **Player**
> "“We can do it, Lucian! Look at what we accomplished so far.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Lucian Galade: "“Of course.""*)

### Węzeł `[141]`
Mówca: **Lucian Galade**
> ""The state is powerful as is. The question is how to approach these constitutional amendments and if it's realistic to pull off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: ""We must draft a bill with more executive powers.""*)
  - -> `[124]` (*Player: "“We must draft a bill to destroy the power of the judicia..."*)

### Węzeł `[142]`
Mówca: **Petr Vectern**
> ""You're talking about going against the reformists and public opinion all at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Lucian Galade: ""Mr. Vice President has a point.""*)

### Węzeł `[143]`
Mówca: **Lucian Galade**
> ""Mr. Vice President has a point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: "“You might be right.""*)
  - -> `[99]` (*Player: "“Cut it out, you two. Are you with me or not?""*)

### Węzeł `[144]`
Mówca: **Lucian Galade**
> ""I understand. We do not have to remove your veto. Instead, we can discuss limiting it with the reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: ""No, I will only support a new constitution that strength..."*)
  - -> `[127]` (*Player: ""Fair enough. Let's work with the reformists.""*)
  - -> `[133]` (*Player: ""Then I don't intend to pursue constitutional change. We ..."*)

### Węzeł `[145]`
Mówca: **Petr Vectern**
> ""I don't know if we can survive that politically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Petr Vectern: ""You're talking about going against the reformists and pu..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“What do you suggest we do then? Maybe I can reconsider working with the reformists.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: "“According to the initial draft we made with the reformis..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. This is not happening. I'd rather not include either of these points.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucian Galade: "“That will not be accepted by the reformists. This draft ..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""I want to minimize the damage to my seat.""]** — Mówca: **Player**
> ""I want to minimize the damage to my seat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Lucian Galade: ""I understand. We do not have to remove your veto. Instea..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA: "“I have no problems with these clauses. Let's work with the reformists.""]** — Mówca: **Player**
> "“I have no problems with these clauses. Let's work with the reformists.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_Reform_WorkWithReformists ..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""The President needs to be able to exercise his powers with ease to maintain stability.""]** — Mówca: **Player**
> ""The President needs to be able to exercise his powers with ease to maintain stability.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Lucian Galade: ""I understand. We do not have to remove your veto. Instea..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""We must strengthen the state by removing the power of the Old Guard.""]** — Mówca: **Player**
> ""We must strengthen the state by removing the power of the Old Guard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lucian Galade: ""The state is powerful as is. The question is how to appr..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "“The real problem is the judiciary's power, not the president's.""]** — Mówca: **Player**
> "“The real problem is the judiciary's power, not the president's.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Lucian Galade: "“I somewhat agree with you, sir.""*)

### Węzeł `[153]`
Mówca: **Petr Vectern**
> ""Yes. Of course I'm with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Lucian Galade: ""Well... Let's see what we can do about it.""*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We need to address other more important problems, too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Petr Vectern: ""Of course. We'll have time to discuss everything you want.""*)

### Węzeł `[155]`
**[WYBÓR GRACZA: "“What is the best outcome for us then?""]** — Mówca: **Player**
> "“What is the best outcome for us then?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: "“According to the initial draft we made with the reformis..."*)

### Węzeł `[156]`
Mówca: **Lucian Galade**
> ""If you are serious about this, I will explore the options for you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucian Galade: ""However, I must stress that I am not for this.""*)

### Węzeł `[157]`
Mówca: **Lucian Galade**
> "“To clarify before we head in any particular direction, what are your intentions, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: ""We must strengthen the state by removing the power of th..."*)
  - -> `[150]` (*Player: ""The President needs to be able to exercise his powers wi..."*)
  - -> `[148]` (*Player: ""I want to minimize the damage to my seat.""*)

### Węzeł `[158]`
Mówca: **Lucian Galade**
> "“The public might be persuaded, but the reformists in the Assembly are not going to fall for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Lucian Galade: "“They would try to paint you as yet another strongman try..."*)

### Węzeł `[159]`
Mówca: **Lucian Galade**
> "“They would try to paint you as yet another strongman trying to grab more power for himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player: "“What do you suggest we do, then?""*)
  - -> `[152]` (*Player: "“The real problem is the judiciary's power, not the presi..."*)
  - -> `[135]` (*Player: "“I can handle them. It will be done under the Rayne admin..."*)

### Węzeł `[160]`
**[WYBÓR GRACZA: "“What do you suggest, Lucian?""]** — Mówca: **Player**
> "“What do you suggest, Lucian?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: "“According to the initial draft we made with the reformis..."*)

### Węzeł `[161]`
Mówca: **Lucian Galade**
> ""It would be quite difficult to secure the 166 votes needed to propose such a bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: "“You would also be burning bridges with the Reformists an..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA: "“What about you, Petr?""]** — Mówca: **Player**
> "“What about you, Petr?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_Reform_WorkWithOldGuards =..."*)

### Węzeł `[163]`
Mówca: **Petr Vectern**
> ""It will be very difficult to plead that case to the reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Lucian Galade: "“Taking away the legislative power of the Supreme Court w..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Speech_Democracy_Liberal == true)"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Petr Vectern: ""Anton, we got elected by promising democratic reforms.""*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Speech_Democracy_Liberal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Petr Vectern: ""We would lose all reformist support.""*)

### Węzeł `[167]`
Mówca: **Petr Vectern**
> ""Anton, we got elected by promising democratic reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player: "“We can package it as a *democratic* reform.”"*)
  - -> `[176]` (*Player: "“No matter what you say, I intend to come out of this str..."*)
  - -> `[171]` (*Player: ""We don't need the reformists. We can always work with th..."*)

### Węzeł `[168]`
Mówca: **Lucian Galade**
> "“That would be tough, sir. But I trust your judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucian Galade: ""It would be quite difficult to secure the 166 votes need..."*)

### Węzeł `[169]`
Mówca: **Petr Vectern**
> ""We would lose all reformist support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player: "“We can package it as a *democratic* reform.”"*)
  - -> `[176]` (*Player: "“No matter what you say, I intend to come out of this str..."*)
  - -> `[171]` (*Player: ""We don't need the reformists. We can always work with th..."*)

### Węzeł `[170]`
Mówca: **Petr Vectern**
> ""That does include strengthening the Assembly by giving them a chance to override vetoes, as well as ensuring that the judiciary is independent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player: "“Can't we avoid strengthening the Assembly?""*)
  - -> `[181]` (*Player: "“If it must be done, I will do it.""*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We don't need the reformists. We can always work with the NFP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Petr Vectern), `[169]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "Petr looked troubled."*)

### Węzeł `[172]`
Mówca: **Lucian Galade**
> "“As you wish. We will move forward on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Lucian nodded."*)

### Węzeł `[173]`
**[WYBÓR GRACZA: "“We can package it as a *democratic* reform.”"]** — Mówca: **Player**
> "“We can package it as a *democratic* reform.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Petr Vectern), `[169]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Lucian Galade: "“The public might be persuaded, but the reformists in the..."*)

### Węzeł `[174]`
Mówca: **Lucian Galade**
> "“However, most people will not be persuaded by that. It would be tough to reach the 166 votes needed to propose such a bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: "“You would also be burning bridges with the Reformists an..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You're right. Let's work with the reformists.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_Reform_WorkWithReformists ..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: "“No matter what you say, I intend to come out of this stronger as the President.”"]** — Mówca: **Player**
> "“No matter what you say, I intend to come out of this stronger as the President.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Petr Vectern), `[169]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Lucian Galade: "“The public might be persuaded, but the reformists in the..."*)

### Węzeł `[177]`
Mówca: **Lucian Galade**
> ""Well... Let's see what we can do about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "Lucian scratched his head."*)

### Węzeł `[178]`
Mówca: **Lucian Galade**
> "“I somewhat agree with you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Lucian Galade: "“However, most people will not be persuaded by that. It w..."*)

### Węzeł `[179]`
Mówca: **Petr Vectern**
> ""What everyone's expecting is a rebalance of power between the executive, legislative and judiciary branches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Petr Vectern: ""That does include strengthening the Assembly by giving t..."*)

### Węzeł `[180]`
Mówca: **Petr Vectern**
> ""Of course. We'll have time to discuss everything you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Lucian Galade: "“To clarify before we head in any particular direction, w..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA: "“If it must be done, I will do it.""]** — Mówca: **Player**
> "“If it must be done, I will do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: "“According to the initial draft we made with the reformis..."*)

### Węzeł `[182]`
Mówca: **Petr Vectern**
> ""The reformists are pretty loud about their thoughts on the presidential powers, Anton. You know they think this position breeds dictators.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player: "“I don't care what they think. We can handle them.""*)
  - -> `[175]` (*Player: "“You're right. Let's work with the reformists.""*)
  - -> `[154]` (*Player: "“We need to address other more important problems, too.""*)

### Węzeł `[183]`
**[WYBÓR GRACZA: "“Can't we avoid strengthening the Assembly?""]** — Mówca: **Player**
> "“Can't we avoid strengthening the Assembly?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "Petr looked troubled."*)

### Węzeł `[184]`
Mówca: **Lucian Galade**
> "“According to the initial draft we made with the reformists, there are two changes to the Constitution that are not open for their discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Lucian opened his dossier."*)

### Węzeł `[185]`
**[WYBÓR GRACZA: "“I see that. But we will move towards this direction for now.""]** — Mówca: **Player**
> "“I see that. But we will move towards this direction for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_Reform_WorkWithOldGuards =..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I don't care what they think. We can handle them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Lucian Galade: "“To clarify before we head in any particular direction, w..."*)

### Węzeł `[187]`
Mówca: **Lucian Galade**
> "“First, the Supreme Court will no longer vote on constitutional amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucian Galade: "“Second, the President's absolute veto will be taken away..."*)

### Węzeł `[188]`
Mówca: **Lucian Galade**
> "“The entire process will take a long time. But we must start working with a reform committee to evaluate all possibilities for a new Constitution as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: "“We will write a more democratic Constitution with the re..."*)
  - -> `[89]` (*Player: "“The new Constitution should give the President wide-rang..."*)
  - -> `[90]` (*Player: "“We could work with the Old Guard to protect our existing..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Intention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Lucian Galade: "“Let us at least work with a reform committee to start ta..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Intention = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Dictator_Intention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Lucian Galade: "“We will form a reform committee and start talking with a..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Intention = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Reformist_Intention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Lucian Galade: "“We will form a reform committee together with all partie..."*)

### Węzeł `[192]`
Mówca: **Lucian Galade**
> "“We will form a reform committee together with all parties and start reaching out to all the stakeholders in the Assembly and the Court for a new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Petr Vectern: ""By later in the year, we should have an idea of the refo..."*)

### Węzeł `[193]`
Mówca: **Lucian Galade**
> "“We will form a reform committee and start talking with all stakeholders in the Assembly and the Court to see if such changes to the Constitution would be possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Petr Vectern: ""By later in the year, we should know more about the refo..."*)

### Węzeł `[194]`
Mówca: **Lucian Galade**
> "“Let us at least work with a reform committee to start talking with all stakeholders in the Assembly and the Court just to query opinions. I'll try to reach out to the Old Guard, in the meantime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Petr Vectern: ""By later in the year, we should have an idea about the r..."*)

### Węzeł `[195]`
Mówca: **Petr Vectern**
> ""By later in the year, we should have an idea of the reform contents and what the other parties want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Lucian took notes."*)

### Węzeł `[196]`
Mówca: **Petr Vectern**
> ""By later in the year, we should know more about the reform contents and how to balance the clauses of the new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Lucian took notes."*)

### Węzeł `[197]`
Mówca: **Petr Vectern**
> ""By later in the year, we should have an idea about the reform contents and what the other parties want. Then we can decide whether to pull the trigger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Lucian took notes."*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "“Our party must fall in line with our position. We can't have a strong divide.""]** — Mówca: **Player**
> "“Our party must fall in line with our position. We can't have a strong divide.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Petr Vectern: ""True. If our party fractures, it's the opposition that w..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA: "“The USP reformists aren't wrong to agree that we need change, but we should be in charge.""]** — Mówca: **Player**
> "“The USP reformists aren't wrong to agree that we need change, but we should be in charge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Petr Vectern: ""We can't let the PFJP leadership take the spotlight on t..."*)

### Węzeł `[200]`
Mówca: **Petr Vectern**
> ""We can't let the PFJP leadership take the spotlight on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Petr Vectern: ""The reformists' demands are clear. They want to limit th..."*)

### Węzeł `[201]`
Mówca: **Petr Vectern**
> ""True. If our party fractures, it's the opposition that will benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Petr Vectern: ""The reformists' demands are clear. They want to limit th..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA: "“Mr. Ricter could be a potential ally in our goal to maintain a majority in the Assembly.""]** — Mówca: **Player**
> "“Mr. Ricter could be a potential ally in our goal to maintain a majority in the Assembly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Lucian Galade: "“He's definitely key in this.""*)

### Węzeł `[203]`
Mówca: **Lucian Galade**
> "“He's definitely key in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Petr Vectern: ""The reformists' demands are clear. They want to limit th..."*)

### Węzeł `[204]`
Mówca: **Narrator**
> "Petr looked troubled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Petr Vectern: ""It will be very difficult to plead that case to the refo..."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "Lucian raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucian Galade: ""If we go against the demands of the people, the reformis..."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "Lucian nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Intention = true"*)

### Węzeł `[207]`
Mówca: **Narrator**
> "Petr nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Petr Vectern: ""Yes. The divisions of power need to be rebalanced for a ..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "Petr shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Petr Vectern: ""Why would you want to work with the Old Guard?""*)

### Węzeł `[209]`
Mówca: **Narrator**
> "Lucian scratched his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention = true"*)

### Węzeł `[210]`
**[WYBÓR GRACZA: "“I won't be bought, it won't happen.”"]** — Mówca: **Player**
> "“I won't be bought, it won't happen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Lucian Galade: "“Alphonso said the same thing. I doubt there was anybody ..."*)

### Węzeł `[211]`
**[WYBÓR GRACZA: "“I will enter a dialogue with them eventually. We need to be diplomatic.”"]** — Mówca: **Player**
> "“I will enter a dialogue with them eventually. We need to be diplomatic.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Lucian Galade: "“Wise approach. It's good to understand and see if we can..."*)

### Węzeł `[212]`
Mówca: **Lucian Galade**
> "“However, to reform the constitution we must receive a two-thirds majority in the Grand National Assembly, which is 166 votes. *And* a simple majority in the Supreme Court that equates to 6 votes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Lucian Galade: "“After we have settled on how to proceed, we will need to..."*)

### Węzeł `[213]`
Mówca: **Lucian Galade**
> "“After we have settled on how to proceed, we will need to talk with our party figures. Our first goal must be to get the 150 signatures needed to start the process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Lucian Galade: "“Following the greenlight from the USP, we will reach out..."*)

### Węzeł `[214]`
Mówca: **Lucian Galade**
> "“Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Lucian Galade: "“To clarify before we head in any particular direction, w..."*)

### Węzeł `[215]`
Mówca: **Narrator**
> "Lucian looked at his watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Lucian Galade: "“Well then, gentlemen. Precisely 30 minutes.”"*)

### Węzeł `[216]`
Mówca: **Lucian Galade**
> "“Well then, gentlemen. Precisely 30 minutes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lucian Galade: "“This concludes our political briefing for today. Our nex..."*)

### Węzeł `[217]`
Mówca: **Lucian Galade**
> "“Talk to you soon, sir. I will keep in touch.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Petr Vectern: "“See you both at the next meeting.”"*)

### Węzeł `[218]`
Mówca: **Petr Vectern**
> "“See you both at the next meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Lucian and Petr bid their farewells and left. A mysteriou..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Backstab == true)"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Lucian Galade: "“True. But we can't let the Old Guard manipulate us and t..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Backstab == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: "“True. But we can't let the Old Guard manipulate us and t..."*)

### Węzeł `[222]`
Mówca: **Lucian Galade**
> "“True. But we can't let the Old Guard manipulate us and then backstab us, like we did with Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: "“Looks like we have many challenges ahead.”"*)
  - -> `[85]` (*Player: "“We cannot allow obstructionists to exist.”"*)
  - -> `[87]` (*Player: "“We can't underestimate this situation.""*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Lucian Arrives For Political Overview`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The door swung open and Lucian Galade, my chief strategis..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucian Arrives For Political Overview]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "Lucian Arrives For Political Overview"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucian Arrives For Political Overview]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "Lucian Arrives For Political Overview"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucian Arrives For Political Overview]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "Lucian Arrives For Political Overview"*)

### Węzeł `[227]`
Mówca: **Lucian Galade**
> "“Frens Ricter, leader of the reformists, believes that true change can only be accomplished by transferring some of our powers to the Assembly. I will move into the details of their demands shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "“I agree with the reformists. Our responsibility is to de..."*)
  - -> `[51]` (*Player: "“We need to listen to the people if we want to serve this..."*)
  - -> `[53]` (*Player: "“If we lose power, we won't be able to execute the change..."*)

### Węzeł `[228]`
Mówca: **Petr Vectern**
> "“We did it Anton, we won! Finally! All those years with our noses to the grindstone paid off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Petr's eyes sparkled. The strain of the past months had p..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_Rumburg");`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_Rumburg");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Petr Vectern: ""Enjoying the new secretary I picked out for you? Thought..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_LT_CampaignBill = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_LT_CampaignBill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_PublicBlame == true"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Holsord_PublicOpinion = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_PublicOpinion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_LT_CampaignBill = true"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Deyr_IncreasingHomeless = true;
BaseGameSupport.Report_Turn01_Holsord_PoliceFireReport = true;
BaseGameSupport.News_Turn01_HP_FireStrikesHSU = true;
BaseGameSupport.News_Turn01_HP_Committee = true;
BaseGameSupport.News_Turn01_LT_NationalLeagueSeason = true;
BaseGameSupport.News_Turn01_G_RiziaGas = true;
BaseGame.Policy_Law_ReformCommittee = true;
BaseGameSupport.News_Turn01_E_AlphonsoLeavesLotherberg = true;
BaseGameSupport.News_Turn01_R_RediscoveringIzzam = true;
BaseGameSupport.Report_Turn01_Holsord_GNATourismBill = true;
BaseGameSupport.Report_Turn01_Leiren_ProtectNatureMarch = true;
BaseGameSupport.Report_Turn01_Narbel_GasomDiscoveries = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Deyr_IncreasingHomeless"] = true;
Variable["BaseGameSupport.Report_Turn01_Holsord_PoliceFireReport"] = true;
Variable["BaseGameSupport.News_Turn01_HP_FireStrikesHSU"] = true;
Variable["BaseGameSupport.News_Turn01_HP_Committee"] = true;
Variable["BaseGameSupport.News_Turn01_LT_NationalLeagueSeason"] = true;
Variable["BaseGameSupport.News_Turn01_G_RiziaGas"] = true;
Variable["BaseGame.Policy_Law_ReformCommittee"] = true;
Variable["BaseGameSupport.News_Turn01_E_AlphonsoLeavesLotherberg"] = true;
Variable["BaseGameSupport.News_Turn01_R_RediscoveringIzzam"] = true;
Variable["BaseGameSupport.Report_Turn01_Holsord_GNATourismBill"] = true;
Variable["BaseGameSupport.Report_Turn01_Leiren_ProtectNatureMarch"] = true;
Variable["BaseGameSupport.Report_Turn01_Narbel_GasomDiscoveries"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn01_A_PoliticalOverview = true"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucian Galade: ""That's very bold. Then we must start with eliminating th..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_Reform_MoreExecutivePower = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_Reform_MoreExecutivePower"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Lucian Galade: ""Very well. We will begin to explore how to realistically..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_Reform_DestroyJudiciary = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_Reform_DestroyJudiciary"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Lucian Galade: ""Very well. We will begin to explore how to realistically..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_Reform_StrengthenYourPosition = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_Reform_StrengthenYourPosition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Lucian Galade: ""Very well. We will begin to explore how to realistically..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_Reform_WorkWithReformists = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_Reform_WorkWithReformists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: "“As you wish. We will move forward on that.""*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_Reform_WorkWithOldGuards = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_Reform_WorkWithOldGuards"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "Lucian scratched his head."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_Reform_WorkWithReformists = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_Reform_WorkWithReformists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lucian Galade: "“Yes, sir.""*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_Reform_WorkWithReformists = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_Reform_WorkWithReformists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Lucian Galade: "“As you wish. We will move forward on that.""*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_Reform_WorkWithOldGuards = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_Reform_WorkWithOldGuards"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "Lucian scratched his head."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_Reform_WorkWithOldGuards = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_Reform_WorkWithOldGuards"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Petr Vectern: ""Yes. Of course I'm with you.""*)

### Węzeł `[245]`
Mówca: **Lucian Galade**
> "“Following the greenlight from the USP, we will reach out to the other party leaders to see if they would back our draft. The last step is to convince the justices of the Court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Lucian Galade: "“The entire process will take a long time. But we must st..."*)

### Węzeł `[246]`
Mówca: **Narrator**
> "Petr's eyes sparkled. The strain of the past months had put a damper on his usual rakish charm, but today he was looking and acting more like his old self. He loosened his tie and undid the top two buttons of his shirt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_Rumburg");"*)

### Węzeł `[247]`
Mówca: **Petr Vectern**
> ""Enjoying the new secretary I picked out for you? Thought you'd appreciate her gorgeous set of... talents. It's a shame the rest of your staff aren't as easy on the eyes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "He gestured to the slight paunch that protruded over his ..."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "He gestured to the slight paunch that protruded over his waistband."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Petr Vectern: "“But, hey, back in university, did you ever imagine we wo..."*)

### Węzeł `[249]`
Mówca: **Narrator**
> "Lucian spoke in soft, clipped tones that immediately drew your attention towards what he had to say. Petr and I waited for him to proceed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: "“Let's start by evaluating our current situation.""*)

### Węzeł `[250]`
Mówca: **Petr Vectern**
> "“We did it Anton, we won! Finally! The bribery, the backstabbing -- it's all paid off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Petr's eyes sparkled. The strain of the past months had p..."*)

### Węzeł `[251]`
Mówca: **Petr Vectern**
> "“We did it Anton, we won! Finally! All those games we played with the media paid off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Petr's eyes sparkled. The strain of the past months had p..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Backstab == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Petr Vectern: "“We did it Anton, we won! Finally! The bribery, the backs..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Backstab == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Petr Vectern: "“We did it Anton, we won! Finally! All those years with o..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_PublicBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_PublicBlame == true"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_PublicBlame == true)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_PublicBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Petr Vectern: "“We did it Anton, we won! Finally! All those games we pla..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_PublicBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Military == true)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Lucian Galade: "“Our election campaign promised to focus on the military...."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Lucian Galade: "“The military and the general staff are a powerful elemen..."*)

### Węzeł `[261]`
Mówca: **Lucian Galade**
> "“Our election campaign promised to focus on the military. This was a safe choice. The military and the general staff are a powerful element in the state, and as history tells us, a dangerous one too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Player: "“The military can be close allies. And with the Rumburg t..."*)
  - -> `[265]` (*Player: "“The Sordish Armed Forces represent our pride as a nation..."*)
  - -> `[277]` (*Player: "“I don't want to die in prison just like Artor S. Wisci d..."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Intention == true"*)

### Węzeł `[262]`
Mówca: **Lucian Galade**
> "“The military and the general staff are a powerful element in the state, and as history tells us, a dangerous one too. We do have some room to make structural changes -- by reducing their budget, for example. But it is quite limited.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player: "“I want to receive the advice of the military before maki..."*)
  - -> `[277]` (*Player: "“I don't want to die in prison just like Artor S. Wisci d..."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Intention == true"*)
  - -> `[266]` (*Player: "“With the Rumburg threat on the horizon, we can't reduce ..."*)
  - -> `[267]` (*Player: "“The military has been nothing but a burden on our societ..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA: "“I want to work with them anyway. The new administration will be open to talk to businessmen.”"]** — Mówca: **Player**
> "“I want to work with them anyway. The new administration will be open to talk to businessmen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lucian Galade: "“It's always easier for the administration to have busine..."*)

### Węzeł `[264]`
**[WYBÓR GRACZA: "“The military can be close allies. And with the Rumburg threat on the horizon, we need them.”"]** — Mówca: **Player**
> "“The military can be close allies. And with the Rumburg threat on the horizon, we need them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Lucian Galade: "“Rumburg is a massive threat. One that also requires us t..."*)

### Węzeł `[265]`
**[WYBÓR GRACZA: "“The Sordish Armed Forces represent our pride as a nation and will be funded as promised.”"]** — Mówca: **Player**
> "“The Sordish Armed Forces represent our pride as a nation and will be funded as promised.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Lucian Galade: "“That will ensure they will be on our side unless we do s..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA: "“With the Rumburg threat on the horizon, we can't reduce our defense capability and anger our General Staff.”"]** — Mówca: **Player**
> "“With the Rumburg threat on the horizon, we can't reduce our defense capability and anger our General Staff.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Lucian Galade: "“I would advise the same. The budget should be maintained..."*)

### Węzeł `[267]`
**[WYBÓR GRACZA: "“The military has been nothing but a burden on our society. We should do something drastic -- like cutting their funding.”"]** — Mówca: **Player**
> "“The military has been nothing but a burden on our society. We should do something drastic -- like cutting their funding.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Lucian Galade: "“That is possible, but we can be sure that there will be ..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA: "“If they prove to be a political threat in the future, we can get rid of them.”"]** — Mówca: **Player**
> "“If they prove to be a political threat in the future, we can get rid of them.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Dictator_Intention"] == true`
- **Kontekst wejściowy (poprzednik):** `[261]` (Lucian Galade), `[262]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Lucian Galade: "“Bold strategy Mr. President. One that could work, but we..."*)

### Węzeł `[269]`
Mówca: **Lucian Galade**
> "“Rumburg is a massive threat. One that also requires us to ally with other, stronger nations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucian Galade: "“Defense Minister Iosef Lancea is more loyal to us compar..."*)

### Węzeł `[270]`
Mówca: **Lucian Galade**
> "“That will ensure they will be on our side unless we do something drastic in the course of our term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucian Galade: "“Defense Minister Iosef Lancea is more loyal to us compar..."*)

### Węzeł `[271]`
Mówca: **Lucian Galade**
> "“I would advise the same. The budget should be maintained and we should refrain from confronting the military too directly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucian Galade: "“Defense Minister Iosef Lancea is more loyal to us compar..."*)

### Węzeł `[272]`
Mówca: **Lucian Galade**
> "“That is possible, but we can be sure that there will be a strong negative reaction. If we push the military too far, it could cause real trouble.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucian Galade: "“Defense Minister Iosef Lancea is more loyal to us compar..."*)

### Węzeł `[273]`
Mówca: **Lucian Galade**
> "“Bold strategy Mr. President. One that could work, but we would need to amend the constitution first. Let's not get ahead of ourselves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucian Galade: "“Defense Minister Iosef Lancea is more loyal to us compar..."*)

### Węzeł `[274]`
Mówca: **Petr Vectern**
> "“If we act strongly against the military, both of those guys will unite against us. I agree with Lucian. We need to tread carefully here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "Lucian looked at his watch."*)

### Węzeł `[275]`
Mówca: **Lucian Galade**
> "“Defense Minister Iosef Lancea is more loyal to us compared to General Kruger. A fact that obviously can change with our actions. Either way, I see a potential rift between the two since they are clearly of different minds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Petr Vectern: "“If we act strongly against the military, both of those g..."*)

### Węzeł `[276]`
Mówca: **Lucian Galade**
> "“None of us want to live through the 1927 scenario again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucian Galade: "“Defense Minister Iosef Lancea is more loyal to us compar..."*)

### Węzeł `[277]`
**[WYBÓR GRACZA: "“I don't want to die in prison just like Artor S. Wisci did.”"]** — Mówca: **Player**
> "“I don't want to die in prison just like Artor S. Wisci did.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Lucian Galade), `[262]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Lucian Galade: "“None of us want to live through the 1927 scenario again.”"*)

### Węzeł `[278]`
Mówca: **Lucian Galade**
> "“It is sound to listen to them but they have very biased and narrow opinions. Nationalism clouds their minds. General Kruger is a specter of the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucian Galade: "“Defense Minister Iosef Lancea is more loyal to us compar..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA: "“I want to receive the advice of the military before making up my mind.”"]** — Mówca: **Player**
> "“I want to receive the advice of the military before making up my mind.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Lucian Galade: "“It is sound to listen to them but they have very biased ..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Intention == true"*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Intention == true)"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player: "“If they prove to be a political threat in the future, we..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Intention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[283]`
**[WYBÓR GRACZA: "“We won't let these privileged, greedy, and snobby capitalists run the country.”"]** — Mówca: **Player**
> "“We won't let these privileged, greedy, and snobby capitalists run the country.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Lucian Galade: "“Let's not underestimate their influence. These are not h..."*)

### Węzeł `[284]`
Mówca: **Lucian Galade**
> "“It's always easier for the administration to have businesses' support.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Lucian looked at Petr."*)

### Węzeł `[285]`
Mówca: **Lucian Galade**
> "“Alphonso said the same thing. I doubt there was anybody else to turn to in his case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Lucian looked at Petr."*)

### Węzeł `[286]`
Mówca: **Lucian Galade**
> "“Wise approach. It's good to understand and see if we can reach a middle ground.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Lucian looked at Petr."*)

### Węzeł `[287]`
Mówca: **Lucian Galade**
> "“Let's not underestimate their influence. These are not harmless people either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Lucian looked at Petr."*)

### Węzeł `[288]`
Mówca: **Petr Vectern**
> "“He'd be a useful ally as well. Tusk has an incredible network and owns a good amount of Bergia Steel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“We need to tread carefully on all sides with all power p..."*)

### Węzeł `[289]`
**[WYBÓR GRACZA: "“Tusk is heading the group. We should make sure he is on our side.”"]** — Mówca: **Player**
> "“Tusk is heading the group. We should make sure he is on our side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Petr Vectern: "“He'd be a useful ally as well. Tusk has an incredible ne..."*)

### Węzeł `[290]`
Mówca: **Narrator**
> "Petr looked troubled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucian Galade: "“That would be tough, sir. But I trust your judgement.""*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's exactly what I'm aiming to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Lucian Galade: "“Of course.""*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_WhiskeyBottle");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_WhiskeyBottle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)
