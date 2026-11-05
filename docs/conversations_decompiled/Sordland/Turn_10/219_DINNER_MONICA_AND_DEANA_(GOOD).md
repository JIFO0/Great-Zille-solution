# Sordland/Turn10/DINNER MONICA AND DEANA (GOOD)

- **ID konwersacji:** `219`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/219_DINNER_MONICA_AND_DEANA_(GOOD).md`
- **Liczba węzłów dialogowych:** 411
- **Liczba wyborów gracza:** 110

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Capitalist`
- `BaseGame.Enable_WomensRightsBill_Strong`
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Malenyevist`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_LeadsWomensRights`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Rumburg_War`
- `BaseGame.Situation_Law_ExcellentWomenRights`
- `BaseGame.Turn05_P_Vineyard`
- `BaseGame.Turn07_Personal_FrancConscripted`
- `BaseGame.Turn07_Personal_FrancMilitarySchool`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn10_PartyCongress_Retired`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_Exile`
- `BaseGame.Exile_LeaveNow`
- `BaseGame.Exile_MonicaDeanaWithYou`
- `BaseGame.Retirement_FamilyWithYou`
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[50]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""Yes, and damn proud of it.""** | `[134]` **Deana**: ""Papa, are we 'bourgeoisie pigs'?"" | `Variable["BaseGame.Capitalist"] > 5` | *Brak zmian stanu* | `[43]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[8]` | **""Franc's just been spending too much time in Arcasia, sweetie.""** | `[136]` **Deana**: ""Papa, are we a 'socialist hive ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[9]` | **""Not if I have anything to do with it.""** | `[136]` **Deana**: ""Papa, are we a 'socialist hive ..." | `(Variable["BaseGame.Malenyevist"] > 5) == false` | *Brak zmian stanu* | `[43]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[10]` | **""Yes, and damn proud of it.""** | `[136]` **Deana**: ""Papa, are we a 'socialist hive ..." | `Variable["BaseGame.Malenyevist"] > 5` | *Brak zmian stanu* | `[43]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[14]` | **""Not if I have anything to do with it.""** | `[134]` **Deana**: ""Papa, are we 'bourgeoisie pigs'?"" | `(Variable["BaseGame.Capitalist"] > 5) == false` | *Brak zmian stanu* | `[43]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[15]` | **""Franc's just been spending too much time in United Contana, sweetie.""** | `[134]` **Deana**: ""Papa, are we 'bourgeoisie pigs'?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[16]` | **""If he sacrifices himself for the sake of the country, that will be his decision.""** | `[70]` **Deana**: ""Papa, is Franc going to die fig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Deana**: ""But--"" |
| `[20]` | **""No, of course not.""** | `[70]` **Deana**: ""Papa, is Franc going to die fig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Deana**: ""But--"" |
| `[25]` | **""No, I've learned my lesson.""** | `[83]` **Deana**: ""Papa, is it true how he got int..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[26]` | **""Only if you show more gratitude for it than he did.""** | `[83]` **Deana**: ""Papa, is it true how he got int..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[27]` | **"Don't look at them and go to your door."** | `[17]` **Narrator**: "I didn't know if it was my imagi..."<br>`[19]` **Narrator**: "The guards formed a cordon to le..." | `Variable["BaseGame.Ending_Coup"] == true` | *Brak zmian stanu* | `[35]` **Narrator**: "Once inside, I locked the front ..." |
| `[28]` | **"Give the guards a suspicious look."** | `[17]` **Narrator**: "I didn't know if it was my imagi..."<br>`[19]` **Narrator**: "The guards formed a cordon to le..." | `Variable["BaseGame.Ending_Coup"] == true` | *Brak zmian stanu* | `[35]` **Narrator**: "Once inside, I locked the front ..." |
| `[29]` | **""Just keep studying so we'll never have to find out.""** | `[83]` **Deana**: ""Papa, is it true how he got int..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[30]` | **""What? Of course not.""** | `[71]` **Deana**: ""Papa, is Sordland 'run by a bun..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[31]` | **""It's complicated.""** | `[71]` **Deana**: ""Papa, is Sordland 'run by a bun..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[39]` | **""But right now, there's no time. We need to get out of Sordland. All of us.""** | `[3]` **Narrator**: "Monica's eyes were shining." | `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)` | *Brak zmian stanu* | `[75]` **Narrator**: "Monica and Deana turned to look ..." |
| `[41]` | **""Once the election's over, I'm taking you both on holiday.""** | `[3]` **Narrator**: "Monica's eyes were shining." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[339]` **Narrator**: "Monica sighed heavily."<br>`[340]` **Narrator**: "Monica smiled." |
| `[44]` | **"Hug her."** | `[37]` **Deana**: ""Hi, Papa."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Player**: ""How was school today?""<br>`[53]` **Player**: ""Where's your mother?"" |
| `[45]` | **""Deana! How was school today?""** | `[37]` **Deana**: ""Hi, Papa."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "Deana shrugged." |
| `[46]` | **""Where's your mother?""** | `[37]` **Deana**: ""Hi, Papa."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Deana**: ""She's in the kitchen."" |
| `[48]` | **""And we'll have plenty of time for that, because I'm retiring from politics at the..."** | `[3]` **Narrator**: "Monica's eyes were shining." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[99]` **Narrator**: "Monica and Deana looked at me in..." |
| `[52]` | **""How was school today?""** | `[44]` **Player_Italic**: "I opened my arms to embrace my d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "Deana shrugged." |
| `[53]` | **""Where's your mother?""** | `[44]` **Player_Italic**: "I opened my arms to embrace my d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Deana**: ""She's in the kitchen."" |
| `[57]` | **""And we'll have plenty of time for that after my presidency ends.""** | `[3]` **Narrator**: "Monica's eyes were shining." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[306]` **Narrator**: "Monica smiled at me."<br>`[310]` **Narrator**: "Monica frowned." |
| `[58]` | **""My retirement from politics is going to be the best thing that ever happened to us.""** | `[3]` **Narrator**: "Monica's eyes were shining." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[306]` **Narrator**: "Monica smiled at me."<br>`[310]` **Narrator**: "Monica frowned." |
| `[62]` | **""Now that we're all here, I wanted to say something.""** | `[49]` **Narrator**: "The three of us gathered around ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Player**: ""I know the past four years have..."<br>`[96]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych odgałęzień)* |
| `[63]` | **"Raise your glass."** | `[49]` **Narrator**: "The three of us gathered around ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Player**: ""I know the past four years have..."<br>`[96]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych odgałęzień)* |
| `[64]` | **"Tap on the side of your glass."** | `[49]` **Narrator**: "The three of us gathered around ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Player**: ""I know the past four years have..."<br>`[96]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych odgałęzień)* |
| `[65]` | **""You might be right.""** | `[59]` **Deana**: ""I won a prize at the science fa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Narrator**: "Deana smiled." |
| `[66]` | **""That's just silly.""** | `[59]` **Deana**: ""I won a prize at the science fa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Narrator**: "Deana smiled." |
| `[67]` | **""Well, *I* care.""** | `[60]` **Deana**: ""I won a prize at the handicraft..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Narrator**: "Deana smiled." |
| `[68]` | **""She's just jealous because she was always bad at sewing.""** | `[60]` **Deana**: ""I won a prize at the handicraft..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Narrator**: "Deana smiled." |
| `[69]` | **"Hug her from behind."** | `[94]` **Narrator**: "I stepped into the kitchen. Moni..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Monica**: ""God, Anton, don't startle me li..."<br>`[165]` **Narrator**: "When she realized it was me, she..." |
| `[93]` | **""I know the past four years have been hard on all of us.""** | `[62]` **Player**: ""Now that we're all here, I want..."<br>`[63]` **Player_Italic**: "I raised my glass for a toast. M..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Player**: ""I was so busy focusing on the n..."<br>`[124]` **Player**: ""I know I haven't been there for..."<br>*(oraz 2 innych odgałęzień)* |
| `[96]` | **""The past four years have been the hardest in my life.""** | `[62]` **Player**: ""Now that we're all here, I want..."<br>`[63]` **Player_Italic**: "I raised my glass for a toast. M..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Player**: ""I was so busy focusing on the n..."<br>`[124]` **Player**: ""I know I haven't been there for..."<br>*(oraz 2 innych odgałęzień)* |
| `[97]` | **""The past four years have tested our strength as a family.""** | `[62]` **Player**: ""Now that we're all here, I want..."<br>`[63]` **Player_Italic**: "I raised my glass for a toast. M..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Player**: ""I was so busy focusing on the n..."<br>`[124]` **Player**: ""I know I haven't been there for..."<br>*(oraz 2 innych odgałęzień)* |
| `[98]` | **""Smells delicious.""** | `[94]` **Narrator**: "I stepped into the kitchen. Moni..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Narrator**: "Monica whirled around in surprise." |
| `[115]` | **""I hope someday, we'll be able to put this behind us and be a normal family again.""** | `[123]` **Player**: ""I was so busy focusing on the n..."<br>`[124]` **Player**: ""I know I haven't been there for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "Monica's eyes were shining." |
| `[119]` | **""Can't a man greet his wife?""** | `[5]` **Monica**: ""God, Anton, don't startle me li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Monica**: ""Yes, of course. Just walk in a ..." |
| `[121]` | **""You're right. That was a close call.""** | `[5]` **Monica**: ""God, Anton, don't startle me li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Monica**: ""It wasn't a 'close call' for Se..."<br>`[170]` **Monica**: ""I haven't been that scared for ..." |
| `[123]` | **""I was so busy focusing on the needs of the Sordish people that I sometimes forgot..."** | `[93]` **Player**: ""I know the past four years have..."<br>`[96]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Player**: ""I hope someday, we'll be able t..."<br>`[155]` **Player**: ""I hope I can make it up to you ..." |
| `[124]` | **""I know I haven't been there for either of you as much as I should have.""** | `[93]` **Player**: ""I know the past four years have..."<br>`[96]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Player**: ""I hope someday, we'll be able t..."<br>`[155]` **Player**: ""I hope I can make it up to you ..." |
| `[125]` | **""I'm so grateful to both of you for supporting me through it all.""** | `[93]` **Player**: ""I know the past four years have..."<br>`[96]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Player**: ""We deserve some time off togeth..."<br>`[178]` **Player**: ""We deserve to celebrate."" |
| `[147]` | **""The military is after me. After what happened at the parade, I'm not safe -- and ..."** | `[108]` **Monica**: ""Anton, what in the everloving h..." | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[141]` **Narrator**: "Deana looked at me in disbelief...." |
| `[148]` | **""I'm about to be the first president in Sordish history to get impeached. I'll be ..."** | `[108]` **Monica**: ""Anton, what in the everloving h..." | `Variable["BaseGame.Ending_ImpeachmentTrial"] == true` | *Brak zmian stanu* | `[135]` **Narrator**: "Deana scratched her head." |
| `[149]` | **""I've just signed part of my own country over to Rumburg. I'm going to be a pariah..."** | `[108]` **Monica**: ""Anton, what in the everloving h..." | `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true` | *Brak zmian stanu* | `[135]` **Narrator**: "Deana scratched her head." |
| `[150]` | **""Franc never took his studies so seriously.""** | `[142]` **Deana**: ""Almost forgot that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Narrator**: "Deana frowned."<br>`[100]` **Deana**: ""He does now. He wrote me and sa..."<br>*(oraz 3 innych odgałęzień)* |
| `[151]` | **""I can and I will.""** | `[61]` **Monica**: ""Anton, you can't do that. Not f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Narrator**: "Monica sighed heavily."<br>`[263]` **Narrator**: "Monica slammed her hand down on ..." |
| `[152]` | **""It's not just for your sake. I'm sick and tired of this game. I want out.""** | `[61]` **Monica**: ""Anton, you can't do that. Not f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Narrator**: "Monica sighed heavily."<br>`[263]` **Narrator**: "Monica slammed her hand down on ..." |
| `[153]` | **""What do you hear from your brother these days?""** | `[142]` **Deana**: ""Almost forgot that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Deana**: ""He doesn't call home so much no..."<br>`[137]` **Deana**: ""I think he's getting really int..."<br>*(oraz 3 innych odgałęzień)* |
| `[155]` | **""I hope I can make it up to you someday.""** | `[123]` **Player**: ""I was so busy focusing on the n..."<br>`[124]` **Player**: ""I know I haven't been there for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "Monica's eyes were shining." |
| `[176]` | **""I'm so proud of us for getting through it all together.""** | `[93]` **Player**: ""I know the past four years have..."<br>`[96]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Player**: ""We deserve some time off togeth..."<br>`[178]` **Player**: ""We deserve to celebrate."" |
| `[177]` | **""We deserve some time off together as a family.""** | `[125]` **Player**: ""I'm so grateful to both of you ..."<br>`[176]` **Player**: ""I'm so proud of us for getting ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "Monica's eyes were shining." |
| `[178]` | **""We deserve to celebrate.""** | `[125]` **Player**: ""I'm so grateful to both of you ..."<br>`[176]` **Player**: ""I'm so proud of us for getting ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "Monica's eyes were shining." |
| `[185]` | **""Nobody will listen to you once I'm out of office. Sorry.""** | `[184]` **Monica**: ""I don't know about this, Anton...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Monica**: ""You may be right. I just hate t..." |
| `[186]` | **""I know, and you'll be able to come back to that. But we need to lay low for a whi..."** | `[184]` **Monica**: ""I don't know about this, Anton...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Monica**: ""I-- you might be right."" |
| `[187]` | **""Monica. You know I only did what I did because I had to.""** | `[183]` **Monica**: ""But the things your father's do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Monica**: ""The ends don't justify the means."" |
| `[188]` | **""Monica, everything I did was for you!""** | `[183]` **Monica**: ""But the things your father's do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Monica**: ""The ends don't justify the means."" |
| `[193]` | **""Monica. You know I only did what I did because I had to.""** | `[194]` **Monica**: ""But the things your father's do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Monica**: ""The ends don't justify the means."" |
| `[196]` | **""Monica, everything I did was for you!""** | `[194]` **Monica**: ""But the things your father's do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Monica**: ""The ends don't justify the means."" |
| `[197]` | **""I know, and you'll be able to come back to that. But we need to lay low for a whi..."** | `[195]` **Monica**: ""I don't know about this, Anton...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Monica**: ""You might be right."" |
| `[198]` | **""You won't be able to fight for women's rights from a cell. Or a grave.""** | `[195]` **Monica**: ""I don't know about this, Anton...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Monica**: ""My God, Anton. You think it's t..." |
| `[202]` | **""Kyrute. It's going to be an adventure.""** | `[201]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Monica**: ""We're not going anywhere, Deana..." |
| `[203]` | **""You'll find out once we get there. It'll be a surprise.""** | `[201]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Monica**: ""We're not going anywhere, Deana..." |
| `[211]` | **""Kyrute. It's going to be an adventure.""** | `[210]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Deana**: ""But what about school? What abo..." |
| `[212]` | **""You'll find out once we get there. It'll be a surprise.""** | `[210]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Deana**: ""But what about school? What abo..." |
| `[219]` | **""Tomorrow morning. Let's get packing.""** | `[218]` **Monica**: ""All right, Anton. When do we le..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Exile_LeaveNow"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[244]` **Narrator**: "Monica's face paled. She nodded ..." |
| `[220]` | **""We'll leave in a week. I need to make sure our tracks are covered first.""** | `[218]` **Monica**: ""All right, Anton. When do we le..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[244]` **Narrator**: "Monica's face paled. She nodded ..." |
| `[222]` | **""Tomorrow morning. I've got to get packing.""** | `[221]` **Monica**: ""When will you leave?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Exile_LeaveNow"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[233]` **Deana**: ""Papa, no! You can't leave us!"" |
| `[223]` | **""We'll leave in a week. I need to make sure our tracks are covered first.""** | `[221]` **Monica**: ""When will you leave?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[233]` **Deana**: ""Papa, no! You can't leave us!"" |
| `[224]` | **""I'm not going anywhere without you.""** | `[221]` **Monica**: ""When will you leave?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Narrator**: "Monica's lips formed a thin line." |
| `[228]` | **""All right, all right. Let's finish dinner.""** | `[227]` **Monica**: ""And Anton, you and I are going ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Narrator**: "The three of us finished our foo..." |
| `[229]` | **""I've lost my appetite. I'll see you two later.""** | `[227]` **Monica**: ""And Anton, you and I are going ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Narrator**: "I cleared my plate and went up t..." |
| `[235]` | **""I'll come back soon.""** | `[234]` **Monica**: ""It's better this way, sweetheart."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Monica**: ""Let's finish dinner, at least."" |
| `[236]` | **""I'll call all the time.""** | `[234]` **Monica**: ""It's better this way, sweetheart."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Monica**: ""Let's finish dinner, at least."" |
| `[238]` | **""All right.""** | `[237]` **Monica**: ""Let's finish dinner, at least."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Narrator**: "The three of us ate in tense sil..." |
| `[239]` | **""No, I don't have time.""** | `[237]` **Monica**: ""Let's finish dinner, at least."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Narrator**: "I took a last look at Monica and..." |
| `[247]` | **""All right.""** | `[246]` **Monica**: ""Let's finish dinner, at least."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Narrator**: "We ate in tense silence. I could..." |
| `[249]` | **""No, we don't have time.""** | `[246]` **Monica**: ""Let's finish dinner, at least."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Narrator**: "We hurriedly cleared our plates ..." |
| `[269]` | **""Oh, we're getting as far away from Holsord as possible.""** | `[268]` **Deana**: ""Does that mean we're not gonna ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Narrator**: "As I spoke, I felt like a weight..." |
| `[270]` | **""We could stay here, but we don't have to. We can do whatever we want.""** | `[268]` **Deana**: ""Does that mean we're not gonna ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Narrator**: "As I spoke, I felt like a weight..." |
| `[273]` | **""And I won't stop fighting for the causes I believe in, too. From a distance.""** | `[272]` **Monica**: ""I'm still going to keep fightin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Narrator**: "Monica and I smiled at each other." |
| `[274]` | **""Well, I'm done with politics. Full stop. I'll take up farming or something.""** | `[272]` **Monica**: ""I'm still going to keep fightin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Narrator**: "Monica and I smiled at each other." |
| `[278]` | **""Of course.""** | `[277]` **Monica**: ""Can we finish dinner now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Narrator**: "The three of us dug into our foo..." |
| `[279]` | **""You two go ahead. I have to write my retirement speech.""** | `[277]` **Monica**: ""Can we finish dinner now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Narrator**: "I cleared my plate and went up t..." |
| `[285]` | **""I-- you're right. I don't know what I'm talking about.""** | `[284]` **Deana**: ""Yeah, Papa. You've gotta stay s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[295]` **Monica**: ""Good. Because I'll be damned if..."<br>`[296]` **Monica**: ""It's settled then. You'll fight..." |
| `[286]` | **""I'm sorry. But this is for the best.""** | `[284]` **Deana**: ""Yeah, Papa. You've gotta stay s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Monica**: ""The best? You think that witch ..."<br>`[291]` **Monica**: ""I'm disappointed in you, Anton...." |
| `[297]` | **""Yes. For you two.""** | `[296]` **Monica**: ""It's settled then. You'll fight..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[299]` **Narrator**: "Monica and I smiled at each other." |
| `[298]` | **""Yes. For Sordland.""** | `[296]` **Monica**: ""It's settled then. You'll fight..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[299]` **Narrator**: "Monica and I smiled at each other." |
| `[301]` | **""Of course.""** | `[300]` **Deana**: ""Can we finish dinner now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Narrator**: "The three of us ate and animated..." |
| `[302]` | **""You two go ahead. I'm going to my study.""** | `[300]` **Deana**: ""Can we finish dinner now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Narrator**: "I cleared my plate and went upst..." |
| `[322]` | **""And I won't stop fighting for the causes I believe in, too. From a distance.""** | `[319]` **Monica**: ""I'm still going to keep fightin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Narrator**: "Monica and I smiled at each other." |
| `[324]` | **""Well, I'm done with politics. Full stop. I'll take up farming or something.""** | `[319]` **Monica**: ""I'm still going to keep fightin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Narrator**: "Monica and I smiled at each other." |
| `[326]` | **""Of course.""** | `[325]` **Monica**: ""Can we finish dinner now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[328]` **Narrator**: "The three of us ate and animated..." |
| `[327]` | **""You two go ahead. I'm going to my study.""** | `[325]` **Monica**: ""Can we finish dinner now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Narrator**: "I cleared my plate and went upst..." |
| `[354]` | **""Ladies' choice.""** | `[353]` **Deana**: ""Where are we gonna go?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Narrator**: "Monica and Deana grinned at each..." |
| `[355]` | **""We'll go to the Benfi coast.""** | `[353]` **Deana**: ""Where are we gonna go?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Narrator**: "Monica and Deana grinned at each..." |
| `[356]` | **""We'll go to our vineyard in Erlory.""** | `[353]` **Deana**: ""Where are we gonna go?"" | `Variable["BaseGame.Turn05_P_Vineyard"] == true` | *Brak zmian stanu* | `[357]` **Narrator**: "Monica and Deana grinned at each..." |
| `[362]` | **""Of course.""** | `[361]` **Deana**: ""Can we finish dinner now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[364]` **Narrator**: "The three of us ate and animated..." |
| `[363]` | **""You two go ahead. I'm going to my study.""** | `[361]` **Deana**: ""Can we finish dinner now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[365]` **Narrator**: "I cleared my plate and went upst..." |
| `[367]` | **""What? Why?""** | `[366]` **Monica**: ""Anton, I think you should quit ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Monica**: ""With everything that's happened..." |
| `[368]` | **""I can't. I've come too far.""** | `[366]` **Monica**: ""Anton, I think you should quit ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Monica**: ""With everything that's happened..." |
| `[369]` | **""Honestly, I've been having similar thoughts.""** | `[366]` **Monica**: ""Anton, I think you should quit ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Monica**: ""With everything that's happened..." |
| `[378]` | **""Okay. You've made your point. I'll retire.""** | `[377]` **Monica**: ""You being President -- it hasn'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Narrator**: "Monica gave me a look of gratitude." |
| `[379]` | **""Sorry, Monica. I've got to keep going.""** | `[377]` **Monica**: ""You being President -- it hasn'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[382]` **Narrator**: "Monica's lips formed a thin line." |
| `[385]` | **""Of course.""** | `[384]` **Deana**: ""Can we finish dinner now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[386]` **Narrator**: "The three of us finished our foo..." |
| `[387]` | **""You two go ahead. I'm going to my study.""** | `[384]` **Deana**: ""Can we finish dinner now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Narrator**: "I cleared my plate and went upst..." |
| `[395]` | **""Oh, we're getting as far away from Holsord as possible.""** | `[318]` **Deana**: ""Does that mean we're not gonna ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Narrator**: "As I spoke, I felt like a weight..." |
| `[396]` | **""We could stay here, but we don't have to. We can do whatever we want.""** | `[318]` **Deana**: ""Does that mean we're not gonna ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Narrator**: "As I spoke, I felt like a weight..." |
| `[410]` | **""I never thought I would be a pariah.""** | `[108]` **Monica**: ""Anton, what in the everloving h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Narrator**: "Deana scratched her head." |

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
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Deana: ""She's in the kitchen.""*)

