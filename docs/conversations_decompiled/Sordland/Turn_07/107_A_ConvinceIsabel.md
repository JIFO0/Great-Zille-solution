# Sordland/Turn07/A_ConvinceIsabel

- **ID konwersacji:** `107`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/107_A_ConvinceIsabel.md`
- **Liczba węzłów dialogowych:** 419
- **Liczba wyborów gracza:** 81

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[38]** Lucian Galade
- **[39]** Waiter
- **[50]** Kesaro Kibener
- **[59]** Isabel Edmonds

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Order_AntiCorruptionPolice`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Reform_Heron_SentKesaro`
- `BaseGame.Relations_Nia_Opposition`
- `BaseGame.Turn05_SnO_Investigate_OldGuard`
- `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice`
- `BaseGameIsolated.Turn07_A_IsabelOrdered_Salad`
- `BaseGameIsolated.Turn07_A_Isabel_Opinion`
- `BaseGameIsolated.Turn07_A_Ordered_Early`
- `BaseGameIsolated.Turn07_A_Ordered_LespianZabla`
- `BaseGameIsolated.Turn07_A_Ordered_Liver`
- `BaseGameIsolated.Turn07_A_Ordered_Salad`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Enable_HeronDecision`
- `BaseGame.Enable_HeronMeeting`
- `BaseGame.Enable_OfferBribeToHeron`
- `BaseGame.Lucian_FailsHeron`
- `BaseGame.Lucian_PersuadesHeron`
- `BaseGame.Reform_Reform_Heron_SentKesaro`
- `BaseGame.Reform_Reform_Isabel_Convinced`
- `BaseGameIsolated.Turn07_A_IsabelOrdered_Salad`
- `BaseGameIsolated.Turn07_A_Isabel_Opinion`
- `BaseGameIsolated.Turn07_A_Ordered_Early`
- `BaseGameIsolated.Turn07_A_Ordered_LespianZabla`
- `BaseGameIsolated.Turn07_A_Ordered_Liver`
- `BaseGameIsolated.Turn07_A_Ordered_Salad`
- `BaseGameSupport.Journal_Turn07_Isabel_Convinced`
- `BaseGameSupport.Journal_Turn07_Isabel_Failed`
- `GameCondition.Turn07_A_ConvinceHeron`
- `GameCondition.Turn07_A_ConvinceIsabel`
- `GameCondition.Turn07_Decision_HeronMeeting`

