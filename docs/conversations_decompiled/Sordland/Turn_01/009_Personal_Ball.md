# Sordland/Turn01/Personal_Ball

- **ID konwersacji:** `9`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/009_Personal_Ball.md`
- **Liczba węzłów dialogowych:** 241
- **Liczba wyborów gracza:** 78

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana
- **[28]** Evelyn Vectern
- **[31]** Franc
- **[46]** Bernard Circas
- **[54]** Serge Wolkner
- **[57]** Reporter
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend`
- `BaseGame.Prologue_Speech_Democracy_Conservative`
- `BaseGame.Prologue_Speech_Democracy_Liberal`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Promise_Immigration_Tighten`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Monica_SupportIntentionAtBall`
- `BaseGameSupport.Codex_Characters_Assembly_BernardCircas`
- `BaseGameSupport.Codex_Characters_Assembly_BernardCircas_Dead`
- `BaseGameSupport.News_Turn01_ST_Interview_CallOthers`
- `BaseGameSupport.News_Turn01_ST_Interview_DifferingValues`
- `BaseGameSupport.News_Turn01_ST_Interview_Negative`
- `BaseGameSupport.News_Turn01_ST_Interview_NoComment`
- `BaseGameSupport.News_Turn01_ST_Interview_NoExpect`
- `BaseGameSupport.News_Turn01_ST_Interview_PartyTrouble`
- `BaseGameSupport.News_Turn01_ST_Interview_Regardless`
- `BaseGameSupport.News_Turn01_ST_Interview_USPPower`
- `BaseGameSupport.News_Turn01_ST_Interview_WelcomeIt`
- `BaseGameSupport.News_Turn01_ST_MPShot`
- `BaseGameSupport.Report_Turn01_Holsord_SecurityIncreased`
- `GameCondition.Turn01_Personal_Ball`