### Węzeł `[3]`
Mówca: **Narrator**
> "Monica's eyes were shining."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Monica whirled around in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[5]`
Mówca: **Monica**
> ""God, Anton, don't startle me like that! You know I'm still on edge after the parade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""You're right. That was a close call.""*)
  - -> `[119]` (*Player: ""Can't a man greet his wife?""*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""Yes, and damn proud of it.""]** — Mówca: **Player**
> ""Yes, and damn proud of it.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Capitalist"] > 5`
- **Kontekst wejściowy (poprzednik):** `[134]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Monica appeared in the doorway. She smiled at the two of us."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Deana smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Deana: ""Mama's in there. I've gotta do some homework before dinn..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""Franc's just been spending too much time in Arcasia, sweetie.""]** — Mówca: **Player**
> ""Franc's been spending too much time in Arcasia, sweetie.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Monica appeared in the doorway. She smiled at the two of us."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: ""Not if I have anything to do with it.""]** — Mówca: **Player**
> ""Not if I have anything to do with it.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Malenyevist"] > 5) == false`
- **Kontekst wejściowy (poprzednik):** `[136]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Monica appeared in the doorway. She smiled at the two of us."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: ""Yes, and damn proud of it.""]** — Mówca: **Player**
> ""Yes, and damn proud of it.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Malenyevist"] > 5`
- **Kontekst wejściowy (poprzednik):** `[136]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Monica appeared in the doorway. She smiled at the two of us."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "The usual crowd of protesters was waiting for me outside ..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "I didn't know if it was my imagination, but there seemed ..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Not if I have anything to do with it.""]** — Mówca: **Player**
> ""Not if I have anything to do with it.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Capitalist"] > 5) == false`
- **Kontekst wejściowy (poprzednik):** `[134]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Monica appeared in the doorway. She smiled at the two of us."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""Franc's just been spending too much time in United Contana, sweetie.""]** — Mówca: **Player**
> ""Franc's been spending too much time in United Contana, sweetie.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Monica appeared in the doorway. She smiled at the two of us."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""If he sacrifices himself for the sake of the country, that will be his decision.""]** — Mówca: **Player**
> ""If he sacrifices himself for the sake of the country, that will be his decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Deana: ""But--""*)

### Węzeł `[17]`
Mówca: **Narrator**
> "I didn't know if it was my imagination, but there seemed to be more guards outside my complex than usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[18]`
Mówca: **Narrator**
> "The usual crowd of protesters was waiting for me outside the gates of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The guards formed a cordon to let me through."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "The guards formed a cordon to let me through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""No, of course not.""]** — Mówca: **Player**
> ""No, of course not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Deana: ""But--""*)

