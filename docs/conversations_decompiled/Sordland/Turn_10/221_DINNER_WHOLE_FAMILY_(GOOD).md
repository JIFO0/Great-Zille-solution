# Sordland/Turn10/DINNER WHOLE FAMILY (GOOD)

- **ID konwersacji:** `221`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/221_DINNER_WHOLE_FAMILY_(GOOD).md`
- **Liczba węzłów dialogowych:** 475
- **Liczba wyborów gracza:** 112

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana
- **[31]** Franc

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Enable_WomensRightsBill_Strong`
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.LeakedScandal_Franc_StateUniversity`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Media_Censored`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Relations_Monica_LeadsWomensRights`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Rumburg_War`
- `BaseGame.Situation_Law_ExcellentWomenRights`
- `BaseGame.Turn05_P_Vineyard`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn10_PartyCongress_Retired`
- `BaseGame.Unrest_BFF_Deal_Promised`
- `BaseGame.Unrest_BFF_Deal_Signed`
- `BaseGame.Unrest_BFF_Happened`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_Exile`
- `BaseGame.Exile_LeaveNow`
- `BaseGame.Exile_MonicaDeanaWithYou`
- `BaseGame.Exile_WholeFamilyWithYou`
- `BaseGame.Retirement_FamilyWithYou`
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[53]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""We'll go to our vineyard in Erlory.""** | `[238]` **Deana**: ""Where are we gonna go?"" | `Variable["BaseGame.Turn05_P_Vineyard"] == true` | *Brak zmian stanu* | `[237]` **Narrator**: "Monica and Deana grinned at each..." |
| `[6]` | **""And I won't stop fighting for the causes I believe in, too. From a distance.""** | `[236]` **Monica**: ""I'm still going to keep fightin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Narrator**: "Monica and I smiled at each other." |
| `[7]` | **""You three go ahead. I'm going to my study.""** | `[215]` **Franc**: ""Yes. Great. More family time. F..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Narrator**: "I cleared my plate and went upst..." |
| `[11]` | **""I'm so proud of us for getting through it all together.""** | `[77]` **Player**: ""I know the past four years have..."<br>`[81]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Player**: ""We deserve some time off togeth..."<br>`[26]` **Player**: ""We deserve to celebrate."" |
| `[13]` | **""I know, and you'll be able to come back to that. But we need to lay low for now.""** | `[193]` **Monica**: ""I don't know about this, Anton...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Monica**: ""You might be right."" |
| `[14]` | **""Now that we're all here, I wanted to say something.""** | `[200]` **Narrator**: "The three of us gathered around ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Player**: ""I know the past four years have..."<br>`[81]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych odgałęzień)* |
| `[16]` | **""I'm so grateful to all of you for supporting me through it all.""** | `[77]` **Player**: ""I know the past four years have..."<br>`[81]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Player**: ""We deserve some time off togeth..."<br>`[26]` **Player**: ""We deserve to celebrate."" |
| `[20]` | **""I know I haven't been there for any of you as much as I should have.""** | `[77]` **Player**: ""I know the past four years have..."<br>`[81]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Player**: ""I hope someday, we'll be able t..."<br>`[34]` **Player**: ""I hope I can make it up to you ..." |
| `[21]` | **""I was so busy focusing on the needs of the Sordish people that I sometimes forgot..."** | `[77]` **Player**: ""I know the past four years have..."<br>`[81]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Player**: ""I hope someday, we'll be able t..."<br>`[34]` **Player**: ""I hope I can make it up to you ..." |
| `[26]` | **""We deserve to celebrate.""** | `[11]` **Player**: ""I'm so proud of us for getting ..."<br>`[16]` **Player**: ""I'm so grateful to all of you f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "Monica's eyes were shining." |
| `[30]` | **""We deserve some time off together as a family.""** | `[11]` **Player**: ""I'm so proud of us for getting ..."<br>`[16]` **Player**: ""I'm so grateful to all of you f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "Monica's eyes were shining." |
| `[32]` | **"Give the guards a suspicious look."** | `[23]` **Narrator**: "I didn't know if it was my imagi..."<br>`[24]` **Narrator**: "The guards formed a cordon to le..." | `Variable["BaseGame.Ending_Coup"] == true` | *Brak zmian stanu* | `[35]` **Narrator**: "Once inside, I locked the front ..." |
| `[33]` | **"Don't look at them and go to your door."** | `[23]` **Narrator**: "I didn't know if it was my imagi..."<br>`[24]` **Narrator**: "The guards formed a cordon to le..." | `Variable["BaseGame.Ending_Coup"] == true` | *Brak zmian stanu* | `[35]` **Narrator**: "Once inside, I locked the front ..." |
| `[34]` | **""I hope I can make it up to you someday.""** | `[20]` **Player**: ""I know I haven't been there for..."<br>`[21]` **Player**: ""I was so busy focusing on the n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "Monica's eyes were shining." |
| `[36]` | **""I hope someday, we'll be able to put this behind us and be a normal family again.""** | `[20]` **Player**: ""I know I haven't been there for..."<br>`[21]` **Player**: ""I was so busy focusing on the n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "Monica's eyes were shining." |
| `[42]` | **""Where's your mother?""** | `[45]` **Deana**: ""Hi, Papa."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Deana**: ""She's in the kitchen."" |
| `[43]` | **""Deana! How was school today?""** | `[45]` **Deana**: ""Hi, Papa."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Narrator**: "Deana shrugged." |
| `[44]` | **"Hug her."** | `[45]` **Deana**: ""Hi, Papa."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Player**: ""How was school today?""<br>`[52]` **Player**: ""Where's your mother?"" |
| `[50]` | **""Once the election's over, I'm taking you all on holiday.""** | `[38]` **Narrator**: "Monica's eyes were shining." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[111]` **Narrator**: "Monica sighed heavily."<br>`[100]` **Narrator**: "Monica smiled." |
| `[52]` | **""Where's your mother?""** | `[44]` **Player_Italic**: "I opened my arms to embrace my d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Deana**: ""She's in the kitchen."" |
| `[54]` | **""How was school today?""** | `[44]` **Player_Italic**: "I opened my arms to embrace my d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Narrator**: "Deana shrugged." |
| `[64]` | **""But right now, there's no time. We need to get out of Sordland. All of us.""** | `[38]` **Narrator**: "Monica's eyes were shining." | `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)` | *Brak zmian stanu* | `[68]` **Narrator**: "Monica, Franc and Deana turned t..." |
| `[66]` | **""My retirement from politics is going to be the best thing that ever happened to us.""** | `[38]` **Narrator**: "Monica's eyes were shining." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[154]` **Narrator**: "Monica smiled at me."<br>`[139]` **Narrator**: "Monica frowned." |
| `[67]` | **""And we'll have plenty of time for that after my presidency ends.""** | `[38]` **Narrator**: "Monica's eyes were shining." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[154]` **Narrator**: "Monica smiled at me."<br>`[139]` **Narrator**: "Monica frowned." |
| `[69]` | **""And we'll have plenty of time for that, because I'm retiring from politics at the..."** | `[38]` **Narrator**: "Monica's eyes were shining." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[97]` **Narrator**: "Monica, Franc and Deana looked a..." |
| `[70]` | **""Of course.""** | `[85]` **Franc**: ""Sure it will. Can we finish din..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Narrator**: "The four of us dug into our food..." |
| `[71]` | **""You three go ahead. I have to write my retirement speech.""** | `[85]` **Franc**: ""Sure it will. Can we finish din..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Narrator**: "I cleared my plate and went up t..." |
| `[72]` | **""You three go ahead. I'm going to my study.""** | `[86]` **Franc**: ""Great. Amazing. Can we finish d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Narrator**: "I cleared my plate and went upst..." |
| `[77]` | **""I know the past four years have been hard on all of us.""** | `[14]` **Player**: ""Now that we're all here, I want..."<br>`[161]` **Player_Italic**: "I raised my glass for a toast. M..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Player**: ""I was so busy focusing on the n..."<br>`[20]` **Player**: ""I know I haven't been there for..."<br>*(oraz 2 innych odgałęzień)* |
| `[81]` | **""The past four years have been the hardest in my life.""** | `[14]` **Player**: ""Now that we're all here, I want..."<br>`[161]` **Player_Italic**: "I raised my glass for a toast. M..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Player**: ""I was so busy focusing on the n..."<br>`[20]` **Player**: ""I know I haven't been there for..."<br>*(oraz 2 innych odgałęzień)* |
| `[82]` | **""Of course.""** | `[86]` **Franc**: ""Great. Amazing. Can we finish d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Narrator**: "The four of us ate and animatedl..." |
| `[83]` | **""The past four years have tested our strength as a family.""** | `[14]` **Player**: ""Now that we're all here, I want..."<br>`[161]` **Player_Italic**: "I raised my glass for a toast. M..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Player**: ""I was so busy focusing on the n..."<br>`[20]` **Player**: ""I know I haven't been there for..."<br>*(oraz 2 innych odgałęzień)* |
| `[87]` | **""She's just jealous because she was always bad at sewing.""** | `[74]` **Deana**: ""I won a prize at the handicraft..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Narrator**: "Deana smiled and pointed to the ..." |
| `[88]` | **""Well, *I* care.""** | `[74]` **Deana**: ""I won a prize at the handicraft..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Narrator**: "Deana smiled and pointed to the ..." |
| `[89]` | **""That's just silly.""** | `[76]` **Deana**: ""I won a prize at the science fa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Narrator**: "Deana smiled and pointed to the ..." |
| `[90]` | **""You might be right.""** | `[76]` **Deana**: ""I won a prize at the science fa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Narrator**: "Deana smiled and pointed to the ..." |
| `[112]` | **""Yes. For you three.""** | `[148]` **Monica**: ""It's settled then. You'll fight..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Narrator**: "Monica and I smiled at each other." |
| `[113]` | **""Yes. For Sordland.""** | `[148]` **Monica**: ""It's settled then. You'll fight..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Narrator**: "Monica and I smiled at each other." |
| `[114]` | **""Smells delicious.""** | `[109]` **Narrator**: "I stepped into the kitchen. Moni..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Narrator**: "Monica whirled around in surprise." |
| `[118]` | **""Of course.""** | `[141]` **Franc**: ""Great. Amazing. Can we finish d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Narrator**: "The four of us ate and animatedl..." |
| `[119]` | **""You two go ahead. I'm going to my study.""** | `[141]` **Franc**: ""Great. Amazing. Can we finish d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Narrator**: "I cleared my plate and went upst..." |
| `[127]` | **"Hug her from behind."** | `[109]` **Narrator**: "I stepped into the kitchen. Moni..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Monica**: ""God, Anton, don't startle me li..."<br>`[134]` **Narrator**: "When she realized it was me, she..." |
| `[137]` | **""And I won't stop fighting for the causes I believe in, too. From a distance.""** | `[155]` **Monica**: ""I'm still going to keep fightin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "Monica and I smiled at each other." |
| `[138]` | **""Well, I'm done with politics. Full stop. I'll take up farming or something.""** | `[155]` **Monica**: ""I'm still going to keep fightin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "Monica and I smiled at each other." |
| `[143]` | **""I know, and you'll be able to come back to that. But we need to lay low for a whi..."** | `[241]` **Monica**: ""I don't know about this, Anton...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Monica**: ""I-- you might be right."" |
| `[145]` | **""You're right. I won't do it again.""** | `[142]` **Monica**: ""God, Anton, don't startle me li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Monica**: ""I still can't believe Serge is ..."<br>`[165]` **Monica**: ""I still can't believe nobody go..." |
| `[147]` | **""Can't a man greet his wife?""** | `[142]` **Monica**: ""God, Anton, don't startle me li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Monica**: ""Yes, of course. Just walk in a ..." |
| `[149]` | **""Of course.""** | `[168]` **Franc**: ""Go Dad. I believe in you. Can w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Narrator**: "The four of us finished our food..." |
| `[150]` | **""You three go ahead. I'm going to my study.""** | `[168]` **Franc**: ""Go Dad. I believe in you. Can w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Narrator**: "I cleared my plate and went upst..." |
| `[151]` | **""Monica. You know I only did what I did because I had to.""** | `[192]` **Monica**: ""No. The things your father's do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Monica**: ""The ends don't justify the means."" |
| `[152]` | **""Monica, everything I did was for you!""** | `[192]` **Monica**: ""No. The things your father's do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Monica**: ""The ends don't justify the means."" |
| `[153]` | **""You won't be able to fight for women's rights from a cell. Or a grave.""** | `[193]` **Monica**: ""I don't know about this, Anton...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Monica**: ""My God, Anton. You think it's t..." |
| `[161]` | **"Raise your glass."** | `[200]` **Narrator**: "The three of us gathered around ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Player**: ""I know the past four years have..."<br>`[81]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych odgałęzień)* |
| `[178]` | **"Tap on the side of your glass."** | `[200]` **Narrator**: "The three of us gathered around ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Player**: ""I know the past four years have..."<br>`[81]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych odgałęzień)* |
| `[188]` | **""Of course.""** | `[215]` **Franc**: ""Yes. Great. More family time. F..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Narrator**: "The four of us ate and animatedl..." |
| `[205]` | **""It's not just for your sake. I'm sick and tired of this game. I want out.""** | `[140]` **Monica**: ""Anton, you can't do that. Not f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Narrator**: "Monica sighed heavily."<br>`[130]` **Narrator**: "Monica slammed her hand down on ..." |
| `[206]` | **""I can and I will.""** | `[140]` **Monica**: ""Anton, you can't do that. Not f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Narrator**: "Monica sighed heavily."<br>`[130]` **Narrator**: "Monica slammed her hand down on ..." |
| `[214]` | **""Well, I'm done with politics. Full stop. I'll take up farming or something.""** | `[236]` **Monica**: ""I'm still going to keep fightin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Narrator**: "Monica and I smiled at each other." |
| `[216]` | **""Honestly, I've been having similar thoughts.""** | `[176]` **Monica**: ""Anton, I think you should stop...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Monica**: ""With everything that's happened..." |
| `[217]` | **""Nobody will listen to you once I'm out of office. Sorry.""** | `[241]` **Monica**: ""I don't know about this, Anton...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Monica**: ""You may be right. I just hate t..." |
| `[218]` | **""Monica. You know I only did what I did because I had to.""** | `[240]` **Monica**: ""Deana, you don't have to worry ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Monica**: ""The ends don't justify the means."" |
| `[219]` | **""Monica, everything I did was for you!""** | `[240]` **Monica**: ""Deana, you don't have to worry ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Monica**: ""The ends don't justify the means."" |
| `[220]` | **""I-- you're right. I don't know what I'm talking about.""** | `[242]` **Deana**: ""Yeah, Papa. You've gotta stay s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Monica**: ""Good. Because I'll be damned if..."<br>`[148]` **Monica**: ""It's settled then. You'll fight..." |
| `[221]` | **""I can't. I've come too far.""** | `[176]` **Monica**: ""Anton, I think you should stop...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Monica**: ""With everything that's happened..." |
| `[222]` | **""What? Why?""** | `[176]` **Monica**: ""Anton, I think you should stop...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Monica**: ""With everything that's happened..." |
| `[223]` | **""I'm about to be the first president in Sordish history to get impeached. I'll be ..."** | `[105]` **Monica**: ""Anton, what in the everloving h..." | `Variable["BaseGame.Ending_ImpeachmentTrial"] == true` | *Brak zmian stanu* | `[5]` **Narrator**: "Deana scratched her head." |
| `[225]` | **""The military is after me. After what happened at the parade, I'm not safe -- and ..."** | `[105]` **Monica**: ""Anton, what in the everloving h..." | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[254]` **Narrator**: "Deana looked at me in disbelief...." |
| `[229]` | **""I've just signed part of my own country over to Rumburg. I'm going to be a pariah..."** | `[105]` **Monica**: ""Anton, what in the everloving h..." | `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true` | *Brak zmian stanu* | `[5]` **Narrator**: "Deana scratched her head." |
| `[235]` | **""I'm sorry. But this is for the best.""** | `[242]` **Deana**: ""Yeah, Papa. You've gotta stay s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Monica**: ""The best? You think that witch ..."<br>`[160]` **Monica**: ""I'm disappointed in you, Anton...." |
| `[244]` | **""Okay. You've made your point. I'll retire.""** | `[258]` **Monica**: ""You being President -- it hasn'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Narrator**: "Monica gave me a look of gratitude." |
| `[245]` | **""Sorry, Monica. I've got to keep going.""** | `[258]` **Monica**: ""You being President -- it hasn'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Narrator**: "Monica's lips formed a thin line." |
| `[249]` | **""Ladies' choice.""** | `[238]` **Deana**: ""Where are we gonna go?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Narrator**: "Monica and Deana grinned at each..." |
| `[250]` | **""We'll go to the Benfi coast.""** | `[238]` **Deana**: ""Where are we gonna go?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Narrator**: "Monica and Deana grinned at each..." |
| `[262]` | **""Oh, we're getting as far away from Holsord as we can.""** | `[213]` **Deana**: ""Does that mean we're not gonna ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Narrator**: "As I spoke, I felt like a weight..." |
| `[263]` | **""We could stay here. But we don't have to. We can go anywhere we want.""** | `[213]` **Deana**: ""Does that mean we're not gonna ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Narrator**: "As I spoke, I felt like a weight..." |
| `[279]` | **""Language!""** | `[311]` **Franc**: ""Shit, Dad, that parade was a cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Franc**: ""Serge is dead, and your biggest..."<br>`[281]` **Franc**: ""You almost died *again*, and yo..." |
| `[280]` | **""You could've invited them in. There's enough food.""** | `[292]` **Narrator**: "He flung his backpack in a corne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[298]` **Franc**: ""Ha. Even if they would cross th..." |
| `[284]` | **""They might be.""** | `[273]` **Franc**: ""Sorry I'm late. Are some of tho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Franc**: ""Well, I'd be more suspicious of..." |
| `[285]` | **""I'm starting to get suspicious of them, to be honest.""** | `[273]` **Franc**: ""Sorry I'm late. Are some of tho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[302]` **Narrator**: "He flung his backpack in a corne..." |
| `[291]` | **""I hope you two are being careful.""** | `[278]` **Narrator**: "He flung his backpack in a corne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Franc**: ""We're certainly being more care..."<br>`[312]` **Franc**: ""Don't you worry. I've seen what..." |
| `[293]` | **""It wasn't a 'close call' for Serge.""** | `[311]` **Franc**: ""Shit, Dad, that parade was a cl..." | `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true` | *Brak zmian stanu* | `[306]` **Franc**: ""Yeah. I hope his family's doing..." |
| `[294]` | **""Too close.""** | `[311]` **Franc**: ""Shit, Dad, that parade was a cl..." | `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false` | *Brak zmian stanu* | `[318]` **Franc**: ""Right."" |
| `[296]` | **""So that's still going on.""** | `[278]` **Narrator**: "He flung his backpack in a corne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Franc**: ""Yes, no thanks to you. One of h..."<br>`[295]` **Franc**: ""Don't look so surprised."" |
| `[310]` | **""You *know* those brats? I was going to ask the guards to have them tear-gassed.""** | `[292]` **Narrator**: "He flung his backpack in a corne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Franc**: ""Don't do it. They brought goggl..." |
| `[324]` | **""I'm not going anywhere without you.""** | `[365]` **Monica**: ""When will you leave, Anton?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Narrator**: "Monica's lips formed a thin line." |
| `[325]` | **""I'll come back soon.""** | `[340]` **Monica**: ""It's better this way, sweetheart."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Monica**: ""Let's finish dinner, at least."" |
| `[328]` | **""I'll call all the time.""** | `[340]` **Monica**: ""It's better this way, sweetheart."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Monica**: ""Let's finish dinner, at least."" |
| `[330]` | **""Kyrute. It's going to be an adventure.""** | `[73]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[349]` **Monica**: ""We're not going anywhere, Deana..." |
| `[331]` | **""You'll find out once we get there. It'll be a surprise.""** | `[73]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[349]` **Monica**: ""We're not going anywhere, Deana..." |
| `[338]` | **""Kyrute. It's going to be an adventure.""** | `[75]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Deana**: ""But what about school? What abo..." |
| `[339]` | **""You'll find out once we get there. It'll be a surprise.""** | `[75]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Deana**: ""But what about school? What abo..." |
| `[343]` | **""All right.""** | `[334]` **Monica**: ""Let's finish dinner, at least."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Narrator**: "We ate in tense silence. I could..." |
| `[344]` | **""No, we don't have time.""** | `[334]` **Monica**: ""Let's finish dinner, at least."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[364]` **Narrator**: "We hurriedly cleared our plates...." |
| `[351]` | **""No, I don't have time.""** | `[342]` **Monica**: ""Let's finish dinner, at least."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Narrator**: "I took a last look at Monica, Fr..." |
| `[356]` | **""In a week. I need to make sure our tracks are covered first.""** | `[365]` **Monica**: ""When will you leave, Anton?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[350]` **Deana**: ""Papa, no! You can't leave us!"" |
| `[357]` | **""In a week. I need to make sure our tracks are covered first.""** | `[360]` **Franc**: ""This is crazy, Dad. When do you..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[362]` **Narrator**: "Monica's face paled. She nodded ..." |
| `[358]` | **""All right.""** | `[342]` **Monica**: ""Let's finish dinner, at least."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[345]` **Narrator**: "The four of us ate in tense sile..." |
| `[359]` | **""Tomorrow morning. I've got to get packing.""** | `[365]` **Monica**: ""When will you leave, Anton?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Exile_LeaveNow"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[350]` **Deana**: ""Papa, no! You can't leave us!"" |
| `[361]` | **""Tomorrow morning. Let's get packing.""** | `[360]` **Franc**: ""This is crazy, Dad. When do you..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Exile_LeaveNow"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[362]` **Narrator**: "Monica's face paled. She nodded ..." |
| `[363]` | **""All right, all right. Let's finish dinner.""** | `[332]` **Monica**: ""And Anton, you and I are going ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Narrator**: "The four of us finished our food..." |
| `[366]` | **""I've lost my appetite. I'll see you two later.""** | `[332]` **Monica**: ""And Anton, you and I are going ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Narrator**: "I cleared my plate and went up t..." |
| `[371]` | **""Kyrute. It's going to be an adventure.""** | `[376]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Monica**: ""We're not going anywhere, Deana..." |
| `[377]` | **""You'll find out once we get there. It'll be a surprise.""** | `[376]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Monica**: ""We're not going anywhere, Deana..." |
| `[391]` | **""Kyrute. It's going to be an adventure.""** | `[389]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Deana**: ""But what about school? What abo..." |
| `[392]` | **""You'll find out once we get there. It'll be a surprise.""** | `[389]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Deana**: ""But what about school? What abo..." |
| `[394]` | **""So be it. Monica and Deana, we'll leave in a week. I need to make sure our tracks..."** | `[401]` **Franc**: ""This is crazy. Mom, Dad, you do..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[390]` **Narrator**: "Monica's face paled. She nodded ..." |
| `[400]` | **""All right.""** | `[396]` **Monica**: ""Let's finish dinner, at least."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[403]` **Narrator**: "We ate in tense silence. I could..." |
| `[404]` | **""So be it. Monica and Deana, we leave tomorrow morning. Let's get packing.""** | `[401]` **Franc**: ""This is crazy. Mom, Dad, you do..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Exile_LeaveNow"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[390]` **Narrator**: "Monica's face paled. She nodded ..." |
| `[406]` | **""No, we don't have time.""** | `[396]` **Monica**: ""Let's finish dinner, at least."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[402]` **Narrator**: "We hurriedly cleared our plates...." |
| `[452]` | **""Oh, we're getting as far away from Holsord as we can.""** | `[239]` **Deana**: ""Does that mean we're not gonna ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Narrator**: "As I spoke, I felt like a weight..." |
| `[453]` | **""We could stay here. But we don't have to. We can go anywhere we want.""** | `[239]` **Deana**: ""Does that mean we're not gonna ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Narrator**: "As I spoke, I felt like a weight..." |
| `[474]` | **""I never thought I would be a pariah.""** | `[105]` **Monica**: ""Anton, what in the everloving h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Narrator**: "Deana scratched her head." |

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
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "I still had work to do."*)

