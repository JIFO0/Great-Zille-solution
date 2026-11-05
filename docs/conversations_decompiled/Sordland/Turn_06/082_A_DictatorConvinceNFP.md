# Sordland/Turn06/A_DictatorConvinceNFP

- **ID konwersacji:** `82`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/082_A_DictatorConvinceNFP.md`
- **Liczba węzłów dialogowych:** 461
- **Liczba wyborów gracza:** 91

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[50]** Kesaro Kibener

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Decision_Turn03_StabilityOrder_BanBoth`
- `BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth`
- `BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.PersonalWealth`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Threshold_8`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.Turn06_A_Kesaro_Alliance`
- `BaseGameIsolated.Turn06_A_Kesaro_Ban_RY`
- `BaseGameIsolated.Turn06_A_Kesaro_Bill`
- `BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS`
- `BaseGameIsolated.Turn06_A_Kesaro_Threshold_10`
- `BaseGameIsolated.Turn06_A_Kesaro_Threshold_8`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_Ban_YoungSords`
- `BaseGame.Reform_Alliance_NFP`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Threshold_8`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Reform_Reform_NFP_Convinced`
- `BaseGame.Relations_Kesaro_Promise_Alliance`
- `BaseGame.Relations_Kesaro_Promise_Bill`
- `BaseGameIsolated.Turn06_A_Kesaro_Alliance`
- `BaseGameIsolated.Turn06_A_Kesaro_Ban_RY`
- `BaseGameIsolated.Turn06_A_Kesaro_Bill`
- `BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS`
- `BaseGameIsolated.Turn06_A_Kesaro_Threshold_10`
- `BaseGameIsolated.Turn06_A_Kesaro_Threshold_8`
- `BaseGameSupport.Journal_Turn06_Kesaro_Alliance`
- `BaseGameSupport.Journal_Turn06_Kesaro_BanRY`
- `BaseGameSupport.Journal_Turn06_Kesaro_Bill`
- `BaseGameSupport.Journal_Turn06_Kesaro_RevertYS`
- `BaseGameSupport.Journal_Turn06_Kesaro_Threshold10`
- `BaseGameSupport.Journal_Turn06_Kesaro_Threshold8`
- `BaseGameSupport.News_Turn06_LT_NFPConvinced`
- `BaseGameSupport.News_Turn06_LT_NFPNotConvinced`
- `BaseGameSupport.News_Turn06_ST_RayneMeetsKibener`
- `BaseGameSupport.News_Turn06_ST_VictoryDay`
- `BaseGameSupport.Report_Turn06_Holsord_NFP_NotConvinced`
- `GameCondition.Turn06_A_Reform`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[11]` | **""I've been looking forward to speaking with you in private, Mr. Kibener.""** | `[16]` **Narrator**: "I was halfway through my second ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Kesaro Kibener**: ""Likewise, President Rayne. We h..." |
| `[12]` | **""Why the delay?""** | `[16]` **Narrator**: "I was halfway through my second ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Kesaro Kibener**: ""I was stopped by the police on ..." |
| `[14]` | **""Good morning, Mr. Kibener.""** | `[16]` **Narrator**: "I was halfway through my second ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Kesaro Kibener**: ""Good morning, Mr. President."" |
| `[24]` | **""You didn't even ask me if you could smoke in my office.""** | `[23]` **Narrator**: "He pulled out a cigarette along ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Kesaro Kibener**: ""Apologies. May I smoke in your ..." |
| `[25]` | **""Have you forgotten common courtesy, Mr. Kibener? Are we not offering cigarettes t..."** | `[23]` **Narrator**: "He pulled out a cigarette along ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Kesaro Kibener**: ""Apologies. Here."" |
| `[26]` | **""Let's get this over with.""** | `[23]` **Narrator**: "He pulled out a cigarette along ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Kesaro Kibener**: ""Very well."" |
| `[28]` | **""Go ahead.""** | `[27]` **Kesaro Kibener**: ""Apologies. May I smoke in your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Kesaro Kibener**: ""Thank you."" |
| `[29]` | **""No, you may not.""** | `[27]` **Kesaro Kibener**: ""Apologies. May I smoke in your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "Our eyes locked. After trying to..." |
| `[54]` | **""Thanks for the compliment.""** | `[49]` **Kesaro Kibener**: ""Now, Rumburg will have a harder..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Kesaro Kibener**: ""That brings me to the Religious..." |
| `[60]` | **""The support President Smolak received from United Contana was a concern, but real..."** | `[49]` **Kesaro Kibener**: ""Now, Rumburg will have a harder..." | `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == false` | *Brak zmian stanu* | `[67]` **Kesaro Kibener**: ""Their time will come too."" |
| `[61]` | **""Rumburg and the BFF will both meet a bad end if they dare to divide Sordland.""** | `[49]` **Kesaro Kibener**: ""Now, Rumburg will have a harder..."<br>`[59]` **Kesaro Kibener**: ""Rumburg is using them to weaken..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Kesaro Kibener**: ""That's right. They don't even k..." |
| `[62]` | **""We can't intervene in other countries. It would destabilize the region.""** | `[59]` **Kesaro Kibener**: ""Rumburg is using them to weaken..."<br>`[65]` **Kesaro Kibener**: ""Rumburg is using them to weaken..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Kesaro Kibener**: ""A Sordish president has to do w..." |
| `[64]` | **""Wehlen could be a valuable ally in the future, now that we have established a clo..."** | `[49]` **Kesaro Kibener**: ""Now, Rumburg will have a harder..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Kesaro Kibener**: ""I doubt it."" |
| `[66]` | **""Wehlen can take care of their own problems, and we will take care of ours.""** | `[59]` **Kesaro Kibener**: ""Rumburg is using them to weaken..."<br>`[65]` **Kesaro Kibener**: ""Rumburg is using them to weaken..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Kesaro Kibener**: ""They are a weaker nation both i..." |
| `[81]` | **""The bill was practically a recruitment flyer for the BFF. The more of these we pa..."** | `[78]` **Kesaro Kibener**: ""But you decided to veto it. Why..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Kesaro Kibener**: ""In this case, doing nothing is ..." |
| `[83]` | **""It was too restrictive on the Bludish people. I couldn't let it pass.""** | `[78]` **Kesaro Kibener**: ""But you decided to veto it. Why..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Kesaro Kibener**: ""If anything, we are not restric..." |
| `[85]` | **""We need to find a way where we can coexist without violence.""** | `[74]` **Kesaro Kibener**: ""Thanks to your support, the BFF..."<br>`[78]` **Kesaro Kibener**: ""But you decided to veto it. Why..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Kesaro Kibener**: ""In an ideal world, yes. But as ..." |
| `[86]` | **""The Bludish problem must be solved. We can't have an independence movement inside..."** | `[74]` **Kesaro Kibener**: ""Thanks to your support, the BFF..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Kesaro Kibener**: ""I'm glad you and I agree on thi..." |
| `[88]` | **""It was a well-written and strong bill. It would have been wrong to veto it.""** | `[74]` **Kesaro Kibener**: ""Thanks to your support, the BFF..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Kesaro Kibener**: ""Thank you. I led the effort. I ..." |
| `[105]` | **""To find a middle ground. Scratch my back and I will scratch yours.""** | `[104]` **Kesaro Kibener**: ""So I am asking you now. What di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Kesaro Kibener**: ""I've heard that enough in my li..." |
| `[106]` | **""I need you to help me, Kesaro. With your support, we can do a lot of good for Sor..."** | `[104]` **Kesaro Kibener**: ""So I am asking you now. What di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Kesaro Kibener**: ""From the looks of it, you want ..." |
| `[107]` | **""Just to have a chat.""** | `[104]` **Kesaro Kibener**: ""So I am asking you now. What di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Kesaro Kibener**: ""Then let's have a chat."" |
| `[109]` | **""What do you have in mind?""** | `[108]` **Kesaro Kibener**: ""If you want me to even consider..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Kesaro Kibener**: ""You will keep the election thre..." |
| `[110]` | **""I will not change anything in the draft. I have already decided on these points.""** | `[108]` **Kesaro Kibener**: ""If you want me to even consider..."<br>`[132]` **Kesaro Kibener**: ""If you want me to even *conside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Kesaro Kibener**: ""Then there is no point in conti..." |
| `[111]` | **""Fine. I will change the election threshold in return for your support.""** | `[108]` **Kesaro Kibener**: ""If you want me to even consider..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Kesaro Kibener**: ""You will keep the election thre..." |
| `[116]` | **""Very well. You will get what you want. The election threshold will remain the same.""** | `[117]` **Kesaro Kibener**: ""Anything other than that, and y..."<br>`[175]` **Kesaro Kibener**: ""Shame on you."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_10"]...` | `[121]` **Kesaro Kibener**: ""Very good. Now we are getting s..." |
| `[118]` | **""Then try your best to fight the bill, Kesaro. You won't get far.""** | `[117]` **Kesaro Kibener**: ""Anything other than that, and y..."<br>`[137]` **Kesaro Kibener**: ""Anything other than that, and y..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Kesaro Kibener**: ""If you only knew how many times..." |
| `[129]` | **""Just to have a chat.""** | `[126]` **Kesaro Kibener**: ""So I am asking you now. What di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Kesaro Kibener**: ""Then let's have a chat."" |
| `[130]` | **""To find a middle ground. Scratch my back and I will scratch yours.""** | `[126]` **Kesaro Kibener**: ""So I am asking you now. What di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Kesaro Kibener**: ""I've heard that enough in my li..." |
| `[131]` | **""I need you to help me, Kesaro. With your support, we can do a lot of good for Sor..."** | `[126]` **Kesaro Kibener**: ""So I am asking you now. What di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Kesaro Kibener**: ""From the looks of it, you want ..." |
| `[134]` | **""Fine. I will change the election threshold in return for your support.""** | `[132]` **Kesaro Kibener**: ""If you want me to even *conside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Kesaro Kibener**: ""You will keep the election thre..." |
| `[135]` | **""What do you have in mind?""** | `[132]` **Kesaro Kibener**: ""If you want me to even *conside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Kesaro Kibener**: ""You will keep the election thre..." |
| `[139]` | **""Very well. You will get what you want. The threshold will remain the same.""** | `[137]` **Kesaro Kibener**: ""Anything other than that, and y..."<br>`[165]` **Kesaro Kibener**: ""Shame on you."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_10"]...` | `[138]` **Kesaro Kibener**: ""Very good. Now we are getting s..." |
| `[140]` | **""I can go up to 8% and that is my final offer. Take it or get out of my office.""** | `[137]` **Kesaro Kibener**: ""Anything other than that, and y..."<br>`[165]` **Kesaro Kibener**: ""Shame on you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Narrator**: "He stroked his chin and paused b..." |
| `[147]` | **""To find a middle ground. Scratch my back and I will scratch yours.""** | `[146]` **Kesaro Kibener**: ""So I am asking you now. What di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Kesaro Kibener**: ""I've heard that enough in my li..." |
| `[148]` | **""Just to have a chat.""** | `[146]` **Kesaro Kibener**: ""So I am asking you now. What di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Kesaro Kibener**: ""Then let's have a chat."" |
| `[149]` | **""I need you to help me, Kesaro. With your support, we can do a lot of good for Sor..."** | `[146]` **Kesaro Kibener**: ""So I am asking you now. What di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Kesaro Kibener**: ""From the looks of it, you want ..." |
| `[162]` | **""Would a loaded check in your name change your mind, perhaps?" [Bribe]"** | `[137]` **Kesaro Kibener**: ""Anything other than that, and y..." | `Variable["BaseGame.PersonalWealth"] > 0` | *Brak zmian stanu* | `[163]` **Kesaro Kibener**: ""Who do you take me for? Frens R..." |
| `[169]` | **""Would a loaded check in your name change your mind, perhaps?" [Bribe]"** | `[117]` **Kesaro Kibener**: ""Anything other than that, and y..." | `Variable["BaseGame.PersonalWealth"] > 0` | *Brak zmian stanu* | `[173]` **Kesaro Kibener**: ""Who do you take me for? Frens R..." |
| `[206]` | **""Absolutely not. I made that decision for a reason. I can't risk violence on the s..."** | `[186]` **Kesaro Kibener**: ""But let me put it simply. If yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Kesaro Kibener**: ""Then there's no point in contin..." |
| `[207]` | **""If that is what it takes, then consider the Young Sords un-banned.""** | `[186]` **Kesaro Kibener**: ""But let me put it simply. If yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS"]...` | `[304]` **Kesaro Kibener**: ""That's what I like to hear. Now..." |
| `[208]` | **""Please, be reasonable. Is there anything else I can offer you? What else do you w..."** | `[186]` **Kesaro Kibener**: ""But let me put it simply. If yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Kesaro Kibener**: ""I told you, Mr. President. This..." |
| `[220]` | **""His beliefs have not changed.""** | `[223]` **Kesaro Kibener**: ""Where is the man who once stood..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Kesaro Kibener**: ""I think they have."" |
| `[221]` | **""He has gotten wiser.""** | `[223]` **Kesaro Kibener**: ""Where is the man who once stood..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[423]` **Kesaro Kibener**: ""Give me a break."" |
| `[222]` | **""I see the truth now.""** | `[223]` **Kesaro Kibener**: ""Where is the man who once stood..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[423]` **Kesaro Kibener**: ""Give me a break."" |
| `[225]` | **""Careful, Kesaro. Watch your words.""** | `[224]` **Kesaro Kibener**: ""So you decided to actively unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Kesaro Kibener**: ""Oh, give me a break."" |
| `[226]` | **""I am not the man I once was. I know better now.""** | `[224]` **Kesaro Kibener**: ""So you decided to actively unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Kesaro Kibener**: ""Oh, give me a break."" |
| `[227]` | **""We are not here to talk about our personal beliefs.""** | `[224]` **Kesaro Kibener**: ""So you decided to actively unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Kesaro Kibener**: ""Oh, give me a break."" |
| `[231]` | **""We are not here to talk about our personal beliefs.""** | `[238]` **Kesaro Kibener**: ""You would sell out your own mov..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[425]` **Kesaro Kibener**: ""Oh, give me a break."" |
| `[240]` | **""Careful, Kesaro. Watch your words.""** | `[238]` **Kesaro Kibener**: ""You would sell out your own mov..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[425]` **Kesaro Kibener**: ""Oh, give me a break."" |
| `[244]` | **""I see the truth now.""** | `[242]` **Kesaro Kibener**: ""Where is the man who believed i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Kesaro Kibener**: ""Give me a break."" |
| `[246]` | **""He has gotten wiser.""** | `[242]` **Kesaro Kibener**: ""Where is the man who believed i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Kesaro Kibener**: ""Give me a break."" |
| `[247]` | **""His beliefs have not changed.""** | `[242]` **Kesaro Kibener**: ""Where is the man who believed i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[426]` **Kesaro Kibener**: ""I think they have."" |
| `[248]` | **""I am not the man I once was. I know better now.""** | `[238]` **Kesaro Kibener**: ""You would sell out your own mov..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[425]` **Kesaro Kibener**: ""Oh, give me a break."" |
| `[250]` | **""I am not the man I once was. I know better now.""** | `[258]` **Kesaro Kibener**: ""I suppose when a man gets older..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[309]` **Kesaro Kibener**: ""Good. We all must continue lear..." |
| `[251]` | **""We are not here to talk about our personal beliefs.""** | `[258]` **Kesaro Kibener**: ""I suppose when a man gets older..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Kesaro Kibener**: ""I hope you don't mean that poli..." |
| `[260]` | **""Careful, Kesaro. Watch your words.""** | `[258]` **Kesaro Kibener**: ""I suppose when a man gets older..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[308]` **Kesaro Kibener**: ""I mean no offense, Mr. President."" |
| `[262]` | **""Anything for the movement.""** | `[261]` **Kesaro Kibener**: ""It is no surprise, really. This..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Kesaro Kibener**: ""Good to see that the fire still..." |
| `[263]` | **""Thank you, Kesaro.""** | `[261]` **Kesaro Kibener**: ""It is no surprise, really. This..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Kesaro Kibener**: ""You're welcome."" |
| `[264]` | **""I did it for the Sordish citizens. Nothing else.""** | `[261]` **Kesaro Kibener**: ""It is no surprise, really. This..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Kesaro Kibener**: ""That's exactly what the Young S..." |
| `[269]` | **""We are not here to talk about our personal beliefs.""** | `[276]` **Kesaro Kibener**: ""But it's no wonder a former Red..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Kesaro Kibener**: ""Oh, give me a break."" |
| `[277]` | **""Careful, Kesaro. Watch your words.""** | `[276]` **Kesaro Kibener**: ""But it's no wonder a former Red..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Kesaro Kibener**: ""Oh, give me a break."" |
| `[280]` | **""I see the truth now.""** | `[279]` **Kesaro Kibener**: ""Where is the man who once stood..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[430]` **Kesaro Kibener**: ""Give me a break."" |
| `[281]` | **""He has gotten wiser.""** | `[279]` **Kesaro Kibener**: ""Where is the man who once stood..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[430]` **Kesaro Kibener**: ""Give me a break."" |
| `[282]` | **""His beliefs have not changed.""** | `[279]` **Kesaro Kibener**: ""Where is the man who once stood..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[429]` **Kesaro Kibener**: ""I think they have."" |
| `[283]` | **""I am not the man I once was. I know better now.""** | `[276]` **Kesaro Kibener**: ""But it's no wonder a former Red..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Kesaro Kibener**: ""Oh, give me a break."" |
| `[291]` | **""All right. I will reverse the ban.""** | `[287]` **Kesaro Kibener**: ""I told you, Mr. President. This..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS"]...` | `[304]` **Kesaro Kibener**: ""That's what I like to hear. Now..." |
| `[292]` | **""I'm afraid I have to decline.""** | `[287]` **Kesaro Kibener**: ""I told you, Mr. President. This..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Kesaro Kibener**: ""Then there's no point in contin..." |
| `[297]` | **""I'm offering an alliance between the USP and NFP. You will not be affected by the..."** | `[104]` **Kesaro Kibener**: ""So I am asking you now. What di..."<br>`[108]` **Kesaro Kibener**: ""If you want me to even consider..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[298]` **Kesaro Kibener**: ""I see. An alliance, you say."" |
| `[321]` | **""I've heard enough. You can't make such demands of the President of Sordland!""** | `[320]` **Kesaro Kibener**: ""If you can't do either one, say..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Kesaro Kibener**: ""Then there is no use in continu..." |
| `[323]` | **""Message received. If that's what it takes, I will ban the Red Youth.""** | `[205]` **Kesaro Kibener**: ""So if you want my help, you nee..."<br>`[315]` **Kesaro Kibener**: ""I want you to ban the Red Youth..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] = true;` | `[342]` **Kesaro Kibener**: ""Excellent."" |
| `[324]` | **""Absolutely not. I left them alone for a reason. I can't risk violence on the stre..."** | `[205]` **Kesaro Kibener**: ""So if you want my help, you nee..."<br>`[315]` **Kesaro Kibener**: ""I want you to ban the Red Youth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Kesaro Kibener**: ""Maybe we can... come to an agre..." |
| `[325]` | **""I'm sorry, but I can't do that. Surely there must be something else I can offer y..."** | `[205]` **Kesaro Kibener**: ""So if you want my help, you nee..."<br>`[315]` **Kesaro Kibener**: ""I want you to ban the Red Youth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Kesaro Kibener**: ""Hmm. There is something I want."" |
| `[331]` | **""I will sign the bill and also ban the Red Youth. You will help me in return.""** | `[320]` **Kesaro Kibener**: ""If you can't do either one, say..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn06_A_Kesaro_Bill"] = true;...` | `[329]` **Kesaro Kibener**: ""See, that wasn't so hard, was it?"" |
| `[338]` | **""I will ban the Red Youth in return for your support.""** | `[320]` **Kesaro Kibener**: ""If you can't do either one, say..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] = true;` | `[329]` **Kesaro Kibener**: ""See, that wasn't so hard, was it?"" |
| `[346]` | **""If they live in Sordland, they need to know how to speak in Sordish.""** | `[350]` **Kesaro Kibener**: ""This bill, I call it the Unifie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[330]` **Kesaro Kibener**: ""It makes sense, doesn't it?"" |
| `[347]` | **""You will get your signature. I will sign the bill when I receive it.""** | `[320]` **Kesaro Kibener**: ""If you can't do either one, say..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn06_A_Kesaro_Bill"] = true;` | `[329]` **Kesaro Kibener**: ""See, that wasn't so hard, was it?"" |
| `[349]` | **""So your answer is to ban them completely from speaking Bludish at school?""** | `[350]` **Kesaro Kibener**: ""This bill, I call it the Unifie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[345]` **Kesaro Kibener**: ""They can speak to each other in..." |
| `[351]` | **""I will decide when I see the bill. Not before.""** | `[350]` **Kesaro Kibener**: ""This bill, I call it the Unifie..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Kesaro Kibener**: ""Will you do the right thing for..."<br>`[340]` **Kesaro Kibener**: ""I want to be clear."" |
| `[358]` | **""You will get your signature. I will sign the bill when I receive it.""** | `[357]` **Kesaro Kibener**: ""Will you do the right thing for..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn06_A_Kesaro_Bill"] = true;` | `[329]` **Kesaro Kibener**: ""See, that wasn't so hard, was it?"" |
| `[359]` | **""I don't think so. I won't go along with your scheme.""** | `[357]` **Kesaro Kibener**: ""Will you do the right thing for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Kesaro Kibener**: ""There are no schemes here."" |
| `[375]` | **""Apologies, but I have to refuse. It would close more doors than it would open.""** | `[374]` **Kesaro Kibener**: ""It would open many doors for bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Kesaro Kibener**: ""I understand. Just keep it in m..." |
| `[376]` | **""I'm glad you asked. How better to cement our newfound partnership than with an al..."** | `[374]` **Kesaro Kibener**: ""It would open many doors for bo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn06_A_Kesaro_Alliance"] = t...` | `[378]` **Kesaro Kibener**: ""What a historic day!"" |
| `[382]` | **""We will do great things together.""** | `[381]` **Kesaro Kibener**: ""Well then, Mr. President. My re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Kesaro Kibener**: ""I am looking forward to it."" |
| `[384]` | **""Thank you for coming, Kesaro.""** | `[381]` **Kesaro Kibener**: ""Well then, Mr. President. My re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[387]` **Kesaro Kibener**: ""Thank you for having me."" |
| `[385]` | **""Make sure you deliver your end of the promise.""** | `[381]` **Kesaro Kibener**: ""Well then, Mr. President. My re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[386]` **Kesaro Kibener**: ""I have never broken my word in ..." |
| `[438]` | **""It was a necessary evil. Don't expect me to sit by while my people suffer.""** | `[437]` **Kesaro Kibener**: ""You sold our national pride for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[444]` **Kesaro Kibener**: ""You are naive."" |
| `[439]` | **""I don't see anything wrong with accepting a helping hand.""** | `[437]` **Kesaro Kibener**: ""You sold our national pride for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[444]` **Kesaro Kibener**: ""You are naive."" |
| `[440]` | **""Is your national pride so fragile that this will destroy it? I don't think so.""** | `[437]` **Kesaro Kibener**: ""You sold our national pride for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[443]` **Kesaro Kibener**: ""I fought for my country many ti..." |
| `[441]` | **""Kesaro. I am the President. I won't allow you to talk to me like this.""** | `[437]` **Kesaro Kibener**: ""You sold our national pride for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[442]` **Kesaro Kibener**: ""Of course. My apologies. I'll g..." |
| `[455]` | **""Is that an original Rippo?""** | `[23]` **Narrator**: "He pulled out a cigarette along ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[456]` **Kesaro Kibener**: ""You bet, Mr. President. It's on..." |

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
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_ST_VictoryDay = true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn06_A_Reform = true;
BaseGameSupport.News_Turn06_ST_RayneMeetsKibener = true;`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn06_A_Reform"] = true;
Variable["BaseGameSupport.News_Turn06_ST_RayneMeetsKibener"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The final preparations for Sordland's new Constitution were nearly complete. Soon, it would be presented in the Grand National Assembly; after that, it would be up to the Supreme Court to approve the changes. Including the ones that diminished the Justices' own power."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true && BaseGame.Re..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true ..."*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_President == tru..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The final preparations for Sordland's new Constitution we..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "The final preparations for Sordland's new Constitution we..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true && BaseGame.Reform_Gloria_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true && BaseGame.Re..."*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true && BaseGame...."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true && BaseGame.Reform_Gloria_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "We had strong support in the party and the Assembly, but ..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true && BaseGame.Reform_Gloria_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "I knew I was on shaky ground with the Assembly. I despera..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: ""I've been looking forward to speaking with you in private, Mr. Kibener.""]** — Mówca: **Player**
> ""I've been looking forward to speaking with you in private, Mr. Kibener.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Kesaro Kibener: ""Likewise, President Rayne. We have much to discuss.""*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""Why the delay?""]** — Mówca: **Player**
> ""Why the delay?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Kesaro Kibener: ""I was stopped by the police on my way here. I seem to be..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "We had strong support in the party and the Assembly, but I wanted a landslide victory in order to force a yes out of the Court. So I had invited Kesaro Kibener, leader of the National Front Party, to have a private chat about my proposal. He was supposed to be in my office 20 minutes ago."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "I was halfway through my second coffee of the day when Ki..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Good morning, Mr. Kibener.""]** — Mówca: **Player**
> ""Good morning, Mr. Kibener.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Kesaro Kibener: ""Good morning, Mr. President.""*)

### Węzeł `[15]`
Mówca: **Narrator**
> "The final preparations for Sordland's new Constitution were nearly complete. Soon, it would be presented in the Grand National Assembly; a huge step for our administration. Then it would be on to the Supreme Court."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true && BaseGame.Re..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "I was halfway through my second coffee of the day when Kibener finally entered. He was wearing a brown suit with his party's pin neatly attached. After firmly shaking hands, he sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""Good morning, Mr. Kibener.""*)
  - -> `[11]` (*Player: ""I've been looking forward to speaking with you in privat..."*)
  - -> `[12]` (*Player: ""Why the delay?""*)

### Węzeł `[17]`
Mówca: **Narrator**
> "I knew I was on shaky ground with the Assembly. I desperately needed more votes. So I had invited Kesaro Kibener, leader of the National Front Party, to have a private chat about my proposal. He was supposed to be in my office 20 minutes ago."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "I was halfway through my second coffee of the day when Ki..."*)

### Węzeł `[18]`
Mówca: **Kesaro Kibener**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Kesaro Kibener: ""I hope you don't mind the slight delay. I was stopped by..."*)

### Węzeł `[19]`
Mówca: **Kesaro Kibener**
> ""Likewise, President Rayne. We have much to discuss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Kesaro Kibener: ""I hope you don't mind the slight delay. I was stopped by..."*)

### Węzeł `[20]`
Mówca: **Kesaro Kibener**
> ""I was stopped by the police on my way here. I seem to be subject to more and more such 'random' checks these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He grinned."*)

### Węzeł `[21]`
Mówca: **Kesaro Kibener**
> ""I hope you don't mind the slight delay. I was stopped by the police on my way here. I seem to be subject to more and more such 'random' checks these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "He grinned."*)

### Węzeł `[22]`
Mówca: **Kesaro Kibener**
> ""Some key figures in my party are also reporting obstructions from the state. It seems that your reforms aren't sitting well with certain members of the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "He pulled out a cigarette along with a Rippo lighter and ..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "He pulled out a cigarette along with a Rippo lighter and lit it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Player: ""Is that an original Rippo?""*)
  - -> `[24]` (*Player: ""You didn't even ask me if you could smoke in my office.""*)
  - -> `[25]` (*Player: ""Have you forgotten common courtesy, Mr. Kibener? Are we ..."*)
  - -> `[26]` (*Player: ""Let's get this over with.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""You didn't even ask me if you could smoke in my office.""]** — Mówca: **Player**
> ""You didn't even ask me if you could smoke in my office.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Kesaro Kibener: ""Apologies. May I smoke in your office, Mr. President?""*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Have you forgotten common courtesy, Mr. Kibener? Are we not offering cigarettes to friends anymore?""]** — Mówca: **Player**
> ""Have you forgotten common courtesy, Mr. Kibener? Are we not offering cigarettes to friends anymore?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Kesaro Kibener: ""Apologies. Here.""*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Let's get this over with.""]** — Mówca: **Player**
> ""Let's get this over with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Kesaro Kibener: ""Very well.""*)

### Węzeł `[27]`
Mówca: **Kesaro Kibener**
> ""Apologies. May I smoke in your office, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: ""Go ahead.""*)
  - -> `[29]` (*Player: ""No, you may not.""*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""Go ahead.""]** — Mówca: **Player**
> ""Go ahead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Kesaro Kibener: ""Thank you.""*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""No, you may not.""]** — Mówca: **Player**
> ""No, you may not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Our eyes locked. After trying to stare me down for a few ..."*)

### Węzeł `[30]`
Mówca: **Kesaro Kibener**
> ""Apologies. Here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "He passed a cigarette to me and lit it up."*)

### Węzeł `[31]`
Mówca: **Kesaro Kibener**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "I took a look at his lighter as he put it down on the tab..."*)

### Węzeł `[32]`
Mówca: **Kesaro Kibener**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "I took a look at his lighter as he put it down on the tab..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Our eyes locked. After trying to stare me down for a few moments, Kesaro finally gave in and extinguished his cigarette."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "I took a look at his lighter as he put it down on the tab..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "He passed a cigarette to me and lit it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "I took a look at his lighter as he put it down on the tab..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "I took a look at his lighter as he put it down on the table. It was a regular Rippo, but the shape appeared to be malformed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Looking more closely, I could see a large circular dent i..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "Looking more closely, I could see a large circular dent in the chrome plating."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Kesaro Kibener: ""It's a bullet mark.""*)

### Węzeł `[37]`
Mówca: **Kesaro Kibener**
> ""It's a bullet mark.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Kesaro Kibener: ""Believe it or not, this lighter is the reason I'm alive ..."*)

### Węzeł `[38]`
Mówca: **Kesaro Kibener**
> ""Believe it or not, this lighter is the reason I'm alive today. I should be thankful that the damn assassin was Bludish. No wonder he was incompetent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Kesaro Kibener: ""The lighter took the first shot. The second one grazed m..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "He pulled on his collar to reveal the scar on his neck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Kesaro Kibener: ""Maybe I'll tell you the full story some other time. For ..."*)

### Węzeł `[40]`
Mówca: **Kesaro Kibener**
> ""Maybe I'll tell you the full story some other time. For now, let's talk about our collaboration. I know why you called me here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Kesaro Kibener: ""But before we get into the proposal, I'd like to discuss..."*)

### Węzeł `[41]`
Mówca: **Kesaro Kibener**
> ""But before we get into the proposal, I'd like to discuss a few topics that I believe to be of higher priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Kesaro Kibener: ""The Bludish independence movement, for example. Not only..."*)

### Węzeł `[42]`
Mówca: **Kesaro Kibener**
> ""The lighter took the first shot. The second one grazed me right here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "He pulled on his collar to reveal the scar on his neck."*)

### Węzeł `[43]`
Mówca: **Kesaro Kibener**
> ""I may not be fond of President Smolak, but our joint operation with the Wehzeks was certainly successful in stamping out the BFF. I consider that a great success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Kesaro Kibener: ""Now, Rumburg will have a harder time trying to influence..."*)

### Węzeł `[44]`
Mówca: **Kesaro Kibener**
> ""The Bludish independence movement, for example. Not only do the separatists pose an existential risk to us, they also threaten our neighbors in Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Kesaro Kibener: ""I may not be fond of President Smolak, but our joint ope..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)

### Węzeł `[48]`
Mówca: **Kesaro Kibener**
> ""That brings me to the Religious Harmony Bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Kesaro Kibener: ""Our party and many members of parliament worked extremel..."*)

### Węzeł `[49]`
Mówca: **Kesaro Kibener**
> ""Now, Rumburg will have a harder time trying to influence us from within. Let's not forget their caches of KA-74s in our country. You've done the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: ""Thanks for the compliment.""*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false"*)
  - -> `[64]` (*Player: ""Wehlen could be a valuable ally in the future, now that ..."*)
  - -> `[61]` (*Player: ""Rumburg and the BFF will both meet a bad end if they dar..."*)

### Węzeł `[50]`
Mówca: **Kesaro Kibener**
> ""That's right. They don't even know whom they are dealing with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Kesaro Kibener: ""That brings me to the Religious Harmony Bill.""*)

### Węzeł `[51]`
Mówca: **Kesaro Kibener**
> ""Closing the borders with Wehlen has helped, but the countryside of Nargis and Bergia continues to be plagued by the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)

### Węzeł `[52]`
Mówca: **Kesaro Kibener**
> ""Wehlen continues to be plagued by the BFF. They use their secret bases in the mountains to launch infiltrations into Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)

### Węzeł `[53]`
Mówca: **Kesaro Kibener**
> ""I doubt it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Kesaro Kibener: ""That brings me to the Religious Harmony Bill.""*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Thanks for the compliment.""]** — Mówca: **Player**
> ""Thanks for the compliment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Kesaro Kibener: ""That brings me to the Religious Harmony Bill.""*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_DefendBorder == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Kesaro Kibener: ""Closing the borders with Wehlen has helped, but the coun..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Kesaro Kibener: ""Wehlen continues to be plagued by the BFF. They use thei..."*)

### Węzeł `[58]`
Mówca: **Kesaro Kibener**
> ""They are a weaker nation both in heart and might. They won't have the capacity to handle the Bludish threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Kesaro Kibener: ""That brings me to the Religious Harmony Bill.""*)

### Węzeł `[59]`
Mówca: **Kesaro Kibener**
> ""Rumburg is using them to weaken us, and they might succeed if we do nothing to stop them. Let's not forget their caches of KA-74s in our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: ""Rumburg and the BFF will both meet a bad end if they dar..."*)
  - -> `[62]` (*Player: ""We can't intervene in other countries. It would destabil..."*)
  - -> `[66]` (*Player: ""Wehlen can take care of their own problems, and we will ..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""The support President Smolak received from United Contana was a concern, but realpolitik was the victor.""]** — Mówca: **Player**
> ""The support President Smolak received from United Contana was a concern, but realpolitik was the victor.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == false`
- **Kontekst wejściowy (poprzednik):** `[49]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Kesaro Kibener: ""Their time will come too.""*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Rumburg and the BFF will both meet a bad end if they dare to divide Sordland.""]** — Mówca: **Player**
> ""Rumburg and the BFF will both meet a bad end if they dare to divide Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Kesaro Kibener), `[59]` (Kesaro Kibener), `[65]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Kesaro Kibener: ""That's right. They don't even know whom they are dealing..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""We can't intervene in other countries. It would destabilize the region.""]** — Mówca: **Player**
> ""We can't intervene in other countries. It would destabilize the region.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Kesaro Kibener), `[65]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Kesaro Kibener: ""A Sordish president has to do whatever is necessary to p..."*)

