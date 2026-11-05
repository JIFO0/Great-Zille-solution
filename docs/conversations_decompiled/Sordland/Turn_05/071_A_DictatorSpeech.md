# Sordland/Turn05/A_DictatorSpeech

- **ID konwersacji:** `71`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/071_A_DictatorSpeech.md`
- **Liczba węzłów dialogowych:** 274
- **Liczba wyborów gracza:** 84

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[32]** Frens Ricter
- **[34]** Gloria Tory
- **[50]** Kesaro Kibener

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Reform_Albin_Convinced`
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Threshold_8`
- `BaseGame.Speech_PromisedToTrySoll`
- `BaseGame.Wehlen_TradeDeal`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B`
- `BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed`
- `BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard`
- `BaseGameIsolated.Turn05_A_Speech_SeparationofPowers`
- `BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive`
- `BaseGameIsolated.Turn05_A_Speech_StrongerDecrees`
- `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Public_Opinion`
- `BaseGame.Sollist`
- `BaseGame.Speech_PromisedToTrySoll`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B`
- `BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard`
- `BaseGameIsolated.Turn05_A_Speech_SeparationofPowers`
- `BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive`
- `BaseGameIsolated.Turn05_A_Speech_StrongerDecrees`
- `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower`
- `BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy`
- `BaseGameSupport.News_Turn05_G_WalkerWarnsNavy`
- `BaseGameSupport.News_Turn05_HP_ConstitutionNotAdequate_D`
- `BaseGameSupport.News_Turn05_HP_ElectionThreshold_D`
- `BaseGameSupport.News_Turn05_HP_StrongerExecutive_D`
- `BaseGameSupport.News_Turn05_LT_StrongerDecrees_D`
- `BaseGameSupport.News_Turn05_R_PromisedToTrySoll`
- `BaseGameSupport.News_Turn05_ST_OvershadowedByOldGuard_D`
- `BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal`
- `BaseGameSupport.News_Turn05_ST_SCTooMuchPower_D`
- `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both`
- `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_GloriaAlbin`
- `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None`
- `BaseGameSupport.Report_Turn05_Uziren_BorderReport`
- `GameCondition.Turn05_A_Speech`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""We both know that our Constitution is flawed.""** | `[52]` **Gloria Tory**: ""Mr. President, with all due res..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Gloria Tory**: ""Tarquin Soll and his efforts ca..." |
| `[9]` | **""We must finally rewrite the Constitution of Soll and break our chains of the past!""** | `[39]` **Narrator**: "I continued." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Player**: ""We will break the Supreme Court..."<br>`[45]` **Player**: ""I will break down the obstacles..."<br>*(oraz 1 innych odgałęzień)* |
| `[14]` | **""We are not specifically cooperating with someone, but everyone. We ask that you a..."** | `[16]` **Narrator**: "I looked at him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Player**: ""Do not stand against change! Be..."<br>`[33]` **Player**: ""Don't you dare stand against us..."<br>*(oraz 2 innych odgałęzień)* |
| `[19]` | **""I'm saddened to hear about your opposite stance.""** | `[16]` **Narrator**: "I looked at him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Player**: ""Do not stand against change! Be..."<br>`[33]` **Player**: ""Don't you dare stand against us..."<br>*(oraz 2 innych odgałęzień)* |
| `[22]` | **""I respect your opinion.""** | `[14]` **Player**: ""We are not specifically coopera..."<br>`[19]` **Player**: ""I'm saddened to hear about your..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "He murmured something from his s..." |
| `[24]` | **""Thank you, Mrs. Speaker.""** | `[60]` **Narrator**: "Gloria looked at me to see if I'..."<br>`[68]` **Narrator**: "Gloria looked at me to see if I'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Narrator**: "I got up from my seat and starte..." |
| `[25]` | **""Do not stand against change! Be a part of it, Mr. Ricter! We can do much more tog..."** | `[14]` **Player**: ""We are not specifically coopera..."<br>`[19]` **Player**: ""I'm saddened to hear about your..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "He murmured something from his s..." |
| `[28]` | **""We don't need you.""** | `[14]` **Player**: ""We are not specifically coopera..."<br>`[19]` **Player**: ""I'm saddened to hear about your..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "He murmured something from his s..." |
| `[33]` | **""Don't you dare stand against us! Otherwise, know that the PFJP is guaranteed to b..."** | `[14]` **Player**: ""We are not specifically coopera..."<br>`[19]` **Player**: ""I'm saddened to hear about your..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "He murmured something from his s..." |
| `[34]` | **""Ladies and Gentlemen...""** | `[32]` **Narrator**: "I walked to the stand as loud cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Player**: ""The Supreme Court holds too muc..."<br>`[92]` **Player**: ""We have always been overshadowe..."<br>*(oraz 3 innych odgałęzień)* |
| `[35]` | **""It is you, who shouldn't use the word 'democratic' when you want your way to succ..."** | `[16]` **Narrator**: "I looked at him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Player**: ""Do not stand against change! Be..."<br>`[33]` **Player**: ""Don't you dare stand against us..."<br>*(oraz 2 innych odgałęzień)* |
| `[36]` | **""The Supreme Court holds too much power...""** | `[34]` **Player**: ""Ladies and Gentlemen of the Gra..."<br>`[78]` **Player**: ""Honorable Members of the Grand ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPo...` | `[39]` **Narrator**: "I continued." |
| `[37]` | **""Our election threshold has harmed our democracy more than anything...""** | `[34]` **Player**: ""Ladies and Gentlemen of the Gra..."<br>`[78]` **Player**: ""Honorable Members of the Grand ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Law_Threshold_8"] == true` | `Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPo...` | `[39]` **Narrator**: "I continued." |
| `[38]` | **""It is time to strengthen the executive to enact faster and more powerful reforms!""** | `[34]` **Player**: ""Ladies and Gentlemen of the Gra..."<br>`[78]` **Player**: ""Honorable Members of the Grand ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true` | `Variable["BaseGameIsolated.Turn05_A_Speech_StrengthenExec...` | `[39]` **Narrator**: "I continued." |
| `[43]` | **""...Therefore, we propose changes to the Constitution to prepare Sordland for a fa..."** | `[39]` **Narrator**: "I continued." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Player**: ""We will break the Supreme Court..."<br>`[45]` **Player**: ""I will break down the obstacles..."<br>*(oraz 1 innych odgałęzień)* |
| `[44]` | **""We will break the Supreme Court's authority over constitutional changes.""** | `[9]` **Player**: ""We must finally rewrite the Con..."<br>`[43]` **Player**: ""...Therefore, we propose change..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Narrator**: "I focused on..." |
| `[45]` | **""I will break down the obstacles before me!""** | `[9]` **Player**: ""We must finally rewrite the Con..."<br>`[43]` **Player**: ""...Therefore, we propose change..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Narrator**: "I focused on..." |
| `[46]` | **""We will rebalance the branches of government to ensure a more democratic process.""** | `[9]` **Player**: ""We must finally rewrite the Con..."<br>`[43]` **Player**: ""...Therefore, we propose change..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive"] == false` | *Brak zmian stanu* | `[100]` **Narrator**: "I focused on..." |
| `[50]` | **"Unity."** | `[100]` **Narrator**: "I focused on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Player**: ""We will make Sordland great aga..."<br>`[132]` **Player**: ""Let's embrace the future.""<br>*(oraz 2 innych odgałęzień)* |
| `[53]` | **""Please don't interrupt me.""** | `[52]` **Gloria Tory**: ""Mr. President, with all due res..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Gloria Tory**: ""Tarquin Soll and his efforts ca..." |
| `[54]` | **""I'm not finished yet, Mrs. Tory.""** | `[52]` **Gloria Tory**: ""Mr. President, with all due res..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Gloria Tory**: ""Tarquin Soll and his efforts ca..." |
| `[55]` | **""Ladies and gentlemen of the Assembly! We must set aside our differences.""** | `[56]` **Narrator**: "I took a breath and continued." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Player**: ""Be part of a new era for Sordla..."<br>`[63]` **Player**: ""I ask everyone to support us in..."<br>*(oraz 1 innych odgałęzień)* |
| `[58]` | **""It is time to make a new Constitution together!""** | `[56]` **Narrator**: "I took a breath and continued." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Player**: ""Be part of a new era for Sordla..."<br>`[63]` **Player**: ""I ask everyone to support us in..."<br>*(oraz 1 innych odgałęzień)* |
| `[59]` | **""I ask everyone to think clearly about our current situation. And join us for chan..."** | `[56]` **Narrator**: "I took a breath and continued." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Player**: ""Be part of a new era for Sordla..."<br>`[63]` **Player**: ""I ask everyone to support us in..."<br>*(oraz 1 innych odgałęzień)* |
| `[61]` | **""Ladies and Gentlemen, I demand your votes!""** | `[55]` **Player**: ""Ladies and gentlemen of the Ass..."<br>`[58]` **Player**: ""It is time to make a new Consti..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Player**: ""Let's write the future together!""<br>`[65]` **Player**: ""I will address all the problems..."<br>*(oraz 2 innych odgałęzień)* |
| `[62]` | **""Let's write the future together!""** | `[61]` **Player**: ""Ladies and Gentlemen, I demand ..."<br>`[63]` **Player**: ""I ask everyone to support us in..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Player_Italic**: "I saluted the crowd."<br>`[165]` **Player_Italic**: "I decided to read a poem before ..." |
| `[63]` | **""I ask everyone to support us in the upcoming vote.""** | `[55]` **Player**: ""Ladies and gentlemen of the Ass..."<br>`[58]` **Player**: ""It is time to make a new Consti..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Player**: ""Let's write the future together!""<br>`[65]` **Player**: ""I will address all the problems..."<br>*(oraz 2 innych odgałęzień)* |
| `[64]` | **""Be part of a new era for Sordland. Join us and vote for our proposal.""** | `[55]` **Player**: ""Ladies and gentlemen of the Ass..."<br>`[58]` **Player**: ""It is time to make a new Consti..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Player**: ""Let's write the future together!""<br>`[65]` **Player**: ""I will address all the problems..."<br>*(oraz 2 innych odgałęzień)* |
| `[65]` | **""I will address all the problems of the past in my proposal!""** | `[61]` **Player**: ""Ladies and Gentlemen, I demand ..."<br>`[63]` **Player**: ""I ask everyone to support us in..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Player_Italic**: "I saluted the crowd."<br>`[165]` **Player_Italic**: "I decided to read a poem before ..." |
| `[66]` | **""USP will change and lead Sordland into the future!""** | `[61]` **Player**: ""Ladies and Gentlemen, I demand ..."<br>`[63]` **Player**: ""I ask everyone to support us in..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Player_Italic**: "I saluted the crowd."<br>`[165]` **Player_Italic**: "I decided to read a poem before ..." |
| `[67]` | **""For justice in Sordland!""** | `[164]` **Player_Italic**: "I saluted the crowd." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "The Assembly roared with all kin..." |
| `[69]` | **""For a strong Sordland!""** | `[164]` **Player_Italic**: "I saluted the crowd." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "The Assembly roared with all kin..." |
| `[70]` | **""For a united Sordland!""** | `[164]` **Player_Italic**: "I saluted the crowd." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "The Assembly roared with all kin..." |
| `[71]` | **""We will bring change regardless of your support.""** | `[12]` **Narrator**: "He murmured something from his s..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub...` | `[68]` **Narrator**: "Gloria looked at me to see if I'..." |
| `[72]` | **""For a free Sordland!""** | `[164]` **Player_Italic**: "I saluted the crowd." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "The Assembly roared with all kin..." |
| `[73]` | **""Your times have passed, Mr. Ricter.""** | `[12]` **Narrator**: "He murmured something from his s..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub...` | `[68]` **Narrator**: "Gloria looked at me to see if I'..." |
| `[75]` | **""Thank you.""** | `[12]` **Narrator**: "He murmured something from his s..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub...` | `[68]` **Narrator**: "Gloria looked at me to see if I'..." |
| `[78]` | **""Honorable Members of Assembly...""** | `[32]` **Narrator**: "I walked to the stand as loud cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Player**: ""The Supreme Court holds too muc..."<br>`[92]` **Player**: ""We have always been overshadowe..."<br>*(oraz 3 innych odgałęzień)* |
| `[79]` | **""I expect your support in the upcoming vote, Mr. Ricter.""** | `[12]` **Narrator**: "He murmured something from his s..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub...` | `[68]` **Narrator**: "Gloria looked at me to see if I'..." |
| `[80]` | **""Brothers and sisters...""** | `[32]` **Narrator**: "I walked to the stand as loud cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Player**: ""The Supreme Court holds too muc..."<br>`[92]` **Player**: ""We have always been overshadowe..."<br>*(oraz 3 innych odgałęzień)* |
| `[90]` | **""Our Constitution doesn't adequately define or respect the separation of powers...""** | `[34]` **Player**: ""Ladies and Gentlemen of the Gra..."<br>`[78]` **Player**: ""Honorable Members of the Grand ..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false` | `Variable["BaseGameIsolated.Turn05_A_Speech_SeparationofPo...` | `[39]` **Narrator**: "I continued." |
| `[92]` | **""We have always been overshadowed by the Old Guard...""** | `[34]` **Player**: ""Ladies and Gentlemen of the Gra..."<br>`[78]` **Player**: ""Honorable Members of the Grand ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Speech_OvershadowedGu...` | `[39]` **Narrator**: "I continued." |
| `[95]` | **""I call everyone to stand by us to make historic changes to our Constitution and b..."** | `[39]` **Narrator**: "I continued." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Player**: ""We will break the Supreme Court..."<br>`[45]` **Player**: ""I will break down the obstacles..."<br>*(oraz 1 innych odgałęzień)* |
| `[99]` | **""I just wanted to thank everybody for their comments.""** | `[108]` **Gloria Tory**: ""Yes, Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Gloria Tory**: ""Alright, Mr. President."" |
| `[102]` | **""Mr. Ricter...""** | `[108]` **Gloria Tory**: ""Yes, Mr. President.""<br>`[60]` **Narrator**: "Gloria looked at me to see if I'..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] == true) == false` | *Brak zmian stanu* | `[16]` **Narrator**: "I looked at him." |
| `[104]` | **"Change."** | `[100]` **Narrator**: "I focused on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Player**: ""We will make Sordland great aga..."<br>`[132]` **Player**: ""Let's embrace the future.""<br>*(oraz 2 innych odgałęzień)* |
| `[105]` | **"Peace."** | `[100]` **Narrator**: "I focused on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Player**: ""We will make Sordland great aga..."<br>`[132]` **Player**: ""Let's embrace the future.""<br>*(oraz 2 innych odgałęzień)* |
| `[106]` | **""Mr. Kibener...""** | `[108]` **Gloria Tory**: ""Yes, Mr. President.""<br>`[60]` **Narrator**: "Gloria looked at me to see if I'..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] == true) == false` | *Brak zmian stanu* | `[97]` **Narrator**: "I looked at him." |
| `[115]` | **"Ask to speak."** | `[118]` **Narrator**: "Kesaro went back to his seat but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Gloria Tory**: ""Yes, Mr. President."" |
| `[116]` | **"Leave the Assembly."** | `[118]` **Narrator**: "Kesaro went back to his seat but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "I got up from my seat and starte..." |
| `[124]` | **""Tarquin Soll will answer for the crimes committed during his rule! We will make s..."** | `[50]` **Player**: ""It is more important than ever ..."<br>`[104]` **Player**: ""We must not be afraid of change..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true` | `Variable["BaseGame.Speech_PromisedToTrySoll"] = true;`<br>`Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist...`<br>*(+1 skryptów)* | `[109]` **Narrator**: "Just as I was about to continue ..."<br>`[51]` **Narrator**: "Loud noises came from USP and NF..." |
| `[129]` | **""We will be strengthening the presidential decrees.""** | `[50]` **Player**: ""It is more important than ever ..."<br>`[104]` **Player**: ""We must not be afraid of change..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true` | `Variable["BaseGameIsolated.Turn05_A_Speech_StrongerDecree...`<br>`PlaySoundEffect("AssemblyLoud");` | `[109]` **Narrator**: "Just as I was about to continue ..."<br>`[51]` **Narrator**: "Loud noises came from USP and NF..." |
| `[131]` | **""We will make Sordland great again!""** | `[50]` **Player**: ""It is more important than ever ..."<br>`[104]` **Player**: ""We must not be afraid of change..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyLoud");` | `[109]` **Narrator**: "Just as I was about to continue ..."<br>`[51]` **Narrator**: "Loud noises came from USP and NF..." |
| `[132]` | **""Let's embrace the future.""** | `[50]` **Player**: ""It is more important than ever ..."<br>`[104]` **Player**: ""We must not be afraid of change..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyLoud");` | `[109]` **Narrator**: "Just as I was about to continue ..."<br>`[51]` **Narrator**: "Loud noises came from USP and NF..." |
| `[137]` | **""You don't believe that.""** | `[52]` **Gloria Tory**: ""Mr. President, with all due res..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Gloria Tory**: ""Tarquin Soll and his efforts ca..." |
| `[141]` | **""We are not here to destroy Sollism nor our cultural values.""** | `[146]` **Gloria Tory**: ""That was the extent of my quick..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Gloria Tory**: ""You've just promised to try Sol..."<br>`[158]` **Gloria Tory**: ""Please continue your speech, Mr..." |
| `[148]` | **""That was disrespectful Mrs. Speaker. Please don't try to sabotage my speech.""** | `[146]` **Gloria Tory**: ""That was the extent of my quick..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Gloria Tory**: ""You've just promised to try Sol..."<br>`[158]` **Gloria Tory**: ""Please continue your speech, Mr..." |
| `[153]` | **""Who are you trying to provoke, Mrs. Tory? USP is behind me.""** | `[146]` **Gloria Tory**: ""That was the extent of my quick..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Gloria Tory**: ""You've just promised to try Sol..."<br>`[158]` **Gloria Tory**: ""Please continue your speech, Mr..." |
| `[157]` | **""I'll act as if that didn't happen.""** | `[146]` **Gloria Tory**: ""That was the extent of my quick..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Gloria Tory**: ""You've just promised to try Sol..."<br>`[158]` **Gloria Tory**: ""Please continue your speech, Mr..." |
| `[159]` | **"War."** | `[100]` **Narrator**: "I focused on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Player**: ""We will make Sordland great aga..."<br>`[132]` **Player**: ""Let's embrace the future.""<br>*(oraz 2 innych odgałęzień)* |
| `[160]` | **""Give me the power to make Sordland great again!""** | `[61]` **Player**: ""Ladies and Gentlemen, I demand ..."<br>`[63]` **Player**: ""I ask everyone to support us in..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true` | *Brak zmian stanu* | `[164]` **Player_Italic**: "I saluted the crowd."<br>`[165]` **Player_Italic**: "I decided to read a poem before ..." |
| `[164]` | **"Salute the crowd."** | `[62]` **Player**: ""Let's write the future together!""<br>`[65]` **Player**: ""I will address all the problems..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Player**: ""For justice in Sordland!""<br>`[69]` **Player**: ""For a strong Sordland!""<br>*(oraz 2 innych odgałęzień)* |
| `[165]` | **"Finish with a poem."** | `[62]` **Player**: ""Let's write the future together!""<br>`[65]` **Player**: ""I will address all the problems..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Player**: ""There is a destiny above destin..."<br>`[167]` **Player**: ""There is a victory growing with..." |
| `[166]` | **""There is a destiny above destiny...""** | `[165]` **Player_Italic**: "I decided to read a poem before ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Player**: ""There is a revolution, beyond o..."<br>`[170]` **Player**: ""There is God, beyond existence ..."<br>*(oraz 1 innych odgałęzień)* |
| `[167]` | **""There is a victory growing with every morning...""** | `[165]` **Player_Italic**: "I decided to read a poem before ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Player**: ""There is a revolution, beyond o..."<br>`[170]` **Player**: ""There is God, beyond existence ..."<br>*(oraz 1 innych odgałęzień)* |
| `[168]` | **""There is my country, beyond my existence or nonexistence...""** | `[166]` **Player**: ""There is a destiny above destin..."<br>`[167]` **Player**: ""There is a victory growing with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Player**: ""There are songs to be sung in a..."<br>`[173]` **Player**: ""There is a spring that blossoms..."<br>*(oraz 1 innych odgałęzień)* |
| `[169]` | **""There is a revolution, beyond our and their existence...""** | `[166]` **Player**: ""There is a destiny above destin..."<br>`[167]` **Player**: ""There is a victory growing with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Player**: ""There are songs to be sung in a..."<br>`[173]` **Player**: ""There is a spring that blossoms..."<br>*(oraz 1 innych odgałęzień)* |
| `[170]` | **""There is God, beyond existence and nonexistence...""** | `[166]` **Player**: ""There is a destiny above destin..."<br>`[167]` **Player**: ""There is a victory growing with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Player**: ""There are songs to be sung in a..."<br>`[173]` **Player**: ""There is a spring that blossoms..."<br>*(oraz 1 innych odgałęzień)* |
| `[171]` | **""There is the evil that tortures and tears me down...""** | `[168]` **Player**: ""There is my country, beyond my ..."<br>`[169]` **Player**: ""There is a revolution, beyond o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Player**: ""Do not doubt the One! There is ..."<br>`[175]` **Player**: ""Fear not when the dark falls! T..."<br>*(oraz 1 innych odgałęzień)* |
| `[172]` | **""There are songs to be sung in affectation of our battles...""** | `[168]` **Player**: ""There is my country, beyond my ..."<br>`[169]` **Player**: ""There is a revolution, beyond o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Player**: ""Do not doubt the One! There is ..."<br>`[175]` **Player**: ""Fear not when the dark falls! T..."<br>*(oraz 1 innych odgałęzień)* |
| `[173]` | **""There is a spring that blossoms out of the graves of our fallen...""** | `[168]` **Player**: ""There is my country, beyond my ..."<br>`[169]` **Player**: ""There is a revolution, beyond o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Player**: ""Do not doubt the One! There is ..."<br>`[175]` **Player**: ""Fear not when the dark falls! T..."<br>*(oraz 1 innych odgałęzień)* |
| `[174]` | **""Do not doubt the One! There is a decision coming from the heavens...""** | `[171]` **Player**: ""There is the evil that tortures..."<br>`[172]` **Player**: ""There are songs to be sung in a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Player**: ""Beyond the next morning, there ..." |
| `[175]` | **""Fear not when the dark falls! There is an artist painting the sun.""** | `[171]` **Player**: ""There is the evil that tortures..."<br>`[172]` **Player**: ""There are songs to be sung in a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Player**: ""Beyond the next morning, there ..." |
| `[176]` | **""Do not dare call it defeat! There is a fortress made from my ashes.""** | `[171]` **Player**: ""There is the evil that tortures..."<br>`[172]` **Player**: ""There are songs to be sung in a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Player**: ""Beyond the next morning, there ..." |
| `[177]` | **""Beyond the next morning, there is a victory waiting to be won.""** | `[174]` **Player**: ""Do not doubt the One! There is ..."<br>`[175]` **Player**: ""Fear not when the dark falls! T..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "The Assembly roared with all kin..." |
| `[178]` | **""Rest assured, your concerns will be addressed.""** | `[97]` **Narrator**: "I looked at him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Player**: ""I expect your support, Mr. Kibe..."<br>`[181]` **Player**: ""Thank you for your support. We ..."<br>*(oraz 1 innych odgałęzień)* |
| `[179]` | **""We'd like to have cooperation between our parties.""** | `[97]` **Narrator**: "I looked at him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Player**: ""I expect your support, Mr. Kibe..."<br>`[181]` **Player**: ""Thank you for your support. We ..."<br>*(oraz 1 innych odgałęzień)* |
| `[180]` | **""I welcome your positive attitude.""** | `[178]` **Player**: ""Rest assured, your concerns wil..."<br>`[179]` **Player**: ""We'd like to have cooperation b..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub...` | `[60]` **Narrator**: "Gloria looked at me to see if I'..." |
| `[181]` | **""Thank you for your support. We are looking forward to work with the NFP.""** | `[178]` **Player**: ""Rest assured, your concerns wil..."<br>`[179]` **Player**: ""We'd like to have cooperation b..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub...` | `[60]` **Narrator**: "Gloria looked at me to see if I'..." |
| `[182]` | **""Thank you for the nice words.""** | `[97]` **Narrator**: "I looked at him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Player**: ""I expect your support, Mr. Kibe..."<br>`[181]` **Player**: ""Thank you for your support. We ..."<br>*(oraz 1 innych odgałęzień)* |
| `[183]` | **""I expect your support, Mr. Kibener! We can do much more together.""** | `[178]` **Player**: ""Rest assured, your concerns wil..."<br>`[179]` **Player**: ""We'd like to have cooperation b..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub...` | `[60]` **Narrator**: "Gloria looked at me to see if I'..." |
| `[255]` | **""Hear me out.""** | `[254]` **Narrator**: "Loud noises came from USP and NF..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Narrator**: "I took a breath and continued." |
| `[256]` | **""Everyone! Please! Let me finish.""** | `[254]` **Narrator**: "Loud noises came from USP and NF..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Narrator**: "I took a breath and continued." |
| `[257]` | **""Let me explain.""** | `[254]` **Narrator**: "Loud noises came from USP and NF..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Narrator**: "I took a breath and continued." |

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
  - -> `[3]` (*Narrator: "I came to the Grand National Assembly of Sordland to deli..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I came to the Grand National Assembly of Sordland to deliver a speech regarding the new Constitution and ask for the support of the Assembly before the upcoming vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I walked quickly through the corridors, giving my greetin..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I walked quickly through the corridors, giving my greetings to people on my way towards the parliamentary hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyShouting");"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "When I entered the hall, the Assembly was in complete chaos, with shouting and cursing between the parties. There was a heavy argument about a proposal made by an MP from NFP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I took my seat inside the special area reserved for the m..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""We both know that our Constitution is flawed.""]** — Mówca: **Player**
