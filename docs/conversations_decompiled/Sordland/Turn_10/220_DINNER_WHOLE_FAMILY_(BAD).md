# Sordland/Turn10/DINNER WHOLE FAMILY (BAD)

- **ID konwersacji:** `220`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/220_DINNER_WHOLE_FAMILY_(BAD).md`
- **Liczba węzłów dialogowych:** 309
- **Liczba wyborów gracza:** 72

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
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.LeakedScandal_Franc_StateUniversity`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Media_Censored`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Rumburg_War`
- `BaseGame.Situation_Law_ExcellentWomenRights`
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
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[52]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **"Don't look at them and go to your door."** | `[7]` **Narrator**: "I didn't know if it was my imagi..."<br>`[9]` **Narrator**: "The guards formed a cordon to le..." | `Variable["BaseGame.Ending_Coup"] == true` | *Brak zmian stanu* | `[14]` **Narrator**: "Once inside, I locked the front ..." |
| `[15]` | **"Give the guards a suspicious look."** | `[7]` **Narrator**: "I didn't know if it was my imagi..."<br>`[9]` **Narrator**: "The guards formed a cordon to le..." | `Variable["BaseGame.Ending_Coup"] == true` | *Brak zmian stanu* | `[14]` **Narrator**: "Once inside, I locked the front ..." |
| `[17]` | **"Hug her."** | `[16]` **Deana**: ""Hi, Papa."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Player**: ""How's school?""<br>`[33]` **Player**: ""Where's your mother?"" |
| `[18]` | **""Deana! How is school?""** | `[16]` **Deana**: ""Hi, Papa."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "Deana shrugged." |
| `[19]` | **""Where's your mother?""** | `[16]` **Deana**: ""Hi, Papa."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "Deana mutely gestured towards th..." |
| `[28]` | **""You might be right.""** | `[23]` **Deana**: ""I won a prize at the science fa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "Deana ignored my comment and ges..." |
| `[29]` | **""That's just silly.""** | `[23]` **Deana**: ""I won a prize at the science fa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "Deana ignored my comment and ges..." |
| `[30]` | **""Well, *I* care.""** | `[27]` **Deana**: ""I won a prize at the handicraft..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "Deana ignored my comment and ges..." |
| `[31]` | **""She's just jealous because she was always bad at sewing.""** | `[27]` **Deana**: ""I won a prize at the handicraft..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "Deana ignored my comment and ges..." |
| `[32]` | **""How's school?""** | `[17]` **Player_Italic**: "I opened my arms to embrace my d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "Deana shrugged." |
| `[33]` | **""Where's your mother?""** | `[17]` **Player_Italic**: "I opened my arms to embrace my d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "Deana mutely gestured towards th..." |
| `[38]` | **"Hug her from behind."** | `[37]` **Narrator**: "I hesitantly stepped into the ki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Monica**: ""God, Anton, don't startle me li..."<br>`[46]` **Monica**: ""God, Anton, don't startle me li..." |
| `[39]` | **""Smells delicious.""** | `[37]` **Narrator**: "I hesitantly stepped into the ki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "Monica whirled around in surpris..." |
| `[40]` | **"Walk back out and wait for Franc in the living room."** | `[37]` **Narrator**: "I hesitantly stepped into the ki..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "I awkwardly flipped through one ..." |
| `[47]` | **""I'm sorry. I'll go wait in the living room.""** | `[45]` **Monica**: ""God, Anton, don't startle me li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Narrator**: "I walked back out and sat on the..." |
| `[48]` | **""Can't a man greet his wife?""** | `[45]` **Monica**: ""God, Anton, don't startle me li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Monica**: ""No. Not if he's you."" |
| `[61]` | **""You could've invited them in. There's enough food.""** | `[84]` **Narrator**: "He flung his backpack in a corne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Franc**: ""Ha. Even if they would cross th..." |
| `[63]` | **""They might be.""** | `[57]` **Franc**: ""Sorry I'm late. Are some of tho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Franc**: ""Well, I'd be more suspicious of..." |
| `[65]` | **""I'm starting to get suspicious of them, to be honest.""** | `[57]` **Franc**: ""Sorry I'm late. Are some of tho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Narrator**: "He flung his backpack in a corne..." |
| `[69]` | **""You *know* those brats? I was going to ask the guards to have them tear-gassed.""** | `[84]` **Narrator**: "He flung his backpack in a corne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Franc**: ""Don't do it. They brought goggl..." |
| `[70]` | **""I hope you two are being careful.""** | `[85]` **Narrator**: "He flung his backpack in a corne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Franc**: ""We're certainly being more care..."<br>`[80]` **Franc**: ""Don't you worry. I've seen what..." |
| `[71]` | **""So that's still going on.""** | `[85]` **Narrator**: "He flung his backpack in a corne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Franc**: ""Yes, no thanks to you. One of h..."<br>`[81]` **Franc**: ""Don't look so surprised."" |
| `[87]` | **""Language!""** | `[86]` **Franc**: ""Shit, Dad, that parade was a cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Franc**: ""Serge is dead, and your biggest..."<br>`[93]` **Franc**: ""You almost died *again*, and yo..." |
| `[88]` | **""It wasn't a 'close call' for Serge.""** | `[86]` **Franc**: ""Shit, Dad, that parade was a cl..." | `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true` | *Brak zmian stanu* | `[92]` **Franc**: ""I know. I can't believe he's go..." |
| `[95]` | **""I know. I still can't believe nobody was hurt.""** | `[86]` **Franc**: ""Shit, Dad, that parade was a cl..." | `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false` | *Brak zmian stanu* | `[99]` **Franc**: ""This time."" |
| `[108]` | **""Now that we're all here, I wanted to say something.""** | `[107]` **Narrator**: "The four of us gathered around t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Player**: ""I know the past four years have..."<br>`[112]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych odgałęzień)* |
| `[109]` | **"Raise your glass."** | `[107]` **Narrator**: "The four of us gathered around t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Player**: ""I know the past four years have..."<br>`[112]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych odgałęzień)* |
| `[110]` | **"Tap on the side of your glass."** | `[107]` **Narrator**: "The four of us gathered around t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Player**: ""I know the past four years have..."<br>`[112]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych odgałęzień)* |
| `[111]` | **""I know the past four years have been hard on all of us.""** | `[108]` **Player**: ""Now that we're all here, I want..."<br>`[109]` **Player_Italic**: "I raised my glass for a toast. M..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Player**: ""I was so busy focusing on the n..."<br>`[115]` **Player**: ""I let my power get to my head. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[112]` | **""The past four years have been the hardest in my life.""** | `[108]` **Player**: ""Now that we're all here, I want..."<br>`[109]` **Player_Italic**: "I raised my glass for a toast. M..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Player**: ""I was so busy focusing on the n..."<br>`[115]` **Player**: ""I let my power get to my head. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[113]` | **""The past four years have tested our strength as a family.""** | `[108]` **Player**: ""Now that we're all here, I want..."<br>`[109]` **Player_Italic**: "I raised my glass for a toast. M..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Player**: ""I was so busy focusing on the n..."<br>`[115]` **Player**: ""I let my power get to my head. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[114]` | **""I was so busy focusing on the needs of the Sordish people that I forgot about Sor..."** | `[111]` **Player**: ""I know the past four years have..."<br>`[112]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Player**: ""I hope someday, we'll be able t..."<br>`[117]` **Player**: ""I hope I can redeem myself some..." |
| `[115]` | **""I let my power get to my head. I became unrecognizeable to myself -- and to all o..."** | `[111]` **Player**: ""I know the past four years have..."<br>`[112]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Player**: ""I hope someday, we'll be able t..."<br>`[117]` **Player**: ""I hope I can redeem myself some..." |
| `[116]` | **""I've done some unforgivable things. Especially to you, Monica.""** | `[111]` **Player**: ""I know the past four years have..."<br>`[112]` **Player**: ""The past four years have been t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Player**: ""I hope someday, we'll be able t..."<br>`[117]` **Player**: ""I hope I can redeem myself some..." |
| `[117]` | **""I hope I can redeem myself someday.""** | `[114]` **Player**: ""I was so busy focusing on the n..."<br>`[115]` **Player**: ""I let my power get to my head. ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Narrator**: "Monica looked at me sadly. She s..." |
| `[118]` | **""I hope someday, we'll be able to put this behind us and be a family again.""** | `[114]` **Player**: ""I was so busy focusing on the n..."<br>`[115]` **Player**: ""I let my power get to my head. ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Narrator**: "Monica looked at me sadly. She s..." |
| `[120]` | **""I swear to you all, I'll learn from my mistakes during my next term.""** | `[119]` **Narrator**: "Monica looked at me sadly. She s..." | `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[271]` **Narrator**: "Monica sighed heavily." |
| `[121]` | **""As a first step towards that, I'm retiring from politics at the end of this term.""** | `[119]` **Narrator**: "Monica looked at me sadly. She s..." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[171]` **Narrator**: "Everyone at the table looked at ..." |
| `[122]` | **""But right now, there's no time. We need to get out of Sordland. All of us.""** | `[119]` **Narrator**: "Monica looked at me sadly. She s..." | `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)` | *Brak zmian stanu* | `[128]` **Narrator**: "Everyone turned to look at me in..." |
| `[126]` | **""I swear to you all, once I'm retired things will go back to the way they used to ..."** | `[119]` **Narrator**: "Monica looked at me sadly. She s..." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[244]` **Narrator**: "Monica sighed heavily." |
| `[127]` | **""My retirement from politics is going to be the best thing that ever happened to us.""** | `[119]` **Narrator**: "Monica looked at me sadly. She s..." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[244]` **Narrator**: "Monica sighed heavily." |
| `[139]` | **""I've just signed part of my own country over to Rumburg. I'm going to be a pariah..."** | `[129]` **Monica**: ""Anton, what in the everloving h..." | `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true` | *Brak zmian stanu* | `[142]` **Narrator**: "Deana frowned." |
| `[140]` | **""I'm about to be the first president in Sordish history to get impeached. I'll be ..."** | `[129]` **Monica**: ""Anton, what in the everloving h..." | `Variable["BaseGame.Ending_ImpeachmentTrial"] == true` | *Brak zmian stanu* | `[142]` **Narrator**: "Deana frowned." |
| `[141]` | **""The military is after me. After what happened at the parade, I'm not safe -- and ..."** | `[129]` **Monica**: ""Anton, what in the everloving h..." | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[155]` **Narrator**: "Deana looked at me in disbelief...." |
| `[172]` | **""Monica, we were going to wait until after the election.""** | `[170]` **Franc**: ""Yeah, that was sarcasm."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Monica**: ""That was the plan before I lear..."<br>`[183]` **Monica**: ""You're not even running anymore..."<br>*(oraz 1 innych odgałęzień)* |
| `[173]` | **""Monica, now is not the time. We've got to get out of here.""** | `[170]` **Franc**: ""Yeah, that was sarcasm."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Monica**: ""No, Anton. You've dug your own ..." |
| `[174]` | **""Your mother is right. We're divorcing immediately after the election.""** | `[170]` **Franc**: ""Yeah, that was sarcasm."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Monica**: ""That was the plan before I lear..."<br>`[183]` **Monica**: ""You're not even running anymore..."<br>*(oraz 1 innych odgałęzień)* |
| `[182]` | **""No. Not without my family.""** | `[181]` **Monica**: ""Go, Anton. I think it's better ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Monica**: ""Then leave this house."" |
| `[188]` | **""All right. I'm leaving in a week. I have to make sure my tracks are covered first.""** | `[181]` **Monica**: ""Go, Anton. I think it's better ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[190]` **Franc**: ""Dad, where are you going to go?"" |
| `[189]` | **""All right. I'm leaving tomorrow.""** | `[181]` **Monica**: ""Go, Anton. I think it's better ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Exile_LeaveNow"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[190]` **Franc**: ""Dad, where are you going to go?"" |
| `[192]` | **""Kyrute. And you kids can visit whenever you want.""** | `[191]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Franc**: ""Uh... All right."" |
| `[193]` | **""I'd rather not tell you. For safety reasons.""** | `[191]` **Narrator**: "I thought for a moment. Kyrute, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Franc**: ""Uh... All right."" |
| `[195]` | **""It's the presidential complex. I'm the President, remember?""** | `[194]` **Monica**: ""Then leave this house."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Narrator**: "Tears appeared in Monica's eyes." |
| `[196]` | **""Fine. I will.""** | `[194]` **Monica**: ""Then leave this house."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Narrator**: "Franc and Deana watched silently..." |
| `[211]` | **""It's not just for your sake. I'm sick and tired of this game. I want out.""** | `[210]` **Monica**: ""Anton, you can't do that. Not f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Narrator**: "Monica sighed heavily." |
| `[212]` | **""I can and I will.""** | `[210]` **Monica**: ""Anton, you can't do that. Not f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Narrator**: "Monica sighed heavily." |
| `[216]` | **""Kids, don't listen to her. Everything's going to work out.""** | `[219]` **Franc**: ""Yeah, that was sarcasm."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Monica**: ""That's not how this works. You ..." |
| `[218]` | **""Monica, didn't you hear a word I said? I'm putting politics behind me so we can b..."** | `[219]` **Franc**: ""Yeah, that was sarcasm."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Monica**: ""That's not how this works. You ..." |
| `[220]` | **""Monica, we were going to wait until after the election.""** | `[219]` **Franc**: ""Yeah, that was sarcasm."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Monica**: ""That was the plan before I lear..."<br>`[225]` **Monica**: ""If you're retiring, why does it..." |
| `[231]` | **""I will. And I'm dropping out of politics, no matter what.""** | `[230]` **Monica**: ""I'm sorry, Anton. This dinner w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Narrator**: "Franc and Deana were still sitti..." |
| `[232]` | **""Fine. But I'm not retiring. History will remember me as the best leader Sordland ..."** | `[230]` **Monica**: ""I'm sorry, Anton. This dinner w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Narrator**: "Franc and Deana were still sitti..." |
| `[254]` | **""Kids, don't listen to her. Everything's going to work out.""** | `[251]` **Franc**: ""Yeah, that was sarcasm."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Monica**: ""That's not how this works. You ..." |
| `[255]` | **""Monica, didn't you hear a word I said? I'm putting politics behind me so we can b..."** | `[251]` **Franc**: ""Yeah, that was sarcasm."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Monica**: ""That's not how this works. You ..." |
| `[256]` | **""Monica, we were going to wait until after the election.""** | `[251]` **Franc**: ""Yeah, that was sarcasm."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Monica**: ""That was the plan before I lear..."<br>`[247]` **Monica**: ""If you're retiring, why does it..." |
| `[264]` | **""I will. And I'm still dropping out of the election, no matter what.""** | `[263]` **Monica**: ""I'm sorry, Anton. This dinner w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[253]` **Narrator**: "Franc and Deana were still sitti..." |
| `[266]` | **""This is the presidential complex. Last I checked, I was still President.""** | `[263]` **Monica**: ""I'm sorry, Anton. This dinner w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Narrator**: "Franc and Deana were still sitti..." |
| `[278]` | **""Your mother is right, kids. We're getting divorced -- immediately after the elect..."** | `[277]` **Franc**: ""Yeah, that was sarcasm."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Monica**: ""That was the plan before I lear..."<br>`[275]` **Monica**: ""Don't worry, we won't make it p..." |
| `[282]` | **""Monica, we were going to wait until after the election.""** | `[277]` **Franc**: ""Yeah, that was sarcasm."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Monica**: ""That was the plan before I lear..."<br>`[275]` **Monica**: ""Don't worry, we won't make it p..." |
| `[286]` | **""I will. I'll see you later, kids.""** | `[289]` **Monica**: ""I'm sorry, Anton. This dinner w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Narrator**: "Franc and Deana were still sitti..." |
| `[290]` | **""This is the presidential complex. Last I checked, I was still President.""** | `[289]` **Monica**: ""I'm sorry, Anton. This dinner w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Narrator**: "Franc and Deana were still sitti..." |
| `[298]` | **""I swear to you all, I'll learn from my mistakes during the next administration.""** | `[119]` **Narrator**: "Monica looked at me sadly. She s..." | `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[271]` **Narrator**: "Monica sighed heavily." |
| `[308]` | **""I never thought I would be a pariah.""** | `[129]` **Monica**: ""Anton, what in the everloving h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Narrator**: "Deana frowned." |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Suddenly, Franc burst through the door."*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "The usual crowd of protesters was waiting for me outside ..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I didn't know if it was my imagination, but there seemed ..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "Don't look at them and go to your door."]** — Mówca: **Player_Italic**
> "I rushed past the guards to my door."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_Coup"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator), `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Once inside, I locked the front door behind me."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I didn't know if it was my imagination, but there seemed to be more guards outside my complex than usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "The usual crowd of protesters was waiting for me outside the gates of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "The guards formed a cordon to let me through."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "The guards formed a cordon to let me through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Italic: "Give the guards a suspicious look."*)
  - -> `[6]` (*Player_Italic: "Don't look at them and go to your door."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "I hurried past them, went inside and locked the front doo..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "I hurried past them, went inside and locked the front door behind me. I heard hesitant footsteps coming my way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Deana: ""Hi, Papa.""*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Once inside, I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "I hurried past them, went inside and locked the front doo..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "Give the guards a suspicious look."]** — Mówca: **Player_Italic**
> "I regarded them with suspicion as I passed. With the military against me, could they be trusted?"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_Coup"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator), `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Once inside, I locked the front door behind me."*)