### Węzeł `[63]`
Mówca: **Kesaro Kibener**
> ""A Sordish president has to do whatever is necessary to protect his people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Kesaro Kibener: ""That brings me to the Religious Harmony Bill.""*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Wehlen could be a valuable ally in the future, now that we have established a closer relationship.""]** — Mówca: **Player**
> ""Wehlen could be a valuable ally in the future, now that we have established a closer relationship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Kesaro Kibener: ""I doubt it.""*)

### Węzeł `[65]`
Mówca: **Kesaro Kibener**
> ""Rumburg is using them to weaken us. Hopefully, our increased military funding will make sure their efforts won't bear fruit. But we need to stay vigilant. Let's not forget their caches of KA-74s in our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: ""Rumburg and the BFF will both meet a bad end if they dar..."*)
  - -> `[62]` (*Player: ""We can't intervene in other countries. It would destabil..."*)
  - -> `[66]` (*Player: ""Wehlen can take care of their own problems, and we will ..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""Wehlen can take care of their own problems, and we will take care of ours.""]** — Mówca: **Player**
> ""Wehlen can take care of their own problems, and we will take care of ours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Kesaro Kibener), `[65]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Kesaro Kibener: ""They are a weaker nation both in heart and might. They w..."*)

### Węzeł `[67]`
Mówca: **Kesaro Kibener**
> ""Their time will come too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Kesaro Kibener: ""That brings me to the Religious Harmony Bill.""*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == f..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: ""The support President Smolak received from United Contan..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Kesaro Kibener: ""Rumburg is using them to weaken us. Hopefully, our incre..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Kesaro Kibener: ""Rumburg is using them to weaken us, and they might succe..."*)

### Węzeł `[74]`
Mówca: **Kesaro Kibener**
> ""Thanks to your support, the BFF and other extremist groups won't be able to use religion to organise and gain support among the common folk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: ""The Bludish problem must be solved. We can't have an ind..."*)
  - -> `[88]` (*Player: ""It was a well-written and strong bill. It would have bee..."*)
  - -> `[85]` (*Player: ""We need to find a way where we can coexist without viole..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Kesaro Kibener: ""Thanks to your support, the BFF and other extremist grou..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Kesaro Kibener: ""But you decided to veto it. Why are you ignoring the pro..."*)

### Węzeł `[78]`
Mówca: **Kesaro Kibener**
> ""But you decided to veto it. Why are you ignoring the problem? The Bludish are using Nurity as a tool in their quest for independence. This is a direct threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: ""We need to find a way where we can coexist without viole..."*)
  - -> `[83]` (*Player: ""It was too restrictive on the Bludish people. I couldn't..."*)
  - -> `[81]` (*Player: ""The bill was practically a recruitment flyer for the BFF..."*)

### Węzeł `[79]`
Mówca: **Kesaro Kibener**
> ""If anything, we are not restrictive enough. But I will not dive into this further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[80]`
Mówca: **Kesaro Kibener**
> ""In this case, doing nothing is far worse. The BFF is actively using priests in majority-Bludish areas. But let's not get off track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""The bill was practically a recruitment flyer for the BFF. The more of these we pass, the more followers they get.""]** — Mówca: **Player**
> ""The bill was practically a recruitment flyer for the BFF. The more of these we pass, the more followers they get.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Kesaro Kibener: ""In this case, doing nothing is far worse. The BFF is act..."*)