> ""We both know that our Constitution is flawed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Gloria Tory: ""Tarquin Soll and his efforts cannot be ignored. We must ..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I took my seat inside the special area reserved for the ministers. Gloria was shouting from her seat at the centre of the hall as she hit the gavel three times, with each strike heavier than the one before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Gloria Tory: "<shout>"ORDER! ORDER!"</shout>"*)

### Węzeł `[8]`
Mówca: **Gloria Tory**
> "<shout>"ORDER! ORDER!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I saw Kesaro Kibener standing up from his seat and shouti..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: ""We must finally rewrite the Constitution of Soll and break our chains of the past!""]** — Mówca: **Player**
> ""We must finally rewrite the Constitution of Soll and break our chains of the past!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""We will break the Supreme Court's authority over constit..."*)
  - -> `[45]` (*Player: ""I will break down the obstacles before me!""*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == f..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Despite her efforts, the argument continued for a couple of minutes before everybody took back to their seats and finally went quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Gloria Tory: ""Mr. Kibener, next time when I tell you to do so, either ..."*)

### Węzeł `[11]`
Mówca: **Gloria Tory**
> ""Mr. Kibener, next time when I tell you to do so, either take your seat or leave the hall; so we can proceed with the procedures of this Assembly and continue our duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Some MP's from the NFP side shouted back at her in protest."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "He murmured something from his seat which was illegible from my position."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""I expect your support in the upcoming vote, Mr. Ricter.""*)
  - -> `[71]` (*Player: ""We will bring change regardless of your support.""*)
  - -> `[75]` (*Player: ""Thank you.""*)
  - -> `[73]` (*Player: ""Your times have passed, Mr. Ricter.""*)

### Węzeł `[13]`
Mówca: **Narrator**
> "Some MP's from the NFP side shouted back at her in protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Gloria Tory: ""Honorable ladies and gentlemen, if you allow me to conti..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""We are not specifically cooperating with someone, but everyone. We ask that you also join us.""]** — Mówca: **Player**
> ""We are not specifically cooperating with someone, but everyone. We ask that you also join us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""Do not stand against change! Be a part of it, Mr. Ricter..."*)
  - -> `[33]` (*Player: ""Don't you dare stand against us! Otherwise, know that th..."*)
  - -> `[22]` (*Player: ""I respect your opinion.""*)
  - -> `[28]` (*Player: ""We don't need you.""*)

### Węzeł `[15]`
Mówca: **Gloria Tory**
> ""Honorable ladies and gentlemen, if you allow me to continue...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "She pointed at me."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "I looked at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: ""It is you, who shouldn't use the word 'democratic' when ..."*)
  - -> `[14]` (*Player: ""We are not specifically cooperating with someone, but ev..."*)
  - -> `[19]` (*Player: ""I'm saddened to hear about your opposite stance.""*)

### Węzeł `[17]`
Mówca: **Gloria Tory**
> ""We have the President here with us today. He has asked to give an important announcement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "The Assembly fell silent."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "I saw Kesaro Kibener standing up from his seat and shouting towards the members of the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Gloria Tory: ""Mr. Kibener! Calm yourself! Show respect to the procedur..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""I'm saddened to hear about your opposite stance.""]** — Mówca: **Player**
> ""I'm saddened to hear about your opposite stance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""Do not stand against change! Be a part of it, Mr. Ricter..."*)
  - -> `[33]` (*Player: ""Don't you dare stand against us! Otherwise, know that th..."*)
  - -> `[22]` (*Player: ""I respect your opinion.""*)
  - -> `[28]` (*Player: ""We don't need you.""*)

### Węzeł `[20]`
Mówca: **Gloria Tory**
> ""Mr. Kibener! Calm yourself! Show respect to the procedures of this Assembly!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Despite her efforts, the argument continued for a couple ..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Response]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "Response"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""I respect your opinion.""]** — Mówca: **Player**
> ""I respect your opinion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Player), `[19]` (Player), `[35]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "He murmured something from his seat which was illegible f..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "She pointed at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Gloria Tory: ""We have the President here with us today. He has asked t..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Thank you, Mrs. Speaker.""]** — Mówca: **Player**
> ""Thank you, Mrs. Speaker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Narrator), `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "I got up from my seat and started my walk towards the exit."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Do not stand against change! Be a part of it, Mr. Ricter! We can do much more together.""]** — Mówca: **Player**
> ""Do not stand against change! Be a part of it, Mr. Ricter! We can do much more together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Player), `[19]` (Player), `[35]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "He murmured something from his seat which was illegible f..."*)

### Węzeł `[26]`
Mówca: **Gloria Tory**
> ""You have the floor, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "I walked to the stand as loud clapping started in the USP..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "The Assembly fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Gloria Tory: ""You have the floor, Mr. President.""*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""We don't need you.""]** — Mówca: **Player**
> ""We don't need you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Player), `[19]` (Player), `[35]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "He murmured something from his seat which was illegible f..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: ""Mr. Ricter...""*)

### Węzeł `[32]`
Mówca: **Narrator**
> "I walked to the stand as loud clapping started in the USP's side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: ""Ladies and Gentlemen...""*)
  - -> `[78]` (*Player: ""Honorable Members of Assembly...""*)
  - -> `[80]` (*Player: ""Brothers and sisters...""*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""Don't you dare stand against us! Otherwise, know that the PFJP is guaranteed to be history.""]** — Mówca: **Player**
> ""Don't you dare stand against us! Otherwise, know that the PFJP is guaranteed to be history.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Player), `[19]` (Player), `[35]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "He murmured something from his seat which was illegible f..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Ladies and Gentlemen...""]** — Mówca: **Player**
> ""Ladies and Gentlemen of the Grand National Assembly of Sordland! I am here today to raise important questions regarding our outdated Constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""The Supreme Court holds too much power...""*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8 == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[92]` (*Player: ""We have always been overshadowed by the Old Guard...""*)

### Węzeł `[35]`
**[WYBÓR GRACZA: ""It is you, who shouldn't use the word 'democratic' when you want your way to succeed but disregard our opinion.""]** — Mówca: **Player**
> ""It is you, who shouldn't use the word 'democratic' when you want your way to succeed but disregard our opinion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""Do not stand against change! Be a part of it, Mr. Ricter..."*)
  - -> `[33]` (*Player: ""Don't you dare stand against us! Otherwise, know that th..."*)
  - -> `[22]` (*Player: ""I respect your opinion.""*)
  - -> `[28]` (*Player: ""We don't need you.""*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""The Supreme Court holds too much power...""]** — Mówca: **Player**
> ""The Supreme Court holds too much power over our elected branches! They have been obstructing the law making process and has long plagued the democracy in Sordland. Tarquin Soll gave this power to the Court for the sole reason to protect the Constitution of the 20's, which leads us to fail in adapting to the new world...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Player), `[78]` (Player), `[80]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower = true;"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Our election threshold has harmed our democracy more than anything...""]** — Mówca: **Player**
> ""Our election threshold has harmed our democracy more than anything since the formation of our republic. As USP, we have governed for a long time and I can acknowledge that this success was partly the result of our current 10% percent threshold.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Kontekst wejściowy (poprzednik):** `[34]` (Player), `[78]` (Player), `[80]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower = true;"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""It is time to strengthen the executive to enact faster and more powerful reforms!""]** — Mówca: **Player**
> ""It is time to strengthen the executive to enact faster and more powerful reforms!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Kontekst wejściowy (poprzednik):** `[34]` (Player), `[78]` (Player), `[80]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive = true;"*)

### Węzeł `[39]`
Mówca: **Narrator**
> "I continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: ""...Therefore, we propose changes to the Constitution to ..."*)
  - -> `[9]` (*Player: ""We must finally rewrite the Constitution of Soll and bre..."*)
  - -> `[95]` (*Player: ""I call everyone to stand by us to make historic changes ..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: ""Mr. Kibener...""*)

### Węzeł `[43]`
**[WYBÓR GRACZA: ""...Therefore, we propose changes to the Constitution to prepare Sordland for a fast changing new world!""]** — Mówca: **Player**
> ""...Therefore, we propose changes to the Constitution to prepare Sordland for a fast changing new world!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""We will break the Supreme Court's authority over constit..."*)
  - -> `[45]` (*Player: ""I will break down the obstacles before me!""*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == f..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""We will break the Supreme Court's authority over constitutional changes.""]** — Mówca: **Player**
> ""We will break the Supreme Court's authority over constitutional changes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Player), `[43]` (Player), `[95]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "I focused on..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""I will break down the obstacles before me!""]** — Mówca: **Player**
> ""I will break down the obstacles before me!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Player), `[43]` (Player), `[95]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "I focused on..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""We will rebalance the branches of government to ensure a more democratic process.""]** — Mówca: **Player**
> ""We will rebalance the branches of government to ensure a more democratic process.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive"] == false`
- **Kontekst wejściowy (poprzednik):** `[9]` (Player), `[43]` (Player), `[95]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "I focused on..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Convinced == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyLoud");"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Just as I was about to continue speaking, Gloria Tory int..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "Unity."]** — Mówca: **Player**
> ""It is more important than ever that we stand united as a nation in these changing times. I call everybody to be part of the change our people has been calling for. We all want to make Sordland better, don't we? Let's embrace democracy and unite under the banner of our people, and surely Sordland will be great again!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[131]` (*Player: ""We will make Sordland great again!""*)
  - -> `[132]` (*Player: ""Let's embrace the future.""*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Loud noises came from USP and NFP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "I took a breath and continued."*)

### Węzeł `[52]`
Mówca: **Gloria Tory**
> ""Mr. President, with all due respect, I believe Sordland already has a functioning Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""Please don't interrupt me.""*)
  - -> `[54]` (*Player: ""I'm not finished yet, Mrs. Tory.""*)
  - -> `[6]` (*Player: ""We both know that our Constitution is flawed.""*)
  - -> `[137]` (*Player: ""You don't believe that.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Please don't interrupt me.""]** — Mówca: **Player**
> ""Please don't interrupt me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Gloria Tory: ""Tarquin Soll and his efforts cannot be ignored. We must ..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""I'm not finished yet, Mrs. Tory.""]** — Mówca: **Player**
> ""I'm not finished yet, Mrs. Tory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Gloria Tory: ""Tarquin Soll and his efforts cannot be ignored. We must ..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Ladies and gentlemen of the Assembly! We must set aside our differences.""]** — Mówca: **Player**
> ""Ladies and gentlemen of the Assembly! We must set aside our differences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: ""Be part of a new era for Sordland. Join us and vote for ..."*)
  - -> `[63]` (*Player: ""I ask everyone to support us in the upcoming vote.""*)
  - -> `[61]` (*Player: ""Ladies and Gentlemen, I demand your votes!""*)

### Węzeł `[56]`
Mówca: **Narrator**
> "I took a breath and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: ""Ladies and gentlemen of the Assembly! We must set aside ..."*)
  - -> `[58]` (*Player: ""It is time to make a new Constitution together!""*)
  - -> `[59]` (*Player: ""I ask everyone to think clearly about our current situat..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Response`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true"*)
  - -> `[24]` (*Player: ""Thank you, Mrs. Speaker.""*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""It is time to make a new Constitution together!""]** — Mówca: **Player**
> ""It is time to make a new Constitution together!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: ""Be part of a new era for Sordland. Join us and vote for ..."*)
  - -> `[63]` (*Player: ""I ask everyone to support us in the upcoming vote.""*)
  - -> `[61]` (*Player: ""Ladies and Gentlemen, I demand your votes!""*)

### Węzeł `[59]`
**[WYBÓR GRACZA: ""I ask everyone to think clearly about our current situation. And join us for change.""]** — Mówca: **Player**
> ""I ask everyone to think clearly about our current situation. And join us for change.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: ""Be part of a new era for Sordland. Join us and vote for ..."*)
  - -> `[63]` (*Player: ""I ask everyone to support us in the upcoming vote.""*)
  - -> `[61]` (*Player: ""Ladies and Gentlemen, I demand your votes!""*)

### Węzeł `[60]`
Mówca: **Narrator**
> "Gloria looked at me to see if I'd finished my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "Jump to: [Response]"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Ladies and Gentlemen, I demand your votes!""]** — Mówca: **Player**
> ""Ladies and Gentlemen, I demand your votes!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Player), `[58]` (Player), `[59]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame...."*)
  - -> `[62]` (*Player: ""Let's write the future together!""*)
  - -> `[65]` (*Player: ""I will address all the problems of the past in my propos..."*)
  - -> `[66]` (*Player: ""USP will change and lead Sordland into the future!""*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""Let's write the future together!""]** — Mówca: **Player**
> ""Let's write the future together!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Player), `[63]` (Player), `[64]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player_Italic: "Salute the crowd."*)
  - -> `[165]` (*Player_Italic: "Finish with a poem."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""I ask everyone to support us in the upcoming vote.""]** — Mówca: **Player**
> ""I ask everyone to support us in the upcoming vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Player), `[58]` (Player), `[59]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame...."*)
  - -> `[62]` (*Player: ""Let's write the future together!""*)
  - -> `[65]` (*Player: ""I will address all the problems of the past in my propos..."*)
  - -> `[66]` (*Player: ""USP will change and lead Sordland into the future!""*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Be part of a new era for Sordland. Join us and vote for our proposal.""]** — Mówca: **Player**
> ""Be part of a new era for Sordland. Join us and vote for our proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Player), `[58]` (Player), `[59]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame...."*)
  - -> `[62]` (*Player: ""Let's write the future together!""*)
  - -> `[65]` (*Player: ""I will address all the problems of the past in my propos..."*)
  - -> `[66]` (*Player: ""USP will change and lead Sordland into the future!""*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""I will address all the problems of the past in my proposal!""]** — Mówca: **Player**
> ""I will address all the problems of the past in my proposal!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Player), `[63]` (Player), `[64]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player_Italic: "Salute the crowd."*)
  - -> `[165]` (*Player_Italic: "Finish with a poem."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""USP will change and lead Sordland into the future!""]** — Mówca: **Player**
> ""USP will change and lead Sordland into the future!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Player), `[63]` (Player), `[64]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player_Italic: "Salute the crowd."*)
  - -> `[165]` (*Player_Italic: "Finish with a poem."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""For justice in Sordland!""]** — Mówca: **Player**
> ""For justice in Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "The Assembly roared with all kinds of different reactions."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Gloria looked at me to see if I'd finished my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "Jump to: [Response]"*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""For a strong Sordland!""]** — Mówca: **Player**
> ""For a strong Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "The Assembly roared with all kinds of different reactions."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: ""For a united Sordland!""]** — Mówca: **Player**
> ""For a united Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "The Assembly roared with all kinds of different reactions."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: ""We will bring change regardless of your support.""]** — Mówca: **Player**
> ""We will bring change regardless of your support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B = true"*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""For a free Sordland!""]** — Mówca: **Player**
> ""For a free Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "The Assembly roared with all kinds of different reactions."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""Your times have passed, Mr. Ricter.""]** — Mówca: **Player**
> ""Your times have passed, Mr. Ricter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B = true"*)

### Węzeł `[74]`
Mówca: **Narrator**
> "The Assembly roared with all kinds of different reactions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B = true"*)

### Węzeł `[76]`
Mówca: **Frens Ricter**
> ""Thank you, Mrs. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Frens Ricter: ""I would like to thank Mr. President for his speech. We, ..."*)

### Węzeł `[77]`
Mówca: **Gloria Tory**
> ""Thank you for the speech, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "I walked back to my seat as many MP's asked to speak. Fre..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""Honorable Members of Assembly...""]** — Mówca: **Player**
> ""Honorable Members of the Grand National Assembly of Sordland! I am here today to raise important questions regarding our outdated Constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""The Supreme Court holds too much power...""*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8 == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[92]` (*Player: ""We have always been overshadowed by the Old Guard...""*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""I expect your support in the upcoming vote, Mr. Ricter.""]** — Mówca: **Player**
> ""I expect your support in the upcoming vote, Mr. Ricter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B = true"*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Brothers and sisters...""]** — Mówca: **Player**
> ""Brothers and sisters! I am here today to raise important questions regarding our outdated Constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""The Supreme Court holds too much power...""*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8 == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[92]` (*Player: ""We have always been overshadowed by the Old Guard...""*)

### Węzeł `[81]`
Mówca: **Kesaro Kibener**
> ""We will stand together with any attempt to protect and strengthen our established political culture and national values. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Kesaro went back to his seat but the chaos in the Assembl..."*)

### Węzeł `[82]`
Mówca: **Frens Ricter**
> ""Thank you, Mrs. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Suddenly Kesaro Kibener started yelling from his seat."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_8 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8 == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_8 == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_8 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""Our election threshold has harmed our democracy more tha..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_8 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Stronger == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""It is time to strengthen the executive to enact faster a..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: ""Our Constitution doesn't adequately define or respect th..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "MP's kept shouting and responding to each other, creating a loud mess where nothing was legible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Gloria Tory: ""Order! Order! This topic has finished. We are moving unt..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""Our Constitution doesn't adequately define or respect the separation of powers...""]** — Mówca: **Player**
> ""Our Constitution doesn't adequately define or respect the separation of powers and the balance between the branches. In order to strengthen our democracy, we must be brave enough to point out the faults of our Constitution.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[34]` (Player), `[78]` (Player), `[80]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SeparationofPowers = true"*)

