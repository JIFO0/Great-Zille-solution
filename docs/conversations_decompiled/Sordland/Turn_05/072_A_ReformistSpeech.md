# Sordland/Turn05/A_ReformistSpeech

- **ID konwersacji:** `72`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/072_A_ReformistSpeech.md`
- **Liczba węzłów dialogowych:** 266
- **Liczba wyborów gracza:** 82

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
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Law_TermLimits_2`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Threshold_8`
- `BaseGame.Speech_PromisedToTrySoll`
- `BaseGame.Wehlen_TradeDeal`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B`
- `BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed`
- `BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard`
- `BaseGameIsolated.Turn05_A_Speech_PresidentTooPower`
- `BaseGameIsolated.Turn05_A_Speech_RemoveDecrees`
- `BaseGameIsolated.Turn05_A_Speech_SeparationofPowers`
- `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Public_Opinion`
- `BaseGame.Sollist`
- `BaseGame.Speech_PromisedToTrySoll`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A`
- `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B`
- `BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed`
- `BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard`
- `BaseGameIsolated.Turn05_A_Speech_PresidentTooPower`
- `BaseGameIsolated.Turn05_A_Speech_RemoveDecrees`
- `BaseGameIsolated.Turn05_A_Speech_SeparationofPowers`
- `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower`
- `BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy`
- `BaseGameSupport.News_Turn05_G_WalkerWarnsNavy`
- `BaseGameSupport.News_Turn05_HP_AssemblyOvershadowed_R`
- `BaseGameSupport.News_Turn05_HP_ConstitutionNotAdequate_R`
- `BaseGameSupport.News_Turn05_HP_ElectionThreshold_R`
- `BaseGameSupport.News_Turn05_HP_PresidentTooPowerful_R`
- `BaseGameSupport.News_Turn05_LT_RemoveDecrees_R`
- `BaseGameSupport.News_Turn05_R_PromisedToTrySoll`
- `BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal`
- `BaseGameSupport.News_Turn05_ST_SCTooMuchPower_R`
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
| `[19]` | **""Ladies and Gentlemen...""** | `[18]` **Narrator**: "I walked to the stand as loud cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Player**: ""The Supreme Court holds too muc..."<br>`[62]` **Player**: ""Our elected Assembly has always..."<br>*(oraz 3 innych odgałęzień)* |
| `[20]` | **""The Supreme Court holds too much power...""** | `[19]` **Player**: ""Ladies and Gentlemen of the Gra..."<br>`[53]` **Player**: ""Honorable Members of the Grand ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPo...` | `[23]` **Narrator**: "I continued." |
| `[21]` | **""Our election threshold has harmed our democracy more than anything...""** | `[19]` **Player**: ""Ladies and Gentlemen of the Gra..."<br>`[53]` **Player**: ""Honorable Members of the Grand ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true` | `Variable["BaseGameIsolated.Turn05_A_Speech_ElectionThresh...` | `[23]` **Narrator**: "I continued." |
| `[22]` | **""Perhaps it's not expected of me to say this, but the President holds too much aut..."** | `[19]` **Player**: ""Ladies and Gentlemen of the Gra..."<br>`[53]` **Player**: ""Honorable Members of the Grand ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Law_Decrees_Default"] == false  and  Variable["BaseGame.Reform_Law_TermLimits_2"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false` | `Variable["BaseGameIsolated.Turn05_A_Speech_PresidentTooPo...` | `[23]` **Narrator**: "I continued." |
| `[24]` | **""...Therefore, we propose changes to the Constitution to prepare Sordland for a mo..."** | `[23]` **Narrator**: "I continued." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyApplause");` | `[67]` **Narrator**: "Applauses came from USP and PFJP..." |
| `[25]` | **""We will break the Supreme Court's authority over constitutional changes.""** | `[65]` **Narrator**: "Loud applauses came from PFJP se..."<br>`[66]` **Narrator**: "Applauses came from USP and PFJP..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Narrator**: "I focused on..." |
| `[26]` | **""We will fix the loopholes that allows the presidents to exercise absolute veto ov..."** | `[65]` **Narrator**: "Loud applauses came from PFJP se..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Narrator**: "I focused on..." |
| `[27]` | **""We will rebalance the branches of government to ensure a more democratic process.""** | `[65]` **Narrator**: "Loud applauses came from PFJP se..."<br>`[66]` **Narrator**: "Applauses came from USP and PFJP..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Narrator**: "I focused on..." |
| `[31]` | **"Unity."** | `[68]` **Narrator**: "I focused on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Player**: ""We will make Sordland great aga..."<br>`[83]` **Player**: ""Let's embrace the future.""<br>*(oraz 2 innych odgałęzień)* |
| `[34]` | **""Please don't interrupt me.""** | `[33]` **Gloria Tory**: ""Mr. President, with all due res..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Gloria Tory**: ""Tarquin Soll and his efforts ca..." |
| `[35]` | **""I'm not finished yet, Mrs. Tory.""** | `[33]` **Gloria Tory**: ""Mr. President, with all due res..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Gloria Tory**: ""Tarquin Soll and his efforts ca..." |
| `[36]` | **""Ladies and gentlemen of the Assembly! We must set aside our differences.""** | `[37]` **Narrator**: "I took a breath and continued." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Player**: ""Be part of a new era for Sordla..."<br>`[42]` **Player**: ""I ask everyone to support us in..."<br>*(oraz 1 innych odgałęzień)* |
| `[38]` | **""It is time to make a new Constitution together!""** | `[37]` **Narrator**: "I took a breath and continued." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Player**: ""Be part of a new era for Sordla..."<br>`[42]` **Player**: ""I ask everyone to support us in..."<br>*(oraz 1 innych odgałęzień)* |
| `[39]` | **""I ask everyone to think clearly about our current situation. And join us for chan..."** | `[37]` **Narrator**: "I took a breath and continued." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Player**: ""Be part of a new era for Sordla..."<br>`[42]` **Player**: ""I ask everyone to support us in..."<br>*(oraz 1 innych odgałęzień)* |
| `[40]` | **""Ladies and Gentlemen, I demand your votes!""** | `[36]` **Player**: ""Ladies and gentlemen of the Ass..."<br>`[38]` **Player**: ""It is time to make a new Consti..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Player**: ""Let's write the future together!""<br>`[44]` **Player**: ""I will address all the problems..."<br>*(oraz 1 innych odgałęzień)* |
| `[41]` | **""Let's write the future together!""** | `[40]` **Player**: ""Ladies and Gentlemen, I demand ..."<br>`[42]` **Player**: ""I ask everyone to support us in..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Player_Italic**: "I saluted the crowd."<br>`[174]` **Player_Italic**: "I decided to read a poem before ..." |
| `[42]` | **""I ask everyone to support us in the upcoming vote.""** | `[36]` **Player**: ""Ladies and gentlemen of the Ass..."<br>`[38]` **Player**: ""It is time to make a new Consti..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Player**: ""Let's write the future together!""<br>`[44]` **Player**: ""I will address all the problems..."<br>*(oraz 1 innych odgałęzień)* |
| `[43]` | **""Be part of a new era for Sordland. Join us and vote for our proposal.""** | `[36]` **Player**: ""Ladies and gentlemen of the Ass..."<br>`[38]` **Player**: ""It is time to make a new Consti..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Player**: ""Let's write the future together!""<br>`[44]` **Player**: ""I will address all the problems..."<br>*(oraz 1 innych odgałęzień)* |
| `[44]` | **""I will address all the problems of the past in my proposal!""** | `[40]` **Player**: ""Ladies and Gentlemen, I demand ..."<br>`[42]` **Player**: ""I ask everyone to support us in..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Player_Italic**: "I saluted the crowd."<br>`[174]` **Player_Italic**: "I decided to read a poem before ..." |
| `[45]` | **""USP will change and lead Sordland into the future!""** | `[40]` **Player**: ""Ladies and Gentlemen, I demand ..."<br>`[42]` **Player**: ""I ask everyone to support us in..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Player_Italic**: "I saluted the crowd."<br>`[174]` **Player_Italic**: "I decided to read a poem before ..." |
| `[46]` | **""For justice in Sordland!""** | `[167]` **Player_Italic**: "I saluted the crowd." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Narrator**: "The Assembly roared with all kin..." |
| `[47]` | **""For a democratic Sordland!""** | `[167]` **Player_Italic**: "I saluted the crowd." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Narrator**: "The Assembly roared with all kin..." |
| `[48]` | **""For a united Sordland!""** | `[167]` **Player_Italic**: "I saluted the crowd." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Narrator**: "The Assembly roared with all kin..." |
| `[49]` | **""For a free Sordland!""** | `[167]` **Player_Italic**: "I saluted the crowd." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Narrator**: "The Assembly roared with all kin..." |
| `[53]` | **""Honorable Members of Assembly...""** | `[18]` **Narrator**: "I walked to the stand as loud cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Player**: ""The Supreme Court holds too muc..."<br>`[62]` **Player**: ""Our elected Assembly has always..."<br>*(oraz 3 innych odgałęzień)* |
| `[54]` | **""Brothers and sisters...""** | `[18]` **Narrator**: "I walked to the stand as loud cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Player**: ""The Supreme Court holds too muc..."<br>`[62]` **Player**: ""Our elected Assembly has always..."<br>*(oraz 3 innych odgałęzień)* |
| `[61]` | **""Our Constitution doesn't adequately define or respect the separation of powers...""** | `[19]` **Player**: ""Ladies and Gentlemen of the Gra..."<br>`[53]` **Player**: ""Honorable Members of the Grand ..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Reform_Law_Decrees_Default"] == false  and  Variable["BaseGame.Reform_Law_TermLimits_2"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false` | `Variable["BaseGameIsolated.Turn05_A_Speech_SeparationofPo...` | `[23]` **Narrator**: "I continued." |
| `[62]` | **""Our elected Assembly has always been overshadowed...""** | `[19]` **Player**: ""Ladies and Gentlemen of the Gra..."<br>`[53]` **Player**: ""Honorable Members of the Grand ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Speech_OvershadowedGu...` | `[23]` **Narrator**: "I continued." |
| `[63]` | **""We must finally rewrite the Constitution of Soll and break our chains of the past!""** | `[23]` **Narrator**: "I continued." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyApplause");` | `[65]` **Narrator**: "Loud applauses came from PFJP se..." |
| `[64]` | **""I call everyone to stand by us to make historic changes to our Constitution and b..."** | `[23]` **Narrator**: "I continued." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyApplause");` | `[66]` **Narrator**: "Applauses came from USP and PFJP..." |
| `[69]` | **"Change."** | `[68]` **Narrator**: "I focused on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Player**: ""We will make Sordland great aga..."<br>`[83]` **Player**: ""Let's embrace the future.""<br>*(oraz 2 innych odgałęzień)* |
| `[70]` | **"Peace."** | `[68]` **Narrator**: "I focused on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Player**: ""We will make Sordland great aga..."<br>`[83]` **Player**: ""Let's embrace the future.""<br>*(oraz 2 innych odgałęzień)* |
| `[77]` | **""Tarquin Soll will answer for the crimes committed during his rule! We will make s..."** | `[31]` **Player**: ""It is more important than ever ..."<br>`[69]` **Player**: ""We must not be afraid of change..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true` | `Variable["BaseGame.Speech_PromisedToTrySoll"] = true;`<br>`Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist...`<br>*(+1 skryptów)* | `[71]` **Narrator**: "Just as I was about to continue ..."<br>`[32]` **Narrator**: "Loud noises came from USP and NF..." |
| `[81]` | **""We will be removing the presidential decrees and leave lawmaking to the Assembly.""** | `[31]` **Player**: ""It is more important than ever ..."<br>`[69]` **Player**: ""We must not be afraid of change..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true` | `Variable["BaseGameIsolated.Turn05_A_Speech_RemoveDecrees"...`<br>`PlaySoundEffect("AssemblyLoud");` | `[71]` **Narrator**: "Just as I was about to continue ..."<br>`[32]` **Narrator**: "Loud noises came from USP and NF..." |
| `[82]` | **""We will make Sordland great again!""** | `[31]` **Player**: ""It is more important than ever ..."<br>`[69]` **Player**: ""We must not be afraid of change..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyLoud");` | `[71]` **Narrator**: "Just as I was about to continue ..."<br>`[32]` **Narrator**: "Loud noises came from USP and NF..." |
| `[83]` | **""Let's embrace the future.""** | `[31]` **Player**: ""It is more important than ever ..."<br>`[69]` **Player**: ""We must not be afraid of change..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("AssemblyLoud");` | `[71]` **Narrator**: "Just as I was about to continue ..."<br>`[32]` **Narrator**: "Loud noises came from USP and NF..." |
| `[84]` | **""We both know that our Constitution is flawed.""** | `[33]` **Gloria Tory**: ""Mr. President, with all due res..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Gloria Tory**: ""Tarquin Soll and his efforts ca..." |
| `[85]` | **""You don't believe that.""** | `[33]` **Gloria Tory**: ""Mr. President, with all due res..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Gloria Tory**: ""Tarquin Soll and his efforts ca..." |
| `[115]` | **"Leave the Assembly."** | `[114]` **Narrator**: "Kesaro went back to his seat but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Narrator**: "I got up from my seat and starte..." |
| `[116]` | **"Ask to speak."** | `[114]` **Narrator**: "Kesaro went back to his seat but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Gloria Tory**: ""Yes, Mr. President."" |
| `[119]` | **""Mr. Kibener...""** | `[118]` **Gloria Tory**: ""Yes, Mr. President.""<br>`[135]` **Narrator**: "Gloria looked at me to see if I'..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] == true) == false` | *Brak zmian stanu* | `[122]` **Narrator**: "I looked at him." |
| `[120]` | **""Mr. Ricter...""** | `[118]` **Gloria Tory**: ""Yes, Mr. President.""<br>`[135]` **Narrator**: "Gloria looked at me to see if I'..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] == true) == false` | *Brak zmian stanu* | `[146]` **Narrator**: "I looked at him." |
| `[121]` | **""I just wanted to thank everybody for their comments.""** | `[118]` **Gloria Tory**: ""Yes, Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Gloria Tory**: ""Alright, Mr. President."" |
| `[123]` | **""It is you, who shouldn't use the word 'democratic' when you want a more centraliz..."** | `[122]` **Narrator**: "I looked at him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Narrator**: "He watched as he slouched on his..." |
| `[124]` | **""We are not specifically cooperating with someone, but everyone. We ask that you a..."** | `[122]` **Narrator**: "I looked at him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Narrator**: "He watched as he slouched on his..." |
| `[125]` | **""I'm saddened to hear about your opposite stance.""** | `[122]` **Narrator**: "I looked at him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Narrator**: "He watched as he slouched on his..." |
| `[127]` | **""Do not stand against change! Be a part of it, Mr. Kibener! We can do much more to..."** | `[126]` **Narrator**: "He watched as he slouched on his..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Player**: ""I expect your support in the up..."<br>`[132]` **Player**: ""We will bring change regardless..."<br>*(oraz 2 innych odgałęzień)* |
| `[128]` | **""Don't you dare stand against us! Otherwise, know that the NFP is guaranteed to be..."** | `[126]` **Narrator**: "He watched as he slouched on his..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Player**: ""I expect your support in the up..."<br>`[132]` **Player**: ""We will bring change regardless..."<br>*(oraz 2 innych odgałęzień)* |
| `[129]` | **""I respect your opinion.""** | `[126]` **Narrator**: "He watched as he slouched on his..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Player**: ""I expect your support in the up..."<br>`[132]` **Player**: ""We will bring change regardless..."<br>*(oraz 2 innych odgałęzień)* |
| `[130]` | **""We don't need you.""** | `[126]` **Narrator**: "He watched as he slouched on his..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Player**: ""I expect your support in the up..."<br>`[132]` **Player**: ""We will bring change regardless..."<br>*(oraz 2 innych odgałęzień)* |
| `[131]` | **""I expect your support in the upcoming vote, Mr. Kibener.""** | `[127]` **Player**: ""Do not stand against change! Be..."<br>`[128]` **Player**: ""Don't you dare stand against us..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub...` | `[135]` **Narrator**: "Gloria looked at me to see if I'..." |
| `[132]` | **""We will bring change regardless of your support.""** | `[127]` **Player**: ""Do not stand against change! Be..."<br>`[128]` **Player**: ""Don't you dare stand against us..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub...` | `[135]` **Narrator**: "Gloria looked at me to see if I'..." |
| `[133]` | **""Thank you.""** | `[127]` **Player**: ""Do not stand against change! Be..."<br>`[128]` **Player**: ""Don't you dare stand against us..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub...` | `[135]` **Narrator**: "Gloria looked at me to see if I'..." |
| `[134]` | **""Your times have passed, Mr. Kibener.""** | `[127]` **Player**: ""Do not stand against change! Be..."<br>`[128]` **Player**: ""Don't you dare stand against us..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub...` | `[135]` **Narrator**: "Gloria looked at me to see if I'..." |
| `[143]` | **""Thank you, Mrs. Speaker.""** | `[135]` **Narrator**: "Gloria looked at me to see if I'..."<br>`[153]` **Narrator**: "Gloria looked at me to see if I'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Narrator**: "I got up from my seat and starte..." |
| `[145]` | **""Rest assured, your concerns will be addressed.""** | `[146]` **Narrator**: "I looked at him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Player**: ""I expect your support, Mr. Rict..."<br>`[151]` **Player**: ""Thank you for your support. We ..."<br>*(oraz 1 innych odgałęzień)* |
| `[147]` | **""We'd like to have cooperation between our parties.""** | `[146]` **Narrator**: "I looked at him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Player**: ""I expect your support, Mr. Rict..."<br>`[151]` **Player**: ""Thank you for your support. We ..."<br>*(oraz 1 innych odgałęzień)* |
| `[149]` | **""I welcome your positive attitude.""** | `[145]` **Player**: ""Rest assured, your concerns wil..."<br>`[147]` **Player**: ""We'd like to have cooperation b..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub...` | `[153]` **Narrator**: "Gloria looked at me to see if I'..." |
| `[150]` | **""I expect your support, Mr. Ricter! We can do much more together.""** | `[145]` **Player**: ""Rest assured, your concerns wil..."<br>`[147]` **Player**: ""We'd like to have cooperation b..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub...` | `[153]` **Narrator**: "Gloria looked at me to see if I'..." |
| `[151]` | **""Thank you for your support. We are looking forward to work with the PFJP.""** | `[145]` **Player**: ""Rest assured, your concerns wil..."<br>`[147]` **Player**: ""We'd like to have cooperation b..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub...` | `[153]` **Narrator**: "Gloria looked at me to see if I'..." |
| `[152]` | **""Thank you for the nice words.""** | `[146]` **Narrator**: "I looked at him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Player**: ""I expect your support, Mr. Rict..."<br>`[151]` **Player**: ""Thank you for your support. We ..."<br>*(oraz 1 innych odgałęzień)* |
| `[166]` | **""There is a victory growing with every morning...""** | `[174]` **Player_Italic**: "I decided to read a poem before ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Player**: ""There is a revolution that's co..."<br>`[169]` **Player**: ""There is God beyond existence o..."<br>*(oraz 1 innych odgałęzień)* |
| `[167]` | **"Salute the crowd."** | `[41]` **Player**: ""Let's write the future together!""<br>`[44]` **Player**: ""I will address all the problems..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Player**: ""For justice in Sordland!""<br>`[47]` **Player**: ""For a democratic Sordland!""<br>*(oraz 2 innych odgałęzień)* |
| `[168]` | **""There is my country beyond everything, my beloved...""** | `[166]` **Player**: ""There is a victory growing with..."<br>`[173]` **Player**: ""There is a destiny above destin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Player**: ""There are songs to be sung in a..."<br>`[172]` **Player**: ""There is a spring that blossoms..."<br>*(oraz 1 innych odgałęzień)* |
| `[169]` | **""There is God beyond existence or nonexistence...""** | `[166]` **Player**: ""There is a victory growing with..."<br>`[173]` **Player**: ""There is a destiny above destin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Player**: ""There are songs to be sung in a..."<br>`[172]` **Player**: ""There is a spring that blossoms..."<br>*(oraz 1 innych odgałęzień)* |
| `[170]` | **""Fear not when the dark falls! There is an artist painting the sun.""** | `[172]` **Player**: ""There is a spring that blossoms..."<br>`[176]` **Player**: ""There are songs to be sung in a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Player**: ""Beyond the next morning, there ..." |
| `[171]` | **""Beyond the next morning, there is a victory waiting to be won.""** | `[170]` **Player**: ""Fear not when the dark falls! T..."<br>`[175]` **Player**: ""Do not dare to surrender! There..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Narrator**: "The Assembly roared with all kin..." |
| `[172]` | **""There is a spring that blossoms out of the graves of our fallen...""** | `[168]` **Player**: ""There is my country beyond ever..."<br>`[169]` **Player**: ""There is God beyond existence o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Player**: ""Do not doubt the One! There is ..."<br>`[170]` **Player**: ""Fear not when the dark falls! T..."<br>*(oraz 1 innych odgałęzień)* |
| `[173]` | **""There is a destiny above destiny...""** | `[174]` **Player_Italic**: "I decided to read a poem before ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Player**: ""There is a revolution that's co..."<br>`[169]` **Player**: ""There is God beyond existence o..."<br>*(oraz 1 innych odgałęzień)* |
| `[174]` | **"Finish with a poem."** | `[41]` **Player**: ""Let's write the future together!""<br>`[44]` **Player**: ""I will address all the problems..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Player**: ""There is a destiny above destin..."<br>`[166]` **Player**: ""There is a victory growing with..." |
| `[175]` | **""Do not dare to surrender! There is a victory that grows with defeat.""** | `[172]` **Player**: ""There is a spring that blossoms..."<br>`[176]` **Player**: ""There are songs to be sung in a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Player**: ""Beyond the next morning, there ..." |
| `[176]` | **""There are songs to be sung in affectation of our victories...""** | `[168]` **Player**: ""There is my country beyond ever..."<br>`[169]` **Player**: ""There is God beyond existence o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Player**: ""Do not doubt the One! There is ..."<br>`[170]` **Player**: ""Fear not when the dark falls! T..."<br>*(oraz 1 innych odgałęzień)* |
| `[177]` | **""There is a revolution that's coming...""** | `[166]` **Player**: ""There is a victory growing with..."<br>`[173]` **Player**: ""There is a destiny above destin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Player**: ""There are songs to be sung in a..."<br>`[172]` **Player**: ""There is a spring that blossoms..."<br>*(oraz 1 innych odgałęzień)* |
| `[178]` | **""There is the evil that tortures and tears me down...""** | `[168]` **Player**: ""There is my country beyond ever..."<br>`[169]` **Player**: ""There is God beyond existence o..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Player**: ""Do not doubt the One! There is ..."<br>`[170]` **Player**: ""Fear not when the dark falls! T..."<br>*(oraz 1 innych odgałęzień)* |
| `[179]` | **""Do not doubt the One! There is a decision coming from the heavens...""** | `[172]` **Player**: ""There is a spring that blossoms..."<br>`[176]` **Player**: ""There are songs to be sung in a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Player**: ""Beyond the next morning, there ..." |
| `[237]` | **""I'll act as if that didn't happen.""** | `[88]` **Gloria Tory**: ""That was the extent of my quick..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Gloria Tory**: ""You've just promised to try Sol..."<br>`[249]` **Gloria Tory**: ""Please continue your speech, Mr..." |
| `[238]` | **""Who are you trying to provoke, Mrs. Tory? USP is behind me.""** | `[88]` **Gloria Tory**: ""That was the extent of my quick..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Gloria Tory**: ""You've just promised to try Sol..."<br>`[249]` **Gloria Tory**: ""Please continue your speech, Mr..." |
| `[239]` | **""That was disrespectful Mrs. Speaker. Please don't try to sabotage my speech.""** | `[88]` **Gloria Tory**: ""That was the extent of my quick..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Gloria Tory**: ""You've just promised to try Sol..."<br>`[249]` **Gloria Tory**: ""Please continue your speech, Mr..." |
| `[240]` | **""We are not here to destroy Sollism nor our cultural values.""** | `[88]` **Gloria Tory**: ""That was the extent of my quick..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Gloria Tory**: ""You've just promised to try Sol..."<br>`[249]` **Gloria Tory**: ""Please continue your speech, Mr..." |
| `[247]` | **""Everyone! Please! Let me finish.""** | `[246]` **Narrator**: "Loud noises came from USP and NF..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Narrator**: "I took a breath and continued." |
| `[248]` | **""Hear me out.""** | `[246]` **Narrator**: "Loud noises came from USP and NF..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Narrator**: "I took a breath and continued." |
| `[250]` | **""Let me explain.""** | `[246]` **Narrator**: "Loud noises came from USP and NF..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Narrator**: "I took a breath and continued." |

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
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyShouting");"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "When I entered the hall, the Assembly was in complete chaos, with shouting and cursing between the parties. There was a heavy argument about a proposal made by an MP from NFP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I took my seat inside the special area reserved for the m..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "I took my seat inside the special area reserved for the ministers. Gloria was shouting from her seat at the centre of the hall as she hit the gavel three times, with each strike heavier than the one before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Gloria Tory: "<shout>"ORDER! ORDER!"</shout>"*)

