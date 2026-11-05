# Sordland/Turn10/DINNER WITH SERGE

- **ID konwersacji:** `215`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/215_DINNER_WITH_SERGE.md`
- **Liczba węzłów dialogowych:** 251
- **Liczba wyborów gracza:** 78

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Public_Opinion`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Rumburg_War`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn10_PartyCongress_FormNewParty`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGame.Turn10_PartyCongress_Retired`
- `BaseGame.Turn10_PartyCongress_Won`
- `BaseGameIsolated.Turn10_FinalSupper_BrokeTV`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_Exile`
- `BaseGame.Exile_LeaveNow`
- `BaseGame.Turn10_FinalSupper_Retired`
- `BaseGameIsolated.Turn10_FinalSupper_BrokeTV`
- `BaseGameIsolated.Turn10_FinalSupper_GameOff`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater`
- `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow`
- `BaseGameSupport.Journal_Turn10_FinalSupper_Retire`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[213] Sordland/Turn10/Personal_FinalSupper** (../Turn_10/213_Personal_FinalSupper.md), Węzeł `[47]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"Turn off the TV."** | `[8]` **Narrator**: "Before kickoff, the team captain..."<br>`[14]` **Narrator**: "The captain stood up and explain..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Serge Wolkner**: ""Sir?"" |
| `[4]` | **"Throw a heavy paperweight at the TV."** | `[8]` **Narrator**: "Before kickoff, the team captain..."<br>`[14]` **Narrator**: "The captain stood up and explain..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] =...` | `[65]` **Serge Wolkner**: ""Sir!"" |
| `[28]` | **"Look at the guards more closely."** | `[13]` **Narrator**: "I didn't know if it was my imagi..."<br>`[23]` **Narrator**: "The guards formed a cordon to le..." | `Variable["BaseGame.Ending_Coup"] == true` | *Brak zmian stanu* | `[22]` **Narrator**: "Once we were inside, I locked th..." |
| `[29]` | **"Don't look at them and go to your door."** | `[13]` **Narrator**: "I didn't know if it was my imagi..."<br>`[23]` **Narrator**: "The guards formed a cordon to le..." | `Variable["BaseGame.Ending_Coup"] == true` | *Brak zmian stanu* | `[22]` **Narrator**: "Once we were inside, I locked th..." |
| `[39]` | **""Serge, want a beer?""** | `[22]` **Narrator**: "Once we were inside, I locked th..."<br>`[24]` **Narrator**: "We hurried past them and went in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Serge Wolkner**: ""I'd love one, sir."" |
| `[40]` | **""Sorry about the mess in here.""** | `[22]` **Narrator**: "Once we were inside, I locked th..."<br>`[24]` **Narrator**: "We hurried past them and went in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Serge Wolkner**: ""No problem at all, sir."" |
| `[41]` | **""I'd make dinner, but I don't have any food in the fridge.""** | `[22]` **Narrator**: "Once we were inside, I locked th..."<br>`[24]` **Narrator**: "We hurried past them and went in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Serge Wolkner**: ""No problem at all, sir."" |
| `[46]` | **""Too good for me.""** | `[45]` **Serge Wolkner**: ""It must be hard for you, a lion..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Narrator**: "Serge gave me a sorrowful look." |
| `[47]` | **""I can get along just fine without her.""** | `[45]` **Serge Wolkner**: ""It must be hard for you, a lion..."<br>`[159]` **Narrator**: "Maybe this would be my year afte..."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Narrator**: "Serge gave me a sorrowful look." |
| `[48]` | **""You didn't know her like I did. I'm glad she's out of here.""** | `[45]` **Serge Wolkner**: ""It must be hard for you, a lion..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Narrator**: "Serge gave me a sorrowful look." |
| `[51]` | **""You still think I'm great? After I almost got you killed?""** | `[50]` **Serge Wolkner**: ""Don't you worry, Mr. Rayne. You..." | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[60]` **Serge Wolkner**: ""It would have been an honor to ..." |
| `[58]` | **""You still think I'm great? After everything I've done?""** | `[50]` **Serge Wolkner**: ""Don't you worry, Mr. Rayne. You..." | `Variable["BaseGame.LeakedScandals_Severity"] > 3` | *Brak zmian stanu* | `[61]` **Serge Wolkner**: ""Whatever you did, I know you ha..." |
| `[59]` | **""Serge, you're a greater man than I'll ever be.""** | `[50]` **Serge Wolkner**: ""Don't you worry, Mr. Rayne. You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Serge Wolkner**: ""You humble me, sir."" |
| `[62]` | **""Thanks. I'm sure I will too.""** | `[50]` **Serge Wolkner**: ""Don't you worry, Mr. Rayne. You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Narrator**: "We went into the living room and..." |
| `[68]` | **""That's because I own them.""** | `[67]` **Serge Wolkner**: ""See, sir? The football team thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "FC Anrica was playing marvellous..." |
| `[69]` | **""Yeah, I know.""** | `[67]` **Serge Wolkner**: ""See, sir? The football team thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "FC Anrica was playing marvellous..." |
| `[70]` | **""See, sir? The Sordish people think you're great as well.""** | `[21]` **Narrator**: "Before kickoff, the team captain..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Player**: ""Anrica does, anyway.""<br>`[72]` **Player**: ""Yeah, I know."" |
| `[71]` | **""Anrica does, anyway.""** | `[70]` **Serge Wolkner**: ""See, sir? The Sordish people th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "FC Anrica was playing marvellous..." |
| `[72]` | **""Yeah, I know.""** | `[70]` **Serge Wolkner**: ""See, sir? The Sordish people th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "FC Anrica was playing marvellous..." |
| `[73]` | **""I can't even watch a goddamn football game anymore!""** | `[65]` **Serge Wolkner**: ""Sir!""<br>`[66]` **Serge Wolkner**: ""Sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Serge Wolkner**: ""You know you can talk to me abo..." |
| `[74]` | **""Why can't they just stick to kicking the ball around? Why bring politics into it?""** | `[65]` **Serge Wolkner**: ""Sir!""<br>`[66]` **Serge Wolkner**: ""Sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Serge Wolkner**: ""You know you can talk to me abo..." |
| `[75]` | **""Sorry. I suddenly lost my interest in football.""** | `[65]` **Serge Wolkner**: ""Sir!""<br>`[66]` **Serge Wolkner**: ""Sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Serge Wolkner**: ""You know you can talk to me abo..." |
| `[79]` | **""I don't think I want another term.""** | `[77]` **Serge Wolkner**: ""Is something on your mind, sir?""<br>`[78]` **Serge Wolkner**: ""You know you can talk to me abo..." | `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[86]` **Serge Wolkner**: ""Come on, Mr. Rayne. That's no w..." |
| `[83]` | **""I can't wait till I can leave this all behind.""** | `[77]` **Serge Wolkner**: ""Is something on your mind, sir?""<br>`[78]` **Serge Wolkner**: ""You know you can talk to me abo..." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[86]` **Serge Wolkner**: ""Come on, Mr. Rayne. That's no w..." |
| `[84]` | **""I don't think I can win this election.""** | `[77]` **Serge Wolkner**: ""Is something on your mind, sir?""<br>`[78]` **Serge Wolkner**: ""You know you can talk to me abo..." | `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[86]` **Serge Wolkner**: ""Come on, Mr. Rayne. That's no w..." |
| `[85]` | **""I don't know if I can make it to the end of my term.""** | `[77]` **Serge Wolkner**: ""Is something on your mind, sir?""<br>`[78]` **Serge Wolkner**: ""You know you can talk to me abo..." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[86]` **Serge Wolkner**: ""Come on, Mr. Rayne. That's no w..." |
| `[87]` | **""I lost my family, Serge.""** | `[86]` **Serge Wolkner**: ""Come on, Mr. Rayne. That's no w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Player**: ""And I think things are about to..."<br>`[93]` **Player**: ""And I think the military is sti..."<br>*(oraz 4 innych odgałęzień)* |
| `[88]` | **""I lost my best friend, Serge.""** | `[86]` **Serge Wolkner**: ""Come on, Mr. Rayne. That's no w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Player**: ""And I think things are about to..."<br>`[93]` **Player**: ""And I think the military is sti..."<br>*(oraz 4 innych odgałęzień)* |
| `[92]` | **""I almost lost you, Serge.""** | `[86]` **Serge Wolkner**: ""Come on, Mr. Rayne. That's no w..." | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[105]` **Player**: ""And I think things are about to..."<br>`[93]` **Player**: ""And I think the military is sti..."<br>*(oraz 4 innych odgałęzień)* |
| `[93]` | **""And I think the military is still plotting against me.""** | `[87]` **Player**: ""I lost my family, Serge.""<br>`[88]` **Player**: ""I lost my best friend, Serge.""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[108]` **Serge Wolkner**: ""You listen here, sir."" |
| `[100]` | **""And I'm about to get crucified for giving half our country to Rumburg.""** | `[87]` **Player**: ""I lost my family, Serge.""<br>`[88]` **Player**: ""I lost my best friend, Serge.""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`<br>`(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false` | *Brak zmian stanu* | `[108]` **Serge Wolkner**: ""You listen here, sir."" |
| `[104]` | **""Not to mention that the Court's about to have me impeached.""** | `[87]` **Player**: ""I lost my family, Serge.""<br>`[88]` **Player**: ""I lost my best friend, Serge.""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`<br>`(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`<br>`(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false` | *Brak zmian stanu* | `[108]` **Serge Wolkner**: ""You listen here, sir."" |
| `[105]` | **""And I think things are about to get a whole lot worse.""** | `[87]` **Player**: ""I lost my family, Serge.""<br>`[88]` **Player**: ""I lost my best friend, Serge.""<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[108]` **Serge Wolkner**: ""You listen here, sir."" |
| `[106]` | **""Who or what else am I going to have to sacrifice before this is over?""** | `[87]` **Player**: ""I lost my family, Serge.""<br>`[88]` **Player**: ""I lost my best friend, Serge.""<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`<br>`(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`<br>`(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false` | *Brak zmian stanu* | `[108]` **Serge Wolkner**: ""You listen here, sir."" |
| `[107]` | **""But you're right. I should try to think positively.""** | `[87]` **Player**: ""I lost my family, Serge.""<br>`[88]` **Player**: ""I lost my best friend, Serge.""<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`<br>`(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`<br>`(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false` | *Brak zmian stanu* | `[110]` **Narrator**: "Serge smiled." |
| `[113]` | **""I can't wait for my next term.""** | `[77]` **Serge Wolkner**: ""Is something on your mind, sir?""<br>`[78]` **Serge Wolkner**: ""You know you can talk to me abo..." | `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[114]` **Narrator**: "Serge smiled." |
| `[116]` | **""He was a naive idiot.""** | `[112]` **Serge Wolkner**: ""He was strong. Brave. Full of h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Player**: ""I've got to face facts, Serge. ..."<br>`[130]` **Player**: ""But I've made it this far. I'll..."<br>*(oraz 1 innych odgałęzień)* |
| `[117]` | **""He was a liar.""** | `[112]` **Serge Wolkner**: ""He was strong. Brave. Full of h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Player**: ""I've got to face facts, Serge. ..."<br>`[130]` **Player**: ""But I've made it this far. I'll..."<br>*(oraz 1 innych odgałęzień)* |
| `[118]` | **""He was. And I still am.""** | `[112]` **Serge Wolkner**: ""He was strong. Brave. Full of h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Player**: ""But sometimes being brave means..."<br>`[120]` **Player**: ""Thanks for believing in me, Ser..."<br>*(oraz 1 innych odgałęzień)* |
| `[119]` | **""But sometimes being brave means knowing when to throw in the towel.""** | `[118]` **Player**: ""He was. And I still am."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Serge Wolkner**: ""You mean..."" |
| `[120]` | **""Thanks for believing in me, Serge. I'll stick out the rest of my term for you.""** | `[118]` **Player**: ""He was. And I still am."" | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[136]` **Narrator**: "Serge looked at me, his eyes shi..." |
| `[124]` | **""Thanks for believing in me, Serge. I'll keep going for you.""** | `[118]` **Player**: ""He was. And I still am."" | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[136]` **Narrator**: "Serge looked at me, his eyes shi..." |
| `[125]` | **""But you're right. I've made it this far. I've got to keep going.""** | `[116]` **Player**: ""He was a naive idiot.""<br>`[117]` **Player**: ""He was a liar."" | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[136]` **Narrator**: "Serge looked at me, his eyes shi..." |
| `[126]` | **""I've got to face facts, Serge. It's over.""** | `[116]` **Player**: ""He was a naive idiot.""<br>`[117]` **Player**: ""He was a liar."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Serge Wolkner**: ""You mean..."" |
| `[130]` | **""But I've made it this far. I'll stick out the rest of my term for you.""** | `[116]` **Player**: ""He was a naive idiot.""<br>`[117]` **Player**: ""He was a liar."" | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[136]` **Narrator**: "Serge looked at me, his eyes shi..." |
| `[135]` | **""I'm leaving Sordland.""** | `[131]` **Serge Wolkner**: ""You mean..."" | `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)` | *Brak zmian stanu* | `[178]` **Narrator**: "Serge's eyes widened." |
| `[137]` | **""I'm going to do everything right this time.""** | `[115]` **Serge Wolkner**: ""That sounds like the Anton Rayn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Serge Wolkner**: ""Of course you will, sir."" |
| `[138]` | **""I'm going to crush *all* my enemies.""** | `[115]` **Serge Wolkner**: ""That sounds like the Anton Rayn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Serge Wolkner**: ""Of course you will, sir."" |
| `[139]` | **""I'm going to get back at those bastards that tried to kill us.""** | `[115]` **Serge Wolkner**: ""That sounds like the Anton Rayn..." | `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true` | *Brak zmian stanu* | `[140]` **Serge Wolkner**: ""Of course you will, sir."" |
| `[141]` | **""I'm going to get my wife and kids back.""** | `[115]` **Serge Wolkner**: ""That sounds like the Anton Rayn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Serge Wolkner**: ""Of course you will, sir."" |
| `[143]` | **""Thanks. Let's finish the game.""** | `[142]` **Serge Wolkner**: ""But no matter what happens, I w..."<br>`[158]` **Serge Wolkner**: ""No matter what happens, sir, it..." | `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false` | *Brak zmian stanu* | `[151]` **Serge Wolkner**: ""Nothing would make me happier."" |
| `[148]` | **""Thanks. I've still got some beers if you want to stay for a drink or two.""** | `[142]` **Serge Wolkner**: ""But no matter what happens, I w..."<br>`[158]` **Serge Wolkner**: ""No matter what happens, sir, it..." | `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true` | *Brak zmian stanu* | `[150]` **Serge Wolkner**: ""Nothing would make me happier."" |
| `[149]` | **""Thanks. If you don't mind, Serge, I'd rather be alone tonight after all. I want t..."** | `[142]` **Serge Wolkner**: ""But no matter what happens, I w..."<br>`[158]` **Serge Wolkner**: ""No matter what happens, sir, it..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Serge Wolkner**: ""Of course, sir."" |
| `[164]` | **"Decide to continue."** | `[163]` **Narrator**: "After showing Serge to the door,..." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[172]` **Narrator**: "If only for Serge's sake." |
| `[166]` | **"Think about leaving the country."** | `[163]` **Narrator**: "After showing Serge to the door,..." | `Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)` | *Brak zmian stanu* | `[165]` **Narrator**: "I could go to Kyrute. It was the..." |
| `[170]` | **"Draft a speech announcing your retirement from politics."** | `[163]` **Narrator**: "After showing Serge to the door,..." | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[171]` **Narrator**: "I hoped Serge wouldn't be too ma..." |
| `[173]` | **"Leave now."** | `[165]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...`<br>`Variable["BaseGame.Exile_LeaveNow"] = true;` | `[176]` **Narrator**: "It was time for a fresh start. I..." |
| `[174]` | **"Leave after covering up your tracks."** | `[165]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...` | `[177]` **Narrator**: "It was time for a fresh start. I..." |
| `[182]` | **""I'm retiring from politics. Full stop.""** | `[131]` **Serge Wolkner**: ""You mean..."" | `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[184]` **Narrator**: "Serge frowned." |
| `[183]` | **""I'm retiring from politics. My mind is made up.""** | `[131]` **Serge Wolkner**: ""You mean..."" | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[184]` **Narrator**: "Serge frowned." |
| `[190]` | **""Thanks. Let's finish the game.""** | `[186]` **Serge Wolkner**: ""No matter what happens, sir, it..." | `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false` | *Brak zmian stanu* | `[194]` **Serge Wolkner**: ""Nothing would make me happier."" |
| `[191]` | **""Thanks. I've still got some beers if you want to stay for a drink or two.""** | `[186]` **Serge Wolkner**: ""No matter what happens, sir, it..." | `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true` | *Brak zmian stanu* | `[193]` **Serge Wolkner**: ""Nothing would make me happier."" |
| `[192]` | **""Thanks. If you don't mind, Serge, I'd rather be alone tonight after all. I want t..."** | `[186]` **Serge Wolkner**: ""No matter what happens, sir, it..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Serge Wolkner**: ""Of course, sir."" |
| `[205]` | **""That's it. I'm leaving for Kyrute right now.""** | `[204]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...`<br>`Variable["BaseGame.Exile_LeaveNow"] = true;`<br>*(+1 skryptów)* | `[207]` **Player**: ""And you're coming with me.""<br>`[208]` **Player**: ""I won't ask you to come with me..." |
| `[206]` | **""Yes. That's it. I will leave for Kyrute soon. But, first, I have to cover my trac..."** | `[204]` **Narrator**: "I could go to Kyrute. It was the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Leav...`<br>`Variable["BaseGame.Ending_Exile"] = true;` | `[207]` **Player**: ""And you're coming with me.""<br>`[208]` **Player**: ""I won't ask you to come with me..." |
| `[207]` | **""And you're coming with me.""** | `[206]` **Player**: ""Yes. That's it. I will leave fo..."<br>`[205]` **Player**: ""That's it. I'm leaving for Kyru..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Serge Wolkner**: ""Sir, you know how much I enjoy ..." |
| `[208]` | **""I won't ask you to come with me. I know you've got your family.""** | `[206]` **Player**: ""Yes. That's it. I will leave fo..."<br>`[205]` **Player**: ""That's it. I'm leaving for Kyru..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Narrator**: "Serge looked stunned." |
| `[212]` | **""All right, I understand. I'll go alone, then.""** | `[209]` **Serge Wolkner**: ""Sir, you know how much I enjoy ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Narrator**: "Serge looked stunned." |
| `[213]` | **""That's an order, not a request.""** | `[209]` **Serge Wolkner**: ""Sir, you know how much I enjoy ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Narrator**: "Serge looked stunned." |
| `[218]` | **""Thank you, Serge. I ought to start packing now.""** | `[211]` **Serge Wolkner**: ""No matter what happens, sir, it..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Serge Wolkner**: ""Of course, sir. Good luck."" |
| `[220]` | **""Thank you, Serge. Stay for a beer?""** | `[211]` **Serge Wolkner**: ""No matter what happens, sir, it..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Serge Wolkner**: ""Nothing would make me happier."" |
| `[221]` | **""Well, fuck you too, Serge!""** | `[217]` **Serge Wolkner**: ""Thank you for the invitation, b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Narrator**: "Serge gaped at me in outrage. He..." |
| `[222]` | **""I'm sorry. I was joking. Stay for a beer?""** | `[217]` **Serge Wolkner**: ""Thank you for the invitation, b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Narrator**: "Serge smiled uncomfortably and r..." |
| `[223]` | **""I'm sorry. I didn't mean that. Thank you for everything, Serge.""** | `[217]` **Serge Wolkner**: ""Thank you for the invitation, b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Narrator**: "Serge smiled uncomfortably and r..." |
| `[236]` | **"Start planning for the end of your presidency."** | `[163]` **Narrator**: "After showing Serge to the door,..." | `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true` | *Brak zmian stanu* | `[237]` **Narrator**: "I only had a few months left as ..." |
| `[243]` | **""I can't wait for a fresh start in politics.""** | `[77]` **Serge Wolkner**: ""Is something on your mind, sir?""<br>`[78]` **Serge Wolkner**: ""You know you can talk to me abo..." | `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[114]` **Narrator**: "Serge smiled." |
| `[244]` | **""What's the point of continuing in politics?""** | `[77]` **Serge Wolkner**: ""Is something on your mind, sir?""<br>`[78]` **Serge Wolkner**: ""You know you can talk to me abo..." | `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`<br>`(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false` | *Brak zmian stanu* | `[86]` **Serge Wolkner**: ""Come on, Mr. Rayne. That's no w..." |
| `[245]` | **"Stop contemplating and go to bed."** | `[163]` **Narrator**: "After showing Serge to the door,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |

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
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: ""I can get along just fine without her.""*)