### Węzeł `[16]`
Mówca: **Deana**
> ""Hi, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Italic: "Hug her."*)
  - -> `[18]` (*Player: ""Deana! How is school?""*)
  - -> `[19]` (*Player: ""Where's your mother?""*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "Hug her."]** — Mówca: **Player_Italic**
> "I opened my arms to embrace my daughter. She reluctantly accepted."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: ""How's school?""*)
  - -> `[33]` (*Player: ""Where's your mother?""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Deana! How is school?""]** — Mówca: **Player**
> ""Deana! How is school?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Deana shrugged."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""Where's your mother?""]** — Mówca: **Player**
> ""Where's your mother?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "Deana mutely gestured towards the kitchen."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "Deana mutely gestured towards the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Deana: ""I'll be in my room till dinner.""*)

### Węzeł `[21]`
Mówca: **Deana**
> ""I'll be in my room till dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "I followed her with my eyes as she went upstairs, thinkin..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "Deana shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_ExcellentWomenRights == true ||Bas..."*)

### Węzeł `[23]`
Mówca: **Deana**
> ""I won a prize at the science fair. Honestly, I think they were teaching girls different stuff before 'cause they knew we were smarter than boys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: ""You might be right.""*)
  - -> `[29]` (*Player: ""That's just silly.""*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_ExcellentWomenRights == true ||Bas..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_ExcellentWomenRights == true ||B..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Deana: ""I won a prize at the science fair. Honestly, I think the..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Deana: ""I won a prize at the handicrafts fair. Mama didn't seem ..."*)

### Węzeł `[27]`
Mówca: **Deana**
> ""I won a prize at the handicrafts fair. Mama didn't seem to care that much, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""Well, *I* care.""*)
  - -> `[31]` (*Player: ""She's just jealous because she was always bad at sewing.""*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""You might be right.""]** — Mówca: **Player**
> ""You might be right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Deana ignored my comment and gestured vaguely towards the..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""That's just silly.""]** — Mówca: **Player**
> ""That's just silly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Deana ignored my comment and gestured vaguely towards the..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""Well, *I* care.""]** — Mówca: **Player**
> ""Well, *I* care.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Deana ignored my comment and gestured vaguely towards the..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""She's just jealous because she was always bad at sewing.""]** — Mówca: **Player**
> ""She's just jealous because she was always bad at sewing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Deana ignored my comment and gestured vaguely towards the..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""How's school?""]** — Mówca: **Player**
> ""How's school?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Deana shrugged."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""Where's your mother?""]** — Mówca: **Player**
> ""Where's your mother?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "Deana mutely gestured towards the kitchen."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Deana ignored my comment and gestured vaguely towards the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Deana: ""Mama's in there. I'll be up in my room till dinner.""*)

### Węzeł `[35]`
Mówca: **Deana**
> ""Mama's in there. I'll be up in my room till dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "I followed her with my eyes as she went upstairs, thinkin..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "I followed her with my eyes as she went upstairs, thinking about the days when she idolized me. She was starting to look more and more like her mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "I hesitantly stepped into the kitchen. Monica was stirrin..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "I hesitantly stepped into the kitchen. Monica was stirring a pot on the stove, her back turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Italic: "Hug her from behind."*)
  - -> `[39]` (*Player: ""Smells delicious.""*)
  - -> `[40]` (*Player_Italic: "Walk back out and wait for Franc in the living room."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "Hug her from behind."]** — Mówca: **Player_Italic**