### Węzeł `[21]`
Mówca: **Deana**
> ""But--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Monica appeared in the doorway. She smiled at the two of us."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Italic: "Give the guards a suspicious look."*)
  - -> `[27]` (*Player_Italic: "Don't look at them and go to your door."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "I hurried past them, went inside and locked the front doo..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""No, I've learned my lesson.""]** — Mówca: **Player**
> ""No, I've learned my lesson.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Monica appeared in the doorway. She smiled at the two of us."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Only if you show more gratitude for it than he did.""]** — Mówca: **Player**
> ""Only if you show more gratitude for it than he did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Monica appeared in the doorway. She smiled at the two of us."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "Don't look at them and go to your door."]** — Mówca: **Player_Italic**
> "I rushed past the guards to my door."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_Coup"] == true`
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator), `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Once inside, I locked the front door behind me."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "Give the guards a suspicious look."]** — Mówca: **Player_Italic**
> "I regarded them with suspicion as I passed. With the military against me, could they be trusted?"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_Coup"] == true`
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator), `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Once inside, I locked the front door behind me."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""Just keep studying so we'll never have to find out.""]** — Mówca: **Player**
> ""Just keep studying so we'll never have to find out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Monica appeared in the doorway. She smiled at the two of us."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""What? Of course not.""]** — Mówca: **Player**
> ""What? Of course not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Monica appeared in the doorway. She smiled at the two of us."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""It's complicated.""]** — Mówca: **Player**
> ""It's complicated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Monica appeared in the doorway. She smiled at the two of us."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == true)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Deana: ""He doesn't call home so much now that the troops are get..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Deana: ""I think he's getting really into his army training.""*)

### Węzeł `[35]`
Mówca: **Narrator**
> "Once inside, I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "I hurried past them, went inside and locked the front doo..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "I hurried past them, went inside and locked the front door behind me. I heard footsteps coming my way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Deana: ""Hi, Papa.""*)

### Węzeł `[37]`
Mówca: **Deana**
> ""Hi, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Italic: "Hug her."*)
  - -> `[45]` (*Player: ""Deana! How was school today?""*)
  - -> `[46]` (*Player: ""Where's your mother?""*)

### Węzeł `[38]`
Mówca: **Deana**
> ""Not much. He writes me letters sometimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Deana: ""Papa, are we a 'socialist hive mind'?""*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""But right now, there's no time. We need to get out of Sordland. All of us.""]** — Mówca: **Player**
> ""But right now, there's no time. We need to get out of Sordland. All of us.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Monica and Deana turned to look at me in shock."*)

### Węzeł `[40]`
Mówca: **Deana**
> ""Not much. He writes me letters sometimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Deana: ""Papa, are we 'bourgeoisie pigs'?""*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Once the election's over, I'm taking you both on holiday.""]** — Mówca: **Player**
> ""Once the election's over, I'm taking you both on holiday.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)

### Węzeł `[42]`
Mówca: **Deana**
> ""Not much. He doesn't call as often now that he's got a girlfriend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Deana: ""Papa, is it true how he got into Holsord State? Would yo..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Monica appeared in the doorway. She smiled at the two of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Monica: ""Dinner's ready.""*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "Hug her."]** — Mówca: **Player_Italic**
> "I opened my arms to embrace my daughter. She hugged me back happily."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: ""How was school today?""*)
  - -> `[53]` (*Player: ""Where's your mother?""*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""Deana! How was school today?""]** — Mówca: **Player**
> ""Deana! How was school today?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Deana shrugged."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""Where's your mother?""]** — Mówca: **Player**
> ""Where's your mother?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Deana: ""She's in the kitchen.""*)

### Węzeł `[47]`
Mówca: **Monica**
> ""Dinner's ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "The three of us gathered around the dining room table. Mo..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: ""And we'll have plenty of time for that, because I'm retiring from politics at the end of this term.""]** — Mówca: **Player**
> ""And we'll have plenty of time for that, because I'm retiring from politics at the end of this term.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "Monica and Deana looked at me in shock."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "The three of us gathered around the dining room table. Monica ladled out bowls full of zabla. The stew tasted as good as it smelled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: ""Now that we're all here, I wanted to say something.""*)
  - -> `[63]` (*Player_Italic: "Raise your glass."*)
  - -> `[64]` (*Player_Italic: "Tap on the side of your glass."*)

### Węzeł `[50]`
Mówca: **Deana**
> ""She's in the kitchen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Deana: ""I've gotta do some homework before dinner.""*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Deana shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_ExcellentWomenRights == true ||Bas..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""How was school today?""]** — Mówca: **Player**
> ""How was school today?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Deana shrugged."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Where's your mother?""]** — Mówca: **Player**
> ""Where's your mother?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Deana: ""She's in the kitchen.""*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_ExcellentWomenRights == true ||Bas..."*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_ExcellentWomenRights == true ||B..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Deana: ""I won a prize at the science fair. Honestly, I think the..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Deana: ""I won a prize at the handicrafts fair. Mama didn't seem ..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""And we'll have plenty of time for that after my presidency ends.""]** — Mówca: **Player**
> ""And we'll have plenty of time for that after my presidency ends.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""My retirement from politics is going to be the best thing that ever happened to us.""]** — Mówca: **Player**
> ""My retirement from politics is going to be the best thing that ever happened to us.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)

### Węzeł `[59]`
Mówca: **Deana**
> ""I won a prize at the science fair. Honestly, I think they were teaching girls different stuff before 'cause they knew we were smarter than boys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""You might be right.""*)
  - -> `[66]` (*Player: ""That's just silly.""*)

### Węzeł `[60]`
Mówca: **Deana**
> ""I won a prize at the handicrafts fair. Mama didn't seem to care that much, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""Well, *I* care.""*)
  - -> `[68]` (*Player: ""She's just jealous because she was always bad at sewing.""*)

### Węzeł `[61]`
Mówca: **Monica**
> ""Anton, you can't do that. Not for my sake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: ""It's not just for your sake. I'm sick and tired of this ..."*)
  - -> `[151]` (*Player: ""I can and I will.""*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""Now that we're all here, I wanted to say something.""]** — Mówca: **Player**
> ""Now that we're all here, I wanted to say something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: ""I know the past four years have been hard on all of us.""*)
  - -> `[96]` (*Player: ""The past four years have been the hardest in my life.""*)
  - -> `[97]` (*Player: ""The past four years have tested our strength as a family.""*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "Raise your glass."]** — Mówca: **Player_Italic**
> "I raised my glass for a toast. Monica and Deana slowly followed suit, looking puzzled."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: ""I know the past four years have been hard on all of us.""*)
  - -> `[96]` (*Player: ""The past four years have been the hardest in my life.""*)
  - -> `[97]` (*Player: ""The past four years have tested our strength as a family.""*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "Tap on the side of your glass."]** — Mówca: **Player_Italic**
> "I tapped on the side of my glass for attention. Monica and Deana looked at me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: ""I know the past four years have been hard on all of us.""*)
  - -> `[96]` (*Player: ""The past four years have been the hardest in my life.""*)
  - -> `[97]` (*Player: ""The past four years have tested our strength as a family.""*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""You might be right.""]** — Mówca: **Player**
> ""You might be right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Deana smiled."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""That's just silly.""]** — Mówca: **Player**
> ""That's just silly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Deana smiled."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Well, *I* care.""]** — Mówca: **Player**
> ""Well, *I* care.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Deana smiled."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""She's just jealous because she was always bad at sewing.""]** — Mówca: **Player**
> ""She's just jealous because she was always bad at sewing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Deana smiled."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "Hug her from behind."]** — Mówca: **Player_Italic**
> "I snuck up behind Monica and gave her a hug. She screamed and dropped her ladle."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[70]`
Mówca: **Deana**
> ""Papa, is Franc going to die fighting the Rummies?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: ""No, of course not.""*)
  - -> `[16]` (*Player: ""If he sacrifices himself for the sake of the country, th..."*)

### Węzeł `[71]`
Mówca: **Deana**
> ""Papa, is Sordland 'run by a bunch of weaklings'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""What? Of course not.""*)
  - -> `[31]` (*Player: ""It's complicated.""*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: ""My retirement from politics is going to be the best thin..."*)
  - -> `[57]` (*Player: ""And we'll have plenty of time for that after my presiden..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: ""And we'll have plenty of time for that, because I'm reti..."*)
  - -> `[41]` (*Player: ""Once the election's over, I'm taking you both on holiday.""*)

### Węzeł `[75]`
Mówca: **Narrator**
> "Monica and Deana turned to look at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Monica: ""Anton, what in the everloving hell?""*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist > 5"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Capitalist > 5)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Capitalist"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: ""Yes, and damn proud of it.""*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Capitalist > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Capitalist"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""Not if I have anything to do with it.""*)

