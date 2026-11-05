# Sordland/Turn05/SnO_FoundedPolice

- **ID konwersacji:** `63`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/063_SnO_FoundedPolice.md`
- **Liczba węzłów dialogowych:** 398
- **Liczba wyborów gracza:** 90

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Nia_Opposition`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Relations_Walter_Promise_TaxFulfilled`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`
- `BaseGame.Turn04_SnO_LE_Justice_Increased`
- `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice`
- `BaseGame.Turn05_SnO_LE_Policy_CommunityPolice`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Turn05_SnO_Investigate_OldGuard`
- `BaseGame.Turn05_SnO_Investigate_Oligarchs`
- `BaseGame.Turn05_SnO_Investigate_Opposition`
- `BaseGameSupport.Journal_Turn05_Investigations_OldGuard`
- `BaseGameSupport.Journal_Turn05_Investigations_Oligarchs`
- `BaseGameSupport.Journal_Turn05_Investigations_Reformists`
- `BaseGameSupport.News_Turn05_HP_ACPFormed`
- `BaseGameSupport.News_Turn05_HP_CPFormed`
- `GameCondition.Turn05_SnO_FoundedPolice`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"“We need to find out who has ulterior motives and root them out of the administrat..."** | `[100]` **Lucian Galade**: "“We always suspected the existen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Karl Greiser**: "“I couldn't agree more. Anyone w..." |
| `[7]` | **"“I guess Minister Morgna is on our side on this. She really wants to tackle corrup..."** | `[100]` **Lucian Galade**: "“We always suspected the existen..." | `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false` | *Brak zmian stanu* | `[105]` **Karl Greiser**: "“Yes, she does, despite constant..." |
| `[8]` | **"“Keep pursuing this Karl. If you encounter any obstacles, my full authority will p..."** | `[100]` **Lucian Galade**: "“We always suspected the existen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Karl Greiser**: "“Thank you, sir. I will be relen..." |
| `[18]` | **"“Focus Anti-Corruption investigations on Hawker and the Old Guard.”"** | `[254]` **Karl Greiser**: "“Where should we concentrate our..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] = tr...`<br>`Variable["BaseGame.Faction_OldGuard_Content"] = false;` | `[255]` **Karl Greiser**: "“Yes, sir. We will focus our res..." |
| `[25]` | **"“The economy must be controlled by the state. Lotherberg has too much influence.”"** | `[110]` **Karl Greiser**: "“And they seem to be evading tax..." | `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true` | *Brak zmian stanu* | `[155]` **Karl Greiser**: "“You are correct, President Rayn..." |
| `[28]` | **"“You are right, I need to go out more often nowadays.”"** | `[27]` **Narrator**: "The weather outside was beautifu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Karl Greiser**: "“Good idea. And when you do, the..." |
| `[29]` | **"“The weather isn't of much concern right now.”"** | `[27]` **Narrator**: "The weather outside was beautifu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Karl Greiser**: "“Of course, sir.”" |
| `[30]` | **"“Good to see you, Karl. How have you been?”"** | `[27]` **Narrator**: "The weather outside was beautifu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Karl Greiser**: "“Very good. Thanks to the increa..."<br>`[185]` **Karl Greiser**: "“It's fine, sir. The Emergency A..."<br>*(oraz 1 innych odgałęzień)* |
| `[45]` | **"“People like us know the additional steps that need to be climbed to get anywhere ..."** | `[23]` **Karl Greiser**: "“I have been used to being uncom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Karl Greiser**: "“I used to work 15 hours a day t..." |
| `[46]` | **"“We both did well for ourselves, Karl.”"** | `[23]` **Karl Greiser**: "“I have been used to being uncom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Karl Greiser**: "“Indeed, sir. One way or another..." |
| `[47]` | **"Don't comment."** | `[23]` **Karl Greiser**: "“I have been used to being uncom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Narrator**: "He took a seat and corrected his..." |
| `[52]` | **"“You're a good man, Karl. I still owe you for protecting me and my family.”"** | `[49]` **Karl Greiser**: "“Indeed, sir. One way or another..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Karl Greiser**: "“I did my job. But beyond that I..." |
| `[53]` | **"“Nothing comes free and easy, that's for sure.”"** | `[49]` **Karl Greiser**: "“Indeed, sir. One way or another..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Karl Greiser**: "“We see eye to eye.”" |
| `[54]` | **"“So, are you very close with Mrs. Graf?”"** | `[51]` **Karl Greiser**: "“That allowed me to enter the Ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Karl Greiser**: "“She played a major role in my l..." |
| `[55]` | **"“So, she's the one who got you this far, eh?”"** | `[51]` **Karl Greiser**: "“That allowed me to enter the Ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Karl Greiser**: "“I'd like to think that it was m..." |
| `[58]` | **"“We can rise even higher if we dare to dream.”"** | `[49]` **Karl Greiser**: "“Indeed, sir. One way or another..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Karl Greiser**: "“Then we will.”" |
| `[60]` | **"“Hard-working and loyal people are hard to come by. I need people like you.”"** | `[51]` **Karl Greiser**: "“That allowed me to enter the Ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Karl Greiser**: "“My loyalties lie with you, Mr. ..." |
| `[66]` | **"“She takes her work personally. Her motivations to fight corruption are real.”"** | `[65]` **Karl Greiser**: "“Minister Morgna —though not as ..." | `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false` | *Brak zmian stanu* | `[91]` **Karl Greiser**: "“Thanks to the resource diversio..."<br>`[77]` **Karl Greiser**: "“Her drive certainly is, but the..." |
| `[67]` | **"“So the Anti-Corruption Police is separated from the Interior?”"** | `[65]` **Karl Greiser**: "“Minister Morgna —though not as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Karl Greiser**: "“Yes. It is for a good reason. W..." |
| `[68]` | **"“You are our best man for the job and I am sure you will excel at it.”"** | `[65]` **Karl Greiser**: "“Minister Morgna —though not as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Karl Greiser**: "“Thanks for the good words. You ..." |
| `[71]` | **"“Why would she?”"** | `[69]` **Karl Greiser**: "“Minister Graf —though not as in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Karl Greiser**: "“Why would anyone pose a threat?..." |
| `[72]` | **"“The only thing that matters is that you only take orders from me, and not anyone ..."** | `[69]` **Karl Greiser**: "“Minister Graf —though not as in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Karl Greiser**: "“That won't change sir. I was ju..." |
| `[73]` | **"“Minister Graf is our close ally in the cabinet. I don't want similar words uttere..."** | `[69]` **Karl Greiser**: "“Minister Graf —though not as in..." | `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true` | *Brak zmian stanu* | `[204]` **Karl Greiser**: "“Affirmative. Won't happen again.”" |
| `[74]` | **"“The gangs are concentrated in that city aren't they?”"** | `[70]` **Karl Greiser**: "“The Nargis, Agnland and Bergia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Karl Greiser**: "“Yes, they have a lot of presenc..." |
| `[75]` | **"“Lileas Graf has a good security history. You will handle them with her.”"** | `[70]` **Karl Greiser**: "“The Nargis, Agnland and Bergia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Karl Greiser**: "“Of course, sir. We are working ..." |
| `[76]` | **"“If you are successful, a better future awaits you in the administration.”"** | `[70]` **Karl Greiser**: "“The Nargis, Agnland and Bergia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Karl Greiser**: "“I won't disappoint you, sir.”" |
| `[86]` | **"“What do you mean?”"** | `[84]` **Karl Greiser**: "“There are elements within our s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Karl Greiser**: "“May I speak frankly, sir?”" |
| `[87]` | **"“Elaborate, please.”"** | `[84]` **Karl Greiser**: "“There are elements within our s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Karl Greiser**: "“May I speak frankly, sir?”" |
| `[96]` | **"“Sure. You are among friends.”"** | `[95]` **Karl Greiser**: "“May I speak frankly, sir?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Karl Greiser**: "“There are some very powerful de..."<br>`[99]` **Karl Greiser**: "“I am a supporter of the Emergen..." |
| `[97]` | **"“Of course.”"** | `[95]` **Karl Greiser**: "“May I speak frankly, sir?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Karl Greiser**: "“There are some very powerful de..."<br>`[99]` **Karl Greiser**: "“I am a supporter of the Emergen..." |
| `[108]` | **"“Bribery should be eradicated from the system.”"** | `[110]` **Karl Greiser**: "“And they seem to be evading tax..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Karl Greiser**: "“We will do our best, sir. It pl..." |
| `[109]` | **"“We could look further into Tusk and the Lotherberg group.”"** | `[110]` **Karl Greiser**: "“And they seem to be evading tax..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Karl Greiser**: "“If that is your desire, we can ..." |
| `[119]` | **"“Don't poke the bear when we are not ready to fight it. Maintain low-key operations.”"** | `[100]` **Lucian Galade**: "“We always suspected the existen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Karl Greiser**: "“Our police is made up of only t..." |
| `[128]` | **"“I don't always see eye to eye with her, but we might be allies on this topic.”"** | `[65]` **Karl Greiser**: "“Minister Morgna —though not as ..." | `Variable["BaseGame.Relations_Nia_Opposition"] == true` | *Brak zmian stanu* | `[129]` **Karl Greiser**: "“I think our enemies are common ..." |
| `[133]` | **"“I'm not sure if Morgna can be fully trusted. What if she turns this force against..."** | `[100]` **Lucian Galade**: "“We always suspected the existen..." | `Variable["BaseGame.Relations_Nia_Opposition"] == true` | *Brak zmian stanu* | `[134]` **Karl Greiser**: "“That would be unlikely, wouldn'..." |
| `[152]` | **"“Tusk is an issue but he shouldn't be our primary target. There are bigger fish to..."** | `[110]` **Karl Greiser**: "“And they seem to be evading tax..." | `Variable["BaseGame.Faction_Oligarchs_Content"] == true` | *Brak zmian stanu* | `[102]` **Karl Greiser**: "“Very well, sir.”" |
| `[157]` | **""Who cares about him, anyway...""** | `[238]` **Karl Greiser**: "“It really seems like they have ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Lucian Galade**: "“It's not good to underestimate ..." |
| `[158]` | **"“Mr. Koronti has been very supportive of my administration. He is a close friend.”"** | `[238]` **Karl Greiser**: "“It really seems like they have ..." | `Variable["BaseGame.Media_SordlandToday_Bias"] == true` | *Brak zmian stanu* | `[233]` **Karl Greiser**: "“He might not be innocent, but i..." |
| `[159]` | **"“Marcel offered me a deal before, and needs to be investigated.”"** | `[238]` **Karl Greiser**: "“It really seems like they have ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Karl Greiser**: "“We certainly can. I wish we had..." |
| `[160]` | **"“Focus Anti-Corruption investigations on Tusk and the Oligarchs.”"** | `[254]` **Karl Greiser**: "“Where should we concentrate our..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] = t...`<br>`Variable["BaseGame.Faction_Oligarchs_Content"] = false;` | `[256]` **Karl Greiser**: "“Yes, sir. We will focus our res..." |
| `[162]` | **"“We need to protect and keep our communities safe. This is another step towards th..."** | `[227]` **Karl Greiser**: "“I've had many of my trusted off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Karl Greiser**: "“The enhanced local security and..." |
| `[163]` | **"“If communities, especially of ethnic descent, gain more responsibility in their o..."** | `[227]` **Karl Greiser**: "“I've had many of my trusted off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Karl Greiser**: "“Harsher police action does not ..." |
| `[164]` | **"“How did we ever come to this low point?”"** | `[227]` **Karl Greiser**: "“I've had many of my trusted off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Karl Greiser**: "“The recession has allowed these..." |
| `[167]` | **"“It's a very powerful force. One that didn't exist in Sordland before.”"** | `[166]` **Karl Greiser**: "“Indeed so. Minister Morgna has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Karl Greiser**: "“The structure being separated f..." |
| `[168]` | **"“The important question for us is where your loyalties lie.”"** | `[166]` **Karl Greiser**: "“Indeed so. Minister Morgna has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Karl Greiser**: "“I serve my country and its lead..." |
| `[169]` | **"“Congratulations. I hope we'll be close partners in the fight against corruption.”"** | `[166]` **Karl Greiser**: "“Indeed so. Minister Morgna has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Karl Greiser**: "“Sir, we have a tough and long f..." |
| `[170]` | **"“There are too many enemies inside Sordland. They need to be found and imprisoned.”"** | `[165]` **Karl Greiser**: "“Correct. Minister Graf has give..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Karl Greiser**: "“Our established forces has begu..." |
| `[171]` | **"“The important question for us is where your loyalties lie.”"** | `[165]` **Karl Greiser**: "“Correct. Minister Graf has give..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Karl Greiser**: "“I serve my country and its lead..." |
| `[172]` | **"“It's a very powerful force. One that didn't exist in Sordland before.”"** | `[165]` **Karl Greiser**: "“Correct. Minister Graf has give..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Karl Greiser**: "“Yes. We have great powers regar..." |
| `[188]` | **"“We need to find out about their weaknesses, just in case.”"** | `[223]` **Karl Greiser**: "“Minister Morgna is very concern..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[198]` **Karl Greiser**: "“In that case, the department wi..." |
| `[189]` | **"“Don't worry about Hawker. He is aiding our administration.”"** | `[223]` **Karl Greiser**: "“Minister Morgna is very concern..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Karl Greiser**: "“Very well, sir.”" |
| `[193]` | **"“Good day and good luck, Mr. Greiser.”"** | `[266]` **Lucian Galade**: "“Well, it has been decided. That..."<br>`[267]` **Karl Greiser**: "“I am very glad you have taken s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Karl Greiser**: "“Good day, sir.”" |
| `[194]` | **"“Thank you for your time Karl.”"** | `[266]` **Lucian Galade**: "“Well, it has been decided. That..."<br>`[267]` **Karl Greiser**: "“I am very glad you have taken s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Karl Greiser**: "“It is a privilege to work with ..." |
| `[202]` | **"“Me and Lileas see eye to eye on many issues. I wouldn't worry about her.”"** | `[69]` **Karl Greiser**: "“Minister Graf —though not as in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Karl Greiser**: "“She holds immense power in the ..." |
| `[212]` | **"“Yes. You are among confidants.”"** | `[213]` **Karl Greiser**: "“May I speak frankly, sir?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Karl Greiser**: "“There are some very powerful de..."<br>`[378]` **Karl Greiser**: "“The Reformists are a threat to ..." |
| `[214]` | **"“Of course.”"** | `[213]` **Karl Greiser**: "“May I speak frankly, sir?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Karl Greiser**: "“There are some very powerful de..."<br>`[378]` **Karl Greiser**: "“The Reformists are a threat to ..." |
| `[215]` | **"“Elaborate please.”"** | `[211]` **Karl Greiser**: "“There are elements within our s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Karl Greiser**: "“May I speak frankly, sir?”" |
| `[216]` | **"“What do you mean?”"** | `[211]` **Karl Greiser**: "“There are elements within our s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Karl Greiser**: "“May I speak frankly, sir?”" |
| `[229]` | **"“The crime families need to be taken down. We can't let them do what they want wit..."** | `[227]` **Karl Greiser**: "“I've had many of my trusted off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Karl Greiser**: "“We are fighting them already, a..." |
| `[237]` | **"“Focus Anti-Corruption investigations on the opposition.""** | `[254]` **Karl Greiser**: "“Where should we concentrate our..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] = ...` | `[257]` **Karl Greiser**: "“Yes, sir. We will focus our res..." |
| `[241]` | **"“Frens Ricter is our ally and we shouldn't move against him.”"** | `[81]` **Lucian Galade**: "“The Old Guard must have pushed ..." | `Variable["BaseGame.Reform_Reformist_Path"] == true` | *Brak zmian stanu* | `[248]` **Karl Greiser**: "“Very well, sir.”" |
| `[242]` | **"“There is nothing illegal, so why even talk about this?”"** | `[81]` **Lucian Galade**: "“The Old Guard must have pushed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Karl Greiser**: "“I wanted to disclose all of the..." |
| `[243]` | **"“Ricter is a loyal servant of Sordland. The Old Guard is trying to pressure him.”"** | `[81]` **Lucian Galade**: "“The Old Guard must have pushed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Karl Greiser**: "“The way we received this intell..." |
| `[247]` | **"“He must have some dirt on him. We should look deeper.”"** | `[81]` **Lucian Galade**: "“The Old Guard must have pushed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Karl Greiser**: "“Everyone has something, usually..." |
| `[271]` | **"“The increased Interior budget should allow us to diminish them.”"** | `[70]` **Karl Greiser**: "“The Nargis, Agnland and Bergia ..." | `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true` | *Brak zmian stanu* | `[272]` **Karl Greiser**: "“It already has. We are receivin..." |
| `[274]` | **"“Make sure the force represents the diverse makeup of the neighborhoods in which i..."** | `[279]` **Karl Greiser**: "“We are ensuring that people tak..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Karl Greiser**: "“Very well, sir. We will ensure ..." |
| `[275]` | **"“Make sure to pick the right people for the job and have solid background checks.”"** | `[279]` **Karl Greiser**: "“We are ensuring that people tak..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Karl Greiser**: "“I have personally picked the in..." |
| `[276]` | **"“Don't arm the Community Police. We shouldn't trust them yet.”"** | `[279]` **Karl Greiser**: "“We are ensuring that people tak..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Karl Greiser**: "“I understand your perspective. ..." |
| `[283]` | **"“He must have some dirt on him. We might need to look deeper.”"** | `[284]` **Lucian Galade**: "“The Old Guard must have pushed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Karl Greiser**: "“Everyone has something, usually..." |
| `[287]` | **"“Frens Ricter should be investigated in full.”"** | `[284]` **Lucian Galade**: "“The Old Guard must have pushed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Karl Greiser**: "“Yes sir. If you think he is an ..." |
| `[288]` | **"“There is nothing illegal, so why even talk about this?”"** | `[284]` **Lucian Galade**: "“The Old Guard must have pushed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[293]` **Karl Greiser**: "“I wanted to fully disclose all ..." |
| `[289]` | **"“Ricter is a loyal servant of Sordland. Old Guards are trying to pressure him.”"** | `[284]` **Lucian Galade**: "“The Old Guard must have pushed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Karl Greiser**: "“The way we received this intell..." |
| `[310]` | **"“I guess Minister Morgna is on our side on this. She really wants to tackle corrup..."** | `[309]` **Lucian Galade**: "“We always suspected that they w..." | `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false` | *Brak zmian stanu* | `[311]` **Karl Greiser**: "“Yes. And she is constantly enco..." |
| `[312]` | **"“Don't poke the bear when we are not ready to fight it. Maintain low-key operations.”"** | `[309]` **Lucian Galade**: "“We always suspected that they w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Karl Greiser**: "“Our agency is made up of the mo..." |
| `[315]` | **"“Not sure if Graf can be fully trusted. What if she turns this force against us?”"** | `[309]` **Lucian Galade**: "“We always suspected that they w..." | `Variable["BaseGame.Relations_Nia_Opposition"] == true` | *Brak zmian stanu* | `[316]` **Karl Greiser**: "“That would be unlikely wouldn't..." |
| `[320]` | **"“We need to find out who has ulterior motives and root them out of the administrat..."** | `[309]` **Lucian Galade**: "“We always suspected that they w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Karl Greiser**: "“I couldn't agree more. Anyone w..." |
| `[321]` | **"“Keep pursuing this Karl. If you encounter any obstacles, my full authority will p..."** | `[309]` **Lucian Galade**: "“We always suspected that they w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Karl Greiser**: "“Thank you sir, I will be relent..." |
| `[324]` | **"“Focus Secret State Police investigations on Hawker and the Old Guard.”"** | `[372]` **Karl Greiser**: "“Where should we concentrate our..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] = tr...`<br>`Variable["BaseGame.Faction_OldGuard_Content"] = false;` | `[329]` **Karl Greiser**: "“Yes, sir. We will focus our res..." |
| `[325]` | **"“Focus Secret State Police investigations on Tusk and the Oligarchs.”"** | `[372]` **Karl Greiser**: "“Where should we concentrate our..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] = t...` | `[327]` **Karl Greiser**: "“Yes, sir. We will focus our res..." |
| `[326]` | **"“Focus Secret State Police investigations on the opposition parties.”"** | `[372]` **Karl Greiser**: "“Where should we concentrate our..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] = ...` | `[328]` **Karl Greiser**: "“Yes, sir. We will focus our res..." |
| `[344]` | **"“Who cares about him, anyway...”"** | `[350]` **Karl Greiser**: "“It really seems like they have ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Lucian Galade**: "“It's not good to underestimate ..." |
| `[345]` | **"“Mr. Koronti has been very supportive of my administration. He is a close friend.”"** | `[350]` **Karl Greiser**: "“It really seems like they have ..." | `Variable["BaseGame.Media_SordlandToday_Bias"] == true` | *Brak zmian stanu* | `[330]` **Karl Greiser**: "“He might not be innocent, sir. ..." |
| `[346]` | **"“Marcel offered me a deal before. He needs to be investigated in full.”"** | `[350]` **Karl Greiser**: "“It really seems like they have ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Karl Greiser**: "“We certainly can do so. I wish ..." |
| `[349]` | **"“Tusk is an issue, but he shouldn't be our primary target. There are bigger fish t..."** | `[339]` **Karl Greiser**: "“And it is suspected that they a..." | `Variable["BaseGame.Faction_Oligarchs_Content"] == true` | *Brak zmian stanu* | `[331]` **Karl Greiser**: "“Very well, sir. If he isn't a b..." |
| `[351]` | **"“The Oligarchs pose a larger threat to our administration. We need to curb them im..."** | `[339]` **Karl Greiser**: "“And it is suspected that they a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Karl Greiser**: "“If that is your desire, we can ..." |
| `[352]` | **"“The economy must be controlled by the state. Lotherberg has too much influence.”"** | `[339]` **Karl Greiser**: "“And it is suspected that they a..." | `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true` | *Brak zmian stanu* | `[347]` **Karl Greiser**: "“You are correct, President Rayn..." |
| `[353]` | **"“Bribery should be eradicated from the system.”"** | `[339]` **Karl Greiser**: "“And it is suspected that they a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[336]` **Karl Greiser**: "“We will do our best, sir. It pl..." |
| `[359]` | **"“We need to find out about their weaknesses, just in case.”"** | `[365]` **Karl Greiser**: "“Minister Morgna is very concern..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[362]` **Karl Greiser**: "“In that case, the department wi..." |
| `[360]` | **"“Don't worry about Hawker. He is aiding our administration.”"** | `[365]` **Karl Greiser**: "“Minister Morgna is very concern..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Karl Greiser**: "“Very well, sir.”" |
| `[379]` | **"“That's exactly what I want you to do.”"** | `[213]` **Karl Greiser**: "“May I speak frankly, sir?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Karl Greiser**: "“There are some very powerful de..."<br>`[378]` **Karl Greiser**: "“The Reformists are a threat to ..." |

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
  - -> `[4]` (*Narrator: "Karl Greiser arrived for a meeting to discuss the new pol..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "“We need to find out who has ulterior motives and root them out of the administration.”"]** — Mówca: **Player**
> "“We need to find out who has ulterior motives and root them out of the administration.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Karl Greiser: "“I couldn't agree more. Anyone who corrupts our system an..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Karl Greiser arrived for a meeting to discuss the new police force. After Livia informed us of his arrival, Lucian opened the door and let him in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Karl Greiser: "“Hello, Mr. President. Mr. Galade. What a sunny day, isn'..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_SnO_FoundedPolice = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_SnO_FoundedPolice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Karl and Lucian left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“I guess Minister Morgna is on our side on this. She really wants to tackle corruption inside.”"]** — Mówca: **Player**
> "“I guess Minister Morgna is on our side on this. She really wants to tackle corruption inside.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[100]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Karl Greiser: "“Yes, she does, despite constantly encountering resistanc..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Keep pursuing this Karl. If you encounter any obstacles, my full authority will protect you.”"]** — Mówca: **Player**
> "“Keep pursuing this Karl. If you encounter any obstacles, my full authority will protect you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Karl Greiser: "“Thank you, sir. I will be relentless. The adversaries of..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == t..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: "“We have been informed of the establishment of the Anti-C..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: "“We have been informed of the establishment of the Secret..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucian Galade: "“We have been informed of the establishment of the Commun..."*)