### Węzeł `[7]`
Mówca: **Gloria Tory**
> "<shout>"ORDER! ORDER!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "I saw Kesaro Kibener standing up from his seat and shouti..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Despite her efforts, the argument continued for a couple of minutes before everybody took back to their seats and finally went quiet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Gloria Tory: ""Mr. Kibener, next time when I tell you to do so, either ..."*)

### Węzeł `[9]`
Mówca: **Gloria Tory**
> ""Mr. Kibener, next time when I tell you to do so, either take your seat or leave the hall; so we can proceed with the procedures of this Assembly and continue our duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Some MP's from the NFP side shouted back at her in protest."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Some MP's from the NFP side shouted back at her in protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Gloria Tory: ""Honorable ladies and gentlemen, if you allow me to conti..."*)

### Węzeł `[11]`
Mówca: **Gloria Tory**
> ""Honorable ladies and gentlemen, if you allow me to continue...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "She pointed at me."*)

### Węzeł `[12]`
Mówca: **Gloria Tory**
> ""We have the President here with us today. He has asked to give an important announcement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "The Assembly fell silent."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "I saw Kesaro Kibener standing up from his seat and shouting towards the members of the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Gloria Tory: ""Mr. Kibener! Calm yourself! Show respect to the procedur..."*)

### Węzeł `[14]`
Mówca: **Gloria Tory**
> ""Mr. Kibener! Calm yourself! Show respect to the procedures of this Assembly!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Despite her efforts, the argument continued for a couple ..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "She pointed at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Gloria Tory: ""We have the President here with us today. He has asked t..."*)