### Węzeł `[3]`
Mówca: **Monica**
> ""There's still so much that needs to be done for Sordland. But maybe you're not the one to do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""We'll go to our vineyard in Erlory.""]** — Mówca: **Player**
> ""We'll go to our vineyard in Erlory.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_Vineyard"] == true`
- **Kontekst wejściowy (poprzednik):** `[238]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Narrator: "Monica and Deana grinned at each other. Franc rolled his ..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Deana scratched her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Deana: ""What's a pariah?""*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""And I won't stop fighting for the causes I believe in, too. From a distance.""]** — Mówca: **Player**
> ""And I won't stop fighting for the causes I believe in, too. From a distance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Monica and I smiled at each other."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""You three go ahead. I'm going to my study.""]** — Mówca: **Player**
> ""You two go ahead. I'm going to my study.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "I cleared my plate and went upstairs."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Vineyard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_Vineyard == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Vineyard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_Vineyard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""We'll go to our vineyard in Erlory.""*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_Vineyard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Vineyard"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[11]`
**[WYBÓR GRACZA: ""I'm so proud of us for getting through it all together.""]** — Mówca: **Player**
> ""I'm so proud of us for getting through it all together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Player), `[81]` (Player), `[83]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""We deserve some time off together as a family.""*)
  - -> `[26]` (*Player: ""We deserve to celebrate.""*)

### Węzeł `[12]`
Mówca: **Monica**
> ""I truly think it's for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""I know, and you'll be able to come back to that. But we need to lay low for now.""]** — Mówca: **Player**
> ""I know, and you'll be able to come back to that. But we need to lay low for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Monica: ""You might be right.""*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Now that we're all here, I wanted to say something.""]** — Mówca: **Player**
> ""Now that we're all here, I wanted to say something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""I know the past four years have been hard on all of us.""*)
  - -> `[81]` (*Player: ""The past four years have been the hardest in my life.""*)
  - -> `[83]` (*Player: ""The past four years have tested our strength as a family.""*)