### Węzeł `[15]`
Mówca: **Karl Greiser**
> "“I want to make it absolutely clear. My belief in you as a leader is unquestionable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Karl Greiser: "“Minister Morgna —though not as inspiring as you are— has..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Karl sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Karl Greiser: "“Last but not least is the opposition leader Frens Ricter..."*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> "“We have been informed of the establishment of the Anti-Corruption Police under the Ministry of Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Karl Greiser: "“Indeed so. Minister Morgna has given me full authority t..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Focus Anti-Corruption investigations on Hawker and the Old Guard.”"]** — Mówca: **Player**
> "“Focus Anti-Corruption investigations on Hawker and the Old Guard.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_OldGuard = true; BaseGame..."*)

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“We have been informed of the establishment of the Community Police under the Ministry of Interior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Karl Greiser: "“Yes. Minister Graf has given me full authority to lead t..."*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> "“We have been informed of the establishment of the Secret State Police under the Ministry of Interior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Karl Greiser: "“Correct. Minister Graf has given me full authority to le..."*)

### Węzeł `[21]`
Mówca: **Karl Greiser**
> "“Our current efforts have been successful at containing these gangs. This force will ensure the reduction of crime in neighbourhoods.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Karl Greiser: "“The Nargis, Agnland and Bergia regions are suffering fro..."*)