### Węzeł `[16]`
Mówca: **Gloria Tory**
> ""You have the floor, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I walked to the stand as loud clapping started in the USP..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "The Assembly fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Gloria Tory: ""You have the floor, Mr. President.""*)

### Węzeł `[18]`
Mówca: **Narrator**
> "I walked to the stand as loud clapping started in the USP's side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: ""Ladies and Gentlemen...""*)
  - -> `[53]` (*Player: ""Honorable Members of Assembly...""*)
  - -> `[54]` (*Player: ""Brothers and sisters...""*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Ladies and Gentlemen...""]** — Mówca: **Player**
> ""Ladies and Gentlemen of the Grand National Assembly of Sordland! I am here today to raise important questions regarding our outdated Constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: ""The Supreme Court holds too much power...""*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == false && BaseGame...."*)
  - -> `[62]` (*Player: ""Our elected Assembly has always been overshadowed...""*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""The Supreme Court holds too much power...""]** — Mówca: **Player**
> ""The Supreme Court holds too much power over our elected branches! They have been obstructing the law making process and has long plagued the democracy in Sordland. Tarquin Soll gave this power to the Court for the sole reason to protect the Constitution of the 20's, which leads us to fail in adapting to the new world...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Player), `[53]` (Player), `[54]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower = true;"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Our election threshold has harmed our democracy more than anything...""]** — Mówca: **Player**
> ""Our election threshold has harmed our democracy more than anything since the formation of our republic. As USP, we have governed for a long time and I can acknowledge that this success was partly the result of our current 10% percent threshold.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Kontekst wejściowy (poprzednik):** `[19]` (Player), `[53]` (Player), `[54]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed ..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""Perhaps it's not expected of me to say this, but the President holds too much authority...""]** — Mówca: **Player**
> ""Perhaps it's not expected of me to say this, but the President holds too much authority in Sordish politics. In order to strengthen our democracy, we must be brave enough to point out the injustices and faults of our Constitution.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == false  and  Variable["BaseGame.Reform_Law_TermLimits_2"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Kontekst wejściowy (poprzednik):** `[19]` (Player), `[53]` (Player), `[54]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_PresidentTooPower = true;"*)