### Węzeł `[3]`
**[WYBÓR GRACZA: "Turn off the TV."]** — Mówca: **Player_Italic**
> "Turn off the TV."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator), `[14]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Serge Wolkner: ""Sir?""*)

### Węzeł `[4]`
**[WYBÓR GRACZA: "Throw a heavy paperweight at the TV."]** — Mówca: **Player_Italic**
> "I picked up the nearest paperweight and threw it at the screen. Broken glass flew everywhere."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator), `[14]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_BrokeTV = true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == false"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing Lileas Graf for president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player_Italic: "Turn off the TV."*)
  - -> `[4]` (*Player_Italic: "Throw a heavy paperweight at the TV."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < -5"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < -5)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "The usual crowd of protesters was waiting for me outside ..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "I didn't know if it was my imagination, but there seemed ..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "The usual crowd of protesters was waiting for me outside the gates of the complex."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "The guards formed a cordon to let Serge and me through."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "I didn't know if it was my imagination, but there seemed to be more guards outside my complex than usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[14]`
Mówca: **Narrator**
> "The captain stood up and explained that the President of Sordland had a substantial stake in the team. In protest of my despicable actions, he and his teammates would not be playing tonight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player_Italic: "Turn off the TV."*)
  - -> `[4]` (*Player_Italic: "Throw a heavy paperweight at the TV."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_..."*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Publi..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] >= 3  or  Variable["BaseGame.Public_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_GameOff = true"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity >= 3 || BaseGame.Public_Opinion < 0 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] >= 3  or  Variable["BaseGame.Public_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Won == true"*)

### Węzeł `[18]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing me for president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Serge Wolkner: ""See, sir? The football team thinks you're great as well.""*)

### Węzeł `[19]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech thanking me for all I'd done during my term."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Serge Wolkner: ""See, sir? The football team thinks you're great as well.""*)

### Węzeł `[20]`
Mówca: **Narrator**
> "Right before kickoff, all of the members of FC Anrica suddenly lay down on the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "The captain stood up and explained that the President of ..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Before kickoff, the team captain gave a short speech endorsing me for president."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Serge Wolkner: ""See, sir? The Sordish people think you're great as well.""*)

### Węzeł `[22]`
Mówca: **Narrator**
> "Once we were inside, I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: ""Serge, want a beer?""*)
  - -> `[40]` (*Player: ""Sorry about the mess in here.""*)
  - -> `[41]` (*Player: ""I'd make dinner, but I don't have any food in the fridge.""*)

### Węzeł `[23]`
Mówca: **Narrator**
> "The guards formed a cordon to let Serge and me through."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "We hurried past them and went inside. I locked the front door behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: ""Serge, want a beer?""*)
  - -> `[40]` (*Player: ""Sorry about the mess in here.""*)
  - -> `[41]` (*Player: ""I'd make dinner, but I don't have any food in the fridge.""*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Italic: "Look at the guards more closely."*)
  - -> `[29]` (*Player_Italic: "Don't look at them and go to your door."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "We hurried past them and went inside. I locked the front ..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "Look at the guards more closely."]** — Mówca: **Player_Italic**
> "I regarded them with suspicion as I passed. With the military against me, could they be trusted?"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_Coup"] == true`
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator), `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Once we were inside, I locked the front door behind me."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "Don't look at them and go to your door."]** — Mówca: **Player_Italic**
> "We rushed past the guards to my door."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_Coup"] == true`
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator), `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Once we were inside, I locked the front door behind me."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true || (BaseGam..."*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true || (BaseG..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true  or  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Before kickoff, the team captain gave a short speech than..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true || (BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true  or  (Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Before kickoff, the team captain gave a short speech endo..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == false"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == false)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Before kickoff, the team captain gave a short speech endo..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Before kickoff, the team captain gave a short speech endo..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Won == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Won == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Before kickoff, the team captain gave a short speech endo..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true || (BaseGam..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Serge, want a beer?""]** — Mówca: **Player**
> ""Serge, want a beer?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator), `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Serge Wolkner: ""I'd love one, sir.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Sorry about the mess in here.""]** — Mówca: **Player**
> ""Sorry about the mess in here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator), `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Serge Wolkner: ""No problem at all, sir.""*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""I'd make dinner, but I don't have any food in the fridge.""]** — Mówca: **Player**
> ""I'd make dinner, but I don't have any food in the fridge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator), `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Serge Wolkner: ""No problem at all, sir.""*)