### Skoki między-konwersacyjne:
- Węzeł `[8]` -> **[114] Sordland/Turn07/NiaDialogue01_Opposition** (../Turn_07/114_NiaDialogue01_Opposition.md), Węzeł `[1]`
- Węzeł `[9]` -> **[108] Sordland/Turn07/NiaDialogue01_Ally** (../Turn_07/108_NiaDialogue01_Ally.md), Węzeł `[1]`
- Węzeł `[148]` -> **[113] Sordland/Turn07/IsabelIntro** (../Turn_07/113_IsabelIntro.md), Węzeł `[1]`
- Węzeł `[188]` -> **[110] Sordland/Turn07/WhatAreYourIntentions** (../Turn_07/110_WhatAreYourIntentions.md), Węzeł `[1]`
- Węzeł `[275]` -> **[109] Sordland/Turn07/NiaDialogue02_Personal** (../Turn_07/109_NiaDialogue02_Personal.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **""We have a guest coming. We'll wait for her to order.""** | `[11]` **Waiter**: ""Did you decide on the entrée, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Waiter**: ""Of course, sir."" |
| `[13]` | **""Not yet.""** | `[11]` **Waiter**: ""Did you decide on the entrée, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Waiter**: ""And madame?"" |
| `[14]` | **""What's on today's menu?""** | `[11]` **Waiter**: ""Did you decide on the entrée, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Waiter**: ""For the entrée, we have the opt..." |
| `[15]` | **""We are in a meeting here. Can you leave us alone?""** | `[11]` **Waiter**: ""Did you decide on the entrée, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Waiter**: ""Of course, sir. I'm sorry."" |
| `[21]` | **""I'll have sauté-Perlase with Lespian Zabla.""** | `[20]` **Waiter**: ""For the entrée, we have the opt..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"...` | `[26]` **Waiter**: ""Perfect. And you, madame?"" |
| `[22]` | **""I'll have the liver fricassée.""** | `[20]` **Waiter**: ""For the entrée, we have the opt..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] = true;` | `[26]` **Waiter**: ""Perfect. And you, madame?"" |
| `[23]` | **""I'll have Salade Luco.""** | `[20]` **Waiter**: ""For the entrée, we have the opt..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] = true;` | `[26]` **Waiter**: ""Perfect. And you, madame?"" |
| `[24]` | **""I won't order now.""** | `[20]` **Waiter**: ""For the entrée, we have the opt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Waiter**: ""As you wish, sir."" |
| `[39]` | **""Agreed. We shouldn't scare her off.""** | `[38]` **Nia Morgna**: ""But if she feels cornered, we m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Nia Morgna**: ""That's for the best."" |
| `[40]` | **""I disagree. We must keep up the pressure.""** | `[38]` **Nia Morgna**: ""But if she feels cornered, we m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Nia Morgna**: ""I am not sure about that, Mr. P..." |
| `[41]` | **""Let's not overthink this.""** | `[38]` **Nia Morgna**: ""But if she feels cornered, we m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Nia Morgna**: ""Agreed."" |
| `[51]` | **"Stand up for a handshake."** | `[50]` **Narrator**: "Nia got up from her chair to sha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Isabel Edmonds**: ""Mr. President. Good to see you."" |
| `[52]` | **"Welcome her from your seat."** | `[50]` **Narrator**: "Nia got up from her chair to sha..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[55]` **Narrator**: "She bowed her head slightly." |
| `[75]` | **"Welcome her from your seat."** | `[78]` **Narrator**: "Nia got up from her chair to sha..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Va...` | `[79]` **Narrator**: "She bowed her head slightly." |
| `[80]` | **"Stand up for a handshake."** | `[78]` **Narrator**: "Nia got up from her chair to sha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Isabel Edmonds**: ""Mr. President. Good to see you...." |
| `[90]` | **""Good to see you, Justice Edmonds.""** | `[81]` **Isabel Edmonds**: ""Mr. President. Good to see you...."<br>`[82]` **Isabel Edmonds**: ""Mr. President. I hope you're en..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Narrator**: "The waiter held a chair for Isabel." |
| `[91]` | **""Please, join me.""** | `[81]` **Isabel Edmonds**: ""Mr. President. Good to see you...."<br>`[82]` **Isabel Edmonds**: ""Mr. President. I hope you're en..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Narrator**: "The waiter held a chair for Isabel." |
| `[92]` | **""Please, take a seat.""** | `[81]` **Isabel Edmonds**: ""Mr. President. Good to see you...."<br>`[82]` **Isabel Edmonds**: ""Mr. President. I hope you're en..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Narrator**: "The waiter held a chair for Isabel." |
| `[95]` | **""Wouldn't you want to join me?""** | `[94]` **Isabel Edmonds**: ""I also didn't want to intrude y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Isabel Edmonds**: ""Thanks for the offer. I'm good."" |
| `[96]` | **""It's okay, Mrs. Edmonds. I thought we were here to meet over a meal.""** | `[94]` **Isabel Edmonds**: ""I also didn't want to intrude y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Narrator**: "She stared at me for a second." |
| `[97]` | **""Please, don't worry about it.""** | `[94]` **Isabel Edmonds**: ""I also didn't want to intrude y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Isabel Edmonds**: ""As you wish."" |
| `[102]` | **""What was on the menu?""** | `[115]` **Waiter**: ""Are you ready to give the order..." | `Variable["BaseGame.Relations_Nia_Opposition"] == true` | *Brak zmian stanu* | `[130]` **Waiter**: ""For the entrée, we have the opt..." |
| `[107]` | **""Please, take a seat.""** | `[54]` **Isabel Edmonds**: ""Mr. President. Good to see you.""<br>`[56]` **Isabel Edmonds**: ""Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "She took a seat across the table." |
| `[108]` | **""Good to see you, Justice Edmonds.""** | `[54]` **Isabel Edmonds**: ""Mr. President. Good to see you.""<br>`[56]` **Isabel Edmonds**: ""Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "She took a seat across the table." |
| `[109]` | **""Welcome, Mrs. Edmonds.""** | `[54]` **Isabel Edmonds**: ""Mr. President. Good to see you.""<br>`[56]` **Isabel Edmonds**: ""Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "She took a seat across the table." |
| `[117]` | **""I'll have the same.""** | `[121]` **Waiter**: ""As you wish."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Waiter**: ""Perfect, sir."" |
| `[118]` | **""Mrs. Edmonds?""** | `[121]` **Waiter**: ""As you wish.""<br>`[115]` **Waiter**: ""Are you ready to give the order..." | `Variable["BaseGame.Relations_Nia_Opposition"] == true` | *Brak zmian stanu* | `[119]` **Isabel Edmonds**: ""I'll have the salad. Thank you."" |
| `[123]` | **""I'll have the salad too.""** | `[122]` **Waiter**: ""Of course. And you, sir?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] = true;` | `[125]` **Waiter**: ""Perfect."" |
| `[124]` | **""I'll get the same as Mrs. Morgna.""** | `[122]` **Waiter**: ""Of course. And you, sir?"" | `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false` | `Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"...` | `[125]` **Waiter**: ""Perfect."" |
| `[132]` | **""I'll have sauté-Perlase with Lespian Zabla.""** | `[122]` **Waiter**: ""Of course. And you, sir?""<br>`[130]` **Waiter**: ""For the entrée, we have the opt..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"...` | `[170]` **Isabel Edmonds**: ""I'll have the salad. Thank you.""<br>`[138]` **Narrator**: "He quickly took a couple of note..." |
| `[133]` | **""I'll have the liver fricassée.""** | `[122]` **Waiter**: ""Of course. And you, sir?""<br>`[130]` **Waiter**: ""For the entrée, we have the opt..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] = true;` | `[170]` **Isabel Edmonds**: ""I'll have the salad. Thank you.""<br>`[138]` **Narrator**: "He quickly took a couple of note..." |
| `[134]` | **""I'll have Salade Luco.""** | `[130]` **Waiter**: ""For the entrée, we have the opt..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] = true;` | `[171]` **Isabel Edmonds**: ""I'll have the same. Thank you."" |
| `[140]` | **""Mrs. Edmonds. You know why we're here.""** | `[139]` **Narrator**: "He went back downstairs, leaving..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Isabel Edmonds**: ""Yes, Mr. President. I know."" |
| `[141]` | **""How is the situation in the Supreme Court?""** | `[139]` **Narrator**: "He went back downstairs, leaving..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Isabel Edmonds**: ""Let's just say... busy."" |
| `[142]` | **""We want to cooperate with you, Mrs. Edmonds.""** | `[139]` **Narrator**: "He went back downstairs, leaving..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Isabel Edmonds**: ""That's very welcome, Mr. Presid..." |
| `[143]` | **""Let's get to the point, shall we?""** | `[139]` **Narrator**: "He went back downstairs, leaving..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Isabel Edmonds**: ""As you wish, Mr. President."" |
| `[172]` | **""I am, thank you.""** | `[81]` **Isabel Edmonds**: ""Mr. President. Good to see you...."<br>`[82]` **Isabel Edmonds**: ""Mr. President. I hope you're en..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Narrator**: "The waiter held a chair for Isabel." |
| `[191]` | **"Stay silent."** | `[190]` **Isabel Edmonds**: ""Let's see..."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn07_Isabel_Convinced...`<br>`Variable["BaseGameSupport.Journal_Turn07_Isabel_Failed"] ...` | `[198]` **Isabel Edmonds**: ""I think I can get behind this p..."<br>`[199]` **Isabel Edmonds**: ""I regret to say I do not see ey..." |
| `[192]` | **""Please, Isabel. This vote means a lot to us.""** | `[190]` **Isabel Edmonds**: ""Let's see..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Isabel Edmonds**: ""Okay. Let me finish, Mr. Presid..." |
| `[193]` | **""Mrs. Edmonds, I really hope you vote for the proposal.""** | `[190]` **Isabel Edmonds**: ""Let's see..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Isabel Edmonds**: ""Okay. Let me finish, Mr. Presid..." |
| `[200]` | **""Please reconsider, Mrs. Edmonds. This proposal is very important.""** | `[199]` **Isabel Edmonds**: ""I regret to say I do not see ey..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Isabel Edmonds**: ""I don't think my conclusion wil..." |
| `[201]` | **""That's very sad to hear. Is there no way to change your mind?""** | `[199]` **Isabel Edmonds**: ""I regret to say I do not see ey..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Isabel Edmonds**: ""I don't think so, Mr. President."" |
| `[202]` | **""Look, I will be clear. Whatever you think about it, you will vote yes!""** | `[199]` **Isabel Edmonds**: ""I regret to say I do not see ey..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Isabel Edmonds**: ""Mr. President... Please."" |
| `[204]` | **""That's great to hear.""** | `[198]` **Isabel Edmonds**: ""I think I can get behind this p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[412]` **Isabel Edmonds**: ""I'll do my best to get the thre..."<br>`[211]` **Isabel Edmonds**: ""I can get you the three votes y..."<br>*(oraz 1 innych odgałęzień)* |
| `[205]` | **""You think?""** | `[198]` **Isabel Edmonds**: ""I think I can get behind this p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Isabel Edmonds**: ""Yes."" |
| `[206]` | **""Thank you, Mrs. Edmonds.""** | `[198]` **Isabel Edmonds**: ""I think I can get behind this p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[412]` **Isabel Edmonds**: ""I'll do my best to get the thre..."<br>`[211]` **Isabel Edmonds**: ""I can get you the three votes y..."<br>*(oraz 1 innych odgałęzień)* |
| `[221]` | **""Thank you.""** | `[220]` **Isabel Edmonds**: ""We were already somewhat inclin..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Reform_Isabel_Convinced"] = true;` | `[243]` **Isabel Edmonds**: ""I see that we're all finished w..."<br>`[232]` **Nia Morgna**: ""That's great to hear that you w..." |
| `[222]` | **""Are you sure that you can bring three votes?""** | `[220]` **Isabel Edmonds**: ""We were already somewhat inclin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Isabel Edmonds**: ""Yes. We always act together. Th..." |
| `[223]` | **""Good.""** | `[220]` **Isabel Edmonds**: ""We were already somewhat inclin..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Reform_Isabel_Convinced"] = true;` | `[243]` **Isabel Edmonds**: ""I see that we're all finished w..."<br>`[232]` **Nia Morgna**: ""That's great to hear that you w..." |
| `[225]` | **""That's not good enough.""** | `[219]` **Isabel Edmonds**: ""I'll do my best to convince my ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Isabel Edmonds**: ""I told you that I will speak wi..." |
| `[226]` | **""Thank you.""** | `[219]` **Isabel Edmonds**: ""I'll do my best to convince my ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Reform_Isabel_Convinced"] = true;` | `[243]` **Isabel Edmonds**: ""I see that we're all finished w..."<br>`[232]` **Nia Morgna**: ""That's great to hear that you w..." |
| `[227]` | **""So you are not sure if you can bring three votes?""** | `[219]` **Isabel Edmonds**: ""I'll do my best to convince my ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Isabel Edmonds**: ""I told you that I will speak wi..." |
| `[234]` | **""Don't disrespect me like this, Mrs. Edmonds.""** | `[218]` **Isabel Edmonds**: ""Thank you for inviting me here,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Narrator**: "She stood up." |
| `[235]` | **""Thank you for coming.""** | `[218]` **Isabel Edmonds**: ""Thank you for inviting me here,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Narrator**: "She stood up and shook my hand." |
| `[236]` | **""You can't leave before we agree on this.""** | `[218]` **Isabel Edmonds**: ""Thank you for inviting me here,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Narrator**: "She stood up." |
| `[245]` | **""Thank you for coming.""** | `[244]` **Isabel Edmonds**: ""Thank you for inviting me here,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[248]` **Narrator**: "She stood up and shook my hand." |
| `[246]` | **""Let's change the Constitution, Mrs. Edmonds!""** | `[244]` **Isabel Edmonds**: ""Thank you for inviting me here,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[248]` **Narrator**: "She stood up and shook my hand." |
| `[247]` | **""I'll be expecting your vote in the upcoming session.""** | `[244]` **Isabel Edmonds**: ""Thank you for inviting me here,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[248]` **Narrator**: "She stood up and shook my hand." |
| `[252]` | **""What do we do now?""** | `[251]` **Nia Morgna**: ""That's not good."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Nia Morgna**: ""You should maybe talk to Lucian..." |
| `[253]` | **""It's not...""** | `[251]` **Nia Morgna**: ""That's not good."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Nia Morgna**: ""You should maybe talk to Lucian..." |
| `[254]` | **""Oh really? Tell me about it!""** | `[251]` **Nia Morgna**: ""That's not good."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Narrator**: "She did not reply." |
| `[260]` | **""Yes. I hope we can trust her.""** | `[259]` **Nia Morgna**: ""That's good news."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Nia Morgna**: ""You should maybe talk to Lucian..." |
| `[261]` | **""We still need to reach out to more people. She won't be enough.""** | `[259]` **Nia Morgna**: ""That's good news."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Nia Morgna**: ""You should maybe talk to Lucian..." |
| `[262]` | **""That's great news!""** | `[259]` **Nia Morgna**: ""That's good news."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[264]` **Narrator**: "After a few minutes of thoughtfu..." |
| `[351]` | **""Arrange a meeting with him immediately.""** | `[350]` **Lucian Galade**: ""He wants to arrange a meeting o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[355]` **Lucian Galade**: ""Understood, sir."" |
| `[352]` | **""That's good news. I'll leave the arrangement up to you.""** | `[350]` **Lucian Galade**: ""He wants to arrange a meeting o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[355]` **Lucian Galade**: ""Understood, sir."" |
| `[353]` | **""That I cannot do, Lucian.""** | `[350]` **Lucian Galade**: ""He wants to arrange a meeting o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Lucian Galade**: ""Sir, are you sure? He'd be very..." |
| `[357]` | **""Okay, I'll leave it to your judgement.""** | `[354]` **Lucian Galade**: ""Sir, are you sure? He'd be very..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Lucian Galade**: ""Understood, sir. Then I'll try ..." |
| `[358]` | **""Yes. I'm sure.""** | `[354]` **Lucian Galade**: ""Sir, are you sure? He'd be very..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Lucian Galade**: ""Understood, sir."" |
| `[360]` | **""Don't make me repeat myself, Lucian.""** | `[354]` **Lucian Galade**: ""Sir, are you sure? He'd be very..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Lucian Galade**: ""Understood, sir."" |
| `[363]` | **""Arrange a meeting with him immediately.""** | `[348]` **Kesaro Kibener**: ""I will try to arrange something..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Kesaro Kibener**: ""Understood. Leave that up to me."" |
| `[364]` | **""That's good news. I'll leave the arrangement up to you.""** | `[348]` **Kesaro Kibener**: ""I will try to arrange something..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Kesaro Kibener**: ""Understood. Leave that up to me."" |
| `[365]` | **""That I cannot do, Kesaro.""** | `[348]` **Kesaro Kibener**: ""I will try to arrange something..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[366]` **Kesaro Kibener**: ""What do you mean? I thought you..." |
| `[368]` | **""You're right. Okay, I'll leave the arrangement to your judgement, Kesaro.""** | `[366]` **Kesaro Kibener**: ""What do you mean? I thought you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Kesaro Kibener**: ""Of course."" |
| `[369]` | **""Yes, I did. But the meeting has to be on my terms. Is he not willing to meet in H..."** | `[366]` **Kesaro Kibener**: ""What do you mean? I thought you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[371]` **Kesaro Kibener**: ""I'm afraid that won't do for him."" |
| `[370]` | **""He's either going to come to my office or we won't have a meeting.""** | `[366]` **Kesaro Kibener**: ""What do you mean? I thought you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[371]` **Kesaro Kibener**: ""I'm afraid that won't do for him."" |
| `[372]` | **""Fine. We'll have it his way.""** | `[371]` **Kesaro Kibener**: ""I'm afraid that won't do for him."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[376]` **Kesaro Kibener**: ""Okay. I'll arrange it soon."" |
| `[373]` | **""Then force him. I thought you were supposed to convince him.""** | `[371]` **Kesaro Kibener**: ""I'm afraid that won't do for him."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Kesaro Kibener**: ""I already did. You are asking f..." |
| `[414]` | **""That's not good enough.""** | `[413]` **Isabel Edmonds**: ""Your changes to Article 6 and 7..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[417]` **Isabel Edmonds**: ""Maybe you should have thought a..." |
| `[415]` | **""Thank you.""** | `[413]` **Isabel Edmonds**: ""Your changes to Article 6 and 7..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Reform_Isabel_Convinced"] = true;` | `[243]` **Isabel Edmonds**: ""I see that we're all finished w..."<br>`[232]` **Nia Morgna**: ""That's great to hear that you w..." |
| `[416]` | **""So you are not sure if you can bring three votes?""** | `[413]` **Isabel Edmonds**: ""Your changes to Article 6 and 7..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[417]` **Isabel Edmonds**: ""Maybe you should have thought a..." |

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
  - -> `[5]` (*Narrator: "Nia Morgna had arranged a dinner meeting with Justice Isa..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "We settled on a table on the second floor of Le Papillion, a world class Lespian restaurant in downtown Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The whole floor was reserved for us, and the music coming..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The whole floor was reserved for us, and the music coming from downstairs was enough to guard our voices from potential eavesdroppers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Nia Morgna: ""...I still can't believe Soll came to the vote.""*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Nia Morgna had arranged a dinner meeting with Justice Isabel Edmonds. Ahead of the dinner, Nia and I met to have a talk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "We settled on a table on the second floor of Le Papillion..."*)

### Węzeł `[6]`
Mówca: **Nia Morgna**
> ""...I still can't believe Soll came to the vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[10]`
Mówca: **Narrator**
> "The waiter approached us and bowed in respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Waiter: ""Did you decide on the entrée, sir?""*)

### Węzeł `[11]`
Mówca: **Waiter**
> ""Did you decide on the entrée, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: ""We have a guest coming. We'll wait for her to order.""*)
  - -> `[13]` (*Player: ""Not yet.""*)
  - -> `[14]` (*Player: ""What's on today's menu?""*)
  - -> `[15]` (*Player: ""We are in a meeting here. Can you leave us alone?""*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""We have a guest coming. We'll wait for her to order.""]** — Mówca: **Player**
> ""We have a guest coming. We'll wait for her to order.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Waiter: ""Of course, sir.""*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""Not yet.""]** — Mówca: **Player**
> ""Not yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Waiter: ""And madame?""*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""What's on today's menu?""]** — Mówca: **Player**
> ""What's on today's menu?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Waiter: ""For the entrée, we have the options of sauté-Perlase wit..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""We are in a meeting here. Can you leave us alone?""]** — Mówca: **Player**
> ""We are in a meeting here. Can you leave us alone?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Waiter: ""Of course, sir. I'm sorry.""*)