> "I snuck up behind Monica and gave her a hug. She screamed and dropped her ladle."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Smells delicious.""]** — Mówca: **Player**
> ""Smells delicious.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Monica whirled around in surprise. Her eyes narrowed."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "Walk back out and wait for Franc in the living room."]** — Mówca: **Player_Italic**
> "I walked back out and went to wait for Franc in the living room. I didn't want to disturb her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "I awkwardly flipped through one of Monica's women's magaz..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Monica whirled around in surprise. Her eyes narrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Monica: ""God, Anton, don't startle me like that! You know we're a..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Monica: ""God, Anton, don't startle me like that! Go wait in the l..."*)

### Węzeł `[45]`
Mówca: **Monica**
> ""God, Anton, don't startle me like that! You know we're all still on edge after the parade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: ""I'm sorry. I'll go wait in the living room.""*)
  - -> `[48]` (*Player: ""Can't a man greet his wife?""*)

### Węzeł `[46]`
Mówca: **Monica**
> ""God, Anton, don't startle me like that! Go wait in the living room. I'll tell you when dinner's ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "I walked back out and sat on the living room sofa."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""I'm sorry. I'll go wait in the living room.""]** — Mówca: **Player**
> ""I'm sorry. I'll go wait in the living room.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "I walked back out and sat on the living room sofa."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Can't a man greet his wife?""]** — Mówca: **Player**
> ""Can't a man greet his wife?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Monica: ""No. Not if he's you.""*)