### Węzeł `[42]`
Mówca: **Serge Wolkner**
> ""I'd love one, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Serge glanced around the house. With Monica and the child..."*)

### Węzeł `[43]`
Mówca: **Serge Wolkner**
> ""No problem at all, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "Serge glanced around the house. With Monica and the child..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "Serge glanced around the house. With Monica and the children's belongings gone and my work documents spread everywhere, it barely resembled a home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Serge Wolkner: ""It must be hard for you, a lion living without your lion..."*)

### Węzeł `[45]`
Mówca: **Serge Wolkner**
> ""It must be hard for you, a lion living without your lioness. Mrs. Rayne was a good woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""Too good for me.""*)
  - -> `[47]` (*Player: ""I can get along just fine without her.""*)
  - -> `[48]` (*Player: ""You didn't know her like I did. I'm glad she's out of he..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""Too good for me.""]** — Mówca: **Player**
> ""Too good for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Serge gave me a sorrowful look."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""I can get along just fine without her.""]** — Mówca: **Player**
> ""I can get along just fine without her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Serge Wolkner), `[159]` (Narrator), `[172]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Serge gave me a sorrowful look."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: ""You didn't know her like I did. I'm glad she's out of here.""]** — Mówca: **Player**
> ""You didn't know her like I did. I'm glad she's out of here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Serge gave me a sorrowful look."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Serge gave me a sorrowful look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Serge Wolkner: ""Don't you worry, Mr. Rayne. You'll find another woman de..."*)

### Węzeł `[50]`
Mówca: **Serge Wolkner**
> ""Don't you worry, Mr. Rayne. You'll find another woman deserving of your greatness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[59]` (*Player: ""Serge, you're a greater man than I'll ever be.""*)
  - -> `[62]` (*Player: ""Thanks. I'm sure I will too.""*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""You still think I'm great? After I almost got you killed?""]** — Mówca: **Player**