### Węzeł `[23]`
Mówca: **Narrator**
> "I continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: ""...Therefore, we propose changes to the Constitution to ..."*)
  - -> `[63]` (*Player: ""We must finally rewrite the Constitution of Soll and bre..."*)
  - -> `[64]` (*Player: ""I call everyone to stand by us to make historic changes ..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""...Therefore, we propose changes to the Constitution to prepare Sordland for a more democratic era!""]** — Mówca: **Player**
> ""...Therefore, we propose changes to the Constitution to prepare Sordland for a more democratic era!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplause");"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""We will break the Supreme Court's authority over constitutional changes.""]** — Mówca: **Player**
> ""We will break the Supreme Court's authority over constitutional changes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator), `[66]` (Narrator), `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "I focused on..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""We will fix the loopholes that allows the presidents to exercise absolute veto over legislation.""]** — Mówca: **Player**
> ""We will fix the loopholes that allows the presidents to exercise absolute veto over legislation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "I focused on..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""We will rebalance the branches of government to ensure a more democratic process.""]** — Mówca: **Player**
> ""We will rebalance the branches of government to ensure a more democratic process.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator), `[66]` (Narrator), `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "I focused on..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Convinced == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyLoud");"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "Just as I was about to continue speaking, Gloria Tory int..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "Unity."]** — Mówca: **Player**
> ""It is more important than ever that we stand united as a nation in these changing times. I call everybody to be part of the change our people have been calling for. We all want to make Sordland better, don't we? Let's embrace democracy and unite under the banner of our people, and surely Sordland will be great again!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[82]` (*Player: ""We will make Sordland great again!""*)
  - -> `[83]` (*Player: ""Let's embrace the future.""*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Loud noises came from USP and NFP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "I took a breath and continued."*)

### Węzeł `[33]`
Mówca: **Gloria Tory**
> ""Mr. President, with all due respect, I believe Sordland is already democratic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: ""Please don't interrupt me.""*)
  - -> `[35]` (*Player: ""I'm not finished yet, Mrs. Tory.""*)
  - -> `[84]` (*Player: ""We both know that our Constitution is flawed.""*)
  - -> `[85]` (*Player: ""You don't believe that.""*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Please don't interrupt me.""]** — Mówca: **Player**
> ""Please don't interrupt me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Gloria Tory: ""Tarquin Soll and his efforts cannot be ignored. We must ..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: ""I'm not finished yet, Mrs. Tory.""]** — Mówca: **Player**
> ""I'm not finished yet, Mrs. Tory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Gloria Tory: ""Tarquin Soll and his efforts cannot be ignored. We must ..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Ladies and gentlemen of the Assembly! We must set aside our differences.""]** — Mówca: **Player**
> ""Ladies and gentlemen of the Assembly! We must set aside our differences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: ""Be part of a new era for Sordland. Join us and vote for ..."*)
  - -> `[42]` (*Player: ""I ask everyone to support us in the upcoming vote.""*)
  - -> `[40]` (*Player: ""Ladies and Gentlemen, I demand your votes!""*)

### Węzeł `[37]`
Mówca: **Narrator**
> "I took a breath and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""Ladies and gentlemen of the Assembly! We must set aside ..."*)
  - -> `[38]` (*Player: ""It is time to make a new Constitution together!""*)
  - -> `[39]` (*Player: ""I ask everyone to think clearly about our current situat..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""It is time to make a new Constitution together!""]** — Mówca: **Player**
> ""It is time to make a new Constitution together!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: ""Be part of a new era for Sordland. Join us and vote for ..."*)
  - -> `[42]` (*Player: ""I ask everyone to support us in the upcoming vote.""*)
  - -> `[40]` (*Player: ""Ladies and Gentlemen, I demand your votes!""*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""I ask everyone to think clearly about our current situation. And join us for change.""]** — Mówca: **Player**
> ""I ask everyone to think clearly about our current situation. And join us for change.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: ""Be part of a new era for Sordland. Join us and vote for ..."*)
  - -> `[42]` (*Player: ""I ask everyone to support us in the upcoming vote.""*)
  - -> `[40]` (*Player: ""Ladies and Gentlemen, I demand your votes!""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Ladies and Gentlemen, I demand your votes!""]** — Mówca: **Player**
> ""Ladies and Gentlemen, I demand your votes!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Player), `[38]` (Player), `[39]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: ""Let's write the future together!""*)
  - -> `[44]` (*Player: ""I will address all the problems of the past in my propos..."*)
  - -> `[45]` (*Player: ""USP will change and lead Sordland into the future!""*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Let's write the future together!""]** — Mówca: **Player**
> ""Let's write the future together!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Player), `[42]` (Player), `[43]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Italic: "Salute the crowd."*)
  - -> `[174]` (*Player_Italic: "Finish with a poem."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""I ask everyone to support us in the upcoming vote.""]** — Mówca: **Player**
> ""I ask everyone to support us in the upcoming vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Player), `[38]` (Player), `[39]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: ""Let's write the future together!""*)
  - -> `[44]` (*Player: ""I will address all the problems of the past in my propos..."*)
  - -> `[45]` (*Player: ""USP will change and lead Sordland into the future!""*)

### Węzeł `[43]`
**[WYBÓR GRACZA: ""Be part of a new era for Sordland. Join us and vote for our proposal.""]** — Mówca: **Player**
> ""Be part of a new era for Sordland. Join us and vote for our proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Player), `[38]` (Player), `[39]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: ""Let's write the future together!""*)
  - -> `[44]` (*Player: ""I will address all the problems of the past in my propos..."*)
  - -> `[45]` (*Player: ""USP will change and lead Sordland into the future!""*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""I will address all the problems of the past in my proposal!""]** — Mówca: **Player**
> ""I will address all the problems of the past in my proposal!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Player), `[42]` (Player), `[43]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Italic: "Salute the crowd."*)
  - -> `[174]` (*Player_Italic: "Finish with a poem."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""USP will change and lead Sordland into the future!""]** — Mówca: **Player**
> ""USP will change and lead Sordland into the future!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Player), `[42]` (Player), `[43]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Italic: "Salute the crowd."*)
  - -> `[174]` (*Player_Italic: "Finish with a poem."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""For justice in Sordland!""]** — Mówca: **Player**