### Węzeł `[82]`
Mówca: **Kesaro Kibener**
> ""Thank you. I led the effort. I was happy but not surprised to receive so much support from my fellow MPs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[83]`
**[WYBÓR GRACZA: ""It was too restrictive on the Bludish people. I couldn't let it pass.""]** — Mówca: **Player**
> ""It was too restrictive on the Bludish people. I couldn't let it pass.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Kesaro Kibener: ""If anything, we are not restrictive enough. But I will n..."*)

### Węzeł `[84]`
Mówca: **Kesaro Kibener**
> ""In an ideal world, yes. But as long as the BFF exists, that is not the world we live in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""We need to find a way where we can coexist without violence.""]** — Mówca: **Player**
> ""We need to find a way where we can coexist without violence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Kesaro Kibener), `[78]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Kesaro Kibener: ""In an ideal world, yes. But as long as the BFF exists, t..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""The Bludish problem must be solved. We can't have an independence movement inside Sordland.""]** — Mówca: **Player**
> ""The Bludish problem must be solved. We can't have an independence movement inside Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Kesaro Kibener: ""I'm glad you and I agree on this issue.""*)

### Węzeł `[87]`
Mówca: **Kesaro Kibener**
> ""I'm glad you and I agree on this issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""It was a well-written and strong bill. It would have been wrong to veto it.""]** — Mówca: **Player**
> ""It was a well-written and strong bill. It would have been wrong to veto it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Kesaro Kibener: ""Thank you. I led the effort. I was happy but not surpris..."*)