### Węzeł `[49]`
Mówca: **Monica**
> ""No. Not if he's you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "I walked back out and sat on the living room sofa."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "I walked back out and sat on the living room sofa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "I awkwardly flipped through one of Monica's women's magaz..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "I awkwardly flipped through one of Monica's women's magazines. I felt like an intruder in my own home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Suddenly, Franc burst through the door."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Suddenly, Franc burst through the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Franc: ""Sorry I'm late. Are some of those guards outside new? I ..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[56]`
Mówca: **Franc**
> ""Well, I'd be more suspicious of them if I were you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "He flung his backpack in a corner and sprawled out in a c..."*)

### Węzeł `[57]`
Mówca: **Franc**
> ""Sorry I'm late. Are some of those guards outside new? I had to convince them I was really your son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: ""They might be.""*)
  - -> `[65]` (*Player: ""I'm starting to get suspicious of them, to be honest.""*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Franc: ""Sorry I'm late. I ran into a couple of my friends protes..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Franc: ""Sorry I'm late. I was with Sheyna. We were, uh, studying.""*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""You could've invited them in. There's enough food.""]** — Mówca: **Player**
> ""You could've invited them in. There's enough food.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Franc: ""Ha. Even if they would cross the picket line, they're ve..."*)

### Węzeł `[62]`
Mówca: **Franc**
> ""Sorry I'm late. I ran into a couple of my friends protesting outside. It was pretty awkward, telling them I was having dinner with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "He flung his backpack in a corner and sprawled out in a c..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""They might be.""]** — Mówca: **Player**
> ""They might be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Franc: ""Well, I'd be more suspicious of them if I were you.""*)

### Węzeł `[64]`
Mówca: **Narrator**
> "He flung his backpack in a corner and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Franc: ""Shit, Dad, that parade was a close call. I thought the b..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""I'm starting to get suspicious of them, to be honest.""]** — Mówca: **Player**
> ""I'm starting to get suspicious of them, to be honest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "He flung his backpack in a corner and sprawled out in a c..."*)

### Węzeł `[66]`
Mówca: **Franc**
> ""Ha. Even if they would cross the picket line, they're vegetarians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Deana came running down the stairs."*)

### Węzeł `[67]`
Mówca: **Franc**
> ""Sorry I'm late. I was with Sheyna. We were, uh, studying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "He flung his backpack in a corner and sprawled out in a c..."*)

### Węzeł `[68]`
Mówca: **Franc**
> ""Don't do it. They brought goggles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Deana came running down the stairs."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""You *know* those brats? I was going to ask the guards to have them tear-gassed.""]** — Mówca: **Player**
> ""You *know* those brats? I was going to ask the guards to have them tear-gassed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Franc: ""Don't do it. They brought goggles.""*)

### Węzeł `[70]`
**[WYBÓR GRACZA: ""I hope you two are being careful.""]** — Mówca: **Player**
> ""I hope you two are being careful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: ""So that's still going on.""]** — Mówca: **Player**
> ""So that's still going on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_..."*)

### Węzeł `[72]`
Mówca: **Franc**
> ""Yes, no thanks to you. One of her uncles was almost killed during that business at the dam.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Franc glared at me. He looked like he was about to say so..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_..."*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unres..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Franc: ""Yes, no thanks to you. One of her uncles was almost kill..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Franc: ""Don't look so surprised.""*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_..."*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unres..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Franc: ""We're certainly being more careful than you've been with..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true && (BaseGame.Unrest_BFF_Deal_Promised == false && BaseGame.Unrest_BFF_Deal_Signed == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  (Variable["BaseGame.Unrest_BFF_Deal_Promised"] == false  and  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Franc: ""Don't you worry. I've seen what fatherhood does to a man.""*)

### Węzeł `[79]`
Mówca: **Franc**
> ""We're certainly being more careful than you've been with your treatment of her people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Franc glared at me. He looked like he was about to say so..."*)

### Węzeł `[80]`
Mówca: **Franc**
> ""Don't you worry. I've seen what fatherhood does to a man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Franc smirked. He looked like he was about to say somethi..."*)

### Węzeł `[81]`
Mówca: **Franc**
> ""Don't look so surprised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Franc smirked. He looked like he was about to say somethi..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "Franc smirked. He looked like he was about to say something else, but then Deana came down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Deana: ""Franc!""*)

### Węzeł `[83]`
Mówca: **Narrator**
> "Franc glared at me. He looked like he was about to say something else, but then Deana came down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Deana: ""Franc!""*)

### Węzeł `[84]`
Mówca: **Narrator**
> "He flung his backpack in a corner and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: ""You *know* those brats? I was going to ask the guards to..."*)
  - -> `[61]` (*Player: ""You could've invited them in. There's enough food.""*)

### Węzeł `[85]`
Mówca: **Narrator**
> "He flung his backpack in a corner and sprawled out in a chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: ""I hope you two are being careful.""*)
  - -> `[71]` (*Player: ""So that's still going on.""*)

### Węzeł `[86]`
Mówca: **Franc**
> ""Shit, Dad, that parade was a close call. I thought the ball was bad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[87]` (*Player: ""Language!""*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""Language!""]** — Mówca: **Player**
> ""Language!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""It wasn't a 'close call' for Serge.""]** — Mówca: **Player**
> ""It wasn't a 'close call' for Serge.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Kontekst wejściowy (poprzednik):** `[86]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Franc: ""I know. I can't believe he's gone.""*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: ""It wasn't a 'close call' for Serge.""*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: ""I know. I still can't believe nobody was hurt.""*)

### Węzeł `[92]`
Mówca: **Franc**
> ""I know. I can't believe he's gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Before I could respond, Deana came running down the stairs."*)

### Węzeł `[93]`
Mówca: **Franc**
> ""You almost died *again*, and your biggest concern is swear words?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Before I could respond, Deana came running down the stairs."*)

### Węzeł `[94]`
Mówca: **Franc**
> ""Serge is dead, and your biggest concern is swear words?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Before I could respond, Deana came running down the stairs."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""I know. I still can't believe nobody was hurt.""]** — Mówca: **Player**
> ""I know. I still can't believe nobody was hurt.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[86]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Franc: ""This time.""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Franc: ""Serge is dead, and your biggest concern is swear words?""*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Franc: ""You almost died *again*, and your biggest concern is swe..."*)

### Węzeł `[99]`
Mówca: **Franc**
> ""This time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Before I could respond, Deana came running down the stairs."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Before I could respond, Deana came running down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Deana: ""Franc!""*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Deana came running down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Deana: ""Franc!""*)

### Węzeł `[102]`
Mówca: **Deana**
> ""Franc!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Franc: ""Hey, pipsqueak.""*)

### Węzeł `[103]`
Mówca: **Franc**
> ""Hey, pipsqueak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "He ruffled her hair. I thought about how much time had pa..."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "He ruffled her hair. I thought about how much time had passed since we'd all been together under one roof."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Monica emerged from the kitchen and gave Franc a big hug...."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "Monica emerged from the kitchen and gave Franc a big hug. As she turned back to me, the warmth drained from her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Monica: ""Dinner's ready.""*)

### Węzeł `[106]`
Mówca: **Monica**
> ""Dinner's ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "The four of us gathered around the dining room table. Mon..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "The four of us gathered around the dining room table. Monica ladled out bowls full of beef stew -- not my favorite, but a comforting dish nonetheless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: ""Now that we're all here, I wanted to say something.""*)
  - -> `[109]` (*Player_Italic: "Raise your glass."*)
  - -> `[110]` (*Player_Italic: "Tap on the side of your glass."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""Now that we're all here, I wanted to say something.""]** — Mówca: **Player**
> ""Now that we're all here, I wanted to say something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player: ""I know the past four years have been hard on all of us.""*)
  - -> `[112]` (*Player: ""The past four years have been the hardest in my life.""*)
  - -> `[113]` (*Player: ""The past four years have tested our strength as a family.""*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "Raise your glass."]** — Mówca: **Player_Italic**
> "I raised my glass for a toast. Monica, Franc and Deana slowly followed suit, looking puzzled."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player: ""I know the past four years have been hard on all of us.""*)
  - -> `[112]` (*Player: ""The past four years have been the hardest in my life.""*)
  - -> `[113]` (*Player: ""The past four years have tested our strength as a family.""*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "Tap on the side of your glass."]** — Mówca: **Player_Italic**