### Węzeł `[16]`
Mówca: **Waiter**
> ""Of course, sir. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Waiter: ""I'll leave you to it.""*)

### Węzeł `[17]`
Mówca: **Waiter**
> ""And madame?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[18]`
Mówca: **Nia Morgna**
> ""We'll order later, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Waiter: ""Of course, madame.""*)

### Węzeł `[19]`
Mówca: **Waiter**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Waiter: ""I'll be around.""*)

### Węzeł `[20]`
Mówca: **Waiter**
> ""For the entrée, we have the options of sauté-Perlase with Lespian-style Zabla, Falenco-style liver fricassée, or Salade Luco made with fresh vegetables and herbs from southern Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""I'll have sauté-Perlase with Lespian Zabla.""*)
  - -> `[22]` (*Player: ""I'll have the liver fricassée.""*)
  - -> `[23]` (*Player: ""I'll have Salade Luco.""*)
  - -> `[24]` (*Player: ""I won't order now.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""I'll have sauté-Perlase with Lespian Zabla.""]** — Mówca: **Player**
> ""I'll have sauté-Perlase with Lespian Zabla.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_LespianZabla = true"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""I'll have the liver fricassée.""]** — Mówca: **Player**
> ""I'll have the liver fricassée.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Liver = true"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""I'll have Salade Luco.""]** — Mówca: **Player**
> ""I'll have Salade Luco.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Salad = true"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""I won't order now.""]** — Mówca: **Player**
> ""I won't order now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Waiter: ""As you wish, sir.""*)

### Węzeł `[25]`
Mówca: **Waiter**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "He went downstairs again."*)

### Węzeł `[26]`
Mówca: **Waiter**
> ""Perfect. And you, madame?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[27]`
Mówca: **Nia Morgna**
> ""No thank you. I'd rather wait for our guest to arrive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Waiter: ""Of course. I'll be around.""*)

### Węzeł `[28]`
Mówca: **Waiter**
> ""I'll be around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "He went downstairs again."*)

### Węzeł `[29]`
Mówca: **Waiter**
> ""Of course, madame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "He went downstairs again."*)

### Węzeł `[30]`
Mówca: **Waiter**
> ""I'll leave you to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "He went downstairs again."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "He went downstairs again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[32]`
Mówca: **Waiter**
> ""Of course. I'll be around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Early = true"*)

### Węzeł `[33]`
Mówca: **Nia Morgna**
> ""Let's try not to agitate her when she comes. We won the vote, so she already has pressure on her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_AntiCorruptionPolice == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Nia Morgna: ""Not to mention the pressure from the anti-corruption pol..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Nia Morgna: ""But if she feels cornered, we might lose her. So it's im..."*)

### Węzeł `[37]`
Mówca: **Nia Morgna**
> ""Not to mention the pressure from the anti-corruption police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Nia Morgna: ""But if she feels cornered, we might lose her. So it's im..."*)

### Węzeł `[38]`
Mówca: **Nia Morgna**
> ""But if she feels cornered, we might lose her. So it's important not to put too much pressure on her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: ""Agreed. We shouldn't scare her off.""*)
  - -> `[40]` (*Player: ""I disagree. We must keep up the pressure.""*)
  - -> `[41]` (*Player: ""Let's not overthink this.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Agreed. We shouldn't scare her off.""]** — Mówca: **Player**
> ""Agreed. We shouldn't scare her off.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Nia Morgna: ""That's for the best.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""I disagree. We must keep up the pressure.""]** — Mówca: **Player**
> ""I disagree. We must keep up the pressure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Nia Morgna: ""I am not sure about that, Mr. President.""*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Let's not overthink this.""]** — Mówca: **Player**
> ""Let's not overthink this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Nia Morgna: ""Agreed.""*)

### Węzeł `[42]`
Mówca: **Nia Morgna**
> ""Agreed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Salad == true || BaseGa..."*)

### Węzeł `[43]`
Mówca: **Nia Morgna**
> ""I am not sure about that, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Nia Morgna: ""Just please don't forget that we cannot succeed without ..."*)

### Węzeł `[44]`
Mówca: **Nia Morgna**
> ""Just please don't forget that we cannot succeed without her help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Salad == true || BaseGa..."*)

### Węzeł `[45]`
Mówca: **Nia Morgna**
> ""That's for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Salad == true || BaseGa..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `NiaHubEnd`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Nia Morgna: ""Let's try not to agitate her when she comes. We won the ..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "At that moment, the waiter came back with my order."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Waiter: ""May I?""*)

### Węzeł `[48]`
Mówca: **Nia Morgna**
> ""Oh, Good to see you, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Nia got up from her chair to shake Isabel's hand."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Suddenly, I noticed Justice Isabel Edmonds coming upstairs. She was wearing a plain dark gray dress that hid most of her features."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Nia Morgna: ""Oh, Good to see you, Mrs. Edmonds.""*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Nia got up from her chair to shake Isabel's hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player_Italic: "Stand up for a handshake."*)
  - -> `[52]` (*Player_Italic: "Welcome her from your seat."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "Stand up for a handshake."]** — Mówca: **Player_Italic**
> "I stood up and shook her hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Isabel Edmonds: ""Mr. President. Good to see you.""*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "Welcome her from your seat."]** — Mówca: **Player_Italic**
> "I welcomed her without standing up."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Nia Morgna: ""Oh, Good to see you, Mrs. Edmonds.""*)

### Węzeł `[54]`
Mówca: **Isabel Edmonds**
> ""Mr. President. Good to see you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: ""Good to see you, Justice Edmonds.""*)
  - -> `[109]` (*Player: ""Welcome, Mrs. Edmonds.""*)
  - -> `[107]` (*Player: ""Please, take a seat.""*)

### Węzeł `[55]`
Mówca: **Narrator**
> "She bowed her head slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Isabel Edmonds: ""Mr. President.""*)

### Węzeł `[56]`
Mówca: **Isabel Edmonds**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: ""Good to see you, Justice Edmonds.""*)
  - -> `[109]` (*Player: ""Welcome, Mrs. Edmonds.""*)
  - -> `[107]` (*Player: ""Please, take a seat.""*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Salad = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Waiter: ""Perfect. And you, madame?""*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Liver = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Waiter: ""Perfect. And you, madame?""*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_LespianZabla = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Waiter: ""Perfect. And you, madame?""*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Salad == true || BaseGameIsolated.Turn07_A_Ordered_Liver == true || BaseGameIsolated.Turn07_A_Ordered_LespianZabla == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Salad == true || BaseGa..."*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Ordered_Salad == true || Base..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Salad == true || BaseGameIsolated.Turn07_A_Ordered_Liver == true || BaseGameIsolated.Turn07_A_Ordered_LespianZabla == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] == true  or  Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] == true  or  Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "At that moment, the waiter came back with my order."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Ordered_Salad == true || BaseGameIsolated.Turn07_A_Ordered_Liver == true || BaseGameIsolated.Turn07_A_Ordered_LespianZabla == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] == true  or  Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] == true  or  Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Suddenly, I noticed Justice Isabel Edmonds coming upstair..."*)

### Węzeł `[63]`
Mówca: **Waiter**
> ""May I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Salad == true"*)