### Węzeł `[91]`
Mówca: **Gloria Tory**
> ""Order! Order! This topic has finished. We are moving unto our next topic...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""We have always been overshadowed by the Old Guard...""]** — Mówca: **Player**
> ""We have always been overshadowed by the Old Guard and the judiciary branch in Sordland. The Grand National Assembly and the President must be able to exercise their job properly and without obstruction. However, our current Constitution fails to guarantee this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Player), `[78]` (Player), `[80]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard = true;"*)

### Węzeł `[93]`
Mówca: **Frens Ricter**
> ""I ask Mr. President to reevaluate his decision and not ignore the demands of our people! Otherwise you should never use the word 'democratic' again!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Frens Ricter: ""Thank you, Mrs. Speaker.""*)

### Węzeł `[94]`
Mówca: **Narrator**
> "I slowly left the hall. The shouting could be heard from every corridor of the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""I call everyone to stand by us to make historic changes to our Constitution and bring it to the standards of today's world!""]** — Mówca: **Player**
> ""I call everyone to stand by us to make historic changes to our Constitution and bring it to the standards of today's world!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""We will break the Supreme Court's authority over constit..."*)
  - -> `[45]` (*Player: ""I will break down the obstacles before me!""*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == f..."*)

### Węzeł `[96]`
Mówca: **Frens Ricter**
> ""As long as Mr. President continues to follow the footsteps of his party's founder, we will be doing our best to stop this proposal. We do not welcome this attempt to break our system further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Frens Ricter: ""I ask Mr. President to reevaluate his decision and not i..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "I looked at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: ""Thank you for the nice words.""*)
  - -> `[179]` (*Player: ""We'd like to have cooperation between our parties.""*)
  - -> `[178]` (*Player: ""Rest assured, your concerns will be addressed.""*)

### Węzeł `[98]`
Mówca: **Narrator**
> "I got up from my seat and started my walk towards the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "MP's kept shouting and responding to each other, creating..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA: ""I just wanted to thank everybody for their comments.""]** — Mówca: **Player**
> ""I just wanted to thank everybody for their comments.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Gloria Tory: ""Alright, Mr. President.""*)

### Węzeł `[100]`
Mówca: **Narrator**
> "I focused on..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "Unity."*)
  - -> `[104]` (*Player: "Change."*)
  - -> `[105]` (*Player: "Peace."*)
  - -> `[159]` (*Player: "War."*)

### Węzeł `[101]`
Mówca: **Frens Ricter**
> ""However, our demands seemed to be ignored by the government. Even though we made the reform committee's work possible, it was us, who were pushed back from the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[102]`
**[WYBÓR GRACZA: ""Mr. Ricter...""]** — Mówca: **Player**
> ""Mr. Ricter...""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[108]` (Gloria Tory), `[60]` (Narrator), `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "I looked at him."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist -= 10`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "Change."]** — Mówca: **Player**
> ""We must not be afraid of change. The world is changing, and Sordland needs the change it has earned after years of Sollism in the last decades. We will rewrite the old and make a constitution that would reflect the will of the people, and open the way for a democratic Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[131]` (*Player: ""We will make Sordland great again!""*)
  - -> `[132]` (*Player: ""Let's embrace the future.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "Peace."]** — Mówca: **Player**
> ""The '29 Constitution was the product of a time of war. Now is a time for peace. As we must make peace between each other, we must strive for peace in the world. We need a more democratic constitution that would reflect the will of the people, and flourish in the upcoming times of peace and prosper!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[131]` (*Player: ""We will make Sordland great again!""*)
  - -> `[132]` (*Player: ""Let's embrace the future.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""Mr. Kibener...""]** — Mówca: **Player**
> ""Mr. Kibener...""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[108]` (Gloria Tory), `[60]` (Narrator), `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "I looked at him."*)

### Węzeł `[107]`
Mówca: **Frens Ricter**
> ""I would like to thank Mr. President for his speech. We, the People's Freedom and Justice Party, stands in agreement with the need for a new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Frens Ricter: ""However, our demands seemed to be ignored by the governm..."*)

### Węzeł `[108]`
Mówca: **Gloria Tory**
> ""Yes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: ""Mr. Kibener...""*)
  - -> `[102]` (*Player: ""Mr. Ricter...""*)
  - -> `[99]` (*Player: ""I just wanted to thank everybody for their comments.""*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Just as I was about to continue speaking, Gloria Tory interrupted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Gloria Tory: ""Mr. President, with all due respect, I believe Sordland ..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "I got up from my seat and started my walk towards the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "MP's kept shouting and responding to each other, creating..."*)

### Węzeł `[111]`
Mówca: **Kesaro Kibener**
> "<shout>"You and PFJP are nothing but puppets of western interests!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Gloria Tory: "<shout>"ORDER!"</shout>"*)