> "I tapped on the side of my glass for attention. Monica, Franc and Deana looked at me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player: ""I know the past four years have been hard on all of us.""*)
  - -> `[112]` (*Player: ""The past four years have been the hardest in my life.""*)
  - -> `[113]` (*Player: ""The past four years have tested our strength as a family.""*)

### Węzeł `[111]`
**[WYBÓR GRACZA: ""I know the past four years have been hard on all of us.""]** — Mówca: **Player**
> ""I know the past four years have been hard on all of us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Player), `[109]` (Player_Italic), `[110]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: ""I was so busy focusing on the needs of the Sordish peopl..."*)
  - -> `[115]` (*Player: ""I let my power get to my head. I became unrecognizeable ..."*)
  - -> `[116]` (*Player: ""I've done some unforgivable things. Especially to you, M..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: ""The past four years have been the hardest in my life.""]** — Mówca: **Player**
> ""The past four years have been the hardest in my life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Player), `[109]` (Player_Italic), `[110]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: ""I was so busy focusing on the needs of the Sordish peopl..."*)
  - -> `[115]` (*Player: ""I let my power get to my head. I became unrecognizeable ..."*)
  - -> `[116]` (*Player: ""I've done some unforgivable things. Especially to you, M..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""The past four years have tested our strength as a family.""]** — Mówca: **Player**
> ""The past four years have tested our strength as a family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Player), `[109]` (Player_Italic), `[110]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: ""I was so busy focusing on the needs of the Sordish peopl..."*)
  - -> `[115]` (*Player: ""I let my power get to my head. I became unrecognizeable ..."*)
  - -> `[116]` (*Player: ""I've done some unforgivable things. Especially to you, M..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""I was so busy focusing on the needs of the Sordish people that I forgot about Sordland's most important people: my own family.""]** — Mówca: **Player**
> ""I was so busy focusing on the needs of the Sordish people that I forgot about Sordland's most important people: my own wife and children.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Player), `[112]` (Player), `[113]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: ""I hope someday, we'll be able to put this behind us and ..."*)
  - -> `[117]` (*Player: ""I hope I can redeem myself someday.""*)

### Węzeł `[115]`
**[WYBÓR GRACZA: ""I let my power get to my head. I became unrecognizeable to myself -- and to all of you.""]** — Mówca: **Player**
> ""I let my power get to my head. I became unrecognizable to myself -- and to all of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Player), `[112]` (Player), `[113]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: ""I hope someday, we'll be able to put this behind us and ..."*)
  - -> `[117]` (*Player: ""I hope I can redeem myself someday.""*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""I've done some unforgivable things. Especially to you, Monica.""]** — Mówca: **Player**
> ""I've done some unforgivable things. Especially to you, Monica.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Player), `[112]` (Player), `[113]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: ""I hope someday, we'll be able to put this behind us and ..."*)
  - -> `[117]` (*Player: ""I hope I can redeem myself someday.""*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""I hope I can redeem myself someday.""]** — Mówca: **Player**
> ""I hope I can redeem myself someday.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Player), `[115]` (Player), `[116]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Monica looked at me sadly. She slowly shook her head."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""I hope someday, we'll be able to put this behind us and be a family again.""]** — Mówca: **Player**
> ""I hope someday, we'll be able to put this behind us and be a family again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Player), `[115]` (Player), `[116]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Monica looked at me sadly. She slowly shook her head."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Monica looked at me sadly. She slowly shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""I swear to you all, I'll learn from my mistakes during my next term.""]** — Mówca: **Player**
> ""I swear to you all, I'll learn from my mistakes during my next term.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""As a first step towards that, I'm retiring from politics at the end of this term.""]** — Mówca: **Player**
> ""As a first step towards that, I'm retiring from politics at the end of this term.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "Everyone at the table looked at me in shock."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""But right now, there's no time. We need to get out of Sordland. All of us.""]** — Mówca: **Player**
> ""But right now, there's no time. We need to get out of Sordland. All of us.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "Everyone turned to look at me in shock."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player: ""My retirement from politics is going to be the best thin..."*)
  - -> `[126]` (*Player: ""I swear to you all, once I'm retired things will go back..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""As a first step towards that, I'm retiring from politics..."*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""I swear to you all, once I'm retired things will go back to the way they used to be.""]** — Mówca: **Player**
> ""I swear to you all, once I'm retired things will go back to the way they used to be.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[127]`
**[WYBÓR GRACZA: ""My retirement from politics is going to be the best thing that ever happened to us.""]** — Mówca: **Player**
> ""My retirement from politics is going to be the best thing that ever happened to us.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "Everyone turned to look at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Monica: ""Anton, what in the everloving hell?""*)

### Węzeł `[129]`
Mówca: **Monica**
> ""Anton, what in the everloving hell?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[308]` (*Player: ""I never thought I would be a pariah.""*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: ""The military is after me. After what happened at the par..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_ImpeachmentTrial == true)"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player: ""I'm about to be the first president in Sordish history t..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_GivenEstordAndNarbel == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player: ""I've just signed part of my own country over to Rumburg...."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[139]`
**[WYBÓR GRACZA: ""I've just signed part of my own country over to Rumburg. I'm going to be a pariah, and so are all of you.""]** — Mówca: **Player**
> ""I've just signed part of my own country over to Rumburg. I'm going to be a pariah, and so are all of you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Kontekst wejściowy (poprzednik):** `[129]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "Deana frowned."*)

### Węzeł `[140]`
**[WYBÓR GRACZA: ""I'm about to be the first president in Sordish history to get impeached. I'll be a pariah, and so will all of you.""]** — Mówca: **Player**
> ""I'm about to be the first president in Sordish history to get impeached. I'll be a pariah, and so will all of you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Kontekst wejściowy (poprzednik):** `[129]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "Deana frowned."*)

### Węzeł `[141]`
**[WYBÓR GRACZA: ""The military is after me. After what happened at the parade, I'm not safe -- and neither are any of you.""]** — Mówca: **Player**
> ""The military is after me. After what happened at the parade, I'm not safe -- and neither are any of you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[129]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "Deana looked at me in disbelief. Her lower lip trembled s..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "Deana frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Deana: ""What's a pariah?""*)