### Skoki między-konwersacyjne:
- Węzeł `[89]` -> **[10] Sordland/Turn01/Ball Prep and Travel** (../Turn_01/010_Ball_Prep_and_Travel.md), Węzeł `[1]`
- Węzeł `[92]` -> **[11] Sordland/Turn01/Shooting** (../Turn_01/011_Shooting.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **"“If the opposition is willing to support us.”"** | `[10]` **Reporter**: "“Do you plan on working together..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Reporter**: "“Mr. Ricter clarified that as lo..."<br>`[12]` **Reporter**: "“Mr. Ricter clarified that as lo..." |
| `[7]` | **"“My administration will bring real change.”"** | `[10]` **Reporter**: "“Do you plan on working together..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Reporter**: "“Does that mean you don’t plan o..." |
| `[8]` | **"“This night is for celebration. I’m not going to talk about my policies now.”"** | `[10]` **Reporter**: "“Do you plan on working together..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Reporter**: "“Does that mean you don’t plan o..." |
| `[9]` | **"“We are going to work with everybody.”"** | `[10]` **Reporter**: "“Do you plan on working together..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Reporter**: "“Mr. Ricter clarified that as lo..."<br>`[12]` **Reporter**: "“Mr. Ricter clarified that as lo..." |
| `[13]` | **"“I did not say that.”"** | `[11]` **Reporter**: "“Does that mean you don’t plan o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn01_ST_Interview_Negati...` | `[21]` **Reporter**: ""One more question. One of your ..."<br>`[116]` **Reporter**: ""One more question. One of your ..." |
| `[14]` | **"“We will do our job, no matter what.”"** | `[11]` **Reporter**: "“Does that mean you don’t plan o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn01_ST_Interview_Regard...` | `[21]` **Reporter**: ""One more question. One of your ..."<br>`[116]` **Reporter**: ""One more question. One of your ..." |
| `[15]` | **"“I don’t think the opposition shares our values, no.”"** | `[11]` **Reporter**: "“Does that mean you don’t plan o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn01_ST_Interview_Differ...` | `[21]` **Reporter**: ""One more question. One of your ..."<br>`[116]` **Reporter**: ""One more question. One of your ..." |
| `[16]` | **""No comment, sorry.""** | `[11]` **Reporter**: "“Does that mean you don’t plan o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn01_ST_Interview_Negati...` | `[21]` **Reporter**: ""One more question. One of your ..."<br>`[116]` **Reporter**: ""One more question. One of your ..." |
| `[17]` | **"“I welcome it. This is a challenge for us all.”"** | `[12]` **Reporter**: "“Mr. Ricter clarified that as lo..."<br>`[102]` **Reporter**: "“Mr. Ricter clarified that as lo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn01_ST_Interview_Welcom...` | `[21]` **Reporter**: ""One more question. One of your ..."<br>`[116]` **Reporter**: ""One more question. One of your ..." |
| `[18]` | **"“We want the other parties to join him in this endeavor.”"** | `[12]` **Reporter**: "“Mr. Ricter clarified that as lo..."<br>`[102]` **Reporter**: "“Mr. Ricter clarified that as lo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn01_ST_Interview_CallOt...` | `[21]` **Reporter**: ""One more question. One of your ..."<br>`[116]` **Reporter**: ""One more question. One of your ..." |
| `[19]` | **"“Honestly, I don’t expect much from him.”"** | `[12]` **Reporter**: "“Mr. Ricter clarified that as lo..."<br>`[102]` **Reporter**: "“Mr. Ricter clarified that as lo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn01_ST_Interview_NoExpe...` | `[21]` **Reporter**: ""One more question. One of your ..."<br>`[116]` **Reporter**: ""One more question. One of your ..." |
| `[20]` | **"“I can’t comment since I haven’t seen his statement yet.”"** | `[12]` **Reporter**: "“Mr. Ricter clarified that as lo..."<br>`[102]` **Reporter**: "“Mr. Ricter clarified that as lo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn01_ST_Interview_NoComm...` | `[21]` **Reporter**: ""One more question. One of your ..."<br>`[116]` **Reporter**: ""One more question. One of your ..." |
| `[30]` | **"“Are you sure you've gotten any wiser, Petr?”"** | `[29]` **Petr Vectern**: "“You two are growing faster than..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Petr Vectern**: "“Maybe not. After all, I'm still..." |
| `[31]` | **"“You're a sight for sore eyes, Petr.”"** | `[29]` **Petr Vectern**: "“You two are growing faster than..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Petr Vectern**: "“Likewise.”" |
| `[32]` | **"“Mr. Vice President.”"** | `[29]` **Petr Vectern**: "“You two are growing faster than..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Petr Vectern**: "“Mr. President.”" |
| `[35]` | **"“Appreciated, Evelyn. It means a lot.”"** | `[28]` **Evelyn Vectern**: "“Congratulations, Anton. I have ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Evelyn Vectern**: "“The pleasure is mine.”" |
| `[36]` | **"“I wish I was as sure as you.”"** | `[28]` **Evelyn Vectern**: "“Congratulations, Anton. I have ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Petr Vectern**: ""Come now, you became the presid..." |
| `[37]` | **"“There's a woman behind every successful man.”"** | `[28]` **Evelyn Vectern**: "“Congratulations, Anton. I have ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Evelyn Vectern**: "“What a gentleman.”" |
| `[38]` | **"“Thank you. We both worked hard to make it happen.”"** | `[28]` **Evelyn Vectern**: "“Congratulations, Anton. I have ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Evelyn Vectern**: "“We know you did. You deserve th..." |
| `[44]` | **"“Yes, it's time. Let's go.”"** | `[43]` **Deana**: "“Papa, can we go? I want to see ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Player_Italic**: "We left the lobby and made our w..." |
| `[45]` | **"“Of course, darling.”"** | `[43]` **Deana**: "“Papa, can we go? I want to see ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Player_Italic**: "We left the lobby and made our w..." |
| `[46]` | **"Move to the ball room."** | `[44]` **Player**: "“Yes, it's time. Let's go.”"<br>`[45]` **Player**: "“Of course, my darling. Let's no..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "Inside, we were yet again surrou..." |
| `[47]` | **"“I'll see you on the trip home.”"** | `[51]` **Serge Wolkner**: "“Good luck out there, Mr. Presid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Narrator**: "I stepped out and immediately fo..." |
| `[48]` | **"“Goodbye.”"** | `[51]` **Serge Wolkner**: "“Good luck out there, Mr. Presid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Narrator**: "I stepped out and immediately fo..." |
| `[57]` | **"“We are having a conversation here, Deana.”"** | `[43]` **Deana**: "“Papa, can we go? I want to see ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "She turned away in disappointment." |
| `[64]` | **"“Thank you, Petr.”"** | `[61]` **Petr Vectern**: ""I respect that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Evelyn Vectern**: "“Monica, how are you? You've bar..." |
| `[65]` | **"“I couldn't have done it without you.”"** | `[61]` **Petr Vectern**: ""I respect that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Petr Vectern**: ""I only did my part, Anton. But,..." |
| `[66]` | **"“We could start by getting some drinks.”"** | `[40]` **Petr Vectern**: ""And tonight, we reap the rewards!""<br>`[63]` **Petr Vectern**: "“I think it's time to celebrate ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Petr Vectern**: "“You read my mind."" |
| `[67]` | **"“Yes, I definitely need a celebration after all that.”"** | `[40]` **Petr Vectern**: ""And tonight, we reap the rewards!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Petr Vectern**: "“I know you do."" |
| `[71]` | **"“Exactly, that's why we are here.”"** | `[40]` **Petr Vectern**: ""And tonight, we reap the rewards!""<br>`[63]` **Petr Vectern**: "“I think it's time to celebrate ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Petr Vectern**: "“We could start by getting some ..." |
| `[72]` | **"“I hope you will show the same enthusiasm on the job.”"** | `[40]` **Petr Vectern**: ""And tonight, we reap the rewards!""<br>`[63]` **Petr Vectern**: "“I think it's time to celebrate ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Petr Vectern**: "“Of course I will! You know me -..." |
| `[75]` | **"“Somebody had to do it.”"** | `[61]` **Petr Vectern**: ""I respect that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Petr Vectern**: ""You're right. I'm glad it was y..." |
| `[82]` | **"“We have to get used to it.""** | `[81]` **Petr Vectern**: ""Oof. That was tiring."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Petr Vectern**: ""Well-"" |
| `[83]` | **"“If I have to shake another hand again...""** | `[81]` **Petr Vectern**: ""Oof. That was tiring."" | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("BallGunshot");` | `[86]` **Narrator**: "Suddenly, a loud banging noise e..." |
| `[84]` | **"“What, you're already tired?""** | `[81]` **Petr Vectern**: ""Oof. That was tiring."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Petr Vectern**: ""Well-"" |
| `[87]` | **"“Another drink?""** | `[81]` **Petr Vectern**: ""Oof. That was tiring."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Petr Vectern**: ""Well-"" |
| `[117]` | **""I've had it with your questions!""** | `[21]` **Reporter**: ""One more question. One of your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "“That’s enough, ma'am,” said one..." |
| `[118]` | **""It was agreed on by the majority of the GNA. I couldn't use my veto on the first ..."** | `[21]` **Reporter**: ""One more question. One of your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "“That’s enough, ma'am,” said one..." |
| `[119]` | **""I've had it with your questions!""** | `[116]` **Reporter**: ""One more question. One of your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "“That’s enough, ma'am,” said one..." |
| `[120]` | **""Yes. No political party deserves to be silenced.""** | `[116]` **Reporter**: ""One more question. One of your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "“That’s enough, ma'am,” said one..." |
| `[121]` | **""I just didn't want to cause too much of a stir on my first day.""** | `[116]` **Reporter**: ""One more question. One of your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "“That’s enough, ma'am,” said one..." |
| `[122]` | **""Perhaps it was. If left unchecked, those two parties will only make trouble for me.""** | `[21]` **Reporter**: ""One more question. One of your ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn01_ST_Interview_USPPow...` | `[22]` **Narrator**: "“That’s enough, ma'am,” said one..." |
| `[123]` | **""As long as you don't burn the roast. Am I right, Petr?""** | `[98]` **Monica**: "“Don't be so old-fashioned, Evel..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[127]` **Narrator**: "Petr laughed loudly. Monica and ..." |
| `[124]` | **""Up to a point, yes. They mustn't neglect their responsibilities to their husbands..."** | `[98]` **Monica**: "“Don't be so old-fashioned, Evel..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[128]` **Narrator**: "Monica opened her mouth, then cl..." |
| `[125]` | **""Absolutely. And we'll work together to achieve that.""** | `[98]` **Monica**: "“Don't be so old-fashioned, Evel..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[129]` **Narrator**: "Monica flashed me a smile." |
| `[126]` | **""That's my wife -- never content to be just a pretty face!""** | `[98]` **Monica**: "“Don't be so old-fashioned, Evel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Narrator**: "Monica flashed me a smile." |
| `[133]` | **""It's to ensure the USP has the funds we need to stay in power long enough to trul..."** | `[21]` **Reporter**: ""One more question. One of your ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn01_ST_Interview_PartyT...` | `[22]` **Narrator**: "“That’s enough, ma'am,” said one..." |
| `[142]` | **""Absolutely. Whether the bill is proposed by my own party or not, I would use my v..."** | `[116]` **Reporter**: ""One more question. One of your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "“That’s enough, ma'am,” said one..." |
| `[148]` | **""Thank you, Mr. Circas. Your congratulations are well received, despite our politi..."** | `[144]` **Bernard Circas**: ""Congratulations, President Rayn..." | `Variable["BaseGame.Prologue_Speech_Democracy_Conservative"] == true` | *Brak zmian stanu* | `[145]` **Bernard Circas**: ""Political differences shouldn't..." |
| `[149]` | **""A remarkable achievement, yes. But the true test begins now, don't you think?""** | `[144]` **Bernard Circas**: ""Congratulations, President Rayn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Bernard Circas**: ""Correct, Mr. President. The rea..." |
| `[150]` | **""I appreciate your congratulations. But from one former Red Youth member to anothe..."** | `[144]` **Bernard Circas**: ""Congratulations, President Rayn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Bernard Circas**: ""That's right, President Rayne. ..." |
| `[160]` | **""Thank you, Mr. Holstron. Our shared past binds us in this journey for a stronger ..."** | `[157]` **Remus Holstron**: ""President Rayne. You have no id..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Remus Holstron**: ""Once a Young Sord, always a You..." |
| `[161]` | **""We've come a long way from our Young Sords days, haven't we, Mr. Holstron?""** | `[157]` **Remus Holstron**: ""President Rayne. You have no id..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Remus Holstron**: ""We sure have. But I still remem..." |
| `[162]` | **""Almost as happy as it makes me to see a fellow Young Sord at this ball.""** | `[157]` **Remus Holstron**: ""President Rayne. You have no id..." | `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == false` | *Brak zmian stanu* | `[196]` **Remus Holstron**: ""From street brawls in Jen to ha..." |
| `[165]` | **""Thank you, Mr. Circas. We've both come a long way from our Red Youth days, haven'..."** | `[144]` **Bernard Circas**: ""Congratulations, President Rayn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Bernard Circas**: ""Yes, we have. But some things n..." |
| `[175]` | **""Revolution, Mr. Circas? Let's hope it's a peaceful one, for the sake of both Sord..."** | `[147]` **Bernard Circas**: "“Perhaps now is the time that ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Bernard Circas**: ""You mustn't forget. To ride tow..." |
| `[176]` | **""You might be onto something, Bernard. But tonight, let's put politics aside and e..."** | `[147]` **Bernard Circas**: "“Perhaps now is the time that ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Bernard Circas**: ""You're right. Tonight should be..." |
| `[177]` | **""Revolution or not, Mr. Circas. It's a night of unity for Sordland. Let's celebrat..."** | `[147]` **Bernard Circas**: "“Perhaps now is the time that ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Bernard Circas**: ""Unity is a rare beast, Presiden..." |
| `[178]` | **""Sordland needs progress, not revolution. Any upheaval will endanger our chance fo..."** | `[147]` **Bernard Circas**: "“Perhaps now is the time that ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Bernard Circas**: ""Remember, to ride towards the s..." |
| `[188]` | **""Thanks for sharing your wisdom, Mr. Circas. Enjoy your evening.""** | `[187]` **Bernard Circas**: ""I've taken up enough of your ti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Bernard Circas**: ""Until we meet again."" |
| `[189]` | **""Well said, Bernard. I'll see you inside.""** | `[187]` **Bernard Circas**: ""I've taken up enough of your ti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Bernard Circas**: ""Until we meet again."" |
| `[190]` | **""You certainly have a way with words, Mr. Circas. I see why they gave you the Vulp..."** | `[187]` **Bernard Circas**: ""I've taken up enough of your ti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Bernard Circas**: ""Until we meet again."" |
| `[194]` | **""I appreciate your sentiments, Mr. Holstron. This triumph belongs to every Sordish..."** | `[157]` **Remus Holstron**: ""President Rayne. You have no id..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Remus Holstron**: ""I know every maroon-blooded Sor..." |
| `[205]` | **""Nicely put, Mr. Holstron. Our shared past and values will help in forging a stron..."** | `[204]` **Remus Holstron**: ""Think of Sordland like a piece ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Remus Holstron**: ""I hope so. That weakling Alphon..." |
| `[206]` | **""Don't forget the importance of embracing new ideals.""** | `[204]` **Remus Holstron**: ""Think of Sordland like a piece ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Remus Holstron**: ""I'm all for new ideals, as long..." |
| `[207]` | **""Your emphasis on order and strength concerns me. We must not forget that democrac..."** | `[204]` **Remus Holstron**: ""Think of Sordland like a piece ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Remus Holstron**: ""I beg to differ. Democracy isn'..." |
| `[208]` | **""I appreciate your perspective, but I believe we need to balance strength with com..."** | `[204]` **Remus Holstron**: ""Think of Sordland like a piece ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Remus Holstron**: ""Compassion won't help when the ..." |
| `[217]` | **""I appreciate your support. Together, we will ensure the preservation of our Sordi..."** | `[224]` **Remus Holstron**: ""I'm glad you're as concerned ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Remus Holstron**: ""Either way, it looks like both ..." |
| `[218]` | **""The tightening of laws should be aimed at preserving our nation's harmony, not fo..."** | `[224]` **Remus Holstron**: ""I'm glad you're as concerned ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Remus Holstron**: ""Either way, it looks like both ..." |
| `[219]` | **""Yes, our immigration is sorely in need of regulation. But we must remember our va..."** | `[224]` **Remus Holstron**: ""I'm glad you're as concerned ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Remus Holstron**: ""Either way, it looks like both ..." |
| `[220]` | **""I disagree. Diversity fosters richness in culture and ideas. Immigration will onl..."** | `[216]` **Remus Holstron**: ""We can't let our culture and id..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Remus Holstron**: ""Either way, it looks like both ..." |
| `[221]` | **""Mr. Holstron, our nation has always thrived by accepting others. We can't shy awa..."** | `[216]` **Remus Holstron**: ""We can't let our culture and id..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Remus Holstron**: ""Either way, it looks like both ..." |
| `[222]` | **""I did not want to change too much too quickly. But I do agree with you. I'm looki..."** | `[216]` **Remus Holstron**: ""We can't let our culture and id..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Remus Holstron**: ""Either way, it looks like both ..." |
| `[226]` | **""Yes, let's put aside politics for tonight. Enjoy the evening.""** | `[225]` **Remus Holstron**: ""But tonight's a celebration, ri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Remus Holstron**: ""We'll speak soon. And remember,..." |
| `[227]` | **""I fully intend to do so. Thanks for the kind words.""** | `[225]` **Remus Holstron**: ""But tonight's a celebration, ri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Remus Holstron**: ""Remember, Mr. President: One So..." |
| `[228]` | **""We have a lot of work to do, Mr. Holstron. I look forward to seeing your proposal..."** | `[225]` **Remus Holstron**: ""But tonight's a celebration, ri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Remus Holstron**: ""Looking forward to it, Mr. Pres..." |
| `[235]` | **""My days in the Young Sords are long behind me now.""** | `[157]` **Remus Holstron**: ""President Rayne. You have no id..." | `(Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == false) == false` | *Brak zmian stanu* | `[236]` **Remus Holstron**: ""Once a Young Sord, always a You..." |
| `[237]` | **""It's been a long time, Comrade Circas.""** | `[144]` **Bernard Circas**: ""Congratulations, President Rayn..." | `(Variable["BaseGame.Prologue_Speech_Democracy_Conservative"] == true) == false` | *Brak zmian stanu* | `[238]` **Bernard Circas**: ""It has, President Rayne. But on..." |

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
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I had just finished buttoning up my suit jacket when the doorbell rang. The Presidential Guard had arrived to pick us up for the inaugural ball."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The ball was a three-decade-old tradition, breathlessly a..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The ball was a three-decade-old tradition, breathlessly anticipated by politicians, bureaucrats and the press. All eyes were about to be on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "I called on Monica to get the children ready. Looking in ..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "My guards fended most of them off, but one woman managed to dodge them and corner me. I recognized the Sordish Broadcasting Company logo on her press lanyard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Reporter: "“Mr. President! Mr. President!”"*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“If the opposition is willing to support us.”"]** — Mówca: **Player**
> "“If the opposition is willing to support us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Conservative == true"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“My administration will bring real change.”"]** — Mówca: **Player**
> "“My administration will bring real change.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Reporter: "“Does that mean you don’t plan on working together? Do yo..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“This night is for celebration. I’m not going to talk about my policies now.”"]** — Mówca: **Player**
> "“This night is for celebration. I’m not going to talk about my policies now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Reporter: "“Does that mean you don’t plan on working together? Do yo..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“We are going to work with everybody.”"]** — Mówca: **Player**
> "“We are going to work with everybody.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Conservative == true"*)