### Węzeł `[112]`
Mówca: **Narrator**
> "I walked back to my seat as many MP's asked to speak. Frens Ricter was among them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Gloria Tory: ""Yes, Mr. Ricter.""*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Suddenly Kesaro Kibener started yelling from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Kesaro Kibener: "<shout>"You must have lost your mind to claim you were th..."*)

### Węzeł `[114]`
Mówca: **Gloria Tory**
> ""Yes, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Frens Ricter: ""Thank you, Mrs. Speaker.""*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "Ask to speak."]** — Mówca: **Player_Italic**
> "I asked to speak."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Gloria Tory: ""Yes, Mr. President.""*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "Leave the Assembly."]** — Mówca: **Player_Italic**
> "I decided to leave the Assembly and its chaos behind."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I got up from my seat and started my walk towards the exit."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "Gloria looked at me to see if I'd finished my response."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "Kesaro went back to his seat but the chaos in the Assembly continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player_Italic: "Ask to speak."*)
  - -> `[116]` (*Player_Italic: "Leave the Assembly."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist -= 10"*)

### Węzeł `[120]`
Mówca: **Kesaro Kibener**
> ""Mr. President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "He looked directly at me."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: ""Tarquin Soll will answer for the crimes committed during..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Tarquin Soll will answer for the crimes committed during his rule! We will make sure of that!""]** — Mówca: **Player**
> ""Tarquin Soll will answer for the crimes committed during his rule! We will make sure of that!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Kontekst wejściowy (poprzednik):** `[50]` (Player), `[104]` (Player), `[105]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll = true"*)

### Węzeł `[125]`
Mówca: **Narrator**
> "Gloria gave him a stare. She looked annoyed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Gloria Tory: ""...Very well, Mr. Kibener... Go ahead.""*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Stronger == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: ""We will be strengthening the presidential decrees.""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[129]`
**[WYBÓR GRACZA: ""We will be strengthening the presidential decrees.""]** — Mówca: **Player**
> ""We will be strengthening the presidential decrees.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Kontekst wejściowy (poprzednik):** `[50]` (Player), `[104]` (Player), `[105]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_StrongerDecrees = true"*)

### Węzeł `[130]`
Mówca: **Narrator**
> "He looked directly at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Kesaro Kibener: ""The nationalist movement wants to thank Mr. Rayne for hi..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""We will make Sordland great again!""]** — Mówca: **Player**
> ""We will make Sordland great again!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Player), `[104]` (Player), `[105]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""Let's embrace the future.""]** — Mówca: **Player**
> ""Let's embrace the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Player), `[104]` (Player), `[105]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[133]`
Mówca: **Narrator**
> "Some applauses came from the NFP and USP seats. Most of the others started to make loud noises again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Gloria Tory: ""Thank you for the speech, Mr. President.""*)