### Węzeł `[64]`
Mówca: **Narrator**
> "He placed the plate of Salade Luco on the table. It looked very fresh and smelled of olive oil."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He went ahead and refilled our glasses with water."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Salad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Salad == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Ordered_Salad == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Salad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "He placed the plate of Salade Luco on the table. It looke..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Ordered_Salad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Liver == true"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Liver == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Liver == true"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Ordered_Liver == true)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Liver == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "He placed the plate of Falenco style liver fricassée on t..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Ordered_Liver == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "He placed the plate of sauté-Perlase and next to it, the ..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "He placed the plate of Falenco style liver fricassée on the table. It looked and smelled like heaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He went ahead and refilled our glasses with water."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "He placed the plate of sauté-Perlase and next to it, the Lespian style Zabla, which was served in a small clay bowl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He went ahead and refilled our glasses with water."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "He went ahead and refilled our glasses with water."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Waiter: ""Bon Appétit.""*)

### Węzeł `[74]`
Mówca: **Waiter**
> ""Bon Appétit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Suddenly, I noticed Justice Isabel Edmonds coming upstair..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "Welcome her from your seat."]** — Mówca: **Player_Italic**
> "I welcomed her without standing up."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[76]`
Mówca: **Nia Morgna**
> ""Oh, Good to see you, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "Nia got up from her chair to shake Isabel's hand."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "Suddenly, I noticed Justice Isabel Edmonds coming upstairs. She was wearing a plain dark gray dress that hid most of her features."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1"*)

### Węzeł `[78]`
Mówca: **Narrator**
> "Nia got up from her chair to shake Isabel's hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Italic: "Stand up for a handshake."*)
  - -> `[75]` (*Player_Italic: "Welcome her from your seat."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "She bowed her head slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Isabel Edmonds: ""Mr. President. I hope you're enjoying your meal.""*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "Stand up for a handshake."]** — Mówca: **Player_Italic**
> "I stood up and shook her hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Isabel Edmonds: ""Mr. President. Good to see you. I hope you're enjoying y..."*)

### Węzeł `[81]`
Mówca: **Isabel Edmonds**
> ""Mr. President. Good to see you. I hope you're enjoying your meal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: ""I am, thank you.""*)
  - -> `[90]` (*Player: ""Good to see you, Justice Edmonds.""*)
  - -> `[91]` (*Player: ""Please, join me.""*)
  - -> `[92]` (*Player: ""Please, take a seat.""*)

### Węzeł `[82]`
Mówca: **Isabel Edmonds**
> ""Mr. President. I hope you're enjoying your meal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: ""I am, thank you.""*)
  - -> `[90]` (*Player: ""Good to see you, Justice Edmonds.""*)
  - -> `[91]` (*Player: ""Please, join me.""*)
  - -> `[92]` (*Player: ""Please, take a seat.""*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "She bowed her head slightly."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] = Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "She bowed her head slightly."*)

### Węzeł `[85]`
Mówca: **Waiter**
> ""Would you like to order Madame?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "She took a long look at the table and my plate."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "The waiter held a chair for Isabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Waiter: ""Would you like to order Madame?""*)

### Węzeł `[87]`
Mówca: **Nia Morgna**
> ""Is there something wrong, Mrs. Edmonds?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Isabel Edmonds: ""Oh no, there's nothing wrong. I just don't want to eat u..."*)

### Węzeł `[88]`
Mówca: **Isabel Edmonds**
> ""No, thank you. I won't be here long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Nia Morgna: ""Is there something wrong, Mrs. Edmonds?""*)

### Węzeł `[89]`
Mówca: **Narrator**
> "She took a long look at the table and my plate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Isabel Edmonds: ""No, thank you. I won't be here long.""*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""Good to see you, Justice Edmonds.""]** — Mówca: **Player**
> ""Good to see you, Justice Edmonds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Isabel Edmonds), `[82]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "The waiter held a chair for Isabel."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""Please, join me.""]** — Mówca: **Player**
> ""Please, join me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Isabel Edmonds), `[82]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "The waiter held a chair for Isabel."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Please, take a seat.""]** — Mówca: **Player**
> ""Please, take a seat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Isabel Edmonds), `[82]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "The waiter held a chair for Isabel."*)

### Węzeł `[93]`
Mówca: **Isabel Edmonds**
> ""Oh no, there's nothing wrong. I just don't want to eat up too much of your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Isabel Edmonds: ""I also didn't want to intrude your meal, Mr. President.""*)

### Węzeł `[94]`
Mówca: **Isabel Edmonds**
> ""I also didn't want to intrude your meal, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player: ""It's okay, Mrs. Edmonds. I thought we were here to meet ..."*)
  - -> `[97]` (*Player: ""Please, don't worry about it.""*)
  - -> `[95]` (*Player: ""Wouldn't you want to join me?""*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Wouldn't you want to join me?""]** — Mówca: **Player**
> ""Wouldn't you want to join me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Isabel Edmonds: ""Thanks for the offer. I'm good.""*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""It's okay, Mrs. Edmonds. I thought we were here to meet over a meal.""]** — Mówca: **Player**
> ""It's okay, Mrs. Edmonds. I thought we were here to meet over a meal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "She stared at me for a second."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Please, don't worry about it.""]** — Mówca: **Player**
> ""Please, don't worry about it. ""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Isabel Edmonds: ""As you wish.""*)

### Węzeł `[98]`
Mówca: **Isabel Edmonds**
> ""Yes...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "The waiter looked uncomfortable while waiting for the ord..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "She stared at me for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Isabel Edmonds: ""Yes...""*)

### Węzeł `[100]`
Mówca: **Isabel Edmonds**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "The waiter looked uncomfortable while waiting for the ord..."*)

### Węzeł `[101]`
Mówca: **Isabel Edmonds**
> ""Thanks for the offer. I'm good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "The waiter looked uncomfortable while waiting for the ord..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA: ""What was on the menu?""]** — Mówca: **Player**
> ""What was on the menu?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Kontekst wejściowy (poprzednik):** `[115]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Waiter: ""For the entrée, we have the options of sauté-Perlase wit..."*)

### Węzeł `[103]`
Mówca: **Nia Morgna**
> ""Come on, Mrs. Edmonds. Let's order something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Nia Morgna: ""I'll have the sauté-Perlase, please. And for Mrs. Edmond..."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "The waiter looked uncomfortable while waiting for the orders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[105]`
Mówca: **Nia Morgna**
> ""I'll have the sauté-Perlase, please. And for Mrs. Edmonds...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Isabel Edmonds: ""...I'll have the salad, then. Thank you.""*)

### Węzeł `[106]`
Mówca: **Isabel Edmonds**
> ""...I'll have the salad, then. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Waiter: ""Perfect.""*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Please, take a seat.""]** — Mówca: **Player**
> ""Please, take a seat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Isabel Edmonds), `[56]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "She took a seat across the table."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""Good to see you, Justice Edmonds.""]** — Mówca: **Player**
> ""Good to see you, Justice Edmonds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Isabel Edmonds), `[56]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "She took a seat across the table."*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""Welcome, Mrs. Edmonds.""]** — Mówca: **Player**
> ""Welcome, Mrs. Edmonds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Isabel Edmonds), `[56]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "She took a seat across the table."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "She took a seat across the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Nia Morgna: ""How was your day, Mrs. Edmonds?""*)

### Węzeł `[111]`
Mówca: **Isabel Edmonds**
> ""I would normally say good, but this time I will take the liberty to say that it was insanely exhausting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Isabel Edmonds: ""Heavy court matters again... Not that I'm complaining.""*)

### Węzeł `[112]`
Mówca: **Nia Morgna**
> ""How was your day, Mrs. Edmonds?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Isabel Edmonds: ""I would normally say good, but this time I will take the..."*)

### Węzeł `[113]`
Mówca: **Isabel Edmonds**
> ""Heavy court matters again... Not that I'm complaining.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[114]`
Mówca: **Narrator**
> "Suddenly, the waiter approached us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Waiter: ""Are you ready to give the orders, sir? Madame?""*)

### Węzeł `[115]`
Mówca: **Waiter**
> ""Are you ready to give the orders, sir? Madame?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[116]`
Mówca: **Nia Morgna**
> ""I'll have the sauté-Perlase, please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Waiter: ""As you wish.""*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""I'll have the same.""]** — Mówca: **Player**
> ""I'll have the same.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Waiter: ""Perfect, sir.""*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Mrs. Edmonds?""]** — Mówca: **Player**
> ""Mrs. Edmonds?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Kontekst wejściowy (poprzednik):** `[121]` (Waiter), `[115]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Isabel Edmonds: ""I'll have the salad. Thank you.""*)

### Węzeł `[119]`
Mówca: **Isabel Edmonds**
> ""I'll have the salad. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_IsabelOrdered_Salad = true"*)

### Węzeł `[120]`
Mówca: **Waiter**
> ""Perfect, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_LespianZabla = true"*)

### Węzeł `[121]`
Mówca: **Waiter**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: ""I'll have the same.""*)
  - -> `[118]` (*Player: ""Mrs. Edmonds?""*)

### Węzeł `[122]`
Mówca: **Waiter**
> ""Of course. And you, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: ""I'll have sauté-Perlase with Lespian Zabla.""*)
  - -> `[133]` (*Player: ""I'll have the liver fricassée.""*)
  - -> `[123]` (*Player: ""I'll have the salad too.""*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""I'll have the salad too.""]** — Mówca: **Player**
> ""I'll have the salad too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Salad = true"*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""I'll get the same as Mrs. Morgna.""]** — Mówca: **Player**
> ""I'll get the same as Mrs. Morgna.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[122]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_LespianZabla = true"*)

### Węzeł `[125]`
Mówca: **Waiter**
> ""Perfect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "He quickly took a couple of notes in his tiny notebook."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_LespianZabla = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_IsabelOrdered_Salad == false"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_LespianZabla = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Waiter: ""Perfect.""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Salad = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Waiter: ""Perfect.""*)

### Węzeł `[129]`
Mówca: **Waiter**
> ""I'll be back shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "He went back downstairs, leaving us alone on the upper fl..."*)