> ""For justice in Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "The Assembly roared with all kinds of different reactions."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""For a democratic Sordland!""]** — Mówca: **Player**
> ""For a democratic Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "The Assembly roared with all kinds of different reactions."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: ""For a united Sordland!""]** — Mówca: **Player**
> ""For a united Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "The Assembly roared with all kinds of different reactions."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: ""For a free Sordland!""]** — Mówca: **Player**
> ""For a free Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "The Assembly roared with all kinds of different reactions."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "The Assembly roared with all kinds of different reactions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[51]`
Mówca: **Frens Ricter**
> ""Thank you, Mrs. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Frens Ricter: ""I would like to thank Mr. President for his speech. We, ..."*)

### Węzeł `[52]`
Mówca: **Gloria Tory**
> ""Thank you for the speech, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "I walked back to my seat as many MP's asked to speak. Fre..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Honorable Members of Assembly...""]** — Mówca: **Player**
> ""Honorable Members of the Grand National Assembly of Sordland! I am here today to raise important questions regarding our outdated Constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: ""The Supreme Court holds too much power...""*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == false && BaseGame...."*)
  - -> `[62]` (*Player: ""Our elected Assembly has always been overshadowed...""*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Brothers and sisters...""]** — Mówca: **Player**
> ""Brothers and sisters! I am here today to raise important questions regarding our outdated Constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: ""The Supreme Court holds too much power...""*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == false && BaseGame...."*)
  - -> `[62]` (*Player: ""Our elected Assembly has always been overshadowed...""*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Refor..."*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Ref..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Our election threshold has harmed our democracy more tha..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true || BaseGame.Reform_Law_Threshold_8 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true  or  Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == false && BaseGame.Reform_Law_TermLimits_2 == true && BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == false && BaseGame...."*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Default == false && BaseGam..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == false && BaseGame.Reform_Law_TermLimits_2 == true && BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == false  and  Variable["BaseGame.Reform_Law_TermLimits_2"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: ""Perhaps it's not expected of me to say this, but the Pre..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Default == false && BaseGame.Reform_Law_TermLimits_2 == true && BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Ministers_Default == false && BaseGame.Reform_Law_Impeachment_Removed == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == false  and  Variable["BaseGame.Reform_Law_TermLimits_2"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: ""Our Constitution doesn't adequately define or respect th..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Our Constitution doesn't adequately define or respect the separation of powers...""]** — Mówca: **Player**
> ""Our Constitution doesn't adequately define or respect the separation of powers and the balance between the branches. In order to strengthen our democracy, we must be brave enough to point out the faults of our Constitution.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == false  and  Variable["BaseGame.Reform_Law_TermLimits_2"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[19]` (Player), `[53]` (Player), `[54]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SeparationofPowers = true"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""Our elected Assembly has always been overshadowed...""]** — Mówca: **Player**
> ""Our elected Assembly has always been overshadowed by the executive and the designated judiciary branches in Sordland. The Grand National Assembly must be able to exercise its job properly and without obstruction. However, our current Constitution fails to guarantee this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Player), `[53]` (Player), `[54]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard = true;"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""We must finally rewrite the Constitution of Soll and break our chains of the past!""]** — Mówca: **Player**
> ""We must finally rewrite the Constitution of Soll and break our chains of the past!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplause");"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""I call everyone to stand by us to make historic changes to our Constitution and bring it to the standards of today's world!""]** — Mówca: **Player**
> ""I call everyone to stand by us to make historic changes to our Constitution and bring it to the standards of today's world!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplause");"*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Loud applauses came from PFJP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""We will break the Supreme Court's authority over constit..."*)
  - -> `[26]` (*Player: ""We will fix the loopholes that allows the presidents to ..."*)
  - -> `[27]` (*Player: ""We will rebalance the branches of government to ensure a..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "Applauses came from USP and PFJP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""We will break the Supreme Court's authority over constit..."*)
  - -> `[27]` (*Player: ""We will rebalance the branches of government to ensure a..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Applauses came from USP and PFJP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""We will break the Supreme Court's authority over constit..."*)
  - -> `[27]` (*Player: ""We will rebalance the branches of government to ensure a..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "I focused on..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "Unity."*)
  - -> `[69]` (*Player: "Change."*)
  - -> `[70]` (*Player: "Peace."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "Change."]** — Mówca: **Player**
> ""We must not be afraid of change. The world is changing, and Sordland needs the change it has earned after years of Sollism in the last decades. We will rewrite the old and make a constitution that would reflect the will of the people, and open the way for a democratic Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[82]` (*Player: ""We will make Sordland great again!""*)
  - -> `[83]` (*Player: ""Let's embrace the future.""*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "Peace."]** — Mówca: **Player**
> ""The '29 Constitution was the product of a time of war. Now is a time for peace. As we must make peace between each other, we must strive for peace in the world. We need a more democratic constitution that would reflect the will of the people, and flourish in the upcoming times of peace and prosper!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[82]` (*Player: ""We will make Sordland great again!""*)
  - -> `[83]` (*Player: ""Let's embrace the future.""*)

### Węzeł `[71]`
Mówca: **Narrator**
> "Just as I was about to continue speaking, Gloria Tory interrupted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Gloria Tory: ""Mr. President, with all due respect, I believe Sordland ..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "I walked back to my seat as many MP's asked to speak. Frens Ricter was among them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Gloria Tory: ""Yes, Mr. Ricter.""*)

### Węzeł `[73]`
Mówca: **Narrator**
> "Suddenly Kesaro Kibener started yelling from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Kesaro Kibener: "<shout>"The President must have lost his mind to cooperat..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""Tarquin Soll will answer for the crimes committed during..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[77]`
**[WYBÓR GRACZA: ""Tarquin Soll will answer for the crimes committed during his rule! We will make sure of that!""]** — Mówca: **Player**
> ""Tarquin Soll will answer for the crimes committed during his rule! We will make sure of that!""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Kontekst wejściowy (poprzednik):** `[31]` (Player), `[69]` (Player), `[70]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll = true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: ""We will be removing the presidential decrees and leave l..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
**[WYBÓR GRACZA: ""We will be removing the presidential decrees and leave lawmaking to the Assembly.""]** — Mówca: **Player**
> ""We will be removing the presidential decrees and leave lawmaking to the Assembly.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Kontekst wejściowy (poprzednik):** `[31]` (Player), `[69]` (Player), `[70]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_RemoveDecrees = true"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: ""We will make Sordland great again!""]** — Mówca: **Player**
> ""We will make Sordland great again!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Player), `[69]` (Player), `[70]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[83]`
**[WYBÓR GRACZA: ""Let's embrace the future.""]** — Mówca: **Player**
> ""Let's embrace the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Player), `[69]` (Player), `[70]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""We both know that our Constitution is flawed.""]** — Mówca: **Player**
> ""We both know that our Constitution is flawed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Gloria Tory: ""Tarquin Soll and his efforts cannot be ignored. We must ..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""You don't believe that.""]** — Mówca: **Player**
> ""You don't believe that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Gloria Tory: ""Tarquin Soll and his efforts cannot be ignored. We must ..."*)

### Węzeł `[86]`
Mówca: **Gloria Tory**
> ""Tarquin Soll and his efforts cannot be ignored. We must keep following the path he defined for Sordish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Gloria Tory: ""I'm sure the Honorable Members of USP will see that the ..."*)

### Węzeł `[87]`
Mówca: **Gloria Tory**
> ""I'm sure the Honorable Members of USP will see that the President is acting rash by allying with the opposition to destroy the culture of Sollism that established Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Gloria Tory: ""That was the extent of my quick note. Thank you. The Pre..."*)

### Węzeł `[88]`
Mówca: **Gloria Tory**
> ""That was the extent of my quick note. Thank you. The President has the floor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Player: ""That was disrespectful Mrs. Speaker. Please don't try to..."*)
  - -> `[240]` (*Player: ""We are not here to destroy Sollism nor our cultural valu..."*)
  - -> `[238]` (*Player: ""Who are you trying to provoke, Mrs. Tory? USP is behind ..."*)
  - -> `[237]` (*Player: ""I'll act as if that didn't happen.""*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true && BaseGame.Refo..."*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Convinced == true && BaseGame.Re..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true  and  Variable["BaseGame.Reform_Albin_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplause2");"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Convinced == true && BaseGame.Reform_Albin_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true  and  Variable["BaseGame.Reform_Albin_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplauseShouting");"*)

### Węzeł `[92]`
Mówca: **Narrator**
> "The whole United Sordland Party stood up and started applauding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Gloria Tory: ""Thank you for the speech, Mr. President.""*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Some applauses came from the PFJP and USP seats. Most of the others started to make loud noises again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Gloria Tory: ""Thank you for the speech, Mr. President.""*)

### Węzeł `[94]`
Mówca: **Gloria Tory**
> ""Yes, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Frens Ricter: ""Thank you, Mrs. Speaker.""*)

### Węzeł `[95]`
Mówca: **Frens Ricter**
> ""I would like to thank Mr. President for his speech. We, the People's Freedom and Justice Party, stand in agreement with the need for a more democratic Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Frens Ricter: ""I would like to thank the Ladies and Gentlemen of the Un..."*)

### Węzeł `[96]`
Mówca: **Frens Ricter**
> ""I would like to thank the Ladies and Gentlemen of the United Sordland Party for their more open attitude compared to past years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Frens Ricter: ""As long as Mr. President's words prove not to be just wo..."*)

### Węzeł `[97]`
Mówca: **Frens Ricter**
> ""As long as Mr. President's words prove not to be just words, we will be behind this much needed movement for change. We welcome this attempt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Frens Ricter: ""I ask Mr. President to share the final contents of this ..."*)

### Węzeł `[98]`
Mówca: **Frens Ricter**
> ""I ask Mr. President to share the final contents of this proposal as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Frens Ricter: ""Thank you, Mrs. Speaker.""*)

### Węzeł `[99]`
Mówca: **Frens Ricter**
> ""Thank you, Mrs. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Suddenly Kesaro Kibener started yelling from his seat."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist -= 10`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[101]`
Mówca: **Kesaro Kibener**
> "<shout>"The President must have lost his mind to cooperate with the likes of you, Mr. Ricter!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Kesaro Kibener: "<shout>"You and PFJP are nothing but puppets of western i..."*)

### Węzeł `[102]`
Mówca: **Kesaro Kibener**
> "<shout>"You and PFJP are nothing but puppets of western interests!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Gloria Tory: "<shout>"ORDER!"</shout>"*)

### Węzeł `[103]`
Mówca: **Gloria Tory**
> "<shout>"ORDER!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Kesaro Kibener: ""Madame Speaker! I know you are in agreement with me as w..."*)

### Węzeł `[104]`
Mówca: **Kesaro Kibener**
> ""Madame Speaker! I know you are in agreement with me as well. Don't stand idly there while this administration is making deals with snakes and undermine the integrity of Sor-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Gloria Tory: ""ORDER! Mr. Kibener! How many times do I need to say? You..."*)

### Węzeł `[105]`
Mówca: **Gloria Tory**
> ""ORDER! Mr. Kibener! How many times do I need to say? You are speaking out of tu-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Kesaro Kibener: ""I demand to speak!""*)

### Węzeł `[106]`
Mówca: **Kesaro Kibener**
> ""I demand to speak!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Gloria gave him a stare. She looked annoyed."*)

### Węzeł `[107]`
Mówca: **Gloria Tory**
> ""...Very well, Mr. Kibener... Go ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Kesaro Kibener: ""Mr. President!""*)

### Węzeł `[108]`
Mówca: **Kesaro Kibener**
> ""Mr. President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "He looked directly at me."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "He looked directly at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Kesaro Kibener: ""The nationalist movement does not agree with your priori..."*)