### Węzeł `[15]`
Mówca: **Narrator**
> "I cleared my plate and went upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "I still had work to do."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""I'm so grateful to all of you for supporting me through it all.""]** — Mówca: **Player**
> ""I'm so grateful to all of you for supporting me through it all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Player), `[81]` (Player), `[83]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""We deserve some time off together as a family.""*)
  - -> `[26]` (*Player: ""We deserve to celebrate.""*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "The usual crowd of protesters was waiting for me outside ..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "I didn't know if it was my imagination, but there seemed ..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I know I haven't been there for any of you as much as I should have.""]** — Mówca: **Player**
> ""I know I haven't been there for any of you as much as I should have.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Player), `[81]` (Player), `[83]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""I hope someday, we'll be able to put this behind us and ..."*)
  - -> `[34]` (*Player: ""I hope I can make it up to you someday.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""I was so busy focusing on the needs of the Sordish people that I sometimes forgot about Sordland's most important people: my own wife and children.""]** — Mówca: **Player**
> ""I was so busy focusing on the needs of the Sordish people that I sometimes forgot about Sordland's most important people: my own wife and children.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Player), `[81]` (Player), `[83]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""I hope someday, we'll be able to put this behind us and ..."*)
  - -> `[34]` (*Player: ""I hope I can make it up to you someday.""*)

### Węzeł `[22]`
Mówca: **Narrator**
> "The usual crowd of protesters was waiting for me outside the gates of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "The guards formed a cordon to let me through."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "I didn't know if it was my imagination, but there seemed to be more guards outside my complex than usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "The guards formed a cordon to let me through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[25]`
Mówca: **Deana**
> ""Cool. It'll be an adventure!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Franc: ""Great. Amazing. Can we finish dinner now?""*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""We deserve to celebrate.""]** — Mówca: **Player**
> ""We deserve to celebrate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Player), `[16]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Monica's eyes were shining."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Italic: "Give the guards a suspicious look."*)
  - -> `[33]` (*Player_Italic: "Don't look at them and go to your door."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "I hurried past them, went inside and locked the front doo..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""We deserve some time off together as a family.""]** — Mówca: **Player**
> ""We deserve some time off together as a family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Player), `[16]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Monica's eyes were shining."*)

### Węzeł `[31]`
Mówca: **Monica**
> ""I'd like that. What about you, Deana?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Deana: ""Yeah! Franc, are you coming too?""*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "Give the guards a suspicious look."]** — Mówca: **Player_Italic**
> "I regarded them with suspicion as I passed. With the military against me, could they be trusted?"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_Coup"] == true`
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator), `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Once inside, I locked the front door behind me."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "Don't look at them and go to your door."]** — Mówca: **Player_Italic**
> "I rushed past the guards to my door."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_Coup"] == true`
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator), `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Once inside, I locked the front door behind me."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""I hope I can make it up to you someday.""]** — Mówca: **Player**
> ""I hope I can make it up to you someday.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Player), `[21]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Monica's eyes were shining."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "Once inside, I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "I hurried past them, went inside and locked the front doo..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""I hope someday, we'll be able to put this behind us and be a normal family again.""]** — Mówca: **Player**
> ""I hope someday, we'll be able to put this behind us and be a normal family again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Player), `[21]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Monica's eyes were shining."*)

### Węzeł `[37]`
Mówca: **Deana**
> ""Mama? Is that true?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead"*)

### Węzeł `[38]`
Mówca: **Narrator**
> "Monica's eyes were shining."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: ""My retirement from politics is going to be the best thin..."*)
  - -> `[67]` (*Player: ""And we'll have plenty of time for that after my presiden..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: ""And we'll have plenty of time for that, because I'm reti..."*)
  - -> `[50]` (*Player: ""Once the election's over, I'm taking you all on holiday.""*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Where's your mother?""]** — Mówca: **Player**
> ""Where's your mother?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Deana: ""She's in the kitchen.""*)

### Węzeł `[43]`
**[WYBÓR GRACZA: ""Deana! How was school today?""]** — Mówca: **Player**
> ""Deana! How was school today?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Deana shrugged."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "Hug her."]** — Mówca: **Player_Italic**
> "I opened my arms to embrace my daughter. She hugged me back happily."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: ""How was school today?""*)
  - -> `[52]` (*Player: ""Where's your mother?""*)

### Węzeł `[45]`
Mówca: **Deana**
> ""Hi, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Italic: "Hug her."*)
  - -> `[43]` (*Player: ""Deana! How was school today?""*)
  - -> `[42]` (*Player: ""Where's your mother?""*)

### Węzeł `[46]`
Mówca: **Narrator**
> "I hurried past them, went inside and locked the front door behind me. I heard footsteps coming my way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Deana: ""Hi, Papa.""*)

### Węzeł `[47]`
Mówca: **Deana**
> ""What's a pariah?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)

### Węzeł `[48]`
Mówca: **Monica**
> ""No. The Anton Rayne I married wouldn't give up so easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Monica: ""Think of everything you've accomplished. And everything ..."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "When we were done, I went up to my study and started drafting my retirement speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou = true"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Once the election's over, I'm taking you all on holiday.""]** — Mówca: **Player**
> ""Once the election's over, I'm taking you all on holiday.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "I sat down and began writing my announcement that I was retiring from politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou = true"*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""Where's your mother?""]** — Mówca: **Player**
> ""Where's your mother?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Deana: ""She's in the kitchen.""*)

### Węzeł `[53]`
Mówca: **Narrator**
> "I still had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "Narrator: "...""*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""How was school today?""]** — Mówca: **Player**
> ""How was school today?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Deana shrugged."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "Deana shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_ExcellentWomenRights == true ||Bas..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "The four of us dug into our food and started talking about what we'd do once I was no longer President."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "When we were done, I went up to my study and started draf..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "I cleared my plate and went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "I sat down and began writing my announcement that I was r..."*)

### Węzeł `[58]`
Mówca: **Deana**
> ""She's in the kitchen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Deana: ""I've gotta do some homework before dinner.""*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_ExcellentWomenRights == true ||Bas..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_ExcellentWomenRights == true ||B..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Deana: ""I won a prize at the science fair. Honestly, I think the..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Deana: ""I won a prize at the handicrafts fair. Mama didn't seem ..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "The four of us ate and animatedly discussed our plans for my next term. Once we had cleared our plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "I still had work to do."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "I cleared my plate and went upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "I still had work to do."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""But right now, there's no time. We need to get out of Sordland. All of us.""]** — Mówca: **Player**
> ""But right now, there's no time. We need to get out of Sordland. All of us.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Monica, Franc and Deana turned to look at me in shock."*)

### Węzeł `[65]`
Mówca: **Monica**
> ""I suppose you don't have much of a chance of re-election, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""My retirement from politics is going to be the best thing that ever happened to us.""]** — Mówca: **Player**
> ""My retirement from politics is going to be the best thing that ever happened to us.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""And we'll have plenty of time for that after my presidency ends.""]** — Mówca: **Player**
> ""And we'll have plenty of time for that after my presidency ends.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Monica, Franc and Deana turned to look at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Monica: ""Anton, what in the everloving hell?""*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""And we'll have plenty of time for that, because I'm retiring from politics at the end of this term.""]** — Mówca: **Player**
> ""And we'll have plenty of time for that, because I'm retiring from politics at the end of this term.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Monica, Franc and Deana looked at me in shock."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "The four of us dug into our food and started talking abou..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: ""You three go ahead. I have to write my retirement speech.""]** — Mówca: **Player**
> ""You three go ahead. I have to write my retirement speech.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "I cleared my plate and went up to my study."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""You three go ahead. I'm going to my study.""]** — Mówca: **Player**
> ""You three go ahead. I'm going to my study.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "I cleared my plate and went upstairs."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "I thought for a moment. Kyrute, the only truly neutral country I knew of, seemed like the obvious choice. A little house in the mountains wouldn't cost much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player: ""Kyrute. It's going to be an adventure.""*)
  - -> `[331]` (*Player: ""You'll find out once we get there. It'll be a surprise.""*)