### Węzeł `[89]`
Mówca: **Kesaro Kibener**
> ""Our party and many members of parliament worked extremely hard on the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[90]`
Mówca: **Kesaro Kibener**
> ""Look. I went over your proposed constitutional changes...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "Kesaro opened his suitcase, took out a folder and put the..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "Kesaro opened his suitcase, took out a folder and put the draft constitution papers on the table. I could see the scribbles he'd made in the margins."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_15 == true"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_15 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_15 == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_15 == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_15 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Kesaro Kibener: ""An election threshold increase to 15%? Exactly whom do y..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_15 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Kesaro Kibener: ""An election threshold decrease to 3%? Exactly whom do yo..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8 == true"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_8 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8 == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_8 == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_8 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Kesaro Kibener: ""An election threshold decrease to 8%? Exactly whom do yo..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_8 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Kesaro Kibener: ""I don't see many problems with the draft, honestly.""*)

### Węzeł `[101]`
Mówca: **Kesaro Kibener**
> ""An election threshold increase to 15%? Exactly whom do you think you're dealing with here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Kesaro Kibener: ""You do realize the NFP's current share of the vote is un..."*)

### Węzeł `[102]`
Mówca: **Kesaro Kibener**
> ""You do realize the NFP's current share of the vote is under this threshold, don't you? You're attempting to get my party to participate in its own destruction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Kesaro Kibener: ""You know that I will fight this until my last breath if ..."*)

### Węzeł `[103]`
Mówca: **Kesaro Kibener**
> ""You know that I will fight this until my last breath if I have to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Kesaro Kibener: ""So I am asking you now. What did you even call me here f..."*)

### Węzeł `[104]`
Mówca: **Kesaro Kibener**
> ""So I am asking you now. What did you even call me here for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""To find a middle ground. Scratch my back and I will scra..."*)
  - -> `[106]` (*Player: ""I need you to help me, Kesaro. With your support, we can..."*)
  - -> `[107]` (*Player: ""Just to have a chat.""*)
  - -> `[297]` (*Player: ""I'm offering an alliance between the USP and NFP. You wi..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""To find a middle ground. Scratch my back and I will scratch yours.""]** — Mówca: **Player**
> ""To find a middle ground. Scratch my back and I will scratch yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Kesaro Kibener: ""I've heard that enough in my life to know that it doesn'..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""I need you to help me, Kesaro. With your support, we can do a lot of good for Sordland.""]** — Mówca: **Player**
> ""I need you to help me, Kesaro. With your support, we can do a lot of good for Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Kesaro Kibener: ""From the looks of it, you want to do a lot more good for..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Just to have a chat.""]** — Mówca: **Player**
> ""Just to have a chat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Kesaro Kibener: ""Then let's have a chat.""*)

### Węzeł `[108]`
Mówca: **Kesaro Kibener**
> ""If you want me to even consider supporting you, you will change the draft and you will change it now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""I will not change anything in the draft. I have already ..."*)
  - -> `[109]` (*Player: ""What do you have in mind?""*)
  - -> `[111]` (*Player: ""Fine. I will change the election threshold in return for..."*)
  - -> `[297]` (*Player: ""I'm offering an alliance between the USP and NFP. You wi..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""What do you have in mind?""]** — Mówca: **Player**
> ""What do you have in mind?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Kesaro Kibener: ""You will keep the election threshold where it has always..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""I will not change anything in the draft. I have already decided on these points.""]** — Mówca: **Player**
> ""I will not change anything in the draft. I have already decided on these points.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Kesaro Kibener), `[132]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Kesaro Kibener: ""Then there is no point in continuing this conversation, ..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA: ""Fine. I will change the election threshold in return for your support.""]** — Mówca: **Player**
> ""Fine. I will change the election threshold in return for your support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Kesaro Kibener: ""You will keep the election threshold where it has always..."*)

### Węzeł `[112]`
Mówca: **Kesaro Kibener**
> ""You will keep the election threshold where it has always been, at 10%.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Kesaro Kibener: ""Anything other than that, and you can kiss our support g..."*)

### Węzeł `[113]`
Mówca: **Kesaro Kibener**
> ""Then there is no point in continuing this conversation, is there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "Kesaro stood up and looked down at me."*)

### Węzeł `[114]`
Mówca: **Kesaro Kibener**
> ""Before I go, I guarantee you this. That proposal will not pass the Assembly. I will make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "Jump to: [KesaroLeaves]"*)

### Węzeł `[115]`
Mówca: **Kesaro Kibener**
> ""Good luck, Mr. President. You're bound to need it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Narrator: "He closed the door and left my office."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""Very well. You will get what you want. The election threshold will remain the same.""]** — Mówca: **Player**
> ""Very well. You will get what you want. The election threshold will remain the same.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Kesaro Kibener), `[175]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 = true"*)

### Węzeł `[117]`
Mówca: **Kesaro Kibener**
> ""Anything other than that, and you can kiss our support goodbye. In fact, the NFP will fight very hard to prevent this bill from passing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[118]` (*Player: ""Then try your best to fight the bill, Kesaro. You won't ..."*)
  - -> `[116]` (*Player: ""Very well. You will get what you want. The election thre..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Then try your best to fight the bill, Kesaro. You won't get far.""]** — Mówca: **Player**
> ""Then try your best to fight the bill, Kesaro. You won't get far.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Kesaro Kibener), `[137]` (Kesaro Kibener), `[165]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Kesaro Kibener: ""If you only knew how many times I've heard that. Yet loo..."*)

### Węzeł `[119]`
Mówca: **Kesaro Kibener**
> ""If you only knew how many times I've heard that. Yet look where I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "Kesaro stood up and looked down at me."*)

### Węzeł `[120]`
Mówca: **Kesaro Kibener**
> ""We are done here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Kesaro Kibener: ""Good luck, Mr. President. You're bound to need it.""*)

### Węzeł `[121]`
Mówca: **Kesaro Kibener**
> ""Very good. Now we are getting somewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Kesaro Kibener: ""I am not that worried about the rest of the contents in ..."*)

### Węzeł `[122]`
Mówca: **Kesaro Kibener**
> ""An election threshold decrease to 3%? Exactly whom do you think you're dealing with here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Kesaro Kibener: ""Don't you understand what will happen when you decrease ..."*)

### Węzeł `[123]`
Mówca: **Kesaro Kibener**
> ""Don't you understand what will happen when you decrease the threshold? Our Assembly will be overrun with Bludish and communist traitors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Kesaro Kibener: ""What is next? A Bludish quota in the Assembly? A Bludish..."*)

### Węzeł `[124]`
Mówca: **Kesaro Kibener**
> ""What is next? A Bludish quota in the Assembly? A Bludish revolution? Handing our country over to *them*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Kesaro Kibener: ""You know that I will fight this until my last breath if ..."*)

### Węzeł `[125]`
Mówca: **Kesaro Kibener**
> ""You know that I will fight this until my last breath if I have to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Kesaro Kibener: ""So I am asking you now. What did you even call me here f..."*)

### Węzeł `[126]`
Mówca: **Kesaro Kibener**
> ""So I am asking you now. What did you even call me here for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: ""To find a middle ground. Scratch my back and I will scra..."*)
  - -> `[131]` (*Player: ""I need you to help me, Kesaro. With your support, we can..."*)
  - -> `[129]` (*Player: ""Just to have a chat.""*)

### Węzeł `[127]`
Mówca: **Narrator**
> "Kesaro stood up and looked down at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Kesaro Kibener: ""Before I go, I guarantee you this. That proposal will no..."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "Kesaro stood up and looked down at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "Jump to: [KesaroLeaves]"*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Just to have a chat.""]** — Mówca: **Player**
> ""Just to have a chat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Kesaro Kibener: ""Then let's have a chat.""*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""To find a middle ground. Scratch my back and I will scratch yours.""]** — Mówca: **Player**
> ""To find a middle ground. Scratch my back and I will scratch yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Kesaro Kibener: ""I've heard that enough in my life to know that it doesn'..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""I need you to help me, Kesaro. With your support, we can do a lot of good for Sordland.""]** — Mówca: **Player**
> ""I need you to help me, Kesaro. With your support, we can do a lot of good for Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Kesaro Kibener: ""From the looks of it, you want to do a lot more good for..."*)

### Węzeł `[132]`
Mówca: **Kesaro Kibener**
> ""If you want me to even *consider* supporting you, you will change the draft and you will change it now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""I will not change anything in the draft. I have already ..."*)
  - -> `[135]` (*Player: ""What do you have in mind?""*)
  - -> `[134]` (*Player: ""Fine. I will change the election threshold in return for..."*)

### Węzeł `[133]`
Mówca: **Kesaro Kibener**
> ""From the looks of it, you want to do a lot more good for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Kesaro Kibener: ""If you want me to even *consider* supporting you, you wi..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA: ""Fine. I will change the election threshold in return for your support.""]** — Mówca: **Player**
> ""Fine. I will change the election threshold in return for your support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Kesaro Kibener: ""You will keep the election threshold where it has always..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA: ""What do you have in mind?""]** — Mówca: **Player**
> ""What do you have in mind?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Kesaro Kibener: ""You will keep the election threshold where it has always..."*)

### Węzeł `[136]`
Mówca: **Kesaro Kibener**
> ""You will keep the election threshold where it has always been, at 10%.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Kesaro Kibener: ""Anything other than that, and you can kiss our support g..."*)

### Węzeł `[137]`
Mówca: **Kesaro Kibener**
> ""Anything other than that, and you can kiss our support goodbye. In fact, the NFP will fight very hard to prevent this bill from passing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: ""Then try your best to fight the bill, Kesaro. You won't ..."*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[139]` (*Player: ""Very well. You will get what you want. The threshold wil..."*)
  - -> `[140]` (*Player: ""I can go up to 8% and that is my final offer. Take it or..."*)

### Węzeł `[138]`
Mówca: **Kesaro Kibener**
> ""Very good. Now we are getting somewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Kesaro Kibener: ""I am not that worried about the rest of the contents in ..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA: ""Very well. You will get what you want. The threshold will remain the same.""]** — Mówca: **Player**
> ""Very well. You will get what you want. The threshold will remain the same.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Kesaro Kibener), `[165]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 = true"*)

### Węzeł `[140]`
**[WYBÓR GRACZA: ""I can go up to 8% and that is my final offer. Take it or get out of my office.""]** — Mówca: **Player**
> ""I can go up to 8% and that is my final offer. Take it or get out of my office.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Kesaro Kibener), `[165]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "He stroked his chin and paused before answering."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "He stroked his chin and paused before answering."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Kesaro Kibener: ""I am fine with it as long as I get something else out of..."*)

### Węzeł `[142]`
Mówca: **Kesaro Kibener**
> ""I am fine with it as long as I get something else out of the deal. And that depends on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Threshold_8 = true"*)

### Węzeł `[143]`
Mówca: **Kesaro Kibener**
> ""An election threshold decrease to 8%? Exactly whom do you think you're dealing with here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Kesaro Kibener: ""Don't you understand what will happen when you decrease ..."*)

### Węzeł `[144]`
Mówca: **Kesaro Kibener**
> ""Don't you understand what will happen when you decrease the threshold? Our Assembly will be overrun with Bludish and communist traitors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Kesaro Kibener: ""What is next? A Bludish quota in the Assembly? A Bludish..."*)

### Węzeł `[145]`
Mówca: **Kesaro Kibener**
> ""What is next? A Bludish quota in the Assembly? A Bludish revolution? Handing our country over to *them*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Kesaro Kibener: ""So I am asking you now. What did you even call me here f..."*)

### Węzeł `[146]`
Mówca: **Kesaro Kibener**
> ""So I am asking you now. What did you even call me here for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player: ""To find a middle ground. Scratch my back and I will scra..."*)
  - -> `[149]` (*Player: ""I need you to help me, Kesaro. With your support, we can..."*)
  - -> `[148]` (*Player: ""Just to have a chat.""*)

### Węzeł `[147]`
**[WYBÓR GRACZA: ""To find a middle ground. Scratch my back and I will scratch yours.""]** — Mówca: **Player**
> ""To find a middle ground. Scratch my back and I will scratch yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Kesaro Kibener: ""I've heard that enough in my life to know that it doesn'..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Just to have a chat.""]** — Mówca: **Player**
> ""Just to have a chat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Kesaro Kibener: ""Then let's have a chat.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I need you to help me, Kesaro. With your support, we can do a lot of good for Sordland.""]** — Mówca: **Player**
> ""I need you to help me, Kesaro. With your support, we can do a lot of good for Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Kesaro Kibener: ""From the looks of it, you want to do a lot more good for..."*)

### Węzeł `[150]`
Mówca: **Kesaro Kibener**
> ""I've heard that enough in my life to know that it doesn't work that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Kesaro Kibener: ""If you want me to even *consider* supporting you, you wi..."*)