### Węzeł `[10]`
Mówca: **Reporter**
> "“Do you plan on working together with the opposition parties on the expected constitutional reforms?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "“My administration will bring real change.”"*)
  - -> `[8]` (*Player: "“This night is for celebration. I’m not going to talk abo..."*)
  - -> `[6]` (*Player: "“If the opposition is willing to support us.”"*)
  - -> `[9]` (*Player: "“We are going to work with everybody.”"*)

### Węzeł `[11]`
Mówca: **Reporter**
> "“Does that mean you don’t plan on working together? Do you think you share no common ground with the other parties?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "“I did not say that.”"*)
  - -> `[14]` (*Player: "“We will do our job, no matter what.”"*)
  - -> `[15]` (*Player: "“I don’t think the opposition shares our values, no.”"*)
  - -> `[16]` (*Player: ""No comment, sorry.""*)

### Węzeł `[12]`
Mówca: **Reporter**
> "“Mr. Ricter clarified that as long as you hold your promises of democratization, they will support you on these issues to the end. What do you think about this statement?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: "“I welcome it. This is a challenge for us all.”"*)
  - -> `[18]` (*Player: "“We want the other parties to join him in this endeavor.”"*)
  - -> `[19]` (*Player: "“Honestly, I don’t expect much from him.”"*)
  - -> `[20]` (*Player: "“I can’t comment since I haven’t seen his statement yet.”"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“I did not say that.”"]** — Mówca: **Player**
> "“I did not say that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_Interview_Negative = true"*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“We will do our job, no matter what.”"]** — Mówca: **Player**
> "“We will do our job, no matter what.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_Interview_Regardless = true"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“I don’t think the opposition shares our values, no.”"]** — Mówca: **Player**
> "“I don’t think the opposition shares our values, no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_Interview_DifferingValues ..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""No comment, sorry.""]** — Mówca: **Player**
> "“No comment, sorry.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_Interview_Negative = true"*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“I welcome it. This is a challenge for us all.”"]** — Mówca: **Player**
> "“I welcome it. This is a challenge for us all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Reporter), `[102]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_Interview_WelcomeIt = true;"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“We want the other parties to join him in this endeavor.”"]** — Mówca: **Player**
> "“We want the other parties to join him in this endeavor.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Reporter), `[102]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_Interview_CallOthers = true;"*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“Honestly, I don’t expect much from him.”"]** — Mówca: **Player**
> "“Honestly, I don’t expect much from him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Reporter), `[102]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_Interview_NoExpect = true;"*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“I can’t comment since I haven’t seen his statement yet.”"]** — Mówca: **Player**
> "“I can’t comment since I haven’t seen his statement yet.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Reporter), `[102]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_Interview_NoComment = true"*)