### Węzeł `[22]`
Mówca: **Karl Greiser**
> "“I want to make it absolutely clear. My belief in you as a leader is unquestionable. Consider me as your inside man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Karl Greiser: "“Minister Graf —though not as inspiring as you are— has a..."*)

### Węzeł `[23]`
Mówca: **Karl Greiser**
> "“I have been used to being uncomfortable my whole life. I too came from a poor family, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: "“People like us know the additional steps that need to be..."*)
  - -> `[46]` (*Player: "“We both did well for ourselves, Karl.”"*)
  - -> `[47]` (*Player_Italic: "Don't comment."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "He took a seat and corrected his posture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“The economy must be controlled by the state. Lotherberg has too much influence.”"]** — Mówca: **Player**
> "“The economy must be controlled by the state. Lotherberg has too much influence.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Kontekst wejściowy (poprzednik):** `[110]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Karl Greiser: "“You are correct, President Rayne. They need to be looked..."*)

### Węzeł `[26]`
Mówca: **Karl Greiser**
> "“Hello, Mr. President. Mr. Galade. What a sunny day, isn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "The weather outside was beautiful indeed. Clear sky and s..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "The weather outside was beautiful indeed. Clear sky and sunshine made the scenery look lively. I could even hear the sounds of birds chirping from the palace garden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: "“You are right, I need to go out more often nowadays.”"*)
  - -> `[30]` (*Player: "“Good to see you, Karl. How have you been?”"*)
  - -> `[29]` (*Player: "“The weather isn't of much concern right now.”"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“You are right, I need to go out more often nowadays.”"]** — Mówca: **Player**
> "“You are right, I need to go out more often nowadays.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Karl Greiser: "“Good idea. And when you do, the Presidential Guard will ..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“The weather isn't of much concern right now.”"]** — Mówca: **Player**
> "“The weather isn't of much concern right now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Karl Greiser: "“Of course, sir.”"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Good to see you, Karl. How have you been?”"]** — Mówca: **Player**
> "“Good to see you, Karl. How have you been?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)

### Węzeł `[31]`
Mówca: **Karl Greiser**
> "“Good idea. And when you do, the Presidential Guard will be there to protect you, as always.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucian Galade: "“Please have a seat. We don't want you to feel uncomforta..."*)

### Węzeł `[32]`
Mówca: **Karl Greiser**
> "“Very good. Thanks to the increased budget at the Interior, we have been combatting a lot of the issues that plagued us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Karl Greiser: "“My position bears more responsibility now.”"*)

### Węzeł `[33]`
Mówca: **Karl Greiser**
> "“Of course, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucian Galade: "“Please have a seat. We don't want you to feel uncomforta..."*)

### Węzeł `[34]`
Mówca: **Lucian Galade**
> "“Please have a seat. We don't want you to feel uncomfortable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)

### Węzeł `[35]`
Mówca: **Karl Greiser**
> "“It's been going okay. We have tackled many security issues but there are still some to go through.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Karl Greiser: "“But more importantly, the security situation in the coun..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Karl Greiser: "“Very good. Thanks to the increased budget at the Interio..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[39]`
Mówca: **Karl Greiser**
> "“My position bears more responsibility now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Karl Greiser: "“But more importantly, the security situation in the coun..."*)

### Węzeł `[40]`
Mówca: **Karl Greiser**
> "“But more importantly, the security situation in the country is much more stable, allowing people to return to a normal life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucian Galade: "“Please have a seat. We don't want you to feel uncomforta..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "He didn't sit down and walked a few steps towards the wal..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Karl Greiser: "“I am used to being uncomfortable.”"*)

### Węzeł `[44]`
Mówca: **Karl Greiser**
> "“I am used to being uncomfortable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He took a seat and corrected his posture."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“People like us know the additional steps that need to be climbed to get anywhere in life.”"]** — Mówca: **Player**
> "“People like us know the additional steps that need to be climbed to get anywhere in life.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Karl Greiser: "“I used to work 15 hours a day to bring food back to my s..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“We both did well for ourselves, Karl.”"]** — Mówca: **Player**
> "“We both did well for ourselves, Karl.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Karl Greiser: "“Indeed, sir. One way or another we took what we deserved..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I didn't comment."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He took a seat and corrected his posture."*)

### Węzeł `[48]`
Mówca: **Karl Greiser**
> "“I used to work 15 hours a day to bring food back to my sisters. My entire life was been a struggle until I signed up to be a volunteer in the Arvory police force.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Karl Greiser: "“They gave me a scholarship to attend the police academy...."*)

### Węzeł `[49]`
Mówca: **Karl Greiser**
> "“Indeed, sir. One way or another we took what we deserved, and life has rewarded us for it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: "“Nothing comes free and easy, that's for sure.”"*)
  - -> `[52]` (*Player: "“You're a good man, Karl. I still owe you for protecting ..."*)
  - -> `[58]` (*Player: "“We can rise even higher if we dare to dream.”"*)

### Węzeł `[50]`
Mówca: **Karl Greiser**
> "“They gave me a scholarship to attend the police academy. An opportunity I wouldn't have been able to have, if I didn't work diligently.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Karl Greiser: "“That allowed me to enter the Arvory Police Force as a pa..."*)

### Węzeł `[51]`
Mówca: **Karl Greiser**
> "“That allowed me to enter the Arvory Police Force as a patrolman and to meet Ms. Graf, who opened several doors that led me to better places.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: "“So, are you very close with Mrs. Graf?”"*)
  - -> `[55]` (*Player: "“So, she's the one who got you this far, eh?”"*)
  - -> `[60]` (*Player: "“Hard-working and loyal people are hard to come by. I nee..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“You're a good man, Karl. I still owe you for protecting me and my family.”"]** — Mówca: **Player**
> "“You're a good man, Karl. I still owe you for protecting me and my family.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Karl Greiser: "“I did my job. But beyond that I would easily risk my lif..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Nothing comes free and easy, that's for sure.”"]** — Mówca: **Player**
> "“Nothing comes free and easy, that's for sure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Karl Greiser: "“We see eye to eye.”"*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "“So, are you very close with Mrs. Graf?”"]** — Mówca: **Player**
> "“So, are you very close with Mrs. Graf?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Karl Greiser: "“She played a major role in my life and she still is my s..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "“So, she's the one who got you this far, eh?”"]** — Mówca: **Player**
> "“So, she's the one who got you this far, eh?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Karl Greiser: "“I'd like to think that it was my own skills and experien..."*)

### Węzeł `[56]`
Mówca: **Karl Greiser**
> "“I did my job. But beyond that I would easily risk my life to save the President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He took a seat and corrected his posture."*)

### Węzeł `[57]`
Mówca: **Karl Greiser**
> "“We see eye to eye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He took a seat and corrected his posture."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“We can rise even higher if we dare to dream.”"]** — Mówca: **Player**
> "“We can rise even higher if we dare to dream big.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Karl Greiser: "“Then we will.”"*)

### Węzeł `[59]`
Mówca: **Karl Greiser**
> "“Then we will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He took a seat and corrected his posture."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Hard-working and loyal people are hard to come by. I need people like you.”"]** — Mówca: **Player**
> "“Hard-working and loyal people are hard to come by. I need people like you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Karl Greiser: "“My loyalties lie with you, Mr. President. No one else.”"*)

### Węzeł `[61]`
Mówca: **Karl Greiser**
> "“She played a major role in my life and she still is my superior. But to be honest, my motivations lie with serving the country. And right now that means serving you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He took a seat and corrected his posture."*)

### Węzeł `[62]`
Mówca: **Karl Greiser**
> "“I'd like to think that it was my own skills and experience, sir. But of course, I cannot deny that she had a huge impact on my career.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He took a seat and corrected his posture."*)

### Węzeł `[63]`
Mówca: **Karl Greiser**
> "“My loyalties lie with you, Mr. President. No one else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He took a seat and corrected his posture."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "He didn't sit down and walked a few steps towards the wall where President Alphonso's portrait was hanging."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Karl Greiser: "“I have been used to being uncomfortable my whole life. I..."*)

### Węzeł `[65]`
Mówca: **Karl Greiser**
> "“Minister Morgna —though not as inspiring as you are— has also shown great capability. The more I work with her, the more I am convinced that she is a very motivated and efficient administrator.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[67]` (*Player: "“So the Anti-Corruption Police is separated from the Inte..."*)
  - -> `[68]` (*Player: "“You are our best man for the job and I am sure you will ..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“She takes her work personally. Her motivations to fight corruption are real.”"]** — Mówca: **Player**
> "“She takes her work personally. Her motivations to fight corruption are real.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[65]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Increased == true"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“So the Anti-Corruption Police is separated from the Interior?”"]** — Mówca: **Player**
> "“So the Anti-Corruption Police is separated from the Interior?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Karl Greiser: "“Yes. It is for a good reason. We have found some irregul..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“You are our best man for the job and I am sure you will excel at it.”"]** — Mówca: **Player**
> "“You are our best man for the job and I am sure you will excel at it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Karl Greiser: "“Thanks for the good words. You honor me, but our job is ..."*)

### Węzeł `[69]`
Mówca: **Karl Greiser**
> "“Minister Graf —though not as inspiring as you are— has also shown great capability. But the more I work with her, the more I am convinced that she herself might pose a threat to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player: "“Me and Lileas see eye to eye on many issues. I wouldn't ..."*)
  - -> `[71]` (*Player: "“Why would she?”"*)
  - -> `[72]` (*Player: "“The only thing that matters is that you only take orders..."*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)

### Węzeł `[70]`
Mówca: **Karl Greiser**
> "“The Nargis, Agnland and Bergia regions are suffering from most of the crime issues. Out of all Estord seems to be the hot spot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "“The gangs are concentrated in that city aren't they?”"*)
  - -> `[75]` (*Player: "“Lileas Graf has a good security history. You will handle..."*)
  - -> `[76]` (*Player: "“If you are successful, a better future awaits you in the..."*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“Why would she?”"]** — Mówca: **Player**
> "“Why would she?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Karl Greiser: "“Why would anyone pose a threat? Because of the power the..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“The only thing that matters is that you only take orders from me, and not anyone else.”"]** — Mówca: **Player**
> "“The only thing that matters is that you only take orders from me, and not anyone else.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Karl Greiser: "“That won't change sir. I was just trying to give you som..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“Minister Graf is our close ally in the cabinet. I don't want similar words uttered again.”"]** — Mówca: **Player**
> "“Minister Graf is our close ally in the cabinet. I don't want similar words uttered again.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Kontekst wejściowy (poprzednik):** `[69]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Karl Greiser: "“Affirmative. Won't happen again.”"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“The gangs are concentrated in that city aren't they?”"]** — Mówca: **Player**
> "“The gangs are concentrated in that city aren't they?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Karl Greiser: "“Yes, they have a lot of presence there. Our efforts are ..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Lileas Graf has a good security history. You will handle them with her.”"]** — Mówca: **Player**
> "“Lileas Graf has a good security history. You will handle them with her.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Karl Greiser: "“Of course, sir. We are working in close collaboration wi..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“If you are successful, a better future awaits you in the administration.”"]** — Mówca: **Player**
> "“If you are successful, a better future awaits you in the administration.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Karl Greiser: "“I won't disappoint you, sir.”"*)

### Węzeł `[77]`
Mówca: **Karl Greiser**
> "“Her drive certainly is, but there are real obstacles nonetheless. This new force can help in removing those.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Karl leaned closer and lowered his voice ever so slightly."*)