### Węzeł `[79]`
Mówca: **Narrator**
> "Deana frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Deana: ""Papa, is Franc going to die fighting the Rummies?""*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 5"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist > 5)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: ""Yes, and damn proud of it.""*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: ""Not if I have anything to do with it.""*)

### Węzeł `[83]`
Mówca: **Deana**
> ""Papa, is it true how he got into Holsord State? Would you do that for me, too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""No, I've learned my lesson.""*)
  - -> `[26]` (*Player: ""Only if you show more gratitude for it than he did.""*)
  - -> `[29]` (*Player: ""Just keep studying so we'll never have to find out.""*)

### Węzeł `[84]`
Mówca: **Deana**
> ""I've gotta do some homework before dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "I followed her with my eyes as she went upstairs. She was..."*)

### Węzeł `[85]`
Mówca: **Deana**
> ""Mama's in there. I've gotta do some homework before dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "I followed her with my eyes as she went upstairs. She was..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_FrancConscripted == true || Ba..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[89]`
Mówca: **Narrator**
> "I followed her with my eyes as she went upstairs. She was starting to look more and more like her mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I stepped into the kitchen. Monica was stirring a pot on ..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Deana: ""He does now. He told me so in one of his letters.""*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""I know the past four years have been hard on all of us.""]** — Mówca: **Player**
> ""I know the past four years have been hard on all of us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Player), `[63]` (Player_Italic), `[64]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""I was so busy focusing on the needs of the Sordish peopl..."*)
  - -> `[124]` (*Player: ""I know I haven't been there for either of you as much as..."*)
  - -> `[125]` (*Player: ""I'm so grateful to both of you for supporting me through..."*)
  - -> `[176]` (*Player: ""I'm so proud of us for getting through it all together.""*)

### Węzeł `[94]`
Mówca: **Narrator**
> "I stepped into the kitchen. Monica was stirring a pot on the stove, her back turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Italic: "Hug her from behind."*)
  - -> `[98]` (*Player: ""Smells delicious.""*)

### Węzeł `[95]`
Mówca: **Monica**
> ""Of course not, sweetie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 5"*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""The past four years have been the hardest in my life.""]** — Mówca: **Player**
> ""The past four years have been the hardest in my life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Player), `[63]` (Player_Italic), `[64]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""I was so busy focusing on the needs of the Sordish peopl..."*)
  - -> `[124]` (*Player: ""I know I haven't been there for either of you as much as..."*)
  - -> `[125]` (*Player: ""I'm so grateful to both of you for supporting me through..."*)
  - -> `[176]` (*Player: ""I'm so proud of us for getting through it all together.""*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""The past four years have tested our strength as a family.""]** — Mówca: **Player**
> ""The past four years have tested our strength as a family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Player), `[63]` (Player_Italic), `[64]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""I was so busy focusing on the needs of the Sordish peopl..."*)
  - -> `[124]` (*Player: ""I know I haven't been there for either of you as much as..."*)
  - -> `[125]` (*Player: ""I'm so grateful to both of you for supporting me through..."*)
  - -> `[176]` (*Player: ""I'm so proud of us for getting through it all together.""*)

### Węzeł `[98]`
**[WYBÓR GRACZA: ""Smells delicious.""]** — Mówca: **Player**
> ""Smells delicious.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Monica whirled around in surprise."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "Monica and Deana looked at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Monica: ""Anton, you can't do that. Not for my sake.""*)

### Węzeł `[100]`
Mówca: **Deana**
> ""He does now. He wrote me and said  he's getting really into his army training.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Deana: ""Papa, is Sordland 'run by a bunch of weaklings'?""*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_GivenEstordAndNarbel == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: ""I've just signed part of my own country over to Rumburg...."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Monica: ""God, Anton, don't startle me like that! You know I'm sti..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "When she realized it was me, she smiled and gave me a kis..."*)

### Węzeł `[107]`
Mówca: **Deana**
> ""He does now. He told me so in one of his letters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Deana: ""Papa, is it true how he got into Holsord State? Would yo..."*)

### Węzeł `[108]`
Mówca: **Monica**
> ""Anton, what in the everloving hell?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[410]` (*Player: ""I never thought I would be a pariah.""*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_ImpeachmentTrial == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""I'm about to be the first president in Sordish history t..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player: ""The military is after me. After what happened at the par..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[115]`
**[WYBÓR GRACZA: ""I hope someday, we'll be able to put this behind us and be a normal family again.""]** — Mówca: **Player**
> ""I hope someday, we'll be able to put this behind us and be a normal family again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Player), `[124]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Monica's eyes were shining."*)

### Węzeł `[116]`
Mówca: **Deana**
> ""Are they gonna kill us like they killed Serge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Monica's brow was furrowed."*)

### Węzeł `[117]`
Mówca: **Deana**
> ""Are they gonna try to kill us like they tried to kill Papa?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Monica's brow was furrowed."*)

### Węzeł `[118]`
Mówca: **Monica**
> ""It's an outcast, sweetie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 5"*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""Can't a man greet his wife?""]** — Mówca: **Player**
> ""Can't a man greet his wife?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Monica: ""Yes, of course. Just walk in a little more loudly next t..."*)

### Węzeł `[120]`
Mówca: **Monica**
> ""Sorry, Anton. I guess I've been on edge lately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Monica: ""Why don't you go fix yourself a drink in the living room..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""You're right. That was a close call.""]** — Mówca: **Player**
> ""You're right. That was a close call.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[122]`
Mówca: **Monica**
> ""Yes, of course. Just walk in a little more loudly next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Monica: ""Why don't you go fix yourself a drink in the living room..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""I was so busy focusing on the needs of the Sordish people that I sometimes forgot about Sordland's most important people: my own wife and daughter.""]** — Mówca: **Player**
> ""I was so busy focusing on the needs of the Sordish people that I sometimes forgot about Sordland's most important people: my own wife and daughter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Player), `[96]` (Player), `[97]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: ""I hope someday, we'll be able to put this behind us and ..."*)
  - -> `[155]` (*Player: ""I hope I can make it up to you someday.""*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""I know I haven't been there for either of you as much as I should have.""]** — Mówca: **Player**
> ""I know I haven't been there for either of you as much as I should have.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Player), `[96]` (Player), `[97]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: ""I hope someday, we'll be able to put this behind us and ..."*)
  - -> `[155]` (*Player: ""I hope I can make it up to you someday.""*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""I'm so grateful to both of you for supporting me through it all.""]** — Mówca: **Player**
> ""I'm so grateful to both of you for supporting me through it all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Player), `[96]` (Player), `[97]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: ""We deserve some time off together as a family.""*)
  - -> `[178]` (*Player: ""We deserve to celebrate.""*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Deana: ""Are they gonna kill us like they killed Serge?""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Deana: ""Are they gonna try to kill us like they tried to kill Pa..."*)

### Węzeł `[129]`
Mówca: **Deana**
> ""What's a pariah?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Monica: ""It's an outcast, sweetie.""*)

### Węzeł `[130]`
Mówca: **Deana**
> ""He doesn't call home so much now that the troops are getting ready for war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "Deana frowned."*)

### Węzeł `[131]`
Mówca: **Monica**
> ""Why don't you go fix yourself a drink in the living room? I'll let you know when dinner's ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "I sat down in the living room, poured myself a bit of whi..."*)

### Węzeł `[132]`
Mówca: **Deana**
> ""Mama? Is that true?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead"*)

### Węzeł `[133]`
Mówca: **Narrator**
> "I sat down in the living room, poured myself a bit of whiskey and flipped through one of Monica's women's magazines."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_LeadsWomensRights == true && Ba..."*)

### Węzeł `[134]`
Mówca: **Deana**
> ""Papa, are we 'bourgeoisie pigs'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist > 5"*)
  - -> `[15]` (*Player: ""Franc's just been spending too much time in United Conta..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "Deana scratched her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Deana: ""What's a pariah?""*)

### Węzeł `[136]`
Mówca: **Deana**
> ""Papa, are we a 'socialist hive mind'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 5"*)
  - -> `[8]` (*Player: ""Franc's just been spending too much time in Arcasia, swe..."*)

### Węzeł `[137]`
Mówca: **Deana**
> ""I think he's getting really into his army training.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Deana: ""Papa, is Sordland 'run by a bunch of weaklings'?""*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == true)"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "Deana frowned."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Deana: ""He does now. He wrote me and said  he's getting really i..."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "Deana looked at me in disbelief. Her lower lip trembled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Deana: ""Mama? Is that true?""*)

### Węzeł `[142]`
Mówca: **Deana**
> ""Almost forgot that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: ""Franc never took his studies so seriously.""*)
  - -> `[153]` (*Player: ""What do you hear from your brother these days?""*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_FrancConscripted == true || Ba..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[146]`
Mówca: **Deana**
> ""He does now. He told me so in one of his letters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Deana: ""Papa, are we a 'socialist hive mind'?""*)

### Węzeł `[147]`
**[WYBÓR GRACZA: ""The military is after me. After what happened at the parade, I'm not safe -- and neither are you.""]** — Mówca: **Player**
> ""The military is after me. After what happened at the parade, I'm not safe -- and neither are you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[108]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "Deana looked at me in disbelief. Her lower lip trembled s..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""I'm about to be the first president in Sordish history to get impeached. I'll be a pariah, and so will both of you.""]** — Mówca: **Player**
> ""I'm about to be the first president in Sordish history to get impeached. I'll be a pariah, and so will both of you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Kontekst wejściowy (poprzednik):** `[108]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Deana scratched her head."*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I've just signed part of my own country over to Rumburg. I'm going to be a pariah, and so are all of you.""]** — Mówca: **Player**
> ""I've just signed part of my own country over to Rumburg. I'm going to be a pariah, and so are all of you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Kontekst wejściowy (poprzednik):** `[108]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Deana scratched her head."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""Franc never took his studies so seriously.""]** — Mówca: **Player**
> ""Franc never took his studies so seriously.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""I can and I will.""]** — Mówca: **Player**
> ""I can and I will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""It's not just for your sake. I'm sick and tired of this game. I want out.""]** — Mówca: **Player**
> ""It's not just for your sake. I'm sick and tired of this game. I want out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: ""What do you hear from your brother these days?""]** — Mówca: **Player**
> ""What do you hear from your brother these days?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)

### Węzeł `[154]`
Mówca: **Deana**
> ""He does now. He told me so in one of his letters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Deana: ""Papa, are we 'bourgeoisie pigs'?""*)

### Węzeł `[155]`
**[WYBÓR GRACZA: ""I hope I can make it up to you someday.""]** — Mówca: **Player**
> ""I hope I can make it up to you someday.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Player), `[124]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Monica's eyes were shining."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Deana: ""Not much. He writes me letters sometimes.""*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Deana: ""Not much. He doesn't call as often now that he's got a g..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Deana: ""Not much. He writes me letters sometimes.""*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Deana: ""He does now. He told me so in one of his letters.""*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Deana: ""He does now. He told me so in one of his letters.""*)

### Węzeł `[165]`
Mówca: **Narrator**
> "When she realized it was me, she smiled and gave me a kiss on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Monica: ""Sorry, Anton. I guess I've been on edge lately.""*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Monica: ""It wasn't a 'close call' for Serge.""*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Monica: ""I haven't been that scared for you since the ball.""*)

### Węzeł `[169]`
Mówca: **Monica**
> ""It wasn't a 'close call' for Serge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Monica: ""Why don't you go fix yourself a drink in the living room..."*)

### Węzeł `[170]`
Mówca: **Monica**
> ""I haven't been that scared for you since the ball.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Monica: ""Why don't you go fix yourself a drink in the living room..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_LeadsWomensRights == true && BaseGame.Enable_WomensRightsBill_Strong == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_LeadsWomensRights == true && Ba..."*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_LeadsWomensRights == true && ..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_LeadsWomensRights == true && BaseGame.Enable_WomensRightsBill_Strong == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_LeadsWomensRights"] == true  and  Variable["BaseGame.Enable_WomensRightsBill_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "It took me a second to realize Monica herself was on the ..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_LeadsWomensRights == true && BaseGame.Enable_WomensRightsBill_Strong == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_LeadsWomensRights"] == true  and  Variable["BaseGame.Enable_WomensRightsBill_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Deana came rushing back down the stairs and made a beelin..."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "It took me a second to realize Monica herself was on the cover. The headline: "Sordland's Woman of the Year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Deana came rushing back down the stairs and made a beelin..."*)

### Węzeł `[175]`
Mówca: **Narrator**
> "Deana came rushing back down the stairs and made a beeline for the coffee table. She picked up her pencil case."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Deana: ""Almost forgot that.""*)

### Węzeł `[176]`
**[WYBÓR GRACZA: ""I'm so proud of us for getting through it all together.""]** — Mówca: **Player**
> ""I'm so proud of us for getting through it all together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Player), `[96]` (Player), `[97]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: ""We deserve some time off together as a family.""*)
  - -> `[178]` (*Player: ""We deserve to celebrate.""*)

### Węzeł `[177]`
**[WYBÓR GRACZA: ""We deserve some time off together as a family.""]** — Mówca: **Player**
> ""We deserve some time off together as a family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Player), `[176]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Monica's eyes were shining."*)

### Węzeł `[178]`
**[WYBÓR GRACZA: ""We deserve to celebrate.""]** — Mówca: **Player**
> ""We deserve to celebrate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Player), `[176]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Monica's eyes were shining."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "Monica's brow was furrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Monica: ""Of course not, sweetie.""*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 5"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 5)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Monica: ""But the things your father's done... he's brought this o..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Monica: ""I don't know about this, Anton. I still have so much to ..."*)

### Węzeł `[183]`
Mówca: **Monica**
> ""But the things your father's done... he's brought this on himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Player: ""Monica. You know I only did what I did because I had to.""*)
  - -> `[188]` (*Player: ""Monica, everything I did was for you!""*)