### Węzeł `[21]`
Mówca: **Reporter**
> ""One more question. One of your first acts as president was to sign a campaign finance law allocating public election funds by seats in the Assembly as opposed to number of votes. Is this a deliberate attempt to defund the Communist Party and the Bludia Workers' Party, neither of which have reached the election threshold?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: ""I've had it with your questions!""*)
  - -> `[118]` (*Player: ""It was agreed on by the majority of the GNA. I couldn't ..."*)
  - -> `[122]` (*Player: ""Perhaps it was. If left unchecked, those two parties wil..."*)
  - -> `[133]` (*Player: ""It's to ensure the USP has the funds we need to stay in ..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "“That’s enough, ma'am,” said one of my guards while nudging the reporter away from me. A path through the crowd was now open, and we quickly made our way to the entrance of the palace. At the same time, a dozen fireworks went off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "The entrance was decorated with beautiful ribbons in Sord..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "The entrance was decorated with beautiful ribbons in Sordland’s colors of white, yellow and maroon. A lush maroon carpet had been rolled down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "We entered the lobby and joined the throngs of people mak..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "We entered the lobby and joined the throngs of people making their way towards the ballroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)

### Węzeł `[25]`
Mówca: **Deana**
> "“Uncle Petr!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Franc: "“Hi, Uncle Petr. It's great to see you.""*)

### Węzeł `[26]`
Mówca: **Franc**
> "“Hi, Uncle Petr. It's great to see you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Petr Vectern: "“You two are growing faster than I am getting wiser!”"*)

### Węzeł `[27]`
Mówca: **Petr Vectern**
> "“There they are, the most beautiful family in Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Deana: "“Uncle Petr!”"*)

### Węzeł `[28]`
Mówca: **Evelyn Vectern**
> "“Congratulations, Anton. I have to say, the results were clear to me from the beginning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "“Appreciated, Evelyn. It means a lot.”"*)
  - -> `[38]` (*Player: "“Thank you. We both worked hard to make it happen.”"*)
  - -> `[36]` (*Player: "“I wish I was as sure as you.”"*)
  - -> `[37]` (*Player: "“There's a woman behind every successful man.”"*)

### Węzeł `[29]`
Mówca: **Petr Vectern**
> "“You two are growing faster than I am getting wiser!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: "“Are you sure you've gotten any wiser, Petr?”"*)
  - -> `[31]` (*Player: "“You're a sight for sore eyes, Petr.”"*)
  - -> `[32]` (*Player: "“Mr. Vice President.”"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Are you sure you've gotten any wiser, Petr?”"]** — Mówca: **Player**
> "“Are you sure you've gotten any wiser, Petr?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Petr Vectern: "“Maybe not. After all, I'm still sticking with you.""*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“You're a sight for sore eyes, Petr.”"]** — Mówca: **Player**
> "“You're a sight for sore eyes, Petr.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Petr Vectern: "“Likewise.”"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Mr. Vice President.”"]** — Mówca: **Player**
> "“Mr. Vice President.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Petr Vectern: "“Mr. President.”"*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Inside, we were yet again surrounded by a noisy crowd – but this time, it was the politicians who sought to appease the new authority in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "I spent the next few hours shaking hands, joining various..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Petr's wife Evelyn approached us and shook our hands with a firmness that belied her delicate features."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Evelyn Vectern: "“Congratulations, Anton. I have to say, the results were ..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Appreciated, Evelyn. It means a lot.”"]** — Mówca: **Player**
> "“Appreciated, Evelyn. It means a lot.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Evelyn Vectern: "“The pleasure is mine.”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“I wish I was as sure as you.”"]** — Mówca: **Player**
> "“I wish I was as sure as you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Petr Vectern: ""Come now, you became the president. You held fast agains..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“There's a woman behind every successful man.”"]** — Mówca: **Player**
> "“There's a woman behind every successful man.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Evelyn Vectern: "“What a gentleman.”"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Thank you. We both worked hard to make it happen.”"]** — Mówca: **Player**
> "“Thank you. We both worked hard to make it happen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Evelyn Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Evelyn Vectern: "“We know you did. You deserve the position.”"*)

### Węzeł `[39]`
Mówca: **Evelyn Vectern**
> "“Monica, how are you? You've barely said a word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Monica: ""I'm more than relieved to have this roller-coaster ride ..."*)

### Węzeł `[40]`
Mówca: **Petr Vectern**
> ""And tonight, we reap the rewards!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: "“I hope you will show the same enthusiasm on the job.”"*)
  - -> `[71]` (*Player: "“Exactly, that's why we are here.”"*)
  - -> `[66]` (*Player: "“We could start by getting some drinks.”"*)
  - -> `[67]` (*Player: "“Yes, I definitely need a celebration after all that.”"*)

### Węzeł `[41]`
Mówca: **Evelyn Vectern**
> "“What a gentleman.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "Monica smiled at me."*)

### Węzeł `[42]`
Mówca: **Evelyn Vectern**
> "“The pleasure is mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Petr Vectern: "“I think it's time to celebrate this victory!""*)

### Węzeł `[43]`
Mówca: **Deana**
> "“Papa, can we go? I want to see the ballroom!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "“We are having a conversation here, Deana.”"*)
  - -> `[44]` (*Player: "“Yes, it's time. Let's go.”"*)
  - -> `[45]` (*Player: "“Of course, darling.”"*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Yes, it's time. Let's go.”"]** — Mówca: **Player**
> "“Yes, it's time. Let's go.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Italic: "Move to the ball room."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Of course, darling.”"]** — Mówca: **Player**
> "“Of course, my darling. Let's not delay any longer.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Italic: "Move to the ball room."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "Move to the ball room."]** — Mówca: **Player_Italic**
> "We left the lobby and made our way towards the ballroom."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Player), `[45]` (Player), `[59]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Inside, we were yet again surrounded by a noisy crowd – b..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "“I'll see you on the trip home.”"]** — Mówca: **Player**
> "“I'll see you on the trip home.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "I stepped out and immediately found myself surrounded by ..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Goodbye.”"]** — Mówca: **Player**
> "“Goodbye.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "I stepped out and immediately found myself surrounded by ..."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "I stepped out and immediately found myself surrounded by loud voices and camera flashes. Hordes of eager journalists thrust their portable microphones my way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "My guards fended most of them off, but one woman managed ..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Politicians, bureaucrats and celebrities -- the creme de la creme of the Sordland elite -- streamed inside the building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Serge Wolkner: "“Good luck out there, Mr. President.”"*)

### Węzeł `[51]`
Mówca: **Serge Wolkner**
> "“Good luck out there, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: "“I'll see you on the trip home.”"*)
  - -> `[48]` (*Player: "“Goodbye.”"*)

### Węzeł `[52]`
Mówca: **Petr Vectern**
> "“Maybe not. After all, I'm still sticking with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Monica: "“Happy to see a familiar face, Petr. Evelyn!”"*)

### Węzeł `[53]`
Mówca: **Petr Vectern**
> "“Likewise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Monica: "“Happy to see a familiar face, Petr. Evelyn!”"*)

### Węzeł `[54]`
Mówca: **Petr Vectern**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Monica: "“Happy to see a familiar face, Petr. Evelyn!”"*)

### Węzeł `[55]`
Mówca: **Monica**
> "“Happy to see a familiar face, Petr. Evelyn!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Petr's wife Evelyn approached us and shook our hands with..."*)

### Węzeł `[56]`
Mówca: **Reporter**
> "“Mr. President! Mr. President!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Reporter: "“Do you plan on working together with the opposition part..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“We are having a conversation here, Deana.”"]** — Mówca: **Player**
> "“We are having a conversation here, Deana.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "She turned away in disappointment."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "She turned away in disappointment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Monica: "“That's all right, we need to go anyway. It's already time.”"*)

### Węzeł `[59]`
Mówca: **Monica**
> "“That's all right, we need to go anyway. It's already time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Italic: "Move to the ball room."*)

### Węzeł `[60]`
Mówca: **Petr Vectern**
> ""Come now, you became the president. You held fast against the party leadership and managed to win.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Petr Vectern: ""I respect that.""*)

### Węzeł `[61]`
Mówca: **Petr Vectern**
> ""I respect that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: "“Somebody had to do it.”"*)
  - -> `[64]` (*Player: "“Thank you, Petr.”"*)
  - -> `[65]` (*Player: "“I couldn't have done it without you.”"*)

### Węzeł `[62]`
Mówca: **Evelyn Vectern**
> "“We know you did. You deserve the position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Petr Vectern: ""And tonight, we reap the rewards!""*)

### Węzeł `[63]`
Mówca: **Petr Vectern**
> "“I think it's time to celebrate this victory!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: "“I hope you will show the same enthusiasm on the job.”"*)
  - -> `[71]` (*Player: "“Exactly, that's why we are here.”"*)
  - -> `[66]` (*Player: "“We could start by getting some drinks.”"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Thank you, Petr.”"]** — Mówca: **Player**
> "“Thank you, Petr.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Evelyn Vectern: "“Monica, how are you? You've barely said a word.""*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“I couldn't have done it without you.”"]** — Mówca: **Player**
> "“I couldn't have done it without you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Petr Vectern: ""I only did my part, Anton. But, thanks, that means a lot.""*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“We could start by getting some drinks.”"]** — Mówca: **Player**
> "“We could start by getting some drinks.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Petr Vectern), `[63]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Petr Vectern: "“You read my mind.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“Yes, I definitely need a celebration after all that.”"]** — Mówca: **Player**
> "“Yes, I definitely need a celebration after all that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Petr Vectern: "“I know you do.""*)