### Węzeł `[130]`
Mówca: **Waiter**
> ""For the entrée, we have the options of sauté-Perlase with Lespian-style Zabla, Falenco-style liver fricassée, or Salade Luco made with fresh vegetables and herbs from southern Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: ""I'll have sauté-Perlase with Lespian Zabla.""*)
  - -> `[133]` (*Player: ""I'll have the liver fricassée.""*)
  - -> `[134]` (*Player: ""I'll have Salade Luco.""*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Liver = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_IsabelOrdered_Salad == false"*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""I'll have sauté-Perlase with Lespian Zabla.""]** — Mówca: **Player**
> ""I'll have sauté-Perlase with Lespian Zabla.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Waiter), `[130]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_LespianZabla = true"*)

### Węzeł `[133]`
**[WYBÓR GRACZA: ""I'll have the liver fricassée.""]** — Mówca: **Player**
> ""I'll have the liver fricassée.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Waiter), `[130]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Liver = true"*)

### Węzeł `[134]`
**[WYBÓR GRACZA: ""I'll have Salade Luco.""]** — Mówca: **Player**
> ""I'll have Salade Luco.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Waiter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Salad = true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_LespianZabla = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_LespianZabla"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_IsabelOrdered_Salad == false"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Salad = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Isabel Edmonds: ""I'll have the same. Thank you.""*)

### Węzeł `[137]`
Mówca: **Waiter**
> ""Perfect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "He quickly took a couple of notes in his tiny notebook."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "He quickly took a couple of notes in his tiny notebook."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Waiter: ""I'll be back shortly.""*)

### Węzeł `[139]`
Mówca: **Narrator**
> "He went back downstairs, leaving us alone on the upper floor again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player: ""Mrs. Edmonds. You know why we're here.""*)
  - -> `[141]` (*Player: ""How is the situation in the Supreme Court?""*)
  - -> `[142]` (*Player: ""We want to cooperate with you, Mrs. Edmonds.""*)
  - -> `[143]` (*Player: ""Let's get to the point, shall we?""*)

### Węzeł `[140]`
**[WYBÓR GRACZA: ""Mrs. Edmonds. You know why we're here.""]** — Mówca: **Player**
> ""Mrs. Edmonds. You know why we're here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Isabel Edmonds: ""Yes, Mr. President. I know.""*)

### Węzeł `[141]`
**[WYBÓR GRACZA: ""How is the situation in the Supreme Court?""]** — Mówca: **Player**
> ""How is the situation in the Supreme Court?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Isabel Edmonds: ""Let's just say... busy.""*)

### Węzeł `[142]`
**[WYBÓR GRACZA: ""We want to cooperate with you, Mrs. Edmonds.""]** — Mówca: **Player**
> ""We want to cooperate with you, Mrs. Edmonds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Isabel Edmonds: ""That's very welcome, Mr. President. I want the same thing.""*)

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Let's get to the point, shall we?""]** — Mówca: **Player**
> ""Let's get to the point, shall we?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Isabel Edmonds: ""As you wish, Mr. President.""*)

### Węzeł `[144]`
Mówca: **Isabel Edmonds**
> ""As you wish, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "She moved herself on the chair to be more comfortable."*)

### Węzeł `[145]`
Mówca: **Isabel Edmonds**
> ""Yes, Mr. President. I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "She moved herself on the chair to be more comfortable."*)

### Węzeł `[146]`
Mówca: **Isabel Edmonds**
> ""That's very welcome, Mr. President. I want the same thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "She moved herself on the chair to be more comfortable."*)

### Węzeł `[147]`
Mówca: **Isabel Edmonds**
> ""Let's just say... busy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "She moved herself on the chair to be more comfortable."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "She moved herself on the chair to be more comfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[149]`
Mówca: **Narrator**
> "At that moment, the waiter came back from downstairs, carrying plates of food. After seeing that we were in the midst of a discussion, he averted his eyes as he approached us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Early == true"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Early = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Early"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "He went downstairs again."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Early == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Early == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Ordered_Early == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Early == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Early"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Ordered_Early == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Ordered_Early"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "He quickly started serving the food and refilled our glas..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "He quickly served Nia and Isabel's food and refilled all of our glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Isabel Edmonds: ""Thank you.""*)

### Węzeł `[155]`
Mówca: **Isabel Edmonds**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Waiter: ""Bon Appétit.""*)

### Węzeł `[156]`
Mówca: **Narrator**
> "He quickly started serving the food and refilled our glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Salad == true"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Liver == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Liver == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Ordered_Liver == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Liver == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "He placed the plate of Falenco-style liver fricassée in f..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Ordered_Liver == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Ordered_Liver"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "He placed the plate of sauté-Perlase and next to it, the ..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Salad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Salad == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Ordered_Salad == true)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Ordered_Salad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "He placed the plate of Salade Luco in front of me. It loo..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Ordered_Salad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Ordered_Salad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Liver == true"*)

### Węzeł `[163]`
Mówca: **Narrator**
> "He placed the plate of Falenco-style liver fricassée in front of me. It looked and smelled like heaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "I was very hungry."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "He placed the plate of Salade Luco in front of me. It looked very fresh and smelled of olive oil."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "I was very hungry."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "He placed the plate of sauté-Perlase and next to it, the Lespian style Zabla, which was served in a small clay bowl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "I was very hungry."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "I was very hungry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Waiter: ""Bon Appétit.""*)

### Węzeł `[167]`
Mówca: **Waiter**
> ""Bon Appétit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[168]`
Mówca: **Waiter**
> ""Bon Appétit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[169]`
Mówca: **Nia Morgna**
> ""Thank you. It looks delicious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "The waiter bowed to us and quickly went downstairs."*)

### Węzeł `[170]`
Mówca: **Isabel Edmonds**
> ""I'll have the salad. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "He quickly took a couple of notes in his tiny notebook."*)

### Węzeł `[171]`
Mówca: **Isabel Edmonds**
> ""I'll have the same. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "He quickly took a couple of notes in his tiny notebook."*)

### Węzeł `[172]`
**[WYBÓR GRACZA: ""I am, thank you.""]** — Mówca: **Player**
> ""I am, thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Isabel Edmonds), `[82]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "The waiter held a chair for Isabel."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "The waiter bowed to us and quickly went downstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[174]`
Mówca: **Narrator**
> "We wished each other a good meal as Isabel and Nia slowly started to eat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Nia Morgna: ""So, Mrs. Edmonds... Are you still thinking the same abou..."*)

### Węzeł `[175]`
Mówca: **Nia Morgna**
> ""So, Mrs. Edmonds... Are you still thinking the same about the Old Guard?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Isabel Edmonds: ""Of course. Nothing has changed.""*)

### Węzeł `[176]`
Mówca: **Isabel Edmonds**
> ""Of course. Nothing has changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Nia Morgna: ""That's good. We still have that in common.""*)

### Węzeł `[177]`
Mówca: **Nia Morgna**
> ""That's good. We still have that in common.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Isabel Edmonds: ""That doesn't mean I will accept any proposal the Old Gua..."*)

### Węzeł `[178]`
Mówca: **Isabel Edmonds**
> ""That doesn't mean I will accept any proposal the Old Guards oppose...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)

### Węzeł `[179]`
Mówca: **Isabel Edmonds**
> ""...nor it means I will put the whole Court under the bus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Isabel Edmonds: ""The impeachment clause about the Justices affects all of..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true |..."*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Isabel Edmonds: ""...nor it means I will put the whole Court under the bus.""*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Nia Morgna: ""Yet we must do something.""*)

### Węzeł `[183]`
Mówca: **Isabel Edmonds**
> ""The impeachment clause about the Justices affects all of us, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Nia Morgna: ""I understand your concerns. I also do not agree with tha..."*)

### Węzeł `[184]`
Mówca: **Nia Morgna**
> ""Yet we must do something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Nia Morgna: ""You also know that we need this change in our institutio..."*)

### Węzeł `[185]`
Mówca: **Nia Morgna**
> ""You also know that we need this change in our institutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "Isabel took a sip from her water and turned to me."*)

### Węzeł `[186]`
Mówca: **Nia Morgna**
> ""I understand your concerns. I also do not agree with that clause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Nia Morgna: ""But we must start somewhere. I am supporting the Preside..."*)

### Węzeł `[187]`
Mówca: **Nia Morgna**
> ""But we must start somewhere. I am supporting the President because he made this proposal with good intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "Isabel took a sip from her water and turned to me."*)

### Węzeł `[188]`
Mówca: **Narrator**
> "Isabel took a sip from her water and turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[189]`
Mówca: **Nia Morgna**
> ""You have decided then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Isabel Edmonds: ""Let's see...""*)

### Węzeł `[190]`
Mówca: **Isabel Edmonds**
> ""Let's see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player: ""Mrs. Edmonds, I really hope you vote for the proposal.""*)
  - -> `[192]` (*Player: ""Please, Isabel. This vote means a lot to us.""*)
  - -> `[191]` (*Player_Italic: "Stay silent."*)

### Węzeł `[191]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I waited for her to continue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion >= 3"*)

### Węzeł `[192]`
**[WYBÓR GRACZA: ""Please, Isabel. This vote means a lot to us.""]** — Mówca: **Player**
> ""Please, Isabel. This vote means a lot to us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Isabel Edmonds: ""Okay. Let me finish, Mr. President.""*)

### Węzeł `[193]`
**[WYBÓR GRACZA: ""Mrs. Edmonds, I really hope you vote for the proposal.""]** — Mówca: **Player**
> ""Mrs. Edmonds, I really hope you vote for the proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Isabel Edmonds: ""Okay. Let me finish, Mr. President.""*)

### Węzeł `[194]`
Mówca: **Isabel Edmonds**
> ""Okay. Let me finish, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion >= 3"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Isabel_Opinion >= 3"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Isabel_Opinion >= 3)"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Isabel_Opinion >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Isabel_Convinced = true"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Isabel_Opinion >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Isabel_Opinion"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Isabel_Failed = true"*)

### Węzeł `[198]`
Mówca: **Isabel Edmonds**
> ""I think I can get behind this proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player: ""That's great to hear.""*)
  - -> `[206]` (*Player: ""Thank you, Mrs. Edmonds.""*)
  - -> `[205]` (*Player: ""You think?""*)