### Węzeł `[74]`
Mówca: **Deana**
> ""I won a prize at the handicrafts fair. Mama didn't seem to care that much, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: ""Well, *I* care.""*)
  - -> `[87]` (*Player: ""She's just jealous because she was always bad at sewing.""*)

### Węzeł `[75]`
Mówca: **Narrator**
> "I thought for a moment. Kyrute, the only truly neutral country I knew of, seemed like the obvious choice. A little house in the mountains wouldn't cost much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Player: ""Kyrute. It's going to be an adventure.""*)
  - -> `[339]` (*Player: ""You'll find out once we get there. It'll be a surprise.""*)

### Węzeł `[76]`
Mówca: **Deana**
> ""I won a prize at the science fair. Honestly, I think they were teaching girls different stuff before 'cause they knew we were smarter than boys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: ""You might be right.""*)
  - -> `[89]` (*Player: ""That's just silly.""*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I know the past four years have been hard on all of us.""]** — Mówca: **Player**
> ""I know the past four years have been hard on all of us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Player), `[161]` (Player_Italic), `[178]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""I was so busy focusing on the needs of the Sordish peopl..."*)
  - -> `[20]` (*Player: ""I know I haven't been there for any of you as much as I ..."*)
  - -> `[16]` (*Player: ""I'm so grateful to all of you for supporting me through ..."*)
  - -> `[11]` (*Player: ""I'm so proud of us for getting through it all together.""*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumbur..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Monica smiled."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""The past four years have been the hardest in my life.""]** — Mówca: **Player**
> ""The past four years have been the hardest in my life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Player), `[161]` (Player_Italic), `[178]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""I was so busy focusing on the needs of the Sordish peopl..."*)
  - -> `[20]` (*Player: ""I know I haven't been there for any of you as much as I ..."*)
  - -> `[16]` (*Player: ""I'm so grateful to all of you for supporting me through ..."*)
  - -> `[11]` (*Player: ""I'm so proud of us for getting through it all together.""*)

### Węzeł `[82]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "The four of us ate and animatedly discussed our plans for..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: ""The past four years have tested our strength as a family.""]** — Mówca: **Player**
> ""The past four years have tested our strength as a family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Player), `[161]` (Player_Italic), `[178]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""I was so busy focusing on the needs of the Sordish peopl..."*)
  - -> `[20]` (*Player: ""I know I haven't been there for any of you as much as I ..."*)
  - -> `[16]` (*Player: ""I'm so grateful to all of you for supporting me through ..."*)
  - -> `[11]` (*Player: ""I'm so proud of us for getting through it all together.""*)

### Węzeł `[84]`
Mówca: **Narrator**
> "I still had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "Narrator: "...""*)

### Węzeł `[85]`
Mówca: **Franc**
> ""Sure it will. Can we finish dinner now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: ""Of course.""*)
  - -> `[71]` (*Player: ""You three go ahead. I have to write my retirement speech.""*)

### Węzeł `[86]`
Mówca: **Franc**
> ""Great. Amazing. Can we finish dinner now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: ""Of course.""*)
  - -> `[72]` (*Player: ""You three go ahead. I'm going to my study.""*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""She's just jealous because she was always bad at sewing.""]** — Mówca: **Player**
> ""She's just jealous because she was always bad at sewing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Deana smiled and pointed to the kitchen."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""Well, *I* care.""]** — Mówca: **Player**
> ""Well, *I* care.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Deana smiled and pointed to the kitchen."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""That's just silly.""]** — Mówca: **Player**
> ""That's just silly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Deana smiled and pointed to the kitchen."*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""You might be right.""]** — Mówca: **Player**
> ""You might be right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Deana smiled and pointed to the kitchen."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "The four of us ate and animatedly discussed our plans for my retirement. Once we had cleared our plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou = true"*)

### Węzeł `[92]`
Mówca: **Narrator**
> "I cleared my plate and went upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "BaseGame.Retirement_FamilyWithYou = true"*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Deana smiled and pointed to the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Deana: ""Mama's in there. I've gotta do some homework before dinn..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumbur..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Monica smiled at me."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Monica frowned."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Monica, Franc and Deana looked at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Monica: ""Anton, you can't do that. Not for my sake.""*)

### Węzeł `[98]`
Mówca: **Deana**
> ""Mama's in there. I've gotta do some homework before dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "I followed her with my eyes as she went upstairs. She was..."*)

### Węzeł `[99]`
Mówca: **Deana**
> ""I've gotta do some homework before dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "I followed her with my eyes as she went upstairs. She was..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Monica smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Monica: ""I'd like that. What about you, Deana?""*)

### Węzeł `[101]`
Mówca: **Deana**
> ""Papa, where are we going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "I thought for a moment. Kyrute, the only truly neutral co..."*)

### Węzeł `[102]`
Mówca: **Deana**
> ""Papa, where are we going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "I thought for a moment. Kyrute, the only truly neutral co..."*)

### Węzeł `[103]`
Mówca: **Deana**
> ""Cool. It'll be an adventure!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Franc: ""Sure it will. Can we finish dinner now?""*)

### Węzeł `[104]`
Mówca: **Narrator**
> "Monica and I smiled at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Franc: ""Great. Amazing. Can we finish dinner now?""*)

### Węzeł `[105]`
Mówca: **Monica**
> ""Anton, what in the everloving hell?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[474]` (*Player: ""I never thought I would be a pariah.""*)

### Węzeł `[106]`
Mówca: **Narrator**
> "I followed her with my eyes as she went upstairs. She was starting to look more and more like her mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "I stepped into the kitchen. Monica was stirring a pot on ..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Deana still looked confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Deana: ""Papa, where are we going?""*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Deana still looked confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Deana: ""Papa, where are we going?""*)

### Węzeł `[109]`
Mówca: **Narrator**
> "I stepped into the kitchen. Monica was stirring a pot on the stove, her back turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player_Italic: "Hug her from behind."*)
  - -> `[114]` (*Player: ""Smells delicious.""*)

### Węzeł `[110]`
Mówca: **Narrator**
> "Monica and I smiled at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Deana: ""Cool. It'll be an adventure!""*)

### Węzeł `[111]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Monica: ""Anton, I think you should stop. Not just drop out of the..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: ""Yes. For you three.""]** — Mówca: **Player**
> ""Yes. For you three.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Monica and I smiled at each other."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""Yes. For Sordland.""]** — Mówca: **Player**
> ""Yes. For Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Monica and I smiled at each other."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Smells delicious.""]** — Mówca: **Player**
> ""Smells delicious.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "Monica whirled around in surprise."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 0"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 0)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Monica: ""And every day you stay in government gives your opponent..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Monica: ""Of course I don't want to lose the progress we've made f..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "The four of us ate and animatedly discussed our plans for..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""You two go ahead. I'm going to my study.""]** — Mówca: **Player**
> ""You three go ahead. I'm going to my study.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "I cleared my plate and went upstairs."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Deana: ""Are they gonna kill us like they killed Serge?""*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Deana: ""Are they gonna try to kill us like they tried to kill Pa..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "The four of us finished our food in silence. Once we had cleared our plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "I still had work to do."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "I cleared my plate and went upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "I still had work to do."*)

### Węzeł `[125]`
Mówca: **Monica**
> ""The ends don't justify the means.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA: "Hug her from behind."]** — Mówca: **Player_Italic**
> "I snuck up behind Monica and gave her a hug. She screamed and dropped her ladle."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[128]`
Mówca: **Narrator**
> "Monica whirled around in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[129]`
Mówca: **Monica**
> ""And every day you stay in government gives your opponents more chances to smear your reputation -- and ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Deana: ""They've been making fun of me at school because of you, ..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "Monica slammed her hand down on the table, surprising the three of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Monica: ""No. The Anton Rayne I married wouldn't give up so easily.""*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Monica: ""God, Anton, don't startle me like that! You know I'm sti..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "When she realized it was me, she smiled and gave me a kis..."*)

### Węzeł `[134]`
Mówca: **Narrator**
> "When she realized it was me, she smiled and gave me a kiss on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Monica: ""Sorry, Anton. I guess I've been on edge lately.""*)

### Węzeł `[135]`
Mówca: **Monica**
> ""My God, Anton. You think it's that bad?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Franc: ""Yeah, it's bad. And my professors are saying it could ge..."*)

### Węzeł `[136]`
Mówca: **Monica**
> ""You might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Franc: ""Yeah, it's bad. And my professors are saying it could ge..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""And I won't stop fighting for the causes I believe in, too. From a distance.""]** — Mówca: **Player**
> ""And I won't stop fighting for the causes I believe in, too. From a distance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Monica and I smiled at each other."*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""Well, I'm done with politics. Full stop. I'll take up farming or something.""]** — Mówca: **Player**
> ""Well, I'm done with politics. Full stop. I'll take up farming or something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Monica and I smiled at each other."*)

### Węzeł `[139]`
Mówca: **Narrator**
> "Monica frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)

### Węzeł `[140]`
Mówca: **Monica**
> ""Anton, you can't do that. Not for my sake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player: ""It's not just for your sake. I'm sick and tired of this ..."*)
  - -> `[206]` (*Player: ""I can and I will.""*)

### Węzeł `[141]`
Mówca: **Franc**
> ""Great. Amazing. Can we finish dinner now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: ""Of course.""*)
  - -> `[119]` (*Player: ""You two go ahead. I'm going to my study.""*)

### Węzeł `[142]`
Mówca: **Monica**
> ""God, Anton, don't startle me like that! You know I'm still on edge after the parade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player: ""You're right. I won't do it again.""*)
  - -> `[147]` (*Player: ""Can't a man greet his wife?""*)

### Węzeł `[143]`
**[WYBÓR GRACZA: ""I know, and you'll be able to come back to that. But we need to lay low for a while.""]** — Mówca: **Player**
> ""I know, and you'll be able to come back to that. But we need to lay low for a while.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Monica: ""I-- you might be right.""*)

### Węzeł `[144]`
Mówca: **Monica**
> ""We're going to have to have a serious talk about the things you did while in office, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA: ""You're right. I won't do it again.""]** — Mówca: **Player**
> ""You're right. I won't do it again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[146]`
Mówca: **Monica**
> ""Sorry, Anton. I guess I've been on edge lately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Monica: ""Why don't you go fix yourself a drink in the living room..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA: ""Can't a man greet his wife?""]** — Mówca: **Player**
> ""Can't a man greet his wife?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Monica: ""Yes, of course. Just walk in a little more loudly next t..."*)

### Węzeł `[148]`
Mówca: **Monica**
> ""It's settled then. You'll fight and you'll win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: ""Yes. For you three.""*)
  - -> `[113]` (*Player: ""Yes. For Sordland.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "The four of us finished our food in silence. Once we had ..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""You three go ahead. I'm going to my study.""]** — Mówca: **Player**
> ""You three go ahead. I'm going to my study.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "I cleared my plate and went upstairs."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""Monica. You know I only did what I did because I had to.""]** — Mówca: **Player**
> ""Monica. You know I only did what I did because I had to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Monica: ""The ends don't justify the means.""*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""Monica, everything I did was for you!""]** — Mówca: **Player**
> ""Monica, everything I did was for you!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Monica: ""The ends don't justify the means.""*)

### Węzeł `[153]`
**[WYBÓR GRACZA: ""You won't be able to fight for women's rights from a cell. Or a grave.""]** — Mówca: **Player**
> ""You won't be able to fight for women's rights from a cell. Or a grave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Monica: ""My God, Anton. You think it's that bad?""*)

### Węzeł `[154]`
Mówca: **Narrator**
> "Monica smiled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Monica: ""I'm looking forward to that, Anton. After everything tha..."*)

### Węzeł `[155]`
Mówca: **Monica**
> ""I'm still going to keep fighting for women's rights. No matter who wins the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: ""And I won't stop fighting for the causes I believe in, t..."*)
  - -> `[138]` (*Player: ""Well, I'm done with politics. Full stop. I'll take up fa..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Monica: ""I still can't believe Serge is gone.""*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Monica: ""I still can't believe nobody got hurt.""*)

### Węzeł `[159]`
Mówca: **Monica**
> ""Yes, of course. Just walk in a little more loudly next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Monica: ""Why don't you go fix yourself a drink in the living room..."*)

### Węzeł `[160]`
Mówca: **Monica**
> ""I'm disappointed in you, Anton. But I can't force you to go on if you don't want to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA: "Raise your glass."]** — Mówca: **Player_Italic**
> "I raised my glass for a toast. Monica, Franc and Deana slowly followed suit, looking puzzled."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""I know the past four years have been hard on all of us.""*)
  - -> `[81]` (*Player: ""The past four years have been the hardest in my life.""*)
  - -> `[83]` (*Player: ""The past four years have tested our strength as a family.""*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player: ""The military is after me. After what happened at the par..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[165]`
Mówca: **Monica**
> ""I still can't believe nobody got hurt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Monica: ""Why don't you go fix yourself a drink in the living room..."*)

### Węzeł `[166]`
Mówca: **Monica**
> ""I still can't believe Serge is gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Monica: ""Why don't you go fix yourself a drink in the living room..."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "The four of us ate and animatedly discussed our holiday plans. Once we had cleared our plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "I still had work to do."*)

### Węzeł `[168]`
Mówca: **Franc**
> ""Go Dad. I believe in you. Can we finish dinner now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: ""Of course.""*)
  - -> `[150]` (*Player: ""You three go ahead. I'm going to my study.""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_ImpeachmentTrial == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player: ""I'm about to be the first president in Sordish history t..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_GivenEstordAndNarbel == true)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player: ""I've just signed part of my own country over to Rumburg...."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[175]`