### Węzeł `[68]`
Mówca: **Petr Vectern**
> "“I know you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Evelyn Vectern: "“Monica, how are you? You've barely said a word.""*)

### Węzeł `[69]`
Mówca: **Petr Vectern**
> "“You read my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Petr grinned and beckoned a roving waiter. The four of us..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "Petr grinned and beckoned a roving waiter. The four of us each took a glass of champagne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Evelyn Vectern: "“Monica, how are you? You've barely said a word.""*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“Exactly, that's why we are here.”"]** — Mówca: **Player**
> "“Exactly, that's why we are here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Petr Vectern), `[63]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Petr Vectern: "“We could start by getting some drinks.”"*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“I hope you will show the same enthusiasm on the job.”"]** — Mówca: **Player**
> "“I hope you will show the same enthusiasm on the job.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Petr Vectern), `[63]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Petr Vectern: "“Of course I will! You know me -- I work as hard as I play.""*)

### Węzeł `[73]`
Mówca: **Narrator**
> "He gave a short smile that looked halfway genuine. He seemed uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Evelyn Vectern: "“Monica, how are you? You've barely said a word.""*)

### Węzeł `[74]`
Mówca: **Petr Vectern**
> "“Of course I will! You know me -- I work as hard as I play.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He gave a short smile that looked halfway genuine. He see..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Somebody had to do it.”"]** — Mówca: **Player**
> "“Somebody had to do it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Petr Vectern: ""You're right. I'm glad it was you is all.""*)

### Węzeł `[76]`
Mówca: **Petr Vectern**
> ""You're right. I'm glad it was you is all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Evelyn Vectern: "“Monica, how are you? You've barely said a word.""*)

### Węzeł `[77]`
Mówca: **Petr Vectern**
> "“We could start by getting some drinks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Petr grinned and beckoned a roving waiter. The four of us..."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "Monica smiled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1"*)

### Węzeł `[79]`
Mówca: **Petr Vectern**
> ""I only did my part, Anton. But, thanks, that means a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Evelyn Vectern: "“Monica, how are you? You've barely said a word.""*)

### Węzeł `[80]`
Mówca: **Narrator**
> "We finally settled down at our dinner table with the Vecterns as the band started playing some slow jazz tunes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Petr Vectern: ""Oof. That was tiring.""*)

### Węzeł `[81]`
Mówca: **Petr Vectern**
> ""Oof. That was tiring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: "“We have to get used to it.""*)
  - -> `[84]` (*Player: "“What, you're already tired?""*)
  - -> `[87]` (*Player: "“Another drink?""*)
  - -> `[83]` (*Player: "“If I have to shake another hand again...""*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“We have to get used to it.""]** — Mówca: **Player**
> "“We have to get used to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Petr Vectern: ""Well-""*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“If I have to shake another hand again...""]** — Mówca: **Player**
> "“If I have to shake another hand again...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("BallGunshot");"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“What, you're already tired?""]** — Mówca: **Player**
> "“What, you're already tired?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Petr Vectern: ""Well-""*)

### Węzeł `[85]`
Mówca: **Petr Vectern**
> ""Well-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("BallGunshot");"*)

### Węzeł `[86]`
Mówca: **Narrator**
> "Suddenly, a loud banging noise echoed from outside the ballroom. Then another one. And another."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "The musicians stopped playing. Everyone in the room was l..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "“Another drink?""]** — Mówca: **Player**
> ""Another drink?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Petr Vectern: ""Well-""*)

### Węzeł `[88]`
Mówca: **Monica**
> ""I'm more than relieved to have this roller-coaster ride over with. But of course, now the real work begins...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Evelyn Vectern: ""Ah, yes. Managing the help, planning parties, daily trip..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "I called on Monica to get the children ready. Looking in the mirror, I straightened my tie and took a deep breath. After tonight, there would be no turning back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[90]`
Mówca: **Narrator**
> "I spent the next few hours shaking hands, joining various conversations -- some serious, some superficial -- and making speeches."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "We finally settled down at our dinner table with the Vect..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "The musicians stopped playing. Everyone in the room was looking around in confusion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Petr and I turned towards each other, realization dawning..."*)

### Węzeł `[92]`
Mówca: **Petr Vectern**
> ""Fireworks!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Petr and I turned towards each other, realization dawning on both of our faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Petr Vectern: ""Fireworks!?""*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn01_Personal_Ball = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn01_Personal_Ball"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[95]`
Mówca: **Narrator**
> "At all costs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_MPShot = true"*)

### Węzeł `[96]`
Mówca: **Narrator**
> "I crushed the cigarette on the ashtray."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");"*)

### Węzeł `[97]`
Mówca: **Evelyn Vectern**
> ""Ah, yes. Managing the help, planning parties, daily trips to the salon to look your best for foreign dignitaries --""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Monica: "“Don't be so old-fashioned, Evelyn! I plan to use my powe..."*)