### Węzeł `[199]`
Mówca: **Isabel Edmonds**
> ""I regret to say I do not see eye to eye with you, Mr. President. I don't think I can support this proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player: ""Look, I will be clear. Whatever you think about it, you ..."*)
  - -> `[201]` (*Player: ""That's very sad to hear. Is there no way to change your ..."*)
  - -> `[200]` (*Player: ""Please reconsider, Mrs. Edmonds. This proposal is very i..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA: ""Please reconsider, Mrs. Edmonds. This proposal is very important.""]** — Mówca: **Player**
> ""Please reconsider, Mrs. Edmonds. This proposal is very important.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[199]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Isabel Edmonds: ""I don't think my conclusion will differ.""*)

### Węzeł `[201]`
**[WYBÓR GRACZA: ""That's very sad to hear. Is there no way to change your mind?""]** — Mówca: **Player**
> ""That's very sad to hear. Is there no way to change your mind?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[199]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Isabel Edmonds: ""I don't think so, Mr. President.""*)

### Węzeł `[202]`
**[WYBÓR GRACZA: ""Look, I will be clear. Whatever you think about it, you will vote yes!""]** — Mówca: **Player**
> ""Look, I will be clear. Whatever you think about it, you will vote yes!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[199]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Isabel Edmonds: ""Mr. President... Please.""*)

### Węzeł `[203]`
Mówca: **Isabel Edmonds**
> ""Mr. President... Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[204]`
**[WYBÓR GRACZA: ""That's great to hear.""]** — Mówca: **Player**
> ""That's great to hear.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[205]`
**[WYBÓR GRACZA: ""You think?""]** — Mówca: **Player**
> ""You think?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Isabel Edmonds: ""Yes.""*)

### Węzeł `[206]`
**[WYBÓR GRACZA: ""Thank you, Mrs. Edmonds.""]** — Mówca: **Player**
> ""Thank you, Mrs. Edmonds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[207]`
Mówca: **Isabel Edmonds**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_AntiCorruptionPolice == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Isabel Edmonds: ""I can get you the three votes you need.""*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Isabel Edmonds: ""I think I can get you the votes you need.""*)

### Węzeł `[211]`
Mówca: **Isabel Edmonds**
> ""I can get you the three votes you need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Isabel Edmonds: ""We were already somewhat inclined to vote for the propos..."*)

### Węzeł `[212]`
Mówca: **Isabel Edmonds**
> ""I think I can get you the votes you need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Isabel Edmonds: ""I'll do my best to convince my group. But I can only spe..."*)

### Węzeł `[213]`
Mówca: **Isabel Edmonds**
> ""I don't think so, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[214]`
Mówca: **Isabel Edmonds**
> ""I don't think my conclusion will differ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[215]`
Mówca: **Nia Morgna**
> ""Justice Edmonds...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Isabel Edmonds: ""In fact, I think it's time that I leave.""*)

### Węzeł `[216]`
Mówca: **Isabel Edmonds**
> ""In fact, I think it's time that I leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Isabel Edmonds: ""I see that we're all finished with our meals too. I thin..."*)

### Węzeł `[217]`
Mówca: **Isabel Edmonds**
> ""I see that we're all finished with our meals too. I think it's time to conclude this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Isabel Edmonds: ""Thank you for inviting me here, Mr. President.""*)

### Węzeł `[218]`
Mówca: **Isabel Edmonds**
> ""Thank you for inviting me here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player: ""Thank you for coming.""*)
  - -> `[236]` (*Player: ""You can't leave before we agree on this.""*)
  - -> `[234]` (*Player: ""Don't disrespect me like this, Mrs. Edmonds.""*)

### Węzeł `[219]`
Mówca: **Isabel Edmonds**
> ""I'll do my best to convince my group. But I can only speak for myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player: ""Thank you.""*)
  - -> `[227]` (*Player: ""So you are not sure if you can bring three votes?""*)
  - -> `[225]` (*Player: ""That's not good enough.""*)

### Węzeł `[220]`
Mówca: **Isabel Edmonds**
> ""We were already somewhat inclined to vote for the proposal. I will talk with my group.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player: ""Thank you.""*)
  - -> `[222]` (*Player: ""Are you sure that you can bring three votes?""*)
  - -> `[223]` (*Player: ""Good.""*)

### Węzeł `[221]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Isabel_Convinced = true"*)

### Węzeł `[222]`
**[WYBÓR GRACZA: ""Are you sure that you can bring three votes?""]** — Mówca: **Player**
> ""Are you sure that you can bring three votes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Isabel Edmonds: ""Yes. We always act together. They will listen to me.""*)

### Węzeł `[223]`
**[WYBÓR GRACZA: ""Good.""]** — Mówca: **Player**
> ""Good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Isabel_Convinced = true"*)

### Węzeł `[224]`
Mówca: **Isabel Edmonds**
> ""Yes. We always act together. They will listen to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Isabel_Convinced = true"*)

### Węzeł `[225]`
**[WYBÓR GRACZA: ""That's not good enough.""]** — Mówca: **Player**
> ""That's not good enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Isabel Edmonds: ""I told you that I will speak with them. What else would ..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Isabel_Convinced = true"*)

### Węzeł `[227]`
**[WYBÓR GRACZA: ""So you are not sure if you can bring three votes?""]** — Mówca: **Player**
> ""So you are not sure if you can bring three votes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Isabel Edmonds: ""I told you that I will speak with them. What else would ..."*)

### Węzeł `[228]`
Mówca: **Isabel Edmonds**
> ""I told you that I will speak with them. What else would you want me to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[229]`
Mówca: **Narrator**
> "Isabel took her coat and walked downstairs. Nia and I looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Nia Morgna: ""That's not good.""*)

### Węzeł `[230]`
Mówca: **Nia Morgna**
> ""Nothing but your support, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Isabel Edmonds: ""And that I will give.""*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Isabel_Convinced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Reform_Isabel_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[232]`
Mówca: **Nia Morgna**
> ""That's great to hear that you will support us. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Isabel Edmonds: ""I see that we're all finished with our meals too. I thin..."*)

### Węzeł `[233]`
Mówca: **Isabel Edmonds**
> ""And that I will give.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Isabel_Convinced = true"*)

### Węzeł `[234]`
**[WYBÓR GRACZA: ""Don't disrespect me like this, Mrs. Edmonds.""]** — Mówca: **Player**
> ""Don't disrespect me like this, Mrs. Edmonds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Narrator: "She stood up."*)

### Węzeł `[235]`
**[WYBÓR GRACZA: ""Thank you for coming.""]** — Mówca: **Player**
> ""Thank you for coming.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "She stood up and shook my hand."*)

### Węzeł `[236]`
**[WYBÓR GRACZA: ""You can't leave before we agree on this.""]** — Mówca: **Player**
> ""You can't leave before we agree on this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Narrator: "She stood up."*)

### Węzeł `[237]`
Mówca: **Narrator**
> "She stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Isabel Edmonds: ""I don't know what you mean. I have already told you my p..."*)

### Węzeł `[238]`
Mówca: **Narrator**
> "She stood up and shook my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[239]`
Mówca: **Isabel Edmonds**
> ""I don't know what you mean. I have already told you my position. And I have another place to be, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Isabel Edmonds: ""If you'll excuse me...""*)

### Węzeł `[240]`
Mówca: **Isabel Edmonds**
> ""If you'll excuse me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[241]`
Mówca: **Nia Morgna**
> ""Thank you for the meeting, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Isabel Edmonds: ""Likewise.""*)

### Węzeł `[242]`
Mówca: **Isabel Edmonds**
> ""Likewise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "Isabel took her coat and walked downstairs. Nia and I loo..."*)

### Węzeł `[243]`
Mówca: **Isabel Edmonds**
> ""I see that we're all finished with our meals too. I think it's time to conclude this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Isabel Edmonds: ""Thank you for inviting me here, Mr. President.""*)

### Węzeł `[244]`
Mówca: **Isabel Edmonds**
> ""Thank you for inviting me here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player: ""Thank you for coming.""*)
  - -> `[246]` (*Player: ""Let's change the Constitution, Mrs. Edmonds!""*)
  - -> `[247]` (*Player: ""I'll be expecting your vote in the upcoming session.""*)

### Węzeł `[245]`
**[WYBÓR GRACZA: ""Thank you for coming.""]** — Mówca: **Player**
> ""Thank you for coming.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "She stood up and shook my hand."*)

### Węzeł `[246]`
**[WYBÓR GRACZA: ""Let's change the Constitution, Mrs. Edmonds!""]** — Mówca: **Player**
> ""Let's change the Constitution, Mrs. Edmonds!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "She stood up and shook my hand."*)

### Węzeł `[247]`
**[WYBÓR GRACZA: ""I'll be expecting your vote in the upcoming session.""]** — Mówca: **Player**
> ""I'll be expecting your vote in the upcoming session.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "She stood up and shook my hand."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "She stood up and shook my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[249]`
Mówca: **Nia Morgna**
> ""Thank you for the meeting, Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Isabel Edmonds: ""Likewise.""*)

### Węzeł `[250]`
Mówca: **Isabel Edmonds**
> ""Likewise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "Isabel took her coat and walked downstairs. Nia and I loo..."*)

### Węzeł `[251]`
Mówca: **Nia Morgna**
> ""That's not good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player: ""It's not...""*)
  - -> `[254]` (*Player: ""Oh really? Tell me about it!""*)
  - -> `[252]` (*Player: ""What do we do now?""*)

### Węzeł `[252]`
**[WYBÓR GRACZA: ""What do we do now?""]** — Mówca: **Player**
> ""What do we do now?"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Nia Morgna: ""You should maybe talk to Lucian about other options. We ..."*)

### Węzeł `[253]`
**[WYBÓR GRACZA: ""It's not...""]** — Mówca: **Player**
> ""It's not...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Nia Morgna: ""You should maybe talk to Lucian about other options. We ..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA: ""Oh really? Tell me about it!""]** — Mówca: **Player**
> ""Oh really? Tell me about it!"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "She did not reply."*)

### Węzeł `[255]`
Mówca: **Nia Morgna**
> ""You should maybe talk to Lucian about other options. We may need to reach out to Heron, but I don't think he'll be of any help without Isabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "After a few minutes of thoughtful silence, we also got up..."*)

### Węzeł `[256]`
Mówca: **Narrator**
> "She did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "After a few minutes of thoughtful silence, we also got up..."*)

### Węzeł `[257]`
Mówca: **Narrator**
> "After a few minutes of thoughtful silence, we also got up from our seats and left the restaurant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "It was not a good start. It looked like I had no choice b..."*)