### Węzeł `[110]`
Mówca: **Kesaro Kibener**
> ""The nationalist movement does not agree with your priorities nor the way you're trying to implement them. The National Front Party will not stand with you on your new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Kesaro Kibener: ""Let it be known that the NFP's concerns are not included..."*)

### Węzeł `[111]`
Mówca: **Kesaro Kibener**
> ""Let it be known that the NFP's concerns are not included in this so called "democratic" reforms. Thus Mr. President has no right to claim them as such!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Kesaro Kibener: ""We will stand our ground against any attempt to bring do..."*)

### Węzeł `[112]`
Mówca: **Kesaro Kibener**
> ""We will stand our ground against any attempt to bring down our established political culture and national values. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Kesaro went back to his seat but the chaos in the Assembl..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Gloria gave him a stare. She looked annoyed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Gloria Tory: ""...Very well, Mr. Kibener... Go ahead.""*)

### Węzeł `[114]`
Mówca: **Narrator**
> "Kesaro went back to his seat but the chaos in the Assembly continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player_Italic: "Ask to speak."*)
  - -> `[115]` (*Player_Italic: "Leave the Assembly."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "Leave the Assembly."]** — Mówca: **Player_Italic**
> "I decided to leave the Assembly and its chaos behind."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "I got up from my seat and started my walk towards the exit."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "Ask to speak."]** — Mówca: **Player_Italic**
> "I asked to speak."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Gloria Tory: ""Yes, Mr. President.""*)

### Węzeł `[117]`
Mówca: **Narrator**
> "I got up from my seat and started my walk towards the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "MP's kept shouting and responding to each other, creating..."*)

### Węzeł `[118]`
Mówca: **Gloria Tory**
> ""Yes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: ""Mr. Kibener...""*)
  - -> `[120]` (*Player: ""Mr. Ricter...""*)
  - -> `[121]` (*Player: ""I just wanted to thank everybody for their comments.""*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""Mr. Kibener...""]** — Mówca: **Player**
> ""Mr. Kibener...""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[118]` (Gloria Tory), `[135]` (Narrator), `[153]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "I looked at him."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""Mr. Ricter...""]** — Mówca: **Player**
> ""Mr. Ricter...""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[118]` (Gloria Tory), `[135]` (Narrator), `[153]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "I looked at him."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I just wanted to thank everybody for their comments.""]** — Mówca: **Player**
> ""I just wanted to thank everybody for their comments.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Gloria Tory: ""Alright, Mr. President.""*)