### Węzeł `[134]`
Mówca: **Kesaro Kibener**
> ""Let it be known that the NFP will do its best to aid with the draft of the new constitution, and to reach an agreement with the USP. If our concerns are listened to, NFP has the power to make this proposal pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Kesaro Kibener: ""We will stand together with any attempt to protect and s..."*)

### Węzeł `[135]`
Mówca: **Kesaro Kibener**
> "<shout>"You must have lost your mind to claim you were the reason for the reform talks, Mr. Ricter!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Kesaro Kibener: "<shout>"You and PFJP are nothing but puppets of western i..."*)

### Węzeł `[136]`
Mówca: **Kesaro Kibener**
> ""The nationalist movement wants to thank Mr. Rayne for his priorities. The National Front Party will not stand in your way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Kesaro Kibener: ""Let it be known that the NFP will do its best to aid wit..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""You don't believe that.""]** — Mówca: **Player**
> ""You don't believe that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Gloria Tory: ""Tarquin Soll and his efforts cannot be ignored. We must ..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "The whole United Sordland Party stood up and started applauding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Gloria Tory: ""Thank you for the speech, Mr. President.""*)

### Węzeł `[139]`
Mówca: **Gloria Tory**
> ""Tarquin Soll and his efforts cannot be ignored. We must keep following the path he defined for Sordish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Gloria Tory: ""I'm sure the Honorable Members of USP will see that the ..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Gloria looked at me to see if I'd finished my response."*)