Mówca: **Monica**
> ""Why don't you go fix yourself a drink in the living room? I'll let you know when dinner's ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "I sat down in the living room, poured myself a bit of whi..."*)

### Węzeł `[176]`
Mówca: **Monica**
> ""Anton, I think you should stop. Not just drop out of the election -- quit politics entirely..""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player: ""What? Why?""*)
  - -> `[221]` (*Player: ""I can't. I've come too far.""*)
  - -> `[216]` (*Player: ""Honestly, I've been having similar thoughts.""*)

### Węzeł `[177]`
Mówca: **Narrator**
> "I sat down in the living room, poured myself a bit of whiskey and flipped through one of Monica's women's magazines."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_LeadsWomensRights == true && Ba..."*)

### Węzeł `[178]`
**[WYBÓR GRACZA: "Tap on the side of your glass."]** — Mówca: **Player_Italic**
> "I tapped on the side of my glass for attention. Monica, Franc and Deana looked at me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""I know the past four years have been hard on all of us.""*)
  - -> `[81]` (*Player: ""The past four years have been the hardest in my life.""*)
  - -> `[83]` (*Player: ""The past four years have tested our strength as a family.""*)

### Węzeł `[179]`
Mówca: **Narrator**
> "As I spoke, I felt like a weight was lifting from my shoulders. I knew I'd made the right choice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Monica: ""I'm still going to keep fighting for women's rights. No ..."*)

### Węzeł `[180]`
Mówca: **Monica**
> ""I'm disappointed, but I can't force you to continue a fight you've got no interest in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)

### Węzeł `[181]`
Mówca: **Monica**
> ""The best? You think that witch Lileas will continue our women's rights reforms?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Monica: ""I'm disappointed in you, Anton. But I can't force you to..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Monica: ""And the things you did as President... maybe this is for..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Monica: ""There's still so much that needs to be done for Sordland..."*)

### Węzeł `[185]`
Mówca: **Monica**
> ""Good. Because I'll be damned if that witch Lileas tears down our progress on women's rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Monica: ""It's settled then. You'll fight and you'll win.""*)

### Węzeł `[186]`
Mówca: **Narrator**
> "Monica and I smiled at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Deana: ""Cool. It'll be an adventure!""*)

### Węzeł `[187]`
Mówca: **Narrator**
> "It took me a second to realize Monica herself was on the cover. The headline: "Sordland's Woman of the Year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "Suddenly, Franc burst through the door."*)

### Węzeł `[188]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "The four of us ate and animatedly discussed our holiday p..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_LeadsWomensRights == true && BaseGame.Enable_WomensRightsBill_Strong == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_LeadsWomensRights == true && Ba..."*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_LeadsWomensRights == true && ..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_LeadsWomensRights == true && BaseGame.Enable_WomensRightsBill_Strong == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_LeadsWomensRights"] == true  and  Variable["BaseGame.Enable_WomensRightsBill_Strong"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "It took me a second to realize Monica herself was on the ..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_LeadsWomensRights == true && BaseGame.Enable_WomensRightsBill_Strong == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_LeadsWomensRights"] == true  and  Variable["BaseGame.Enable_WomensRightsBill_Strong"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "Suddenly, Franc burst through the door."*)

### Węzeł `[192]`
Mówca: **Monica**
> ""No. The things your father's done... he's brought this on himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: ""Monica. You know I only did what I did because I had to.""*)
  - -> `[152]` (*Player: ""Monica, everything I did was for you!""*)

### Węzeł `[193]`
Mówca: **Monica**
> ""I don't know about this, Anton. I still have so much to do for women's rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: ""I know, and you'll be able to come back to that. But we ..."*)
  - -> `[153]` (*Player: ""You won't be able to fight for women's rights from a cel..."*)

### Węzeł `[194]`
Mówca: **Monica**
> ""I-- you might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Deana: ""Papa, where are we going?""*)

### Węzeł `[195]`
Mówca: **Monica**
> ""You may be right. I just hate the idea of losing all the progress we've made...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Deana: ""Papa, where are we going?""*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true)"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Monica: ""I still don't think you should have let that witch Lilea..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Monica: ""I'm disappointed, but I can't force you to continue a fi..."*)

### Węzeł `[199]`
Mówca: **Monica**
> ""Dinner's ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "The three of us gathered around the dining room table. Mo..."*)

### Węzeł `[200]`
Mówca: **Narrator**
> "The three of us gathered around the dining room table. Monica ladled out bowls full of zabla. The stew tasted as good as it smelled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""Now that we're all here, I wanted to say something.""*)
  - -> `[161]` (*Player_Italic: "Raise your glass."*)
  - -> `[178]` (*Player_Italic: "Tap on the side of your glass."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Monica: ""Good. Because I'll be damned if that witch Lileas tears ..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Monica: ""It's settled then. You'll fight and you'll win.""*)

### Węzeł `[204]`
Mówca: **Monica**
> ""Of course I don't want to lose the progress we've made for women -- but I'm afraid that'll happen anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA: ""It's not just for your sake. I'm sick and tired of this game. I want out.""]** — Mówca: **Player**
> ""It's not just for your sake. I'm sick and tired of this game. I want out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)

### Węzeł `[206]`
**[WYBÓR GRACZA: ""I can and I will.""]** — Mówca: **Player**
> ""I can and I will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)

### Węzeł `[207]`
Mówca: **Deana**
> ""Yeah! Franc, are you coming too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)

### Węzeł `[208]`
Mówca: **Monica**
> ""You never did know when to give up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Franc: ""Go Dad. I believe in you. Can we finish dinner now?""*)

### Węzeł `[209]`
Mówca: **Monica**
> ""I'm looking forward to that, Anton. After everything that's happened... it's really for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Monica: ""The best? You think that witch Lileas will continue our ..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Monica: ""I'm disappointed in you, Anton. But I can't force you to..."*)

### Węzeł `[213]`
Mówca: **Deana**
> ""Does that mean we're not gonna live here anymore?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player: ""Oh, we're getting as far away from Holsord as we can.""*)
  - -> `[263]` (*Player: ""We could stay here. But we don't have to. We can go anyw..."*)

### Węzeł `[214]`
**[WYBÓR GRACZA: ""Well, I'm done with politics. Full stop. I'll take up farming or something.""]** — Mówca: **Player**
> ""Well, I'm done with politics. Full stop. I'll take up farming or something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Monica and I smiled at each other."*)

### Węzeł `[215]`
Mówca: **Franc**
> ""Yes. Great. More family time. For now, can we finish dinner?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: ""Of course.""*)
  - -> `[7]` (*Player: ""You three go ahead. I'm going to my study.""*)

### Węzeł `[216]`
**[WYBÓR GRACZA: ""Honestly, I've been having similar thoughts.""]** — Mówca: **Player**
> ""Honestly, I've been having similar thoughts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Monica: ""With everything that's happened... I don't think the pub..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA: ""Nobody will listen to you once I'm out of office. Sorry.""]** — Mówca: **Player**
> ""Nobody will listen to you once I'm out of office. Sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Monica: ""You may be right. I just hate the idea of losing all the..."*)

### Węzeł `[218]`
**[WYBÓR GRACZA: ""Monica. You know I only did what I did because I had to.""]** — Mówca: **Player**
> ""Monica. You know I only did what I did because I had to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Monica: ""The ends don't justify the means.""*)

### Węzeł `[219]`
**[WYBÓR GRACZA: ""Monica, everything I did was for you!""]** — Mówca: **Player**
> ""Monica, everything I did was for you!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Monica: ""The ends don't justify the means.""*)

### Węzeł `[220]`
**[WYBÓR GRACZA: ""I-- you're right. I don't know what I'm talking about.""]** — Mówca: **Player**
> ""I-- you're right. I don't know what I'm talking about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)

### Węzeł `[221]`
**[WYBÓR GRACZA: ""I can't. I've come too far.""]** — Mówca: **Player**
> ""I can't. I've come too far.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Monica: ""With everything that's happened... I don't think the pub..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA: ""What? Why?""]** — Mówca: **Player**
> ""What? Why?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[176]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Monica: ""With everything that's happened... I don't think the pub..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA: ""I'm about to be the first president in Sordish history to get impeached. I'll be a pariah, and so will both of you.""]** — Mówca: **Player**
> ""I'm about to be the first president in Sordish history to get impeached. I'll be a pariah, and so will all of you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Kontekst wejściowy (poprzednik):** `[105]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Deana scratched her head."*)

### Węzeł `[224]`
Mówca: **Narrator**
> "Monica gave me a look of gratitude."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Monica: ""I truly think it's for the best.""*)

### Węzeł `[225]`
**[WYBÓR GRACZA: ""The military is after me. After what happened at the parade, I'm not safe -- and neither are you.""]** — Mówca: **Player**
> ""The military is after me. After what happened at the parade, I'm not safe -- and neither are you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[105]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "Deana looked at me in disbelief. Her lower lip trembled s..."*)

### Węzeł `[226]`
Mówca: **Narrator**
> "Monica's lips formed a thin line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Monica: ""You never did know when to give up.""*)

### Węzeł `[227]`
Mówca: **Monica**
> ""Think of everything you've accomplished. And everything you have left to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Monica: ""Everything *we* have left to do.""*)

### Węzeł `[228]`
Mówca: **Deana**
> ""Are they gonna try to kill us like they tried to kill Papa?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Narrator: "Monica's brow was furrowed."*)

### Węzeł `[229]`
**[WYBÓR GRACZA: ""I've just signed part of my own country over to Rumburg. I'm going to be a pariah, and so are all of you.""]** — Mówca: **Player**
> ""I've just signed part of my own country over to Rumburg. I'm going to be a pariah, and so are all of you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Kontekst wejściowy (poprzednik):** `[105]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Deana scratched her head."*)