### Węzeł `[151]`
Mówca: **Kesaro Kibener**
> ""Then let's have a chat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Kesaro Kibener: ""If you want me to even *consider* supporting you, you wi..."*)

### Węzeł `[152]`
Mówca: **Kesaro Kibener**
> ""I've heard that enough in my life to know that it doesn't work that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Kesaro Kibener: ""But fine. It's only 2%.""*)

### Węzeł `[153]`
Mówca: **Kesaro Kibener**
> ""From the looks of it, you want to do a lot more good for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Kesaro Kibener: ""But fine. It's only 2%.""*)

### Węzeł `[154]`
Mówca: **Kesaro Kibener**
> ""Then let's have a chat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Kesaro Kibener: ""In the end, it's only a 2% difference.""*)

### Węzeł `[155]`
Mówca: **Kesaro Kibener**
> ""I've heard that enough in my life to know that it doesn't work that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Kesaro Kibener: ""If you want me to even consider supporting you, you will..."*)

### Węzeł `[156]`
Mówca: **Kesaro Kibener**
> ""From the looks of it, you want to do a lot more good for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Kesaro Kibener: ""If you want me to even consider supporting you, you will..."*)

### Węzeł `[157]`
Mówca: **Kesaro Kibener**
> ""Then let's have a chat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Kesaro Kibener: ""If you want me to even consider supporting you, you will..."*)

### Węzeł `[158]`
Mówca: **Kesaro Kibener**
> ""But fine. It's only 2%.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Kesaro Kibener: ""I am fine with it as long as I get something else out of..."*)

### Węzeł `[159]`
Mówca: **Kesaro Kibener**
> ""I am fine with it as long as I get something else out of the deal. And that depends on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Threshold_8 = true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_10"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Kesaro Kibener: ""Very good. Now we are getting somewhere.""*)

### Węzeł `[161]`
Mówca: **Kesaro Kibener**
> ""I am not that worried about the rest of the contents in the constitutional changes in principle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Kesaro Kibener: ""But I assure you, the rest of the Assembly will be worri..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA: ""Would a loaded check in your name change your mind, perhaps?" [Bribe]"]** — Mówca: **Player**
> ""Would a loaded check in your name change your mind, perhaps?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Kontekst wejściowy (poprzednik):** `[137]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Kesaro Kibener: ""Who do you take me for? Frens Ricter?""*)

### Węzeł `[163]`
Mówca: **Kesaro Kibener**
> ""Who do you take me for? Frens Ricter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Kesaro Kibener: ""You are offending me if you think I can be bought with s..."*)

### Węzeł `[164]`
Mówca: **Kesaro Kibener**
> ""You are offending me if you think I can be bought with such a simple thing as money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Kesaro Kibener: ""Shame on you.""*)

### Węzeł `[165]`
Mówca: **Kesaro Kibener**
> ""Shame on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: ""Then try your best to fight the bill, Kesaro. You won't ..."*)
  - -> `[139]` (*Player: ""Very well. You will get what you want. The threshold wil..."*)
  - -> `[140]` (*Player: ""I can go up to 8% and that is my final offer. Take it or..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 0)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player: ""Would a loaded check in your name change your mind, perh..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[169]`
**[WYBÓR GRACZA: ""Would a loaded check in your name change your mind, perhaps?" [Bribe]"]** — Mówca: **Player**
> ""Would a loaded check in your name change your mind, perhaps?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Kontekst wejściowy (poprzednik):** `[117]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Kesaro Kibener: ""Who do you take me for? Frens Ricter?""*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 0)"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""Would a loaded check in your name change your mind, perh..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[173]`
Mówca: **Kesaro Kibener**
> ""Who do you take me for? Frens Ricter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Kesaro Kibener: ""You are offending me if you think I can be bought with s..."*)

### Węzeł `[174]`
Mówca: **Kesaro Kibener**
> ""You are offending me if you think I can be bought with such a simple thing as money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Kesaro Kibener: ""Shame on you.""*)

### Węzeł `[175]`
Mówca: **Kesaro Kibener**
> ""Shame on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: ""Then try your best to fight the bill, Kesaro. You won't ..."*)
  - -> `[116]` (*Player: ""Very well. You will get what you want. The election thre..."*)

### Węzeł `[176]`
Mówca: **Kesaro Kibener**
> ""I don't see many problems with the draft, honestly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Kesaro Kibener: ""But I assure you, the rest of the Assembly will be worri..."*)

### Węzeł `[177]`
Mówca: **Kesaro Kibener**
> ""As I mentioned, there are more pressing situations in Sordland right now. The BFF isn't even the half of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == ..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == ..."*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords =..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Kesaro Kibener: ""Your outrageous decision to ban the Young Sords, for exa..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Threshold_8 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_8"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Kesaro Kibener: ""I am not that worried about the rest of the contents in ..."*)

### Węzeł `[182]`
Mówca: **Kesaro Kibener**
> ""Your outrageous decision to ban the Young Sords, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Kesaro Kibener: ""You have unfairly attacked a perfectly legal entity. One..."*)

### Węzeł `[183]`
Mówca: **Kesaro Kibener**
> ""You have unfairly attacked a perfectly legal entity. One of the oldest organisations in this country, in fact, founded solely to defend pure Sordish values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Kesaro Kibener: ""How many patriots have been prosecuted while the communi..."*)

### Węzeł `[184]`
Mówca: **Kesaro Kibener**
> ""How many patriots have been prosecuted while the communists and United Contanan moles get free rein?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Kesaro Kibener: ""The nationalists did not start this violence. It was the..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_10"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Kesaro Kibener: ""Very good. Now we are getting somewhere.""*)

### Węzeł `[186]`
Mówca: **Kesaro Kibener**
> ""But let me put it simply. If you want my help, you will reverse the ban on the Young Sords immediately. Otherwise, we are done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Player: ""If that is what it takes, then consider the Young Sords ..."*)
  - -> `[206]` (*Player: ""Absolutely not. I made that decision for a reason. I can..."*)
  - -> `[208]` (*Player: ""Please, be reasonable. Is there anything else I can offe..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_StabilityOrder_BanBoth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Kesaro Kibener: ""Your outrageous decision to ban the Young Sords, for exa..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_StabilityOrder_BanBoth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true"*)

### Węzeł `[190]`
Mówca: **Kesaro Kibener**
> ""Your outrageous decision to ban the Young Sords, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Kesaro Kibener: ""You have unfairly attacked a perfectly legal entity. One..."*)

### Węzeł `[191]`
Mówca: **Kesaro Kibener**
> ""You have unfairly attacked a perfectly legal entity. One of the oldest organisations in this country, in fact, founded solely to defend pure Sordish values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Kesaro Kibener: ""I don't know who put it in your mind that this would res..."*)

### Węzeł `[192]`
Mówca: **Kesaro Kibener**
> ""I don't know who put it in your mind that this would resolve the political violence. You ought to pick your advisors more carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Kesaro Kibener: ""The nationalists did not start this violence. It was the..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == ..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Kesaro Kibener: ""There's the matter of the communists. Those damn rats ar..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Kesaro Kibener: ""In the face of the political violence engulfing this cou..."*)

### Węzeł `[196]`
Mówca: **Kesaro Kibener**
> ""The nationalists did not start this violence. It was the reds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)

### Węzeł `[197]`
Mówca: **Kesaro Kibener**
> ""I don't know who put it in your mind that this would resolve the political violence. You ought to pick your advisors more carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Kesaro Kibener: ""We will continue this conversation later.""*)

### Węzeł `[198]`
Mówca: **Kesaro Kibener**
> ""The nationalists did not start this violence. It was the reds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)

### Węzeł `[199]`
Mówca: **Kesaro Kibener**
> ""There's the matter of the communists. Those damn rats are everywhere I look, trying to sneak into Sordish society from the crevices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Kesaro Kibener: ""You get rid of one, ten more appear!""*)

### Węzeł `[200]`
Mówca: **Kesaro Kibener**
> ""You get rid of one, ten more appear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Kesaro Kibener: ""But I must give you credit. You have done well to curb t..."*)

### Węzeł `[201]`
Mówca: **Kesaro Kibener**
> ""In the face of the political violence engulfing this country, your refusal to take action speaks multitudes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)

### Węzeł `[202]`
Mówca: **Kesaro Kibener**
> ""The damn communist rats are everywhere I look, trying to sneak into Sordish society from the crevices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Kesaro Kibener: ""You get rid of one, ten more appear!""*)

### Węzeł `[203]`
Mówca: **Kesaro Kibener**
> ""But I will say this. The Red Youth have done enough damage to Sordland. They must be stopped before they can do more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Kesaro Kibener: ""The damn communist rats are everywhere I look, trying to..."*)

### Węzeł `[204]`
Mówca: **Kesaro Kibener**
> ""You get rid of one, ten more appear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Kesaro Kibener: ""So if you want my help, you need to act. I want you to b..."*)

### Węzeł `[205]`
Mówca: **Kesaro Kibener**
> ""So if you want my help, you need to act. I want you to ban the Red Youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Player: ""Message received. If that's what it takes, I will ban th..."*)
  - -> `[324]` (*Player: ""Absolutely not. I left them alone for a reason. I can't ..."*)
  - -> `[325]` (*Player: ""I'm sorry, but I can't do that. Surely there must be som..."*)

### Węzeł `[206]`
**[WYBÓR GRACZA: ""Absolutely not. I made that decision for a reason. I can't risk violence on the streets again.""]** — Mówca: **Player**
> ""Absolutely not. I made that decision for a reason. I can't risk violence on the streets again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Kesaro Kibener: ""Then there's no point in continuing this conversation, i..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA: ""If that is what it takes, then consider the Young Sords un-banned.""]** — Mówca: **Player**
> ""If that is what it takes, then consider the Young Sords un-banned.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS = true"*)

### Węzeł `[208]`
**[WYBÓR GRACZA: ""Please, be reasonable. Is there anything else I can offer you? What else do you want?""]** — Mówca: **Player**
> ""Please, be reasonable. Is there anything else I can offer you? What else do you want?"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Kesaro Kibener: ""I told you, Mr. President. This is the least you can off..."*)

### Węzeł `[209]`
Mówca: **Kesaro Kibener**
> ""But I assure you, the rest of the Assembly will be worried. Very worried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Kesaro Kibener: ""If you don't have my backing, there is no way you can ev..."*)

### Węzeł `[210]`
Mówca: **Kesaro Kibener**
> ""If you don't have my backing, there is no way you can ever hope to pass this bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Kesaro Kibener: ""That's why I want you to listen to me very carefully.""*)

### Węzeł `[211]`
Mówca: **Kesaro Kibener**
> ""That's why I want you to listen to me very carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Kesaro Kibener: ""As I mentioned, there are more pressing situations in So..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Kesaro Kibener: ""What I am most surprised about is how an ex-Young Sords ..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Kesaro Kibener: ""But it's no wonder a decision like this came from an ex-..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Kesaro Kibener: ""I don't know who put it in your mind that this would res..."*)

### Węzeł `[218]`
Mówca: **Kesaro Kibener**
> ""But it's no wonder a decision like this came from an ex-Red Youth member. You must still have your sympathies for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Kesaro Kibener: ""So you decided to actively undermine your own nation in ..."*)

### Węzeł `[219]`
Mówca: **Kesaro Kibener**
> ""What I am most surprised about is how an ex-Young Sords member can make a decision like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Kesaro Kibener: ""Where is the man who once stood with us?""*)

### Węzeł `[220]`
**[WYBÓR GRACZA: ""His beliefs have not changed.""]** — Mówca: **Player**
> ""His beliefs have not changed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Kesaro Kibener: ""I think they have.""*)

### Węzeł `[221]`
**[WYBÓR GRACZA: ""He has gotten wiser.""]** — Mówca: **Player**
> ""He has gotten wiser.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Kesaro Kibener: ""Give me a break.""*)

### Węzeł `[222]`
**[WYBÓR GRACZA: ""I see the truth now.""]** — Mówca: **Player**
> ""I see the truth now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Kesaro Kibener: ""Give me a break.""*)

### Węzeł `[223]`
Mówca: **Kesaro Kibener**
> ""Where is the man who once stood with us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player: ""He has gotten wiser.""*)
  - -> `[222]` (*Player: ""I see the truth now.""*)
  - -> `[220]` (*Player: ""His beliefs have not changed.""*)

### Węzeł `[224]`
Mówca: **Kesaro Kibener**
> ""So you decided to actively undermine your own nation in favor of Malenyevism and other dangerous foreign exports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player: ""Careful, Kesaro. Watch your words.""*)
  - -> `[226]` (*Player: ""I am not the man I once was. I know better now.""*)
  - -> `[227]` (*Player: ""We are not here to talk about our personal beliefs.""*)

### Węzeł `[225]`
**[WYBÓR GRACZA: ""Careful, Kesaro. Watch your words.""]** — Mówca: **Player**
> ""Careful, Kesaro. Watch your words.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Kesaro Kibener: ""Oh, give me a break.""*)

### Węzeł `[226]`
**[WYBÓR GRACZA: ""I am not the man I once was. I know better now.""]** — Mówca: **Player**
> ""I am not the man I once was. I know better now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Kesaro Kibener: ""Oh, give me a break.""*)