### Węzeł `[141]`
**[WYBÓR GRACZA: ""We are not here to destroy Sollism nor our cultural values.""]** — Mówca: **Player**
> ""We are not here to destroy Sollism nor our cultural values.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[142]`
Mówca: **Narrator**
> "I slowly left the hall. The shouting could be heard from every corridor of the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[143]`
Mówca: **Gloria Tory**
> ""...Very well, Mr. Kibener... Go ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Kesaro Kibener: ""Mr. President!""*)

### Węzeł `[144]`
Mówca: **Gloria Tory**
> ""I'm sure the Honorable Members of USP will see that the President is acting rash by allying with the opposition to destroy the culture of Sollism that established Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Gloria Tory: ""That was the extent of my quick note. Thank you. The Pre..."*)

### Węzeł `[145]`
Mówca: **Gloria Tory**
> ""Alright, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "MP's kept shouting and responding to each other, creating..."*)

### Węzeł `[146]`
Mówca: **Gloria Tory**
> ""That was the extent of my quick note. Thank you. The President has the floor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""That was disrespectful Mrs. Speaker. Please don't try to..."*)
  - -> `[141]` (*Player: ""We are not here to destroy Sollism nor our cultural valu..."*)
  - -> `[153]` (*Player: ""Who are you trying to provoke, Mrs. Tory? USP is behind ..."*)
  - -> `[157]` (*Player: ""I'll act as if that didn't happen.""*)

### Węzeł `[147]`
Mówca: **Kesaro Kibener**
> ""I demand to speak!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "Gloria gave him a stare. She looked annoyed."*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""That was disrespectful Mrs. Speaker. Please don't try to sabotage my speech.""]** — Mówca: **Player**
> ""That was disrespectful Mrs. Speaker. Please don't try to sabotage my speech.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true && BaseGame.Refo..."*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Convinced == true && BaseGame.Re..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true  and  Variable["BaseGame.Reform_Albin_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplause");"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true  and  Variable["BaseGame.Reform_Albin_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplauseShouting");"*)

### Węzeł `[152]`
Mówca: **Gloria Tory**
> "<shout>"ORDER!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Kesaro Kibener: ""I demand to speak!""*)

### Węzeł `[153]`
**[WYBÓR GRACZA: ""Who are you trying to provoke, Mrs. Tory? USP is behind me.""]** — Mówca: **Player**
> ""Who are you trying to provoke, Mrs. Tory? USP is behind me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Speech_PromisedToTrySoll == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I slowly left the hall. The shouting could be heard from ..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Speech_PromisedToTrySoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "I slowly left the hall. The shouting could be heard from ..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA: ""I'll act as if that didn't happen.""]** — Mówca: **Player**
> ""I'll act as if that didn't happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[158]`
Mówca: **Gloria Tory**
> ""Please continue your speech, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "I took a breath and continued."*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "War."]** — Mówca: **Player**
> ""It is a time of conflict and war. The superpowers of the world are in a race to control the world. Terrorists and rebels around our borders continue to operate. We must be ready for what this new world will throw at us. We must be vigilant! More importantly, Rumburg is threatening our country more than ever. We need a stronger constitution that would strengthen our nation and prepare it for the upcoming times of conflict. And we will prevail!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[131]` (*Player: ""We will make Sordland great again!""*)
  - -> `[132]` (*Player: ""Let's embrace the future.""*)

### Węzeł `[160]`
**[WYBÓR GRACZA: ""Give me the power to make Sordland great again!""]** — Mówca: **Player**
> ""Give me the power to make Sordland great again!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Kontekst wejściowy (poprzednik):** `[61]` (Player), `[63]` (Player), `[64]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player_Italic: "Salute the crowd."*)
  - -> `[165]` (*Player_Italic: "Finish with a poem."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame...."*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGam..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player: ""Give me the power to make Sordland great again!""*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[164]`
**[WYBÓR GRACZA: "Salute the crowd."]** — Mówca: **Player_Italic**
> "I saluted the crowd."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Player), `[65]` (Player), `[66]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""For justice in Sordland!""*)
  - -> `[69]` (*Player: ""For a strong Sordland!""*)
  - -> `[70]` (*Player: ""For a united Sordland!""*)
  - -> `[72]` (*Player: ""For a free Sordland!""*)

### Węzeł `[165]`
**[WYBÓR GRACZA: "Finish with a poem."]** — Mówca: **Player_Italic**
> "I decided to read a poem before I ended my speech."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Player), `[65]` (Player), `[66]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player: ""There is a destiny above destiny...""*)
  - -> `[167]` (*Player: ""There is a victory growing with every morning...""*)