### Węzeł `[122]`
Mówca: **Narrator**
> "I looked at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""It is you, who shouldn't use the word 'democratic' when ..."*)
  - -> `[124]` (*Player: ""We are not specifically cooperating with someone, but ev..."*)
  - -> `[125]` (*Player: ""I'm saddened to hear about your opposite stance.""*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""It is you, who shouldn't use the word 'democratic' when you want a more centralized government.""]** — Mówca: **Player**
> ""It is you, who shouldn't use the word 'democratic' when you want a more centralized government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "He watched as he slouched on his seat, legs crossed."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""We are not specifically cooperating with someone, but everyone. We ask that you also join us.""]** — Mówca: **Player**
> ""We are not specifically cooperating with someone, but everyone. We ask that you also join us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "He watched as he slouched on his seat, legs crossed."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""I'm saddened to hear about your opposite stance.""]** — Mówca: **Player**
> ""I'm saddened to hear about your opposite stance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "He watched as he slouched on his seat, legs crossed."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "He watched as he slouched on his seat, legs crossed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player: ""Do not stand against change! Be a part of it, Mr. Kibene..."*)
  - -> `[128]` (*Player: ""Don't you dare stand against us! Otherwise, know that th..."*)
  - -> `[129]` (*Player: ""I respect your opinion.""*)
  - -> `[130]` (*Player: ""We don't need you.""*)

### Węzeł `[127]`
**[WYBÓR GRACZA: ""Do not stand against change! Be a part of it, Mr. Kibener! We can do much more together.""]** — Mówca: **Player**
> ""Do not stand against change! Be a part of it, Mr. Kibener! We can do much more together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: ""I expect your support in the upcoming vote, Mr. Kibener.""*)
  - -> `[132]` (*Player: ""We will bring change regardless of your support.""*)
  - -> `[133]` (*Player: ""Thank you.""*)
  - -> `[134]` (*Player: ""Your times have passed, Mr. Kibener.""*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""Don't you dare stand against us! Otherwise, know that the NFP is guaranteed to be history.""]** — Mówca: **Player**
> ""Don't you dare stand against us! Otherwise, know that the NFP is guaranteed to be history.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: ""I expect your support in the upcoming vote, Mr. Kibener.""*)
  - -> `[132]` (*Player: ""We will bring change regardless of your support.""*)
  - -> `[133]` (*Player: ""Thank you.""*)
  - -> `[134]` (*Player: ""Your times have passed, Mr. Kibener.""*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""I respect your opinion.""]** — Mówca: **Player**
> ""I respect your opinion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: ""I expect your support in the upcoming vote, Mr. Kibener.""*)
  - -> `[132]` (*Player: ""We will bring change regardless of your support.""*)
  - -> `[133]` (*Player: ""Thank you.""*)
  - -> `[134]` (*Player: ""Your times have passed, Mr. Kibener.""*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""We don't need you.""]** — Mówca: **Player**
> ""We don't need you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: ""I expect your support in the upcoming vote, Mr. Kibener.""*)
  - -> `[132]` (*Player: ""We will bring change regardless of your support.""*)
  - -> `[133]` (*Player: ""Thank you.""*)
  - -> `[134]` (*Player: ""Your times have passed, Mr. Kibener.""*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""I expect your support in the upcoming vote, Mr. Kibener.""]** — Mówca: **Player**
> ""I expect your support in the upcoming vote, Mr. Kibener.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Player), `[128]` (Player), `[129]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A = true"*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""We will bring change regardless of your support.""]** — Mówca: **Player**
> ""We will bring change regardless of your support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Player), `[128]` (Player), `[129]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A = true"*)

### Węzeł `[133]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Player), `[128]` (Player), `[129]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A = true"*)

### Węzeł `[134]`
**[WYBÓR GRACZA: ""Your times have passed, Mr. Kibener.""]** — Mówca: **Player**
> ""Your times have passed, Mr. Kibener.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Player), `[128]` (Player), `[129]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A = true"*)

### Węzeł `[135]`
Mówca: **Narrator**
> "Gloria looked at me to see if I'd finished my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "Jump to: [Response]"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Response`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true"*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true"*)
  - -> `[143]` (*Player: ""Thank you, Mrs. Speaker.""*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: ""Mr. Kibener...""*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true)"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: ""Mr. Ricter...""*)

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Thank you, Mrs. Speaker.""]** — Mówca: **Player**
> ""Thank you, Mrs. Speaker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Narrator), `[153]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "I got up from my seat and started my walk towards the exit."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Response]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "Response"*)

### Węzeł `[145]`
**[WYBÓR GRACZA: ""Rest assured, your concerns will be addressed.""]** — Mówca: **Player**
> ""Rest assured, your concerns will be addressed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: ""I expect your support, Mr. Ricter! We can do much more t..."*)
  - -> `[151]` (*Player: ""Thank you for your support. We are looking forward to wo..."*)
  - -> `[149]` (*Player: ""I welcome your positive attitude.""*)

### Węzeł `[146]`
Mówca: **Narrator**
> "I looked at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: ""Thank you for the nice words.""*)
  - -> `[147]` (*Player: ""We'd like to have cooperation between our parties.""*)
  - -> `[145]` (*Player: ""Rest assured, your concerns will be addressed.""*)

### Węzeł `[147]`
**[WYBÓR GRACZA: ""We'd like to have cooperation between our parties.""]** — Mówca: **Player**
> ""We'd like to have cooperation between our parties.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: ""I expect your support, Mr. Ricter! We can do much more t..."*)
  - -> `[151]` (*Player: ""Thank you for your support. We are looking forward to wo..."*)
  - -> `[149]` (*Player: ""I welcome your positive attitude.""*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Response]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "Response"*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I welcome your positive attitude.""]** — Mówca: **Player**
> ""I welcome your positive attitude.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Player), `[147]` (Player), `[152]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B = true"*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""I expect your support, Mr. Ricter! We can do much more together.""]** — Mówca: **Player**
> ""I expect your support, Mr. Ricter! We can do much more together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Player), `[147]` (Player), `[152]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B = true"*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""Thank you for your support. We are looking forward to work with the PFJP.""]** — Mówca: **Player**
> ""Thank you for your support. We are looking forward to work with the PFJP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Player), `[147]` (Player), `[152]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B = true"*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""Thank you for the nice words.""]** — Mówca: **Player**
> ""Thank you for the nice words.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: ""I expect your support, Mr. Ricter! We can do much more t..."*)
  - -> `[151]` (*Player: ""Thank you for your support. We are looking forward to wo..."*)
  - -> `[149]` (*Player: ""I welcome your positive attitude.""*)

### Węzeł `[153]`
Mówca: **Narrator**
> "Gloria looked at me to see if I'd finished my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "Jump to: [Response]"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Gloria looked at me to see if I'd finished my response."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Reformist_ResponseHub_B"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Gloria looked at me to see if I'd finished my response."*)

### Węzeł `[156]`
Mówca: **Gloria Tory**
> ""Alright, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "MP's kept shouting and responding to each other, creating..."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "MP's kept shouting and responding to each other, creating a loud mess where nothing was legible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Gloria Tory: ""Order! Order! This topic has finished. We are moving unt..."*)

### Węzeł `[158]`
Mówca: **Gloria Tory**
> ""Order! Order! This topic has finished. We are moving unto our next topic...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[159]`
Mówca: **Narrator**
> "I slowly left the hall. Thew shouting could be heard from every corridor of the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[160]`
Mówca: **Narrator**
> "I got up from my seat and started my walk towards the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "MP's kept shouting and responding to each other, creating..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist -= 10"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Speech_PromisedToTrySoll == true)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "I slowly left the hall. Thew shouting could be heard from..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Speech_PromisedToTrySoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "I slowly left the hall. The shouting could be heard from ..."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "I slowly left the hall. The shouting could be heard from every corridor of the Grand National Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[166]`
**[WYBÓR GRACZA: ""There is a victory growing with every morning...""]** — Mówca: **Player**
> ""There is a victory growing with every morning...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: ""There is a revolution that's coming...""*)
  - -> `[169]` (*Player: ""There is God beyond existence or nonexistence...""*)
  - -> `[168]` (*Player: ""There is my country beyond everything, my beloved...""*)

