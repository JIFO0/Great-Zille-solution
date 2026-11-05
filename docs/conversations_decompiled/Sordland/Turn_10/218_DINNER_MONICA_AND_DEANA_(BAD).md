# Sordland/Turn10/DINNER MONICA AND DEANA (BAD)

- **ID konwersacji:** `218`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/218_DINNER_MONICA_AND_DEANA_(BAD).md`
- **Liczba węzłów dialogowych:** 298
- **Liczba wyborów gracza:** 76

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
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Malenyevist`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Rumburg_War`
- `BaseGame.Situation_Law_ExcellentWomenRights`
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
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[49]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""Can't a man greet his wife?""** | `[172]` **Monica**: ""God, Anton, don't startle me li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Monica**: ""No. Not if he's you."" |
| `[14]` | **""What do you hear from your brother these days?""** | `[23]` **Deana**: ""Almost forgot that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Deana**: ""He doesn't call home so much no..."<br>`[275]` **Deana**: ""I think he's getting really int..."<br>*(oraz 3 innych odgałęzień)* |
| `[20]` | **""Kyrute. And you kids can visit whenever you want.""** | `[19]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Deana**: ""Um... All right."" |
| `[21]` | **""This is the presidential complex. Last I checked, I was still President.""** | `[31]` **Monica**: ""I'm sorry, Anton. This dinner w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Narrator**: "Deana was still sitting at the t..." |
| `[22]` | **""I'd rather not tell you. For safety reasons.""** | `[19]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Deana**: ""Um... All right."" |
| `[24]` | **""It's the presidential complex. I'm the President, remember?""** | `[49]` **Monica**: ""Then leave this house."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "Tears appeared in Monica's eyes." |
| `[25]` | **""Your mother is right, Deana. We're getting divorced -- immediately after the elec..."** | `[283]` **Deana**: ""That's not a surprise, Mama. He..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Monica**: ""That was the plan before I lear..."<br>`[17]` **Monica**: ""Don't worry, we won't make it p..." |
| `[26]` | **""Fine. I will.""** | `[49]` **Monica**: ""Then leave this house."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "Deana watched silently as I got ..." |
| `[40]` | **"Tap on the side of your glass."** | `[16]` **Narrator**: "The three of us gathered around ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Player**: ""I know the past four years have..."<br>`[80]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych odgałęzień)* |
| `[42]` | **"Raise your glass."** | `[16]` **Narrator**: "The three of us gathered around ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Player**: ""I know the past four years have..."<br>`[80]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych odgałęzień)* |
| `[44]` | **""Now that we're all here, I wanted to say something.""** | `[16]` **Narrator**: "The three of us gathered around ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Player**: ""I know the past four years have..."<br>`[80]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych odgałęzień)* |
| `[55]` | **""No. Not without my family.""** | `[68]` **Monica**: ""Go, Anton. I think it's better ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Monica**: ""Then leave this house."" |
| `[56]` | **""All right. I will leave in a week. I have to make sure my tracks are covered first.""** | `[68]` **Monica**: ""Go, Anton. I think it's better ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[47]` **Deana**: ""Papa, where are you going to go?"" |
| `[57]` | **""All right. I'm leaving tomorrow.""** | `[68]` **Monica**: ""Go, Anton. I think it's better ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Exile_LeaveNow"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[47]` **Deana**: ""Papa, where are you going to go?"" |
| `[63]` | **"Give the guards a suspicious look."** | `[46]` **Narrator**: "The guards formed a cordon to le..."<br>`[51]` **Narrator**: "I didn't know if it was my imagi..." | `Variable["BaseGame.Ending_Coup"] == true` | *Brak zmian stanu* | `[70]` **Narrator**: "Once inside, I locked the front ..." |
| `[64]` | **"Don't look at them and go to your door."** | `[46]` **Narrator**: "The guards formed a cordon to le..."<br>`[51]` **Narrator**: "I didn't know if it was my imagi..." | `Variable["BaseGame.Ending_Coup"] == true` | *Brak zmian stanu* | `[70]` **Narrator**: "Once inside, I locked the front ..." |
| `[69]` | **""I will. I'll see you later, Deana.""** | `[31]` **Monica**: ""I'm sorry, Anton. This dinner w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Narrator**: "Deana was still sitting at the t..." |
| `[78]` | **""The past four years have tested our strength as a family.""** | `[40]` **Player_Italic**: "I tapped on the side of my glass..."<br>`[42]` **Player_Italic**: "I raised my glass for a toast. M..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Player**: ""I was so busy focusing on the n..."<br>`[123]` **Player**: ""I let my power get to my head. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[80]` | **""The past four years have been the hardest in my life.""** | `[40]` **Player_Italic**: "I tapped on the side of my glass..."<br>`[42]` **Player_Italic**: "I raised my glass for a toast. M..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Player**: ""I was so busy focusing on the n..."<br>`[123]` **Player**: ""I let my power get to my head. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[82]` | **""I know the past four years have been hard on all of us.""** | `[40]` **Player_Italic**: "I tapped on the side of my glass..."<br>`[42]` **Player_Italic**: "I raised my glass for a toast. M..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Player**: ""I was so busy focusing on the n..."<br>`[123]` **Player**: ""I let my power get to my head. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[86]` | **""Where's your mother?""** | `[84]` **Deana**: ""Hi, Papa."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Narrator**: "Deana mutely gestured towards th..." |
| `[87]` | **""Deana! How is school?""** | `[84]` **Deana**: ""Hi, Papa."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Narrator**: "Deana shrugged." |
| `[89]` | **"Hug her."** | `[84]` **Deana**: ""Hi, Papa."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Player**: ""How's school?""<br>`[96]` **Player**: ""Where's your mother?"" |
| `[96]` | **""Where's your mother?""** | `[89]` **Player_Italic**: "I opened my arms to embrace my d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Narrator**: "Deana mutely gestured towards th..." |
| `[97]` | **""How's school?""** | `[89]` **Player_Italic**: "I opened my arms to embrace my d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Narrator**: "Deana shrugged." |
| `[100]` | **""I can and I will.""** | `[3]` **Monica**: ""Anton, you can't do that. Not f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Narrator**: "Monica sighed heavily." |
| `[106]` | **""Monica, we were going to wait until after the election.""** | `[122]` **Deana**: ""That's not a surprise, Mama. He..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Monica**: ""That was the plan before I lear..."<br>`[79]` **Monica**: ""You're not even running anymore..."<br>*(oraz 1 innych odgałęzień)* |
| `[107]` | **""Monica, now is not the time. We've got to get out of here.""** | `[122]` **Deana**: ""That's not a surprise, Mama. He..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Monica**: ""No, Anton. You've dug your own ..." |
| `[108]` | **""Your mother is right. We're divorcing immediately after the election.""** | `[122]` **Deana**: ""That's not a surprise, Mama. He..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Monica**: ""That was the plan before I lear..."<br>`[79]` **Monica**: ""You're not even running anymore..."<br>*(oraz 1 innych odgałęzień)* |
| `[110]` | **""It's not just for your sake. I'm sick and tired of this game. I want out.""** | `[3]` **Monica**: ""Anton, you can't do that. Not f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Narrator**: "Monica sighed heavily." |
| `[116]` | **""I will. And I'm still quitting politics, no matter what.""** | `[124]` **Monica**: ""I'm sorry, Anton. This dinner w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Narrator**: "Deana was still sitting at the t..." |
| `[117]` | **""Fine. But I'm not retiring. I'm going to stay in the Maroon Palace forever, just ..."** | `[124]` **Monica**: ""I'm sorry, Anton. This dinner w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Narrator**: "Deana was still sitting at the t..." |
| `[119]` | **""I've done some unforgivable things. Especially to you, Monica.""** | `[78]` **Player**: ""The past four years have tested..."<br>`[80]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Player**: ""I hope someday, we'll be able t..."<br>`[147]` **Player**: ""I hope I can redeem myself some..." |
| `[121]` | **""She's just jealous because she was always bad at sewing.""** | `[115]` **Deana**: ""I won a prize at the handicraft..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Narrator**: "Deana ignored my comment and ges..." |
| `[123]` | **""I let my power get to my head. I became unrecognizeable to myself -- and to all o..."** | `[78]` **Player**: ""The past four years have tested..."<br>`[80]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Player**: ""I hope someday, we'll be able t..."<br>`[147]` **Player**: ""I hope I can redeem myself some..." |
| `[125]` | **""Well, *I* care.""** | `[115]` **Deana**: ""I won a prize at the handicraft..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Narrator**: "Deana ignored my comment and ges..." |
| `[126]` | **""I was so busy focusing on the needs of the Sordish people that I forgot about Sor..."** | `[78]` **Player**: ""The past four years have tested..."<br>`[80]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Player**: ""I hope someday, we'll be able t..."<br>`[147]` **Player**: ""I hope I can redeem myself some..." |
| `[128]` | **""That's just silly.""** | `[118]` **Deana**: ""I won a prize at the science fa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Narrator**: "Deana ignored my comment and ges..." |
| `[132]` | **""You might be right.""** | `[118]` **Deana**: ""I won a prize at the science fa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Narrator**: "Deana ignored my comment and ges..." |
| `[138]` | **""The military is after me. After what happened at the parade, I'm not safe -- and ..."** | `[217]` **Monica**: ""Anton, what in the everloving h..." | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[201]` **Narrator**: "Deana looked at me in disbelief...." |
| `[140]` | **""I'm about to be the first president in Sordish history to get impeached. I'll be ..."** | `[217]` **Monica**: ""Anton, what in the everloving h..." | `Variable["BaseGame.Ending_ImpeachmentTrial"] == true` | *Brak zmian stanu* | `[216]` **Narrator**: "Deana scratched her head." |
| `[144]` | **""I've just signed part of my own country over to Rumburg. I'm going to be a pariah..."** | `[217]` **Monica**: ""Anton, what in the everloving h..." | `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true` | *Brak zmian stanu* | `[216]` **Narrator**: "Deana scratched her head." |
| `[145]` | **""I hope someday, we'll be able to put this behind us and be a family again.""** | `[119]` **Player**: ""I've done some unforgivable thi..."<br>`[123]` **Player**: ""I let my power get to my head. ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Narrator**: "Monica looked at me sadly. She s..." |
| `[147]` | **""I hope I can redeem myself someday.""** | `[119]` **Player**: ""I've done some unforgivable thi..."<br>`[123]` **Player**: ""I let my power get to my head. ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Narrator**: "Monica looked at me sadly. She s..." |
| `[148]` | **""I will. And I'm still quitting politics, no matter what.""** | `[158]` **Monica**: ""I'm sorry, Anton. This dinner w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Narrator**: "Deana was still sitting at the t..." |
| `[150]` | **""This is the presidential complex. Last I checked, I was still President.""** | `[158]` **Monica**: ""I'm sorry, Anton. This dinner w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Narrator**: "Deana was still sitting at the t..." |
| `[152]` | **""Smells delicious.""** | `[153]` **Narrator**: "I hesitantly stepped into the ki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Narrator**: "Monica whirled around in surpris..." |
| `[165]` | **"Hug her from behind."** | `[153]` **Narrator**: "I hesitantly stepped into the ki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Monica**: ""God, Anton, don't startle me li..."<br>`[184]` **Monica**: ""God, Anton, don't startle me li..." |
| `[179]` | **""Deana, don't listen to her. Everything's going to work out.""** | `[185]` **Deana**: ""That's not a surprise, Mama. He..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Monica**: ""That's not how this works. You ..." |
| `[180]` | **""Monica, didn't you hear a word I said? I'm putting politics behind me so we can b..."** | `[185]` **Deana**: ""That's not a surprise, Mama. He..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Monica**: ""That's not how this works. You ..." |
| `[181]` | **""Monica, we were going to wait until after the election.""** | `[185]` **Deana**: ""That's not a surprise, Mama. He..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Monica**: ""That was the plan before I lear..."<br>`[293]` **Monica**: ""You're not even running anymore..."<br>*(oraz 1 innych odgałęzień)* |
| `[182]` | **""I'm sorry. I'll go wait in the living room.""** | `[172]` **Monica**: ""God, Anton, don't startle me li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Narrator**: "I walked back out and sat on the..." |
| `[183]` | **""But right now, there's no time. We need to get out of Sordland. All of us.""** | `[157]` **Narrator**: "Monica looked at me sadly. She s..." | `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)` | *Brak zmian stanu* | `[192]` **Narrator**: "Monica and Deana turned to look ..." |
| `[197]` | **""My retirement from politics is going to be the best thing that ever happened to us.""** | `[157]` **Narrator**: "Monica looked at me sadly. She s..." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[206]` **Narrator**: "Monica sighed heavily." |
| `[198]` | **""I swear to you both, once I'm retired things will go back to the way they used to..."** | `[157]` **Narrator**: "Monica looked at me sadly. She s..." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[206]` **Narrator**: "Monica sighed heavily." |
| `[199]` | **""As a first step towards that, I'm retiring from politics at the end of this term.""** | `[157]` **Narrator**: "Monica looked at me sadly. She s..." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[219]` **Narrator**: "Monica and Deana looked at me in..." |
| `[200]` | **""I swear to you both, I'll learn from my mistakes as I strive to make Sordland a b..."** | `[157]` **Narrator**: "Monica looked at me sadly. She s..." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[186]` **Narrator**: "Monica sighed heavily." |
| `[212]` | **""Deana, don't listen to her. Everything's going to work out.""** | `[130]` **Deana**: ""That's not a surprise, Mama. He..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Monica**: ""That's not how this works. You ..." |
| `[213]` | **""Monica, didn't you hear a word I said? I'm putting politics behind me so we can b..."** | `[130]` **Deana**: ""That's not a surprise, Mama. He..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Monica**: ""That's not how this works. You ..." |
| `[214]` | **""Monica, we were going to wait until after the election.""** | `[130]` **Deana**: ""That's not a surprise, Mama. He..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Monica**: ""That was the plan before I lear..."<br>`[193]` **Monica**: ""If you're retiring, why does it..." |
| `[215]` | **""Monica, we were going to wait until after the election.""** | `[283]` **Deana**: ""That's not a surprise, Mama. He..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Monica**: ""That was the plan before I lear..."<br>`[17]` **Monica**: ""Don't worry, we won't make it p..." |
| `[220]` | **""Franc never took his studies so seriously.""** | `[23]` **Deana**: ""Almost forgot that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Narrator**: "Deana frowned."<br>`[231]` **Deana**: ""He does now. I think he's getti..."<br>*(oraz 3 innych odgałęzień)* |
| `[229]` | **""No, of course not.""** | `[228]` **Deana**: ""Papa, is Franc going to die fig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Deana**: ""But--"" |
| `[230]` | **""If he sacrifices himself for the sake of the country, that will be his decision.""** | `[228]` **Deana**: ""Papa, is Franc going to die fig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Deana**: ""But--"" |
| `[252]` | **""Yes, and damn proud of it.""** | `[248]` **Deana**: ""Papa, are we a 'socialist hive ..." | `Variable["BaseGame.Malenyevist"] > 5` | *Brak zmian stanu* | `[280]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[253]` | **""Not if I have anything to do with it.""** | `[248]` **Deana**: ""Papa, are we a 'socialist hive ..." | `(Variable["BaseGame.Malenyevist"] > 5) == false` | *Brak zmian stanu* | `[280]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[254]` | **""Franc's just been spending too much time in Arcasia, sweetie.""** | `[248]` **Deana**: ""Papa, are we a 'socialist hive ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[258]` | **""Yes, and damn proud of it.""** | `[247]` **Deana**: ""Papa, are we 'bourgeoisie pigs'?"" | `Variable["BaseGame.Capitalist"] > 5` | *Brak zmian stanu* | `[280]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[259]` | **""Not if I have anything to do with it.""** | `[247]` **Deana**: ""Papa, are we 'bourgeoisie pigs'?"" | `(Variable["BaseGame.Capitalist"] > 5) == false` | *Brak zmian stanu* | `[280]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[260]` | **""Franc's just been spending too much time in United Contana, sweetie.""** | `[247]` **Deana**: ""Papa, are we 'bourgeoisie pigs'?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[263]` | **""No, I've learned my lesson.""** | `[262]` **Deana**: ""Papa, is it true how he got int..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[264]` | **""Only if you show more gratitude for it than he did.""** | `[262]` **Deana**: ""Papa, is it true how he got int..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[265]` | **""Just keep studying so we'll never have to find out.""** | `[262]` **Deana**: ""Papa, is it true how he got int..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[277]` | **""What? Of course not.""** | `[276]` **Deana**: ""Papa, is Sordland 'run by a bun..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[278]` | **""It's complicated.""** | `[276]` **Deana**: ""Papa, is Sordland 'run by a bun..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Narrator**: "Monica appeared in the doorway. ..." |
| `[297]` | **""I never thought I would be a pariah.""** | `[217]` **Monica**: ""Anton, what in the everloving h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Narrator**: "Deana scratched her head." |

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
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Monica: ""Then leave this house.""*)