### Węzeł `[258]`
Mówca: **Narrator**
> "Isabel took her coat and walked downstairs. Nia and I looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Nia Morgna: ""That's good news.""*)

### Węzeł `[259]`
Mówca: **Nia Morgna**
> ""That's good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player: ""Yes. I hope we can trust her.""*)
  - -> `[262]` (*Player: ""That's great news!""*)
  - -> `[261]` (*Player: ""We still need to reach out to more people. She won't be ..."*)

### Węzeł `[260]`
**[WYBÓR GRACZA: ""Yes. I hope we can trust her.""]** — Mówca: **Player**
> ""Yes. I hope we can trust her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Nia Morgna: ""You should maybe talk to Lucian about other options. We ..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA: ""We still need to reach out to more people. She won't be enough.""]** — Mówca: **Player**
> ""We still need to reach out to more people. She won't be enough."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Nia Morgna: ""You should maybe talk to Lucian about other options. We ..."*)

### Węzeł `[262]`
**[WYBÓR GRACZA: ""That's great news!""]** — Mówca: **Player**
> ""That's great news!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "After a few minutes of thoughtful silence, we also got up..."*)

### Węzeł `[263]`
Mówca: **Nia Morgna**
> ""You should maybe talk to Lucian about other options. We may try reaching out to Heron if you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "After a few minutes of thoughtful silence, we also got up..."*)

### Węzeł `[264]`
Mówca: **Narrator**
> "After a few minutes of thoughtful silence, we also got up from our seats and left the restaurant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "It was a good start. But I was still uncertain if Isabel ..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Nia Morgna: ""No, thank you. I'll be leaving soon.""*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Nia Morgna: ""We'll order later, thank you.""*)

### Węzeł `[268]`
Mówca: **Nia Morgna**
> ""No, thank you. I'll be leaving soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Waiter: ""Of course, madame.""*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Nia Morgna: ""No thank you. I'll be leaving soon.""*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Nia Morgna: ""No thank you. I'd rather wait for our guest to arrive.""*)

### Węzeł `[272]`
Mówca: **Nia Morgna**
> ""No thank you. I'll be leaving soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Waiter: ""Of course. I'll be around.""*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Nia Morgna: ""Mr. President...""*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[276]`
Mówca: **Nia Morgna**
> ""Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Nia Morgna: ""I know it's too late, but you are making a mistake. You'..."*)

### Węzeł `[277]`
Mówca: **Nia Morgna**
> ""I know it's too late, but you are making a mistake. You've sent our opportunity to change the constitution for the better right into the trash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Nia Morgna: ""And I can't believe that you also...""*)

### Węzeł `[278]`
Mówca: **Nia Morgna**
> ""And I can't believe that you also...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Ordered_Salad == true || BaseGa..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: ""What was on the menu?""*)
  - -> `[118]` (*Player: ""Mrs. Edmonds?""*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Nia Morgna: ""I'll have the sauté-Perlase, please.""*)

### Węzeł `[282]`
Mówca: **Nia Morgna**
> ""Oh I know that feeling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Nia Morgna: ""But now that you are here, I will take my leave. I have ..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Nia Morgna: ""I won't be ordering. I was just leaving.""*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Nia Morgna: ""Come on, Mrs. Edmonds. Let's order something.""*)

### Węzeł `[286]`
Mówca: **Narrator**
> "She shook our hands and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Suddenly, the waiter approached us."*)

### Węzeł `[287]`
Mówca: **Nia Morgna**
> ""Have a nice evening, Mr. President. Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "She shook our hands and left the room."*)

### Węzeł `[288]`
Mówca: **Narrator**
> "She shook our hands and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Isabel Edmonds: ""Well...""*)

### Węzeł `[289]`
Mówca: **Nia Morgna**
> ""Have a nice evening, Mr. President. Mrs. Edmonds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "She shook our hands and left the room."*)

### Węzeł `[290]`
Mówca: **Nia Morgna**
> ""I won't be ordering. I was just leaving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Nia Morgna: ""Have a nice evening, Mr. President. Mrs. Edmonds.""*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: ""I'll get the same as Mrs. Morgna.""*)

### Węzeł `[294]`
Mówca: **Isabel Edmonds**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Isabel Edmonds: ""...I'll have the salad, then. Thank you.""*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Nia Morgna: ""Oh I know that feeling.""*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Suddenly, the waiter approached us."*)

### Węzeł `[298]`
Mówca: **Nia Morgna**
> ""But now that you are here, I will take my leave. I have business to take care of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Nia Morgna: ""Have a nice evening, Mr. President. Mrs. Edmonds.""*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "He quickly served Isabel's food and refilled our glasses."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "He quickly served Nia and Isabel's food and refilled all ..."*)

### Węzeł `[302]`
Mówca: **Narrator**
> "He quickly served Isabel's food and refilled our glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Isabel Edmonds: ""Thank you.""*)

### Węzeł `[303]`
Mówca: **Isabel Edmonds**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Waiter: ""Bon Appétit.""*)

### Węzeł `[304]`
Mówca: **Waiter**
> ""Bon Appétit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "We wished each other a good meal as Isabel started to eat."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "We wished each other a good meal as Isabel and Nia slowly..."*)

### Węzeł `[308]`
Mówca: **Narrator**
> "We wished each other a good meal as Isabel started to eat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "The food here was insanely delicious."*)

### Węzeł `[309]`
Mówca: **Narrator**
> "The food here was insanely delicious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "Isabel took a sip from her water and turned to me."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player: ""Mrs. Edmonds, I really hope you vote for the proposal.""*)
  - -> `[192]` (*Player: ""Please, Isabel. This vote means a lot to us.""*)
  - -> `[191]` (*Player_Italic: "Stay silent."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Nia Morgna: ""You have decided then?""*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Isabel_Convinced = true"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Nia Morgna: ""Nothing but your support, Mrs. Edmonds.""*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Isabel Edmonds: ""I see that we're all finished with our meals too. I thin..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Nia Morgna: ""That's great to hear that you will support us. Thank you.""*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "Isabel took her coat and walked downstairs."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Nia Morgna: ""Thank you for the meeting, Mrs. Edmonds.""*)

### Węzeł `[322]`
Mówca: **Narrator**
> "Isabel took her coat and walked downstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "It was time to think about the other options if I wanted ..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "Isabel took her coat and walked downstairs."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Nia Morgna: ""Thank you for the meeting, Mrs. Edmonds.""*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Isabel Edmonds: ""In fact, I think it's time that I leave.""*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Nia Morgna: ""Justice Edmonds...""*)

### Węzeł `[329]`
Mówca: **Narrator**
> "It was not a good start. It looked like I had no choice but to work with the Old Guards if I wanted to pass this Constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Narrator: "I got in the presidential Kadilla and Serge started drivi..."*)

### Węzeł `[330]`
Mówca: **Narrator**
> "It was a good start. But I was still uncertain if Isabel would be enough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Narrator: "I got in the presidential Kadilla and Serge started drivi..."*)

### Węzeł `[331]`
Mówca: **Narrator**
> "It was time to think about the other options if I wanted to pass this Constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Narrator: "I got in the presidential Kadilla and Serge started drivi..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_A_ConvinceIsabel = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_A_ConvinceIsabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[333]`
Mówca: **Narrator**
> "I got in the presidential Kadilla and Serge started driving me home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_SentKesaro == true"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true)"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Narrator: "On the way, I received a call from on the brand new radio..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_HeronDecision = true"*)

### Węzeł `[337]`
Mówca: **Narrator**
> "On the way, I received a call on the brand new radio phone that was mounted in our vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "It was Kesaro Kibener. His voice was very difficult to un..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_SentKesaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_SentKesaro == true"*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Heron_SentKesaro == true)"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_SentKesaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_SentKesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "On the way, I received a call on the brand new radio phon..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Heron_SentKesaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_SentKesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true"*)

### Węzeł `[341]`
Mówca: **Narrator**
> "On the way, I received a call from on the brand new radio phone that was mounted in our vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "It was Lucian. His voice was very difficult to understand..."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "It was Kesaro Kibener. His voice was very difficult to understand through the static."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Kesaro Kibener: ""Mr. President. I hope your meeting went well.""*)

### Węzeł `[343]`
Mówca: **Narrator**
> "It was Lucian. His voice was very difficult to understand through the static."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Lucian Galade: ""Mr. President. I hope your meeting went well.""*)

### Węzeł `[344]`
Mówca: **Kesaro Kibener**
> ""Mr. President. I hope your meeting went well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Kesaro Kibener: ""I have some good news for you.""*)

### Węzeł `[345]`
Mówca: **Lucian Galade**
> ""Mr. President. I hope your meeting went well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Lucian Galade: ""I have urgent news to share. Heron has agreed to meet be..."*)

### Węzeł `[346]`
Mówca: **Kesaro Kibener**
> ""I have some good news for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Kesaro Kibener: ""Mr. Garaci had agreed to meet with you. As long as the m..."*)

### Węzeł `[347]`
Mówca: **Kesaro Kibener**
> ""Mr. Garaci had agreed to meet with you. As long as the meeting is not documented and kept hidden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Kesaro Kibener: ""I will try to arrange something. Would you be able to me..."*)

### Węzeł `[348]`
Mówca: **Kesaro Kibener**
> ""I will try to arrange something. Would you be able to meet with him outside of the capital? He said it would be safer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player: ""Arrange a meeting with him immediately.""*)
  - -> `[364]` (*Player: ""That's good news. I'll leave the arrangement up to you.""*)
  - -> `[365]` (*Player: ""That I cannot do, Kesaro.""*)

### Węzeł `[349]`
Mówca: **Lucian Galade**
> ""I have urgent news to share. Heron has agreed to meet before the Court Vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Lucian Galade: ""He wants to arrange a meeting outside of the capital. So..."*)

### Węzeł `[350]`
Mówca: **Lucian Galade**
> ""He wants to arrange a meeting outside of the capital. Somewhere more hidden and out of the public eye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player: ""Arrange a meeting with him immediately.""*)
  - -> `[352]` (*Player: ""That's good news. I'll leave the arrangement up to you.""*)
  - -> `[353]` (*Player: ""That I cannot do, Lucian.""*)