### Węzeł `[98]`
Mówca: **Monica**
> "“Don't be so old-fashioned, Evelyn! I plan to use my power as First Lady to advance the position of women throughout Sordland. Equal rights for our sex are long overdue, wouldn't you say, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""As long as you don't burn the roast. Am I right, Petr?""*)
  - -> `[124]` (*Player: ""Up to a point, yes. They mustn't neglect their responsib..."*)
  - -> `[125]` (*Player: ""Absolutely. And we'll work together to achieve that.""*)
  - -> `[126]` (*Player: ""That's my wife -- never content to be just a pretty face!""*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Conservative == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Conservative == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Speech_Democracy_Conservative == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Conservative == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Conservative"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Reporter: "“Mr. Ricter clarified that as long as you support their d..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Speech_Democracy_Conservative == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Conservative"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Reporter: "“Mr. Ricter clarified that as long as you hold your promi..."*)

### Węzeł `[102]`
Mówca: **Reporter**
> "“Mr. Ricter clarified that as long as you support their demands of democratization, they will work with you on all issues with a cooperative spirit. What do you think about this statement?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: "“I welcome it. This is a challenge for us all.”"*)
  - -> `[18]` (*Player: "“We want the other parties to join him in this endeavor.”"*)
  - -> `[19]` (*Player: "“Honestly, I don’t expect much from him.”"*)
  - -> `[20]` (*Player: "“I can’t comment since I haven’t seen his statement yet.”"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_Interview_WelcomeIt = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_WelcomeIt"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_Interview_CallOthers = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_CallOthers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_Interview_NoExpect = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_NoExpect"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_Interview_NoComment = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_NoComment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_Interview_Regardless = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_Regardless"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_Interview_DifferingValues = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_DifferingValues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_Interview_Negative = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_Negative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_MPShot = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_MPShot"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "I crushed the cigarette on the ashtray."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Holsord_SecurityIncreased = true;
BaseGameSupport.Codex_Characters_Assembly_BernardCircas = false; BaseGameSupport.Codex_Characters_Assembly_BernardCircas_Dead = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_SecurityIncreased"] = true;
Variable["BaseGameSupport.Codex_Characters_Assembly_BernardCircas"] = false;
Variable["BaseGameSupport.Codex_Characters_Assembly_BernardCircas_Dead"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn01_Personal_Ball = true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Evelyn Vectern: "“Monica, how are you? You've barely said a word.""*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Reporter: ""One more question. One of your first acts as president w..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Reporter: ""One more question. One of your first acts as president w..."*)

### Węzeł `[116]`
Mówca: **Reporter**
> ""One more question. One of your first acts as president was to veto a campaign finance law that would have deprived small parties of public funds while increasing those channeled to your own. Are we seeing the beginning of a more egalitarian administration?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: ""I've had it with your questions!""*)
  - -> `[120]` (*Player: ""Yes. No political party deserves to be silenced.""*)
  - -> `[142]` (*Player: ""Absolutely. Whether the bill is proposed by my own party..."*)
  - -> `[121]` (*Player: ""I just didn't want to cause too much of a stir on my fir..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""I've had it with your questions!""]** — Mówca: **Player**
> ""I've had it with your questions!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "“That’s enough, ma'am,” said one of my guards while nudgi..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""It was agreed on by the majority of the GNA. I couldn't use my veto on the first day.""]** — Mówca: **Player**
> ""It was agreed on by the majority of the GNA. I couldn't use my veto on the first day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "“That’s enough, ma'am,” said one of my guards while nudgi..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""I've had it with your questions!""]** — Mówca: **Player**
> ""I've had it with your questions!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "“That’s enough, ma'am,” said one of my guards while nudgi..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""Yes. No political party deserves to be silenced.""]** — Mówca: **Player**
> ""Yes. No political party deserves to be silenced.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "“That’s enough, ma'am,” said one of my guards while nudgi..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I just didn't want to cause too much of a stir on my first day.""]** — Mówca: **Player**
> ""I just didn't want to cause too much of a stir on my first day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "“That’s enough, ma'am,” said one of my guards while nudgi..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""Perhaps it was. If left unchecked, those two parties will only make trouble for me.""]** — Mówca: **Player**
> ""Perhaps it was. If left unchecked, those two parties will only make trouble for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_Interview_USPPower = true"*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""As long as you don't burn the roast. Am I right, Petr?""]** — Mówca: **Player**
> ""As long as you don't burn the roast. Am I right, Petr?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Up to a point, yes. They mustn't neglect their responsibilities to their husbands and families.""]** — Mówca: **Player**
> ""Up to a point, yes. They mustn't neglect their responsibilities to their husbands and families.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""Absolutely. And we'll work together to achieve that.""]** — Mówca: **Player**
> ""Absolutely. And we'll work together to achieve that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1; BaseGame.Relation..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""That's my wife -- never content to be just a pretty face!""]** — Mówca: **Player**
> ""That's my wife -- never content to be just a pretty face!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Monica flashed me a smile."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "Petr laughed loudly. Monica and Evelyn both glared at us. An awkward silence descended."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "Deana suddenly jumped in between us and tugged on my sleeve."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "Monica opened her mouth, then closed it again. An awkward silence descended."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "Deana suddenly jumped in between us and tugged on my sleeve."*)

### Węzeł `[129]`
Mówca: **Narrator**
> "Monica flashed me a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "Deana suddenly jumped in between us and tugged on my sleeve."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1;
BaseGame.Relations_Monica_SupportIntentionAtBall = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;
Variable["BaseGame.Relations_Monica_SupportIntentionAtBall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Monica flashed me a smile."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "Petr laughed loudly. Monica and Evelyn both glared at us...."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "Deana suddenly jumped in between us and tugged on my sleeve."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Deana: "“Papa, can we go? I want to see the ballroom!”"*)

### Węzeł `[133]`
**[WYBÓR GRACZA: ""It's to ensure the USP has the funds we need to stay in power long enough to truly bring democracy to this country.""]** — Mówca: **Player**
> ""No, it's to ensure the USP has the funds we need to stay in power long enough to truly bring democracy to this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_ST_Interview_PartyTrouble = true"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_Interview_USPPower = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_USPPower"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "“That’s enough, ma'am,” said one of my guards while nudgi..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_ST_Interview_PartyTrouble = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_Interview_PartyTrouble"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "“That’s enough, ma'am,” said one of my guards while nudgi..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "Monica opened her mouth, then closed it again. An awkward..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == ..."*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend =..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I had just finished buttoning up my suit jacket when the ..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "I had just finished buttoning up my suit jacket when the ..."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "I had just finished buttoning up my suit jacket when the doorbell rang. The Presidential Guard had arrived to pick us up for the inaugural ball."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The ball was a three-decade-old tradition, breathlessly a..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("BallGunshot");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("BallGunshot");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Suddenly, a loud banging noise echoed from outside the ba..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Absolutely. Whether the bill is proposed by my own party or not, I would use my veto on it if it goes against the interest of our democracy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "“That’s enough, ma'am,” said one of my guards while nudgi..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Map_Music_Tense");`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Legislative", "Position_NotableMem..."*)