### Węzeł `[143]`
Mówca: **Deana**
> ""What's a pariah?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true && B..."*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true &&..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Franc: ""It's an outcast, Dee. Like what I am since everyone at H..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true && BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[147]`
Mówca: **Franc**
> ""It's an outcast, Dee. Like what I am since everyone at Holsord State found out how I really got in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "Franc gave me a pointed look. Deana still looked uncertain."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "Franc gave me a pointed look. Deana still looked uncertain."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Franc: ""We're supposed to uproot our entire lives because you sc..."*)

### Węzeł `[149]`
Mówca: **Franc**
> ""It's an outcast, Dee. Like what I am since Anton Rayne became the enemy of Holsord State.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "Franc gave me a pointed look. Deana still looked uncertain."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Franc: ""It's an outcast, Dee. Like what I am since Anton Rayne b..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Franc: ""It's an outcast, Dee.""*)

### Węzeł `[153]`
Mówca: **Franc**
> ""It's an outcast, Dee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "Franc gave me a pointed look. Deana still looked uncertain."*)

### Węzeł `[154]`
Mówca: **Franc**
> ""We're supposed to uproot our entire lives because you screwed up?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Monica slammed a hand down on the table. We all turned to..."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "Deana looked at me in disbelief. Her lower lip trembled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Deana: ""Mama? Is that true?""*)

### Węzeł `[156]`
Mówca: **Narrator**
> "Monica slammed a hand down on the table. We all turned to look at her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Monica: ""Nobody's going anywhere. Except you, Anton.""*)

### Węzeł `[157]`
Mówca: **Deana**
> ""Mama? Is that true?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Deana: ""Are they gonna kill us like they killed Serge?""*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Deana: ""Are they gonna try to kill us like they tried to kill Pa..."*)

### Węzeł `[161]`
Mówca: **Deana**
> ""Are they gonna kill us like they killed Serge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "Monica scowled at me."*)

### Węzeł `[162]`
Mówca: **Deana**
> ""Are they gonna try to kill us like they tried to kill Papa?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "Monica scowled at me."*)

### Węzeł `[163]`
Mówca: **Monica**
> ""Nobody's going anywhere. Except you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Monica: ""Franc, Deana -- your father and I are getting divorced.""*)

### Węzeł `[164]`
Mówca: **Monica**
> ""Franc, Deana -- your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Franc: ""What a surprise.""*)

### Węzeł `[165]`
Mówca: **Franc**
> ""What a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Deana: ""I'm not surprised, Franc. He hasn't been living in the h..."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "Monica scowled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Monica: ""No, sweetie. Your father's imagining things.""*)

### Węzeł `[167]`
Mówca: **Monica**
> ""No, sweetie. Your father's imagining things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Monica: ""The only person in danger is him.""*)

### Węzeł `[168]`
Mówca: **Monica**
> ""The only person in danger is him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Monica: ""Franc, Deana -- your father and I are getting divorced.""*)

### Węzeł `[169]`
Mówca: **Deana**
> ""I'm not surprised, Franc. He hasn't been living in the house for weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Franc: ""Yeah, that was sarcasm.""*)

### Węzeł `[170]`
Mówca: **Franc**
> ""Yeah, that was sarcasm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: ""Monica, we were going to wait until after the election.""*)
  - -> `[174]` (*Player: ""Your mother is right. We're divorcing immediately after ..."*)
  - -> `[173]` (*Player: ""Monica, now is not the time. We've got to get out of here.""*)

### Węzeł `[171]`
Mówca: **Narrator**
> "Everyone at the table looked at me in shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Monica: ""Anton, you can't do that. Not for my sake.""*)

### Węzeł `[172]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[173]`
**[WYBÓR GRACZA: ""Monica, now is not the time. We've got to get out of here.""]** — Mówca: **Player**
> ""Monica, now is not the time. We've got to get out of here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Monica: ""No, Anton. You've dug your own grave. You've got to deal..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA: ""Your mother is right. We're divorcing immediately after the election.""]** — Mówca: **Player**
> ""Your mother is right. We're divorcing immediately after the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Monica: ""That was the plan before I learned the truth about what ..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true || (BaseGam..."*)

### Węzeł `[178]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "She looked up. Her face was dead serious."*)

### Węzeł `[179]`
Mówca: **Monica**
> ""No, Anton. You've dug your own grave. You've got to deal with this yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "She looked up. Her face was dead serious."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "She looked up. Her face was dead serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Monica: ""Go, Anton. I think it's better this way.""*)

### Węzeł `[181]`
Mówca: **Monica**
> ""Go, Anton. I think it's better this way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player: ""All right. I'm leaving tomorrow.""*)
  - -> `[188]` (*Player: ""All right. I'm leaving in a week. I have to make sure my..."*)
  - -> `[182]` (*Player: ""No. Not without my family.""*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""No. Not without my family.""]** — Mówca: **Player**
> ""No. Not without my family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Monica: ""Then leave this house.""*)

### Węzeł `[183]`
Mówca: **Monica**
> ""You're not even running anymore. Why should it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "She looked up. Her face was dead serious."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true || (BaseGam..."*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true || (BaseG..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true  or  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Monica: ""You're not even running anymore. Why should it matter?""*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true  or  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Monica: ""If you're leaving the country, the election doesn't matt..."*)

### Węzeł `[187]`
Mówca: **Monica**
> ""If you're leaving the country, the election doesn't matter, does it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "She looked up. Her face was dead serious."*)

### Węzeł `[188]`
**[WYBÓR GRACZA: ""All right. I'm leaving in a week. I have to make sure my tracks are covered first.""]** — Mówca: **Player**
> ""All right. I'm leaving in a week. I have to make sure my tracks are covered first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[189]`
**[WYBÓR GRACZA: ""All right. I'm leaving tomorrow.""]** — Mówca: **Player**
> ""All right. I'm leaving tomorrow.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[190]`
Mówca: **Franc**
> ""Dad, where are you going to go?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "I thought for a moment. Kyrute, the only truly neutral co..."*)

### Węzeł `[191]`
Mówca: **Narrator**
> "I thought for a moment. Kyrute, the only truly neutral country I knew of, seemed like the obvious choice. A little house in the mountains wouldn't cost much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Player: ""Kyrute. And you kids can visit whenever you want.""*)
  - -> `[193]` (*Player: ""I'd rather not tell you. For safety reasons.""*)

### Węzeł `[192]`
**[WYBÓR GRACZA: ""Kyrute. And you kids can visit whenever you want.""]** — Mówca: **Player**
> ""Kyrute. And you kids can visit whenever you want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Franc: ""Uh... All right.""*)

### Węzeł `[193]`
**[WYBÓR GRACZA: ""I'd rather not tell you. For safety reasons.""]** — Mówca: **Player**
> ""I'd rather not tell you. For safety reasons.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Franc: ""Uh... All right.""*)

### Węzeł `[194]`
Mówca: **Monica**
> ""Then leave this house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player: ""It's the presidential complex. I'm the President, rememb..."*)
  - -> `[196]` (*Player: ""Fine. I will.""*)

### Węzeł `[195]`
**[WYBÓR GRACZA: ""It's the presidential complex. I'm the President, remember?""]** — Mówca: **Player**
> ""It's the presidential complex. I'm the President, remember?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "Tears appeared in Monica's eyes."*)

### Węzeł `[196]`
**[WYBÓR GRACZA: ""Fine. I will.""]** — Mówca: **Player**
> ""Fine. I will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "Franc and Deana watched silently as I got up from the tab..."*)

### Węzeł `[197]`
Mówca: **Franc**
> ""Uh... All right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Franc: ""I guess good luck, then?""*)

### Węzeł `[198]`
Mówca: **Franc**
> ""I guess good luck, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "Deana still looked slightly dazed."*)

### Węzeł `[199]`
Mówca: **Narrator**
> "Deana still looked slightly dazed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Deana: ""Yeah. Good luck, Papa.""*)

### Węzeł `[200]`
Mówca: **Deana**
> ""Yeah. Good luck, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "Monica refused to meet my gaze. I wondered if this was th..."*)

### Węzeł `[201]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see her -- or any of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "I drained my glass and left the table. I had packing to do."*)

### Węzeł `[202]`
Mówca: **Narrator**
> "I drained my glass and left the table. I had packing to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[203]`
Mówca: **Narrator**
> "Tears appeared in Monica's eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Monica: ""Please, Anton.""*)