> ""You still think I'm great? After I almost got you killed?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[50]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Serge Wolkner: ""It would have been an honor to die in the service of Pre..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: ""You still think I'm great? After I almost got you killed?""*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity > 3"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity > 3)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: ""You still think I'm great? After everything I've done?""*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[58]`
**[WYBÓR GRACZA: ""You still think I'm great? After everything I've done?""]** — Mówca: **Player**
> ""You still think I'm great? After everything that's come out about me?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Kontekst wejściowy (poprzednik):** `[50]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Serge Wolkner: ""Whatever you did, I know you had your reasons.""*)

### Węzeł `[59]`
**[WYBÓR GRACZA: ""Serge, you're a greater man than I'll ever be.""]** — Mówca: **Player**
> ""Serge, you're a greater man than I'll ever be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Serge Wolkner: ""You humble me, sir.""*)

### Węzeł `[60]`
Mówca: **Serge Wolkner**
> ""It would have been an honor to die in the service of President Anton Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "We went into the living room and settled into our chairs...."*)

### Węzeł `[61]`
Mówca: **Serge Wolkner**
> ""Whatever you did, I know you had your reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "We went into the living room and settled into our chairs...."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""Thanks. I'm sure I will too.""]** — Mówca: **Player**
> ""Thanks. I'm sure I will too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "We went into the living room and settled into our chairs...."*)

### Węzeł `[63]`
Mówca: **Serge Wolkner**
> ""You humble me, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "We went into the living room and settled into our chairs...."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "We went into the living room and settled into our chairs. The game was about to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[65]`
Mówca: **Serge Wolkner**
> ""Sir!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: ""I can't even watch a goddamn football game anymore!""*)
  - -> `[74]` (*Player: ""Why can't they just stick to kicking the ball around? Wh..."*)
  - -> `[75]` (*Player: ""Sorry. I suddenly lost my interest in football.""*)

### Węzeł `[66]`
Mówca: **Serge Wolkner**
> ""Sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: ""I can't even watch a goddamn football game anymore!""*)
  - -> `[74]` (*Player: ""Why can't they just stick to kicking the ball around? Wh..."*)
  - -> `[75]` (*Player: ""Sorry. I suddenly lost my interest in football.""*)

### Węzeł `[67]`
Mówca: **Serge Wolkner**
> ""See, sir? The football team thinks you're great as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: ""That's because I own them.""*)
  - -> `[69]` (*Player: ""Yeah, I know.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""That's because I own them.""]** — Mówca: **Player**
> ""That's because I own them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "FC Anrica was playing marvellously. But as the game went ..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Yeah, I know.""]** — Mówca: **Player**
> ""Yeah, I know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "FC Anrica was playing marvellously. But as the game went ..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: ""See, sir? The Sordish people think you're great as well.""]** — Mówca: **Serge Wolkner**
> ""See, sir? The Sordish people think you're great as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: ""Anrica does, anyway.""*)
  - -> `[72]` (*Player: ""Yeah, I know.""*)

### Węzeł `[71]`
**[WYBÓR GRACZA: ""Anrica does, anyway.""]** — Mówca: **Player**
> ""Anrica does, anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "FC Anrica was playing marvellously. But as the game went ..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""Yeah, I know.""]** — Mówca: **Player**
> ""Yeah, I know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "FC Anrica was playing marvellously. But as the game went ..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""I can't even watch a goddamn football game anymore!""]** — Mówca: **Player**
> ""I can't even watch a goddamn football game anymore!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Serge Wolkner), `[66]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Serge Wolkner: ""You know you can talk to me about anything, Mr. President.""*)

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Why can't they just stick to kicking the ball around? Why bring politics into it?""]** — Mówca: **Player**
> ""Why can't they just stick to kicking the ball around? Why bring politics into it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Serge Wolkner), `[66]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Serge Wolkner: ""You know you can talk to me about anything, Mr. President.""*)

### Węzeł `[75]`
**[WYBÓR GRACZA: ""Sorry. I suddenly lost my interest in football.""]** — Mówca: **Player**
> ""Sorry. I suddenly lost my interest in football.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Serge Wolkner), `[66]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Serge Wolkner: ""You know you can talk to me about anything, Mr. President.""*)

### Węzeł `[76]`
Mówca: **Narrator**
> "FC Anrica was playing marvellously. But as the game went on, I found my attention waning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Serge leaned over and switched off the TV. He looked at m..."*)

### Węzeł `[77]`
Mówca: **Serge Wolkner**
> ""Is something on your mind, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[78]`
Mówca: **Serge Wolkner**
> ""You know you can talk to me about anything, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""I don't think I want another term.""]** — Mówca: **Player**
> ""I don't think I want another term.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[77]` (Serge Wolkner), `[78]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Serge Wolkner: ""Come on, Mr. Rayne. That's no way to talk.""*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: ""I don't know if I can make it to the end of my term.""*)
  - -> `[83]` (*Player: ""I can't wait till I can leave this all behind.""*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: ""I can't wait till I can leave this all behind.""]** — Mówca: **Player**
> ""I can't wait till I can leave this all behind.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[77]` (Serge Wolkner), `[78]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Serge Wolkner: ""Come on, Mr. Rayne. That's no way to talk.""*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""I don't think I can win this election.""]** — Mówca: **Player**
> ""I don't think I can win this election.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[77]` (Serge Wolkner), `[78]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Serge Wolkner: ""Come on, Mr. Rayne. That's no way to talk.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""I don't know if I can make it to the end of my term.""]** — Mówca: **Player**
> ""I don't know if I can make it to the end of my term.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[77]` (Serge Wolkner), `[78]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Serge Wolkner: ""Come on, Mr. Rayne. That's no way to talk.""*)