### Węzeł `[227]`
**[WYBÓR GRACZA: ""We are not here to talk about our personal beliefs.""]** — Mówca: **Player**
> ""We are not here to talk about our personal beliefs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Kesaro Kibener: ""Oh, give me a break.""*)

### Węzeł `[228]`
Mówca: **Narrator**
> "Kesaro clenched his fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Kesaro Kibener: ""We will continue this conversation later.""*)

### Węzeł `[229]`
Mówca: **Kesaro Kibener**
> ""We will continue this conversation later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Kesaro Kibener: ""But let me put it simply. If you want my help, you will ..."*)

### Węzeł `[230]`
Mówca: **Kesaro Kibener**
> ""We will continue this conversation later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Kesaro Kibener: ""But let me put it simply. If you want my help, you will ..."*)

### Węzeł `[231]`
**[WYBÓR GRACZA: ""We are not here to talk about our personal beliefs.""]** — Mówca: **Player**
> ""We are not here to talk about our personal beliefs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Kesaro Kibener: ""Oh, give me a break.""*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Kesaro Kibener: ""What I am most surprised about is how an ex-Young Sords ..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
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
  - -> `[239]` (*Kesaro Kibener: ""But it's no wonder a decision like this came from an ex-..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Kesaro Kibener: ""We will continue this conversation later.""*)

### Węzeł `[238]`
Mówca: **Kesaro Kibener**
> ""You would sell out your own movement for your own good, wouldn't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player: ""Careful, Kesaro. Watch your words.""*)
  - -> `[248]` (*Player: ""I am not the man I once was. I know better now.""*)
  - -> `[231]` (*Player: ""We are not here to talk about our personal beliefs.""*)

### Węzeł `[239]`
Mówca: **Kesaro Kibener**
> ""But it's no wonder a decision like this came from an ex-Red Youth member. You are all the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Kesaro Kibener: ""You would sell out your own movement for your own good, ..."*)

### Węzeł `[240]`
**[WYBÓR GRACZA: ""Careful, Kesaro. Watch your words.""]** — Mówca: **Player**
> ""Careful, Kesaro. Watch your words.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Kesaro Kibener: ""Oh, give me a break.""*)

### Węzeł `[241]`
Mówca: **Kesaro Kibener**
> ""What I am most surprised about is how an ex-Young Sords member can make a decision like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Kesaro Kibener: ""Where is the man who believed in our ideals back then? W..."*)

### Węzeł `[242]`
Mówca: **Kesaro Kibener**
> ""Where is the man who believed in our ideals back then? Where is the man who would fight for his brothers and sisters?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player: ""He has gotten wiser.""*)
  - -> `[244]` (*Player: ""I see the truth now.""*)
  - -> `[247]` (*Player: ""His beliefs have not changed.""*)

### Węzeł `[243]`
Mówca: **Kesaro Kibener**
> ""We will continue this conversation later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Kesaro Kibener: ""But let me put it simply. If you want my help, you will ..."*)

### Węzeł `[244]`
**[WYBÓR GRACZA: ""I see the truth now.""]** — Mówca: **Player**
> ""I see the truth now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Kesaro Kibener: ""Give me a break.""*)

### Węzeł `[245]`
Mówca: **Narrator**
> "Kesaro clenched his fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Kesaro Kibener: ""We will continue this conversation later.""*)

### Węzeł `[246]`
**[WYBÓR GRACZA: ""He has gotten wiser.""]** — Mówca: **Player**
> ""He has gotten wiser.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Kesaro Kibener: ""Give me a break.""*)

### Węzeł `[247]`
**[WYBÓR GRACZA: ""His beliefs have not changed.""]** — Mówca: **Player**
> ""His beliefs have not changed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Kesaro Kibener: ""I think they have.""*)

### Węzeł `[248]`
**[WYBÓR GRACZA: ""I am not the man I once was. I know better now.""]** — Mówca: **Player**
> ""I am not the man I once was. I know better now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Kesaro Kibener: ""Oh, give me a break.""*)

### Węzeł `[249]`
Mówca: **Kesaro Kibener**
> ""We will continue this conversation later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Kesaro Kibener: ""But let me put it simply. If you want my help, you will ..."*)

### Węzeł `[250]`
**[WYBÓR GRACZA: ""I am not the man I once was. I know better now.""]** — Mówca: **Player**
> ""I am not the man I once was. I know better now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Kesaro Kibener: ""Good. We all must continue learning.""*)

### Węzeł `[251]`
**[WYBÓR GRACZA: ""We are not here to talk about our personal beliefs.""]** — Mówca: **Player**
> ""We are not here to talk about our personal beliefs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Kesaro Kibener: ""I hope you don't mean that politics is separate from per..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Kesaro Kibener: ""It is no surprise, really. This sort of proactive move i..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == true)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Kesaro Kibener: ""The decision was quite a pleasant surprise for me, reall..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Kesaro Kibener: ""I don't know who put it in your mind that this would res..."*)

### Węzeł `[258]`
Mówca: **Kesaro Kibener**
> ""I suppose when a man gets older, he renounces the foolishness of his youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player: ""Careful, Kesaro. Watch your words.""*)
  - -> `[250]` (*Player: ""I am not the man I once was. I know better now.""*)
  - -> `[251]` (*Player: ""We are not here to talk about our personal beliefs.""*)

### Węzeł `[259]`
Mówca: **Kesaro Kibener**
> ""The decision was quite a pleasant surprise for me, really. Knowing you used to support the reds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Kesaro Kibener: ""I suppose when a man gets older, he renounces the foolis..."*)

### Węzeł `[260]`
**[WYBÓR GRACZA: ""Careful, Kesaro. Watch your words.""]** — Mówca: **Player**
> ""Careful, Kesaro. Watch your words.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Kesaro Kibener: ""I mean no offense, Mr. President.""*)

### Węzeł `[261]`
Mówca: **Kesaro Kibener**
> ""It is no surprise, really. This sort of proactive move is exactly what I'd expect from a fellow former Young Sord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Player: ""Thank you, Kesaro.""*)
  - -> `[262]` (*Player: ""Anything for the movement.""*)
  - -> `[264]` (*Player: ""I did it for the Sordish citizens. Nothing else.""*)

### Węzeł `[262]`
**[WYBÓR GRACZA: ""Anything for the movement.""]** — Mówca: **Player**
> ""Anything for the movement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Kesaro Kibener: ""Good to see that the fire still burns inside you.""*)

### Węzeł `[263]`
**[WYBÓR GRACZA: ""Thank you, Kesaro.""]** — Mówca: **Player**
> ""Thank you, Kesaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Kesaro Kibener: ""You're welcome.""*)

### Węzeł `[264]`
**[WYBÓR GRACZA: ""I did it for the Sordish citizens. Nothing else.""]** — Mówca: **Player**
> ""I did it for the Sordish citizens. Nothing else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Kesaro Kibener: ""That's exactly what the Young Sords was founded for.""*)

### Węzeł `[265]`
Mówca: **Kesaro Kibener**
> ""But we will continue this conversation later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Kesaro Kibener: ""Here is what I had in mind.""*)

### Węzeł `[266]`
Mówca: **Kesaro Kibener**
> ""I don't know who put it in your mind that this would resolve the political violence, but you sure ought to pick your advisors more carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Kesaro Kibener: ""But we will continue this conversation later.""*)

### Węzeł `[267]`
Mówca: **Kesaro Kibener**
> ""But I must give you credit. You have done well to curb the violence by banning the Red Youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)

### Węzeł `[268]`
Mówca: **Kesaro Kibener**
> ""We will continue this conversation later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Kesaro Kibener: ""But I will say this. The Red Youth have done enough dama..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA: ""We are not here to talk about our personal beliefs.""]** — Mówca: **Player**
> ""We are not here to talk about our personal beliefs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Kesaro Kibener: ""Oh, give me a break.""*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Kesaro Kibener: ""What I am most surprised about is how an ex-Young Sords ..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == true)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Kesaro Kibener: ""But it's no wonder a former Red Youth member would falte..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Kesaro Kibener: ""I don't know who put it in your mind that doing nothing ..."*)

### Węzeł `[276]`
Mówca: **Kesaro Kibener**
> ""But it's no wonder a former Red Youth member would falter like this. You are all the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player: ""Careful, Kesaro. Watch your words.""*)
  - -> `[283]` (*Player: ""I am not the man I once was. I know better now.""*)
  - -> `[269]` (*Player: ""We are not here to talk about our personal beliefs.""*)

### Węzeł `[277]`
**[WYBÓR GRACZA: ""Careful, Kesaro. Watch your words.""]** — Mówca: **Player**
> ""Careful, Kesaro. Watch your words.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Kesaro Kibener: ""Oh, give me a break.""*)

### Węzeł `[278]`
Mówca: **Kesaro Kibener**
> ""What I am most surprised about is how an ex-Young Sords member can simply sit by like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Kesaro Kibener: ""Where is the man who once stood with us?""*)

### Węzeł `[279]`
Mówca: **Kesaro Kibener**
> ""Where is the man who once stood with us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player: ""He has gotten wiser.""*)
  - -> `[280]` (*Player: ""I see the truth now.""*)
  - -> `[282]` (*Player: ""His beliefs have not changed.""*)

### Węzeł `[280]`
**[WYBÓR GRACZA: ""I see the truth now.""]** — Mówca: **Player**
> ""I see the truth now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Kesaro Kibener: ""Give me a break.""*)

### Węzeł `[281]`
**[WYBÓR GRACZA: ""He has gotten wiser.""]** — Mówca: **Player**
> ""He has gotten wiser.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Kesaro Kibener: ""Give me a break.""*)

### Węzeł `[282]`
**[WYBÓR GRACZA: ""His beliefs have not changed.""]** — Mówca: **Player**
> ""His beliefs have not changed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Kesaro Kibener: ""I think they have.""*)

### Węzeł `[283]`
**[WYBÓR GRACZA: ""I am not the man I once was. I know better now.""]** — Mówca: **Player**
> ""I am not the man I once was. I know better now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Kesaro Kibener: ""Oh, give me a break.""*)

### Węzeł `[284]`
Mówca: **Narrator**
> "Kesaro clenched his fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Kesaro Kibener: ""We will continue this conversation later.""*)

### Węzeł `[285]`
Mówca: **Kesaro Kibener**
> ""I don't know who put it in your mind that doing nothing would resolve the violence, but you sure ought to pick your advisors more carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Kesaro Kibener: ""We will continue this conversation later.""*)

### Węzeł `[286]`
Mówca: **Kesaro Kibener**
> ""We will continue this conversation later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Kesaro Kibener: ""But I will say this. The Red Youth have done enough dama..."*)

### Węzeł `[287]`
Mówca: **Kesaro Kibener**
> ""I told you, Mr. President. This is the least you can offer. If you can't do it, forget about my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player: ""All right. I will reverse the ban.""*)
  - -> `[292]` (*Player: ""I'm afraid I have to decline.""*)

### Węzeł `[288]`
Mówca: **Kesaro Kibener**
> ""Then there's no point in continuing this conversation, is there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Narrator: "Kesaro stood up and looked down at me."*)

### Węzeł `[289]`
Mówca: **Narrator**
> "Kesaro stood up and looked down at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Kesaro Kibener: ""Before I go, I guarantee you this. That bill will not pa..."*)

### Węzeł `[290]`
Mówca: **Kesaro Kibener**
> ""Before I go, I guarantee you this. That bill will not pass the Assembly. I will make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "Jump to: [KesaroLeaves]"*)

### Węzeł `[291]`
**[WYBÓR GRACZA: ""All right. I will reverse the ban.""]** — Mówca: **Player**
> ""All right. I will reverse the ban.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS = true"*)

### Węzeł `[292]`
**[WYBÓR GRACZA: ""I'm afraid I have to decline.""]** — Mówca: **Player**
> ""I'm afraid I have to decline.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[287]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Kesaro Kibener: ""Then there's no point in continuing this conversation, i..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Kesaro Kibener: ""That's what I like to hear. Now...""*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `KesaroLeaves`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Kesaro Kibener: ""We are done here.""*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [KesaroLeaves]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "KesaroLeaves"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [KesaroLeaves]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "KesaroLeaves"*)

### Węzeł `[297]`
**[WYBÓR GRACZA: ""I'm offering an alliance between the USP and NFP. You will not be affected by the threshold.""]** — Mówca: **Player**
> ""I'm offering an alliance between the USP and NFP. You will not be affected by the threshold.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Kesaro Kibener), `[108]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Kesaro Kibener: ""I see. An alliance, you say.""*)

### Węzeł `[298]`
Mówca: **Kesaro Kibener**
> ""I see. An alliance, you say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Kesaro Kibener: ""You do know how to make a deal exciting, Mr. President. ..."*)

### Węzeł `[299]`
Mówca: **Kesaro Kibener**
> ""You do know how to make a deal exciting, Mr. President. The new threshold would definitely keep the commies and the Bluds out of the Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Narrator: "He stroke his chin for a moment."*)

### Węzeł `[300]`
Mówca: **Narrator**
> "He stroke his chin for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Alliance = true"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Alliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Kesaro Kibener: ""I can get behind it. But I will have to work hard to con..."*)

### Węzeł `[302]`
Mówca: **Kesaro Kibener**
> ""I can get behind it. But I will have to work hard to convince the NFP. I assume you will do the same with your party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Kesaro Kibener: ""Let's just say that it is on the table.""*)

### Węzeł `[303]`
Mówca: **Kesaro Kibener**
> ""Let's just say that it is on the table.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Kesaro Kibener: ""I am not that worried about the rest of the contents in ..."*)

### Węzeł `[304]`
Mówca: **Kesaro Kibener**
> ""That's what I like to hear. Now...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == ..."*)

### Węzeł `[305]`
Mówca: **Kesaro Kibener**
> ""You're welcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Kesaro Kibener: ""Here is what I had in mind.""*)

### Węzeł `[306]`
Mówca: **Kesaro Kibener**
> ""Good to see that the fire still burns inside you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Kesaro Kibener: ""Here is what I had in mind.""*)