### Węzeł `[78]`
Mówca: **Karl Greiser**
> "“Therefore, having the new police force separated from the Interior helps its independence and objectivity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Karl leaned closer and lowered his voice ever so slightly."*)

### Węzeł `[79]`
Mówca: **Karl Greiser**
> "“Yes. It is for a good reason. We have found some irregularities in our police forces. Some of our top officers are involved with corruption.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Karl Greiser: "“Therefore, having the new police force separated from th..."*)

### Węzeł `[80]`
Mówca: **Karl Greiser**
> "“Thanks for the good words. You honor me, but our job is not yet done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Karl leaned closer and lowered his voice ever so slightly."*)

### Węzeł `[81]`
Mówca: **Lucian Galade**
> "“The Old Guard must have pushed this forward. We shouldn't even consider moving on the reformist leader in our position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[242]` (*Player: "“There is nothing illegal, so why even talk about this?”"*)
  - -> `[243]` (*Player: "“Ricter is a loyal servant of Sordland. The Old Guard is ..."*)
  - -> `[247]` (*Player: "“He must have some dirt on him. We should look deeper.”"*)

### Węzeł `[82]`
Mówca: **Lucian Galade**
> "“Hawker, Heron and their cronies in the Supreme Court won't be able to be prosecuted unless the Assembly agrees to in our new constitution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lucian Galade: "“It won't be possible to get them if we fail to pass the ..."*)

### Węzeł `[83]`
Mówca: **Lucian Galade**
> "“The Community Police is driven by local enforcement and will aid us in our internal security efforts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Karl Greiser: "“I also wanted to point out that hundreds of Agno-Sordish..."*)

### Węzeł `[84]`
Mówca: **Karl Greiser**
> "“There are elements within our state that have ulterior motives.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: "“What do you mean?”"*)
  - -> `[87]` (*Player: "“Elaborate, please.”"*)

### Węzeł `[85]`
Mówca: **Karl Greiser**
> "“Why would anyone pose a threat? Because of the power they hold, of course. I can easily tell you that she pulls many strings. Ambition is a dangerous thing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "Karl leaned closer and lowered his voice ever so slightly."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "“What do you mean?”"]** — Mówca: **Player**
> "“What do you mean?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Karl Greiser: "“May I speak frankly, sir?”"*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "“Elaborate, please.”"]** — Mówca: **Player**
> "“Elaborate, please.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Karl Greiser: "“May I speak frankly, sir?”"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Justice_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Increased == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Justice_Increased == true)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Justice_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Karl Greiser: "“Thanks to the resource diversion to her ministry, those ..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Justice_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Karl Greiser: "“Her drive certainly is, but there are real obstacles non..."*)

### Węzeł `[91]`
Mówca: **Karl Greiser**
> "“Thanks to the resource diversion to her ministry, those objectives can now be met. Justice will indeed be served.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Karl leaned closer and lowered his voice ever so slightly."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true || BaseGame.Refo..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Karl Greiser: "“There are some very powerful deep state forces inside th..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Karl Greiser: "“I am a supporter of the Emergency Act and the expanded p..."*)

### Węzeł `[95]`
Mówca: **Karl Greiser**
> "“May I speak frankly, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player: "“Sure. You are among friends.”"*)
  - -> `[97]` (*Player: "“Of course.”"*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "“Sure. You are among friends.”"]** — Mówca: **Player**
> "“Sure. You are among friends.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "“Of course.”"]** — Mówca: **Player**
> "“Of course.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)

### Węzeł `[98]`
Mówca: **Karl Greiser**
> "“There are some very powerful deep state forces inside the administration. Our investigations have just begun, but certain links we have discovered are troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Karl Greiser: "“Mr. Hawker has financial and other ties to certain figur..."*)

### Węzeł `[99]`
Mówca: **Karl Greiser**
> "“I am a supporter of the Emergency Act and the expanded powers given to our police to stabilise the country. We have achieved our goals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Karl Greiser: "“However, I couldn't help but notice that certain high-ra..."*)

### Węzeł `[100]`
Mówca: **Lucian Galade**
> "“We always suspected the existence of such a deep state. The real question here is, who in the government and cabinet is on Mr. Hawker's side?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: "“Don't poke the bear when we are not ready to fight it. M..."*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[3]` (*Player: "“We need to find out who has ulterior motives and root th..."*)
  - -> `[8]` (*Player: "“Keep pursuing this Karl. If you encounter any obstacles,..."*)

### Węzeł `[101]`
Mówca: **Karl Greiser**
> "“Mr. Hawker has financial and other ties to certain figures. He is a dangerous man. Currently, we are collecting evidence to find out exactly what his network comprises.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucian Galade: "“We always suspected the existence of such a deep state. ..."*)

### Węzeł `[102]`
Mówca: **Karl Greiser**
> "“Very well, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Karl Greiser: "“Marcel Koronti and HOS also have a strong presence in th..."*)

### Węzeł `[103]`
Mówca: **Karl Greiser**
> "“I couldn't agree more. Anyone who corrupts our system and creates a parallel organization is a threat to Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lucian Galade: "“The most important subject here is the Old Guard establi..."*)

### Węzeł `[104]`
Mówca: **Karl Greiser**
> "“Thank you, sir. I will be relentless. The adversaries of this country will be found.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lucian Galade: "“The most important subject here is the Old Guard establi..."*)

### Węzeł `[105]`
Mówca: **Karl Greiser**
> "“Yes, she does, despite constantly encountering resistance in the Ministry and other institutions. Morgna is poking around where she isn't wanted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lucian Galade: "“The most important subject here is the Old Guard establi..."*)

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“Once enough evidence is gathered, we should be able to begin the corruption trials if we want to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true"*)

### Węzeł `[107]`
Mówca: **Karl Greiser**
> "“Besides them, there are other elements we are aware of. The Oligarchs seem to have some people in the inside as well. We have received some unconfirmed reports about Mr. Tusk having bought people in the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Karl Greiser: "“And they seem to be evading taxes through bribery and ex..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Bribery should be eradicated from the system.”"]** — Mówca: **Player**
> "“Bribery should be eradicated from the system.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Karl Greiser: "“We will do our best, sir. It plagues us from all ends bu..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“We could look further into Tusk and the Lotherberg group.”"]** — Mówca: **Player**
> "“We could look further into Tusk and the Lotherberg group.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Karl Greiser: "“If that is your desire, we can certainly inquire further..."*)

### Węzeł `[110]`
Mówca: **Karl Greiser**
> "“And they seem to be evading taxes through bribery and exploiting the grey areas in our laws. Our investigators in Estord and Narbel have also found some suspicious financial activity from some of their corporations. If their tax returns were to be made public, it would help us track irregularities in the filings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[109]` (*Player: "“We could look further into Tusk and the Lotherberg group.”"*)
  - -> `[108]` (*Player: "“Bribery should be eradicated from the system.”"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: "“Hawker, Heron and their cronies in the Supreme Court won..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: "“Hawker, Heron and the rest of the Guard in the Supreme C..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_President == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_President == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Lucian Galade: "“Hawker, Heron and the rest of the Guard in the Supreme C..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: "“Hawker, Heron and the rest of the Guard in the Supreme C..."*)

### Węzeł `[117]`
Mówca: **Lucian Galade**
> "“Hawker, Heron and the rest of the Guard in the Supreme Court will be able to be prosecuted with our new constitution. The President will have full authority to do so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Lucian Galade: "“However, it won't be possible to get them if we fail to ..."*)

### Węzeł `[118]`
Mówca: **Lucian Galade**
> "“Hawker, Heron and the rest of the Guard in the Supreme Court won't be able to be prosecuted at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucian Galade: "“This means we can't cut the head off the snake, but we w..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“Don't poke the bear when we are not ready to fight it. Maintain low-key operations.”"]** — Mówca: **Player**
> "“Don't poke the bear when we are not ready to fight it. Maintain low-key operations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Karl Greiser: "“Our police is made up of only the most loyal officers, s..."*)

### Węzeł `[120]`
Mówca: **Karl Greiser**
> "“Our police is made up of only the most loyal officers, sir. Hundreds of people, hand-picked by Minister Morgna. They have no history with the establishment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Karl Greiser: "“Our operations are very hidden at the moment. We are pic..."*)

### Węzeł `[121]`
Mówca: **Karl Greiser**
> "“Our operations are very hidden at the moment. We are picking off the weaker cogs in the machine that will eventually lead us to the top.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lucian Galade: "“The most important subject here is the Old Guard establi..."*)

### Węzeł `[122]`
Mówca: **Lucian Galade**
> "“It won't be possible to get them if we fail to pass the reforms or we have low political support in the Assembly. But it is too early to tell.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Karl Greiser: "“Besides them, there are other elements we are aware of. ..."*)

### Węzeł `[123]`
Mówca: **Lucian Galade**
> "“This means we can't cut the head off the snake, but we will be able to strangle everyone around them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Karl Greiser: "“Besides them, there are other elements we are aware of. ..."*)

### Węzeł `[124]`
Mówca: **Lucian Galade**
> "“However, it won't be possible to get them if we fail to pass the reforms. It all depends on whether we can gather support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Karl Greiser: "“Besides them, there are other elements we are aware of. ..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: "“I don't always see eye to eye with her, but we might be ..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“She takes her work personally. Her motivations to fight ..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: "“I don't always see eye to eye with her, but we might be allies on this topic.”"]** — Mówca: **Player**
> "“I don't always see eye to eye with her, but we might be allies on this topic.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Kontekst wejściowy (poprzednik):** `[65]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Karl Greiser: "“I think our enemies are common so why not be friends. Th..."*)

### Węzeł `[129]`
Mówca: **Karl Greiser**
> "“I think our enemies are common so why not be friends. The bigger picture is about our country after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Karl leaned closer and lowered his voice ever so slightly."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player: "“I'm not sure if Morgna can be fully trusted. What if she..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "“I guess Minister Morgna is on our side on this. She real..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "“I'm not sure if Morgna can be fully trusted. What if she turns this force against us?”"]** — Mówca: **Player**
> "“I'm not sure if Morgna can be fully trusted. What if she turns this force against us?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Kontekst wejściowy (poprzednik):** `[100]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Karl Greiser: "“That would be unlikely, wouldn't it? You are the person ..."*)

### Węzeł `[134]`
Mówca: **Karl Greiser**
> "“That would be unlikely, wouldn't it? You are the person that gave her the cabinet position, allowing her to have the authority to fight the real enemies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Increased == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Justice_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Increased == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Justice_Increased == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Justice_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Karl Greiser: "“Not only that, you diverted funding to her ministry. You..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Justice_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Karl Greiser: "“Mr. President, you founded this force to fight corruptio..."*)

### Węzeł `[138]`
Mówca: **Karl Greiser**
> "“Not only that, you diverted funding to her ministry. You are the only President to have done so in the history of the Republic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Karl Greiser: "“Mr. President, you founded this force to fight corruptio..."*)

### Węzeł `[139]`
Mówca: **Karl Greiser**
> "“Mr. President, you founded this force to fight corruption. We will only take down those who are truly deserving of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_CompanyFulfilled == tru..."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "Lucian coughed. I saw Karl gaze at him for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lucian Galade: "“The most important subject here is the Old Guard establi..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Media_SordlandToday_Bias == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_CompanyFulfilled == tru..."*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_CompanyFulfilled == t..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Media_SordlandToday_Bias == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "Lucian coughed. I saw Karl gaze at him for a moment."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Media_SordlandToday_Bias == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Lucian wrote a couple of notes down."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "Lucian wrote a couple of notes down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lucian Galade: "“The most important subject here is the Old Guard establi..."*)

### Węzeł `[145]`
Mówca: **Lucian Galade**
> "“The most important subject here is the Old Guard establishment. They pose a direct threat to us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lucian Galade: "“Once enough evidence is gathered, we should be able to b..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player: "“Mr. Koronti has been very supportive of my administratio..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: "“Tusk is an issue but he shouldn't be our primary target...."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[152]`
**[WYBÓR GRACZA: "“Tusk is an issue but he shouldn't be our primary target. There are bigger fish to fry.”"]** — Mówca: **Player**
> "“Tusk is an issue but he shouldn't be our primary target. There are bigger fish to fry.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Kontekst wejściowy (poprzednik):** `[110]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Karl Greiser: "“Very well, sir.”"*)