### Węzeł `[144]`
Mówca: **Bernard Circas**
> ""Congratulations, President Rayne. A remarkable achievement, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Conservative == true"*)
  - -> `[149]` (*Player: ""A remarkable achievement, yes. But the true test begins ..."*)
  - -> `[150]` (*Player: ""I appreciate your congratulations. But from one former R..."*)
  - -> `[165]` (*Player: ""Thank you, Mr. Circas. We've both come a long way from o..."*)

### Węzeł `[145]`
Mówca: **Bernard Circas**
> ""Political differences shouldn't keep us from acknowledging achievements. But I still hold out hope that joining the Red Youth wasn't just a phase for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Bernard Circas: "“I can't help but wonder how the winds of change will blo..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "Behind me, I heard a familiar voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Petr Vectern: "“There they are, the most beautiful family in Sordland!”"*)

### Węzeł `[147]`
Mówca: **Bernard Circas**
> "“Perhaps now is the time that our long-nurtured dream of revolution will finally become a reality.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player: ""Revolution, Mr. Circas? Let's hope it's a peaceful one, ..."*)
  - -> `[178]` (*Player: ""Sordland needs progress, not revolution. Any upheaval wi..."*)
  - -> `[176]` (*Player: ""You might be onto something, Bernard. But tonight, let's..."*)
  - -> `[177]` (*Player: ""Revolution or not, Mr. Circas. It's a night of unity for..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Circas. Your congratulations are well received, despite our political differences.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Speech_Democracy_Conservative"] == true`
- **Kontekst wejściowy (poprzednik):** `[144]` (Bernard Circas)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Bernard Circas: ""Political differences shouldn't keep us from acknowledgi..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A remarkable achievement, yes. But the true test begins now, don't you think?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Bernard Circas)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Bernard Circas: ""Correct, Mr. President. The real work begins now.""*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I appreciate your congratulations. But from one former Red Youth member to another, we both know our work has just begun.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Bernard Circas)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Bernard Circas: ""That's right, President Rayne. Once a Red Youth, always ..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == true )"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "As I navigated through the crowd, a familiar figure stepp..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "Navigating the sea of guests, I found myself face-to-face..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Behind me, I heard a familiar voice."*)

### Węzeł `[157]`
Mówca: **Remus Holstron**
> ""President Rayne. You have no idea how happy it makes me to see a fellow Young Sord in the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player: ""Thank you, Mr. Holstron. Our shared past binds us in thi..."*)
  - -> `[161]` (*Player: ""We've come a long way from our Young Sords days, haven't..."*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == false"*)
  - -> `[194]` (*Player: ""I appreciate your sentiments, Mr. Holstron. This triumph..."*)

### Węzeł `[158]`
Mówca: **Remus Holstron**
> ""We sure have. But I still remember them like they were yesterday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Remus Holstron: ""My time in the Young Sords taught me a lot about the tru..."*)

### Węzeł `[159]`
Mówca: **Remus Holstron**
> ""Once a Young Sord, always a Young Sord. That's what I believe, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Remus Holstron: ""My time in the Young Sords taught me a lot about the tru..."*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Holstron. Our shared past binds us in this journey for a stronger Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Remus Holstron: ""Once a Young Sord, always a Young Sord. That's what I be..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We've come a long way from our Young Sords days, haven't we, Mr. Holstron?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Remus Holstron: ""We sure have. But I still remember them like they were y..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Almost as happy as it makes me to see a fellow Young Sord at this ball.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == false`
- **Kontekst wejściowy (poprzednik):** `[157]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Remus Holstron: ""From street brawls in Jen to handshakes at the Maroon Pa..."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "Navigating the sea of guests, I found myself face-to-face with a towering figure. Remus Holstron, the 'Iron Wall', former Young Sord, and a stalwart of the National Front Party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "He leveled a steel gaze at me, then broke into a smile."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "As I navigated through the crowd, a familiar figure stepped into my path. It was Bernard Circas -- the acclaimed poet and now MP. His face bore a look of subtle defiance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Bernard Circas: ""Congratulations, President Rayne. A remarkable achieveme..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Circas. We've both come a long way from our Red Youth days, haven't we?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Bernard Circas)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Bernard Circas: ""Yes, we have. But some things never change, do they?""*)

### Węzeł `[166]`
Mówca: **Bernard Circas**
> ""Correct, Mr. President. The real work begins now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Bernard Circas: "“I can't help but wonder how the winds of change will blo..."*)

### Węzeł `[167]`
Mówca: **Bernard Circas**
> ""That's right, President Rayne. Once a Red Youth, always a Red Youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Bernard Circas: "“I can't help but wonder how the winds of change will blo..."*)

### Węzeł `[168]`
Mówca: **Bernard Circas**
> ""Yes, we have. But some things never change, do they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Bernard Circas: "“I can't help but wonder how the winds of change will blo..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Bernard Circas");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Bernard Circas");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "As I watched Bernard Circas blend back into the crowd, hi..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Remus Holstron");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Remus Holstron");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "As Remus Holstron disappeared back into the crowd, his pa..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Conservative == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Conservative == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Speech_Democracy_Conservative == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Conservative == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Conservative"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""Thank you, Mr. Circas. Your congratulations are well rec..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Speech_Democracy_Conservative == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Conservative"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Player: ""It's been a long time, Comrade Circas.""*)

### Węzeł `[174]`
Mówca: **Bernard Circas**
> "“I can't help but wonder how the winds of change will blow in our Sordland now that you've taken the helm.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Bernard Circas: "“Perhaps now is the time that our long-nurtured dream of ..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Revolution, Mr. Circas? Let's hope it's a peaceful one, for the sake of both Sordland and its new president.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Bernard Circas)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Bernard Circas: ""You mustn't forget. To ride towards the sun is to invite..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You might be onto something, Bernard. But tonight, let's put politics aside and enjoy the evening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Bernard Circas)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Bernard Circas: ""You're right. Tonight should be a celebration. But remem..."*)

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Revolution or not, Mr. Circas. It's a night of unity for Sordland. Let's celebrate that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Bernard Circas)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Bernard Circas: ""Unity is a rare beast, President Rayne. Remember, to rid..."*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sordland needs progress, not revolution. Any upheaval will endanger our chance for improvement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Bernard Circas)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Bernard Circas: ""Remember, to ride towards the sun is to invite flame, ye..."*)

### Węzeł `[179]`
Mówca: **Bernard Circas**
> ""You mustn't forget. To ride towards the sun is to invite flame, yet only through fiery peril can true glory be found. The light of it binds us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Bernard Circas: ""That is the weight of your new role.""*)

### Węzeł `[180]`
Mówca: **Bernard Circas**
> ""You're right. Tonight should be a celebration. But remember, to ride towards the sun is to invite flame, yet only through fiery peril can true glory be found. The light of it binds us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Bernard Circas: ""Let's hope for the same for Sordland.""*)

### Węzeł `[181]`
Mówca: **Bernard Circas**
> ""Unity is a rare beast, President Rayne. Remember, to ride towards the sun is to invite flame, yet only through fiery peril can true glory be found. The light of it binds us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Bernard Circas: ""We will share this journey together.""*)

### Węzeł `[182]`
Mówca: **Bernard Circas**
> ""Remember, to ride towards the sun is to invite flame, yet only through fiery peril can true glory be found. The light of it binds us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Bernard Circas: ""Danger and progress... they might be more intertwined th..."*)

### Węzeł `[183]`
Mówca: **Bernard Circas**
> ""That is the weight of your new role.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Bernard Circas: ""I've taken up enough of your time, President Rayne. This..."*)

### Węzeł `[184]`
Mówca: **Bernard Circas**
> ""Let's hope for the same for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Bernard Circas: ""I've taken up enough of your time, President Rayne. This..."*)

### Węzeł `[185]`
Mówca: **Bernard Circas**
> ""We will share this journey together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Bernard Circas: ""I've taken up enough of your time, President Rayne. This..."*)

### Węzeł `[186]`
Mówca: **Bernard Circas**
> ""Danger and progress... they might be more intertwined than you think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Bernard Circas: ""I've taken up enough of your time, President Rayne. This..."*)

### Węzeł `[187]`
Mówca: **Bernard Circas**
> ""I've taken up enough of your time, President Rayne. This is your night, after all. Your family, friends, and country await.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: ""Thanks for sharing your wisdom, Mr. Circas. Enjoy your e..."*)
  - -> `[190]` (*Player: ""You certainly have a way with words, Mr. Circas. I see w..."*)
  - -> `[189]` (*Player: ""Well said, Bernard. I'll see you inside.""*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thanks for sharing your wisdom, Mr. Circas. Enjoy your evening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Bernard Circas)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Bernard Circas: ""Until we meet again.""*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well said, Bernard. I'll see you inside.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Bernard Circas)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Bernard Circas: ""Until we meet again.""*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You certainly have a way with words, Mr. Circas. I see why they gave you the Vulpitzer Award.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Bernard Circas)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Bernard Circas: ""Until we meet again.""*)

### Węzeł `[191]`
Mówca: **Narrator**
> "Were they mere poetic expressions? Or a reflection of the real socialist sentiments stirring within the country?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Behind me, I heard a familiar voice."*)

### Węzeł `[192]`
Mówca: **Narrator**
> "As I watched Bernard Circas blend back into the crowd, his words echoed in my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "Were they mere poetic expressions? Or a reflection of the..."*)

### Węzeł `[193]`
Mówca: **Bernard Circas**
> ""Until we meet again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Bernard Circas");"*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I appreciate your sentiments, Mr. Holstron. This triumph belongs to every Sordish citizen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Remus Holstron: ""I know every maroon-blooded Sord is rejoicing at your vi..."*)

### Węzeł `[195]`
Mówca: **Remus Holstron**
> ""I know every maroon-blooded Sord is rejoicing at your victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Remus Holstron: ""My time in the Young Sords taught me a lot about the tru..."*)