### Węzeł `[230]`
Mówca: **Deana**
> ""Are they gonna kill us like they killed Serge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Narrator: "Monica's brow was furrowed."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 5"*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 5)"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Monica: ""No. The things your father's done... he's brought this o..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Monica: ""I don't know about this, Anton. I still have so much to ..."*)

### Węzeł `[234]`
Mówca: **Deana**
> ""They've been making fun of me at school because of you, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA: ""I'm sorry. But this is for the best.""]** — Mówca: **Player**
> ""I'm sorry. But this is for the best.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)

### Węzeł `[236]`
Mówca: **Monica**
> ""I'm still going to keep fighting for women's rights. No matter who wins the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: ""And I won't stop fighting for the causes I believe in, t..."*)
  - -> `[214]` (*Player: ""Well, I'm done with politics. Full stop. I'll take up fa..."*)

### Węzeł `[237]`
Mówca: **Narrator**
> "Monica and Deana grinned at each other. Franc rolled his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Franc: ""Yes. Great. More family time. For now, can we finish din..."*)

### Węzeł `[238]`
Mówca: **Deana**
> ""Where are we gonna go?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player: ""Ladies' choice.""*)
  - -> `[250]` (*Player: ""We'll go to the Benfi coast.""*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard == true"*)

### Węzeł `[239]`
Mówca: **Deana**
> ""Does that mean we're not gonna live here anymore?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Player: ""Oh, we're getting as far away from Holsord as we can.""*)
  - -> `[453]` (*Player: ""We could stay here. But we don't have to. We can go anyw..."*)

### Węzeł `[240]`
Mówca: **Monica**
> ""Deana, you don't have to worry about that. The things your father's done... he's brought this on himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player: ""Monica. You know I only did what I did because I had to.""*)
  - -> `[219]` (*Player: ""Monica, everything I did was for you!""*)

### Węzeł `[241]`
Mówca: **Monica**
> ""I don't know about this, Anton. I still have so much to do for women's rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: ""I know, and you'll be able to come back to that. But we ..."*)
  - -> `[217]` (*Player: ""Nobody will listen to you once I'm out of office. Sorry.""*)

### Węzeł `[242]`
Mówca: **Deana**
> ""Yeah, Papa. You've gotta stay strong!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player: ""I'm sorry. But this is for the best.""*)
  - -> `[220]` (*Player: ""I-- you're right. I don't know what I'm talking about.""*)

### Węzeł `[243]`
Mówca: **Narrator**
> "As I spoke, I felt like a weight was lifting from my shoulders. I knew I'd made the right choice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Monica: ""I'm still going to keep fighting for women's rights. No ..."*)

### Węzeł `[244]`
**[WYBÓR GRACZA: ""Okay. You've made your point. I'll retire.""]** — Mówca: **Player**
> ""Okay. You've made your point. I'll retire.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "Monica gave me a look of gratitude."*)

### Węzeł `[245]`
**[WYBÓR GRACZA: ""Sorry, Monica. I've got to keep going.""]** — Mówca: **Player**
> ""Sorry, Monica. I've got to keep going.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "Monica's lips formed a thin line."*)

### Węzeł `[246]`
Mówca: **Monica**
> ""Of course not, sweetie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Franc: ""Come on, Mom. None of us know what these people are capa..."*)

### Węzeł `[247]`
Mówca: **Monica**
> ""I still don't think you should have let that witch Lileas win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Monica: ""I'm disappointed, but I can't force you to continue a fi..."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "Deana still looked confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Deana: ""Does that mean we're not gonna live here anymore?""*)

### Węzeł `[249]`
**[WYBÓR GRACZA: ""Ladies' choice.""]** — Mówca: **Player**
> ""Ladies' choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Narrator: "Monica and Deana grinned at each other. Franc rolled his ..."*)

### Węzeł `[250]`
**[WYBÓR GRACZA: ""We'll go to the Benfi coast.""]** — Mówca: **Player**
> ""We'll go to the Benfi coast.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Narrator: "Monica and Deana grinned at each other. Franc rolled his ..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_..."*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumbur..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3 || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Turn10_PartyCongress_Lost == true || BaseGame.Public_Opinion < 0 || BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  or  Variable["BaseGame.Public_Opinion"] < 0  or  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "Monica slammed her hand down on the table, surprising the..."*)

### Węzeł `[254]`
Mówca: **Narrator**
> "Deana looked at me in disbelief. Her lower lip trembled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Deana: ""Mama? Is that true?""*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Monica: ""We're going to have to have a serious talk about the thi..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Monica: ""There's still so much that needs to be done for Sordland..."*)

### Węzeł `[258]`
Mówca: **Monica**
> ""You being President -- it hasn't been easy on any of us. Maybe we could go back to the way things were before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: ""Okay. You've made your point. I'll retire.""*)
  - -> `[245]` (*Player: ""Sorry, Monica. I've got to keep going.""*)

### Węzeł `[259]`
Mówca: **Narrator**
> "Monica's brow was furrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Monica: ""Of course not, sweetie.""*)

### Węzeł `[260]`
Mówca: **Monica**
> ""Everything *we* have left to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Deana: ""Yeah, Papa. You've gotta stay strong!""*)

### Węzeł `[261]`
Mówca: **Monica**
> ""With everything that's happened... I don't think the public is on your side anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 0"*)

### Węzeł `[262]`
**[WYBÓR GRACZA: ""Oh, we're getting as far away from Holsord as we can.""]** — Mówca: **Player**
> ""Oh, we're getting as far away from Holsord as we can.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "As I spoke, I felt like a weight was lifting from my shou..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA: ""We could stay here. But we don't have to. We can go anywhere we want.""]** — Mówca: **Player**
> ""We could stay here. But we don't have to. We can go anywhere we want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "As I spoke, I felt like a weight was lifting from my shou..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 5"*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 5)"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Monica: ""Deana, you don't have to worry about that. The things yo..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Monica: ""I don't know about this, Anton. I still have so much to ..."*)

### Węzeł `[267]`
Mówca: **Monica**
> ""And the things you did as President... maybe this is for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)

### Węzeł `[268]`
Mówca: **Monica**
> ""There's still so much that needs to be done for Sordland. But maybe you're not the one to do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)

### Węzeł `[269]`
Mówca: **Narrator**
> "Suddenly, Franc burst through the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Franc: ""Sorry I'm late. Are some of those guards outside new? I ..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[273]`
Mówca: **Franc**
> ""Sorry I'm late. Are some of those guards outside new? I had to convince them I was really your son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Player: ""They might be.""*)
  - -> `[285]` (*Player: ""I'm starting to get suspicious of them, to be honest.""*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Franc: ""Sorry I'm late. I ran into a couple of my friends protes..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Franc: ""Sorry I'm late. I was with Sheyna. We were, uh, studying.""*)

### Węzeł `[277]`
Mówca: **Franc**
> ""Don't do it. They brought goggles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "Deana came running down the stairs."*)

### Węzeł `[278]`
Mówca: **Narrator**
> "He flung his backpack in a corner and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player: ""I hope you two are being careful.""*)
  - -> `[296]` (*Player: ""So that's still going on.""*)

### Węzeł `[279]`
**[WYBÓR GRACZA: ""Language!""]** — Mówca: **Player**
> ""Language!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[280]`
**[WYBÓR GRACZA: ""You could've invited them in. There's enough food.""]** — Mówca: **Player**
> ""You could've invited them in. There's enough food.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[292]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Franc: ""Ha. Even if they would cross the picket line, they're ve..."*)

### Węzeł `[281]`
Mówca: **Franc**
> ""You almost died *again*, and your biggest concern is swear words?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "Before I could respond, Deana came running down the stairs."*)

### Węzeł `[282]`
Mówca: **Franc**
> ""Well, I'd be more suspicious of them if I were you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "He flung his backpack in a corner and sprawled out in a c..."*)

### Węzeł `[283]`
Mówca: **Franc**
> ""Sorry I'm late. I ran into a couple of my friends protesting outside. It was pretty awkward, telling them I was having dinner with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "He flung his backpack in a corner and sprawled out in a c..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA: ""They might be.""]** — Mówca: **Player**
> ""They might be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Franc: ""Well, I'd be more suspicious of them if I were you.""*)

### Węzeł `[285]`
**[WYBÓR GRACZA: ""I'm starting to get suspicious of them, to be honest.""]** — Mówca: **Player**
> ""I'm starting to get suspicious of them, to be honest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "He flung his backpack in a corner and sprawled out in a c..."*)

### Węzeł `[286]`
Mówca: **Franc**
> ""Sorry I'm late. I was with Sheyna. We were, uh, studying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Narrator: "He flung his backpack in a corner and sprawled out in a c..."*)

### Węzeł `[287]`
Mówca: **Narrator**
> "Deana came running down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Deana: ""Franc! Franc!""*)

### Węzeł `[288]`
Mówca: **Narrator**
> "Before I could respond, Deana came running down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Deana: ""Franc! Franc!""*)

### Węzeł `[289]`
Mówca: **Narrator**
> "Franc glared at me. He looked like he was about to say something else, but then Deana came down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Deana: ""Franc! Franc!""*)

### Węzeł `[290]`
Mówca: **Narrator**
> "Franc smirked. He looked like he was about to say something else, but then Deana came down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Deana: ""Franc! Franc!""*)

### Węzeł `[291]`
**[WYBÓR GRACZA: ""I hope you two are being careful.""]** — Mówca: **Player**
> ""I hope you two are being careful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_..."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "He flung his backpack in a corner and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Player: ""You *know* those brats? I was going to ask the guards to..."*)
  - -> `[280]` (*Player: ""You could've invited them in. There's enough food.""*)

### Węzeł `[293]`
**[WYBÓR GRACZA: ""It wasn't a 'close call' for Serge.""]** — Mówca: **Player**
> ""It wasn't a 'close call' for Serge.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Kontekst wejściowy (poprzednik):** `[311]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Franc: ""Yeah. I hope his family's doing okay.""*)

### Węzeł `[294]`
**[WYBÓR GRACZA: ""Too close.""]** — Mówca: **Player**
> ""Too close.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[311]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Franc: ""Right.""*)

### Węzeł `[295]`
Mówca: **Franc**
> ""Don't look so surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "Franc smirked. He looked like he was about to say somethi..."*)

### Węzeł `[296]`
**[WYBÓR GRACZA: ""So that's still going on.""]** — Mówca: **Player**
> ""So that's still going on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_..."*)

### Węzeł `[297]`
Mówca: **Franc**
> ""Serge is dead, and your biggest concern is swear words?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "Before I could respond, Deana came running down the stairs."*)

### Węzeł `[298]`
Mówca: **Franc**
> ""Ha. Even if they would cross the picket line, they're vegetarians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "Deana came running down the stairs."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Player: ""It wasn't a 'close call' for Serge.""*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player: ""Too close.""*)

### Węzeł `[302]`
Mówca: **Narrator**
> "He flung his backpack in a corner and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Franc: ""Shit, Dad, that parade was a close call. I thought the b..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_..."*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unres..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Franc: ""We're certainly being more careful than you've been with..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Franc: ""Don't you worry. I've seen what fatherhood does to a man.""*)

