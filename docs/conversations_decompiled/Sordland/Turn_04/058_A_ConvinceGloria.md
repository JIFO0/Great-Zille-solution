# Sordland/Turn04/A_ConvinceGloria

- **ID konwersacji:** `58`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Sordland/Turn_04/058_A_ConvinceGloria.md`
- **Liczba węzłów dialogowych:** 561
- **Liczba wyborów gracza:** 118

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[34]** Gloria Tory

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Country_Unrest`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Welfare_EducationPrivatization`
- `BaseGame.Prologue_Party_Congress_Soll`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Gloria_Law_Decrees_Default`
- `BaseGame.Reform_Gloria_Law_Honorary_Default`
- `BaseGame.Reform_Gloria_Law_Impeachment_Default`
- `BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Gloria_Law_Threshold_Default`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_Default`
- `BaseGame.Reform_Law_Honorary_NoImmunity`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Ministers_Assembly`
- `BaseGame.Reform_Law_Ministers_ConfidenceVote`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Threshold_8`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn04_P_Monica_Benfi_Speech`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Gloria_Law_Decrees_Default`
- `BaseGame.Reform_Gloria_Law_Honorary_Default`
- `BaseGame.Reform_Gloria_Law_Impeachment_Default`
- `BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Gloria_Law_Threshold_Default`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Decrees_Weaker`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_Default`
- `BaseGame.Reform_Law_Honorary_NoImmunity`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Assembly`
- `BaseGame.Reform_Law_Impeachment_Default`
- `BaseGame.Reform_Law_Impeachment_Harder`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Threshold_8`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Relations_Gloria_Promise_Justice`
- `BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled`
- `BaseGame.Turn04_P_Monica_Benfi_Speech`
- `BaseGameSupport.Journal_Turn04_Reforms_ConvincedGloria`
- `BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceGloria`
- `BaseGameSupport.News_Turn04_ST_BFFCallToNations`
- `BaseGameSupport.News_Turn04_ST_RayneStopsUnrest_Deal`
- `GameCondition.Turn04_A_Convince_Gloria`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[11]` | **""How are you doing, Mrs. Tory?""** | `[10]` **Narrator**: "On her gesture, I took a seat. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Gloria Tory**: ""I'm fine, Mr. Rayne. How are you?"" |
| `[13]` | **""I love what you did with the office.""** | `[10]` **Narrator**: "On her gesture, I took a seat. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Narrator**: "She smiled." |
| `[19]` | **""I'm fine too, thank you.""** | `[15]` **Gloria Tory**: ""I'm fine, Mr. Rayne. How are you?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Gloria Tory**: ""Anyway, let's keep this simple,..." |
| `[20]` | **""I'm very happy to see you, Mrs. Tory. It's been a while.""** | `[15]` **Gloria Tory**: ""I'm fine, Mr. Rayne. How are you?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Gloria Tory**: ""Indeed, Mr. President."" |
| `[21]` | **""As good as I can be.""** | `[15]` **Gloria Tory**: ""I'm fine, Mr. Rayne. How are you?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Gloria Tory**: ""That's what we all strive for."" |
| `[24]` | **""Not as good as you imagine.""** | `[442]` **Gloria Tory**: ""So. How does the presidential c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Gloria Tory**: ""I'm sure it doesn't give you ba..." |
| `[25]` | **""It's better, what can I say?""** | `[442]` **Gloria Tory**: ""So. How does the presidential c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Gloria Tory**: ""I'm sure it doesn't give you ba..." |
| `[26]` | **""The chair is fine, but the work that comes with it is insane.""** | `[442]` **Gloria Tory**: ""So. How does the presidential c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Gloria Tory**: ""Well, you knew about that, didn..." |
| `[30]` | **""The reforms are not against anyone. It's all in the name of democracy.""** | `[29]` **Gloria Tory**: ""I don't see why the backbone of..."<br>`[396]` **Gloria Tory**: ""I don't see why the backbone of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Gloria Tory**: ""In the name of democracy?"" |
| `[31]` | **""Mrs. Tory, I need you to help me here.""** | `[29]` **Gloria Tory**: ""I don't see why the backbone of..."<br>`[396]` **Gloria Tory**: ""I don't see why the backbone of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Gloria Tory**: ""So you want me to help you dest..." |
| `[32]` | **""My reforms are very critical for the future of Sordland, Mrs. Tory.""** | `[29]` **Gloria Tory**: ""I don't see why the backbone of..."<br>`[396]` **Gloria Tory**: ""I don't see why the backbone of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Gloria Tory**: ""They are certainly critical for..." |
| `[38]` | **""There is nothing personal about this, Mrs. Tory.""** | `[35]` **Gloria Tory**: ""Even though you owe everything ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Gloria Tory**: ""Whatever you intend to do, you ..." |
| `[39]` | **""I would never betray our party.""** | `[35]` **Gloria Tory**: ""Even though you owe everything ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Gloria Tory**: ""Whatever you intend to do, you ..." |
| `[40]` | **""How dare you suggest I never liked Soll? I'm a proud Sollist.""** | `[35]` **Gloria Tory**: ""Even though you owe everything ..." | `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false` | *Brak zmian stanu* | `[41]` **Gloria Tory**: ""You claim that, Mr. Rayne, but ..." |
| `[44]` | **""I'm sure we can make a deal.""** | `[43]` **Gloria Tory**: ""That's all I can say.""<br>`[56]` **Gloria Tory**: ""For your safety, I hope that no..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Gloria Tory**: ""I'm not so sure about that.""<br>`[135]` **Gloria Tory**: ""Let's see if we can."" |
| `[48]` | **""Perhaps I could change your thoughts on the matter...with some well placed invest..."** | `[43]` **Gloria Tory**: ""That's all I can say.""<br>`[130]` **Gloria Tory**: ""That's what I think."" | `Variable["BaseGame.PersonalWealth"] >= 1` | *Brak zmian stanu* | `[55]` **Gloria Tory**: ""You think you can bribe me, Mr...." |
| `[49]` | **""You must understand that these reforms are a necessity. Let me explain.""** | `[43]` **Gloria Tory**: ""That's all I can say.""<br>`[56]` **Gloria Tory**: ""For your safety, I hope that no..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Gloria Tory**: ""How?"" |
| `[51]` | **""We need these reforms to fix our problems with the unrestricted power of the Supr..."** | `[50]` **Gloria Tory**: ""How?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Gloria Tory**: ""The Supreme Court is already do..." |
| `[52]` | **""The people of Sordland demanded change. The USP must give them what they want. We..."** | `[50]` **Gloria Tory**: ""How?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Gloria Tory**: ""I am aware that our popularity ..." |
| `[53]` | **""The USP is a party that knows how to react in changing times. We must lead the na..."** | `[50]` **Gloria Tory**: ""How?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Gloria Tory**: ""That's for the party to decide...." |
| `[67]` | **""I have no deal with anyone.""** | `[62]` **Gloria Tory**: ""You must know this will mean br..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Gloria Tory**: ""I don't know how your acts can ..." |
| `[68]` | **""You're pointing fingers without even thinking.""** | `[62]` **Gloria Tory**: ""You must know this will mean br..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Gloria Tory**: ""I don't know how your acts can ..." |
| `[69]` | **""The decrease is important to democratize our elections.""** | `[62]` **Gloria Tory**: ""You must know this will mean br..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Gloria Tory**: ""I don't know how your acts can ..." |
| `[70]` | **""I can reconsider the decrease in the threshold.""** | `[62]` **Gloria Tory**: ""You must know this will mean br..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Gloria Tory**: ""Oh, you will *reconsider*?"" |
| `[78]` | **""Yes, I'll remove the change to the threshold." [CHANGE THE REFORM]"** | `[80]` **Gloria Tory**: ""I don't know what to say before..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] ...` | `[84]` **Gloria Tory**: ""That's a step in the right dire..." |
| `[79]` | **""Will that ensure your support?""** | `[95]` **Gloria Tory**: ""I cannot allow you to destroy o..."<br>`[96]` **Gloria Tory**: ""I'd rather leave the threshold ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Gloria Tory**: ""I don't know what to say before..." |
| `[81]` | **""The same goes for me.""** | `[80]` **Gloria Tory**: ""I don't know what to say before..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Gloria Tory**: ""All I can promise is that the c..."<br>`[83]` **Gloria Tory**: ""I don't know if I can promise a..." |
| `[82]` | **""First I need to know if I'll have your support.""** | `[80]` **Gloria Tory**: ""I don't know what to say before..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Gloria Tory**: ""All I can promise is that the c..."<br>`[83]` **Gloria Tory**: ""I don't know if I can promise a..." |
| `[86]` | **""Very well. I'll remove the change to the threshold." [CHANGE THE REFORM]"** | `[95]` **Gloria Tory**: ""I cannot allow you to destroy o..."<br>`[96]` **Gloria Tory**: ""I'd rather leave the threshold ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] ...` | `[84]` **Gloria Tory**: ""That's a step in the right dire..." |
| `[97]` | **""That is not up to you, Mrs. Tory. My proposed threshold stays.""** | `[95]` **Gloria Tory**: ""I cannot allow you to destroy o..."<br>`[96]` **Gloria Tory**: ""I'd rather leave the threshold ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[556]` **Gloria Tory**: ""Then we are at an impasse.""<br>`[110]` **Gloria Tory**: ""That's too bad. Yet you still w..." |
| `[102]` | **""Fine, I'll remove the change to the threshold." [CHANGE THE REFORM]"** | `[101]` **Gloria Tory**: ""All I can promise is that the c..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] ...` | `[84]` **Gloria Tory**: ""That's a step in the right dire..." |
| `[103]` | **""I cannot promise that.""** | `[101]` **Gloria Tory**: ""All I can promise is that the c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Gloria Tory**: ""All right, Mr. President. I'm s..." |
| `[120]` | **""These reforms are very critical for the future of Sordland, Mrs. Tory.""** | `[119]` **Gloria Tory**: ""I don't see why the backbone of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Gloria Tory**: ""I tend to disagree."" |
| `[121]` | **""Mrs. Tory, I need you to help me here.""** | `[119]` **Gloria Tory**: ""I don't see why the backbone of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Gloria Tory**: ""I don't know if I can be of any..." |
| `[122]` | **""We need these reforms for our democracy.""** | `[119]` **Gloria Tory**: ""I don't see why the backbone of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Gloria Tory**: ""Democracy?"" |
| `[144]` | **""This is a shame. I was hoping we could work together.""** | `[145]` **Gloria Tory**: ""You want to punish him for the ..."<br>`[189]` **Gloria Tory**: ""Isn't it? You have promised to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Gloria Tory**: ""So was I, Mr. President. I reme..."<br>`[199]` **Gloria Tory**: ""Somehow I always knew it wasn't..." |
| `[146]` | **""I have no intention of putting Colonel Soll on trial.""** | `[145]` **Gloria Tory**: ""You want to punish him for the ..."<br>`[189]` **Gloria Tory**: ""Isn't it? You have promised to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Gloria Tory**: ""Then why are you taking away hi..."<br>`[194]` **Gloria Tory**: ""Then why are you taking his imm..." |
| `[147]` | **""This is not about Soll.""** | `[145]` **Gloria Tory**: ""You want to punish him for the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Gloria Tory**: ""Isn't it? You have promised to ..." |
| `[153]` | **""Why are you against all this, Mrs. Tory? I was thinking we could work together.""** | `[152]` **Gloria Tory**: ""You can't just target our found..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Gloria Tory**: ""I'm trying my best to work with..." |
| `[154]` | **""This is not about him.""** | `[152]` **Gloria Tory**: ""You can't just target our found..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Gloria Tory**: ""I'm sure it isn't. It must be a..." |
| `[155]` | **""Fine. I'll remove the changes to the Member of Honor laws from the proposal." [CH..."** | `[152]` **Gloria Tory**: ""You can't just target our found..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] =...` | `[165]` **Gloria Tory**: ""Great. Now, we can start talkin..." |
| `[158]` | **""Fine. I'll remove the changes to the Member of Honor laws from the proposal." [CH..."** | `[157]` **Gloria Tory**: ""So, you're not removing the cla..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] =...` | `[165]` **Gloria Tory**: ""Great. Now, we can start talkin..." |
| `[159]` | **""No. We could talk about the other clauses instead.""** | `[157]` **Gloria Tory**: ""So, you're not removing the cla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Gloria Tory**: ""It seems you don't understand."" |
| `[188]` | **""What makes you think that I don't respect him?""** | `[145]` **Gloria Tory**: ""You want to punish him for the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Gloria Tory**: ""Are you seriously asking me thi..." |
| `[206]` | **""The Member of Honor laws are unnecessary and undemocratic. This is not about Soll.""** | `[190]` **Gloria Tory**: ""Then why are you taking away hi..."<br>`[194]` **Gloria Tory**: ""Then why are you taking his imm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Gloria Tory**: ""Soll is the only Member of Hono..." |
| `[207]` | **""How about you answer me this: Why did Soll grant himself absolute immunity and pr..."** | `[190]` **Gloria Tory**: ""Then why are you taking away hi..."<br>`[194]` **Gloria Tory**: ""Then why are you taking his imm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Gloria Tory**: ""Maybe it was a security mechani..." |
| `[208]` | **""Let's calm down. I am here to listen to your concerns.""** | `[190]` **Gloria Tory**: ""Then why are you taking away hi..."<br>`[194]` **Gloria Tory**: ""Then why are you taking his imm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Gloria Tory**: ""Well, I've already stated my co..." |
| `[209]` | **""What are you talking about? There is no *agenda*.""** | `[189]` **Gloria Tory**: ""Isn't it? You have promised to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Gloria Tory**: ""Oh, I'm sure there isn't."" |
| `[211]` | **""It was different back then.""** | `[195]` **Gloria Tory**: ""So was I, Mr. President. I reme..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Gloria Tory**: ""I know it very well."" |
| `[212]` | **""Everything is politics, Mrs. Tory. You of all people must know this.""** | `[195]` **Gloria Tory**: ""So was I, Mr. President. I reme..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Gloria Tory**: ""I know it very well."" |
| `[213]` | **""Let's calm down. I am here to listen to your concerns.""** | `[195]` **Gloria Tory**: ""So was I, Mr. President. I reme..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Gloria Tory**: ""Well, I've already stated my co..." |
| `[220]` | **""Look, I promise that we won't touch him. But these ancient laws should be removed.""** | `[200]` **Gloria Tory**: ""I expected that you would go th..."<br>`[214]` **Gloria Tory**: ""Well, I've already stated my co..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Gloria Tory**: ""Fine. Let's talk about your oth..." |
| `[221]` | **""You win, Mrs. Tory. If this earns me your support, I will remove this point from ..."** | `[200]` **Gloria Tory**: ""I expected that you would go th..."<br>`[214]` **Gloria Tory**: ""Well, I've already stated my co..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] =...` | `[228]` **Gloria Tory**: ""Great. Now, we can start talking."" |
| `[222]` | **""Spare me your sarcasm.""** | `[216]` **Gloria Tory**: ""Oh, I'm sure there isn't."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Gloria Tory**: ""Anyway... I am not going to dra..." |
| `[223]` | **""Then why are you so surprised?""** | `[200]` **Gloria Tory**: ""I expected that you would go th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Gloria Tory**: ""Anyway... I am not going to dra..." |
| `[224]` | **""Come on, let's try to find some common ground.""** | `[200]` **Gloria Tory**: ""I expected that you would go th..."<br>`[214]` **Gloria Tory**: ""Well, I've already stated my co..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Gloria Tory**: ""Fine. Let's talk about your oth..." |
| `[227]` | **""Fine. I'll remove the changes to the Member of Honor laws from the proposal." [CH..."** | `[210]` **Gloria Tory**: ""Anyway... I am not going to dra..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] =...` | `[228]` **Gloria Tory**: ""Great. Now, we can start talking."" |
| `[246]` | **""It seems our understanding of democracy is very different.""** | `[243]` **Gloria Tory**: ""I don't see anything *democrati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Gloria Tory**: ""Looks like it."" |
| `[247]` | **""This will benefit the party.""** | `[243]` **Gloria Tory**: ""I don't see anything *democrati..."<br>`[427]` **Gloria Tory**: ""I don't see any real reform her..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[253]` **Gloria Tory**: ""Who are you kidding? This propo..."<br>`[254]` **Gloria Tory**: ""I continue to disagree."" |
| `[248]` | **""What I see is a bright future for Sordland. We need to be united.""** | `[243]` **Gloria Tory**: ""I don't see anything *democrati..."<br>`[427]` **Gloria Tory**: ""I don't see any real reform her..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[253]` **Gloria Tory**: ""Who are you kidding? This propo..."<br>`[254]` **Gloria Tory**: ""I continue to disagree."" |
| `[249]` | **""Let's change the topic and discuss how I can make you and the conservatives happy.""** | `[243]` **Gloria Tory**: ""I don't see anything *democrati..."<br>`[427]` **Gloria Tory**: ""I don't see any real reform her..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Gloria Tory**: ""By listening to our concerns an..." |
| `[258]` | **""Mrs. Tory, please try to understand me. I cannot give concessions now.""** | `[257]` **Gloria Tory**: ""So what are you thinking about?..."<br>`[421]` **Gloria Tory**: ""I can't support you giving your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Narrator**: "She raised an eyebrow and then t..." |
| `[268]` | **""I will remove the changes about the impeachment of the presidents." [CHANGE THE R..."** | `[257]` **Gloria Tory**: ""So what are you thinking about?..."<br>`[409]` **Gloria Tory**: ""Then there will be no further d..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] == false` | `Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"...` | `[272]` **Gloria Tory**: ""Finally. The proposal is starti..." |
| `[269]` | **""You're right. I will not strengthen presidential decrees. Let's keep it as it is...."** | `[257]` **Gloria Tory**: ""So what are you thinking about?..."<br>`[409]` **Gloria Tory**: ""Then there will be no further d..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Decrees_Default"] == false` | `Variable["BaseGame.Reform_Gloria_Law_Decrees_Default"] = ...` | `[271]` **Gloria Tory**: ""That is certainly a step in the..." |
| `[270]` | **""Fine. We will not touch the immunity of the Justices. Let's remove that point." [..."** | `[257]` **Gloria Tory**: ""So what are you thinking about?..."<br>`[409]` **Gloria Tory**: ""Then there will be no further d..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false  and  Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] == false` | `Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_D...` | `[273]` **Gloria Tory**: ""Finally. The proposal is starti..." |
| `[285]` | **""You are right. That is one risky topic. I will remove it." [CHANGE THE REFORM]"** | `[280]` **Gloria Tory**: ""And there is no way that the As..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] =...` | `[288]` **Gloria Tory**: ""I'm glad we are on the same page."" |
| `[286]` | **""You can believe what you will, Mrs. Tory. Just tell me if you will give us suppor..."** | `[280]` **Gloria Tory**: ""And there is no way that the As..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Gloria Tory**: ""My conscience doesn't allow me ..."<br>`[284]` **Gloria Tory**: ""You are a stubborn man. But any..."<br>*(oraz 1 innych odgałęzień)* |
| `[287]` | **""You might be right but that will not stop me from trying. I wish you'd join me in..."** | `[280]` **Gloria Tory**: ""And there is no way that the As..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Gloria Tory**: ""My conscience doesn't allow me ..."<br>`[284]` **Gloria Tory**: ""You are a stubborn man. But any..."<br>*(oraz 1 innych odgałęzień)* |
| `[301]` | **""If that's going to assure your support, you have my word.""** | `[300]` **Gloria Tory**: ""Put my name at the top of the l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Gloria Tory**: ""I'll hold you to that promise."" |
| `[302]` | **""That's it? That's easy. Consider it done.""** | `[300]` **Gloria Tory**: ""Put my name at the top of the l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[308]` **Gloria Tory**: ""No need to flaunt, Mr. President."" |
| `[303]` | **""That's a deal, Mrs. Tory. I'll expect your votes in return.""** | `[300]` **Gloria Tory**: ""Put my name at the top of the l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Gloria Tory**: ""Good."" |
| `[304]` | **""I can't do that.""** | `[300]` **Gloria Tory**: ""Put my name at the top of the l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[557]` **Gloria Tory**: ""Then we are at an impasse."" |
| `[313]` | **""Glad to hear that, Mrs. Tory.""** | `[312]` **Gloria Tory**: ""I hope there won't be any surpr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Gloria Tory**: ""I just hope you won't continue ..."<br>`[338]` **Gloria Tory**: ""I just hope you won't flirt wit..."<br>*(oraz 1 innych odgałęzień)* |
| `[314]` | **""What surprises?""** | `[312]` **Gloria Tory**: ""I hope there won't be any surpr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[324]` **Gloria Tory**: ""We have to calculate every poss..."<br>`[327]` **Gloria Tory**: ""We have to calculate every poss..."<br>*(oraz 1 innych odgałęzień)* |
| `[315]` | **""Your lack of faith in me is disappointing.""** | `[312]` **Gloria Tory**: ""I hope there won't be any surpr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[324]` **Gloria Tory**: ""We have to calculate every poss..."<br>`[327]` **Gloria Tory**: ""We have to calculate every poss..."<br>*(oraz 1 innych odgałęzień)* |
| `[316]` | **""I assure you, there is nothing you should be concerned about.""** | `[312]` **Gloria Tory**: ""I hope there won't be any surpr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Gloria Tory**: ""I'll hold you to that promise."" |
| `[341]` | **""Signatures are not enough. We'll need all the votes from the USP.""** | `[340]` **Gloria Tory**: ""That will depend to some extent..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Gloria Tory**: ""Well, that's politics for you."" |
| `[342]` | **""Which policies make you concerned?""** | `[340]` **Gloria Tory**: ""That will depend to some extent..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Gloria Tory**: ""I am completely against your ef..."<br>`[353]` **Gloria Tory**: ""I am concerned about the Oligar..." |
| `[343]` | **""Thank you.""** | `[340]` **Gloria Tory**: ""That will depend to some extent..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Narrator**: "She smiled and nodded." |
| `[358]` | **""Don't worry. That won't happen.""** | `[354]` **Gloria Tory**: ""But we'll discuss that later. W..."<br>`[355]` **Gloria Tory**: ""We expect you to succeed where ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Gloria Tory**: ""Good."" |
| `[359]` | **""I can't promise anything. These decisions depend on the circumstances.""** | `[354]` **Gloria Tory**: ""But we'll discuss that later. W..."<br>`[355]` **Gloria Tory**: ""We expect you to succeed where ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[362]` **Gloria Tory**: ""For the sake of your reforms, y..." |
| `[360]` | **""I am not Alphonso.""** | `[354]` **Gloria Tory**: ""But we'll discuss that later. W..."<br>`[355]` **Gloria Tory**: ""We expect you to succeed where ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[363]` **Gloria Tory**: ""I know. That's why I want to se..."<br>`[367]` **Gloria Tory**: ""Yes. Different names, I guess."" |
| `[361]` | **""It will happen one way or another.""** | `[354]` **Gloria Tory**: ""But we'll discuss that later. W..."<br>`[355]` **Gloria Tory**: ""We expect you to succeed where ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[362]` **Gloria Tory**: ""For the sake of your reforms, y..." |
| `[377]` | **""I'll be expecting your wing's support, Mrs. Tory.""** | `[375]` **Gloria Tory**: ""But now I need to get back to m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Narrator**: "She only responded with a nod as..." |
| `[378]` | **""I understand. I'll leave you to it.""** | `[375]` **Gloria Tory**: ""But now I need to get back to m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Narrator**: "She only responded with a nod as..." |
| `[379]` | **""Goodbye, Mrs. Tory. Thank you.""** | `[375]` **Gloria Tory**: ""But now I need to get back to m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Narrator**: "She only responded with a nod as..." |
| `[384]` | **"Shake her hand."** | `[383]` **Narrator**: "She extended her hand to me for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[390]` **Gloria Tory**: ""This doesn't mean we won't be a..." |
| `[385]` | **"Walk away without shaking her hand."** | `[383]` **Narrator**: "She extended her hand to me for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[389]` **Gloria Tory**: ""What happened to manners?"" |
| `[386]` | **""I am not finished.""** | `[383]` **Narrator**: "She extended her hand to me for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Gloria Tory**: ""Please do not humiliate yoursel..." |
| `[387]` | **""I'm not going anywhere until you give me the signatures.""** | `[383]` **Narrator**: "She extended her hand to me for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Gloria Tory**: ""Please do not humiliate yoursel..." |
| `[397]` | **""You will give me the signatures. I don't care if it's willingly or not.""** | `[388]` **Gloria Tory**: ""Please do not humiliate yoursel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[400]` **Gloria Tory**: ""I'd rather not reply to that."" |
| `[398]` | **""Don't forget who you are talking to.""** | `[388]` **Gloria Tory**: ""Please do not humiliate yoursel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[400]` **Gloria Tory**: ""I'd rather not reply to that."" |
| `[399]` | **""Goodbye.""** | `[388]` **Gloria Tory**: ""Please do not humiliate yoursel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[392]` **Narrator**: "I left her room." |
| `[410]` | **""I can't give you what you want, Mrs. Tory.""** | `[409]` **Gloria Tory**: ""Then there will be no further d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[412]` **Gloria Tory**: ""Too bad. I thought we were clos..." |
| `[428]` | **""It seems our understanding of reform is very different.""** | `[427]` **Gloria Tory**: ""I don't see any real reform her..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Gloria Tory**: ""Looks like it."" |
| `[436]` | **""Good morning, Mrs. Tory.""** | `[8]` **Narrator**: "I knocked on the door and entered." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Gloria Tory**: ""Good to see you here, Mr. Rayne."" |
| `[437]` | **""Hello Gloria.""** | `[8]` **Narrator**: "I knocked on the door and entered." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Gloria Tory**: ""Good to see you here, Mr. Rayne."" |
| `[438]` | **""Here I am.""** | `[8]` **Narrator**: "I knocked on the door and entered." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Gloria Tory**: ""Good to see you here, Mr. Rayne."" |
| `[493]` | **""I will be expecting a lot from conservatives as well.""** | `[492]` **Gloria Tory**: ""The conservatives will be expec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[456]` **Gloria Tory**: ""Increasing the threshold to 15 ..."<br>`[311]` **Gloria Tory**: ""I can get you the signatures ne..." |
| `[494]` | **""Of course.""** | `[492]` **Gloria Tory**: ""The conservatives will be expec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[495]` **Gloria Tory**: ""Good."" |
| `[496]` | **""Whatever you need, Mrs. Tory.""** | `[492]` **Gloria Tory**: ""The conservatives will be expec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[495]` **Gloria Tory**: ""Good."" |
| `[506]` | **""No, this is too important to me. But what if I remove the change to the threshold..."** | `[157]` **Gloria Tory**: ""So, you're not removing the cla..." | `Variable["BaseGame.Reform_Law_Threshold_8"] == true  or  Variable["BaseGame.Reform_Law_Threshold_3"] == true` | `Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] ...` | `[507]` **Gloria Tory**: ""Good. Now, we can start talking."" |
| `[510]` | **""No. We could talk about the other clauses instead.""** | `[210]` **Gloria Tory**: ""Anyway... I am not going to dra..." | `(Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false` | *Brak zmian stanu* | `[509]` **Gloria Tory**: ""It seems you don't understand."" |
| `[514]` | **""You win. How about I remove the change to the threshold instead?" [CHANGE THE REF..."** | `[210]` **Gloria Tory**: ""Anyway... I am not going to dra..." | `Variable["BaseGame.Reform_Law_Threshold_8"] == true` | `Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] ...` | `[518]` **Gloria Tory**: ""Good. Now, we can start talking."" |
| `[522]` | **""What does he have to do with anything?""** | `[521]` **Gloria Tory**: ""We wouldn't want to upset him, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[526]` **Gloria Tory**: ""He's not the only person who wo..." |
| `[523]` | **""I don't care if he's upset.""** | `[521]` **Gloria Tory**: ""We wouldn't want to upset him, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[526]` **Gloria Tory**: ""He's not the only person who wo..." |
| `[524]` | **""Mrs. Tory, please. You're being unreasonable.""** | `[521]` **Gloria Tory**: ""We wouldn't want to upset him, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[526]` **Gloria Tory**: ""He's not the only person who wo..." |
| `[525]` | **""Fine. I'll have Monica taken off the schedule and let him speak.""** | `[521]` **Gloria Tory**: ""We wouldn't want to upset him, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[528]` **Gloria Tory**: ""Wonderful."" |
| `[532]` | **""No. I won't let my wife down like that.""** | `[527]` **Gloria Tory**: ""If you want conservative suppor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[533]` **Gloria Tory**: ""Tell me, why does she want to d..." |
| `[534]` | **""She wants to give Sordish women a voice.""** | `[533]` **Gloria Tory**: ""Tell me, why does she want to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[535]` **Gloria Tory**: ""So do I. But this is not the way."" |
| `[536]` | **""This isn't about her, it's about women's rights. I thought you'd understand.""** | `[527]` **Gloria Tory**: ""If you want conservative suppor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[537]` **Gloria Tory**: ""Believe me, I understand. More ..." |
| `[540]` | **""All right. I'll tell Monica the speech is off.""** | `[551]` **Gloria Tory**: ""Just let Mayor Leste have his l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[553]` **Gloria Tory**: ""Thank you. Trust me, it's for t..." |
| `[541]` | **""She wants First Lady to be more than just a ceremonial position.""** | `[533]` **Gloria Tory**: ""Tell me, why does she want to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[542]` **Gloria Tory**: ""And why should it be? What does..." |
| `[543]` | **""Does it matter? She's my wife. If it's important to her, it's important to me.""** | `[533]` **Gloria Tory**: ""Tell me, why does she want to d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[544]` **Gloria Tory**: ""As important as the change you ..." |
| `[546]` | **""That's unfair. Monica's been campaigning for women's rights since I met her.""** | `[545]` **Gloria Tory**: ""They'll see a shrill, hectoring..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[548]` **Gloria Tory**: ""I'm just telling you what other..." |
| `[547]` | **""You might have a point.""** | `[545]` **Gloria Tory**: ""They'll see a shrill, hectoring..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Gloria Tory**: ""Listen, I do believe the status..." |
| `[552]` | **""No. Monica will speak at the festival.""** | `[551]` **Gloria Tory**: ""Just let Mayor Leste have his l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[529]` **Gloria Tory**: ""Then we are at an impasse."" |
| `[554]` | **""You sound bitter. I'm sorry your path to the top wasn't as easy as hers.""** | `[545]` **Gloria Tory**: ""They'll see a shrill, hectoring..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[555]` **Gloria Tory**: ""It wasn't. But that has nothing..." |

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
  - -> `[3]` (*Narrator: "I arrived at the Grand National Assembly, which was only ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I arrived at the Grand National Assembly, which was only a five-minute drive away from the Palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_ST_BFFCallToNations = true"*)