### Węzeł `[166]`
**[WYBÓR GRACZA: ""There is a destiny above destiny...""]** — Mówca: **Player**
> ""There is a destiny above destiny...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""There is a revolution, beyond our and their existence...""*)
  - -> `[170]` (*Player: ""There is God, beyond existence and nonexistence...""*)
  - -> `[168]` (*Player: ""There is my country, beyond my existence or nonexistence..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA: ""There is a victory growing with every morning...""]** — Mówca: **Player**
> ""There is a victory growing with every morning...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""There is a revolution, beyond our and their existence...""*)
  - -> `[170]` (*Player: ""There is God, beyond existence and nonexistence...""*)
  - -> `[168]` (*Player: ""There is my country, beyond my existence or nonexistence..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA: ""There is my country, beyond my existence or nonexistence...""]** — Mówca: **Player**
> ""There is my country, beyond my existence or nonexistence...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Player), `[167]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: ""There are songs to be sung in affectation of our battles..."*)
  - -> `[173]` (*Player: ""There is a spring that blossoms out of the graves of our..."*)
  - -> `[171]` (*Player: ""There is the evil that tortures and tears me down...""*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""There is a revolution, beyond our and their existence...""]** — Mówca: **Player**
> ""There is a revolution, beyond our and their existence...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Player), `[167]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: ""There are songs to be sung in affectation of our battles..."*)
  - -> `[173]` (*Player: ""There is a spring that blossoms out of the graves of our..."*)
  - -> `[171]` (*Player: ""There is the evil that tortures and tears me down...""*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""There is God, beyond existence and nonexistence...""]** — Mówca: **Player**
> ""There is God, beyond existence and nonexistence...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Player), `[167]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: ""There are songs to be sung in affectation of our battles..."*)
  - -> `[173]` (*Player: ""There is a spring that blossoms out of the graves of our..."*)
  - -> `[171]` (*Player: ""There is the evil that tortures and tears me down...""*)

### Węzeł `[171]`
**[WYBÓR GRACZA: ""There is the evil that tortures and tears me down...""]** — Mówca: **Player**
> ""There is the evil that tortures and tears me down...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Player), `[169]` (Player), `[170]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player: ""Do not doubt the One! There is a decision coming from th..."*)
  - -> `[175]` (*Player: ""Fear not when the dark falls! There is an artist paintin..."*)
  - -> `[176]` (*Player: ""Do not dare call it defeat! There is a fortress made fro..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA: ""There are songs to be sung in affectation of our battles...""]** — Mówca: **Player**
> ""There are songs to be sung in affectation of our battles...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Player), `[169]` (Player), `[170]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player: ""Do not doubt the One! There is a decision coming from th..."*)
  - -> `[175]` (*Player: ""Fear not when the dark falls! There is an artist paintin..."*)
  - -> `[176]` (*Player: ""Do not dare call it defeat! There is a fortress made fro..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA: ""There is a spring that blossoms out of the graves of our fallen...""]** — Mówca: **Player**
> ""There is a spring that blossoms out of the graves of our fallen...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Player), `[169]` (Player), `[170]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player: ""Do not doubt the One! There is a decision coming from th..."*)
  - -> `[175]` (*Player: ""Fear not when the dark falls! There is an artist paintin..."*)
  - -> `[176]` (*Player: ""Do not dare call it defeat! There is a fortress made fro..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA: ""Do not doubt the One! There is a decision coming from the heavens...""]** — Mówca: **Player**
> ""Do not doubt the One! There is a decision coming from the heavens...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Player), `[172]` (Player), `[173]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: ""Beyond the next morning, there is a victory waiting to b..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA: ""Fear not when the dark falls! There is an artist painting the sun.""]** — Mówca: **Player**
> ""Fear not when the dark falls! There is an artist painting the sun.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Player), `[172]` (Player), `[173]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: ""Beyond the next morning, there is a victory waiting to b..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: ""Do not dare call it defeat! There is a fortress made from my ashes.""]** — Mówca: **Player**
> ""Do not dare call it defeat! There is a fortress made from my ashes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Player), `[172]` (Player), `[173]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: ""Beyond the next morning, there is a victory waiting to b..."*)

### Węzeł `[177]`
**[WYBÓR GRACZA: ""Beyond the next morning, there is a victory waiting to be won.""]** — Mówca: **Player**
> ""Beyond the next morning, there is a victory waiting to be won.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Player), `[175]` (Player), `[176]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "The Assembly roared with all kinds of different reactions."*)