### Węzeł `[306]`
Mówca: **Franc**
> ""Yeah. I hope his family's doing okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "Before I could respond, Deana came running down the stairs."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Franc: ""Serge is dead, and your biggest concern is swear words?""*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Franc: ""You almost died *again*, and your biggest concern is swe..."*)

### Węzeł `[310]`
**[WYBÓR GRACZA: ""You *know* those brats? I was going to ask the guards to have them tear-gassed.""]** — Mówca: **Player**
> ""You *know* those brats? I was going to ask the guards to have them tear-gassed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[292]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Franc: ""Don't do it. They brought goggles.""*)

### Węzeł `[311]`
Mówca: **Franc**
> ""Shit, Dad, that parade was a close call. I thought the ball was bad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[279]` (*Player: ""Language!""*)

### Węzeł `[312]`
Mówca: **Franc**
> ""Don't you worry. I've seen what fatherhood does to a man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "Franc smirked. He looked like he was about to say somethi..."*)

### Węzeł `[313]`
Mówca: **Franc**
> ""We're certainly being more careful than you've been with your treatment of her people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Narrator: "Franc glared at me. He looked like he was about to say so..."*)

### Węzeł `[314]`
Mówca: **Franc**
> ""Yes, no thanks to you. One of her uncles was almost killed during that business at the dam.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Narrator: "Franc glared at me. He looked like he was about to say so..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_..."*)
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unres..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Franc: ""Yes, no thanks to you. One of her uncles was almost kill..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Franc: ""Don't look so surprised.""*)

### Węzeł `[318]`
Mówca: **Franc**
> ""Right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "Before I could respond, Deana came running down the stairs."*)

### Węzeł `[319]`
Mówca: **Deana**
> ""Franc! Franc!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Franc: ""Hey, pipsqueak.""*)

### Węzeł `[320]`
Mówca: **Franc**
> ""Hey, pipsqueak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Narrator: "The two of them ignored me for a moment and started chatt..."*)

### Węzeł `[321]`
Mówca: **Narrator**
> "The two of them ignored me for a moment and started chatting away about their schools."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "Monica appeared in the doorway and smiled warmly at the s..."*)

### Węzeł `[322]`
Mówca: **Narrator**
> "Monica appeared in the doorway and smiled warmly at the sight of the three of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Monica: ""Dinner's ready.""*)

### Węzeł `[323]`
Mówca: **Franc**
> ""Come on, Mom. None of us know what these people are capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 5"*)

### Węzeł `[324]`
**[WYBÓR GRACZA: ""I'm not going anywhere without you.""]** — Mówca: **Player**
> ""I'm not going anywhere without you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "Monica's lips formed a thin line."*)

### Węzeł `[325]`
**[WYBÓR GRACZA: ""I'll come back soon.""]** — Mówca: **Player**
> ""I'll come back soon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Monica: ""Let's finish dinner, at least.""*)

### Węzeł `[326]`
Mówca: **Narrator**
> "I had a lot of packing to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[327]`
Mówca: **Narrator**
> "When we were done, we cleared our plates and went up to our rooms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Narrator: "We had a lot of packing to do."*)

### Węzeł `[328]`
**[WYBÓR GRACZA: ""I'll call all the time.""]** — Mówca: **Player**
> ""I'll call all the time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Monica: ""Let's finish dinner, at least.""*)

### Węzeł `[329]`
Mówca: **Narrator**
> "I put that thought out of my mind as I cleared my plate and went up to the bedroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "I had a lot of packing to do."*)

### Węzeł `[330]`
**[WYBÓR GRACZA: ""Kyrute. It's going to be an adventure.""]** — Mówca: **Player**
> ""Kyrute. It's going to be an adventure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Monica: ""We're not going anywhere, Deana. Only your father is.""*)

### Węzeł `[331]`
**[WYBÓR GRACZA: ""You'll find out once we get there. It'll be a surprise.""]** — Mówca: **Player**
> ""You'll find out once we get there. It'll be a surprise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Monica: ""We're not going anywhere, Deana. Only your father is.""*)

### Węzeł `[332]`
Mówca: **Monica**
> ""And Anton, you and I are going to have a serious talk once this has blown over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player: ""All right, all right. Let's finish dinner.""*)
  - -> `[366]` (*Player: ""I've lost my appetite. I'll see you two later.""*)

### Węzeł `[333]`
Mówca: **Franc**
> ""Mom, are you kidding? This could be a huge mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Monica: ""I'm sorry, Franc. I'm not going to uproot our lives here..."*)

### Węzeł `[334]`
Mówca: **Monica**
> ""Let's finish dinner, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Player: ""All right.""*)
  - -> `[344]` (*Player: ""No, we don't have time.""*)

### Węzeł `[335]`
Mówca: **Narrator**
> "I still had plenty of work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "Narrator: "...""*)

### Węzeł `[336]`
Mówca: **Narrator**
> "We had a lot of packing to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou = true"*)

### Węzeł `[337]`
Mówca: **Narrator**
> "I took a last look at Monica, Franc and Deana as I cleared my plate and went up to the bedroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "I had a lot of packing to do."*)

### Węzeł `[338]`
**[WYBÓR GRACZA: ""Kyrute. It's going to be an adventure.""]** — Mówca: **Player**
> ""Kyrute. It's going to be an adventure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Deana: ""But what about school? What about my friends?""*)

### Węzeł `[339]`
**[WYBÓR GRACZA: ""You'll find out once we get there. It'll be a surprise.""]** — Mówca: **Player**
> ""You'll find out once we get there. It'll be a surprise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Deana: ""But what about school? What about my friends?""*)

### Węzeł `[340]`
Mówca: **Monica**
> ""It's better this way, sweetheart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Player: ""I'll come back soon.""*)
  - -> `[328]` (*Player: ""I'll call all the time.""*)

### Węzeł `[341]`
Mówca: **Monica**
> ""Then the Raynes are staying put.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Monica: ""And Anton, you and I are going to have a serious talk on..."*)

### Węzeł `[342]`
Mówca: **Monica**
> ""Let's finish dinner, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player: ""All right.""*)
  - -> `[351]` (*Player: ""No, I don't have time.""*)

### Węzeł `[343]`
**[WYBÓR GRACZA: ""All right.""]** — Mówca: **Player**
> ""All right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[334]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Narrator: "We ate in tense silence. I could tell Monica, Franc and D..."*)

### Węzeł `[344]`
**[WYBÓR GRACZA: ""No, we don't have time.""]** — Mówca: **Player**
> ""No, we don't have time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[334]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Narrator: "We hurriedly cleared our plates. Monica, Deana and I went..."*)

### Węzeł `[345]`
Mówca: **Narrator**
> "The four of us ate in tense silence. I wondered if this would be our last dinner together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "I put that thought out of my mind as I cleared my plate a..."*)

### Węzeł `[346]`
Mówca: **Monica**
> ""I'm sorry, Franc. I'm not going to uproot our lives here because of mistakes your father made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Monica: ""When will you leave, Anton?""*)

### Węzeł `[347]`
Mówca: **Narrator**
> "I cleared my plate and went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "I still had plenty of work to do."*)

### Węzeł `[348]`
Mówca: **Narrator**
> "The four of us finished our food in silence. When we had cleared the plates, I went up to my study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "I still had plenty of work to do."*)

### Węzeł `[349]`
Mówca: **Monica**
> ""We're not going anywhere, Deana. Only your father is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Franc: ""Mom, are you kidding? This could be a huge mistake.""*)

### Węzeł `[350]`
Mówca: **Deana**
> ""Papa, no! You can't leave us!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Monica: ""It's better this way, sweetheart.""*)

### Węzeł `[351]`
**[WYBÓR GRACZA: ""No, I don't have time.""]** — Mówca: **Player**
> ""No, I don't have time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[342]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "I took a last look at Monica, Franc and Deana as I cleare..."*)

### Węzeł `[352]`
Mówca: **Narrator**
> "Monica's lips formed a thin line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Monica: ""Then the Raynes are staying put.""*)

### Węzeł `[353]`
Mówca: **Deana**
> ""But what about school? What about my friends?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Monica: ""You'll make lots of new friends. And Kyrute's school sys..."*)

### Węzeł `[354]`
Mówca: **Deana**
> ""Cool! We're going on an adventure!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Franc: ""Something like that...""*)

### Węzeł `[355]`
Mówca: **Monica**
> ""You'll make lots of new friends. And Kyrute's school system is a lot better than Sordland's, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Franc: ""This is crazy, Dad. When do you want to leave?""*)

### Węzeł `[356]`
**[WYBÓR GRACZA: ""In a week. I need to make sure our tracks are covered first.""]** — Mówca: **Player**
> ""In a week. I need to make sure our tracks are covered first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[357]`
**[WYBÓR GRACZA: ""In a week. I need to make sure our tracks are covered first.""]** — Mówca: **Player**
> ""In a week. I need to make sure our tracks are covered first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[360]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[358]`
**[WYBÓR GRACZA: ""All right.""]** — Mówca: **Player**
> ""All right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[342]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Narrator: "The four of us ate in tense silence. I wondered if this w..."*)