### Węzeł `[204]`
Mówca: **Monica**
> ""Please, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "Franc and Deana watched silently as I got up from the tab..."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "Franc and Deana watched silently as I got up from the table. Finally, Franc spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Franc: ""Uh, I'll call you soon, Dad.""*)

### Węzeł `[206]`
Mówca: **Franc**
> ""Uh, I'll call you soon, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Deana: ""Yeah. I will too!""*)

### Węzeł `[207]`
Mówca: **Deana**
> ""Yeah. I will too!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Monica refused to meet my gaze. I wondered if this was th..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see her -- or any of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "I put that thought out of my mind as I left. I still had ..."*)

### Węzeł `[209]`
Mówca: **Narrator**
> "I put that thought out of my mind as I left. I still had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[210]`
Mówca: **Monica**
> ""Anton, you can't do that. Not for my sake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player: ""It's not just for your sake. I'm sick and tired of this ..."*)
  - -> `[212]` (*Player: ""I can and I will.""*)

### Węzeł `[211]`
**[WYBÓR GRACZA: ""It's not just for your sake. I'm sick and tired of this game. I want out.""]** — Mówca: **Player**
> ""It's not just for your sake. I'm sick and tired of this game. I want out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[212]`
**[WYBÓR GRACZA: ""I can and I will.""]** — Mówca: **Player**
> ""I can and I will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[213]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Monica: ""Franc, Deana -- your father and I are getting divorced.""*)

### Węzeł `[214]`
Mówca: **Monica**
> ""Franc, Deana -- your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Franc: ""What a surprise.""*)

### Węzeł `[215]`
Mówca: **Franc**
> ""What a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Deana: ""I'm not surprised, Franc. He hasn't been living in the h..."*)

### Węzeł `[216]`
**[WYBÓR GRACZA: ""Kids, don't listen to her. Everything's going to work out.""]** — Mówca: **Player**
> ""Kids, don't listen to her. Everything's going to work out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Monica: ""That's not how this works. You don't get to choose.""*)

### Węzeł `[217]`
Mówca: **Deana**
> ""I'm not surprised, Franc. He hasn't been living in the house for weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Franc: ""Yeah, that was sarcasm.""*)

### Węzeł `[218]`
**[WYBÓR GRACZA: ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""]** — Mówca: **Player**
> ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Monica: ""That's not how this works. You don't get to choose.""*)

### Węzeł `[219]`
Mówca: **Franc**
> ""Yeah, that was sarcasm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player: ""Monica, we were going to wait until after the election.""*)
  - -> `[216]` (*Player: ""Kids, don't listen to her. Everything's going to work out.""*)
  - -> `[218]` (*Player: ""Monica, didn't you hear a word I said? I'm putting polit..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[221]`
Mówca: **Monica**
> ""That's not how this works. You don't get to choose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Franc: ""Mom, can't you give him a chance? Things were pretty goo..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Monica: ""That was the plan before I learned the truth about what ..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Monica: ""If you're retiring, why does it matter?""*)

### Węzeł `[225]`
Mówca: **Monica**
> ""If you're retiring, why does it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Franc: ""Mom, can't you give him a chance? Things were pretty goo..."*)

### Węzeł `[226]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Franc: ""Mom, can't you give him a chance? Things were pretty goo..."*)

### Węzeł `[227]`
Mówca: **Franc**
> ""Mom, can't you give him a chance? Things were pretty good before, weren't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Monica: ""Oh, sweetheart. They were. But it's not that easy.""*)

### Węzeł `[228]`
Mówca: **Monica**
> ""Oh, sweetheart. They were. But it's not that easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "She turned to me, her eyes full of regret."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "She turned to me, her eyes full of regret."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Monica: ""I'm sorry, Anton. This dinner was a mistake. I think you..."*)

### Węzeł `[230]`
Mówca: **Monica**
> ""I'm sorry, Anton. This dinner was a mistake. I think you should go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player: ""I will. And I'm dropping out of politics, no matter what.""*)
  - -> `[232]` (*Player: ""Fine. But I'm not retiring. History will remember me as ..."*)

### Węzeł `[231]`
**[WYBÓR GRACZA: ""I will. And I'm dropping out of politics, no matter what.""]** — Mówca: **Player**
> ""I will. And I'm dropping out of politics, no matter what.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "Franc and Deana were still sitting at the table, looking ..."*)

### Węzeł `[232]`
**[WYBÓR GRACZA: ""Fine. But I'm not retiring. History will remember me as the best leader Sordland ever had.""]** — Mówca: **Player**
> ""Fine. But I'm not retiring. History will remember me as the best leader Sordland ever had.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "Franc and Deana were still sitting at the table, looking ..."*)

### Węzeł `[233]`
Mówca: **Franc**
> ""Uh, I guess... good luck, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Deana: ""Yeah. Good luck!""*)

### Węzeł `[234]`
Mówca: **Deana**
> ""Yeah. Good luck!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "Monica refused to meet my gaze. I wondered if this was th..."*)

### Węzeł `[235]`
Mówca: **Narrator**
> "Franc and Deana were still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Franc: ""Uh, I guess... good luck, Dad.""*)

### Węzeł `[236]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see her -- or any of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Narrator: "I put that thought out of my mind as I made my way back t..."*)

### Węzeł `[237]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse. I still had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[238]`
Mówca: **Narrator**
> "Franc and Deana were still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Franc: ""Uh, I guess... I'll call you soon, Dad.""*)

### Węzeł `[239]`
Mówca: **Franc**
> ""Uh, I guess... I'll call you soon, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Deana: ""Yeah. I will too!""*)

### Węzeł `[240]`
Mówca: **Deana**
> ""Yeah. I will too!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "Monica refused to meet my gaze. I wondered if this was th..."*)

### Węzeł `[241]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "Instead, I started thinking about how I would announce my..."*)

### Węzeł `[242]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see her -- or any of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "I put that thought out of my mind as I made my way back t..."*)

### Węzeł `[243]`
Mówca: **Narrator**
> "Instead, I started thinking about how I would announce my decision to retire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[244]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Monica: ""Franc, Deana -- your father and I are getting divorced.""*)

### Węzeł `[245]`
Mówca: **Monica**
> ""Franc, Deana -- your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Franc: ""What a surprise.""*)

### Węzeł `[246]`
Mówca: **Franc**
> ""What a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Deana: ""I'm not surprised, Franc. He hasn't been living in the h..."*)

### Węzeł `[247]`
Mówca: **Monica**
> ""If you're retiring, why does it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Franc: ""Mom, can't you give him a chance? Things were pretty goo..."*)

### Węzeł `[248]`
Mówca: **Franc**
> ""Uh, I guess... I'll call you soon, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Deana: ""Yeah. I will too!""*)

### Węzeł `[249]`
Mówca: **Deana**
> ""I'm not surprised, Franc. He hasn't been living in the house for weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Franc: ""Yeah, that was sarcasm.""*)

### Węzeł `[250]`
Mówca: **Monica**
> ""Oh, sweetheart. They were. But it's not that easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "She turned to me, her eyes full of regret."*)

### Węzeł `[251]`
Mówca: **Franc**
> ""Yeah, that was sarcasm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Player: ""Monica, we were going to wait until after the election.""*)
  - -> `[254]` (*Player: ""Kids, don't listen to her. Everything's going to work out.""*)
  - -> `[255]` (*Player: ""Monica, didn't you hear a word I said? I'm putting polit..."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "She turned to me, her eyes full of regret."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Monica: ""I'm sorry, Anton. This dinner was a mistake. I think you..."*)

### Węzeł `[253]`
Mówca: **Narrator**
> "Franc and Deana were still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Franc: ""Uh, I guess... I'll call you soon, Dad.""*)