### Węzeł `[307]`
Mówca: **Kesaro Kibener**
> ""That's exactly what the Young Sords was founded for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Kesaro Kibener: ""Here is what I had in mind.""*)

### Węzeł `[308]`
Mówca: **Kesaro Kibener**
> ""I mean no offense, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Kesaro Kibener: ""Here is what I had in mind.""*)

### Węzeł `[309]`
Mówca: **Kesaro Kibener**
> ""Good. We all must continue learning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Kesaro Kibener: ""Here is what I had in mind.""*)

### Węzeł `[310]`
Mówca: **Kesaro Kibener**
> ""I hope you don't mean that politics is separate from personal beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Kesaro Kibener: ""If you did, I would have to take back my compliment.""*)

### Węzeł `[311]`
Mówca: **Kesaro Kibener**
> ""If you did, I would have to take back my compliment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Kesaro Kibener: ""Here is what I had in mind.""*)

### Węzeł `[312]`
Mówca: **Kesaro Kibener**
> ""There's the matter of the communists. Those damn rats are everywhere I look, trying to sneak into Sordish society from the crevices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Kesaro Kibener: ""You get rid of one, ten more appear!""*)

### Węzeł `[313]`
Mówca: **Kesaro Kibener**
> ""You get rid of one, ten more appear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Kesaro Kibener: ""To me, this is a problem that needs to be solved.""*)

### Węzeł `[314]`
Mówca: **Kesaro Kibener**
> ""To me, this is a problem that needs to be solved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Kesaro Kibener: ""I want you to ban the Red Youth. Sordland has suffered e..."*)