### Węzeł `[359]`
**[WYBÓR GRACZA: ""Tomorrow morning. I've got to get packing.""]** — Mówca: **Player**
> ""Tomorrow morning. I've got to get packing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[360]`
Mówca: **Franc**
> ""This is crazy, Dad. When do you want to leave?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Player: ""Tomorrow morning. Let's get packing.""*)
  - -> `[357]` (*Player: ""In a week. I need to make sure our tracks are covered fi..."*)

### Węzeł `[361]`
**[WYBÓR GRACZA: ""Tomorrow morning. Let's get packing.""]** — Mówca: **Player**
> ""Tomorrow morning. Let's get packing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[360]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[362]`
Mówca: **Narrator**
> "Monica's face paled. She nodded silently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Deana: ""Cool! We're going on an adventure!""*)

### Węzeł `[363]`
**[WYBÓR GRACZA: ""All right, all right. Let's finish dinner.""]** — Mówca: **Player**
> ""All right, all right. Let's finish dinner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Narrator: "The four of us finished our food in silence. When we had ..."*)

### Węzeł `[364]`
Mówca: **Narrator**
> "We hurriedly cleared our plates. Monica, Deana and I went up to our rooms, while Franc went back to his dormitory to collect his things."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Narrator: "We had a lot of packing to do."*)

### Węzeł `[365]`
Mówca: **Monica**
> ""When will you leave, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player: ""Tomorrow morning. I've got to get packing.""*)
  - -> `[356]` (*Player: ""In a week. I need to make sure our tracks are covered fi..."*)
  - -> `[324]` (*Player: ""I'm not going anywhere without you.""*)

### Węzeł `[366]`
**[WYBÓR GRACZA: ""I've lost my appetite. I'll see you two later.""]** — Mówca: **Player**
> ""I've lost my appetite. I'll see you two later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "I cleared my plate and went up to my study."*)

### Węzeł `[367]`
Mówca: **Narrator**
> "We ate in tense silence. I could tell Monica, Franc and Deana were all deep in thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "When we were done, we cleared our plates and went up to o..."*)

### Węzeł `[368]`
Mówca: **Franc**
> ""Something like that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Monica: ""Let's finish dinner, at least.""*)

### Węzeł `[369]`
Mówca: **Franc**
> ""Yeah, it's bad. And my professors are saying it could get a lot worse. I wouldn't mind leaving for a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[370]`
Mówca: **Monica**
> ""The ends don't justify the means.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[371]`
**[WYBÓR GRACZA: ""Kyrute. It's going to be an adventure.""]** — Mówca: **Player**
> ""Kyrute. It's going to be an adventure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[376]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Monica: ""We're not going anywhere, Deana. Only your father is.""*)

### Węzeł `[372]`
Mówca: **Narrator**
> "Deana still looked confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Deana: ""Papa, where are we going?""*)

### Węzeł `[373]`
Mówca: **Franc**
> ""Good choice, Mom. Dad, we can't just uproot our lives because of your mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Monica: ""When will you leave, Anton?""*)

### Węzeł `[374]`
Mówca: **Deana**
> ""Papa, where are we going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Narrator: "I thought for a moment. Kyrute, the only truly neutral co..."*)

### Węzeł `[375]`
Mówca: **Monica**
> ""We're not going anywhere, Deana. Only your father is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Franc: ""Good choice, Mom. Dad, we can't just uproot our lives be..."*)

### Węzeł `[376]`
Mówca: **Narrator**
> "I thought for a moment. Kyrute, the only truly neutral country I knew of, seemed like the obvious choice. A little house in the mountains wouldn't cost much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Player: ""Kyrute. It's going to be an adventure.""*)
  - -> `[377]` (*Player: ""You'll find out once we get there. It'll be a surprise.""*)

### Węzeł `[377]`
**[WYBÓR GRACZA: ""You'll find out once we get there. It'll be a surprise.""]** — Mówca: **Player**
> ""You'll find out once we get there. It'll be a surprise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[376]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Monica: ""We're not going anywhere, Deana. Only your father is.""*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Franc: ""It's an outcast, Dee. Like what I am since Anton Rayne b..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Franc: ""It's an outcast, Dee.""*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true &&..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Franc: ""It's an outcast, Dee. Like what I am since everyone at H..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[384]`
Mówca: **Franc**
> ""It's an outcast, Dee. Like what I am since everyone at Holsord State found out how I really got in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Narrator: "Franc gave me a pointed look. Deana still looked uncertain."*)

### Węzeł `[385]`
Mówca: **Narrator**
> "Franc gave me a pointed look. Deana still looked uncertain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 5"*)

### Węzeł `[386]`
Mówca: **Franc**
> ""It's an outcast, Dee. Like what I am since Anton Rayne became the enemy of Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Narrator: "Franc gave me a pointed look. Deana still looked uncertain."*)

### Węzeł `[387]`
Mówca: **Franc**
> ""It's an outcast, Dee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Narrator: "Franc gave me a pointed look. Deana still looked uncertain."*)

### Węzeł `[388]`
Mówca: **Deana**
> ""Papa, where are we going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "I thought for a moment. Kyrute, the only truly neutral co..."*)

### Węzeł `[389]`
Mówca: **Narrator**
> "I thought for a moment. Kyrute, the only truly neutral country I knew of, seemed like the obvious choice. A little house in the mountains wouldn't cost much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Player: ""Kyrute. It's going to be an adventure.""*)
  - -> `[392]` (*Player: ""You'll find out once we get there. It'll be a surprise.""*)

### Węzeł `[390]`
Mówca: **Narrator**
> "Monica's face paled. She nodded silently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Deana: ""Cool! We're going on an adventure!""*)

### Węzeł `[391]`
**[WYBÓR GRACZA: ""Kyrute. It's going to be an adventure.""]** — Mówca: **Player**
> ""Kyrute. It's going to be an adventure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[389]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Deana: ""But what about school? What about my friends?""*)

### Węzeł `[392]`
**[WYBÓR GRACZA: ""You'll find out once we get there. It'll be a surprise.""]** — Mówca: **Player**
> ""You'll find out once we get there. It'll be a surprise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[389]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Deana: ""But what about school? What about my friends?""*)

### Węzeł `[393]`
Mówca: **Deana**
> ""But what about school? What about my friends?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Monica: ""You'll make lots of new friends. And Kyrute's school sys..."*)

### Węzeł `[394]`
**[WYBÓR GRACZA: ""So be it. Monica and Deana, we'll leave in a week. I need to make sure our tracks are covered first.""]** — Mówca: **Player**
> ""So be it. Monica and Deana, we'll leave in a week. I need to make sure our tracks are covered first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[395]`
Mówca: **Narrator**
> "We had a lot of packing to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou = true"*)

### Węzeł `[396]`
Mówca: **Monica**
> ""Let's finish dinner, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Player: ""All right.""*)
  - -> `[406]` (*Player: ""No, we don't have time.""*)

### Węzeł `[397]`
Mówca: **Narrator**
> "When we were done, Franc took a cab back to Holsord State and Monica, Deana and I rushed up to our rooms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Narrator: "We had a lot of packing to do."*)

### Węzeł `[398]`
Mówca: **Monica**
> ""You'll make lots of new friends. And Kyrute's school system is a lot better than Sordland's, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Franc: ""This is crazy. Mom, Dad, you do what you want, but I'm s..."*)

### Węzeł `[399]`
Mówca: **Franc**
> ""I'll come visit once you're settled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Monica: ""Let's finish dinner, at least.""*)

### Węzeł `[400]`
**[WYBÓR GRACZA: ""All right.""]** — Mówca: **Player**
> ""All right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Narrator: "We ate in tense silence. I could tell Monica, Franc and D..."*)

### Węzeł `[401]`
Mówca: **Franc**
> ""This is crazy. Mom, Dad, you do what you want, but I'm staying put.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Player: ""So be it. Monica and Deana, we leave tomorrow morning. L..."*)
  - -> `[394]` (*Player: ""So be it. Monica and Deana, we'll leave in a week. I nee..."*)

### Węzeł `[402]`
Mówca: **Narrator**
> "We hurriedly cleared our plates. Franc took a cab back to Holsord State while Monica, Deana and I went up to our rooms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Narrator: "We had a lot of packing to do."*)

### Węzeł `[403]`
Mówca: **Narrator**
> "We ate in tense silence. I could tell Monica, Franc and Deana were all deep in thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Narrator: "When we were done, Franc took a cab back to Holsord State..."*)

### Węzeł `[404]`
**[WYBÓR GRACZA: ""So be it. Monica and Deana, we leave tomorrow morning. Let's get packing.""]** — Mówca: **Player**
> ""So be it. Monica and Deana, we leave tomorrow morning. Let's get packing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[401]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[405]`
Mówca: **Deana**
> ""Cool! We're going on an adventure!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Franc: ""I'll come visit once you're settled.""*)

### Węzeł `[406]`
**[WYBÓR GRACZA: ""No, we don't have time.""]** — Mówca: **Player**
> ""No, we don't have time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "We hurriedly cleared our plates. Franc took a cab back to..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true &&..."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Franc: ""I know things will be easier for me once everyone stops ..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[410]`
Mówca: **Franc**
> ""I know things will be easier for me once everyone stops talking about how I really got into Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[411]`
Mówca: **Franc**
> ""I know things will be easier for me at school once everyone stops blaming me for stuff you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[412]`
Mówca: **Franc**
> ""I know things will be easier for me once Anton Rayne is no longer enemy number one of Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "Deana still looked confused."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Franc: ""I know things will be easier for me once Anton Rayne is ..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Franc: ""I know things will be easier for me at school once every..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true &&..."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Franc: ""I know things will be easier for me once everyone stops ..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[419]`
Mówca: **Franc**
> ""I know things will be easier for me once everyone stops talking about how I really got into Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Narrator: "Deana looked slightly confused."*)

### Węzeł `[420]`
Mówca: **Franc**
> ""I know things will be easier for me once Anton Rayne is no longer enemy number one of Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Narrator: "Deana looked slightly confused."*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Franc: ""I know things will be easier for me once Anton Rayne is ..."*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Franc: ""I know things will be easier for me at school once every..."*)

### Węzeł `[424]`
Mówca: **Franc**
> ""I know things will be easier for me at school once everyone stops blaming me for stuff you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Narrator: "Deana looked slightly confused."*)

### Węzeł `[425]`
Mówca: **Narrator**
> "Deana looked slightly confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Deana: ""Does that mean we're not gonna live here anymore?""*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true &&..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Franc: ""I know things will be easier for me once everyone stops ..."*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Franc: ""I know things will be easier for me once Anton Rayne is ..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Franc: ""I know things will be easier for me at school once every..."*)

### Węzeł `[432]`
Mówca: **Franc**
> ""I know things will be easier for me at school once everyone stops blaming me for stuff you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Monica: ""You being President -- it hasn't been easy on any of us...."*)

### Węzeł `[433]`
Mówca: **Franc**
> ""I know things will be easier for me once everyone stops talking about how I really got into Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Monica: ""You being President -- it hasn't been easy on any of us...."*)

### Węzeł `[434]`
Mówca: **Franc**
> ""I know things will be easier for me once Anton Rayne is no longer enemy number one of Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Monica: ""You being President -- it hasn't been easy on any of us...."*)

### Węzeł `[435]`
Mówca: **Franc**
> ""Sure, as long as we don't go anywhere lame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Deana: ""Where are we gonna go?""*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true &&..."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Franc: ""Maybe. You know I've been studying twice as hard to prov..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[439]`
Mówca: **Franc**
> ""Maybe. You know I've been studying twice as hard to prove myself since everyone found out how I really got into Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Deana: ""Where are we gonna go?""*)

### Węzeł `[440]`
Mówca: **Franc**
> ""Sure. It's gonna be chaos on campus anyway no matter who wins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Deana: ""Where are we gonna go?""*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Franc: ""Sure. It's gonna be chaos on campus anyway no matter who..."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Franc: ""Sure, as long as we don't go anywhere lame.""*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Exile = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "Narrator: "...""*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Retirement_FamilyWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true"*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Retirement_FamilyWithYou = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Retirement_FamilyWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[452]`
**[WYBÓR GRACZA: ""Oh, we're getting as far away from Holsord as we can.""]** — Mówca: **Player**
> ""Oh, we're getting as far away from Holsord as we can.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[239]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "As I spoke, I felt like a weight was lifting from my shou..."*)

### Węzeł `[453]`
**[WYBÓR GRACZA: ""We could stay here. But we don't have to. We can go anywhere we want.""]** — Mówca: **Player**
> ""We could stay here. But we don't have to. We can go anywhere we want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[239]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "As I spoke, I felt like a weight was lifting from my shou..."*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Exile = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "Narrator: "...""*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Exile = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "Narrator: "...""*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FinalSupper_Retired = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "Narrator: "...""*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FinalSupper_Retired = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame...."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Monica: ""I suppose the politics world might not take you seriousl..."*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Monica: ""I suppose you don't have much of a chance of re-election..."*)

### Węzeł `[461]`
Mówca: **Monica**
> ""I suppose the politics world might not take you seriously after your presidency ends, anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Narrator: "Monica's face paled. She nodded silently."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Narrator: "Monica's face paled. She nodded silently."*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "I still had work to do."*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "Monica's face paled. She nodded silently."*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "Monica's face paled. She nodded silently."*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Deana: ""Papa, no! You can't leave us!""*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Deana: ""Papa, no! You can't leave us!""*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Narrator: "..."`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: ""But right now, there's no time. We need to get out of So..."*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[474]`
**[WYBÓR GRACZA: ""I never thought I would be a pariah.""]** — Mówca: **Player**
> ""I never thought I would be a pariah.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Deana scratched her head."*)