### Węzeł `[351]`
**[WYBÓR GRACZA: ""Arrange a meeting with him immediately.""]** — Mówca: **Player**
> ""Arrange a meeting with him immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Lucian Galade: ""Understood, sir.""*)

### Węzeł `[352]`
**[WYBÓR GRACZA: ""That's good news. I'll leave the arrangement up to you.""]** — Mówca: **Player**
> ""That's good news. I'll leave the arrangement up to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Lucian Galade: ""Understood, sir.""*)

### Węzeł `[353]`
**[WYBÓR GRACZA: ""That I cannot do, Lucian.""]** — Mówca: **Player**
> ""That I cannot do, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Lucian Galade: ""Sir, are you sure? He'd be very helpful.""*)

### Węzeł `[354]`
Mówca: **Lucian Galade**
> ""Sir, are you sure? He'd be very helpful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player: ""Yes. I'm sure.""*)
  - -> `[357]` (*Player: ""Okay, I'll leave it to your judgement.""*)
  - -> `[360]` (*Player: ""Don't make me repeat myself, Lucian.""*)

### Węzeł `[355]`
Mówca: **Lucian Galade**
> ""Understood, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_Decision_HeronMeeting = true"*)

### Węzeł `[356]`
Mówca: **Lucian Galade**
> ""Understood, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_Decision_HeronMeeting = true"*)

### Węzeł `[357]`
**[WYBÓR GRACZA: ""Okay, I'll leave it to your judgement.""]** — Mówca: **Player**
> ""Okay, I'll leave it to your judgement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Lucian Galade: ""Understood, sir. Then I'll try to arrange a meeting.""*)

### Węzeł `[358]`
**[WYBÓR GRACZA: ""Yes. I'm sure.""]** — Mówca: **Player**
> ""Yes. I'm sure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Lucian Galade: ""Understood, sir.""*)

### Węzeł `[359]`
Mówca: **Lucian Galade**
> ""Understood, sir. Then I'll try to arrange a meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_Decision_HeronMeeting = true"*)

### Węzeł `[360]`
**[WYBÓR GRACZA: ""Don't make me repeat myself, Lucian.""]** — Mówca: **Player**
> ""Don't make me repeat myself, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Lucian Galade: ""Understood, sir.""*)

### Węzeł `[361]`
Mówca: **Lucian Galade**
> ""Good evening. Leaving the call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "The line dropped dead."*)

### Węzeł `[362]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)

### Węzeł `[363]`
**[WYBÓR GRACZA: ""Arrange a meeting with him immediately.""]** — Mówca: **Player**
> ""Arrange a meeting with him immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Kesaro Kibener: ""Understood. Leave that up to me.""*)

### Węzeł `[364]`
**[WYBÓR GRACZA: ""That's good news. I'll leave the arrangement up to you.""]** — Mówca: **Player**
> ""That's good news. I'll leave the arrangement up to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Kesaro Kibener: ""Understood. Leave that up to me.""*)

### Węzeł `[365]`
**[WYBÓR GRACZA: ""That I cannot do, Kesaro.""]** — Mówca: **Player**
> ""That I cannot do, Kesaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Kesaro Kibener: ""What do you mean? I thought you wanted me to convince him.""*)

### Węzeł `[366]`
Mówca: **Kesaro Kibener**
> ""What do you mean? I thought you wanted me to convince him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Player: ""He's either going to come to my office or we won't have ..."*)
  - -> `[369]` (*Player: ""Yes, I did. But the meeting has to be on my terms. Is he..."*)
  - -> `[368]` (*Player: ""You're right. Okay, I'll leave the arrangement to your j..."*)

### Węzeł `[367]`
Mówca: **Kesaro Kibener**
> ""Understood. Leave that up to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_Decision_HeronMeeting = true"*)

### Węzeł `[368]`
**[WYBÓR GRACZA: ""You're right. Okay, I'll leave the arrangement to your judgement, Kesaro.""]** — Mówca: **Player**
> ""You're right. Okay, I'll leave the arrangement to your judgement, Kesaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Kesaro Kibener: ""Of course.""*)

### Węzeł `[369]`
**[WYBÓR GRACZA: ""Yes, I did. But the meeting has to be on my terms. Is he not willing to meet in Holsord?""]** — Mówca: **Player**
> ""Yes, I did. But the meeting has to be on my terms. Is he not willing to meet in Holsord?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Kesaro Kibener: ""I'm afraid that won't do for him.""*)

### Węzeł `[370]`
**[WYBÓR GRACZA: ""He's either going to come to my office or we won't have a meeting.""]** — Mówca: **Player**
> ""He's either going to come to my office or we won't have a meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Kesaro Kibener: ""I'm afraid that won't do for him.""*)

### Węzeł `[371]`
Mówca: **Kesaro Kibener**
> ""I'm afraid that won't do for him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Player: ""Fine. We'll have it his way.""*)
  - -> `[373]` (*Player: ""Then force him. I thought you were supposed to convince ..."*)

### Węzeł `[372]`
**[WYBÓR GRACZA: ""Fine. We'll have it his way.""]** — Mówca: **Player**
> ""Fine. We'll have it his way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Kesaro Kibener: ""Okay. I'll arrange it soon.""*)

### Węzeł `[373]`
**[WYBÓR GRACZA: ""Then force him. I thought you were supposed to convince him.""]** — Mówca: **Player**
> ""Then force him. I thought you were supposed to convince him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Kesaro Kibener: ""I already did. You are asking for too much.""*)

### Węzeł `[374]`
Mówca: **Kesaro Kibener**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_Decision_HeronMeeting = true"*)

### Węzeł `[375]`
Mówca: **Kesaro Kibener**
> ""I'll let you return to your duties now. Good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "The line dropped dead."*)

### Węzeł `[376]`
Mówca: **Kesaro Kibener**
> ""Okay. I'll arrange it soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_Decision_HeronMeeting = true"*)

### Węzeł `[377]`
Mówca: **Kesaro Kibener**
> ""I already did. You are asking for too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_SentKesaro = false"*)

### Węzeł `[378]`
Mówca: **Kesaro Kibener**
> ""Anyway, I'll leave you to your duties. Good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_Decision_HeronMeeting = true"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true || BaseGame.Turn05_SnO_Investigate_OldGuard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == tru..."*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == t..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true || BaseGame.Turn05_SnO_Investigate_OldGuard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true  or  Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lucian_PersuadesHeron = true"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true || BaseGame.Turn05_SnO_Investigate_OldGuard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true  or  Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lucian_FailsHeron = true"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lucian_PersuadesHeron = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Lucian_PersuadesHeron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lucian_FailsHeron = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Lucian_FailsHeron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 0)"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_OfferBribeToHeron = true"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_ConvinceIsabel = true"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_OfferBribeToHeron = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_OfferBribeToHeron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_ConvinceIsabel = true"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_Decision_HeronMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_Decision_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_ConvinceHeron = true"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_A_ConvinceHeron = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_A_ConvinceHeron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Lucian Galade: ""Good evening. Leaving the call.""*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_Decision_HeronMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_Decision_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_ConvinceHeron = true"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_A_ConvinceHeron = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_A_ConvinceHeron"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "The line dropped dead."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_SentKesaro = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Reform_Heron_SentKesaro"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Kesaro Kibener: ""Anyway, I'll leave you to your duties. Good evening.""*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_Decision_HeronMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_Decision_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_HeronMeeting = true"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Isabel_Convinced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Isabel_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Isabel Edmonds: ""I think I can get behind this proposal.""*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Isabel_Failed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Isabel_Failed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Isabel Edmonds: ""I regret to say I do not see eye to eye with you, Mr. Pr..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_IsabelOrdered_Salad = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_IsabelOrdered_Salad"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Waiter: ""Of course. And you, sir?""*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_IsabelOrdered_Salad == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_IsabelOrdered_Salad == false"*)
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_IsabelOrdered_Salad == false)"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_IsabelOrdered_Salad == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_IsabelOrdered_Salad"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Isabel Edmonds: ""I'll have the salad. Thank you.""*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_IsabelOrdered_Salad == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_IsabelOrdered_Salad"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "He quickly took a couple of notes in his tiny notebook."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_Decision_HeronMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_Decision_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_HeronMeeting = true"*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_Decision_HeronMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_Decision_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_HeronMeeting = true"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_HeronDecision = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_HeronDecision"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == tru..."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_HeronMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Kesaro Kibener: ""I'll let you return to your duties now. Good evening.""*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_HeronMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Kesaro Kibener: ""I'll let you return to your duties now. Good evening.""*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_HeronMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_HeronMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Lucian Galade: ""Good evening. Leaving the call.""*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition == true"*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Nia_Opposition == true)"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "The waiter bowed to us and quickly went downstairs."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Nia_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Nia Morgna: ""Thank you. It looks delicious.""*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Isabel Edmonds: ""I'll do my best to get the three votes but I can only sp..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)

### Węzeł `[412]`
Mówca: **Isabel Edmonds**
> ""I'll do my best to get the three votes but I can only speak for myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Isabel Edmonds: ""Your changes to Article 6 and 7 will make it really diff..."*)

### Węzeł `[413]`
Mówca: **Isabel Edmonds**
> ""Your changes to Article 6 and 7 will make it really difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Player: ""Thank you.""*)
  - -> `[416]` (*Player: ""So you are not sure if you can bring three votes?""*)
  - -> `[414]` (*Player: ""That's not good enough.""*)

### Węzeł `[414]`
**[WYBÓR GRACZA: ""That's not good enough.""]** — Mówca: **Player**
> ""That's not good enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[413]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Isabel Edmonds: ""Maybe you should have thought about this before you alte..."*)

### Węzeł `[415]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[413]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Isabel_Convinced = true"*)

### Węzeł `[416]`
**[WYBÓR GRACZA: ""So you are not sure if you can bring three votes?""]** — Mówca: **Player**
> ""So you are not sure if you can bring three votes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[413]` (Isabel Edmonds)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Isabel Edmonds: ""Maybe you should have thought about this before you alte..."*)

### Węzeł `[417]`
Mówca: **Isabel Edmonds**
> ""Maybe you should have thought about this before you altered your proposal at the last minute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Isabel Edmonds: ""I told you that I will speak with them. What else would ..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