### Węzeł `[4]`
Mówca: **Gloria Tory**
> ""Good to see you here, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "It was a small, neatly organised office. There were small..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Today, I had a private meeting with Gloria Tory, one of the leading figures of the USP, to get her approval for the proposal. She was also key in reaching 150 signatures to propose the new Constitution, as she had extensive control over our party's conservative and moderate wings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "As I walked through the corridors of the Grand National A..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "As I walked through the corridors of the Grand National Assembly, I was confronted by my memories of the historic building. Despite being a member of Assembly not long ago, it now felt like the distant past."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I walked into the left wing of the Assembly which current..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I walked into the left wing of the Assembly which currently acted as the quarters of the USP. Gloria's office was the first one inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I knocked on the door and entered."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "I knocked on the door and entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Player: ""Good morning, Mrs. Tory.""*)
  - -> `[437]` (*Player: ""Hello Gloria.""*)
  - -> `[438]` (*Player: ""Here I am.""*)

### Węzeł `[9]`
Mówca: **Narrator**
> "It was a small, neatly organised office. There were small figurines, photos and plants around the place. It had a homey feel, unlike my own Assembly office when I had worked there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "On her gesture, I took a seat. The chair was very uncomfo..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "On her gesture, I took a seat. The chair was very uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player: ""How are you doing, Mrs. Tory?""*)
  - -> `[13]` (*Player: ""I love what you did with the office.""*)