### Węzeł `[153]`
Mówca: **Karl Greiser**
> "“If that is your desire, we can certainly inquire further about their operations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Karl Greiser: "“Marcel Koronti and HOS also have a strong presence in th..."*)

### Węzeł `[154]`
Mówca: **Karl Greiser**
> "“We will do our best, sir. It plagues us from all ends but the Oligarchs seem to have immense influence and money. They keep utilizing it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Karl Greiser: "“Marcel Koronti and HOS also have a strong presence in th..."*)

### Węzeł `[155]`
Mówca: **Karl Greiser**
> "“You are correct, President Rayne. They need to be looked at.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Karl Greiser: "“Marcel Koronti and HOS also have a strong presence in th..."*)

### Węzeł `[156]`
Mówca: **Karl Greiser**
> "“Marcel Koronti and HOS also have a strong presence in the media and many other industries. There are some patterns we observed that are unusual.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Karl Greiser: "“It really seems like they have a powerful influence in t..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA: ""Who cares about him, anyway...""]** — Mówca: **Player**
> ""Who cares about him anyway...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Lucian Galade: "“It's not good to underestimate such critical public opin..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "“Mr. Koronti has been very supportive of my administration. He is a close friend.”"]** — Mówca: **Player**
> "“Mr. Koronti has been very supportive of my administration. He is a close friend.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Kontekst wejściowy (poprzednik):** `[238]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Karl Greiser: "“He might not be innocent, but if you think he isn't an i..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "“Marcel offered me a deal before, and needs to be investigated.”"]** — Mówca: **Player**
> "“Marcel offered me a deal before, and needs to be investigated.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Karl Greiser: "“We certainly can. I wish we had proof of the incident. I..."*)

### Węzeł `[160]`
**[WYBÓR GRACZA: "“Focus Anti-Corruption investigations on Tusk and the Oligarchs.”"]** — Mówca: **Player**
> "“Focus Anti-Corruption investigations on Tusk and the Oligarchs.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs = true; BaseGam..."*)

### Węzeł `[161]`
Mówca: **Karl Greiser**
> "“Yes. Minister Graf has given me full authority to lead the new force in order to combat organised crime, drug trade and trafficking in our poorer cities and their neighbourhoods. Their role is of a supportive nature.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Karl Greiser: "“I've had many of my trusted officers scout hundreds of l..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA: "“We need to protect and keep our communities safe. This is another step towards that.”"]** — Mówca: **Player**
> "“We need to protect and keep our communities safe. This is another step towards that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Karl Greiser: "“The enhanced local security and cooperation these new lo..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: "“If communities, especially of ethnic descent, gain more responsibility in their own security, it could backfire.”"]** — Mówca: **Player**
> "“If communities, especially of ethnic descent, gain more responsibility in their own security, it could backfire.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Karl Greiser: "“Harsher police action does not necessarily helps us win ..."*)

### Węzeł `[164]`
**[WYBÓR GRACZA: "“How did we ever come to this low point?”"]** — Mówca: **Player**
> "“How did we ever come to this low point?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Karl Greiser: "“The recession has allowed these criminal gangs to take c..."*)

### Węzeł `[165]`
Mówca: **Karl Greiser**
> "“Correct. Minister Graf has given me full authority to lead the new force in order to combat subversives and other threats to the state from the inside. The agents we have recruited are the most loyal and experienced.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player: "“There are too many enemies inside Sordland. They need to..."*)
  - -> `[171]` (*Player: "“The important question for us is where your loyalties lie.”"*)
  - -> `[172]` (*Player: "“It's a very powerful force. One that didn't exist in Sor..."*)

### Węzeł `[166]`
Mówca: **Karl Greiser**
> "“Indeed so. Minister Morgna has given me full authority to lead the new force in order to fight corruption from within.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player: "“It's a very powerful force. One that didn't exist in Sor..."*)
  - -> `[168]` (*Player: "“The important question for us is where your loyalties lie.”"*)
  - -> `[169]` (*Player: "“Congratulations. I hope we'll be close partners in the f..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA: "“It's a very powerful force. One that didn't exist in Sordland before.”"]** — Mówca: **Player**
> "“It's a very powerful force. One that didn't exist in Sordland before.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Karl Greiser: "“The structure being separated from the Interior helps ma..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA: "“The important question for us is where your loyalties lie.”"]** — Mówca: **Player**
> "“The important question for us is where your loyalties lie.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Karl Greiser: "“I serve my country and its leader President Anton Rayne.”"*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "“Congratulations. I hope we'll be close partners in the fight against corruption.”"]** — Mówca: **Player**
> "“Congratulations. I hope we'll be close partners in the fight against corruption.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Karl Greiser: "“Sir, we have a tough and long fight ahead of us. It will..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA: "“There are too many enemies inside Sordland. They need to be found and imprisoned.”"]** — Mówca: **Player**
> "“There are too many enemies inside Sordland. They need to be found and imprisoned.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Karl Greiser: "“Our established forces has begun gathering intelligence ..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA: "“The important question for us is where your loyalties lie.”"]** — Mówca: **Player**
> "“The important question for us is where your loyalties lie.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Karl Greiser: "“I serve my country and its leader President Anton Rayne.”"*)

### Węzeł `[172]`
**[WYBÓR GRACZA: "“It's a very powerful force. One that didn't exist in Sordland before.”"]** — Mówca: **Player**
> "“It's a very powerful force. One that didn't exist in Sordland before.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Karl Greiser: "“Yes. We have great powers regarding our operations, than..."*)

### Węzeł `[173]`
Mówca: **Karl Greiser**
> "“Our established forces has begun gathering intelligence on the suspected enemies of the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Karl Greiser: "“I want to make it absolutely clear. My belief in you as ..."*)

### Węzeł `[174]`
Mówca: **Karl Greiser**
> "“I serve my country and its leader President Anton Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Karl Greiser: "“I want to make it absolutely clear. My belief in you as ..."*)

### Węzeł `[175]`
Mówca: **Karl Greiser**
> "“Yes. We have great powers regarding our operations, thanks to the Security Package and your authority.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Karl Greiser: "“I want to make it absolutely clear. My belief in you as ..."*)

### Węzeł `[176]`
Mówca: **Karl Greiser**
> "“The enhanced local security and cooperation these new local forces provide will help us improve the dangerous situation in these neighbourhoods.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Karl Greiser: "“Our current efforts have been successful at containing t..."*)

### Węzeł `[177]`
Mówca: **Karl Greiser**
> "“Harsher police action does not necessarily helps us win the battle against organised crime. We need to work with the locals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Karl Greiser: "“Our current efforts have been successful at containing t..."*)

### Węzeł `[178]`
Mówca: **Karl Greiser**
> "“The recession has allowed these criminal gangs to take control in poverty-stricken areas. Desperate people will do a lot for money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Karl Greiser: "“Our current efforts have been successful at containing t..."*)

### Węzeł `[179]`
Mówca: **Karl Greiser**
> "“The structure being separated from the Interior helps maintain perspective and independence from previous hierarchies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Karl Greiser: "“I want to make it absolutely clear. My belief in you as ..."*)

### Węzeł `[180]`
Mówca: **Karl Greiser**
> "“I serve my country and its leader President Anton Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Karl Greiser: "“I want to make it absolutely clear. My belief in you as ..."*)

### Węzeł `[181]`
Mówca: **Karl Greiser**
> "“Sir, we have a tough and long fight ahead of us. It will take years, but we will win. You can believe that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Karl Greiser: "“I want to make it absolutely clear. My belief in you as ..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Karl Greiser: "“It's fine, sir. The Emergency Act gave us wide-ranging p..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Karl Greiser: "“It's been going okay. We have tackled many security issu..."*)

### Węzeł `[185]`
Mówca: **Karl Greiser**
> "“It's fine, sir. The Emergency Act gave us wide-ranging powers and allowed us to crush any illegal activity in the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Karl Greiser: "“But more importantly, the security situation in the coun..."*)

### Węzeł `[186]`
Mówca: **Karl Greiser**
> "“However, I couldn't help but notice that certain high-ranking officers in the Sordish Police Force have been acting autonomously. This is a grave concern for us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Lucian Galade: "“The chain of command is jeopardised?”"*)

### Węzeł `[187]`
Mówca: **Lucian Galade**
> "“The chain of command is jeopardised?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Karl Greiser: "“After further research, we found that there are some ver..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA: "“We need to find out about their weaknesses, just in case.”"]** — Mówca: **Player**
> "“We need to find out about their weaknesses, just in case.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Karl Greiser: "“In that case, the department will keep an eye on any lea..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA: "“Don't worry about Hawker. He is aiding our administration.”"]** — Mówca: **Player**
> "“Don't worry about Hawker. He is aiding our administration.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Karl Greiser: "“Very well, sir.”"*)

### Węzeł `[190]`
Mówca: **Karl Greiser**
> "“Mr. Hawker has financial and other ties to certain figures in the police and the government. He is a dangerous man. Currently, we are collecting evidence of his middlemen to discover a real link that would lead to further suspects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "Lucian glanced at me with his eyebrow raised."*)

### Węzeł `[191]`
Mówca: **Karl Greiser**
> "“After further research, we found that there are some very powerful deep state forces inside the administration influencing our security. Our investigations have just begun, but certain links we have discovered are troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Karl Greiser: "“Mr. Hawker has financial and other ties to certain figur..."*)

### Węzeł `[192]`
Mówca: **Karl Greiser**
> "“Good day, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Karl and Lucian left the room."*)

### Węzeł `[193]`
**[WYBÓR GRACZA: "“Good day and good luck, Mr. Greiser.”"]** — Mówca: **Player**
> "“Good day and good luck, Mr. Greiser.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Lucian Galade), `[267]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Karl Greiser: "“Good day, sir.”"*)

### Węzeł `[194]`
**[WYBÓR GRACZA: "“Thank you for your time Karl.”"]** — Mówca: **Player**
> "“Thank you for your time, Karl.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Lucian Galade), `[267]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Karl Greiser: "“It is a privilege to work with you, President Rayne. Goo..."*)

### Węzeł `[195]`
Mówca: **Karl Greiser**
> "“It is a privilege to work with you, President Rayne. Good day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Karl and Lucian left the room."*)

### Węzeł `[196]`
Mówca: **Narrator**
> "Lucian glanced at me with his eyebrow raised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Karl Greiser: "“Minister Morgna is very concerned about the Supreme Cour..."*)

### Węzeł `[197]`
Mówca: **Karl Greiser**
> "“Very well, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Lucian Galade: "“Let's discuss this further later.”"*)

### Węzeł `[198]`
Mówca: **Karl Greiser**
> "“In that case, the department will keep an eye on any leads.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucian Galade: "“We surely can to be on the safe side, even though we are..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: "“Minister Graf is our close ally in the cabinet. I don't ..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[202]`
**[WYBÓR GRACZA: "“Me and Lileas see eye to eye on many issues. I wouldn't worry about her.”"]** — Mówca: **Player**
> "“Me and Lileas see eye to eye on many issues. I wouldn't worry about her.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Karl Greiser: "“She holds immense power in the Interior security apparat..."*)

### Węzeł `[203]`
Mówca: **Karl Greiser**
> "“That won't change sir. I was just trying to give you some inside information from the Interior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "Karl leaned closer and lowered his voice ever so slightly."*)

### Węzeł `[204]`
Mówca: **Karl Greiser**
> "“Affirmative. Won't happen again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "Karl leaned closer and lowered his voice ever so slightly."*)

### Węzeł `[205]`
Mówca: **Karl Greiser**
> "“She holds immense power in the Interior security apparatus. She also seems to have a powerful base in the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "Karl leaned closer and lowered his voice ever so slightly."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "Karl leaned closer and lowered his voice ever so slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Karl Greiser: "“There are elements within our state that have ulterior m..."*)

### Węzeł `[207]`
Mówca: **Narrator**
> "Karl leaned closer and lowered his voice ever so slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Karl Greiser: "“The initial analysis by our agents has uncovered some tr..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true || BaseGame.Refo..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Karl Greiser: "“There are some very powerful deep state forces inside th..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Karl Greiser: "“The Reformists are a threat to the next election, sir. T..."*)