### Węzeł `[184]`
Mówca: **Monica**
> ""I don't know about this, Anton. I still have so much to do for women's rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player: ""I know, and you'll be able to come back to that. But we ..."*)
  - -> `[185]` (*Player: ""Nobody will listen to you once I'm out of office. Sorry.""*)

### Węzeł `[185]`
**[WYBÓR GRACZA: ""Nobody will listen to you once I'm out of office. Sorry.""]** — Mówca: **Player**
> ""Nobody will listen to you once I'm out of office. Sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Monica: ""You may be right. I just hate the idea of losing all the..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA: ""I know, and you'll be able to come back to that. But we need to lay low for a while.""]** — Mówca: **Player**
> ""I know, and you'll be able to come back to that. But we need to lay low for a while.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Monica: ""I-- you might be right.""*)

### Węzeł `[187]`
**[WYBÓR GRACZA: ""Monica. You know I only did what I did because I had to.""]** — Mówca: **Player**
> ""Monica. You know I only did what I did because I had to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Monica: ""The ends don't justify the means.""*)

### Węzeł `[188]`
**[WYBÓR GRACZA: ""Monica, everything I did was for you!""]** — Mówca: **Player**
> ""Monica, everything I did was for you!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Monica: ""The ends don't justify the means.""*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 5"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 5)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Monica: ""But the things your father's done... he's brought this o..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Monica: ""I don't know about this, Anton. I still have so much to ..."*)

### Węzeł `[192]`
Mówca: **Monica**
> ""The ends don't justify the means.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[193]`
**[WYBÓR GRACZA: ""Monica. You know I only did what I did because I had to.""]** — Mówca: **Player**
> ""Monica. You know I only did what I did because I had to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Monica: ""The ends don't justify the means.""*)

### Węzeł `[194]`
Mówca: **Monica**
> ""But the things your father's done... he's brought this on himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player: ""Monica. You know I only did what I did because I had to.""*)
  - -> `[196]` (*Player: ""Monica, everything I did was for you!""*)

### Węzeł `[195]`
Mówca: **Monica**
> ""I don't know about this, Anton. I still have so much to do for women's rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player: ""I know, and you'll be able to come back to that. But we ..."*)
  - -> `[198]` (*Player: ""You won't be able to fight for women's rights from a cel..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA: ""Monica, everything I did was for you!""]** — Mówca: **Player**
> ""Monica, everything I did was for you!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Monica: ""The ends don't justify the means.""*)