### Węzeł `[11]`
**[WYBÓR GRACZA: ""How are you doing, Mrs. Tory?""]** — Mówca: **Player**
> ""How are you doing, Mrs. Tory?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Gloria Tory: ""I'm fine, Mr. Rayne. How are you?""*)

### Węzeł `[12]`
Mówca: **Gloria Tory**
> ""We both know why we are here. You want me to give you my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Default == true"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""I love what you did with the office.""]** — Mówca: **Player**
> ""I love what you did with the office.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "She smiled."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Gloria Tory: ""*A woman's touch* they call it. Like men cannot have a s..."*)

### Węzeł `[15]`
Mówca: **Gloria Tory**
> ""I'm fine, Mr. Rayne. How are you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: ""I'm very happy to see you, Mrs. Tory. It's been a while.""*)
  - -> `[19]` (*Player: ""I'm fine too, thank you.""*)
  - -> `[21]` (*Player: ""As good as I can be.""*)

### Węzeł `[16]`
Mówca: **Gloria Tory**
> ""*A woman's touch* they call it. Like men cannot have a sense of tidiness or style.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Gloria Tory: ""...Which might actually be true.""*)

### Węzeł `[17]`
Mówca: **Gloria Tory**
> ""Anyway, let's keep this simple, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Threshold_3 == false || BaseGame.Ref..."*)

### Węzeł `[18]`
Mówca: **Gloria Tory**
> ""...Which might actually be true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Gloria Tory: ""Anyway, let's keep this simple, Mr. Rayne.""*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""I'm fine too, thank you.""]** — Mówca: **Player**
> ""I'm fine too, thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Gloria Tory: ""Anyway, let's keep this simple, Mr. Rayne.""*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I'm very happy to see you, Mrs. Tory. It's been a while.""]** — Mówca: **Player**
> ""I'm very happy to see you, Mrs. Tory. It's been a while.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Gloria Tory: ""Indeed, Mr. President.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""As good as I can be.""]** — Mówca: **Player**
> ""As good as I can be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Gloria Tory: ""That's what we all strive for.""*)

### Węzeł `[22]`
Mówca: **Gloria Tory**
> ""Indeed, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Narrator: "She smiled."*)

### Węzeł `[23]`
Mówca: **Gloria Tory**
> ""That's what we all strive for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Gloria Tory: ""Anyway, let's keep this simple, Mr. Rayne.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Not as good as you imagine.""]** — Mówca: **Player**
> ""Not as good as you imagine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[442]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Gloria Tory: ""I'm sure it doesn't give you back pains the way ours do.""*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""It's better, what can I say?""]** — Mówca: **Player**
> ""It's better, what can I say?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[442]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Gloria Tory: ""I'm sure it doesn't give you back pains the way ours do.""*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""The chair is fine, but the work that comes with it is insane.""]** — Mówca: **Player**
> ""The chair is fine, but the work that comes with it is insane.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[442]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Gloria Tory: ""Well, you knew about that, didn't you?""*)

### Węzeł `[27]`
Mówca: **Gloria Tory**
> ""Well, you knew about that, didn't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Gloria Tory: ""Anyway, let's keep this simple, Mr. Rayne.""*)

### Węzeł `[28]`
Mówca: **Gloria Tory**
> ""I'm sure it doesn't give you back pains the way ours do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Gloria Tory: ""Anyway, let's keep this simple, Mr. Rayne.""*)

### Węzeł `[29]`
Mówca: **Gloria Tory**
> ""I don't see why the backbone of the USP would support your rushed reforms. Don't you realize they go directly against the wishes of the founder of this party and the state?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""The reforms are not against anyone. It's all in the name..."*)
  - -> `[31]` (*Player: ""Mrs. Tory, I need you to help me here.""*)
  - -> `[32]` (*Player: ""My reforms are very critical for the future of Sordland,..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""The reforms are not against anyone. It's all in the name of democracy.""]** — Mówca: **Player**
> ""The reforms are not against anyone. It's all in the name of democracy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Gloria Tory), `[396]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Gloria Tory: ""In the name of democracy?""*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Mrs. Tory, I need you to help me here.""]** — Mówca: **Player**
> ""Mrs. Tory, I need you to help me here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Gloria Tory), `[396]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Gloria Tory: ""So you want me to help you destroy what our party has wo..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""My reforms are very critical for the future of Sordland, Mrs. Tory.""]** — Mówca: **Player**
> ""My reforms are very critical for the future of Sordland, Mrs. Tory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Gloria Tory), `[396]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Gloria Tory: ""They are certainly critical for destroying what our part..."*)

### Węzeł `[33]`
Mówca: **Gloria Tory**
> ""In the name of democracy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)

### Węzeł `[34]`
Mówca: **Gloria Tory**
> ""You'd like the USP to disintegrate, wouldn't you, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Gloria Tory: ""Even though you owe everything to Colonel Soll, I think ..."*)

### Węzeł `[35]`
Mówca: **Gloria Tory**
> ""Even though you owe everything to Colonel Soll, I think you never liked him, nor the party he built.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""There is nothing personal about this, Mrs. Tory.""*)
  - -> `[39]` (*Player: ""I would never betray our party.""*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)

### Węzeł `[36]`
Mówca: **Gloria Tory**
> ""So you want me to help you destroy what our party has worked so hard to build?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)

### Węzeł `[37]`
Mówca: **Gloria Tory**
> ""They are certainly critical for destroying what our party has worked so hard to build.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""There is nothing personal about this, Mrs. Tory.""]** — Mówca: **Player**
> ""There is nothing personal about this, Mrs. Tory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Gloria Tory: ""Whatever you intend to do, you will be facing quite the ..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""I would never betray our party.""]** — Mówca: **Player**
> ""I would never betray our party.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Gloria Tory: ""Whatever you intend to do, you will be facing quite the ..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""How dare you suggest I never liked Soll? I'm a proud Sollist.""]** — Mówca: **Player**
> ""How dare you suggest I never liked Soll? I'm a proud Sollist.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[35]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Gloria Tory: ""You claim that, Mr. Rayne, but the Sollists already know..."*)

### Węzeł `[41]`
Mówca: **Gloria Tory**
> ""You claim that, Mr. Rayne, but the Sollists already know who you are working with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Gloria Tory: ""Whatever you intend to do, you will be facing quite the ..."*)

### Węzeł `[42]`
Mówca: **Gloria Tory**
> ""Whatever you intend to do, you will be facing quite the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Gloria Tory: ""That's all I can say.""*)

### Węzeł `[43]`
Mówca: **Gloria Tory**
> ""That's all I can say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""I'm sure we can make a deal.""*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)
  - -> `[49]` (*Player: ""You must understand that these reforms are a necessity. ..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""I'm sure we can make a deal.""]** — Mówca: **Player**
> ""I'm sure we can make a deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Gloria Tory), `[56]` (Gloria Tory), `[130]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == false ||  BaseGa..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth >= 1)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: ""Perhaps I could change your thoughts on the matter...wit..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Perhaps I could change your thoughts on the matter...with some well placed investments?""]** — Mówca: **Player**
> ""Perhaps I could change your mind on the matter...with some well placed investments?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[43]` (Gloria Tory), `[130]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Gloria Tory: ""You think you can bribe me, Mr. President?""*)

### Węzeł `[49]`
**[WYBÓR GRACZA: ""You must understand that these reforms are a necessity. Let me explain.""]** — Mówca: **Player**
> ""You must understand that these reforms are a necessity. Let me explain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Gloria Tory), `[56]` (Gloria Tory), `[130]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Gloria Tory: ""How?""*)

### Węzeł `[50]`
Mówca: **Gloria Tory**
> ""How?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: ""We need these reforms to fix our problems with the unres..."*)
  - -> `[52]` (*Player: ""The people of Sordland demanded change. The USP must giv..."*)
  - -> `[53]` (*Player: ""The USP is a party that knows how to react in changing t..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""We need these reforms to fix our problems with the unrestricted power of the Supreme Court.""]** — Mówca: **Player**
> ""We need these reforms to fix our problems with the unrestricted power of the Supreme Court.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Gloria Tory: ""The Supreme Court is already doing what it can to preser..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""The people of Sordland demanded change. The USP must give them what they want. We need the people's support.""]** — Mówca: **Player**
> ""The people of Sordland demanded change. The USP must give them what they want. We need the people's support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Gloria Tory: ""I am aware that our popularity has been on the decline.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""The USP is a party that knows how to react in changing times. We must lead the nation into the future.""]** — Mówca: **Player**
> ""The USP is a party that knows how to react in changing times. We must lead the nation into the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Gloria Tory: ""That's for the party to decide. Not you.""*)

### Węzeł `[54]`
Mówca: **Gloria Tory**
> ""The Supreme Court is already doing what it can to preserve Soll's values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Gloria Tory: ""There is no problem here except the ones you are creatin..."*)

### Węzeł `[55]`
Mówca: **Gloria Tory**
> ""You think you can bribe me, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Gloria Tory: ""For your safety, I hope that nobody heard that. The wall..."*)

### Węzeł `[56]`
Mówca: **Gloria Tory**
> ""For your safety, I hope that nobody heard that. The walls here are not as thick as in your palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""I'm sure we can make a deal.""*)
  - -> `[49]` (*Player: ""You must understand that these reforms are a necessity. ..."*)

### Węzeł `[57]`
Mówca: **Gloria Tory**
> ""I'm not so sure about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Refor..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Reform_Law_Threshold_3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Refor..."*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Ref..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Reform_Law_Threshold_3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_8"] == true  or  Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Gloria Tory: ""Especially when you're trying to decrease the electoral ..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Reform_Law_Threshold_3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_8"] == true  or  Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)

### Węzeł `[61]`
Mówca: **Gloria Tory**
> ""Especially when you're trying to decrease the electoral threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Gloria Tory: ""You must know this will mean bringing the communists int..."*)

### Węzeł `[62]`
Mówca: **Gloria Tory**
> ""You must know this will mean bringing the communists into the Assembly. You probably have a deal with either them or... maybe the PFJP. Frens seemed to be positive about giving you support too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: ""The decrease is important to democratize our elections.""*)
  - -> `[67]` (*Player: ""I have no deal with anyone.""*)
  - -> `[68]` (*Player: ""You're pointing fingers without even thinking.""*)
  - -> `[70]` (*Player: ""I can reconsider the decrease in the threshold.""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true || BaseG..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Gloria Tory: ""Especially considering the fact that you're trying to ch..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "GloriaDiscussion"*)

### Węzeł `[66]`
Mówca: **Gloria Tory**
> ""Especially considering the fact that you're trying to change the Member of Honor laws. This is clearly a move against President Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaTalkAboutSoll]"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""I have no deal with anyone.""]** — Mówca: **Player**
> ""I have no deal with anyone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Gloria Tory: ""I don't know how your acts can even be justified inside ..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""You're pointing fingers without even thinking.""]** — Mówca: **Player**
> ""You're pointing fingers without even thinking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Gloria Tory: ""I don't know how your acts can even be justified inside ..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""The decrease is important to democratize our elections.""]** — Mówca: **Player**
> ""The decrease is important to democratize our elections.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Gloria Tory: ""I don't know how your acts can even be justified inside ..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: ""I can reconsider the decrease in the threshold.""]** — Mówca: **Player**
> ""I can reconsider the decrease in the threshold.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Gloria Tory: ""Oh, you will *reconsider*?""*)

### Węzeł `[71]`
Mówca: **Gloria Tory**
> ""I don't know how your acts can even be justified inside the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)

### Węzeł `[72]`
Mówca: **Gloria Tory**
> ""There is no problem here except the ones you are creating with Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == false ||  BaseGa..."*)

### Węzeł `[73]`
Mówca: **Gloria Tory**
> ""I am aware that our popularity has been on the decline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Gloria Tory: ""But I blame it on this administration, Mr. Rayne. Plus, ..."*)

### Węzeł `[74]`
Mówca: **Gloria Tory**
> ""But I blame it on this administration, Mr. Rayne. Plus, these reforms are not about the people, are they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == false ||  BaseGa..."*)

### Węzeł `[75]`
Mówca: **Gloria Tory**
> ""That's for the party to decide. Not you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == false ||  BaseGa..."*)

### Węzeł `[76]`
Mówca: **Gloria Tory**
> ""I seriously do not know if the conservatives would be willing to support you at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Refor..."*)

### Węzeł `[77]`
Mówca: **Gloria Tory**
> ""Oh, you will *reconsider*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""Yes, I'll remove the change to the threshold." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Yes, I'll remove the change to the threshold.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Threshold_Default = true"*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""Will that ensure your support?""]** — Mówca: **Player**
> ""Will that ensure your support?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Gloria Tory), `[96]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Gloria Tory: ""I don't know what to say before seeing a commitment from..."*)

### Węzeł `[80]`
Mówca: **Gloria Tory**
> ""I don't know what to say before seeing a commitment from you, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: ""Yes, I'll remove the change to the threshold." [CHANGE T..."*)
  - -> `[81]` (*Player: ""The same goes for me.""*)
  - -> `[82]` (*Player: ""First I need to know if I'll have your support.""*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""The same goes for me.""]** — Mówca: **Player**
> ""The same goes for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: ""First I need to know if I'll have your support.""]** — Mówca: **Player**
> ""First I need to know if I'll have your support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)

### Węzeł `[83]`
Mówca: **Gloria Tory**
> ""I don't know if I can promise anything before I see action from you. Especially with all these issues you're creating for the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)