### Węzeł `[167]`
**[WYBÓR GRACZA: "Salute the crowd."]** — Mówca: **Player_Italic**
> "I saluted the crowd."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Player), `[44]` (Player), `[45]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""For justice in Sordland!""*)
  - -> `[47]` (*Player: ""For a democratic Sordland!""*)
  - -> `[48]` (*Player: ""For a united Sordland!""*)
  - -> `[49]` (*Player: ""For a free Sordland!""*)

### Węzeł `[168]`
**[WYBÓR GRACZA: ""There is my country beyond everything, my beloved...""]** — Mówca: **Player**
> ""There is my country beyond everything, my beloved...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Player), `[173]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: ""There are songs to be sung in affectation of our victori..."*)
  - -> `[172]` (*Player: ""There is a spring that blossoms out of the graves of our..."*)
  - -> `[178]` (*Player: ""There is the evil that tortures and tears me down...""*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""There is God beyond existence or nonexistence...""]** — Mówca: **Player**
> ""There is God beyond existence or nonexistence...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Player), `[173]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: ""There are songs to be sung in affectation of our victori..."*)
  - -> `[172]` (*Player: ""There is a spring that blossoms out of the graves of our..."*)
  - -> `[178]` (*Player: ""There is the evil that tortures and tears me down...""*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""Fear not when the dark falls! There is an artist painting the sun.""]** — Mówca: **Player**
> ""Fear not when the dark falls! There is an artist painting the sun.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Player), `[176]` (Player), `[178]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player: ""Beyond the next morning, there is a victory waiting to b..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA: ""Beyond the next morning, there is a victory waiting to be won.""]** — Mówca: **Player**
> ""Beyond the next morning, there is a victory waiting to be won.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Player), `[175]` (Player), `[179]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "The Assembly roared with all kinds of different reactions."*)

### Węzeł `[172]`
**[WYBÓR GRACZA: ""There is a spring that blossoms out of the graves of our fallen...""]** — Mówca: **Player**
> ""There is a spring that blossoms out of the graves of our fallen...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Player), `[169]` (Player), `[177]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player: ""Do not doubt the One! There is a decision coming from th..."*)
  - -> `[170]` (*Player: ""Fear not when the dark falls! There is an artist paintin..."*)
  - -> `[175]` (*Player: ""Do not dare to surrender! There is a victory that grows ..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA: ""There is a destiny above destiny...""]** — Mówca: **Player**
> ""There is a destiny above destiny...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: ""There is a revolution that's coming...""*)
  - -> `[169]` (*Player: ""There is God beyond existence or nonexistence...""*)
  - -> `[168]` (*Player: ""There is my country beyond everything, my beloved...""*)

### Węzeł `[174]`
**[WYBÓR GRACZA: "Finish with a poem."]** — Mówca: **Player_Italic**
> "I decided to read a poem before I ended my speech."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Player), `[44]` (Player), `[45]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player: ""There is a destiny above destiny...""*)
  - -> `[166]` (*Player: ""There is a victory growing with every morning...""*)

### Węzeł `[175]`
**[WYBÓR GRACZA: ""Do not dare to surrender! There is a victory that grows with defeat.""]** — Mówca: **Player**
> ""Do not dare to surrender! There is a victory that grows with defeat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Player), `[176]` (Player), `[178]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player: ""Beyond the next morning, there is a victory waiting to b..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: ""There are songs to be sung in affectation of our victories...""]** — Mówca: **Player**
> ""There are songs to be sung in affectation of our victories...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Player), `[169]` (Player), `[177]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player: ""Do not doubt the One! There is a decision coming from th..."*)
  - -> `[170]` (*Player: ""Fear not when the dark falls! There is an artist paintin..."*)
  - -> `[175]` (*Player: ""Do not dare to surrender! There is a victory that grows ..."*)

### Węzeł `[177]`
**[WYBÓR GRACZA: ""There is a revolution that's coming...""]** — Mówca: **Player**
> ""There is a revolution that's coming...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Player), `[173]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: ""There are songs to be sung in affectation of our victori..."*)
  - -> `[172]` (*Player: ""There is a spring that blossoms out of the graves of our..."*)
  - -> `[178]` (*Player: ""There is the evil that tortures and tears me down...""*)

### Węzeł `[178]`
**[WYBÓR GRACZA: ""There is the evil that tortures and tears me down...""]** — Mówca: **Player**
> ""There is the evil that tortures and tears me down...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Player), `[169]` (Player), `[177]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player: ""Do not doubt the One! There is a decision coming from th..."*)
  - -> `[170]` (*Player: ""Fear not when the dark falls! There is an artist paintin..."*)
  - -> `[175]` (*Player: ""Do not dare to surrender! There is a victory that grows ..."*)

### Węzeł `[179]`
**[WYBÓR GRACZA: ""Do not doubt the One! There is a decision coming from the heavens...""]** — Mówca: **Player**
> ""Do not doubt the One! There is a decision coming from the heavens...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Player), `[176]` (Player), `[178]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player: ""Beyond the next morning, there is a victory waiting to b..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == true && BaseGame.Reform_Gloria_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true && BaseGame.Refor..."*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Convinced == true && BaseGame.Ref..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == true && BaseGame.Reform_Gloria_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both =..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Convinced == true && BaseGame.Reform_Gloria_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true || BaseGame.Refor..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == true || BaseGame.Reform_Gloria_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true || BaseGame.Refor..."*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Albin_Convinced == true || BaseGame.Ref..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Albin_Convinced == true || BaseGame.Reform_Gloria_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Albin_Convinced"] == true  or  Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Gloria..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Albin_Convinced == true || BaseGame.Reform_Gloria_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Albin_Convinced"] == true  or  Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None =..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_None"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_GloriaAlbin = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_GloriaAlbin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_ReformStatus_Both"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_TradeDeal == true)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Uziren_BorderReport = true"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true && BaseGame.Refor..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Uziren_BorderReport = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Uziren_BorderReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Albin_Convinced == true && BaseGame.Refor..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy = true"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_G_WalkerWarnsNavy = true"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_RemoveDecrees == true"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_G_WalkerWarnsNavy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_WalkerWarnsNavy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_RemoveDecrees == true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == t..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_SCTooMuchPower_R = true"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_A_Speech = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_A_Speech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_SCTooMuchPower_R = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_SCTooMuchPower_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == t..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_AssemblyOvershadowed_R = true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_ConstitutionNotAdequate_R = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_ConstitutionNotAdequate_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_PresidentTooPower == true"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_RemoveDecrees == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_RemoveDecrees == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Speech_RemoveDecrees == true)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_RemoveDecrees == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_RemoveDecrees"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_LT_RemoveDecrees_R = true"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Speech_RemoveDecrees == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_RemoveDecrees"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed ..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == ..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SeparationofPowers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_ConstitutionNotAdequate_R ..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_SeparationofPowers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_PresidentTooPower == true"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_AssemblyOvershadowed_R = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_AssemblyOvershadowed_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SeparationofPowers == true"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_LT_RemoveDecrees_R = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_RemoveDecrees_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed ..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_ElectionThreshold_R = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_ElectionThreshold_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_PresidentTooPower == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_PresidentTooPower == true"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Speech_PresidentTooPower == t..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_PresidentTooPower == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_PresidentTooPower"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_PresidentTooPowerful_R = true"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Speech_PresidentTooPower == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_PresidentTooPower"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed ..."*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarme..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_ElectionThreshold_R = true"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard == true"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_PresidentTooPowerful_R = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_PresidentTooPowerful_R"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower == true"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SupremeCourtPower"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "I continued."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_ElectionThresholdHarmed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "I continued."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_OvershadowedGuard"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "I continued."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_SeparationofPowers = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_SeparationofPowers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "I continued."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Speech_PromisedToTrySoll == true)"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_R_PromisedToTrySoll = true; B..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Speech_PromisedToTrySoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Med..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_R_PromisedToTrySoll = true;
BaseGame.Public_Opinion -= 3;
BaseGame.Bludish_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_R_PromisedToTrySoll"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Med..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_A_Speech = true"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Media_SordlandToday_Bias == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Med..."*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Speech_PromisedToTrySoll == true && BaseGame.M..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Media_SordlandToday_Bias == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_PromisedToTrySoll_NoDeal =..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Speech_PromisedToTrySoll == true && BaseGame.Media_SordlandToday_Bias == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_A_Speech = true"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_PresidentTooPower = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_PresidentTooPower"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "I continued."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Speech_RemoveDecrees = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Speech_RemoveDecrees"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[237]`
**[WYBÓR GRACZA: ""I'll act as if that didn't happen.""]** — Mówca: **Player**
> ""I'll act as if that didn't happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[238]`
**[WYBÓR GRACZA: ""Who are you trying to provoke, Mrs. Tory? USP is behind me.""]** — Mówca: **Player**
> ""Who are you trying to provoke, Mrs. Tory? USP is behind me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[239]`
**[WYBÓR GRACZA: ""That was disrespectful Mrs. Speaker. Please don't try to sabotage my speech.""]** — Mówca: **Player**
> ""That was disrespectful Mrs. Speaker. Please don't try to sabotage my speech.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[240]`
**[WYBÓR GRACZA: ""We are not here to destroy Sollism nor our cultural values.""]** — Mówca: **Player**
> ""We are not here to destroy Sollism nor our cultural values.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Speech_PromisedToTrySoll == true )"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Gloria Tory: ""You've just promised to try Soll, Mr. President! You are..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Speech_PromisedToTrySoll == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Gloria Tory: ""Please continue your speech, Mr. President.""*)

### Węzeł `[244]`
Mówca: **Gloria Tory**
> ""You've just promised to try Soll, Mr. President! You are talking about the founder of this party. He is the true founder of this republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Gloria Tory: ""What crimes are you talking about? You owe everything yo..."*)

### Węzeł `[245]`
Mówca: **Gloria Tory**
> ""What crimes are you talking about? You owe everything you have to him. This is unacceptable!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyLoud");"*)

### Węzeł `[246]`
Mówca: **Narrator**
> "Loud noises came from USP and NFP seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player: ""Everyone! Please! Let me finish.""*)
  - -> `[248]` (*Player: ""Hear me out.""*)
  - -> `[250]` (*Player: ""Let me explain.""*)

### Węzeł `[247]`
**[WYBÓR GRACZA: ""Everyone! Please! Let me finish.""]** — Mówca: **Player**
> ""Everyone! Please! Let me finish.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[246]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "I took a breath and continued."*)

### Węzeł `[248]`
**[WYBÓR GRACZA: ""Hear me out.""]** — Mówca: **Player**
> ""Hear me out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[246]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "I took a breath and continued."*)

### Węzeł `[249]`
Mówca: **Gloria Tory**
> ""Please continue your speech, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "I took a breath and continued."*)

### Węzeł `[250]`
**[WYBÓR GRACZA: ""Let me explain.""]** — Mówca: **Player**
> ""Let me explain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[246]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "I took a breath and continued."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Speech_PromisedToTrySoll == true"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Speech_PromisedToTrySoll == true )"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Speech_PromisedToTrySoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Speech_PromisedToTrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("VoteRoar");"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Speech_PromisedToTrySoll == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Speech_PromisedToTrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true && BaseGame.Refo..."*)

### Węzeł `[254]`
Mówca: **Narrator**
> "The whole United Sordland Party stood up and started shouting at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Gloria Tory: ""Your time is finished. Please take your seat, Mr. Presid..."*)

### Węzeł `[255]`
Mówca: **Gloria Tory**
> ""Your time is finished. Please take your seat, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "I walked back to my seat as many MP's asked to speak. Fre..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyShouting");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyShouting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "When I entered the hall, the Assembly was in complete cha..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplause");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplause");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Applauses came from USP and PFJP seats."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplause");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplause");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Loud applauses came from PFJP seats."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplause");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplause");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Applauses came from USP and PFJP seats."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyLoud");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyLoud");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Loud noises came from USP and NFP seats."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyLoud");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyLoud");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "Loud noises came from USP and NFP seats."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("VoteRoar");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("VoteRoar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "The whole United Sordland Party stood up and started shou..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplause2");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplause2");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "The whole United Sordland Party stood up and started appl..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplauseShouting");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplauseShouting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Some applauses came from the PFJP and USP seats. Most of ..."*)