### Węzeł `[315]`
Mówca: **Kesaro Kibener**
> ""I want you to ban the Red Youth. Sordland has suffered enough from the disease these rats bring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Player: ""Message received. If that's what it takes, I will ban th..."*)
  - -> `[324]` (*Player: ""Absolutely not. I left them alone for a reason. I can't ..."*)
  - -> `[325]` (*Player: ""I'm sorry, but I can't do that. Surely there must be som..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == ..."*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords =..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Kesaro Kibener: ""There's the matter of the communists. Those damn rats ar..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Kesaro Kibener: ""I was in Bergia some time ago, and I visited one of thei..."*)

### Węzeł `[319]`
Mówca: **Kesaro Kibener**
> ""While you're in such an agreeable mood, I do have another suggestion...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Kesaro Kibener: ""I was in Bergia some time ago, and I visited one of thei..."*)

### Węzeł `[320]`
Mówca: **Kesaro Kibener**
> ""If you can't do either one, say goodbye to your reform package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Player: ""You will get your signature. I will sign the bill when I..."*)
  - -> `[338]` (*Player: ""I will ban the Red Youth in return for your support.""*)
  - -> `[331]` (*Player: ""I will sign the bill and also ban the Red Youth. You wil..."*)
  - -> `[321]` (*Player: ""I've heard enough. You can't make such demands of the Pr..."*)

### Węzeł `[321]`
**[WYBÓR GRACZA: ""I've heard enough. You can't make such demands of the President of Sordland!""]** — Mówca: **Player**
> ""I've heard enough. You can't make such demands of the President of Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Kesaro Kibener: ""Then there is no use in continuing this conversation, is..."*)

### Węzeł `[322]`
Mówca: **Kesaro Kibener**
> ""I knew we could find some common ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Kesaro Kibener: ""Very well. The NFP and I will support you in your reform..."*)

### Węzeł `[323]`
**[WYBÓR GRACZA: ""Message received. If that's what it takes, I will ban the Red Youth.""]** — Mówca: **Player**
> ""Message received. If that's what it takes, I will ban the Red Youth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Kesaro Kibener), `[315]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Ban_RY = true"*)

### Węzeł `[324]`
**[WYBÓR GRACZA: ""Absolutely not. I left them alone for a reason. I can't risk violence on the streets again.""]** — Mówca: **Player**
> ""Absolutely not. I left them alone for a reason. I can't risk violence on the streets again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Kesaro Kibener), `[315]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Kesaro Kibener: ""Maybe we can... come to an agreement, then.""*)

### Węzeł `[325]`
**[WYBÓR GRACZA: ""I'm sorry, but I can't do that. Surely there must be something else I can offer you?""]** — Mówca: **Player**
> ""I'm sorry, but I can't do that. Surely there must be something else I can offer you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Kesaro Kibener), `[315]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Kesaro Kibener: ""Hmm. There is something I want.""*)

### Węzeł `[326]`
Mówca: **Kesaro Kibener**
> ""Hmm. There is something I want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Kesaro Kibener: ""Maybe we can... come to an agreement, then.""*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Ban_RY = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Kesaro Kibener: ""Excellent.""*)

### Węzeł `[328]`
Mówca: **Kesaro Kibener**
> ""You will either sign my bill or ban the Red Youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Kesaro Kibener: ""If you can't do either one, say goodbye to your reform p..."*)

### Węzeł `[329]`
Mówca: **Kesaro Kibener**
> ""See, that wasn't so hard, was it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Kesaro Kibener: ""I knew we could find some common ground.""*)

### Węzeł `[330]`
Mówca: **Kesaro Kibener**
> ""It makes sense, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true || (BaseG..."*)

### Węzeł `[331]`
**[WYBÓR GRACZA: ""I will sign the bill and also ban the Red Youth. You will help me in return.""]** — Mówca: **Player**
> ""I will sign the bill and also ban the Red Youth. You will help me in return.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Bill = true; BaseGameIso..."*)

### Węzeł `[332]`
Mówca: **Kesaro Kibener**
> ""Maybe we can... come to an agreement, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Kesaro Kibener: ""I was in Bergia some time ago, and I visited one of thei..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Bill = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Bill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Kesaro Kibener: ""See, that wasn't so hard, was it?""*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Ban_RY = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Kesaro Kibener: ""See, that wasn't so hard, was it?""*)

### Węzeł `[335]`
Mówca: **Kesaro Kibener**
> ""I was in Bergia some time ago, and I visited one of their village schools.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Kesaro Kibener: ""I went in to greet the students, and to my shock... none..."*)

### Węzeł `[336]`
Mówca: **Kesaro Kibener**
> ""I went in to greet the students, and to my shock... none of these children knew how to speak Sordish! Can you believe it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Kesaro Kibener: ""They didn't understand me.... their own countryman.""*)

### Węzeł `[337]`
Mówca: **Kesaro Kibener**
> ""They didn't understand me.... their own countryman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Kesaro Kibener: ""I went to the nearby villages. All of them were the same..."*)

### Węzeł `[338]`
**[WYBÓR GRACZA: ""I will ban the Red Youth in return for your support.""]** — Mówca: **Player**
> ""I will ban the Red Youth in return for your support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Ban_RY = true;"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Bill = true; BaseGameIsolated.Turn06_A_Kesaro_Ban_RY = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Bill"] = true;
Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Kesaro Kibener: ""See, that wasn't so hard, was it?""*)

### Węzeł `[340]`
Mówca: **Kesaro Kibener**
> ""I want to be clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Kesaro Kibener: ""This was not a request for you to take a look.""*)

### Węzeł `[341]`
Mówca: **Kesaro Kibener**
> ""This was not a request for you to take a look.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Kesaro Kibener: ""You will either sign my bill or ban the Red Youth.""*)

### Węzeł `[342]`
Mówca: **Kesaro Kibener**
> ""Excellent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Kesaro Kibener: ""While you're in such an agreeable mood, I do have anothe..."*)

### Węzeł `[343]`
Mówca: **Kesaro Kibener**
> ""Then there is no use in continuing this conversation, is there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "Kesaro stood up and looked down at me."*)

### Węzeł `[344]`
Mówca: **Narrator**
> "Kesaro stood up and looked down at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Kesaro Kibener: ""Before I go, I guarantee you this. That bill will not pa..."*)

### Węzeł `[345]`
Mówca: **Kesaro Kibener**
> ""They can speak to each other in whatever language they want. But they must learn Sordish. That's it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true || (BaseG..."*)

### Węzeł `[346]`
**[WYBÓR GRACZA: ""If they live in Sordland, they need to know how to speak in Sordish.""]** — Mówca: **Player**
> ""If they live in Sordland, they need to know how to speak in Sordish.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Kesaro Kibener: ""It makes sense, doesn't it?""*)

### Węzeł `[347]`
**[WYBÓR GRACZA: ""You will get your signature. I will sign the bill when I receive it.""]** — Mówca: **Player**
> ""You will get your signature. I will sign the bill when I receive it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Bill = true;"*)

### Węzeł `[348]`
Mówca: **Kesaro Kibener**
> ""Before I go, I guarantee you this. That bill will not pass the Assembly. I will make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "Jump to: [KesaroLeaves]"*)

### Węzeł `[349]`
**[WYBÓR GRACZA: ""So your answer is to ban them completely from speaking Bludish at school?""]** — Mówca: **Player**
> ""So your answer is to ban them completely from speaking Bludish at school?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Kesaro Kibener: ""They can speak to each other in whatever language they w..."*)

### Węzeł `[350]`
Mówca: **Kesaro Kibener**
> ""This bill, I call it the Unified Education Language Act, will enforce our language as the only one accepted in educational institutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Player: ""If they live in Sordland, they need to know how to speak..."*)
  - -> `[349]` (*Player: ""So your answer is to ban them completely from speaking B..."*)
  - -> `[351]` (*Player: ""I will decide when I see the bill. Not before.""*)

### Węzeł `[351]`
**[WYBÓR GRACZA: ""I will decide when I see the bill. Not before.""]** — Mówca: **Player**
> ""I will decide when I see the bill. Not before.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true || (BaseG..."*)

### Węzeł `[352]`
Mówca: **Kesaro Kibener**
> ""I went to the nearby villages. All of them were the same! Not a single soul spoke Sordish! That put me on the path to draft a new bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Kesaro Kibener: ""This bill, I call it the Unified Education Language Act,..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [KesaroLeaves]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "KesaroLeaves"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true || (BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true && BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true) || BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true || (BaseG..."*)
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true || (Bas..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true || (BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true && BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true) || BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] == true  or  (Variable["BaseGame.Decision_Turn03_StabilityOrder_BanBoth"] == true  and  Variable["BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS"] == true)  or  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Kesaro Kibener: ""Will you do the right thing for Sordland? What do you th..."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true || (BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true && BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true) || BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] == true  or  (Variable["BaseGame.Decision_Turn03_StabilityOrder_BanBoth"] == true  and  Variable["BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS"] == true)  or  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Kesaro Kibener: ""I want to be clear.""*)

### Węzeł `[357]`
Mówca: **Kesaro Kibener**
> ""Will you do the right thing for Sordland? What do you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player: ""You will get your signature. I will sign the bill when I..."*)
  - -> `[359]` (*Player: ""I don't think so. I won't go along with your scheme.""*)

### Węzeł `[358]`
**[WYBÓR GRACZA: ""You will get your signature. I will sign the bill when I receive it.""]** — Mówca: **Player**
> ""You will get your signature. I will sign the bill when I receive it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[357]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Bill = true;"*)

### Węzeł `[359]`
**[WYBÓR GRACZA: ""I don't think so. I won't go along with your scheme.""]** — Mówca: **Player**
> ""I don't think so. I won't go along with your scheme.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[357]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Kesaro Kibener: ""There are no schemes here.""*)

### Węzeł `[360]`
Mówca: **Kesaro Kibener**
> ""There are no schemes here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Kesaro Kibener: ""But regardless, I think we have achieved much today.""*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Bill = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Bill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Kesaro Kibener: ""See, that wasn't so hard, was it?""*)

### Węzeł `[362]`
Mówca: **Kesaro Kibener**
> ""But regardless, I think we have achieved much today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Kesaro Kibener: ""See, that wasn't so hard, was it?""*)

### Węzeł `[363]`
Mówca: **Kesaro Kibener**
> ""Here is what I had in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Kesaro Kibener: ""I was in Bergia some time ago, and I visited one of thei..."*)

### Węzeł `[364]`
Mówca: **Kesaro Kibener**
> ""Very well. The NFP and I will support you in your reform package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Kesaro Kibener: ""Congratulations, Mr. President.""*)

### Węzeł `[365]`
Mówca: **Kesaro Kibener**
> ""Congratulations, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_NFP_Convinced = true; BaseGameSupp..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_NFP_Convinced = true;
BaseGameSupport.News_Turn06_LT_NFPConvinced = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] = true;
Variable["BaseGameSupport.News_Turn06_LT_NFPConvinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Alliance == true"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Alliance == true"*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_A_Kesaro_Alliance == true)"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Kesaro Kibener: ""Well then, Mr. President. My respect for you has increas..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_A_Kesaro_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Kesaro Kibener: ""One last thing before we shake hands.""*)

### Węzeł `[370]`
Mówca: **Kesaro Kibener**
> ""One last thing before we shake hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Kesaro Kibener: ""I see your willingness to cooperate with me and I applau..."*)

### Węzeł `[371]`
Mówca: **Kesaro Kibener**
> ""I see your willingness to cooperate with me and I applaud it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Kesaro Kibener: ""What do you think about taking things a step further?""*)

### Węzeł `[372]`
Mówca: **Kesaro Kibener**
> ""What do you think about taking things a step further?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Kesaro Kibener: ""An alliance between our two parties. We would be extreme..."*)

### Węzeł `[373]`
Mówca: **Kesaro Kibener**
> ""An alliance between our two parties. We would be extremely powerful in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Kesaro Kibener: ""It would open many doors for both of us.""*)

### Węzeł `[374]`
Mówca: **Kesaro Kibener**
> ""It would open many doors for both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Player: ""I'm glad you asked. How better to cement our newfound pa..."*)
  - -> `[375]` (*Player: ""Apologies, but I have to refuse. It would close more doo..."*)

### Węzeł `[375]`
**[WYBÓR GRACZA: ""Apologies, but I have to refuse. It would close more doors than it would open.""]** — Mówca: **Player**
> ""Apologies, but I have to refuse. It would close more doors than it would open.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Kesaro Kibener: ""I understand. Just keep it in mind.""*)

### Węzeł `[376]`
**[WYBÓR GRACZA: ""I'm glad you asked. How better to cement our newfound partnership than with an alliance?""]** — Mówca: **Player**
> ""I'm glad you asked. How better to cement our newfound partnership than with an alliance?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Alliance = true"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Alliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Kesaro Kibener: ""What a historic day!""*)

### Węzeł `[378]`
Mówca: **Kesaro Kibener**
> ""What a historic day!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Kesaro Kibener: ""It will be tough to convince our respective parties, but..."*)

### Węzeł `[379]`
Mówca: **Kesaro Kibener**
> ""It will be tough to convince our respective parties, but I believe the good we'll do for Sordland together will be worth the hurdle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Kesaro Kibener: ""Well then, Mr. President. My respect for you has increas..."*)

### Węzeł `[380]`
Mówca: **Kesaro Kibener**
> ""I understand. Just keep it in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Kesaro Kibener: ""Well then, Mr. President. My respect for you has increas..."*)

### Węzeł `[381]`
Mówca: **Kesaro Kibener**
> ""Well then, Mr. President. My respect for you has increased a hundredfold within the short span of this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Player: ""We will do great things together.""*)
  - -> `[384]` (*Player: ""Thank you for coming, Kesaro.""*)
  - -> `[385]` (*Player: ""Make sure you deliver your end of the promise.""*)

### Węzeł `[382]`
**[WYBÓR GRACZA: ""We will do great things together.""]** — Mówca: **Player**
> ""We will do great things together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[381]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Kesaro Kibener: ""I am looking forward to it.""*)

### Węzeł `[383]`
Mówca: **Kesaro Kibener**
> ""I am looking forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Narrator: "We shook hands and Kesaro turned around to leave."*)

### Węzeł `[384]`
**[WYBÓR GRACZA: ""Thank you for coming, Kesaro.""]** — Mówca: **Player**
> ""Thank you for coming, Kesaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[381]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Kesaro Kibener: ""Thank you for having me.""*)

### Węzeł `[385]`
**[WYBÓR GRACZA: ""Make sure you deliver your end of the promise.""]** — Mówca: **Player**
> ""Make sure you deliver your end of the promise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[381]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Kesaro Kibener: ""I have never broken my word in my life.""*)

### Węzeł `[386]`
Mówca: **Kesaro Kibener**
> ""I have never broken my word in my life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Narrator: "We shook hands and Kesaro turned around to leave."*)

### Węzeł `[387]`
Mówca: **Kesaro Kibener**
> ""Thank you for having me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Narrator: "We shook hands and Kesaro turned around to leave."*)

### Węzeł `[388]`
Mówca: **Narrator**
> "We shook hands and Kesaro turned around to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "Kesaro closed the door and left my office."*)

### Węzeł `[389]`
Mówca: **Narrator**
> "Kesaro closed the door and left my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Alliance == true"*)

### Węzeł `[390]`
Mówca: **Narrator**
> "He closed the door and left my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_LT_NFPNotConvinced = true"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Alliance == true"*)
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_A_Kesaro_Alliance == true)"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Alliance = true"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_A_Kesaro_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Bill == true"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_NFP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Alliance_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Kesaro_Alliance = true"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Bill == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Bill == true"*)
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_A_Kesaro_Bill == true)"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Bill == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Bill"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Kesaro_Promise_Bill = true;"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_A_Kesaro_Bill == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_Bill"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Bill = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Kesaro_Promise_Bill"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Kesaro_Bill = true;"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true"*)
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true)"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS = false; BaseGa..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS = false; BaseGame.Policy_Law_Ban_YoungSords = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] = false;
Variable["BaseGame.Policy_Law_Ban_YoungSords"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Kesaro_RevertYS = true"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 == true"*)
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 == true)"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_10"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_15 = false; BaseGame.Reform..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_10"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Threshold_8 == true"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Threshold_8 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Threshold_8 == true"*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_A_Kesaro_Threshold_8 == true)"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Threshold_8 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_15 = false; BaseGame.Reform..."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_A_Kesaro_Threshold_8 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_A_Reform = true; BaseGameSupport.New..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_15 = false; BaseGame.Reform_Law_Threshold_3 = false; BaseGame.Reform_Law_Threshold_8 = true; BaseGame.Reform_Law_Threshold_Default = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Threshold_15"] = false;
Variable["BaseGame.Reform_Law_Threshold_3"] = false;
Variable["BaseGame.Reform_Law_Threshold_8"] = true;
Variable["BaseGame.Reform_Law_Threshold_Default"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Kesaro_Threshold8 = true"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_15 = false; BaseGame.Reform_Law_Threshold_3 = false; BaseGame.Reform_Law_Threshold_8 = false; BaseGame.Reform_Law_Threshold_Default = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Threshold_15"] = false;
Variable["BaseGame.Reform_Law_Threshold_3"] = false;
Variable["BaseGame.Reform_Law_Threshold_8"] = false;
Variable["BaseGame.Reform_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Kesaro_Threshold10 = true"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true"*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true)"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY = true; BaseGam..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 == true"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY = true; BaseGame.Policy_Law_Ban_RedYouth = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] = true;
Variable["BaseGame.Policy_Law_Ban_RedYouth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Kesaro_BanRY = true"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Kesaro_Alliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Kesaro_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Bill == true"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Kesaro_Bill = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Kesaro_Bill"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Kesaro_RevertYS = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Kesaro_RevertYS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true"*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Kesaro_BanRY = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Kesaro_BanRY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 == true"*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Kesaro_Threshold10 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Kesaro_Threshold10"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_A_Kesaro_Threshold_8 == true"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Kesaro_Threshold8 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Kesaro_Threshold8"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_A_Reform = true; BaseGameSupport.New..."*)

### Węzeł `[421]`
Mówca: **Narrator**
> "He grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Kesaro Kibener: ""Some key figures in my party are also reporting obstruct..."*)

### Węzeł `[422]`
Mówca: **Kesaro Kibener**
> ""I think they have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "Kesaro clenched his fist."*)

### Węzeł `[423]`
Mówca: **Kesaro Kibener**
> ""Give me a break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "Kesaro clenched his fist."*)

### Węzeł `[424]`
Mówca: **Kesaro Kibener**
> ""Oh, give me a break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "Kesaro clenched his fist."*)

### Węzeł `[425]`
Mówca: **Kesaro Kibener**
> ""Oh, give me a break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "Kesaro clenched his fist."*)

### Węzeł `[426]`
Mówca: **Kesaro Kibener**
> ""I think they have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "Kesaro clenched his fist."*)

### Węzeł `[427]`
Mówca: **Kesaro Kibener**
> ""Give me a break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "Kesaro clenched his fist."*)

### Węzeł `[428]`
Mówca: **Kesaro Kibener**
> ""Oh, give me a break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "Kesaro clenched his fist."*)

### Węzeł `[429]`
Mówca: **Kesaro Kibener**
> ""I think they have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "Kesaro clenched his fist."*)

### Węzeł `[430]`
Mówca: **Kesaro Kibener**
> ""Give me a break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "Kesaro clenched his fist."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == t..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Kesaro Kibener: ""I also wanted to talk about the aid you received from Un..."*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Kesaro Kibener: ""Look. I went over your proposed constitutional changes...""*)

### Węzeł `[434]`
Mówca: **Kesaro Kibener**
> ""I also wanted to talk about the aid you received from United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Kesaro Kibener: ""Do you think that's just free money? Do you think they o..."*)

### Węzeł `[435]`
Mówca: **Kesaro Kibener**
> ""Do you think that's just free money? Do you think they offered it out of sheer goodwill?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Kesaro Kibener: ""You were fooled. They saw Sordland battling the recessio..."*)

### Węzeł `[436]`
Mówca: **Kesaro Kibener**
> ""You were fooled. They saw Sordland battling the recession and they pounced on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Kesaro Kibener: ""You sold our national pride for money.""*)

### Węzeł `[437]`
Mówca: **Kesaro Kibener**
> ""You sold our national pride for money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Player: ""It was a necessary evil. Don't expect me to sit by while..."*)
  - -> `[439]` (*Player: ""I don't see anything wrong with accepting a helping hand.""*)
  - -> `[440]` (*Player: ""Is your national pride so fragile that this will destroy..."*)
  - -> `[441]` (*Player: ""Kesaro. I am the President. I won't allow you to talk to..."*)

### Węzeł `[438]`
**[WYBÓR GRACZA: ""It was a necessary evil. Don't expect me to sit by while my people suffer.""]** — Mówca: **Player**
> ""It was a necessary evil. Don't expect me to sit by while my people suffer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Kesaro Kibener: ""You are naive.""*)

### Węzeł `[439]`
**[WYBÓR GRACZA: ""I don't see anything wrong with accepting a helping hand.""]** — Mówca: **Player**
> ""I don't see anything wrong with accepting a helping hand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Kesaro Kibener: ""You are naive.""*)

### Węzeł `[440]`
**[WYBÓR GRACZA: ""Is your national pride so fragile that this will destroy it? I don't think so.""]** — Mówca: **Player**
> ""Is your national pride so fragile that this will destroy it? I don't think so.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Kesaro Kibener: ""I fought for my country many times, and I have the scars..."*)

### Węzeł `[441]`
**[WYBÓR GRACZA: ""Kesaro. I am the President. I won't allow you to talk to me like this.""]** — Mówca: **Player**
> ""Kesaro. I am the President. I won't allow you to talk to me like this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Kesaro Kibener: ""Of course. My apologies. I'll get to the point.""*)

### Węzeł `[442]`
Mówca: **Kesaro Kibener**
> ""Of course. My apologies. I'll get to the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Kesaro Kibener: ""Look. I went over your proposed constitutional changes...""*)

### Węzeł `[443]`
Mówca: **Kesaro Kibener**
> ""I fought for my country many times, and I have the scars to prove it. Can you say the same?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Kesaro Kibener: ""I won't waste my breath further on this matter, since yo..."*)

### Węzeł `[444]`
Mówca: **Kesaro Kibener**
> ""You are naive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Kesaro Kibener: ""I won't waste my breath further on this matter, since yo..."*)

### Węzeł `[445]`
Mówca: **Kesaro Kibener**
> ""I won't waste my breath further on this matter, since you clearly don't understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Kesaro Kibener: ""Look. I went over your proposed constitutional changes...""*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_LT_NFPNotConvinced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_LT_NFPNotConvinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn06_Holsord_NFP_NotConvinced = ..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn06_Holsord_NFP_NotConvinced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn06_Holsord_NFP_NotConvinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_A_Reform = true; BaseGameSupport.New..."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Kesaro_Promise_Alliance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_NFP = true"*)

### Węzeł `[453]`
Mówca: **Kesaro Kibener**
> ""In the end, it's only a 2% difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Kesaro Kibener: ""I am fine with it as long as I get something else out of..."*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_KesaroLighter");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_KesaroLighter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Kesaro Kibener: ""Please. Keep it.""*)

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is that an original Rippo?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Kesaro Kibener: ""You bet, Mr. President. It's one of the firsts.""*)

### Węzeł `[456]`
Mówca: **Kesaro Kibener**
> ""You bet, Mr. President. It's one of the firsts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Narrator: "He gave me the lighter. It was an original Rippo, but the..."*)

### Węzeł `[457]`
Mówca: **Narrator**
> "He gave me the lighter. It was an original Rippo, but the shape appeared to be malformed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_KesaroLighter");"*)

### Węzeł `[458]`
Mówca: **Kesaro Kibener**
> ""Please. Keep it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Looking more closely, I could see a large circular dent i..."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_ST_VictoryDay = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_ST_VictoryDay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true ..."*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