### Węzeł `[84]`
Mówca: **Gloria Tory**
> ""That's a step in the right direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)

### Węzeł `[85]`
Mówca: **Gloria Tory**
> ""I'm sure it isn't. It must be about some other Member of Honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Gloria Tory: ""So, you're not removing the clause from the proposal?""*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Very well. I'll remove the change to the threshold." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Very well. I'll remove the change to the threshold.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Gloria Tory), `[96]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Threshold_Default = true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Gloria Tory: ""You'd like the USP to disintegrate, wouldn't you, Mr. Ra..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Gloria Tory: ""Even though you owe everything to Colonel Soll, I think ..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Gloria Tory: ""Decreasing the threshold to 3% is unacceptable. You will..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Gloria Tory: ""I do not support an election threshold of 8%. This sets ..."*)

### Węzeł `[93]`
Mówca: **Gloria Tory**
> ""Decreasing the threshold to 3% is unacceptable. You will be bringing all of the marginal parties into the Assembly and reducing our majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Gloria Tory: ""I cannot allow you to destroy our party. Either this poi..."*)

### Węzeł `[94]`
Mówca: **Gloria Tory**
> ""I do not support an election threshold of 8%. This sets a dangerous situation for us, as both the WPB and the CPS will gain more power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Gloria Tory: ""I'd rather leave the threshold as it is.""*)

### Węzeł `[95]`
Mówca: **Gloria Tory**
> ""I cannot allow you to destroy our party. Either this point is removed entirely or there will be no discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: ""Very well. I'll remove the change to the threshold." [CH..."*)
  - -> `[97]` (*Player: ""That is not up to you, Mrs. Tory. My proposed threshold ..."*)
  - -> `[79]` (*Player: ""Will that ensure your support?""*)

### Węzeł `[96]`
Mówca: **Gloria Tory**
> ""I'd rather leave the threshold as it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: ""Very well. I'll remove the change to the threshold." [CH..."*)
  - -> `[97]` (*Player: ""That is not up to you, Mrs. Tory. My proposed threshold ..."*)
  - -> `[79]` (*Player: ""Will that ensure your support?""*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""That is not up to you, Mrs. Tory. My proposed threshold stays.""]** — Mówca: **Player**
> ""That is not up to you, Mrs. Tory. My proposed threshold stays.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Gloria Tory), `[96]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Gloria Tory: ""All I can promise is that the conservatives will definit..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Gloria Tory: ""I don't know if I can promise anything before I see acti..."*)

### Węzeł `[101]`
Mówca: **Gloria Tory**
> ""All I can promise is that the conservatives will definitely oppose you unless you remove that clause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: ""Fine, I'll remove the change to the threshold." [CHANGE ..."*)
  - -> `[103]` (*Player: ""I cannot promise that.""*)

### Węzeł `[102]`
**[WYBÓR GRACZA: ""Fine, I'll remove the change to the threshold." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine, I'll remove the change to the threshold.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Threshold_Default = true"*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""I cannot promise that.""]** — Mówca: **Player**
> ""I cannot promise that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaFail]"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_3 == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Gloria Tory: ""Then we are at an impasse.""*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Gloria Tory: ""That's too bad. Yet you still want our support...""*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GloriaFail`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Gloria Tory: ""All right, Mr. President. I'm sorry I won't be able to h..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaFail]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GloriaFail"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaFail]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GloriaFail"*)

### Węzeł `[110]`
Mówca: **Gloria Tory**
> ""That's too bad. Yet you still want our support...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Gloria Tory: ""I don't know if I can promise anything before I see acti..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Threshold_3 == false || BaseGame.Reform_Law_Threshold_8 == false) && 
BaseGame.Reform_Law_Impeachment_Removed == false && BaseGame.Reform_Law_Decrees_Stronger == false && BaseGame.Reform_Law_Judges_Impeachment_Default == true && BaseGame.Reform_Law_Honorary_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Threshold_3 == false || BaseGame.Ref..."*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Threshold_3 == false || BaseGame.R..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Threshold_3 == false || BaseGame.Reform_Law_Threshold_8 == false) && 
BaseGame.Reform_Law_Impeachment_Removed == false && BaseGame.Reform_Law_Decrees_Stronger == false && BaseGame.Reform_Law_Judges_Impeachment_Default == true && BaseGame.Reform_Law_Honorary_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == false  or  Variable["BaseGame.Reform_Law_Threshold_8"] == false)  and  
Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == false  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Gloria Tory: ""We both know why you are here. You need my support.""*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Threshold_3 == false || BaseGame.Reform_Law_Threshold_8 == false) && 
BaseGame.Reform_Law_Impeachment_Removed == false && BaseGame.Reform_Law_Decrees_Stronger == false && BaseGame.Reform_Law_Judges_Impeachment_Default == true && BaseGame.Reform_Law_Honorary_Default == true
)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Threshold_3"] == false  or  Variable["BaseGame.Reform_Law_Threshold_8"] == false)  and  
Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == false  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == false ||  BaseGa..."*)

### Węzeł `[114]`
Mówca: **Gloria Tory**
> ""We both know why you are here. You need my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Gloria Tory: ""I reviewed your proposal in detail. It's a fine draft. Y..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == false ||  BaseGa..."*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_Default == false ||  Base..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == false  or  
Variable["BaseGame.Reform_Law_Honorary_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Gloria Tory: ""We both know why we are here. You want me to give you my..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == false  or  
Variable["BaseGame.Reform_Law_Honorary_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Gloria Tory: ""We both know why you are here. You want me to give you m..."*)

### Węzeł `[118]`
Mówca: **Gloria Tory**
> ""We both know why you are here. You want me to give you my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Gloria Tory: ""I don't see why the backbone of this party should suppor..."*)

### Węzeł `[119]`
Mówca: **Gloria Tory**
> ""I don't see why the backbone of this party should support your rushed reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""We need these reforms for our democracy.""*)
  - -> `[121]` (*Player: ""Mrs. Tory, I need you to help me here.""*)
  - -> `[120]` (*Player: ""These reforms are very critical for the future of Sordla..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""These reforms are very critical for the future of Sordland, Mrs. Tory.""]** — Mówca: **Player**
> ""These reforms are very critical for the future of Sordland, Mrs. Tory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Gloria Tory: ""I tend to disagree.""*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""Mrs. Tory, I need you to help me here.""]** — Mówca: **Player**
> ""Mrs. Tory, I need you to help me here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Gloria Tory: ""I don't know if I can be of any help.""*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""We need these reforms for our democracy.""]** — Mówca: **Player**
> ""We need these reforms for our democracy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Gloria Tory: ""Democracy?""*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: ""How dare you suggest I never liked Soll? I'm a proud Sol..."*)

### Węzeł `[126]`
Mówca: **Gloria Tory**
> ""Democracy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Gloria Tory: ""What you are doing seems more like a move against the Su..."*)

### Węzeł `[127]`
Mówca: **Gloria Tory**
> ""I don't know if I can be of any help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Gloria Tory: ""There are issues with the proposal.""*)

### Węzeł `[128]`
Mówca: **Gloria Tory**
> ""I tend to disagree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Gloria Tory: ""That's what I think.""*)

### Węzeł `[129]`
Mówca: **Gloria Tory**
> ""What you are doing seems more like a move against the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Gloria Tory: ""That's what I think.""*)