### Węzeł `[3]`
Mówca: **Monica**
> ""Anton, you can't do that. Not for my sake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""It's not just for your sake. I'm sick and tired of this ..."*)
  - -> `[100]` (*Player: ""I can and I will.""*)

### Węzeł `[4]`
Mówca: **Deana**
> ""Then I guess good luck, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Monica refused to meet my gaze. I wondered if this was th..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see either of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I drained my glass and left the table. I had packing to do."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""Can't a man greet his wife?""]** — Mówca: **Player**
> ""Can't a man greet his wife?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Monica: ""No. Not if he's you.""*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I drained my glass and left the table. I had packing to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[8]`
Mówca: **Deana**
> ""I'll still call you, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Monica refused to meet my gaze. I wondered if this was th..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see either of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "I put that thought out of my mind as I left. I still had ..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player: ""The military is after me. After what happened at the par..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[13]`
Mówca: **Narrator**
> "I put that thought out of my mind as I left. I still had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""What do you hear from your brother these days?""]** — Mówca: **Player**
> ""What do you hear from your brother these days?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)

### Węzeł `[15]`
Mówca: **Monica**
> ""Dinner's ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "The three of us gathered around the dining room table. Mo..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "The three of us gathered around the dining room table. Monica ladled out bowls full of beef stew -- not my favorite, but a comforting dish nonetheless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""Now that we're all here, I wanted to say something.""*)
  - -> `[42]` (*Player_Italic: "Raise your glass."*)
  - -> `[40]` (*Player_Italic: "Tap on the side of your glass."*)