### Węzeł `[86]`
Mówca: **Serge Wolkner**
> ""Come on, Mr. Rayne. That's no way to talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""I lost my family, Serge.""*)
  - -> `[88]` (*Player: ""I lost my best friend, Serge.""*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""I lost my family, Serge.""]** — Mówca: **Player**
> ""I lost my family, Serge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""I lost my best friend, Serge.""]** — Mówca: **Player**
> ""I lost my best friend, Serge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: ""I almost lost you, Serge.""*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[92]`
**[WYBÓR GRACZA: ""I almost lost you, Serge.""]** — Mówca: **Player**
> ""I almost lost you, Serge.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[86]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""And I think the military is still plotting against me.""]** — Mówca: **Player**
> ""And I think the military is still plotting against me.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[87]` (Player), `[88]` (Player), `[92]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Serge Wolkner: ""You listen here, sir.""*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""And I think things are about to get a whole lot worse.""*)
  - -> `[93]` (*Player: ""And I think the military is still plotting against me.""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_GivenEstordAndNarbel == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""And I think things are about to get a whole lot worse.""*)
  - -> `[100]` (*Player: ""And I'm about to get crucified for giving half our count..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)

### Węzeł `[100]`
**[WYBÓR GRACZA: ""And I'm about to get crucified for giving half our country to Rumburg.""]** — Mówca: **Player**
> ""And I'm about to get crucified for giving half our country to Rumburg.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true` AND `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[87]` (Player), `[88]` (Player), `[92]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Serge Wolkner: ""You listen here, sir.""*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_ImpeachmentTrial == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""And I think things are about to get a whole lot worse.""*)
  - -> `[104]` (*Player: ""Not to mention that the Court's about to have me impeach..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: ""Who or what else am I going to have to sacrifice before ..."*)
  - -> `[107]` (*Player: ""But you're right. I should try to think positively.""*)

### Węzeł `[104]`
**[WYBÓR GRACZA: ""Not to mention that the Court's about to have me impeached.""]** — Mówca: **Player**
> ""Not to mention that the Court's about to have me impeached.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true` AND `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false` AND `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[87]` (Player), `[88]` (Player), `[92]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Serge Wolkner: ""You listen here, sir.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""And I think things are about to get a whole lot worse.""]** — Mówca: **Player**
> ""And I think things are about to get a whole lot worse.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[87]` (Player), `[88]` (Player), `[92]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Serge Wolkner: ""You listen here, sir.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""Who or what else am I going to have to sacrifice before this is over?""]** — Mówca: **Player**
> ""Who or what else am I going to have to sacrifice before this is over?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false` AND `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false` AND `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[87]` (Player), `[88]` (Player), `[92]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Serge Wolkner: ""You listen here, sir.""*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""But you're right. I should try to think positively.""]** — Mówca: **Player**
> ""But you're right. I should try to think positively.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false` AND `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false` AND `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[87]` (Player), `[88]` (Player), `[92]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Serge smiled."*)

### Węzeł `[108]`
Mówca: **Serge Wolkner**
> ""You listen here, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Serge Wolkner: ""The Anton Rayne I met four years ago would never have fa..."*)

### Węzeł `[109]`
Mówca: **Serge Wolkner**
> ""The Anton Rayne I met four years ago would never have fallen victim to self-defeat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Serge Wolkner: ""He was strong. Brave. Full of hope.""*)

### Węzeł `[110]`
Mówca: **Narrator**
> "Serge smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Serge Wolkner: ""Exactly.""*)

### Węzeł `[111]`
Mówca: **Serge Wolkner**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Serge Wolkner: ""The Anton Rayne I met four years ago would never have fa..."*)

### Węzeł `[112]`
Mówca: **Serge Wolkner**
> ""He was strong. Brave. Full of hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: ""He was a naive idiot.""*)
  - -> `[117]` (*Player: ""He was a liar.""*)
  - -> `[118]` (*Player: ""He was. And I still am.""*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""I can't wait for my next term.""]** — Mówca: **Player**
> ""I can't wait for my next term.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[77]` (Serge Wolkner), `[78]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Serge smiled."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "Serge smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Serge Wolkner: ""That sounds like the Anton Rayne I know.""*)

### Węzeł `[115]`
Mówca: **Serge Wolkner**
> ""That sounds like the Anton Rayne I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: ""I'm going to do everything right this time.""*)
  - -> `[138]` (*Player: ""I'm going to crush *all* my enemies.""*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[141]` (*Player: ""I'm going to get my wife and kids back.""*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""He was a naive idiot.""]** — Mówca: **Player**
> ""He was a naive idiot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[126]` (*Player: ""I've got to face facts, Serge. It's over.""*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""He was a liar.""]** — Mówca: **Player**
> ""He was a liar.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[126]` (*Player: ""I've got to face facts, Serge. It's over.""*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""He was. And I still am.""]** — Mówca: **Player**
> ""He was. And I still am.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[119]` (*Player: ""But sometimes being brave means knowing when to throw in..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""But sometimes being brave means knowing when to throw in the towel.""]** — Mówca: **Player**
> ""But sometimes being brave means knowing when to throw in the towel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Serge Wolkner: ""You mean...""*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""Thanks for believing in me, Serge. I'll stick out the rest of my term for you.""]** — Mówca: **Player**
> ""Thanks for believing in me, Serge. I'll stick out the rest of my term for you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[118]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "Serge looked at me, his eyes shining."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: ""Thanks for believing in me, Serge. I'll stick out the re..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: ""Thanks for believing in me, Serge. I'll keep going for y..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Thanks for believing in me, Serge. I'll keep going for you.""]** — Mówca: **Player**
> ""Thanks for believing in me, Serge. I'll keep going for you.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[118]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "Serge looked at me, his eyes shining."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""But you're right. I've made it this far. I've got to keep going.""]** — Mówca: **Player**
> ""But you're right. I've made it this far. I've got to keep going.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[116]` (Player), `[117]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "Serge looked at me, his eyes shining."*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""I've got to face facts, Serge. It's over.""]** — Mówca: **Player**
> ""I've got to face facts, Serge. It's over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Player), `[117]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Serge Wolkner: ""You mean...""*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: ""But I've made it this far. I'll stick out the rest of my..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: ""But you're right. I've made it this far. I've got to kee..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""But I've made it this far. I'll stick out the rest of my term for you.""]** — Mówca: **Player**
> ""But I've made it this far. I'll stick out the rest of my term for you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[116]` (Player), `[117]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "Serge looked at me, his eyes shining."*)