### Węzeł `[130]`
Mówca: **Gloria Tory**
> ""That's what I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""I'm sure we can make a deal.""*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)
  - -> `[49]` (*Player: ""You must understand that these reforms are a necessity. ..."*)

### Węzeł `[131]`
Mówca: **Gloria Tory**
> ""There are issues with the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Gloria Tory: ""That's what I think.""*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == false ||  BaseGa..."*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_Default == false ||  Base..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == false  or  
Variable["BaseGame.Reform_Law_Honorary_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Gloria Tory: ""I'm not so sure about that.""*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == false  or  
Variable["BaseGame.Reform_Law_Honorary_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Gloria Tory: ""Let's see if we can.""*)

### Węzeł `[135]`
Mówca: **Gloria Tory**
> ""Let's see if we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "GloriaDiscussion"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == false ||  BaseGa..."*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_Default == false ||  Base..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == false  or  
Variable["BaseGame.Reform_Law_Honorary_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Gloria Tory: ""I seriously do not know if the conservatives would be wi..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == false  or  
Variable["BaseGame.Reform_Law_Honorary_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Gloria Tory: ""I do not support this proposal the way it currently stan..."*)

### Węzeł `[139]`
Mówca: **Gloria Tory**
> ""I do not support this proposal the way it currently stands. But you seem to be willing to talk, so let's talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "GloriaDiscussion"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true || BaseG..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Gloria Tory: ""...But your changes to the Member of Honor laws are a ma..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaDiscussion]"*)

### Węzeł `[143]`
Mówca: **Gloria Tory**
> ""...But your changes to the Member of Honor laws are a major obstacle. We obviously can't condone any threats against Colonel Tarquin Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Gloria Tory: ""You want to punish him for the aggressive policies he pu..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA: ""This is a shame. I was hoping we could work together.""]** — Mówca: **Player**
> ""This is a shame. I was hoping we could work together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Gloria Tory), `[189]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Congress_Soll == true"*)

### Węzeł `[145]`
Mówca: **Gloria Tory**
> ""You want to punish him for the aggressive policies he pursued in the past? Is that the intention here? You can't win this fight, Mr. President. Soll built this republic in the midst of blood and chaos. He demands respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player: ""This is not about Soll.""*)
  - -> `[144]` (*Player: ""This is a shame. I was hoping we could work together.""*)
  - -> `[146]` (*Player: ""I have no intention of putting Colonel Soll on trial.""*)
  - -> `[188]` (*Player: ""What makes you think that I don't respect him?""*)

### Węzeł `[146]`
**[WYBÓR GRACZA: ""I have no intention of putting Colonel Soll on trial.""]** — Mówca: **Player**
> ""I have no intention of putting Colonel Soll on trial.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Gloria Tory), `[189]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)

### Węzeł `[147]`
**[WYBÓR GRACZA: ""This is not about Soll.""]** — Mówca: **Player**
> ""This is not about Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Gloria Tory: ""Isn't it? You have promised to reform our government bra..."*)

### Węzeł `[148]`
Mówca: **Gloria Tory**
> ""You should at least remove the changes to the Member of Honor laws, or there will be no further discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Gloria Tory: ""You can't just target our founder and expect our support..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true || BaseGam..."*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true || BaseG..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Gloria Tory: ""You should at least remove the changes to the Member of ..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaDiscussion]"*)

### Węzeł `[152]`
Mówca: **Gloria Tory**
> ""You can't just target our founder and expect our support. If this point is not removed, expect a grand opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Player: ""Fine. I'll remove the changes to the Member of Honor law..."*)
  - -> `[154]` (*Player: ""This is not about him.""*)
  - -> `[153]` (*Player: ""Why are you against all this, Mrs. Tory? I was thinking ..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: ""Why are you against all this, Mrs. Tory? I was thinking we could work together.""]** — Mówca: **Player**
> ""Why are you against all this, Mrs. Tory? I was thinking we could work together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Gloria Tory: ""I'm trying my best to work with you, Mr. President. Yet ..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA: ""This is not about him.""]** — Mówca: **Player**
> ""This is not about him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Gloria Tory: ""I'm sure it isn't. It must be about some other Member of..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: ""Fine. I'll remove the changes to the Member of Honor laws from the proposal." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I'll remove the changes to the Member of Honor laws from the proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Honorary_Default = true"*)

### Węzeł `[156]`
Mówca: **Gloria Tory**
> ""I'm trying my best to work with you, Mr. President. Yet you're not listening to your own party members.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Gloria Tory: ""So, you're not removing the clause from the proposal?""*)

### Węzeł `[157]`
Mówca: **Gloria Tory**
> ""So, you're not removing the clause from the proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player: ""Fine. I'll remove the changes to the Member of Honor law..."*)
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Refor..."*)
  - -> `[159]` (*Player: ""No. We could talk about the other clauses instead.""*)

### Węzeł `[158]`
**[WYBÓR GRACZA: ""Fine. I'll remove the changes to the Member of Honor laws from the proposal." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I'll remove the changes to the Member of Honor laws from the proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Honorary_Default = true"*)

### Węzeł `[159]`
**[WYBÓR GRACZA: ""No. We could talk about the other clauses instead.""]** — Mówca: **Player**
> ""No. We could talk about the other clauses instead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Gloria Tory: ""It seems you don't understand.""*)

### Węzeł `[160]`
Mówca: **Gloria Tory**
> ""It seems you don't understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaFail]"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaFail]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GloriaFail"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GloriaDiscussion`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_ConfidenceVote == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaDiscussion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "GloriaDiscussion"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaDiscussion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "GloriaDiscussion"*)

### Węzeł `[165]`
Mówca: **Gloria Tory**
> ""Great. Now, we can start talking for real.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaDiscussion]"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaDiscussion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "GloriaDiscussion"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Gloria Tory: ""...But not quite enough.""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "She took a long look at the proposal on her table."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Gloria Tory: ""The fact that you are removing the possibility of your i..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Stronger == true)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Gloria Tory: ""It is also unbelievable that you are strengthening the a..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_ConfidenceVote == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_ConfidenceVote == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_ConfidenceVote == true )"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_ConfidenceVote == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_ConfidenceVote"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Gloria Tory: ""I must say that I like the changes regarding the appoint..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_ConfidenceVote == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_ConfidenceVote"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Assembly == true"*)

### Węzeł `[179]`
Mówca: **Gloria Tory**
> ""I must say that I wouldn't have given the Assembly the right to nominate ministers. This can create a lot of problems for future governments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Gloria Tory: ""But moving on...""*)

### Węzeł `[180]`
Mówca: **Gloria Tory**
> ""I must say that I like the changes regarding the appointment of ministers. That's one positive aspect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Gloria Tory: ""But moving on...""*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Gloria Tory: ""It is unbelievable that you are taking away the immunity..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Assembly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Assembly == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Assembly == true)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Assembly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Gloria Tory: ""I must say that I wouldn't have given the Assembly the r..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Assembly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Gloria Tory: ""I must say that I expected some sort of a reform regardi..."*)

### Węzeł `[187]`
Mówca: **Gloria Tory**
> ""I must say that I expected some sort of a reform regarding the appointment of ministers. I am surprised that you're ignoring the large support behind that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Gloria Tory: ""But moving on...""*)

### Węzeł `[188]`
**[WYBÓR GRACZA: ""What makes you think that I don't respect him?""]** — Mówca: **Player**
> ""What makes you think that I don't respect him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Gloria Tory: ""Are you seriously asking me this, Mr. President? I thoug..."*)

### Węzeł `[189]`
Mówca: **Gloria Tory**
> ""Isn't it? You have promised to reform our government branches, yet your proposal points to another agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player: ""What are you talking about? There is no *agenda*.""*)
  - -> `[144]` (*Player: ""This is a shame. I was hoping we could work together.""*)
  - -> `[146]` (*Player: ""I have no intention of putting Colonel Soll on trial.""*)

### Węzeł `[190]`
Mówca: **Gloria Tory**
> ""Then why are you taking away his title? Why strike against an old man who has fought all his life for our country?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player: ""The Member of Honor laws are unnecessary and undemocrati..."*)
  - -> `[207]` (*Player: ""How about you answer me this: Why did Soll grant himself..."*)
  - -> `[208]` (*Player: ""Let's calm down. I am here to listen to your concerns.""*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Gloria Tory: ""Then why are you taking away his title? Why strike again..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Gloria Tory: ""Then why are you taking his immunity away? He isn't even..."*)

### Węzeł `[194]`
Mówca: **Gloria Tory**
> ""Then why are you taking his immunity away? He isn't even a public figure since he retired from politics. What prompted you to include this in your so called 'democracy' package?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player: ""The Member of Honor laws are unnecessary and undemocrati..."*)
  - -> `[207]` (*Player: ""How about you answer me this: Why did Soll grant himself..."*)
  - -> `[208]` (*Player: ""Let's calm down. I am here to listen to your concerns.""*)

### Węzeł `[195]`
Mówca: **Gloria Tory**
> ""So was I, Mr. President. I remember when you proudly defended the USP's values. Yet it seems that it was just politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player: ""It was different back then.""*)
  - -> `[212]` (*Player: ""Everything is politics, Mrs. Tory. You of all people mus..."*)
  - -> `[213]` (*Player: ""Let's calm down. I am here to listen to your concerns.""*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Congress_Soll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Congress_Soll == true"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Congress_Soll == true)"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Congress_Soll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Congress_Soll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Gloria Tory: ""So was I, Mr. President. I remember when you proudly def..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Congress_Soll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Congress_Soll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Gloria Tory: ""Somehow I always knew it wasn't going to happen. I still..."*)

### Węzeł `[199]`
Mówca: **Gloria Tory**
> ""Somehow I always knew it wasn't going to happen. I still remember how you backstabbed President Soll in favor of the incompetency of Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Gloria Tory: ""I expected that you would go this route already.""*)

### Węzeł `[200]`
Mówca: **Gloria Tory**
> ""I expected that you would go this route already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player: ""Look, I promise that we won't touch him. But these ancie..."*)
  - -> `[221]` (*Player: ""You win, Mrs. Tory. If this earns me your support, I wil..."*)
  - -> `[223]` (*Player: ""Then why are you so surprised?""*)
  - -> `[224]` (*Player: ""Come on, let's try to find some common ground.""*)

### Węzeł `[201]`
Mówca: **Gloria Tory**
> ""Are you seriously asking me this, Mr. President? I thought we were talking about *your* proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Congress_Soll == true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Congress_Soll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Congress_Soll == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Congress_Soll == true)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Congress_Soll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Congress_Soll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Gloria Tory: ""Anyway... I am not going to drag this out for any longer..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Congress_Soll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Congress_Soll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Gloria Tory: ""Don't forget that I was there when you backstabbed Presi..."*)

### Węzeł `[205]`
Mówca: **Gloria Tory**
> ""Don't forget that I was there when you backstabbed President Soll in favour of the incompetency of Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Gloria Tory: ""I expected that you would go this route already.""*)

### Węzeł `[206]`
**[WYBÓR GRACZA: ""The Member of Honor laws are unnecessary and undemocratic. This is not about Soll.""]** — Mówca: **Player**
> ""The Member of Honor laws are unnecessary and undemocratic. This is not about Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Gloria Tory), `[194]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Gloria Tory: ""Soll is the only Member of Honor. This is automatically ..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA: ""How about you answer me this: Why did Soll grant himself absolute immunity and protection? What is he scared of?""]** — Mówca: **Player**
> ""How about you answer me this: Why did Soll grant himself absolute immunity and protection? What is he scared of?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Gloria Tory), `[194]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Gloria Tory: ""Maybe it was a security mechanism against traitors like...""*)

### Węzeł `[208]`
**[WYBÓR GRACZA: ""Let's calm down. I am here to listen to your concerns.""]** — Mówca: **Player**
> ""Let's calm down. I am here to listen to your concerns.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Gloria Tory), `[194]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Gloria Tory: ""Well, I've already stated my concerns, Mr. President. Le..."*)

### Węzeł `[209]`
**[WYBÓR GRACZA: ""What are you talking about? There is no *agenda*.""]** — Mówca: **Player**
> ""What are you talking about? There is no *agenda*.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Gloria Tory: ""Oh, I'm sure there isn't.""*)

### Węzeł `[210]`
Mówca: **Gloria Tory**
> ""Anyway... I am not going to drag this out for any longer. Will you listen to the party or keep pushing your own agenda?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player: ""Fine. I'll remove the changes to the Member of Honor law..."*)
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8 == true"*)

### Węzeł `[211]`
**[WYBÓR GRACZA: ""It was different back then.""]** — Mówca: **Player**
> ""It was different back then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Gloria Tory: ""I know it very well.""*)

### Węzeł `[212]`
**[WYBÓR GRACZA: ""Everything is politics, Mrs. Tory. You of all people must know this.""]** — Mówca: **Player**
> ""Everything is politics, Mrs. Tory. You of all people must know this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Gloria Tory: ""I know it very well.""*)

### Węzeł `[213]`
**[WYBÓR GRACZA: ""Let's calm down. I am here to listen to your concerns.""]** — Mówca: **Player**
> ""Let's calm down. I am here to listen to your concerns.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Gloria Tory: ""Well, I've already stated my concerns, Mr. President. Le..."*)

### Węzeł `[214]`
Mówca: **Gloria Tory**
> ""Well, I've already stated my concerns, Mr. President. Let's listen to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player: ""Look, I promise that we won't touch him. But these ancie..."*)
  - -> `[221]` (*Player: ""You win, Mrs. Tory. If this earns me your support, I wil..."*)
  - -> `[224]` (*Player: ""Come on, let's try to find some common ground.""*)

### Węzeł `[215]`
Mówca: **Gloria Tory**
> ""I know it very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player: ""Look, I promise that we won't touch him. But these ancie..."*)
  - -> `[221]` (*Player: ""You win, Mrs. Tory. If this earns me your support, I wil..."*)
  - -> `[224]` (*Player: ""Come on, let's try to find some common ground.""*)

### Węzeł `[216]`
Mówca: **Gloria Tory**
> ""Oh, I'm sure there isn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player: ""Spare me your sarcasm.""*)
  - -> `[220]` (*Player: ""Look, I promise that we won't touch him. But these ancie..."*)
  - -> `[221]` (*Player: ""You win, Mrs. Tory. If this earns me your support, I wil..."*)
  - -> `[224]` (*Player: ""Come on, let's try to find some common ground.""*)

### Węzeł `[217]`
Mówca: **Gloria Tory**
> ""Soll is the only Member of Honor. This is automatically about him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player: ""Look, I promise that we won't touch him. But these ancie..."*)
  - -> `[221]` (*Player: ""You win, Mrs. Tory. If this earns me your support, I wil..."*)
  - -> `[224]` (*Player: ""Come on, let's try to find some common ground.""*)

### Węzeł `[218]`
Mówca: **Gloria Tory**
> ""Maybe it was a security mechanism against traitors like...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "She cleared her throat."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "She cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Gloria Tory: ""Anyway... I am not going to drag this out for any longer..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA: ""Look, I promise that we won't touch him. But these ancient laws should be removed.""]** — Mówca: **Player**
> ""Look, I promise that we won't touch him. But these ancient laws should be removed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Gloria Tory), `[214]` (Gloria Tory), `[215]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Gloria Tory: ""Fine. Let's talk about your other points.""*)

### Węzeł `[221]`
**[WYBÓR GRACZA: ""You win, Mrs. Tory. If this earns me your support, I will remove this point from the proposal." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""You win, Mrs. Tory. If this earns me your support, I will remove this point from the proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Gloria Tory), `[214]` (Gloria Tory), `[215]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Honorary_Default = true"*)

### Węzeł `[222]`
**[WYBÓR GRACZA: ""Spare me your sarcasm.""]** — Mówca: **Player**
> ""Spare me your sarcasm.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Gloria Tory: ""Anyway... I am not going to drag this out for any longer..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA: ""Then why are you so surprised?""]** — Mówca: **Player**
> ""Then why are you so surprised?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Gloria Tory: ""Anyway... I am not going to drag this out for any longer..."*)

### Węzeł `[224]`
**[WYBÓR GRACZA: ""Come on, let's try to find some common ground.""]** — Mówca: **Player**
> ""Come on, let's try to find some common ground.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Gloria Tory), `[214]` (Gloria Tory), `[215]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Gloria Tory: ""Fine. Let's talk about your other points.""*)

### Węzeł `[225]`
Mówca: **Gloria Tory**
> ""Fine. Let's talk about your other points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaDiscussion]"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaDiscussion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "GloriaDiscussion"*)

### Węzeł `[227]`
**[WYBÓR GRACZA: ""Fine. I'll remove the changes to the Member of Honor laws from the proposal." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I'll remove the changes to the Member of Honor laws from the proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Honorary_Default = true"*)

### Węzeł `[228]`
Mówca: **Gloria Tory**
> ""Great. Now, we can start talking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaDiscussion]"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaDiscussion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "GloriaDiscussion"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GloriaTalkAboutSoll`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Gloria Tory: ""You want to punish him for the aggressive policies he pu..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaTalkAboutSoll]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "GloriaTalkAboutSoll"*)

### Węzeł `[232]`
Mówca: **Gloria Tory**
> ""But moving on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[233]`
Mówca: **Gloria Tory**
> ""It is unbelievable that you are taking away the immunity of the Justices. A big mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true"*)

### Węzeł `[234]`
Mówca: **Gloria Tory**
> ""Even though the Assembly is elected by the people, it does not hold enough judicial insight and neutrality to impeach Justices. The separation of powers shouldn't be damaged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Gloria Tory: ""This is something I cannot accept.""*)

### Węzeł `[235]`
Mówca: **Gloria Tory**
> ""It is also unbelievable that you are strengthening the already powerful presidential decrees. I don't know what your plans are, but I can easily say that I don't like it. This can go in a very bad direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[236]`
Mówca: **Gloria Tory**
> ""The fact that you are removing the possibility of your impeachment is not right. Giving yourself absolute immunity while in office is too bold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Gloria Tory: ""I don't see anything *democratic* here, Mr. President. C..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Gloria Tory: ""On top of all that, you are removing the possibility of ..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true || BaseGa..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true)"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Gloria Tory: ""Not to mention that you are removing presidential decree..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[243]`
Mówca: **Gloria Tory**
> ""I don't see anything *democratic* here, Mr. President. Can you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player: ""It seems our understanding of democracy is very different.""*)
  - -> `[247]` (*Player: ""This will benefit the party.""*)
  - -> `[248]` (*Player: ""What I see is a bright future for Sordland. We need to b..."*)
  - -> `[249]` (*Player: ""Let's change the topic and discuss how I can make you an..."*)

### Węzeł `[244]`
Mówca: **Gloria Tory**
> ""Not to mention that you are removing presidential decrees. I don't know who pressured you into that, but clearly that person has more influence on you than anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[245]`
Mówca: **Gloria Tory**
> ""On top of all that, you are removing the possibility of your own impeachment. Giving yourself absolute immunity while in office. That's bold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Gloria Tory: ""I don't see anything *democratic* here, Mr. President. C..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA: ""It seems our understanding of democracy is very different.""]** — Mówca: **Player**
> ""It seems our understanding of democracy is very different.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Gloria Tory: ""Looks like it.""*)

### Węzeł `[247]`
**[WYBÓR GRACZA: ""This will benefit the party.""]** — Mówca: **Player**
> ""This will benefit the party.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Gloria Tory), `[427]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)

### Węzeł `[248]`
**[WYBÓR GRACZA: ""What I see is a bright future for Sordland. We need to be united.""]** — Mówca: **Player**
> ""What I see is a bright future for Sordland. We need to be united.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Gloria Tory), `[427]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)

### Węzeł `[249]`
**[WYBÓR GRACZA: ""Let's change the topic and discuss how I can make you and the conservatives happy.""]** — Mówca: **Player**
> ""Let's change the topic and discuss how I can make you and the conservatives happy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Gloria Tory), `[427]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Gloria Tory: ""By listening to our concerns and acting on them? I repre..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Decrees_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true && Base..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Decrees_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Gloria Tory: ""Who are you kidding? This proposal is designed for your ..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Decrees_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Gloria Tory: ""I continue to disagree.""*)

### Węzeł `[253]`
Mówca: **Gloria Tory**
> ""Who are you kidding? This proposal is designed for your own benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Gloria Tory: ""So what are you thinking about? Are you ready to make ch..."*)

### Węzeł `[254]`
Mówca: **Gloria Tory**
> ""I continue to disagree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Gloria Tory: ""So what are you thinking about? Are you ready to make ch..."*)

### Węzeł `[255]`
Mówca: **Gloria Tory**
> ""Looks like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Gloria Tory: ""So what are you thinking about? Are you ready to make ch..."*)

### Węzeł `[256]`
Mówca: **Gloria Tory**
> ""By listening to our concerns and acting on them? I represent the conservative wing of the party, Mr. President. You should realize that you're not interacting with just one person here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Gloria Tory: ""So what are you thinking about? Are you ready to make ch..."*)

### Węzeł `[257]`
Mówca: **Gloria Tory**
> ""So what are you thinking about? Are you ready to make changes to your proposal or should we keep talking past each other?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default == false &..."*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame...."*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)
  - -> `[258]` (*Player: ""Mrs. Tory, please try to understand me. I cannot give co..."*)

### Węzeł `[258]`
**[WYBÓR GRACZA: ""Mrs. Tory, please try to understand me. I cannot give concessions now.""]** — Mówca: **Player**
> ""Mrs. Tory, please try to understand me. I cannot give concessions now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Gloria Tory), `[421]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "She raised an eyebrow and then took a look at the proposa..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default == false &..."*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Default == false..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false  and  Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player: ""Fine. We will not touch the immunity of the Justices. Le..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false  and  Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Gloria_Law_Decrees_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame...."*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGam..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Gloria_Law_Decrees_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Decrees_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player: ""You're right. I will not strengthen presidential decrees..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Gloria_Law_Decrees_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Decrees_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Gloria_Law_Impeachment_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true && Base..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Gloria_Law_Impeachment_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player: ""I will remove the changes about the impeachment of the p..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Gloria_Law_Impeachment_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[268]`
**[WYBÓR GRACZA: ""I will remove the changes about the impeachment of the presidents." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will remove the changes about the impeachment of the presidents.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] == false`
- **Kontekst wejściowy (poprzednik):** `[257]` (Gloria Tory), `[409]` (Gloria Tory), `[421]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Impeachment_Default = true"*)

### Węzeł `[269]`
**[WYBÓR GRACZA: ""You're right. I will not strengthen presidential decrees. Let's keep it as it is." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""You're right. I will not strengthen presidential decrees. Let's keep it as it is.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Decrees_Default"] == false`
- **Kontekst wejściowy (poprzednik):** `[257]` (Gloria Tory), `[409]` (Gloria Tory), `[421]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Decrees_Default = true"*)

### Węzeł `[270]`
**[WYBÓR GRACZA: ""Fine. We will not touch the immunity of the Justices. Let's remove that point." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. We will not touch the immunity of the Justices. Let's remove that point.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false  and  Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] == false`
- **Kontekst wejściowy (poprzednik):** `[257]` (Gloria Tory), `[409]` (Gloria Tory), `[421]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default = true"*)

### Węzeł `[271]`
Mówca: **Gloria Tory**
> ""That is certainly a step in the right direction...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[272]`
Mówca: **Gloria Tory**
> ""Finally. The proposal is starting to make some sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "She took a long look at the proposal on her table."*)

### Węzeł `[273]`
Mówca: **Gloria Tory**
> ""Finally. The proposal is starting to make some sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "She took a long look at the proposal on her table."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true)"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Gloria Tory: ""Let me give you some advice, Mr. President. Giving yours..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Gloria Tory: ""You know what?""*)

### Węzeł `[277]`
Mówca: **Gloria Tory**
> ""...But not quite enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Gloria Tory: ""Let me give you some advice, Mr. President. Giving yours..."*)

### Węzeł `[278]`
Mówca: **Gloria Tory**
> ""Let me give you some advice, Mr. President. Giving yourself the same title as Tarquin Soll will not make you a hero. You have not earned that title nor the immunity and the protection it brings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Gloria Tory: ""Remove the changes to the Member of Honor laws from the ..."*)

### Węzeł `[279]`
Mówca: **Gloria Tory**
> ""Remove the changes to the Member of Honor laws from the proposal before it becomes public. Let's not damage our party nor your reputation further. This will only bring you ridicule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Gloria Tory: ""And there is no way that the Assembly or the Supreme Cou..."*)

### Węzeł `[280]`
Mówca: **Gloria Tory**
> ""And there is no way that the Assembly or the Supreme Court would vote for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player: ""You are right. That is one risky topic. I will remove it..."*)
  - -> `[286]` (*Player: ""You can believe what you will, Mrs. Tory. Just tell me i..."*)
  - -> `[287]` (*Player: ""You might be right but that will not stop me from trying..."*)

### Węzeł `[281]`
Mówca: **Gloria Tory**
> ""You know what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Gloria Tory: ""I feel extra generous today.""*)

### Węzeł `[282]`
Mówca: **Narrator**
> "She raised an eyebrow and then took a look at the proposal on her table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)

### Węzeł `[283]`
Mówca: **Narrator**
> "She took a long look at the proposal on her table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Impeachment_Removed == true && BaseG..."*)

### Węzeł `[284]`
Mówca: **Gloria Tory**
> ""You are a stubborn man. But anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Gloria Tory: ""There is one other way for you to gain my support.""*)

### Węzeł `[285]`
**[WYBÓR GRACZA: ""You are right. That is one risky topic. I will remove it." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""You are right. That is one risky topic. I will remove it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[280]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Honorary_Default = true"*)

### Węzeł `[286]`
**[WYBÓR GRACZA: ""You can believe what you will, Mrs. Tory. Just tell me if you will give us support or not.""]** — Mówca: **Player**
> ""You can believe what you will, Mrs. Tory. Just tell me if you will give us support or not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[280]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[287]`
**[WYBÓR GRACZA: ""You might be right but that will not stop me from trying. I wish you'd join me in this endeavour.""]** — Mówca: **Player**
> ""You might be right but that will not stop me from trying. I wish you'd join me in this endeavour.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[280]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[288]`
Mówca: **Gloria Tory**
> ""I'm glad we are on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaConvinced]"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaConvinced]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "GloriaConvinced"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaConvinced]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "GloriaConvinced"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaFail]"*)

### Węzeł `[294]`
Mówca: **Gloria Tory**
> ""All right, Mr. President. I'm sorry I won't be able to help you. I wish you luck gathering the signatures you need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "She suddenly stood up."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaFail]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GloriaFail"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_East == true)"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Gloria Tory: ""My conscience doesn't allow me to help the spread of Mal..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_East == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Gloria Tory: ""You are a stubborn man. But anyway...""*)

### Węzeł `[299]`
Mówca: **Gloria Tory**
> ""There is one other way for you to gain my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Gloria Tory: ""Put my name at the top of the list of Supreme Court Just..."*)

### Węzeł `[300]`
Mówca: **Gloria Tory**
> ""Put my name at the top of the list of Supreme Court Justice candidates. In case of a vacancy in the Supreme Court, I want to be appointed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Player: ""If that's going to assure your support, you have my word.""*)
  - -> `[302]` (*Player: ""That's it? That's easy. Consider it done.""*)
  - -> `[303]` (*Player: ""That's a deal, Mrs. Tory. I'll expect your votes in retu..."*)
  - -> `[304]` (*Player: ""I can't do that.""*)

### Węzeł `[301]`
**[WYBÓR GRACZA: ""If that's going to assure your support, you have my word.""]** — Mówca: **Player**
> ""If that's going to assure your support, you have my word.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Gloria Tory: ""I'll hold you to that promise.""*)

### Węzeł `[302]`
**[WYBÓR GRACZA: ""That's it? That's easy. Consider it done.""]** — Mówca: **Player**
> ""That's it? That's easy. Consider it done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Gloria Tory: ""No need to flaunt, Mr. President.""*)

### Węzeł `[303]`
**[WYBÓR GRACZA: ""That's a deal, Mrs. Tory. I'll expect your votes in return.""]** — Mówca: **Player**
> ""That's a deal, Mrs. Tory. I'll expect your votes in return.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Gloria Tory: ""Good.""*)

### Węzeł `[304]`
**[WYBÓR GRACZA: ""I can't do that.""]** — Mówca: **Player**
> ""I can't do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Gloria Tory: ""Then we are at an impasse.""*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaFail]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GloriaFail"*)

### Węzeł `[306]`
Mówca: **Gloria Tory**
> ""I'll hold you to that promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Gloria_Promise_Justice = true"*)

### Węzeł `[307]`
Mówca: **Gloria Tory**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Gloria_Promise_Justice = true"*)

### Węzeł `[308]`
Mówca: **Gloria Tory**
> ""No need to flaunt, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Gloria_Promise_Justice = true"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaConvinced]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "GloriaConvinced"*)

### Węzeł `[310]`
Mówca: **Gloria Tory**
> ""I reviewed your proposal in detail. It's a fine draft. Your changes aren't major enough to cause any difficulties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Gloria Tory: ""I believe I can give you the help you require.""*)

### Węzeł `[311]`
Mówca: **Gloria Tory**
> ""I can get you the signatures needed for the proposal. I'll talk to the other conservatives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Gloria Tory: ""I hope there won't be any surprises though, Mr. President.""*)

### Węzeł `[312]`
Mówca: **Gloria Tory**
> ""I hope there won't be any surprises though, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Player: ""Glad to hear that, Mrs. Tory.""*)
  - -> `[314]` (*Player: ""What surprises?""*)
  - -> `[315]` (*Player: ""Your lack of faith in me is disappointing.""*)
  - -> `[316]` (*Player: ""I assure you, there is nothing you should be concerned a..."*)

### Węzeł `[313]`
**[WYBÓR GRACZA: ""Glad to hear that, Mrs. Tory.""]** — Mówca: **Player**
> ""Glad to hear that, Mrs. Tory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[314]`
**[WYBÓR GRACZA: ""What surprises?""]** — Mówca: **Player**
> ""What surprises?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[315]`
**[WYBÓR GRACZA: ""Your lack of faith in me is disappointing.""]** — Mówca: **Player**
> ""Your lack of faith in me is disappointing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[316]`
**[WYBÓR GRACZA: ""I assure you, there is nothing you should be concerned about.""]** — Mówca: **Player**
> ""I assure you, there is nothing you should be concerned about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Gloria Tory: ""I'll hold you to that promise.""*)

### Węzeł `[317]`
Mówca: **Gloria Tory**
> ""I'll hold you to that promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Gloria Tory: ""We have to calculate every possibility, Mr. President. A..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_East == true)"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Gloria Tory: ""We have to calculate every possibility, Mr. President. A..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_East == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Gloria Tory: ""We have to calculate every possibility, Mr. President. A..."*)

### Węzeł `[324]`
Mówca: **Gloria Tory**
> ""We have to calculate every possibility, Mr. President. After all, I do not see eye to eye with your other policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Gloria Tory: ""Especially the continuation of Alphonso's free market re..."*)

### Węzeł `[325]`
Mówca: **Gloria Tory**
> ""Especially the continuation of Alphonso's free market reforms...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Gloria Tory: ""You have seen the recession. It's proven that this exper..."*)

### Węzeł `[326]`
Mówca: **Gloria Tory**
> ""You have seen the recession. It's proven that this experiment doesn't work. But anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Gloria Tory: ""Of course, I can't guarantee that all the conservatives ..."*)

### Węzeł `[327]`
Mówca: **Gloria Tory**
> ""We have to calculate every possibility, Mr. President. After all, I do not see eye to eye with your other policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Gloria Tory: ""Especially your promotion of eastern values. Getting clo..."*)

### Węzeł `[328]`
Mówca: **Gloria Tory**
> ""Especially your promotion of eastern values. Getting closer to United Contana will definitely create huge problems for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Gloria Tory: ""I hope you are not going to follow through with that ide..."*)

### Węzeł `[329]`
Mówca: **Gloria Tory**
> ""I hope you are not going to follow through with that idea to the end. Flirting with the Malenyevists will only bring us trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Gloria Tory: ""Of course, I can't guarantee that all the conservatives ..."*)

### Węzeł `[330]`
Mówca: **Gloria Tory**
> ""We have to calculate every possibility, Mr. President. After all, this is Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Gloria Tory: ""Of course, I can't guarantee that all the conservatives ..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_East == true)"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Gloria Tory: ""I just hope you won't flirt with the Malenyevists. Your ..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_East == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Gloria Tory: ""Of course, I can't guarantee that all the conservatives ..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Gloria Tory: ""I just hope you won't continue Alphonso's destruction of..."*)

### Węzeł `[337]`
Mówca: **Gloria Tory**
> ""I just hope you won't continue Alphonso's destruction of the country with your economic policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Gloria Tory: ""Of course, I can't guarantee that all the conservatives ..."*)

### Węzeł `[338]`
Mówca: **Gloria Tory**
> ""I just hope you won't flirt with the Malenyevists. Your promotion of eastern values was troubling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Gloria Tory: ""Of course, I can't guarantee that all the conservatives ..."*)

### Węzeł `[339]`
Mówca: **Gloria Tory**
> ""Of course, I can't guarantee that all the conservatives of the party will vote for your constitutional changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Gloria Tory: ""I have serious reservations about privatizing healthcare..."*)

### Węzeł `[340]`
Mówca: **Gloria Tory**
> ""That will depend to some extent on your policies. But the signatures, at least, are as good as gathered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Player: ""Thank you.""*)
  - -> `[342]` (*Player: ""Which policies make you concerned?""*)
  - -> `[341]` (*Player: ""Signatures are not enough. We'll need all the votes from..."*)

### Węzeł `[341]`
**[WYBÓR GRACZA: ""Signatures are not enough. We'll need all the votes from the USP.""]** — Mówca: **Player**
> ""Signatures are not enough. We'll need all the votes from the USP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Gloria Tory: ""Well, that's politics for you.""*)

### Węzeł `[342]`
**[WYBÓR GRACZA: ""Which policies make you concerned?""]** — Mówca: **Player**
> ""Which policies make you concerned?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EducationPrivatization == true"*)

### Węzeł `[343]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Narrator: "She smiled and nodded."*)

### Węzeł `[344]`
Mówca: **Gloria Tory**
> ""Well, that's politics for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Narrator: "She smiled."*)

### Węzeł `[345]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Gloria Tory: ""I'll do what I can.""*)

### Węzeł `[346]`
Mówca: **Narrator**
> "She smiled and nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Gloria Tory: ""Before we finish...There is one thing I need to say.""*)

### Węzeł `[347]`
Mówca: **Gloria Tory**
> ""I'll do what I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Gloria Tory: ""Before we finish... There is one thing I need to say.""*)

### Węzeł `[348]`
Mówca: **Gloria Tory**
> ""I am completely against your efforts to privatize our educational institutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Gloria Tory: ""The State must be responsible for educating its citizens..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EducationPrivatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EducationPrivatization == true"*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Welfare_EducationPrivatization == true)"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EducationPrivatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Gloria Tory: ""I am completely against your efforts to privatize our ed..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Welfare_EducationPrivatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Gloria Tory: ""I am concerned about the Oligarchs and the state of our ..."*)

### Węzeł `[352]`
Mówca: **Gloria Tory**
> ""The State must be responsible for educating its citizens. Your reform will corrupt our education system and bring foreign influence...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Gloria Tory: ""But we'll discuss that later. What we expect from you is..."*)

### Węzeł `[353]`
Mówca: **Gloria Tory**
> ""I am concerned about the Oligarchs and the state of our economy. I am worried that they may influence you for their own benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Gloria Tory: ""We expect you to succeed where Alphonso failed in resist..."*)

### Węzeł `[354]`
Mówca: **Gloria Tory**
> ""But we'll discuss that later. What we expect from you is not to pursue further privatization. If you start privatizing health care or state-owned corporations, I doubt I can help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player: ""Don't worry. That won't happen.""*)
  - -> `[359]` (*Player: ""I can't promise anything. These decisions depend on the ..."*)
  - -> `[360]` (*Player: ""I am not Alphonso.""*)
  - -> `[361]` (*Player: ""It will happen one way or another.""*)

### Węzeł `[355]`
Mówca: **Gloria Tory**
> ""We expect you to succeed where Alphonso failed in resisting their siren call. If you start privatizing health care or state-owned corporations, I doubt I can help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player: ""Don't worry. That won't happen.""*)
  - -> `[359]` (*Player: ""I can't promise anything. These decisions depend on the ..."*)
  - -> `[360]` (*Player: ""I am not Alphonso.""*)
  - -> `[361]` (*Player: ""It will happen one way or another.""*)

### Węzeł `[356]`
Mówca: **Gloria Tory**
> ""Before we finish...There is one thing I need to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EducationPrivatization == true"*)

### Węzeł `[357]`
Mówca: **Gloria Tory**
> ""Before we finish... There is one thing I need to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EducationPrivatization == true"*)

### Węzeł `[358]`
**[WYBÓR GRACZA: ""Don't worry. That won't happen.""]** — Mówca: **Player**
> ""Don't worry. That won't happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Gloria Tory), `[355]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Gloria Tory: ""Good.""*)

### Węzeł `[359]`
**[WYBÓR GRACZA: ""I can't promise anything. These decisions depend on the circumstances.""]** — Mówca: **Player**
> ""I can't promise anything. These decisions depend on the circumstances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Gloria Tory), `[355]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Gloria Tory: ""For the sake of your reforms, you'd better hope that it ..."*)

### Węzeł `[360]`
**[WYBÓR GRACZA: ""I am not Alphonso.""]** — Mówca: **Player**
> ""I am not Alphonso.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Gloria Tory), `[355]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[361]`
**[WYBÓR GRACZA: ""It will happen one way or another.""]** — Mówca: **Player**
> ""It will happen one way or another.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Gloria Tory), `[355]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Gloria Tory: ""For the sake of your reforms, you'd better hope that it ..."*)

### Węzeł `[362]`
Mówca: **Gloria Tory**
> ""For the sake of your reforms, you'd better hope that it doesn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "She stood up."*)

### Węzeł `[363]`
Mówca: **Gloria Tory**
> ""I know. That's why I want to see you succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "She stood up."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Gloria Tory: ""I know. That's why I want to see you succeed.""*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Gloria Tory: ""Yes. Different names, I guess.""*)

### Węzeł `[367]`
Mówca: **Gloria Tory**
> ""Yes. Different names, I guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "She stood up."*)

### Węzeł `[368]`
Mówca: **Gloria Tory**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "She stood up."*)

### Węzeł `[369]`
Mówca: **Gloria Tory**
> ""I believe I can give you the help you require.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Narrator: "She repositioned herself on the chair."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GloriaConvinced`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Gloria Tory: ""I believe I can give you the help you require.""*)

### Węzeł `[371]`
Mówca: **Narrator**
> "She stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Gloria Tory: ""I believe I've made myself clear. Thanks for stopping by..."*)

### Węzeł `[372]`
Mówca: **Gloria Tory**
> ""I believe I've made myself clear. Thanks for stopping by, Mr. President. I hope you'll hold your promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Narrator: "She extended her hand to me for a handshake."*)

### Węzeł `[373]`
Mówca: **Narrator**
> "She extended her hand to me for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "Once I shook her hand, she immediately sat back down."*)

### Węzeł `[374]`
Mówca: **Narrator**
> "Once I shook her hand, she immediately sat back down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced = true"*)

### Węzeł `[375]`
Mówca: **Gloria Tory**
> ""But now I need to get back to my duties. If you'll excuse me, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Player: ""I understand. I'll leave you to it.""*)
  - -> `[379]` (*Player: ""Goodbye, Mrs. Tory. Thank you.""*)
  - -> `[377]` (*Player: ""I'll be expecting your wing's support, Mrs. Tory.""*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Gloria_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Gloria Tory: ""But now I need to get back to my duties. If you'll excus..."*)

### Węzeł `[377]`
**[WYBÓR GRACZA: ""I'll be expecting your wing's support, Mrs. Tory.""]** — Mówca: **Player**
> ""I'll be expecting your wing's support, Mrs. Tory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Narrator: "She only responded with a nod as I left her office."*)

### Węzeł `[378]`
**[WYBÓR GRACZA: ""I understand. I'll leave you to it.""]** — Mówca: **Player**
> ""I understand. I'll leave you to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Narrator: "She only responded with a nod as I left her office."*)

### Węzeł `[379]`
**[WYBÓR GRACZA: ""Goodbye, Mrs. Tory. Thank you.""]** — Mówca: **Player**
> ""Goodbye, Mrs. Tory. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Narrator: "She only responded with a nod as I left her office."*)

### Węzeł `[380]`
Mówca: **Narrator**
> "She only responded with a nod as I left her office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Narrator: "The conservative side was handled, but to get to the 150 ..."*)

### Węzeł `[381]`
Mówca: **Narrator**
> "She suddenly stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Gloria Tory: ""I must get back to work. Thanks for stopping by, Mr. Pre..."*)