### Węzeł `[17]`
Mówca: **Monica**
> ""Don't worry, we won't make it public until then. I just wanted Deana to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Deana: ""Mama, can't you give him a chance? Maybe things really c..."*)

### Węzeł `[18]`
Mówca: **Monica**
> ""Nobody's going anywhere. Except you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Monica: ""Deana, your father and I are getting divorced.""*)

### Węzeł `[19]`
Mówca: **Narrator**
> "I thought for a moment. Kyrute, the only truly neutral country I knew of, seemed like the obvious choice. A little house in the mountains wouldn't cost much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: ""Kyrute. And you kids can visit whenever you want.""*)
  - -> `[22]` (*Player: ""I'd rather not tell you. For safety reasons.""*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""Kyrute. And you kids can visit whenever you want.""]** — Mówca: **Player**
> ""Kyrute. And you can visit whenever you want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Deana: ""Um... All right.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""This is the presidential complex. Last I checked, I was still President.""]** — Mówca: **Player**
> ""This is the presidential complex. Last I checked, I was still President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "Deana was still sitting at the table, looking uncomfortable."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""I'd rather not tell you. For safety reasons.""]** — Mówca: **Player**
> ""I'd rather not tell you. For safety reasons.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Deana: ""Um... All right.""*)

### Węzeł `[23]`
Mówca: **Deana**
> ""Almost forgot that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player: ""Franc never took his studies so seriously.""*)
  - -> `[14]` (*Player: ""What do you hear from your brother these days?""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""It's the presidential complex. I'm the President, remember?""]** — Mówca: **Player**
> ""It's the presidential complex. I'm the President, remember?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Tears appeared in Monica's eyes."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Your mother is right, Deana. We're getting divorced -- immediately after the election.""]** — Mówca: **Player**
> ""Your mother is right, Deana. We're getting divorced -- immediately after the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Fine. I will.""]** — Mówca: **Player**
> ""Fine. I will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Deana watched silently as I got up from the table. Finall..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Monica: ""That was the plan before I learned the truth about what ..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Monica: ""Don't worry, we won't make it public until then. I just ..."*)

### Węzeł `[30]`
Mówca: **Deana**
> ""Um... All right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Deana still looked slightly dazed."*)

### Węzeł `[31]`
Mówca: **Monica**
> ""I'm sorry, Anton. This dinner was a mistake. I think you should go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: ""I will. I'll see you later, Deana.""*)
  - -> `[21]` (*Player: ""This is the presidential complex. Last I checked, I was ..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "She turned to me, her eyes full of regret."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Monica: ""I'm sorry, Anton. This dinner was a mistake. I think you..."*)

### Węzeł `[33]`
Mówca: **Monica**
> ""Oh, sweetheart. It's too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "She turned to me, her eyes full of regret."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Deana still looked slightly dazed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Deana: ""Then I guess good luck, Papa.""*)

### Węzeł `[35]`
Mówca: **Deana**
> ""Mama, can't you give him a chance? Maybe things really could get better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Monica: ""Oh, sweetheart. It's too late for that.""*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "The usual crowd of protesters was waiting for me outside ..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "I didn't know if it was my imagination, but there seemed ..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Tears appeared in Monica's eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Monica: ""Please, Anton.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "Tap on the side of your glass."]** — Mówca: **Player_Italic**
> "I tapped on the side of my glass for attention. Monica and Deana looked at me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: ""I know the past four years have been hard on all of us.""*)
  - -> `[80]` (*Player: ""The past four years have been the hardest in my life.""*)
  - -> `[78]` (*Player: ""The past four years have tested our strength as a family.""*)