### Węzeł `[131]`
Mówca: **Serge Wolkner**
> ""You mean...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ==..."*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup ..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player: ""I'm leaving Sordland.""*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == false && (BaseGame.Ending_Coup == true || BaseGame.Ending_ImpeachmentTrial == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[135]`
**[WYBÓR GRACZA: ""I'm leaving Sordland.""]** — Mówca: **Player**
> ""I'm leaving Sordland.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_War"] == false  and  (Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Ending_ImpeachmentTrial"] == true)`
- **Kontekst wejściowy (poprzednik):** `[131]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "Serge's eyes widened."*)

### Węzeł `[136]`
Mówca: **Narrator**
> "Serge looked at me, his eyes shining."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Serge Wolkner: ""That sounds like the Anton I know.""*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""I'm going to do everything right this time.""]** — Mówca: **Player**
> ""I'm going to do everything right this time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Serge Wolkner: ""Of course you will, sir.""*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""I'm going to crush *all* my enemies.""]** — Mówca: **Player**
> ""I'm going to crush *all* my enemies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Serge Wolkner: ""Of course you will, sir.""*)

### Węzeł `[139]`
**[WYBÓR GRACZA: ""I'm going to get back at those bastards that tried to kill us.""]** — Mówca: **Player**
> ""I'm going to get back at those bastards that tried to kill us.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Kontekst wejściowy (poprzednik):** `[115]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Serge Wolkner: ""Of course you will, sir.""*)

### Węzeł `[140]`
Mówca: **Serge Wolkner**
> ""Of course you will, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Serge Wolkner: ""But no matter what happens, I want you to know it's been..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA: ""I'm going to get my wife and kids back.""]** — Mówca: **Player**
> ""I'm going to get my wife and kids back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Serge Wolkner: ""Of course you will, sir.""*)

### Węzeł `[142]`
Mówca: **Serge Wolkner**
> ""But no matter what happens, I want you to know it's been a pleasure being your driver.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true"*)
  - -> `[149]` (*Player: ""Thanks. If you don't mind, Serge, I'd rather be alone to..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Thanks. Let's finish the game.""]** — Mówca: **Player**
> ""Thanks. Let's finish the game.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[142]` (Serge Wolkner), `[158]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Serge Wolkner: ""Nothing would make me happier.""*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_FinalSupper_BrokeTV = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Serge Wolkner: ""Sir!""*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true )"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""Thanks. I've still got some beers if you want to stay fo..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: ""Thanks. Let's finish the game.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Thanks. I've still got some beers if you want to stay for a drink or two.""]** — Mówca: **Player**
> ""Thanks. And sorry I broke the TV. I've still got some beers if you want to stay for a drink or two.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true`
- **Kontekst wejściowy (poprzednik):** `[142]` (Serge Wolkner), `[158]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Serge Wolkner: ""Nothing would make me happier.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""Thanks. If you don't mind, Serge, I'd rather be alone tonight after all. I want to think about my next steps.""]** — Mówca: **Player**
> ""Thanks. If you don't mind, Serge, I'd rather be alone tonight after all. I want to think about my next steps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Serge Wolkner), `[158]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Serge Wolkner: ""Of course, sir.""*)

### Węzeł `[150]`
Mówca: **Serge Wolkner**
> ""Nothing would make me happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "I cracked open two beers and we raised the bottles in a b..."*)

### Węzeł `[151]`
Mówca: **Serge Wolkner**
> ""Nothing would make me happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "I turned the TV back on. FC Anrica had already scored a g..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "I turned the TV back on. FC Anrica had already scored a goal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "Maybe this would be my year after all."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "Serge leaned over and switched off the TV. He looked at me with probing eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Serge Wolkner: ""Is something on your mind, sir?""*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == ..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player: ""I'm going to get back at those bastards that tried to ki..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
Mówca: **Serge Wolkner**
> ""That sounds like the Anton I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Serge Wolkner: ""No matter what happens, sir, it's been a pleasure being ..."*)

### Węzeł `[158]`
Mówca: **Serge Wolkner**
> ""No matter what happens, sir, it's been a pleasure being your driver.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true"*)
  - -> `[149]` (*Player: ""Thanks. If you don't mind, Serge, I'd rather be alone to..."*)

### Węzeł `[159]`
Mówca: **Narrator**
> "Maybe this would be my year after all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[160]`
Mówca: **Narrator**
> "I cracked open two beers and we raised the bottles in a brief toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "Maybe this would be my year after all."*)

### Węzeł `[161]`
Mówca: **Serge Wolkner**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Serge Wolkner: ""Thank you for the invitation.""*)