### Węzeł `[382]`
Mówca: **Gloria Tory**
> ""I must get back to work. Thanks for stopping by, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Narrator: "She extended her hand to me for a handshake."*)

### Węzeł `[383]`
Mówca: **Narrator**
> "She extended her hand to me for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Player_Italic: "Shake her hand."*)
  - -> `[385]` (*Player_Italic: "Walk away without shaking her hand."*)
  - -> `[386]` (*Player: ""I am not finished.""*)
  - -> `[387]` (*Player: ""I'm not going anywhere until you give me the signatures.""*)

### Węzeł `[384]`
**[WYBÓR GRACZA: "Shake her hand."]** — Mówca: **Player_Italic**
> "I stood up and shook her hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Gloria Tory: ""This doesn't mean we won't be able to cooperate on other..."*)

### Węzeł `[385]`
**[WYBÓR GRACZA: "Walk away without shaking her hand."]** — Mówca: **Player_Italic**
> "I stood up and walked away."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Gloria Tory: ""What happened to manners?""*)

### Węzeł `[386]`
**[WYBÓR GRACZA: ""I am not finished.""]** — Mówca: **Player**
> ""I am not finished.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Gloria Tory: ""Please do not humiliate yourself further, Mr. President.""*)

### Węzeł `[387]`
**[WYBÓR GRACZA: ""I'm not going anywhere until you give me the signatures.""]** — Mówca: **Player**
> ""I'm not going anywhere until you give me the signatures.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Gloria Tory: ""Please do not humiliate yourself further, Mr. President.""*)

### Węzeł `[388]`
Mówca: **Gloria Tory**
> ""Please do not humiliate yourself further, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Player: ""Don't forget who you are talking to.""*)
  - -> `[397]` (*Player: ""You will give me the signatures. I don't care if it's wi..."*)
  - -> `[399]` (*Player: ""Goodbye.""*)

### Węzeł `[389]`
Mówca: **Gloria Tory**
> ""What happened to manners?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Gloria Tory: ""Suit yourself.""*)

### Węzeł `[390]`
Mówca: **Gloria Tory**
> ""This doesn't mean we won't be able to cooperate on other matters. I hope to speak again soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "I left her room."*)