### Węzeł `[41]`
Mówca: **Monica**
> ""Please, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Deana watched silently as I got up from the table. Finall..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "Raise your glass."]** — Mówca: **Player_Italic**
> "I raised my glass for a toast. Monica and Deana slowly followed suit, looking puzzled."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: ""I know the past four years have been hard on all of us.""*)
  - -> `[80]` (*Player: ""The past four years have been the hardest in my life.""*)
  - -> `[78]` (*Player: ""The past four years have tested our strength as a family.""*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Deana watched silently as I got up from the table. Finally, she spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Deana: ""I'll still call you, Papa.""*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""Now that we're all here, I wanted to say something.""]** — Mówca: **Player**
> ""Now that we're all here, I wanted to say something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: ""I know the past four years have been hard on all of us.""*)
  - -> `[80]` (*Player: ""The past four years have been the hardest in my life.""*)
  - -> `[78]` (*Player: ""The past four years have tested our strength as a family.""*)

### Węzeł `[45]`
Mówca: **Narrator**
> "Deana came back downstairs and made a beeline for the pencil case on the coffee table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Deana: ""Almost forgot that.""*)

### Węzeł `[46]`
Mówca: **Narrator**
> "The guards formed a cordon to let me through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[47]`
Mówca: **Deana**
> ""Papa, where are you going to go?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "I thought for a moment. Kyrute, the only truly neutral co..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "The usual crowd of protesters was waiting for me outside the gates of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "The guards formed a cordon to let me through."*)

### Węzeł `[49]`
Mówca: **Monica**
> ""Then leave this house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: ""It's the presidential complex. I'm the President, rememb..."*)
  - -> `[26]` (*Player: ""Fine. I will.""*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Instead, I started thinking about how I would announce my decision not to seek re-election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "I didn't know if it was my imagination, but there seemed to be more guards outside my complex than usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_ImpeachmentTrial == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player: ""I'm about to be the first president in Sordish history t..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
**[WYBÓR GRACZA: ""No. Not without my family.""]** — Mówca: **Player**
> ""No. Not without my family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Monica: ""Then leave this house.""*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""All right. I will leave in a week. I have to make sure my tracks are covered first.""]** — Mówca: **Player**
> ""All right. I will leave in a week. I have to make sure my tracks are covered first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""All right. I'm leaving tomorrow.""]** — Mówca: **Player**
> ""All right. I'm leaving tomorrow.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player_Italic: "Give the guards a suspicious look."*)
  - -> `[64]` (*Player_Italic: "Don't look at them and go to your door."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "I hurried past them, went inside and locked the front doo..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse. I still had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[62]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Instead, I started thinking about how I would announce my..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "Give the guards a suspicious look."]** — Mówca: **Player_Italic**
> "I regarded them with suspicion as I passed. With the military against me, could they be trusted?"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_Coup"] == true`
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator), `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Once inside, I locked the front door behind me."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "Don't look at them and go to your door."]** — Mówca: **Player_Italic**
> "I rushed past the guards to my door."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_Coup"] == true`
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator), `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Once inside, I locked the front door behind me."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_GivenEstordAndNarbel == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player: ""I've just signed part of my own country over to Rumburg...."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[68]`
Mówca: **Monica**
> ""Go, Anton. I think it's better this way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: ""All right. I'm leaving tomorrow.""*)
  - -> `[56]` (*Player: ""All right. I will leave in a week. I have to make sure m..."*)
  - -> `[55]` (*Player: ""No. Not without my family.""*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""I will. I'll see you later, Deana.""]** — Mówca: **Player**
> ""I will. I'll see you later, Deana.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "Deana was still sitting at the table, looking uncomfortable."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "Once inside, I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "I hurried past them, went inside and locked the front doo..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see either of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "I put that thought out of my mind as I made my way back t..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see either of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "I put that thought out of my mind as I made my way back t..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "She looked up. Her face was dead serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Monica: ""Go, Anton. I think it's better this way.""*)

### Węzeł `[74]`
Mówca: **Narrator**
> "I hurried past them, went inside and locked the front door behind me. I heard hesitant footsteps coming my way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Deana: ""Hi, Papa.""*)

### Węzeł `[75]`
Mówca: **Narrator**
> "Instead, I started thinking about where I wanted to go for my retirement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[76]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "She looked up. Her face was dead serious."*)

### Węzeł `[77]`
Mówca: **Monica**
> ""No, Anton. You've dug your own grave. You've got to deal with this yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "She looked up. Her face was dead serious."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""The past four years have tested our strength as a family.""]** — Mówca: **Player**
> ""The past four years have tested our strength as a family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Player_Italic), `[42]` (Player_Italic), `[44]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player: ""I was so busy focusing on the needs of the Sordish peopl..."*)
  - -> `[123]` (*Player: ""I let my power get to my head. I became unrecognizeable ..."*)
  - -> `[119]` (*Player: ""I've done some unforgivable things. Especially to you, M..."*)

### Węzeł `[79]`
Mówca: **Monica**
> ""You're not even running anymore. Why should it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "She looked up. Her face was dead serious."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""The past four years have been the hardest in my life.""]** — Mówca: **Player**
> ""The past four years have been the hardest in my life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Player_Italic), `[42]` (Player_Italic), `[44]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player: ""I was so busy focusing on the needs of the Sordish peopl..."*)
  - -> `[123]` (*Player: ""I let my power get to my head. I became unrecognizeable ..."*)
  - -> `[119]` (*Player: ""I've done some unforgivable things. Especially to you, M..."*)

### Węzeł `[81]`
Mówca: **Monica**
> ""If you're leaving the country, the election doesn't matter, does it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "She looked up. Her face was dead serious."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: ""I know the past four years have been hard on all of us.""]** — Mówca: **Player**
> ""I know the past four years have been hard on all of us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Player_Italic), `[42]` (Player_Italic), `[44]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player: ""I was so busy focusing on the needs of the Sordish peopl..."*)
  - -> `[123]` (*Player: ""I let my power get to my head. I became unrecognizeable ..."*)
  - -> `[119]` (*Player: ""I've done some unforgivable things. Especially to you, M..."*)

### Węzeł `[83]`
Mówca: **Deana**
> ""I'll still call you, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Monica refused to meet my gaze. I wondered if this was th..."*)

### Węzeł `[84]`
Mówca: **Deana**
> ""Hi, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Italic: "Hug her."*)
  - -> `[87]` (*Player: ""Deana! How is school?""*)
  - -> `[86]` (*Player: ""Where's your mother?""*)

### Węzeł `[85]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Instead, I started thinking about where I wanted to go fo..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Where's your mother?""]** — Mówca: **Player**
> ""Where's your mother?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "Deana mutely gestured towards the kitchen."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""Deana! How is school?""]** — Mówca: **Player**
> ""Deana! How is school?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "Deana shrugged."*)