### Węzeł `[211]`
Mówca: **Karl Greiser**
> "“There are elements within our state that have ulterior motives.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Player: "“What do you mean?”"*)
  - -> `[215]` (*Player: "“Elaborate please.”"*)

### Węzeł `[212]`
**[WYBÓR GRACZA: "“Yes. You are among confidants.”"]** — Mówca: **Player**
> "“Yes. You are among confidants.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)

### Węzeł `[213]`
Mówca: **Karl Greiser**
> "“May I speak frankly, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player: "“Yes. You are among confidants.”"*)
  - -> `[214]` (*Player: "“Of course.”"*)
  - -> `[379]` (*Player: "“That's exactly what I want you to do.”"*)

### Węzeł `[214]`
**[WYBÓR GRACZA: "“Of course.”"]** — Mówca: **Player**
> "“Of course.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)

### Węzeł `[215]`
**[WYBÓR GRACZA: "“Elaborate please.”"]** — Mówca: **Player**
> "“Elaborate please.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Karl Greiser: "“May I speak frankly, sir?”"*)

### Węzeł `[216]`
**[WYBÓR GRACZA: "“What do you mean?”"]** — Mówca: **Player**
> "“What do you mean?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Karl Greiser: "“May I speak frankly, sir?”"*)

### Węzeł `[217]`
Mówca: **Karl Greiser**
> "“The initial analysis by our agents has uncovered some troubling facts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Karl Greiser: "“There are elements within our state that have ulterior m..."*)

### Węzeł `[218]`
Mówca: **Lucian Galade**
> "“Let's discuss this further later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Karl Greiser: "“Besides them, there are other elements we are aware of. ..."*)

### Węzeł `[219]`
Mówca: **Lucian Galade**
> "“We surely can to be on the safe side, even though we are working with them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Karl Greiser: "“Besides them, there are other elements we are aware of. ..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_OldGuard = true; BaseGameSupport.Journal_Turn05_Investigations_OldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] = true;
Variable["BaseGameSupport.Journal_Turn05_Investigations_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content = false"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs = true; BaseGameSupport.Journal_Turn05_Investigations_Oligarchs = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] = true;
Variable["BaseGameSupport.Journal_Turn05_Investigations_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content = false"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Opposition = true; BaseGameSupport.Journal_Turn05_Investigations_Reformists = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] = true;
Variable["BaseGameSupport.Journal_Turn05_Investigations_Reformists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Karl Greiser: "“Yes, sir. We will focus our research and investigation o..."*)

### Węzeł `[223]`
Mówca: **Karl Greiser**
> "“Minister Morgna is very concerned about the Supreme Court and Old Guards. She sees them as the primary threat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player: "“Don't worry about Hawker. He is aiding our administration.”"*)
  - -> `[188]` (*Player: "“We need to find out about their weaknesses, just in case.”"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: "“The economy must be controlled by the state. Lotherberg ..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[227]`
Mówca: **Karl Greiser**
> "“I've had many of my trusted officers scout hundreds of loyal community volunteers and train them in the police academies around the country. The Koranelli and Skinner gangs have a presence in many of their districts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player: "“We need to protect and keep our communities safe. This i..."*)
  - -> `[163]` (*Player: "“If communities, especially of ethnic descent, gain more ..."*)
  - -> `[229]` (*Player: "“The crime families need to be taken down. We can't let t..."*)
  - -> `[164]` (*Player: "“How did we ever come to this low point?”"*)

### Węzeł `[228]`
Mówca: **Karl Greiser**
> "“We are fighting them already, and the community police force will cut their connections further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Karl Greiser: "“Our current efforts have been successful at containing t..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA: "“The crime families need to be taken down. We can't let them do what they want with impunity.”"]** — Mówca: **Player**
> "“The crime families need to be taken down. We can't let them do what they want with impunity.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Karl Greiser: "“We are fighting them already, and the community police f..."*)

### Węzeł `[230]`
Mówca: **Karl Greiser**
> "“Of course, sir. We are working in close collaboration with Mrs. Graf. Things are much better already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: "“The Community Police is driven by local enforcement and ..."*)

### Węzeł `[231]`
Mówca: **Karl Greiser**
> "“Yes, they have a lot of presence there. Our efforts are increasingly pushing them to act in the shadows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: "“The Community Police is driven by local enforcement and ..."*)

### Węzeł `[232]`
Mówca: **Karl Greiser**
> "“I won't disappoint you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: "“The Community Police is driven by local enforcement and ..."*)

### Węzeł `[233]`
Mówca: **Karl Greiser**
> "“He might not be innocent, but if you think he isn't an issue then we can move on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Karl sighed."*)

### Węzeł `[234]`
Mówca: **Karl Greiser**
> "“They do have reach, but the President has much more influence and authority.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Karl sighed."*)

### Węzeł `[235]`
Mówca: **Karl Greiser**
> "“We certainly can. I wish we had proof of the incident. It would help in a case against him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Karl sighed."*)

### Węzeł `[236]`
Mówca: **Karl Greiser**
> "“Last but not least is the opposition leader Frens Ricter. We have received intelligence that he has connections to Arcasia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Karl Greiser: "“Upon further inquiries, we can't see anything illegal he..."*)

### Węzeł `[237]`
**[WYBÓR GRACZA: "“Focus Anti-Corruption investigations on the opposition.""]** — Mówca: **Player**
> "“Focus Anti-Corruption investigations on the opposition parties.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Opposition = true; BaseGa..."*)

### Węzeł `[238]`
Mówca: **Karl Greiser**
> "“It really seems like they have a powerful influence in the majority of the so-called independent news organisations. They might not be so independent after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[157]` (*Player: ""Who cares about him, anyway...""*)
  - -> `[159]` (*Player: "“Marcel offered me a deal before, and needs to be investi..."*)

### Węzeł `[239]`
Mówca: **Lucian Galade**
> "“It's not good to underestimate such critical public opinion tools.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Karl Greiser: "“They do have reach, but the President has much more infl..."*)

### Węzeł `[240]`
Mówca: **Karl Greiser**
> "“Upon further inquiries, we can't see anything illegal here besides a mismatch of information.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucian Galade: "“The Old Guard must have pushed this forward. We shouldn'..."*)

### Węzeł `[241]`
**[WYBÓR GRACZA: "“Frens Ricter is our ally and we shouldn't move against him.”"]** — Mówca: **Player**
> "“Frens Ricter is our ally and we shouldn't move against him.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Karl Greiser: "“Very well, sir.”"*)

### Węzeł `[242]`
**[WYBÓR GRACZA: "“There is nothing illegal, so why even talk about this?”"]** — Mówca: **Player**
> "“There is nothing illegal, so why even talk about this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Karl Greiser: "“I wanted to disclose all of the information that the ACP..."*)

### Węzeł `[243]`
**[WYBÓR GRACZA: "“Ricter is a loyal servant of Sordland. The Old Guard is trying to pressure him.”"]** — Mówca: **Player**
> "“Ricter is a loyal servant of Sordland. The Old Guard is trying to pressure him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Karl Greiser: "“The way we received this intelligence was unusual, to sa..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player: "“Frens Ricter is our ally and we shouldn't move against h..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[247]`
**[WYBÓR GRACZA: "“He must have some dirt on him. We should look deeper.”"]** — Mówca: **Player**
> "“He must have some dirt on him. We should look deeper.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Karl Greiser: "“Everyone has something, usually. The PFJP and the other ..."*)

### Węzeł `[248]`
Mówca: **Karl Greiser**
> "“Very well, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Lucian Galade: "“There are so many potential corruption cases here.”"*)

### Węzeł `[249]`
Mówca: **Karl Greiser**
> "“The way we received this intelligence was unusual, to say the least. It totally came through the back channels.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Lucian Galade: "“There are so many potential corruption cases here.”"*)

### Węzeł `[250]`
Mówca: **Karl Greiser**
> "“I wanted to disclose all of the information that the ACP has.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Lucian Galade: "“There are so many potential corruption cases here.”"*)

### Węzeł `[251]`
Mówca: **Karl Greiser**
> "“Everyone has something, usually. The PFJP and the other opposition members can't be fully clean.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Lucian Galade: "“There are so many potential corruption cases here.”"*)

### Węzeł `[252]`
Mówca: **Karl Greiser**
> "“Therefore, we need to pick a faction to focus on. We can't investigate everyone within the remainder of this term and come up with a thorough and compelling case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_..."*)

### Węzeł `[253]`
Mówca: **Lucian Galade**
> "“There are so many potential corruption cases here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Karl Greiser: "“Therefore, we need to pick a faction to focus on. We can..."*)