### Węzeł `[391]`
Mówca: **Gloria Tory**
> ""Suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "I left her room."*)

### Węzeł `[392]`
Mówca: **Narrator**
> "I left her room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Narrator: "Albin and the reformist wing was my last hope to get the ..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Default == true"*)
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Default == true)"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Gloria Tory: ""I don't see why the backbone of this party should suppor..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Gloria Tory: ""I don't see why the backbone of the USP would support yo..."*)

### Węzeł `[396]`
Mówca: **Gloria Tory**
> ""I don't see why the backbone of this party should support your rushed reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""The reforms are not against anyone. It's all in the name..."*)
  - -> `[31]` (*Player: ""Mrs. Tory, I need you to help me here.""*)
  - -> `[32]` (*Player: ""My reforms are very critical for the future of Sordland,..."*)

### Węzeł `[397]`
**[WYBÓR GRACZA: ""You will give me the signatures. I don't care if it's willingly or not.""]** — Mówca: **Player**
> ""You will give me the signatures. I don't care if it's willingly or not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Gloria Tory: ""I'd rather not reply to that.""*)

### Węzeł `[398]`
**[WYBÓR GRACZA: ""Don't forget who you are talking to.""]** — Mówca: **Player**
> ""Don't forget who you are talking to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Gloria Tory: ""I'd rather not reply to that.""*)

### Węzeł `[399]`
**[WYBÓR GRACZA: ""Goodbye.""]** — Mówca: **Player**
> ""Goodbye.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "I left her room."*)

### Węzeł `[400]`
Mówca: **Gloria Tory**
> ""I'd rather not reply to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "I left her room."*)

### Węzeł `[401]`
Mówca: **Narrator**
> "Albin and the reformist wing was my last hope to get the needed 150 signatures for the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "Even then, it looked quite uncertain if we could get 166 ..."*)

### Węzeł `[402]`
Mówca: **Narrator**
> "Even then, it looked quite uncertain if we could get 166 votes in the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Narrator: "I went outside. Serge drove me back to the palace, where ..."*)

### Węzeł `[403]`
Mówca: **Narrator**
> "I went outside. Serge drove me back to the palace, where I met Lucian and told him the bad news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceGl..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Gloria_Promise_Justice = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Gloria_Promise_Justice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaConvinced]"*)

### Węzeł `[405]`
Mówca: **Gloria Tory**
> ""My conscience doesn't allow me to help the spread of Malenyevism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaFail]"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Judges_Impeachment_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true && Base..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Judges_Impeachment_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Gloria Tory: ""Then there will be no further discussion.""*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Judges_Impeachment_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)

### Węzeł `[409]`
Mówca: **Gloria Tory**
> ""Then there will be no further discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default == false &..."*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame...."*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)
  - -> `[410]` (*Player: ""I can't give you what you want, Mrs. Tory.""*)

### Węzeł `[410]`
**[WYBÓR GRACZA: ""I can't give you what you want, Mrs. Tory.""]** — Mówca: **Player**
> ""I can't give you what you want, Mrs. Tory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Gloria Tory: ""Too bad. I thought we were close to an arrangement.""*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaFail]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GloriaFail"*)

### Węzeł `[412]`
Mówca: **Gloria Tory**
> ""Too bad. I thought we were close to an arrangement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaFail]"*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true && Base..."*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Gloria Tory: ""Then there will be no further discussion.""*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Gloria_Law_Impeachment_Default == false) && (BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Impeachment_Removed == true && BaseG..."*)
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Impeachment_Removed == true && Bas..."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Gloria_Law_Impeachment_Default == false) && (BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] == false)  and  (Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false  and  Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Gloria Tory: ""...But not quite enough.""*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Gloria_Law_Impeachment_Default == false) && (BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] == false)  and  (Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false  and  Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Gloria Tory: ""You know what?""*)

### Węzeł `[419]`
Mówca: **Gloria Tory**
> ""...But not quite enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaDemandHub]"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GloriaDemandHub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Gloria Tory: ""I can't support you giving yourself absolute immunity wh..."*)

### Węzeł `[421]`
Mówca: **Gloria Tory**
> ""I can't support you giving yourself absolute immunity while taking the Court's away. This is unacceptable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default == false &..."*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame...."*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true && BaseGa..."*)
  - -> `[258]` (*Player: ""Mrs. Tory, please try to understand me. I cannot give co..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaDemandHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "GloriaDemandHub"*)

### Węzeł `[423]`
Mówca: **Narrator**
> "She repositioned herself on the chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true || BaseGa..."*)
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true || Base..."*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Gloria Tory: ""I don't see anything *democratic* here, Mr. President. C..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Gloria Tory: ""I don't see any real reform here, Mr. President. Do you?""*)

### Węzeł `[427]`
Mówca: **Gloria Tory**
> ""I don't see any real reform here, Mr. President. Do you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Player: ""It seems our understanding of reform is very different.""*)
  - -> `[247]` (*Player: ""This will benefit the party.""*)
  - -> `[248]` (*Player: ""What I see is a bright future for Sordland. We need to b..."*)
  - -> `[249]` (*Player: ""Let's change the topic and discuss how I can make you an..."*)

### Węzeł `[428]`
**[WYBÓR GRACZA: ""It seems our understanding of reform is very different.""]** — Mówca: **Player**
> ""It seems our understanding of reform is very different.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[427]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Gloria Tory: ""Looks like it.""*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true)"*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Gloria Tory: ""Let me give you some advice, Mr. President. Giving yours..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Narrator: "She took a look at the proposal."*)

### Węzeł `[432]`
Mówca: **Gloria Tory**
> ""You know what...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaConvinced]"*)

### Węzeł `[433]`
Mówca: **Narrator**
> "She took a look at the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Gloria Tory: ""You know what...""*)

### Węzeł `[434]`
Mówca: **Narrator**
> "The conservative side was handled, but to get to the 150 signatures I needed, I would still have to deal with Albin Clavin and the reformist wing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Narrator: "I went outside. Serge drove me back to the palace, where ..."*)

### Węzeł `[435]`
Mówca: **Narrator**
> "I went outside. Serge drove me back to the palace, where I met Lucian and told him about the progress I'd made with Gloria."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn04_Reforms_ConvincedGloria = ..."*)

### Węzeł `[436]`
**[WYBÓR GRACZA: ""Good morning, Mrs. Tory.""]** — Mówca: **Player**
> ""Good morning, Mrs. Tory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Gloria Tory: ""Good to see you here, Mr. Rayne.""*)

### Węzeł `[437]`
**[WYBÓR GRACZA: ""Hello Gloria.""]** — Mówca: **Player**
> ""Hello Gloria.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Gloria Tory: ""Good to see you here, Mr. Rayne.""*)

### Węzeł `[438]`
**[WYBÓR GRACZA: ""Here I am.""]** — Mówca: **Player**
> ""Here I am.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Gloria Tory: ""Good to see you here, Mr. Rayne.""*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceGloria = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceGloria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_A_Convince_Gloria = true"*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn04_Reforms_ConvincedGloria = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Reforms_ConvincedGloria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_A_Convince_Gloria = true"*)

### Węzeł `[441]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Gloria Tory: ""So. How does the presidential chair compare to the ones ..."*)

### Węzeł `[442]`
Mówca: **Gloria Tory**
> ""So. How does the presidential chair compare to the ones in the Assembly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: ""Not as good as you imagine.""*)
  - -> `[25]` (*Player: ""It's better, what can I say?""*)
  - -> `[26]` (*Player: ""The chair is fine, but the work that comes with it is in..."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn04_A_Convince_Gloria = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn04_A_Convince_Gloria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true && BaseGame.Ref..."*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true &&
BaseGame.Reform_Autocrat_Path == false &&
BaseGame.Country_Unrest <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true && BaseGame.Ref..."*)
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true && BaseGame.R..."*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true &&
BaseGame.Reform_Autocrat_Path == false &&
BaseGame.Country_Unrest <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true  and 
Variable["BaseGame.Reform_Autocrat_Path"] == false  and 
Variable["BaseGame.Country_Unrest"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_ST_RayneStopsUnrest_Deal = true"*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true &&
BaseGame.Reform_Autocrat_Path == false &&
BaseGame.Country_Unrest <= 0

)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  and 
Variable["BaseGame.Reform_Autocrat_Path"] == false  and 
Variable["BaseGame.Country_Unrest"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_ST_RayneStopsUnrest_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_ST_RayneStopsUnrest_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true"*)
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_President == true)"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Gloria Tory: ""A President that has the power to impeach Justices will ..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Gloria Tory: ""Even though the Assembly is elected by the people, it do..."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_15 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_15 == true"*)
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_15 == true)"*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_15 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Gloria Tory: ""Increasing the threshold to 15 percent ought to mollify ..."*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_15 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Gloria Tory: ""I can get you the signatures needed for the proposal. I'..."*)

### Węzeł `[454]`
Mówca: **Gloria Tory**
> ""A President that has the power to impeach Justices will be very dangerous in the future. We shouldn't damage the separation of powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Gloria Tory: ""This is something I cannot accept.""*)

### Węzeł `[455]`
Mówca: **Gloria Tory**
> ""This is something I cannot accept.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true"*)

### Węzeł `[456]`
Mówca: **Gloria Tory**
> ""Increasing the threshold to 15 percent ought to mollify a lot of lifetime USP members. It secures our advantageous position and further consolidates it by leaving other parties out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Gloria Tory: ""I can get you the signatures needed for the proposal. I'..."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Threshold_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Gloria Tory: ""That's a step in the right direction.""*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Honorary_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Gloria Tory: ""Great. Now, we can start talking for real.""*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Honorary_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Gloria Tory: ""Great. Now, we can start talking.""*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Gloria Tory: ""Finally. The proposal is starting to make some sense.""*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Decrees_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Decrees_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Gloria Tory: ""That is certainly a step in the right direction...""*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Impeachment_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Gloria Tory: ""Finally. The proposal is starting to make some sense.""*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Honorary_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Gloria Tory: ""I'm glad we are on the same page.""*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_3 = false; BaseGame.Reform_Law_Threshold_8 = false; BaseGame.Reform_Law_Threshold_15 = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Threshold_3"] = false;
Variable["BaseGame.Reform_Law_Threshold_8"] = false;
Variable["BaseGame.Reform_Law_Threshold_15"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default = true"*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Honorary_Default == true"*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Threshold_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Threshold_Default == true"*)
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Law_Threshold_Default == true)"*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Threshold_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_3 = false; BaseGame.Reform_..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Law_Threshold_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Honorary_Default == true"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == ..."*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Honorary_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Honorary_Default == true"*)
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Law_Honorary_Default == true)"*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Honorary_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished = false; BaseGame...."*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Law_Honorary_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Impeachment_Default == true"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Default = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Decrees_Default == true"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly = false;
BaseGame.Reform_Law_Judges_Impeachment_President = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] = false;
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default = true"*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished = false; BaseGame.Reform_Law_Honorary_NoImmunity = false; BaseGame.Reform_Law_Honorary_Presidents = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] = false;
Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] = false;
Variable["BaseGame.Reform_Law_Honorary_Presidents"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Default = true"*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Honorary_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Impeachment_Default == true"*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed = false; BaseGame.Reform_Law_Impeachment_Assembly = false; BaseGame.Reform_Law_Impeachment_Harder = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] = false;
Variable["BaseGame.Reform_Law_Impeachment_Assembly"] = false;
Variable["BaseGame.Reform_Law_Impeachment_Harder"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Default = true;"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger = false; BaseGame.Reform_Law_Decrees_Removed = false; BaseGame.Reform_Law_Decrees_Weaker = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] = false;
Variable["BaseGame.Reform_Law_Decrees_Removed"] = false;
Variable["BaseGame.Reform_Law_Decrees_Weaker"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default = true"*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Impeachment_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Impeachment_Default == true"*)
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Law_Impeachment_Default == true)"*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Impeachment_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed = false; BaseGame..."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Law_Impeachment_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Decrees_Default == true"*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == ..."*)
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default =..."*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly = false; ..."*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Decrees_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Decrees_Default == true"*)
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Law_Decrees_Default == true)"*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Decrees_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger = false; BaseGame.Re..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Law_Decrees_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == ..."*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Convinced == true"*)
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Gloria_Convinced == true)"*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Threshold_Default == true"*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Gloria_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[492]`
Mówca: **Gloria Tory**
> ""The conservatives will be expecting a lot from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Player: ""I will be expecting a lot from conservatives as well.""*)
  - -> `[494]` (*Player: ""Of course.""*)
  - -> `[496]` (*Player: ""Whatever you need, Mrs. Tory.""*)

### Węzeł `[493]`
**[WYBÓR GRACZA: ""I will be expecting a lot from conservatives as well.""]** — Mówca: **Player**
> ""I will be expecting a lot from conservatives as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[492]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_15 == true"*)

### Węzeł `[494]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[492]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Gloria Tory: ""Good.""*)