### Węzeł `[88]`
Mówca: **Deana**
> ""Uh, I guess... good luck, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "Monica refused to meet my gaze. I wondered if this was th..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "Hug her."]** — Mówca: **Player_Italic**
> "I opened my arms to embrace my daughter. She reluctantly accepted."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player: ""How's school?""*)
  - -> `[96]` (*Player: ""Where's your mother?""*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Monica: ""That was the plan before I learned the truth about what ..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Monica: ""You're not even running anymore. Why should it matter?""*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Monica: ""If you're leaving the country, the election doesn't matt..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""Where's your mother?""]** — Mówca: **Player**
> ""Where's your mother?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "Deana mutely gestured towards the kitchen."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""How's school?""]** — Mówca: **Player**
> ""How's school?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "Deana shrugged."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "Deana shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_ExcellentWomenRights == true ||Bas..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "Deana mutely gestured towards the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Deana: ""I'll be in my room till dinner.""*)

### Węzeł `[100]`
**[WYBÓR GRACZA: ""I can and I will.""]** — Mówca: **Player**
> ""I can and I will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see either of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "I put that thought out of my mind as I made my way back t..."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "Deana was still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Deana: ""I'll still call you, Papa.""*)

### Węzeł `[103]`
Mówca: **Narrator**
> "I still had plenty of work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[104]`
Mówca: **Narrator**
> "Deana was still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Deana: ""Uh, I guess... good luck, Papa.""*)

### Węzeł `[105]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "I still had plenty of work to do."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Monica, now is not the time. We've got to get out of here.""]** — Mówca: **Player**
> ""Monica, now is not the time. We've got to get out of here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Monica: ""No, Anton. You've dug your own grave. You've got to deal..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""Your mother is right. We're divorcing immediately after the election.""]** — Mówca: **Player**
> ""Your mother is right. We're divorcing immediately after the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see either of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "I put that thought out of my mind as I made my way back t..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""It's not just for your sake. I'm sick and tired of this game. I want out.""]** — Mówca: **Player**
> ""It's not just for your sake. I'm sick and tired of this game. I want out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_ExcellentWomenRights == true ||Bas..."*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_ExcellentWomenRights == true ||B..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Deana: ""I won a prize at the science fair. Honestly, I think the..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Deana: ""I won a prize at the handicrafts fair. Mama didn't seem ..."*)

### Węzeł `[114]`
Mówca: **Monica**
> ""Deana, your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "Deana took a sip of her water. I could see she was trying..."*)

### Węzeł `[115]`
Mówca: **Deana**
> ""I won a prize at the handicrafts fair. Mama didn't seem to care that much, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: ""Well, *I* care.""*)
  - -> `[121]` (*Player: ""She's just jealous because she was always bad at sewing.""*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""I will. And I'm still quitting politics, no matter what.""]** — Mówca: **Player**
> ""I will. And I'm still quitting politics, no matter what.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "Deana was still sitting at the table, looking uncomfortable."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""Fine. But I'm not retiring. I'm going to stay in the Maroon Palace forever, just to show you.""]** — Mówca: **Player**
> ""Fine. But I'm not retiring. I'm going to stay in the Maroon Palace forever, just to show you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Deana was still sitting at the table, looking uncomfortable."*)

### Węzeł `[118]`
Mówca: **Deana**
> ""I won a prize at the science fair. Honestly, I think they were teaching girls different stuff before 'cause they knew we were smarter than boys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: ""You might be right.""*)
  - -> `[128]` (*Player: ""That's just silly.""*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""I've done some unforgivable things. Especially to you, Monica.""]** — Mówca: **Player**
> ""I've done some unforgivable things. Especially to you, Monica.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Player), `[80]` (Player), `[82]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player: ""I hope someday, we'll be able to put this behind us and ..."*)
  - -> `[147]` (*Player: ""I hope I can redeem myself someday.""*)

### Węzeł `[120]`
Mówca: **Deana**
> ""Good luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Monica refused to meet my gaze. I wondered if this was th..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""She's just jealous because she was always bad at sewing.""]** — Mówca: **Player**
> ""She's just jealous because she was always bad at sewing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Deana ignored my comment and gestured vaguely towards the..."*)

### Węzeł `[122]`
Mówca: **Deana**
> ""That's not a surprise, Mama. He hasn't been living at the house in weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: ""Monica, we were going to wait until after the election.""*)
  - -> `[108]` (*Player: ""Your mother is right. We're divorcing immediately after ..."*)
  - -> `[107]` (*Player: ""Monica, now is not the time. We've got to get out of here.""*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""I let my power get to my head. I became unrecognizeable to myself -- and to all of you.""]** — Mówca: **Player**
> ""I let my power get to my head. I became unrecognizable to myself -- and to you two.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Player), `[80]` (Player), `[82]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player: ""I hope someday, we'll be able to put this behind us and ..."*)
  - -> `[147]` (*Player: ""I hope I can redeem myself someday.""*)

### Węzeł `[124]`
Mówca: **Monica**
> ""I'm sorry, Anton. This dinner was a mistake. I think you should go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: ""I will. And I'm still quitting politics, no matter what.""*)
  - -> `[117]` (*Player: ""Fine. But I'm not retiring. I'm going to stay in the Mar..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""Well, *I* care.""]** — Mówca: **Player**
> ""Well, *I* care.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Deana ignored my comment and gestured vaguely towards the..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""I was so busy focusing on the needs of the Sordish people that I forgot about Sordland's most important people: my own wife and daughter.""]** — Mówca: **Player**
> ""I was so busy focusing on the needs of the Sordish people that I forgot about Sordland's most important people: my own wife and daughter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Player), `[80]` (Player), `[82]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player: ""I hope someday, we'll be able to put this behind us and ..."*)
  - -> `[147]` (*Player: ""I hope I can redeem myself someday.""*)

### Węzeł `[127]`
Mówca: **Deana**
> ""Uh, I guess... I'll call you soon, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Monica refused to meet my gaze. I wondered if this was th..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""That's just silly.""]** — Mówca: **Player**
> ""That's just silly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Deana ignored my comment and gestured vaguely towards the..."*)

### Węzeł `[129]`
Mówca: **Deana**
> ""Uh, I guess... I'll call you soon, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Deana: ""Good luck.""*)