### Węzeł `[162]`
Mówca: **Serge Wolkner**
> ""Thank you for the invitation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "After showing Serge to the door, I sat and thought for a ..."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "After showing Serge to the door, I sat and thought for a while longer. His confidence in me was touching. But was it enough?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false &&(BaseGame.Ending_Impeachm..."*)
  - -> `[245]` (*Player_Italic: "Stop contemplating and go to bed."*)

### Węzeł `[164]`
**[WYBÓR GRACZA: "Decide to continue."]** — Mówca: **Player_Italic**
> "I gritted my teeth. I had come this far. I would finish what I had started."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "If only for Serge's sake."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "I could go to Kyrute. It was the one completely neutral country I knew of, and a little house in the mountains wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player_Italic: "Leave now."*)
  - -> `[174]` (*Player_Italic: "Leave after covering up your tracks."*)

### Węzeł `[166]`
**[WYBÓR GRACZA: "Think about leaving the country."]** — Mówca: **Player_Italic**
> "I went up to my office and spun the globe on my desk."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)`
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "I could go to Kyrute. It was the one completely neutral c..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == false &&(BaseGame.Ending_Impeachm..."*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == false &&(BaseGame.Ending_Impeac..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player_Italic: "Think about leaving the country."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == false &&(BaseGame.Ending_ImpeachmentTrial == true || BaseGame.Ending_Coup == true || BaseGame.Rumburg_GivenEstordAndNarbel == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == false  and (Variable["BaseGame.Ending_ImpeachmentTrial"] == true  or  Variable["BaseGame.Ending_Coup"] == true  or  Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[170]`
**[WYBÓR GRACZA: "Draft a speech announcing your retirement from politics."]** — Mówca: **Player_Italic**
> "I went up to my office and began drafting a speech announcing my retirement from politics."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "I hoped Serge wouldn't be too mad at me for letting him d..."*)

### Węzeł `[171]`
Mówca: **Narrator**
> "I hoped Serge wouldn't be too mad at me for letting him down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[172]`
Mówca: **Narrator**
> "If only for Serge's sake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[173]`
**[WYBÓR GRACZA: "Leave now."]** — Mówca: **Player_Italic**
> "I started packing my suitcase. I wasn't going to stay in Sordland a second longer."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[174]`
**[WYBÓR GRACZA: "Leave after covering up your tracks."]** — Mówca: **Player_Italic**
> "I decided to cover up my tracks. There were some documents that needed to be incinerated."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Exile = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[176]`
Mówca: **Narrator**
> "It was time for a fresh start. I hoped Serge would understand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[177]`
Mówca: **Narrator**
> "It was time for a fresh start. I hoped Serge would understand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[178]`
Mówca: **Narrator**
> "Serge's eyes widened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Serge Wolkner: ""What? Sir, you can't just...""*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player: ""I'm retiring from politics. My mind is made up.""*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: ""I'm retiring from politics. Full stop.""*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""I'm retiring from politics. Full stop.""]** — Mówca: **Player**
> ""I'm retiring from politics. Full stop.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[131]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Serge frowned."*)