### Węzeł `[254]`
Mówca: **Karl Greiser**
> "“Where should we concentrate our anti-corruption efforts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: "“Focus Anti-Corruption investigations on Hawker and the O..."*)
  - -> `[160]` (*Player: "“Focus Anti-Corruption investigations on Tusk and the Oli..."*)
  - -> `[237]` (*Player: "“Focus Anti-Corruption investigations on the opposition.""*)

### Węzeł `[255]`
Mówca: **Karl Greiser**
> "“Yes, sir. We will focus our research and investigation on the Old Guard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Lucian Galade: "“Well, it has been decided. That should conclude the meet..."*)

### Węzeł `[256]`
Mówca: **Karl Greiser**
> "“Yes, sir. We will focus our research and investigation on the Oligarchs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Lucian Galade: "“Well, it has been decided. That should conclude the meet..."*)

### Węzeł `[257]`
Mówca: **Karl Greiser**
> "“Yes, sir. We will focus our research and investigation on the PFJP as well as the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Lucian Galade: "“Well, it has been decided. That should conclude the meet..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true || BaseGame.Refo..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Lucian Galade: "“The most logical step would be to use the ACP to pressur..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Karl Greiser: "“Where should we concentrate our anti-corruption efforts?”"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_..."*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn0..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Lucian Galade: "“The Old Guard has us exactly where they want us. If we u..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Karl Greiser: "“Where should we concentrate our anti-corruption efforts?”"*)

### Węzeł `[264]`
Mówca: **Lucian Galade**
> "“The Old Guard has us exactly where they want us. If we unleash the ACP on them, we might have a backup in case things don't go well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Karl Greiser: "“Where should we concentrate our anti-corruption efforts?”"*)

### Węzeł `[265]`
Mówca: **Lucian Galade**
> "“The most logical step would be to use the ACP to pressure either the Oligarchs or the Old Guard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Karl Greiser: "“Where should we concentrate our anti-corruption efforts?”"*)

### Węzeł `[266]`
Mówca: **Lucian Galade**
> "“Well, it has been decided. That should conclude the meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: "“Thank you for your time Karl.”"*)
  - -> `[193]` (*Player: "“Good day and good luck, Mr. Greiser.”"*)

### Węzeł `[267]`
Mówca: **Karl Greiser**
> "“I am very glad you have taken such a step, Mr. President. Well... I will continue my work if there is nothing else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: "“Thank you for your time Karl.”"*)
  - -> `[193]` (*Player: "“Good day and good luck, Mr. Greiser.”"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player: "“The increased Interior budget should allow us to diminis..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[271]`
**[WYBÓR GRACZA: "“The increased Interior budget should allow us to diminish them.”"]** — Mówca: **Player**
> "“The increased Interior budget should allow us to diminish them.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Kontekst wejściowy (poprzednik):** `[70]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Karl Greiser: "“It already has. We are receiving reports of several earl..."*)

### Węzeł `[272]`
Mówca: **Karl Greiser**
> "“It already has. We are receiving reports of several early successes. Once the Community Police operations kick in with full force, we will end those gangs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: "“The Community Police is driven by local enforcement and ..."*)

### Węzeł `[273]`
Mówca: **Karl Greiser**
> "“You should receive further reports on our progress and actions in the upcoming months, President Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Karl Greiser: "“I am very glad you have taken such a step, Mr. President..."*)

### Węzeł `[274]`
**[WYBÓR GRACZA: "“Make sure the force represents the diverse makeup of the neighborhoods in which it is active.”"]** — Mówca: **Player**
> "“Make sure the force represents the diverse makeup of the neighborhoods in which it is active.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Karl Greiser: "“Very well, sir. We will ensure diversity in the new force.”"*)

### Węzeł `[275]`
**[WYBÓR GRACZA: "“Make sure to pick the right people for the job and have solid background checks.”"]** — Mówca: **Player**
> "“Make sure to pick the right people for the job and have solid background checks.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Karl Greiser: "“I have personally picked the initial recruits. My office..."*)

### Węzeł `[276]`
**[WYBÓR GRACZA: "“Don't arm the Community Police. We shouldn't trust them yet.”"]** — Mówca: **Player**
> "“Don't arm the Community Police. We shouldn't trust them yet.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Karl Greiser: "“I understand your perspective. I will remove the right t..."*)

### Węzeł `[277]`
Mówca: **Karl Greiser**
> "“I also wanted to point out that hundreds of Agno-Sordish, Bludish and Sordish volunteers are now entering training. Soon they will assist our forces.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Karl Greiser: "“We are ensuring that people take charge of their own dis..."*)

### Węzeł `[278]`
Mówca: **Karl Greiser**
> "“Very well, sir. We will ensure diversity in the new force.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Karl Greiser: "“You should receive further reports on our progress and a..."*)

### Węzeł `[279]`
Mówca: **Karl Greiser**
> "“We are ensuring that people take charge of their own districts. By giving them responsibility and oversight, we will have them as our allies on the ground.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player: "“Make sure the force represents the diverse makeup of the..."*)
  - -> `[275]` (*Player: "“Make sure to pick the right people for the job and have ..."*)
  - -> `[276]` (*Player: "“Don't arm the Community Police. We shouldn't trust them ..."*)

### Węzeł `[280]`
Mówca: **Karl Greiser**
> "“I have personally picked the initial recruits. My officers are evaluating all of them with thorough checks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Karl Greiser: "“You should receive further reports on our progress and a..."*)

### Węzeł `[281]`
Mówca: **Karl Greiser**
> "“I understand your perspective. I will remove the right to carry a weapon for the CP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Karl Greiser: "“You should receive further reports on our progress and a..."*)

### Węzeł `[282]`
Mówca: **Karl Greiser**
> "“Yes sir. If you think he is an enemy, we will look deeper.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Lucian Galade: "“There are so many potential corruption cases here.”"*)

### Węzeł `[283]`
**[WYBÓR GRACZA: "“He must have some dirt on him. We might need to look deeper.”"]** — Mówca: **Player**
> "“He must have some dirt on him. We might need to look deeper.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Karl Greiser: "“Everyone has something, usually. The PFJP and the other ..."*)

### Węzeł `[284]`
Mówca: **Lucian Galade**
> "“The Old Guard must have pushed this forward. We should consider investigating Mr. Ricter further. The PFJP poses a threat for the next election. It's better to know more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player: "“Frens Ricter should be investigated in full.”"*)
  - -> `[288]` (*Player: "“There is nothing illegal, so why even talk about this?”"*)
  - -> `[289]` (*Player: "“Ricter is a loyal servant of Sordland. Old Guards are tr..."*)
  - -> `[283]` (*Player: "“He must have some dirt on him. We might need to look dee..."*)

### Węzeł `[285]`
Mówca: **Karl Greiser**
> "“Upon further inquiries, we see a mismatch of information between the border guard and the intelligence units.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lucian Galade: "“The Old Guard must have pushed this forward. We should c..."*)

### Węzeł `[286]`
Mówca: **Karl Greiser**
> "“The way we received this intelligence was unusual to say the least. It totally went through the back-channels.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Lucian Galade: "“There are so many potential corruption cases here.”"*)

### Węzeł `[287]`
**[WYBÓR GRACZA: "“Frens Ricter should be investigated in full.”"]** — Mówca: **Player**
> "“Frens Ricter should be investigated in full.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Karl Greiser: "“Yes sir. If you think he is an enemy, we will look deeper.”"*)

### Węzeł `[288]`
**[WYBÓR GRACZA: "“There is nothing illegal, so why even talk about this?”"]** — Mówca: **Player**
> "“There is nothing illegal, so why even talk about this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Karl Greiser: "“I wanted to fully disclose all information available to ..."*)

### Węzeł `[289]`
**[WYBÓR GRACZA: "“Ricter is a loyal servant of Sordland. Old Guards are trying to pressure him.”"]** — Mówca: **Player**
> "“Ricter is a loyal servant of Sordland. Old Guards are trying to pressure him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Karl Greiser: "“The way we received this intelligence was unusual to say..."*)

### Węzeł `[290]`
Mówca: **Karl Greiser**
> "“Let's start with the primary person, the opposition leader Frens Ricter. We have received credible intelligence that he has connections to Arcasia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Karl Greiser: "“Upon further inquiries, we see a mismatch of information..."*)

### Węzeł `[291]`
Mówca: **Karl Greiser**
> "“Everyone has something, usually. The PFJP and the other opposition members can't be fully clean.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Lucian Galade: "“There are so many potential corruption cases here.”"*)

### Węzeł `[292]`
Mówca: **Lucian Galade**
> "“There are so many potential corruption cases here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Karl Greiser: "“I am a supporter of the Emergency Act and the expanded p..."*)

### Węzeł `[293]`
Mówca: **Karl Greiser**
> "“I wanted to fully disclose all information available to the SSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Lucian Galade: "“There are so many potential corruption cases here.”"*)

### Węzeł `[294]`
Mówca: **Narrator**
> "Lucian looked deep in thoughts. He sighed before he continued. I saw Karl gaze at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Lucian Galade: "“The most important subject here is the Old Guard establi..."*)

### Węzeł `[295]`
Mówca: **Karl Greiser**
> "“Not only that you also diverted the funding to her ministry. You are the only President to have done so in the history of the Republic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Karl Greiser: "“Mr. President you founded this force to fight corruption..."*)

### Węzeł `[296]`
Mówca: **Karl Greiser**
> "“Mr. President you founded this force to fight corruption and it won't be able take those down who are clear of evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_CompanyFulfilled == tru..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Player: "“Not sure if Graf can be fully trusted. What if she turns..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Player: "“I guess Minister Morgna is on our side on this. She real..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Media_SordlandToday_Bias == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_CompanyFulfilled == tru..."*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_CompanyFulfilled == t..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Media_SordlandToday_Bias == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "Lucian looked deep in thoughts. He sighed before he conti..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Media_SordlandToday_Bias == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "Lucian wrote a couple of notes down."*)

### Węzeł `[303]`
Mówca: **Karl Greiser**
> "“Mr. Hawker has financial and other ties to certain figures. He is a dangerous man. Currently we are collecting evidence of his middlemen to discover a real link that would lead to further suspects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Lucian Galade: "“We always suspected that they were dangerously close but..."*)

### Węzeł `[304]`
Mówca: **Narrator**
> "Lucian wrote a couple of notes down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Lucian Galade: "“The most important subject here is the Old Guard establi..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Karl Greiser: "“Not only that you also diverted the funding to her minis..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Karl Greiser: "“Mr. President you founded this force to fight corruption..."*)

### Węzeł `[308]`
Mówca: **Lucian Galade**
> "“Hawker, Heron and the rest of the Guard in the Supreme Court will be able to be prosecuted with our new constitution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Karl Greiser: "“Besides them, there are other elements we are aware of. ..."*)

### Węzeł `[309]`
Mówca: **Lucian Galade**
> "“We always suspected that they were dangerously close but the real question here is who in the government and cabinet is on their side?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[312]` (*Player: "“Don't poke the bear when we are not ready to fight it. M..."*)
  - -> `[320]` (*Player: "“We need to find out who has ulterior motives and root th..."*)
  - -> `[321]` (*Player: "“Keep pursuing this Karl. If you encounter any obstacles,..."*)

### Węzeł `[310]`
**[WYBÓR GRACZA: "“I guess Minister Morgna is on our side on this. She really wants to tackle corruption inside.”"]** — Mówca: **Player**
> "“I guess Minister Morgna is on our side on this. She really wants to tackle corruption inside.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[309]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Karl Greiser: "“Yes. And she is constantly encountering resistance in th..."*)

### Węzeł `[311]`
Mówca: **Karl Greiser**
> "“Yes. And she is constantly encountering resistance in the Ministry and other institutions. Mrs. Morgna is poking into places they don't want her to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Lucian Galade: "“The most important subject here is the Old Guard establi..."*)

### Węzeł `[312]`
**[WYBÓR GRACZA: "“Don't poke the bear when we are not ready to fight it. Maintain low-key operations.”"]** — Mówca: **Player**
> "“Don't poke the bear when we are not ready to fight it. Maintain low-key operations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Karl Greiser: "“Our agency is made up of the most loyal, sir. Hundreds o..."*)

### Węzeł `[313]`
Mówca: **Karl Greiser**
> "“Our agency is made up of the most loyal, sir. Hundreds of people were hand-picked by Minister Graf, personally. They have no history with the establishment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Karl Greiser: "“Our operations are very hidden at the moment. We are pic..."*)

### Węzeł `[314]`
Mówca: **Karl Greiser**
> "“Our operations are very hidden at the moment. We are picking off the weaker cogs in the machine that will eventually lead us to the top."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Lucian Galade: "“The most important subject here is the Old Guard establi..."*)

### Węzeł `[315]`
**[WYBÓR GRACZA: "“Not sure if Graf can be fully trusted. What if she turns this force against us?”"]** — Mówca: **Player**
> "“Not sure if Graf can be fully trusted. What if she turns this force against us?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Kontekst wejściowy (poprzednik):** `[309]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Karl Greiser: "“That would be unlikely wouldn't it, sir? You are the per..."*)

### Węzeł `[316]`
Mówca: **Karl Greiser**
> "“That would be unlikely wouldn't it, sir? You are the person that gave her the cabinet position; allowing her to have the authority to fight the real enemies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)

### Węzeł `[317]`
Mówca: **Karl Greiser**
> "“There are some very powerful deep state forces inside the administration. Our investigations have just begun but certain links we have discovered are troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Karl Greiser: "“Mr. Hawker has financial and other ties to certain figur..."*)

### Węzeł `[318]`
Mówca: **Karl Greiser**
> "“Thank you sir, I will be relentless; the adversaries of this country will be found.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Lucian Galade: "“The most important subject here is the Old Guard establi..."*)

### Węzeł `[319]`
Mówca: **Karl Greiser**
> "“I couldn't agree more. Anyone who attacks the state and creates a parallel organisation is a threat to Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Lucian Galade: "“The most important subject here is the Old Guard establi..."*)

### Węzeł `[320]`
**[WYBÓR GRACZA: "“We need to find out who has ulterior motives and root them out of the administration.”"]** — Mówca: **Player**
> "“We need to find out who has ulterior motives and root them out of the administration.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Karl Greiser: "“I couldn't agree more. Anyone who attacks the state and ..."*)

### Węzeł `[321]`
**[WYBÓR GRACZA: "“Keep pursuing this Karl. If you encounter any obstacles, my full authority will protect you.”"]** — Mówca: **Player**
> "“Keep pursuing this Karl. If you encounter any obstacles, my full authority will protect you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Karl Greiser: "“Thank you sir, I will be relentless; the adversaries of ..."*)

### Węzeł `[322]`
Mówca: **Lucian Galade**
> "“The most important subject here is the Old Guard establishment. They pose a direct threat to us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Lucian Galade: "“Once enough intelligence is gathered, we may be able to ..."*)

### Węzeł `[323]`
Mówca: **Lucian Galade**
> "“Once enough intelligence is gathered, we may be able to arrest them extrajudicially.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default == true"*)

### Węzeł `[324]`
**[WYBÓR GRACZA: "“Focus Secret State Police investigations on Hawker and the Old Guard.”"]** — Mówca: **Player**
> "“Focus Secret State Police investigations on Hawker and the Old Guard.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_OldGuard = true; BaseGame..."*)

### Węzeł `[325]`
**[WYBÓR GRACZA: "“Focus Secret State Police investigations on Tusk and the Oligarchs.”"]** — Mówca: **Player**
> "“Focus Secret State Police investigations on Tusk and the Oligarchs.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs = true; BaseGam..."*)

### Węzeł `[326]`
**[WYBÓR GRACZA: "“Focus Secret State Police investigations on the opposition parties.”"]** — Mówca: **Player**
> "“Focus Secret State Police investigations on the opposition parties.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Opposition = true; BaseGa..."*)

### Węzeł `[327]`
Mówca: **Karl Greiser**
> "“Yes, sir. We will focus our research and investigation on the Oligarchs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Lucian Galade: "“Well, it has been decided. That should conclude the meet..."*)