### Węzeł `[130]`
Mówca: **Deana**
> ""That's not a surprise, Mama. He hasn't been living at the house in weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Player: ""Monica, we were going to wait until after the election.""*)
  - -> `[212]` (*Player: ""Deana, don't listen to her. Everything's going to work o..."*)
  - -> `[213]` (*Player: ""Monica, didn't you hear a word I said? I'm putting polit..."*)

### Węzeł `[131]`
Mówca: **Monica**
> ""Deana, your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Deana: ""That's not a surprise, Mama. He hasn't been living at th..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""You might be right.""]** — Mówca: **Player**
> ""You might be right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Deana ignored my comment and gestured vaguely towards the..."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "Monica scowled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Monica: ""No, sweetie. Your father's imagining things.""*)

### Węzeł `[134]`
Mówca: **Monica**
> ""Oh, sweetheart. They were. But it's not that easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "She turned to me, her eyes full of regret."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "She turned to me, her eyes full of regret."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Monica: ""I'm sorry, Anton. This dinner was a mistake. I think you..."*)

### Węzeł `[136]`
Mówca: **Narrator**
> "Deana was still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Deana: ""Uh, I guess... I'll call you soon, Papa.""*)

### Węzeł `[137]`
Mówca: **Narrator**
> "Deana was still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Deana: ""Uh, I guess... I'll call you soon, Papa.""*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""The military is after me. After what happened at the parade, I'm not safe -- and neither are any of you.""]** — Mówca: **Player**
> ""The military is after me. After what happened at the parade, I'm not safe -- and neither are any of you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[217]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "Deana looked at me in disbelief. Her lower lip trembled s..."*)

### Węzeł `[139]`
Mówca: **Narrator**
> "Deana ignored my comment and gestured vaguely towards the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Deana: ""Mama's in there. I'll be up in my room till dinner.""*)

### Węzeł `[140]`
**[WYBÓR GRACZA: ""I'm about to be the first president in Sordish history to get impeached. I'll be a pariah, and so will all of you.""]** — Mówca: **Player**
> ""I'm about to be the first president in Sordish history to get impeached. I'll be a pariah, and so will all of you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Kontekst wejściowy (poprzednik):** `[217]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "Deana scratched her head."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "Deana was still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Deana: ""Uh, I guess... I'll call you soon, Papa.""*)

### Węzeł `[142]`
Mówca: **Deana**
> ""Mama's in there. I'll be up in my room till dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "I followed her with my eyes as she went upstairs, thinkin..."*)

### Węzeł `[143]`
Mówca: **Deana**
> ""I'll be in my room till dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "I followed her with my eyes as she went upstairs, thinkin..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA: ""I've just signed part of my own country over to Rumburg. I'm going to be a pariah, and so are all of you.""]** — Mówca: **Player**
> ""I've just signed part of my own country over to Rumburg. I'm going to be a pariah, and so are all of you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Kontekst wejściowy (poprzednik):** `[217]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "Deana scratched her head."*)

### Węzeł `[145]`
**[WYBÓR GRACZA: ""I hope someday, we'll be able to put this behind us and be a family again.""]** — Mówca: **Player**
> ""I hope someday, we'll be able to put this behind us and be a family again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Player), `[123]` (Player), `[126]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "Monica looked at me sadly. She slowly shook her head."*)

### Węzeł `[146]`
Mówca: **Deana**
> ""Mama, can't you give him a chance? Things were pretty good before, weren't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Monica: ""Oh, sweetheart. They were. But it's not that easy.""*)

### Węzeł `[147]`
**[WYBÓR GRACZA: ""I hope I can redeem myself someday.""]** — Mówca: **Player**
> ""I hope I can redeem myself someday.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Player), `[123]` (Player), `[126]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "Monica looked at me sadly. She slowly shook her head."*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""I will. And I'm still quitting politics, no matter what.""]** — Mówca: **Player**
> ""I will. And I'm still quitting politics, no matter what.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "Deana was still sitting at the table, looking uncomfortable."*)

### Węzeł `[149]`
Mówca: **Narrator**
> "I followed her with my eyes as she went upstairs, thinking about the days when she idolized me. She was starting to look more and more like her mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "I hesitantly stepped into the kitchen. Monica was stirrin..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""This is the presidential complex. Last I checked, I was still President.""]** — Mówca: **Player**
> ""This is the presidential complex. Last I checked, I was still President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "Deana was still sitting at the table, looking uncomfortable."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Monica: ""Deana, your father and I are getting divorced.""*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""Smells delicious.""]** — Mówca: **Player**
> ""Smells delicious.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "Monica whirled around in surprise. Her eyes narrowed."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "I hesitantly stepped into the kitchen. Monica was stirring a pot on the stove, her back turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Italic: "Hug her from behind."*)
  - -> `[152]` (*Player: ""Smells delicious.""*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player: ""But right now, there's no time. We need to get out of So..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
Mówca: **Narrator**
> "Monica looked at me sadly. She slowly shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[158]`
Mówca: **Monica**
> ""I'm sorry, Anton. This dinner was a mistake. I think you should go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""I will. And I'm still quitting politics, no matter what.""*)
  - -> `[150]` (*Player: ""This is the presidential complex. Last I checked, I was ..."*)

### Węzeł `[159]`
Mówca: **Monica**
> ""That's not how this works. You don't get to choose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Deana: ""Mama, can't you give him a chance? Things were pretty go..."*)

### Węzeł `[160]`
Mówca: **Monica**
> ""If you're retiring, why does it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Deana: ""Mama, can't you give him a chance? Things were pretty go..."*)

### Węzeł `[161]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Deana: ""Mama, can't you give him a chance? Things were pretty go..."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "She turned to me, her eyes full of regret."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Monica: ""I'm sorry, Anton. This dinner was a mistake. I think you..."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "Monica whirled around in surprise. Her eyes narrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[164]`
Mówca: **Monica**
> ""The only person in danger is him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Monica: ""Deana, your father and I are getting divorced.""*)

### Węzeł `[165]`
**[WYBÓR GRACZA: "Hug her from behind."]** — Mówca: **Player_Italic**
> "I snuck up behind Monica and gave her a hug. She screamed and dropped her ladle."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Monica: ""God, Anton, don't startle me like that! You know we're a..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Monica: ""God, Anton, don't startle me like that! Go wait in the l..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Monica: ""That was the plan before I learned the truth about what ..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)

### Węzeł `[172]`
Mówca: **Monica**
> ""God, Anton, don't startle me like that! You know we're all still on edge after the parade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: ""I'm sorry. I'll go wait in the living room.""*)
  - -> `[6]` (*Player: ""Can't a man greet his wife?""*)

### Węzeł `[173]`
Mówca: **Monica**
> ""No. Not if he's you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "I walked back out and sat on the living room sofa."*)

### Węzeł `[174]`
Mówca: **Monica**
> ""No, sweetie. Your father's imagining things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Monica: ""The only person in danger is him.""*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player: ""My retirement from politics is going to be the best thin..."*)
  - -> `[198]` (*Player: ""I swear to you both, once I'm retired things will go bac..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player: ""As a first step towards that, I'm retiring from politics..."*)
  - -> `[200]` (*Player: ""I swear to you both, I'll learn from my mistakes as I st..."*)

### Węzeł `[178]`
Mówca: **Monica**
> ""Oh, sweetheart. They were. But it's not that easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "She turned to me, her eyes full of regret."*)

### Węzeł `[179]`
**[WYBÓR GRACZA: ""Deana, don't listen to her. Everything's going to work out.""]** — Mówca: **Player**
> ""Deana, don't listen to her. Everything's going to work out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Monica: ""That's not how this works. You don't get to choose.""*)

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""]** — Mówca: **Player**
> ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Monica: ""That's not how this works. You don't get to choose.""*)

### Węzeł `[181]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""I'm sorry. I'll go wait in the living room.""]** — Mówca: **Player**
> ""I'm sorry. I'll go wait in the living room.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "I walked back out and sat on the living room sofa."*)