### Węzeł `[197]`
**[WYBÓR GRACZA: ""I know, and you'll be able to come back to that. But we need to lay low for a while.""]** — Mówca: **Player**
> ""I know, and you'll be able to come back to that. But we need to lay low for a while.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Monica: ""You might be right.""*)

### Węzeł `[198]`
**[WYBÓR GRACZA: ""You won't be able to fight for women's rights from a cell. Or a grave.""]** — Mówca: **Player**
> ""You won't be able to fight for women's rights from a cell. Or a grave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Monica: ""My God, Anton. You think it's that bad?""*)

### Węzeł `[199]`
Mówca: **Narrator**
> "Deana still looked confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Deana: ""Papa, where are we going?""*)

### Węzeł `[200]`
Mówca: **Deana**
> ""Papa, where are we going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "I thought for a moment. Kyrute, the only truly neutral co..."*)

### Węzeł `[201]`
Mówca: **Narrator**
> "I thought for a moment. Kyrute, the only truly neutral country I knew of, seemed like the obvious choice. A little house in the mountains wouldn't cost much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player: ""Kyrute. It's going to be an adventure.""*)
  - -> `[203]` (*Player: ""You'll find out once we get there. It'll be a surprise.""*)

### Węzeł `[202]`
**[WYBÓR GRACZA: ""Kyrute. It's going to be an adventure.""]** — Mówca: **Player**
> ""Kyrute. It's going to be an adventure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Monica: ""We're not going anywhere, Deana. Only your father is.""*)

### Węzeł `[203]`
**[WYBÓR GRACZA: ""You'll find out once we get there. It'll be a surprise.""]** — Mówca: **Player**
> ""You'll find out once we get there. It'll be a surprise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Monica: ""We're not going anywhere, Deana. Only your father is.""*)

### Węzeł `[204]`
Mówca: **Monica**
> ""We're not going anywhere, Deana. Only your father is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "She looked at me apologetically."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "She looked at me apologetically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Monica: ""I'm sorry, Anton. I'm not going to uproot our lives here..."*)

### Węzeł `[206]`
Mówca: **Monica**
> ""My God, Anton. You think it's that bad?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[207]`
Mówca: **Monica**
> ""You might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "Deana still looked confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Deana: ""Papa, where are we going?""*)

### Węzeł `[209]`
Mówca: **Deana**
> ""Papa, where are we going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "I thought for a moment. Kyrute, the only truly neutral co..."*)

### Węzeł `[210]`
Mówca: **Narrator**
> "I thought for a moment. Kyrute, the only truly neutral country I knew of, seemed like the obvious choice. A little house in the mountains wouldn't cost much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player: ""Kyrute. It's going to be an adventure.""*)
  - -> `[212]` (*Player: ""You'll find out once we get there. It'll be a surprise.""*)

### Węzeł `[211]`
**[WYBÓR GRACZA: ""Kyrute. It's going to be an adventure.""]** — Mówca: **Player**
> ""Kyrute. It's going to be an adventure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Deana: ""But what about school? What about my friends?""*)

### Węzeł `[212]`
**[WYBÓR GRACZA: ""You'll find out once we get there. It'll be a surprise.""]** — Mówca: **Player**
> ""You'll find out once we get there. It'll be a surprise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Deana: ""But what about school? What about my friends?""*)

### Węzeł `[213]`
Mówca: **Monica**
> ""I-- you might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[214]`
Mówca: **Monica**
> ""You may be right. I just hate the idea of losing all the progress we've made...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[215]`
Mówca: **Monica**
> ""I'm sorry, Anton. I'm not going to uproot our lives here because of mistakes you made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Monica: ""When will you leave?""*)

### Węzeł `[216]`
Mówca: **Deana**
> ""But what about school? What about my friends?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Monica: ""You'll make lots of new friends. And Kyrute's school sys..."*)

### Węzeł `[217]`
Mówca: **Monica**
> ""You'll make lots of new friends. And Kyrute's school system is a lot better than Sordland's, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Monica: ""All right, Anton. When do we leave?""*)