### Węzeł `[328]`
Mówca: **Karl Greiser**
> "“Yes, sir. We will focus our research and investigation on the PFJP and the NFP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Lucian Galade: "“Well, it has been decided. That should conclude the meet..."*)

### Węzeł `[329]`
Mówca: **Karl Greiser**
> "“Yes, sir. We will focus our research and investigation on the Old Guard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Lucian Galade: "“Well, it has been decided. That should conclude the meet..."*)

### Węzeł `[330]`
Mówca: **Karl Greiser**
> "“He might not be innocent, sir. But if you think he isn't an issue, then we can move on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Karl Greiser: "“Therefore we need to pick a faction to focus on. We can'..."*)

### Węzeł `[331]`
Mówca: **Karl Greiser**
> "“Very well, sir. If he isn't a big concern for you, we can talk about other figures.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Karl Greiser: "“Marcel Koronti and HOS also have a strong presence in th..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player: "“Mr. Koronti has been very supportive of my administratio..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[335]`
Mówca: **Karl Greiser**
> "“If that is your desire, we can certainly inquire further about their operations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Karl Greiser: "“Marcel Koronti and HOS also have a strong presence in th..."*)

### Węzeł `[336]`
Mówca: **Karl Greiser**
> "“We will do our best, sir. It plagues us from all ends, but the Oligarchs seem to have immense influence and money. They keep utilizing it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Karl Greiser: "“Marcel Koronti and HOS also have a strong presence in th..."*)

### Węzeł `[337]`
Mówca: **Karl Greiser**
> "“Marcel Koronti and HOS also have a strong presence in the media and many other industries. There are some patterns we observed that are unusual.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Karl Greiser: "“It really seems like they have a powerful influence in t..."*)

### Węzeł `[338]`
Mówca: **Karl Greiser**
> "“We certainly can do so. I wish we had proof of the incident... It would help in a case against him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Karl Greiser: "“Therefore we need to pick a faction to focus on. We can'..."*)

### Węzeł `[339]`
Mówca: **Karl Greiser**
> "“And it is suspected that they are evading taxes through bribery and exploiting grey areas in our laws. Our investigators in Estord and Narbel have also found some suspicious financial activity from some of their corporations. If tax returns were to be made public, it would help us track irregularities in the filings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[351]` (*Player: "“The Oligarchs pose a larger threat to our administration..."*)
  - -> `[353]` (*Player: "“Bribery should be eradicated from the system.”"*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Player: "“The economy must be controlled by the state. Lotherberg ..."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[343]`
Mówca: **Karl Greiser**
> "“Besides them, there are other elements we are aware of. The Oligarchs seem to have some people in the inside as well. We have received some unconfirmed reports about Mr. Tusk having made deals with the enemies of the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Karl Greiser: "“And it is suspected that they are evading taxes through ..."*)

### Węzeł `[344]`
**[WYBÓR GRACZA: "“Who cares about him, anyway...”"]** — Mówca: **Player**
> "“Who cares about him, anyway...”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Lucian Galade: "“It's not good to underestimate such critical public opin..."*)

### Węzeł `[345]`
**[WYBÓR GRACZA: "“Mr. Koronti has been very supportive of my administration. He is a close friend.”"]** — Mówca: **Player**
> "“Mr. Koronti has been very supportive of my administration. He is a close friend.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Kontekst wejściowy (poprzednik):** `[350]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Karl Greiser: "“He might not be innocent, sir. But if you think he isn't..."*)

### Węzeł `[346]`
**[WYBÓR GRACZA: "“Marcel offered me a deal before. He needs to be investigated in full.”"]** — Mówca: **Player**
> "“Marcel offered me a deal before. He needs to be investigated in full.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Karl Greiser: "“We certainly can do so. I wish we had proof of the incid..."*)

### Węzeł `[347]`
Mówca: **Karl Greiser**
> "“You are correct, President Rayne. They need to be looked at.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Karl Greiser: "“Marcel Koronti and HOS also have a strong presence in th..."*)

### Węzeł `[348]`
Mówca: **Karl Greiser**
> "“They do have reach, but the President has much more influence and authority.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Karl Greiser: "“Therefore we need to pick a faction to focus on. We can'..."*)

### Węzeł `[349]`
**[WYBÓR GRACZA: "“Tusk is an issue, but he shouldn't be our primary target. There are bigger fish to fry.”"]** — Mówca: **Player**
> "“Tusk is an issue, but he shouldn't be our primary target. There are bigger fish to fry.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Kontekst wejściowy (poprzednik):** `[339]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Karl Greiser: "“Very well, sir. If he isn't a big concern for you, we ca..."*)

### Węzeł `[350]`
Mówca: **Karl Greiser**
> "“It really seems like they have a powerful influence in the majority of the so-called independent news organisations. They might not be so independent after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[344]` (*Player: "“Who cares about him, anyway...”"*)
  - -> `[346]` (*Player: "“Marcel offered me a deal before. He needs to be investig..."*)

### Węzeł `[351]`
**[WYBÓR GRACZA: "“The Oligarchs pose a larger threat to our administration. We need to curb them immediately.”"]** — Mówca: **Player**
> "“The Oligarchs pose a larger threat to our administration. We need to curb them immediately.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[339]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Karl Greiser: "“If that is your desire, we can certainly inquire further..."*)

### Węzeł `[352]`
**[WYBÓR GRACZA: "“The economy must be controlled by the state. Lotherberg has too much influence.”"]** — Mówca: **Player**
> "“The economy must be controlled by the state. Lotherberg has too much influence.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Kontekst wejściowy (poprzednik):** `[339]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Karl Greiser: "“You are correct, President Rayne. They need to be looked..."*)

### Węzeł `[353]`
**[WYBÓR GRACZA: "“Bribery should be eradicated from the system.”"]** — Mówca: **Player**
> "“Bribery should be eradicated from the system.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[339]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Karl Greiser: "“We will do our best, sir. It plagues us from all ends, b..."*)

### Węzeł `[354]`
Mówca: **Lucian Galade**
> "“It's not good to underestimate such critical public opinion tools.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Karl Greiser: "“They do have reach, but the President has much more infl..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true)"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Player: "“Tusk is an issue, but he shouldn't be our primary target..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[358]`
Mówca: **Lucian Galade**
> "“Let's discuss this further later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Karl Greiser: "“Besides them, there are other elements we are aware of. ..."*)

### Węzeł `[359]`
**[WYBÓR GRACZA: "“We need to find out about their weaknesses, just in case.”"]** — Mówca: **Player**
> "“We need to find out about their weaknesses, just in case.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Karl Greiser: "“In that case, the department will keep an eye on any lea..."*)

### Węzeł `[360]`
**[WYBÓR GRACZA: "“Don't worry about Hawker. He is aiding our administration.”"]** — Mówca: **Player**
> "“Don't worry about Hawker. He is aiding our administration.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Karl Greiser: "“Very well, sir.”"*)

### Węzeł `[361]`
Mówca: **Karl Greiser**
> "“Very well, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Lucian Galade: "“Let's discuss this further later.”"*)

### Węzeł `[362]`
Mówca: **Karl Greiser**
> "“In that case, the department will keep an eye on any leads.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Lucian Galade: "“We surely can do that to be on the safe side, even thoug..."*)

### Węzeł `[363]`
Mówca: **Karl Greiser**
> "“Mr. Hawker has financial and other ties to certain figures in the police and the government. He is a dangerous man. Currently, we are collecting evidence in order to discover exactly what his network comprises.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Narrator: "Lucian glanced at me with his eyebrow raised."*)

### Węzeł `[364]`
Mówca: **Lucian Galade**
> "“We surely can do that to be on the safe side, even though we are working with them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Karl Greiser: "“Besides them, there are other elements we are aware of. ..."*)

### Węzeł `[365]`
Mówca: **Karl Greiser**
> "“Minister Morgna is very concerned about the Supreme Court and Old Guard. She sees them as the primary threat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Player: "“Don't worry about Hawker. He is aiding our administration.”"*)
  - -> `[359]` (*Player: "“We need to find out about their weaknesses, just in case.”"*)

### Węzeł `[366]`
Mówca: **Narrator**
> "Lucian glanced at me with his eyebrow raised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Karl Greiser: "“Minister Morgna is very concerned about the Supreme Cour..."*)

### Węzeł `[367]`
Mówca: **Karl Greiser**
> "“I am a supporter of the Emergency Act and the expanded powers given to our police to stabilise the country. We have achieved our goals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Karl Greiser: "“However, I couldn't help but notice that certain high-ra..."*)

### Węzeł `[368]`
Mówca: **Karl Greiser**
> "“After further research, we found that there are some very powerful deep state forces inside the administration influencing our security. Our investigations have just begun, but certain links we have discovered are troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Karl Greiser: "“Mr. Hawker has financial and other ties to certain figur..."*)

### Węzeł `[369]`
Mówca: **Lucian Galade**
> "“The chain of command is jeopardized?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Karl Greiser: "“After further research, we found that there are some ver..."*)

### Węzeł `[370]`
Mówca: **Karl Greiser**
> "“However, I couldn't help but notice that certain high-ranking officers in the Sordish Police Force have been acting autonomously. This is a grave concern for us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“The chain of command is jeopardized?”"*)

### Węzeł `[371]`
Mówca: **Karl Greiser**
> "“Therefore we need to pick a faction to focus on. We can't investigate everyone within the remainder of the term and come up with a thorough and compelling case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_..."*)

### Węzeł `[372]`
Mówca: **Karl Greiser**
> "“Where should we concentrate our efforts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Player: "“Focus Secret State Police investigations on Hawker and t..."*)
  - -> `[325]` (*Player: "“Focus Secret State Police investigations on Tusk and the..."*)
  - -> `[326]` (*Player: "“Focus Secret State Police investigations on the oppositi..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_..."*)
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn0..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Lucian Galade: "“The Old Guard have us exactly where they want us. If we ..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Lucian Galade: "“The most logical step would be to use the SSP to pressur..."*)

### Węzeł `[376]`
Mówca: **Lucian Galade**
> "“The Old Guard have us exactly where they want us. If we unleash the SSP on them we might have something as a backup, in case things don't go well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Karl Greiser: "“Where should we concentrate our efforts?”"*)

### Węzeł `[377]`
Mówca: **Lucian Galade**
> "“The most logical step would be to use the SSP to pressure either the Oligarchs or the Old Guard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Karl Greiser: "“Where should we concentrate our efforts?”"*)

### Węzeł `[378]`
Mówca: **Karl Greiser**
> "“The Reformists are a threat to the next election, sir. The people could rally behind them and endanger your administration. With the SSP, we can resort to harsh but necessary actions to remove these threats.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Karl Greiser: "“Let's start with the primary person, the opposition lead..."*)

### Węzeł `[379]`
**[WYBÓR GRACZA: "“That's exactly what I want you to do.”"]** — Mówca: **Player**
> "“That's exactly what I want you to do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true || BaseGame.Reform..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default == true"*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Default == true)"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Karl Greiser: "“Besides them, there are other elements we are aware of. ..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Lucian Galade: "“Hawker, Heron and the rest of the Guard in the Supreme C..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == t..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_ACPFormed = true"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true"*)
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true)"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_CPFormed = true"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_SnO_FoundedPolice = true"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_ACPFormed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_ACPFormed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_SnO_FoundedPolice = true"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_CPFormed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_CPFormed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_SnO_FoundedPolice = true"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_OldGuard = true; BaseGameSupport.Journal_Turn05_Investigations_OldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] = true;
Variable["BaseGameSupport.Journal_Turn05_Investigations_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content = false"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs = true; BaseGameSupport.Journal_Turn05_Investigations_Oligarchs = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] = true;
Variable["BaseGameSupport.Journal_Turn05_Investigations_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Karl Greiser: "“Yes, sir. We will focus our research and investigation o..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Opposition = true; BaseGameSupport.Journal_Turn05_Investigations_Reformists = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] = true;
Variable["BaseGameSupport.Journal_Turn05_Investigations_Reformists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Karl Greiser: "“Yes, sir. We will focus our research and investigation o..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_OldGuard_Content"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Karl Greiser: "“Yes, sir. We will focus our research and investigation o..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Content"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Karl Greiser: "“Yes, sir. We will focus our research and investigation o..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_OldGuard_Content"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Karl Greiser: "“Yes, sir. We will focus our research and investigation o..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