### Węzeł `[196]`
Mówca: **Remus Holstron**
> ""From street brawls in Jen to handshakes at the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Remus Holstron: ""My time in the Young Sords taught me a lot about the tru..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == false"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Speech_Democracy_Liberal == false)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player: ""Almost as happy as it makes me to see a fellow Young Sor..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Speech_Democracy_Liberal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player: ""My days in the Young Sords are long behind me now.""*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Tighten == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Tighten == true"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Immigration_Tighten == true)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Tighten == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Tighten"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Remus Holstron: ""I heard about your promise to tighten Sordland's immigra..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Immigration_Tighten == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Tighten"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Remus Holstron: ""Speaking of which, I heard you're sticking with Alphonso..."*)

### Węzeł `[203]`
Mówca: **Remus Holstron**
> ""My time in the Young Sords taught me a lot about the true spirit of this nation. You too, I bet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Remus Holstron: ""Think of Sordland like a piece of iron forged in fire. S..."*)

### Węzeł `[204]`
Mówca: **Remus Holstron**
> ""Think of Sordland like a piece of iron forged in fire. Strengthened by the flame of dedication and the hammer of order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player: ""Nicely put, Mr. Holstron. Our shared past and values wil..."*)
  - -> `[208]` (*Player: ""I appreciate your perspective, but I believe we need to ..."*)
  - -> `[206]` (*Player: ""Don't forget the importance of embracing new ideals.""*)
  - -> `[207]` (*Player: ""Your emphasis on order and strength concerns me. We must..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Nicely put, Mr. Holstron. Our shared past and values will help in forging a strong Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Remus Holstron: ""I hope so. That weakling Alphonso knew nothing about the..."*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't forget the importance of embracing new ideals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Remus Holstron: ""I'm all for new ideals, as long as we don't stray too fa..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your emphasis on order and strength concerns me. We must not forget that democracy is the core of our nation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Remus Holstron: ""I beg to differ. Democracy isn't the core of our nation,..."*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I appreciate your perspective, but I believe we need to balance strength with compassion to truly honor the spirit of Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Remus Holstron: ""Compassion won't help when the country descends into cha..."*)

### Węzeł `[209]`
Mówca: **Remus Holstron**
> ""Compassion won't help when the country descends into chaos. Only a firm hand with an unyielding grip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Tighten == true"*)

### Węzeł `[210]`
Mówca: **Remus Holstron**
> ""I hope so. That weakling Alphonso knew nothing about the true nature of leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Tighten == true"*)

### Węzeł `[211]`
Mówca: **Remus Holstron**
> ""I beg to differ. Democracy isn't the core of our nation, Mr. President. It's something we copied from our neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Remus Holstron: ""Whether in 1866 or 1928, one thing rings true. Without o..."*)

### Węzeł `[212]`
Mówca: **Remus Holstron**
> ""I'm all for new ideals, as long as we don't stray too far from the principles that have defined us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Tighten == true"*)

### Węzeł `[213]`
Mówca: **Remus Holstron**
> ""Either way, it looks like both of us have a busy term ahead of us. I've got a series of bills I'm working on to address the friction in our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Remus Holstron: ""But tonight's a celebration, right? Time to show all the..."*)

### Węzeł `[214]`
Mówca: **Remus Holstron**
> ""Whether in 1866 or 1928, one thing rings true. Without order, there is chaos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Tighten == true"*)

### Węzeł `[215]`
Mówca: **Remus Holstron**
> ""I heard about your promise to tighten Sordland's immigration laws, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Remus Holstron: ""I'm glad you're as concerned about preserving our nation..."*)

### Węzeł `[216]`
Mówca: **Remus Holstron**
> ""We can't let our culture and identity become diluted. Sordland for Sords, as they say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player: ""I disagree. Diversity fosters richness in culture and id..."*)
  - -> `[222]` (*Player: ""I did not want to change too much too quickly. But I do ..."*)
  - -> `[221]` (*Player: ""Mr. Holstron, our nation has always thrived by accepting..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I appreciate your support. Together, we will ensure the preservation of our Sordish identity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Remus Holstron: ""Either way, it looks like both of us have a busy term ah..."*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The tightening of laws should be aimed at preserving our nation's harmony, not fostering division.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Remus Holstron: ""Either way, it looks like both of us have a busy term ah..."*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, our immigration is sorely in need of regulation. But we must remember our values of unity and compassion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Remus Holstron: ""Either way, it looks like both of us have a busy term ah..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I disagree. Diversity fosters richness in culture and ideas. Immigration will only strengthen Sordish identity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Remus Holstron: ""Either way, it looks like both of us have a busy term ah..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Holstron, our nation has always thrived by accepting others. We can't shy away from that now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Remus Holstron: ""Either way, it looks like both of us have a busy term ah..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I did not want to change too much too quickly. But I do agree with you. I'm looking to tighten those laws in the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Remus Holstron: ""Either way, it looks like both of us have a busy term ah..."*)

### Węzeł `[223]`
Mówca: **Remus Holstron**
> ""Speaking of which, I heard you're sticking with Alphonso's lax immigration laws? Surely that's not true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Remus Holstron: ""We can't let our culture and identity become diluted. So..."*)

### Węzeł `[224]`
Mówca: **Remus Holstron**
> ""I'm glad you're as concerned about preserving our nation's identity as I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player: ""I appreciate your support. Together, we will ensure the ..."*)
  - -> `[219]` (*Player: ""Yes, our immigration is sorely in need of regulation. Bu..."*)
  - -> `[218]` (*Player: ""The tightening of laws should be aimed at preserving our..."*)

### Węzeł `[225]`
Mówca: **Remus Holstron**
> ""But tonight's a celebration, right? Time to show all the establishment politicians in the Palace how a real patriot lets loose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player: ""Yes, let's put aside politics for tonight. Enjoy the eve..."*)
  - -> `[228]` (*Player: ""We have a lot of work to do, Mr. Holstron. I look forwar..."*)
  - -> `[227]` (*Player: ""I fully intend to do so. Thanks for the kind words.""*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, let's put aside politics for tonight. Enjoy the evening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Remus Holstron: ""We'll speak soon. And remember, never lose sight of the ..."*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I fully intend to do so. Thanks for the kind words.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Remus Holstron: ""Remember, Mr. President: One Sordland, One Nation, One F..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We have a lot of work to do, Mr. Holstron. I look forward to seeing your proposals. Good evening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Remus Holstron: ""Looking forward to it, Mr. President. Remember: One Sord..."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "A mirror to the nationalism still stirring within Sordland, he offered a potent reminder of the complexities and divisions that we would need to navigate in the days to come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Behind me, I heard a familiar voice."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "As Remus Holstron disappeared back into the crowd, his parting words resonated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "A mirror to the nationalism still stirring within Sordlan..."*)

### Węzeł `[231]`
Mówca: **Remus Holstron**
> ""We'll speak soon. And remember, never lose sight of the iron cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Remus Holstron");"*)

### Węzeł `[232]`
Mówca: **Remus Holstron**
> ""Looking forward to it, Mr. President. Remember: One Sordland, One Nation, One Future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Remus Holstron");"*)

### Węzeł `[233]`
Mówca: **Remus Holstron**
> ""Remember, Mr. President: One Sordland, One Nation, One Future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Remus Holstron");"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Legislative", "Position_NotableMember_4", "Legislative_MansounLeke");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Legislative","Position_NotableMember_4","Legislative_MansounLeke");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Holsord_SecurityIncreased =..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My days in the Young Sords are long behind me now.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[157]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Remus Holstron: ""Once a Young Sord, always a Young Sord. That's how I fee..."*)

### Węzeł `[236]`
Mówca: **Remus Holstron**
> ""Once a Young Sord, always a Young Sord. That's how I feel, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Remus Holstron: ""My time in the Young Sords taught me a lot about the tru..."*)

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's been a long time, Comrade Circas.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Speech_Democracy_Conservative"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[144]` (Bernard Circas)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Bernard Circas: ""It has, President Rayne. But once a Red Youth, always a ..."*)

### Węzeł `[238]`
Mówca: **Bernard Circas**
> ""It has, President Rayne. But once a Red Youth, always a Red Youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Bernard Circas: "“I can't help but wonder how the winds of change will blo..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[240]`
Mówca: **Narrator**
> "He leveled a steel gaze at me, then broke into a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Remus Holstron: ""President Rayne. You have no idea how happy it makes me ..."*)