### Węzeł `[218]`
Mówca: **Monica**
> ""All right, Anton. When do we leave?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player: ""Tomorrow morning. Let's get packing.""*)
  - -> `[220]` (*Player: ""We'll leave in a week. I need to make sure our tracks ar..."*)

### Węzeł `[219]`
**[WYBÓR GRACZA: ""Tomorrow morning. Let's get packing.""]** — Mówca: **Player**
> ""Tomorrow morning. Let's get packing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[220]`
**[WYBÓR GRACZA: ""We'll leave in a week. I need to make sure our tracks are covered first.""]** — Mówca: **Player**
> ""We'll leave in a week. I need to make sure our tracks are covered first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[221]`
Mówca: **Monica**
> ""When will you leave?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player: ""Tomorrow morning. I've got to get packing.""*)
  - -> `[223]` (*Player: ""We'll leave in a week. I need to make sure our tracks ar..."*)
  - -> `[224]` (*Player: ""I'm not going anywhere without you.""*)

### Węzeł `[222]`
**[WYBÓR GRACZA: ""Tomorrow morning. I've got to get packing.""]** — Mówca: **Player**
> ""Tomorrow morning. I've got to get packing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[223]`
**[WYBÓR GRACZA: ""We'll leave in a week. I need to make sure our tracks are covered first.""]** — Mówca: **Player**
> ""We'll leave in a week. I need to make sure our tracks are covered first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[224]`
**[WYBÓR GRACZA: ""I'm not going anywhere without you.""]** — Mówca: **Player**
> ""I'm not going anywhere without you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Narrator: "Monica's lips formed a thin line."*)

### Węzeł `[225]`
Mówca: **Narrator**
> "Monica's lips formed a thin line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Monica: ""Then the Raynes are staying put.""*)

### Węzeł `[226]`
Mówca: **Monica**
> ""Then the Raynes are staying put.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Monica: ""And Anton, you and I are going to have a serious talk on..."*)

### Węzeł `[227]`
Mówca: **Monica**
> ""And Anton, you and I are going to have a serious talk once this has blown over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player: ""All right, all right. Let's finish dinner.""*)
  - -> `[229]` (*Player: ""I've lost my appetite. I'll see you two later.""*)

### Węzeł `[228]`
**[WYBÓR GRACZA: ""All right, all right. Let's finish dinner.""]** — Mówca: **Player**
> ""All right, all right. Let's finish dinner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "The three of us finished our food in silence. When we had..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA: ""I've lost my appetite. I'll see you two later.""]** — Mówca: **Player**
> ""I've lost my appetite. I'll see you two later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "I cleared my plate and went up to my study."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "The three of us finished our food in silence. When we had cleared the plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "I still had plenty of work to do."*)

### Węzeł `[231]`
Mówca: **Narrator**
> "I still had plenty of work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[232]`
Mówca: **Narrator**
> "I cleared my plate and went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "I still had plenty of work to do."*)

### Węzeł `[233]`
Mówca: **Deana**
> ""Papa, no! You can't leave us!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Monica: ""It's better this way, sweetheart.""*)

### Węzeł `[234]`
Mówca: **Monica**
> ""It's better this way, sweetheart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player: ""I'll come back soon.""*)
  - -> `[236]` (*Player: ""I'll call all the time.""*)

### Węzeł `[235]`
**[WYBÓR GRACZA: ""I'll come back soon.""]** — Mówca: **Player**
> ""I'll come back soon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Monica: ""Let's finish dinner, at least.""*)

### Węzeł `[236]`
**[WYBÓR GRACZA: ""I'll call all the time.""]** — Mówca: **Player**
> ""I'll call all the time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Monica: ""Let's finish dinner, at least.""*)

### Węzeł `[237]`
Mówca: **Monica**
> ""Let's finish dinner, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Player: ""All right.""*)
  - -> `[239]` (*Player: ""No, I don't have time.""*)

### Węzeł `[238]`
**[WYBÓR GRACZA: ""All right.""]** — Mówca: **Player**
> ""All right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "The three of us ate in tense silence. I wondered if this ..."*)

### Węzeł `[239]`
**[WYBÓR GRACZA: ""No, I don't have time.""]** — Mówca: **Player**
> ""No, I don't have time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "I took a last look at Monica and Deana as I cleared my pl..."*)

### Węzeł `[240]`
Mówca: **Narrator**
> "The three of us ate in tense silence. I wondered if this would be our last dinner together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "I put that thought out of my mind as I cleared my plate a..."*)

### Węzeł `[241]`
Mówca: **Narrator**
> "I put that thought out of my mind as I cleared my plate and went up to the bedroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "I had a lot of packing to do."*)

### Węzeł `[242]`
Mówca: **Narrator**
> "I had a lot of packing to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[243]`
Mówca: **Narrator**
> "I took a last look at Monica and Deana as I cleared my plate and went up to the bedroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "I had a lot of packing to do."*)

### Węzeł `[244]`
Mówca: **Narrator**
> "Monica's face paled. She nodded silently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Deana: ""Cool! We're going on an adventure!""*)

### Węzeł `[245]`
Mówca: **Deana**
> ""Cool! We're going on an adventure!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Monica: ""Let's finish dinner, at least.""*)

### Węzeł `[246]`
Mówca: **Monica**
> ""Let's finish dinner, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player: ""All right.""*)
  - -> `[249]` (*Player: ""No, we don't have time.""*)

### Węzeł `[247]`
**[WYBÓR GRACZA: ""All right.""]** — Mówca: **Player**
> ""All right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[246]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "We ate in tense silence. I could tell Monica and Deana we..."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "We had a lot of packing to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou = true"*)

### Węzeł `[249]`
**[WYBÓR GRACZA: ""No, we don't have time.""]** — Mówca: **Player**
> ""No, we don't have time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[246]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "We hurriedly cleared our plates and went up to our rooms."*)

### Węzeł `[250]`
Mówca: **Narrator**
> "We ate in tense silence. I could tell Monica and Deana were both deep in thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "When we were done, we cleared our plates and went up to o..."*)

### Węzeł `[251]`
Mówca: **Narrator**
> "We hurriedly cleared our plates and went up to our rooms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "We had a lot of packing to do."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "When we were done, we cleared our plates and went up to our rooms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "We had a lot of packing to do."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumbur..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "Monica slammed her hand down on the table, surprising me ..."*)

### Węzeł `[256]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)

### Węzeł `[257]`
Mówca: **Monica**
> ""I suppose you don't have much of a chance of re-election, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Monica: ""And the things you did as President... maybe this is for..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Monica: ""There's still so much that needs to be done for Sordland..."*)

### Węzeł `[261]`
Mówca: **Monica**
> ""And the things you did as President... maybe this is for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[262]`
Mówca: **Monica**
> ""There's still so much that needs to be done for Sordland. But maybe you're not the one to do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[263]`
Mówca: **Narrator**
> "Monica slammed her hand down on the table, surprising me and Deana."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Monica: ""No. The Anton Rayne I married wouldn't give up so easily.""*)

### Węzeł `[264]`
Mówca: **Monica**
> ""No. The Anton Rayne I married wouldn't give up so easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Monica: ""Think of everything you've accomplished. And everything ..."*)

### Węzeł `[265]`
Mówca: **Monica**
> ""Think of everything you've accomplished. And everything you have left to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Monica: ""Everything *we* have left to do.""*)

### Węzeł `[266]`
Mówca: **Monica**
> ""Everything *we* have left to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Deana: ""Yeah, Papa. You've gotta stay strong!""*)

### Węzeł `[267]`
Mówca: **Narrator**
> "Deana still looked confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Deana: ""Does that mean we're not gonna live here anymore?""*)

### Węzeł `[268]`
Mówca: **Deana**
> ""Does that mean we're not gonna live here anymore?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player: ""Oh, we're getting as far away from Holsord as possible.""*)
  - -> `[270]` (*Player: ""We could stay here, but we don't have to. We can do what..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA: ""Oh, we're getting as far away from Holsord as possible.""]** — Mówca: **Player**
> ""Oh, we're getting as far away from Holsord as possible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[268]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "As I spoke, I felt like a weight was lifting from my shou..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA: ""We could stay here, but we don't have to. We can do whatever we want.""]** — Mówca: **Player**
> ""We could stay here, but we don't have to. We can do whatever we want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[268]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "As I spoke, I felt like a weight was lifting from my shou..."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "As I spoke, I felt like a weight was lifting from my shoulders. I knew I'd made the right choice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Monica: ""I'm still going to keep fighting for women's rights. No ..."*)

### Węzeł `[272]`
Mówca: **Monica**
> ""I'm still going to keep fighting for women's rights. No matter who wins the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player: ""And I won't stop fighting for the causes I believe in, t..."*)
  - -> `[274]` (*Player: ""Well, I'm done with politics. Full stop. I'll take up fa..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA: ""And I won't stop fighting for the causes I believe in, too. From a distance.""]** — Mówca: **Player**
> ""And I won't stop fighting for the causes I believe in, too. From a distance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "Monica and I smiled at each other."*)

### Węzeł `[274]`
**[WYBÓR GRACZA: ""Well, I'm done with politics. Full stop. I'll take up farming or something.""]** — Mówca: **Player**
> ""Well, I'm done with politics. Full stop. I'll take up farming or something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "Monica and I smiled at each other."*)

### Węzeł `[275]`
Mówca: **Narrator**
> "Monica and I smiled at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Deana: ""Cool. It'll be an adventure!""*)

### Węzeł `[276]`
Mówca: **Deana**
> ""Cool. It'll be an adventure!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Monica: ""Can we finish dinner now?""*)

### Węzeł `[277]`
Mówca: **Monica**
> ""Can we finish dinner now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player: ""Of course.""*)
  - -> `[279]` (*Player: ""You two go ahead. I have to write my retirement speech.""*)

### Węzeł `[278]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "The three of us dug into our food and started talking abo..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA: ""You two go ahead. I have to write my retirement speech.""]** — Mówca: **Player**
> ""You two go ahead. I have to write my retirement speech.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "I cleared my plate and went up to my study."*)

### Węzeł `[280]`
Mówca: **Narrator**
> "The three of us dug into our food and started talking about what we'd do once I was no longer President."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "When we were done, I went up to my study and started draf..."*)

### Węzeł `[281]`
Mówca: **Narrator**
> "When we were done, I went up to my study and started drafting my retirement speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true; BaseGame.Reti..."*)

### Węzeł `[282]`
Mówca: **Narrator**
> "I cleared my plate and went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "I sat down and began writing my announcement that I was e..."*)

### Węzeł `[283]`
Mówca: **Narrator**
> "I sat down and began writing my announcement that I was ending my political career for good."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true; BaseGame.Reti..."*)

### Węzeł `[284]`
Mówca: **Deana**
> ""Yeah, Papa. You've gotta stay strong!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Player: ""I'm sorry. But this is for the best.""*)
  - -> `[285]` (*Player: ""I-- you're right. I don't know what I'm talking about.""*)

### Węzeł `[285]`
**[WYBÓR GRACZA: ""I-- you're right. I don't know what I'm talking about.""]** — Mówca: **Player**
> ""I-- you're right. I don't know what I'm talking about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)

### Węzeł `[286]`
**[WYBÓR GRACZA: ""I'm sorry. But this is for the best.""]** — Mówca: **Player**
> ""I'm sorry. But this is for the best.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Monica: ""The best? You think that witch Lileas will continue our ..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Monica: ""I'm disappointed in you, Anton. But I can't force you to..."*)

### Węzeł `[290]`
Mówca: **Monica**
> ""The best? You think that witch Lileas will continue our women's rights reforms?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Monica: ""I'm disappointed in you, Anton. But I can't force you to..."*)

### Węzeł `[291]`
Mówca: **Monica**
> ""I'm disappointed in you, Anton. But I can't force you to go on if you don't want to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true)"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Monica: ""Good. Because I'll be damned if that witch Lileas tears ..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Monica: ""It's settled then. You'll fight and you'll win.""*)

### Węzeł `[295]`
Mówca: **Monica**
> ""Good. Because I'll be damned if that witch Lileas tears down our progress on women's rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Monica: ""It's settled then. You'll fight and you'll win.""*)

### Węzeł `[296]`
Mówca: **Monica**
> ""It's settled then. You'll fight and you'll win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Player: ""Yes. For you two.""*)
  - -> `[298]` (*Player: ""Yes. For Sordland.""*)

### Węzeł `[297]`
**[WYBÓR GRACZA: ""Yes. For you two.""]** — Mówca: **Player**
> ""Yes. For you two.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Narrator: "Monica and I smiled at each other."*)

### Węzeł `[298]`
**[WYBÓR GRACZA: ""Yes. For Sordland.""]** — Mówca: **Player**
> ""Yes. For Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Narrator: "Monica and I smiled at each other."*)

### Węzeł `[299]`
Mówca: **Narrator**
> "Monica and I smiled at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Deana: ""Can we finish dinner now?""*)

### Węzeł `[300]`
Mówca: **Deana**
> ""Can we finish dinner now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Player: ""Of course.""*)
  - -> `[302]` (*Player: ""You two go ahead. I'm going to my study.""*)

### Węzeł `[301]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "The three of us ate and animatedly discussed our plans fo..."*)

### Węzeł `[302]`
**[WYBÓR GRACZA: ""You two go ahead. I'm going to my study.""]** — Mówca: **Player**
> ""You two go ahead. I'm going to my study.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "I cleared my plate and went upstairs."*)

### Węzeł `[303]`
Mówca: **Narrator**
> "The three of us ate and animatedly discussed our plans for my next term. Once we had cleared our plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "I still had work to do."*)

### Węzeł `[304]`
Mówca: **Narrator**
> "I cleared my plate and went upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "I still had work to do."*)

### Węzeł `[305]`
Mówca: **Narrator**
> "I still had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[306]`
Mówca: **Narrator**
> "Monica smiled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Monica: ""I'm looking forward to that, Anton. After everything tha..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumbur..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "Monica smiled at me."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "Monica frowned."*)

### Węzeł `[310]`
Mówca: **Narrator**
> "Monica frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)

### Węzeł `[311]`
Mówca: **Monica**
> ""I'm looking forward to that, Anton. After everything that's happened... it's really for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Monica: ""We're going to have to have a serious talk about the thi..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Monica: ""There's still so much that needs to be done for Sordland..."*)

### Węzeł `[315]`
Mówca: **Monica**
> ""There's still so much that needs to be done for Sordland. But maybe you're not the one to do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "Deana looked slightly confused."*)

### Węzeł `[316]`
Mówca: **Monica**
> ""We're going to have to have a serious talk about the things you did while in office, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "Deana looked slightly confused."*)

### Węzeł `[317]`
Mówca: **Narrator**
> "Deana looked slightly confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Deana: ""Does that mean we're not gonna live here anymore?""*)

### Węzeł `[318]`
Mówca: **Deana**
> ""Does that mean we're not gonna live here anymore?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Player: ""Oh, we're getting as far away from Holsord as possible.""*)
  - -> `[396]` (*Player: ""We could stay here, but we don't have to. We can do what..."*)

### Węzeł `[319]`
Mówca: **Monica**
> ""I'm still going to keep fighting for women's rights. No matter who wins the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Player: ""And I won't stop fighting for the causes I believe in, t..."*)
  - -> `[324]` (*Player: ""Well, I'm done with politics. Full stop. I'll take up fa..."*)

### Węzeł `[320]`
Mówca: **Deana**
> ""Cool. It'll be an adventure!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Monica: ""Can we finish dinner now?""*)

### Węzeł `[321]`
Mówca: **Narrator**
> "Monica and I smiled at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Deana: ""Cool. It'll be an adventure!""*)

### Węzeł `[322]`
**[WYBÓR GRACZA: ""And I won't stop fighting for the causes I believe in, too. From a distance.""]** — Mówca: **Player**
> ""And I won't stop fighting for the causes I believe in, too. From a distance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Narrator: "Monica and I smiled at each other."*)

### Węzeł `[323]`
Mówca: **Narrator**
> "As I spoke, I felt like a weight was lifting from my shoulders. I knew I'd made the right choice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Monica: ""I'm still going to keep fighting for women's rights. No ..."*)

### Węzeł `[324]`
**[WYBÓR GRACZA: ""Well, I'm done with politics. Full stop. I'll take up farming or something.""]** — Mówca: **Player**
> ""Well, I'm done with politics. Full stop. I'll take up farming or something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Narrator: "Monica and I smiled at each other."*)

### Węzeł `[325]`
Mówca: **Monica**
> ""Can we finish dinner now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Player: ""Of course.""*)
  - -> `[327]` (*Player: ""You two go ahead. I'm going to my study.""*)

### Węzeł `[326]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[325]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Narrator: "The three of us ate and animatedly discussed our plans fo..."*)

### Węzeł `[327]`
**[WYBÓR GRACZA: ""You two go ahead. I'm going to my study.""]** — Mówca: **Player**
> ""You two go ahead. I'm going to my study.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[325]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "I cleared my plate and went upstairs."*)

### Węzeł `[328]`
Mówca: **Narrator**
> "The three of us ate and animatedly discussed our plans for my retirement. Once we had cleared our plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true; BaseGame.Reti..."*)

### Węzeł `[329]`
Mówca: **Narrator**
> "I cleared my plate and went upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true; BaseGame.Reti..."*)

### Węzeł `[330]`
Mówca: **Narrator**
> "I still had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true)"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Monica: ""I still don't think you should have let that witch Lilea..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Monica: ""I'm disappointed, but I can't force you to continue a fi..."*)

### Węzeł `[334]`
Mówca: **Monica**
> ""I still don't think you should have let that witch Lileas win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Monica: ""I'm disappointed, but I can't force you to continue a fi..."*)

### Węzeł `[335]`
Mówca: **Monica**
> ""I'm disappointed, but I can't force you to continue a fight you've got no interest in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "Deana looked slightly confused."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumbur..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Narrator: "Monica smiled."*)

### Węzeł `[339]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Monica: ""Anton, I think you should quit politics. Not just drop o..."*)

### Węzeł `[340]`
Mówca: **Narrator**
> "Monica smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Monica: ""I'd like that. What about you, Deana?""*)

### Węzeł `[341]`
Mówca: **Monica**
> ""I'd like that. What about you, Deana?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Deana: ""Yeah! Can Franc come, too?""*)

### Węzeł `[342]`
Mówca: **Deana**
> ""Yeah! Can Franc come, too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion > 0"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion > 0"*)
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion > 0)"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true && (BaseGame.Turn07_Personal..."*)
  - -> `[350]` (*Monica: ""Yes, let's wait for a break in his schedule.""*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "Monica and I exchanged troubled glances over Deana's head."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == true && (BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true && (BaseGame.Turn07_Personal..."*)
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == true && (BaseGame.Turn07_Person..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == true && (BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == true  and  (Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Monica: ""If he's not off fighting Rumburg.""*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == true && (BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == true  and  (Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Monica: ""Yes, let's wait for a break in his schedule.""*)

### Węzeł `[349]`
Mówca: **Monica**
> ""If he's not off fighting Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Deana: ""Where are we gonna go?""*)

### Węzeł `[350]`
Mówca: **Monica**
> ""Yes, let's wait for a break in his schedule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Deana: ""Where are we gonna go?""*)

### Węzeł `[351]`
Mówca: **Monica**
> ""We'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Deana: ""Where are we gonna go?""*)

### Węzeł `[352]`
Mówca: **Narrator**
> "Monica and I exchanged troubled glances over Deana's head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Monica: ""We'll see.""*)

### Węzeł `[353]`
Mówca: **Deana**
> ""Where are we gonna go?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Player: ""Ladies' choice.""*)
  - -> `[355]` (*Player: ""We'll go to the Benfi coast.""*)
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard == true"*)

### Węzeł `[354]`
**[WYBÓR GRACZA: ""Ladies' choice.""]** — Mówca: **Player**
> ""Ladies' choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "Monica and Deana grinned at each other."*)

### Węzeł `[355]`
**[WYBÓR GRACZA: ""We'll go to the Benfi coast.""]** — Mówca: **Player**
> ""We'll go to the Benfi coast.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "Monica and Deana grinned at each other."*)

### Węzeł `[356]`
**[WYBÓR GRACZA: ""We'll go to our vineyard in Erlory.""]** — Mówca: **Player**
> ""We'll go to our vineyard in Erlory.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_Vineyard"] == true`
- **Kontekst wejściowy (poprzednik):** `[353]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "Monica and Deana grinned at each other."*)

### Węzeł `[357]`
Mówca: **Narrator**
> "Monica and Deana grinned at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Deana: ""Can we finish dinner now?""*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Vineyard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard == true"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_Vineyard == true)"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Vineyard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_Vineyard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Player: ""We'll go to our vineyard in Erlory.""*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_Vineyard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Vineyard"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[361]`
Mówca: **Deana**
> ""Can we finish dinner now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Player: ""Of course.""*)
  - -> `[363]` (*Player: ""You two go ahead. I'm going to my study.""*)

### Węzeł `[362]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[361]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Narrator: "The three of us ate and animatedly discussed our holiday ..."*)

### Węzeł `[363]`
**[WYBÓR GRACZA: ""You two go ahead. I'm going to my study.""]** — Mówca: **Player**
> ""You two go ahead. I'm going to my study.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[361]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Narrator: "I cleared my plate and went upstairs."*)

### Węzeł `[364]`
Mówca: **Narrator**
> "The three of us ate and animatedly discussed our holiday plans. Once we had cleared our plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "I still had work to do."*)

### Węzeł `[365]`
Mówca: **Narrator**
> "I cleared my plate and went upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "I still had work to do."*)

### Węzeł `[366]`
Mówca: **Monica**
> ""Anton, I think you should quit politics. Not just drop out of the election -- retire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Player: ""What? Why?""*)
  - -> `[368]` (*Player: ""I can't. I've come too far.""*)
  - -> `[369]` (*Player: ""Honestly, I've been having similar thoughts.""*)

### Węzeł `[367]`
**[WYBÓR GRACZA: ""What? Why?""]** — Mówca: **Player**
> ""What? Why?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Monica: ""With everything that's happened... I don't think you bel..."*)

### Węzeł `[368]`
**[WYBÓR GRACZA: ""I can't. I've come too far.""]** — Mówca: **Player**
> ""I can't. I've come too far.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Monica: ""With everything that's happened... I don't think you bel..."*)

### Węzeł `[369]`
**[WYBÓR GRACZA: ""Honestly, I've been having similar thoughts.""]** — Mówca: **Player**
> ""Honestly, I've been having similar thoughts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Monica: ""With everything that's happened... I don't think you bel..."*)

### Węzeł `[370]`
Mówca: **Monica**
> ""With everything that's happened... I don't think you belong in government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 0"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 0"*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 0)"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Monica: ""And every day you stay there gives your opponents more c..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Monica: ""Of course I don't want to lose the progress we've made f..."*)

### Węzeł `[374]`
Mówca: **Monica**
> ""And every day you stay there gives your opponents more chances to smear your reputation -- and ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Deana: ""They've been making fun of me at school because of you, ..."*)

### Węzeł `[375]`
Mówca: **Deana**
> ""They've been making fun of me at school because of you, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Monica: ""You being President -- it hasn't been easy on any of us...."*)

### Węzeł `[376]`
Mówca: **Monica**
> ""Of course I don't want to lose the progress we've made for women -- but I'm afraid that'll happen anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Monica: ""You being President -- it hasn't been easy on any of us...."*)

### Węzeł `[377]`
Mówca: **Monica**
> ""You being President -- it hasn't been easy on any of us. Maybe we could go back to the way things were before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Player: ""Okay. You've made your point. I'll retire.""*)
  - -> `[379]` (*Player: ""Sorry, Monica. I've got to keep going.""*)

### Węzeł `[378]`
**[WYBÓR GRACZA: ""Okay. You've made your point. I'll retire.""]** — Mówca: **Player**
> ""Okay. You've made your point. I'll retire.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Narrator: "Monica gave me a look of gratitude."*)

### Węzeł `[379]`
**[WYBÓR GRACZA: ""Sorry, Monica. I've got to keep going.""]** — Mówca: **Player**
> ""Sorry, Monica. I've got to keep going.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Narrator: "Monica's lips formed a thin line."*)

### Węzeł `[380]`
Mówca: **Narrator**
> "Monica gave me a look of gratitude."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Monica: ""I truly think it's for the best.""*)

### Węzeł `[381]`
Mówca: **Monica**
> ""I truly think it's for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[382]`
Mówca: **Narrator**
> "Monica's lips formed a thin line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Monica: ""You never did know when to give up.""*)

### Węzeł `[383]`
Mówca: **Monica**
> ""You never did know when to give up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Deana: ""Can we finish dinner now?""*)

### Węzeł `[384]`
Mówca: **Deana**
> ""Can we finish dinner now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Player: ""Of course.""*)
  - -> `[387]` (*Player: ""You two go ahead. I'm going to my study.""*)

### Węzeł `[385]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[384]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Narrator: "The three of us finished our food in silence. Once we had..."*)

### Węzeł `[386]`
Mówca: **Narrator**
> "The three of us finished our food in silence. Once we had cleared our plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "I still had work to do."*)

### Węzeł `[387]`
**[WYBÓR GRACZA: ""You two go ahead. I'm going to my study.""]** — Mówca: **Player**
> ""You two go ahead. I'm going to my study.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[384]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Narrator: "I cleared my plate and went upstairs."*)

### Węzeł `[388]`
Mówca: **Narrator**
> "I cleared my plate and went upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "I still had work to do."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FinalSupper_Retired = true; BaseGame.Retirement_FamilyWithYou = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;
Variable["BaseGame.Retirement_FamilyWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FinalSupper_Retired = true; BaseGame.Retirement_FamilyWithYou = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;
Variable["BaseGame.Retirement_FamilyWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Exile = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[395]`
**[WYBÓR GRACZA: ""Oh, we're getting as far away from Holsord as possible.""]** — Mówca: **Player**
> ""Oh, we're getting as far away from Holsord as possible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "As I spoke, I felt like a weight was lifting from my shou..."*)

### Węzeł `[396]`
**[WYBÓR GRACZA: ""We could stay here, but we don't have to. We can do whatever we want.""]** — Mówca: **Player**
> ""We could stay here, but we don't have to. We can do whatever we want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "As I spoke, I felt like a weight was lifting from my shou..."*)

### Węzeł `[397]`
Mówca: **Monica**
> ""I suppose the political world may not take you seriously as a former President, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame...."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Monica: ""I suppose the political world may not take you seriously..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Monica: ""I suppose you don't have much of a chance of re-election..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "I still had work to do."*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "Monica's face paled. She nodded silently."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "Monica's face paled. She nodded silently."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Deana: ""Papa, no! You can't leave us!""*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Deana: ""Papa, no! You can't leave us!""*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ..."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: ""But right now, there's no time. We need to get out of So..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[410]`
**[WYBÓR GRACZA: ""I never thought I would be a pariah.""]** — Mówca: **Player**
> ""I never thought I would be a pariah.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Deana scratched her head."*)