### Węzeł `[183]`
**[WYBÓR GRACZA: ""I'm retiring from politics. My mind is made up.""]** — Mówca: **Player**
> ""I'm retiring from politics. My mind is made up.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[131]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Serge frowned."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "Serge frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Serge Wolkner: ""All right, sir. I understand.""*)

### Węzeł `[185]`
Mówca: **Serge Wolkner**
> ""All right, sir. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Serge Wolkner: ""No matter what happens, sir, it's been a pleasure being ..."*)

### Węzeł `[186]`
Mówca: **Serge Wolkner**
> ""No matter what happens, sir, it's been a pleasure being your driver.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true"*)
  - -> `[192]` (*Player: ""Thanks. If you don't mind, Serge, I'd rather be alone to..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Player: ""Thanks. I've still got some beers if you want to stay fo..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn10_FinalSupper_BrokeTV == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: ""Thanks. Let's finish the game.""*)

### Węzeł `[190]`
**[WYBÓR GRACZA: ""Thanks. Let's finish the game.""]** — Mówca: **Player**
> ""Thanks. Let's finish the game.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[186]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Serge Wolkner: ""Nothing would make me happier.""*)

### Węzeł `[191]`
**[WYBÓR GRACZA: ""Thanks. I've still got some beers if you want to stay for a drink or two.""]** — Mówca: **Player**
> ""Thanks. I've still got some beers if you want to stay for a drink or two.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn10_FinalSupper_BrokeTV"] == true`
- **Kontekst wejściowy (poprzednik):** `[186]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Serge Wolkner: ""Nothing would make me happier.""*)

### Węzeł `[192]`
**[WYBÓR GRACZA: ""Thanks. If you don't mind, Serge, I'd rather be alone tonight after all. I want to think about my next steps.""]** — Mówca: **Player**
> ""Thanks. If you don't mind, Serge, I'd rather be alone tonight after all. I want to think about my next steps.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Serge Wolkner: ""Of course, sir.""*)

### Węzeł `[193]`
Mówca: **Serge Wolkner**
> ""Nothing would make me happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "I cracked open two beers and we raised the bottles in a b..."*)

### Węzeł `[194]`
Mówca: **Serge Wolkner**
> ""Nothing would make me happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "I turned the TV back on. FC Anrica had already scored a g..."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "I turned the TV back on. FC Anrica had already scored a goal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "My presidency was coming to an end. But for this evening,..."*)

### Węzeł `[196]`
Mówca: **Serge Wolkner**
> ""Thank you for the invitation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "I walked Serge to the door, then went upstairs. I still h..."*)

### Węzeł `[197]`
Mówca: **Serge Wolkner**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Serge Wolkner: ""Thank you for the invitation.""*)

### Węzeł `[198]`
Mówca: **Narrator**
> "I cracked open two beers and we raised the bottles in a brief toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "My presidency was coming to an end. But for this evening,..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_FinalSupper_GameOff = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn10_FinalSupper_GameOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "Right before kickoff, all of the members of FC Anrica sud..."*)

### Węzeł `[200]`
Mówca: **Narrator**
> "My presidency was coming to an end. But for this evening, at least, it didn't matter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[201]`
Mówca: **Narrator**
> "I walked Serge to the door, then went upstairs. I still had some work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[202]`
Mówca: **Serge Wolkner**
> ""What? Sir, you can't just...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "Now that I'd said it, it seemed like the most obvious sol..."*)

### Węzeł `[203]`
Mówca: **Narrator**
> "Now that I'd said it, it seemed like the most obvious solution in the world. The gears in my head started spinning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "I could go to Kyrute. It was the one completely neutral c..."*)

### Węzeł `[204]`
Mówca: **Narrator**
> "I could go to Kyrute. It was the one completely neutral country I could easily reach, and a little house in the mountains wouldn't cost me much."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player: ""That's it. I'm leaving for Kyrute right now.""*)
  - -> `[206]` (*Player: ""Yes. That's it. I will leave for Kyrute soon. But, first..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA: ""That's it. I'm leaving for Kyrute right now.""]** — Mówca: **Player**
> ""That's it. I'm leaving for Kyrute right now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true"*)

### Węzeł `[206]`
**[WYBÓR GRACZA: ""Yes. That's it. I will leave for Kyrute soon. But, first, I have to cover my tracks. Just in case.""]** — Mówca: **Player**
> ""Yes. That's it. I will leave for Kyrute soon. But, first, I have to cover my tracks. Just in case.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true"*)

### Węzeł `[207]`
**[WYBÓR GRACZA: ""And you're coming with me.""]** — Mówca: **Player**
> ""And you're coming with me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Player), `[205]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Serge Wolkner: ""Sir, you know how much I enjoy being your driver, but I ..."*)

### Węzeł `[208]`
**[WYBÓR GRACZA: ""I won't ask you to come with me. I know you've got your family.""]** — Mówca: **Player**
> ""I won't ask you to come with me. I know you've got your family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[206]` (Player), `[205]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Serge looked stunned."*)

### Węzeł `[209]`
Mówca: **Serge Wolkner**
> ""Sir, you know how much I enjoy being your driver, but I can't leave my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player: ""That's an order, not a request.""*)
  - -> `[212]` (*Player: ""All right, I understand. I'll go alone, then.""*)

### Węzeł `[210]`
Mówca: **Narrator**
> "Serge looked stunned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Serge Wolkner: ""I-- I suppose it's a fittingly bold move for a bold Pres..."*)

### Węzeł `[211]`
Mówca: **Serge Wolkner**
> ""No matter what happens, sir, it's been a pleasure to serve you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player: ""Thank you, Serge. I ought to start packing now.""*)
  - -> `[220]` (*Player: ""Thank you, Serge. Stay for a beer?""*)

### Węzeł `[212]`
**[WYBÓR GRACZA: ""All right, I understand. I'll go alone, then.""]** — Mówca: **Player**
> ""All right, I understand. I'll go alone, then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Serge looked stunned."*)

### Węzeł `[213]`
**[WYBÓR GRACZA: ""That's an order, not a request.""]** — Mówca: **Player**
> ""That's an order, not a request.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Serge looked stunned."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "Serge looked stunned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Serge Wolkner: ""President Rayne, I've been happy to serve you, but this ..."*)

### Węzeł `[215]`
Mówca: **Serge Wolkner**
> ""President Rayne, I've been happy to serve you, but this is too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "He backed towards the door."*)

### Węzeł `[216]`
Mówca: **Narrator**
> "He backed towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Serge Wolkner: ""Thank you for the invitation, but I really must be leavi..."*)

### Węzeł `[217]`
Mówca: **Serge Wolkner**
> ""Thank you for the invitation, but I really must be leaving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player: ""Well, fuck you too, Serge!""*)
  - -> `[222]` (*Player: ""I'm sorry. I was joking. Stay for a beer?""*)
  - -> `[223]` (*Player: ""I'm sorry. I didn't mean that. Thank you for everything,..."*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Serge. I ought to start packing now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Serge Wolkner: ""Of course, sir. Good luck.""*)

### Węzeł `[219]`
Mówca: **Serge Wolkner**
> ""I-- I suppose it's a fittingly bold move for a bold President such as yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Serge Wolkner: ""No matter what happens, sir, it's been a pleasure to ser..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Serge. Stay for a beer?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Serge Wolkner: ""Nothing would make me happier.""*)

### Węzeł `[221]`
**[WYBÓR GRACZA: ""Well, fuck you too, Serge!""]** — Mówca: **Player**
> ""Well, fuck you too, Serge!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Narrator: "Serge gaped at me in outrage. He ran out the door to his ..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA: ""I'm sorry. I was joking. Stay for a beer?""]** — Mówca: **Player**
> ""I'm sorry. I was joking. Stay for a beer?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "Serge smiled uncomfortably and ran out the door to his car."*)

### Węzeł `[223]`
**[WYBÓR GRACZA: ""I'm sorry. I didn't mean that. Thank you for everything, Serge.""]** — Mówca: **Player**
> ""I'm sorry. I didn't mean that. Thank you for everything, Serge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "Serge smiled uncomfortably and ran out the door to his car."*)

### Węzeł `[224]`
Mówca: **Narrator**
> "Serge smiled uncomfortably and ran out the door to his car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "I watched him go, then opened a beer for myself and got b..."*)

### Węzeł `[225]`
Mówca: **Narrator**
> "Serge gaped at me in outrage. He ran out the door to his car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "I watched him go, then opened a beer for myself and got b..."*)

### Węzeł `[226]`
Mówca: **Narrator**
> "I watched him go, then opened a beer for myself and got busy packing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[227]`
Mówca: **Serge Wolkner**
> ""Nothing would make me happier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "I cracked open two beers and we raised the bottles in a b..."*)

### Węzeł `[228]`
Mówca: **Narrator**
> "I cracked open two beers and we raised the bottles in a brief toast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "Once we had drained our glasses, I showed him to the door..."*)

### Węzeł `[229]`
Mówca: **Serge Wolkner**
> ""Of course, sir. Good luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "I watched him go, then opened a beer for myself and got b..."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "Once we had drained our glasses, I showed him to the door. Then, I got busy packing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Exile = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Player: ""And you're coming with me.""*)
  - -> `[208]` (*Player: ""I won't ask you to come with me. I know you've got your ..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_FinalSupper_Retired = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn10_FinalSupper_Retired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Retired == true"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Retired == true)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Retired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Player_Italic: "Start planning for the end of your presidency."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Retired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Italic: "Draft a speech announcing your retirement from politics."*)
  - -> `[164]` (*Player_Italic: "Decide to continue."*)

### Węzeł `[236]`
**[WYBÓR GRACZA: "Start planning for the end of your presidency."]** — Mówca: **Player_Italic**
> "I went upstairs to my office and started working again."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Retired"] == true`
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Narrator: "I only had a few months left as President of Sordland. I ..."*)

### Węzeł `[237]`
Mówca: **Narrator**
> "I only had a few months left as President of Sordland. I had to make them count."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_FinalSupper_Retired = true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Exile_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "It was time for a fresh start. I hoped Serge would unders..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Tu..."*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame...."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: ""What's the point of continuing in politics?""*)
  - -> `[243]` (*Player: ""I can't wait for a fresh start in politics.""*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true && BaseGame.Turn10_PartyCongress_FormNewParty == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""I don't think I want another term.""*)
  - -> `[84]` (*Player: ""I don't think I can win this election.""*)
  - -> `[113]` (*Player: ""I can't wait for my next term.""*)

### Węzeł `[243]`
**[WYBÓR GRACZA: ""I can't wait for a fresh start in politics.""]** — Mówca: **Player**
> ""I can't wait for a fresh start in politics.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[77]` (Serge Wolkner), `[78]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Serge smiled."*)

### Węzeł `[244]`
**[WYBÓR GRACZA: ""What's the point of continuing in politics?""]** — Mówca: **Player**
> ""What's the point of continuing in politics?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true  and  Variable["BaseGame.Turn10_PartyCongress_FormNewParty"] == false` AND `(Variable["BaseGame.Turn10_PartyCongress_Retired"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[77]` (Serge Wolkner), `[78]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Serge Wolkner: ""Come on, Mr. Rayne. That's no way to talk.""*)

### Węzeł `[245]`
**[WYBÓR GRACZA: "Stop contemplating and go to bed."]** — Mówca: **Player_Italic**
> "I willed myself to stop thinking so hard. I was tired. That was all."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Exile = true"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveLater"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "It was time for a fresh start. I hoped Serge would unders..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_LeaveNow"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow = true"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_FinalSupper_Retire = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_FinalSupper_Retire"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