### Węzeł `[178]`
**[WYBÓR GRACZA: ""Rest assured, your concerns will be addressed.""]** — Mówca: **Player**
> ""Rest assured, your concerns will be addressed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player: ""I expect your support, Mr. Kibener! We can do much more ..."*)
  - -> `[181]` (*Player: ""Thank you for your support. We are looking forward to wo..."*)
  - -> `[180]` (*Player: ""I welcome your positive attitude.""*)

### Węzeł `[179]`
**[WYBÓR GRACZA: ""We'd like to have cooperation between our parties.""]** — Mówca: **Player**
> ""We'd like to have cooperation between our parties.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player: ""I expect your support, Mr. Kibener! We can do much more ..."*)
  - -> `[181]` (*Player: ""Thank you for your support. We are looking forward to wo..."*)
  - -> `[180]` (*Player: ""I welcome your positive attitude.""*)

### Węzeł `[180]`
**[WYBÓR GRACZA: ""I welcome your positive attitude.""]** — Mówca: **Player**
> ""I welcome your positive attitude.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Player), `[179]` (Player), `[182]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A = true"*)

### Węzeł `[181]`
**[WYBÓR GRACZA: ""Thank you for your support. We are looking forward to work with the NFP.""]** — Mówca: **Player**
> ""Thank you for your support. We are looking forward to work with the NFP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Player), `[179]` (Player), `[182]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A = true"*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""Thank you for the nice words.""]** — Mówca: **Player**
> ""Thank you for the nice words.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player: ""I expect your support, Mr. Kibener! We can do much more ..."*)
  - -> `[181]` (*Player: ""Thank you for your support. We are looking forward to wo..."*)
  - -> `[180]` (*Player: ""I welcome your positive attitude.""*)

### Węzeł `[183]`
**[WYBÓR GRACZA: ""I expect your support, Mr. Kibener! We can do much more together.""]** — Mówca: **Player**
> ""I expect your support, Mr. Kibener! We can do much more together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Player), `[179]` (Player), `[182]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A = true"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Response]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "Response"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == true || BaseGame.Reform_Gloria_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true || BaseGame.Refor..."*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Convinced == true || BaseGame.Ref..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == true || BaseGame.Reform_Gloria_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == true  or  Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Gloria..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Convinced == true || BaseGame.Reform_Gloria_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == true  or  Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None =..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == true && BaseGame.Reform_Gloria_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true && BaseGame.Refor..."*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Convinced == true && BaseGame.Ref..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == true && BaseGame.Reform_Gloria_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both =..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Convinced == true && BaseGame.Reform_Gloria_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true || BaseGame.Refor..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_GloriaAlbin = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_GloriaAlbin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_TradeDeal == true)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Uziren_BorderReport = true"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true && BaseGame.Refor..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Uziren_BorderReport = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Uziren_BorderReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true && BaseGame.Refor..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_StrongerDecrees == true"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy = true"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_G_WalkerWarnsNavy = true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_G_WalkerWarnsNavy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_WalkerWarnsNavy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_StrongerDecrees == true"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "I continued."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "I continued."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "I continued."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_SeparationofPowers = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SeparationofPowers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "I continued."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "I continued."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_StrongerDecrees = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_StrongerDecrees"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_A_Speech = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_A_Speech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_StrongerDecrees == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_StrongerDecrees == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Speech_StrongerDecrees == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_StrongerDecrees == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_StrongerDecrees"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_LT_StrongerDecrees_D = true"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Speech_StrongerDecrees == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_StrongerDecrees"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed ..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_LT_StrongerDecrees_D = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_StrongerDecrees_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed ..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed ..."*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarme..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_ElectionThreshold_D = true"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_ElectionThreshold_D = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_ElectionThreshold_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true"*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == t..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_OvershadowedByOldGuard_D =..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_OvershadowedByOldGuard_D = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_OvershadowedByOldGuard_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == ..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SeparationofPowers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_ConstitutionNotAdequate_D ..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_SeparationofPowers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == true"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_ConstitutionNotAdequate_D = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_ConstitutionNotAdequate_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == true"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == true"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive ==..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_StrongerExecutive_D = true"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_StrongerExecutive_D = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_StrongerExecutive_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true"*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == t..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_SCTooMuchPower_D = true"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_SCTooMuchPower_D = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_SCTooMuchPower_D"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Speech_PromisedToTrySoll == true)"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_R_PromisedToTrySoll = true"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Speech_PromisedToTrySoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Med..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_R_PromisedToTrySoll = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_R_PromisedToTrySoll"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Med..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Media_SordlandToday_Bias == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Med..."*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Speech_PromisedToTrySoll == true && BaseGame.M..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Media_SordlandToday_Bias == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal =..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Media_SordlandToday_Bias == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_A_Speech = true"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_A_Speech = true"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 3;
BaseGame.Bludish_Opinion += 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Speech_PromisedToTrySoll == true)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 3; BaseGame.Bludish_Opinion += 5;"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Speech_PromisedToTrySoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == f..."*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive ==..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""We will rebalance the branches of government to ensure a..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_StrengthenExecutive"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Speech_PromisedToTrySoll == true )"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Gloria Tory: ""You've just promised to try Soll, Mr. President! You are..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Speech_PromisedToTrySoll == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Gloria Tory: ""Please continue your speech, Mr. President.""*)

### Węzeł `[252]`
Mówca: **Gloria Tory**
> ""You've just promised to try Soll, Mr. President! You are talking about the founder of this party. He is the true founder of this republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Gloria Tory: ""What crimes are you talking about? You owe everything yo..."*)

### Węzeł `[253]`
Mówca: **Gloria Tory**
> ""What crimes are you talking about? You owe everything you have to him. This is unacceptable!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyLoud");"*)

### Węzeł `[254]`
Mówca: **Narrator**
> "Loud noises came from USP and NFP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Player: ""Everyone! Please! Let me finish.""*)
  - -> `[255]` (*Player: ""Hear me out.""*)
  - -> `[257]` (*Player: ""Let me explain.""*)

### Węzeł `[255]`
**[WYBÓR GRACZA: ""Hear me out.""]** — Mówca: **Player**
> ""Hear me out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "I took a breath and continued."*)

### Węzeł `[256]`
**[WYBÓR GRACZA: ""Everyone! Please! Let me finish.""]** — Mówca: **Player**
> ""Everyone! Please! Let me finish.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "I took a breath and continued."*)

### Węzeł `[257]`
**[WYBÓR GRACZA: ""Let me explain.""]** — Mówca: **Player**
> ""Let me explain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "I took a breath and continued."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Speech_PromisedToTrySoll == true )"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("VoteRoar");"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Speech_PromisedToTrySoll == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true && BaseGame.Refo..."*)

### Węzeł `[261]`
Mówca: **Narrator**
> "The whole United Sordland Party stood up and started shouting at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Gloria Tory: ""Your time is over. Please sit down, Mr. President.""*)

### Węzeł `[262]`
Mówca: **Gloria Tory**
> ""Your time is over. Please sit down, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "I walked back to my seat as many MP's asked to speak. Fre..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Speech_PromisedToTrySoll == true )"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Frens Ricter: ""Despite Mr. President here claiming to serve justice by ..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Speech_PromisedToTrySoll == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Frens Ricter: ""As long as Mr. President continues to follow the footste..."*)

### Węzeł `[266]`
Mówca: **Frens Ricter**
> ""Despite Mr. President here claiming to serve justice by going against his party's founder, we know this to be some hogwash! Know that we will be doing our best to stop this proposal. We do not welcome this attempt to break our system further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Frens Ricter: ""I ask Mr. President to reevaluate his decision and not i..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyShouting");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyShouting");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "When I entered the hall, the Assembly was in complete cha..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyLoud");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyLoud");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Loud noises came from USP and NFP seats."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyLoud");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyLoud");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "Loud noises came from USP and NFP seats."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("VoteRoar");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("VoteRoar");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "The whole United Sordland Party stood up and started shou..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplause");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplause");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "The whole United Sordland Party stood up and started appl..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplauseShouting");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplauseShouting");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "Some applauses came from the NFP and USP seats. Most of t..."*)