### Węzeł `[183]`
**[WYBÓR GRACZA: ""But right now, there's no time. We need to get out of Sordland. All of us.""]** — Mówca: **Player**
> ""But right now, there's no time. We need to get out of Sordland. All of us.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Kontekst wejściowy (poprzednik):** `[157]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "Monica and Deana turned to look at me in shock."*)

### Węzeł `[184]`
Mówca: **Monica**
> ""God, Anton, don't startle me like that! Go wait in the living room. I'll tell you when dinner's ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "I walked back out and sat on the living room sofa."*)

### Węzeł `[185]`
Mówca: **Deana**
> ""That's not a surprise, Mama. He hasn't been living at the house in weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player: ""Monica, we were going to wait until after the election.""*)
  - -> `[179]` (*Player: ""Deana, don't listen to her. Everything's going to work o..."*)
  - -> `[180]` (*Player: ""Monica, didn't you hear a word I said? I'm putting polit..."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Monica: ""Deana, your father and I are getting divorced.""*)

### Węzeł `[187]`
Mówca: **Deana**
> ""Mama, can't you give him a chance? Things were pretty good before, weren't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Monica: ""Oh, sweetheart. They were. But it's not that easy.""*)

### Węzeł `[188]`
Mówca: **Narrator**
> "I walked back out and sat on the living room sofa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "I awkwardly flipped through one of Monica's women's magaz..."*)

### Węzeł `[189]`
Mówca: **Narrator**
> "I awkwardly flipped through one of Monica's women's magazines. I felt like an intruder in my own home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Deana came back downstairs and made a beeline for the pen..."*)

### Węzeł `[190]`
Mówca: **Deana**
> ""Are they gonna kill us like they killed Serge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "Monica scowled at me."*)

### Węzeł `[191]`
Mówca: **Deana**
> ""Are they gonna try to kill us like they tried to kill Papa?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "Monica scowled at me."*)

### Węzeł `[192]`
Mówca: **Narrator**
> "Monica and Deana turned to look at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Monica: ""Anton, what in the everloving hell?""*)

### Węzeł `[193]`
Mówca: **Monica**
> ""If you're retiring, why does it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Deana: ""Mama, can't you give him a chance? Things were pretty go..."*)

### Węzeł `[194]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Deana: ""Mama, can't you give him a chance? Things were pretty go..."*)

### Węzeł `[195]`
Mówca: **Monica**
> ""That's not how this works. You don't get to choose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Deana: ""Mama, can't you give him a chance? Things were pretty go..."*)

### Węzeł `[196]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Deana: ""Mama, can't you give him a chance? Maybe things really c..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA: ""My retirement from politics is going to be the best thing that ever happened to us.""]** — Mówca: **Player**
> ""My retirement from politics is going to be the best thing that ever happened to us.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[157]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[198]`
**[WYBÓR GRACZA: ""I swear to you both, once I'm retired things will go back to the way they used to be.""]** — Mówca: **Player**
> ""I swear to you both, once I'm retired things will go back to the way they used to be.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[157]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[199]`
**[WYBÓR GRACZA: ""As a first step towards that, I'm retiring from politics at the end of this term.""]** — Mówca: **Player**
> ""As a first step towards that, I'm retiring from politics at the end of this term.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[157]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "Monica and Deana looked at me in shock."*)

### Węzeł `[200]`
**[WYBÓR GRACZA: ""I swear to you both, I'll learn from my mistakes as I strive to make Sordland a better place.""]** — Mówca: **Player**
> ""I swear to you both, I'll learn from my mistakes as I strive to make Sordland a better place.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[157]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[201]`
Mówca: **Narrator**
> "Deana looked at me in disbelief. Her lower lip trembled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Deana: ""Mama? Is that true?""*)

### Węzeł `[202]`
Mówca: **Monica**
> ""Deana, your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "Deana took a sip of her water. I could see she was trying..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Deana: ""Are they gonna kill us like they killed Serge?""*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Deana: ""Are they gonna try to kill us like they tried to kill Pa..."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Monica: ""Deana, your father and I are getting divorced.""*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Monica: ""That was the plan before I learned the truth about what ..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Monica: ""If you're retiring, why does it matter?""*)

### Węzeł `[210]`
Mówca: **Deana**
> ""What's a pariah?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Monica: ""It's an outcast, sweetie. But you and I don't need to wo..."*)

### Węzeł `[211]`
Mówca: **Deana**
> ""Mama? Is that true?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead"*)

### Węzeł `[212]`
**[WYBÓR GRACZA: ""Deana, don't listen to her. Everything's going to work out.""]** — Mówca: **Player**
> ""Deana, don't listen to her. Everything's going to work out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Monica: ""That's not how this works. You don't get to choose.""*)

### Węzeł `[213]`
**[WYBÓR GRACZA: ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""]** — Mówca: **Player**
> ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Monica: ""That's not how this works. You don't get to choose.""*)

### Węzeł `[214]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[215]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[216]`
Mówca: **Narrator**
> "Deana scratched her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Deana: ""What's a pariah?""*)

### Węzeł `[217]`
Mówca: **Monica**
> ""Anton, what in the everloving hell?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[297]` (*Player: ""I never thought I would be a pariah.""*)

### Węzeł `[218]`
Mówca: **Monica**
> ""Deana, your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "Deana took a sip of her water. I could see she was trying..."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "Monica and Deana looked at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Monica: ""Anton, you can't do that. Not for my sake.""*)

### Węzeł `[220]`
**[WYBÓR GRACZA: ""Franc never took his studies so seriously.""]** — Mówca: **Player**
> ""Franc never took his studies so seriously.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_FrancConscripted == true || Ba..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "Deana frowned."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Deana: ""He does now. I think he's getting really into his army t..."*)

### Węzeł `[227]`
Mówca: **Narrator**
> "Deana frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Deana: ""Papa, is Franc going to die fighting the Rummies?""*)

### Węzeł `[228]`
Mówca: **Deana**
> ""Papa, is Franc going to die fighting the Rummies?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player: ""No, of course not.""*)
  - -> `[230]` (*Player: ""If he sacrifices himself for the sake of the country, th..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA: ""No, of course not.""]** — Mówca: **Player**
> ""No, of course not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Deana: ""But--""*)

### Węzeł `[230]`
**[WYBÓR GRACZA: ""If he sacrifices himself for the sake of the country, that will be his decision.""]** — Mówca: **Player**
> ""If he sacrifices himself for the sake of the country, that will be his decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Deana: ""But--""*)

### Węzeł `[231]`
Mówca: **Deana**
> ""He does now. I think he's getting really into his army training.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Deana: ""Papa, is Sordland 'run by a bunch of weaklings'?""*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_FrancConscripted == true || Base..."*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_FrancConscripted == true || Ba..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[235]`
Mówca: **Deana**
> ""He doesn't call home so much now that the troops are getting ready for war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "Deana frowned."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Deana: ""He doesn't call home so much now that the troops are get..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Deana: ""I think he's getting really into his army training.""*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Deana: ""He does now.""*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[242]`
Mówca: **Deana**
> ""He does now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Deana: ""Papa, are we a 'socialist hive mind'?""*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Deana: ""He does now.""*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Deana: ""He does now.""*)

### Węzeł `[246]`
Mówca: **Deana**
> ""He does now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Deana: ""Papa, are we 'bourgeoisie pigs'?""*)