### Węzeł `[254]`
**[WYBÓR GRACZA: ""Kids, don't listen to her. Everything's going to work out.""]** — Mówca: **Player**
> ""Kids, don't listen to her. Everything's going to work out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Monica: ""That's not how this works. You don't get to choose.""*)

### Węzeł `[255]`
**[WYBÓR GRACZA: ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""]** — Mówca: **Player**
> ""Monica, didn't you hear a word I said? I'm putting politics behind me so we can be a family again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Monica: ""That's not how this works. You don't get to choose.""*)

### Węzeł `[256]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[257]`
Mówca: **Narrator**
> "Franc and Deana were still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Franc: ""Uh, I guess... I'll call you soon, Dad.""*)

### Węzeł `[258]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Franc: ""Mom, can't you give him a chance? Things were pretty goo..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Monica: ""That was the plan before I learned the truth about what ..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Monica: ""If you're retiring, why does it matter?""*)

### Węzeł `[262]`
Mówca: **Franc**
> ""Mom, can't you give him a chance? Things were pretty good before, weren't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Monica: ""Oh, sweetheart. They were. But it's not that easy.""*)

### Węzeł `[263]`
Mówca: **Monica**
> ""I'm sorry, Anton. This dinner was a mistake. I think you should go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Player: ""I will. And I'm still dropping out of the election, no m..."*)
  - -> `[266]` (*Player: ""This is the presidential complex. Last I checked, I was ..."*)

### Węzeł `[264]`
**[WYBÓR GRACZA: ""I will. And I'm still dropping out of the election, no matter what.""]** — Mówca: **Player**
> ""I will. And I'm still dropping out of the election, no matter what.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Narrator: "Franc and Deana were still sitting at the table, looking ..."*)

### Węzeł `[265]`
Mówca: **Monica**
> ""That's not how this works. You don't get to choose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Franc: ""Mom, can't you give him a chance? Things were pretty goo..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA: ""This is the presidential complex. Last I checked, I was still President.""]** — Mówca: **Player**
> ""This is the presidential complex. Last I checked, I was still President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "Franc and Deana were still sitting at the table, looking ..."*)

### Węzeł `[267]`
Mówca: **Deana**
> ""Yeah. I will too!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "Monica refused to meet my gaze. I wondered if this was th..."*)

### Węzeł `[268]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see her -- or any of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "I put that thought out of my mind as I made my way back t..."*)

### Węzeł `[269]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "Instead, I started thinking about where I wanted to go fo..."*)

### Węzeł `[270]`
Mówca: **Narrator**
> "Instead, I started thinking about where I wanted to go for my retirement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[271]`
Mówca: **Narrator**
> "Monica sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Monica: ""Franc, Deana -- your father and I are getting divorced.""*)

### Węzeł `[272]`
Mówca: **Monica**
> ""Franc, Deana -- your father and I are getting divorced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Franc: ""What a surprise.""*)

### Węzeł `[273]`
Mówca: **Franc**
> ""What a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Deana: ""I'm not surprised, Franc. He hasn't been living in the h..."*)

### Węzeł `[274]`
Mówca: **Deana**
> ""I'm not surprised, Franc. He hasn't been living in the house for weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Franc: ""Yeah, that was sarcasm.""*)

### Węzeł `[275]`
Mówca: **Monica**
> ""Don't worry, we won't make it public until then. I just wanted Franc and Deana to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Franc: ""Mom, can't you give him a chance? Maybe the next term re..."*)

### Węzeł `[276]`
Mówca: **Monica**
> ""That was the plan before I learned the truth about what you'd done with your time in office. Along with the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Franc: ""Mom, can't you give him a chance? Maybe the next term re..."*)

### Węzeł `[277]`
Mówca: **Franc**
> ""Yeah, that was sarcasm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player: ""Monica, we were going to wait until after the election.""*)
  - -> `[278]` (*Player: ""Your mother is right, kids. We're getting divorced -- im..."*)

### Węzeł `[278]`
**[WYBÓR GRACZA: ""Your mother is right, kids. We're getting divorced -- immediately after the election.""]** — Mówca: **Player**
> ""Your mother is right, kids. We're getting divorced -- immediately after the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Monica: ""That was the plan before I learned the truth about what ..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Monica: ""Don't worry, we won't make it public until then. I just ..."*)

### Węzeł `[282]`
**[WYBÓR GRACZA: ""Monica, we were going to wait until after the election.""]** — Mówca: **Player**
> ""Monica, we were going to wait until after the election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)

### Węzeł `[283]`
Mówca: **Franc**
> ""Mom, can't you give him a chance? Maybe the next term really could be better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Monica: ""Oh, sweetheart. It's too late for that.""*)

### Węzeł `[284]`
Mówca: **Monica**
> ""Oh, sweetheart. It's too late for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "She turned to me, her eyes full of regret."*)

### Węzeł `[285]`
Mówca: **Narrator**
> "She turned to me, her eyes full of regret."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Monica: ""I'm sorry, Anton. This dinner was a mistake. I think you..."*)

### Węzeł `[286]`
**[WYBÓR GRACZA: ""I will. I'll see you later, kids.""]** — Mówca: **Player**
> ""I will. I'll see you later, kids.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[289]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "Franc and Deana were still sitting at the table, looking ..."*)

### Węzeł `[287]`
Mówca: **Franc**
> ""Uh, I guess... I'll call you soon, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Deana: ""Yeah. I will too!""*)

### Węzeł `[288]`
Mówca: **Narrator**
> "Franc and Deana were still sitting at the table, looking uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Franc: ""Uh, I guess... I'll call you soon, Dad.""*)

### Węzeł `[289]`
Mówca: **Monica**
> ""I'm sorry, Anton. This dinner was a mistake. I think you should go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Player: ""I will. I'll see you later, kids.""*)
  - -> `[290]` (*Player: ""This is the presidential complex. Last I checked, I was ..."*)

### Węzeł `[290]`
**[WYBÓR GRACZA: ""This is the presidential complex. Last I checked, I was still President.""]** — Mówca: **Player**
> ""This is the presidential complex. Last I checked, I was still President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[289]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "Franc and Deana were still sitting at the table, looking ..."*)

### Węzeł `[291]`
Mówca: **Deana**
> ""Yeah. I will too!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Narrator: "Monica refused to meet my gaze. I wondered if this was th..."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "I put that thought out of my mind as I made my way back to the guesthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "I still had plenty of work to do."*)

### Węzeł `[293]`
Mówca: **Narrator**
> "Monica refused to meet my gaze. I wondered if this was the last time I would see her -- or any of them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "I put that thought out of my mind as I made my way back t..."*)

### Węzeł `[294]`
Mówca: **Narrator**
> "I still had plenty of work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Exile = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FinalSupper_Retired = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true"*)

### Węzeł `[298]`
**[WYBÓR GRACZA: ""I swear to you all, I'll learn from my mistakes during the next administration.""]** — Mówca: **Player**
> ""I swear to you all, I'll learn from my mistakes during the next administration.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "Monica sighed heavily."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame...."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Player: ""I swear to you all, I'll learn from my mistakes during t..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: ""I swear to you all, I'll learn from my mistakes during m..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Franc: ""Dad, where are you going to go?""*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Franc: ""Dad, where are you going to go?""*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""But right now, there's no time. We need to get out of So..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true || BaseGame.Ending_ImpeachmentTrial == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[308]`
**[WYBÓR GRACZA: ""I never thought I would be a pariah.""]** — Mówca: **Player**
> ""I never thought I would be a pariah.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "Deana frowned."*)