### Węzeł `[495]`
Mówca: **Gloria Tory**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_15 == true"*)

### Węzeł `[496]`
**[WYBÓR GRACZA: ""Whatever you need, Mrs. Tory.""]** — Mówca: **Player**
> ""Whatever you need, Mrs. Tory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[492]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Gloria Tory: ""Good.""*)

### Węzeł `[497]`
Mówca: **Gloria Tory**
> ""I feel extra generous today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaConvinced]"*)

### Węzeł `[498]`
Mówca: **Gloria Tory**
> ""Just don't forget, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Gloria Tory: ""The conservatives will be expecting a lot from you.""*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)"*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Gloria Tory: ""I do have one condition. I want you to cancel that speec..."*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Gloria Tory: ""Just don't forget, Mr. President.""*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Reform_Law_Threshold_3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Refor..."*)
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Ref..."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Reform_Law_Threshold_3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_8"] == true  or  Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Player: ""No, this is too important to me. But what if I remove th..."*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Reform_Law_Threshold_3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_8"] == true  or  Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Threshold_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Gloria Tory: ""Good. Now, we can start talking.""*)

### Węzeł `[506]`
**[WYBÓR GRACZA: ""No, this is too important to me. But what if I remove the change to the threshold instead?" [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""No, this is too important to me. But what if I remove the change to the threshold instead?" [CHANGE THE REFORM]"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Threshold_8"] == true  or  Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Kontekst wejściowy (poprzednik):** `[157]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Threshold_Default = true"*)

### Węzeł `[507]`
Mówca: **Gloria Tory**
> ""Good. Now, we can start talking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaDiscussion]"*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaDiscussion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "GloriaDiscussion"*)

### Węzeł `[509]`
Mówca: **Gloria Tory**
> ""It seems you don't understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaFail]"*)

### Węzeł `[510]`
**[WYBÓR GRACZA: ""No. We could talk about the other clauses instead.""]** — Mówca: **Player**
> ""No. We could talk about the other clauses instead.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[210]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Gloria Tory: ""It seems you don't understand.""*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_8 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_8 == true"*)
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_8 == true)"*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_8 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Player: ""You win. How about I remove the change to the threshold ..."*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_8 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Player: ""No. We could talk about the other clauses instead.""*)

### Węzeł `[514]`
**[WYBÓR GRACZA: ""You win. How about I remove the change to the threshold instead?" [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""You win. How about I remove the change to the threshold instead?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Kontekst wejściowy (poprzednik):** `[210]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Gloria_Law_Threshold_Default = true"*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Gloria_Law_Threshold_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Gloria Tory: ""Good. Now, we can start talking.""*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaDiscussion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "GloriaDiscussion"*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaFail]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GloriaFail"*)

### Węzeł `[518]`
Mówca: **Gloria Tory**
> ""Good. Now, we can start talking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaDiscussion]"*)

### Węzeł `[519]`
Mówca: **Gloria Tory**
> ""I do have one condition. I want you to cancel that speech you were planning for your wife at the Benfi Festival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Gloria Tory: ""Mayor Leste is not only popular in Benfi, he's one of th..."*)

### Węzeł `[520]`
Mówca: **Gloria Tory**
> ""Mayor Leste is not only popular in Benfi, he's one of the most influential members of the USP's conservative wing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Gloria Tory: ""We wouldn't want to upset him, would we?""*)

### Węzeł `[521]`
Mówca: **Gloria Tory**
> ""We wouldn't want to upset him, would we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Player: ""What does he have to do with anything?""*)
  - -> `[523]` (*Player: ""I don't care if he's upset.""*)
  - -> `[524]` (*Player: ""Mrs. Tory, please. You're being unreasonable.""*)
  - -> `[525]` (*Player: ""Fine. I'll have Monica taken off the schedule and let hi..."*)

### Węzeł `[522]`
**[WYBÓR GRACZA: ""What does he have to do with anything?""]** — Mówca: **Player**
> ""What does he have to do with anything?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[521]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Gloria Tory: ""He's not the only person who would be upset, Mr. Preside..."*)

### Węzeł `[523]`
**[WYBÓR GRACZA: ""I don't care if he's upset.""]** — Mówca: **Player**
> ""I don't care if he's upset.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[521]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Gloria Tory: ""He's not the only person who would be upset, Mr. Preside..."*)

### Węzeł `[524]`
**[WYBÓR GRACZA: ""Mrs. Tory, please. You're being unreasonable.""]** — Mówca: **Player**
> ""Mrs. Tory, please. You're being unreasonable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[521]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Gloria Tory: ""He's not the only person who would be upset, Mr. Preside..."*)

### Węzeł `[525]`
**[WYBÓR GRACZA: ""Fine. I'll have Monica taken off the schedule and let him speak.""]** — Mówca: **Player**
> ""Fine. I'll have Monica taken off the schedule and let him speak.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[521]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Gloria Tory: ""Wonderful.""*)

### Węzeł `[526]`
Mówca: **Gloria Tory**
> ""He's not the only person who would be upset, Mr. President. You know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Gloria Tory: ""If you want conservative support, you cannot let the Fir..."*)

### Węzeł `[527]`
Mówca: **Gloria Tory**
> ""If you want conservative support, you cannot let the First Lady speak in Mr. Leste's stead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Player: ""No. I won't let my wife down like that.""*)
  - -> `[536]` (*Player: ""This isn't about her, it's about women's rights. I thoug..."*)

### Węzeł `[528]`
Mówca: **Gloria Tory**
> ""Wonderful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech = false; BaseGame.T..."*)

### Węzeł `[529]`
Mówca: **Gloria Tory**
> ""Then we are at an impasse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaFail]"*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [GloriaFail]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "GloriaFail"*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech = false;
BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] = false;
Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Gloria Tory: ""Just don't forget, Mr. President.""*)

### Węzeł `[532]`
**[WYBÓR GRACZA: ""No. I won't let my wife down like that.""]** — Mówca: **Player**
> ""No. I won't let my wife down like that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[527]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Gloria Tory: ""Tell me, why does she want to do this speech so badly?""*)

### Węzeł `[533]`
Mówca: **Gloria Tory**
> ""Tell me, why does she want to do this speech so badly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Player: ""She wants to give Sordish women a voice.""*)
  - -> `[541]` (*Player: ""She wants First Lady to be more than just a ceremonial p..."*)
  - -> `[543]` (*Player: ""Does it matter? She's my wife. If it's important to her,..."*)

### Węzeł `[534]`
**[WYBÓR GRACZA: ""She wants to give Sordish women a voice.""]** — Mówca: **Player**
> ""She wants to give Sordish women a voice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[533]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Gloria Tory: ""So do I. But this is not the way.""*)

### Węzeł `[535]`
Mówca: **Gloria Tory**
> ""So do I. But this is not the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Gloria Tory: ""I've spent nearly two decades in this Assembly. I know h..."*)

### Węzeł `[536]`
**[WYBÓR GRACZA: ""This isn't about her, it's about women's rights. I thought you'd understand.""]** — Mówca: **Player**
> ""This isn't about her, it's about women's rights. I thought you'd understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[527]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Gloria Tory: ""Believe me, I understand. More than your wife, even.""*)

### Węzeł `[537]`
Mówca: **Gloria Tory**
> ""Believe me, I understand. More than your wife, even.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Gloria Tory: ""Tell me, why does she want to do this speech so badly?""*)

### Węzeł `[538]`
Mówca: **Gloria Tory**
> ""I've spent nearly two decades in this Assembly. I know how real change happens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Gloria Tory: ""The old conservative men who hold the power in this gove..."*)

### Węzeł `[539]`
Mówca: **Gloria Tory**
> ""The old conservative men who hold the power in this government will not listen to Mrs. Rayne's speech and suddenly have a change of heart. Rather the opposite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Gloria Tory: ""They'll see a shrill, hectoring housewife who slept with..."*)

### Węzeł `[540]`
**[WYBÓR GRACZA: ""All right. I'll tell Monica the speech is off.""]** — Mówca: **Player**
> ""All right. I'll tell Monica the speech is off.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[551]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Gloria Tory: ""Thank you. Trust me, it's for the best.""*)

### Węzeł `[541]`
**[WYBÓR GRACZA: ""She wants First Lady to be more than just a ceremonial position.""]** — Mówca: **Player**
> ""She wants First Lady to be more than just a ceremonial position.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[533]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Gloria Tory: ""And why should it be? What does your wife know about pol..."*)

### Węzeł `[542]`
Mówca: **Gloria Tory**
> ""And why should it be? What does your wife know about politics?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Gloria Tory: ""I've spent nearly two decades in this Assembly. I know h..."*)

### Węzeł `[543]`
**[WYBÓR GRACZA: ""Does it matter? She's my wife. If it's important to her, it's important to me.""]** — Mówca: **Player**
> ""Does it matter? She's my wife. If it's important to her, it's important to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[533]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Gloria Tory: ""As important as the change you claim to be fighting for?""*)

### Węzeł `[544]`
Mówca: **Gloria Tory**
> ""As important as the change you claim to be fighting for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Gloria Tory: ""I've spent nearly two decades in this Assembly. I know h..."*)

### Węzeł `[545]`
Mówca: **Gloria Tory**
> ""They'll see a shrill, hectoring housewife who slept with the President for a spot on that stage and is now hopelessly out of her depth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Player: ""That's unfair. Monica's been campaigning for women's rig..."*)
  - -> `[547]` (*Player: ""You might have a point.""*)
  - -> `[554]` (*Player: ""You sound bitter. I'm sorry your path to the top wasn't ..."*)

### Węzeł `[546]`
**[WYBÓR GRACZA: ""That's unfair. Monica's been campaigning for women's rights since I met her.""]** — Mówca: **Player**
> ""That's unfair. Monica's been campaigning for women's rights since I met her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[545]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Gloria Tory: ""I'm just telling you what others will think.""*)

### Węzeł `[547]`
**[WYBÓR GRACZA: ""You might have a point.""]** — Mówca: **Player**
> ""You might have a point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[545]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Gloria Tory: ""Listen, I do believe the status of women could improve d..."*)

### Węzeł `[548]`
Mówca: **Gloria Tory**
> ""I'm just telling you what others will think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Gloria Tory: ""Listen, I do believe the status of women could improve d..."*)

### Węzeł `[549]`
Mówca: **Gloria Tory**
> ""Listen, I do believe the status of women could improve during your administration. Your education minister has been gathering ideas for a bill that appears quite promising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Gloria Tory: ""But you've got to have patience. Having Monica speak now..."*)

### Węzeł `[550]`
Mówca: **Gloria Tory**
> ""But you've got to have patience. Having Monica speak now will be detrimental for all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Gloria Tory: ""Just let Mayor Leste have his little moment in the spotl..."*)

### Węzeł `[551]`
Mówca: **Gloria Tory**
> ""Just let Mayor Leste have his little moment in the spotlight. His time will be over soon enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Player: ""All right. I'll tell Monica the speech is off.""*)
  - -> `[552]` (*Player: ""No. Monica will speak at the festival.""*)

### Węzeł `[552]`
**[WYBÓR GRACZA: ""No. Monica will speak at the festival.""]** — Mówca: **Player**
> ""No. Monica will speak at the festival.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[551]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Gloria Tory: ""Then we are at an impasse.""*)

### Węzeł `[553]`
Mówca: **Gloria Tory**
> ""Thank you. Trust me, it's for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech = false; BaseGame.T..."*)

### Węzeł `[554]`
**[WYBÓR GRACZA: ""You sound bitter. I'm sorry your path to the top wasn't as easy as hers.""]** — Mówca: **Player**
> ""You sound bitter. I'm sorry your path to the top wasn't as easy as hers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[545]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Gloria Tory: ""It wasn't. But that has nothing to do with it.""*)

### Węzeł `[555]`
Mówca: **Gloria Tory**
> ""It wasn't. But that has nothing to do with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Gloria Tory: ""Listen, I do believe the status of women could improve d..."*)

### Węzeł `[556]`
Mówca: **Gloria Tory**
> ""Then we are at an impasse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaFail]"*)

### Węzeł `[557]`
Mówca: **Gloria Tory**
> ""Then we are at an impasse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "Jump to: [GloriaFail]"*)

### Węzeł `[558]`
Mówca: **Gloria Tory**
> ""I have serious reservations about privatizing healthcare or the Sordish State Corporation. The support of my faction can change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Gloria Tory: ""That will depend to some extent on your policies. But th..."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_ST_BFFCallToNations = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_ST_BFFCallToNations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Today, I had a private meeting with Gloria Tory, one of t..."*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