### Węzeł `[247]`
Mówca: **Deana**
> ""Papa, are we 'bourgeoisie pigs'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist > 5"*)
  - -> `[260]` (*Player: ""Franc's just been spending too much time in United Conta..."*)

### Węzeł `[248]`
Mówca: **Deana**
> ""Papa, are we a 'socialist hive mind'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 5"*)
  - -> `[254]` (*Player: ""Franc's just been spending too much time in Arcasia, swe..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 5"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist > 5)"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Player: ""Yes, and damn proud of it.""*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player: ""Not if I have anything to do with it.""*)

### Węzeł `[252]`
**[WYBÓR GRACZA: ""Yes, and damn proud of it.""]** — Mówca: **Player**
> ""Yes, and damn proud of it.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Malenyevist"] > 5`
- **Kontekst wejściowy (poprzednik):** `[248]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Monica appeared in the doorway. She smiled at Deana, then..."*)

### Węzeł `[253]`
**[WYBÓR GRACZA: ""Not if I have anything to do with it.""]** — Mówca: **Player**
> ""Not if I have anything to do with it.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Malenyevist"] > 5) == false`
- **Kontekst wejściowy (poprzednik):** `[248]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Monica appeared in the doorway. She smiled at Deana, then..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA: ""Franc's just been spending too much time in Arcasia, sweetie.""]** — Mówca: **Player**
> ""Franc's been spending too much time in Arcasia, sweetie.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Monica appeared in the doorway. She smiled at Deana, then..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist > 5"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Capitalist > 5)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Capitalist"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Player: ""Yes, and damn proud of it.""*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Capitalist > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Capitalist"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Player: ""Not if I have anything to do with it.""*)

### Węzeł `[258]`
**[WYBÓR GRACZA: ""Yes, and damn proud of it.""]** — Mówca: **Player**
> ""Yes, and damn proud of it.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Capitalist"] > 5`
- **Kontekst wejściowy (poprzednik):** `[247]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Monica appeared in the doorway. She smiled at Deana, then..."*)

### Węzeł `[259]`
**[WYBÓR GRACZA: ""Not if I have anything to do with it.""]** — Mówca: **Player**
> ""Not if I have anything to do with it.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Capitalist"] > 5) == false`
- **Kontekst wejściowy (poprzednik):** `[247]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Monica appeared in the doorway. She smiled at Deana, then..."*)

### Węzeł `[260]`
**[WYBÓR GRACZA: ""Franc's just been spending too much time in United Contana, sweetie.""]** — Mówca: **Player**
> ""Franc's been spending too much time in United Contana, sweetie.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Monica appeared in the doorway. She smiled at Deana, then..."*)

### Węzeł `[261]`
Mówca: **Deana**
> ""He does now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Deana: ""Papa, is it true how he got into Holsord State? Would yo..."*)

### Węzeł `[262]`
Mówca: **Deana**
> ""Papa, is it true how he got into Holsord State? Would you do that for me, too?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Player: ""No, I've learned my lesson.""*)
  - -> `[264]` (*Player: ""Only if you show more gratitude for it than he did.""*)
  - -> `[265]` (*Player: ""Just keep studying so we'll never have to find out.""*)

### Węzeł `[263]`
**[WYBÓR GRACZA: ""No, I've learned my lesson.""]** — Mówca: **Player**
> ""No, I've learned my lesson.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Monica appeared in the doorway. She smiled at Deana, then..."*)

### Węzeł `[264]`
**[WYBÓR GRACZA: ""Only if you show more gratitude for it than he did.""]** — Mówca: **Player**
> ""Only if you show more gratitude for it than he did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Monica appeared in the doorway. She smiled at Deana, then..."*)

### Węzeł `[265]`
**[WYBÓR GRACZA: ""Just keep studying so we'll never have to find out.""]** — Mówca: **Player**
> ""Just keep studying so we'll never have to find out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Monica appeared in the doorway. She smiled at Deana, then..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Deana: ""Not much. He writes me letters sometimes.""*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Deana: ""Not much. He writes me letters sometimes.""*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Deana: ""Not much. He doesn't call as often now that he's got a g..."*)

### Węzeł `[272]`
Mówca: **Deana**
> ""Not much. He writes me letters sometimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Deana: ""Papa, are we a 'socialist hive mind'?""*)

### Węzeł `[273]`
Mówca: **Deana**
> ""Not much. He writes me letters sometimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Deana: ""Papa, are we 'bourgeoisie pigs'?""*)

### Węzeł `[274]`
Mówca: **Deana**
> ""Not much. He doesn't call as often now that he's got a girlfriend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Deana: ""Papa, is it true how he got into Holsord State? Would yo..."*)

### Węzeł `[275]`
Mówca: **Deana**
> ""I think he's getting really into his army training.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Deana: ""Papa, is Sordland 'run by a bunch of weaklings'?""*)

### Węzeł `[276]`
Mówca: **Deana**
> ""Papa, is Sordland 'run by a bunch of weaklings'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player: ""What? Of course not.""*)
  - -> `[278]` (*Player: ""It's complicated.""*)

### Węzeł `[277]`
**[WYBÓR GRACZA: ""What? Of course not.""]** — Mówca: **Player**
> ""What? Of course not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Monica appeared in the doorway. She smiled at Deana, then..."*)

### Węzeł `[278]`
**[WYBÓR GRACZA: ""It's complicated.""]** — Mówca: **Player**
> ""It's complicated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Monica appeared in the doorway. She smiled at Deana, then..."*)

### Węzeł `[279]`
Mówca: **Deana**
> ""But--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Monica appeared in the doorway. She smiled at Deana, then..."*)

### Węzeł `[280]`
Mówca: **Narrator**
> "Monica appeared in the doorway. She smiled at Deana, then fixed me with an icy look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Monica: ""Dinner's ready.""*)

### Węzeł `[281]`
Mówca: **Monica**
> ""It's an outcast, sweetie. But you and I don't need to worry about that. This is your father's problem, not ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Deana: ""But then where are we going?""*)

### Węzeł `[282]`
Mówca: **Deana**
> ""But then where are we going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Monica: ""Nobody's going anywhere. Except you, Anton.""*)

### Węzeł `[283]`
Mówca: **Deana**
> ""That's not a surprise, Mama. He hasn't been living at the house in weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: ""Monica, we were going to wait until after the election.""*)
  - -> `[25]` (*Player: ""Your mother is right, Deana. We're getting divorced -- i..."*)

### Węzeł `[284]`
Mówca: **Narrator**
> "Deana took a sip of her water. I could see she was trying to act mature."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Deana: ""That's not a surprise, Mama. He hasn't been living at th..."*)

### Węzeł `[285]`
Mówca: **Narrator**
> "Deana took a sip of her water. I could see she was trying to act mature."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Deana: ""That's not a surprise, Mama. He hasn't been living at th..."*)

### Węzeł `[286]`
Mówca: **Narrator**
> "Deana took a sip of her water. I could see she was trying to act mature."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Deana: ""That's not a surprise, Mama. He hasn't been living at th..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Exile = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FinalSupper_Retired = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame...."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Monica: ""You're not even running anymore. Why does it matter?""*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Monica: ""If you're retiring, why does it matter?""*)

### Węzeł `[293]`
Mówca: **Monica**
> ""You're not even running anymore. Why does it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Deana: ""Mama, can't you give him a chance? Things were pretty go..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Deana: ""Papa, where are you going to go?""*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Deana: ""Papa, where are you going to go?""*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[297]`
**[WYBÓR GRACZA: ""I never thought I would be a pariah.""]** — Mówca: **Player**
> ""I never thought I would be a pariah.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "Deana scratched her head."*)
